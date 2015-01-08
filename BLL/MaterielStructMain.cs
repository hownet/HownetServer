using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类MaterielStructMain 的摘要说明。
    /// </summary>
    public class MaterielStructMain
    {
        private readonly Hownet.DAL.MaterielStructMain dal = new Hownet.DAL.MaterielStructMain();
        public MaterielStructMain()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MainID)
        {
            return dal.Exists(MainID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MaterielStructMain model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielStructMain> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.MaterielStructMain model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielStructMain> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int MainID)
        {

            dal.Delete(MainID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.MaterielStructMain GetModel(int MainID)
        {

            return dal.GetModel(MainID);
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
        public List<Hownet.Model.MaterielStructMain> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.MaterielStructMain> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MaterielStructMain> modelList = new List<Hownet.Model.MaterielStructMain>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MaterielStructMain model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MaterielStructMain();
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    else
                    {
                        model.MainID = 0;
                    }
                    model.Ver = dt.Rows[n]["Ver"].ToString();
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    else
                    {
                        model.TaskID = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["IsDefault"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsDefault"].ToString() == "1") || (dt.Rows[n]["IsDefault"].ToString().ToLower() == "true"))
                        {
                            model.IsDefault = true;
                        }
                        else
                        {
                            model.IsDefault = false;
                        }
                    }
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    else
                    {
                        model.IsVerify = 0;
                    }
                    if (dt.Rows[n]["VerifyManID"].ToString() != "")
                    {
                        model.VerifyManID = int.Parse(dt.Rows[n]["VerifyManID"].ToString());
                    }
                    else
                    {
                        model.VerifyManID = 0;
                    }
                    if (dt.Rows[n]["VerifyDateTime"].ToString() != "")
                    {
                        model.VerifyDateTime = DateTime.Parse(dt.Rows[n]["VerifyDateTime"].ToString());
                    }
                    else
                    {
                        model.VerifyDateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["Executant"].ToString() != "")
                    {
                        model.Executant = int.Parse(dt.Rows[n]["Executant"].ToString());
                    }
                    else
                    {
                        model.Executant = 0;
                    }
                    if (dt.Rows[n]["Money"] != null && dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    if (dt.Rows[n]["WorkingMoney"] != null && dt.Rows[n]["WorkingMoney"].ToString() != "")
                    {
                        model.WorkingMoney = decimal.Parse(dt.Rows[n]["WorkingMoney"].ToString());
                    }
                    if (dt.Rows[n]["OutPrice"] != null && dt.Rows[n]["OutPrice"].ToString() != "")
                    {
                        model.OutPrice = decimal.Parse(dt.Rows[n]["OutPrice"].ToString());
                    }
                    if (dt.Rows[n]["MaterielPro"] != null && dt.Rows[n]["MaterielPro"].ToString() != "")
                    {
                        model.MaterielPro = decimal.Parse(dt.Rows[n]["MaterielPro"].ToString());
                    }
                    if (dt.Rows[n]["GrossProfit"] != null && dt.Rows[n]["GrossProfit"].ToString() != "")
                    {
                        model.GrossProfit = decimal.Parse(dt.Rows[n]["GrossProfit"].ToString());
                    }
                    if (dt.Rows[n]["GrossPro"] != null && dt.Rows[n]["GrossPro"].ToString() != "")
                    {
                        model.GrossPro = decimal.Parse(dt.Rows[n]["GrossPro"].ToString());
                    }
                    if (dt.Rows[n]["CMT"] != null && dt.Rows[n]["CMT"].ToString() != "")
                    {
                        model.CMT = decimal.Parse(dt.Rows[n]["CMT"].ToString());
                    }
                    model.BySizeName = dt.Rows[n]["BySizeName"].ToString();
                    model.ExSize = dt.Rows[n]["ExSize"].ToString();
                    model.MaterielLoss = dt.Rows[n]["MaterielLoss"].ToString();
                    model.PackLoss = dt.Rows[n]["PackLoss"].ToString();
                    if (dt.Rows[n]["FillManID"] != null && dt.Rows[n]["FillManID"].ToString() != "")
                    {
                        model.FillManID = int.Parse(dt.Rows[n]["FillManID"].ToString());
                    }
                    model.FillManName = dt.Rows[n]["FillManName"].ToString();
                    model.VerifyManName = dt.Rows[n]["VerifyManName"].ToString();
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
        /// 更新某款号的物料结构单IsDefault为假
        /// </summary>
        /// <param name="MaterielID">款号ID</param>
        public void UpDefault(int MaterielID)
        {
            dal.UpDefault(MaterielID);
        }
        /// <summary>
        /// 返回某款号的默认物料结构单编号
        /// </summary>
        /// <param name="MaterielID">款号</param>
        /// <returns></returns>
        public int GetIsDefaultID(int MaterielID)
        {
            return dal.GetIsDefaultID(MaterielID);
        }
                 /// <summary>
        /// 要把主表ID返回某物料结构
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetBomListByMainID(int MainID)
        {
            return dal.GetBomListByMainID(MainID);
        }
          /// <summary>
        /// 返回某物料的下一级结构(一般只用于半成品等只有一个版本的)
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetBomListByMateriel(int MaterielID)
        {
            return dal.GetBomListByMateriel(MaterielID);
        }
         /// <summary>
        /// 返回某生产单所用物料结构
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetDemandList(int MainID)
        {
            return dal.GetDemandList(MainID);
        }
         /// <summary>
        /// 返回某物料的下一级结构*主指半成品
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetDemandChildMateriel(int MaterielID)
        {
            return dal.GetDemandChildMateriel(MaterielID);
        }
        /// <summary>
        /// 判断某BOMID是否已使用
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool CheckBomID(int ID)
        {
            return dal.CheckBomID(ID);
        }
        /// <summary>
        /// 判断某半成品或外加工材料是否有使用
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool CheckWuliao(int ID)
        {
            return dal.CheckWuliao(ID);
        }
        /// <summary>
        /// 多表下返回某款号的主物料结构 ID列表
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetIDList(int MaterielID)
        {
            return dal.GetIDList(MaterielID);
        }
        public DataSet GetInfoIDList()
        {
            return dal.GetInfoIDList();
        }
        public int CountUse(int MainID)
        {
            return dal.CountUse(MainID);
        }
        public DataSet GetBrandList(int BrandID)
        {
            return dal.GetBrandList(BrandID);
        }
        /// <summary>
        /// 打印生产单时所需的BOM表
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPrintList(int MainID)
        {
            return dal.GetPrintList(MainID);
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

