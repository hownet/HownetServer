using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:VouchersInfo
	/// </summary>
	public partial class VouchersInfo
	{
		public VouchersInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "VouchersInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from VouchersInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.VouchersInfo model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into VouchersInfo(");
            strSql.Append("MainID,Summary,AccountsOne,AccountsTwo,DebitMoney,CreditMoney,IsPosting,AOne,ATwo)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@Summary,@AccountsOne,@AccountsTwo,@DebitMoney,@CreditMoney,@IsPosting,@AOne,@ATwo)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Summary", SqlDbType.NVarChar,4000),
					new SqlParameter("@AccountsOne", SqlDbType.Int,4),
					new SqlParameter("@AccountsTwo", SqlDbType.Int,4),
					new SqlParameter("@DebitMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreditMoney", SqlDbType.Decimal,9),
					new SqlParameter("@IsPosting", SqlDbType.Bit,1),
					new SqlParameter("@AOne", SqlDbType.NVarChar,500),
					new SqlParameter("@ATwo", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.Summary;
            parameters[2].Value = model.AccountsOne;
            parameters[3].Value = model.AccountsTwo;
            parameters[4].Value = model.DebitMoney;
            parameters[5].Value = model.CreditMoney;
            parameters[6].Value = model.IsPosting;
            parameters[7].Value = model.AOne;
            parameters[8].Value = model.ATwo;

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
        public bool Update(Hownet.Model.VouchersInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update VouchersInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("Summary=@Summary,");
            strSql.Append("AccountsOne=@AccountsOne,");
            strSql.Append("AccountsTwo=@AccountsTwo,");
            strSql.Append("DebitMoney=@DebitMoney,");
            strSql.Append("CreditMoney=@CreditMoney,");
            strSql.Append("IsPosting=@IsPosting,");
            strSql.Append("AOne=@AOne,");
            strSql.Append("ATwo=@ATwo");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Summary", SqlDbType.NVarChar,4000),
					new SqlParameter("@AccountsOne", SqlDbType.Int,4),
					new SqlParameter("@AccountsTwo", SqlDbType.Int,4),
					new SqlParameter("@DebitMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreditMoney", SqlDbType.Decimal,9),
					new SqlParameter("@IsPosting", SqlDbType.Bit,1),
					new SqlParameter("@AOne", SqlDbType.NVarChar,500),
					new SqlParameter("@ATwo", SqlDbType.NVarChar,500),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.Summary;
            parameters[2].Value = model.AccountsOne;
            parameters[3].Value = model.AccountsTwo;
            parameters[4].Value = model.DebitMoney;
            parameters[5].Value = model.CreditMoney;
            parameters[6].Value = model.IsPosting;
            parameters[7].Value = model.AOne;
            parameters[8].Value = model.ATwo;
            parameters[9].Value = model.ID;

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
            strSql.Append("delete from VouchersInfo ");
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
            strSql.Append("delete from VouchersInfo ");
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
        public Hownet.Model.VouchersInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,Summary,AccountsOne,AccountsTwo,DebitMoney,CreditMoney,IsPosting,AOne,ATwo from VouchersInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.VouchersInfo model = new Hownet.Model.VouchersInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                model.Summary = ds.Tables[0].Rows[0]["Summary"].ToString();
                if (ds.Tables[0].Rows[0]["AccountsOne"] != null && ds.Tables[0].Rows[0]["AccountsOne"].ToString() != "")
                {
                    model.AccountsOne = int.Parse(ds.Tables[0].Rows[0]["AccountsOne"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AccountsTwo"] != null && ds.Tables[0].Rows[0]["AccountsTwo"].ToString() != "")
                {
                    model.AccountsTwo = int.Parse(ds.Tables[0].Rows[0]["AccountsTwo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DebitMoney"] != null && ds.Tables[0].Rows[0]["DebitMoney"].ToString() != "")
                {
                    model.DebitMoney = decimal.Parse(ds.Tables[0].Rows[0]["DebitMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreditMoney"] != null && ds.Tables[0].Rows[0]["CreditMoney"].ToString() != "")
                {
                    model.CreditMoney = decimal.Parse(ds.Tables[0].Rows[0]["CreditMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsPosting"] != null && ds.Tables[0].Rows[0]["IsPosting"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsPosting"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsPosting"].ToString().ToLower() == "true"))
                    {
                        model.IsPosting = true;
                    }
                    else
                    {
                        model.IsPosting = false;
                    }
                }
                model.AOne = ds.Tables[0].Rows[0]["AOne"].ToString();
                model.ATwo = ds.Tables[0].Rows[0]["ATwo"].ToString();
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
            strSql.Append("select  1 as A,ID,MainID,Summary,AccountsOne,AccountsTwo,DebitMoney,CreditMoney,IsPosting,AOne,ATwo ");
            strSql.Append(" FROM VouchersInfo ");
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
            strSql.Append(" ID,MainID,Summary,AccountsOne,AccountsTwo,DebitMoney,CreditMoney,IsPosting,AOne,ATwo ");
            strSql.Append(" FROM VouchersInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByMainID(int MainID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from VouchersInfo ");
            strSql.Append(" where MainID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = MainID;

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
			parameters[0].Value = "VouchersInfo";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

