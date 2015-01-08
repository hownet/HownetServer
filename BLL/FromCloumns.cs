using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// FromCloumns
    /// </summary>
    public partial class FromCloumns
    {
        private readonly Hownet.DAL.FromCloumns dal = new Hownet.DAL.FromCloumns();
        public FromCloumns()
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
        public int Add(Hownet.Model.FromCloumns model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.FromCloumns> li = DataTableToList(dt);
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
        public bool Update(Hownet.Model.FromCloumns model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据,数据源为DataTable
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.FromCloumns> li = DataTableToList(dt);
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
        public Hownet.Model.FromCloumns GetModel(int ID)
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
        public List<Hownet.Model.FromCloumns> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.FromCloumns> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.FromCloumns> modelList = new List<Hownet.Model.FromCloumns>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.FromCloumns model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.FromCloumns();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.Fileds = dt.Rows[n]["Fileds"].ToString();
                    model.CName = dt.Rows[n]["CName"].ToString();
                    if (dt.Rows[n]["Width"] != null && dt.Rows[n]["Width"].ToString() != "")
                    {
                        model.Width = int.Parse(dt.Rows[n]["Width"].ToString());
                    }
                    if (dt.Rows[n]["IsShow"] != null && dt.Rows[n]["IsShow"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsShow"].ToString() == "1") || (dt.Rows[n]["IsShow"].ToString().ToLower() == "true"))
                        {
                            model.IsShow = true;
                        }
                        else
                        {
                            model.IsShow = false;
                        }
                    }
                    if (dt.Rows[n]["IsCanEdit"] != null && dt.Rows[n]["IsCanEdit"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCanEdit"].ToString() == "1") || (dt.Rows[n]["IsCanEdit"].ToString().ToLower() == "true"))
                        {
                            model.IsCanEdit = true;
                        }
                        else
                        {
                            model.IsCanEdit = false;
                        }
                    }
                    if (dt.Rows[n]["IsCanFilter"] != null && dt.Rows[n]["IsCanFilter"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCanFilter"].ToString() == "1") || (dt.Rows[n]["IsCanFilter"].ToString().ToLower() == "true"))
                        {
                            model.IsCanFilter = true;
                        }
                        else
                        {
                            model.IsCanFilter = false;
                        }
                    }
                    if (dt.Rows[n]["IsCanGroup"] != null && dt.Rows[n]["IsCanGroup"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCanGroup"].ToString() == "1") || (dt.Rows[n]["IsCanGroup"].ToString().ToLower() == "true"))
                        {
                            model.IsCanGroup = true;
                        }
                        else
                        {
                            model.IsCanGroup = false;
                        }
                    }
                    if (dt.Rows[n]["IsCanSort"] != null && dt.Rows[n]["IsCanSort"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCanSort"].ToString() == "1") || (dt.Rows[n]["IsCanSort"].ToString().ToLower() == "true"))
                        {
                            model.IsCanSort = true;
                        }
                        else
                        {
                            model.IsCanSort = false;
                        }
                    }
                    if (dt.Rows[n]["IsFix"] != null && dt.Rows[n]["IsFix"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsFix"].ToString() == "1") || (dt.Rows[n]["IsFix"].ToString().ToLower() == "true"))
                        {
                            model.IsFix = true;
                        }
                        else
                        {
                            model.IsFix = false;
                        }
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    model.EName = dt.Rows[n]["EName"].ToString();
                    if (dt.Rows[n]["UserID"] != null && dt.Rows[n]["UserID"].ToString() != "")
                    {
                        model.UserID = int.Parse(dt.Rows[n]["UserID"].ToString());
                    }
                    if (dt.Rows[n]["MainID"] != null && dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    if (dt.Rows[n]["IsMust"] != null && dt.Rows[n]["IsMust"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsMust"].ToString() == "1") || (dt.Rows[n]["IsMust"].ToString().ToLower() == "true"))
                        {
                            model.IsMust = true;
                        }
                        else
                        {
                            model.IsMust = false;
                        }
                    }
                    if (dt.Rows[n]["TypeID"] != null && dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    if (dt.Rows[n]["OrderBy"] != null && dt.Rows[n]["OrderBy"].ToString() != "")
                    {
                        model.OrderBy = int.Parse(dt.Rows[n]["OrderBy"].ToString());
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
        public DataSet GetFC(int MainID, int UserID)
        {
            return dal.GetFC(MainID, UserID);
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

