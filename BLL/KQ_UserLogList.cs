using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// KQ_UserLogList
	/// </summary>
	public partial class KQ_UserLogList
	{
		private readonly Hownet.DAL.KQ_UserLogList dal=new Hownet.DAL.KQ_UserLogList();
		public KQ_UserLogList()
		{}
		#region  Method

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
		public int  Add(Hownet.Model.KQ_UserLogList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_UserLogList> li = DataTableToList(dt);
			int a=0;
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					a=Add(li[i]);
				}
			}
				return a;
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Hownet.Model.KQ_UserLogList model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_UserLogList> li = DataTableToList(dt);
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					 dal.Update(li[i]);
				}
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.KQ_UserLogList GetModel(int ID)
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
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.KQ_UserLogList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.KQ_UserLogList> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.KQ_UserLogList> modelList = new List<Hownet.Model.KQ_UserLogList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.KQ_UserLogList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.KQ_UserLogList();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["UserID"]!=null && dt.Rows[n]["UserID"].ToString()!="")
					{
						model.UserID=int.Parse(dt.Rows[n]["UserID"].ToString());
					}
					if(dt.Rows[n]["Nian"]!=null && dt.Rows[n]["Nian"].ToString()!="")
					{
						model.Nian=int.Parse(dt.Rows[n]["Nian"].ToString());
					}
					if(dt.Rows[n]["Yue"]!=null && dt.Rows[n]["Yue"].ToString()!="")
					{
						model.Yue=int.Parse(dt.Rows[n]["Yue"].ToString());
					}
					if(dt.Rows[n]["Ri"]!=null && dt.Rows[n]["Ri"].ToString()!="")
					{
						model.Ri=int.Parse(dt.Rows[n]["Ri"].ToString());
					}
					if(dt.Rows[n]["Shi"]!=null && dt.Rows[n]["Shi"].ToString()!="")
					{
						model.Shi=int.Parse(dt.Rows[n]["Shi"].ToString());
					}
					if(dt.Rows[n]["Fen"]!=null && dt.Rows[n]["Fen"].ToString()!="")
					{
						model.Fen=int.Parse(dt.Rows[n]["Fen"].ToString());
					}
					if(dt.Rows[n]["Miao"]!=null && dt.Rows[n]["Miao"].ToString()!="")
					{
						model.Miao=int.Parse(dt.Rows[n]["Miao"].ToString());
					}
					model.CompanySN=dt.Rows[n]["CompanySN"].ToString();
					if(dt.Rows[n]["OldID"]!=null && dt.Rows[n]["OldID"].ToString()!="")
					{
						model.OldID=int.Parse(dt.Rows[n]["OldID"].ToString());
					}
					model.DateOne=dt.Rows[n]["DateOne"].ToString();
					model.TimeOne=dt.Rows[n]["TimeOne"].ToString();
					if(dt.Rows[n]["DateTime"]!=null && dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
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
        public DataSet GetLogsList(int UserID, DateTime dt1, DateTime dt2)
        {
            return dal.GetLogsList(UserID, dt1, dt2);
        }
        public DataSet GetLogsUser(DateTime dt1, DateTime dt2)
        {
            return dal.GetLogsUser(dt1, dt2);
        }
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

