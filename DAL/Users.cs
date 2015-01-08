using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Users。
	/// </summary>
	public class Users
	{
		public Users()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Users");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Users(");
            strSql.Append("Name,Password,TrueName,Phone,Email,EmployeeID,DepartmentID,State,JobsID)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Password,@TrueName,@Phone,@Email,@EmployeeID,@DepartmentID,@State,@JobsID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.Binary,20),
					new SqlParameter("@TrueName", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@JobsID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.TrueName;
            parameters[3].Value = model.Phone;
            parameters[4].Value = model.Email;
            parameters[5].Value = model.EmployeeID;
            parameters[6].Value = model.DepartmentID;
            parameters[7].Value = model.State;
            parameters[8].Value = model.JobsID;

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
        public bool Update(Hownet.Model.Users model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Users set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Password=@Password,");
            strSql.Append("TrueName=@TrueName,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Email=@Email,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("State=@State,");
            strSql.Append("JobsID=@JobsID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.Binary,20),
					new SqlParameter("@TrueName", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@State", SqlDbType.Int,4),
					new SqlParameter("@JobsID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Password;
            parameters[2].Value = model.TrueName;
            parameters[3].Value = model.Phone;
            parameters[4].Value = model.Email;
            parameters[5].Value = model.EmployeeID;
            parameters[6].Value = model.DepartmentID;
            parameters[7].Value = model.State;
            parameters[8].Value = model.JobsID;
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
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Users ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.Users GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,Password,TrueName,Phone,Email,EmployeeID,DepartmentID,State,JobsID from Users ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.Users model = new Hownet.Model.Users();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["Password"].ToString() != "")
                {
                    model.Password = (byte[])ds.Tables[0].Rows[0]["Password"];
                }
                model.TrueName = ds.Tables[0].Rows[0]["TrueName"].ToString();
                model.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepartmentID"].ToString() != "")
                {
                    model.DepartmentID = int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["State"].ToString() != "")
                {
                    model.State = int.Parse(ds.Tables[0].Rows[0]["State"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JobsID"].ToString() != "")
                {
                    model.JobsID = int.Parse(ds.Tables[0].Rows[0]["JobsID"].ToString());
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
            strSql.Append("select 1 as A,ID,Name,Password,TrueName,Phone,Email,EmployeeID,DepartmentID,State,JobsID ");
            strSql.Append(" FROM Users ");
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
            strSql.Append(" ID,Name,Password,TrueName,Phone,Email,EmployeeID,DepartmentID,State,JobsID ");
            strSql.Append(" FROM Users ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public object GetPass(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select Password from Users where (ID=@ID)");
            SqlParameter[] sps = { new SqlParameter("@ID", UserID) };
            return DbHelperSQL.GetSingle(strSql.ToString(), sps);
        }
        public DataTable GetPassByUserName(string UserName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select ID, Password from Users where (Name=@UserName)");
            SqlParameter[] sps = { new SqlParameter("@UserName", UserName) };
            return DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
        }
        public DataSet GetViewList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  ID, Name, TrueName,DepartmentID,JobsID FROM Users");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetPerList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT    ID, Name, ParentID, 0 AS UseID FROM      (SELECT  TOP (100) PERCENT ID * - 1 AS ID, Name, 0 AS ParentID FROM      Deparment ");
            strSql.Append(" ORDER BY ID DESC) AS Tem UNION ALL SELECT   ID, JobsName, DepartmentID * - 1 AS ParentID, 0 AS Expr1 FROM      DepartmentJobs ");
            strSql.Append(" UNION ALL SELECT   -9999999+ID AS ID, TrueName, JobsID, ID AS Expr1 FROM      Users WHERE   (JobsID > 0)");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetTableName()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT object_name(so.id) AS Name FROM dbo.sysobjects so WHERE so.type = N'U' AND permissions(so.id) & 4096 <> 0 ");
            strSql.Append(" AND ObjectProperty(so.id, N'IsMSShipped') = 0 ORDER BY user_name(so.uid), object_name(so.id) ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetTableColumns(string TableName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   d.name  表名, a.colorder 字段序号, a.name 字段名, (case when COLUMNPROPERTY( a.id,a.name,'IsIdentity')=1 then 1 else 0 end) 标识, ");
            strSql.Append(" (case when (SELECT count(*) FROM sysobjects  WHERE (name in (SELECT name FROM sysindexes WHERE (id = a.id) AND (indid in (SELECT indid ");
            strSql.Append(" FROM sysindexkeys WHERE (id = a.id) AND (colid in (SELECT colid FROM syscolumns WHERE (id = a.id) AND (name = a.name) ) ) ) ) ) ) AND (xtype = 'PK')  ");
            strSql.Append(" ) > 0 then 1 else 0 end) 主键,b.name 类型,a.length 占用字节数,COLUMNPROPERTY(a.id,a.name,'PRECISION') as 长度, ");
            strSql.Append(" isnull(COLUMNPROPERTY(a.id,a.name,'Scale'),0) as 小数位数,(case when a.isnullable=1 then 1 else 0 end) 允许空, ");
            strSql.Append(" isnull(e.text,'') 默认值,isnull(g.[value],'') AS 字段说明   FROM  syscolumns a  left join systypes b on a.xtype=b.xusertype ");
            strSql.Append(" inner join sysobjects d on a.id=d.id  and  d.xtype='U' and d.name<>'dtproperties' left join syscomments e on a.cdefault=e.id ");
            strSql.Append(" left join sys.extended_properties g on a.id=g.major_id AND a.colid = g.minor_id ");// where d.name=@TableName ")
            if (TableName != "")
                strSql.Append("  where d.name='" + TableName + "'");
            strSql.Append(" order by d.name,a.colorder ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int GetUserIDByName(string UserName)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID From Users Where (TrueName=@Name)");
            SqlParameter[] sps = { new SqlParameter("@Name", UserName) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
                
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
			parameters[0].Value = "Users";
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

