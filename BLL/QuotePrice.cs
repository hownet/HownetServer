using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类QuotePrice 的摘要说明。
    /// </summary>
    public class QuotePrice
    {
        private readonly Hownet.DAL.QuotePrice dal = new Hownet.DAL.QuotePrice();
        public QuotePrice()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int QuotePriceID)
        {
            return dal.Exists(QuotePriceID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.QuotePrice model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.QuotePrice> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.QuotePrice model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.QuotePrice> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int QuotePriceID)
        {

            dal.Delete(QuotePriceID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.QuotePrice GetModel(int QuotePriceID)
        {

            return dal.GetModel(QuotePriceID);
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
        public DataSet GetTopList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.QuotePrice> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.QuotePrice> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.QuotePrice> modelList = new List<Hownet.Model.QuotePrice>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.QuotePrice model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.QuotePrice();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
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
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["ColorTypeID"].ToString() != "")
                    {
                        model.ColorTypeID = int.Parse(dt.Rows[n]["ColorTypeID"].ToString());
                    }
                    else
                    {
                        model.ColorTypeID = 0;
                    }
                    if (dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    else
                    {
                        model.ColorID = 0;
                    }
                    if (dt.Rows[n]["Conversion"].ToString() != "")
                    {
                        model.Conversion = decimal.Parse(dt.Rows[n]["Conversion"].ToString());
                    }
                    else
                    {
                        model.Conversion = 0;
                    }
                    if (dt.Rows[n]["CompanyMeasureID"].ToString() != "")
                    {
                        model.CompanyMeasureID = int.Parse(dt.Rows[n]["CompanyMeasureID"].ToString());
                    }
                    else
                    {
                        model.CompanyMeasureID = 0;
                    }
                    if (dt.Rows[n]["DepotMeasureID"].ToString() != "")
                    {
                        model.DepotMeasureID = int.Parse(dt.Rows[n]["DepotMeasureID"].ToString());
                    }
                    else
                    {
                        model.DepotMeasureID = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["IsUse"].ToString() != "")
                    {
                        model.IsUse = int.Parse(dt.Rows[n]["IsUse"].ToString());
                    }
                    else
                    {
                        model.IsUse = 0;
                    }
                    if (dt.Rows[n]["LastAmount"].ToString() != "")
                    {
                        model.LastAmount = decimal.Parse(dt.Rows[n]["LastAmount"].ToString());
                    }
                    else
                    {
                        model.LastAmount = 0;
                    }
                    if (dt.Rows[n]["DayMaxAmount"].ToString() != "")
                    {
                        model.DayMaxAmount = decimal.Parse(dt.Rows[n]["DayMaxAmount"].ToString());
                    }
                    else
                    {
                        model.DayMaxAmount = 0;
                    }
                    if (dt.Rows[n]["BackDay"].ToString() != "")
                    {
                        model.BackDay = int.Parse(dt.Rows[n]["BackDay"].ToString());
                    }
                    else
                    {
                        model.BackDay = 0;
                    }
                    model.CompanySn = dt.Rows[n]["CompanySn"].ToString();
                    if (dt.Rows[n]["MoneyType"].ToString() != "")
                    {
                        model.MoneyType = int.Parse(dt.Rows[n]["MoneyType"].ToString());
                    }
                    else
                    {
                        model.MoneyType = 0;
                    }
                    if (dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    else
                    {
                        model.BrandID = 0;
                    }
                    if (dt.Rows[n]["MTID"].ToString() != "")
                    {
                        model.MTID = int.Parse(dt.Rows[n]["MTID"].ToString());
                    }
                    else
                    {
                        model.MTID = 0;
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
        public void UpPrice(int CompanyID, int MaterielID, int BrandID, decimal Price, int measureid,int MTID)
        {
            DataTable dt = dal.GetList("(CompanyID=" + CompanyID + ") And (MaterielID=" + MaterielID + ") And (BrandID=" + BrandID + ") And (DepotMeasureID=" + measureid + ") And (MTID=" + MTID + ")").Tables[0];
            if (dt.Rows.Count == 0)
            {
                Hownet.Model.QuotePrice modQP = new Hownet.Model.QuotePrice();
                modQP.CompanyID = CompanyID;
                modQP.MaterielID = MaterielID;
                modQP.BrandID = BrandID;
                modQP.Price = Price;
                modQP.DepotMeasureID = measureid;
                modQP.DateTime = DateTime.Today;
                modQP.Remark = modQP.CompanySn = "";
                modQP.MTID = MTID;
                Add(modQP);
            }
            else
            {
                if (decimal.Parse(dt.Rows[0]["Price"].ToString()) != Price)
                {
                    dt.Rows[0]["Price"] = Price;
                    UpdateByDt(dt);
                }
            }
        }
        public void UpProcessPrice(int CompanyID, int MaterielID, int BrandID, decimal Price, int measureid,int MTID)
        {
            DataTable dt = dal.GetList("(CompanyID=" + CompanyID + ") And (MaterielID=" + MaterielID + ") And (ColorTypeID=" + BrandID + ") And (DepotMeasureID=" + measureid + ") And (MTID=" + MTID + ")").Tables[0];
            if (dt.Rows.Count == 0)
            {
                Hownet.Model.QuotePrice modQP = new Hownet.Model.QuotePrice();
                modQP.CompanyID = CompanyID;
                modQP.MaterielID = MaterielID;
                modQP.ColorTypeID = BrandID;
                modQP.Price = Price;
                modQP.DepotMeasureID = measureid;
                modQP.DateTime = DateTime.Today;
                modQP.Remark = modQP.CompanySn = "";
                modQP.BrandID = 0;
                Add(modQP);
            }
            else
            {
                if (decimal.Parse(dt.Rows[0]["Price"].ToString()) != Price)
                {
                    dt.Rows[0]["Price"] = Price;
                    UpdateByDt(dt);
                }
            }
        }
        public decimal GetPrice(int CompanyID, int MaterielID, int BrandID, int measureid,int MTID)
        {
            DataTable dt = dal.GetList("(CompanyID=" + CompanyID + ") And (MaterielID=" + MaterielID + ") And (BrandID=" + BrandID + ") And (DepotMeasureID=" + measureid + ") And (MTID=" + MTID + ")").Tables[0];
            if (dt.Rows.Count > 0)
                return decimal.Parse(dt.Rows[0]["Price"].ToString());
            else
                return 0;
        }
        public decimal GetProcessPrice(int CompanyID, int MaterielID, int BrandID, int measureid,int MTID)
        {
            DataTable dt = dal.GetList("(CompanyID=" + CompanyID + ") And (MaterielID=" + MaterielID + ") And (ColorTypeID=" + BrandID + ") And (DepotMeasureID=" + measureid + ") And (MTID=" + MTID + ")").Tables[0];
            if (dt.Rows.Count > 0)
                return decimal.Parse(dt.Rows[0]["Price"].ToString());
            else
                return 0;
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

