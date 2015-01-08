using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.InteropServices;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        [DllImport("Iphlpapi.dll")]
        private static extern int SendARP(Int32 dest, Int32 host, ref Int64 mac, ref Int32 length);
        [DllImport("Ws2_32.dll")]
        private static extern Int32 inet_addr(string ip);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                Maticsoft.DBUtility.DbHelperSQL.connOpen();

                ReaderCard.BasicTable.bllME = new Hownet.BLL.MiniEmp();
                ReaderCard.BasicTable.bllWTI = new Hownet.BLL.WorkTicketInfo();
                ReaderCard.BasicTable.bllWTIDC = new Hownet.BLL.WorkTicketIDCard();
                ReaderCard.BasicTable.bllOT = new Hownet.BLL.OtherType();
                ReaderCard.BasicTable.bllAR = new Hownet.BLL.AttendanceRecords();
                ReaderCard.BasicTable.bllST = new Hownet.BLL.SysTem();
                ReaderCard.BasicTable.bllCRL = new Hownet.BLL.CardReaderList();
                ReaderCard.BasicTable.bllWType = new Hownet.BLL.WorkType();
                ReaderCard.BasicTable.bllPU = new Hownet.BLL.PermissionsUser();

                BaseClass.dsSysTem = ReaderCard.BasicTable.bllST.GetList("(ID=" + (ReaderCard.BasicTable.bllST.GetMaxId() - 1) + ")");

                ReaderCard.BasicTable.dtAttRules = ReaderCard.BasicTable.bllOT.GetTypeList("考勤设置").Tables[0];
                ReaderCard.BasicTable.dtWTCard = ReaderCard.BasicTable.bllWTIDC.GetAllListByCardID(0).Tables[0];
                ReaderCard.BasicTable.dtEmployee = ReaderCard.BasicTable.bllME.GetAllList().Tables[0];
                ReaderCard.BasicTable.dtMain = ReaderCard.BasicTable.bllWTIDC.GetPaddtMain().Tables[0];
                ReaderCard.BasicTable.dtWorkTime = ReaderCard.BasicTable.bllOT.GetWorkTime().Tables[0];
                ReaderCard.BasicTable.dtCarReaderList = ReaderCard.BasicTable.bllCRL.GetAllList().Tables[0];
                ReaderCard.BasicTable.dtWorkType = ReaderCard.BasicTable.bllWType.GetAllList().Tables[0];
                //  ReaderCard.BasicTable.dsPU = ReaderCard.BasicTable.bllPU.GetAllList();
                ReaderCard.BasicTable.modST = ReaderCard.BasicTable.bllST.GetModel(ReaderCard.BasicTable.bllST.GetMaxId() - 1);
                if (BaseClass.dsSysTem.Tables.Count > 0)
                {
                    ReaderCard.BasicTable.BackDepotWorkingID = Convert.ToInt32(BaseClass.dsSysTem.Tables[0].Rows[0]["BackDepotWorking"]);
                    ReaderCard.BasicTable.DefaultDepot = Convert.ToInt32(BaseClass.dsSysTem.Tables[0].Rows[0]["DefaultDepot"]);
                    ReaderCard.BasicTable.IsShowMoney = Convert.ToBoolean(BaseClass.dsSysTem.Tables[0].Rows[0]["IsShowMoney"]);

                }

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
                    //   _Mac = mac_dest;
                    ViewState["Mac"] = mac_dest;
                }
                catch (Exception err)
                {
                    Response.Write(err.Message);
                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            GridView2.DataSource = null;
            GridView2.DataBind();

            GridView1.DataSource = null;
            GridView1.DataBind();


            //ReaderCard.TreatmentCarID tc = new ReaderCard.TreatmentCarID("3255+" + TextBox1.Text);
            //string aa = tc.Treatment();
            //Label1.Text = aa;e
            int card = 0;
            try
            {
                card = Convert.ToInt32(TextBox1.Text.Trim());
            }
            catch
            {
                Label1.Text = "卡号格式不正确";
                TextBox1.Text = string.Empty;
                TextBox1.Focus();
                return;
            }
            ReaderCard.PadCarID PC = new ReaderCard.PadCarID("1" + ViewState["Mac"].ToString() + "+" + TextBox1.Text);
            string aa = PC.Treatment();
            Label1.Text = aa;
            TextBox1.Text = string.Empty;
           
            DataRow[] drs = ReaderCard.BasicTable.dtEmployee.Select("(IDCardID=" + card + ")");
            if (drs.Length > 0)
            {
                DataTable dt = ReaderCard.BasicTable.bllME.GetSumAmount(Convert.ToInt32(drs[0]["ID"])).Tables[0];
                GridView2.DataSource = dt;
                GridView2.DataBind();
            }
            else
            {
                DataTable dt = ReaderCard.BasicTable.bllWTIDC.GetWorkOverList(card).Tables[0];
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            TextBox1.Focus();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int a = GridView1.Columns.Count;
                //  Label1.Text = e.CommandArgument.ToString();
                Control c = (Control)e.CommandSource;
                GridViewRow g = (GridViewRow)c.NamingContainer;
                ReaderCard.PadCarID PC = new ReaderCard.PadCarID("2" + ViewState["Mac"].ToString() + "+" + g.Cells[1].Text);
                string aa = PC.Treatment();
                Label1.Text = aa;
                // Label1.Text = g.Cells[1].Text;
                //this.txtValueAddress.Text = g.Cells[2].Text;
                TextBox1.Focus();
            }
        }
    }
}
