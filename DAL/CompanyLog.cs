using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类CompanyLog。
	/// </summary>
	public class CompanyLog
	{
		public CompanyLog()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CompanyLog"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CompanyLog");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.CompanyLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CompanyLog(");
            strSql.Append("CompanyID,DateTime,LastMoney,ChangMoney,Money,TypeID,TableID,NowMoneyTypeID,NowMoney,NowReta)");
            strSql.Append(" values (");
            strSql.Append("@CompanyID,@DateTime,@LastMoney,@ChangMoney,@Money,@TypeID,@TableID,@NowMoneyTypeID,@NowMoney,@NowReta)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ChangMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TableID", SqlDbType.Int,4),
					new SqlParameter("@NowMoneyTypeID", SqlDbType.Int,4),
					new SqlParameter("@NowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NowReta", SqlDbType.Decimal,9)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.LastMoney;
            parameters[3].Value = model.ChangMoney;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.TypeID;
            parameters[6].Value = model.TableID;
            parameters[7].Value = model.NowMoneyTypeID;
            parameters[8].Value = model.NowMoney;
            parameters[9].Value = model.NowReta;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Hownet.Model.CompanyLog model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CompanyLog set ");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("LastMoney=@LastMoney,");
            strSql.Append("ChangMoney=@ChangMoney,");
            strSql.Append("Money=@Money,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TableID=@TableID,");
            strSql.Append("NowMoneyTypeID=@NowMoneyTypeID,");
            strSql.Append("NowMoney=@NowMoney,");
            strSql.Append("NowReta=@NowReta");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ChangMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TableID", SqlDbType.Int,4),
					new SqlParameter("@NowMoneyTypeID", SqlDbType.Int,4),
					new SqlParameter("@NowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NowReta", SqlDbType.Decimal,9)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.CompanyID;
            parameters[2].Value = model.DateTime;
            parameters[3].Value = model.LastMoney;
            parameters[4].Value = model.ChangMoney;
            parameters[5].Value = model.Money;
            parameters[6].Value = model.TypeID;
            parameters[7].Value = model.TableID;
            parameters[8].Value = model.NowMoneyTypeID;
            parameters[9].Value = model.NowMoney;
            parameters[10].Value = model.NowReta;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
      
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {
            Hownet.Model.CompanyLog modCL = GetModel(ID);
            if (modCL.TypeID != 4 && modCL.TypeID != 2)
            {

            }

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CompanyLog ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 金額往來表單名
        /// </summary>
        public enum MoneyTableType
        {

            /// <summary>
            /// 采购收货
            /// </summary>
            Back = 1,
            /// <summary>
            /// 还供应商货款
            /// </summary>
            OutMoney = 2,
            /// <summary>
            /// 销售开单
            /// </summary>
            Sell = 3,
            /// <summary>
            /// 收客户货款
            /// </summary>
            BackMoney = 4,
            /// <summary>
            /// 销售退货
            /// </summary>
            SellBack = 5,
            /// <summary>
            /// 采购退货
            /// </summary>
            StockBackSupp = 6,
            /// <summary>
            /// 加工厂领料
            /// </summary>
            ProcessingLinLiao = 7,
            /// <summary>
            /// 加工厂来成品
            /// </summary>
            Processing2Depot = 8,
            /// <summary>
            /// 付加工厂货款
            /// </summary>
            OutProcessing = 9
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.CompanyLog GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CompanyID,DateTime,LastMoney,ChangMoney,Money,TypeID,TableID,NowMoneyTypeID,NowMoney,NowReta from CompanyLog ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.CompanyLog model = new Hownet.Model.CompanyLog();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastMoney"].ToString() != "")
                {
                    model.LastMoney = decimal.Parse(ds.Tables[0].Rows[0]["LastMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ChangMoney"].ToString() != "")
                {
                    model.ChangMoney = decimal.Parse(ds.Tables[0].Rows[0]["ChangMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TableID"].ToString() != "")
                {
                    model.TableID = int.Parse(ds.Tables[0].Rows[0]["TableID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowMoneyTypeID"].ToString() != "")
                {
                    model.NowMoneyTypeID = int.Parse(ds.Tables[0].Rows[0]["NowMoneyTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowMoney"].ToString() != "")
                {
                    model.NowMoney = decimal.Parse(ds.Tables[0].Rows[0]["NowMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowReta"].ToString() != "")
                {
                    model.NowReta = decimal.Parse(ds.Tables[0].Rows[0]["NowReta"].ToString());
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
            strSql.Append("select 1 as A,ID,CompanyID,DateTime,LastMoney,ChangMoney,Money,TypeID,TableID,NowMoneyTypeID,NowMoney,NowReta ");
            strSql.Append(" FROM CompanyLog ");
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
            strSql.Append(" ID,CompanyID,DateTime,LastMoney,ChangMoney,Money,TypeID,TableID,NowMoneyTypeID,NowMoney,NowReta ");
            strSql.Append(" FROM CompanyLog ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 判断是否可以修改期初余额
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <returns></returns>
        public bool CheckCanEditLoan(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT COUNT(ID) AS Expr1 FROM CompanyLog WHERE (CompanyID = @CompanyID)");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID) };
            int a = (int)DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (a > 1)
                return false;
            else
                return true;
        }
        /// <summary>
        /// 返回新增入库单时，前次入库到本次之间还款金额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetBackMoney(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT SUM(ChangMoney) AS Money, MAX(DateTime) AS DateTime FROM CompanyLog WHERE (TypeID = 2 OR TypeID = 6) AND (CompanyID = @comID) AND (ID > ");
            strSql.Append(" (SELECT TOP (1) ID FROM CompanyLog AS CompanyLog_1 WHERE (CompanyID = @comID) AND  ((TypeID = 1) Or (TypeID = -2)) ");
            strSql.Append(" ORDER BY ID DESC)) ");
            SqlParameter[] sps = { new SqlParameter("@comID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }
        /// <summary>
        /// 返回新增入库单时，前次入库后金额
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public decimal GetBackLastMoney(int CompanyID)
        {
            decimal money = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP (1) Money FROM CompanyLog WHERE (CompanyID = @CompanyID) AND ((TypeID = - 2) OR ");
            strSql.Append(" (TypeID = 1)) ORDER BY ID DESC");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (obj != null)
            {
                money = decimal.Parse(obj.ToString());
            }
            return money;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteLog(int CompanyID,int TypeID,int TableID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CompanyLog ");
            strSql.Append(" where (CompanyID=@ID) And (TypeID=@TypeID) And (TableID=@TableID) ");
            SqlParameter[] parameters = {new SqlParameter("@ID", CompanyID),new SqlParameter("@TypeID",TypeID),new SqlParameter("@TableID",TableID)};
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 返回新增入库单时，前次入库到本次之间还款金额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetBackSellMoney(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(ChangMoney) AS Money, MAX(DateTime) AS DateTime,Max(ID) as ID FROM      CompanyLog WHERE   (TypeID = 4 OR ");
            strSql.Append(" TypeID = 5) AND (CompanyID = @comID) AND (ID > (SELECT   TOP (1) ID FROM      CompanyLog AS CompanyLog_1 ");
            strSql.Append(" WHERE   (CompanyID = @comID) AND (TypeID = 3 OR TypeID = - 1) ORDER BY ID DESC))");
            SqlParameter[] sps = { new SqlParameter("@comID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回新增发货单时，前次入库后金额
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetSellLastMoney(int CompanyID)
        {
          //  decimal money = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP (1) DateTime,Money FROM CompanyLog WHERE (CompanyID = @CompanyID) AND ((TypeID = - 1) OR ");
            strSql.Append(" (TypeID = 3)) ORDER BY ID DESC");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID) };
            //object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            //if (obj != null)
            //{
            //    money = decimal.Parse(obj.ToString());
            //}
            //return money;
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSellOne(DateTime dtOne,DateTime dtTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CompanyLog.TypeID, (SELECT   Name FROM      Materiel WHERE   (ID = ProduceSellOne.MaterielID)) AS MaterielName, ");
            strSql.Append(" (SELECT   Name FROM      Materiel AS Materiel_1 WHERE   (ID = ProduceSellOne.BrandID)) AS BrandName, ProduceSellOne.Amount, ");
            strSql.Append(" ProduceSellOne.Conversion,  ProduceSellOne.BoxMeasureAmount, ProduceSellOne.Price, ProduceSellOne.Money, CompanyLog.ID ");
            strSql.Append(" FROM      CompanyLog INNER JOIN ProduceSellOne ON CompanyLog.TableID = ProduceSellOne.MainID WHERE  (CompanyLog.DateTime>=CONVERT(DATETIME, '" + dtOne + "', 102)) And (CompanyLog.DateTime<CONVERT(DATETIME, '" + dtTwo + "', 102))");
            //if (TypeID==2)
            //    strSql.Append(" (CompanyLog.TypeID = 1) or (CompanyLog.TypeID = 6)");
            //else
            //    strSql.Append(" (CompanyLog.TypeID = 3) or (CompanyLog.TypeID = 5)");
            strSql.Append(" And ((Select TypeID from Company where (id=CompanyLog.CompanyID))=1) ORDER BY CompanyLog.ID");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetStockBack(DateTime dtOne, DateTime dtTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   MaterielType.Name AS TypeName, Materiel.Name AS MaterielName, StockBackInfo.Amount, Measure.Name AS MeasureName, ");
            strSql.Append(" StockBackInfo.Price, StockBackInfo.Money, CompanyLog.ID, CompanyLog.TypeID FROM      StockBackInfo INNER JOIN ");
            strSql.Append(" CompanyLog ON StockBackInfo.MainID = CompanyLog.TableID INNER JOIN MaterielType INNER JOIN Materiel ON MaterielType.ID ");
            strSql.Append(" = Materiel.TypeID ON StockBackInfo.MaterielID = Materiel.ID INNER JOIN Measure ON StockBackInfo.CompanyMeasureID = Measure.ID ");
            strSql.Append(" WHERE   (CompanyLog.DateTime >= CONVERT(DATETIME,  '" + dtOne + "', 102)) AND  (CompanyLog.DateTime < ");
            strSql.Append("  CONVERT(DATETIME, '" + dtTwo + "', 102)) AND ((SELECT   TypeID FROM      Company WHERE   (ID = CompanyLog.CompanyID)) = 2) ");
            strSql.Append(" ORDER BY CompanyLog.ID");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetProcessing(DateTime dtOne, DateTime dtTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   MaterielType.Name AS TypeName, Materiel.Name AS MaterielName, ProduceSellOne.Amount, Measure.Name AS MeasureName, ");
            strSql.Append(" ProduceSellOne.Price, ProduceSellOne.Money,  CompanyLog.ID, CompanyLog.TypeID FROM CompanyLog INNER JOIN ");
            strSql.Append(" ProduceSellOne ON CompanyLog.TableID = ProduceSellOne.MainID INNER JOIN Materiel ON ProduceSellOne.MaterielID = Materiel.ID ");
            strSql.Append(" INNER JOIN MaterielType ON Materiel.TypeID = MaterielType.ID INNER JOIN Measure ON ProduceSellOne.MeasureID = Measure.ID ");
            strSql.Append(" WHERE  (CompanyLog.DateTime>=CONVERT(DATETIME, '" + dtOne + "', 102)) And (CompanyLog.DateTime<CONVERT(DATETIME, '" + dtTwo + "', 102))");
            strSql.Append(" And ((SELECT   TypeID FROM      Company WHERE   (ID = CompanyLog.CompanyID)) = 3) ORDER BY CompanyLog.ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetCompanyMoney(int TypeID)
        {
            Hownet.DAL.Company dalCom = new Company();
            DataSet ds = dalCom.GetList("(TypeID=" + TypeID + ")");
            ds.Tables[0].Columns.Add("Money", typeof(decimal));
            int _comID = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                _comID = int.Parse(ds.Tables[0].Rows[i]["ID"].ToString());
                ds.Tables[0].Rows[i]["Money"] = GetNowMoney(_comID);
            }
            return ds;
        }
        public decimal GetNowMoney(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Money FROM      CompanyLog WHERE   (ID = (SELECT   MAX(ID) AS Expr1 FROM      ");
            strSql.Append(" CompanyLog AS CompanyLog_1 WHERE   (CompanyID = @CompanyID)))");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return decimal.Parse(o.ToString());
            else
                return 0;

        }
        public void DeleteByCompanyID(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CompanyLog ");
            strSql.Append(" where CompanyID=@CompanyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
            parameters[0].Value = CompanyID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID FROM      CompanyLog WHERE   (CompanyID = @CompanyID) AND (ID > (SELECT   ID ");
            strSql.Append(" FROM      CompanyLog AS CompanyLog_1 WHERE   (CompanyID = @CompanyID) AND (TypeID = @TypeID) AND (TableID = @TableID)))");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID), new SqlParameter("@TypeID", TypeID), new SqlParameter("@TableID", TableID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 0;
            else
                return 1;
        }
        /// <summary>
        /// 返回加工厂领料时，返回此前欠款
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public decimal GetProcessingBackLastMoney(int CompanyID)
        {
            decimal money = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP (1) Money FROM CompanyLog WHERE (CompanyID = @CompanyID) AND ((TypeID = - 3) OR ");
            strSql.Append(" (TypeID = 8)) ORDER BY ID DESC");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (obj != null)
            {
                money = decimal.Parse(obj.ToString());
            }
            return money;
        }
        /// <summary>
        /// 返回新增领料单时，期间付款或领料
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetProcessingBackMoney(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT SUM(ChangMoney) AS Money, MAX(DateTime) AS DateTime FROM CompanyLog WHERE (TypeID = 7 OR TypeID = 2) AND (CompanyID = @comID) AND (ID > ");
            strSql.Append(" (SELECT TOP (1) ID FROM CompanyLog AS CompanyLog_1 WHERE (CompanyID = @comID) AND  ((TypeID = 8) Or (TypeID = -3)) ");
            strSql.Append(" ORDER BY ID DESC)) ");
            SqlParameter[] sps = { new SqlParameter("@comID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }
        /// <summary>
        /// 返回新增外加工收货单时，上次欠加工厂货款
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetProcess2DepotLastMoney(int CompanyID)
        {
            //  decimal money = 0;
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP (1) DateTime,Money FROM CompanyLog WHERE (CompanyID = @CompanyID) AND ((TypeID = - 3) OR ");
            strSql.Append(" (TypeID = 8)) ORDER BY ID DESC");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID) };
            //object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            //if (obj != null)
            //{
            //    money = decimal.Parse(obj.ToString());
            //}
            //return money;
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回新外加工收货单时，期间还款金额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetProcess2DepotBackSellMoney(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(ChangMoney) AS Money, MAX(DateTime) AS DateTime,Max(ID) as ID FROM      CompanyLog WHERE   (TypeID = 7 OR ");
            strSql.Append(" TypeID = 9) AND (CompanyID = @comID) AND (ID > (SELECT   TOP (1) ID FROM      CompanyLog AS CompanyLog_1 ");
            strSql.Append(" WHERE   (CompanyID = @comID) AND (TypeID = 8 OR TypeID = - 3) ORDER BY ID DESC))");
            SqlParameter[] sps = { new SqlParameter("@comID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public decimal GetLastMoney(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   CompanyLog_1.Money  FROM      (SELECT   MAX(ID) AS ID FROM      CompanyLog WHERE   (CompanyID = "+CompanyID+")) AS T INNER JOIN ");
            strSql.Append(" CompanyLog AS CompanyLog_1 ON T.ID = CompanyLog_1.ID" );
            DataTable dt = DbHelperSQL.Query(strSql.ToString()).Tables[0];
            if (dt.Rows.Count > 0)
                return Convert.ToDecimal(dt.Rows[0][0]);
            else
                return 0;
        }
        public DataSet GetInOutList(int TypeID,DateTime dt1,DateTime dt2)
        {
            DAL.Company dalC = new Company();
            DataTable dtC = dalC.GetList("(TypeID=" + TypeID + ")").Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("公司名", typeof(string));
            dt.Columns.Add("期初", typeof(decimal));
            dt.Columns.Add("增加", typeof(decimal));
            dt.Columns.Add("减少", typeof(decimal));
            dt.Columns.Add("余额", typeof(decimal));
            dt.Columns.Add("编号", typeof(string));
            dt.Columns.Add("手机", typeof(string));
            dt.Columns.Add("帐号", typeof(string));
            dt.Columns.Add("结余", typeof(decimal));
            
            for (int i = 0; i < dtC.Rows.Count; i++)
            {
                dt.Rows.Add(dtC.Rows[i]["ID"], dtC.Rows[i]["Name"], DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value, dtC.Rows[i]["Sn"], dtC.Rows[i]["Mabile"], dtC.Rows[i]["BankNO"], DBNull.Value);
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   T.CompanyID, T.ID, CompanyLog_1.Money FROM      (SELECT   CompanyLog.CompanyID, MAX(CompanyLog.ID) AS ID ");
            strSql.Append(" FROM      CompanyLog INNER JOIN Company ON CompanyLog.CompanyID = Company.ID ");
            strSql.Append(" WHERE   (CompanyLog.DateTime < @dt1) AND (Company.TypeID = @TypeID) ");
            strSql.Append(" GROUP BY CompanyLog.CompanyID) AS T INNER JOIN CompanyLog AS CompanyLog_1 ON T.ID = CompanyLog_1.ID");
            SqlParameter[] sps = { new SqlParameter("@TypeID", TypeID), new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2) };
            DataTable dtLoan = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j = 0; j < dtLoan.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["ID"]) == Convert.ToInt32(dtLoan.Rows[j]["CompanyID"]))
                    {
                        if(Convert.ToDecimal(dtLoan.Rows[j]["Money"])!=0)
                        dt.Rows[i][2] = dtLoan.Rows[j]["Money"];
                        break;
                    }
                }
            }
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   CompanyLog.CompanyID, SUM(CompanyLog.ChangMoney) AS Money FROM      CompanyLog INNER JOIN ");
            strSql.Append(" Company ON CompanyLog.CompanyID = Company.ID WHERE   (CompanyLog.DateTime > @dt1) AND (Company.TypeID = @TypeID) ");
            strSql.Append(" AND (CompanyLog.DateTime < @dt2) AND (CompanyLog.TypeID = @TypeID * - 1 OR CompanyLog.TypeID = 3 OR ");
            strSql.Append(" CompanyLog.TypeID = 1 OR  CompanyLog.TypeID = 8) GROUP BY CompanyLog.CompanyID");
            dtLoan = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j = 0; j < dtLoan.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["ID"]) == Convert.ToInt32(dtLoan.Rows[j]["CompanyID"]))
                    {
                        if (Convert.ToDecimal(dtLoan.Rows[j]["Money"]) != 0)
                        dt.Rows[i][3] = dtLoan.Rows[j]["Money"];
                        break;
                    }
                }
            }
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   CompanyLog.CompanyID, SUM(CompanyLog.ChangMoney) AS Money FROM      CompanyLog INNER JOIN ");
            strSql.Append(" Company ON CompanyLog.CompanyID = Company.ID WHERE   (CompanyLog.DateTime > @dt1) AND (Company.TypeID = @TypeID) AND (CompanyLog.DateTime < @dt2) AND  ");
            strSql.Append(" (CompanyLog.TypeID = 2 OR CompanyLog.TypeID = 4 OR CompanyLog.TypeID = 5 OR CompanyLog.TypeID = 6 OR CompanyLog.TypeID = 7 OR ");
            strSql.Append(" CompanyLog.TypeID = 9) GROUP BY CompanyLog.CompanyID");
            dtLoan = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j = 0; j < dtLoan.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["ID"]) == Convert.ToInt32(dtLoan.Rows[j]["CompanyID"]))
                    {
                        if (Convert.ToDecimal(dtLoan.Rows[j]["Money"]) != 0)
                        dt.Rows[i][4] = dtLoan.Rows[j]["Money"];
                        break;
                    }
                }
            }
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   T.CompanyID, T.ID, CompanyLog_1.Money FROM      (SELECT   CompanyLog.CompanyID, Max(CompanyLog.ID) AS ID ");
            strSql.Append(" FROM      CompanyLog INNER JOIN Company ON CompanyLog.CompanyID = Company.ID WHERE   (CompanyLog.DateTime < @dt2) AND (Company.TypeID = @TypeID) ");
            strSql.Append(" GROUP BY CompanyLog.CompanyID) AS T INNER JOIN CompanyLog AS CompanyLog_1 ON T.ID = CompanyLog_1.ID ORDER BY T.CompanyID");
            dtLoan = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j = 0; j < dtLoan.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["ID"]) == Convert.ToInt32(dtLoan.Rows[j]["CompanyID"]))
                    {
                        //if (Convert.ToDecimal(dtLoan.Rows[j]["Money"]) != 0)
                        dt.Rows[i][5] = dtLoan.Rows[j]["Money"];
                        break;
                    }
                }
            }
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   T.CompanyID, T.ID, CompanyLog_1.Money FROM      (SELECT   CompanyLog.CompanyID, Max(CompanyLog.ID) AS ID ");
            strSql.Append(" FROM      CompanyLog INNER JOIN Company ON CompanyLog.CompanyID = Company.ID WHERE    (Company.TypeID = @TypeID) ");
            strSql.Append(" GROUP BY CompanyLog.CompanyID) AS T INNER JOIN CompanyLog AS CompanyLog_1 ON T.ID = CompanyLog_1.ID ORDER BY T.CompanyID ");
            dtLoan = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j = 0; j < dtLoan.Rows.Count; j++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["ID"]) == Convert.ToInt32(dtLoan.Rows[j]["CompanyID"]))
                    {
                        //if (Convert.ToDecimal(dtLoan.Rows[j]["Money"]) != 0)
                        dt.Rows[i][9] = dtLoan.Rows[j]["Money"];
                        break;
                    }
                }
            }
            //strSql.Remove(0, strSql.Length);
            //strSql.Append("SELECT     ID, Name, Sn, LinkMan, Mabile, BankNO FROM         Company WHERE     (TypeID = @TypeID) GROUP BY ID, Name, Sn, LinkMan, Mabile, BankNO");
            //dtLoan = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{

            //    for (int j = 0; j < dtLoan.Rows.Count; j++)
            //    {
            //        if (Convert.ToInt32(dt.Rows[i]["ID"]) == Convert.ToInt32(dtLoan.Rows[j]["ID"]))
            //        {
            //            //if (Convert.ToDecimal(dtLoan.Rows[j]["Money"]) != 0)
            //            dt.Rows[i][6] = dtLoan.Rows[j]["Sn"];
            //            dt.Rows[i][7] = dtLoan.Rows[j]["Sn"];
            //            dt.Rows[i][8] = dtLoan.Rows[j]["Sn"];
            //            break;
            //        }
            //    }
            //}
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            dt.TableName = "dt";
            ds.Tables.Add(dt);
            return ds;
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
            parameters[0].Value = "CompanyLog";
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

