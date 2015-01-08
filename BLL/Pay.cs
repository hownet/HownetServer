using System;
using System.Data;

using Hownet.Model;
using System.Collections.Generic;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类Pay 的摘要说明。
	/// </summary>
	public class Pay
	{
		private readonly Hownet.DAL.Pay dal=new Hownet.DAL.Pay();
		public Pay()
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
		public int  Add(Hownet.Model.Pay model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.Pay> li = DataTableToList(dt);
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
		public void Update(Hownet.Model.Pay model)
		{
			dal.Update(model);
		}
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.Pay> li = DataTableToList(dt);
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
		public Hownet.Model.Pay GetModel(int ID)
		{
			return dal.GetModel(ID);
		}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.Pay> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Pay> modelList = new List<Hownet.Model.Pay>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Pay model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Pay();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["Remain"] != null && dt.Rows[n]["Remain"].ToString() != "")
                    {
                        model.Remain = decimal.Parse(dt.Rows[n]["Remain"].ToString());
                    }
                    if (dt.Rows[n]["EmployeeID"] != null && dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    if (dt.Rows[n]["Month"] != null && dt.Rows[n]["Month"].ToString() != "")
                    {
                        model.Month = decimal.Parse(dt.Rows[n]["Month"].ToString());
                    }
                    if (dt.Rows[n]["Payment"] != null && dt.Rows[n]["Payment"].ToString() != "")
                    {
                        model.Payment = decimal.Parse(dt.Rows[n]["Payment"].ToString());
                    }
                    if (dt.Rows[n]["BoardWages"] != null && dt.Rows[n]["BoardWages"].ToString() != "")
                    {
                        model.BoardWages = decimal.Parse(dt.Rows[n]["BoardWages"].ToString());
                    }
                    if (dt.Rows[n]["Repair"] != null && dt.Rows[n]["Repair"].ToString() != "")
                    {
                        model.Repair = decimal.Parse(dt.Rows[n]["Repair"].ToString());
                    }
                    if (dt.Rows[n]["LastRemain"] != null && dt.Rows[n]["LastRemain"].ToString() != "")
                    {
                        model.LastRemain = decimal.Parse(dt.Rows[n]["LastRemain"].ToString());
                    }
                    if (dt.Rows[n]["MainID"] != null && dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    if (dt.Rows[n]["Fact"] != null && dt.Rows[n]["Fact"].ToString() != "")
                    {
                        model.Fact = decimal.Parse(dt.Rows[n]["Fact"].ToString());
                    }
                    if (dt.Rows[n]["IsEnd"] != null && dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsEnd"].ToString() == "1") || (dt.Rows[n]["IsEnd"].ToString().ToLower() == "true"))
                        {
                            model.IsEnd = true;
                        }
                        else
                        {
                            model.IsEnd = false;
                        }
                    }
                    if (dt.Rows[n]["FullAttendance"] != null && dt.Rows[n]["FullAttendance"].ToString() != "")
                    {
                        model.FullAttendance = decimal.Parse(dt.Rows[n]["FullAttendance"].ToString());
                    }
                    if (dt.Rows[n]["Fine"] != null && dt.Rows[n]["Fine"].ToString() != "")
                    {
                        model.Fine = decimal.Parse(dt.Rows[n]["Fine"].ToString());
                    }
                    if (dt.Rows[n]["Deposit"] != null && dt.Rows[n]["Deposit"].ToString() != "")
                    {
                        model.Deposit = decimal.Parse(dt.Rows[n]["Deposit"].ToString());
                    }
                    if (dt.Rows[n]["Add1"] != null && dt.Rows[n]["Add1"].ToString() != "")
                    {
                        model.Add1 = decimal.Parse(dt.Rows[n]["Add1"].ToString());
                    }
                    if (dt.Rows[n]["Add2"] != null && dt.Rows[n]["Add2"].ToString() != "")
                    {
                        model.Add2 = decimal.Parse(dt.Rows[n]["Add2"].ToString());
                    }
                    if (dt.Rows[n]["Add3"] != null && dt.Rows[n]["Add3"].ToString() != "")
                    {
                        model.Add3 = decimal.Parse(dt.Rows[n]["Add3"].ToString());
                    }
                    if (dt.Rows[n]["Add4"] != null && dt.Rows[n]["Add4"].ToString() != "")
                    {
                        model.Add4 = decimal.Parse(dt.Rows[n]["Add4"].ToString());
                    }
                    if (dt.Rows[n]["Add5"] != null && dt.Rows[n]["Add5"].ToString() != "")
                    {
                        model.Add5 = decimal.Parse(dt.Rows[n]["Add5"].ToString());
                    }
                    if (dt.Rows[n]["Jian1"] != null && dt.Rows[n]["Jian1"].ToString() != "")
                    {
                        model.Jian1 = decimal.Parse(dt.Rows[n]["Jian1"].ToString());
                    }
                    if (dt.Rows[n]["Jian2"] != null && dt.Rows[n]["Jian2"].ToString() != "")
                    {
                        model.Jian2 = decimal.Parse(dt.Rows[n]["Jian2"].ToString());
                    }
                    if (dt.Rows[n]["Jian3"] != null && dt.Rows[n]["Jian3"].ToString() != "")
                    {
                        model.Jian3 = decimal.Parse(dt.Rows[n]["Jian3"].ToString());
                    }
                    if (dt.Rows[n]["Jian4"] != null && dt.Rows[n]["Jian4"].ToString() != "")
                    {
                        model.Jian4 = decimal.Parse(dt.Rows[n]["Jian4"].ToString());
                    }
                    if (dt.Rows[n]["Jian5"] != null && dt.Rows[n]["Jian5"].ToString() != "")
                    {
                        model.Jian5 = decimal.Parse(dt.Rows[n]["Jian5"].ToString());
                    }
                    if (dt.Rows[n]["ActualMonth"] != null && dt.Rows[n]["ActualMonth"].ToString() != "")
                    {
                        model.ActualMonth = decimal.Parse(dt.Rows[n]["ActualMonth"].ToString());
                    }
                    if (dt.Rows[n]["NotFact"] != null && dt.Rows[n]["NotFact"].ToString() != "")
                    {
                        if ((dt.Rows[n]["NotFact"].ToString() == "1") || (dt.Rows[n]["NotFact"].ToString().ToLower() == "true"))
                        {
                            model.NotFact = true;
                        }
                        else
                        {
                            model.NotFact = false;
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
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        /// <summary>
        /// 取得工人工资及明细
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetEmpPay(int MainID)
        {
            DataSet ds = dal.GetEmpPay(MainID);
            Hownet.Model.Pay modP = new Hownet.Model.Pay();
            ds.Tables[0].Columns.Add("OneDate", typeof(string));
            ds.Tables[0].Columns.Add("TwoDate", typeof(string));
            ds.Tables[0].Columns.Add("NowMoney", typeof(decimal));
            //ds.Tables[0].Columns.Add("FullAttendance", typeof(decimal));
            //ds.Tables[0].Columns.Add("Fine", typeof(decimal));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ds.Tables[0].Rows[i]["OneDate"] = ((DateTime)(ds.Tables[0].Rows[i]["BegingDate"])).ToString("yyyy年MM月dd日");
                ds.Tables[0].Rows[i]["TwoDate"] = ((DateTime)(ds.Tables[0].Rows[i]["EndDate"])).ToString("yyyy年MM月dd日");
                if (ds.Tables[0].Rows[i]["Month"].ToString() != "")
                    modP.Month = decimal.Parse(ds.Tables[0].Rows[i]["Month"].ToString());
                else
                    modP.Month = 0;
                if (ds.Tables[0].Rows[i]["Repair"].ToString() != "")
                    modP.Repair = decimal.Parse(ds.Tables[0].Rows[i]["Repair"].ToString());
                else
                    modP.Repair = 0;
                if (ds.Tables[0].Rows[i]["Payment"].ToString() != "")
                    modP.Payment = decimal.Parse(ds.Tables[0].Rows[i]["Payment"].ToString());
                else
                    modP.Payment = 0;
                if (ds.Tables[0].Rows[i]["BoardWages"].ToString() != "")
                    modP.BoardWages = decimal.Parse(ds.Tables[0].Rows[i]["BoardWages"].ToString());
                else
                    modP.BoardWages = 0;
                if (ds.Tables[0].Rows[i]["FullAttendance"].ToString() != "")
                    modP.FullAttendance = decimal.Parse(ds.Tables[0].Rows[i]["FullAttendance"].ToString());
                else
                    modP.FullAttendance = 0;
                if (ds.Tables[0].Rows[i]["Fine"].ToString() != "")
                    modP.Fine = decimal.Parse(ds.Tables[0].Rows[i]["Fine"].ToString());
                else
                    modP.Fine = 0;
                if (ds.Tables[0].Rows[i]["Deposit"].ToString() != "")
                    modP.Deposit = decimal.Parse(ds.Tables[0].Rows[i]["Deposit"].ToString());
                else
                    modP.Deposit = 0;
                ds.Tables[0].Rows[i]["NowMoney"] = modP.Month + modP.Repair - modP.BoardWages - modP.Payment + modP.FullAttendance - modP.Fine - modP.Deposit;
            }
            return ds;
        }
        /// <summary>
        /// 删除一次工资统计
        /// </summary>
        /// <param name="MainID"></param>
        public void DelPay(int MainID)
        {
             dal.DelPay(MainID);
        }
        ///// <summary>
        ///// 更新工资表
        ///// </summary>
        ///// <param name="model"></param>
        //public void UpPay(Hownet.Model.Pay model)
        //{
        //    dal.Update(model);
        //}
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

