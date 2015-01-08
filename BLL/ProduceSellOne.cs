using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类ProduceSellOne 的摘要说明。
	/// </summary>
	public class ProduceSellOne
	{
		private readonly Hownet.DAL.ProduceSellOne dal=new Hownet.DAL.ProduceSellOne();
		public ProduceSellOne()
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
		public int  Add(Hownet.Model.ProduceSellOne model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ProduceSellOne> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.ProduceSellOne model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ProduceSellOne> li=DataTableToList(dt);
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
		public Hownet.Model.ProduceSellOne GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            DataSet ds = dal.GetList(strWhere);
            ds.Tables[0].Columns.Add("RepAmount", typeof(decimal));
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ds.Tables[0].Rows[i]["RepAmount"] = DBNull.Value;
                }
            }
			return ds;
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
		public List<Hownet.Model.ProduceSellOne> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ProduceSellOne> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.ProduceSellOne> modelList = new List<Hownet.Model.ProduceSellOne>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.ProduceSellOne model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.ProduceSellOne();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
                    }
                    if (dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    else
                    {
                        model.Price = 0;
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    else
                    {
                        model.Amount = 0;
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    else
                    {
                        model.Money = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    else
                    {
                        model.MainID = 0;
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    else
                    {
                        model.MeasureID = 0;
                    }
                    if (dt.Rows[n]["BoxMeasureID"].ToString() != "")
                    {
                        model.BoxMeasureID = int.Parse(dt.Rows[n]["BoxMeasureID"].ToString());
                    }
                    else
                    {
                        model.BoxMeasureID = 0;
                    }
                    if (dt.Rows[n]["Conversion"].ToString() != "")
                    {
                        model.Conversion = int.Parse(dt.Rows[n]["Conversion"].ToString());
                    }
                    else
                    {
                        model.Conversion = 0;
                    }
                    if (dt.Rows[n]["BoxMeasureAmount"].ToString() != "")
                    {
                        model.BoxMeasureAmount = int.Parse(dt.Rows[n]["BoxMeasureAmount"].ToString());
                    }
                    else
                    {
                        model.BoxMeasureAmount = 0;
                    }
                    if (dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    else
                    {
                        model.BrandID = 0;
                    }
                    if (dt.Rows[n]["SalesOrderInfoID"].ToString() != "")
                    {
                        model.SalesOrderInfoID = int.Parse(dt.Rows[n]["SalesOrderInfoID"].ToString());
                    }
                    else
                    {
                        model.SalesOrderInfoID = 0;
                    }
                    if (dt.Rows[n]["RemarkID"].ToString() != "")
                    {
                        model.RemarkID = int.Parse(dt.Rows[n]["RemarkID"].ToString());
                    }
                    else
                    {
                        model.RemarkID = 0;
                    }
                    if (dt.Rows[n]["MTID"].ToString() != "")
                    {
                        model.MTID = int.Parse(dt.Rows[n]["MTID"].ToString());
                    }
                    else
                    {
                        model.MTID = 0;
                    }
                    model.SellRemark = dt.Rows[n]["SellRemark"].ToString();
                    try
                    {
                        model.CompanyMaterielName = dt.Rows[n]["CompanyMaterielName"].ToString();
                    }
                    catch (Exception ex)
                    {
                        model.CompanyMaterielName = string.Empty;
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
        public void DeleteByMain(int MainID)
        {
            dal.DeleteByMain(MainID);
        }        /// <summary>
        /// 某客户订单的发货记录
        /// </summary>
        /// <param name="SalesID"></param>
        /// <returns></returns>
        public int CountSellSales(int SalesID)
        {
            return dal.CountSellSales(SalesID);
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

