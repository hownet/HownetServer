using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类DepartmentTaskMain 的摘要说明。
    /// </summary>
    public class DepartmentTaskMain
    {
        private readonly Hownet.DAL.DepartmentTaskMain dal = new Hownet.DAL.DepartmentTaskMain();
        public DepartmentTaskMain()
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
        public int Add(Hownet.Model.DepartmentTaskMain model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.DepartmentTaskMain> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.DepartmentTaskMain model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.DepartmentTaskMain> li = DataTableToList(dt);
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
        public Hownet.Model.DepartmentTaskMain GetModel(int ID)
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
        public List<Hownet.Model.DepartmentTaskMain> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.DepartmentTaskMain> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.DepartmentTaskMain> modelList = new List<Hownet.Model.DepartmentTaskMain>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.DepartmentTaskMain model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.DepartmentTaskMain();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["DepartmentID"].ToString() != "")
                    {
                        model.DepartmentID = int.Parse(dt.Rows[n]["DepartmentID"].ToString());
                    }
                    else
                    {
                        model.DepartmentID = 0;
                    }
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    else
                    {
                        model.TaskID = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["LastDate"].ToString() != "")
                    {
                        model.LastDate = DateTime.Parse(dt.Rows[n]["LastDate"].ToString());
                    }
                    else
                    {
                        model.LastDate = DateTime.Parse("1900-1-1");
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["Num"].ToString() != "")
                    {
                        model.Num = int.Parse(dt.Rows[n]["Num"].ToString());
                    }
                    else
                    {
                        model.Num = 0;
                    }
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                    }
                    else
                    {
                        model.IsEnd = 0;
                    }
                    if (dt.Rows[n]["PWID"].ToString() != "")
                    {
                        model.PWID = int.Parse(dt.Rows[n]["PWID"].ToString());
                    }
                    else
                    {
                        model.PWID = 0;
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
        /// 返回某生产单下已拆分的班组任务列表
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetDepList(int TaskID)
        {
            return dal.GetDepList(TaskID);
        }
         /// <summary>
        /// 取得新编号
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public int NewNum(DateTime dt)
        {
            return dal.NewNum(dt);
        }
                /// <summary>
        /// 某班组所分配任务列表
        /// </summary>
        /// <param name="DeparmentID"></param>
        /// <returns></returns>
        public DataSet GetListByDeparmentID(int DeparmentID)
        {
            DataSet ds = dal.GetListByDeparmentID(DeparmentID);
            ds.Tables[0].Columns.Add("NewNum", typeof(string));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DateTime dt = (DateTime)(ds.Tables[0].Rows[i]["MainDate"]);
                ds.Tables[0].Rows[i]["NewNum"] = "SCD-" + dt.ToString("yyyyMMdd") + "-" + ds.Tables[0].Rows[i]["MainNum"].ToString() + "-" + ds.Tables[0].Rows[i]["Num"].ToString();
            }
            return ds;
        }
        public DataTable GetAllNum()
        {
            DataTable dt = dal.GetAllNum().Tables[0];
            dt.Columns.Add("NewNum", typeof(string));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["NewNum"] = ((DateTime)(dt.Rows[i]["DateTime"])).ToString("yyyyMMdd") + dt.Rows[i]["Num"].ToString().PadLeft(3, '0');
            }
            return dt;
        }
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

