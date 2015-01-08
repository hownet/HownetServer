using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:SumReportInfo
    /// </summary>
    public partial class SumReportInfo
    {
        public SumReportInfo()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SumReportInfo");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SumReportInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SumReportInfo(");
            strSql.Append("MainID,ColorID,ColorOneID,ColorTwoID,SizeID,LastAmount,InAmount,OutAmount,Amount)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@LastAmount,@InAmount,@OutAmount,@Amount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@LastAmount", SqlDbType.Real,4),
					new SqlParameter("@InAmount", SqlDbType.Real,4),
					new SqlParameter("@OutAmount", SqlDbType.Real,4),
					new SqlParameter("@Amount", SqlDbType.Real,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorOneID;
            parameters[3].Value = model.ColorTwoID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.LastAmount;
            parameters[6].Value = model.InAmount;
            parameters[7].Value = model.OutAmount;
            parameters[8].Value = model.Amount;

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
        public bool Update(Hownet.Model.SumReportInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SumReportInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("LastAmount=@LastAmount,");
            strSql.Append("InAmount=@InAmount,");
            strSql.Append("OutAmount=@OutAmount,");
            strSql.Append("Amount=@Amount");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@LastAmount", SqlDbType.Real,4),
					new SqlParameter("@InAmount", SqlDbType.Real,4),
					new SqlParameter("@OutAmount", SqlDbType.Real,4),
					new SqlParameter("@Amount", SqlDbType.Real,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorOneID;
            parameters[3].Value = model.ColorTwoID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.LastAmount;
            parameters[6].Value = model.InAmount;
            parameters[7].Value = model.OutAmount;
            parameters[8].Value = model.Amount;
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
            strSql.Append("delete from SumReportInfo ");
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
            strSql.Append("delete from SumReportInfo ");
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
        public Hownet.Model.SumReportInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,ColorID,ColorOneID,ColorTwoID,SizeID,LastAmount,InAmount,OutAmount,Amount from SumReportInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.SumReportInfo model = new Hownet.Model.SumReportInfo();
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
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorOneID"] != null && ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"] != null && ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"] != null && ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastAmount"] != null && ds.Tables[0].Rows[0]["LastAmount"].ToString() != "")
                {
                    model.LastAmount = decimal.Parse(ds.Tables[0].Rows[0]["LastAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["InAmount"] != null && ds.Tables[0].Rows[0]["InAmount"].ToString() != "")
                {
                    model.InAmount = decimal.Parse(ds.Tables[0].Rows[0]["InAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OutAmount"] != null && ds.Tables[0].Rows[0]["OutAmount"].ToString() != "")
                {
                    model.OutAmount = decimal.Parse(ds.Tables[0].Rows[0]["OutAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
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
            strSql.Append("select  1 as A,ID,MainID,ColorID,ColorOneID,ColorTwoID,SizeID,LastAmount,InAmount,OutAmount,Amount ");
            strSql.Append(" FROM SumReportInfo ");
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
            strSql.Append(" ID,MainID,ColorID,ColorOneID,ColorTwoID,SizeID,LastAmount,InAmount,OutAmount,Amount ");
            strSql.Append(" FROM SumReportInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
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
            parameters[0].Value = "SumReportInfo";
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

