using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类MaterielInOrOut 的摘要说明。
	/// </summary>
	public class MaterielInOrOut
	{
		private readonly Hownet.DAL.MaterielInOrOut dal=new Hownet.DAL.MaterielInOrOut();
		public MaterielInOrOut()
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
		public int  Add(Hownet.Model.MaterielInOrOut model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.MaterielInOrOut> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.MaterielInOrOut model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.MaterielInOrOut> li=DataTableToList(dt);
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
		public Hownet.Model.MaterielInOrOut GetModel(int ID)
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
		public List<Hownet.Model.MaterielInOrOut> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.MaterielInOrOut> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.MaterielInOrOut> modelList = new List<Hownet.Model.MaterielInOrOut>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.MaterielInOrOut model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.MaterielInOrOut();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					if(dt.Rows[n]["MListID"].ToString()!="")
					{
						model.MListID=int.Parse(dt.Rows[n]["MListID"].ToString());
					}
					if(dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					if(dt.Rows[n]["ColorID"].ToString()!="")
					{
						model.ColorID=int.Parse(dt.Rows[n]["ColorID"].ToString());
					}
					if(dt.Rows[n]["ColorOneID"].ToString()!="")
					{
						model.ColorOneID=int.Parse(dt.Rows[n]["ColorOneID"].ToString());
					}
					if(dt.Rows[n]["ColorTwoID"].ToString()!="")
					{
						model.ColorTwoID=int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
					}
					if(dt.Rows[n]["SizeID"].ToString()!="")
					{
						model.SizeID=int.Parse(dt.Rows[n]["SizeID"].ToString());
					}
					if(dt.Rows[n]["BrandID"].ToString()!="")
					{
						model.BrandID=int.Parse(dt.Rows[n]["BrandID"].ToString());
					}
					if(dt.Rows[n]["TableTypeID"].ToString()!="")
					{
						model.TableTypeID=int.Parse(dt.Rows[n]["TableTypeID"].ToString());
					}
					if(dt.Rows[n]["PorN"].ToString()!="")
					{
						model.PorN=int.Parse(dt.Rows[n]["PorN"].ToString());
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
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

