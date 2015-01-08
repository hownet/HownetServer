using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Size。
	/// </summary>
	public class Size
	{
		public Size()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Size"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Size");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Size model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Size(");
            strSql.Append("Name,Sn,IsUse,IsEnd,SizeTypeID,Orders)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Sn,@IsUse,@IsEnd,@SizeTypeID,@Orders)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@SizeTypeID", SqlDbType.Int,4),
					new SqlParameter("@Orders", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Sn;
            parameters[2].Value = model.IsUse;
            parameters[3].Value = model.IsEnd;
            parameters[4].Value = model.SizeTypeID;
            parameters[5].Value = model.Orders;

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
        public bool Update(Hownet.Model.Size model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Size set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Sn=@Sn,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("SizeTypeID=@SizeTypeID,");
            strSql.Append("Orders=@Orders");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@SizeTypeID", SqlDbType.Int,4),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Sn;
            parameters[2].Value = model.IsUse;
            parameters[3].Value = model.IsEnd;
            parameters[4].Value = model.SizeTypeID;
            parameters[5].Value = model.Orders;
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
            strSql.Append("delete from Size ");
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
            strSql.Append("delete from Size ");
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
        public Hownet.Model.Size GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,Sn,IsUse,IsEnd,SizeTypeID,Orders from Size ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.Size model = new Hownet.Model.Size();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                model.Sn = ds.Tables[0].Rows[0]["Sn"].ToString();
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
                if (ds.Tables[0].Rows[0]["IsEnd"] != null && ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeTypeID"] != null && ds.Tables[0].Rows[0]["SizeTypeID"].ToString() != "")
                {
                    model.SizeTypeID = int.Parse(ds.Tables[0].Rows[0]["SizeTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Orders"] != null && ds.Tables[0].Rows[0]["Orders"].ToString() != "")
                {
                    model.Orders = int.Parse(ds.Tables[0].Rows[0]["Orders"].ToString());
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
            strSql.Append("select  1 as A,ID,Name,Sn,IsUse,IsEnd,SizeTypeID,Orders ");
            strSql.Append(" FROM Size order by Orders");
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
            strSql.Append(" ID,Name,Sn,IsUse,IsEnd,SizeTypeID,Orders ");
            strSql.Append(" FROM Size ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 查找某个尺码的ID
        /// </summary>
        /// <param name="CName"></param>
        /// <returns></returns>
        public int GetID(string SName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select ID from Size Where (Name=@Name)");
            SqlParameter[] sps = { new SqlParameter("@Name", SName) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return int.Parse(o.ToString());
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
			parameters[0].Value = "Size";
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

