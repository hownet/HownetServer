﻿using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// BAS_FlowUpStatus
	/// </summary>
	public partial class BAS_FlowUpStatus
	{
		private readonly Hownet.DAL.BAS_FlowUpStatus dal=new Hownet.DAL.BAS_FlowUpStatus();
		public BAS_FlowUpStatus()
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
		public int  Add(Hownet.Model.BAS_FlowUpStatus model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.BAS_FlowUpStatus> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.BAS_FlowUpStatus model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.BAS_FlowUpStatus> li = DataTableToList(dt);
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
		public Hownet.Model.BAS_FlowUpStatus GetModel(int AutoInc)
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
		public List<Hownet.Model.BAS_FlowUpStatus> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.BAS_FlowUpStatus> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.BAS_FlowUpStatus> modelList = new List<Hownet.Model.BAS_FlowUpStatus>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.BAS_FlowUpStatus model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.BAS_FlowUpStatus();
					model.Code=dt.Rows[n]["Code"].ToString();
					model.CnName=dt.Rows[n]["CnName"].ToString();
					model.EnName=dt.Rows[n]["EnName"].ToString();
					if(dt.Rows[n]["SuccessRate"]!=null && dt.Rows[n]["SuccessRate"].ToString()!="")
					{
						model.SuccessRate=decimal.Parse(dt.Rows[n]["SuccessRate"].ToString());
					}
					if(dt.Rows[n]["IsValid"]!=null && dt.Rows[n]["IsValid"].ToString()!="")
					{
						if((dt.Rows[n]["IsValid"].ToString()=="1")||(dt.Rows[n]["IsValid"].ToString().ToLower()=="true"))
						{
						model.IsValid=true;
						}
						else
						{
							model.IsValid=false;
						}
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["AutoInc"]!=null && dt.Rows[n]["AutoInc"].ToString()!="")
					{
						model.AutoInc=int.Parse(dt.Rows[n]["AutoInc"].ToString());
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

