using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类StockBackInfoList 的摘要说明。
	/// </summary>
	public class StockBackInfoList
	{
		private readonly Hownet.DAL.StockBackInfoList dal=new Hownet.DAL.StockBackInfoList();
		public StockBackInfoList()
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
		public int  Add(Hownet.Model.StockBackInfoList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.StockBackInfoList> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.StockBackInfoList model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.StockBackInfoList> li=DataTableToList(dt);
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
		public Hownet.Model.StockBackInfoList GetModel(int ID)
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
		public List<Hownet.Model.StockBackInfoList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.StockBackInfoList> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.StockBackInfoList> modelList = new List<Hownet.Model.StockBackInfoList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.StockBackInfoList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.StockBackInfoList();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["InfoID"].ToString()!="")
					{
						model.InfoID=int.Parse(dt.Rows[n]["InfoID"].ToString());
					}
					else
					{
						model.InfoID=0;
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					else
					{
						model.Amount=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["IsOK"].ToString()!="")
					{
						if((dt.Rows[n]["IsOK"].ToString()=="1")||(dt.Rows[n]["IsOK"].ToString().ToLower()=="true"))
						{
						model.IsOK=true;
						}
						else
						{
							model.IsOK=false;
						}
					}
					if(dt.Rows[n]["BatchNumber"].ToString()!="")
					{
						model.BatchNumber=int.Parse(dt.Rows[n]["BatchNumber"].ToString());
					}
					else
					{
						model.BatchNumber=0;
					}
					if(dt.Rows[n]["NotAmount"].ToString()!="")
					{
						model.NotAmount=decimal.Parse(dt.Rows[n]["NotAmount"].ToString());
					}
					else
					{
						model.NotAmount=0;
					}
                    if (dt.Rows[n]["SpecID"] != null && dt.Rows[n]["SpecID"].ToString() != "")
                    {
                        model.SpecID = int.Parse(dt.Rows[n]["SpecID"].ToString());
                    }
                    if (dt.Rows[n]["DepotInfoID"] != null && dt.Rows[n]["DepotInfoID"].ToString() != "")
                    {
                        model.DepotInfoID = int.Parse(dt.Rows[n]["DepotInfoID"].ToString());
                    }
                    if (dt.Rows[n]["MainID"] != null && dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    model.QRID = dt.Rows[n]["QRID"].ToString();
                    if (dt.Rows[n]["NowAmount"] != null && dt.Rows[n]["NowAmount"].ToString() != "")
                    {
                        model.NowAmount = decimal.Parse(dt.Rows[n]["NowAmount"].ToString());
                    }
                    if (dt.Rows[n]["RListID"] != null && dt.Rows[n]["RListID"].ToString() != "")
                    {
                        model.RListID = int.Parse(dt.Rows[n]["RListID"].ToString());
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


         public bool DeleteByInfoID(int InfoID)
        {
           return dal.DeleteByInfoID(InfoID);
        }

         public bool DeleteByMainID(int MainID)
         {
             return dal.DeleteByMainID(MainID);
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

