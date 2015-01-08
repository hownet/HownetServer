using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// Bas_TestingManager
	/// </summary>
	public partial class Bas_TestingManager
	{
		private readonly Hownet.DAL.Bas_TestingManager dal=new Hownet.DAL.Bas_TestingManager();
		public Bas_TestingManager()
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
		public bool Exists(int AutoInc)
		{
			return dal.Exists(AutoInc);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Hownet.Model.Bas_TestingManager model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Bas_TestingManager> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.Bas_TestingManager model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Bas_TestingManager> li = DataTableToList(dt);
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
		public bool Delete(int AutoInc)
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
		public Hownet.Model.Bas_TestingManager GetModel(int AutoInc)
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
		public List<Hownet.Model.Bas_TestingManager> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.Bas_TestingManager> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Bas_TestingManager> modelList = new List<Hownet.Model.Bas_TestingManager>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Bas_TestingManager model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Bas_TestingManager();
					model.TestingNo=dt.Rows[n]["TestingNo"].ToString();
					model.ProCnName=dt.Rows[n]["ProCnName"].ToString();
					model.ProEnName=dt.Rows[n]["ProEnName"].ToString();
					model.QualityReq_C=dt.Rows[n]["QualityReq_C"].ToString();
					model.QualityReq_E=dt.Rows[n]["QualityReq_E"].ToString();
					model.StandardReq_C=dt.Rows[n]["StandardReq_C"].ToString();
					model.StandardReq_E=dt.Rows[n]["StandardReq_E"].ToString();
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["AutoInc"]!=null && dt.Rows[n]["AutoInc"].ToString()!="")
					{
						model.AutoInc=int.Parse(dt.Rows[n]["AutoInc"].ToString());
					}
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

