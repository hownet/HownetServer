using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// KQ_UserInfoList
	/// </summary>
	public partial class KQ_UserInfoList
	{
		private readonly Hownet.DAL.KQ_UserInfoList dal=new Hownet.DAL.KQ_UserInfoList();
		public KQ_UserInfoList()
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
		public int  Add(Hownet.Model.KQ_UserInfoList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_UserInfoList> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.KQ_UserInfoList model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_UserInfoList> li = DataTableToList(dt);
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
		public Hownet.Model.KQ_UserInfoList GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}


		/// <summary>
		/// LTP
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
		/// LTP
		/// </summary>
		public List<Hownet.Model.KQ_UserInfoList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// LTP
		/// </summary>
		public List<Hownet.Model.KQ_UserInfoList> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.KQ_UserInfoList> modelList = new List<Hownet.Model.KQ_UserInfoList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.KQ_UserInfoList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.KQ_UserInfoList();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["UserID"]!=null && dt.Rows[n]["UserID"].ToString()!="")
					{
						model.UserID=int.Parse(dt.Rows[n]["UserID"].ToString());
					}
					if(dt.Rows[n]["EmpID"]!=null && dt.Rows[n]["EmpID"].ToString()!="")
					{
						model.EmpID=int.Parse(dt.Rows[n]["EmpID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					if(dt.Rows[n]["FingerIndex"]!=null && dt.Rows[n]["FingerIndex"].ToString()!="")
					{
						model.FingerIndex=int.Parse(dt.Rows[n]["FingerIndex"].ToString());
					}
					model.FingerTemplate=dt.Rows[n]["FingerTemplate"].ToString();
					model.Privilege=dt.Rows[n]["Privilege"].ToString();
					model.Password=dt.Rows[n]["Password"].ToString();
					if(dt.Rows[n]["enabled"]!=null && dt.Rows[n]["enabled"].ToString()!="")
					{
						if((dt.Rows[n]["enabled"].ToString()=="1")||(dt.Rows[n]["enabled"].ToString().ToLower()=="true"))
						{
						model.enabled=true;
						}
						else
						{
							model.enabled=false;
						}
					}
					model.No=dt.Rows[n]["No"].ToString();
					model.CompanySN=dt.Rows[n]["CompanySN"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// LTP
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        public DataSet GetUserList()
        {
            return dal.GetUserList();
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

