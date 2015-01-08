using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类SysTem。
    /// </summary>
    public class SysTem
    {
        public SysTem()
        { }
        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "SysTem");
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SysTem");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SysTem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SysTem(");
            strSql.Append("CompanyName,LinkMan,Phone,Fax,HDSerie,Registration,BanKName,BankNO,BankUserName,Address,Direct2Depot,Sell4Depot,AutoClient,BoxOrPic,NumType,Mobile,SellMoney,CustOder,NotPermissions,DepotAllowNegative,IsChangedSales,BackDepotWorking,OderOne,OderTwo,OderThree,AutoCaicBoardWages,DefaultRawDepot,DefaultDepot,IsShowMoney,CompanyByUser,DoubleNotDefaultWTNum,OrderDays,OrderNeedEat,IsCheckNoWork,IsCanEditAmount,IsAutoClose,IsTicketNotNeedCaic,IsShowOutEmp,DataVer,MaterielByTask,SumByWorking)");
            strSql.Append(" values (");
            strSql.Append("@CompanyName,@LinkMan,@Phone,@Fax,@HDSerie,@Registration,@BanKName,@BankNO,@BankUserName,@Address,@Direct2Depot,@Sell4Depot,@AutoClient,@BoxOrPic,@NumType,@Mobile,@SellMoney,@CustOder,@NotPermissions,@DepotAllowNegative,@IsChangedSales,@BackDepotWorking,@OderOne,@OderTwo,@OderThree,@AutoCaicBoardWages,@DefaultRawDepot,@DefaultDepot,@IsShowMoney,@CompanyByUser,@DoubleNotDefaultWTNum,@OrderDays,@OrderNeedEat,@IsCheckNoWork,@IsCanEditAmount,@IsAutoClose,@IsTicketNotNeedCaic,@IsShowOutEmp,@DataVer,@MaterielByTask,@SumByWorking)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@LinkMan", SqlDbType.NVarChar,12),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@HDSerie", SqlDbType.NVarChar,50),
					new SqlParameter("@Registration", SqlDbType.NVarChar,2000),
					new SqlParameter("@BanKName", SqlDbType.NVarChar,255),
					new SqlParameter("@BankNO", SqlDbType.NVarChar,255),
					new SqlParameter("@BankUserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@Direct2Depot", SqlDbType.Bit,1),
					new SqlParameter("@Sell4Depot", SqlDbType.Bit,1),
					new SqlParameter("@AutoClient", SqlDbType.Bit,1),
					new SqlParameter("@BoxOrPic", SqlDbType.Bit,1),
					new SqlParameter("@NumType", SqlDbType.Int,4),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,255),
					new SqlParameter("@SellMoney", SqlDbType.Int,4),
					new SqlParameter("@CustOder", SqlDbType.Bit,1),
					new SqlParameter("@NotPermissions", SqlDbType.Bit,1),
					new SqlParameter("@DepotAllowNegative", SqlDbType.Bit,1),
					new SqlParameter("@IsChangedSales", SqlDbType.Bit,1),
					new SqlParameter("@BackDepotWorking", SqlDbType.Int,4),
					new SqlParameter("@OderOne", SqlDbType.Int,4),
					new SqlParameter("@OderTwo", SqlDbType.Int,4),
					new SqlParameter("@OderThree", SqlDbType.Int,4),
					new SqlParameter("@AutoCaicBoardWages", SqlDbType.Bit,1),
					new SqlParameter("@DefaultRawDepot", SqlDbType.Int,4),
					new SqlParameter("@DefaultDepot", SqlDbType.Int,4),
					new SqlParameter("@IsShowMoney", SqlDbType.Bit,1),
					new SqlParameter("@CompanyByUser", SqlDbType.Bit,1),
					new SqlParameter("@DoubleNotDefaultWTNum", SqlDbType.Decimal,9),
					new SqlParameter("@OrderDays", SqlDbType.Int,4),
					new SqlParameter("@OrderNeedEat", SqlDbType.Bit,1),
					new SqlParameter("@IsCheckNoWork", SqlDbType.Bit,1),
					new SqlParameter("@IsCanEditAmount", SqlDbType.Bit,1),
					new SqlParameter("@IsAutoClose", SqlDbType.Bit,1),
					new SqlParameter("@IsTicketNotNeedCaic", SqlDbType.Bit,1),
					new SqlParameter("@IsShowOutEmp", SqlDbType.Bit,1),
					new SqlParameter("@DataVer", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielByTask", SqlDbType.Bit,1),
					new SqlParameter("@SumByWorking", SqlDbType.Bit,1)};
            parameters[0].Value = model.CompanyName;
            parameters[1].Value = model.LinkMan;
            parameters[2].Value = model.Phone;
            parameters[3].Value = model.Fax;
            parameters[4].Value = model.HDSerie;
            parameters[5].Value = model.Registration;
            parameters[6].Value = model.BanKName;
            parameters[7].Value = model.BankNO;
            parameters[8].Value = model.BankUserName;
            parameters[9].Value = model.Address;
            parameters[10].Value = model.Direct2Depot;
            parameters[11].Value = model.Sell4Depot;
            parameters[12].Value = model.AutoClient;
            parameters[13].Value = model.BoxOrPic;
            parameters[14].Value = model.NumType;
            parameters[15].Value = model.Mobile;
            parameters[16].Value = model.SellMoney;
            parameters[17].Value = model.CustOder;
            parameters[18].Value = model.NotPermissions;
            parameters[19].Value = model.DepotAllowNegative;
            parameters[20].Value = model.IsChangedSales;
            parameters[21].Value = model.BackDepotWorking;
            parameters[22].Value = model.OderOne;
            parameters[23].Value = model.OderTwo;
            parameters[24].Value = model.OderThree;
            parameters[25].Value = model.AutoCaicBoardWages;
            parameters[26].Value = model.DefaultRawDepot;
            parameters[27].Value = model.DefaultDepot;
            parameters[28].Value = model.IsShowMoney;
            parameters[29].Value = model.CompanyByUser;
            parameters[30].Value = model.DoubleNotDefaultWTNum;
            parameters[31].Value = model.OrderDays;
            parameters[32].Value = model.OrderNeedEat;
            parameters[33].Value = model.IsCheckNoWork;
            parameters[34].Value = model.IsCanEditAmount;
            parameters[35].Value = model.IsAutoClose;
            parameters[36].Value = model.IsTicketNotNeedCaic;
            parameters[37].Value = model.IsShowOutEmp;
            parameters[38].Value = model.DataVer;
            parameters[39].Value = model.MaterielByTask;
            parameters[40].Value = model.SumByWorking;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hownet.Model.SysTem model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SysTem set ");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("LinkMan=@LinkMan,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Fax=@Fax,");
            strSql.Append("HDSerie=@HDSerie,");
            strSql.Append("Registration=@Registration,");
            strSql.Append("BanKName=@BanKName,");
            strSql.Append("BankNO=@BankNO,");
            strSql.Append("BankUserName=@BankUserName,");
            strSql.Append("Address=@Address,");
            strSql.Append("Direct2Depot=@Direct2Depot,");
            strSql.Append("Sell4Depot=@Sell4Depot,");
            strSql.Append("AutoClient=@AutoClient,");
            strSql.Append("BoxOrPic=@BoxOrPic,");
            strSql.Append("NumType=@NumType,");
            strSql.Append("Mobile=@Mobile,");
            strSql.Append("SellMoney=@SellMoney,");
            strSql.Append("CustOder=@CustOder,");
            strSql.Append("NotPermissions=@NotPermissions,");
            strSql.Append("DepotAllowNegative=@DepotAllowNegative,");
            strSql.Append("IsChangedSales=@IsChangedSales,");
            strSql.Append("BackDepotWorking=@BackDepotWorking,");
            strSql.Append("OderOne=@OderOne,");
            strSql.Append("OderTwo=@OderTwo,");
            strSql.Append("OderThree=@OderThree,");
            strSql.Append("AutoCaicBoardWages=@AutoCaicBoardWages,");
            strSql.Append("DefaultRawDepot=@DefaultRawDepot,");
            strSql.Append("DefaultDepot=@DefaultDepot,");
            strSql.Append("IsShowMoney=@IsShowMoney,");
            strSql.Append("CompanyByUser=@CompanyByUser,");
            strSql.Append("DoubleNotDefaultWTNum=@DoubleNotDefaultWTNum,");
            strSql.Append("OrderDays=@OrderDays,");
            strSql.Append("OrderNeedEat=@OrderNeedEat,");
            strSql.Append("IsCheckNoWork=@IsCheckNoWork,");
            strSql.Append("IsCanEditAmount=@IsCanEditAmount,");
            strSql.Append("IsAutoClose=@IsAutoClose,");
            strSql.Append("IsTicketNotNeedCaic=@IsTicketNotNeedCaic,");
            strSql.Append("IsShowOutEmp=@IsShowOutEmp,");
            strSql.Append("DataVer=@DataVer,");
            strSql.Append("MaterielByTask=@MaterielByTask,");
            strSql.Append("SumByWorking=@SumByWorking");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@LinkMan", SqlDbType.NVarChar,12),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@HDSerie", SqlDbType.NVarChar,50),
					new SqlParameter("@Registration", SqlDbType.NVarChar,2000),
					new SqlParameter("@BanKName", SqlDbType.NVarChar,255),
					new SqlParameter("@BankNO", SqlDbType.NVarChar,255),
					new SqlParameter("@BankUserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@Direct2Depot", SqlDbType.Bit,1),
					new SqlParameter("@Sell4Depot", SqlDbType.Bit,1),
					new SqlParameter("@AutoClient", SqlDbType.Bit,1),
					new SqlParameter("@BoxOrPic", SqlDbType.Bit,1),
					new SqlParameter("@NumType", SqlDbType.Int,4),
					new SqlParameter("@Mobile", SqlDbType.NVarChar,255),
					new SqlParameter("@SellMoney", SqlDbType.Int,4),
					new SqlParameter("@CustOder", SqlDbType.Bit,1),
					new SqlParameter("@NotPermissions", SqlDbType.Bit,1),
					new SqlParameter("@DepotAllowNegative", SqlDbType.Bit,1),
					new SqlParameter("@IsChangedSales", SqlDbType.Bit,1),
					new SqlParameter("@BackDepotWorking", SqlDbType.Int,4),
					new SqlParameter("@OderOne", SqlDbType.Int,4),
					new SqlParameter("@OderTwo", SqlDbType.Int,4),
					new SqlParameter("@OderThree", SqlDbType.Int,4),
					new SqlParameter("@AutoCaicBoardWages", SqlDbType.Bit,1),
					new SqlParameter("@DefaultRawDepot", SqlDbType.Int,4),
					new SqlParameter("@DefaultDepot", SqlDbType.Int,4),
					new SqlParameter("@IsShowMoney", SqlDbType.Bit,1),
					new SqlParameter("@CompanyByUser", SqlDbType.Bit,1),
					new SqlParameter("@DoubleNotDefaultWTNum", SqlDbType.Decimal,9),
					new SqlParameter("@OrderDays", SqlDbType.Int,4),
					new SqlParameter("@OrderNeedEat", SqlDbType.Bit,1),
					new SqlParameter("@IsCheckNoWork", SqlDbType.Bit,1),
					new SqlParameter("@IsCanEditAmount", SqlDbType.Bit,1),
					new SqlParameter("@IsAutoClose", SqlDbType.Bit,1),
					new SqlParameter("@IsTicketNotNeedCaic", SqlDbType.Bit,1),
					new SqlParameter("@IsShowOutEmp", SqlDbType.Bit,1),
					new SqlParameter("@DataVer", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielByTask", SqlDbType.Bit,1),
					new SqlParameter("@SumByWorking", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyName;
            parameters[1].Value = model.LinkMan;
            parameters[2].Value = model.Phone;
            parameters[3].Value = model.Fax;
            parameters[4].Value = model.HDSerie;
            parameters[5].Value = model.Registration;
            parameters[6].Value = model.BanKName;
            parameters[7].Value = model.BankNO;
            parameters[8].Value = model.BankUserName;
            parameters[9].Value = model.Address;
            parameters[10].Value = model.Direct2Depot;
            parameters[11].Value = model.Sell4Depot;
            parameters[12].Value = model.AutoClient;
            parameters[13].Value = model.BoxOrPic;
            parameters[14].Value = model.NumType;
            parameters[15].Value = model.Mobile;
            parameters[16].Value = model.SellMoney;
            parameters[17].Value = model.CustOder;
            parameters[18].Value = model.NotPermissions;
            parameters[19].Value = model.DepotAllowNegative;
            parameters[20].Value = model.IsChangedSales;
            parameters[21].Value = model.BackDepotWorking;
            parameters[22].Value = model.OderOne;
            parameters[23].Value = model.OderTwo;
            parameters[24].Value = model.OderThree;
            parameters[25].Value = model.AutoCaicBoardWages;
            parameters[26].Value = model.DefaultRawDepot;
            parameters[27].Value = model.DefaultDepot;
            parameters[28].Value = model.IsShowMoney;
            parameters[29].Value = model.CompanyByUser;
            parameters[30].Value = model.DoubleNotDefaultWTNum;
            parameters[31].Value = model.OrderDays;
            parameters[32].Value = model.OrderNeedEat;
            parameters[33].Value = model.IsCheckNoWork;
            parameters[34].Value = model.IsCanEditAmount;
            parameters[35].Value = model.IsAutoClose;
            parameters[36].Value = model.IsTicketNotNeedCaic;
            parameters[37].Value = model.IsShowOutEmp;
            parameters[38].Value = model.DataVer;
            parameters[39].Value = model.MaterielByTask;
            parameters[40].Value = model.SumByWorking;
            parameters[41].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysTem ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysTem ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.SysTem GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CompanyName,LinkMan,Phone,Fax,HDSerie,Registration,BanKName,BankNO,BankUserName,Address,Direct2Depot,Sell4Depot,AutoClient,BoxOrPic,NumType,Mobile,SellMoney,CustOder,NotPermissions,DepotAllowNegative,IsChangedSales,BackDepotWorking,OderOne,OderTwo,OderThree,AutoCaicBoardWages,DefaultRawDepot,DefaultDepot,IsShowMoney,CompanyByUser,DoubleNotDefaultWTNum,OrderDays,OrderNeedEat,IsCheckNoWork,IsCanEditAmount,IsAutoClose,IsTicketNotNeedCaic,IsShowOutEmp,DataVer,MaterielByTask,SumByWorking from SysTem ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.SysTem model = new Hownet.Model.SysTem();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.CompanyName = ds.Tables[0].Rows[0]["CompanyName"].ToString();
                model.LinkMan = ds.Tables[0].Rows[0]["LinkMan"].ToString();
                model.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                model.Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                model.HDSerie = ds.Tables[0].Rows[0]["HDSerie"].ToString();
                model.Registration = ds.Tables[0].Rows[0]["Registration"].ToString();
                model.BanKName = ds.Tables[0].Rows[0]["BanKName"].ToString();
                model.BankNO = ds.Tables[0].Rows[0]["BankNO"].ToString();
                model.BankUserName = ds.Tables[0].Rows[0]["BankUserName"].ToString();
                model.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                if (ds.Tables[0].Rows[0]["Direct2Depot"] != null && ds.Tables[0].Rows[0]["Direct2Depot"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Direct2Depot"].ToString() == "1") || (ds.Tables[0].Rows[0]["Direct2Depot"].ToString().ToLower() == "true"))
                    {
                        model.Direct2Depot = true;
                    }
                    else
                    {
                        model.Direct2Depot = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Sell4Depot"] != null && ds.Tables[0].Rows[0]["Sell4Depot"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Sell4Depot"].ToString() == "1") || (ds.Tables[0].Rows[0]["Sell4Depot"].ToString().ToLower() == "true"))
                    {
                        model.Sell4Depot = true;
                    }
                    else
                    {
                        model.Sell4Depot = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["AutoClient"] != null && ds.Tables[0].Rows[0]["AutoClient"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["AutoClient"].ToString() == "1") || (ds.Tables[0].Rows[0]["AutoClient"].ToString().ToLower() == "true"))
                    {
                        model.AutoClient = true;
                    }
                    else
                    {
                        model.AutoClient = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["BoxOrPic"] != null && ds.Tables[0].Rows[0]["BoxOrPic"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["BoxOrPic"].ToString() == "1") || (ds.Tables[0].Rows[0]["BoxOrPic"].ToString().ToLower() == "true"))
                    {
                        model.BoxOrPic = true;
                    }
                    else
                    {
                        model.BoxOrPic = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["NumType"] != null && ds.Tables[0].Rows[0]["NumType"].ToString() != "")
                {
                    model.NumType = int.Parse(ds.Tables[0].Rows[0]["NumType"].ToString());
                }
                model.Mobile = ds.Tables[0].Rows[0]["Mobile"].ToString();
                if (ds.Tables[0].Rows[0]["SellMoney"] != null && ds.Tables[0].Rows[0]["SellMoney"].ToString() != "")
                {
                    model.SellMoney = int.Parse(ds.Tables[0].Rows[0]["SellMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustOder"] != null && ds.Tables[0].Rows[0]["CustOder"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["CustOder"].ToString() == "1") || (ds.Tables[0].Rows[0]["CustOder"].ToString().ToLower() == "true"))
                    {
                        model.CustOder = true;
                    }
                    else
                    {
                        model.CustOder = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["NotPermissions"] != null && ds.Tables[0].Rows[0]["NotPermissions"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["NotPermissions"].ToString() == "1") || (ds.Tables[0].Rows[0]["NotPermissions"].ToString().ToLower() == "true"))
                    {
                        model.NotPermissions = true;
                    }
                    else
                    {
                        model.NotPermissions = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["DepotAllowNegative"] != null && ds.Tables[0].Rows[0]["DepotAllowNegative"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["DepotAllowNegative"].ToString() == "1") || (ds.Tables[0].Rows[0]["DepotAllowNegative"].ToString().ToLower() == "true"))
                    {
                        model.DepotAllowNegative = true;
                    }
                    else
                    {
                        model.DepotAllowNegative = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsChangedSales"] != null && ds.Tables[0].Rows[0]["IsChangedSales"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsChangedSales"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsChangedSales"].ToString().ToLower() == "true"))
                    {
                        model.IsChangedSales = true;
                    }
                    else
                    {
                        model.IsChangedSales = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["BackDepotWorking"] != null && ds.Tables[0].Rows[0]["BackDepotWorking"].ToString() != "")
                {
                    model.BackDepotWorking = int.Parse(ds.Tables[0].Rows[0]["BackDepotWorking"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OderOne"] != null && ds.Tables[0].Rows[0]["OderOne"].ToString() != "")
                {
                    model.OderOne = int.Parse(ds.Tables[0].Rows[0]["OderOne"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OderTwo"] != null && ds.Tables[0].Rows[0]["OderTwo"].ToString() != "")
                {
                    model.OderTwo = int.Parse(ds.Tables[0].Rows[0]["OderTwo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OderThree"] != null && ds.Tables[0].Rows[0]["OderThree"].ToString() != "")
                {
                    model.OderThree = int.Parse(ds.Tables[0].Rows[0]["OderThree"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AutoCaicBoardWages"] != null && ds.Tables[0].Rows[0]["AutoCaicBoardWages"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["AutoCaicBoardWages"].ToString() == "1") || (ds.Tables[0].Rows[0]["AutoCaicBoardWages"].ToString().ToLower() == "true"))
                    {
                        model.AutoCaicBoardWages = true;
                    }
                    else
                    {
                        model.AutoCaicBoardWages = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["DefaultRawDepot"] != null && ds.Tables[0].Rows[0]["DefaultRawDepot"].ToString() != "")
                {
                    model.DefaultRawDepot = int.Parse(ds.Tables[0].Rows[0]["DefaultRawDepot"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DefaultDepot"] != null && ds.Tables[0].Rows[0]["DefaultDepot"].ToString() != "")
                {
                    model.DefaultDepot = int.Parse(ds.Tables[0].Rows[0]["DefaultDepot"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsShowMoney"] != null && ds.Tables[0].Rows[0]["IsShowMoney"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsShowMoney"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsShowMoney"].ToString().ToLower() == "true"))
                    {
                        model.IsShowMoney = true;
                    }
                    else
                    {
                        model.IsShowMoney = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["CompanyByUser"] != null && ds.Tables[0].Rows[0]["CompanyByUser"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["CompanyByUser"].ToString() == "1") || (ds.Tables[0].Rows[0]["CompanyByUser"].ToString().ToLower() == "true"))
                    {
                        model.CompanyByUser = true;
                    }
                    else
                    {
                        model.CompanyByUser = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["DoubleNotDefaultWTNum"] != null && ds.Tables[0].Rows[0]["DoubleNotDefaultWTNum"].ToString() != "")
                {
                    model.DoubleNotDefaultWTNum = decimal.Parse(ds.Tables[0].Rows[0]["DoubleNotDefaultWTNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderDays"] != null && ds.Tables[0].Rows[0]["OrderDays"].ToString() != "")
                {
                    model.OrderDays = int.Parse(ds.Tables[0].Rows[0]["OrderDays"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderNeedEat"] != null && ds.Tables[0].Rows[0]["OrderNeedEat"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["OrderNeedEat"].ToString() == "1") || (ds.Tables[0].Rows[0]["OrderNeedEat"].ToString().ToLower() == "true"))
                    {
                        model.OrderNeedEat = true;
                    }
                    else
                    {
                        model.OrderNeedEat = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCheckNoWork"] != null && ds.Tables[0].Rows[0]["IsCheckNoWork"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCheckNoWork"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCheckNoWork"].ToString().ToLower() == "true"))
                    {
                        model.IsCheckNoWork = true;
                    }
                    else
                    {
                        model.IsCheckNoWork = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCanEditAmount"] != null && ds.Tables[0].Rows[0]["IsCanEditAmount"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCanEditAmount"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCanEditAmount"].ToString().ToLower() == "true"))
                    {
                        model.IsCanEditAmount = true;
                    }
                    else
                    {
                        model.IsCanEditAmount = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsAutoClose"] != null && ds.Tables[0].Rows[0]["IsAutoClose"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsAutoClose"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsAutoClose"].ToString().ToLower() == "true"))
                    {
                        model.IsAutoClose = true;
                    }
                    else
                    {
                        model.IsAutoClose = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsTicketNotNeedCaic"] != null && ds.Tables[0].Rows[0]["IsTicketNotNeedCaic"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsTicketNotNeedCaic"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsTicketNotNeedCaic"].ToString().ToLower() == "true"))
                    {
                        model.IsTicketNotNeedCaic = true;
                    }
                    else
                    {
                        model.IsTicketNotNeedCaic = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsShowOutEmp"] != null && ds.Tables[0].Rows[0]["IsShowOutEmp"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsShowOutEmp"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsShowOutEmp"].ToString().ToLower() == "true"))
                    {
                        model.IsShowOutEmp = true;
                    }
                    else
                    {
                        model.IsShowOutEmp = false;
                    }
                }
                model.DataVer = ds.Tables[0].Rows[0]["DataVer"].ToString();
                if (ds.Tables[0].Rows[0]["MaterielByTask"] != null && ds.Tables[0].Rows[0]["MaterielByTask"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["MaterielByTask"].ToString() == "1") || (ds.Tables[0].Rows[0]["MaterielByTask"].ToString().ToLower() == "true"))
                    {
                        model.MaterielByTask = true;
                    }
                    else
                    {
                        model.MaterielByTask = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["SumByWorking"] != null && ds.Tables[0].Rows[0]["SumByWorking"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["SumByWorking"].ToString() == "1") || (ds.Tables[0].Rows[0]["SumByWorking"].ToString().ToLower() == "true"))
                    {
                        model.SumByWorking = true;
                    }
                    else
                    {
                        model.SumByWorking = false;
                    }
                }
                model.A = 1;
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  1 as A,ID,CompanyName,LinkMan,Phone,Fax,HDSerie,Registration,BanKName,BankNO,BankUserName,Address,Direct2Depot,Sell4Depot,AutoClient,BoxOrPic,NumType,Mobile,SellMoney,CustOder,NotPermissions,DepotAllowNegative,IsChangedSales,BackDepotWorking,OderOne,OderTwo,OderThree,AutoCaicBoardWages,DefaultRawDepot,DefaultDepot,IsShowMoney,CompanyByUser,DoubleNotDefaultWTNum,OrderDays,OrderNeedEat,IsCheckNoWork,IsCanEditAmount,IsAutoClose,IsTicketNotNeedCaic,IsShowOutEmp,DataVer,MaterielByTask,SumByWorking ");
            strSql.Append(" FROM SysTem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,CompanyName,LinkMan,Phone,Fax,HDSerie,Registration,BanKName,BankNO,BankUserName,Address,Direct2Depot,Sell4Depot,AutoClient,BoxOrPic,NumType,Mobile,SellMoney,CustOder,NotPermissions,DepotAllowNegative,IsChangedSales,BackDepotWorking,OderOne,OderTwo,OderThree,AutoCaicBoardWages,DefaultRawDepot,DefaultDepot,IsShowMoney,CompanyByUser,DoubleNotDefaultWTNum,OrderDays,OrderNeedEat,IsCheckNoWork,IsCanEditAmount,IsAutoClose,IsTicketNotNeedCaic,IsShowOutEmp,DataVer,MaterielByTask,SumByWorking ");
            strSql.Append(" FROM SysTem ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 根据硬盘序列号检查软件注册状态，如果没有注册信息，添加记录并返回空，并返回注册码
        /// </summary>
        /// <param name="HDID"></param>
        /// <returns></returns>
        public string CheckHDID(string HDID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as qwe from system where (HDSerie=@HDID)");
            SqlParameter[] sps ={ new SqlParameter("@HDID", HDID) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sps).ToString() == "0")
            {
                Hownet.Model.SysTem modST = new Hownet.Model.SysTem();
                modST.CompanyName = "";
                modST.Fax = "";
                modST.LinkMan = "";
                modST.Phone = "";
                modST.Registration = "";
                modST.HDSerie = HDID;
                Add(modST);
                return string.Empty;
            }
            else
            {
                string sql = "select Registration from system where (HDSerie=@HDID)";
                object obj = DbHelperSQL.GetSingle(sql, sps);
                return obj.ToString();
            }
        }
        public void Backup(string fileName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("BACKUP DATABASE [Task] TO  DISK = @fileName WITH NOFORMAT, NOINIT,  ");
            strSql.Append(" NAME = N'Task_backup', SKIP, REWIND, NOUNLOAD,  STATS = 10 ");
            SqlParameter[] sps = {new SqlParameter("@fileName",fileName) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public void ClearAll(string table )
        {
            String strSql = "Truncate Table " + table;
            DbHelperSQL.GetSingle(strSql);
        }
        public void UpDatabase()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select Top 1 DataVer from System Order by ID Desc");
            string ssVer = string.Empty;
            try
            {
                ssVer = DbHelperSQL.GetSingle(strSql.ToString()).ToString();
            }
            catch
            {
                strSql.Remove(0, strSql.Length);
                strSql.Append("ALTER TABLE dbo.SysTem ADD	DataVer nvarchar(50) NOT NULL CONSTRAINT DF_SysTem_DataVer DEFAULT '1' ");
                DbHelperSQL.ExecuteSql(strSql.ToString());
                ssVer = "1";
            }
            if (ssVer == "1")
            {
                strSql.Remove(0, strSql.Length);
                strSql.Append(" ALTER TABLE dbo.Materiel ADD ");
                strSql.Append(" TiaoMaH nvarchar(50) NOT NULL CONSTRAINT DF_Materiel_TiaoMaH DEFAULT '',");
                strSql.Append(" ChengBengJ decimal(18, 2) NOT NULL CONSTRAINT DF_Materiel_ChengBengJ DEFAULT 0,");
                strSql.Append(" LingShouJia decimal(18, 2) NOT NULL CONSTRAINT DF_Materiel_LingShouJia DEFAULT 0,");
                strSql.Append(" YiJiDaiLiJia decimal(18, 2) NOT NULL CONSTRAINT DF_Materiel_YiJiDaiLiJia DEFAULT 0,");
                strSql.Append(" ErJiDaiLiJia decimal(18, 2) NOT NULL CONSTRAINT DF_Materiel_ErJiDaiLiJia DEFAULT 0, ");
                strSql.Append(" SanJiDaiLiJia decimal(18, 2) NOT NULL CONSTRAINT DF_Materiel_SanJiDaiLiJia DEFAULT 0");
                DbHelperSQL.ExecuteSql(strSql.ToString());


                Hownet.Model.SysTem modST = GetModel(GetMaxId() - 1);
                modST.DataVer = "2";
                Update(modST);
            }
            if (ssVer == "2")
            {
                strSql.Remove(0, strSql.Length);
                strSql.Append(" ");
            }
        }
        public bool CheckCanSetMatByTask()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT COUNT(ID) AS Expr1 FROM Repertory GROUP BY MListID, DepartmentID HAVING (COUNT(ID) > 1) ");
            return DbHelperSQL.Query(strSql.ToString()).Tables[0].Rows.Count == 0;
        }
        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            SqlParameter[] parameters = {
                    new SqlParameter("@tblName", SqlDbType.VarChar, 255),
                    new SqlParameter("@fldName", SqlDbType.VarChar, 255),
                    new SqlParameter("@PageSize", SqlDbType.Int),
                    new SqlParameter("@PageIndex", SqlDbType.Int),
                    new SqlParameter("@IsReCount", SqlDbType.Bit),
                    new SqlParameter("@OrderType", SqlDbType.Bit),
                    new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
                    };
            parameters[0].Value = "SysTem";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  成员方法
    }
}

