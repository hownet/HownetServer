using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类PaySum。
	/// </summary>
	public class PaySum
	{
		public PaySum()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "PaySum"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PaySum");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.PaySum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PaySum(");
			strSql.Append("MaterielID,WorkingID,Amount,Price,DateTime,EmployeeID,PayMainID)");
			strSql.Append(" values (");
			strSql.Append("@MaterielID,@WorkingID,@Amount,@Price,@DateTime,@EmployeeID,@PayMainID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@PayMainID", SqlDbType.Int,4)};
			parameters[0].Value = model.MaterielID;
			parameters[1].Value = model.WorkingID;
			parameters[2].Value = model.Amount;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.DateTime;
			parameters[5].Value = model.EmployeeID;
			parameters[6].Value = model.PayMainID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public void Update(Hownet.Model.PaySum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PaySum set ");
			strSql.Append("MaterielID=@MaterielID,");
			strSql.Append("WorkingID=@WorkingID,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("Price=@Price,");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("EmployeeID=@EmployeeID,");
			strSql.Append("PayMainID=@PayMainID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Money,8),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@PayMainID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MaterielID;
			parameters[2].Value = model.WorkingID;
			parameters[3].Value = model.Amount;
			parameters[4].Value = model.Price;
			parameters[5].Value = model.DateTime;
			parameters[6].Value = model.EmployeeID;
			parameters[7].Value = model.PayMainID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete PaySum ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.PaySum GetModel(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MaterielID,WorkingID,Amount,Price,DateTime,EmployeeID,PayMainID from PaySum ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.PaySum model=new Hownet.Model.PaySum();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MaterielID"].ToString()!="")
				{
					model.MaterielID=int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WorkingID"].ToString()!="")
				{
					model.WorkingID=int.Parse(ds.Tables[0].Rows[0]["WorkingID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Amount"].ToString()!="")
				{
					model.Amount=int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EmployeeID"].ToString()!="")
				{
					model.EmployeeID=int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PayMainID"].ToString()!="")
				{
					model.PayMainID=int.Parse(ds.Tables[0].Rows[0]["PayMainID"].ToString());
				}
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MaterielID,WorkingID,Amount,Price,DateTime,EmployeeID,PayMainID ");
			strSql.Append(" FROM PaySum ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 删除一次工资汇总数量
        /// </summary>
        /// <param name="MainID"></param>
        public void DelPay(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete PaySum ");
            strSql.Append(" where PayMainID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 返回两日期之间所录入工票及手工记录数量
        /// </summary>
        /// <param name="DateOne"></param>
        /// <param name="DateTwo"></param>
        /// <returns></returns>
        public DataSet SumAmount(DateTime DateOne, DateTime DateTwo)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT (SELECT WorkingName FROM Working WHERE (WorkingID = WorkticketInfo.WorkingID)) AS WorkName, (SELECT MaterielName FROM Materiel ");
            //strSql.Append(" WHERE (MaterielID = WorkticketInfo.MaterielID)) AS MaterielName, SUM(Amount)  AS Amount, (SELECT EmployeeName FROM Employee WHERE (EmployeeID = ");
            //strSql.Append(" WorkticketInfo.EmployeeID)) AS EmployeeName, (SELECT Sn FROM Employee AS Employee_1 WHERE (EmployeeID = WorkticketInfo.EmployeeID)) AS Sn, (SELECT DepartmentName ");
            //strSql.Append(" FROM Department WHERE (DepartmentID = (SELECT DepartmentID FROM Employee AS Employee_2 WHERE (EmployeeID = WorkticketInfo.EmployeeID)))) ");
            //strSql.Append(" AS DepartmentName FROM (SELECT EmployeeID, (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_2 WHERE (ProduceTaskID = (SELECT ProductTaskID ");
            //strSql.Append(" FROM WorkTicket WHERE (WorkTicketID = WorkticketInfo_3.MainID)))) AS MaterielID,  WorkingID, (SELECT Amount FROM WorkTicket AS WorkTicket_5 ");
            //strSql.Append(" WHERE (WorkTicketID = WorkticketInfo_3.MainID)) AS Amount FROM WorkticketInfo AS WorkticketInfo_3 WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) ");
            //strSql.Append(" UNION ALL SELECT EmployeeID, (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_1 WHERE (ProduceTaskID = (SELECT ProductTaskID FROM WorkTicket AS ");
            //strSql.Append(" WorkTicket_1 WHERE (WorkTicketID = (SELECT MainID FROM WorkticketInfo AS WorkticketInfo_2 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))))))  ");
            //strSql.Append(" AS MainID, (SELECT WorkingID FROM WorkticketInfo AS WorkticketInfo_1 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID)) AS WorkingID,  Amount ");
            //strSql.Append(" FROM WorkTicketBreak WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo))  AS WorkticketInfo GROUP BY EmployeeID, WorkingID, MaterielID");            
            strSql.Append(" SELECT (SELECT WorkingName FROM Working WHERE (WorkingID = WorkticketInfo.WorkingID)) AS WorkName,  (SELECT MaterielName FROM Materiel WHERE (MaterielID = ");
            strSql.Append(" WorkticketInfo.MaterielID)) AS MaterielName, SUM(Amount)  AS Amount, (SELECT EmployeeName FROM Employee WHERE (EmployeeID = WorkticketInfo.EmployeeID)) AS EmployeeName, ");
            strSql.Append(" (SELECT Sn FROM Employee AS Employee_1 WHERE (EmployeeID = WorkticketInfo.EmployeeID)) AS Sn, (SELECT DepartmentName FROM Department WHERE (DepartmentID = ");
            strSql.Append(" (SELECT DepartmentID FROM Employee AS Employee_2 WHERE (EmployeeID = WorkticketInfo.EmployeeID)))) AS DepartmentName FROM (SELECT EmployeeID, ");
            strSql.Append(" (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_2 WHERE (ProduceTaskID = (SELECT ProductTaskID FROM WorkTicket WHERE (WorkTicketID = ");
            strSql.Append(" WorkticketInfo_3.MainID)))) AS MaterielID,  WorkingID, (SELECT Amount FROM WorkTicket AS WorkTicket_5 WHERE (WorkTicketID = WorkticketInfo_3.MainID)) AS Amount ");
            strSql.Append(" FROM WorkticketInfo AS WorkticketInfo_3 WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) UNION ALL SELECT EmployeeID, (SELECT MaterielID ");
            strSql.Append(" FROM ProduceTaskMain AS ProduceTaskMain_1 WHERE (ProduceTaskID = (SELECT ProductTaskID FROM WorkTicket AS WorkTicket_1 WHERE (WorkTicketID = ");
            strSql.Append(" (SELECT MainID FROM WorkticketInfo AS WorkticketInfo_2 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))))))  AS MainID, (SELECT WorkingID ");
            strSql.Append(" FROM WorkticketInfo AS WorkticketInfo_1 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID)) AS WorkingID,  Amount FROM WorkTicketBreak WHERE (DateTime >= ");
            strSql.Append(" @DateOne) AND (DateTime <= @DateTwo) UNION ALL SELECT HandBackMain.EmployeeID, HandBackInfo.MaterielID,  HandBackInfo.WorkingID, HandBackInfo.Amount ");
            strSql.Append(" FROM HandBackInfo INNER JOIN HandBackMain ON HandBackInfo.MainID = HandBackMain.MainID WHERE (HandBackMain.DateTime >= @DateOne) AND ");
            strSql.Append(" (HandBackMain.DateTime <= @DateTwo)) AS WorkticketInfo GROUP BY EmployeeID, WorkingID, MaterielID");
            SqlParameter[] sqs ={ new SqlParameter("@DateOne", DateOne), new SqlParameter("@DateTwo", DateTwo) };
            return DbHelperSQL.Query(strSql.ToString(), sqs);
        }
        public DataSet SumAmountByPW(DateTime DateOne, DateTime DateTwo, int EmployeeID, bool IsInfo, int MaterielID, int WorkingID, bool SumColor,int DepID)
        {
            DateOne = DateOne.AddMilliseconds(-1);
            DateTime dtt = DateTwo.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT (SELECT WorkingName FROM Working WHERE (WorkingID = WorkticketInfo.WorkingID)) AS WorkName, ");
            //strSql.Append(" (SELECT MaterielName FROM Materiel WHERE (MaterielID = WorkticketInfo.MaterielID)) AS MaterielName, SUM(Amount) ");
            //strSql.Append(" AS Amount, (SELECT EmployeeName FROM Employee WHERE (EmployeeID = WorkticketInfo.EmployeeID)) AS EmployeeName, ");
            //strSql.Append(" (SELECT Sn FROM Employee AS Employee_1 WHERE (EmployeeID = WorkticketInfo.EmployeeID)) AS Sn, (SELECT DepartmentName ");
            //strSql.Append(" FROM Department WHERE (DepartmentID = (SELECT DepartmentID FROM Employee AS Employee_2 WHERE (EmployeeID = WorkticketInfo.EmployeeID))))  ");
            //strSql.Append(" AS DepartmentName, WorkingID FROM (SELECT EmployeeID, (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_2 ");
            //strSql.Append(" WHERE (ProduceTaskID = (SELECT ProductTaskID FROM WorkTicket WHERE (WorkTicketID = WorkticketInfo_3.MainID)))) AS MaterielID, ");
            //strSql.Append(" (SELECT WorkingID FROM ProductWorkingInfo WHERE (ProductWorkingID = WorkticketInfo_3.WorkingID)) AS WorkingID, ");
            //strSql.Append(" (SELECT Amount FROM WorkTicket AS WorkTicket_5 WHERE (WorkTicketID = WorkticketInfo_3.MainID)) AS Amount ");
            //strSql.Append(" FROM WorkticketInfo AS WorkticketInfo_3 WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) UNION ALL ");
            //strSql.Append(" SELECT EmployeeID, (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_1 WHERE (ProduceTaskID = (SELECT ProductTaskID ");
            //strSql.Append(" FROM WorkTicket AS WorkTicket_1 WHERE (WorkTicketID = (SELECT MainID FROM WorkticketInfo AS WorkticketInfo_2 ");
            //strSql.Append(" WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))))))  AS MainID, (SELECT WorkingID FROM ProductWorkingInfo AS ProductWorkingInfo_1 ");
            //strSql.Append(" WHERE (ProductWorkingID = (SELECT WorkingID FROM WorkticketInfo AS WorkticketInfo_1 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))))  ");
            //strSql.Append(" AS WorkingID, Amount FROM WorkTicketBreak WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) UNION ALL ");
            //strSql.Append(" SELECT HandBackMain.EmployeeID, HandBackInfo.MaterielID, (SELECT WorkingID FROM ProductWorkingInfo AS ProductWorkingInfo_2 ");
            //strSql.Append(" WHERE (ProductWorkingID = HandBackInfo.WorkingID)) AS WorkingID, HandBackInfo.Amount FROM HandBackInfo INNER JOIN ");
            //strSql.Append(" HandBackMain ON HandBackInfo.MainID = HandBackMain.MainID WHERE (HandBackMain.DateTime >= @DateOne) AND ");
            //strSql.Append(" (HandBackMain.DateTime <= @DateTwo)) AS WorkticketInfo GROUP BY EmployeeID, WorkingID, MaterielID");
            if (IsInfo)
            {
                //strSql.Append("SELECT PayInfo.WorkticketInfoID, PayInfo.ID,cast(0 as bit) as IsSelect, PayInfo.EmployeeID, MiniEmp_1.Sn, PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.Amount,PayInfo.ColorID,PayInfo.SizeID, MiniEmp_1.DepartmentID, ");
                //strSql.Append(" MiniEmp_1.Name AS EmpName, PayInfo.BoxNum, PayInfo.DateTime FROM      PayInfo INNER JOIN MiniEmp AS MiniEmp_1 ON ");
                //strSql.Append(" PayInfo.EmployeeID = MiniEmp_1.ID ");
                //strSql.Append(" SELECT   PayInfo.WorkticketInfoID, PayInfo.ID, CAST(0 AS bit) AS IsSelect, PayInfo.EmployeeID, MiniEmp_1.Sn,  ");
                //strSql.Append(" PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.Amount, PayInfo.ColorID, PayInfo.SizeID, MiniEmp_1.DepartmentID, ");
                //strSql.Append(" MiniEmp_1.Name AS EmpName, PayInfo.BoxNum, PayInfo.DateTime, ProductWorkingInfo.Price, ");
                //strSql.Append(" PayInfo.Amount * ProductWorkingInfo.Price AS Money FROM      PayInfo INNER JOIN ");
                //strSql.Append(" MiniEmp AS MiniEmp_1 ON PayInfo.EmployeeID = MiniEmp_1.ID LEFT OUTER JOIN ");
                //strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID ");
                strSql.Append(" SELECT   PayInfo.WorkticketInfoID, PayInfo.ID, CAST(0 AS bit) AS IsSelect, PayInfo.EmployeeID, MiniEmp_1.Sn,  ");
                strSql.Append(" PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.Amount, PayInfo.ColorID, PayInfo.SizeID, MiniEmp_1.DepartmentID, ");
                strSql.Append(" MiniEmp_1.Name AS EmpName, PayInfo.BoxNum, PayInfo.DateTime, ProductWorkingInfo.Price, PayInfo.Amount * ProductWorkingInfo.Price AS Money, ProductTaskMain.BedNO,ProductTaskMain.Num ");
                strSql.Append(" FROM      ProductWorkingInfo RIGHT OUTER JOIN PayInfo INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo.EmployeeID = MiniEmp_1.ID LEFT OUTER JOIN ");
                strSql.Append(" ProductTaskMain INNER JOIN WorkTicketInfo ON ProductTaskMain.ID = WorkTicketInfo.TaskID ON PayInfo.WorkticketInfoID = WorkTicketInfo.ID ON ProductWorkingInfo.ID = PayInfo.ProductWorkingID");
                strSql.Append(" WHERE   (PayInfo.DateTime >= @dtOne) AND (PayInfo.DateTime < @dtTwo) ");
                if (DepID > 0)
                    strSql.Append(" And (MiniEmp_1.DepartmentID=" + DepID + ")");
                if (EmployeeID > 0)
                    strSql.Append(" AND (PayInfo.EmployeeID = @EmployeeID) ");
                if (MaterielID > 0)
                    strSql.Append(" AND (PayInfo.MaterielID = @MaterielID) ");
                if (WorkingID > 0)
                    strSql.Append(" AND (PayInfo.WorkingID = @WorkingID) ");
                strSql.Append(" ORDER BY PayInfo.EmployeeID, PayInfo.MaterielID, PayInfo.WorkingID, PayInfo.BoxNum, PayInfo.DateTime");
            }
            else
            {
                //strSql.Append(" SELECT   PayInfo.EmployeeID, MiniEmp_1.Sn, PayInfo.WorkingID, PayInfo.MaterielID, SUM(PayInfo.Amount) AS Amount, ");
                //strSql.Append(" MiniEmp_1.DepartmentID, MiniEmp_1.Name AS EmpName FROM      PayInfo INNER JOIN MiniEmp AS MiniEmp_1 ON ");
                //strSql.Append(" PayInfo.EmployeeID = MiniEmp_1.ID ");
                strSql.Append(" SELECT   PayInfo.EmployeeID, MiniEmp_1.Sn, PayInfo.WorkingID, PayInfo.MaterielID, SUM(PayInfo.Amount) AS Amount,  ");
                strSql.Append(" MiniEmp_1.DepartmentID, MiniEmp_1.Name AS EmpName, ProductWorkingInfo.Price,  ProductWorkingInfo.Price * SUM(PayInfo.Amount) AS Money, ProductTaskMain.Num ");
                if (SumColor)
                    strSql.Append(", PayInfo.ColorID ");
                strSql.Append(" FROM       ProductTaskMain INNER JOIN WorkTicketInfo ON ProductTaskMain.ID = WorkTicketInfo.TaskID RIGHT OUTER JOIN ");
                strSql.Append("PayInfo INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo.EmployeeID = MiniEmp_1.ID ON WorkTicketInfo.ID = PayInfo.WorkticketInfoID LEFT OUTER JOIN ");
                strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID ");
                strSql.Append(" WHERE   (PayInfo.DateTime >= @dtOne) AND (PayInfo.DateTime < @dtTwo)  ");
                if (DepID > 0)
                    strSql.Append(" And (MiniEmp_1.DepartmentID=" + DepID + ")");
                if (EmployeeID > 0)
                    strSql.Append(" AND (PayInfo.EmployeeID = @EmployeeID) ");
                if (MaterielID > 0)
                    strSql.Append(" AND (PayInfo.MaterielID = @MaterielID) ");
                if (WorkingID > 0)
                    strSql.Append(" AND (PayInfo.WorkingID = @WorkingID) ");
                strSql.Append(" GROUP BY PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, MiniEmp_1.DepartmentID, MiniEmp_1.Name, MiniEmp_1.Sn , ProductWorkingInfo.Price, ProductTaskMain.Num");
                if (SumColor)
                    strSql.Append(", PayInfo.ColorID ");
                strSql.Append(" ORDER BY PayInfo.EmployeeID, PayInfo.MaterielID, PayInfo.WorkingID ");
            }
            SqlParameter[] sqs = { new SqlParameter("@dtOne", DateOne), new SqlParameter("@dtTwo", dtt), new SqlParameter("@EmployeeID", EmployeeID),
                                 new SqlParameter("@MaterielID",MaterielID),new SqlParameter("@WorkingID",WorkingID)};
            return DbHelperSQL.Query(strSql.ToString(), sqs);
        }
        public DataSet GetSumAmountByPW(DateTime DateOne, DateTime DateTwo,bool SumColor )
        {
            DateTime dtt = DateTwo.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   PayInfo.WorkingID, PayInfo.MaterielID, SUM(PayInfo.Amount) AS Amount, ProductWorkingInfo.Price, ");
            strSql.Append(" ProductWorkingInfo.Price * SUM(PayInfo.Amount) AS Money ");
            if (SumColor)
                strSql.Append(", PayInfo.ColorID ");
            strSql.Append(" FROM      PayInfo LEFT OUTER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID WHERE   (PayInfo.DateTime >= @dtOne) AND ");
            strSql.Append(" (PayInfo.DateTime < @dtTwo) GROUP BY PayInfo.WorkingID, PayInfo.MaterielID, ProductWorkingInfo.Price ");
            if (SumColor)
                strSql.Append(", PayInfo.ColorID ");
            strSql.Append(" ORDER BY PayInfo.MaterielID, PayInfo.WorkingID");
            SqlParameter[] sqs = { new SqlParameter("@dtOne", DateOne), new SqlParameter("@dtTwo", dtt)};
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
			parameters[0].Value = "PaySum";
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

