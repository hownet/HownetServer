using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类WorkTicketIDBack 的摘要说明。
	/// </summary>
	public class WorkTicketIDBack
	{
		private readonly Hownet.DAL.WorkTicketIDBack dal=new Hownet.DAL.WorkTicketIDBack();
		public WorkTicketIDBack()
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
		public int  Add(Hownet.Model.WorkTicketIDBack model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDBack> li = DataTableToList(dt);
            if (li.Count > 0)
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
		public void Update(Hownet.Model.WorkTicketIDBack model)
		{
			dal.Update(model);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDBack> li = DataTableToList(dt);
            if (li.Count > 0)
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
		public Hownet.Model.WorkTicketIDBack GetModel(int ID)
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
		public List<Hownet.Model.WorkTicketIDBack> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.WorkTicketIDBack> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.WorkTicketIDBack> modelList = new List<Hownet.Model.WorkTicketIDBack>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.WorkTicketIDBack model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.WorkTicketIDBack();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}

                    model.TicketIDCardID = dt.Rows[n]["TicketIDCardID"].ToString().Trim();

					if(dt.Rows[n]["EmployeeIDCardID"].ToString()!="")
					{
						model.EmployeeIDCardID=int.Parse(dt.Rows[n]["EmployeeIDCardID"].ToString());
					}
					if(dt.Rows[n]["WorkTicketID"].ToString()!="")
					{
						model.WorkTicketID=int.Parse(dt.Rows[n]["WorkTicketID"].ToString());
					}
					if(dt.Rows[n]["WorkingID"].ToString()!="")
					{
						model.WorkingID=int.Parse(dt.Rows[n]["WorkingID"].ToString());
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
        public void AddPayInfo(int MaterielID, int InfoID, string oderNum)
        {
            dal.AddPayInfo(MaterielID, InfoID, oderNum);
        }
        public DataSet GetWorkingByTicketID(int GroupBy, int TicketID)
        {
            return dal.GetWorkingByTicketID(GroupBy, TicketID);
        }
        public string CountAmount(int EmpID, DateTime dt)
        {
            return dal.CountAmount(EmpID, dt);
        }
        public DataSet GetKey(int TicketID, int WorkOrder, int SizeID, int ColorID)
        {
            return dal.GetKey(TicketID, WorkOrder, SizeID, ColorID);
        }
        public DateTime GetDateTime()
        {
            return dal.GetDateTime();
        }
        public string GetEmployee(int EmpID, int typeID, DateTime dt)
        {
            return dal.GetEmployee(EmpID, typeID, dt);
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

