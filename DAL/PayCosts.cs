using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类PayCosts。
    /// </summary>
    public class PayCosts
    {
        public PayCosts()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PayCosts");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.PayCosts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PayCosts(");
            strSql.Append("DateTime,TypeID,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate)");
            strSql.Append(" values (");
            strSql.Append("@DateTime,@TypeID,@Remark,@Num,@FillMan,@FillDate,@IsVerify,@VerifyMan,@VerifyDate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.FillMan;
            parameters[5].Value = model.FillDate;
            parameters[6].Value = model.IsVerify;
            parameters[7].Value = model.VerifyMan;
            parameters[8].Value = model.VerifyDate;
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
        public void Update(Hownet.Model.PayCosts model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PayCosts set ");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Num=@Num,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.TypeID;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.Num;
            parameters[5].Value = model.FillMan;
            parameters[6].Value = model.FillDate;
            parameters[7].Value = model.IsVerify;
            parameters[8].Value = model.VerifyMan;
            parameters[9].Value = model.VerifyDate;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayCosts ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.PayCosts GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DateTime,TypeID,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate from PayCosts ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.PayCosts model = new Hownet.Model.PayCosts();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
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
            strSql.Append("select ID,DateTime,TypeID,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate ");
            strSql.Append(" FROM PayCosts ");
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
            strSql.Append(" ID,DateTime,TypeID,Remark,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate ");
            strSql.Append(" FROM PayCosts ");
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
            strSql.Append(" Select ID from PayCosts order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 取得新编号
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public int NewNum(DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            strSql.Append("Select max(Num) as exp1 from PayCosts where (datetime >@dt1) and (datetime<@dt2) ");
            SqlParameter[] sp = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sp) != null)
            {
                return int.Parse(DbHelperSQL.GetSingle(strSql.ToString(), sp).ToString()) + 1;
            }
            else
            {
                return 1;
            }
        }
        public DataSet GetListByDay(DateTime dtOne, DateTime dtTwo, int EmployeeID)
        {
            StringBuilder strSql = new StringBuilder();
            DateTime dtt = dtTwo.AddDays(1);
            strSql.Append("SELECT PayCostsInfo.EmployeeID, SUM(PayCostsInfo.Money) AS Money,PayCosts.TypeID ");
            strSql.Append(" FROM PayCosts INNER JOIN PayCostsInfo ON PayCosts.ID = PayCostsInfo.MainID ");
            strSql.Append(" WHERE (PayCosts.DateTime >= @dtOne) AND (PayCosts.DateTime < @dtTwo) ");
            if (EmployeeID > 0)
                strSql.Append(" And (PayCostsInfo.EmployeeID=@EmployeeID )");
            strSql.Append(" GROUP BY PayCostsInfo.EmployeeID, PayCosts.TypeID");
            SqlParameter[] sp = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtt), new SqlParameter("@EmployeeID", EmployeeID) };
            return DbHelperSQL.Query(strSql.ToString(), sp);
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
            parameters[0].Value = "PayCosts";
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

