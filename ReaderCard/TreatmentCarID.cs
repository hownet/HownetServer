using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class TreatmentCarID
    {
        private static DateTime dt;
        private static string mes = string.Empty;
        private string CarIDstr;
        private static Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
        private int TypeID = 0;
        private int _depotID = ReaderCard.BasicTable.DefaultDepot;
        private int _comTypeID = 0;

        private Hownet.BLL.OrderingList bllOL = new Hownet.BLL.OrderingList();
        private Hownet.Model.OrderingList modOL = new Hownet.Model.OrderingList();
        private Hownet.BLL.SysTem bllST = new Hownet.BLL.SysTem();
       // private Hownet.Model.SysTem modST = BasicTable.modST;
        public TreatmentCarID(string CarID)
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
                    string[] ss = CarIDstr.Split('+');
                    if (ss[1].Length > 3 && CarIDstr.IndexOf("*") == -1)//是刷卡信息
                    {

                        int crID = FindNID(ss[0]);
                        if (crID > 0)
                        {
                            TypeID = Convert.ToInt32(ReaderCard.BasicTable.dtCarReaderList.Select("(ID=" + crID + ")")[0]["TypeID"]);
                            if (TypeID == 1)
                            {
                                TreatmentAttendance ta = new TreatmentAttendance(ss[0], ss[1]);
                                return ta.TrAtt();
                            }
                            else if (TypeID == 2)
                            {
                                TreatmentInDepot(int.Parse(ss[0]), int.Parse(ss[1]));
                            }
                            else if (TypeID == 3)
                            {
                                Ordering(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                                return mes;
                            }
                            else if (TypeID == 4)
                            {
                                Dining(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                                return mes;
                            }
                            else if (TypeID == 5)
                            {
                                return OpenDoor.OpenDooring(Convert.ToInt32(ss[0]), Convert.ToInt32(ss[1]));
                            }
                        }
                        else
                        {
                            FindEmpCard(int.Parse(ss[0]), int.Parse(ss[1]));
                            return mes;
                        }
                    }
                    #region 按键信息
                    else//
                    {
                        if (CarIDstr.IndexOf('*') > -1)
                        {
                            string[] t = CarIDstr.Split('+');
                            string sss = t[1].Remove(0, _comTypeID);
                            sss = sss.Remove(sss.Length - 1, 1);
                            if (sss.IndexOf("*") == -1)
                            {
                                int crID = FindNID(t[0]);
                                if (crID > 0)
                                {
                                    TypeID = Convert.ToInt32(ReaderCard.BasicTable.dtCarReaderList.Select("(ID=" + crID + ")")[0]["TypeID"]);
                                    if (TypeID == 1)
                                    {

                                    }
                                    else if (TypeID == 2)
                                    {
                                        //if (ReaderCard.BasicTable.dtCarReaderList.Rows.Count > 0)
                                        //{
                                        //    _depotID = Convert.ToInt32(ReaderCard.BasicTable.dtCarReaderList.Select("(NID=" + Convert.ToInt32(t[0]) + ")")[0]["Location"]);
                                        //}
                                        return InDepot.InDepotAmount(Convert.ToInt32(sss), Convert.ToInt32(t[0]), _depotID);
                                    }
                                    else if (TypeID == 4)
                                    {
                                        DiningKey(Convert.ToInt32(t[0]), Convert.ToInt32(sss));
                                        return mes;
                                    }
                                }
                                else
                                {
                                    #region 只有一个*的按键信息，主要是工序号的移动
                                    int a = int.Parse(sss);
                                    if (a == 0)
                                    {
                                        DataRow[] drs = BasicTable.dtMain.Select("(No=" + t[0] + ")");
                                        if (drs.Length > 0)
                                        {
                                            if (Convert.ToInt32(drs[0]["WorkingList"]) > -1)
                                            {

                                                DataRow[] drsEW = BasicTable.dtEmpWorkList.Select("(EmployeeID=" + drs[0]["EmployeeID"] + ")");
                                                int rr = Convert.ToInt32(drs[0]["WorkingList"]);
                                                if (drsEW.Length > rr)
                                                {
                                                    ReturnStr(0, int.Parse(t[0]), GetSendOneString(drsEW[rr][2].ToString() + " " + drsEW[rr][4].ToString()) + drsEW[rr][3].ToString());
                                                }
                                                else
                                                {

                                                    ReturnStr(2, int.Parse(t[0]), "没有记录");
                                                    return mes;
                                                }
                                                drs[0]["WorkingList"] = Convert.ToInt32(drs[0]["WorkingList"]) + 1;
                                                return mes;
                                            }
                                        }
                                    }
                                    return MoveWorking.MoveWorkingID(int.Parse(t[0]), a);
                                    //return mes;
                                    #endregion
                                }
                            }
                            else
                            {
                                ss = sss.Split('*');//string[]
                                int cou = ss.Length;
                                string mesg = string.Empty;
                                DataRow[] drs = BasicTable.dtMain.Select("(No=" + t[0] + ")");
                                if (drs.Length > 0)
                                {
                                    #region//货物相关查询
                                    if (drs[0]["CardID"].ToString() != "0" && ss[0] == "0")
                                    {
                                        int workID = 0, sizeID = 0, colorID = 0;
                                        try
                                        {
                                            workID = int.Parse(ss[1]);
                                            sizeID = int.Parse(ss[2]);
                                            colorID = int.Parse(ss[3]);
                                        }
                                        catch { };
                                        DataTable ttt = BasicTable.bllWTI.GetKey(int.Parse(drs[0]["TicketID"].ToString()), workID, sizeID, colorID).Tables[0];
                                        DataRow[] ddrs = ttt.Select(" (WorkingID =" + workID + ") ");
                                        if (ddrs.Length > 0)
                                        {
                                            if (sizeID == 0 && colorID == 0)
                                            {
                                                mesg = ddrs[0]["WorkingName"].ToString();//ddrs[0]["Orders"].ToString() + 
                                                int l = 15 - gb.GetByteCount(mesg);
                                                if (l > 0)
                                                {
                                                    for (int i = 0; i < l; i++)
                                                    {
                                                        mesg = mesg + " ";
                                                    }
                                                }
                                                if (ddrs[0]["EmployeeName"].ToString() != "")
                                                    mesg = mesg + ddrs[0]["EmployeeName"].ToString();
                                                else
                                                    mesg = mesg + "该工序无人完成";
                                                ReturnStr(0, int.Parse(t[0]), mesg);
                                                return mes;
                                            }
                                        }
                                        else
                                        {
                                            ReturnStr(2, int.Parse(t[0]), "没有这道工序");
                                            return mes;
                                        }

                                    }
                                    #endregion
                                    #region //员工相关查询
                                    else if (drs[0]["EmployeeID"].ToString() != "0" && ss[0] == "1")
                                    {
                                        int employeeID = int.Parse(drs[0]["EmployeeID"].ToString());
                                        int typeID = int.Parse(ss[1]);
                                        if (typeID == 0 || typeID > 2)
                                        {
                                            ReturnStr(0, int.Parse(t[0]), "指令错误！");
                                            return mes;
                                        }
                                        mesg = drs[0]["EmployeeName"].ToString();
                                        if (typeID == 1)
                                        {
                                            mesg = mesg + " 今天";
                                            if (Convert.ToInt32(drs[0]["WorkingList"]) == -1)
                                            {
                                                DataRow[] drsEW = BasicTable.dtEmpWorkList.Select("(EmployeeID=" + drs[0]["EmployeeID"] + ")");
                                                if (drsEW.Length > 0)
                                                {
                                                    for (int rrr = 0; rrr < drsEW.Length; rrr++)
                                                    {
                                                        drsEW[rrr].Delete();
                                                    }
                                                    BasicTable.dtEmpWorkList.AcceptChanges();
                                                }
                                                DataTable dtTem = BasicTable.bllWTIDC.GetEmpWork(Convert.ToInt32(drs[0]["EmployeeID"])).Tables[0];
                                                for (int i = 0; i < dtTem.Rows.Count; i++)
                                                {
                                                    BasicTable.dtEmpWorkList.Rows.Add(dtTem.Rows[i].ItemArray);
                                                }
                                                drs[0]["WorkingList"] = 0;
                                            }
                                        }
                                        else
                                        {
                                            mesg = mesg + " 本月";
                                        }
                                        int l = 15 - gb.GetByteCount(mesg);
                                        if (l > 0)
                                        {
                                            for (int i = 0; i < l; i++)
                                            {
                                                mesg = mesg + " ";
                                            }
                                        }
                                        mesg = mesg + BasicTable.bllWTI.GetEmployee(employeeID, typeID, dt, ReaderCard.BasicTable.IsShowMoney).ToString();
                                        ReturnStr(0, int.Parse(t[0]), mesg);
                                        return mes;
                                    }
                                    #endregion
                                    #region 入库数量
                                    else if (Convert.ToInt32(drs[0]["EmployeeID"]) > 0 && Convert.ToInt32(ss[0]) == 2)
                                    {
                                        if (ss[1].Length == 0)
                                        {
                                            ReturnStr(0, int.Parse(t[0]), "入库数量错误！");
                                            return mes;
                                        }
                                        return InDepot.InDepotAmount(Convert.ToInt32(ss[1]), Convert.ToInt32(t[0]), _depotID);
                                        // return mes;
                                    }
                                    //修改当前及后续工序的数量
                                    else if (Convert.ToInt32(drs[0]["EmployeeID"]) == 0 && Convert.ToInt32(ss[0]) == 3)
                                    {
                                        if (ss[1].Length == 0)
                                        {
                                            ReturnStr(0, int.Parse(t[0]), "数量错误！");
                                            return mes;
                                        }
                                        return EditAmount.EditWorkAmount(Convert.ToInt32(ss[1]), Convert.ToInt32(t[0]), Convert.ToInt32(drs[0]["GroupBy"]));
                                        // return mes;
                                    }
                                    #endregion
                                    else
                                    {
                                        ReturnStr(0, int.Parse(t[0]), "指令错误！");
                                        return mes;
                                    }

                                }
                                else
                                {
                                    ReturnStr(0, int.Parse(t[0]), "无相关卡号记录!");
                                    return mes;
                                }
                            }
                        }
                        else
                        {
                            CarIDstr = CarIDstr.Replace("\r", string.Empty);
                            CarIDstr = CarIDstr.Replace("#", string.Empty);
                            ss = CarIDstr.Split('+');
                            DataRow[] drs = BasicTable.dtMain.Select("(No=" + ss[0] + ")");
                            if (drs.Length > 0)
                            {
                                if ((drs[0]["WorkingID"] == DBNull.Value || drs[0]["WorkingID"].ToString() == string.Empty || Convert.ToInt32(drs[0]["WorkingID"]) == 0)&&Convert.ToInt32( drs[0]["WorkingList"])>-1) //没有工序，则为员工卡
                                {
                                    
                                    int typeID = Convert.ToInt32(ss[1]);
                                    int employeeID = int.Parse(drs[0]["EmployeeID"].ToString());
                                    if (typeID == 0 || typeID > 2)
                                    {
                                        ReturnStr(2, int.Parse(ss[0]), "指令错误！");
                                        return mes;
                                    }
                                    string mesg = drs[0]["EmployeeName"].ToString();

                                    mesg = drs[0]["EmployeeName"].ToString();
                                    if (typeID == 1)
                                    {
                                        mesg = mesg + " 今天";
                                        if (Convert.ToInt32(drs[0]["WorkingList"]) == -1)
                                        {
                                            DataRow[] drsEW = BasicTable.dtEmpWorkList.Select("(EmployeeID=" + drs[0]["EmployeeID"] + ")");
                                            if (drsEW.Length > 0)
                                            {
                                                for (int rrr = 0; rrr < drsEW.Length; rrr++)
                                                {
                                                    drsEW[rrr].Delete();
                                                }
                                                BasicTable.dtEmpWorkList.AcceptChanges();
                                            }
                                            DataTable dtTem = BasicTable.bllWTIDC.GetEmpWork(Convert.ToInt32(drs[0]["EmployeeID"])).Tables[0];
                                            for (int i = 0; i < dtTem.Rows.Count; i++)
                                            {
                                                BasicTable.dtEmpWorkList.Rows.Add(dtTem.Rows[i].ItemArray);
                                            }
                                            drs[0]["WorkingList"] = 0;
                                        }
                                    }
                                    else
                                    {
                                        mesg = mesg + " 本月";
                                    }
                                    int l = 15 - gb.GetByteCount(mesg);
                                    if (l > 0)
                                    {
                                        for (int i = 0; i < l; i++)
                                        {
                                            mesg = mesg + " ";
                                        }
                                    }
                                    mesg = mesg + BasicTable.bllWTI.GetEmployee(employeeID, typeID, dt, ReaderCard.BasicTable.IsShowMoney).ToString();
                                    ReturnStr(0, int.Parse(ss[0]), mesg);
                                    return mes;
                                }
                                else
                                {
                                    #region 只有一个*的按键信息，主要是工序号的移动
                                    int a = int.Parse(ss[1]);
                                    if (a == 0)
                                    {
                                         drs = BasicTable.dtMain.Select("(No=" + ss[0] + ")");
                                        if (drs.Length > 0)
                                        {
                                            if (Convert.ToInt32(drs[0]["WorkingList"]) > -1)
                                            {

                                                DataRow[] drsEW = BasicTable.dtEmpWorkList.Select("(EmployeeID=" + drs[0]["EmployeeID"] + ")");
                                                int rr = Convert.ToInt32(drs[0]["WorkingList"]);
                                                if (drsEW.Length > rr)
                                                {
                                                    ReturnStr(0, int.Parse(ss[0]), GetSendOneString(drsEW[rr][2].ToString() + " " + drsEW[rr][4].ToString()) + drsEW[rr][3].ToString());
                                                }
                                                else
                                                {

                                                    ReturnStr(2, int.Parse(ss[0]), "没有记录");
                                                    return mes;
                                                }
                                                drs[0]["WorkingList"] = Convert.ToInt32(drs[0]["WorkingList"]) + 1;
                                                return mes;
                                            }
                                        }
                                    }
                                    return MoveWorking.MoveWorkingID(int.Parse(ss[0]), a);
                                    //return mes;
                                    #endregion
                                }
                            }
                            else
                            {
                                ReturnStr(0, int.Parse(ss[0]), "无相关卡号记录!");
                                return mes;
                            }
                        }
                    }
                   
                    #endregion
                }
                return mes;
            }
            catch (Exception ex)
            {
                string[] ss = CarIDstr.Split('+');
                return "2," + ss[0] + ","+ex.ToString();
            }
        }
        /// <summary>
        /// 就餐机按键
        /// </summary>
        /// <param name="NID">机器号</param>
        /// <param name="Key">按键指令</param>
        private void DiningKey(int NID, int Key)
        {
            if (Key == 0 || Key > 3)
            {
                ReturnStr(2, NID, "指令错误!");
                return;
            }
            else
            {
                Hownet.BLL.OrderingList bllOL = new Hownet.BLL.OrderingList();
                DataTable dtorder=bllOL.GetOrderCount(DateTime.Today.AddDays(1).AddSeconds(-1),DateTime.Today.AddDays(2),0).Tables[0];
                if (dtorder.Rows.Count > 0)
                {
                    if (Key == 1)
                    {
                        mes = GetSendOneString("明日早餐共需：");
                        mes = mes + dtorder.Rows[0]["OrderOne"].ToString() + "份";
                        ReturnStr(2, NID, mes);
                        return;
                    }
                    else if (Key == 2)
                    {
                        mes = GetSendOneString("明日午餐共需：");
                        mes = mes + dtorder.Rows[0]["OrderTwo"].ToString() + "份";
                        ReturnStr(2, NID, mes);
                        return;
                    }
                    else if (Key == 3)
                    {
                        mes = GetSendOneString("明日晚餐共需：");
                        mes = mes + dtorder.Rows[0]["OrderThree"].ToString() + "份";
                        ReturnStr(2, NID, mes);
                        return;
                    }
                }
            }
        }
        /// <summary>
        /// 就餐
        /// </summary>
        /// <param name="NID">机器号</param>
        /// <param name="CID">ID卡号</param>
        private void Dining(int NID, int CID)
        {
            int t = 0;
            DataRow[] drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CID + ")");//是否有对应员工，没有就再次查询数据库，以添加新员工，如仍没有，见则转为查询是否为箱头卡
            if (drEm.Length == 0)
            {
                mes = "非正常的员工卡!";
                ReturnStr(2, NID, mes);
                return;
            }
            int olTypeID = GetTypeID();
            DataTable dtOL = bllOL.GetList("(EmployeeID=" + drEm[0]["ID"] + ") And (DateTime='" + DateTime.Today + "')").Tables[0];
            if (dtOL.Rows.Count == 0)
            {
                modOL = new Hownet.Model.OrderingList();
                modOL.EmployeeID = Convert.ToInt32(drEm[0]["ID"]);
                modOL.DateTime = DateTime.Today;
                t = 3;
                if (olTypeID == 1)
                {
                    modOL.DinOne = 1;
                    modOL.OrderOne = modOL.OrderTwo = modOL.DinTwo = modOL.OrderThree = modOL.DinThree = 0;
                    modOL.DiningOneTime = DateTime.Now;
                    modOL.OrderOneTime = modOL.OrdeTwoTime = modOL.DiningTwoTime = modOL.OrdeThreeTime = modOL.DiningThreeTime = DateTime.Parse("1900-1-1");
                    modOL.OrderCount = 0;
                    modOL.DinCount = 1;
                }
                else if (olTypeID == 2)
                {
                    modOL.DinTwo = 1;
                    modOL.DinOne = modOL.OrderOne = modOL.OrderTwo = modOL.OrderThree = modOL.DinThree = 0;
                    modOL.DiningTwoTime = DateTime.Now;
                    modOL.DiningOneTime = modOL.OrderOneTime = modOL.OrdeTwoTime = modOL.OrdeThreeTime = modOL.DiningThreeTime = DateTime.Parse("1900-1-1");
                    modOL.OrderCount = 0;
                    modOL.DinCount = 1;
                }
                else if (olTypeID == 3 || olTypeID == 4)
                {
                    modOL.DinThree = 1;
                    modOL.DinOne = modOL.OrderOne = modOL.DinTwo = modOL.OrderTwo = modOL.OrderThree = 0;
                    modOL.DiningThreeTime = DateTime.Now;
                    modOL.DiningOneTime = modOL.OrderOneTime = modOL.DiningTwoTime = modOL.OrdeTwoTime = modOL.OrdeThreeTime = DateTime.Parse("1900-1-1");
                    modOL.OrderCount = 0;
                    modOL.DinCount = 1;
                }
                bllOL.Add(modOL);
            }
            else
            {
                modOL = bllOL.GetModel(Convert.ToInt32(dtOL.Rows[0]["ID"]));
                if (olTypeID == 1)
                {
                    if (modOL.DinOne == 0)
                    {
                        modOL.DinOne = 1;
                        modOL.DiningOneTime = DateTime.Now;
                        t = 1;
                        if (modOL.OrderOne == 0)
                        {
                            t = 3;
                        }
                    }
                }
                else if (olTypeID == 2)
                {
                    if (modOL.DinTwo == 0)
                    {
                        modOL.DinTwo = 1;
                        modOL.DiningTwoTime = DateTime.Now;
                        t = 1;
                        if (modOL.OrderTwo == 0)
                        {
                            t = 3;
                        }
                    }
                }
                else if (olTypeID == 3 || olTypeID == 4)
                {
                    if (modOL.DinThree == 0)
                    {
                        modOL.DinThree = 1;
                        modOL.DiningThreeTime = DateTime.Now;
                        t = 1;
                        if (modOL.OrderThree == 0)
                        {
                            t = 3;
                        }
                    }
                }
            }
            mes = drEm[0]["Name"].ToString();
            int l = 15 - gb.GetByteCount(mes);
            if (l > 0)
            {
                for (int i = 0; i < l; i++)
                {
                    mes = mes + " ";
                }
            }
            if (t == 1 || t == 3)
            {
                modOL.DinCount += 1;
                bllOL.Update(modOL);
            }
            if (t == 1)
            {
                mes = mes + BasicTable.就餐成功;
                ReturnStr(2, NID, mes);
            }
            else if (t == 0)
            {
                mes = mes + BasicTable.重复就餐;
                ReturnStr(3, NID, mes);
            }
            else if (t == 3)
            {
                mes = mes + BasicTable.未订吃饭;
                ReturnStr(3, NID, mes);
            }
        }
        /// <summary>
        /// 处理订餐
        /// </summary>
        /// <param name="NID">机器号</param>
        /// <param name="CID">ID卡号</param>
        private void Ordering(int NID, int CID)
        {
            bool t = false;
            DataRow[] drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CID + ")");//是否有对应员工，没有就再次查询数据库，以添加新员工，如仍没有，见则转为查询是否为箱头卡
            if (drEm.Length == 0)
            {
                mes = "非正常的员工卡!";
                ReturnStr(2, NID, mes);
                return;
            }
            int olTypeID = GetTypeID();
            if (olTypeID < 4)
            {
                DataTable dtOL = new DataTable();
                if (BasicTable.modST.OderOne > BasicTable.modST.OderThree && olTypeID == 1)
                    dtOL = bllOL.GetList("(EmployeeID=" + drEm[0]["ID"] + ") And (DateTime='" + DateTime.Today.AddDays(BasicTable.modST.OrderDays + 1) + "')").Tables[0];
                else
                    dtOL = bllOL.GetList("(EmployeeID=" + drEm[0]["ID"] + ") And (DateTime='" + DateTime.Today.AddDays(BasicTable.modST.OrderDays) + "')").Tables[0];
                if (dtOL.Rows.Count == 0)
                {
                    modOL = new Hownet.Model.OrderingList();
                    modOL.EmployeeID = Convert.ToInt32(drEm[0]["ID"]);
                    modOL.DateTime = DateTime.Today.AddDays(BasicTable.modST.OrderDays);
                    if (olTypeID == 1)
                    {
                        if (BasicTable.modST.OderOne > BasicTable.modST.OderThree)
                            modOL.DateTime = DateTime.Today.AddDays(BasicTable.modST.OrderDays+1);
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
                mes = drEm[0]["Name"].ToString() + "  预订";
                int l = 15 - gb.GetByteCount(mes);
                if (l > 0)
                {
                    for (int i = 0; i < l; i++)
                    {
                        mes = mes + " ";
                    }
                }
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
            ReturnStr(2, NID, mes);
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
                else if ( hh == 0)
                    a = 4;
            }
            return a;
        }
        private void TreatmentInDepot(int NID, int CID)
        {
            if (ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ")").Length == 0)//ReaderCard.BasicTable.dtWTCard表中如果没有这张卡的信息，就查询数据库，如果查询到有记录，将查询出的记录追加到ReaderCard.BasicTable.dtWTCard中，如果没有记录，则判断本次刷卡为无效卡
            {
                DataTable dtt = BasicTable.bllWTIDC.GetAllListByCardID(CID).Tables[0];
                if (dtt.Rows.Count == 0)
                {
                    ReturnStr(2, NID, "错误的卡号！");
                    DataRow[] drs = BasicTable.dtMain.Select("(No=" + NID + ") ");
                    if (drs.Length > 0)
                    {
                        drs[0].Delete();
                        BasicTable.dtMain.AcceptChanges();
                    }
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
            TreatmentWtickCard(NID, CID);
        }
        /// <summary>
        /// 移动工序
        /// </summary>
        /// <param name="CID">按键指令</param>
        /// <param name="NID">机器号</param>
        private void MoveWorkingID(int NID, int CID)
        {
            ////if (CID != 2 && CID != 8)
            ////{
            ////    ReturnStr(2, NID, "指令错误       2为向前8为向后");
            ////    return;
            ////}

            //DataRow[] drs;
            //string _workingName = string.Empty;
            //drs = BasicTable.dtMain.Select("(No=" + NID + ") ");//查找箱头卡刷卡记录
            //if (drs.Length == 0)
            //{
            //    ReturnStr(2, NID, "没有箱号记录");
            //    return;
            //}
            //else
            //{
            //    DataRow[] ddrs = BasicTable.dtWTCard.Select("(IDCardNo='" + drs[0]["CardID"] + "') ", "Orders");
            //    if (ddrs.Length > 0)
            //    {
            //        if (Convert.ToInt32(drs[0]["InfoID"]) == 0)//主表记录InfoID为0时，显示该箱最后一条记录。
            //        {
            //            drs[0]["InfoID"] = ddrs[ddrs.Length - 1]["InfoID"];
            //            drs[0]["WorkingID"] = ddrs[ddrs.Length - 1]["WorkingID"];
            //            drs[0]["WorkingName"] = _workingName = ddrs[ddrs.Length - 1]["WorkingName"].ToString();
            //            drs[0]["EmployeeID"] = ddrs[ddrs.Length - 1]["EmployeeID"];
            //            drs[0]["WorkingName"] = ddrs[ddrs.Length - 1]["WorkingName"];
            //            drs[0]["WorkTypeID"] = ddrs[ddrs.Length - 1]["WorkTypeID"];
            //            ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[ddrs.Length - 1]["MiniEmpName"].ToString());
            //            return;
            //        }
            //        else
            //        {
            //            if (CID == 2 || CID == 8)
            //            {
            //                for (int i = 0; i < ddrs.Length; i++)
            //                {
            //                    if (ddrs[i]["InfoID"].Equals(drs[0]["InfoID"]))//循环到当前主表保存的工序，再做调整
            //                    {
            //                        if (CID == 2)
            //                        {
            //                            if (i > 0)
            //                            {
            //                                drs[0]["InfoID"] = ddrs[i - 1]["InfoID"];
            //                                drs[0]["WorkingID"] = ddrs[i - 1]["WorkingID"];
            //                                drs[0]["WorkingName"] = _workingName = ddrs[i - 1]["WorkingName"].ToString();
            //                                drs[0]["EmployeeID"] = ddrs[i - 1]["EmployeeID"];
            //                                drs[0]["WorkingName"] = ddrs[i - 1]["WorkingName"];
            //                                drs[0]["WorkTypeID"] = ddrs[i - 1]["WorkTypeID"];
            //                                ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[i - 1]["MiniEmpName"].ToString());
            //                                return;
            //                            }
            //                            else
            //                            {
            //                                ReturnStr(2, NID, "已是第一道工序");
            //                                return;
            //                            }
            //                        }
            //                        else if (CID == 8)
            //                        {
            //                            if (i < (ddrs.Length - 1))
            //                            {
            //                                drs[0]["InfoID"] = ddrs[i + 1]["InfoID"];
            //                                drs[0]["WorkingID"] = ddrs[i + 1]["WorkingID"];
            //                                drs[0]["WorkingName"] = _workingName = ddrs[i + 1]["WorkingName"].ToString();
            //                                drs[0]["EmployeeID"] = ddrs[i + 1]["EmployeeID"];
            //                                drs[0]["WorkingName"] = ddrs[i + 1]["WorkingName"];
            //                                drs[0]["WorkTypeID"] = ddrs[i + 1]["WorkTypeID"];
            //                                ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[i + 1]["MiniEmpName"].ToString());
            //                                return;
            //                            }
            //                            else
            //                            {
            //                                ReturnStr(2, NID, "已是最后的工序");
            //                                return;
            //                            }
            //                        }
            //                        else
            //                        {
            //                            if (i < (ddrs.Length - 1))
            //                            {
            //                                int a = 0;
            //                                if ((i + CID) < ddrs.Length - 1)
            //                                {
            //                                    a = i + CID;
            //                                }
            //                                else
            //                                {
            //                                    a = ddrs.Length - 1;
            //                                }
            //                                drs[0]["InfoID"] = ddrs[a]["InfoID"];
            //                                drs[0]["WorkingID"] = ddrs[a]["WorkingID"];
            //                                drs[0]["WorkingName"] = _workingName = ddrs[a]["WorkingName"].ToString();
            //                                drs[0]["EmployeeID"] = ddrs[a]["EmployeeID"];
            //                                drs[0]["WorkingName"] = ddrs[a]["WorkingName"];
            //                                drs[0]["WorkTypeID"] = ddrs[a]["WorkTypeID"];
            //                                ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[a]["MiniEmpName"].ToString());
            //                                return;
            //                            }
            //                            else
            //                            {
            //                                ReturnStr(2, NID, "已是最后的工序");
            //                                return;
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //            else
            //            {

            //            }
            //        }
            //    }
            //    else
            //    {
            //        ReturnStr(2, NID, "没有箱号记录");
            //        return;
            //    }
            //}

        }
        /// <summary>
        /// 刷卡时，查找是否为箱头卡
        /// </summary>
        /// <param name="CID">卡号ID</param>
        /// <param name="NID">机器号</param>
        private void FindWtickCard(int NID, int CID)
        {
            if (ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ")").Length == 0)//ReaderCard.BasicTable.dtWTCard表中如果没有这张卡的信息，就查询数据库，如果查询到有记录，将查询出的记录追加到ReaderCard.BasicTable.dtWTCard中，如果没有记录，则判断本次刷卡为无效卡
            {
                DataTable dtt = BasicTable.bllWTIDC.GetAllListByCardID(CID).Tables[0];
                if (dtt.Rows.Count == 0)
                {
                    ReturnStr(2, NID, "错误的卡号！");
                    DataRow[] drs = BasicTable.dtMain.Select("(No=" + NID + ") ");
                    if (drs.Length > 0)
                    {
                        drs[0].Delete();
                        BasicTable.dtMain.AcceptChanges();
                    }
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
            TreatmentWtickCard(NID, CID);
            return;
        }
        /// <summary>
        /// 是箱头卡时，处理刷卡信息
        /// </summary>
        /// <param name="NID"></param>
        /// <param name="CID"></param>
        private void TreatmentWtickCard(int NID, int CID)
        {
            DataRow[] drs;
            string ttt = string.Empty;
            string workName = string.Empty;
            int _employeeID = 0;
            int _infoID = 0;
            int _workingID = 0;
            drs = BasicTable.dtMain.Select("(No=" + NID + ")");//dtMain表中删除此前有关这台卡机的刷卡记录
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
            ttt = drs[0]["MaterielName"].ToString() + drs[0]["SizeName"].ToString() + drs[0]["ColorName"].ToString();
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
            //else
            //{
            //    if (TypeID == 0)
            //    {
            //        _employeeID = -1;
            //        ttt = ttt + "所有工序已完成！";
            //    }
            //    else if (TypeID == 2)//该箱货工序都完成时，直接入库至相应仓库
            //    {
            //        InDepot(-1, NID);
            //        ttt = ttt + ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ")", "Orders")[0]["Amount"].ToString();
            //    }
            //}

            DataRow dr = BasicTable.dtMain.NewRow();//将本次刷卡信息添加进dtMain表中。
            dr["ID"] = drs[0]["ID"];
            dr["CardID"] = CID;
            dr["No"] = NID;
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
            dr["WorkingList"] = -1;
            BasicTable.dtMain.Rows.Add(dr);
            if (ddrs.Length == 0)
            {
                if (TypeID == 0)
                {
                    _employeeID = -1;
                    ttt = ttt + "所有工序已完成！";
                }
                else if (TypeID == 2)//该箱货工序都完成时，直接入库至相应仓库
                {

                    mes = InDepot.InDepotAmount(-1, NID, _depotID);
                    ttt = ttt + ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ")", "Orders")[0]["Amount"].ToString();
                }
            }
            ReturnStr(0, NID, ttt);
            return;
        }
        ///// <summary>
        ///// 入库处理
        ///// </summary>
        ///// <param name="Amount">入库数量，工序全部完成自动入库时，设置为-1</param>
        ///// <param name="NID">机器号</param>
        //private void InDepot(int Amount, int NID)
        //{
        //    DataRow[] drsMain = BasicTable.dtMain.Select("(No=" + NID + ")");
        //    if (drsMain.Length == 0)
        //    {
        //        ReturnStr(0, NID, "无相关记录");
        //        return;
        //    }
        //    bool t = false;
        //    Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();//有当前卡机的刷卡记录，读出相应分箱记录
        //    DataTable dttWT = bllWT.GetInDepotList(Convert.ToInt32(drsMain[0]["TicketID"])).Tables[0];
        //    List<Hownet.Model.WorkTicket> liWT = bllWT.DataTableToList(dttWT);
            
        //    if (liWT[0].P2DInfoID > 0 && Amount == -1)
        //    {
        //        ReturnStr(0, NID, "本箱已入库");
        //        return;
        //    }
        //    //if (Amount == -1)
        //    //{
                
        //    //}
        //    #region 记入入库明细
        //    DataTable dtP2D = new DataTable();
        //    if (Amount == -1)
        //    {
        //        dtP2D = bllP2D.GetList("(DateTime='" + DateTime.Today + "') And (IsVerify=4) And (DepotID=" + _depotID + ")").Tables[0];
        //        if (dtP2D.Rows.Count == 0)//查出当天已审核的该仓库入库表
        //        {
        //            modP2D = new Hownet.Model.Product2Depot();
        //            modP2D.DateTime = DateTime.Today;
        //            modP2D.Num = bllP2D.NewNum(modP2D.DateTime);
        //            modP2D.DepotID = _depotID;
        //            modP2D.IsVerify = 4;
        //            modP2D.VerifyMan = 0;
        //            modP2D.VerifyDate = modP2D.DateTime;
        //            modP2D.UpData = 1;
        //            modP2D.A = 1;
        //            modP2D.Remark = "";
        //            modP2D.ID = bllP2D.Add(modP2D);
        //            dtP2D = bllP2D.GetList("(ID=" + modP2D.ID + ")").Tables[0];
        //        }
        //    }
        //    if (liWT[0].P2DInfoID > 0)//这箱货已有入库单编号
        //    {
        //        modP2DInfo = bllP2DInfo.GetModel(liWT[0].P2DInfoID);
        //        if (Amount == -1)
        //        {
        //            if (modP2DInfo.MainID == Convert.ToInt32(dtP2D.Rows[0]["ID"]))//这个入库单明细的主表，等于今天的自动入库单编号
        //            {
        //                Amount = Convert.ToInt32(drsMain[0]["Amount"]);
        //                modP2DInfo.Amount = modP2DInfo.Amount - liWT[0].EligibleAmount + Amount;//更新入库数量
        //                bllP2DInfo.Update(modP2DInfo);
        //                t = true;
        //            }
        //            else
        //            {
        //                ReturnStr(0, NID, "已于此前入库");
        //                return;
        //            }
        //        }
        //        else
        //        {
        //            modP2DInfo.Amount = modP2DInfo.Amount - liWT[0].EligibleAmount + Amount;//更新入库数量
        //            bllP2DInfo.Update(modP2DInfo);
        //            t = true;
        //        }
        //    }
        //    else
        //    {
        //        if(Amount==-1)
        //            Amount = Convert.ToInt32(drsMain[0]["Amount"]);
        //        modP2DInfo = new Hownet.Model.Product2DepotInfo();
        //        modP2DInfo.A = modP2DInfo.ID = 0;
        //        modP2DInfo.MainID = Convert.ToInt32(dtP2D.Rows[0]["ID"]);
        //        modP2DInfo.MaterielID = Convert.ToInt32(drsMain[0]["MaterielID"]);
        //        modP2DInfo.ColorID = liWT[0].ColorID;
        //        modP2DInfo.ColorOneID = liWT[0].ColorOneID;
        //        modP2DInfo.ColorTwoID = liWT[0].ColorTwoID;
        //        modP2DInfo.DeparmentID = liWT[0].DepartmentID;
        //        modP2DInfo.SizeID = liWT[0].SizeID;
        //        modP2DInfo.BrandID = liWT[0].BrandID;
        //        modP2DInfo.Remark = "";
        //        modP2DInfo.TaskID = liWT[0].TaskID;
        //        modP2DInfo.Amount = Amount;
        //        modP2DInfo.MListID = liWT[0].MListID;
        //        liWT[0].P2DInfoID = modP2DInfo.ID = bllP2DInfo.Add(modP2DInfo);
        //    }
        //    #endregion
        //    #region 更新库存
        //    try
        //    {
        //        DataTable dtRep = bllRep.GetList("(DepartmentID=" + _depotID + ") And (MListID=" + liWT[0].MListID + ")").Tables[0];
        //        if (dtRep.Rows.Count > 0)
        //        {
        //            modRep = bllRep.GetModel(Convert.ToInt32(dtRep.Rows[0]["ID"]));
        //            if (Amount == -1)
        //            {
        //                modRep.Amount += liWT[0].Amount;
        //            }
        //            else
        //            {
        //                if (t)
        //                {
        //                    modRep.Amount = modRep.Amount - liWT[0].EligibleAmount + Amount;
        //                }
        //                else
        //                {
        //                    modRep.Amount += Amount;
        //                }
        //            }
        //            bllRep.Update(modRep);
        //        }
        //        else
        //        {
        //            Hownet.BLL.Materiel bllMat = new Hownet.BLL.Materiel();
        //            modRep = new Hownet.Model.Repertory();
        //            modRep.ID = modRep.A = 0;
        //            modRep.MListID = liWT[0].MListID;
        //            modRep.MeasureID = bllMat.GetModel(Convert.ToInt32(drsMain[0]["MaterielID"])).MeasureID;
        //            modRep.ColorID = liWT[0].ColorID;
        //            modRep.ColorOneID = liWT[0].ColorOneID;
        //            modRep.ColorTwoID = liWT[0].ColorTwoID;
        //            modRep.SizeID = liWT[0].SizeID;
        //            modRep.BrandID = liWT[0].BrandID;
        //            modRep.CompanyID = 0;
        //            modRep.DepartmentID = _depotID;
        //            modRep.Amount = Amount;
        //            modRep.MaterielID = Convert.ToInt32(drsMain[0]["MaterielID"]);
        //            bllRep.Add(modRep);
        //        }
        //    #endregion

        //        #region 更总生产单在线数量
        //        List<Hownet.Model.AmountInfo> liAI = bllAI.GetModelList("(MainID=" + liWT[0].TaskID + ") And (TableTypeID=1) And (MListID=" + liWT[0].MListID + ")");
        //        if (liAI.Count > 0)
        //        {
        //            if (Amount == -1)
        //            {
        //                liAI[0].NotAmount -= liWT[0].Amount;
        //            }
        //            else
        //            {
        //                if (t)
        //                {
        //                    liAI[0].NotAmount = liAI[0].NotAmount + liWT[0].EligibleAmount - Amount;
        //                }
        //                else
        //                {
        //                    liAI[0].NotAmount -= Amount;
        //                }
        //            }
        //            bllAI.Update(liAI[0]);
        //        }
        //        if (liWT[0].TaskID > 0)
        //        {
        //            liAI = bllAI.GetModelList("(MainID=" + liWT[0].DepartmentID + ") And (TableTypeID=37) And (MListID=" + liWT[0].MListID + ")");
        //            if (liAI.Count > 0)
        //            {
        //                if (Amount == -1)
        //                {
        //                    liAI[0].NotAmount -= liWT[0].Amount;
        //                }
        //                else
        //                {
        //                    if (t)
        //                    {
        //                        liAI[0].NotAmount = liAI[0].NotAmount + liWT[0].EligibleAmount - Amount;
        //                    }
        //                    else
        //                    {
        //                        liAI[0].NotAmount -= Amount;
        //                    }
        //                }
        //                bllAI.Update(liAI[0]);
        //            }
        //        }
        //        #endregion
        //        #region 更新分箱表
        //        liWT[0].EligibleAmount = Amount;
        //        liWT[0].InferiorAmount = liWT[0].Amount - Amount;
        //        liWT[0].P2DInfoID = modP2DInfo.ID;
        //        liWT[0].P2DDepartmentID = _depotID;
        //        bllWT.Update(liWT[0]);
        //        #endregion
        //        if (Amount > 0 && t)
        //        {
        //            for (int i = 0; i < drsMain.Length; i++)
        //            {
        //                drsMain[i].Delete();
        //            }
        //            BasicTable.dtMain.AcceptChanges();
        //        }
               
        //        DataTable dtttt = bllP2D.GetSumAmount(DateTime.Today,modP2DInfo.DeparmentID ).Tables[0];
        //        string ttt = string.Empty;
        //        if (dtttt.Rows.Count > 0)
        //            ttt = dtttt.Rows[0]["Name"].ToString();
        //        int l = 15 - gb.GetByteCount(ttt);
        //        if (l > 0)
        //        {
        //            for (int i = 0; i < l; i++)
        //            {
        //                ttt = ttt + " ";
        //            }
        //        }
        //        ttt += dtttt.Rows[0]["Amount"].ToString();
        //        ReturnStr(0, NID, ttt);
        //    }
        //    catch (Exception ex)
        //    {
        //    }
        //    return;
        //}
        /// <summary>
        /// 刷卡时，查找是否为员工卡
        /// </summary>
        /// <param name="NID"></param>
        /// <param name="CID"></param>
        private void FindEmpCard(int NID, int CID)
        {
            DataRow[] drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CID + ")");//是否有对应员工，没有就再次查询数据库，以添加新员工，如仍没有，见则转为查询是否为箱头卡
            if (drEm.Length == 0)
            {
                //BasicTable.dtEmployee = BasicTable.bllME.GetView().Tables[0];
                //drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CID + ")");
                //if (drEm.Length == 0)
                //{
                    FindWtickCard(NID, CID);
                    return;
                //}
            }
            ////if (!CheckAttend(int.Parse(drEm[0]["ID"].ToString())))
            ////{
            ////    ReturnStr(2, NID, GetSendOneString(drEm[0]["Name"].ToString()) + "上班未考勤");
            ////    return;
            ////}
            //if (IsInDepot(Convert.ToInt32(drEm[0]["ID"])))
            //{
            //    if (ReaderCard.BasicTable.dtCarReaderList.Rows.Count > 0)
            //    {
            //        _depotID = Convert.ToInt32(ReaderCard.BasicTable.dtCarReaderList.Select("(NID=" + NID + ")")[0]["Location"]);
            //    }
            //    _depotID = Convert.ToInt32(drEm[0]["DepartmentID"]);
            //    InDepot(-1, NID);
            //}
            //else
            //{
            //_depotID = Convert.ToInt32(drEm[0]["DepartmentID"]);



            //if (_depotID == 0)
            //{
            //    ReturnStr(2, NID, "请设置员工部门");
            //    return;
            //}



            TreatmentEmpCard(NID, CID, int.Parse(drEm[0]["ID"].ToString()), drEm[0]["Name"].ToString(), drEm[0]["Sn"].ToString());
            //}
        }
        private bool CheckKQ(int EmployeeID)
        {
            DateTime dt = DateTime.Now;
            DataTable dtAR=new DataTable();
            if (dt.Hour < 6)
                dtAR =BasicTable. bllAR.GetList("(EmployeeID=" + EmployeeID + ") And (DateDay='" + dt.Date.AddDays(-1) + "')").Tables[0];
            else
                dtAR =BasicTable. bllAR.GetList("(EmployeeID=" + EmployeeID + ") And (DateDay='" + dt.Date + "')").Tables[0];
            if (dtAR.Rows.Count == 0)
            {
                return false;
            }
            long one = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='One')")[0]["Value"].ToString()).Ticks;
            long two = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='Two')")[0]["Value"].ToString()).Ticks;
            long three = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='Three')")[0]["Value"].ToString()).Ticks;
            long now = dt.Ticks;
            string timeFileds = string.Empty;
            if (now < three)
                timeFileds = "TimeFive";
            else if (now < two)
                timeFileds = "TimeThree";
            else
                timeFileds = "TimeOne";
            try
            {
                DateTime ddt = Convert.ToDateTime(dtAR.Rows[0][timeFileds]);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// 是员工卡时，处理刷卡信息
        /// </summary>
        /// <param name="CID">卡号ID</param>
        /// <param name="NID">机器号</param>
        /// <param name="EmployeeID">员工ID</param>
        /// <param name="EmployeeName">员工姓名</param>
        private void TreatmentEmpCard(int NID, int CID, int EmployeeID, string EmployeeName, string EmployeeSN)
        {
            DataRow[] drs;
            drs = BasicTable.dtMain.Select("(No=" + NID + ") ");//查找该卡机之前的刷卡记录
            if (drs.Length > 0)
            {
                if (int.Parse(drs[0]["EmployeeID"].ToString()) == 0)//有可以记录工资的记录
                {
                    if (((DateTime)(drs[0]["Date"])).AddSeconds(30) > dt)//30秒内刷员工卡
                    {
                        //if (ReaderCard.BasicTable.bllME.GetSumAmountByEMP(EmployeeID))
                        //{
                        //    ReturnStr(2, NID, "超过最大数量！");
                        //    return;
                        //}

                        #region 给员工记工资
                        //DataRow[] dddrs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CID + ") And (EmployeeID>0)", "DateTime DESC");//按完成时间倒序排列，选出最后一次刷卡的时间
                        //if (dddrs.Length > 0)
                        //{
                        //    TimeSpan ts = Min2Hours(int.Parse(dddrs[0]["Amount"].ToString()) * decimal.Parse(dddrs[0]["FastTime"].ToString()));
                        //    DateTime oldTime = (DateTime)(drs[0]["Date"]);
                        //    if (dt < (oldTime.Add(ts)))
                        //    {
                        //        ReturnStr(2, NID, "刷卡间隔太短！");
                        //        return;
                        //    }
                        //}
                        if (BasicTable.IsCheckKQ)
                        {
                            if (!CheckKQ(EmployeeID))
                            {
                                ReturnStr(2, NID, "上班未考勤！");
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
                                ReturnStr(2, NID, "工种不匹配！");
                                return;
                            }
                            decimal fasttime = Convert.ToDecimal(drWT[0]["FastTime"]);
                            if (fasttime > 0)
                            {
                                TimeSpan ts = Min2Hours(int.Parse(drWT[0]["Amount"].ToString()) * fasttime);
                                DateTime oldTime = BasicTable.bllWTI.GetLastDate(EmployeeID);
                                if (dt < (oldTime.Add(ts)))
                                {
                                    ReturnStr(2, NID, "刷卡间隔太短！");
                                    return;
                                }
                            }

                        }
                        int materielid = int.Parse(drs[0]["MaterielID"].ToString());
                        int InfoID = int.Parse(drs[0]["InfoID"].ToString());
                        BasicTable.modWTI = BasicTable.bllWTI.GetModel(InfoID);
                        if (BasicTable.modWTI.EmployeeID > 0)
                        {
                            ReturnStr(0, NID, "工序已被完成");
                            drs[0].Delete();
                            return;
                        }
                        BasicTable.bllWTI.GetBarBack(int.Parse(drs[0]["InfoID"].ToString()), EmployeeID, dt, 1);
                        BasicTable.bllWTI.AddPayInfo(materielid, InfoID, drs[0]["OderNum"].ToString());
                        drs[0]["EmployeeID"] = EmployeeID;
                        drs[0]["EmployeeName"] = EmployeeName;
                        drs[0]["EmpSN"] = EmployeeSN;
                        if ((bool)(drs[0]["IsEnd"]))//只有最后一道工序未完成，当完成之后，在WorkTicketIDCard表中标记
                        {
                            BasicTable.bllWTIDC.UpdateFishWork(int.Parse(drs[0]["ID"].ToString()));
                        }
                        BasicTable.dtMain.AcceptChanges();
                        string ttt = EmployeeSN + " " + EmployeeName;
                        //int l = 15 - gb.GetByteCount(ttt);
                        //if (l > 0)
                        //{
                        //    for (int i = 0; i < l; i++)
                        //    {
                        //        ttt = ttt + " ";
                        //    }
                        //}
                        if (BasicTable.modST.SumByWorking)
                            ttt = ttt + BasicTable.bllWTI.CountAmountByWorking(EmployeeID, dt, ReaderCard.BasicTable.IsShowMoney, BasicTable.modWTI.PWorkingInfoID).ToString();
                        else
                            ttt = ttt + BasicTable.bllWTI.CountAmount(EmployeeID, dt, ReaderCard.BasicTable.IsShowMoney).ToString();
                        ReturnStr(0, NID, ttt);
                        DataRow[] ddrs = ReaderCard.BasicTable.dtWTCard.Select("(InfoID=" + InfoID + ")");
                        if (ddrs.Length > 0)//将ReaderCard.BasicTable.dtWTCard表中相应工序的完成员工、时间修改
                        {
                            ddrs[0]["EmployeeID"] = EmployeeID;
                            ddrs[0]["MiniEmpName"] = EmployeeName;
                            ddrs[0]["EmpSN"] = EmployeeSN;
                            ddrs[0]["DateTime"] = dt;
                            ddrs[0]["InfoID"] = InfoID;
                            drs[0]["Date"] = DateTime.Now;
                        }
                        if (Convert.ToInt32(drs[0]["WorkingID"]) == BasicTable.BackDepotWorkingID)
                        {

                            drs[0]["EmployeeID"] = EmployeeID;
                            drs[0]["EmployeeName"] = EmployeeName;
                            drs[0]["EmpSN"] = EmployeeSN;
                            if (_depotID > 0)
                            { mes = InDepot.InDepotAmount(-1, NID, _depotID); }
                            else
                            {
                                InDepot.UpNotAmount(-1, NID);
                            }
                            return;
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
                        ReturnStr(2, NID, "刷卡超时");
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
                    ReturnStr(0, NID, "所有工序已完成");
                    drs[0].Delete();
                    BasicTable.dtMain.AcceptChanges();
                    return;
                }
                else if (int.Parse(drs[0]["EmployeeID"].ToString()) > 0 && drs[0]["ID"] != null && drs[0]["ID"].ToString().Trim() != string.Empty)
                {
                    ReturnStr(2, NID, "工序已被员工   " + drs[0]["EmployeeName"].ToString() + "完成");
                    drs[0].Delete();
                    BasicTable.dtMain.AcceptChanges();
                    return;
                }
                else if (Convert.ToInt32(drs[0]["EmployeeID"]) == EmployeeID)
                {
                    if (((DateTime)(drs[0]["Date"])).AddSeconds(10) > dt)//10秒内刷员工卡
                    {
                        Ordering(NID, CID);
                        return;
                    }
                }
                for (int i = 0; i < drs.Length; i++)
                {
                    drs[i].Delete();
                }
                BasicTable.dtMain.AcceptChanges();
                DataRow dr = BasicTable.dtMain.NewRow();
                dr["CardID"] = 0;
                dr["No"] = NID;
                dr["Date"] = dt;
                dr["EmployeeID"] = EmployeeID;
                dr["EmployeeName"] = EmployeeName;
                dr["WorkingList"] = -1;
                dr["EmpSN"] = EmployeeSN;
                BasicTable.dtMain.Rows.Add(dr);
                ReturnStr(0, NID, EmployeeSN+EmployeeName);
                return;
            }
            else//此前没有箱头卡记录，则将员工卡记录添加到dtMain表中
            {
                DataRow dr = BasicTable.dtMain.NewRow();
                dr["CardID"] = 0;
                dr["No"] = NID;
                dr["Date"] = dt;
                dr["EmployeeID"] = EmployeeID;
                dr["WorkingList"] = -1;
                dr["EmployeeName"] = EmployeeName;
                dr["EmpSN"] = "";
                dr["EmpSN"] = EmployeeSN;
                BasicTable.dtMain.Rows.Add(dr);
                ReturnStr(0, NID, EmployeeName);
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
            mes = TypeID.ToString() + "," + NID.ToString() + "," + messs;
        }
        /// <summary>
        /// 查找这个机器号是否为特殊机器
        /// </summary>
        /// <param name="Nid"></param>
        /// <returns></returns>
        private int FindNID(string Nid)
        {
            try
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
                        return Convert.ToInt32(drscr[0]["ID"]);
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
            catch
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
