using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Hownet.BLL.BaseFile
{
   public class ProductClass
    {
       //public DataTable ProductStructureList(int companyID, int BrandID,bool HaveNoCom)
       //{
       //    Hownet.BLL.MaterielList bllML = new MaterielList();
       //    Hownet.BLL.Repertory bllRep = new Repertory();
       //    Hownet.BLL.SalesOrderOne bllSOO = new SalesOrderOne();
       //    Hownet.BLL.ProduceTaskMain bllPTM = new ProduceTaskMain();
       //    Hownet.BLL.ChangBrandInfo bllCBI = new ChangBrandInfo();
       //    DataTable dt = new DataTable();
           
       //    bool t = false;
       //    #region 有特定商标的
       //    if (BrandID > 0)
       //    {
       //        dt = bllML.GetFenXi(1, BrandID).Tables[0].Copy();
       //        if (dt.Rows.Count == 0)
       //            return dt;
       //        dt.Columns.Add("Sale", typeof(int));//客户订单
       //        dt.Columns.Add("NotSale", typeof(int));//未发货数量
       //        dt.Columns.Add("Task", typeof(int));//生产制单在线数量
       //        dt.Columns.Add("Rep", typeof(int));//库存数量
       //        dt.Columns.Add("NotAmount", typeof(int));//差数
       //        dt.Columns.Add("NeedTask", typeof(int));//需生产数量
       //        dt.Columns.Add("Chang", typeof(int));//改标未收回
       //        dt.Columns.Add("DepAmount", typeof(int));//未分配数量
       //        DataTable dtSa = bllSOO.GetFenXi(companyID, BrandID).Tables[0];
       //        if (dtSa.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtSa.Rows.Count; r++)
       //                {
       //                    t = false;
       //                    if (dt.DefaultView[i]["MListID"].ToString() == dtSa.DefaultView[r]["MListID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Sale"] = dtSa.Rows[r]["Amount"];
       //                        dt.Rows[i]["NotSale"] = dtSa.Rows[r]["NotAmount"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //        DataTable dtT = bllPTM.GetFenXi(companyID, BrandID,HaveNoCom).Tables[0];
       //        if (dtT.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtT.Rows.Count; r++)
       //                {
       //                    t = false;

       //                    if (dt.DefaultView[i]["MListID"].ToString() == dtT.DefaultView[r]["MListID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Task"] = dtT.Rows[r]["TaskAmount"];
       //                        dt.Rows[i]["DepAmount"] = dtT.Rows[r]["DepAmount"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //        DataTable dtR = bllRep.GetFenXi(1).Tables[0];
       //        if (dtR.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtR.Rows.Count; r++)
       //                {
       //                    t = false;
       //                    if (dt.DefaultView[i]["MListID"].ToString() == dtR.DefaultView[r]["MListID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Rep"] = dtR.Rows[r]["Amount"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //        DataTable dtC = bllCBI.GetNotAmount(BrandID).Tables[0];
       //        if (dtC.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtC.Rows.Count; r++)
       //                {
       //                    t = false;
       //                    if (dt.DefaultView[i]["MListID"].ToString() == dtC.DefaultView[r]["NewMListID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Chang"] = dtC.Rows[r]["Chang"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //    }
       //    #endregion
       //    #region 没有指定商标，将不区分商标，全部一起计算
       //    else
       //    {
       //        dt = bllML.GetMaterielNoBrand().Tables[0];
       //        dt.Columns.Add("Sale", typeof(int));//客户订单
       //        dt.Columns.Add("NotSale", typeof(int));//未发货数量
       //        dt.Columns.Add("Task", typeof(int));//生产制单在线数量
       //        dt.Columns.Add("Rep", typeof(int));//库存数量
       //        dt.Columns.Add("NotAmount", typeof(int));//差数
       //        dt.Columns.Add("NeedTask", typeof(int));//需生产数量
       //        dt.Columns.Add("Chang", typeof(int));//改标未收回
       //        dt.Columns.Add("DepAmount", typeof(int));//未分配数量
       //        if (dt.Rows.Count == 0)
       //            return dt;
       //        DataTable dtS = bllSOO.GetFenXi(companyID, BrandID).Tables[0];
       //        if (dtS.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtS.Rows.Count; r++)
       //                {
       //                    t = false;
       //                    if (dt.DefaultView[i]["MaterielID"].ToString() == dtS.DefaultView[r]["MaterielID"].ToString() &&
       //                        dt.DefaultView[i]["ColorID"].ToString() == dtS.DefaultView[r]["ColorID"].ToString() &&
       //                        dt.DefaultView[i]["ColorOneID"].ToString() == dtS.DefaultView[r]["ColorOneID"].ToString() &&
       //                        dt.DefaultView[i]["ColorTwoID"].ToString() == dtS.DefaultView[r]["ColorTwoID"].ToString() &&
       //                        dt.DefaultView[i]["SizeID"].ToString() == dtS.DefaultView[r]["SizeID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Sale"] = dtS.Rows[r]["Amount"];
       //                        dt.Rows[i]["NotSale"] = dtS.Rows[r]["NotAmount"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //        DataTable dtT = bllPTM.GetFenXi(companyID, BrandID,HaveNoCom).Tables[0];
       //        if (dtT.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtT.Rows.Count; r++)
       //                {
       //                    t = false;
       //                    if (dt.DefaultView[i]["MaterielID"].ToString() == dtT.DefaultView[r]["MaterielID"].ToString() &&
       //                        dt.DefaultView[i]["ColorID"].ToString() == dtT.DefaultView[r]["ColorID"].ToString() &&
       //                        dt.DefaultView[i]["ColorOneID"].ToString() == dtT.DefaultView[r]["ColorOneID"].ToString() &&
       //                        dt.DefaultView[i]["ColorTwoID"].ToString() == dtT.DefaultView[r]["ColorTwoID"].ToString() &&
       //                        dt.DefaultView[i]["SizeID"].ToString() == dtT.DefaultView[r]["SizeID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Task"] = dtT.Rows[r]["Amount"];
       //                        dt.Rows[i]["DepAmount"] = dtT.Rows[r]["DepAmount"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //        DataTable dtR = bllRep.GetFenXiProduct().Tables[0];
       //        if (dtR.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtR.Rows.Count; r++)
       //                {
       //                    t = false;
       //                    if (dt.DefaultView[i]["MaterielID"].ToString() == dtR.DefaultView[r]["MaterielID"].ToString() &&
       //                        dt.DefaultView[i]["ColorID"].ToString() == dtR.DefaultView[r]["ColorID"].ToString() &&
       //                        dt.DefaultView[i]["ColorOneID"].ToString() == dtR.DefaultView[r]["ColorOneID"].ToString() &&
       //                        dt.DefaultView[i]["ColorTwoID"].ToString() == dtR.DefaultView[r]["ColorTwoID"].ToString() &&
       //                        dt.DefaultView[i]["SizeID"].ToString() == dtR.DefaultView[r]["SizeID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Rep"] = dtR.Rows[r]["Amount"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //        DataTable dtC = bllCBI.GetNotAmount(BrandID).Tables[0];
       //        if (dtC.Rows.Count > 0)
       //        {
       //            for (int i = 0; i < dt.Rows.Count; i++)
       //            {
       //                for (int r = 0; r < dtC.Rows.Count; r++)
       //                {
       //                    t = false;
       //                    if (dt.DefaultView[i]["MaterielID"].ToString() == dtC.DefaultView[r]["MaterielID"].ToString() &&
       //                        dt.DefaultView[i]["ColorID"].ToString() == dtC.DefaultView[r]["ColorID"].ToString() &&
       //                        dt.DefaultView[i]["ColorOneID"].ToString() == dtC.DefaultView[r]["ColorOneID"].ToString() &&
       //                        dt.DefaultView[i]["ColorTwoID"].ToString() == dtC.DefaultView[r]["ColorTwoID"].ToString() &&
       //                        dt.DefaultView[i]["SizeID"].ToString() == dtC.DefaultView[r]["SizeID"].ToString())
       //                    {
       //                        t = true;
       //                        dt.Rows[i]["Chang"] = dtC.Rows[r]["Chang"];
       //                        break;
       //                    }
       //                }
       //            }
       //        }
       //    }
       //    #endregion
       //    if (dt.Rows.Count > 0)
       //    {
       //        int Sa, Task, Rep, Chang,dep;
       //        for (int i = 0; i < dt.Rows.Count; i++)
       //        {
       //            Sa = Task = Rep = Chang = dep = 0;
       //            if (dt.DefaultView[i]["DepAmount"].ToString() != "")
       //                dep = int.Parse(dt.DefaultView[i]["DepAmount"].ToString());
       //            if (dt.DefaultView[i]["NotSale"].ToString() != "")
       //                Sa = int.Parse(dt.DefaultView[i]["NotSale"].ToString());
       //            if (dt.DefaultView[i]["Task"].ToString() != "")
       //                Task = int.Parse(dt.DefaultView[i]["Task"].ToString());
       //            if (dt.DefaultView[i]["Rep"].ToString() != "")
       //                Rep = int.Parse(dt.DefaultView[i]["Rep"].ToString());
       //            if (dt.DefaultView[i]["Chang"].ToString() != "")
       //                Chang = int.Parse(dt.DefaultView[i]["Chang"].ToString());
       //            dt.Rows[i]["NotAmount"] = Rep + dep + Task + Chang - Sa;
       //        }
       //    }
       //    return dt;
       //}
       //public DataTable GetTaskInfo(int companyID, int MListID, bool HaveNoCom)
       //{
       //    Hownet.BLL.ProduceTaskMain bllPTM = new ProduceTaskMain();
       //    return bllPTM.GetFenXiInfo(companyID, MListID, HaveNoCom);
       //}
       //public DataTable GetTaskInfo(int companyID, Hownet.Model.MaterielList mod, bool HaveNoCom)
       //{
       //    Hownet.BLL.ProduceTaskMain bllPTM = new ProduceTaskMain();
       //    return bllPTM.GetFenXiInfo(companyID, mod, HaveNoCom);
       //}
       //public DataTable GetWorkInfo(int companyID,int MaterielID, int MListID, bool HaveNoCom)
       //{
       //    Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
       //    Hownet.BLL.WorkticketInfo bllWTI = new WorkticketInfo();
       //    DataTable dtWI = bllWTI.GetWorkInfo(companyID, MListID, HaveNoCom);
       //    if (dtWI.Rows.Count > 0)
       //    {
       //        dtWI.Columns.Add("EmpDate", typeof(string));
       //        for (int i = 0; i < dtWI.Rows.Count; i++)
       //        {
       //            if (dtWI.Rows[i]["DateTime"].ToString() != "" && (DateTime)(dtWI.Rows[i]["DateTime"]) != DateTime.Parse("1900-1-1"))
       //            {
       //                dtWI.Rows[i]["EmpDate"] = dtWI.Rows[i]["EmployeeName"].ToString() + "/" + ((DateTime)(dtWI.Rows[i]["DateTime"])).ToShortDateString();
       //            }
       //            else
       //                dtWI.Rows[i]["EmpDate"] = " ";
       //        }
       //    }
       //    DataTable dtPWI = bllPWI.GetDefaulttWorkList(MaterielID).Tables[0];
       //    DataTable dt = bllWTI.GetTickList(companyID, MListID, HaveNoCom);
       //    if (dtPWI.Rows.Count > 0)
       //    {
       //        for (int i = 0; i < dtPWI.Rows.Count; i++)
       //        {
       //            dt.Columns.Add(dtPWI.Rows[i]["WorkingName"].ToString(), typeof(string));
       //            for (int j = 0; j < dt.Rows.Count; j++)
       //            {
       //                object box = dt.Rows[j]["箱号"];
       //                object wor = dtPWI.Rows[i]["ProductWorkingID"];
       //                DataRow[] drs = dtWI.Select("(WorkTicketID=" + dt.Rows[j]["WorkTicketID"] + ") And (WorkingID=" + dtPWI.Rows[i]["ProductWorkingID"] + ")");
       //                if (drs.Length > 0)
       //                {
       //                    object obj = drs[0]["EmpDate"];
       //                    dt.Rows[j][dtPWI.Rows[i]["WorkingName"].ToString()] = drs[0]["EmpDate"];
       //                }
       //            }
       //        }
       //    }
       //    return dt;
       //}
       //public DataTable GetWorkInfo(int companyID, int MaterielID, Hownet.Model.MaterielList mod, bool HaveNoCom)
       //{
       //    Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
       //    Hownet.BLL.WorkticketInfo bllWTI = new WorkticketInfo();
       //    DataTable dtWI = bllWTI.GetWorkInfo(companyID, mod, HaveNoCom);
       //    if (dtWI.Rows.Count > 0)
       //    {
       //        dtWI.Columns.Add("EmpDate", typeof(string));
       //        for (int i = 0; i < dtWI.Rows.Count; i++)
       //        {
       //            if (dtWI.Rows[i]["DateTime"].ToString() != "" && (DateTime)(dtWI.Rows[i]["DateTime"]) != DateTime.Parse("1900-1-1"))
       //            {
       //                dtWI.Rows[i]["EmpDate"] = dtWI.Rows[i]["EmployeeName"].ToString() + "/" + ((DateTime)(dtWI.Rows[i]["DateTime"])).ToShortDateString();
       //            }
       //            else
       //                dtWI.Rows[i]["EmpDate"] = " ";
       //        }
       //    }
       //    DataTable dtPWI = bllPWI.GetDefaulttWorkList(MaterielID).Tables[0];
       //    DataTable dt = bllWTI.GetTickList(companyID, mod, HaveNoCom);
       //    if (dtPWI.Rows.Count > 0)
       //    {
       //        for (int i = 0; i < dtPWI.Rows.Count; i++)
       //        {
       //            dt.Columns.Add(dtPWI.Rows[i]["WorkingName"].ToString(), typeof(string));
       //            for (int j = 0; j < dt.Rows.Count; j++)
       //            {
       //                object box = dt.Rows[j]["箱号"];
       //                object wor = dtPWI.Rows[i]["ProductWorkingID"];
       //                DataRow[] drs = dtWI.Select("(WorkTicketID=" + dt.Rows[j]["WorkTicketID"] + ") And (WorkingID=" + dtPWI.Rows[i]["ProductWorkingID"] + ")");
       //                if (drs.Length > 0)
       //                {
       //                    object obj = drs[0]["EmpDate"];
       //                    dt.Rows[j][dtPWI.Rows[i]["WorkingName"].ToString()] = drs[0]["EmpDate"];
       //                }
       //            }
       //        }
       //    }
       //    return dt;
       //}
    }
}
