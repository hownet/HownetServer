using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类ProduceSell 的摘要说明。
    /// </summary>
    public class ProduceSell
    {
        private readonly Hownet.DAL.ProduceSell dal = new Hownet.DAL.ProduceSell();
        public ProduceSell()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大IDGetTaskList
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
        public int Add(Hownet.Model.ProduceSell model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.ProduceSell> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.ProduceSell model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.ProduceSell> li = DataTableToList(dt);
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
        public Hownet.Model.ProduceSell GetModel(int ID)
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
        public List<Hownet.Model.ProduceSell> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ProduceSell> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.ProduceSell> modelList = new List<Hownet.Model.ProduceSell>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.ProduceSell model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.ProduceSell();
                    try
                    {
                        if (dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        else
                        {
                            model.ID = 0;
                        }
                        if (dt.Rows[n]["CompanyID"].ToString() != "")
                        {
                            model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                        }
                        else
                        {
                            model.CompanyID = 0;
                        }
                        if (dt.Rows[n]["DateTime"].ToString() != "")
                        {
                            model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                        }
                        else
                        {
                            model.DateTime = DateTime.Parse("1900-1-1");
                        }
                        if (dt.Rows[n]["Depot"].ToString() != "")
                        {
                            model.Depot = int.Parse(dt.Rows[n]["Depot"].ToString());
                        }
                        else
                        {
                            model.Depot = 0;
                        }
                        model.Remark = dt.Rows[n]["Remark"].ToString();
                        if (dt.Rows[n]["Money"].ToString() != "")
                        {
                            model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                        }
                        else
                        {
                            model.Money = 0;
                        }
                        if (dt.Rows[n]["IsVerify"].ToString() != "")
                        {
                            model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                        }
                        if (dt.Rows[n]["LastMoney"].ToString() != "")
                        {
                            model.LastMoney = decimal.Parse(dt.Rows[n]["LastMoney"].ToString());
                        }
                        else
                        {
                            model.LastMoney = 0;
                        }
                        if (dt.Rows[n]["BackMoney"].ToString() != "")
                        {
                            model.BackMoney = decimal.Parse(dt.Rows[n]["BackMoney"].ToString());
                        }
                        else
                        {
                            model.BackMoney = 0;
                        }
                        if (dt.Rows[n]["Num"].ToString() != "")
                        {
                            model.Num = int.Parse(dt.Rows[n]["Num"].ToString());
                        }
                        else
                        {
                            model.Num = 0;
                        }
                        if (dt.Rows[n]["UpData"].ToString() != "")
                        {
                            model.UpData = int.Parse(dt.Rows[n]["UpData"].ToString());
                        }
                        else
                        {
                            model.UpData = 0;
                        }
                        if (dt.Rows[n]["VerifyMan"].ToString() != "")
                        {
                            model.VerifyMan = int.Parse(dt.Rows[n]["VerifyMan"].ToString());
                        }
                        else
                        {
                            model.VerifyMan = 0;
                        }
                        if (dt.Rows[n]["VerifyDate"].ToString() != "")
                        {
                            model.VerifyDate = DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
                        }
                        else
                        {
                            model.VerifyDate = DateTime.Parse("1900-1-1");
                        }
                        if (dt.Rows[n]["FillMan"].ToString() != "")
                        {
                            model.FillMan = int.Parse(dt.Rows[n]["FillMan"].ToString());
                        }
                        else
                        {
                            model.FillMan = 0;
                        }
                        if (dt.Rows[n]["FillDate"].ToString() != "")
                        {
                            model.FillDate = DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
                        }
                        else
                        {
                            model.FillDate = DateTime.Parse("1900-1-1");
                        }
                        if (dt.Rows[n]["State"].ToString() != "")
                        {
                            model.State = int.Parse(dt.Rows[n]["State"].ToString());
                        }
                        else
                        {
                            model.State = 0;
                        }
                        if (dt.Rows[n]["BackDate"].ToString() != "")
                        {
                            model.BackDate = DateTime.Parse(dt.Rows[n]["BackDate"].ToString());
                        }
                        else
                        {
                            model.BackDate = DateTime.Parse("1900-1-1");
                        }
                        if (dt.Rows[n]["BackMoneyTypeID"].ToString() != "")
                        {
                            model.BackMoneyTypeID = int.Parse(dt.Rows[n]["BackMoneyTypeID"].ToString());
                        }
                        else
                        {
                            model.BackMoneyTypeID = 0;
                        }
                        if (dt.Rows[n]["LastDate"] != null && dt.Rows[n]["LastDate"].ToString() != "")
                        {
                            model.LastDate = DateTime.Parse(dt.Rows[n]["LastDate"].ToString());
                        }
                        model.A = int.Parse(dt.Rows[n]["A"].ToString());
                    }
                    catch (Exception ex)
                    {

                    }
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
        public DataSet GetIDList(int state)
        {
            return dal.GetIDList(state);
        }
        public int NewNum(DateTime dt,int CompanyID)
        {
            return dal.NewNum(dt, CompanyID);
        }
        /// <summary>
        /// 审核/弃审入库单
        /// </summary>
        /// <param name="ID">入库单ID</param>
        /// <param name="t">真为审核出库，假为弃审入库</param>
        public void Verify(int ID, bool t, int Depot)
        {
            Hownet.BLL.ProduceSellInfo bllPSI = new ProduceSellInfo();
            Hownet.BLL.Repertory bllRep = new Repertory();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.BLL.RepertoryList bllRL = new RepertoryList();
            Hownet.Model.RepertoryList modRL = new Model.RepertoryList();
            //Hownet.BLL.Measure bllMea = new Measure();
            Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            List<Hownet.Model.ProduceSellInfo> li = bllPSI.DataTableToList(bllPSI.GetList("(MainID=" + ID + ")").Tables[0]);
            Hownet.BLL.AmountInfo bllAI = new AmountInfo();
            Hownet.Model.AmountInfo modAI;
            Hownet.BLL.OtherType bllOT = new OtherType();
            DataTable dtOT = bllOT.GetList("(Name='仓储单位')").Tables[0];
            int measureid = 0;
            if (dtOT.Rows.Count > 0)
                measureid = Convert.ToInt32(dtOT.Rows[0]["Value"]);
            //DataTable dt = bllMea.GetList("(Name='件')").Tables[0];
            //if (dt.Rows.Count > 0)
            //    modRep.MeasureID = int.Parse(dt.Rows[0]["ID"].ToString());
            //else
            //    modRep.MeasureID = 0;
            for (int i = 0; i < li.Count; i++)
            {
                try
                {
                    modAI = bllAI.GetModel(li[i].SalesInfoID);
                    modRep.BrandID = modML.BrandID = li[i].BrandID;
                    modRep.ColorID = modML.ColorID = li[i].ColorID;
                    modRep.ColorOneID = modML.ColorOneID = li[i].ColorOneID;
                    modRep.ColorTwoID = modML.ColorTwoID = li[i].ColorTwoID;
                    modRep.SizeID = modML.SizeID = li[i].SizeID;
                    if (measureid > 0)
                        modRep.MeasureID = modML.MeasureID = measureid;
                    else
                        modRep.MeasureID = modML.MeasureID = li[i].MeasureID;
                    modRep.MaterielID = modML.MaterielID = li[i].MaterielID;
                    modRep.Amount = li[i].Amount;
                    modRep.DepartmentID = Depot;

                    if (li[i].MListID == 0)
                    {
                        modRep.MListID = li[i].MListID = bllML.GetID(modML);
                        bllPSI.Update(li[i]);
                    }
                    else
                    {
                        modRep.MListID = li[i].MListID;
                    }

                    if (li[i].RepertoryID == 0)
                    {
                        if (Depot > 0)
                            bllRep.InOrOut(modRep, !t);
                    }
                    if (li[i].RepertoryID > 0)
                    {
                        modRep = bllRep.GetModel(li[i].RepertoryID);
                        if (t)
                            modRep.Amount -= li[i].Amount;
                        else
                            modRep.Amount += li[i].Amount;
                        bllRep.Update(modRep);
                    }

                    if (li[i].RepertoryListID > 0)
                    {
                        modRL = bllRL.GetModel(li[i].RepertoryListID);
                        if (t)
                            modRL.Amount -= li[i].Amount;
                        else
                            modRL.Amount += li[i].Amount;
                        bllRL.Update(modRL);
                    }
                    if (modAI != null)
                    {
                        modAI.NotAmount = Convert.ToInt32(li[i].Amount);
                        bllAI.UpNotAmount(modAI, t);
                    }
                }
           
            catch (Exception ex)
            {

            } }
        }
        public void DeleteByCompanyID(int CompanyID)
        {
            dal.DeleteByCompanyID(CompanyID);
        }
                /// <summary>
        /// 审核/弃审入库单
        /// </summary>
        /// <param name="ID">入库单ID</param>
        /// <param name="t">真为审核出库，假为弃审入库</param>
        public bool CheckIsOK(int ID, bool t, int Depot)
        {
            bool _isOK = true;
            Hownet.BLL.Repertory bllRep = new Repertory();
            Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
            Hownet.BLL.ProduceSellOne blPSO = new ProduceSellOne();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            List<Hownet.Model.ProduceSellOne> li = blPSO.DataTableToList(blPSO.GetList("(MainID=" + ID + ")").Tables[0]);
            modRep.DepartmentID = Depot;
            for (int i = 0; i < li.Count; i++)
            {
                modRep.BrandID = modML.BrandID = li[i].BrandID;
                modRep.ColorID = modML.ColorID = 0;
                modRep.ColorOneID = modML.ColorOneID = 0;
                modRep.ColorTwoID = modML.ColorTwoID = 0;
                modRep.SizeID = modML.SizeID = 0;
                modRep.MaterielID = modML.MaterielID = li[i].MaterielID;
                modRep.MeasureID = modML.MeasureID = li[i].MeasureID;
                modRep.MListID = bllML.GetID(modML);
                if (bllRep.GetAmountByModel(modRep) < li[i].Amount)
                {
                    _isOK = false;
                    break;
                }
            }
            return _isOK;
        }
        /// <summary>
        /// 审核/弃审入库单
        /// </summary>
        /// <param name="ID">入库单ID</param>
        /// <param name="t">真为审核出库，假为弃审入库</param>
        public void VerifyProcess(int ID, bool t, int Depot)
        {
            Hownet.BLL.Repertory bllRep = new Repertory();
            Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
            Hownet.BLL.ProduceSellOne blPSO=new ProduceSellOne();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            List<Hownet.Model.ProduceSellOne> li = blPSO.DataTableToList(blPSO.GetList("(MainID=" + ID + ")").Tables[0]);
            modRep.DepartmentID = Depot;
            for (int i = 0; i < li.Count; i++)
            {
                modRep.BrandID = modML.BrandID = li[i].BrandID;
                modRep.ColorID = modML.ColorID = 0;
                modRep.ColorOneID = modML.ColorOneID = 0;
                modRep.ColorTwoID = modML.ColorTwoID = 0;
                modRep.SizeID = modML.SizeID = 0;
                modRep.MaterielID = modML.MaterielID = li[i].MaterielID;
                modRep.Amount = li[i].Amount;
                modRep.MeasureID =modML.MeasureID= li[i].MeasureID;
                modRep.MListID = bllML.GetID(modML);
                bllRep.InOrOut(modRep, !t);
            }
        }
        public DataSet GetPSAnalysisList(string strFiled, string strGroup, string strWhere, bool IsShowInfo)
        {
            return dal.GetPSAnalysisList(strFiled, strGroup, strWhere, IsShowInfo);
        }
        public DataSet GetPSAnListByCS(string strFiled, string strGroup, string strWhere, bool IsShowInfo)
        {
            return dal.GetPSAnListByCS(strFiled, strGroup, strWhere, IsShowInfo);
        }
        public DataSet GetSum(DateTime dtOne, DateTime dtTwo, int TypeID)
        {
            return dal.GetSum(dtOne, dtTwo, TypeID);
        }
        public DataSet GetStockSellInfo(DateTime dtOne, DateTime dtTwo)
        {
            return dal.GetStockSellInfo(dtOne, dtTwo);
        }
        public DataSet GetSellInfo(int MainID)
        {
            return dal.GetSellInfo(MainID);
        }
        public DataSet GetListInfoByTime(DateTime dt1, DateTime dt2, int CompanyID)
        {
            return dal.GetListInfoByTime(dt1, dt2, CompanyID);
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

