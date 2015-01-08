using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类ProduceSell。
    /// </summary>
    public class ProduceSell
    {
        public ProduceSell()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "ProduceSell");
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ProduceSell");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ProduceSell model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ProduceSell(");
            strSql.Append("CompanyID,DateTime,Depot,Remark,Money,IsVerify,LastMoney,BackMoney,Num,UpData,VerifyMan,VerifyDate,FillMan,FillDate,State,BackDate,BackMoneyTypeID,LastDate)");
            strSql.Append(" values (");
            strSql.Append("@CompanyID,@DateTime,@Depot,@Remark,@Money,@IsVerify,@LastMoney,@BackMoney,@Num,@UpData,@VerifyMan,@VerifyDate,@FillMan,@FillDate,@State,@BackDate,@BackMoneyTypeID,@LastDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Depot", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@BackMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@BackDate", SqlDbType.DateTime),
					new SqlParameter("@BackMoneyTypeID", SqlDbType.Int,4),
					new SqlParameter("@LastDate", SqlDbType.DateTime)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.Depot;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.IsVerify;
            parameters[6].Value = model.LastMoney;
            parameters[7].Value = model.BackMoney;
            parameters[8].Value = model.Num;
            parameters[9].Value = model.UpData;
            parameters[10].Value = model.VerifyMan;
            parameters[11].Value = model.VerifyDate;
            parameters[12].Value = model.FillMan;
            parameters[13].Value = model.FillDate;
            parameters[14].Value = model.State;
            parameters[15].Value = model.BackDate;
            parameters[16].Value = model.BackMoneyTypeID;
            parameters[17].Value = model.LastDate;

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
        public bool Update(Hownet.Model.ProduceSell model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProduceSell set ");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("Depot=@Depot,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Money=@Money,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("LastMoney=@LastMoney,");
            strSql.Append("BackMoney=@BackMoney,");
            strSql.Append("Num=@Num,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("State=@State,");
            strSql.Append("BackDate=@BackDate,");
            strSql.Append("BackMoneyTypeID=@BackMoneyTypeID,");
            strSql.Append("LastDate=@LastDate");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Depot", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@BackMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@BackDate", SqlDbType.DateTime),
					new SqlParameter("@BackMoneyTypeID", SqlDbType.Int,4),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.Depot;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.IsVerify;
            parameters[6].Value = model.LastMoney;
            parameters[7].Value = model.BackMoney;
            parameters[8].Value = model.Num;
            parameters[9].Value = model.UpData;
            parameters[10].Value = model.VerifyMan;
            parameters[11].Value = model.VerifyDate;
            parameters[12].Value = model.FillMan;
            parameters[13].Value = model.FillDate;
            parameters[14].Value = model.State;
            parameters[15].Value = model.BackDate;
            parameters[16].Value = model.BackMoneyTypeID;
            parameters[17].Value = model.LastDate;
            parameters[18].Value = model.ID;

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
            strSql.Append("delete from ProduceSell ");
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
            strSql.Append("delete from ProduceSell ");
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
        public Hownet.Model.ProduceSell GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CompanyID,DateTime,Depot,Remark,Money,IsVerify,LastMoney,BackMoney,Num,UpData,VerifyMan,VerifyDate,FillMan,FillDate,State,BackDate,BackMoneyTypeID,LastDate from ProduceSell ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.ProduceSell model = new Hownet.Model.ProduceSell();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Depot"] != null && ds.Tables[0].Rows[0]["Depot"].ToString() != "")
                {
                    model.Depot = int.Parse(ds.Tables[0].Rows[0]["Depot"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"] != null && ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                        model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastMoney"] != null && ds.Tables[0].Rows[0]["LastMoney"].ToString() != "")
                {
                    model.LastMoney = decimal.Parse(ds.Tables[0].Rows[0]["LastMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackMoney"] != null && ds.Tables[0].Rows[0]["BackMoney"].ToString() != "")
                {
                    model.BackMoney = decimal.Parse(ds.Tables[0].Rows[0]["BackMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"] != null && ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"] != null && ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"] != null && ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"] != null && ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"] != null && ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"] != null && ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["State"] != null && ds.Tables[0].Rows[0]["State"].ToString() != "")
                {
                    model.State = int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackDate"] != null && ds.Tables[0].Rows[0]["BackDate"].ToString() != "")
                {
                    model.BackDate = DateTime.Parse(ds.Tables[0].Rows[0]["BackDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackMoneyTypeID"] != null && ds.Tables[0].Rows[0]["BackMoneyTypeID"].ToString() != "")
                {
                    model.BackMoneyTypeID = int.Parse(ds.Tables[0].Rows[0]["BackMoneyTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastDate"] != null && ds.Tables[0].Rows[0]["LastDate"].ToString() != "")
                {
                    model.LastDate = DateTime.Parse(ds.Tables[0].Rows[0]["LastDate"].ToString());
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
            strSql.Append("select  1 as A,ID,CompanyID,DateTime,Depot,Remark,Money,IsVerify,LastMoney,BackMoney,Num,UpData,VerifyMan,VerifyDate,FillMan,FillDate,State,BackDate,BackMoneyTypeID,LastDate ");
            strSql.Append(" FROM ProduceSell ");
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
            strSql.Append(" ID,CompanyID,DateTime,Depot,Remark,Money,IsVerify,LastMoney,BackMoney,Num,UpData,VerifyMan,VerifyDate,FillMan,FillDate,State,BackDate,BackMoneyTypeID,LastDate ");
            strSql.Append(" FROM ProduceSell ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetIDList(int state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from ProduceSell where (State=" + state + ") order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int NewNum(DateTime dt, int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProduceSell WHERE  (CompanyID=" + CompanyID + ")");// (DateTime = @dt) And 
            SqlParameter[] sps = { new SqlParameter("@dt", dt) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
        public void DeleteByCompanyID(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProduceSell ");
            strSql.Append(" where CompanyID=@CompanyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
            parameters[0].Value = CompanyID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetPSAnalysisList(string strFiled, string strGroup, string strWhere, bool IsShowInfo)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" SELECT   ");
                strSql.Append(strFiled);
                strSql.Append(" FROM      ProduceSell INNER JOIN ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID  ");
                //if (IsShowInfo)
                //    strSql.Append(" INNER JOIN ProduceSellInfo ON ProduceSell.ID = ProduceSellInfo.MainID ");
                strSql.Append(" Where (ProduceSell.IsVerify=3) And (ProduceSell.State=21)");
                strSql.Append(strWhere);
                strSql.Append(" GROUP BY ProduceSell.IsVerify ");
                strSql.Append(strGroup);
                strSql.Append(" ORDER BY Date ");
                return DbHelperSQL.Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public DataSet GetPSAnListByCS(string strFiled, string strGroup, string strWhere, bool IsShowInfo)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" SELECT   ");
                strSql.Append(strFiled);
                strSql.Append(" FROM      ProduceSell INNER JOIN ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID INNER JOIN ProduceSellInfo ON ProduceSell.ID = ProduceSellInfo.MainID");
                strSql.Append("  AND ProduceSellOne.MaterielID = ProduceSellInfo.MaterielID ");
                //if (IsShowInfo)
                //    strSql.Append(" INNER JOIN ProduceSellInfo ON ProduceSell.ID = ProduceSellInfo.MainID ");
                strSql.Append(" Where (ProduceSell.IsVerify=3) And (ProduceSell.State=21)");
                strSql.Append(strWhere);
                strSql.Append(" GROUP BY ProduceSell.IsVerify ");
                strSql.Append(strGroup);
                strSql.Append(" ORDER BY Date ");
                return DbHelperSQL.Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public DataSet GetSum(DateTime dtOne, DateTime dtTwo, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Company.Name AS 客户, Materiel_1.Name AS 款号, Materiel.Name AS 商标, SUM(ProduceSellOne.Amount) AS 数量, ");
            strSql.Append(" Measure.Name AS 单位 FROM      Materiel AS Materiel_1 RIGHT OUTER JOIN Materiel RIGHT OUTER JOIN ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID ON Materiel.ID = ProduceSellOne.BrandID LEFT OUTER JOIN ");
            strSql.Append(" Measure ON ProduceSellOne.MeasureID = Measure.ID ON Materiel_1.ID = ProduceSellOne.MaterielID LEFT OUTER JOIN ");
            strSql.Append(" Company ON ProduceSell.CompanyID = Company.ID WHERE   (ProduceSell.DateTime > @dtOne) AND (ProduceSell.DateTime ");
            strSql.Append(" < @dtTwo) AND (ProduceSell.State = @TypeID) And (Materiel_1.AttributeID=4) GROUP BY Company.Name, Materiel_1.Name, Measure.Name, Materiel.Name");
            SqlParameter[] sps = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo), new SqlParameter("@TypeID", TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetStockSellInfo(DateTime dtOne, DateTime dtTwo)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" SELECT   Name, DataTime, CompanyID,cast( StockAmount as int ) as StockAmount, MaterielID, SellCompanyID, SellAmount ");
                strSql.Append(" FROM      (SELECT   Materiel.Name, StockBack.DataTime, StockBack.CompanyID, SUM(StockBackInfo.Amount)  ");
                strSql.Append(" AS StockAmount, StockBackInfo.MaterielID, 0 AS SellCompanyID, 0 AS SellAmount FROM      StockBack INNER JOIN ");
                strSql.Append(" StockBackInfo ON StockBack.ID = StockBackInfo.MainID INNER JOIN Materiel ON StockBackInfo.MaterielID = Materiel.ID ");
                strSql.Append(" WHERE   (StockBack.State = 24) AND (Materiel.AttributeID = 4) AND (StockBack.DataTime > @dtOne) AND  ");
                strSql.Append(" (StockBack.DataTime < @dtTwo) GROUP BY StockBack.CompanyID, StockBack.DataTime, StockBackInfo.MaterielID, Materiel.Name ");
                strSql.Append(" UNION ALL SELECT   Materiel_1.Name, ProduceSell.DateTime, 0 AS stockCompanyID, 0 AS StockAmount,  ");
                strSql.Append(" ProduceSellOne.MaterielID, ProduceSell.CompanyID, SUM(ProduceSellOne.Amount) AS Expr1 FROM      ProduceSell INNER JOIN ");
                strSql.Append(" ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID INNER JOIN Materiel AS Materiel_1 ON ProduceSellOne.MaterielID = Materiel_1.ID ");
                strSql.Append(" WHERE   (Materiel_1.AttributeID = 4) AND (ProduceSell.DateTime > @dtOne) AND (ProduceSell.DateTime < @dtTwo) AND ");
                strSql.Append(" (ProduceSell.State = 21) GROUP BY Materiel_1.Name, ProduceSell.DateTime, ProduceSellOne.MaterielID, ProduceSell.CompanyID) AS T ");
                strSql.Append(" ORDER BY Name, DataTime");
                SqlParameter[] sps = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo) };
                return DbHelperSQL.Query(strSql.ToString(), sps);
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public DataSet GetInfoList(DateTime dt1, DateTime dt2, int CompanyID, bool IsSum)
        {
            StringBuilder strSql = new StringBuilder();
            if (!IsSum)
            {
                strSql.Append("SELECT   StockBack.DataTime AS 日期, Company.Name AS 供应商, Materiel.Name AS 物料名, Color.Name AS 颜色, ");
                strSql.Append(" Size.Name AS 尺码, Measure.Name AS 单位, CAST(StockBackInfo.Amount AS real) AS 数量, StockBackInfo.Price AS 单价, ");
                strSql.Append(" StockBackInfo.Money AS 金额 FROM      StockBackInfo INNER JOIN ");
                strSql.Append(" StockBack ON StockBackInfo.MainID = StockBack.ID INNER JOIN Company ON StockBack.CompanyID = Company.ID INNER JOIN ");
                strSql.Append(" Materiel ON StockBackInfo.MaterielID = Materiel.ID INNER JOIN Measure ON StockBackInfo.CompanyMeasureID = Measure.ID ");
                strSql.Append(" LEFT OUTER JOIN Color ON StockBackInfo.ColorID = Color.ID LEFT OUTER JOIN ");
                strSql.Append(" Size ON StockBackInfo.SizeID = Size.ID ");
                strSql.Append(" WHERE   (StockBack.DataTime > @dt1) AND (StockBack.DataTime < @dt2) ");
                if (CompanyID > 0)
                    strSql.Append(" AND (StockBack.CompanyID = @CompanyID)");
            }
            else
            {
                strSql.Append(" SELECT   Company.Name AS 供应商, Materiel.Name AS 物料名, Color.Name AS 颜色, Size.Name AS 尺码, ");
                strSql.Append(" Measure.Name AS 单位, SUM(CAST(StockBackInfo.Amount AS real)) AS 数量, StockBackInfo.Price AS 单价, ");
                strSql.Append(" SUM(StockBackInfo.Money) AS 金额 FROM      StockBackInfo INNER JOIN ");
                strSql.Append(" StockBack ON StockBackInfo.MainID = StockBack.ID INNER JOIN Company ON StockBack.CompanyID = Company.ID INNER JOIN ");
                strSql.Append(" Materiel ON StockBackInfo.MaterielID = Materiel.ID INNER JOIN Measure ON StockBackInfo.CompanyMeasureID = Measure.ID LEFT OUTER JOIN ");
                strSql.Append(" Color ON StockBackInfo.ColorID = Color.ID LEFT OUTER JOIN Size ON StockBackInfo.SizeID = Size.ID ");
                strSql.Append(" WHERE   (StockBack.DataTime > @dt1) AND (StockBack.DataTime < @dt2) ");
                if (CompanyID > 0)
                    strSql.Append(" AND (StockBack.CompanyID = @CompanyID) ");
                strSql.Append(" GROUP BY Company.Name, Materiel.Name, Color.Name, Size.Name, Measure.Name, StockBackInfo.Price");
            }
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@CompanyID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSellInfo(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT Materiel.Name AS MaterielName, Materiel_1.Name AS BrandName, ");
            strSql.Append(" Measure.Name AS MeasureName, Size.Name AS SizeName, ");
            strSql.Append("  Color.Name AS ColorName, ProduceSellInfo.Amount, ProduceSellOne.Price, ");
            strSql.Append("  ProduceSellOne.Price * ProduceSellInfo.Amount AS Money ");
            strSql.Append(" FROM ProduceSellInfo INNER JOIN ");
            strSql.Append(" Materiel ON ProduceSellInfo.MaterielID = Materiel.ID INNER JOIN ");
            strSql.Append(" Materiel AS Materiel_1 ON ProduceSellInfo.BrandID = Materiel_1.ID INNER JOIN ");
            strSql.Append(" Measure ON ProduceSellInfo.MeasureID = Measure.ID INNER JOIN ");
            strSql.Append("  Size ON ProduceSellInfo.SizeID = Size.ID INNER JOIN ");
            strSql.Append("  Color ON ProduceSellInfo.ColorID = Color.ID INNER JOIN ");
            strSql.Append("  ProduceSellOne ON ProduceSellInfo.MainID = ProduceSellOne.MainID AND ");
            strSql.Append("  ProduceSellInfo.MaterielID = ProduceSellOne.MaterielID AND ");
            strSql.Append("  ProduceSellInfo.BrandID = ProduceSellOne.BrandID ");
            strSql.Append(" WHERE (ProduceSellInfo.MainID = @MainID) ");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetListInfoByTime(DateTime dt1, DateTime dt2, int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT     ProduceSell.CompanyID, Materiel.Name, ProduceSellOne.Amount, ProduceSellOne.Price, ProduceSellOne.Money, ProduceSellOne.Remark,");
            strSql.Append(" ProduceSell.DateTime FROM         ProduceSell INNER JOIN ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID INNER JOIN ");
            strSql.Append(" Materiel ON ProduceSellOne.MaterielID = Materiel.ID WHERE     (ProduceSell.CompanyID = @CompanyID) AND ");
            strSql.Append(" (ProduceSell.DateTime > @dt1) AND (ProduceSell.DateTime < @dt2)");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@CompanyID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
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
            parameters[0].Value = "ProduceSell";
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

