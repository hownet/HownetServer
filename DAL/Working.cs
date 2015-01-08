using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Working。
	/// </summary>
	public class Working
	{
		public Working()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Working"); 
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Working model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Working(");
            strSql.Append("Name,Sn,WorkTypeID,Remark,IsUse,IsEnd,IsSpecial,Price)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Sn,@WorkTypeID,@Remark,@IsUse,@IsEnd,@IsSpecial,@Price)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsSpecial", SqlDbType.Bit,1),
					new SqlParameter("@Price", SqlDbType.Decimal,9)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Sn;
            parameters[2].Value = model.WorkTypeID;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.IsUse;
            parameters[5].Value = model.IsEnd;
            parameters[6].Value = model.IsSpecial;
            parameters[7].Value = model.Price;

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
        public void Update(Hownet.Model.Working model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Working set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Sn=@Sn,");
            strSql.Append("WorkTypeID=@WorkTypeID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("IsSpecial=@IsSpecial,");
            strSql.Append("Price=@Price");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsSpecial", SqlDbType.Bit,1),
					new SqlParameter("@Price", SqlDbType.Decimal,9)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Sn;
            parameters[3].Value = model.WorkTypeID;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.IsUse;
            parameters[6].Value = model.IsEnd;
            parameters[7].Value = model.IsSpecial;
            parameters[8].Value = model.Price;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Working ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.Working GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,Sn,WorkTypeID,Remark,IsUse,IsEnd,IsSpecial,Price from Working ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.Working model = new Hownet.Model.Working();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                model.Sn = ds.Tables[0].Rows[0]["Sn"].ToString();
                if (ds.Tables[0].Rows[0]["WorkTypeID"].ToString() != "")
                {
                    model.WorkTypeID = int.Parse(ds.Tables[0].Rows[0]["WorkTypeID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["IsUse"].ToString() != "")
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
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsSpecial"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsSpecial"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsSpecial"].ToString().ToLower() == "true"))
                    {
                        model.IsSpecial = true;
                    }
                    else
                    {
                        model.IsSpecial = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
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
            strSql.Append("select 1 as A,ID,Name,Sn,WorkTypeID,Remark,IsUse,IsEnd,IsSpecial,Price,Sn+Name as SnName ");
            strSql.Append(" FROM Working ");
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
            strSql.Append(" ID,Name,Sn,WorkTypeID,Remark,IsUse,IsEnd,IsSpecial,Price ");
            strSql.Append(" FROM Working ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public bool CheckCanDelete(int ID)
        {
            bool t = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(ID) AS Expr1 FROM      ProductWorkingInfo WHERE   (WorkingID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            if (Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps)) > 0)
            {
                t = false;
                return t;
            }
            strSql.Remove(0, strSql.Length);
            strSql.Append("SELECT   COUNT(ID) AS Expr1 FROM      DayWorkingInfo WHERE   (WorkingID = @ID)");
            if (Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps)) > 0)
            {
                t= false;
                return t;
            }
            return true;
        }
        public DataSet GetWorkintNotAmount(int WorkingID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Materiel.Name AS 款号, ProductTaskMain.DateTime AS 制单日期, ProductTaskMain.Num AS 制单编号,  ");
            strSql.Append(" ProductTaskMain.TicketDate AS 出卡日期, SUM(WorkTicketInfo.Amount) AS 未生产数量 FROM      Materiel INNER JOIN ");
            strSql.Append(" ProductTaskMain ON Materiel.ID = ProductTaskMain.MaterielID INNER JOIN WorkTicketInfo ON ProductTaskMain.ID = WorkTicketInfo.TaskID ");
            strSql.Append(" WHERE   (WorkTicketInfo.EmployeeID = 0) AND (WorkTicketInfo.WorkingID = @WorkingID) ");
            strSql.Append(" GROUP BY Materiel.Name, ProductTaskMain.DateTime, ProductTaskMain.TicketDate, ProductTaskMain.Num");
            SqlParameter[] sps = { new SqlParameter("@WorkingID", WorkingID )};
            return DbHelperSQL.Query(strSql.ToString(), sps);
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
			parameters[0].Value = "Working";
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

