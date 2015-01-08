using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// FixedAssetsOut
	/// </summary>
	public partial class FixedAssetsOut
	{
		private readonly Hownet.DAL.FixedAssetsOut dal=new Hownet.DAL.FixedAssetsOut();
		public FixedAssetsOut()
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
		public int  Add(Hownet.Model.FixedAssetsOut model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.FixedAssetsOut> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.FixedAssetsOut model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.FixedAssetsOut> li = DataTableToList(dt);
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
		public Hownet.Model.FixedAssetsOut GetModel(int ID)
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
		public List<Hownet.Model.FixedAssetsOut> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.FixedAssetsOut> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.FixedAssetsOut> modelList = new List<Hownet.Model.FixedAssetsOut>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.FixedAssetsOut model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.FixedAssetsOut();
					if(dt.Rows[n]["A"].ToString()!="")
					{
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
					}
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["FAID"].ToString()!="")
					{
						model.FAID=int.Parse(dt.Rows[n]["FAID"].ToString());
					}
					if(dt.Rows[n]["OutDate"].ToString()!="")
					{
						model.OutDate=DateTime.Parse(dt.Rows[n]["OutDate"].ToString());
					}
					if(dt.Rows[n]["ExpectedBackDate"].ToString()!="")
					{
						model.ExpectedBackDate=DateTime.Parse(dt.Rows[n]["ExpectedBackDate"].ToString());
					}
					if(dt.Rows[n]["ActualBackDate"].ToString()!="")
					{
						model.ActualBackDate=DateTime.Parse(dt.Rows[n]["ActualBackDate"].ToString());
					}
					if(dt.Rows[n]["OutDeparmentID"].ToString()!="")
					{
						model.OutDeparmentID=int.Parse(dt.Rows[n]["OutDeparmentID"].ToString());
					}
					if(dt.Rows[n]["OutUserID"].ToString()!="")
					{
						model.OutUserID=int.Parse(dt.Rows[n]["OutUserID"].ToString());
					}
					if(dt.Rows[n]["VerifyManID"].ToString()!="")
					{
						model.VerifyManID=int.Parse(dt.Rows[n]["VerifyManID"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
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

