using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// FixedAssets
	/// </summary>
	public partial class FixedAssets
	{
		private readonly Hownet.DAL.FixedAssets dal=new Hownet.DAL.FixedAssets();
		public FixedAssets()
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
		public int  Add(Hownet.Model.FixedAssets model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.FixedAssets> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.FixedAssets model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.FixedAssets> li = DataTableToList(dt);
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
		public Hownet.Model.FixedAssets GetModel(int ID)
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
		public List<Hownet.Model.FixedAssets> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.FixedAssets> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.FixedAssets> modelList = new List<Hownet.Model.FixedAssets>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.FixedAssets model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.FixedAssets();
					if(dt.Rows[n]["A"].ToString()!="")
					{
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
					}
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Sn=dt.Rows[n]["Sn"].ToString();
					model.Barcode=dt.Rows[n]["Barcode"].ToString();
					model.Name=dt.Rows[n]["Name"].ToString();
					if(dt.Rows[n]["FATypeID"].ToString()!="")
					{
						model.FATypeID=int.Parse(dt.Rows[n]["FATypeID"].ToString());
					}
					model.Spec=dt.Rows[n]["Spec"].ToString();
					if(dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					model.GBCode=dt.Rows[n]["GBCode"].ToString();
					model.More=dt.Rows[n]["More"].ToString();
					if(dt.Rows[n]["DateOfOut"].ToString()!="")
					{
						model.DateOfOut=DateTime.Parse(dt.Rows[n]["DateOfOut"].ToString());
					}
					if(dt.Rows[n]["UseDeparmentID"].ToString()!="")
					{
						model.UseDeparmentID=int.Parse(dt.Rows[n]["UseDeparmentID"].ToString());
					}
					if(dt.Rows[n]["UseTypeID"].ToString()!="")
					{
						model.UseTypeID=int.Parse(dt.Rows[n]["UseTypeID"].ToString());
					}
					model.StoreAccess=dt.Rows[n]["StoreAccess"].ToString();
					if(dt.Rows[n]["Custodian"].ToString()!="")
					{
						model.Custodian=int.Parse(dt.Rows[n]["Custodian"].ToString());
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					if(dt.Rows[n]["MeasureID"].ToString()!="")
					{
						model.MeasureID=int.Parse(dt.Rows[n]["MeasureID"].ToString());
					}
					if(dt.Rows[n]["Price"].ToString()!="")
					{
						model.Price=decimal.Parse(dt.Rows[n]["Price"].ToString());
					}
					if(dt.Rows[n]["AddTypeID"].ToString()!="")
					{
						model.AddTypeID=int.Parse(dt.Rows[n]["AddTypeID"].ToString());
					}
					if(dt.Rows[n]["OldMoney"].ToString()!="")
					{
						model.OldMoney=decimal.Parse(dt.Rows[n]["OldMoney"].ToString());
					}
					if(dt.Rows[n]["NowMoney"].ToString()!="")
					{
						model.NowMoney=decimal.Parse(dt.Rows[n]["NowMoney"].ToString());
					}
					if(dt.Rows[n]["Depreciation"].ToString()!="")
					{
						model.Depreciation=int.Parse(dt.Rows[n]["Depreciation"].ToString());
					}
					if(dt.Rows[n]["ResidualValue"].ToString()!="")
					{
						model.ResidualValue=decimal.Parse(dt.Rows[n]["ResidualValue"].ToString());
					}
					if(dt.Rows[n]["UseDate"].ToString()!="")
					{
						model.UseDate=DateTime.Parse(dt.Rows[n]["UseDate"].ToString());
					}
					if(dt.Rows[n]["Interval"].ToString()!="")
					{
						model.Interval=int.Parse(dt.Rows[n]["Interval"].ToString());
					}
					if(dt.Rows[n]["DepreciationYear"].ToString()!="")
					{
						model.DepreciationYear=int.Parse(dt.Rows[n]["DepreciationYear"].ToString());
					}
					if(dt.Rows[n]["DepreciationMonth"].ToString()!="")
					{
						model.DepreciationMonth=int.Parse(dt.Rows[n]["DepreciationMonth"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["IsOut"].ToString()!="")
					{
						if((dt.Rows[n]["IsOut"].ToString()=="1")||(dt.Rows[n]["IsOut"].ToString().ToLower()=="true"))
						{
						model.IsOut=true;
						}
						else
						{
							model.IsOut=false;
						}
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

