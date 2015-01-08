using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类HandBackInfo。
	/// </summary>
	public class HandBackInfo
	{
		public HandBackInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("InfoID", "HandBackInfo"); 
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int InfoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from HandBackInfo");
            strSql.Append(" where InfoID=@InfoID ");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)};
            parameters[0].Value = InfoID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.HandBackInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into HandBackInfo(");
            strSql.Append("MainID,MaterielID,WorkingID,Amount,Price,Money,PriceID,EmployeeID,DateTime)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@MaterielID,@WorkingID,@Amount,@Price,@Money,@PriceID,@EmployeeID,@DateTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PriceID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.WorkingID;
            parameters[3].Value = model.Amount;
            parameters[4].Value = model.Price;
            parameters[5].Value = model.Money;
            parameters[6].Value = model.PriceID;
            parameters[7].Value = model.EmployeeID;
            parameters[8].Value = model.DateTime;

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
        public bool Update(Hownet.Model.HandBackInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update HandBackInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("WorkingID=@WorkingID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Price=@Price,");
            strSql.Append("Money=@Money,");
            strSql.Append("PriceID=@PriceID,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("DateTime=@DateTime");
            strSql.Append(" where InfoID=@InfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@PriceID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@InfoID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.WorkingID;
            parameters[3].Value = model.Amount;
            parameters[4].Value = model.Price;
            parameters[5].Value = model.Money;
            parameters[6].Value = model.PriceID;
            parameters[7].Value = model.EmployeeID;
            parameters[8].Value = model.DateTime;
            parameters[9].Value = model.InfoID;

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
        public bool Delete(int InfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from HandBackInfo ");
            strSql.Append(" where InfoID=@InfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)
};
            parameters[0].Value = InfoID;

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
        public bool DeleteList(string InfoIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from HandBackInfo ");
            strSql.Append(" where InfoID in (" + InfoIDlist + ")  ");
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
        public Hownet.Model.HandBackInfo GetModel(int InfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 InfoID,MainID,MaterielID,WorkingID,Amount,Price,Money,PriceID,EmployeeID,DateTime from HandBackInfo ");
            strSql.Append(" where InfoID=@InfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)
};
            parameters[0].Value = InfoID;

            Hownet.Model.HandBackInfo model = new Hownet.Model.HandBackInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["InfoID"] != null && ds.Tables[0].Rows[0]["InfoID"].ToString() != "")
                {
                    model.InfoID = int.Parse(ds.Tables[0].Rows[0]["InfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["WorkingID"] != null && ds.Tables[0].Rows[0]["WorkingID"].ToString() != "")
                {
                    model.WorkingID = int.Parse(ds.Tables[0].Rows[0]["WorkingID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PriceID"] != null && ds.Tables[0].Rows[0]["PriceID"].ToString() != "")
                {
                    model.PriceID = int.Parse(ds.Tables[0].Rows[0]["PriceID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmployeeID"] != null && ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
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
            strSql.Append("select  1 as A,InfoID,MainID,MaterielID,WorkingID,Amount,Price,Money,PriceID,EmployeeID,DateTime, ");
            strSql.Append(" (SELECT ID FROM PayInfo WHERE ((BreakID*-1) = HandBackInfo.InfoID) ");
            strSql.Append(" AND (SizeID = 0)) AS PayInfoID");
            strSql.Append(" FROM HandBackInfo ");
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
            strSql.Append(" InfoID,MainID,MaterielID,WorkingID,Amount,Price,Money,PriceID,EmployeeID,DateTime ");
            strSql.Append(" FROM HandBackInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetList(string strWhere)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select InfoID,MainID,MaterielID,WorkingID,Amount,Price,Money,PriceID,1 as A, ");
        //    strSql.Append(" (SELECT ID FROM PayInfo WHERE ((BreakID*-1) = HandBackInfo.InfoID) ");
        //    strSql.Append(" AND (SizeID = 0)) AS PayInfoID");
        //    strSql.Append(" FROM HandBackInfo ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    return DbHelperSQL.Query(strSql.ToString());
        //}
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteByMainID(int MainID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete HandBackInfo ");
            strSql.Append(" where MainID=@MainID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetViews(DateTime DateOne, DateTime DateTwo, int EmployeeID, bool IsInfo, int MaterielID, int WorkingID)
        {
            DateTime dtt = DateTwo.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            if (IsInfo)
            {
                strSql.Append("SELECT   HandBackMain.DateTime, HandBackMain.EmployeeID, HandBackInfo.MaterielID, HandBackInfo.WorkingID, ");
                strSql.Append(" HandBackInfo.Amount,MiniEmp.Name AS EmpName,MiniEmp.DepartmentID FROM      HandBackInfo INNER JOIN ");
                strSql.Append(" HandBackMain ON HandBackInfo.MainID = HandBackMain.MainID INNER JOIN MiniEmp ON HandBackMain.EmployeeID = MiniEmp.ID ");
                strSql.Append(" WHERE   (HandBackMain.DateTime >= @dtOne) AND (HandBackMain.DateTime < @dtTwo) AND (HandBackMain.IsVerify > 2)");
                if (EmployeeID > 0)
                    strSql.Append(" AND (HandBackMain.EmployeeID = @EmployeeID)");
                if (MaterielID > 0)
                    strSql.Append(" AND (HandBackInfo.MaterielID = @MaterielID) ");
                if (WorkingID > 0)
                    strSql.Append(" And  (HandBackInfo.WorkingID = @WorkingID)");
                strSql.Append(" ORDER BY MiniEmp.Name, HandBackInfo.MaterielID, HandBackInfo.WorkingID ");
            }
            else
            {
                strSql.Append(" SELECT   HandBackMain.EmployeeID, HandBackInfo.MaterielID, HandBackInfo.WorkingID, HandBackInfo.Amount, ");
                strSql.Append(" MiniEmp.Name AS EmpName,MiniEmp.DepartmentID");
                strSql.Append(" FROM      HandBackInfo INNER JOIN HandBackMain ON HandBackInfo.MainID = HandBackMain.MainID ");
                strSql.Append(" INNER JOIN MiniEmp ON HandBackMain.EmployeeID = MiniEmp.ID ");
                strSql.Append(" WHERE   (HandBackMain.IsVerify > 2)  AND  (HandBackMain.DateTime >= @dtOne) AND (HandBackMain.DateTime < @dtTwo) ");
                  if (EmployeeID > 0)
                    strSql.Append(" AND (HandBackMain.EmployeeID = @EmployeeID)");
                if (MaterielID > 0)
                    strSql.Append(" AND (HandBackInfo.MaterielID = @MaterielID) ");
                if (WorkingID > 0)
                    strSql.Append(" And  (HandBackInfo.WorkingID = @WorkingID)");
                strSql.Append(" GROUP BY HandBackMain.EmployeeID, HandBackInfo.MaterielID, HandBackInfo.WorkingID, HandBackInfo.Amount,MiniEmp.Name,MiniEmp.DepartmentID ");
                strSql.Append(" ORDER BY MiniEmp.Name, HandBackInfo.MaterielID, HandBackInfo.WorkingID");
            }
            SqlParameter[] sqs = { new SqlParameter("@dtOne", DateOne), new SqlParameter("@dtTwo", dtt), new SqlParameter("@EmployeeID", EmployeeID),
                                 new SqlParameter("@MaterielID",MaterielID),new SqlParameter("@WorkingID",WorkingID)};
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
			parameters[0].Value = "HandBackInfo";
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

