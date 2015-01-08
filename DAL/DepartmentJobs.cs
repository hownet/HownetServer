using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类DepartmentJobs。
    /// </summary>
    public class DepartmentJobs
    {
        public DepartmentJobs()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DepartmentJobs");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.DepartmentJobs model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DepartmentJobs(");
            strSql.Append("JobsName,DepartmentID,Remark,EmployeeCount,IsEnd)");
            strSql.Append(" values (");
            strSql.Append("@JobsName,@DepartmentID,@Remark,@EmployeeCount,@IsEnd)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@JobsName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@EmployeeCount", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
            parameters[0].Value = model.JobsName;
            parameters[1].Value = model.DepartmentID;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.EmployeeCount;
            parameters[4].Value = model.IsEnd;

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
        public void Update(Hownet.Model.DepartmentJobs model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DepartmentJobs set ");
            strSql.Append("JobsName=@JobsName,");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("EmployeeCount=@EmployeeCount,");
            strSql.Append("IsEnd=@IsEnd");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@JobsName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@EmployeeCount", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.JobsName;
            parameters[2].Value = model.DepartmentID;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.EmployeeCount;
            parameters[5].Value = model.IsEnd;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DepartmentJobs ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.DepartmentJobs GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,JobsName,DepartmentID,Remark,EmployeeCount,IsEnd from DepartmentJobs ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.DepartmentJobs model = new Hownet.Model.DepartmentJobs();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.JobsName = ds.Tables[0].Rows[0]["JobsName"].ToString();
                if (ds.Tables[0].Rows[0]["DepartmentID"].ToString() != "")
                {
                    model.DepartmentID = int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["EmployeeCount"].ToString() != "")
                {
                    model.EmployeeCount = int.Parse(ds.Tables[0].Rows[0]["EmployeeCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
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
            strSql.Append("select 1 as A,ID,JobsName,DepartmentID,Remark,EmployeeCount,IsEnd ");
            strSql.Append(" FROM DepartmentJobs ");
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
            strSql.Append(" ID,JobsName,DepartmentID,Remark,EmployeeCount,IsEnd ");
            strSql.Append(" FROM DepartmentJobs ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetJobs()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID, Name, ParentID FROM      (SELECT   TOP (100) PERCENT ID * - 1 AS ID, Name, 0 AS ParentID ");
            strSql.Append(" FROM      Deparment ORDER BY ID DESC) AS Tem UNION ALL SELECT   ID, JobsName, DepartmentID * - 1 AS ParentID FROM      DepartmentJobs");
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
            parameters[0].Value = "DepartmentJobs";
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

