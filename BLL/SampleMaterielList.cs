/**  版本信息模板在安装目录下，可自行修改。
* SampleMaterielList.cs
*
* 功 能： N/A
* 类 名： SampleMaterielList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/1 14:41:31   N/A    初版
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
	/// SampleMaterielList
	/// </summary>
	public partial class SampleMaterielList
	{
		private readonly Hownet.DAL.SampleMaterielList dal=new Hownet.DAL.SampleMaterielList();
		public SampleMaterielList()
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
		public int  Add(Hownet.Model.SampleMaterielList model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMaterielList> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.SampleMaterielList model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMaterielList> li = DataTableToList(dt);
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
		public Hownet.Model.SampleMaterielList GetModel(int ID)
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
		public List<Hownet.Model.SampleMaterielList> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.SampleMaterielList> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SampleMaterielList> modelList = new List<Hownet.Model.SampleMaterielList>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SampleMaterielList model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SampleMaterielList();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"]!=null && dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["MaterielID"]!=null && dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					model.MaterielName=dt.Rows[n]["MaterielName"].ToString();
					if(dt.Rows[n]["CaiPianID"]!=null && dt.Rows[n]["CaiPianID"].ToString()!="")
					{
						model.CaiPianID=int.Parse(dt.Rows[n]["CaiPianID"].ToString());
					}
					model.CaiPianName=dt.Rows[n]["CaiPianName"].ToString();
					if(dt.Rows[n]["SpecID"]!=null && dt.Rows[n]["SpecID"].ToString()!="")
					{
						model.SpecID=int.Parse(dt.Rows[n]["SpecID"].ToString());
					}
					model.SpecName=dt.Rows[n]["SpecName"].ToString();
					model.Weight=dt.Rows[n]["Weight"].ToString();
					if(dt.Rows[n]["CompanyID"]!=null && dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					model.CompanyName=dt.Rows[n]["CompanyName"].ToString();
					if(dt.Rows[n]["Color1ID"]!=null && dt.Rows[n]["Color1ID"].ToString()!="")
					{
						model.Color1ID=int.Parse(dt.Rows[n]["Color1ID"].ToString());
					}
					model.Color1Name=dt.Rows[n]["Color1Name"].ToString();
					if(dt.Rows[n]["Color2ID"]!=null && dt.Rows[n]["Color2ID"].ToString()!="")
					{
						model.Color2ID=int.Parse(dt.Rows[n]["Color2ID"].ToString());
					}
					model.Color2Name=dt.Rows[n]["Color2Name"].ToString();
					if(dt.Rows[n]["Color3ID"]!=null && dt.Rows[n]["Color3ID"].ToString()!="")
					{
						model.Color3ID=int.Parse(dt.Rows[n]["Color3ID"].ToString());
					}
					model.Color3Name=dt.Rows[n]["Color3Name"].ToString();
					if(dt.Rows[n]["Color4ID"]!=null && dt.Rows[n]["Color4ID"].ToString()!="")
					{
						model.Color4ID=int.Parse(dt.Rows[n]["Color4ID"].ToString());
					}
					model.Color4Name=dt.Rows[n]["Color4Name"].ToString();
					if(dt.Rows[n]["Color5ID"]!=null && dt.Rows[n]["Color5ID"].ToString()!="")
					{
						model.Color5ID=int.Parse(dt.Rows[n]["Color5ID"].ToString());
					}
					model.Color5Name=dt.Rows[n]["Color5Name"].ToString();
					if(dt.Rows[n]["Color6ID"]!=null && dt.Rows[n]["Color6ID"].ToString()!="")
					{
						model.Color6ID=int.Parse(dt.Rows[n]["Color6ID"].ToString());
					}
					model.Color6Name=dt.Rows[n]["Color6Name"].ToString();
					if(dt.Rows[n]["Color7ID"]!=null && dt.Rows[n]["Color7ID"].ToString()!="")
					{
						model.Color7ID=int.Parse(dt.Rows[n]["Color7ID"].ToString());
					}
					model.Color7Name=dt.Rows[n]["Color7Name"].ToString();
					if(dt.Rows[n]["Color8ID"]!=null && dt.Rows[n]["Color8ID"].ToString()!="")
					{
						model.Color8ID=int.Parse(dt.Rows[n]["Color8ID"].ToString());
					}
					model.Color8Name=dt.Rows[n]["Color8Name"].ToString();
                    if (dt.Rows[n]["MeasureID"] != null && dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    model.Measurename = dt.Rows[n]["Measurename"].ToString();
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
        public bool DeleteByMainID(int MainID)
        {
            return dal. DeleteByMainID(MainID);
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

