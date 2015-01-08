using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类Employee 的摘要说明。
	/// </summary>
	public class Employee
	{
		private readonly Hownet.DAL.Employee dal=new Hownet.DAL.Employee();
		public Employee()
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
		public int  Add(Hownet.Model.Employee model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Employee> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Employee model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
            List<Hownet.Model.Employee> li = DataTableToList(dt);
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
		public Hownet.Model.Employee GetModel(int ID)
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
		public List<Hownet.Model.Employee> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.Employee> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Employee> modelList = new List<Hownet.Model.Employee>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Employee model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Employee();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					if(dt.Rows[n]["IntroducerID"].ToString()!="")
					{
						model.IntroducerID=int.Parse(dt.Rows[n]["IntroducerID"].ToString());
					}
					model.IdentityCard=dt.Rows[n]["IdentityCard"].ToString();
					if(dt.Rows[n]["Sex"].ToString()!="")
					{
						model.Sex=int.Parse(dt.Rows[n]["Sex"].ToString());
					}
					model.Sn=dt.Rows[n]["Sn"].ToString();
					if(dt.Rows[n]["Province"].ToString()!="")
					{
						model.Province=int.Parse(dt.Rows[n]["Province"].ToString());
					}
					model.Address=dt.Rows[n]["Address"].ToString();
					model.Phone=dt.Rows[n]["Phone"].ToString();
					if(dt.Rows[n]["AccessionDate"].ToString()!="")
					{
						model.AccessionDate=DateTime.Parse(dt.Rows[n]["AccessionDate"].ToString());
					}
					if(dt.Rows[n]["WorkTypeID"].ToString()!="")
					{
						model.WorkTypeID=int.Parse(dt.Rows[n]["WorkTypeID"].ToString());
					}
					if(dt.Rows[n]["PayID"].ToString()!="")
					{
						model.PayID=int.Parse(dt.Rows[n]["PayID"].ToString());
					}
					if(dt.Rows[n]["DimissionDate"].ToString()!="")
					{
						model.DimissionDate=DateTime.Parse(dt.Rows[n]["DimissionDate"].ToString());
					}
					if(dt.Rows[n]["BedID"].ToString()!="")
					{
						model.BedID=int.Parse(dt.Rows[n]["BedID"].ToString());
					}
					if(dt.Rows[n]["TableID"].ToString()!="")
					{
						model.TableID=int.Parse(dt.Rows[n]["TableID"].ToString());
					}
					if(dt.Rows[n]["DepartmentID"].ToString()!="")
					{
						model.DepartmentID=int.Parse(dt.Rows[n]["DepartmentID"].ToString());
					}
					if(dt.Rows[n]["DegreeID"].ToString()!="")
					{
						model.DegreeID=int.Parse(dt.Rows[n]["DegreeID"].ToString());
					}
					if(dt.Rows[n]["PolityID"].ToString()!="")
					{
						model.PolityID=int.Parse(dt.Rows[n]["PolityID"].ToString());
					}
					model.SOSPhone=dt.Rows[n]["SOSPhone"].ToString();
					model.SOSMan=dt.Rows[n]["SOSMan"].ToString();
					model.NowAddress=dt.Rows[n]["NowAddress"].ToString();
					if(dt.Rows[n]["FillDate"].ToString()!="")
					{
						model.FillDate=DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
					}
					if(dt.Rows[n]["FillUser"].ToString()!="")
					{
						model.FillUser=int.Parse(dt.Rows[n]["FillUser"].ToString());
					}
					if(dt.Rows[n]["LassMoney"].ToString()!="")
					{
						model.LassMoney=decimal.Parse(dt.Rows[n]["LassMoney"].ToString());
					}
					if(dt.Rows[n]["Royalty"].ToString()!="")
					{
						model.Royalty=decimal.Parse(dt.Rows[n]["Royalty"].ToString());
					}
					model.Image=dt.Rows[n]["Image"].ToString();
					if(dt.Rows[n]["IsUse"].ToString()!="")
					{
						if((dt.Rows[n]["IsUse"].ToString()=="1")||(dt.Rows[n]["IsUse"].ToString().ToLower()=="true"))
						{
						model.IsUse=true;
						}
						else
						{
							model.IsUse=false;
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
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

