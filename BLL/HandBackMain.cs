using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类HandBackMain 的摘要说明。
	/// </summary>
	public class HandBackMain
	{
		private readonly Hownet.DAL.HandBackMain dal=new Hownet.DAL.HandBackMain();
		public HandBackMain()
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
		public bool Exists(int MainID)
		{
			return dal.Exists(MainID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Hownet.Model.HandBackMain model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.HandBackMain> li = DataTableToList(dt);
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
		public void Update(Hownet.Model.HandBackMain model)
		{
			dal.Update(model);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.HandBackMain> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int MainID)
		{
			
			dal.Delete(MainID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.HandBackMain GetModel(int MainID)
		{
			
			return dal.GetModel(MainID);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.HandBackMain> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			List<Hownet.Model.HandBackMain> modelList = new List<Hownet.Model.HandBackMain>();
			int rowsCount = ds.Tables[0].Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.HandBackMain model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.HandBackMain();
					if(ds.Tables[0].Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(ds.Tables[0].Rows[n]["MainID"].ToString());
					}
					if(ds.Tables[0].Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(ds.Tables[0].Rows[n]["DateTime"].ToString());
					}
					if(ds.Tables[0].Rows[n]["Num"].ToString()!="")
					{
						model.Num=int.Parse(ds.Tables[0].Rows[n]["Num"].ToString());
					}
					if(ds.Tables[0].Rows[n]["EmployeeID"].ToString()!="")
					{
						model.EmployeeID=int.Parse(ds.Tables[0].Rows[n]["EmployeeID"].ToString());
					}
					model.Remark=ds.Tables[0].Rows[n]["Remark"].ToString();
					if(ds.Tables[0].Rows[n]["IsVerify"].ToString()!="")
					{
						model.IsVerify=int.Parse(ds.Tables[0].Rows[n]["IsVerify"].ToString());
					}
					if(ds.Tables[0].Rows[n]["VerifyManID"].ToString()!="")
					{
						model.VerifyManID=int.Parse(ds.Tables[0].Rows[n]["VerifyManID"].ToString());
					}
					if(ds.Tables[0].Rows[n]["VerifyDateTime"].ToString()!="")
					{
						model.VerifyDateTime=DateTime.Parse(ds.Tables[0].Rows[n]["VerifyDateTime"].ToString());
					}
					if(ds.Tables[0].Rows[n]["IsEnd"].ToString()!="")
					{
						model.IsEnd=int.Parse(ds.Tables[0].Rows[n]["IsEnd"].ToString());
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.HandBackMain> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.HandBackMain> modelList = new List<Hownet.Model.HandBackMain>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.HandBackMain model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.HandBackMain();
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["Num"].ToString() != "")
                    {
                        model.Num = int.Parse(dt.Rows[n]["Num"].ToString());
                    }
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    if (dt.Rows[n]["VerifyManID"].ToString() != "")
                    {
                        model.VerifyManID = int.Parse(dt.Rows[n]["VerifyManID"].ToString());
                    }
                    if (dt.Rows[n]["VerifyDateTime"].ToString() != "")
                    {
                        model.VerifyDateTime = DateTime.Parse(dt.Rows[n]["VerifyDateTime"].ToString());
                    }
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
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
        public DataSet GetIDList()
        {
            return dal.GetIDList();
        }
        /// <summary>
        /// 查出所有工序
        /// </summary>
        /// <returns></returns>
        public DataSet GetWork()
        {
            return dal.GetWork();
        }
        public DataSet GetWorkByPW()
        {
            return dal.GetWorkByPW();
        }
        /// <summary>
        /// 取得新编号
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public int NewNum(DateTime dt)
        {
            return dal.NewNum(dt);
        }
         /// <summary>
        /// 更新是否审核
        /// </summary>
        public void UpVerify(Hownet.Model.HandBackMain model)
        {
            dal.UpVerify(model);
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

