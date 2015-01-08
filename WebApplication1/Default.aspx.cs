using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Runtime.InteropServices;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        [DllImport("Iphlpapi.dll")]
        private static extern int SendARP(Int32 dest, Int32 host, ref Int64 mac, ref Int32 length);
        [DllImport("Ws2_32.dll")]
        private static extern Int32 inet_addr(string ip);
        ServiceReference1.FileTransportServiceClient fsc = new WebApplication1.ServiceReference1.FileTransportServiceClient();
        ServiceReference2.DataServiceClient ws = new WebApplication1.ServiceReference2.DataServiceClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

               try
                {
                    string userip = Request.UserHostAddress;
                    string strClientIP = Request.UserHostAddress.ToString().Trim();
                    Int32 ldest = inet_addr(strClientIP); //目的地的ip 
                    Int32 lhost = inet_addr("");   //本地服务器的ip 
                    Int64 macinfo = new Int64();
                    Int32 len = 6;
                    int res = SendARP(ldest, 0, ref macinfo, ref len);
                    string mac_src = macinfo.ToString("X");
                    while (mac_src.Length < 12)
                    {
                        mac_src = mac_src.Insert(0, "0");
                    }
                    string mac_dest = "";
                    for (int i = 0; i < 11; i++)
                    {
                        if (0 == (i % 2))
                        {
                            if (i == 10)
                            {
                                mac_dest = mac_dest.Insert(0, mac_src.Substring(i, 2));
                            }
                            else
                            {
                                mac_dest = "-" + mac_dest.Insert(0, mac_src.Substring(i, 2));
                            }
                        }
                    }
                    ViewState["Mac"] = mac_dest;
                }
                catch (Exception err)
                {
                    Response.Write(err.Message);
                }
                Button1.Visible = true;
                Label2.Text = string.Empty;
                Label3.Text = string.Empty;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

            GridView2.DataSource = null;
            GridView2.DataBind();

            GridView1.DataSource = null;
            GridView1.DataBind();

          
            int card = 0;
            try
            {
                card = Convert.ToInt32(TextBox1.Text.Trim());//ID卡号是数字型的。
            }
            catch
            {
                Label1.Text = "卡号格式不正确";
                TextBox1.Text = string.Empty;
                return;
            }

            string aa = string.Empty;
            if (card < 1000)
            {
                Label1.Text = string.Empty;
                Label2.Text = string.Empty;
                string empname = ws.CheckUser(card.ToString(), string.Empty);
                if (empname.IndexOf(',') == -1)
                {
                    Label3.Text = string.Empty;
                    return;
                }
                string[] ss = empname.Split(',');
                BaseClass.UserID = Convert.ToInt32(ss[0]);
                BaseClass.UserName = ss[1];

                Label3.Text = BaseClass.UserName;// fsc.PadCarID("1" + ViewState["Mac"].ToString() + "+" + TextBox1.Text);//PadCarID方法，查询这找卡的情况，是员工卡或者是货物卡，将其情况返回并显示，如果该机此前30秒内有刷过货物卡且现在的是员工卡，会将货物卡的工序标记为该员工完成，这些是在服务器端处理的，业务流程部分挺多。            }
                Label1.Text = ws.EmpAddWork(BaseClass.TicketInfoID, BaseClass.UserID.ToString(), BaseClass.dtNow);
                GridView1.Visible = false;
                GridView2.Visible = true;
                DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetSumAmount", new object[] { BaseClass.UserID, 0 })).Tables[0];
                GridView2.DataSource = dt;
                GridView2.DataBind();
                Button1.Visible = true;
                Button1.Text = "当天";
            }
            else
            {
                aa = ws.GetBoxInfo(card.ToString());
                DataTable dtBox = ToDataTable(aa);
                if (dtBox.Rows.Count > 0)
                {
                    string boxInfo = dtBox.Rows[0][0].ToString();
                    string workingName = dtBox.Rows[0][1].ToString();
                    BaseClass.TicketInfoID = dtBox.Rows[0][2].ToString();
                    BaseClass.IsCanMove = Convert.ToBoolean(dtBox.Rows[0][3]);
                    BaseClass.dtNow = dtBox.Rows[0][4].ToString();
                    Label1.Text = boxInfo + workingName;
                    string TicketID = TextBox1.Text.Trim();

                    int _ticketID = 0;
                    int _group = 0;
                    try
                    {
                        _ticketID = Convert.ToInt32(TicketID.Substring(0, TicketID.Length - 1));
                        _group = Convert.ToInt32(TicketID.Substring(TicketID.Length - 1));
                    }
                    catch
                    {
                        return;
                    }
                    GridView1.Visible = true;
                    GridView2.Visible = false;
                    DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.WorkTicketIDCard", "GetWorkOverListByTicketID", new object[] { _ticketID })).Tables[0];
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Button1.Visible = false;
                }
            }
            //TextBox1.Text = string.Empty;
            //DataTable dtEMP = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetList", new object[] { "(IDCardID=" + card + ")" })).Tables[0];//判断是否是员工卡
            //if (dtEMP.Rows.Count > 0)//是员工卡，显示该员工当天所做的事情
            //{
            //    GridView1.Visible = false;
            //    GridView2.Visible = true;
            //    ViewState["EmpID"] = dtEMP.Rows[0]["ID"];
            //    DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetSumAmount", new object[] { Convert.ToInt32(dtEMP.Rows[0]["ID"]), 0 })).Tables[0];
            //    GridView2.DataSource = dt;
            //    GridView2.DataBind();
            //    Button1.Visible = true;
            //    Button1.Text = "当天";
            //}
            //else//不是员工卡，则可能是货物卡，返回这一份货物的工序完成情况
            //{
            //    GridView1.Visible = true;
            //    GridView2.Visible = false;
            //    DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.WorkTicketIDCard", "GetWorkOverList", new object[] { card })).Tables[0];
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            //    Button1.Visible = false;
            //}
            TextBox1.Focus();
        }
        protected  DataTable ToDataTable(string strDS)
        {

            DataTable dt = new DataTable();
            dt.TableName = "dt";
            try
            {
                string[] ss = strDS.Split('й');
                string[] ssColumns = ss[0].Split('ж');
                string[] sc;
                for (int i = 0; i < ssColumns.Length; i++)
                {
                    sc = ssColumns[i].Split('ю');
                    if (sc[0] != string.Empty)
                        dt.Columns.Add(sc[0], System.Type.GetType(sc[1]));
                }
                if (ss.Length > 1)
                {
                    for (int i = 1; i < ss.Length; i++)
                    {
                        DataRow dr = dt.NewRow();
                        sc = ss[i].Split('ж');
                        if (sc[0] != string.Empty)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                try
                                {
                                    dr[j] = sc[j];
                                }
                                catch (Exception ex)
                                {
                                    dr[j] = DBNull.Value;
                                }
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

            }
            return dt;
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = GridView1.SelectedRow.Cells[0].Text;
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (e.CommandName == "Select")
            //{
            //    int a = GridView1.Columns.Count;
            //    Label1.Text = e.CommandArgument.ToString();
            //    Control c = (Control)e.CommandSource;
            //    GridViewRow g = (GridViewRow)c.NamingContainer;
            //    string aa = fsc.PadCarID("2" + ViewState["Mac"].ToString() + "+" + g.Cells[1].Text);//当单独刷货物卡后，可以将某一条记录的ID值传回服务器端，标记这台机现在选择了这一张卡的这一个工序，当再接着刷员工卡，就会将现在选择的工序记录给该员工，如果在安卓上面，这个  选择   字段应该是不需要的，那个ID字段需要隐藏起来。
            //    Label1.Text = aa;
            //}

            if (BaseClass.IsCanMove)
            {
                if (e.CommandName == "Select")
                {
                    int a = GridView1.Columns.Count;
                    Label1.Text = e.CommandArgument.ToString();
                    Control c = (Control)e.CommandSource;
                    GridViewRow g = (GridViewRow)c.NamingContainer;

                    BaseClass.TicketInfoID = g.Cells[1].Text;
                    Label1.Text = g.Cells[2].Text;
                }
            }
            else
            {
                Label2.Text = "不能调整工序";
            }
            TextBox1.Focus();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Button1.Text == "当月")//刷员工卡号，切换显示该员工当天或当月的产量明细。
            {
                DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetSumAmount", new object[] { BaseClass.UserID, 0 })).Tables[0];
                GridView2.DataSource = dt;
                GridView2.DataBind();
                Button1.Text = "当天";
                DataTable dtNum = ToDataTable(ws.GetJson("Hownet.BLL.WorkTicketInfo", "GetEmployeeNum", new object[] { BaseClass.UserID, 1 }));
                if (dtNum.Rows.Count > 0)
                {
                    string lblzj = "当天产量：" + dtNum.Rows[0]["Amount"].ToString() + "   工资：";
                    lblzj += string.Format("{0:F1}", Convert.ToDouble(dtNum.Rows[0]["Money"]));
                    Label1.Text = lblzj;
                }
            }
            else
            {
                DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetSumAmount", new object[] { BaseClass.UserID, 1 })).Tables[0];
                GridView2.DataSource = dt;
                GridView2.DataBind();
                Button1.Text = "当月";
                DataTable dtNum = ToDataTable(ws.GetJson("Hownet.BLL.WorkTicketInfo", "GetEmployeeNum", new object[] { BaseClass.UserID, 2 }));
                if (dtNum.Rows.Count > 0)
                {
                    string lblzj = "当月产量：" + dtNum.Rows[0]["Amount"].ToString() + "   工资：";
                    lblzj += string.Format("{0:F1}", Convert.ToDouble(dtNum.Rows[0]["Money"]));
                    Label1.Text = lblzj;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView2.DataSource = null;
            GridView2.DataBind();

            GridView1.DataSource = null;
            GridView1.DataBind();


            int card = 0;
            try
            {
                card = Convert.ToInt32(TextBox1.Text.Trim());//ID卡号是数字型的。
            }
            catch
            {
                Label1.Text = "卡号格式不正确";
                TextBox1.Text = string.Empty;
                return;
            }

            string aa = string.Empty;
            if (card < 1000)
            {
                Label1.Text = string.Empty;
                Label2.Text = string.Empty;
                string empname = ws.CheckUser(card.ToString(), string.Empty);
                if (empname.IndexOf(',') == -1)
                {
                    Label3.Text = string.Empty;
                    return;
                }
                string[] ss = empname.Split(',');
                BaseClass.UserID = Convert.ToInt32(ss[0]);
                BaseClass.UserName = ss[1];

                Label3.Text = BaseClass.UserName;// fsc.PadCarID("1" + ViewState["Mac"].ToString() + "+" + TextBox1.Text);//PadCarID方法，查询这找卡的情况，是员工卡或者是货物卡，将其情况返回并显示，如果该机此前30秒内有刷过货物卡且现在的是员工卡，会将货物卡的工序标记为该员工完成，这些是在服务器端处理的，业务流程部分挺多。            }
                Label1.Text = ws.EmpAddWork(BaseClass.TicketInfoID, BaseClass.UserID.ToString(), BaseClass.dtNow);
                GridView1.Visible = false;
                GridView2.Visible = true;
                DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetSumAmount", new object[] { BaseClass.UserID, 0 })).Tables[0];
                GridView2.DataSource = dt;
                GridView2.DataBind();
                Button1.Visible = true;
                Button1.Text = "当天";
            }
            else
            {
                aa = ws.GetBoxInfo(card.ToString());
                DataTable dtBox = ToDataTable(aa);
                if (dtBox.Rows.Count > 0)
                {
                    string boxInfo = dtBox.Rows[0][0].ToString();
                    string workingName = dtBox.Rows[0][1].ToString();
                    BaseClass.TicketInfoID = dtBox.Rows[0][2].ToString();
                    BaseClass.IsCanMove = Convert.ToBoolean(dtBox.Rows[0][3]);
                    BaseClass.dtNow = dtBox.Rows[0][4].ToString();
                    Label1.Text = boxInfo + workingName;
                    string TicketID = TextBox1.Text.Trim();

                    int _ticketID = 0;
                    int _group = 0;
                    try
                    {
                        _ticketID = Convert.ToInt32(TicketID.Substring(0, TicketID.Length - 1));
                        _group = Convert.ToInt32(TicketID.Substring(TicketID.Length - 1));
                    }
                    catch
                    {
                        return;
                    }
                    GridView1.Visible = true;
                    GridView2.Visible = false;
                    DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.WorkTicketIDCard", "GetWorkOverListByTicketID", new object[] { _ticketID })).Tables[0];
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    Button1.Visible = false;
                }
            }
            //TextBox1.Text = string.Empty;
            //DataTable dtEMP = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetList", new object[] { "(IDCardID=" + card + ")" })).Tables[0];//判断是否是员工卡
            //if (dtEMP.Rows.Count > 0)//是员工卡，显示该员工当天所做的事情
            //{
            //    GridView1.Visible = false;
            //    GridView2.Visible = true;
            //    ViewState["EmpID"] = dtEMP.Rows[0]["ID"];
            //    DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.MiniEmp", "GetSumAmount", new object[] { Convert.ToInt32(dtEMP.Rows[0]["ID"]), 0 })).Tables[0];
            //    GridView2.DataSource = dt;
            //    GridView2.DataBind();
            //    Button1.Visible = true;
            //    Button1.Text = "当天";
            //}
            //else//不是员工卡，则可能是货物卡，返回这一份货物的工序完成情况
            //{
            //    GridView1.Visible = true;
            //    GridView2.Visible = false;
            //    DataTable dt = BaseClass.Byte2DS(fsc.getZipData("Hownet.BLL.WorkTicketIDCard", "GetWorkOverList", new object[] { card })).Tables[0];
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            //    Button1.Visible = false;
            //}
            TextBox1.Focus();
        }



    }
}
