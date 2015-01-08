using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类StockBackInfo 的摘要说明。
	/// </summary>
	public class StockBackInfo
	{
		private readonly Hownet.DAL.StockBackInfo dal=new Hownet.DAL.StockBackInfo();
		public StockBackInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}
        public int UpOrAdd(byte[] bb)
        {
            try
            {
                string strDS = BaseFile.ZipDt.DeCompressString(bb);
                string[] ssRow = strDS.Split('й');
                int _id = 0;
                DataTable dt = GetList("(1=2)").Tables[0];
                int _a = 0;
                for (int j = 0; j < ssRow.Length; j++)
                {
                    if (ssRow[j] != string.Empty)
                    {
                        string[] ss = ssRow[j].Split('ж');//字段分隔
                        _a = Convert.ToInt32(ss[0]);
                        dt.Rows.Clear();
                        dt.Rows.Add(dt.NewRow());

                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            try
                            {
                                dt.Rows[0][i] = ss[i];
                            }
                            catch
                            {
                                if (ss[i] == string.Empty)
                                {
                                    if (dt.Columns[i].DataType == System.Type.GetType("System.DateTime"))
                                    {
                                        dt.Rows[0][i] = Convert.ToDateTime("1900-1-1");
                                    }
                                    else if(dt.Columns[i].DataType!=System.Type.GetType("System.Byte"))
                                    {
                                        dt.Rows[0][i] = 0;
                                    }
                                }
                            }
                        }
                        if (_a == 3)
                        {
                            _id = AddByDt(dt);
                        }
                        else if (_a == 2)
                        {
                            UpdateByDt(dt);
                        }
                        else if (_a == 4)
                        {
                            if (Convert.ToInt32(ss[1]) > 0)
                                Delete(Convert.ToInt32(ss[1]));
                        }
                    }
                }
                return _id;
            }
            catch (Exception ex)
            {
                return 0;
            }
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
		public int  Add(Hownet.Model.StockBackInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.StockBackInfo> li=DataTableToList(dt);
			if(li.Count>0)
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
		public void Update(Hownet.Model.StockBackInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.StockBackInfo> li=DataTableToList(dt);
			if(li.Count>0)
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
		public Hownet.Model.StockBackInfo GetModel(int ID)
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
		public DataSet GetTopList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.StockBackInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.StockBackInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.StockBackInfo> modelList = new List<Hownet.Model.StockBackInfo>();
			int rowsCount = dt.Rows.Count;
            try
            {
                if (rowsCount > 0)
                {
                    Hownet.Model.StockBackInfo model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new Hownet.Model.StockBackInfo();
                        if (dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        if (dt.Rows[n]["MainID"].ToString() != "")
                        {
                            model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                        }
                        if (dt.Rows[n]["StockInfoID"].ToString() != "")
                        {
                            model.StockInfoID = int.Parse(dt.Rows[n]["StockInfoID"].ToString());
                        }
                        if (dt.Rows[n]["MaterielID"].ToString() != "")
                        {
                            model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                        }
                        if (dt.Rows[n]["ColorID"].ToString() != "")
                        {
                            model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                        }
                        if (dt.Rows[n]["ColorOneID"].ToString() != "")
                        {
                            model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                        }
                        if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                        {
                            model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                        }
                        if (dt.Rows[n]["SizeID"].ToString() != "")
                        {
                            model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                        }
                        if (dt.Rows[n]["Price"].ToString() != "")
                        {
                            model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                        }
                        if (dt.Rows[n]["CompanyMeasureID"].ToString() != "")
                        {
                            model.CompanyMeasureID = int.Parse(dt.Rows[n]["CompanyMeasureID"].ToString());
                        }
                        if (dt.Rows[n]["DepotMeasureID"].ToString() != "")
                        {
                            model.DepotMeasureID = int.Parse(dt.Rows[n]["DepotMeasureID"].ToString());
                        }
                        if (dt.Rows[n]["Amount"].ToString() != "")
                        {
                            model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                        }
                        if (dt.Rows[n]["Conversion"].ToString() != "")
                        {
                            model.Conversion = decimal.Parse(dt.Rows[n]["Conversion"].ToString());
                        }
                        model.Remark = dt.Rows[n]["Remark"].ToString();
                        if (dt.Rows[n]["PriceAmount"].ToString() != "")
                        {
                            model.PriceAmount = decimal.Parse(dt.Rows[n]["PriceAmount"].ToString());
                        }
                        if (dt.Rows[n]["NotAmount"].ToString() != "")
                        {
                            model.NotAmount = decimal.Parse(dt.Rows[n]["NotAmount"].ToString());
                        }
                        if (dt.Rows[n]["Money"].ToString() != "")
                        {
                            model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                        }
                        if (dt.Rows[n]["NotPriceAmount"].ToString() != "")
                        {
                            model.NotPriceAmount = decimal.Parse(dt.Rows[n]["NotPriceAmount"].ToString());
                        }
                        if (dt.Rows[n]["MListID"].ToString() != "")
                        {
                            model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                        }
                        if (dt.Rows[n]["CompanyID"].ToString() != "")
                        {
                            model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                        }
                        else
                        {
                            model.CompanyID = 0;
                        }
                        if (dt.Rows[n]["BrandID"].ToString() != "")
                        {
                            model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                        }
                        else
                        {
                            model.BrandID = 0;
                        }
                        if (dt.Rows[n]["IsEnd"].ToString() != "")
                        {
                            model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                        }
                        else
                        {
                            model.IsEnd = 0;
                        }
                        if (dt.Rows[n]["DemandID"].ToString() != "")
                        {
                            model.DemandID = int.Parse(dt.Rows[n]["DemandID"].ToString());
                        }
                        else
                        {
                            model.DemandID = 0;
                        }
                        if (dt.Rows[n]["NeedAmount"].ToString() != "")
                        {
                            model.NeedAmount = decimal.Parse(dt.Rows[n]["NeedAmount"].ToString());
                        }
                        else
                        {
                            model.NeedAmount = 0;
                        }
                        if (dt.Rows[n]["ExcessAmount"].ToString() != "")
                        {
                            model.ExcessAmount = decimal.Parse(dt.Rows[n]["ExcessAmount"].ToString());
                        }
                        else
                        {
                            model.ExcessAmount = 0;
                        }
                        model.StringTaskID = dt.Rows[n]["StringTaskID"].ToString();
                        if (dt.Rows[n]["LastTime"].ToString() != "")
                        {
                            model.LastTime = DateTime.Parse(dt.Rows[n]["LastTime"].ToString());
                        }
                        else
                        {
                            model.LastTime = DateTime.Parse("1900-1-1");
                        }
                        if (dt.Rows[n]["Weight"] != null && dt.Rows[n]["Weight"].ToString() != "")
                        {
                            model.Weight = decimal.Parse(dt.Rows[n]["Weight"].ToString());
                        }
                        if (dt.Rows[n]["SpecID"] != null && dt.Rows[n]["SpecID"].ToString() != "")
                        {
                            model.SpecID = int.Parse(dt.Rows[n]["SpecID"].ToString());
                        }
                        model.MaterielName = dt.Rows[n]["MaterielName"].ToString();
                        model.ColorName = dt.Rows[n]["ColorName"].ToString();
                        model.ColorOneName = dt.Rows[n]["ColorOneName"].ToString();
                        model.ColorTwoName = dt.Rows[n]["ColorTwoName"].ToString();
                        model.SizeName = dt.Rows[n]["SizeName"].ToString();
                        model.BrandName = dt.Rows[n]["BrandName"].ToString();
                        if (dt.Rows[n]["SupplierID"] != null && dt.Rows[n]["SupplierID"].ToString() != "")
                        {
                            model.SupplierID = int.Parse(dt.Rows[n]["SupplierID"].ToString());
                        }
                        model.SupplierName = dt.Rows[n]["SupplierName"].ToString();
                        model.SupplierSN = dt.Rows[n]["SupplierSN"].ToString();
                        model.SpecName = dt.Rows[n]["SpecName"].ToString();
                        try
                        {
                            model.CompanyMaterielName = dt.Rows[n]["CompanyMaterielName"].ToString();
                        }
                        catch (Exception ex)
                        {
                            model.CompanyMaterielName = string.Empty;
                        }
                        model.A = int.Parse(dt.Rows[n]["A"].ToString());
                        modelList.Add(model);
                    }
                }
            }
            catch (Exception ex)
            {
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
                /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteByMain(int ID)
        {
            dal.DeleteByMain(ID);
        }
        public DataSet GetStockInfo(int CompanyID, int State)
        {
            return dal.GetStockInfo(CompanyID, State);
        }
              /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetBackSuppList(string strWhere)
        {
            return dal.GetBackSuppList(strWhere);
        }
        public decimal GetPrice(int CompanyID, int MaterielID, int ColorID, int SizeID, int MeasureID, int State)
        {
            return dal.GetPrice(CompanyID, MaterielID, ColorID, SizeID, MeasureID,State);
        }
        /// <summary>
        /// 获取某一物料采购情况
        /// </summary>
        /// <param name="MListID"></param>
        /// <returns></returns>
        public DataSet GetInfo(int MListID)
        {
            return dal.GetInfo(MListID);
        }
        /// <summary>
        /// 获取某部门在某份生产单中的应配货数量及该物料在某仓库中的库存
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetTemLinLiaoInfo(int TaskID, int DepotID,int DeparmentTypeID)
        {
            return dal.GetTemLinLiaoInfo(TaskID, DepotID, DeparmentTypeID);
        }
        public DataSet GetStockLinLiaoInfo(int StockID, int DepotID)
        {
            return dal.GetStockLinLiaoInfo(StockID, DepotID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TypeID"></param>
        /// <param name="t">真为增加记录，假为删除</param>
        public void StockToDemand(int MainID,int TypeID,bool t)
        {
            DataTable dt = GetList("(MainID=" + MainID + ")").Tables[0];
            #region 已申购数量
            if (TypeID == (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量)
            {
                DataTable dtMD = new DataTable();
                decimal Amount = 0;
                decimal NeedAmount = 0;
                if (dt.Rows.Count > 0)
                {
                    Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                    Hownet.BLL.PlanUseRep bllPR = new PlanUseRep();
                    Hownet.Model.PlanUseRep modPR = new Hownet.Model.PlanUseRep();
                    DataTable dttt = new DataTable();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //查找申购单中该物料在物料计算后对应的记录
                        dtMD = bllMD.GetList("(MListID=" + dt.Rows[i]["MListID"] + ") And (ProduceTaskID IN(" + dt.Rows[i]["StringTaskID"].ToString() + "))").Tables[0];
                        dttt = dtMD.Clone();
                        if (dtMD.Rows.Count > 0)
                        {
                            Amount = Convert.ToDecimal(dt.Rows[i]["Amount"]);
                            for (int j = 0; j < dtMD.Rows.Count; j++)
                            {
                                if (Amount == 0)
                                    break;
                                //查看物料计算明细中某物料现在需采购的数量
                                NeedAmount = bllPR.GetNeedStock(Convert.ToInt32(dtMD.Rows[j]["MListID"]), Convert.ToInt32(dtMD.Rows[j]["ID"]));
                                modPR = new Hownet.Model.PlanUseRep();
                                modPR.A = 1;
                                if (NeedAmount < Amount)
                                {
                                    modPR.NotAmount = modPR.Amount = NeedAmount;
                                    Amount -= NeedAmount;
                                }
                                else
                                {
                                    modPR.NotAmount = modPR.Amount = Amount;
                                    Amount = 0;
                                }
                                modPR.DemandID = Convert.ToInt32(dtMD.Rows[j]["ID"]);
                                modPR.ID = 0;
                                modPR.MListID = Convert.ToInt32(dtMD.Rows[j]["MListID"]);
                                modPR.RelatedID = 0;
                                modPR.StockInfoID = Convert.ToInt32(dt.Rows[i]["ID"]);
                                modPR.TaskID = Convert.ToInt32(dtMD.Rows[j]["ProduceTaskID"]);
                                modPR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量;
                                bllPR.Add(modPR);
                                dttt.Rows.Clear();//更新物料拆分中的已申购数量
                                dttt.Rows.Add(dtMD.Rows[j].ItemArray);
                                dttt.Rows[0]["NeedAmount"] = Convert.ToDecimal(dttt.Rows[0]["NeedAmount"]) + modPR.Amount;
                                bllMD.UpdateByDt(dttt);
                            }
                            //多出的申购数量，记录到空闲记录中
                            if (Amount > 0)
                            {
                                modPR = new Hownet.Model.PlanUseRep();
                                modPR.A = 1;
                                modPR.NotAmount = modPR.Amount = Amount;
                                modPR.DemandID = 0;
                                modPR.ID = 0;
                                modPR.MListID = Convert.ToInt32(dt.Rows[i]["MListID"]);
                                modPR.RelatedID = 0;
                                modPR.StockInfoID = Convert.ToInt32(dt.Rows[i]["ID"]);
                                modPR.TaskID = 0;
                                modPR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量;
                                bllPR.Add(modPR);
                            }
                        }
                    }
                }
            }
            #endregion
            #region 已采购数量
            else if (TypeID == (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已采购数量)
            {
                Hownet.BLL.PlanUseRep bllPR = new PlanUseRep();
                Hownet.Model.PlanUseRep modPR = new Hownet.Model.PlanUseRep();
                Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                Hownet.Model.MaterielDemand modMD = new Hownet.Model.MaterielDemand();
                Hownet.Model.StockBackInfo modSBI = new Hownet.Model.StockBackInfo();
                DataTable dtPR = new DataTable();
                DataTable dtt = new DataTable();
                decimal Amount = 0;
                decimal NotAmount = 0;
                if (t)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        try
                        {
                            Amount = Convert.ToDecimal(dt.Rows[i]["Amount"]);//采购总数
                            modSBI = GetModel(Convert.ToInt32(dt.Rows[i]["StockInfoID"]));//更新申购单NotAmount数量
                            modSBI.NotAmount -= Amount;
                            if (dt.Rows[i]["NeedIsEnd"] != null && dt.Rows[i]["NeedIsEnd"] != DBNull.Value && dt.Rows[i]["NeedIsEnd"].ToString() != string.Empty)

                            modSBI.IsEnd = Convert.ToInt32(dt.Rows[i]["NeedIsEnd"]);
                            Update(modSBI);
                            //采购单对应申购单明细
                            dtPR = bllPR.GetList("(StockInfoID=" + dt.Rows[i]["StockInfoID"] + ") And (TypeID=" + (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量 + ")").Tables[0];
                            #region                          //循环扣减申购未采购数量，并增加一条采购记录，申购单ID记录到新记录的RelatedID字段中
                            for (int j = 0; j < dtPR.Rows.Count; j++)
                            {
                                if (Amount == 0)
                                    break;
                                dtt = dtPR.Clone();
                                NotAmount = Convert.ToDecimal(dtPR.Rows[j]["NotAmount"]);
                                modPR = new Hownet.Model.PlanUseRep();
                                modPR.A = 1;
                                dtt.Rows.Add(dtPR.Rows[j].ItemArray);
                                if (NotAmount < Amount )
                                {
                                        modPR.NotAmount = modPR.Amount = NotAmount;
                                        Amount -= NotAmount;
                                        dtt.Rows[0]["NotAmount"] = 0;
                                        dtt.Rows[0]["IsEnd"] = modSBI.IsEnd;
                                        bllPR.UpdateByDt(dtt);
                                }
                                else
                                {
                                    modPR.NotAmount = modPR.Amount = Amount;
                                    dtt.Rows[0]["NotAmount"] = NotAmount - Amount;
                                    dtt.Rows[0]["IsEnd"] = modSBI.IsEnd;
                                    bllPR.UpdateByDt(dtt);
                                    Amount = 0;
                                }
                                modPR.DemandID = Convert.ToInt32(dtPR.Rows[j]["DemandID"]);
                                modPR.ID = 0;
                                modPR.MListID = Convert.ToInt32(dt.Rows[i]["MListID"]);
                                modPR.RelatedID = Convert.ToInt32(dtPR.Rows[j]["ID"]);
                                modPR.StockInfoID = Convert.ToInt32(dt.Rows[i]["ID"]);
                                modPR.TaskID = Convert.ToInt32(dtPR.Rows[j]["TaskID"]);
                                modPR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已采购数量;
                                if (modPR.Amount > 0)
                                {
                                    bllPR.Add(modPR);
                                    modMD = bllMD.GetModel(modPR.DemandID);//更新物料拆分表的已申购数量和已采购数量
                                    if (modMD != null)
                                    {
                                        modMD.HasStockAmount += modPR.Amount;
                                        modMD.NeedAmount -= modPR.Amount;
                                        modMD.stockNotAmount -= modPR.Amount;
                                        bllMD.Update(modMD);
                                    }
                                }
                            }
                            #endregion
                            #region                           //记录超过申购的数量
                            if (Amount > 0)
                            {
                                modPR = new Hownet.Model.PlanUseRep();
                                modPR.A = 1;
                                modPR.NotAmount = modPR.Amount = Amount;
                                modPR.DemandID = 0;
                                modPR.ID = 0;
                                modPR.MListID = Convert.ToInt32(dt.Rows[i]["MListID"]);
                                modPR.RelatedID = 0;
                                modPR.StockInfoID = Convert.ToInt32(dt.Rows[i]["ID"]);
                                modPR.TaskID = 0;
                                modPR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已采购数量;
                                bllPR.Add(modPR);
                            }
                            #endregion
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
                else
                {
                    //删除分订单明细
                    bllPR.DelStockByStockMainID(MainID);
                }
            }
            #endregion
            else if (TypeID == (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.库存已备料数量)
            {
                Hownet.BLL.PlanUseRep bllPR = new PlanUseRep();
                Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                Hownet.BLL.StockBack bllSB = new StockBack();
                Hownet.BLL.Repertory bllRep = new Repertory();
                int DepotID = bllSB.GetModel(MainID).DepotID;
                //  Hownet.Model.PlanUseRep modPR = new Hownet.Model.PlanUseRep();
                Hownet.Model.StockBackInfo modSBI = new Hownet.Model.StockBackInfo();
                Hownet.Model.MaterielDemand modMD = new Hownet.Model.MaterielDemand();
                Hownet.Model.PlanUseRep modPR = new Hownet.Model.PlanUseRep();
                DataTable dtPR = new DataTable();
                //   DataTable dtPRR = new DataTable();
                DataTable dtt = new DataTable();
                decimal Amount = 0;
                decimal NotAmount = 0;
                decimal TemAmount = 0;
                if (t)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        try
                        {
                            if (Convert.ToInt32(dt.Rows[i]["StockInfoID"]) > 0)
                            {
                                Amount = Convert.ToDecimal(dt.Rows[i]["Amount"]);//采购收货总数
                                modSBI = GetModel(Convert.ToInt32(dt.Rows[i]["StockInfoID"]));//更新采购单NotAmount数量
                                //modSBI.NotAmount -= Amount;
                                if (dt.Rows[i]["NeedIsEnd"] != null && dt.Rows[i]["NeedIsEnd"] != DBNull.Value && dt.Rows[i]["NeedIsEnd"].ToString() != string.Empty)
                                    modSBI.IsEnd = Convert.ToInt32(dt.Rows[i]["NeedIsEnd"]);
                               Update(modSBI);


                                //采购收纲单对应采购单明细
                                dtPR = bllPR.GetList("(StockInfoID=" + dt.Rows[i]["StockInfoID"] + ") And (TypeID=" + (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已采购数量 + ")").Tables[0];
                                #region    //循环扣减申购未采购数量，并增加一条采购记录，申购单ID记录到新记录的RelatedID字段中
                                for (int j = 0; j < dtPR.Rows.Count; j++)
                                {
                                    if (Amount == 0)
                                        break;
                                    dtt = dtPR.Clone();
                                    NotAmount = Convert.ToDecimal(dtPR.Rows[j]["NotAmount"]);
                                    //查询这个生产计划的这种物料，已记录的备料情况
                                    //    dtPRR = bllPR.GetList("(TaskID=" + dtPR.Rows[j]["TaskID"] + ") And (MListID=" + dtPR.Rows[j]["MListID"] + ") And (TypeID=" + (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.库存已备料数量 + ")").Tables[0];
                                    //更新采购订单的未完成数量
                                    modPR = new Hownet.Model.PlanUseRep();
                                    modPR.A = 1;
                                    dtt.Rows.Add(dtPR.Rows[j].ItemArray);
                                    if (NotAmount < Amount)
                                    {
                                        modPR.NotAmount = modPR.Amount = NotAmount;
                                        Amount -= NotAmount;
                                        TemAmount = NotAmount;
                                        dtt.Rows[0]["NotAmount"] = 0;
                                        dtt.Rows[0]["IsEnd"] = modSBI.IsEnd;
                                        bllPR.UpdateByDt(dtt);
                                    }
                                    else
                                    {
                                        modPR.NotAmount = modPR.Amount = Amount;
                                        TemAmount = Amount;
                                        dtt.Rows[0]["NotAmount"] = NotAmount - Amount;
                                        dtt.Rows[0]["IsEnd"] = modSBI.IsEnd;
                                        bllPR.UpdateByDt(dtt);
                                        Amount = 0;
                                    }
                                    modPR.DemandID = Convert.ToInt32(dtPR.Rows[j]["DemandID"]);
                                    modPR.ID = 0;
                                    modPR.MListID = Convert.ToInt32(dt.Rows[i]["MListID"]);
                                    modPR.RelatedID = Convert.ToInt32(dtPR.Rows[j]["ID"]);
                                    modPR.StockInfoID = Convert.ToInt32(dt.Rows[i]["ID"]);
                                    modPR.TaskID = Convert.ToInt32(dtPR.Rows[j]["TaskID"]);
                                    modPR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.库存已备料数量;
                                    //更新物料拆分表的已备料数量
                                    if (modPR.Amount > 0)
                                    {
                                        bllPR.Add(modPR);
                                        modMD = bllMD.GetModel(Convert.ToInt32(dtPR.Rows[j]["DemandID"]));
                                        if (modMD != null)//有物料拆分记录的。
                                        {
                                            modMD.HasStockAmount -= TemAmount;
                                            modMD.RepertoryAmount += TemAmount;
                                            bllMD.Update(modMD);
                                            dtt = bllRep.GetList("(MListID=" + modPR.MListID + ") And (DepartmentID=" + DepotID + ") And (PlanID=" + modPR.TaskID + ")").Tables[0];
                                            if (dtt.Rows.Count > 0)
                                            {
                                                dtt.Rows[0]["Amount"] = Convert.ToDecimal(dtt.Rows[0]["Amount"]) + modPR.Amount;
                                                bllRep.UpdateByDt(dtt);
                                            }
                                            else
                                            {
                                                DataRow dr = dtt.NewRow();
                                                dr["ID"] = dr["A"] = 0;
                                                dr["MListID"] = modMD.MListID;
                                                dr["Amount"] = modPR.Amount;
                                                dr["MeasureID"] = modMD.MeasureID;
                                                dr["DepartmentID"] = DepotID;
                                                dr["MaterielID"] = modMD.MaterielID;
                                                dr["SizeID"] = modMD.SizeID;
                                                dr["ColorID"] = modMD.ColorID;
                                                dr["ColorOneID"] = modMD.ColorOneID;
                                                dr["ColorTwoID"] = modMD.ColorTwoID;
                                                dr["BrandID"] = 0;
                                                dr["CompanyID"] = 0;
                                                dr["PlanID"] = modMD.ProduceTaskID;
                                                dtt.Rows.Add(dr);
                                                bllRep.AddByDt(dtt);
                                            }
                                        }
                                        else//没有物料拆分记录，一般指采购时超出申购的数量，在此记入库存表中。或者指有弃审过的生产计划
                                        {
                                            dtt = bllMD.GetList("(MListID=" + dt.Rows[i]["MListID"] + ") And  (ProduceTaskID=" + modPR.TaskID + ")").Tables[0];
                                            if (dtt.Rows.Count > 0)
                                            {
                                                dtt.Rows[0]["HasStockAmount"] = Convert.ToDecimal(dtt.Rows[0]["HasStockAmount"]) - TemAmount;
                                                dtt.Rows[0]["RepertoryAmount"] = Convert.ToDecimal(dtt.Rows[0]["RepertoryAmount"]) + TemAmount;
                                                bllMD.UpdateByDt(dtt);
                                                dtt = bllRep.GetList("(MListID=" + modPR.MListID + ") And (DepartmentID=" + DepotID + ") And (PlanID=" + modPR.TaskID + ")").Tables[0];
                                                if (dtt.Rows.Count > 0)
                                                {
                                                    dtt.Rows[0]["Amount"] = Convert.ToDecimal(dtt.Rows[0]["Amount"]) + modPR.Amount;
                                                    bllRep.UpdateByDt(dtt);
                                                }
                                                else
                                                {
                                                    DataRow dr = dtt.NewRow();
                                                    dr["ID"] = dr["A"] = 0;
                                                    dr["MListID"] = modMD.MListID;
                                                    dr["Amount"] = modPR.Amount;
                                                    dr["MeasureID"] = modMD.MeasureID;
                                                    dr["DepartmentID"] = DepotID;
                                                    dr["MaterielID"] = modMD.MaterielID;
                                                    dr["SizeID"] = modMD.SizeID;
                                                    dr["ColorID"] = modMD.ColorID;
                                                    dr["ColorOneID"] = modMD.ColorOneID;
                                                    dr["ColorTwoID"] = modMD.ColorTwoID;
                                                    dr["BrandID"] = 0;
                                                    dr["CompanyID"] = 0;
                                                    dr["PlanID"] = modMD.ProduceTaskID;
                                                    dtt.Rows.Add(dr);
                                                    bllRep.AddByDt(dtt);
                                                }
                                            }
                                            dtt = bllRep.GetList("(MListID=" + dt.Rows[i]["MListID"] + ") And (DepartmentID=" + DepotID + ") And (PlanID=0)").Tables[0];
                                            if (dtt.Rows.Count > 0)
                                            {
                                                dtt.Rows[0]["Amount"] = Convert.ToDecimal(dtt.Rows[0]["Amount"]) + modPR.Amount;
                                                bllRep.UpdateByDt(dtt);
                                            }
                                            else
                                            {
                                                DataRow dr = dtt.NewRow();
                                                dr["ID"] = dr["A"] = 0;
                                                dr["MListID"] = dt.Rows[i]["MListID"];
                                                dr["Amount"] = modPR.Amount;
                                                dr["MeasureID"] = dt.Rows[i]["DepotMeasureID"];
                                                dr["DepartmentID"] = DepotID;
                                                dr["MaterielID"] = dt.Rows[i]["MaterielID"];
                                                dr["SizeID"] = dt.Rows[i]["SizeID"];
                                                dr["ColorID"] = dt.Rows[i]["ColorID"];
                                                dr["ColorOneID"] = dt.Rows[i]["ColorOneID"];
                                                dr["ColorTwoID"] = dt.Rows[i]["ColorTwoID"];
                                                dr["BrandID"] = 0;
                                                dr["CompanyID"] = 0;
                                                dr["PlanID"] = 0;
                                                dtt.Rows.Add(dr);
                                                bllRep.AddByDt(dtt);
                                            }
                                        }
                                    }
                                }
                                #endregion
                                //记录超过采购的数量
                                if (Amount > 0)
                                {
                                    dtt = bllRep.GetList("(MListID=" + dt.Rows[i]["MListID"] + ") And (DepartmentID=" + DepotID + ") And (PlanID=0)").Tables[0];
                                    if (dtt.Rows.Count > 0)
                                    {
                                        dtt.Rows[0]["Amount"] = Convert.ToDecimal(dtt.Rows[0]["Amount"]) + Amount;
                                        dtt.Rows[0]["Money"] = Convert.ToDecimal(dtt.Rows[0]["Money"]) + modSBI.Money;
                                        dtt.Rows[0]["Price"] = Convert.ToDecimal(dtt.Rows[0]["Money"]) / Convert.ToDecimal(dtt.Rows[0]["Amount"]);
                                        bllRep.UpdateByDt(dtt);
                                    }
                                    else
                                    {
                                        DataRow dr = dtt.NewRow();
                                        dr["ID"] = dr["A"] = 0;
                                        dr["MListID"] = dt.Rows[i]["MListID"];
                                        dr["Amount"] = Amount;
                                        dr["MeasureID"] = dt.Rows[i]["DepotMeasureID"];
                                        dr["DepartmentID"] = DepotID;
                                        dr["MaterielID"] = dt.Rows[i]["MaterielID"];
                                        dr["SizeID"] = dt.Rows[i]["SizeID"];
                                        dr["ColorID"] = dt.Rows[i]["ColorID"];
                                        dr["ColorOneID"] = dt.Rows[i]["ColorOneID"];
                                        dr["ColorTwoID"] = dt.Rows[i]["ColorTwoID"];
                                        dr["BrandID"] = 0;
                                        dr["CompanyID"] = 0;
                                        dr["PlanID"] = 0;
                                        dr["Price"] = modSBI.Price;
                                        dr["Money"] = modSBI.Money;
                                        dtt.Rows.Add(dr);
                                        bllRep.AddByDt(dtt);
                                    }
                                    //记录超过采购单的数量到PR表，先查找是否有采购超过申购单的，即没有任务单编号的PR表记录，有则更新数量，没有则增加
                                    dtt = bllPR.GetList("(StockInfoID=" + dt.Rows[i]["ID"] + ") And (TaskID=0) And (TypeID=" + (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.库存已备料数量 + ")").Tables[0];
                                    if (dtt.Rows.Count > 0)
                                    {
                                        dtt.Rows[0]["NotAmount"] = Convert.ToDecimal(dtt.Rows[0]["NotAmount"]) + Amount;
                                        bllPR.UpdateByDt(dtt);
                                    }
                                    else
                                    {
                                        //
                                        modPR = new Hownet.Model.PlanUseRep();
                                        modPR.A = 1;
                                        modPR.DemandID = 0;
                                        modPR.ID = 0;
                                        modPR.MListID = Convert.ToInt32(dt.Rows[i]["MListID"]);
                                        modPR.RelatedID = 0;
                                        modPR.StockInfoID = Convert.ToInt32(dt.Rows[i]["ID"]);
                                        modPR.TaskID = 0;
                                        modPR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.库存已备料数量;
                                        modPR.IsEnd = 0;
                                        modPR.Amount = 0;
                                        modPR.NotAmount = Amount;
                                        bllPR.Add(modPR);
                                    }
                                }
                            }
                            else
                            {
                                modPR = new Hownet.Model.PlanUseRep();
                                modPR.A = 1;
                                modPR.DemandID = 0;
                                modPR.ID = 0;
                                modPR.MListID = Convert.ToInt32(dt.Rows[i]["MListID"]);
                                modPR.RelatedID = 0;
                                modPR.StockInfoID = Convert.ToInt32(dt.Rows[i]["ID"]);
                                modPR.TaskID = 0;
                                modPR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.库存已备料数量;
                                modPR.IsEnd = 0;
                                modPR.Amount = Convert.ToDecimal(dt.Rows[i]["Amount"]);
                                modPR.NotAmount = Convert.ToDecimal(dt.Rows[i]["Amount"]);
                            int xcc=    bllPR.Add(modPR);
                                dtt = bllRep.GetList("(MListID=" + dt.Rows[i]["MListID"] + ") And (DepartmentID=" + DepotID + ") And (PlanID=0)").Tables[0];
                                if (dtt.Rows.Count > 0)
                                {
                                    dtt.Rows[0]["Amount"] = Convert.ToDecimal(dtt.Rows[0]["Amount"]) + Convert.ToDecimal(dt.Rows[i]["Amount"]);
                                    bllRep.UpdateByDt(dtt);
                                }
                                else
                                {
                                    DataRow dr = dtt.NewRow();
                                    dr["ID"] = dr["A"] = 0;
                                    dr["MListID"] = dt.Rows[i]["MListID"];
                                    dr["Amount"] = Convert.ToDecimal(dt.Rows[i]["Amount"]);
                                    dr["MeasureID"] = dt.Rows[i]["CompanyMeasureID"];
                                    dr["DepartmentID"] = DepotID;
                                    dr["MaterielID"] = dt.Rows[i]["MaterielID"];
                                    dr["SizeID"] = dt.Rows[i]["SizeID"];
                                    dr["ColorID"] = dt.Rows[i]["ColorID"];
                                    dr["ColorOneID"] = dt.Rows[i]["ColorOneID"];
                                    dr["ColorTwoID"] = dt.Rows[i]["ColorTwoID"];
                                    dr["BrandID"] = 0;
                                    dr["CompanyID"] = 0;
                                    dr["PlanID"] = 0;
                                    dtt.Rows.Add(dr);
                                    bllRep.AddByDt(dtt);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                }
                else
                {
                    bllPR.DelStockBackByMainID(MainID);

                }
            }
        }
        public DataSet GetNeedInfoList(int IsEnd, int TypeID, int CompanyID)
        {
            return dal.GetNeedInfoList(IsEnd, TypeID, CompanyID);
        }
        public DataSet GetNeedInfoListQR(int IsEnd, int TypeID, int CompanyID)
        {
            DataSet ds=dal.GetNeedInfoListQR(IsEnd, TypeID, CompanyID);
            ds.Tables[0].Columns.Add("Amount", typeof(decimal));
            ds.Tables[0].Columns.Add("MainID", typeof(int));
            ds.Tables[0].Columns.Add("Remark", typeof(string));
            ds.Tables[0].Columns.Add("PriceAmount", typeof(decimal));
            ds.Tables[0].Columns.Add("NotPriceAmount", typeof(decimal));
            ds.Tables[0].Columns.Add("CompanyID", typeof(int));
            ds.Tables[0].Columns.Add("IsEnd", typeof(bool));
            ds.Tables[0].Columns.Add("DemandID", typeof(int));
            ds.Tables[0].Columns.Add("ExcessAmount",typeof(decimal));
            ds.Tables[0].Columns.Add("LastTime", typeof(DateTime));
            ds.Tables[0].Columns.Add("SpecID", typeof(int));
            ds.Tables[0].Columns.Add("MaterielName", typeof(string));
            ds.Tables[0].Columns.Add("ColorName", typeof(string));
            ds.Tables[0].Columns.Add("ColorOneName", typeof(string));
            ds.Tables[0].Columns.Add("ColorTwoName", typeof(string));
            ds.Tables[0].Columns.Add("SizeName", typeof(string));
            ds.Tables[0].Columns.Add("BrandName", typeof(string));
            ds.Tables[0].Columns.Add("SupplierID", typeof(int));
            ds.Tables[0].Columns.Add("SupplierName", typeof(string));
            ds.Tables[0].Columns.Add("SupplierSN", typeof(string));
            ds.Tables[0].Columns.Add("SpecName", typeof(string));
            ds.Tables[0].Columns.Add("Money", typeof(decimal));
            return ds;
        }
        public DataSet GetLinLiaoInfo(int MainID)
        {
            return dal.GetLinLiaoInfo(MainID);
        }
        /// <summary>
        /// 审核领料出库
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t">假为审核出库，真为弃审入库</param>
        public void VerifyLinLiao(int MainID, bool t,int DeparmentTypeID)
        {
            try
            {
                List<Hownet.Model.StockBackInfo> li = DataTableToList(GetList("(MainID=" + MainID + ")").Tables[0]);
                Hownet.BLL.StockBack bllSB = new StockBack();
                Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
                Hownet.Model.StockBack modSB = bllSB.GetModel(MainID);
                int PlanID = modSB.TaskID;
                if (DeparmentTypeID == 1)
                {
                    if (modSB.TaskID > 0)
                        PlanID = bllPTM.GetModel(modSB.TaskID).ParentID;
                }
                Hownet.BLL.Repertory bllRep = new Repertory();
                Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
                Hownet.Model.Repertory modRepTem = new Hownet.Model.Repertory();
                Hownet.Model.MaterielDemand modMD = new Hownet.Model.MaterielDemand();
                Hownet.BLL.StockBackInfoList bllSBIL = new StockBackInfoList();
                Hownet.BLL.RepertoryList bllRL = new RepertoryList();
                List<Hownet.Model.StockBackInfoList> liSBIL;
                List<Hownet.Model.MaterielDemand> liMD;
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].StockInfoID > 0)
                    {
                        modRep = bllRep.GetModel(li[i].StockInfoID);
                    }
                    else
                    {
                        modRep = new Hownet.Model.Repertory();
                    }
                    if (!t)
                    {
                        if (li[i].Amount > 0)
                        {
                            if (!(li[i].Amount > modRep.Amount))
                            {
                                modRep.Amount -= li[i].Amount;
                            }
                            else
                            {
                                if (li[i].CompanyID > 0)
                                {
                                    modRepTem = bllRep.GetModel(li[i].CompanyID);
                                    modRepTem.Amount -= (li[i].Amount - modRep.Amount);
                                    bllRep.Update(modRepTem);
                                }
                                modRep.Amount = 0;
                            }
                            bllRep.Update(modRep);
                        }
                        else
                        {
                            if (li[i].CompanyID > 0)
                            {
                                modRepTem = bllRep.GetModel(li[i].CompanyID);
                                modRepTem.Amount -= (li[i].Amount - modRep.Amount);
                                bllRep.Update(modRepTem);
                            }
                            else
                            {
                                DataTable dtTem = bllRep.GetList("(MListID=" + li[i].MListID + ") And (DepartmentID=" + modSB.DepotID + ") And (PlanID=0)").Tables[0];
                                if (dtTem.Rows.Count > 0)
                                {
                                    modRepTem = bllRep.GetModel(Convert.ToInt32(dtTem.Rows[0]["ID"]));
                                    modRepTem.Amount -= li[i].Amount;
                                    bllRep.Update(modRepTem);
                                }
                                else
                                {
                                    modRepTem = new Hownet.Model.Repertory();
                                    modRepTem.A = 0;
                                    modRepTem.Amount = li[i].Amount * -1;
                                    modRepTem.BrandID = li[i].BrandID;
                                    modRepTem.ColorID = li[i].ColorID;
                                    modRepTem.ColorOneID = li[i].ColorOneID;
                                    modRepTem.ColorTwoID = li[i].ColorTwoID;
                                    modRepTem.CompanyID = 0;
                                    modRepTem.DepartmentID = modSB.DepotID;
                                    modRepTem.ID = 0;
                                    modRepTem.MaterielID = li[i].MaterielID;
                                    modRepTem.MeasureID = li[i].DepotMeasureID;
                                    modRepTem.MListID = li[i].MListID;
                                    modRepTem.PlanID = 0;
                                    modRepTem.Remark = string.Empty;
                                    modRepTem.SizeID = li[i].SizeID;
                                    bllRep.Add(modRepTem);
                                }
                            }
                            //modRep.Amount = 0;
                            //bllRep.Update(modRep);
                        }
                    }
                    else
                    {
                        if (li[i].CompanyID == 0)
                        {
                            modRep.Amount += li[i].Amount;
                            bllRep.Update(modRep);
                        }
                        else
                        {
                            modRepTem = bllRep.GetModel(li[i].CompanyID);
                            modRepTem.Amount += li[i].Amount;
                            bllRep.Update(modRepTem);
                        }
                    }


                    if (li[i].DemandID > 0)
                    {
                        modMD = bllMD.GetModel(li[i].DemandID);
                        if (!t)
                        {
                            modMD.OutAmount += li[i].Amount;
                            modMD.RepertoryAmount -= li[i].Amount;
                            modMD.NotAllotAmount -= li[i].Amount;
                            //if (modMD.RepertoryAmount < 0)
                            //    modMD.RepertoryAmount = 0;
                            //if (modMD.NotAllotAmount < 0)
                            //    modMD.NotAllotAmount = 0;
                        }
                        else
                        {
                            modMD.OutAmount -= li[i].Amount;
                            modMD.RepertoryAmount += li[i].Amount;
                            modMD.NotAllotAmount += li[i].Amount;
                        }
                        bllMD.Update(modMD);
                        if (DeparmentTypeID == 1)
                        {
                            liMD = bllMD.DataTableToList(bllMD.GetList("(MListID=" + li[i].MListID + ") And (ProduceTaskID=" + PlanID + ")").Tables[0]);
                            if (liMD.Count > 0)
                            {
                                if (!t)
                                {
                                    liMD[0].OutAmount += li[i].Amount;
                                    liMD[0].RepertoryAmount -= li[i].Amount;
                                    liMD[0].NotAllotAmount -= li[i].Amount;
                                    //if (liMD[0].RepertoryAmount < 0)
                                    //    liMD[0].RepertoryAmount = 0;
                                    //if (liMD[0].NotAllotAmount < 0)
                                    //    liMD[0].NotAllotAmount = 0;
                                }
                                else
                                {
                                    liMD[0].OutAmount -= li[i].Amount;
                                    liMD[0].RepertoryAmount += li[i].Amount;
                                    liMD[0].NotAllotAmount += li[i].Amount;
                                }
                                bllMD.Update(liMD[0]);
                            }
                        }
                    }
                }
                if (DeparmentTypeID == 3&&modSB.Weight>0&&modSB.CompanyID>0)
                {
                    Hownet.BLL.Company bllCom = new Company();
                    Hownet.Model.Company modCom = bllCom.GetModel(modSB.CompanyID);
                    if (t)//弃审入库
                    {
                        modCom.Weight -= modSB.Weight;
                    }
                    else
                    {
                        modCom.Weight += modSB.Weight;
                    }
                    bllCom.Update(modCom);
                }
                liSBIL = bllSBIL.DataTableToList(bllSBIL.GetList("(MainID=" + MainID + ")").Tables[0]);
                if (liSBIL.Count > 0)
                {
                    Hownet.Model.RepertoryList modRL;
                    for (int i = 0; i < liSBIL.Count; i++)
                    {
                        modRL = bllRL.GetModel(Convert.ToInt32(liSBIL[i].RListID));
                        if (t)
                        {
                            modRL.NotAmount += liSBIL[i].NowAmount;
                        }
                        else
                        {
                            modRL.NotAmount -= liSBIL[i].NowAmount; 
                        }
                        bllRL.Update(modRL);

                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 审核半成品加工领料，真的弃审，假为审核
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t"></param>
        public void VerifyStockLinLiao(int MainID, bool t)
        {
            List<Hownet.Model.StockBackInfo> li = DataTableToList(GetList("(MainID=" + MainID + ")").Tables[0]);
            Hownet.BLL.StockBack bllSB = new StockBack();
         //   Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
         //   int PlanID = bllPTM.GetModel(bllSB.GetModel(MainID).TaskID).ParentID;
            Hownet.BLL.Repertory bllRep = new Repertory();
            Hownet.BLL.StockMaterielDemand bllSMD = new StockMaterielDemand();
            Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
            Hownet.Model.MaterielDemand modMD = new Hownet.Model.MaterielDemand();
            Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
            Hownet.Model.StockMaterielDemand modSMD = new Hownet.Model.StockMaterielDemand();

            List<Hownet.Model.MaterielDemand> liMD;
            for (int i = 0; i < li.Count; i++)
            {
                if (li[i].StockInfoID > 0)//库存
                {
                    modRep = bllRep.GetModel(li[i].StockInfoID);
                    if (!t)
                        modRep.Amount -= li[i].Amount;
                    else
                        modRep.Amount += li[i].Amount;
                    bllRep.Update(modRep);
                }
                if (li[i].DemandID > 0)//物料拆分
                {
                    modSMD = bllSMD.GetModel(li[i].DemandID);
                    if (!t)
                    {
                        modSMD.OutAmount += li[i].Amount;
                        modSMD.RepertoryAmount -= li[i].Amount;
                        modSMD.NotAllotAmount -= li[i].Amount;
                    }
                    else
                    {
                        modSMD.OutAmount -= li[i].Amount;
                        modSMD.RepertoryAmount += li[i].Amount;
                        modSMD.NotAllotAmount += li[i].Amount;
                    }
                    bllSMD.Update(modSMD);//生产计划物料拆分
                    liMD = bllMD.DataTableToList(bllMD.GetList("(MListID=" + li[i].MListID + ") And (ProduceTaskID=" + modSMD.PlanID + ")").Tables[0]);
                    if (liMD.Count > 0)
                    {
                        if (!t)
                        {
                            liMD[0].OutAmount += li[i].Amount;
                            liMD[0].RepertoryAmount -= li[i].Amount;
                            liMD[0].NotAllotAmount -= li[i].Amount;
                        }
                        else
                        {
                            liMD[0].OutAmount -= li[i].Amount;
                            liMD[0].RepertoryAmount += li[i].Amount;
                            liMD[0].NotAllotAmount += li[i].Amount;
                        }
                        bllMD.Update(liMD[0]);
                    }
                }
            }
        }
        public void UpIsEnd(int ID, int IsEnd)
        {
            dal.UpIsEnd(ID, IsEnd);
        }
           /// <summary>
        /// 采购单中有半成品时，获取明细数量以便用于计算所需物料
        /// </summary>
        /// <param name="TypeID">采购订单</param>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetSemi(int TypeID, int MainID)
        {
            return dal.GetSemi(TypeID, MainID);
        }
        /// <summary>
        /// 审核调拨单
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t">真为审核，假为弃审</param>
        /// <param name="InDepotID">调入仓</param>
        public void VerifyStorageAllocation(int MainID, bool t,int InDepotID)
        {
            try
            {
                List<Hownet.Model.StockBackInfo> li = DataTableToList(GetList("(MainID=" + MainID + ")").Tables[0]);
                if (li.Count > 0)
                {
                    Hownet.BLL.Repertory bllRep = new Repertory();
                    Hownet.Model.Repertory modRep;
                    List<Hownet.Model.Repertory> liRep;
                    for (int i = 0; i < li.Count; i++)
                    {
                        modRep = bllRep.GetModel(li[i].StockInfoID);
                        if (t)
                        {
                            modRep.Amount -= li[i].Amount;
                            bllRep.Update(modRep);

                            liRep = bllRep.DataTableToList(bllRep.GetList("(DepartmentID=" + InDepotID + ") And (MListID=" + modRep.MListID + ") And (PlanID=" + modRep.PlanID + ")").Tables[0]);
                            if (liRep.Count > 0)
                            {
                                liRep[0].Amount += li[i].Amount;
                                bllRep.Update(liRep[0]);
                            }
                            else
                            {
                                modRep.DepartmentID = InDepotID;
                                modRep.Amount = li[i].Amount;
                                bllRep.Add(modRep);
                            }
                        }
                        else
                        {
                            modRep.Amount += li[i].Amount;
                            bllRep.Update(modRep);
                            liRep = bllRep.DataTableToList(bllRep.GetList("(DepartmentID=" + InDepotID + ") And (MListID=" + modRep.MListID + ") And (PlanID=" + modRep.PlanID + ")").Tables[0]);
                            if (liRep.Count > 0)
                            {
                                liRep[0].Amount -= li[i].Amount;
                                if (liRep[0].Amount < 0)
                                    liRep[0].Amount = 0;
                                bllRep.Update(liRep[0]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 审核自主申购单
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t">真为审核，假为弃审</param>
        public void VerifyOneAddNeedStock(int MainID, bool t)
        {
            if (t)
            {
                List<Hownet.Model.StockBackInfo> li = DataTableToList(GetList("(MainID=" + MainID + ")").Tables[0]);
                if (li.Count > 0)
                {
                    Hownet.BLL.PlanUseRep bllPUR = new PlanUseRep();
                    Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                    Hownet.Model.PlanUseRep modPUR;
                    Hownet.Model.MaterielDemand modMD;
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (li[i].DemandID > 0)
                        {
                            modPUR = new Hownet.Model.PlanUseRep();
                            modPUR.Amount = modPUR.NotAmount = li[i].Amount;
                            modPUR.DemandID = li[i].DemandID;
                            modPUR.ID = 0;
                            modPUR.MListID = li[i].MListID;
                            modPUR.RelatedID = 0;
                            modPUR.StockInfoID = li[i].ID;
                            modPUR.TaskID = Convert.ToInt32(li[i].StringTaskID);
                            modPUR.TypeID = (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量;
                            bllPUR.Add(modPUR);
                            modMD = bllMD.GetModel(modPUR.DemandID);
                            modMD.NeedAmount += modPUR.Amount;
                            bllMD.Update(modMD);
                        }
                    }
                }
            }
            else
            {
                Hownet.BLL.PlanUseRep bllPUR = new PlanUseRep();
                bllPUR.DelNeedByStockMainID(MainID);
            }
        }
        /// <summary>
        /// 返回某单未完成的记录条数
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public int NotIsEnd(int MainID)
        {
            return dal.NotIsEnd(MainID);
        }
        /// <summary>
        /// 返回退货给某供应商时，该供应商之前的收货现有库存大于0的记录
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetBackSupp(int CompanyID, int DepotID)
        {
            return dal.GetBackSupp(CompanyID, DepotID);
        }
        /// <summary>
        /// 审核采购退货
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t">真为审核，假为弃审</param>
        public void VerifyBackSupp(int MainID,bool t)
        {
            try
            {
                Hownet.BLL.StockBack bllSB = new StockBack();
                Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                Hownet.BLL.Repertory bllRep = new Repertory();
                Hownet.BLL.PlanUseRep bllPR = new PlanUseRep();
                List<Hownet.Model.PlanUseRep> liPR;
                Hownet.Model.Repertory modRep;
                Hownet.Model.StockBack modSB = bllSB.GetModel(MainID);
                List<Hownet.Model.MaterielDemand> liMD;
                List<Hownet.Model.StockBackInfo> liSBI = DataTableToList(GetList("(MainID=" + MainID + ")").Tables[0]);
                for (int i = 0; i < liSBI.Count; i++)
                {
                    modRep = bllRep.GetModel(liSBI[i].DemandID);//更新库存数量
                    liPR = bllPR.DataTableToList(bllPR.GetList("(StockInfoID=" +liSBI[i].StockInfoID + ") And (TaskID=" + modRep.PlanID + ") And (TypeID=" + (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已采购数量 + ")").Tables[0]);
                    if (t)//审核
                    {
                        try
                        {
                            modRep.Amount -= liSBI[i].Amount;
                            liPR[0].NotAmount += liSBI[i].Amount;
                        }
                        catch
                        {
                        }
                    }
                    else//弃审
                    {
                        modRep.Amount += liSBI[i].Amount;
                        liPR[0].NotAmount -= liSBI[i].Amount;
                    }
                    bllRep.Update(modRep);
                    bllPR.Update(liPR[0]);
                    liMD = bllMD.DataTableToList(bllMD.GetList("(MListID=" + modRep.MListID + ") And (ProduceTaskID=" + modRep.PlanID + ")").Tables[0]);
                    if (liMD.Count > 0)
                    {
                        if (t)
                        {
                            liMD[0].RepertoryAmount -= liSBI[i].Amount;
                        }
                        else
                        {
                            liMD[0].RepertoryAmount += liSBI[i].Amount;
                        }
                        bllMD.Update(liMD[0]);
                    }
                }
                dal.UpBackSupp(MainID, t);
            }
            catch (Exception ex)
            {
            }
        }
        public void DelByStockInfoID(int StockInfoID)
        {
            dal.DelByStockInfoID(StockInfoID);
        }
          /// <summary>
        /// 物料加工单的领料明细
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetWXOutList(int MainID, int DepotID)
        {
            return dal.GetWXOutList(MainID, DepotID);
        }
        public DataSet GetMaterielOutList(int State, int CompanyID, int TaskID, DateTime dt1, DateTime dt2)
        {
            return dal.GetMaterielOutList(State, CompanyID, TaskID, dt1, dt2);
        }
        public DataSet GetListForOne(int Top, int CompanyID, int MaterielID, DateTime dt1, DateTime dt2,int Stata)
        {
            return dal.GetListForOne(Top, CompanyID, MaterielID, dt1, dt2,Stata);
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

