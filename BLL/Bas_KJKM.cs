using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// Bas_KJKM
	/// </summary>
	public partial class Bas_KJKM
	{
		private readonly Hownet.DAL.Bas_KJKM dal=new Hownet.DAL.Bas_KJKM();
		public Bas_KJKM()
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
		public int  Add(Hownet.Model.Bas_KJKM model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Bas_KJKM> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.Bas_KJKM model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Bas_KJKM> li = DataTableToList(dt);
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
		public Hownet.Model.Bas_KJKM GetModel(int ID)
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
		public List<Hownet.Model.Bas_KJKM> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.Bas_KJKM> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Bas_KJKM> modelList = new List<Hownet.Model.Bas_KJKM>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Bas_KJKM model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Bas_KJKM();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["Orders"]!=null && dt.Rows[n]["Orders"].ToString()!="")
					{
						model.Orders=int.Parse(dt.Rows[n]["Orders"].ToString());
					}
					model.Num=dt.Rows[n]["Num"].ToString();
					model.Name=dt.Rows[n]["Name"].ToString();
					if(dt.Rows[n]["ParentID"]!=null && dt.Rows[n]["ParentID"].ToString()!="")
					{
						model.ParentID=int.Parse(dt.Rows[n]["ParentID"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["Money"] != null && dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    if (dt.Rows[n]["CompanyID"] != null && dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    if (dt.Rows[n]["DebitMoney"] != null && dt.Rows[n]["DebitMoney"].ToString() != "")
                    {
                        model.DebitMoney = decimal.Parse(dt.Rows[n]["DebitMoney"].ToString());
                    }
                    if (dt.Rows[n]["CreditMoney"] != null && dt.Rows[n]["CreditMoney"].ToString() != "")
                    {
                        model.CreditMoney = decimal.Parse(dt.Rows[n]["CreditMoney"].ToString());
                    }
                    if (dt.Rows[n]["MoneyType"] != null && dt.Rows[n]["MoneyType"].ToString() != "")
                    {
                        model.MoneyType = int.Parse(dt.Rows[n]["MoneyType"].ToString());
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
        public DataSet GetTreeList()
        {
            return dal.GetTreeList();
        }
        public DataSet GetFilterList(string s)
        {
            return dal.GetFilterList(s);
        }
        public DataSet GetMoneyKJKM()
        {
            return dal.GetMoneyKJKM();
        }
        public int GetMaxNum(int ParentID)
        {
            return dal.GetMaxNum(ParentID);
        }
        public int GetMaxOrders()
        {
            return dal.GetMaxOrders();
        }
        public void UpMoney(int ParentID)
        {
            object o = dal.UpMoney(ParentID);
            if (o != null)
            {
                List<Hownet.Model.Bas_KJKM> li = DataTableToList(GetList("(Num=" + ParentID + ")").Tables[0]);
                if (li.Count > 0)
                {
                    li[0].Money = Convert.ToDecimal(o);
                    Update(li[0]);
                }
            }
        }
        public void UpParentID()
        {
           DataTable dt = dal.GetParent();
           for (int i = 0; i < dt.Rows.Count; i++)
           {
               UpMoney(Convert.ToInt32(dt.Rows[i][0]));
           }
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

