using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类RepertoryList 的摘要说明。
	/// </summary>
	public class RepertoryList
	{
		private readonly Hownet.DAL.RepertoryList dal=new Hownet.DAL.RepertoryList();
		public RepertoryList()
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
		public int  Add(Hownet.Model.RepertoryList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.RepertoryList> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.RepertoryList model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.RepertoryList> li=DataTableToList(dt);
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
		public Hownet.Model.RepertoryList GetModel(int ID)
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
		public List<Hownet.Model.RepertoryList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.RepertoryList> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.RepertoryList> modelList = new List<Hownet.Model.RepertoryList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.RepertoryList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.RepertoryList();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					else
					{
						model.Amount=0;
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["NotAmount"].ToString()!="")
					{
						model.NotAmount=decimal.Parse(dt.Rows[n]["NotAmount"].ToString());
					}
					else
					{
						model.NotAmount=0;
					}
					if(dt.Rows[n]["StockListID"].ToString()!="")
					{
						model.StockListID=int.Parse(dt.Rows[n]["StockListID"].ToString());
					}
					else
					{
						model.StockListID=0;
					}
					if(dt.Rows[n]["BatchNumber"].ToString()!="")
					{
						model.BatchNumber=int.Parse(dt.Rows[n]["BatchNumber"].ToString());
					}
					else
					{
						model.BatchNumber=0;
					}
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						if((dt.Rows[n]["IsEnd"].ToString()=="1")||(dt.Rows[n]["IsEnd"].ToString().ToLower()=="true"))
						{
						model.IsEnd=true;
						}
						else
						{
							model.IsEnd=false;
						}
					}
                    if (dt.Rows[n]["SpecID"] != null && dt.Rows[n]["SpecID"].ToString() != "")
                    {
                        model.SpecID = int.Parse(dt.Rows[n]["SpecID"].ToString());
                    }
                    model.SpecName = dt.Rows[n]["SpecName"].ToString();
                    if (dt.Rows[n]["DepotInfoID"] != null && dt.Rows[n]["DepotInfoID"].ToString() != "")
                    {
                        model.DepotInfoID = int.Parse(dt.Rows[n]["DepotInfoID"].ToString());
                    }
                    model.DepotInfoName = dt.Rows[n]["DepotInfoName"].ToString();
                    if (dt.Rows[n]["DateTime"] != null && dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["PlanID"] != null && dt.Rows[n]["PlanID"].ToString() != "")
                    {
                        model.PlanID = int.Parse(dt.Rows[n]["PlanID"].ToString());
                    }
                    model.QRID = dt.Rows[n]["QRID"].ToString();
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
        /// <summary>
        ///根据收货明细 删除一条数据
        /// </summary>
        public bool DeleteByStockInfoID(int ID)
        {

            return dal.DeleteByStockInfoID(ID);
        }
        public void UpPlanID(int ID, int PlanID)
        {
            dal.UpPlanID(ID, PlanID);
        }
                /// <summary>
        /// 根据款号和商标，返回库存数量
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <param name="BrandID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetListByMB(int MaterielID, int BrandID, int DepotID)
        {
            return dal.GetListByMB(MaterielID, BrandID, DepotID);
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

