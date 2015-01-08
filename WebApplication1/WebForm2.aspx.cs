using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Collections.Specialized;
using System.Collections;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string type = "";
            string Re = "";
            string str = "";
            Re += "数据传送方式：";
            if (Request.RequestType.ToUpper() == "POST")
            {
                str = "";
                type = "POST";
                Re += type + "<br/>参数分别是：<br/>";
                SortedList table = sParam();
                //Hashtable table = hParam();  

                if (table != null)
                {
                    if (table.Count == 1)
                    {
                        ServiceReference1.FileTransportServiceClient fsc = new WebApplication1.ServiceReference1.FileTransportServiceClient();
                        int sn = 0;
                        try
                        {
                            foreach (DictionaryEntry De in table)
                            {
                                sn = Convert.ToInt32(De.Value);
                            }


                        }
                        catch
                        {
                            Re = "员工编号错误";
                        }
                        DataSet ds = BaseClass.Byte2DS(fsc.GetBySql("Select ID,SN,Name From Employee Where (SN=" + sn + ")"));
                    }
                    //foreach (DictionaryEntry De in table)
                    //{
                    //    Re += "参数名：" + De.Key + " 值：" + De.Value + "<br/>";
                    //}
                }
                else
                { Re = "你没有传递任何参数过来！"; }

            }
            else
            {
                str = "";
                type = "GET";
                Re += type + "<br/>参数分别是：<br/>";
                NameValueCollection nvc = GETInput();
                if (nvc.Count > 0)
                {
                    string sssss = nvc.GetKey(0).ToString();
                    int sn = 0;
                    try
                    {
                        sn = Convert.ToInt32(nvc.GetValues(0)[0]);

                    }
                    catch
                    {
                        Re = "输入错误";
                    }
                    if (sssss.ToLower() == "login")
                    {
                        if (sn > 0)
                        {
                            ServiceReference1.FileTransportServiceClient fsc = new WebApplication1.ServiceReference1.FileTransportServiceClient();
                            DataTable dt = BaseClass.Byte2DS(fsc.GetSqlByByte("Select ID,Sn,Name From MiniEmp Where (Sn=" + sn + ")")).Tables[0];
                            if (dt.Rows.Count == 1)
                            {
                                Re = dt.Rows[0]["ID"].ToString() + " " + dt.Rows[0]["Name"].ToString();
                            }
                            else
                            {
                                Re = "0";
                            }
                        }
                    }
                    else if (sssss.ToLower() == "ticketid")
                    {
                        ServiceReference1.FileTransportServiceClient fsc = new WebApplication1.ServiceReference1.FileTransportServiceClient();
                        Re = fsc.GetBoxInfo(sn.ToString());
                    }
                    else if (sssss.ToLower() == "getticketinfo")
                    {
                        ServiceReference1.FileTransportServiceClient fsc = new WebApplication1.ServiceReference1.FileTransportServiceClient();
                        Re = fsc.GetTicketInfo(sn.ToString());
                    }
                    else if (sssss.ToLower() == "empaddwork")
                    {
                        ServiceReference1.FileTransportServiceClient fsc = new WebApplication1.ServiceReference1.FileTransportServiceClient();
                        string usid = nvc.GetValues(1)[0].ToString();
                        string date = nvc.GetValues(2)[0].ToString();
                        Re = fsc.EmpAddWork(sn.ToString(), usid, date);
                    }
                    else if (sssss.ToLower() == "ordering")
                    {
                        ServiceReference1.FileTransportServiceClient fsc = new ServiceReference1.FileTransportServiceClient();
                        Re = fsc.Ordering(sn.ToString());
                    }
                    //else if (sssss.ToLower() == "daylist")
                    //{
                    //    ServiceReference1.FileTransportServiceClient fsc = new ServiceReference1.FileTransportServiceClient();
                    //    Re = fsc.GetEmpWorkingList(sn, 1);
                    //}
                    //else if (sssss.ToLower() == "monthlist")
                    //{
                    //    ServiceReference1.FileTransportServiceClient fsc = new ServiceReference1.FileTransportServiceClient();
                    //    Re = fsc.GetEmpWorkingList(sn, 2);
                    //}
                    else if (sssss.ToLower() == "paylist")
                    {
                        ServiceReference1.FileTransportServiceClient fsc = new ServiceReference1.FileTransportServiceClient();

                        Re = fsc.GetEmpWorkingList(sn, Convert.ToDateTime(nvc.GetValues(1)[0]), Convert.ToDateTime(nvc.GetValues(2)[0]).AddDays(1));
                    }
                    else
                    {
                        Re = sssss;
                    }
                }
                else
                { Re = "你没有传递任何参数过来！"; }
            }
            Response.Write(Re);
        }

        //获取GET返回来的数据  
        private NameValueCollection GETInput()
        { return Request.QueryString; }

        // 获取POST返回来的数据  
        private string PostInput()
        {
            try
            {
                System.IO.Stream s = Request.InputStream;
                int count = 0;
                byte[] buffer = new byte[1024];
                StringBuilder builder = new StringBuilder();
                while ((count = s.Read(buffer, 0, 1024)) > 0)
                {
                    builder.Append(Encoding.UTF8.GetString(buffer, 0, count));
                }
                s.Flush();
                s.Close();
                s.Dispose();
                return builder.ToString();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private Hashtable hParam()
        {
            string POSTStr = PostInput();
            Hashtable HashList = new Hashtable();
            int index = POSTStr.IndexOf("&");
            string[] Arr = { };
            if (index != -1) //参数传递不只一项  
            {
                Arr = POSTStr.Split('&');
                for (int i = 0; i < Arr.Length; i++)
                {
                    int equalindex = Arr[i].IndexOf('=');
                    string paramN = Arr[i].Substring(0, equalindex);
                    string paramV = Arr[i].Substring(equalindex + 1);
                    if (!HashList.ContainsKey(paramN)) //避免用户传递相同参数  
                    { HashList.Add(paramN, paramV); }
                    else //如果有相同的，一直删除取最后一个值为准  
                    { HashList.Remove(paramN); HashList.Add(paramN, paramV); }
                }
            }
            else //参数少于或等于1项  
            {
                int equalindex = POSTStr.IndexOf('=');
                if (equalindex != -1)
                { //参数是1项  
                    string paramN = POSTStr.Substring(0, equalindex);
                    string paramV = POSTStr.Substring(equalindex + 1);
                    HashList.Add(paramN, paramV);

                }
                else //没有传递参数过来  
                { HashList = null; }
            }
            return HashList;
        }

        private SortedList sParam()
        {
            string POSTStr = PostInput();
            SortedList SortList = new SortedList();
            int index = POSTStr.IndexOf("&");
            string[] Arr = { };
            if (index != -1) //参数传递不只一项  
            {
                Arr = POSTStr.Split('&');
                for (int i = 0; i < Arr.Length; i++)
                {
                    int equalindex = Arr[i].IndexOf('=');
                    string paramN = Arr[i].Substring(0, equalindex);
                    string paramV = Arr[i].Substring(equalindex + 1);
                    if (!SortList.ContainsKey(paramN)) //避免用户传递相同参数  
                    { SortList.Add(paramN, paramV); }
                    else //如果有相同的，一直删除取最后一个值为准  
                    { SortList.Remove(paramN); SortList.Add(paramN, paramV); }
                }
            }
            else //参数少于或等于1项  
            {
                int equalindex = POSTStr.IndexOf('=');
                if (equalindex != -1)
                { //参数是1项  
                    string paramN = POSTStr.Substring(0, equalindex);
                    string paramV = POSTStr.Substring(equalindex + 1);
                    SortList.Add(paramN, paramV);

                }
                else //没有传递参数过来  
                { SortList = null; }
            }
            return SortList;
        } 
    }
}