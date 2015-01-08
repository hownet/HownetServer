using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类MoneyInOrOut 的摘要说明。
	/// </summary>
	public class MoneyInOrOut
	{
		private readonly Hownet.DAL.MoneyInOrOut dal=new Hownet.DAL.MoneyInOrOut();
		public MoneyInOrOut()
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
		public int  Add(Hownet.Model.MoneyInOrOut model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.MoneyInOrOut> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.MoneyInOrOut model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.MoneyInOrOut> li=DataTableToList(dt);
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
		public Hownet.Model.MoneyInOrOut GetModel(int ID)
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
		public List<Hownet.Model.MoneyInOrOut> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.MoneyInOrOut> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MoneyInOrOut> modelList = new List<Hownet.Model.MoneyInOrOut>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MoneyInOrOut model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MoneyInOrOut();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["Num"].ToString() != "")
                    {
                        model.Num = int.Parse(dt.Rows[n]["Num"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    if (dt.Rows[n]["VerifyMan"].ToString() != "")
                    {
                        model.VerifyMan = int.Parse(dt.Rows[n]["VerifyMan"].ToString());
                    }
                    if (dt.Rows[n]["VerifyDate"].ToString() != "")
                    {
                        model.VerifyDate = DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
                    }
                    if (dt.Rows[n]["LastMoney"].ToString() != "")
                    {
                        model.LastMoney = decimal.Parse(dt.Rows[n]["LastMoney"].ToString());
                    }
                    if (dt.Rows[n]["ChangMoney"].ToString() != "")
                    {
                        model.ChangMoney = decimal.Parse(dt.Rows[n]["ChangMoney"].ToString());
                    }
                    if (dt.Rows[n]["FillMan"].ToString() != "")
                    {
                        model.FillMan = int.Parse(dt.Rows[n]["FillMan"].ToString());
                    }
                    if (dt.Rows[n]["FillDate"].ToString() != "")
                    {
                        model.FillDate = DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
                    }
                    if (dt.Rows[n]["KJKMID"] != null && dt.Rows[n]["KJKMID"].ToString() != "")
                    {
                        model.KJKMID = int.Parse(dt.Rows[n]["KJKMID"].ToString());
                    }
                    if (dt.Rows[n]["Fees"] != null && dt.Rows[n]["Fees"].ToString() != "")
                    {
                        model.Fees = decimal.Parse(dt.Rows[n]["Fees"].ToString());
                    }
                    model.A = int.Parse(dt.Rows[n]["A"].ToString());
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
        /// 根据类型返回只有ID值的列表 
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetIDList(int TypeID)
        {
            return dal.GetIDList(TypeID);
        }
        public int NewNum(DateTime dt, int TypeID)
        {
            return dal.NewNum(dt, TypeID);
        }
                /// <summary>
        /// 返回该客户之前的帐户余额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetLastMoney(int CompanyID)
        {
            return dal.GetLastMoney(CompanyID);
        }
        public void DeleteByCompanyID(int CompanyID)
        {
            dal.DeleteByCompanyID(CompanyID);
        }
        public DataSet GetInfoList(DateTime dt1, DateTime dt2, int CompanyID, bool IsSum)
        {
            return dal.GetInfoList(dt1, dt2, CompanyID, IsSum);
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

