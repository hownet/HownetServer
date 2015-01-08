using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类CaicDayMoney 的摘要说明。
	/// </summary>
	public class CaicDayMoney
	{
		private readonly Hownet.DAL.CaicDayMoney dal=new Hownet.DAL.CaicDayMoney();
		public CaicDayMoney()
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
		public int  Add(Hownet.Model.CaicDayMoney model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.CaicDayMoney> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.CaicDayMoney model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.CaicDayMoney> li=DataTableToList(dt);
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
		public Hownet.Model.CaicDayMoney GetModel(int ID)
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
		public List<Hownet.Model.CaicDayMoney> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.CaicDayMoney> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.CaicDayMoney> modelList = new List<Hownet.Model.CaicDayMoney>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.CaicDayMoney model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.CaicDayMoney();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["DayMoney"].ToString()!="")
					{
						model.DayMoney=decimal.Parse(dt.Rows[n]["DayMoney"].ToString());
					}
					else
					{
						model.DayMoney=0;
					}
					if(dt.Rows[n]["NightMoney"].ToString()!="")
					{
						model.NightMoney=decimal.Parse(dt.Rows[n]["NightMoney"].ToString());
					}
					else
					{
						model.NightMoney=0;
					}
					if(dt.Rows[n]["LateAtNightMoney"].ToString()!="")
					{
						model.LateAtNightMoney=decimal.Parse(dt.Rows[n]["LateAtNightMoney"].ToString());
					}
					else
					{
						model.LateAtNightMoney=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["TXBT"].ToString()!="")
					{
						model.TXBT=decimal.Parse(dt.Rows[n]["TXBT"].ToString());
					}
					else
					{
						model.TXBT=0;
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
        public DataSet GetLookupList()
        {
            return dal.GetLookupList();
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

