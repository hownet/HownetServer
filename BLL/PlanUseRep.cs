using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类PlanUseRep 的摘要说明。
	/// </summary>
	public class PlanUseRep
	{
		private readonly Hownet.DAL.PlanUseRep dal=new Hownet.DAL.PlanUseRep();
		public PlanUseRep()
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
		public int  Add(Hownet.Model.PlanUseRep model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.PlanUseRep> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.PlanUseRep model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.PlanUseRep> li=DataTableToList(dt);
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
		public Hownet.Model.PlanUseRep GetModel(int ID)
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
		public List<Hownet.Model.PlanUseRep> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.PlanUseRep> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.PlanUseRep> modelList = new List<Hownet.Model.PlanUseRep>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.PlanUseRep model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.PlanUseRep();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["RelatedID"].ToString()!="")
					{
						model.RelatedID=int.Parse(dt.Rows[n]["RelatedID"].ToString());
					}
					else
					{
						model.RelatedID=0;
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					else
					{
						model.Amount=0;
					}
					if(dt.Rows[n]["DemandID"].ToString()!="")
					{
						model.DemandID=int.Parse(dt.Rows[n]["DemandID"].ToString());
					}
					else
					{
						model.DemandID=0;
					}
					if(dt.Rows[n]["TypeID"].ToString()!="")
					{
						model.TypeID=int.Parse(dt.Rows[n]["TypeID"].ToString());
					}
					else
					{
						model.TypeID=0;
					}
					if(dt.Rows[n]["MListID"].ToString()!="")
					{
						model.MListID=int.Parse(dt.Rows[n]["MListID"].ToString());
					}
					else
					{
						model.MListID=0;
					}
					if(dt.Rows[n]["TaskID"].ToString()!="")
					{
						model.TaskID=int.Parse(dt.Rows[n]["TaskID"].ToString());
					}
					else
					{
						model.TaskID=0;
					}
					if(dt.Rows[n]["StockInfoID"].ToString()!="")
					{
						model.StockInfoID=int.Parse(dt.Rows[n]["StockInfoID"].ToString());
					}
					else
					{
						model.StockInfoID=0;
					}
                    if (dt.Rows[n]["NotAmount"].ToString() != "")
                    {
                        model.NotAmount = decimal.Parse(dt.Rows[n]["NotAmount"].ToString());
                    }
                    else
                    {
                        model.NotAmount = 0;
                    }
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                    }
                    else
                    {
                        model.IsEnd = 0;
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
        public decimal GetAmount(int MListID, int TypeID, string strTask)
        {
            return dal.GetAmount(MListID, TypeID, strTask);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="MListID"></param>
        /// <param name="DemandID"></param>
        /// <param name="StockInfoID"></param>
        /// <param name="Amount"></param>
        /// <param name="TypeID"></param>
        /// <param name="TaskID"></param>
        /// <param name="RelatedID"></param>
        /// <param name="t">真的添加记录，假为删除记录</param>
        public void UpAmount(int MListID, int DemandID, int StockInfoID, decimal Amount, int TypeID,int TaskID,int RelatedID,bool t,int DepotID)
        {
            #region 使用原仓存
            if (TypeID == (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.使用原仓存)
            {
                if (t)
                {
                    //查看之前使用库存的记录,将本次使用原仓存的数更新到数据表。
                    Hownet.BLL.Repertory bllRep = new Repertory();
                    Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
                    Hownet.Model.Repertory modRep = bllRep.GetModel(RelatedID);//需要转出的空闲物料
                    Hownet.Model.MaterielDemand modMD = bllMD.GetModel(DemandID);
                    modRep.Amount = modRep.Amount - Amount;//扣掉有使用的空余数量
                    bllRep.Update(modRep);
                    modMD.RepertoryAmount += Amount;//更新物料拆分表的已备料数量
                    bllMD.Update(modMD);
                    //是否此前有本计划单的备料
                    DataTable dt = bllRep.GetList("(MListID=" + MListID + ") And  (PlanID=" + TaskID + ") And (DepartmentID=" + DepotID + ")").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        //已有，则加上本次数量
                        dt.Rows[0]["Amount"] = Convert.ToDecimal(dt.Rows[0]["Amount"]) + Amount;
                        bllRep.UpdateByDt(dt);
                    }
                    else
                    {
                        //没有则插入此数量
                        modRep.Amount = Amount;
                        modRep.PlanID = TaskID;
                        modRep.DepartmentID = DepotID;
                        bllRep.Add(modRep);
                    }
                }
                else
                {

                }
            }
            #endregion
            #region 已申购数量
            else if (TypeID == (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量)
            {
                if (t)
                {
                    //更新这个生产计划中该物料的已申购数量
                    DataTable dt = GetList("(StockInfoID=" + StockInfoID + ") And (TypeID=" + (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量 + ")").Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        dt.Rows[0]["Amount"] = Convert.ToDecimal(dt.Rows[0]["Amount"]) + Amount;
                        dt.Rows[0]["NotAmount"] = Convert.ToDecimal(dt.Rows[0]["NotAmount"]) + Amount;
                        UpdateByDt(dt);
                    }
                    else
                    {
                        DataRow dr = dt.NewRow();
                        dr["RelatedID"] = RelatedID;
                        dr["Amount"] = Amount;
                        dr["DemandID"] = DemandID;
                        dr["TypeID"] = (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量;
                        dr["MListID"] = MListID;
                        dr["TaskID"] = TaskID;
                        dr["StockInfoID"] = 0;
                        dr["NotAmount"] = Amount;
                        dr["IsEnd"] = 0;
                        dr["A"] = 1;
                        dt.Rows.Add(dr);
                        AddByDt(dt);
                    }
                }
                else
                {

                }
            }
            #endregion
            #region 已采购数量
            else if (TypeID == (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.已采购数量)
            {

            }
            #endregion
        }
        /// <summary>
        /// 计算某生产单中某物料需采购数量，物料计算的需采购量-已有库存-已申购-已采购，如果车间有领货，则直接在物料
        /// 计算的StockNotAmount字段中扣减。
        /// </summary>
        /// <param name="MListID"></param>
        /// <param name="DemandID"></param>
        /// <returns></returns>
        public decimal GetNeedStock(int MListID, int DemandID)
        {
            return dal.GetNeedStock(MListID, DemandID, (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.使用原仓存, (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.已申购数量, (int)Hownet.BLL.BaseFile.MaterielDemandClass.PlanUseRep.已采购数量, (int)BLL.BaseFile.MaterielDemandClass.PlanUseRep.车间已领用数量);
        }
         /// <summary>
        /// 删除某一申购单、采购单、采购收货单的分订单明细
        /// </summary>
        /// <param name="MainID"></param>
        public void DelStockByStockMainID(int MainID)
        {
            dal.DelStockByStockMainID(MainID);
        }
         /// <summary>
        /// 删除某一申购单的分订单明细，扣减物料拆分中已采购数量
        /// </summary>
        /// <param name="MainID"></param>
        public void DelNeedByStockMainID(int MainID)
        {
            dal.DelNeedByStockMainID(MainID);
        }
         /// <summary>
        /// 弃审采购收货，更新系列表。
        /// </summary>
        /// <param name="MainID"></param>
        public void DelStockBackByMainID(int MainID)
        {
            dal.DelStockBackByMainID(MainID);
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

