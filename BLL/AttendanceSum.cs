using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类AttendanceSum 的摘要说明。
	/// </summary>
	public class AttendanceSum
	{
		private readonly Hownet.DAL.AttendanceSum dal=new Hownet.DAL.AttendanceSum();
		public AttendanceSum()
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
		public int  Add(Hownet.Model.AttendanceSum model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.AttendanceSum> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.AttendanceSum model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.AttendanceSum> li=DataTableToList(dt);
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
		public Hownet.Model.AttendanceSum GetModel(int ID)
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
		public List<Hownet.Model.AttendanceSum> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.AttendanceSum> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.AttendanceSum> modelList = new List<Hownet.Model.AttendanceSum>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.AttendanceSum model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.AttendanceSum();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["EmployeeID"].ToString()!="")
					{
						model.EmployeeID=int.Parse(dt.Rows[n]["EmployeeID"].ToString());
					}
					else
					{
						model.EmployeeID=0;
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					if(dt.Rows[n]["DayWorkMin"].ToString()!="")
					{
						model.DayWorkMin=int.Parse(dt.Rows[n]["DayWorkMin"].ToString());
					}
					else
					{
						model.DayWorkMin=0;
					}
					if(dt.Rows[n]["DayWorkTime"].ToString()!="")
					{
						model.DayWorkTime=DateTime.Parse(dt.Rows[n]["DayWorkTime"].ToString());
					}
					else
					{
						model.DayWorkTime=DateTime.Parse("1900-1-1");
					}
					if(dt.Rows[n]["BelateMin"].ToString()!="")
					{
						model.BelateMin=int.Parse(dt.Rows[n]["BelateMin"].ToString());
					}
					else
					{
						model.BelateMin=0;
					}
					if(dt.Rows[n]["LeaveEarlyMin"].ToString()!="")
					{
						model.LeaveEarlyMin=int.Parse(dt.Rows[n]["LeaveEarlyMin"].ToString());
					}
					else
					{
						model.LeaveEarlyMin=0;
					}
					if(dt.Rows[n]["AbsenteeismMin"].ToString()!="")
					{
						model.AbsenteeismMin=int.Parse(dt.Rows[n]["AbsenteeismMin"].ToString());
					}
					else
					{
						model.AbsenteeismMin=0;
					}
					if(dt.Rows[n]["Money"].ToString()!="")
					{
						model.Money=decimal.Parse(dt.Rows[n]["Money"].ToString());
					}
					else
					{
						model.Money=0;
					}
					if(dt.Rows[n]["OvertimeMin"].ToString()!="")
					{
						model.OvertimeMin=int.Parse(dt.Rows[n]["OvertimeMin"].ToString());
					}
					else
					{
						model.OvertimeMin=0;
					}
					if(dt.Rows[n]["OvertimeTime"].ToString()!="")
					{
						model.OvertimeTime=DateTime.Parse(dt.Rows[n]["OvertimeTime"].ToString());
					}
					else
					{
						model.OvertimeTime=DateTime.Parse("1900-1-1");
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

