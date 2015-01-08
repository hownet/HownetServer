using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类StockBack。
    /// </summary>
    public class StockBack
    {
        public StockBack()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from StockBack");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.StockBack model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockBack(");
            strSql.Append("DataTime,Num,CompanyID,Remark,Money,IsVerify,VerifyMan,VerifyDate,DepotID,LastMoney,BackMoney,FillDate,FillMan,UpData,State,BackDate,TaskID,StockRemark,DeparmentType,Weight,OtherTypeID)");
            strSql.Append(" values (");
            strSql.Append("@DataTime,@Num,@CompanyID,@Remark,@Money,@IsVerify,@VerifyMan,@VerifyDate,@DepotID,@LastMoney,@BackMoney,@FillDate,@FillMan,@UpData,@State,@BackDate,@TaskID,@StockRemark,@DeparmentType,@Weight,@OtherTypeID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@DepotID", SqlDbType.Int,4),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@BackMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@BackDate", SqlDbType.DateTime),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@StockRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@DeparmentType", SqlDbType.Int,4),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@OtherTypeID", SqlDbType.Int,4)};
            parameters[0].Value = model.DataTime;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.CompanyID;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.IsVerify;
            parameters[6].Value = model.VerifyMan;
            parameters[7].Value = model.VerifyDate;
            parameters[8].Value = model.DepotID;
            parameters[9].Value = model.LastMoney;
            parameters[10].Value = model.BackMoney;
            parameters[11].Value = model.FillDate;
            parameters[12].Value = model.FillMan;
            parameters[13].Value = model.UpData;
            parameters[14].Value = model.State;
            parameters[15].Value = model.BackDate;
            parameters[16].Value = model.TaskID;
            parameters[17].Value = model.StockRemark;
            parameters[18].Value = model.DeparmentType;
            parameters[19].Value = model.Weight;
            parameters[20].Value = model.OtherTypeID;

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
        public bool Update(Hownet.Model.StockBack model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update StockBack set ");
            strSql.Append("DataTime=@DataTime,");
            strSql.Append("Num=@Num,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Money=@Money,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("DepotID=@DepotID,");
            strSql.Append("LastMoney=@LastMoney,");
            strSql.Append("BackMoney=@BackMoney,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("State=@State,");
            strSql.Append("BackDate=@BackDate,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("StockRemark=@StockRemark,");
            strSql.Append("DeparmentType=@DeparmentType,");
            strSql.Append("Weight=@Weight,");
            strSql.Append("OtherTypeID=@OtherTypeID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@DepotID", SqlDbType.Int,4),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@BackMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@BackDate", SqlDbType.DateTime),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@StockRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@DeparmentType", SqlDbType.Int,4),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@OtherTypeID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.DataTime;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.CompanyID;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.IsVerify;
            parameters[6].Value = model.VerifyMan;
            parameters[7].Value = model.VerifyDate;
            parameters[8].Value = model.DepotID;
            parameters[9].Value = model.LastMoney;
            parameters[10].Value = model.BackMoney;
            parameters[11].Value = model.FillDate;
            parameters[12].Value = model.FillMan;
            parameters[13].Value = model.UpData;
            parameters[14].Value = model.State;
            parameters[15].Value = model.BackDate;
            parameters[16].Value = model.TaskID;
            parameters[17].Value = model.StockRemark;
            parameters[18].Value = model.DeparmentType;
            parameters[19].Value = model.Weight;
            parameters[20].Value = model.OtherTypeID;
            parameters[21].Value = model.ID;

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
            strSql.Append("delete from StockBack ");
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
            strSql.Append("delete from StockBack ");
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
        public Hownet.Model.StockBack GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DataTime,Num,CompanyID,Remark,Money,IsVerify,VerifyMan,VerifyDate,DepotID,LastMoney,BackMoney,FillDate,FillMan,UpData,State,BackDate,TaskID,StockRemark,DeparmentType,Weight,OtherTypeID from StockBack ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.StockBack model = new Hownet.Model.StockBack();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DataTime"] != null && ds.Tables[0].Rows[0]["DataTime"].ToString() != "")
                {
                    model.DataTime = DateTime.Parse(ds.Tables[0].Rows[0]["DataTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"] != null && ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
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
                if (ds.Tables[0].Rows[0]["VerifyMan"] != null && ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"] != null && ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotID"] != null && ds.Tables[0].Rows[0]["DepotID"].ToString() != "")
                {
                    model.DepotID = int.Parse(ds.Tables[0].Rows[0]["DepotID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastMoney"] != null && ds.Tables[0].Rows[0]["LastMoney"].ToString() != "")
                {
                    model.LastMoney = decimal.Parse(ds.Tables[0].Rows[0]["LastMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackMoney"] != null && ds.Tables[0].Rows[0]["BackMoney"].ToString() != "")
                {
                    model.BackMoney = decimal.Parse(ds.Tables[0].Rows[0]["BackMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"] != null && ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"] != null && ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"] != null && ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["State"] != null && ds.Tables[0].Rows[0]["State"].ToString() != "")
                {
                    model.State = int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackDate"] != null && ds.Tables[0].Rows[0]["BackDate"].ToString() != "")
                {
                    model.BackDate = DateTime.Parse(ds.Tables[0].Rows[0]["BackDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"] != null && ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                model.StockRemark = ds.Tables[0].Rows[0]["StockRemark"].ToString();
                if (ds.Tables[0].Rows[0]["DeparmentType"] != null && ds.Tables[0].Rows[0]["DeparmentType"].ToString() != "")
                {
                    model.DeparmentType = int.Parse(ds.Tables[0].Rows[0]["DeparmentType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Weight"] != null && ds.Tables[0].Rows[0]["Weight"].ToString() != "")
                {
                    model.Weight = decimal.Parse(ds.Tables[0].Rows[0]["Weight"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OtherTypeID"] != null && ds.Tables[0].Rows[0]["OtherTypeID"].ToString() != "")
                {
                    model.OtherTypeID = int.Parse(ds.Tables[0].Rows[0]["OtherTypeID"].ToString());
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
            strSql.Append("select  1 as A,ID,DataTime,Num,CompanyID,Remark,Money,IsVerify,VerifyMan,VerifyDate,DepotID,LastMoney,BackMoney,FillDate,FillMan,UpData,State,BackDate,TaskID,StockRemark,DeparmentType,Weight,OtherTypeID ");
            strSql.Append(" FROM StockBack ");
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
            strSql.Append(" ID,DataTime,Num,CompanyID,Remark,Money,IsVerify,VerifyMan,VerifyDate,DepotID,LastMoney,BackMoney,FillDate,FillMan,UpData,State,BackDate,TaskID,StockRemark,DeparmentType,Weight,OtherTypeID ");
            strSql.Append(" FROM StockBack ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetIDList(int Stata)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from StockBack Where (State=@Stata) order by ID");
            SqlParameter[] sps = { new SqlParameter("@Stata", Stata) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        public DataSet GetStockLinLiaoIDList(int StockID, int Stata)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from StockBack Where (State=@Stata) ");
            if(StockID>0)
                strSql.Append(" And (TaskID="+StockID+")");
            strSql.Append(" order by ID");
            SqlParameter[] sps = { new SqlParameter("@Stata", Stata) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int NewNum(DateTime dt, int TypeID,int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            //if (NumTypeID == 0)
            //{
                strSql.Append("SELECT   MAX(Num) AS Expr1 FROM      StockBack Where (State=@state)");
            //}
            //else if (NumTypeID == 1)
            //{
            //    strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      StockBack WHERE   (YEAR(DataTime) = YEAR(@dt)) And (State=@state)");
            //}
            //else if (NumTypeID == 2)
            //{
            //    strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      StockBack WHERE   (YEAR(DataTime) = YEAR(@dt)) AND (MONTH(DataTime) = MONTH(@dt)) And (State=@state)");
            //}
            //else if (NumTypeID == 3)
            //{
            //    strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      StockBack WHERE   (DataTime = @dt) And (State=@state)");
            //}
            if (CompanyID > 0)
            {
                strSql.Append(" And (CompanyID=@CompanyID)");
            }
            SqlParameter[] sps = { new SqlParameter("@dt", dt), new SqlParameter("@state", TypeID),new SqlParameter("@CompanyID",CompanyID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
         /// <summary>
        /// 获取采购未完成数量
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet GetNotBack(int AttributeID)
        {
            StringBuilder strSql=new StringBuilder();
            strSql.Append(" SELECT   SUM(StockBackInfo.NotAmount) AS StockNotBack, StockBackInfo.MListID FROM StockBack INNER JOIN ");
            strSql.Append(" StockBackInfo ON StockBack.ID = StockBackInfo.MainID INNER JOIN Materiel ON StockBackInfo.MaterielID = ");
            strSql.Append(" Materiel.ID WHERE   (StockBack.State = 23) AND (StockBackInfo.NotAmount > 0) AND (StockBack.IsVerify = 3) AND  ");
            strSql.Append(" (Materiel.AttributeID = @AttributeID) And (StockBackInfo.IsEnd=0) GROUP BY StockBackInfo.MListID ");
            SqlParameter[] sps = { new SqlParameter("@AttributeID", AttributeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public bool CheckLinLiao(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(StockBackInfo.ID) AS Expr1 FROM      StockBackInfo INNER JOIN ");
            strSql.Append(" Repertory ON StockBackInfo.StockInfoID  = Repertory.ID WHERE   (StockBackInfo.MainID ");
            strSql.Append("= @MainID) AND (Repertory.Amount - StockBackInfo.Amount < 0)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps)) == 0;
        }
        /// <summary>
        /// 获取某物料采购量超过请购的数量
        /// </summary>
        /// <param name="MListID"></param>
        /// <returns></returns>
        public decimal GetExcessAmount(int MListID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   CAST(SUM(StockBackInfo.ExcessAmount) AS Real) AS ExcessAmount ");
            strSql.Append(" FROM      StockBackInfo INNER JOIN StockBack ON StockBackInfo.MainID = StockBack.ID ");
            strSql.Append(" WHERE   (StockBack.IsVerify > 2) AND (StockBack.IsVerify < 20) AND (StockBack.State = 23) AND (StockBackInfo.IsEnd = 0) AND ");
            strSql.Append(" (StockBackInfo.MListID =" + MListID + ")");
            object o = DbHelperSQL.GetSingle(strSql.ToString());
            if (o != null)
                return Convert.ToDecimal(o);
            else
                return 0;
        }
        public DataSet GetStockList(DateTime dt1, DateTime dt2, int CompanyID, int MaterielID, int TypeID, bool InIsEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  1 as A, CAST(0 AS bit) AS IsSelect, StockBack.DataTime, StockBack.CompanyID, StockBackInfo.MaterielID,StockBack.IsVerify,  ");
            strSql.Append(" StockBackInfo.ColorID, StockBackInfo.ColorOneID, StockBackInfo.SizeID, StockBackInfo.ColorTwoID,StockBackInfo.LastTime, ");
            strSql.Append(" CAST(StockBackInfo.Amount AS real) AS Amount, CAST(StockBackInfo.NotAmount AS real) AS NotAmount,StockBack.StockRemark, StockBack.FillMan,");
            strSql.Append(" StockBackInfo.DepotMeasureID, CAST(StockBackInfo.Amount - StockBackInfo.NotAmount AS real) AS NowAmount, StockBack.State,");
            strSql.Append(" StockBackInfo.Price, StockBackInfo.Money, StockBackInfo.Remark, cast(StockBackInfo.IsEnd as bit) as IsEnd, StockBackInfo.ID,StockBack.ID as MainID ");
            strSql.Append(" FROM      StockBack INNER JOIN StockBackInfo ON StockBack.ID = StockBackInfo.MainID ");
            strSql.Append(" WHERE   (StockBack.DataTime > @dt1) AND (StockBack.DataTime < @dt2) ");
            if (CompanyID > 0)
                strSql.Append(" AND (StockBack.CompanyID = @CompanyID)  ");
            if (MaterielID > 0)
                strSql.Append(" AND (StockBackInfo.MaterielID = @MaterielID) ");
            if(!InIsEnd)
                strSql.Append(" AND (StockBackInfo.IsEnd =0) ");
            strSql.Append("  AND (StockBack.State = @TypeID)");//AND (StockBack.IsVerify > 2)
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@CompanyID", CompanyID), new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@TypeID", TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetStockListByNum(int Num, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  1 as A, CAST(0 AS bit) AS IsSelect, StockBack.DataTime, StockBack.CompanyID, StockBackInfo.MaterielID, StockBack.IsVerify, ");
            strSql.Append(" StockBackInfo.ColorID, StockBackInfo.ColorOneID, StockBackInfo.SizeID, StockBackInfo.ColorTwoID, ");
            strSql.Append(" CAST(StockBackInfo.Amount AS real) AS Amount, CAST(StockBackInfo.NotAmount AS real) AS NotAmount,StockBack.StockRemark, ");
            strSql.Append(" StockBackInfo.DepotMeasureID, CAST(StockBackInfo.Amount - StockBackInfo.NotAmount AS real) AS NowAmount,StockBack.State, ");
            strSql.Append(" StockBackInfo.Price, StockBackInfo.Money, StockBackInfo.Remark, cast(StockBackInfo.IsEnd as bit) as IsEnd, StockBackInfo.ID,StockBack.ID as MainID ");
            strSql.Append(" FROM      StockBack INNER JOIN StockBackInfo ON StockBack.ID = StockBackInfo.MainID ");
            strSql.Append(" WHERE   (StockBack.Num = @Num)  ");
            strSql.Append(" AND (StockBack.IsVerify > 2) AND (StockBack.State = @TypeID)");
            SqlParameter[] sps = { new SqlParameter("@Num", Num), new SqlParameter("@TypeID", TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 将某类单据明细标记为已完成
        /// </summary>
        /// <param name="TypeID"></param>
        public void UpIsEnd(int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE  StockBackInfo SET         IsEnd = 1 FROM      StockBack INNER JOIN ");
            strSql.Append(" StockBackInfo ON StockBack.ID = StockBackInfo.MainID WHERE   (StockBack.State = @TypeID) AND ");
            strSql.Append(" (StockBackInfo.IsEnd = 0) AND (StockBackInfo.NotAmount = 0 OR StockBackInfo.NotAmount < 0)");
            SqlParameter[] sps = {new SqlParameter("@TypeID",TypeID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 判断某申购单是否可以弃审
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool NeedStockCheckCanUnVerify(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   StockBackInfo.MainID FROM      StockBackInfo INNER JOIN ");
            strSql.Append(" StockBackInfo AS StockBackInfo_1 ON StockBackInfo.ID = StockBackInfo_1.StockInfoID ");
            strSql.Append(" WHERE   (StockBackInfo.MainID = @ID)");
            SqlParameter[] sps = {new SqlParameter("@ID",ID) };
            return DbHelperSQL.Query(strSql.ToString(), sps).Tables[0].Rows.Count == 0;
        }
        public DataSet GetSum(DateTime dtOne, DateTime dtTwo, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Company.Name AS 供应商, Materiel.Name AS 物料, Color.Name AS 颜色, Size.Name AS 尺码, SUM(StockBackInfo.Amount) ");
            strSql.Append(" AS 数量, Measure.Name AS 单位 FROM      StockBack INNER JOIN StockBackInfo ON StockBack.ID = StockBackInfo.MainID INNER JOIN ");
            strSql.Append(" Materiel ON StockBackInfo.MaterielID = Materiel.ID INNER JOIN Measure ON StockBackInfo.CompanyMeasureID = Measure.ID LEFT OUTER ");
            strSql.Append(" JOIN Company ON StockBack.CompanyID = Company.ID LEFT OUTER JOIN Color ON StockBackInfo.ColorID = Color.ID LEFT OUTER JOIN ");
            strSql.Append(" Size ON StockBackInfo.SizeID = Size.ID WHERE   (StockBack.State = @TypeID) AND (StockBack.DataTime > @dtOne) AND (StockBack.DataTime ");
            strSql.Append(" < @dtTwo) And (Materiel.AttributeID=4) GROUP BY Company.Name, Materiel.Name, Color.Name, Size.Name, Measure.Name");
            SqlParameter[] sps = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo), new SqlParameter("@TypeID", TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetInfoList(DateTime dt1, DateTime dt2, int CompanyID, bool IsSum)
        {
            StringBuilder strSql = new StringBuilder();
            if (!IsSum)
            {
                //strSql.Append("SELECT StockBack.ID ,  StockBack.DataTime AS 日期,StockBack.Num as 编号, Company.Name AS 供应商, Materiel.Name AS 物料名, Color.Name AS 颜色, ");
                //strSql.Append(" Size.Name AS 尺码, Measure.Name AS 单位, CAST(StockBackInfo.Amount AS real) AS 数量, StockBackInfo.Price AS 单价, ");
                //strSql.Append(" StockBackInfo.Money AS 金额 FROM      StockBackInfo INNER JOIN ");
                //strSql.Append(" StockBack ON StockBackInfo.MainID = StockBack.ID INNER JOIN Company ON StockBack.CompanyID = Company.ID INNER JOIN ");
                //strSql.Append(" Materiel ON StockBackInfo.MaterielID = Materiel.ID INNER JOIN Measure ON StockBackInfo.CompanyMeasureID = Measure.ID ");
                //strSql.Append(" LEFT OUTER JOIN Color ON StockBackInfo.ColorID = Color.ID LEFT OUTER JOIN ");
                //strSql.Append(" Size ON StockBackInfo.SizeID = Size.ID ");
                //strSql.Append(" WHERE   (StockBack.DataTime > @dt1) AND (StockBack.DataTime < @dt2) And ((StockBack.State=24) )");//or (StockBack.State=25)
                strSql.Append(" SELECT   StockBack.ID, StockBack.DataTime AS 日期, StockBack.Num AS 编号, Company.Name AS 供应商, ");
                strSql.Append(" StockBackInfo.MaterielID AS 物料名, StockBackInfo.SizeID AS 尺码, StockBackInfo.ColorID AS 颜色, ");
                strSql.Append(" StockBackInfo.CompanyMeasureID AS 单位, CAST(StockBackInfo.Amount AS real) AS 数量, StockBackInfo.Price AS 单价, ");
                strSql.Append(" StockBackInfo.Money AS 金额, StockBackInfo_1.Price AS 订货单价, StockBackInfo_1.NotAmount AS 未完成数量, ");
                strSql.Append(" StockBackInfo.ColorOneID AS 配色一, StockBackInfo.ColorTwoID AS 配色二, StockBack.IsVerify AS 状态,StockBackInfo_1.Price - StockBackInfo.Price AS 价差 FROM      StockBackInfo INNER JOIN ");
                strSql.Append(" StockBack ON StockBackInfo.MainID = StockBack.ID INNER JOIN Company ON StockBack.CompanyID = Company.ID LEFT OUTER JOIN ");
                strSql.Append(" StockBackInfo AS StockBackInfo_1 ON StockBackInfo.StockInfoID = StockBackInfo_1.ID ");
                strSql.Append(" WHERE   (StockBack.DataTime > @dt1) AND (StockBack.DataTime < @dt2) AND (StockBack.State = 24)");
                if (CompanyID > 0)
                    strSql.Append(" AND (StockBack.CompanyID = @CompanyID)");
                strSql.Append(" ORDER BY 日期, 供应商");
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
                if(CompanyID>0) 
                strSql.Append(" AND (StockBack.CompanyID = @CompanyID) ");
                strSql.Append(" GROUP BY Company.Name, Materiel.Name, Color.Name, Size.Name, Measure.Name, StockBackInfo.Price");
            }
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@CompanyID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetLinLiaoInfoList(int PTMID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   (CASE WHEN (StockBack.DeparmentType = 3) THEN (SELECT   Name FROM      company WHERE   (ID = StockBack.CompanyID)) ELSE ");
            strSql.Append(" (SELECT   Name FROM      Deparment WHERE   (ID = StockBack.CompanyID)) END) AS 领料部门, StockBack.DataTime AS 领料日期,  ");
            strSql.Append(" StockBack.Num AS 单据编号, Materiel.Name AS 物料名, Color.Name AS 颜色, Size.Name AS 尺码, CAST(StockBackInfo.Amount AS real) ");
            strSql.Append(" AS 数量, Measure.Name AS 单位 FROM    StockBackInfo INNER JOIN StockBack ON StockBackInfo.MainID = StockBack.ID LEFT OUTER JOIN ");
            strSql.Append(" Materiel ON StockBackInfo.MaterielID = Materiel.ID LEFT OUTER JOIN Color ON StockBackInfo.ColorID = Color.ID LEFT OUTER JOIN ");
            strSql.Append(" Measure ON StockBackInfo.CompanyMeasureID = Measure.ID LEFT OUTER JOIN Size ON StockBackInfo.SizeID = Size.ID ");
            strSql.Append(" WHERE   (StockBack.TaskID = @PTMID) AND (StockBack.State = 26)");
            SqlParameter[] sps = {new SqlParameter("@PTMID",PTMID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetWXOutList(int CompanyID, int DepotID, int State)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT 3 as A ,0 as ID,cast( 0 as real) as Amount,  StockBackInfo.ID as StockInfoID, StockBackInfo.MainID, StockBackInfo.MaterielID, StockBackInfo.ColorID, ");
            strSql.Append(" StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID, StockBackInfo.SizeID, StockBackInfo.Price, ");
            strSql.Append(" StockBackInfo.CompanyMeasureID, StockBackInfo.DepotMeasureID, StockBackInfo.Amount as NeedAmount, StockBackInfo.Conversion, ");
            strSql.Append(" StockBackInfo.Remark, StockBackInfo.PriceAmount, StockBackInfo.NotAmount, StockBackInfo.Money, ");
            strSql.Append("  StockBackInfo.NotPriceAmount, StockBackInfo.MListID, StockBackInfo.CompanyID, StockBackInfo.BrandID, ");//cast( (StockBackInfo.Amount-StockBackInfo.NotAmount) as real) as
            strSql.Append(" StockBackInfo.IsEnd,   StockBackInfo.StringTaskID, ");
            strSql.Append(" StockBackInfo.LastTime, StockBackInfo.Weight, StockBackInfo.SpecID, StockBackInfo.MaterielName, ");
            strSql.Append(" StockBackInfo.ColorName, StockBackInfo.ColorOneName, StockBackInfo.ColorTwoName, StockBackInfo.SizeName, ");
            strSql.Append(" StockBackInfo.BrandName, StockBackInfo.SupplierID, StockBackInfo.SupplierName, StockBackInfo.SupplierSN, ");
              strSql.Append(" (SELECT   ID FROM      Repertory WHERE   (MListID = StockBackInfo.MListID) AND (PlanID = 0) AND ");
              strSql.Append(" (DepartmentID = @DetotID)) AS DemandID,");
            strSql.Append(" StockBackInfo.SpecName,(SELECT   Amount FROM      Repertory WHERE   (MListID = StockBackInfo.MListID) AND (PlanID = 0) AND ");
            strSql.Append(" (DepartmentID = @DetotID)) AS ExcessAmount, StockBack.State FROM      StockBackInfo INNER JOIN StockBack ON StockBackInfo.MainID = StockBack.ID* @Stata ");
            strSql.Append(" WHERE    (StockBackInfo.NotAmount > 0) AND (StockBack.State = 61) AND (StockBack.CompanyID = @CompanyID)");
            SqlParameter[] sps = { new SqlParameter("@DetotID", DepotID), new SqlParameter("CompanyID", CompanyID), new SqlParameter("@Stata", State) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetFinshedBackMain(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT     Materiel.Name AS 款号, Materiel_1.Name AS 商标, Measure.Name AS 单位, SUM(StockBackInfo.Amount) AS 数量, StockBackInfo.Price AS 单价, ");
            strSql.Append(" SUM(StockBackInfo.Money) AS 金额 FROM         StockBackInfo LEFT OUTER JOIN Measure ON StockBackInfo.CompanyMeasureID = Measure.ID LEFT OUTER JOIN ");
            strSql.Append(" Materiel ON StockBackInfo.MaterielID = Materiel.ID LEFT OUTER JOIN Materiel AS Materiel_1 ON StockBackInfo.BrandID = Materiel_1.ID ");
            strSql.Append(" WHERE     (StockBackInfo.MainID = " + MainID + ") GROUP BY Materiel.Name, Materiel_1.Name, Measure.Name, StockBackInfo.Price");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetReport(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      Materiel WHERE   (ID = StockBackInfo.MaterielID)) AS MaterielName, ");
            strSql.Append(" (SELECT   Name FROM      Materiel AS Materiel_1 WHERE   (ID = StockBackInfo.BrandID)) AS BrandName, ");
            strSql.Append(" (SELECT   Name FROM      Color WHERE   (ID = StockBackInfo.ColorID)) AS ColorName, StockBackInfo.Amount, ");
            strSql.Append("  (SELECT   Name FROM      Color AS Color_1 WHERE   (ID = StockBackInfo.ColorOneID)) AS ColorOneName,");
            strSql.Append("  (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = StockBackInfo.ColorTwoID)) AS ColorTwoName,");
            strSql.Append(" Size.Name AS SizeName FROM      StockBackInfo INNER JOIN Size ON StockBackInfo.SizeID = Size.ID ");
            strSql.Append(" WHERE   (StockBackInfo.MainID = @MainID) ORDER BY Size.Orders");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
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
            parameters[0].Value = "StockBack";
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

