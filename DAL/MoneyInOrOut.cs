using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类MoneyInOrOut。
	/// </summary>
	public class MoneyInOrOut
	{
		public MoneyInOrOut()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "MoneyInOrOut"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MoneyInOrOut");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MoneyInOrOut model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MoneyInOrOut(");
            strSql.Append("Num,DateTime,CompanyID,Money,Remark,TypeID,IsVerify,VerifyMan,VerifyDate,LastMoney,ChangMoney,FillMan,FillDate,KJKMID,Fees)");
            strSql.Append(" values (");
            strSql.Append("@Num,@DateTime,@CompanyID,@Money,@Remark,@TypeID,@IsVerify,@VerifyMan,@VerifyDate,@LastMoney,@ChangMoney,@FillMan,@FillDate,@KJKMID,@Fees)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@TypeID", SqlDbType.TinyInt,1),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ChangMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@KJKMID", SqlDbType.Int,4),
					new SqlParameter("@Fees", SqlDbType.Decimal,9)};
            parameters[0].Value = model.Num;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.CompanyID;
            parameters[3].Value = model.Money;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.TypeID;
            parameters[6].Value = model.IsVerify;
            parameters[7].Value = model.VerifyMan;
            parameters[8].Value = model.VerifyDate;
            parameters[9].Value = model.LastMoney;
            parameters[10].Value = model.ChangMoney;
            parameters[11].Value = model.FillMan;
            parameters[12].Value = model.FillDate;
            parameters[13].Value = model.KJKMID;
            parameters[14].Value = model.Fees;

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
        public bool Update(Hownet.Model.MoneyInOrOut model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MoneyInOrOut set ");
            strSql.Append("Num=@Num,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("Money=@Money,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("LastMoney=@LastMoney,");
            strSql.Append("ChangMoney=@ChangMoney,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("KJKMID=@KJKMID,");
            strSql.Append("Fees=@Fees");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@TypeID", SqlDbType.TinyInt,1),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@ChangMoney", SqlDbType.Decimal,9),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@KJKMID", SqlDbType.Int,4),
					new SqlParameter("@Fees", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Num;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.CompanyID;
            parameters[3].Value = model.Money;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.TypeID;
            parameters[6].Value = model.IsVerify;
            parameters[7].Value = model.VerifyMan;
            parameters[8].Value = model.VerifyDate;
            parameters[9].Value = model.LastMoney;
            parameters[10].Value = model.ChangMoney;
            parameters[11].Value = model.FillMan;
            parameters[12].Value = model.FillDate;
            parameters[13].Value = model.KJKMID;
            parameters[14].Value = model.Fees;
            parameters[15].Value = model.ID;

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
            strSql.Append("delete from MoneyInOrOut ");
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
            strSql.Append("delete from MoneyInOrOut ");
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
        public Hownet.Model.MoneyInOrOut GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Num,DateTime,CompanyID,Money,Remark,TypeID,IsVerify,VerifyMan,VerifyDate,LastMoney,ChangMoney,FillMan,FillDate,KJKMID,Fees from MoneyInOrOut ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.MoneyInOrOut model = new Hownet.Model.MoneyInOrOut();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"] != null && ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
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
                if (ds.Tables[0].Rows[0]["LastMoney"] != null && ds.Tables[0].Rows[0]["LastMoney"].ToString() != "")
                {
                    model.LastMoney = decimal.Parse(ds.Tables[0].Rows[0]["LastMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ChangMoney"] != null && ds.Tables[0].Rows[0]["ChangMoney"].ToString() != "")
                {
                    model.ChangMoney = decimal.Parse(ds.Tables[0].Rows[0]["ChangMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"] != null && ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"] != null && ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["KJKMID"] != null && ds.Tables[0].Rows[0]["KJKMID"].ToString() != "")
                {
                    model.KJKMID = int.Parse(ds.Tables[0].Rows[0]["KJKMID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Fees"] != null && ds.Tables[0].Rows[0]["Fees"].ToString() != "")
                {
                    model.Fees = decimal.Parse(ds.Tables[0].Rows[0]["Fees"].ToString());
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
            strSql.Append("select  1 as A,ID,Num,DateTime,CompanyID,Money,Remark,TypeID,IsVerify,VerifyMan,VerifyDate,LastMoney,ChangMoney,FillMan,FillDate,KJKMID,Fees ");
            strSql.Append(" FROM MoneyInOrOut ");
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
            strSql.Append(" ID,Num,DateTime,CompanyID,Money,Remark,TypeID,IsVerify,VerifyMan,VerifyDate,LastMoney,ChangMoney,FillMan,FillDate,KJKMID,Fees ");
            strSql.Append(" FROM MoneyInOrOut ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 根据类型返回只有ID值的列表 
        /// </summary>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetIDList(int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            string ss = string.Empty;
            if (TypeID == 4 || TypeID == 5)
                ss = " (TypeID=4) OR  (TypeID=5) ";
            if (TypeID == 2 || TypeID == 6)
                ss = " (TypeID=2) OR  (TypeID=6) ";
            strSql.Append("select ID FROM MoneyInOrOut where ");
            strSql.Append(ss);
            strSql.Append(" order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 返回该客户之前的帐户余额
        /// </summary>
        /// <param name="CompanyID">客户名</param>
        /// <returns></returns>
        public DataSet GetLastMoney(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT TOP 1 Money, DateTime, TypeID,TableID FROM CompanyLog WHERE  (CompanyID = @comID)");
            strSql.Append(" ORDER BY ID DESC");
            SqlParameter[] sps = { new SqlParameter("@comID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int NewNum(DateTime dt, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            DateTime dt1 = dt.Date.AddDays(dt.Date.Day * -1 + 1);
            DateTime dt2 = dt1.AddMonths(1);
            strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      MoneyInOrOut WHERE   (DateTime > @dt1) And (DateTime <@dt2) And (TypeID=@TypeID)");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@TypeID", TypeID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
        public void DeleteByCompanyID(int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MoneyInOrOut ");
            strSql.Append(" where CompanyID=@CompanyID ");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
            parameters[0].Value = CompanyID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetInfoList(DateTime dt1, DateTime dt2, int CompanyID, bool IsSum)
        {
            StringBuilder strSql = new StringBuilder();
            if (IsSum)
            {
                strSql.Append(" SELECT  ID,  DateTime AS 日期, CompanyID AS [客户], ChangMoney AS 收款金额 FROM      MoneyInOrOut WHERE   (DateTime > @dt1) AND  (TypeID = 4) ");
                if (CompanyID > 0)
                    strSql.Append(" And (CompanyID=@CompanyID)");
            }
            else
            {
                strSql.Append(" SELECT ID,  DateTime AS 日期, CompanyID AS [供应商], ChangMoney AS 付款金额 FROM      MoneyInOrOut WHERE   (DateTime > @dt1) AND  (TypeID = 2) ");
                if (CompanyID > 0)
                    strSql.Append(" And (CompanyID=@CompanyID)");
            }
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
			parameters[0].Value = "MoneyInOrOut";
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

