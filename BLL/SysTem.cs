using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类SysTem 的摘要说明。
    /// </summary>
    public class SysTem
    {
        private readonly Hownet.DAL.SysTem dal = new Hownet.DAL.SysTem();
        public SysTem()
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
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SysTem model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.SysTem> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.SysTem model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.SysTem> li = DataTableToList(dt);
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
        public Hownet.Model.SysTem GetModel(int ID)
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
        public List<Hownet.Model.SysTem> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.SysTem> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.SysTem> modelList = new List<Hownet.Model.SysTem>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.SysTem model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.SysTem();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    model.CompanyName = dt.Rows[n]["CompanyName"].ToString();
                    model.LinkMan = dt.Rows[n]["LinkMan"].ToString();
                    model.Phone = dt.Rows[n]["Phone"].ToString();
                    model.Fax = dt.Rows[n]["Fax"].ToString();
                    model.HDSerie = dt.Rows[n]["HDSerie"].ToString();
                    model.Registration = dt.Rows[n]["Registration"].ToString();
                    model.BanKName = dt.Rows[n]["BanKName"].ToString();
                    model.BankNO = dt.Rows[n]["BankNO"].ToString();
                    model.BankUserName = dt.Rows[n]["BankUserName"].ToString();
                    model.Address = dt.Rows[n]["Address"].ToString();
                    if (dt.Rows[n]["Direct2Depot"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Direct2Depot"].ToString() == "1") || (dt.Rows[n]["Direct2Depot"].ToString().ToLower() == "true"))
                        {
                            model.Direct2Depot = true;
                        }
                        else
                        {
                            model.Direct2Depot = false;
                        }
                    }
                    if (dt.Rows[n]["Sell4Depot"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Sell4Depot"].ToString() == "1") || (dt.Rows[n]["Sell4Depot"].ToString().ToLower() == "true"))
                        {
                            model.Sell4Depot = true;
                        }
                        else
                        {
                            model.Sell4Depot = false;
                        }
                    }
                    if (dt.Rows[n]["AutoClient"].ToString() != "")
                    {
                        if ((dt.Rows[n]["AutoClient"].ToString() == "1") || (dt.Rows[n]["AutoClient"].ToString().ToLower() == "true"))
                        {
                            model.AutoClient = true;
                        }
                        else
                        {
                            model.AutoClient = false;
                        }
                    }
                    if (dt.Rows[n]["BoxOrPic"].ToString() != "")
                    {
                        if ((dt.Rows[n]["BoxOrPic"].ToString() == "1") || (dt.Rows[n]["BoxOrPic"].ToString().ToLower() == "true"))
                        {
                            model.BoxOrPic = true;
                        }
                        else
                        {
                            model.BoxOrPic = false;
                        }
                    }
                    if (dt.Rows[n]["NumType"].ToString() != "")
                    {
                        model.NumType = int.Parse(dt.Rows[n]["NumType"].ToString());
                    }
                    else
                    {
                        model.NumType = 0;
                    }
                    model.Mobile = dt.Rows[n]["Mobile"].ToString();
                    if (dt.Rows[n]["SellMoney"].ToString() != "")
                    {
                        model.SellMoney = int.Parse(dt.Rows[n]["SellMoney"].ToString());
                    }
                    else
                    {
                        model.SellMoney = 0;
                    }
                    if (dt.Rows[n]["CustOder"].ToString() != "")
                    {
                        if ((dt.Rows[n]["CustOder"].ToString() == "1") || (dt.Rows[n]["CustOder"].ToString().ToLower() == "true"))
                        {
                            model.CustOder = true;
                        }
                        else
                        {
                            model.CustOder = false;
                        }
                    }
                    if (dt.Rows[n]["NotPermissions"].ToString() != "")
                    {
                        if ((dt.Rows[n]["NotPermissions"].ToString() == "1") || (dt.Rows[n]["NotPermissions"].ToString().ToLower() == "true"))
                        {
                            model.NotPermissions = true;
                        }
                        else
                        {
                            model.NotPermissions = false;
                        }
                    }
                    if (dt.Rows[n]["DepotAllowNegative"].ToString() != "")
                    {
                        if ((dt.Rows[n]["DepotAllowNegative"].ToString() == "1") || (dt.Rows[n]["DepotAllowNegative"].ToString().ToLower() == "true"))
                        {
                            model.DepotAllowNegative = true;
                        }
                        else
                        {
                            model.DepotAllowNegative = false;
                        }
                    }
                    if (dt.Rows[n]["IsChangedSales"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsChangedSales"].ToString() == "1") || (dt.Rows[n]["IsChangedSales"].ToString().ToLower() == "true"))
                        {
                            model.IsChangedSales = true;
                        }
                        else
                        {
                            model.IsChangedSales = false;
                        }
                    }
                    if (dt.Rows[n]["BackDepotWorking"].ToString() != "")
                    {
                        model.BackDepotWorking = int.Parse(dt.Rows[n]["BackDepotWorking"].ToString());
                    }
                    else
                    {
                        model.BackDepotWorking = 0;
                    }
                    if (dt.Rows[n]["OderOne"].ToString() != "")
                    {
                        model.OderOne = int.Parse(dt.Rows[n]["OderOne"].ToString());
                    }
                    else
                    {
                        model.OderOne = 0;
                    }
                    if (dt.Rows[n]["OderTwo"].ToString() != "")
                    {
                        model.OderTwo = int.Parse(dt.Rows[n]["OderTwo"].ToString());
                    }
                    else
                    {
                        model.OderTwo = 0;
                    }
                    if (dt.Rows[n]["OderThree"].ToString() != "")
                    {
                        model.OderThree = int.Parse(dt.Rows[n]["OderThree"].ToString());
                    }
                    else
                    {
                        model.OderThree = 0;
                    }
                    if (dt.Rows[n]["AutoCaicBoardWages"].ToString() != "")
                    {
                        if ((dt.Rows[n]["AutoCaicBoardWages"].ToString() == "1") || (dt.Rows[n]["AutoCaicBoardWages"].ToString().ToLower() == "true"))
                        {
                            model.AutoCaicBoardWages = true;
                        }
                        else
                        {
                            model.AutoCaicBoardWages = false;
                        }
                    }
                    if (dt.Rows[n]["DefaultRawDepot"].ToString() != "")
                    {
                        model.DefaultRawDepot = int.Parse(dt.Rows[n]["DefaultRawDepot"].ToString());
                    }
                    else
                    {
                        model.DefaultRawDepot = 0;
                    }
                    if (dt.Rows[n]["DefaultDepot"].ToString() != "")
                    {
                        model.DefaultDepot = int.Parse(dt.Rows[n]["DefaultDepot"].ToString());
                    }
                    else
                    {
                        model.DefaultDepot = 0;
                    }
                    if (dt.Rows[n]["IsShowMoney"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsShowMoney"].ToString() == "1") || (dt.Rows[n]["IsShowMoney"].ToString().ToLower() == "true"))
                        {
                            model.IsShowMoney = true;
                        }
                        else
                        {
                            model.IsShowMoney = false;
                        }
                    }
                    if (dt.Rows[n]["CompanyByUser"].ToString() != "")
                    {
                        if ((dt.Rows[n]["CompanyByUser"].ToString() == "1") || (dt.Rows[n]["CompanyByUser"].ToString().ToLower() == "true"))
                        {
                            model.CompanyByUser = true;
                        }
                        else
                        {
                            model.CompanyByUser = false;
                        }
                    }
                    if (dt.Rows[n]["DoubleNotDefaultWTNum"].ToString() != "")
                    {
                        model.DoubleNotDefaultWTNum = decimal.Parse(dt.Rows[n]["DoubleNotDefaultWTNum"].ToString());
                    }
                    else
                    {
                        model.DoubleNotDefaultWTNum = 0;
                    }
                    if (dt.Rows[n]["OrderDays"].ToString() != "")
                    {
                        model.OrderDays = int.Parse(dt.Rows[n]["OrderDays"].ToString());
                    }
                    if (dt.Rows[n]["OrderNeedEat"].ToString() != "")
                    {
                        if ((dt.Rows[n]["OrderNeedEat"].ToString() == "1") || (dt.Rows[n]["OrderNeedEat"].ToString().ToLower() == "true"))
                        {
                            model.OrderNeedEat = true;
                        }
                        else
                        {
                            model.OrderNeedEat = false;
                        }
                    }
                    if (dt.Rows[n]["IsCheckNoWork"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCheckNoWork"].ToString() == "1") || (dt.Rows[n]["IsCheckNoWork"].ToString().ToLower() == "true"))
                        {
                            model.IsCheckNoWork = true;
                        }
                        else
                        {
                            model.IsCheckNoWork = false;
                        }
                    }
                    if (dt.Rows[n]["IsCanEditAmount"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCanEditAmount"].ToString() == "1") || (dt.Rows[n]["IsCanEditAmount"].ToString().ToLower() == "true"))
                        {
                            model.IsCanEditAmount = true;
                        }
                        else
                        {
                            model.IsCanEditAmount = false;
                        }
                    }
                    if (dt.Rows[n]["IsAutoClose"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsAutoClose"].ToString() == "1") || (dt.Rows[n]["IsAutoClose"].ToString().ToLower() == "true"))
                        {
                            model.IsAutoClose = true;
                        }
                        else
                        {
                            model.IsAutoClose = false;
                        }
                    }
                    if (dt.Rows[n]["IsTicketNotNeedCaic"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsTicketNotNeedCaic"].ToString() == "1") || (dt.Rows[n]["IsTicketNotNeedCaic"].ToString().ToLower() == "true"))
                        {
                            model.IsTicketNotNeedCaic = true;
                        }
                        else
                        {
                            model.IsTicketNotNeedCaic = false;
                        }
                    }
                    if (dt.Rows[n]["IsShowOutEmp"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsShowOutEmp"].ToString() == "1") || (dt.Rows[n]["IsShowOutEmp"].ToString().ToLower() == "true"))
                        {
                            model.IsShowOutEmp = true;
                        }
                        else
                        {
                            model.IsShowOutEmp = false;
                        }
                    }
                    model.DataVer = dt.Rows[n]["DataVer"].ToString();
                    if (dt.Rows[n]["MaterielByTask"] != null && dt.Rows[n]["MaterielByTask"].ToString() != "")
                    {
                        if ((dt.Rows[n]["MaterielByTask"].ToString() == "1") || (dt.Rows[n]["MaterielByTask"].ToString().ToLower() == "true"))
                        {
                            model.MaterielByTask = true;
                        }
                        else
                        {
                            model.MaterielByTask = false;
                        }
                    }
                    if (dt.Rows[n]["SumByWorking"] != null && dt.Rows[n]["SumByWorking"].ToString() != "")
                    {
                        if ((dt.Rows[n]["SumByWorking"].ToString() == "1") || (dt.Rows[n]["SumByWorking"].ToString().ToLower() == "true"))
                        {
                            model.SumByWorking = true;
                        }
                        else
                        {
                            model.SumByWorking = false;
                        }
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
        /// 根据硬盘序列号检查软件注册状态，如果没有注册信息，添加记录并返回空，并返回注册码
        /// </summary>
        /// <param name="HDID"></param>
        /// <returns></returns>
        public string CheckHDID(string HDID)
        {
            return dal.CheckHDID(HDID);
        }
        public void Backup(string fileName)
        {
            dal.Backup(fileName);
        }
        public void ClearAll()
        {
            dal.ClearAll("AmountInfo");
            dal.ClearAll("CaiPian");
            dal.ClearAll("Color");
            dal.ClearAll("Company");
            dal.ClearAll("CompanyLog");
            dal.ClearAll("Deparment");
            dal.ClearAll("DepartmentDemand");
            dal.ClearAll("DepartmentTaskMain");
            //dal.ClearAll("Employee");
            dal.ClearAll("HandBackInfo");
            dal.ClearAll("HandBackMain");
            dal.ClearAll("Materiel");
            dal.ClearAll("MaterielType");
            MaterielType bllMT = new MaterielType();
            bllMT.AddBase();
            dal.ClearAll("MaterielDemand");
            dal.ClearAll("MaterielList");
            dal.ClearAll("MaterielStructInfo");
            dal.ClearAll("MaterielStructMain");
            //dal.ClearAll("MaterielType");
            dal.ClearAll("Measure");
            Measure bllMea = new Measure();
            bllMea.AddBase();
            dal.ClearAll("MiniEmp");
            dal.ClearAll("MoneyInOrOut");
            dal.ClearAll("Pay");
            dal.ClearAll("PayCosts");
            dal.ClearAll("PayCostsInfo");
            dal.ClearAll("PayInfo");
            dal.ClearAll("PayMain");
            dal.ClearAll("PaySum");
            dal.ClearAll("ProduceSell");
            dal.ClearAll("ProduceSellInfo");
            dal.ClearAll("ProduceSellOne");
            dal.ClearAll("ProduceTaskPhoto");
            dal.ClearAll("Product2Depot");
            dal.ClearAll("Product2DepotInfo");
            dal.ClearAll("ProductTaskMain");
            dal.ClearAll("ProductWorkingInfo");
            dal.ClearAll("ProductWorkingMain");
            dal.ClearAll("QuotePrice");
            dal.ClearAll("Repertory");
            dal.ClearAll("SalesOrderInfoList");
            dal.ClearAll("SalesOrderMain");
            dal.ClearAll("Size");
            dal.ClearAll("StockBack");
            dal.ClearAll("StockBackInfo");
            dal.ClearAll("Working");
            dal.ClearAll("WorkTicket");
            dal.ClearAll("WorkTicketBreak");
            dal.ClearAll("WorkTicketIDBack");
            dal.ClearAll("WorkTicketIDCard");
            dal.ClearAll("WorkTicketInfo");
            dal.ClearAll("WorkType");
            dal.ClearAll("SizeTable");
            dal.ClearAll("SizeTableInfo");
            dal.ClearAll("SamplesAmount");
            dal.ClearAll("SampleMateriel");
            dal.ClearAll("SampleMain");
        }
        public void UpDatabase()
        {
            dal.UpDatabase();
        }
        public bool CheckCanSetMatByTask()
        {

            return dal.CheckCanSetMatByTask();
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

