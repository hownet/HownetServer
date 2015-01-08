using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类HandBackInfo 的摘要说明。
	/// </summary>
	public class HandBackInfo
	{
		private readonly Hownet.DAL.HandBackInfo dal=new Hownet.DAL.HandBackInfo();
		public HandBackInfo()
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
        public bool Exists(int InfoID)
        {
            return dal.Exists(InfoID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.HandBackInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Hownet.Model.HandBackInfo model)
        {
            dal.Update(model);
        }
        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.HandBackInfo> li = DataTableToList(dt);
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
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.HandBackInfo> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int InfoID)
        {

            dal.Delete(InfoID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.HandBackInfo GetModel(int InfoID)
        {

            return dal.GetModel(InfoID);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["PayInfoID"] == null || ds.Tables[0].Rows[i]["PayInfoID"].ToString() == "")
                    {
                        ds.Tables[0].Rows[i]["PayInfoID"] = 0;
                    }
                }
            }
            return ds;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.HandBackInfo> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.HandBackInfo> modelList = new List<Hownet.Model.HandBackInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.HandBackInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.HandBackInfo();
                    if (dt.Rows[n]["InfoID"].ToString() != "")
                    {
                        model.InfoID = int.Parse(dt.Rows[n]["InfoID"].ToString());
                    }
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    if (dt.Rows[n]["WorkingID"].ToString() != "")
                    {
                        model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    if (dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    if (dt.Rows[n]["PriceID"].ToString() != "")
                    {
                        model.PriceID = int.Parse(dt.Rows[n]["PriceID"].ToString());
                    }
                    if (dt.Rows[n]["EmployeeID"] != null && dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"] != null && dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
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
        public void Save(DataTable dt, int mainID,int EmployeeID,DateTime date)
        {
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.HandBackInfo model;
                Hownet.BLL.PayInfo bllPI = new PayInfo();
                Hownet.Model.PayInfo modPI = new Hownet.Model.PayInfo();
                for (int n = 0; n < rowsCount; n++)
                {
                    if (dt.Rows[n].RowState != DataRowState.Deleted)
                    {
                        string a = dt.Rows[n]["A"].ToString();
                        if (a != "1")
                        {
                            model = new Hownet.Model.HandBackInfo();
                            if (dt.Rows[n]["MaterielID"].ToString() != "")
                            {
                                modPI.MaterielID = model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                            }
                            if (dt.Rows[n]["WorkingID"].ToString() != "")
                            {
                                modPI.WorkingID = model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
                            }
                            if (dt.Rows[n]["Amount"].ToString() != "")
                            {
                                modPI.Amount = model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
                            }
                            if (dt.Rows[n]["Price"].ToString() != "")
                            {
                                modPI.Price = model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                            }
                            if (dt.Rows[n]["Money"].ToString() != "")
                            {
                                model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                            }
                            if (dt.Rows[n]["PriceID"].ToString() != "")
                            {
                                modPI.ProductWorkingID = model.PriceID = int.Parse(dt.Rows[n]["PriceID"].ToString());
                            }
                            modPI.BoxNum = model.InfoID = int.Parse(dt.Rows[n]["InfoID"].ToString());
                            modPI.EmployeeID = EmployeeID;
                            modPI.DateTime = date;
                            model.MainID = mainID;
                            modPI.ColorID = modPI.SizeID = 0;
                            modPI.OderNum = "";
                            modPI.IsSum = false;
                           
                            if (model.MaterielID != 0 && model.WorkingID != 0 && model.Amount != 0)
                            {
                                if (a == "3")
                                {
                                    modPI.BoxNum = Add(model);
                                    bllPI.Add(modPI);
                                }
                                else if (a == "2")
                                {
                                    modPI.ID = int.Parse(dt.Rows[n]["PayInfoID"].ToString());
                                    Update(model);
                                    bllPI.Update(modPI);
                                }
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteByMainID(int MainID)
        {
            dal.DeleteByMainID(MainID);
        }
        public DataSet GetViews(DateTime DateOne, DateTime DateTwo, int EmployeeID, bool IsInfo,int MaterielID, int WorkingID)
        {
            return dal.GetViews(DateOne, DateTwo, EmployeeID, IsInfo,MaterielID, WorkingID);
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

