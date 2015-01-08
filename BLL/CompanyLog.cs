using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类CompanyLog 的摘要说明。
    /// </summary>
    public class CompanyLog
    {
        private readonly Hownet.DAL.CompanyLog dal = new Hownet.DAL.CompanyLog();
        public CompanyLog()
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
        public int Add(Hownet.Model.CompanyLog model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.CompanyLog> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                Hownet.BLL.Bas_KJKM bllKJ = new Bas_KJKM();
                List<Hownet.Model.Bas_KJKM> liKJ = bllKJ.DataTableToList(bllKJ.GetList("(CompanyID=" + li[0].CompanyID + ")").Tables[0]);
                if (liKJ.Count > 0)
                {
                    if (li[0].TypeID == (int)Enums.MoneyTableType.BackMoney)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.OutMoney)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Back)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Sell)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.SellBack)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.StockBackSupp)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                }
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
        public void Update(Hownet.Model.CompanyLog model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.CompanyLog> li = DataTableToList(dt);
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
        public Hownet.Model.CompanyLog GetModel(int ID)
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
        public List<Hownet.Model.CompanyLog> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.CompanyLog> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.CompanyLog> modelList = new List<Hownet.Model.CompanyLog>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.CompanyLog model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.CompanyLog();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["LastMoney"].ToString() != "")
                    {
                        model.LastMoney = decimal.Parse(dt.Rows[n]["LastMoney"].ToString());
                    }
                    if (dt.Rows[n]["ChangMoney"].ToString() != "")
                    {
                        model.ChangMoney = decimal.Parse(dt.Rows[n]["ChangMoney"].ToString());
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    if (dt.Rows[n]["TableID"].ToString() != "")
                    {
                        model.TableID = int.Parse(dt.Rows[n]["TableID"].ToString());
                    }
                    if (dt.Rows[n]["NowMoneyTypeID"].ToString() != "")
                    {
                        model.NowMoneyTypeID = int.Parse(dt.Rows[n]["NowMoneyTypeID"].ToString());
                    }
                    if (dt.Rows[n]["NowMoney"].ToString() != "")
                    {
                        model.NowMoney = decimal.Parse(dt.Rows[n]["NowMoney"].ToString());
                    }
                    if (dt.Rows[n]["NowReta"].ToString() != "")
                    {
                        model.NowReta = decimal.Parse(dt.Rows[n]["NowReta"].ToString());
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
        /// 判断是否可以修改期初余额
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public bool CheckCanEditLoan(int CompanyID)
        {
            return dal.CheckCanEditLoan(CompanyID);
        }
                /// <summary>
        /// 返回新增入库单时，前次入库到本次之间还款金额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetBackMoney(int CompanyID)
        {
            return dal.GetBackMoney(CompanyID);
        }
        /// <summary>
        /// 返回新增入库单时，前次入库后金额
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public decimal GetBackLastMoney(int CompanyID)
        {
            return dal.GetBackLastMoney(CompanyID);
        }
            /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteLog(int CompanyID, int TypeID, int TableID)
        {
             
                List<Hownet.Model.CompanyLog> li = DataTableToList(GetList(" (CompanyID=" + CompanyID + ") And (TypeID=" + TypeID + ") And (TableID=" + TableID + ") ").Tables[0]);
                dal.DeleteLog(CompanyID, TypeID, TableID);
try
            {
              
                Hownet.BLL.Bas_KJKM bllKJ = new Bas_KJKM();
                List<Hownet.Model.Bas_KJKM> liKJ = bllKJ.DataTableToList(bllKJ.GetList("(CompanyID=" + li[0].CompanyID + ")").Tables[0]);
                if (liKJ.Count > 0)
                {
                    if (li[0].TypeID == (int)Enums.MoneyTableType.BackMoney)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.OutMoney)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Back)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.Sell)
                    {
                        liKJ[0].Money -= li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.SellBack)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(1122);
                    }
                    else if (li[0].TypeID == (int)Enums.MoneyTableType.StockBackSupp)
                    {
                        liKJ[0].Money += li[0].ChangMoney;
                        bllKJ.Update(liKJ[0]);
                        bllKJ.UpMoney(2202);
                    }
                }
               
            }
            catch (Exception ex)
            {
            }
        }
                /// <summary>
        /// 返回新增销售单时，前次开单到本次之间还款金额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetBackSellMoney(int CompanyID)
        {
            return dal.GetBackSellMoney(CompanyID);
        }
        /// <summary>
        /// 返回新增发货单时，前次入库后金额
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetSellLastMoney(int CompanyID)
        {
            return dal.GetSellLastMoney(CompanyID);
        }
        /// 获取往来帐列表
        /// </summary>
        /// <param name="TypeID">类型，true为客户，false为供应商</param>
        /// <returns></returns>
        public DataSet GetFinanceList(int TypeID,DateTime dtOne,DateTime dtTwo)
        {
            Hownet.BLL.Company bllCom = new Company();
            DataTable dt = new DataTable();
            dt.TableName = "Main";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("CompanyID", typeof(int));
            dt.Columns.Add("CompanyName", typeof(string));
            dt.Columns.Add("DateTime", typeof(string));
            dt.Columns.Add("Remark", typeof(string));
            dt.Columns.Add("Debit", typeof(decimal));//借方金额
            dt.Columns.Add("Lenders", typeof(decimal));//贷方金额
            dt.Columns.Add("Money", typeof(decimal));
            dt.Columns.Add("Indexs", typeof(string));
            dt.Columns.Add("Whys", typeof(int));
            DataTable dtList = new DataTable();
            //if (TypeID == 1)
            //    //dtList = GetList("(TypeID=4) Or (TypeID=5) Or (TypeID=3) Or (TypeID=-1) ORDER BY ID").Tables[0];
            //    dtList = GetList(" (Select TypeID from Company where (id=CompanyLog.CompanyID))=" + TypeID + ")").Tables[0];
            //else if (TypeID == 2)
            //    //dtList = GetList("(TypeID=1) OR (TypeID=6) Or (TypeID=2)  or (TypeID=-2) ORDER BY ID").Tables[0];
            //    dtList = GetList(" (Select TypeID from Company where (id=CompanyLog.CompanyID))=" + TypeID + ")").Tables[0];
            //else if (TypeID == 3)

            dtList = GetList(" ((Select TypeID from Company where (id=CompanyLog.CompanyID))=" + TypeID + ") And (DateTime>=CONVERT(DATETIME, '" + dtOne + "', 102)) And (DateTime<CONVERT(DATETIME, '" + dtTwo + "', 102)) ORDER BY ID").Tables[0];
                if (dtList.Rows.Count > 0)
                {
                    for (int i = 0; i < dtList.Rows.Count; i++)
                    {
                        DataRow dr = dt.NewRow();
                        dr["ID"] = dtList.DefaultView[i]["ID"];
                        dr["CompanyID"] = dtList.DefaultView[i]["CompanyID"];
                        if (dr["CompanyID"].ToString() != "0")
                            dr["CompanyName"] = bllCom.GetModel(int.Parse(dtList.DefaultView[i]["CompanyID"].ToString())).Name;
                        else
                            dr["CompanyName"] = "";
                        dr["Money"] = dtList.DefaultView[i]["Money"];
                        dr["Whys"] = dtList.DefaultView[i]["TypeID"];
                        int k = int.Parse(dtList.DefaultView[i]["TypeID"].ToString());
                        //if (dtList.DefaultView[i]["Indexs"].ToString() != "0") 
                        //{
                        dr["DateTime"] = ((DateTime)(dtList.DefaultView[i]["DateTime"])).ToLongDateString();
                        dr["Indexs"] = dtList.DefaultView[i]["TableID"];
                        switch (k)
                        {
                            case 3:
                                {
                                    dr["Remark"] = "销售出库";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 4:
                                {
                                    dr["Remark"] = "收货款";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 5:
                                {
                                    dr["Remark"] = "销售退货";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 1:
                                {
                                    dr["Remark"] = "材料采购入库";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 2:
                                {
                                    dr["Remark"] = "付材料款";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 6:
                                {
                                    dr["Remark"] = "采购退货";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case -1:
                                {
                                    dr["Remark"] = "期初余额";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    dr["Indexs"] = string.Empty;
                                    break;
                                }
                            case -2:
                                {
                                    dr["Remark"] = "期初余额";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    dr["Indexs"] = string.Empty;
                                    break;
                                }
                            case -3:
                                {
                                    dr["Remark"] = "期初余额";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    dr["Indexs"] = string.Empty;
                                    break;
                                }
                            case 7:
                                {
                                    dr["Remark"] = "加工厂领料";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 8:
                                {
                                    dr["Remark"] = "加工厂来成品";
                                    dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            case 9:
                                {
                                    dr["Remark"] = "付加工厂货款";
                                    dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                    break;
                                }
                            //}
                        }

                        dt.Rows.Add(dr);
                    }
                }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            if (TypeID==1)
            {
                try
                {
                    DataTable dtt = dal.GetSellOne(dtOne,dtTwo).Tables[0].Copy();
                    dtt.TableName = "Sell";
                    ds.Tables.Add(dtt);
                    ds.Relations.Add("明细", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
                }
                catch //(Exception ex)
                {
                }
               
            }
            else if (TypeID == 2)
            {
                try
                {
                    DataTable dtt = dal.GetStockBack(dtOne, dtTwo).Tables[0].Copy();
                    dtt.TableName = "Sell";
                    ds.Tables.Add(dtt);
                    ds.Relations.Add("明细", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
                }
                catch (Exception ex)
                {
                }
            }
            else if (TypeID == 3)
            {
                //DataTable dtt = dal.GetProcessing(dtOne, dtTwo).Tables[0].Copy();
                //dtt.TableName = "Sell";
                //ds.Tables.Add(dtt);
                //ds.Relations.Add("明细", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
            }

            return ds;
        }
        public void DeleteByCompanyID(int CompanyID)
        {
            dal.DeleteByCompanyID(CompanyID);
        }
        public DataSet GetCompanyMoney(int TypeID)
        {
            return dal.GetCompanyMoney(TypeID);
        }
        /// 获取往来帐列表
        /// </summary>
        /// <param name="TypeID">类型，true为客户，false为供应商</param>
        /// <returns></returns>
        public DataSet GetCompanyMoneyList(bool TypeID, int CompanyID,DateTime dtOne,DateTime dtTwo)
        {
            Hownet.BLL.Company bllCom = new Company();
            DataTable dt = new DataTable();
            dt.TableName = "Main";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("CompanyID", typeof(int));
            dt.Columns.Add("CompanyName", typeof(string));
            dt.Columns.Add("DateTime", typeof(string));
            dt.Columns.Add("Remark", typeof(string));
            dt.Columns.Add("Debit", typeof(decimal));//借方金额
            dt.Columns.Add("Lenders", typeof(decimal));//贷方金额
            dt.Columns.Add("Money", typeof(decimal));
            dt.Columns.Add("Indexs", typeof(string));
            dt.Columns.Add("Whys", typeof(int));
            DataTable dtList = new DataTable();
            //if (TypeID)
            //    dtList = GetList("(CompanyID=" + CompanyID + ") And ( (TypeID=4) Or (TypeID=5) Or (TypeID=3) Or (TypeID=-1)) ORDER BY ID").Tables[0];
            //else
            //    dtList = GetList("(CompanyID=" + CompanyID + ") And ((TypeID=1) OR (TypeID=6) Or (TypeID=2)  or (TypeID=-2)) ORDER BY ID").Tables[0];
            dtList = GetList(" (CompanyID=" + CompanyID + ") And (DateTime>=CONVERT(DATETIME, '" + dtOne + "', 102)) And (DateTime<CONVERT(DATETIME, '" + dtTwo + "', 102))  ORDER BY ID").Tables[0];
            if (dtList.Rows.Count > 0)
            {
                for (int i = 0; i < dtList.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    dr["ID"] = dtList.DefaultView[i]["ID"];
                    dr["CompanyID"] = dtList.DefaultView[i]["CompanyID"];
                    dr["CompanyName"] = bllCom.GetModel(int.Parse(dtList.DefaultView[i]["CompanyID"].ToString())).Name;
                    dr["Money"] = dtList.DefaultView[i]["Money"];
                    dr["Whys"] = dtList.DefaultView[i]["TypeID"];
                    int k = int.Parse(dtList.DefaultView[i]["TypeID"].ToString());
                    //if (dtList.DefaultView[i]["Indexs"].ToString() != "0") 
                    //{
                    dr["DateTime"] = ((DateTime)(dtList.DefaultView[i]["DateTime"])).ToLongDateString();
                    dr["Indexs"] = dtList.DefaultView[i]["TableID"];
                    switch (k)
                    {
                        case 3:
                            {
                                dr["Remark"] = "销售出库";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 4:
                            {
                                dr["Remark"] = "收货款";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 5:
                            {
                                dr["Remark"] = "销售退货";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 1:
                            {
                                dr["Remark"] = "材料采购入库";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 2:
                            {
                                dr["Remark"] = "付材料款";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 6:
                            {
                                dr["Remark"] = "采购退货";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case -1:
                            {
                                dr["Remark"] = "期初余额";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                dr["Indexs"] = string.Empty;
                                break;
                            }
                        case -2:
                            {
                                dr["Remark"] = "期初余额";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                dr["Indexs"] = string.Empty;
                                break;
                            }
                        case -3:
                            {
                                dr["Remark"] = "期初余额";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                dr["Indexs"] = string.Empty;
                                break;
                            }
                        case 7:
                            {
                                dr["Remark"] = "加工厂领料";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 8:
                            {
                                dr["Remark"] = "加工厂来成品";
                                dr["Debit"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                        case 9:
                            {
                                dr["Remark"] = "付加工厂货款";
                                dr["Lenders"] = dtList.DefaultView[i]["ChangMoney"];
                                break;
                            }
                    }

                    dt.Rows.Add(dr);
                }
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            //DataTable dtt = dal.GetSellOne(TypeID).Tables[0].Copy();
            //dtt.TableName = "Sell";
            //ds.Tables.Add(dtt);
            //ds.Relations.Add("明细", ds.Tables["Main"].Columns["ID"], ds.Tables["Sell"].Columns["ID"]);
            return ds;
        }
        /// <summary>
        /// 是否可以弃审单据
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <param name="TableID"></param>
        /// <returns></returns>
        public int CanUnVerify(int CompanyID, int TypeID, int TableID)
        {
            return dal.CanUnVerify(CompanyID, TypeID, TableID);
        }
           /// <summary>
        /// 返回加工厂领料时，返回此前欠款
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public decimal GetProcessingBackLastMoney(int CompanyID)
        {
            return dal.GetProcessingBackLastMoney(CompanyID);
        }
        /// <summary>
        /// 返回新增领料单时，期间付款或领料
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetProcessingBackMoney(int CompanyID)
        {
            return dal.GetProcessingBackMoney(CompanyID);
        }
            /// <summary>
        /// 返回新增外加工收货单时，上次欠加工厂货款
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetProcess2DepotLastMoney(int CompanyID)
        {
            return dal.GetProcess2DepotLastMoney(CompanyID);
        }
        /// <summary>
        /// 返回新外加工收货单时，期间还款金额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetProcess2DepotBackSellMoney(int CompanyID)
        {
            return dal.GetProcess2DepotBackSellMoney(CompanyID);
        }
        public decimal GetLastMoney(int CompanyID)
        {
            return dal.GetLastMoney(CompanyID);
        }
        public DataSet GetInOutList(int TypeID, DateTime dt1, DateTime dt2)
        {
            return dal.GetInOutList(TypeID, dt1, dt2);
        }
        public DataSet GetLastMoneyList(int TypeID)
        {
            return new DataSet();
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

