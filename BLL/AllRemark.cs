using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// AllRemark
    /// </summary>
    public partial class AllRemark
    {
        private readonly Hownet.DAL.AllRemark dal = new Hownet.DAL.AllRemark();
        public AllRemark()
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
        public int Add(Hownet.Model.AllRemark model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.AllRemark> li = DataTableToList(dt);
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
        public bool Update(Hownet.Model.AllRemark model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据,数据源为DataTable
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.AllRemark> li = DataTableToList(dt);
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
        public Hownet.Model.AllRemark GetModel(int ID)
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
        public List<Hownet.Model.AllRemark> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.AllRemark> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.AllRemark> modelList = new List<Hownet.Model.AllRemark>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.AllRemark model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.AllRemark();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["MainID"] != null && dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    if (dt.Rows[n]["TableTypeID"] != null && dt.Rows[n]["TableTypeID"].ToString() != "")
                    {
                        model.TableTypeID = int.Parse(dt.Rows[n]["TableTypeID"].ToString());
                    }
                    if (dt.Rows[n]["OTID"] != null && dt.Rows[n]["OTID"].ToString() != "")
                    {
                        model.OTID = int.Parse(dt.Rows[n]["OTID"].ToString());
                    }
                    model.OTName = dt.Rows[n]["OTName"].ToString();
                    model.Remark = dt.Rows[n]["Remark"].ToString();
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
        public DataSet GetLastList(int CompanyID, int MaterielID, int TableTypeID)
        {
            return dal.GetLastList(CompanyID, MaterielID, TableTypeID);
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

