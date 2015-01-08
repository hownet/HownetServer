using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类SalesOrderInfoList。
	/// </summary>
	public class SalesOrderInfoList
	{
		public SalesOrderInfoList()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SalesOrderInfoList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SalesOrderInfoList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SalesOrderInfoList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SalesOrderInfoList(");
            strSql.Append("MainID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,Price,IsVerify,VerifyDate,VerifyMan,Progress,UpData,MeasureID,CompanyID,FillMan,FillDate,PackingMethodID,SewingRemark,IsToPlan,SunAmount)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@MaterielID,@BrandID,@Num,@DateTime,@LastDate,@Remark,@Price,@IsVerify,@VerifyDate,@VerifyMan,@Progress,@UpData,@MeasureID,@CompanyID,@FillMan,@FillDate,@PackingMethodID,@SewingRemark,@IsToPlan,@SunAmount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@Progress", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@PackingMethodID", SqlDbType.Int,4),
					new SqlParameter("@SewingRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@IsToPlan", SqlDbType.Bit,1),
					new SqlParameter("@SunAmount", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.BrandID;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.DateTime;
            parameters[5].Value = model.LastDate;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.Price;
            parameters[8].Value = model.IsVerify;
            parameters[9].Value = model.VerifyDate;
            parameters[10].Value = model.VerifyMan;
            parameters[11].Value = model.Progress;
            parameters[12].Value = model.UpData;
            parameters[13].Value = model.MeasureID;
            parameters[14].Value = model.CompanyID;
            parameters[15].Value = model.FillMan;
            parameters[16].Value = model.FillDate;
            parameters[17].Value = model.PackingMethodID;
            parameters[18].Value = model.SewingRemark;
            parameters[19].Value = model.IsToPlan;
            parameters[20].Value = model.SunAmount;

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
        public bool Update(Hownet.Model.SalesOrderInfoList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SalesOrderInfoList set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("Num=@Num,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("LastDate=@LastDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Price=@Price,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("Progress=@Progress,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("PackingMethodID=@PackingMethodID,");
            strSql.Append("SewingRemark=@SewingRemark,");
            strSql.Append("IsToPlan=@IsToPlan,");
            strSql.Append("SunAmount=@SunAmount");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@Progress", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@PackingMethodID", SqlDbType.Int,4),
					new SqlParameter("@SewingRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@IsToPlan", SqlDbType.Bit,1),
					new SqlParameter("@SunAmount", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.BrandID;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.DateTime;
            parameters[5].Value = model.LastDate;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.Price;
            parameters[8].Value = model.IsVerify;
            parameters[9].Value = model.VerifyDate;
            parameters[10].Value = model.VerifyMan;
            parameters[11].Value = model.Progress;
            parameters[12].Value = model.UpData;
            parameters[13].Value = model.MeasureID;
            parameters[14].Value = model.CompanyID;
            parameters[15].Value = model.FillMan;
            parameters[16].Value = model.FillDate;
            parameters[17].Value = model.PackingMethodID;
            parameters[18].Value = model.SewingRemark;
            parameters[19].Value = model.IsToPlan;
            parameters[20].Value = model.SunAmount;
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
            strSql.Append("delete from SalesOrderInfoList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
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
            strSql.Append("delete from SalesOrderInfoList ");
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
        public Hownet.Model.SalesOrderInfoList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,Price,IsVerify,VerifyDate,VerifyMan,Progress,UpData,MeasureID,CompanyID,FillMan,FillDate,PackingMethodID,SewingRemark,IsToPlan,SunAmount from SalesOrderInfoList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.SalesOrderInfoList model = new Hownet.Model.SalesOrderInfoList();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastDate"].ToString() != "")
                {
                    model.LastDate = DateTime.Parse(ds.Tables[0].Rows[0]["LastDate"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Progress"].ToString() != "")
                {
                    model.Progress = int.Parse(ds.Tables[0].Rows[0]["Progress"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PackingMethodID"].ToString() != "")
                {
                    model.PackingMethodID = int.Parse(ds.Tables[0].Rows[0]["PackingMethodID"].ToString());
                }
                model.SewingRemark = ds.Tables[0].Rows[0]["SewingRemark"].ToString();
                if (ds.Tables[0].Rows[0]["IsToPlan"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsToPlan"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsToPlan"].ToString().ToLower() == "true"))
                    {
                        model.IsToPlan = true;
                    }
                    else
                    {
                        model.IsToPlan = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["SunAmount"].ToString() != "")
                {
                    model.SunAmount = int.Parse(ds.Tables[0].Rows[0]["SunAmount"].ToString());
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
            strSql.Append("select 1 as A,ID,MainID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,Price,IsVerify,VerifyDate,VerifyMan,Progress,UpData,MeasureID,CompanyID,FillMan,FillDate,PackingMethodID,SewingRemark,IsToPlan,SunAmount ");
            strSql.Append(" ,Price * SunAmount AS Money,(Select TrueName from Users where (ID=SalesOrderInfoList.FillMan)) as Fill,(Select TrueName from Users where (ID=SalesOrderInfoList.VerifyMan)) as Verify");
            strSql.Append(" FROM SalesOrderInfoList ");
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
            strSql.Append(" ID,MainID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,Price,IsVerify,VerifyDate,VerifyMan,Progress,UpData,MeasureID,CompanyID,FillMan,FillDate,PackingMethodID,SewingRemark,IsToPlan,SunAmount ");
            strSql.Append(" FROM SalesOrderInfoList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from SalesOrderInfoList order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int NewNum(DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      SalesOrderInfoList WHERE  (YEAR(DateTime) = YEAR(@dt))");
            SqlParameter[] sps = { new SqlParameter("@dt", dt) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
        public DataSet GetSales(int CompanyID, int MaterielID, int BrandID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  0 as A, '编号：' + CONVERT(varchar(100), SalesOrderInfoList.DateTime, 112) + REPLACE(STR(SalesOrderInfoList.Num, 3, 0), ' ', ");
            strSql.Append(" '0') + '   未发货总数：' + CAST(SUM(AmountInfo.NotAmount) AS nvarchar) AS NotAmount, SalesOrderInfoList.ID ");
            strSql.Append(" ,  SalesOrderInfoList.MaterielID, SalesOrderInfoList.MeasureID,");
            strSql.Append(" SalesOrderInfoList.BrandID , SUM(AmountInfo.Amount) AS Amount,  SUM(AmountInfo.NotAmount) AS NotAmounts ");
            strSql.Append(" ,SUM(AmountInfo.NotAmount) AS NotAmount, SalesOrderInfoList.DateTime, SalesOrderInfoList.LastDate,SalesOrderInfoList.Price, SalesOrderInfoList.Remark");
            strSql.Append(" FROM SalesOrderInfoList INNER JOIN AmountInfo ON SalesOrderInfoList.ID = AmountInfo.MainID WHERE   (AmountInfo.TableTypeID ");
            strSql.Append(" = @TableTypeID)");
            if (MaterielID > 0)
                strSql.Append(" AND (SalesOrderInfoList.MaterielID = @MaterielID) AND (SalesOrderInfoList.BrandID = @BrandID) ");
            strSql.Append(" AND  (SalesOrderInfoList.IsVerify = 3) AND (SalesOrderInfoList.Progress = 0) AND (SalesOrderInfoList.CompanyID = @CompanyID) AND (AmountInfo.NotAmount > 0) ");
            strSql.Append(" GROUP BY SalesOrderInfoList.DateTime, SalesOrderInfoList.Num, SalesOrderInfoList.ID,SalesOrderInfoList.DateTime,SalesOrderInfoList.LastDate,SalesOrderInfoList.Price,");
            strSql.Append("  SalesOrderInfoList.MaterielID,SalesOrderInfoList.MeasureID, SalesOrderInfoList.BrandID, SalesOrderInfoList.Remark");
            SqlParameter[] sps = {new SqlParameter("@TableTypeID",TableTypeID),new SqlParameter("@MaterielID",MaterielID),
                                 new SqlParameter("@BrandID",BrandID),new SqlParameter("@CompanyID",CompanyID)};
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="OneDate">开始日期</param>
        /// <param name="TwoDate">结束日期</param>
        /// <param name="IsHaveEnd">是否包含已完成的客户订单 </param>
        /// <param name="MatOrCom">按款号还是客户查询</param>
        /// <param name="TableTypeID">数量明细单类型</param>
        /// <returns></returns>
        public DataSet GetSalesList(object OneDate, object TwoDate, bool IsHaveEnd, int MatOrCom, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            strSql1.Append(" WHERE (AmountInfo.TableTypeID = @TableTypeID) And (SalesOrderInfoList.IsVerify=3) ");
                if (OneDate != null)
                {
                    strSql1.Append(" And (SalesOrderInfoList.DateTime > @OneDate) ");
                }
                if (TwoDate != null)
                {
                    strSql1.Append(" And (SalesOrderInfoList.DateTime < @TwoDate) ");
                }
                if (!IsHaveEnd)
                {
                    strSql1.Append(" AND  (AmountInfo.NotAmount > 0) ");
                }
            if (MatOrCom == 1)
            {
                strSql.Append("SELECT   SalesOrderInfoList.MaterielID as 款号, SalesOrderInfoList.BrandID as 商标, SUM(AmountInfo.Amount) AS 总数, ");
                strSql.Append(" SUM(AmountInfo.NotAmount) AS 未发货数量 FROM SalesOrderInfoList INNER JOIN AmountInfo ON SalesOrderInfoList.ID ");
                strSql.Append(" = AmountInfo.MainID ");
                strSql.Append(strSql1);
                strSql.Append(" GROUP BY SalesOrderInfoList.MaterielID, SalesOrderInfoList.BrandID");
            }
            else if (MatOrCom == 2)
            {
                strSql.Append(" SELECT   SalesOrderInfoList.CompanyID as 客户, SUM(AmountInfo.Amount) AS  总数, SUM(AmountInfo.NotAmount) AS 未发货数量 ");
                strSql.Append(" FROM SalesOrderInfoList INNER JOIN AmountInfo ON SalesOrderInfoList.ID = AmountInfo.MainID ");
                strSql.Append(strSql1);
                strSql.Append(" GROUP BY SalesOrderInfoList.CompanyID");
            }
            SqlParameter[] sps = { new SqlParameter("@OneDate", OneDate), new SqlParameter("@TwoDate", TwoDate),new SqlParameter("@TableTypeID",TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetNotAmount(int SalesID,int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID, ");
            strSql.Append(" AmountInfo.NotAmount AS Amount FROM      AmountInfo INNER JOIN SalesOrderInfoList ON AmountInfo.MainID ");
            strSql.Append(" = SalesOrderInfoList.ID WHERE   (AmountInfo.TableTypeID = @TableTypeID) AND (SalesOrderInfoList.ID = ");
            strSql.Append(" @SalesID) AND (AmountInfo.NotAmount > 0)");
            SqlParameter[] sps = { new SqlParameter("@SalesID", SalesID), new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetAllAmount(int MaterielID, int BrandID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ColorID, ColorOneID, ColorTwoID, SizeID , CAST(SUM(Amount) AS real) AS Amount FROM      (SELECT   ColorID, ColorOneID, ColorTwoID, SizeID, ");
            strSql.Append(" SUM(Amount) AS Amount FROM      Repertory WHERE   (MaterielID = @MaterielID) AND (BrandID = @BrandID) And (Amount > 0)");
            strSql.Append(" GROUP BY SizeID, ColorID, ColorOneID, ColorTwoID  UNION ALL SELECT   ");
            strSql.Append(" AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID,  SUM(AmountInfo.NotAmount) ");
            strSql.Append(" AS Amount FROM      ProductTaskMain INNER JOIN AmountInfo ON ProductTaskMain.ID = AmountInfo.MainID ");
            strSql.Append(" WHERE   (ProductTaskMain.MaterielID = @MaterielID) AND (ProductTaskMain.BrandID = @BrandID) AND ");
            strSql.Append(" (AmountInfo.TableTypeID = @TableTypeID) AND (ProductTaskMain.IsVerify = 3) GROUP BY AmountInfo.ColorID, ");
            strSql.Append(" AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID HAVING   (SUM(AmountInfo.NotAmount) > 0)) AS T ");
            strSql.Append(" GROUP BY ColorID, ColorOneID, ColorTwoID, SizeID");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID), new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetAllNotAmount(string IDS, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            string[] ID = IDS.Split(',');
            IDS= IDS.Remove(IDS.Length - 1, 1);
            strSql.Append("SELECT   AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID, SUM(AmountInfo.NotAmount) ");
            strSql.Append(" AS Amount FROM      AmountInfo INNER JOIN SalesOrderInfoList ON AmountInfo.MainID = SalesOrderInfoList.ID ");
            strSql.Append(" WHERE   (AmountInfo.TableTypeID = @TableTypeID) AND (AmountInfo.NotAmount > 0) AND  (SalesOrderInfoList.ID in (" + IDS + ")");// =");//in (" + IDlist + ")  '" + IDS.Remove(IDS.Length - 1, 1)) + "'";
            //strSql.Append(Convert.ToInt32(ID[0]));
            //for (int i = 1; i < ID.Length - 1; i++)
            //{
            //    strSql.Append(" OR  SalesOrderInfoList.ID=");
            //    strSql.Append(Convert.ToInt32(ID[i]));
            //}
            strSql.Append(")  GROUP BY AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID");
            SqlParameter[] sps = { new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetAllAmountByMat(string IDS, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            string[] ID = IDS.Split(',');
            strSql.Append("SELECT   AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID, SUM(AmountInfo.Amount) ");
            strSql.Append(" AS Amount FROM      AmountInfo INNER JOIN SalesOrderInfoList ON AmountInfo.MainID = SalesOrderInfoList.ID ");
            strSql.Append(" WHERE   (AmountInfo.TableTypeID = @TableTypeID) AND (SalesOrderInfoList.ID = ");
            strSql.Append(Convert.ToInt32(ID[0]));
            for (int i = 1; i < ID.Length - 1; i++)
            {
                strSql.Append(" OR  SalesOrderInfoList.ID=");
                strSql.Append(Convert.ToInt32(ID[i]));
            }
            strSql.Append(" ) GROUP BY AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID");
            SqlParameter[] sps = {  new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSalesListByMC(int MaterielID, int BrandID, int CompanyID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  CAST(0 AS bit) AS IsSelect,   SalesOrderInfoList.ID, SalesOrderInfoList.MainID, SalesOrderInfoList.MaterielID, SalesOrderInfoList.BrandID,  ");
            strSql.Append(" SalesOrderInfoList.Num, SalesOrderInfoList.DateTime, SalesOrderInfoList.LastDate, SalesOrderInfoList.Remark,  SalesOrderInfoList.Price, ");
            strSql.Append(" SalesOrderInfoList.IsVerify, SalesOrderInfoList.MeasureID, SalesOrderInfoList.CompanyID, SUM(AmountInfo.Amount) AS Amount, ");
            strSql.Append(" SUM(AmountInfo.NotAmount) AS NotAmount, SalesOrderInfoList.PackingMethodID FROM      SalesOrderInfoList INNER JOIN AmountInfo ON SalesOrderInfoList.ID = AmountInfo.MainID ");
            strSql.Append(" WHERE   (AmountInfo.TableTypeID = @TableTypeID) AND (SalesOrderInfoList.Progress < 3) GROUP BY SalesOrderInfoList.ID, SalesOrderInfoList.MainID, ");
            strSql.Append(" SalesOrderInfoList.MaterielID, SalesOrderInfoList.BrandID, SalesOrderInfoList.Num, SalesOrderInfoList.DateTime, SalesOrderInfoList.LastDate, ");
            strSql.Append(" SalesOrderInfoList.Remark, SalesOrderInfoList.Price, SalesOrderInfoList.IsVerify, SalesOrderInfoList.MeasureID,  SalesOrderInfoList.CompanyID,SalesOrderInfoList.PackingMethodID ");
            strSql.Append(" HAVING   (SalesOrderInfoList.IsVerify = 3) ");
            if (CompanyID > 0)
                strSql.Append(" AND (SalesOrderInfoList.CompanyID = @CompanyID) ");
            if (MaterielID > 0)
                strSql.Append(" AND  (SalesOrderInfoList.MaterielID = @MaterielID) AND (SalesOrderInfoList.BrandID = @BrandID)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID), 
                                   new SqlParameter("@CompanyID",CompanyID),  new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 转入生产计划
        /// </summary>
        /// <param name="SaleID"></param>
        /// <returns></returns>
        public int ToPlan(int SaleID, int FillMan)
        {
            try
            {
                DataTable dt = GetList("(ID=" + SaleID + ")").Tables[0];
                Hownet.DAL.SysTem dalST = new SysTem();
                Hownet.Model.SysTem modST = dalST.GetModel(dalST.GetMaxId());
                Hownet.DAL.ProductionPlan dalPP = new Hownet.DAL.ProductionPlan();
                Hownet.Model.ProductionPlan modPP = new Hownet.Model.ProductionPlan();
                modPP.SalesOrderInfoID = Convert.ToInt32(dt.Rows[0]["ID"]);
                modPP.MaterielID = Convert.ToInt32(dt.Rows[0]["MaterielID"]);
                modPP.BrandID = Convert.ToInt32(dt.Rows[0]["BrandID"]);
             //   modPP.Num = dalPP.NewNum(DateTime.Today, modST.NumType);
                dalPP.NewNum(DateTime.Today, modST.NumType);
                modPP.DateTime = DateTime.Today;
                modPP.LastDate = Convert.ToDateTime(dt.Rows[0]["LastDate"]);
                modPP.Remark = dt.Rows[0]["Remark"].ToString();
                modPP.PWorkingID = modPP.BomID = 0;
                modPP.CompanyID = Convert.ToInt32(dt.Rows[0]["CompanyID"]);
                modPP.IsTicket = modPP.IsBom = false;
                modPP.VerifyDate = Convert.ToDateTime("1900-1-1");
                modPP.VerifyMan = 0;
                modPP.DeparmentID = 0;
                modPP.UpData = 1;
                modPP.FillDate = DateTime.Today;
                modPP.FilMan = FillMan;
                modPP.TicketDate = Convert.ToDateTime("1900-1-1");
                modPP.BedNO = string.Empty;
                modPP.PackingMethodID = Convert.ToInt32(dt.Rows[0]["PackingMethodID"]);
                modPP.SewingRemark = dt.Rows[0]["SewingRemark"].ToString();
                modPP.TypeID = modPP.ParentID = 0;
                modPP.ParentID = 0;
                return dalPP.Add(modPP);
            }
            catch //(Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// 订单列表显示的数据
        /// </summary>
        /// <param name="TableTypeID"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetSalesViewList(int TableTypeID, string strWhere)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                //strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) + REPLACE(STR(Num, 3, 0), ' ', '0') AS Num, ID, MaterielID,DateTime, ");
                //strSql.Append(" CompanyID, BrandID, DateTime, (SELECT   SUM(Amount) AS SumAmount FROM AmountInfo WHERE (MainID = ");
                //strSql.Append(" SalesOrderInfoList.ID) AND (TableTypeID = @TableTypeID)) AS SumAmount,IsToPlan,Remark FROM SalesOrderInfoList ");
                strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) + REPLACE(STR(Num, 5, 0), ' ', '0') AS Num, ID, MaterielID, DateTime,Progress,cast(0 as bit) as IsSelect,  ");
                strSql.Append(" CompanyID, BrandID,  (SELECT   SUM(Amount) AS SumAmount FROM      AmountInfo ");
                strSql.Append(" WHERE   (MainID = SalesOrderInfoList.ID) AND (TableTypeID = @TableTypeID)) AS SumAmount, IsToPlan, ");
                strSql.Append(" (SELECT   SUM(NotAmount) AS SumAmount FROM      AmountInfo AS AmountInfo_1 WHERE   (MainID = SalesOrderInfoList.ID) ");
                strSql.Append(" AND (TableTypeID = @TableTypeID)) AS SumNotAmount,LastDate,");
                strSql.Append("  (CASE WHEN (Mainid = - 1) THEN FillMan ELSE (SELECT     fillman FROM salesordermain WHERE      id = salesorderinfolist.mainid) END) AS FillMan, ");
                strSql.Append(" Remark FROM      SalesOrderInfoList");
                if (strWhere.Length > 0)
                    strSql.Append(" where " + strWhere);
                strSql.Append("  ORDER BY DateTime");
                SqlParameter[] sps = { new SqlParameter("@TableTypeID", TableTypeID) };
                return DbHelperSQL.Query(strSql.ToString(), sps);
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public DataSet GetAnalysisList(string strFiled, string strGroup, string strWhere)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("SELECT   SUM(AmountInfo.Amount) AS SumAmount ");
                strSql.Append(strFiled);
                strSql.Append(" FROM      SalesOrderInfoList INNER JOIN AmountInfo ON SalesOrderInfoList.ID = AmountInfo.MainID  ");
                strSql.Append(" WHERE   (AmountInfo.TableTypeID = 28) And (SalesOrderInfoList.IsVerify = 3) ");
                strSql.Append(strWhere);
                strSql.Append(" GROUP BY SalesOrderInfoList.IsVerify ");
                strSql.Append(strGroup);
                strSql.Append(" ORDER BY Date ");
                return DbHelperSQL.Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        /// <summary>
        /// 删除该订单的生产计划
        /// </summary>
        /// <param name="ID"></param>
        public void DelPlan(int ID,int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" DELETE FROM AmountInfo FROM      ProductionPlan INNER JOIN AmountInfo ON ProductionPlan.ID = AmountInfo.MainID ");
            strSql.Append(" WHERE   (ProductionPlan.SalesOrderInfoID = @SalesID) AND (AmountInfo.TableTypeID = @TableTypeID)");
            SqlParameter[] sps = { new SqlParameter("@SalesID", ID), new SqlParameter("TableTypeID", TableTypeID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);

            strSql.Remove(0, strSql.Length);
            strSql.Append(" DELETE FROM ProductionPlan WHERE   (SalesOrderInfoID = @SalesID)");
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 删除一份订单合同下的所有明细
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        public void DeleteByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM SalesOrderInfoList WHERE   (MainID = @MainID)");
            SqlParameter[] sps = {new SqlParameter("@MainID",MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 销售 发货时，某客户订单的颜色总数
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet GetSumColorAmount(int MainID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(Amount) AS SumNum, SUM(NotAmount) AS SumSales, ColorID, MainID AS SalesID FROM      AmountInfo ");
            strSql.Append(" WHERE   (MainID = @MainID) AND (TableTypeID = @TableTypeID) GROUP BY ColorID, MainID");
            SqlParameter[] sps = {new SqlParameter("@MainID",MainID),new SqlParameter("@TableTypeID",TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetNumList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) + REPLACE(STR(Num, 3, 0), ' ', '0') AS Num, ID,(SELECT   Name ");
            // strSql.Append(" FROM      Materiel WHERE   (ID = ProductTaskMain.MaterielID)) AS MaterielName FROM      ProductTaskMain");
            //strSql.Append(" SELECT   CONVERT(varchar(100), ProductionPlan.DateTime, 112) + '-' + REPLACE(STR(ProductionPlan.Num, 3, 0), ' ', '0') ");
            //strSql.Append(" AS Num, ProductTaskMain.ID,(SELECT   Name FROM      Materiel WHERE   (ID = ProductTaskMain.MaterielID)) AS MaterielName, ");
            //strSql.Append(" ProductTaskMain.BedNO FROM      ProductTaskMain INNER JOIN ProductionPlan ON ProductTaskMain.ParentID = ProductionPlan.ID");
            strSql.Append(" SELECT   CONVERT(varchar(100), SalesOrderInfoList.DateTime, 112) + '-' + CAST(SalesOrderInfoList.Num AS varchar) ");
            strSql.Append(" AS Num, SalesOrderInfoList.ID,  Materiel_1.Name AS MaterielName, SalesOrderInfoList.CompanyID ");
            strSql.Append(" FROM      SalesOrderInfoList LEFT OUTER JOIN Materiel AS Materiel_1 ON SalesOrderInfoList.MaterielID = Materiel_1.ID");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetListForOne(int Top, int CompanyID, int MaterielID, DateTime dt1, DateTime dt2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  ");
            if(Top>0)
                strSql.Append(" Top (@Top)");
            strSql.Append(" SalesOrderInfoList.ID, SalesOrderInfoList.CompanyID AS 客户, SalesOrderInfoList.DateTime AS 日期, SalesOrderInfoList.Num AS 编号, ");
            strSql.Append(" SalesOrderInfoList.MaterielID AS 款号, SalesOrderInfoList.BrandID AS 商标, SalesOrderInfoList.LastDate AS 货期, SalesOrderInfoList.IsVerify AS 状态, ");
            strSql.Append(" SalesOrderInfoList.SunAmount AS 数量, SalesOrderInfoList.MeasureID AS 单位, SalesOrderInfoList.Price AS 单价, SUM(AmountInfo.NotAmount) AS 未发数量, ");
            strSql.Append(" SalesOrderInfoList.Remark as 备注 ");
            strSql.Append(" FROM         SalesOrderInfoList INNER JOIN AmountInfo ON SalesOrderInfoList.ID = AmountInfo.MainID WHERE     (AmountInfo.TableTypeID = 28) ");
            if (CompanyID > 0)
                strSql.Append(" AND (SalesOrderInfoList.CompanyID = @CompanyID) ");
            if(MaterielID>0)
                strSql.Append(" AND (SalesOrderInfoList.MaterielID = @MaterielID) ");
            if (dt1 > Convert.ToDateTime("1900-1-1"))
                strSql.Append(" And (SalesOrderInfoList.DateTime>@dt1) And (SalesOrderInfoList.DateTime<@dt2)");
            strSql.Append(" GROUP BY SalesOrderInfoList.ID, SalesOrderInfoList.MaterielID, SalesOrderInfoList.BrandID, SalesOrderInfoList.Num, SalesOrderInfoList.DateTime, ");
            strSql.Append(" SalesOrderInfoList.LastDate, SalesOrderInfoList.Price, SalesOrderInfoList.IsVerify, SalesOrderInfoList.MeasureID, SalesOrderInfoList.CompanyID,  ");
            strSql.Append(" SalesOrderInfoList.SunAmount,SalesOrderInfoList.Remark ORDER BY 日期 DESC");
            SqlParameter[] sps = { new SqlParameter("@Top", Top), new SqlParameter("@CompanyID", CompanyID),new SqlParameter("@MaterielID",MaterielID),new SqlParameter("@dt1",dt1),
                                 new SqlParameter("@dt2",dt2)};
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
			parameters[0].Value = "SalesOrderInfoList";
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

