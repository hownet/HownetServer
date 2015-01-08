using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类OtherType。
	/// </summary>
	public class OtherType
	{
		public OtherType()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("OtherTypeID", "OtherType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int OtherTypeID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OtherType");
			strSql.Append(" where ID=@OtherTypeID ");
			SqlParameter[] parameters = {
					new SqlParameter("@OtherTypeID", SqlDbType.Int,4)};
			parameters[0].Value = OtherTypeID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.OtherType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OtherType(");
            strSql.Append("Name,TypeID,Value)");
            strSql.Append(" values (");
            strSql.Append("@Name,@TypeID,@Value)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Value", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.Value;

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
        public void Update(Hownet.Model.OtherType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OtherType set ");
            strSql.Append("Name=@Name,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("Value=@Value");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Value", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.TypeID;
            parameters[3].Value = model.Value;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OtherType ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.OtherType GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,TypeID,Value from OtherType ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.OtherType model = new Hownet.Model.OtherType();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                model.Value = ds.Tables[0].Rows[0]["Value"].ToString();
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
            strSql.Append("select 1 as A,ID,Name,TypeID,Value ");
            strSql.Append(" FROM OtherType ");
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
            strSql.Append(" ID,Name,TypeID,Value ");
            strSql.Append(" FROM OtherType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 返回特定类型下的子类型
        /// </summary>
        /// <param name="TypeName">类型名</param>
        /// <returns></returns>
        public DataSet GetTypeList(string TypeName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID, Name, Value, TypeID,1 as A FROM OtherType WHERE (TypeID = (SELECT TOP 1 ID FROM OtherType AS OtherType_1 ");
            strSql.Append(" WHERE (Name = @TypeName) AND (TypeID = 0))) ORDER BY ID");
            SqlParameter[] sps ={ new SqlParameter("@TypeName", TypeName) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        /// <summary>
        /// 返回一类型的ID，不存在则返回0
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public int GetID(string TypeName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT TOP 1 ID FROM OtherType  ");
            strSql.Append(" WHERE (Name = @TypeName) ");
            SqlParameter[] sps ={ new SqlParameter("@TypeName", TypeName) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (obj != null)
                return int.Parse(obj.ToString());
            else
                return 0;
        }
        public DataSet GetWorkTime()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Name, TypeID, Value FROM OtherType WHERE   (Name = N'One') OR  (Name = N'Two') OR (Name = N'Three') ORDER BY ID DESC");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetNumValue()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CAST(Name AS real) AS Name, CAST(Value AS real) AS Value ");
            strSql.Append(" FROM      (SELECT   ID, Name, Value, TypeID, 1 AS A FROM      OtherType WHERE   (TypeID = ");
            strSql.Append(" (SELECT   TOP (1) ID FROM      OtherType AS OtherType_1 WHERE   (Name = '工资提成') AND (TypeID = 0)))) AS T ");
            strSql.Append(" ORDER BY Name DESC");
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
			parameters[0].Value = "OtherType";
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

