using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class PadCarID
    {
        private static DateTime dt;
        private static string mes = string.Empty;
        private string CarIDstr;
        private static Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
        private int TypeID = 0;
        private int _depotID = 0;
        private int _comTypeID = 0;

        private Hownet.BLL.OrderingList bllOL = new Hownet.BLL.OrderingList();
        private Hownet.Model.OrderingList modOL = new Hownet.Model.OrderingList();
        private Hownet.BLL.SysTem bllST = new Hownet.BLL.SysTem();
       // private Hownet.Model.SysTem modST = BasicTable.modST;
        private string _Mac=string.Empty;
        public PadCarID(string CarID)
        {
            CarIDstr = CarID;
        }
        public string Treatment()
        {
            try
            {
                dt = DateTime.Now;
                TypeID = 0;
                if (CarIDstr != "")
                {
                    _comTypeID = Convert.ToInt32(CarIDstr.Substring(0, 1));
                    CarIDstr = CarIDstr.Substring(1);
                    if (_comTypeID == 1)//是刷卡信息
                    {
                        string[] ss = CarIDstr.Substring(1).Split('+');

                        FindEmpCard(ss[0], int.Parse(ss[1]));
                        return mes;
                    }
                    else if (_comTypeID == 2)
                    {
                        string _workingName = string.Empty;
                        string[] ss = CarIDstr.Substring(1).Split('+');
                        DataRow[] drs = BasicTable.dtMain.Select("(MacAddress='" + ss[0] + "') ");//查找箱头卡刷卡记录
                        if (drs.Length == 0)
                        {
                             ReturnStr(2, 0, "3+没有箱号记录");
                        }
                        else
                        {
                            DataRow[] ddrs = BasicTable.dtWTCard.Select("(InfoID='" + ss[1] + "') ");
                            if (ddrs.Length > 0)
                            {
                                //if (Convert.ToInt32(drs[0]["InfoID"]) == 0)//主表记录InfoID为0时，显示该箱最后一条记录。
                                //{
                                    drs[0]["InfoID"] = ddrs[0]["InfoID"];
                                    drs[0]["WorkingID"] = ddrs[0]["WorkingID"];
                                    drs[0]["WorkingName"] = _workingName = ddrs[0]["WorkingName"].ToString();
                                    drs[0]["EmployeeID"] = ddrs[0]["EmployeeID"];
                                    drs[0]["WorkingName"] = ddrs[0]["WorkingName"];
                                    drs[0]["WorkTypeID"] = ddrs[0]["WorkTypeID"];
                                    drs[0]["EmployeeName"] = ddrs[0]["MiniEmpName"];
                                    ReturnStr(0, 0,"4+"+ _workingName +"   "+ ddrs[0]["MiniEmpName"].ToString());
                                //}
                            }
                        }
                        return mes;
                    }
                }
                return "错误";
            }
            catch (Exception ex)
            {
                string[] ss = CarIDstr.Split('+');
                return "2," + ss[0] + ",错误";
            }
        }


        /// <summary>
        /// 刷卡时，查找是否为箱头卡
        /// </summary>
        /// <param name="CID">卡号ID</param>
        /// <param name="NID">机器号</param>
        private void FindWtickCard(string Mac, int CID)
        {
            if (ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ")").Length == 0)//ReaderCard.BasicTable.dtWTCard表中如果没有这张卡的信息，就查询数据库，如果查询到有记录，将查询出的记录追加到ReaderCard.BasicTable.dtWTCard中，如果没有记录，则判断本次刷卡为无效卡
            {
                DataTable dtt = BasicTable.bllWTIDC.GetAllListByCardID(CID).Tables[0];
                if (dtt.Rows.Count == 0)
                {
                    ReturnStr(2, 0, "3+错误的卡号！");
                    return;
                }
                else
                {
                    for (int i = 0; i < dtt.Rows.Count; i++)
                    {
                        ReaderCard.BasicTable.dtWTCard.Rows.Add(dtt.Rows[i].ItemArray);
                    }
                }
            }
            TreatmentWtickCard(Mac, CID);
            return;
        }
        /// <summary>
        /// 是箱头卡时，处理刷卡信息
        /// </summary>
        /// <param name="NID"></param>
        /// <param name="CID"></param>
        private void TreatmentWtickCard(string Mac, int CID)
        {
            DataRow[] drs;
            string ttt = string.Empty;
            string workName = string.Empty;
            int _employeeID = 0;
            int _infoID = 0;
            int _workingID = 0;
            drs = BasicTable.dtMain.Select("(MacAddress='" + Mac + "')");//dtMain表中删除此前有关这台卡机的刷卡记录
            if (drs.Length > 0)
            {
                for (int i = 0; i < drs.Length; i++)
                {
                    drs[i].Delete();
                }
                BasicTable.dtMain.AcceptChanges();
            }
            drs = null;
            drs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ") ");//查找该箱货现在要做的工序等信息，在刷卡上显示，
            ttt = "1+" + drs[0]["MaterielName"].ToString() + drs[0]["SizeName"].ToString() + drs[0]["ColorName"].ToString();
            int l = 15 - gb.GetByteCount(ttt);
            if (l > 0)
            {
                for (int i = 0; i < l; i++)
                {
                    ttt = ttt + " ";
                }
            }
            DataRow[] ddrs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo='" + CID + "') And (EmployeeID=0)", "Orders");
            if (ddrs.Length > 0)
            {
                if (TypeID == 0)
                {
                    _infoID = int.Parse(ddrs[0]["InfoID"].ToString());
                    _workingID = int.Parse(ddrs[0]["WorkingID"].ToString());
                    workName = ddrs[0]["WorkingName"].ToString();
                    if (workName.Length < 6)
                        ttt = ttt + ddrs[0]["Amount"].ToString().PadLeft(3, ' ') + workName;
                    else
                        ttt = ttt + ddrs[0]["Amount"].ToString().PadLeft(3, ' ') + workName.Substring(0, 6);
                }
                else if (TypeID == 2)
                {
                    ttt = ttt + "工序未完！" + ddrs[0]["Amount"].ToString();
                }
            }
            else
            {
                if (TypeID == 0)
                {
                    _employeeID = -1;
                    ttt = ttt + "所有工序已完成！";
                }

            }

            DataRow dr = BasicTable.dtMain.NewRow();//将本次刷卡信息添加进dtMain表中。
            dr["ID"] = drs[0]["ID"];
            dr["CardID"] = CID;
            dr["No"] = 0;
            dr["Date"] = dt;
            dr["TicketID"] = drs[0]["TicketID"];
            dr["WorkingID"] = _workingID;
            dr["InfoID"] = _infoID;
            dr["MaterielID"] = drs[0]["MaterielID"];
            dr["GroupBy"] = drs[0]["GroupBy"];
            dr["OderNum"] = drs[0]["Num"];
            dr["MaterielName"] = drs[0]["MaterielName"];
            dr["SizeName"] = drs[0]["SizeName"];
            dr["ColorName"] = drs[0]["ColorName"];
            if (ddrs.Length > 0)
                dr["Amount"] = ddrs[0]["Amount"];
            else
                dr["Amount"] = drs[0]["Amount"];
            dr["EmployeeID"] = _employeeID;
            dr["IsEnd"] = (ddrs.Length == 1);
            dr["WorkingName"] = workName;
            dr["WorkTypeID"] = drs[0]["WorkTypeID"];
            dr["MacAddress"] = Mac;
            BasicTable.dtMain.Rows.Add(dr);
            //if (ddrs.Length == 0)
            //{
            //    if (TypeID == 0)
            //    {
            //        _employeeID = -1;
            //        ttt = ttt + "所有工序已完成！";
            //    }
            //}
            ReturnStr(0, 0, ttt);
            return;
        }
        /// <summary>
        /// 刷卡时，查找是否为员工卡
        /// </summary>
        /// <param name="NID"></param>
        /// <param name="CID"></param>
        private void FindEmpCard(string Mac, int CID)
        {
            DataRow[] drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CID + ")");//是否有对应员工，没有就再次查询数据库，以添加新员工，如仍没有，见则转为查询是否为箱头卡
            if (drEm.Length == 0)
            {
                FindWtickCard(Mac, CID);
                    return;
            }
            _depotID = Convert.ToInt32(drEm[0]["DepartmentID"]);
            if (_depotID == 0)
            {
                ReturnStr(2, 0, "请设置员工部门");
                return;
            }
            TreatmentEmpCard(Mac, CID, int.Parse(drEm[0]["ID"].ToString()), drEm[0]["Name"].ToString(), drEm[0]["Sn"].ToString());
            //}
        }
        /// <summary>
        /// 是员工卡时，处理刷卡信息
        /// </summary>
        /// <param name="CID">卡号ID</param>
        /// <param name="NID">机器号</param>
        /// <param name="EmployeeID">员工ID</param>
        /// <param name="EmployeeName">员工姓名</param>
        private void TreatmentEmpCard(string Mac, int CID, int EmployeeID, string EmployeeName, string EmployeeSN)
        {
            DataRow[] drs;
            drs = BasicTable.dtMain.Select("(MacAddress='" + Mac + "') ");//查找该卡机之前的刷卡记录
            if (drs.Length > 0)
            {
                if (int.Parse(drs[0]["EmployeeID"].ToString()) == 0)//有可以记录工资的记录
                {
                    if (((DateTime)(drs[0]["Date"])).AddSeconds(30) > dt)//30秒内刷员工卡
                    {
                        #region 给员工记工资
                        DataRow[] dddrs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ") And (EmployeeID>0)", "DateTime DESC");//按完成时间倒序排列，选出最后一次刷卡的时间
                        if (dddrs.Length > 0)
                        {
                            TimeSpan ts = Min2Hours(int.Parse(dddrs[0]["Amount"].ToString()) * decimal.Parse(dddrs[0]["FastTime"].ToString()));
                            DateTime oldTime = (DateTime)(drs[0]["Date"]);
                            if (dt < (oldTime.Add(ts)))
                            {
                                ReturnStr(2, 0, "3+刷卡间隔太短！");
                                return;
                            }
                        }
                        DataRow[] drWT = ReaderCard.BasicTable.dtWTCard.Select("(InfoID=" + drs[0]["InfoID"] + ")");
                        if (drWT.Length > 0)
                        {
                            if (!CheckWorkType(drWT[0]["WorkTypeID"].ToString(), EmployeeID))
                            {
                                for (int i = 0; i < drs.Length; i++)
                                {
                                    drs[i].Delete();
                                }
                                BasicTable.dtMain.AcceptChanges();
                                ReturnStr(2, 0, "3+工种不匹配！");
                                return;
                            }
                        }
                        int materielid = int.Parse(drs[0]["MaterielID"].ToString());
                        int InfoID = int.Parse(drs[0]["InfoID"].ToString());
                        BasicTable.modWTI = BasicTable.bllWTI.GetModel(InfoID);
                        if (BasicTable.modWTI.EmployeeID > 0)
                        {
                            ReturnStr(0, 0, "3+工序已被完成");
                            drs[0].Delete();
                            return;
                        }
                        BasicTable.bllWTI.GetBarBack(int.Parse(drs[0]["InfoID"].ToString()), EmployeeID, dt, 1);
                        BasicTable.bllWTI.AddPayInfo(materielid, InfoID, drs[0]["OderNum"].ToString());
                        drs[0]["EmployeeID"] = EmployeeID;
                        drs[0]["EmployeeName"] = EmployeeName;
                        if ((bool)(drs[0]["IsEnd"]))//只有最后一道工序未完成，当完成之后，在WorkTicketIDCard表中标记
                        {
                            BasicTable.bllWTIDC.UpdateFishWork(int.Parse(drs[0]["ID"].ToString()));
                        }
                        BasicTable.dtMain.AcceptChanges();
                        string ttt ="2+"+ EmployeeSN + " " + EmployeeName;
                        int l = 15 - gb.GetByteCount(ttt);
                        if (l > 0)
                        {
                            for (int i = 0; i < l; i++)
                            {
                                ttt = ttt + " ";
                            }
                        }
                        if (BasicTable.modST.SumByWorking)
                            ttt = ttt + BasicTable.bllWTI.CountAmountByWorking(EmployeeID, dt, ReaderCard.BasicTable.IsShowMoney, BasicTable.modWTI.PWorkingInfoID).ToString();
                        else
                            ttt = ttt + BasicTable.bllWTI.CountAmount(EmployeeID, dt, ReaderCard.BasicTable.IsShowMoney).ToString();
                        ReturnStr(0, 0, ttt);
                        DataRow[] ddrs = ReaderCard.BasicTable.dtWTCard.Select("(InfoID=" + InfoID + ")");
                        if (ddrs.Length > 0)//将ReaderCard.BasicTable.dtWTCard表中相应工序的完成员工、时间修改
                        {
                            ddrs[0]["EmployeeID"] = EmployeeID;
                            ddrs[0]["MiniEmpName"] = EmployeeName;
                            ddrs[0]["DateTime"] = dt;
                            ddrs[0]["InfoID"] = InfoID;
                            drs[0]["Date"] = DateTime.Now;
                        }
                        if (BasicTable.modST.IsCanEditAmount)
                        {
                            return;
                        }
                        drs[0].Delete();
                        return;
                        #endregion
                    }
                    else
                    {
                        ReturnStr(2, 0, "3+刷卡超时");
                    }
                    for (int i = 0; i < drs.Length; i++)
                    {
                        drs[i].Delete();
                    }
                    BasicTable.dtMain.AcceptChanges();
                    return;
                }
                else if (int.Parse(drs[0]["EmployeeID"].ToString()) == -1)
                {
                    ReturnStr(0, 0, "3+所有工序已完成");
                    drs[0].Delete();
                    BasicTable.dtMain.AcceptChanges();
                    return;
                }
                else if (int.Parse(drs[0]["EmployeeID"].ToString()) > 0 && drs[0]["ID"] != null && drs[0]["ID"].ToString().Trim() != string.Empty)
                {
                    ReturnStr(2, 0, "3+工序已被员工   " + drs[0]["EmployeeName"].ToString() + "完成");
                    drs[0].Delete();
                    BasicTable.dtMain.AcceptChanges();
                    return;
                }

                for (int i = 0; i < drs.Length; i++)
                {
                    drs[i].Delete();
                }
                BasicTable.dtMain.AcceptChanges();
                DataRow dr = BasicTable.dtMain.NewRow();
                dr["CardID"] = 0;
                dr["No"] = 0;
                dr["Date"] = dt;
                dr["EmployeeID"] = EmployeeID;
                dr["EmployeeName"] = EmployeeName;
                dr["MacAddress"] = Mac;
                BasicTable.dtMain.Rows.Add(dr);
                ReturnStr(0, 0, "2+"+EmployeeSN+EmployeeName);
                return;
            }
            else//此前没有箱头卡记录，则将员工卡记录添加到dtMain表中
            {
                DataRow dr = BasicTable.dtMain.NewRow();
                dr["CardID"] = 0;
                dr["No"] = 0;
                dr["Date"] = dt;
                dr["EmployeeID"] = EmployeeID;
                dr["MacAddress"] = Mac;
                //dr["EmployeeName"] = EmployeeName;
                BasicTable.dtMain.Rows.Add(dr);
                ReturnStr(0, 0, EmployeeName);
                return;
            }
        }
        private string GetSendOneString(string strMes)
        {
            int l = 15 - gb.GetByteCount(strMes);
            if (l > 0)
            {
                for (int i = 0; i < l; i++)
                {
                    strMes = strMes + " ";
                }
            }
            else
            {
                strMes = strMes.Substring(0, 6);
            }
            return strMes;
        }
        private TimeSpan Min2Hours(decimal Mins)
        {
            int h = (int)(Mins / 60);
            int m = (int)(Mins - h * 60);
            int s = (int)((Mins - (int)Mins) * 60);
            TimeSpan ts = new TimeSpan(h, m, s);
            return ts;
        }
        private bool CheckWorkType(string WorkTypeID, int EmployeeID)
        {
            bool t = false;
            DataRow[] drsEmp = BasicTable.dtEmployee.Select("(ID=" + EmployeeID + ")");
            string wt = drsEmp[0]["WorkTypeID"].ToString();
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
        private bool IsInDepot(int EmployeeID)
        {
            DataRow[] drsWT = BasicTable.dtWorkType.Select("(Name='成品收货')");
            if (drsWT.Length > 0)
            {
                bool t = false;
                DataRow[] drsEmp = BasicTable.dtEmployee.Select("(ID=" + EmployeeID + ")");
                string wt = drsEmp[0]["WorkTypeID"].ToString();
                if (wt.IndexOf(',') > -1)
                {
                    string[] ss = wt.Split(',');
                    for (int i = 0; i < ss.Length; i++)
                    {
                        if (drsWT[0]["ID"].ToString() == ss[i])
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if (drsWT[0]["ID"].ToString() == wt)
                        return true;
                }
                return t;
            }
            else
            {
                return false;
            }
        }
        private void ReturnStr(int TypeID, int NID, string messs)
        {
            mes =  messs;//TypeID.ToString() + "," + NID.ToString() + "," +
        }
        /// <summary>
        /// 查找这个机器号是否为特殊机器
        /// </summary>
        /// <param name="Nid"></param>
        /// <returns></returns>
        private int FindNID(string Nid)
        {
            if (ReaderCard.BasicTable.dtCarReaderList.Rows.Count > 0)
            {
                //for (int i = 0; i < ReaderCard.BasicTable.dtCarReaderList.Rows.Count; i++)
                //{
                //    if (ReaderCard.BasicTable.dtCarReaderList.Rows[i]["NID"].ToString() == Nid)
                //        return Convert.ToInt32(ReaderCard.BasicTable.dtCarReaderList.Rows[i]["ID"]);
                //}
                DataRow[] drscr = ReaderCard.BasicTable.dtCarReaderList.Select("(NID=" + Nid + ")");
                if (drscr.Length > 0)
                {
                    return Convert.ToInt32(drscr[0]["TypeID"]);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        //private bool CheckAttend(int EmployeeID)
        //{
        //    DataTable dtAR = BasicTable.bllAR.GetList("(EmployeeID=" + EmployeeID + ") And (DateDay='" + dt.Date + "')").Tables[0];
        //    string timeFileds = string.Empty;
        //    if (dtAR.Rows.Count == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        int a = int.Parse(dt.Hour.ToString() + dt.Minute.ToString());
        //        int d = 0;
        //        int c = 0;
        //        for (int i = 0; i < BasicTable.dtWorkTime.Rows.Count; i++)
        //        {
        //            string[] ss = BasicTable.dtWorkTime.Rows[i]["Value"].ToString().Split(':');
        //            d = Math.Abs(int.Parse(ss[0] + ss[1]));//取设置时间和当前时间的差，取出最小的，用以判断是哪个时间段
        //            if (a > d)
        //            {
        //                c = i;
        //                break;
        //            }
        //        }
        //        if (c == 0)//加班考勤
        //        {
        //            if (dtAR.Rows[0]["TimeFive"].ToString().Trim() == string.Empty)
        //                return false;
        //            else
        //                return true;
        //        }
        //        else if (c == 1) //下午考勤
        //        {
        //            if (dtAR.Rows[0]["TimeThree"].ToString().Trim() == string.Empty)
        //                return false;
        //            else
        //                return true;
        //        }
        //        else if (c == 2)//上午考勤
        //        {
        //            if (dtAR.Rows[0]["TimeOne"].ToString().Trim() == string.Empty)
        //                return false;
        //            else
        //                return true;
        //        }
        //        return false;
        //    }
        //}
    }
}
