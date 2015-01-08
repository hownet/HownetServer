using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Measure。
	/// </summary>
	public class Measure
	{
		public Measure()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Measure"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Measure");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.Measure model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Measure(");
            strSql.Append("Name,IsUse,Sn,MeasureTypeID,IsEnd,Conversion)");
            strSql.Append(" values (");
            strSql.Append("@Name,@IsUse,@Sn,@MeasureTypeID,@IsEnd,@Conversion)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@MeasureTypeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@Conversion", SqlDbType.Decimal,9)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.IsUse;
            parameters[2].Value = model.Sn;
            parameters[3].Value = model.MeasureTypeID;
            parameters[4].Value = model.IsEnd;
            parameters[5].Value = model.Conversion;

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
        public bool Update(Hownet.Model.Measure model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Measure set ");
            strSql.Append("Name=@Name,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("Sn=@Sn,");
            strSql.Append("MeasureTypeID=@MeasureTypeID,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("Conversion=@Conversion");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@MeasureTypeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@Conversion", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.IsUse;
            parameters[2].Value = model.Sn;
            parameters[3].Value = model.MeasureTypeID;
            parameters[4].Value = model.IsEnd;
            parameters[5].Value = model.Conversion;
            parameters[6].Value = model.ID;

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
            strSql.Append("delete from Measure ");
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
            strSql.Append("delete from Measure ");
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
        public Hownet.Model.Measure GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,IsUse,Sn,MeasureTypeID,IsEnd,Conversion from Measure ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.Measure model = new Hownet.Model.Measure();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["IsUse"] != null && ds.Tables[0].Rows[0]["IsUse"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsUse"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsUse"].ToString().ToLower() == "true"))
                    {
                        model.IsUse = true;
                    }
                    else
                    {
                        model.IsUse = false;
                    }
                }
                model.Sn = ds.Tables[0].Rows[0]["Sn"].ToString();
                if (ds.Tables[0].Rows[0]["MeasureTypeID"] != null && ds.Tables[0].Rows[0]["MeasureTypeID"].ToString() != "")
                {
                    model.MeasureTypeID = int.Parse(ds.Tables[0].Rows[0]["MeasureTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"] != null && ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Conversion"] != null && ds.Tables[0].Rows[0]["Conversion"].ToString() != "")
                {
                    model.Conversion = decimal.Parse(ds.Tables[0].Rows[0]["Conversion"].ToString());
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
            strSql.Append("select  1 as A,ID,Name,IsUse,Sn,MeasureTypeID,IsEnd,Conversion ");
            strSql.Append(" FROM Measure ");
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
            strSql.Append(" ID,Name,IsUse,Sn,MeasureTypeID,IsEnd,Conversion ");
            strSql.Append(" FROM Measure ");
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
			parameters[0].Value = "Measure";
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

