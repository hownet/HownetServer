using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类DayWorkingInfo。
	/// </summary>
	public class DayWorkingInfo
	{
		public DayWorkingInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "DayWorkingInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DayWorkingInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.DayWorkingInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DayWorkingInfo(");
            strSql.Append("MainID,WorkingID,Amount,Price,Money,Remark,EmployeeID)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@WorkingID,@Amount,@Price,@Money,@Remark,@EmployeeID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.WorkingID;
            parameters[2].Value = model.Amount;
            parameters[3].Value = model.Price;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.Remark;
            parameters[6].Value = model.EmployeeID;

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
        public void Update(Hownet.Model.DayWorkingInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DayWorkingInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("WorkingID=@WorkingID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Price=@Price,");
            strSql.Append("Money=@Money,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("EmployeeID=@EmployeeID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.WorkingID;
            parameters[3].Value = model.Amount;
            parameters[4].Value = model.Price;
            parameters[5].Value = model.Money;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.EmployeeID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DayWorkingInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.DayWorkingInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,WorkingID,Amount,Price,Money,Remark,EmployeeID from DayWorkingInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.DayWorkingInfo model = new Hownet.Model.DayWorkingInfo();
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
                if (ds.Tables[0].Rows[0]["WorkingID"].ToString() != "")
                {
                    model.WorkingID = int.Parse(ds.Tables[0].Rows[0]["WorkingID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
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
            strSql.Append("select 1 as A,ID,MainID,WorkingID,Amount,Price,Money,Remark,EmployeeID ");
            strSql.Append(" FROM DayWorkingInfo ");
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
            strSql.Append(" ID,MainID,WorkingID,Amount,Price,Money,Remark,EmployeeID ");
            strSql.Append(" FROM DayWorkingInfo ");
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
            strSql.Append("delete DayWorkingInfo ");
            strSql.Append(" where MainID=@MainID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetViews(DateTime DateOne, DateTime DateTwo, int EmployeeID, bool IsInfo, int WorkingID)
        {
            DateTime dtt = DateTwo.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            if (IsInfo)
            {
                strSql.Append(" SELECT   DayWorking.DateTime, DayWorkingInfo.EmployeeID, DayWorkingInfo.WorkingID, DayWorkingInfo.Price, ");
                strSql.Append(" MiniEmp.Name AS EmpName,MiniEmp.DepartmentID,");
                strSql.Append(" DayWorkingInfo.Amount, DayWorkingInfo.Money FROM  DayWorking INNER JOIN DayWorkingInfo ON DayWorking.ID ");
                strSql.Append(" = DayWorkingInfo.MainID INNER JOIN MiniEmp ON DayWorkingInfo.EmployeeID = MiniEmp.ID ");
                strSql.Append(" WHERE   (DayWorking.DateTime >= @dtOne) AND (DayWorking.DateTime < @dtTwo) AND (DayWorking.IsVerify > 2) ");
                if (EmployeeID > 0)
                    strSql.Append(" AND  (DayWorkingInfo.EmployeeID = @EmployeeID) ");
                if (WorkingID > 0)
                    strSql.Append(" AND  (DayWorkingInfo.WorkingID = @WorkingID) ");
                strSql.Append(" ORDER BY MiniEmp.Name, DayWorkingInfo.WorkingID");
            }
            else
            {
                strSql.Append("SELECT   DayWorkingInfo.EmployeeID, DayWorkingInfo.WorkingID, DayWorkingInfo.Price, DayWorkingInfo.Amount, ");
                strSql.Append(" SUM(DayWorkingInfo.Money) AS Money,MiniEmp.Name AS EmpName,MiniEmp.DepartmentID FROM      DayWorking INNER JOIN DayWorkingInfo ON DayWorking.ID = ");
                strSql.Append(" DayWorkingInfo.MainID INNER JOIN MiniEmp ON DayWorkingInfo.EmployeeID = MiniEmp.ID  WHERE   (DayWorking.IsVerify > 2) AND (DayWorking.DateTime >= @dtOne) AND ");
                strSql.Append(" (DayWorking.DateTime < @dtTwo) ");
                if (EmployeeID > 0)
                    strSql.Append(" AND (DayWorkingInfo.EmployeeID = @EmployeeID) ");
                if (WorkingID > 0)
                    strSql.Append(" AND  (DayWorkingInfo.WorkingID = @WorkingID) ");
                strSql.Append(" GROUP BY DayWorkingInfo.EmployeeID, DayWorkingInfo.WorkingID, DayWorkingInfo.Price, DayWorkingInfo.Amount,MiniEmp.Name,MiniEmp.DepartmentID ");
                strSql.Append(" ORDER BY MiniEmp.Name, DayWorkingInfo.WorkingID");
            }
            SqlParameter[] sqs = { new SqlParameter("@dtOne", DateOne), new SqlParameter("@dtTwo", dtt), new SqlParameter("@EmployeeID", EmployeeID),
                                 new SqlParameter("@WorkingID",WorkingID)};
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
			parameters[0].Value = "DayWorkingInfo";
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

