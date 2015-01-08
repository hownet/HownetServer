using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类SizeBow 的摘要说明。
	/// </summary>
	public class SizeBow
	{
		private readonly Hownet.DAL.SizeBow dal=new Hownet.DAL.SizeBow();
		public SizeBow()
		{}
		#region  成员方法

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
		public int  Add(Hownet.Model.SizeBow model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SizeBow> li=DataTableToList(dt);
			if(li.Count>0)
			{
				return dal.Add(li[0]);
			}
			else
			{
				return 0;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Hownet.Model.SizeBow model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SizeBow> li=DataTableToList(dt);
			if(li.Count>0)
			{
				dal.Update(li[0]);
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.SizeBow GetModel(int ID)
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
		public List<Hownet.Model.SizeBow> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.SizeBow> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SizeBow> modelList = new List<Hownet.Model.SizeBow>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SizeBow model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SizeBow();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["SizeID"].ToString()!="")
					{
						model.SizeID=int.Parse(dt.Rows[n]["SizeID"].ToString());
					}
					else
					{
						model.SizeID=0;
					}
					if(dt.Rows[n]["BowID"].ToString()!="")
					{
						model.BowID=int.Parse(dt.Rows[n]["BowID"].ToString());
					}
					else
					{
						model.BowID=0;
					}
					if(dt.Rows[n]["CottonID"].ToString()!="")
					{
						model.CottonID=int.Parse(dt.Rows[n]["CottonID"].ToString());
					}
					else
					{
						model.CottonID=0;
					}
					if(dt.Rows[n]["TaskID"].ToString()!="")
					{
						model.TaskID=int.Parse(dt.Rows[n]["TaskID"].ToString());
					}
					else
					{
						model.TaskID=0;
					}
					if(dt.Rows[n]["Sash"].ToString()!="")
					{
						model.Sash=int.Parse(dt.Rows[n]["Sash"].ToString());
					}
					else
					{
						model.Sash=0;
					}
					if(dt.Rows[n]["OpenSash"].ToString()!="")
					{
						model.OpenSash=int.Parse(dt.Rows[n]["OpenSash"].ToString());
					}
					else
					{
						model.OpenSash=0;
					}
					if(dt.Rows[n]["PlasticBone"].ToString()!="")
					{
						model.PlasticBone=int.Parse(dt.Rows[n]["PlasticBone"].ToString());
					}
					else
					{
						model.PlasticBone=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
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
		/// 获得分页数据列表
		/// </summary>
		//public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

