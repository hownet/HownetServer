using System;
using System.Data;
using System.Collections.Generic;
using LTP.Common;
using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类ShippingNoticeInfo 的摘要说明。
    /// </summary>
    public class ShippingNoticeInfo
    {
        private readonly Hownet.DAL.ShippingNoticeInfo dal = new Hownet.DAL.ShippingNoticeInfo();
        public ShippingNoticeInfo()
        { }
        #region  成员方法
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
        public int Add(Hownet.Model.ShippingNoticeInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.ShippingNoticeInfo> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.ShippingNoticeInfo model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.ShippingNoticeInfo> li = DataTableToList(dt);
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
        public Hownet.Model.ShippingNoticeInfo GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 得到一个对象实体，从缓存中。
        /// </summary>
        public Hownet.Model.ShippingNoticeInfo GetModelByCache(int ID)
        {

            string CacheKey = "ShippingNoticeInfoModel-" + ID;
            object objModel = LTP.Common.DataCache.GetCache(CacheKey);
            if (objModel == null)
            {
                try
                {
                    objModel = dal.GetModel(ID);
                    if (objModel != null)
                    {
                        int ModelCache = LTP.Common.ConfigHelper.GetConfigInt("ModelCache");
                        LTP.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
                    }
                }
                catch { }
            }
            return (Hownet.Model.ShippingNoticeInfo)objModel;
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
        public List<Hownet.Model.ShippingNoticeInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ShippingNoticeInfo> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.ShippingNoticeInfo> modelList = new List<Hownet.Model.ShippingNoticeInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.ShippingNoticeInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.ShippingNoticeInfo();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    else
                    {
                        model.MainID = 0;
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
                    if (dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    else
                    {
                        model.BrandID = 0;
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    else
                    {
                        model.Amount = 0;
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    else
                    {
                        model.MeasureID = 0;
                    }
                    model.OnePackaging = dt.Rows[n]["OnePackaging"].ToString();
                    model.TwoPackaging = dt.Rows[n]["TwoPackaging"].ToString();
                    if (dt.Rows[n]["LastTime"].ToString() != "")
                    {
                        model.LastTime = DateTime.Parse(dt.Rows[n]["LastTime"].ToString());
                    }
                    else
                    {
                        model.LastTime = DateTime.Parse("1900-1-1");
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
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
        /// 获得分页数据列表
        /// </summary>
        //public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  成员方法
    }
}

