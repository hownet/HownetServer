/**  版本信息模板在安装目录下，可自行修改。
* Sample.cs
*
* 功 能： N/A
* 类 名： Sample
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/1 14:41:30   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// Sample
	/// </summary>
	public partial class Sample
	{
		private readonly Hownet.DAL.Sample dal=new Hownet.DAL.Sample();
		public Sample()
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
		public int  Add(Hownet.Model.Sample model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Sample> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.Sample model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Sample> li = DataTableToList(dt);
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
		public Hownet.Model.Sample GetModel(int ID)
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
		public List<Hownet.Model.Sample> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.Sample> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Sample> modelList = new List<Hownet.Model.Sample>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Sample model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Sample();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.StrNum=dt.Rows[n]["StrNum"].ToString();
					if(dt.Rows[n]["Num"]!=null && dt.Rows[n]["Num"].ToString()!="")
					{
						model.Num=int.Parse(dt.Rows[n]["Num"].ToString());
					}
					model.Titlle=dt.Rows[n]["Titlle"].ToString();
					model.CompanyName=dt.Rows[n]["CompanyName"].ToString();
					if(dt.Rows[n]["CompanyID"]!=null && dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					model.MaterielName=dt.Rows[n]["MaterielName"].ToString();
					if(dt.Rows[n]["MaterielID"]!=null && dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					model.TypeName=dt.Rows[n]["TypeName"].ToString();
					if(dt.Rows[n]["PlanDate"]!=null && dt.Rows[n]["PlanDate"].ToString()!="")
					{
						model.PlanDate=DateTime.Parse(dt.Rows[n]["PlanDate"].ToString());
					}
					model.SeriesName=dt.Rows[n]["SeriesName"].ToString();
					if(dt.Rows[n]["OpenDate"]!=null && dt.Rows[n]["OpenDate"].ToString()!="")
					{
						model.OpenDate=DateTime.Parse(dt.Rows[n]["OpenDate"].ToString());
					}
					if(dt.Rows[n]["LastDate"]!=null && dt.Rows[n]["LastDate"].ToString()!="")
					{
						model.LastDate=DateTime.Parse(dt.Rows[n]["LastDate"].ToString());
					}
					if(dt.Rows[n]["StockBackDate"]!=null && dt.Rows[n]["StockBackDate"].ToString()!="")
					{
						model.StockBackDate=DateTime.Parse(dt.Rows[n]["StockBackDate"].ToString());
					}
					if(dt.Rows[n]["TechDate"]!=null && dt.Rows[n]["TechDate"].ToString()!="")
					{
						model.TechDate=DateTime.Parse(dt.Rows[n]["TechDate"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["FillManID"]!=null && dt.Rows[n]["FillManID"].ToString()!="")
					{
						model.FillManID=int.Parse(dt.Rows[n]["FillManID"].ToString());
					}
					model.FillManName=dt.Rows[n]["FillManName"].ToString();
					if(dt.Rows[n]["VerifyID"]!=null && dt.Rows[n]["VerifyID"].ToString()!="")
					{
						model.VerifyID=int.Parse(dt.Rows[n]["VerifyID"].ToString());
					}
					model.VerifyName=dt.Rows[n]["VerifyName"].ToString();
					if(dt.Rows[n]["FillDate"]!=null && dt.Rows[n]["FillDate"].ToString()!="")
					{
						model.FillDate=DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
					}
					if(dt.Rows[n]["VerifyDate"]!=null && dt.Rows[n]["VerifyDate"].ToString()!="")
					{
						model.VerifyDate=DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
					}
					if(dt.Rows[n]["UpData"]!=null && dt.Rows[n]["UpData"].ToString()!="")
					{
						model.UpData=int.Parse(dt.Rows[n]["UpData"].ToString());
					}
                    model.ProductName = dt.Rows[n]["ProductName"].ToString();
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
        public DataSet GetIDList()
        {
            return dal.GetIDList();
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

