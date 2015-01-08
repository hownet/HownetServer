using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类SalesOrderMain。
	/// </summary>
	public class SalesOrderMain
	{
		public SalesOrderMain()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SalesOrderMain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SalesOrderMain");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SalesOrderMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SalesOrderMain(");
            strSql.Append("CompanyID,DateTime,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,UpData)");
            strSql.Append(" values (");
            strSql.Append("@CompanyID,@DateTime,@Remark,@Num,@FillMan,@FillDate,@IsVerify,@VerifyMan,@VerifyDate,@UpData)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.FillMan;
            parameters[5].Value = model.FillDate;
            parameters[6].Value = model.IsVerify;
            parameters[7].Value = model.VerifyMan;
            parameters[8].Value = model.VerifyDate;
            parameters[9].Value = model.UpData;

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
        public bool Update(Hownet.Model.SalesOrderMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SalesOrderMain set ");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Num=@Num,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("UpData=@UpData");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.FillMan;
            parameters[5].Value = model.FillDate;
            parameters[6].Value = model.IsVerify;
            parameters[7].Value = model.VerifyMan;
            parameters[8].Value = model.VerifyDate;
            parameters[9].Value = model.UpData;
            parameters[10].Value = model.ID;

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
            strSql.Append("delete from SalesOrderMain ");
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
            strSql.Append("delete from SalesOrderMain ");
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
        public Hownet.Model.SalesOrderMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CompanyID,DateTime,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,UpData from SalesOrderMain ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.SalesOrderMain model = new Hownet.Model.SalesOrderMain();
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
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
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
            strSql.Append("select 1 as A,ID,CompanyID,DateTime,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,UpData ");
            strSql.Append(" ,(Select TrueName from Users where (ID=SalesOrderMain.FillMan)) as Fill,(Select TrueName from Users where (ID=SalesOrderMain.VerifyMan)) as Verify");
            strSql.Append(" FROM SalesOrderMain ");
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
            strSql.Append(" ID,CompanyID,DateTime,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,UpData ");
            strSql.Append(" FROM SalesOrderMain ");
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
            strSql.Append("Select ID from SalesOrderMain order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int NewNum(DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      SalesOrderMain WHERE   (YEAR(DateTime) = YEAR(@dt))");
            SqlParameter[] sps = { new SqlParameter("@dt", dt) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
        /// <summary>
        /// 获得一个订单合同的明细数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet GetAmount(int MainID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT 1 as A,  AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID, AmountInfo.MListID, AmountInfo.ID, AmountInfo.TableTypeID,  ");
            strSql.Append(" AmountInfo.Amount, AmountInfo.NotAmount, AmountInfo.NotDepAmount, AmountInfo.Remark, 0 AS RowID,AmountInfo.MainID FROM ");
            strSql.Append(" SalesOrderInfoList INNER JOIN AmountInfo ON SalesOrderInfoList.ID = AmountInfo.MainID WHERE    ");
            strSql.Append("  (SalesOrderInfoList.MainID = @MainID) AND (AmountInfo.TableTypeID = @TableTypeID) ORDER BY SalesOrderInfoList.ID");
            SqlParameter[] sps = {new SqlParameter("@MainID",MainID),new SqlParameter("@TableTypeID",TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回某一款号在库存中的颜色和尺码
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetCS2RepByMatID(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SizeID, ColorID, ColorOneID, ColorTwoID FROM      Repertory WHERE   (MaterielID = @MaterielID) ");
            strSql.Append(" GROUP BY SizeID, ColorID, ColorOneID, ColorTwoID");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
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
			parameters[0].Value = "SalesOrderMain";
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

