using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类PayCostsInfo。
    /// </summary>
    public class PayCostsInfo
    {
        public PayCostsInfo()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PayCostsInfo");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.PayCostsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PayCostsInfo(");
            strSql.Append("MainID,EmployeeID,Money,Remark,IsDeposit)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@EmployeeID,@Money,@Remark,@IsDeposit)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@IsDeposit", SqlDbType.Bit,1)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.Money;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.IsDeposit;

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
        public void Update(Hownet.Model.PayCostsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PayCostsInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("Money=@Money,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsDeposit=@IsDeposit");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@IsDeposit", SqlDbType.Bit,1)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.EmployeeID;
            parameters[3].Value = model.Money;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.IsDeposit;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayCostsInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.PayCostsInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,EmployeeID,Money,Remark,IsDeposit from PayCostsInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.PayCostsInfo model = new Hownet.Model.PayCostsInfo();
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
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["IsDeposit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsDeposit"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsDeposit"].ToString().ToLower() == "true"))
                    {
                        model.IsDeposit = true;
                    }
                    else
                    {
                        model.IsDeposit = false;
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
            strSql.Append("select 1 as A,ID,MainID,EmployeeID,Money,Remark,IsDeposit ");
            strSql.Append(" FROM PayCostsInfo ");
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
            strSql.Append(" ID,MainID,EmployeeID,Money,Remark,IsDeposit ");
            strSql.Append(" FROM PayCostsInfo ");
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
        public void DeleteByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayCostsInfo ");
            strSql.Append(" where MainID=@ID ");
            SqlParameter[] parameters = {new SqlParameter("@ID", MainID)};
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetViews(DateTime DateOne, DateTime DateTwo, int EmployeeID, bool IsInfo)
        {
             DateTime dtt = DateTwo.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            if (IsInfo)
            {
                strSql.Append("SELECT   PayCosts.DateTime, PayCostsInfo.EmployeeID, PayCostsInfo.Money, PayCosts.TypeID, MiniEmp.Name AS EmpName, ");
                strSql.Append(" MiniEmp.DepartmentID  FROM      PayCosts INNER JOIN ");
                strSql.Append(" PayCostsInfo ON PayCosts.ID = PayCostsInfo.MainID  INNER JOIN MiniEmp ON PayCostsInfo.EmployeeID = MiniEmp.ID");
                strSql.Append(" WHERE   (PayCosts.DateTime >= @dtOne) AND (PayCosts.DateTime < @dtTwo) ");
                strSql.Append(" AND (PayCosts.IsVerify > 2)");
                if (EmployeeID > 0)
                    strSql.Append(" And (PayCostsInfo.EmployeeID=@EmployeeID) ");
                strSql.Append(" ORDER BY MiniEmp.Name");
            }
            else
            {
                strSql.Append(" SELECT   PayCostsInfo.EmployeeID,Sum(PayCostsInfo.Money) as Money , PayCosts.TypeID, MiniEmp.Name AS EmpName,  MiniEmp.DepartmentID ");
                strSql.Append(" FROM      PayCosts INNER JOIN PayCostsInfo ON PayCosts.ID = PayCostsInfo.MainID INNER JOIN MiniEmp ON ");
                strSql.Append(" PayCostsInfo.EmployeeID = MiniEmp.ID WHERE   (PayCosts.DateTime >= @dtOne) AND (PayCosts.DateTime < @dtTwo) ");
                strSql.Append(" AND (PayCosts.IsVerify > 2) ");
                if (EmployeeID > 0)
                    strSql.Append(" And (PayCostsInfo.EmployeeID=@EmployeeID)");
                strSql.Append(" GROUP BY PayCostsInfo.EmployeeID,  PayCosts.TypeID, MiniEmp.Name, MiniEmp.DepartmentID ");
                strSql.Append(" ORDER BY MiniEmp.Name");
            }
            SqlParameter[] sqs = { new SqlParameter("@dtOne", DateOne), new SqlParameter("@dtTwo", dtt), new SqlParameter("@EmployeeID", EmployeeID)};
            return DbHelperSQL.Query(strSql.ToString(), sqs);
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
            parameters[0].Value = "PayCostsInfo";
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

