using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// Bas_TestingScheme
	/// </summary>
	public partial class Bas_TestingScheme
	{
		private readonly Hownet.DAL.Bas_TestingScheme dal=new Hownet.DAL.Bas_TestingScheme();
		public Bas_TestingScheme()
		{}
		#region  Method
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long AutoInc)
		{
			return dal.Exists(AutoInc);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(Hownet.Model.Bas_TestingScheme model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public long AddByDt(DataTable dt)
		{
			List<Hownet.Model.Bas_TestingScheme> li = DataTableToList(dt);
			long a=0;
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
		public bool Update(Hownet.Model.Bas_TestingScheme model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Bas_TestingScheme> li = DataTableToList(dt);
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
		public bool Delete(long AutoInc)
		{
			
			return dal.Delete(AutoInc);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string AutoInclist )
		{
			return dal.DeleteList(AutoInclist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.Bas_TestingScheme GetModel(long AutoInc)
		{
			
			return dal.GetModel(AutoInc);
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
		public List<Hownet.Model.Bas_TestingScheme> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.Bas_TestingScheme> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Bas_TestingScheme> modelList = new List<Hownet.Model.Bas_TestingScheme>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Bas_TestingScheme model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Bas_TestingScheme();
					model.SchemeName=dt.Rows[n]["SchemeName"].ToString();
					model.SchemeEnName=dt.Rows[n]["SchemeEnName"].ToString();
					model.SchemeProduct=dt.Rows[n]["SchemeProduct"].ToString();
					model.SchemeContent=dt.Rows[n]["SchemeContent"].ToString();
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["AutoInc"]!=null && dt.Rows[n]["AutoInc"].ToString()!="")
					{
						model.AutoInc=long.Parse(dt.Rows[n]["AutoInc"].ToString());
					}
					model.SchemeAutoInc=dt.Rows[n]["SchemeAutoInc"].ToString();
					if(dt.Rows[n]["IsDef"]!=null && dt.Rows[n]["IsDef"].ToString()!="")
					{
						if((dt.Rows[n]["IsDef"].ToString()=="1")||(dt.Rows[n]["IsDef"].ToString().ToLower()=="true"))
						{
						model.IsDef=true;
						}
						else
						{
							model.IsDef=false;
						}
					}
					if(dt.Rows[n]["IsEnd"]!=null && dt.Rows[n]["IsEnd"].ToString()!="")
					{
						model.IsEnd=int.Parse(dt.Rows[n]["IsEnd"].ToString());
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

