using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// MoneyList
    /// </summary>
    public partial class MoneyList
    {
        private readonly Hownet.DAL.MoneyList dal = new Hownet.DAL.MoneyList();
        public MoneyList()
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
        public int Add(Hownet.Model.MoneyList model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.MoneyList> li = DataTableToList(dt);
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
        public bool Update(Hownet.Model.MoneyList model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据,数据源为DataTable
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.MoneyList> li = DataTableToList(dt);
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
        public Hownet.Model.MoneyList GetModel(int ID)
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
        public List<Hownet.Model.MoneyList> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.MoneyList> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MoneyList> modelList = new List<Hownet.Model.MoneyList>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MoneyList model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MoneyList();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["KJKMID"] != null && dt.Rows[n]["KJKMID"].ToString() != "")
                    {
                        model.KJKMID = int.Parse(dt.Rows[n]["KJKMID"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"] != null && dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["InMoney"] != null && dt.Rows[n]["InMoney"].ToString() != "")
                    {
                        model.InMoney = decimal.Parse(dt.Rows[n]["InMoney"].ToString());
                    }
                    if (dt.Rows[n]["OutMoney"] != null && dt.Rows[n]["OutMoney"].ToString() != "")
                    {
                        model.OutMoney = decimal.Parse(dt.Rows[n]["OutMoney"].ToString());
                    }
                    if (dt.Rows[n]["Money"] != null && dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    if (dt.Rows[n]["TableID"] != null && dt.Rows[n]["TableID"].ToString() != "")
                    {
                        model.TableID = int.Parse(dt.Rows[n]["TableID"].ToString());
                    }
                    if (dt.Rows[n]["TypeID"] != null && dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
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
        public decimal GetLastMoney(int KJKMID)
        {
            return  dal.GetLastMoney(KJKMID);
        }
             /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteLog(int KJKMID, int TypeID, int TableID)
        {
            dal.DeleteLog(KJKMID, TypeID, TableID);
        }
        /// <summary>
        /// 是否可以弃审单据
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <param name="TableID"></param>
        /// <returns></returns>
        public int CanUnVerify(int KJKMID, int TypeID, int TableID)
        {
            return dal.CanUnVerify(KJKMID, TypeID, TableID);
        }
        /// <summary>
        /// 平衡会计科目与流水帐余额
        /// </summary>
        public void Balance()
        {
            dal.Balance();
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

