using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// MesgInfo
	/// </summary>
	public partial class MesgInfo
	{
		private readonly Hownet.DAL.MesgInfo dal=new Hownet.DAL.MesgInfo();
		public MesgInfo()
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
		public int  Add(Hownet.Model.MesgInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.MesgInfo> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.MesgInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.MesgInfo> li = DataTableToList(dt);
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
		public Hownet.Model.MesgInfo GetModel(int ID)
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
		public List<Hownet.Model.MesgInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.MesgInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.MesgInfo> modelList = new List<Hownet.Model.MesgInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.MesgInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.MesgInfo();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"]!=null && dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["ToID"]!=null && dt.Rows[n]["ToID"].ToString()!="")
					{
						model.ToID=int.Parse(dt.Rows[n]["ToID"].ToString());
					}
					model.ToMan=dt.Rows[n]["ToMan"].ToString();
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["IsRead"]!=null && dt.Rows[n]["IsRead"].ToString()!="")
					{
						if((dt.Rows[n]["IsRead"].ToString()=="1")||(dt.Rows[n]["IsRead"].ToString().ToLower()=="true"))
						{
						model.IsRead=true;
						}
						else
						{
							model.IsRead=false;
						}
					}
					if(dt.Rows[n]["IsEnd"]!=null && dt.Rows[n]["IsEnd"].ToString()!="")
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
					if(dt.Rows[n]["IsComplete"]!=null && dt.Rows[n]["IsComplete"].ToString()!="")
					{
						if((dt.Rows[n]["IsComplete"].ToString()=="1")||(dt.Rows[n]["IsComplete"].ToString().ToLower()=="true"))
						{
						model.IsComplete=true;
						}
						else
						{
							model.IsComplete=false;
						}
					}
					if(dt.Rows[n]["LastDateTime"]!=null && dt.Rows[n]["LastDateTime"].ToString()!="")
					{
						model.LastDateTime=DateTime.Parse(dt.Rows[n]["LastDateTime"].ToString());
					}
					if(dt.Rows[n]["CompleteDateTime"]!=null && dt.Rows[n]["CompleteDateTime"].ToString()!="")
					{
						model.CompleteDateTime=DateTime.Parse(dt.Rows[n]["CompleteDateTime"].ToString());
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

