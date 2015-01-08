using System;
using System.Data;

using Hownet.Model;
using System.Data.SqlClient;
using System.Collections.Generic;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类MaterielDemand 的摘要说明。
	/// </summary>
	public class MaterielDemand
	{
		private readonly Hownet.DAL.MaterielDemand dal=new Hownet.DAL.MaterielDemand();
		public MaterielDemand()
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
		public int  Add(Hownet.Model.MaterielDemand model)
		{
			return dal.Add(model);
		}

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielDemand> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.MaterielDemand model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielDemand> li = DataTableToList(dt);
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
		public Hownet.Model.MaterielDemand GetModel(int ID)
		{
			return dal.GetModel(ID);
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.MaterielDemand> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MaterielDemand> modelList = new List<Hownet.Model.MaterielDemand>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MaterielDemand model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MaterielDemand();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["ProduceTaskID"].ToString() != "")
                    {
                        model.ProduceTaskID = int.Parse(dt.Rows[n]["ProduceTaskID"].ToString());
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
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    if (dt.Rows[n]["NotAllotAmount"].ToString() != "")
                    {
                        model.NotAllotAmount = decimal.Parse(dt.Rows[n]["NotAllotAmount"].ToString());
                    }
                    if (dt.Rows[n]["stockAmount"].ToString() != "")
                    {
                        model.stockAmount = decimal.Parse(dt.Rows[n]["stockAmount"].ToString());
                    }
                    if (dt.Rows[n]["stockNotAmount"].ToString() != "")
                    {
                        model.stockNotAmount = decimal.Parse(dt.Rows[n]["stockNotAmount"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    if (dt.Rows[n]["DepID"].ToString() != "")
                    {
                        model.DepID = int.Parse(dt.Rows[n]["DepID"].ToString());
                    }
                    if (dt.Rows[n]["MListID"].ToString() != "")
                    {
                        model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                    }
                    if (dt.Rows[n]["TableTypeID"].ToString() != "")
                    {
                        model.TableTypeID = int.Parse(dt.Rows[n]["TableTypeID"].ToString());
                    }
                    else
                    {
                        model.TableTypeID = 0;
                    }
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                    }
                    else
                    {
                        model.IsEnd = 0;
                    }
                    if (dt.Rows[n]["RepertoryAmount"].ToString() != "")
                    {
                        model.RepertoryAmount = decimal.Parse(dt.Rows[n]["RepertoryAmount"].ToString());
                    }
                    else
                    {
                        model.RepertoryAmount = 0;
                    }
                    if (dt.Rows[n]["NeedAmount"].ToString() != "")
                    {
                        model.NeedAmount = decimal.Parse(dt.Rows[n]["NeedAmount"].ToString());
                    }
                    else
                    {
                        model.NeedAmount = 0;
                    }
                    if (dt.Rows[n]["HasStockAmount"].ToString() != "")
                    {
                        model.HasStockAmount = decimal.Parse(dt.Rows[n]["HasStockAmount"].ToString());
                    }
                    else
                    {
                        model.HasStockAmount = 0;
                    }
                    if (dt.Rows[n]["OutAmount"].ToString() != "")
                    {
                        model.OutAmount = decimal.Parse(dt.Rows[n]["OutAmount"].ToString());
                    }
                    else
                    {
                        model.OutAmount = 0;
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        
        /// <summary>
        /// 取得生产单拆分后的列表
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetTask(int TaskID, int TableTypeID)
        {
            return dal.GetTask(TaskID, TableTypeID);
        }
          /// <summary>
        /// 取得某一未配货物料的明细
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet ShowInfo(int MListID)
        {
            return dal.ShowInfo(MListID);
        }
        /// <summary>
        /// 删除某次已计算的物料需求GetNeedAmountByMListID
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        public void DelNeed(int MainID, int TableTypeID)
        {
            dal.DelNeed(MainID, TableTypeID);
        }
          /// <summary>
        /// 在物料计划时，返回一系列计划单的物料情况
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNeedAmount(string strWhere,string strTask)
        {
            return dal.GetNeedAmount(strWhere,strTask);
        }
          /// <summary>
        /// 获取在一些计划单中，使用某物料的明细，用于分配使用库存量或使用采购余量
        /// </summary>
        /// <param name="MListID"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNeedAmountByMListID(int MListID, string strWhere,int TypeID,string strTaskID)
        {
            return dal.GetNeedAmountByMListID(MListID, strWhere,TypeID,strTaskID);
        }
        /// <summary>
        /// 查找某生产计划或生产单的数量，用于手动增加申购单
        /// </summary>
        /// <param name="PlanID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet GetListByPlanID(int PlanID, int TableTypeID)
        {
            return dal.GetListByPlanID(PlanID, TableTypeID);
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

