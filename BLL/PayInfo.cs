using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类PayInfo 的摘要说明。
    /// </summary>
    public class PayInfo
    {
        private readonly Hownet.DAL.PayInfo dal = new Hownet.DAL.PayInfo();
        public PayInfo()
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
        public int Add(Hownet.Model.PayInfo model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.PayInfo> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.PayInfo model)
        {
            dal.Update(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.PayInfo> li = DataTableToList(dt);
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
        public Hownet.Model.PayInfo GetModel(int ID)
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
        public List<Hownet.Model.PayInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
                /// <summary>
        /// 弃审手动回收
        /// </summary>
        public void DeleteHand(int ID)
        {
            dal.DeleteHand(ID);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.PayInfo> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.PayInfo> modelList = new List<Hownet.Model.PayInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.PayInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.PayInfo();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    if (dt.Rows[n]["WorkingID"].ToString() != "")
                    {
                        model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    if (dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    if (dt.Rows[n]["ProductWorkingID"].ToString() != "")
                    {
                        model.ProductWorkingID = int.Parse(dt.Rows[n]["ProductWorkingID"].ToString());
                    }
                    if (dt.Rows[n]["WorkticketInfoID"].ToString() != "")
                    {
                        model.WorkticketInfoID = int.Parse(dt.Rows[n]["WorkticketInfoID"].ToString());
                    }
                    if (dt.Rows[n]["IsSum"].ToString() != "")
                    {
                        string oo = dt.Rows[n]["IsSum"].ToString();
                        if (oo == "1" || oo.ToLower() == "true")
                        {
                            model.IsSum = true;
                        }
                        else
                        {
                            model.IsSum = false;
                        }
                    }
                    if (dt.Rows[n]["BreakID"].ToString() != "")
                    {
                        model.BreakID = int.Parse(dt.Rows[n]["BreakID"].ToString());
                    }
                    if (dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                    }
                    if (dt.Rows[n]["BoxNum"].ToString() != "")
                    {
                        model.BoxNum = int.Parse(dt.Rows[n]["BoxNum"].ToString());
                    }
                    model.OderNum = dt.Rows[n]["OderNum"].ToString();
                    if (dt.Rows[n]["IsDay"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsDay"].ToString() == "1") || (dt.Rows[n]["IsDay"].ToString().ToLower() == "true"))
                        {
                            model.IsDay = true;
                        }
                        else
                        {
                            model.IsDay = false;
                        }
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
        public void DelByInfoID(DateTime dt, int ID, int BreakID)
        {
            dal.DelByInfoID(dt, ID, BreakID);
        }
        public DataSet GetBackList(DateTime dt, int EmployeeID)
        {
            return dal.GetBackList(dt, EmployeeID);
        }
        public DataSet GetDayList()
        {
            return dal.GetDayList();
        }
              /// <summary>
        /// 获取需要新添加到PayInfo表的记录
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="BoxNum"></param>
        /// <param name="WorkingID"></param>
        /// <returns></returns>
        public DataSet GetAddPayInfo(int TaskID, int BoxNum, int WorkingID)
        {
            DataSet ds = dal.GetAddPayInfo(TaskID, BoxNum, WorkingID);
            int a = ds.Tables[0].Rows.Count;
            return ds;
        }
        public DataSet GetDayReport(DateTime dt)
        {
            return dal.GetDayReport(dt);
        }
        /// <summary>
        /// 返回某员工某时间段内的工作情况
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="dtOne"></param>
        /// <param name="dtTwo"></param>
        /// <returns></returns>
        public DataSet GetEmpWorkList(int EmployeeID, DateTime dtOne, DateTime dtTwo)
        {
            return dal.GetEmpWorkList(EmployeeID, dtOne, dtTwo);
        }
        public void DelDayWorking(int MainID)
        {
            dal.DelDayWorking(MainID);
        }
         /// <summary>
        /// 根据分箱工序ID，删除一条记录
        /// </summary>
        /// <param name="WTIID"></param>
        public void DelByWTInfoID(int WTIID)
        {
            dal.DelByWTInfoID(WTIID);
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

