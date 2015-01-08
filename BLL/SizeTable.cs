using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类SizeTable 的摘要说明。
    /// </summary>
    public class SizeTable
    {
        private readonly Hownet.DAL.SizeTable dal = new Hownet.DAL.SizeTable();
        public SizeTable()
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
        public int Add(Hownet.Model.SizeTable model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.SizeTable> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.SizeTable model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.SizeTable> li = DataTableToList(dt);
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
        public Hownet.Model.SizeTable GetModel(int ID)
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
        public List<Hownet.Model.SizeTable> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.SizeTable> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.SizeTable> modelList = new List<Hownet.Model.SizeTable>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.SizeTable model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.SizeTable();
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
                    if (dt.Rows[n]["TableTypeID"].ToString() != "")
                    {
                        model.TableTypeID = int.Parse(dt.Rows[n]["TableTypeID"].ToString());
                    }
                    else
                    {
                        model.TableTypeID = 0;
                    }
                    if (dt.Rows[n]["FillMan"].ToString() != "")
                    {
                        model.FillMan = int.Parse(dt.Rows[n]["FillMan"].ToString());
                    }
                    else
                    {
                        model.FillMan = 0;
                    }
                    if (dt.Rows[n]["ZhiYang"].ToString() != "")
                    {
                        model.ZhiYang = int.Parse(dt.Rows[n]["ZhiYang"].ToString());
                    }
                    else
                    {
                        model.ZhiYang = 0;
                    }
                    if (dt.Rows[n]["BanFangZhuGuan"].ToString() != "")
                    {
                        model.BanFangZhuGuan = int.Parse(dt.Rows[n]["BanFangZhuGuan"].ToString());
                    }
                    else
                    {
                        model.BanFangZhuGuan = 0;
                    }
                    if (dt.Rows[n]["ShengChangBu"].ToString() != "")
                    {
                        model.ShengChangBu = int.Parse(dt.Rows[n]["ShengChangBu"].ToString());
                    }
                    else
                    {
                        model.ShengChangBu = 0;
                    }
                    if (dt.Rows[n]["LastEditDate"].ToString() != "")
                    {
                        model.LastEditDate = DateTime.Parse(dt.Rows[n]["LastEditDate"].ToString());
                    }
                    else
                    {
                        model.LastEditDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["LastEditMan"].ToString() != "")
                    {
                        model.LastEditMan = int.Parse(dt.Rows[n]["LastEditMan"].ToString());
                    }
                    else
                    {
                        model.LastEditMan = 0;
                    }
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    else
                    {
                        model.IsVerify = 0;
                    }
                    if (dt.Rows[n]["VerifyMan"].ToString() != "")
                    {
                        model.VerifyMan = int.Parse(dt.Rows[n]["VerifyMan"].ToString());
                    }
                    else
                    {
                        model.VerifyMan = 0;
                    }
                    if (dt.Rows[n]["VerifyDate"].ToString() != "")
                    {
                        model.VerifyDate = DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
                    }
                    else
                    {
                        model.VerifyDate = DateTime.Parse("1900-1-1");
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    model.Images = dt.Rows[n]["Images"].ToString();
                    model.LastEditRemark = dt.Rows[n]["LastEditRemark"].ToString();
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    else
                    {
                        model.MeasureID = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["UpData"].ToString() != "")
                    {
                        model.UpData = int.Parse(dt.Rows[n]["UpData"].ToString());
                    }
                    else
                    {
                        model.UpData = 0;
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
        public int GetUpData(int ID)
        {
            return dal.GetUpData(ID);
        }
        public DataSet GetTaskSTList(int TaskID, int TableTypeID)
        {
            return dal.GetTaskSTList(TaskID, TableTypeID);
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

