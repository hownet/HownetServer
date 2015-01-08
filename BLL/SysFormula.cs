using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类SysFormula 的摘要说明。
    /// </summary>
    public class SysFormula
    {
        private readonly Hownet.DAL.SysFormula dal = new Hownet.DAL.SysFormula();
        public SysFormula()
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
        public int Add(Hownet.Model.SysFormula model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.SysFormula> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.SysFormula model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.SysFormula> li = DataTableToList(dt);
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
        public Hownet.Model.SysFormula GetModel(int ID)
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
        public List<Hownet.Model.SysFormula> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.SysFormula> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.SysFormula> modelList = new List<Hownet.Model.SysFormula>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.SysFormula model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.SysFormula();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    model.Operator1 = dt.Rows[n]["Operator1"].ToString();
                    model.Value1 = dt.Rows[n]["Value1"].ToString();
                    model.Operator2 = dt.Rows[n]["Operator2"].ToString();
                    model.Value2 = dt.Rows[n]["Value2"].ToString();
                    model.Operator3 = dt.Rows[n]["Operator3"].ToString();
                    model.Value3 = dt.Rows[n]["Value3"].ToString();
                    model.Operator4 = dt.Rows[n]["Operator4"].ToString();
                    model.Value4 = dt.Rows[n]["Value4"].ToString();
                    model.Operator5 = dt.Rows[n]["Operator5"].ToString();
                    model.Value5 = dt.Rows[n]["Value5"].ToString();
                    model.Operator6 = dt.Rows[n]["Operator6"].ToString();
                    model.Value6 = dt.Rows[n]["Value6"].ToString();
                    model.Operator7 = dt.Rows[n]["Operator7"].ToString();
                    model.Value7 = dt.Rows[n]["Value7"].ToString();
                    model.Operator8 = dt.Rows[n]["Operator8"].ToString();
                    model.Value8 = dt.Rows[n]["Value8"].ToString();
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    else
                    {
                        model.TypeID = 0;
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
        //补贴设置
        public DataSet GetBuTie(object WorkTypeID)
        {
            return dal.GetBuTie(WorkTypeID);
        }
         /// <summary>
        /// 删除补贴设置中非本工种的其余设置
        /// </summary>
        /// <param name="WTID"></param>
        public void DelNoWTID(object WTID)
        {
            dal.DelNoWTID(WTID);
        }
        public DataSet GetBuTieList()
        {
            return dal.GetBuTieList();
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

