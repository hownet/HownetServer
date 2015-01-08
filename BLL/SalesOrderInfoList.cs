using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类SalesOrderInfoList 的摘要说明。
	/// </summary>
	public class SalesOrderInfoList
	{
		private readonly Hownet.DAL.SalesOrderInfoList dal=new Hownet.DAL.SalesOrderInfoList();
		public SalesOrderInfoList()
		{}
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
		public int  Add(Hownet.Model.SalesOrderInfoList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SalesOrderInfoList> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.SalesOrderInfoList model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SalesOrderInfoList> li=DataTableToList(dt);
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
		public Hownet.Model.SalesOrderInfoList GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            DataSet ds = dal.GetList(strWhere);
            ds.Tables[0].Columns.Add("RowID", typeof(int));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["RowID"] = (i+1)*-1;
            }
            return ds;
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
		public List<Hownet.Model.SalesOrderInfoList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.SalesOrderInfoList> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SalesOrderInfoList> modelList = new List<Hownet.Model.SalesOrderInfoList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SalesOrderInfoList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SalesOrderInfoList();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					if(dt.Rows[n]["BrandID"].ToString()!="")
					{
						model.BrandID=int.Parse(dt.Rows[n]["BrandID"].ToString());
					}
					if(dt.Rows[n]["Num"].ToString()!="")
					{
						model.Num=int.Parse(dt.Rows[n]["Num"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}
					if(dt.Rows[n]["LastDate"].ToString()!="")
					{
						model.LastDate=DateTime.Parse(dt.Rows[n]["LastDate"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["Price"].ToString()!="")
					{
						model.Price=decimal.Parse(dt.Rows[n]["Price"].ToString());
					}
					if(dt.Rows[n]["IsVerify"].ToString()!="")
					{
						model.IsVerify=int.Parse(dt.Rows[n]["IsVerify"].ToString());
					}
					if(dt.Rows[n]["VerifyDate"].ToString()!="")
					{
						model.VerifyDate=DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
					}
					if(dt.Rows[n]["VerifyMan"].ToString()!="")
					{
						model.VerifyMan=int.Parse(dt.Rows[n]["VerifyMan"].ToString());
					}
					if(dt.Rows[n]["Progress"].ToString()!="")
					{
						model.Progress=int.Parse(dt.Rows[n]["Progress"].ToString());
					}
					if(dt.Rows[n]["UpData"].ToString()!="")
					{
						model.UpData=int.Parse(dt.Rows[n]["UpData"].ToString());
					}
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    else
                    {
                        model.MeasureID = 0;
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
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
                    if (dt.Rows[n]["PackingMethodID"].ToString() != "")
                    {
                        model.PackingMethodID = int.Parse(dt.Rows[n]["PackingMethodID"].ToString());
                    }
                    else
                    {
                        model.PackingMethodID = 0;
                    }
                    model.SewingRemark = dt.Rows[n]["SewingRemark"].ToString();
                    if (dt.Rows[n]["IsToPlan"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsToPlan"].ToString() == "1") || (dt.Rows[n]["IsToPlan"].ToString().ToLower() == "true"))
                        {
                            model.IsToPlan = true;
                        }
                        else
                        {
                            model.IsToPlan = false;
                        }
                    }
                    if (dt.Rows[n]["SunAmount"].ToString() != "")
                    {
                        model.SunAmount = int.Parse(dt.Rows[n]["SunAmount"].ToString());
                    }
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
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
        public int NewNum(DateTime dt)
        {
            return dal.NewNum(dt);
        }
        public DataSet GetSales(int CompanyID, int MaterielID, int BrandID, int TableTypeID)
        {
            return dal.GetSales(CompanyID, MaterielID, BrandID, TableTypeID);
        }
          /// <summary>
        /// 
        /// </summary>
        /// <param name="OneDate">开始日期</param>
        /// <param name="TwoDate">结束日期</param>
        /// <param name="IsHaveEnd">是否包含已完成的客户订单 </param>
        /// <param name="MatOrCom">按款号还是客户查询</param>
        /// <param name="TableTypeID">数量明细单类型</param>
        /// <returns></returns>
        public DataSet GetSalesList(object OneDate, object TwoDate, bool IsHaveEnd, int MatOrCom, int TableTypeID)
        {
            return dal.GetSalesList(OneDate, TwoDate, IsHaveEnd, MatOrCom, TableTypeID);
        }
        public DataSet GetNotAmount(int SalesID, int TableTypeID)
        {
            return dal.GetNotAmount(SalesID, TableTypeID);
        }
        public DataSet GetAllAmount(int MaterielID, int BrandID, int TableTypeID)
        {
            return dal.GetAllAmount(MaterielID, BrandID, TableTypeID);
        }
        public DataSet GetAllNotAmount(string IDS, int TableTypeID)
        {
            return dal.GetAllNotAmount(IDS, TableTypeID);
        }
        public DataSet GetAllAmountByMat(string IDS, int TableTypeID)
        {
            return dal.GetAllAmountByMat(IDS, TableTypeID);
        }
        public DataSet GetSalesListByMC(int MaterielID, int BrandID, int CompanyID, int TableTypeID)
        {
            return dal.GetSalesListByMC(MaterielID, BrandID, CompanyID, TableTypeID);
        }
        /// <summary>
        /// 转入生产计划
        /// </summary>
        /// <param name="SaleID"></param>
        /// <returns></returns>
        public int ToPlan(int SaleID,int FillMan)
        {
            try
            {
                // DataTable dt = GetList("(ID=" + SaleID + ")").Tables[0];
                Hownet.Model.SalesOrderInfoList modSOI = GetModel(SaleID);
                Hownet.BLL.SysTem bllST = new SysTem();
                Hownet.Model.SysTem modST = bllST.GetModel(bllST.GetMaxId() - 1);
                Hownet.BLL.ProductionPlan bllPP = new ProductionPlan();
                Hownet.Model.ProductionPlan modPP = new Hownet.Model.ProductionPlan();
                modPP.SalesOrderInfoID = modSOI.ID;// Convert.ToInt32(dt.Rows[0]["ID"]);
                modPP.MaterielID = modSOI.MaterielID;// Convert.ToInt32(dt.Rows[0]["MaterielID"]);
                modPP.BrandID = modSOI.BrandID;// Convert.ToInt32(dt.Rows[0]["BrandID"]);
                modPP.Num = modSOI.Num;// Convert.ToInt32(dt.Rows[0]["Num"]);// bllPP.NewNum(DateTime.Today, modST.NumType);
                // dalPP.NewNum(DateTime.Today, modST.NumType);
                modPP.DateTime = modSOI.DateTime;// Convert.ToDateTime(dt.Rows[0]["DateTime"]);// DateTime.Today;
                modPP.LastDate = modSOI.LastDate;// Convert.ToDateTime(dt.Rows[0]["LastDate"]);
                modPP.Remark = modSOI.Remark;// dt.Rows[0]["Remark"].ToString();
                modPP.PWorkingID = modPP.BomID = 0;
                modPP.CompanyID = modSOI.CompanyID;// Convert.ToInt32(dt.Rows[0]["CompanyID"]);
                modPP.IsTicket = modPP.IsBom = false;
                modPP.VerifyDate = Convert.ToDateTime("1900-1-1");
                modPP.VerifyMan = 0;
                modPP.DeparmentID = 0;
                modPP.UpData = 1;
                modPP.FillDate = DateTime.Today;
                modPP.FilMan = FillMan;
                modPP.TicketDate = Convert.ToDateTime("1900-1-1");
                modPP.BedNO = string.Empty;
                modPP.PackingMethodID = modSOI.PackingMethodID;// Convert.ToInt32(dt.Rows[0]["PackingMethodID"]);
                modPP.SewingRemark = modSOI.Remark + "\r\n" + modSOI.SewingRemark;// dt.Rows[0]["Remark"].ToString() + "\r\n" + dt.Rows[0]["SewingRemark"].ToString();
                modPP.TypeID = modPP.ParentID = 0;
                modPP.ParentID = 0;
                modPP.IsVerify = 1;
                modPP.AssociatedID = string.Empty;
                modPP.AssociatedMatID = 0;
                //dt.Rows[0]["IsToPlan"] = 1;
                modSOI.IsToPlan = true;
                Update(modSOI);
                // UpdateByDt(dt);
                return bllPP.Add(modPP);
            }
            catch (Exception ex)
            {
                return 0;
            }
           // return dal.ToPlan(SaleID, FillMan);
        }
        public DataSet GetSalesViewList(int TableTypeID, string strWhere)
        {
            try
            {
                return dal.GetSalesViewList(TableTypeID, strWhere);
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public DataSet GetAnalysisList(string strFiled,string strGroup, string strWhere)
        {
            return dal.GetAnalysisList(strFiled,strGroup, strWhere);
        }
        /// <summary>
        /// 删除该订单的生产计划
        /// </summary>
        /// <param name="ID"></param>
        public void DelPlan(int ID, int TableTypeID)
        {
            dal.DelPlan(ID, TableTypeID);
        }
        /// <summary>
        /// 删除一份订单合同下的所有明细
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        public void DeleteByMainID(int MainID)
        {
            dal.DeleteByMainID(MainID);
        }
        /// <summary>
        /// 销售 发货时，某客户订单的颜色总数
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet GetSumColorAmount(int MainID, int TableTypeID)
        {
            return dal.GetSumColorAmount(MainID, TableTypeID);
        }
        public DataSet GetNumList(string strWhere)
        {
            return dal.GetNumList(strWhere);
        }
        public DataSet GetListForOne(int Top,int CompanyID,int MaterielID,DateTime dt1,DateTime dt2)
        {
            return dal.GetListForOne(Top, CompanyID, MaterielID, dt1, dt2);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

