using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:PayColumnsSet
	/// </summary>
	public partial class PayColumnsSet
	{
		public PayColumnsSet()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "PayColumnsSet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PayColumnsSet");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.PayColumnsSet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PayColumnsSet(");
            strSql.Append("Name,Remark,TypeID,Caic,ColumnsName,IsCosts,IsBack)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Remark,@TypeID,@Caic,@ColumnsName,@IsCosts,@IsBack)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Caic", SqlDbType.Int,4),
					new SqlParameter("@ColumnsName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCosts", SqlDbType.Bit,1),
					new SqlParameter("@IsBack", SqlDbType.Bit,1)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Remark;
            parameters[2].Value = model.TypeID;
            parameters[3].Value = model.Caic;
            parameters[4].Value = model.ColumnsName;
            parameters[5].Value = model.IsCosts;
            parameters[6].Value = model.IsBack;

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
        public bool Update(Hownet.Model.PayColumnsSet model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PayColumnsSet set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Caic=@Caic,");
            strSql.Append("ColumnsName=@ColumnsName,");
            strSql.Append("IsCosts=@IsCosts,");
            strSql.Append("IsBack=@IsBack");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Caic", SqlDbType.Int,4),
					new SqlParameter("@ColumnsName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCosts", SqlDbType.Bit,1),
					new SqlParameter("@IsBack", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Remark;
            parameters[2].Value = model.Caic;
            parameters[3].Value = model.ColumnsName;
            parameters[4].Value = model.IsCosts;
            parameters[5].Value = model.IsBack;
            parameters[6].Value = model.ID;
            parameters[7].Value = model.TypeID;

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
            strSql.Append("delete from PayColumnsSet ");
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
        public bool Delete(int ID, int TypeID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayColumnsSet ");
            strSql.Append(" where ID=@ID and TypeID=@TypeID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4)};
            parameters[0].Value = ID;
            parameters[1].Value = TypeID;

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
            strSql.Append("delete from PayColumnsSet ");
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
        public Hownet.Model.PayColumnsSet GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,Remark,TypeID,Caic,ColumnsName,IsCosts,IsBack from PayColumnsSet ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.PayColumnsSet model = new Hownet.Model.PayColumnsSet();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Caic"] != null && ds.Tables[0].Rows[0]["Caic"].ToString() != "")
                {
                    model.Caic = int.Parse(ds.Tables[0].Rows[0]["Caic"].ToString());
                }
                model.ColumnsName = ds.Tables[0].Rows[0]["ColumnsName"].ToString();
                if (ds.Tables[0].Rows[0]["IsCosts"] != null && ds.Tables[0].Rows[0]["IsCosts"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCosts"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCosts"].ToString().ToLower() == "true"))
                    {
                        model.IsCosts = true;
                    }
                    else
                    {
                        model.IsCosts = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsBack"] != null && ds.Tables[0].Rows[0]["IsBack"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsBack"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsBack"].ToString().ToLower() == "true"))
                    {
                        model.IsBack = true;
                    }
                    else
                    {
                        model.IsBack = false;
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
            strSql.Append("select  1 as A,ID,Name,Remark,TypeID,Caic,ColumnsName,IsCosts,IsBack ");
            strSql.Append(" FROM PayColumnsSet ");
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
            strSql.Append(" ID,Name,Remark,TypeID,Caic,ColumnsName,IsCosts,IsBack ");
            strSql.Append(" FROM PayColumnsSet ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetTypeList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select TypeID as ID,Name From PayColumnsSet WHERE (DATALENGTH(Name) > 0) AND (IsCosts = 1)");
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
			parameters[0].Value = "PayColumnsSet";
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

