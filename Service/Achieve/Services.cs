using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using Contracts;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.IO;
using ReaderCard;

namespace Services
{
    public class Services:IDataService
    {

        public static readonly String uploadFolder = Service.ServiceForm.Dir + @"\UploadFile\";

        public void Hello()
        {
            Console.WriteLine("adfafda");
        }
        public string CheckUser(string UserName, string Pass)
        {
            try
            {
                int a = Convert.ToInt32(UserName);
                Hownet.BLL.MiniEmp bllME = new Hownet.BLL.MiniEmp();
                DataTable dt = bllME.GetList("(Sn='" + UserName + "')").Tables[0];
                if (dt.Rows.Count == 1)
                    return dt.Rows[0]["ID"].ToString() + "," + dt.Rows[0]["Name"].ToString();
                return "员工编号错误";
            }
            catch
            {
                return "员工编号错误";
            }
        }
        public string GetJson(string Bll, string Exc, object[] par)
        {
            DataSet ds = new DataSet();
            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            ds = (DataSet)method.Invoke(obj, par);
            //StringBuilder strDS = new StringBuilder();
            //for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            //{
            //    strDS.Append(ds.Tables[0].Columns[i].ColumnName);
            //    strDS.Append("ю");
            //    strDS.Append(ds.Tables[0].Columns[i].DataType.ToString());
            //    strDS.Append("ж");//列字段
            //}
            //strDS.Append("й");
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
            //    {
            //        strDS.Append(ds.Tables[0].Rows[i][j].ToString());
            //        strDS.Append("ж");
            //    }
            //    strDS.Append("й");
            //}
            return Table2String(ds.Tables[0]);
        }
        private string Table2String(DataTable dt)
        {
            StringBuilder strDS = new StringBuilder();
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                strDS.Append(dt.Columns[i].ColumnName);
                strDS.Append("ю");
                strDS.Append(dt.Columns[i].DataType.ToString());
                strDS.Append("ж");//列字段
            }
            strDS.Append("й");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    strDS.Append(dt.Rows[i][j].ToString());
                    strDS.Append("ж");
                }
                strDS.Append("й");
            }
            return strDS.ToString();
        }
        public string GetImage(string Imagefilename)
        {
            try
            {
                Bitmap bmp = new Bitmap(uploadFolder+ Imagefilename);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch
            {
                return string.Empty;
            }
        }
        public string GetBoxInfo(string TicketID)
        {
            string BoxInfo = string.Empty;
            int _ticketID = 0;
            int _group = 0;
            try
            {
                //if (TicketID.IndexOf(',') > -1)
                //{
                    //string[] ss = TicketID.Split(',');
                    _ticketID = Convert.ToInt32(TicketID.Substring(0, TicketID.Length - 1));
                    _group = Convert.ToInt32(TicketID.Substring(TicketID.Length - 1));
                //}
                //else
                //{
                //    _ticketID = Convert.ToInt32(TicketID);
                //}
            }
            catch
            {
                return BoxInfo;
            }
            DataTable dtt = new DataTable();
            dtt.TableName = "dt";
            dtt.Columns.Add("Remark", typeof(string));
            dtt.Columns.Add("WorkingName", typeof(string));
            dtt.Columns.Add("WTIID", typeof(int));
            dtt.Columns.Add("IsCanMove", typeof(bool));
            dtt.Columns.Add("dtNow", typeof(string));
            DataRow[] drs = ReaderCard.BasicTable.dtWTCard.Select("(TicketID=" + _ticketID + ") And (GroupBy=" + _group + ")");
            if (drs.Length == 0)
            {
                DataTable dttt = BasicTable.bllWTIDC.GetAllListByTicketID(_ticketID, _group).Tables[0];
                if (dttt.Rows.Count == 0)
                {
                    #region
                    Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();
                    DataSet ds = bllWT.GetBoxInfo(_ticketID, _group);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        BoxInfo = "箱号：" + dt.Rows[0]["BoxNum"].ToString() + "，款号：" + dt.Rows[0]["MaterielName"].ToString();
                        if (dt.Rows[0]["BrandName"] != null && dt.Rows[0]["BrandName"].ToString() != string.Empty)
                        {
                            BoxInfo += "， 商标：" + dt.Rows[0]["BrandName"].ToString();
                        }
                        if (dt.Rows[0]["ColorName"] != null && dt.Rows[0]["ColorName"].ToString() != string.Empty)
                        {
                            BoxInfo += "， 颜色：" + dt.Rows[0]["ColorName"].ToString();
                        }
                        if (dt.Rows[0]["SizeName"] != null && dt.Rows[0]["SizeName"].ToString() != string.Empty)
                        {
                            BoxInfo += "， 尺码：" + dt.Rows[0]["SizeName"].ToString();
                        }
                        if (dt.Rows[0]["ColorOneName"] != null && dt.Rows[0]["ColorOneName"].ToString() != string.Empty)
                        {
                            BoxInfo += "， 配色一：" + dt.Rows[0]["ColorOneName"].ToString();
                        }
                        if (dt.Rows[0]["ColorTwoName"] != null && dt.Rows[0]["ColorTwoName"].ToString() != string.Empty)
                        {
                            BoxInfo += "， 配色二：" + dt.Rows[0]["ColorTwoName"].ToString();
                        }
                        BoxInfo += "， 数量：" + dt.Rows[0]["Amount"].ToString();
                        DataRow dr = dtt.NewRow();
                        dr[0] = BoxInfo;
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            dr[1] = "  " + ds.Tables[1].Rows[0][0].ToString();
                            dr[2] = ds.Tables[1].Rows[0][1];
                            dr[3] = ds.Tables[1].Rows[0][2];
                        }
                        else
                        {
                            dr[1] = "  所有工序已完成";
                            dr[2] = 0;
                            dr[3] = false;
                        }
                        dr[4] = DateTime.Now.ToString();
                        dtt.Rows.Add(dr);
                        return Table2String(dtt);
                    }
                    else
                    {
                        return BoxInfo;
                    }
                    #endregion
                }
                else
                {
                    for (int i = 0; i < dttt.Rows.Count; i++)
                    {
                        ReaderCard.BasicTable.dtWTCard.Rows.Add(dttt.Rows[i].ItemArray);
                    }
                    drs = ReaderCard.BasicTable.dtWTCard.Select("(TicketID=" + _ticketID + ") And (GroupBy=" + _group + ")");
                }
                 
            }
            if (drs.Length > 0)
            {
                BoxInfo = "箱号：" + drs[0]["BoxNum"].ToString() + "，款号：" + drs[0]["MaterielName"].ToString();
                //if (drs[0]["BrandName"] != null && drs[0]["BrandName"].ToString() != string.Empty)
                //{
                //    BoxInfo += "， 商标：" + drs[0]["BrandName"].ToString();
                //}
                if (drs[0]["ColorName"] != null && drs[0]["ColorName"].ToString() != string.Empty)
                {
                    BoxInfo += "， 颜色：" + drs[0]["ColorName"].ToString();
                }
                if (drs[0]["SizeName"] != null && drs[0]["SizeName"].ToString() != string.Empty)
                {
                    BoxInfo += "， 尺码：" + drs[0]["SizeName"].ToString();
                }
                //if (drs[0]["ColorOneName"] != null && drs[0]["ColorOneName"].ToString() != string.Empty)
                //{
                //    BoxInfo += "， 配色一：" + drs[0]["ColorOneName"].ToString();
                //}
                //if (drs[0]["ColorTwoName"] != null && drs[0]["ColorTwoName"].ToString() != string.Empty)
                //{
                //    BoxInfo += "， 配色二：" + drs[0]["ColorTwoName"].ToString();
                //}
                BoxInfo += "， 数量：" + drs[0]["Amount"].ToString();
                DataRow dr = dtt.NewRow();
                dr[0] = BoxInfo;
                DataRow[] ddrs = ReaderCard.BasicTable.dtWTCard.Select("(TicketID=" + _ticketID + ") And (GroupBy=" + _group + ") And (EmployeeID=0)", "Orders");
                if (ddrs.Length > 0)
                {
                    dr[1] = ddrs[0]["WorkingName"].ToString();
                    dr[2] = ddrs[0]["InfoID"];
                    dr[3] = ddrs[0]["IsCanMove"];

                }
                else
                {
                    dr[1] = "  所有工序已完成";
                    dr[2] = 0;
                    dr[3] = false;
                }
                dr[4] = DateTime.Now.ToString();
                dtt.Rows.Add(dr);
                return Table2String(dtt);
            }
            else
            {
                return BoxInfo;
            }
        }
        public string GetTicketInfo(string TicketID)
        {
            string BoxInfo = string.Empty;
            int _ticketID = 0;
            int _group = 0;
            try
            {
                if (TicketID.IndexOf(',') > -1)
                {
                  //  string[] ss = TicketID.Split(',');
                    _ticketID = Convert.ToInt32(TicketID.Substring(0,TicketID.Length-1));
                    _group = Convert.ToInt32(TicketID.Substring(TicketID.Length-1));
                }
                else
                {
                    _ticketID = Convert.ToInt32(TicketID);
                }
            }
            catch
            {
                return BoxInfo;
            }
            Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();
            DataTable dt = bllWT.GetTickInfo(_ticketID).Tables[0];
            if (dt.Rows.Count > 0)
                return Table2String(dt);
            else
                return string.Empty;
        }
        public string EmpAddWork(string TicketInfoID, string EmpID,string TicketTime)
        {
            if (TicketInfoID==string.Empty|| TicketTime == string.Empty)
            {
                return "工序卡刷卡不正确";
            }
            if (Convert.ToDateTime(TicketTime).AddSeconds(30) < DateTime.Now)
            {
                return "刷卡超时";
            }
            if (EmpID == string.Empty)
            {
                return string.Empty;
            }
            try
            {
                Hownet.BLL.MiniEmp bllME = new Hownet.BLL.MiniEmp();
                Hownet.Model.MiniEmp modME = bllME.GetModel(Convert.ToInt32(EmpID));
                if (modME == null)
                {
                    return "员工不正确";
                }
                if (Convert.ToDateTime(modME.DimDate) > Convert.ToDateTime("1900-1-1"))
                {
                    return "员工已离职！";
                }
                Hownet.BLL.WorkTicketInfo bllWTI = new Hownet.BLL.WorkTicketInfo();
                Hownet.Model.WorkTicketInfo modWTI = bllWTI.GetModel(Convert.ToInt32(TicketInfoID));
                if (modWTI == null)
                {
                    return "工序卡刷卡不正确";
                }
                if (modWTI.EmployeeID > 0)
                {
                    return "该工序已被完成";
                }
                Hownet.BLL.Working bllW = new Hownet.BLL.Working();
                Hownet.Model.Working modW = bllW.GetModel(modWTI.WorkingID);
                if (!CheckWorkType(modW.WorkTypeID.ToString(), modME.WorkTypeID))
                {
                    return "工种不匹配";
                }
                DateTime dtNow = DateTime.Now;
                Hownet.BLL.ProductTaskMain bllPTM = new Hownet.BLL.ProductTaskMain();
                Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(modWTI.TaskID);
                bllWTI.GetBarBack(modWTI.ID,modME.ID, dtNow, 1);
                bllWTI.AddPayInfo(modPTM.MaterielID, modWTI.ID, modPTM.DateTime.ToString("yyyyMMdd") + modPTM.Num.ToString().PadLeft(3, '0'));
                DataRow[] drs = ReaderCard.BasicTable.dtWTCard.Select("(InfoID=" + TicketInfoID + ")");
                if (drs.Length == 1)
                {
                    drs[0]["EmployeeID"] = modME.ID;
                    drs[0]["MiniEmpName"] = modME.Name;
                    drs[0]["DateTime"] = DateTime.Now;
                }

                if (modWTI.WorkingID == BasicTable.BackDepotWorkingID)
                {
                    Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();
                    Hownet.Model.WorkTicket modWT = bllWT.GetModel(modWTI.MainID);
                    if (modWT.P2DInfoID == 0 )
                    {
                        Hownet.BLL.AmountInfo bllAI = new Hownet.BLL.AmountInfo();
                        List<Hownet.Model.AmountInfo> liAI = bllAI.GetModelList("(MainID=" + modWT.TaskID + ") And (TableTypeID=1) And (MListID=" + modWT.MListID + ")");
                        if (liAI.Count > 0)
                        {
                            liAI[0].NotAmount -= modWT.Amount;
                            bllAI.Update(liAI[0]);
                        }
                    }
                    
                }
                return "今天总产量：" + bllWTI.CountAmount(modME.ID, dtNow, ReaderCard.BasicTable.IsShowMoney).ToString();
            }
            catch
            {
                return "对不起，出现错误！";
            }
            return string.Empty;
        }
        public string Ordering(string EID)
        {
            try
            {
                int _eid = Convert.ToInt32(EID);
            }
            catch
            {
                return "员工不正确";
            }
            bool t = false;
            Hownet.BLL.MiniEmp bllME = new Hownet.BLL.MiniEmp();
            Hownet.Model.MiniEmp modME = bllME.GetModel(Convert.ToInt32( EID));
            if (modME == null)
            {
                return "员工不正确";
            }
            if (Convert.ToDateTime(modME.DimDate) > Convert.ToDateTime("1900-1-1"))
            {
                return "员工已离职！";
            }
            string mes = string.Empty;
            int olTypeID = GetTypeID();
            if (olTypeID < 4)
            {
                DataTable dtOL = new DataTable();
                Hownet.BLL.OrderingList bllOL = new Hownet.BLL.OrderingList();
                Hownet.Model.OrderingList modOL;
                if (BasicTable.modST.OderOne > BasicTable.modST.OderThree && olTypeID == 1)

                    dtOL = bllOL.GetList("(EmployeeID=" + EID + ") And (DateTime='" + DateTime.Today.AddDays(BasicTable.modST.OrderDays + 1) + "')").Tables[0];
                else
                    dtOL = bllOL.GetList("(EmployeeID=" + EID + ") And (DateTime='" + DateTime.Today.AddDays(BasicTable.modST.OrderDays) + "')").Tables[0];
                if (dtOL.Rows.Count == 0)
                {
                    modOL = new Hownet.Model.OrderingList();
                    modOL.EmployeeID = Convert.ToInt32(EID);
                    modOL.DateTime = DateTime.Today.AddDays(BasicTable.modST.OrderDays);
                    if (olTypeID == 1)
                    {
                        if (BasicTable.modST.OderOne > BasicTable.modST.OderThree)
                            modOL.DateTime = DateTime.Today.AddDays(BasicTable.modST.OrderDays + 1);
                        modOL.OrderOne = 1;
                        modOL.DinOne = modOL.OrderTwo = modOL.DinTwo = modOL.OrderThree = modOL.DinThree = 0;
                        modOL.OrderOneTime = DateTime.Now;
                        modOL.DiningOneTime = modOL.OrdeTwoTime = modOL.DiningTwoTime = modOL.OrdeThreeTime = modOL.DiningThreeTime = DateTime.Parse("1900-1-1");
                        modOL.OrderCount = 1;
                        modOL.DinCount = 0;
                    }
                    else if (olTypeID == 2)
                    {
                        modOL.OrderTwo = 1;
                        modOL.DinOne = modOL.OrderOne = modOL.DinTwo = modOL.OrderThree = modOL.DinThree = 0;
                        modOL.OrdeTwoTime = DateTime.Now;
                        modOL.DiningOneTime = modOL.OrderOneTime = modOL.DiningTwoTime = modOL.OrdeThreeTime = modOL.DiningThreeTime = DateTime.Parse("1900-1-1");
                        modOL.OrderCount = 1;
                        modOL.DinCount = 0;
                    }
                    else if (olTypeID == 3)
                    {
                        modOL.OrderThree = 1;
                        modOL.DinOne = modOL.OrderOne = modOL.DinTwo = modOL.OrderTwo = modOL.DinThree = 0;
                        modOL.OrdeThreeTime = DateTime.Now;
                        modOL.DiningOneTime = modOL.OrderOneTime = modOL.DiningTwoTime = modOL.OrdeTwoTime = modOL.DiningThreeTime = DateTime.Parse("1900-1-1");
                        modOL.OrderCount = 1;
                        modOL.DinCount = 0;
                    }
                    bllOL.Add(modOL);
                }
                else
                {
                    modOL = bllOL.GetModel(Convert.ToInt32(dtOL.Rows[0]["ID"]));
                    if (olTypeID == 1)
                    {
                        if (modOL.OrderOne == 0)
                        {
                            modOL.OrderOne = 1;
                            modOL.OrderOneTime = DateTime.Now;
                            t = true;
                        }
                    }
                    else if (olTypeID == 2)
                    {
                        if (modOL.OrderTwo == 0)
                        {
                            modOL.OrderTwo = 1;
                            modOL.OrdeTwoTime = DateTime.Now;
                            t = true;
                        }
                    }
                    else if (olTypeID == 3)
                    {
                        if (modOL.OrderThree == 0)
                        {
                            modOL.OrderThree = 1;
                            modOL.OrdeThreeTime = DateTime.Now;
                            t = true;
                        }
                    }
                }
                if (t)
                {
                    modOL.OrderCount += 1;
                    bllOL.Update(modOL);
                }
                mes = modME.Name + "  预订";

                if (BasicTable.modST.OderOne > BasicTable.modST.OderThree && olTypeID == 1)
                    mes = mes + DateTime.Today.AddDays(BasicTable.modST.OrderDays + 1).Day.ToString() + "日";
                else
                    mes = mes + DateTime.Today.AddDays(BasicTable.modST.OrderDays).Day.ToString() + "日";
                if (olTypeID == 1)
                    mes = mes + "早餐";
                if (olTypeID == 2)
                    mes = mes + "午餐";
                if (olTypeID == 3)
                    mes = mes + "晚餐";
                mes = mes + "成功";
            }
            else
            {
                mes = "已经打烊不订餐了";
            }
            return mes;
        }
        public string EmpAtt(string EID)
        {
            try
            {
                int _eid = Convert.ToInt32(EID);
            }
            catch
            {
                return "员工不正确";
            }
            Attendance TA = new Attendance(Convert.ToInt32(EID));
            return TA.TrAtt();
        }
        private bool CheckWorkType(string WorkTypeID, string  wt)
        {
            bool t = false;

            if (wt.IndexOf(',') > -1)
            {
                string[] ss = wt.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    if (WorkTypeID == ss[i])
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (WorkTypeID == wt)
                    return true;
            }
            return t;
        }
        private int GetTypeID()
        {

            int a = 0;
            int hh = Convert.ToInt32(DateTime.Now.TimeOfDay.ToString().Substring(0, 2));
            if (BasicTable.modST.OderOne < BasicTable.modST.OderThree)
            {
                if (hh > -1 && hh < BasicTable.modST.OderOne)
                    a = 1;
                else if (hh > BasicTable.modST.OderOne - 1 && hh < BasicTable.modST.OderTwo)
                    a = 2;
                else if (hh > BasicTable.modST.OderTwo - 1 && hh < BasicTable.modST.OderThree)
                    a = 3;
                else if (hh > 18 || hh == 0)
                    a = 4;
            }
            else
            {
                if (hh > -1 && hh < BasicTable.modST.OderTwo)
                    a = 2;
                else if (hh > BasicTable.modST.OderTwo - 1 && hh < BasicTable.modST.OderThree)
                    a = 3;
                else if (hh > BasicTable.modST.OderThree - 1 && hh < BasicTable.modST.OderOne)
                    a = 1;
                else if (hh == 0)
                    a = 4;
            }
            return a;
        }
        public string GetName(string MaterielID)
        {
            return "asdfasdfasdf";
        }
    }
}
