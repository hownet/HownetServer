using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// ClothAmount
    /// </summary>
    public partial class ClothAmount
    {
        private readonly Hownet.DAL.ClothAmount dal = new Hownet.DAL.ClothAmount();
        public ClothAmount()
        { }
        #region  Method
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
        public int Add(Hownet.Model.ClothAmount model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.ClothAmount> li = DataTableToList(dt);
            int a = 0;
            if (li.Count > 0)
            {
                for (int i = 0; i < li.Count; i++)
                {
                    a = Add(li[i]);
                }
            }
            return a;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hownet.Model.ClothAmount model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据,数据源为DataTable
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.ClothAmount> li = DataTableToList(dt);
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
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.ClothAmount GetModel(int ID)
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
        public DataSet GetTopList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ClothAmount> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ClothAmount> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.ClothAmount> modelList = new List<Hownet.Model.ClothAmount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.ClothAmount model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.ClothAmount();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["MainID"] != null && dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    model.BoxNum = dt.Rows[n]["BoxNum"].ToString();
                    if (dt.Rows[n]["ColorID"] != null && dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    model.ColorName = dt.Rows[n]["ColorName"].ToString();
                    if (dt.Rows[n]["BrandID"] != null && dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    model.BrandName = dt.Rows[n]["BrandName"].ToString();
                    model.Size1 = dt.Rows[n]["Size1"].ToString();
                    model.Size2 = dt.Rows[n]["Size2"].ToString();
                    model.Size3 = dt.Rows[n]["Size3"].ToString();
                    model.Size4 = dt.Rows[n]["Size4"].ToString();
                    model.Size5 = dt.Rows[n]["Size5"].ToString();
                    model.Size6 = dt.Rows[n]["Size6"].ToString();
                    model.Size7 = dt.Rows[n]["Size7"].ToString();
                    model.Size8 = dt.Rows[n]["Size8"].ToString();
                    model.Size9 = dt.Rows[n]["Size9"].ToString();
                    model.Size10 = dt.Rows[n]["Size10"].ToString();
                    model.Size11 = dt.Rows[n]["Size11"].ToString();
                    model.Size12 = dt.Rows[n]["Size12"].ToString();
                    model.Size13 = dt.Rows[n]["Size13"].ToString();
                    model.Size14 = dt.Rows[n]["Size14"].ToString();
                    model.Size15 = dt.Rows[n]["Size15"].ToString();
                    model.SumAmount = dt.Rows[n]["SumAmount"].ToString();
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
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  Method
    }
}

