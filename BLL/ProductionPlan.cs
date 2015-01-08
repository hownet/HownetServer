using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类ProductionPlan 的摘要说明。
    /// </summary>
    public class ProductionPlan
    {
        private readonly Hownet.DAL.ProductionPlan dal = new Hownet.DAL.ProductionPlan();
        public ProductionPlan()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ProductionPlan model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.ProductionPlan> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                return dal.Add(li[0]);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Hownet.Model.ProductionPlan model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.ProductionPlan> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            dal.Delete(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.ProductionPlan GetModel(int ID)
        {

            return dal.GetModel(ID);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetTopList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ProductionPlan> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ProductionPlan> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.ProductionPlan> modelList = new List<Hownet.Model.ProductionPlan>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.ProductionPlan model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.ProductionPlan();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["SalesOrderInfoID"].ToString() != "")
                    {
                        model.SalesOrderInfoID = int.Parse(dt.Rows[n]["SalesOrderInfoID"].ToString());
                    }
                    else
                    {
                        model.SalesOrderInfoID = 0;
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
                    }
                    if (dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    else
                    {
                        model.BrandID = 0;
                    }
                    if (dt.Rows[n]["Num"].ToString() != "")
                    {
                        model.Num = int.Parse(dt.Rows[n]["Num"].ToString());
                    }
                    else
                    {
                        model.Num = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["LastDate"].ToString() != "")
                    {
                        model.LastDate = DateTime.Parse(dt.Rows[n]["LastDate"].ToString());
                    }
                    else
                    {
                        model.LastDate = DateTime.Parse("1900-1-1");
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["PWorkingID"].ToString() != "")
                    {
                        model.PWorkingID = int.Parse(dt.Rows[n]["PWorkingID"].ToString());
                    }
                    else
                    {
                        model.PWorkingID = 0;
                    }
                    if (dt.Rows[n]["BomID"].ToString() != "")
                    {
                        model.BomID = int.Parse(dt.Rows[n]["BomID"].ToString());
                    }
                    else
                    {
                        model.BomID = 0;
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    if (dt.Rows[n]["IsTicket"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsTicket"].ToString() == "1") || (dt.Rows[n]["IsTicket"].ToString().ToLower() == "true"))
                        {
                            model.IsTicket = true;
                        }
                        else
                        {
                            model.IsTicket = false;
                        }
                    }
                    if (dt.Rows[n]["IsBom"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsBom"].ToString() == "1") || (dt.Rows[n]["IsBom"].ToString().ToLower() == "true"))
                        {
                            model.IsBom = true;
                        }
                        else
                        {
                            model.IsBom = false;
                        }
                    }
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    else
                    {
                        model.IsVerify = 0;
                    }
                    if (dt.Rows[n]["VerifyDate"].ToString() != "")
                    {
                        model.VerifyDate = DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
                    }
                    else
                    {
                        model.VerifyDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["VerifyMan"].ToString() != "")
                    {
                        model.VerifyMan = int.Parse(dt.Rows[n]["VerifyMan"].ToString());
                    }
                    else
                    {
                        model.VerifyMan = 0;
                    }
                    if (dt.Rows[n]["DeparmentID"].ToString() != "")
                    {
                        model.DeparmentID = int.Parse(dt.Rows[n]["DeparmentID"].ToString());
                    }
                    else
                    {
                        model.DeparmentID = 0;
                    }
                    if (dt.Rows[n]["UpData"].ToString() != "")
                    {
                        model.UpData = int.Parse(dt.Rows[n]["UpData"].ToString());
                    }
                    else
                    {
                        model.UpData = 0;
                    }
                    if (dt.Rows[n]["FillDate"].ToString() != "")
                    {
                        model.FillDate = DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
                    }
                    else
                    {
                        model.FillDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["FilMan"].ToString() != "")
                    {
                        model.FilMan = int.Parse(dt.Rows[n]["FilMan"].ToString());
                    }
                    else
                    {
                        model.FilMan = 0;
                    }
                    if (dt.Rows[n]["TicketDate"].ToString() != "")
                    {
                        model.TicketDate = DateTime.Parse(dt.Rows[n]["TicketDate"].ToString());
                    }
                    else
                    {
                        model.TicketDate = DateTime.Parse("1900-1-1");
                    }
                    model.BedNO = dt.Rows[n]["BedNO"].ToString();
                    if (dt.Rows[n]["PackingMethodID"].ToString() != "")
                    {
                        model.PackingMethodID = int.Parse(dt.Rows[n]["PackingMethodID"].ToString());
                    }
                    else
                    {
                        model.PackingMethodID = 0;
                    }
                    model.SewingRemark = dt.Rows[n]["SewingRemark"].ToString();
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    else
                    {
                        model.TypeID = 0;
                    }
                    if (dt.Rows[n]["ParentID"].ToString() != "")
                    {
                        model.ParentID = int.Parse(dt.Rows[n]["ParentID"].ToString());
                    }
                    else
                    {
                        model.ParentID = 0;
                    }
                        model.AssociatedID = dt.Rows[n]["AssociatedID"].ToString();
                    if (dt.Rows[n]["AssociatedMatID"] != null && dt.Rows[n]["AssociatedMatID"].ToString() != "")
                    {
                        model.AssociatedMatID = int.Parse(dt.Rows[n]["AssociatedMatID"].ToString());
                    }
                    model.A = int.Parse(dt.Rows[n]["A"].ToString());
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        public DataSet GetIDList()
        {
            return dal.GetIDList();
        }
        public int NewNum(DateTime dt, int TypeID)
        {
            return dal.NewNum(dt,TypeID);
        }
        public bool CheckNum(DateTime dt, int Num)
        {
            return dal.CheckNum(dt, Num);
        }
        /// <summary>
        /// 将生产计划进行生产
        /// </summary>
        /// <param name="PlanID">计划单ID</param>
        /// <param name="TaskID">生产单ID</param>
        /// <param name="PlanTypeID">计划单类型</param>
        /// <param name="TaskTypeID">生产单类型</param>
        /// <param name="t">真为生产，假为取消生产单</param>
        public void UpPlanAmount(int PlanID, int TaskID, int PlanTypeID, int TaskTypeID, bool t)
        {
            Hownet.BLL.AmountInfo bllAI = new AmountInfo();
            List<Hownet.Model.AmountInfo> liPP = bllAI.DataTableToList(bllAI.GetList("(MainID=" + PlanID + ") And (TableTypeID=" + PlanTypeID + ")").Tables[0]);
            if (liPP.Count>0)
            {
                List<Hownet.Model.AmountInfo> liTask = bllAI.DataTableToList(bllAI.GetList("(MainID=" + TaskID + ") And (TableTypeID=" + TaskTypeID + ")").Tables[0]);
                if (liTask.Count > 0)
                {
                    for (int i = 0; i < liPP.Count; i++)
                    {
                        for (int j = 0; j < liTask.Count; j++)
                        {
                            if (liPP[i].MListID == liTask[j].MListID)
                            {
                                if (t)
                                {
                                    liPP[i].NotAmount -= liTask[j].Amount;
                                }
                                else
                                {
                                    liPP[i].NotAmount += liTask[j].Amount;
                                }
                                bllAI.Update(liPP[i]);
                                break;
                            }
                        }
                    }
                }
            }
            Hownet.Model.ProductionPlan modPP = GetModel(PlanID);
            if (modPP.IsVerify < 4)
            {
                modPP.IsVerify = 4;
                Update(modPP);
            }
        }
        /// <summary>
        /// 计划单列表
        /// </summary>
        /// <param name="TableTypeID">表类型</param>
        /// <param name="TypeID">编号类型</param>
        /// <param name="IsVerify">是否只是已审核的有效单据</param>
        /// <returns></returns>
        public DataSet GetTaskList(int TableTypeID, int TypeID, bool IsVerify)
        {
            return dal.GetTaskList(TableTypeID, TypeID, IsVerify);
        }
        public bool CheckCanDelete(int PlanID)
        {
            return dal.CheckCanDelete(PlanID);
        }
        /// <summary>
        /// 查询某生产计划的入库数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet Get2Depot(int MainID, int TableTypeID)
        {
            return dal.Get2Depot(MainID, TableTypeID);
        }
         /// <summary>
        /// 查找裁剪单的床号
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public int GetMaxTask(int MainID)
        {
            return dal.GetMaxTask(MainID);
        }
        /// <summary>
        /// 取得编号
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetNum(int ID)
        {
            return dal.GetNum(ID);
        }
        /// <summary>
        /// 取得该生产计划已生成的裁剪单数量
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int GetTMCount(int ID)
        {
            return dal.GetTMCount(ID);
        }
        /// <summary>
        /// 取得可以合并的生产计划
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetMerge(int MaterielID,int TableTypeID)
        {
            return dal.GetMerge(MaterielID,TableTypeID);
        }
        /// <summary>
        /// 合并生产计划
        /// </summary>
        /// <param name="StrPPID"></param>
        public int MergePP(string StrPPID)
        {
            Hownet.BLL.AmountInfo bllAI = new AmountInfo();
            string[] ss = StrPPID.Split(',');
            int MainID = 0;
            Hownet.Model.ProductionPlan modPP = GetModel(Convert.ToInt32(ss[0]));
            modPP.TypeID = -1;
            modPP.DeparmentID = -1;
            modPP.UpData = 1;
            modPP.IsVerify = 1;
            MainID = Add(modPP);
            DataTable dt = dal.GetMergeAmount(StrPPID, (int)Enums.TableType.ProductionPlan).Tables[0];
            DataTable dttt = dt.Clone();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML;
            Hownet.BLL.Materiel bllMat=new Materiel();
            Hownet.Model.Materiel modMat=bllMat.GetModel(modPP.MaterielID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dttt.Rows.Clear();
                dt.Rows[i]["MainID"] = MainID;
                modML = new Hownet.Model.MaterielList();
                modML.BrandID = modPP.BrandID;
                modML.ColorID = Convert.ToInt32(dt.Rows[i]["ColorID"]);
                modML.ColorOneID = Convert.ToInt32(dt.Rows[i]["ColorOneID"]);
                modML.ColorTwoID = Convert.ToInt32(dt.Rows[i]["ColorTwoID"]);
                modML.MaterielID = modPP.MaterielID;
                modML.MeasureID = modMat.MeasureID;
                modML.SizeID = Convert.ToInt32(dt.Rows[i]["SizeID"]);
                dt.Rows[i]["MListID"] =modML.ID= bllML.GetID(modML);
                dttt.Rows.Add(dt.Rows[i].ItemArray);
                bllAI.AddByDt(dttt);
            }
            for (int i = 0; i < ss.Length; i++)
            {
                modPP = GetModel(Convert.ToInt32(ss[i]));
                modPP.DeparmentID = MainID;
                modPP.IsVerify = (int)Enums.IsVerify.合并或拆分;
                Update(modPP);
            }
            return MainID;
        }
        public DataSet GetPlanList(int TableTypeID, string strWhere)
        {
            return dal.GetPlanList(TableTypeID, strWhere);
        }
        public DataSet GetNumList(string strWhere)
        {
            return dal.GetNumList(strWhere);
        }
        public DataSet GetNumListForLinLiao(string strWhere)
        {
            return dal.GetNumListForLinLiao(strWhere);
        }
        /// <summary>
        /// 当生产计划被标记为完成等状态时，更新该生产计划库存数量到空闲库存
        /// </summary>
        /// <param name="MainID"></param>
        public void UpPlanMD(int MainID)
        {
            Hownet.BLL.Repertory bllRep = new Repertory();
            List<Hownet.Model.Repertory> li = bllRep.DataTableToList(bllRep.GetList("(PlanID=" + MainID + ")").Tables[0]);
            List<Hownet.Model.Repertory> ll;
            Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
            if (li.Count > 0)
            {
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].Amount > 0)
                    {
                        ll = bllRep.DataTableToList(bllRep.GetList("(PlanID=0) And (DepartmentID=" + li[i].DepartmentID + ") And (MListID=" + li[i].MListID + ")").Tables[0]);
                        if (ll.Count > 0)
                        {
                            ll[0].Amount += li[i].Amount;
                            bllRep.Update(ll[0]);
                        }
                        else
                        {
                            modRep = bllRep.GetModel(li[i].ID);
                            modRep.PlanID = 0;
                            bllRep.Add(modRep);
                        }
                        li[i].Amount = 0;
                        bllRep.Update(li[i]);
                    }
                }
            }
        }
          /// <summary>
        /// 获取某款号的打版师
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetDesigners(int ID)
        {
            return dal.GetDesigners(ID);
        }
        /// <summary>
        /// 根据编号，获取任务单ID和款号
        /// </summary>
        /// <param name="Num"></param>
        /// <returns></returns>
        public DataSet GetListByNum(string Num)
        {
            return dal.GetListByNum(Num);
        }
        public int MDPP(int MainID)
        {
            try
            {
                Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                Hownet.BLL.Repertory bllRep = new Repertory();
                DataTable dt = dal.GetPPMDList(MainID).Tables[0];
                List<Hownet.Model.MaterielDemand> li = bllMD.DataTableToList(bllMD.GetList("(ProduceTaskID=" + MainID + ") And (TableTypeID=41)").Tables[0]);
                for (int i = 0; i < li.Count; i++)
                {
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        if (li[i].MListID == Convert.ToInt32(dt.Rows[j]["MListID"]))
                        {
                            li[i].RepertoryAmount += Convert.ToDecimal(dt.Rows[j]["RepertoryAmount"]);
                            bllMD.Update(li[i]);
                            break;
                        }
                    }
                }
                dal.UpPPMDList(MainID);
                List<Hownet.Model.Repertory> liRe = bllRep.DataTableToList(bllRep.GetList("(PlanID=" + MainID + ")").Tables[0]);
                DataTable dtRep = bllRep.GetPPList(MainID).Tables[0];
                Hownet.Model.Repertory modRe= new Hownet.Model.Repertory();
                bool t = false;
                for (int i = 0; i < dtRep.Rows.Count; i++)
                {
                    t = false;
                    for (int j = 0; j < liRe.Count; j++)
                    {
                        if (liRe[j].MListID == Convert.ToInt32(dtRep.Rows[i]["MListID"]) && liRe[j].DepartmentID == Convert.ToInt32(dtRep.Rows[i]["DepartmentID"]))
                        {
                            liRe[j].Amount += Convert.ToDecimal(dtRep.Rows[i]["Amount"]);
                            t = true;
                            break;
                        }
                    }
                    if (!t)
                    {
                        modRe = new Hownet.Model.Repertory();
                        modRe.A = 3;
                        modRe.Amount = Convert.ToDecimal(dtRep.Rows[i]["Amount"]);
                        modRe.BrandID = Convert.ToInt32(dtRep.Rows[i]["BrandID"]);
                        modRe.ColorID = Convert.ToInt32(dtRep.Rows[i]["ColorID"]);
                        modRe.ColorOneID = Convert.ToInt32(dtRep.Rows[i]["ColorOneID"]);
                        modRe.ColorTwoID = Convert.ToInt32(dtRep.Rows[i]["ColorTwoID"]);
                        modRe.CompanyID = 0;
                        modRe.DepartmentID = Convert.ToInt32(dtRep.Rows[i]["DepartmentID"]);
                        modRe.ID = 0;
                        modRe.MaterielID = Convert.ToInt32(dtRep.Rows[i]["MaterielID"]);
                        modRe.MeasureID = Convert.ToInt32(dtRep.Rows[i]["MeasureID"]);
                        modRe.MListID = Convert.ToInt32(dtRep.Rows[i]["MListID"]);
                        modRe.PlanID = MainID;
                        modRe.Remark = string.Empty;
                        modRe.SizeID = Convert.ToInt32(dtRep.Rows[i]["SizeID"]);
                        modRe.ID = bllRep.Add(modRe);
                        liRe.Add(modRe);
                        
                    }
                }
                bllRep.DelPPList(MainID);
                return 1;
            }
            catch
            {
                return 0;
            }
            
        }
        /// <summary>
        /// 获得分页数据列表
        /// </summary>
        //public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  成员方法
    }
}

