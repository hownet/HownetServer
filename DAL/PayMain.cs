using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类PayMain。
	/// </summary>
	public class PayMain
	{
		public PayMain()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "PayMain"); 
		}

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PayMain");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.PayMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PayMain(");
            strSql.Append("DateTime,BegingDate,EndDate,Indexs,IsVerify,VerifyMan,VerifyDateTime,CaicType,Posting)");
            strSql.Append(" values (");
            strSql.Append("@DateTime,@BegingDate,@EndDate,@Indexs,@IsVerify,@VerifyMan,@VerifyDateTime,@CaicType,@Posting)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@BegingDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@Indexs", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDateTime", SqlDbType.DateTime),
					new SqlParameter("@CaicType", SqlDbType.Int,4),
					new SqlParameter("@Posting", SqlDbType.Int,4)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.BegingDate;
            parameters[2].Value = model.EndDate;
            parameters[3].Value = model.Indexs;
            parameters[4].Value = model.IsVerify;
            parameters[5].Value = model.VerifyMan;
            parameters[6].Value = model.VerifyDateTime;
            parameters[7].Value = model.CaicType;
            parameters[8].Value = model.Posting;

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
        public bool Update(Hownet.Model.PayMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PayMain set ");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("BegingDate=@BegingDate,");
            strSql.Append("EndDate=@EndDate,");
            strSql.Append("Indexs=@Indexs,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDateTime=@VerifyDateTime,");
            strSql.Append("CaicType=@CaicType,");
            strSql.Append("Posting=@Posting");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@BegingDate", SqlDbType.DateTime),
					new SqlParameter("@EndDate", SqlDbType.DateTime),
					new SqlParameter("@Indexs", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDateTime", SqlDbType.DateTime),
					new SqlParameter("@CaicType", SqlDbType.Int,4),
					new SqlParameter("@Posting", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.BegingDate;
            parameters[2].Value = model.EndDate;
            parameters[3].Value = model.Indexs;
            parameters[4].Value = model.IsVerify;
            parameters[5].Value = model.VerifyMan;
            parameters[6].Value = model.VerifyDateTime;
            parameters[7].Value = model.CaicType;
            parameters[8].Value = model.Posting;
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
        public bool Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayMain ");
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
            strSql.Append("delete from PayMain ");
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
        public Hownet.Model.PayMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DateTime,BegingDate,EndDate,Indexs,IsVerify,VerifyMan,VerifyDateTime,CaicType,Posting from PayMain ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.PayMain model = new Hownet.Model.PayMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BegingDate"] != null && ds.Tables[0].Rows[0]["BegingDate"].ToString() != "")
                {
                    model.BegingDate = DateTime.Parse(ds.Tables[0].Rows[0]["BegingDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EndDate"] != null && ds.Tables[0].Rows[0]["EndDate"].ToString() != "")
                {
                    model.EndDate = DateTime.Parse(ds.Tables[0].Rows[0]["EndDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Indexs"] != null && ds.Tables[0].Rows[0]["Indexs"].ToString() != "")
                {
                    model.Indexs = int.Parse(ds.Tables[0].Rows[0]["Indexs"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"] != null && ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"] != null && ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDateTime"] != null && ds.Tables[0].Rows[0]["VerifyDateTime"].ToString() != "")
                {
                    model.VerifyDateTime = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CaicType"] != null && ds.Tables[0].Rows[0]["CaicType"].ToString() != "")
                {
                    model.CaicType = int.Parse(ds.Tables[0].Rows[0]["CaicType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Posting"] != null && ds.Tables[0].Rows[0]["Posting"].ToString() != "")
                {
                    model.Posting = int.Parse(ds.Tables[0].Rows[0]["Posting"].ToString());
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
            strSql.Append("select  1 as A,ID,DateTime,BegingDate,EndDate,Indexs,IsVerify,VerifyMan,VerifyDateTime,CaicType,Posting ");
            strSql.Append(" FROM PayMain ");
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
            strSql.Append(" ID,DateTime,BegingDate,EndDate,Indexs,IsVerify,VerifyMan,VerifyDateTime,CaicType,Posting ");
            strSql.Append(" FROM PayMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 判断是否已审核完成
        /// </summary>
        /// <returns></returns>
        public bool NoEnd()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(ID) AS Expr1 FROM PayMain WHERE (IsVerify = 1)");
            object obj = DbHelperSQL.GetSingle(strSql.ToString());
            bool t = false;
            if (obj.ToString() == "0")
            {
                t = true;
            }
            return t;
        }
        /// <summary>
        /// 取得表最后一个ID值
        /// </summary>
        /// <returns></returns>
        public int GetLastID()
        {
            return DbHelperSQL.GetLastID("ID", "PayMain");
        }
        /// <summary>
        /// 取得新计算时工人工资及明细
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataSet GetTemPay(DateTime BeginDate, DateTime EndDate)
        {
            DataSet ds = new DataSet();
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT @DateOne AS BeginDate, @DateTwo AS EndDate, (SELECT EmployeeName FROM Employee WHERE (EmployeeID = SumPay.EmployeeID)) AS EmployeeName, (SELECT Sn FROM Employee AS Employee_3 ");
            strSql.Append(" WHERE (EmployeeID = SumPay.EmployeeID)) AS Sn, SumPay.Month, (SELECT DepartmentName FROM Department WHERE (DepartmentID = (SELECT DepartmentID FROM Employee AS Employee_2 ");
            strSql.Append(" WHERE (EmployeeID = SumPay.EmployeeID)))) AS DepartmentName,  Pay.LastRemain, SumPay.EmployeeID FROM (SELECT Pay_2.Remain AS LastRemain, Pay_2.EmployeeID FROM Pay AS Pay_2 INNER JOIN ");
            strSql.Append(" (SELECT MAX(DISTINCT Pay_1.ID) AS Expr1 FROM Pay AS Pay_1 INNER JOIN Employee AS Employee_1 ON  Pay_1.EmployeeID = Employee_1.EmployeeID WHERE (Employee_1.DimissionDate = ");
            strSql.Append(" CONVERT(DATETIME,  '1900-01-01 00:00:00', 102)) GROUP BY Pay_1.EmployeeID, Employee_1.EmployeeID) AS tem_1 ON  Pay_2.ID = tem_1.Expr1 GROUP BY Pay_2.Remain, Pay_2.EmployeeID) AS Pay ");
            strSql.Append(" RIGHT OUTER JOIN (SELECT SUM(Amount * Price) AS Month, EmployeeID FROM (SELECT SUM(Amount) AS Amount, EmployeeID, (SELECT Price FROM ProductWorkingInfo WHERE (WorkingID = ");
            strSql.Append(" WorkticketInfo.WorkingID) AND  (MainID = (SELECT ProduceWorkID FROM ProduceTaskMain WHERE (ProduceTaskID = WorkticketInfo.ProduceTaskID))))  AS Price FROM (SELECT EmployeeID, ");
            strSql.Append(" (SELECT ProductTaskID FROM WorkTicket WHERE (WorkTicketID = WorkticketInfo_3.MainID))  AS ProduceTaskID, WorkingID, (SELECT Amount FROM WorkTicket AS WorkTicket_5 WHERE (WorkTicketID ");
            strSql.Append(" = WorkticketInfo_3.MainID))  AS Amount FROM WorkticketInfo AS WorkticketInfo_3 WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) UNION ALL SELECT EmployeeID, (SELECT ProductTaskID ");
            strSql.Append(" FROM WorkTicket AS WorkTicket_1 WHERE (WorkTicketID = (SELECT MainID FROM WorkticketInfo AS WorkticketInfo_2 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID)))) AS MainID, ");
            strSql.Append(" (SELECT WorkingID FROM WorkticketInfo AS WorkticketInfo_1 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))  AS WorkingID, Amount FROM WorkTicketBreak WHERE (DateTime >= @DateOne) ");
            strSql.Append(" AND (DateTime <= @DateTwo))  AS WorkticketInfo GROUP BY EmployeeID, WorkingID, ProduceTaskID UNION ALL SELECT HandBackInfo.Amount, HandBackMain.EmployeeID,  HandBackInfo.Price ");
            strSql.Append(" FROM HandBackInfo INNER JOIN HandBackMain ON  HandBackInfo.MainID = HandBackMain.MainID WHERE (HandBackMain.DateTime >= @DateOne) AND  (HandBackMain.DateTime <= @DateTwo)) AS Month ");
            strSql.Append(" GROUP BY EmployeeID) AS SumPay ON Pay.EmployeeID = SumPay.EmployeeID");
            SqlParameter[] sps ={ new SqlParameter("@DateOne", BeginDate), new SqlParameter("@DateTwo", EndDate) };
            ds = DbHelperSQL.Query(strSql.ToString(), sps);
            ds.Tables[0].TableName = "Main";
            ds.Tables[0].Columns.Add("Repair", typeof(decimal));
            ds.Tables[0].Columns.Add("BoardWages", typeof(decimal));
            ds.Tables[0].Columns.Add("Payment", typeof(decimal));
            ds.Tables[0].Columns.Add("Fact", typeof(decimal));
            ds.Tables[0].Columns.Add("Remain", typeof(decimal));
            ds.Tables[0].Columns.Add("SumAmount",typeof(int));
            strSql.Remove(0, strSql.Length);
            //(select name from employee where (ID=tem.Employeeid)) as 员工姓名,
            //strSql.Append("SELECT EmployeeID, (SELECT EmployeeName FROM Employee WHERE (EmployeeID = WorkticketInfo.EmployeeID)) AS EmployeeName, ");
            //strSql.Append(" (SELECT MaterielName FROM Materiel WHERE (MaterielID = (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_1 ");
            //strSql.Append(" WHERE (ProduceTaskID = WorkticketInfo.ProduceTaskID))))  AS MaterielName, (SELECT WorkingName FROM Working ");
            //strSql.Append(" WHERE (WorkingID = WorkticketInfo.WorkingID)) AS WorkingName, WorkingID, (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_1 ");
            //strSql.Append(" WHERE (ProduceTaskID = WorkticketInfo.ProduceTaskID)) AS MaterielID, Amount,  Price, Amount * Price AS Money ");
            //strSql.Append(" FROM (SELECT employeeid, (SELECT Price FROM ProductWorkingInfo WHERE (WorkingID = WorkticketInfo_4.WorkingID) AND (MainID = ");
            //strSql.Append(" (SELECT ProduceWorkID FROM ProduceTaskMain WHERE (ProduceTaskID = WorkticketInfo_4.ProduceTaskID))))  AS Price, SUM(Amount) AS ");
            //strSql.Append(" Amount, ProduceTaskID, WorkingID FROM (SELECT EmployeeID, (SELECT ProductTaskID FROM WorkTicket WHERE (WorkTicketID = ");
            //strSql.Append(" WorkticketInfo_3.MainID))  AS ProduceTaskID, WorkingID, (SELECT Amount FROM WorkTicket AS WorkTicket_5 ");
            //strSql.Append(" WHERE (WorkTicketID = WorkticketInfo_3.MainID)) AS Amount FROM WorkticketInfo AS WorkticketInfo_3 ");
            //strSql.Append(" WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) UNION ALL SELECT EmployeeID, (SELECT ProductTaskID ");
            //strSql.Append(" FROM WorkTicket AS WorkTicket_1 WHERE (WorkTicketID = (SELECT MainID FROM WorkticketInfo AS WorkticketInfo_2 ");
            //strSql.Append(" WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))))  AS MainID, (SELECT WorkingID FROM WorkticketInfo AS WorkticketInfo_1 ");
            //strSql.Append(" WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))  AS WorkingID, Amount FROM WorkTicketBreak WHERE (DateTime >= @DateOne) ");
            //strSql.Append(" AND (DateTime <= @DateTwo))  AS WorkticketInfo_4 GROUP BY ProduceTaskID, WorkingID, EmployeeID) AS WorkticketInfo ");
            //strSql.Append(" GROUP BY EmployeeID, WorkingID, ProduceTaskID, Amount, Price, Amount * Price UNION ALL SELECT HandBackMain.EmployeeID, ");
            //strSql.Append(" (SELECT EmployeeName FROM Employee AS Employee_1 WHERE (EmployeeID = HandBackMain.EmployeeID)) AS EmployeeName, ");
            //strSql.Append(" (SELECT MaterielName FROM Materiel AS Materiel_1 WHERE (MaterielID = HandBackInfo.MaterielID)) AS MaterielName, ");
            //strSql.Append(" (SELECT WorkingName FROM Working AS Working_1 WHERE (WorkingID = HandBackInfo.WorkingID)) AS WorkingName, ");
            //strSql.Append(" HandBackInfo.WorkingID, HandBackInfo.MaterielID, HandBackInfo.Amount,  ProductWorkingInfo.Price,  ");
            //strSql.Append(" HandBackInfo.Amount * ProductWorkingInfo.Price AS Money FROM HandBackInfo INNER JOIN HandBackMain ON HandBackInfo.MainID ");
            //strSql.Append(" = HandBackMain.MainID INNER JOIN ProductWorkingInfo ON  HandBackInfo.PriceID = ProductWorkingInfo.ProductWorkingID ");
            //strSql.Append(" WHERE (HandBackMain.DateTime >= @DateOne) AND  (HandBackMain.DateTime <= @DateTwo)");
            strSql.Append("SELECT     EmployeeID, ");
            strSql.Append("                          (SELECT     EmployeeName ");
            strSql.Append("                            FROM          Employee ");
            strSql.Append("                            WHERE      (EmployeeID = Tem.EmployeeID)) AS EmployeeName, WorkingID, ");
            strSql.Append("                          (SELECT     WorkingName ");
            strSql.Append("                            FROM          Working ");
            strSql.Append("                            WHERE      (WorkingID = Tem.WorkingID)) AS WorkingName, MaterielID, ");
            strSql.Append("                          (SELECT     MaterielName ");
            strSql.Append("                            FROM          Materiel ");
            strSql.Append("                            WHERE      (MaterielID = Tem.MaterielID)) AS MaterielName, SUM(Amount) AS Amount, Price, SUM(Money) AS Money ");
            strSql.Append("FROM         (SELECT     CAST(EmployeeID AS int) AS EmployeeID, CAST(WorkingID AS int) AS WorkingID, ");
            strSql.Append("                                                  (SELECT     MaterielID ");
            strSql.Append("                                                    FROM          ProduceTaskMain AS ProduceTaskMain_1 ");
            strSql.Append("                                                    WHERE      (ProduceTaskID = WorkticketInfo.ProduceTaskID)) AS MaterielID, Amount, Price, Amount * Price AS Money ");
            strSql.Append("                       FROM          (SELECT     EmployeeID, ");
            strSql.Append("                                                                          (SELECT     Price ");
            strSql.Append("                                                                            FROM          ProductWorkingInfo ");
            strSql.Append("                                                                            WHERE      (WorkingID = WorkticketInfo_4.WorkingID) AND (MainID = ");
            strSql.Append("                                                                                                       (SELECT     ProduceWorkID ");
            strSql.Append("                                                                                                         FROM          ProduceTaskMain ");
            strSql.Append("                                                                                                         WHERE      (ProduceTaskID = WorkticketInfo_4.ProduceTaskID)))) AS Price, SUM(Amount) AS Amount, ProduceTaskID,  ");
            strSql.Append("                                                                      WorkingID ");
            strSql.Append("                                               FROM          (SELECT     EmployeeID, ");
            strSql.Append("                                                                                                  (SELECT     ProductTaskID ");
            strSql.Append("                                                                                                    FROM          Workticket ");
            strSql.Append("                                                                                                    WHERE      (WorkTicketID = WorkticketInfo_3.MainID)) AS ProduceTaskID, WorkingID, ");
            strSql.Append("                                                                                                  (SELECT     Amount ");
            strSql.Append("                                                                                                    FROM          Workticket AS WorkTicket_5 ");
            strSql.Append("                                                                                                    WHERE      (WorkTicketID = WorkticketInfo_3.MainID)) AS Amount ");
            strSql.Append("                                                                       FROM          WorkticketInfo AS WorkticketInfo_3 ");
            strSql.Append("                                                                       WHERE      (DateTime >= @DateOne) AND (DateTime <= @DateTwo) ");
            strSql.Append("                                                                       UNION ALL ");
            strSql.Append("                                                                       SELECT     EmployeeID, ");
            strSql.Append("                                                                                                 (SELECT     ProductTaskID ");
            strSql.Append("                                                                                                   FROM          Workticket AS WorkTicket_1 ");
            strSql.Append("                                                                                                   WHERE      (WorkTicketID = ");
            strSql.Append("                                                                                                                              (SELECT     MainID ");
            strSql.Append("                                                                                                                                FROM          WorkticketInfo AS WorkticketInfo_2 ");
            strSql.Append("                                                                                                                                WHERE      (InfoID = WorkTicketBreak.WorkTicketInfoID)))) AS MainID, ");
            strSql.Append("                                                                                                 (SELECT     WorkingID ");
            strSql.Append("                                                                                                   FROM          WorkticketInfo AS WorkticketInfo_1 ");
            strSql.Append("                                                                                                   WHERE      (InfoID = WorkTicketBreak.WorkTicketInfoID)) AS WorkingID, Amount ");
            strSql.Append("                                                                       FROM         WorkTicketBreak ");
            strSql.Append("                                                                       WHERE     (DateTime >= @DateOne) AND (DateTime <= @DateTwo)) AS WorkticketInfo_4 ");
            strSql.Append("                                               GROUP BY ProduceTaskID, WorkingID, EmployeeID) AS WorkticketInfo ");
            strSql.Append("                       GROUP BY EmployeeID, WorkingID, ProduceTaskID, Amount, Price, Amount * Price ");
            strSql.Append("                       UNION ALL ");
            strSql.Append("                       SELECT     HandBackMain.EmployeeID, HandBackInfo.WorkingID, HandBackInfo.MaterielID, HandBackInfo.Amount, ProductWorkingInfo_1.Price,  ");
            strSql.Append("                                             HandBackInfo.Amount * ProductWorkingInfo_1.Price AS Money ");
            strSql.Append("                       FROM         HandBackInfo INNER JOIN ");
            strSql.Append("                                             HandBackMain ON HandBackInfo.MainID = HandBackMain.MainID INNER JOIN ");
            strSql.Append("                                             ProductWorkingInfo AS ProductWorkingInfo_1 ON HandBackInfo.PriceID = ProductWorkingInfo_1.ProductWorkingID ");
            strSql.Append("                       WHERE     (HandBackMain.DateTime >= @DateOne) AND (HandBackMain.DateTime <= @DateTwo)) AS Tem ");
            strSql.Append("GROUP BY EmployeeID, WorkingID, MaterielID, Price ");
            strSql.Append("ORDER BY EmployeeName, MaterielName, WorkingName ");

            DataSet dsInfo = DbHelperSQL.Query(strSql.ToString(), sps);
            dsInfo.Tables[0].TableName = "Info";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int employeeid = int.Parse(ds.Tables[0].Rows[i]["EmployeeID"].ToString());
                int amount = 0;
                for (int j = 0; j < dsInfo.Tables[0].Rows.Count; j++)
                {
                    if (int.Parse(dsInfo.Tables[0].Rows[j]["EmployeeID"].ToString()) == employeeid)
                    {
                        amount += int.Parse(dsInfo.Tables[0].Rows[j]["Amount"].ToString());
                    }
                }
                ds.Tables[0].Rows[i]["SumAmount"] = amount;
            }
            ds.Tables.Add(dsInfo.Tables[0].Copy());
            dsInfo.Clear();
            ds.Relations.Add("明细", ds.Tables["Main"].Columns["EmployeeID"], ds.Tables["Info"].Columns["EmployeeID"]);
            return ds;
        }
        public DataSet GetTemPayByPW(DateTime BeginDate, DateTime EndDate,int EmployeeID)
        {
            Hownet.DAL.SysTem dalST=new SysTem();
            Hownet.Model.SysTem modST = dalST.GetModel(dalST.GetMaxId() - 1);
            DataSet ds = new DataSet();
            DateTime dtt = EndDate.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT @DateOne AS BeginDate, @DateTwo AS EndDate, (SELECT EmployeeName FROM Employee WHERE (EmployeeID = SumPay.EmployeeID)) AS EmployeeName, (SELECT Sn FROM Employee AS Employee_3 ");
            //strSql.Append(" WHERE (EmployeeID = SumPay.EmployeeID)) AS Sn, SumPay.Month, (SELECT DepartmentName FROM Department WHERE (DepartmentID = (SELECT DepartmentID FROM Employee AS Employee_2 ");
            //strSql.Append(" WHERE (EmployeeID = SumPay.EmployeeID)))) AS DepartmentName,  Pay.LastRemain, SumPay.EmployeeID FROM (SELECT Pay_2.Remain AS LastRemain, Pay_2.EmployeeID FROM Pay AS Pay_2 INNER JOIN ");
            //strSql.Append(" (SELECT MAX(DISTINCT Pay_1.ID) AS Expr1 FROM Pay AS Pay_1 INNER JOIN Employee AS Employee_1 ON  Pay_1.EmployeeID = Employee_1.EmployeeID WHERE (Employee_1.DimissionDate = ");
            //strSql.Append(" CONVERT(DATETIME,  '1900-01-01 00:00:00', 102)) GROUP BY Pay_1.EmployeeID, Employee_1.EmployeeID) AS tem_1 ON  Pay_2.ID = tem_1.Expr1 GROUP BY Pay_2.Remain, Pay_2.EmployeeID) AS Pay ");
            //strSql.Append(" RIGHT OUTER JOIN (SELECT SUM(Amount * Price) AS Month, EmployeeID FROM (SELECT SUM(Amount) AS Amount, EmployeeID, (SELECT Price FROM ProductWorkingInfo WHERE (ProductWorkingID = ");
            //strSql.Append(" WorkticketInfo.WorkingID))  AS Price FROM (SELECT EmployeeID, ");
            //strSql.Append(" (SELECT ProductTaskID FROM WorkTicket WHERE (WorkTicketID = WorkticketInfo_3.MainID))  AS ProduceTaskID, WorkingID, (SELECT Amount FROM WorkTicket AS WorkTicket_5 WHERE (WorkTicketID ");
            //strSql.Append(" = WorkticketInfo_3.MainID))  AS Amount FROM WorkticketInfo AS WorkticketInfo_3 WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) UNION ALL SELECT EmployeeID, (SELECT ProductTaskID ");
            //strSql.Append(" FROM WorkTicket AS WorkTicket_1 WHERE (WorkTicketID = (SELECT MainID FROM WorkticketInfo AS WorkticketInfo_2 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID)))) AS MainID, ");
            //strSql.Append(" (SELECT WorkingID FROM WorkticketInfo AS WorkticketInfo_1 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))  AS WorkingID, Amount FROM WorkTicketBreak WHERE (DateTime >= @DateOne) ");
            //strSql.Append(" AND (DateTime <= @DateTwo))  AS WorkticketInfo GROUP BY EmployeeID, WorkingID, ProduceTaskID UNION ALL SELECT HandBackInfo.Amount, HandBackMain.EmployeeID,  HandBackInfo.Price ");
            //strSql.Append(" FROM HandBackInfo INNER JOIN HandBackMain ON  HandBackInfo.MainID = HandBackMain.MainID WHERE (HandBackMain.DateTime >= @DateOne) AND  (HandBackMain.DateTime <= @DateTwo)) AS Month ");
            //strSql.Append(" GROUP BY EmployeeID) AS SumPay ON Pay.EmployeeID = SumPay.EmployeeID");
            //strSql.Append("SELECT @DateOne AS BeginDate, @DateTwo AS EndDate, 3 AS A, 0 AS ID, (SELECT DepartmentName ");
            //strSql.Append(" FROM Department WHERE (DepartmentID = Employee_4.DepartmentID)) AS DepartmentName,  ");
            //strSql.Append(" Pay.LastRemain, (SELECT OtherTypeName FROM OtherType WHERE (OtherTypeID = Employee_4.PayID)) ");
            //strSql.Append(" AS PayName, SumPay.EmployeeID, SumPay.Month, Employee_4.EmployeeName, Employee_4.Sn, ");
            //strSql.Append(" Employee_4.LassMoney, Employee_4.Royalty, Employee_4.PayID FROM Employee AS Employee_4 INNER ");
            //strSql.Append(" JOIN (SELECT SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS Month,  PayInfo.EmployeeID ");
            //strSql.Append(" FROM PayInfo INNER JOIN ProductWorkingInfo ON PayInfo.ProductWorkingID = ");
            //strSql.Append(" ProductWorkingInfo.ProductWorkingID WHERE (PayInfo.DateTime >= @DateOne) AND ");
            //strSql.Append(" (PayInfo.DateTime < @Date) GROUP BY PayInfo.EmployeeID) AS SumPay ON Employee_4.EmployeeID ");
            //strSql.Append(" = SumPay.EmployeeID LEFT OUTER JOIN (SELECT Pay_2.Remain AS LastRemain, Pay_2.EmployeeID ");
            //strSql.Append(" FROM Pay AS Pay_2 INNER JOIN (SELECT MAX(DISTINCT Pay_1.ID) AS Expr1 FROM Pay AS Pay_1 INNER JOIN ");
            //strSql.Append(" Employee AS Employee_1 ON Pay_1.EmployeeID = Employee_1.EmployeeID WHERE (Employee_1.DimissionDate ");
            //strSql.Append(" = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) GROUP BY Pay_1.EmployeeID, Employee_1.EmployeeID) AS tem_1 ON  ");
            //strSql.Append(" Pay_2.ID = tem_1.Expr1 GROUP BY Pay_2.Remain, Pay_2.EmployeeID) AS Pay ON  SumPay.EmployeeID = Pay.EmployeeID");
            //strSql.Append(" SELECT   @DateOne AS BeginDate, @DateTwo AS EndDate, 3 AS A,0 as MainID,0 as IsEnd, 0 AS ID,Employee_4.PayID,Employee_4.LassMoney,Employee_4.Royalty, (SELECT   Name FROM      Deparment ");
            //strSql.Append(" WHERE   (ID = Employee_4.DepartmentID)) AS DepartmentName, Pay.LastRemain, SumPay.EmployeeID,  SumPay.Month, Employee_4.Name, Employee_4.Sn,Employee_4.Deposit ");
            //strSql.Append(" as AllDeposit,Employee_4.NeedDeposit,Employee_4.Deposit as TemDeposit ");
            //strSql.Append(" FROM      MiniEmp AS Employee_4 INNER JOIN (SELECT     SUM(Month) AS Month, EmployeeID FROM (SELECT SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS ");
            //strSql.Append(" Month, PayInfo.EmployeeID FROM PayInfo INNER JOIN ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID  WHERE (PayInfo.DateTime ");
            //strSql.Append(" >= @DateOne) AND (PayInfo.DateTime < @Date) AND (ProductWorkingInfo.IsCaiC = 1) ");
            //if(EmployeeID>0)
            //    strSql.Append(" And (PayInfo.EmployeeID=@EmployeeID )");
            //strSql.Append(" GROUP BY PayInfo.EmployeeID UNION ALL SELECT     SUM(Amount * Price) AS Month, EmployeeID FROM PayInfo AS PayInfo_1 WHERE (DateTime >= @DateOne) ");
            //strSql.Append(" AND (DateTime < @Date) AND (IsDay = 1) ");
            //if(EmployeeID>0)
            //    strSql.Append(" And (EmployeeID=@EmployeeID )"); 
            //strSql.Append(" GROUP BY EmployeeID) AS TTT GROUP BY EmployeeID) AS SumPay ON ");
            //strSql.Append(" FROM      MiniEmp AS Employee_4 INNER JOIN (SELECT   SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS Month, PayInfo.EmployeeID ");
            //strSql.Append(" FROM      PayInfo INNER JOIN ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID INNER JOIN MiniEmp AS ME ON PayInfo.EmployeeID = ME.ID ");
            //strSql.Append(" WHERE   (PayInfo.DateTime >= @DateOne) AND (PayInfo.DateTime < @Date) AND (ProductWorkingInfo.IsCaiC = 1) AND (NOT (ME.PayID IN (48, 49, 50))) ");
            //if (EmployeeID > 0)
            //        strSql.Append(" And (PayInfo.EmployeeID=@EmployeeID )");
            //strSql.Append(" GROUP BY PayInfo.EmployeeID UNION ALL SELECT     SUM(Amount * Price) AS Month, EmployeeID FROM PayInfo AS PayInfo_1 WHERE (DateTime >= @DateOne) ");
            //strSql.Append(" AND (DateTime < @Date) AND (IsDay = 1) ");
            //if (EmployeeID > 0)
            //    strSql.Append(" And (EmployeeID=@EmployeeID )");
            //strSql.Append(" GROUP BY EmployeeID) AS TTT GROUP BY EmployeeID) AS SumPay ON ");
            //strSql.Append(" Employee_4.ID = SumPay.EmployeeID LEFT OUTER JOIN (SELECT   Pay_2.Remain AS LastRemain, Pay_2.EmployeeID ");
            //strSql.Append(" FROM      Pay AS Pay_2 INNER JOIN (SELECT   MAX(DISTINCT Pay_1.ID) AS Expr1 FROM      Pay AS Pay_1 INNER JOIN ");
            //strSql.Append(" MiniEmp AS Employee_1 ON Pay_1.EmployeeID = Employee_1.ID WHERE   (Employee_1.DimDate IS NULL) "); 
            //strSql.Append(" GROUP BY Pay_1.EmployeeID, Employee_1.ID) AS tem_1 ON Pay_2.ID = tem_1.Expr1 GROUP BY Pay_2.Remain, Pay_2.EmployeeID) AS Pay ON SumPay.EmployeeID = Pay.EmployeeID");


            strSql.Append("SELECT   @DateOne AS BeginDate, @DateTwo AS EndDate, 3 AS A, 0 AS MainID, 0 AS IsEnd, 0 AS ID, Employee_4.PayID,  Employee_4.LassMoney, Employee_4.Royalty, ");
            strSql.Append("  Pay.LastRemain, SumPay.EmployeeID,  SumPay.Month,Employee_4.DepartmentID, ");
            strSql.Append(" Employee_4.Sn, Employee_4.Deposit AS AllDeposit, Employee_4.NeedDeposit, Employee_4.Deposit AS TemDeposit,Employee_4.BankNO,Employee_4.BankAccountName,Employee_4.BankName FROM      MiniEmp AS Employee_4 INNER JOIN ");
            strSql.Append(" (SELECT   SUM(Month) AS Month, EmployeeID FROM      (SELECT   SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS Month, PayInfo.EmployeeID FROM  PayInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID INNER JOIN MiniEmp AS ME ON PayInfo.EmployeeID = ME.ID WHERE   (PayInfo.DateTime >= @DateOne) ");
            strSql.Append(" AND (PayInfo.DateTime < @Date) ");
            if (!modST.IsTicketNotNeedCaic)
                strSql.Append("  AND  (ProductWorkingInfo.IsCaiC = 1) ");
            strSql.Append(" AND (NOT (ME.PayID IN (48, 49, 50))) ");
            if (EmployeeID > 0)
                    strSql.Append(" And (PayInfo.EmployeeID=@EmployeeID )");
            strSql.Append(" GROUP BY PayInfo.EmployeeID UNION ALL SELECT   SUM(Amount * Price) AS Month, EmployeeID FROM  PayInfo AS PayInfo_1 WHERE (DateTime >= @DateOne) ");
            strSql.Append(" AND (DateTime < @Date) AND (IsDay = 1) ");
              if (EmployeeID > 0)
                strSql.Append(" And (EmployeeID=@EmployeeID )");
            strSql.Append(" GROUP BY EmployeeID UNION ALL SELECT   LassMoney, ID FROM      MiniEmp WHERE   (PayID = 48) AND (DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) ");
            if(EmployeeID>0)
                strSql.Append("And  (ID=@EmployeeID )");
            strSql.Append(" ) AS TTT GROUP BY EmployeeID) AS SumPay ON Employee_4.ID = SumPay.EmployeeID LEFT OUTER JOIN (SELECT   Pay_2.Remain AS LastRemain, ");
            strSql.Append(" Pay_2.EmployeeID FROM      Pay AS Pay_2 INNER JOIN (SELECT   MAX(DISTINCT Pay_1.ID) AS Expr1 FROM      Pay AS Pay_1 INNER JOIN MiniEmp AS Employee_1 ON ");
            strSql.Append(" Pay_1.EmployeeID = Employee_1.ID WHERE   (Employee_1.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) GROUP BY Pay_1.EmployeeID, Employee_1.ID) AS tem_1 ON Pay_2.ID = tem_1.Expr1 ");
            strSql.Append(" GROUP BY Pay_2.Remain, Pay_2.EmployeeID) AS Pay ON SumPay.EmployeeID = Pay.EmployeeID ");
            strSql.Append(" WHERE   (Employee_4.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102))");
            SqlParameter[] sps = { new SqlParameter("@DateOne", BeginDate), new SqlParameter("@DateTwo", EndDate), new SqlParameter("@Date", dtt), new SqlParameter("@EmployeeID", EmployeeID) };
            ds = DbHelperSQL.Query(strSql.ToString(), sps);
            ds.Tables[0].TableName = "Main";
            ds.Tables[0].Columns.Add("Repair", typeof(decimal));
            ds.Tables[0].Columns.Add("BoardWages", typeof(decimal));
            ds.Tables[0].Columns.Add("Payment", typeof(decimal));
            ds.Tables[0].Columns.Add("Fact", typeof(decimal));
            ds.Tables[0].Columns.Add("Remain", typeof(decimal));
            ds.Tables[0].Columns.Add("SumAmount", typeof(int));
            strSql.Remove(0, strSql.Length);
            #region 
            //strSql.Append("SELECT EmployeeID, ");
            //strSql.Append("          (SELECT EmployeeName ");
            //strSql.Append("         FROM Employee ");
            //strSql.Append("         WHERE (EmployeeID = WorkticketInfo.EmployeeID)) AS EmployeeName,  ");
            //strSql.Append("      WorkingID, ");
            //strSql.Append("          (SELECT WorkingName ");
            //strSql.Append("         FROM Working ");
            //strSql.Append("         WHERE (WorkingID = WorkticketInfo.WorkingID)) AS WorkingName, MaterielID, ");
            //strSql.Append("          (SELECT MaterielName ");
            //strSql.Append("         FROM Materiel ");
            //strSql.Append("         WHERE (MaterielID = WorkticketInfo.MaterielID)) AS MaterielName, SUM(Amount)  ");
            //strSql.Append("      AS Amount, ");
            //strSql.Append("          (SELECT Price ");
            //strSql.Append("         FROM ProductWorkingInfo ");
            //strSql.Append("         WHERE (ProductWorkingID = WorkticketInfo.ttt)) AS Price ");
            //strSql.Append("FROM (SELECT EmployeeID, ");
            //strSql.Append("                  (SELECT MaterielID ");
            //strSql.Append("                 FROM ProduceTaskMain AS ProduceTaskMain_2 ");
            //strSql.Append("                 WHERE (ProduceTaskID = ");
            //strSql.Append("                           (SELECT ProductTaskID ");
            //strSql.Append("                          FROM WorkTicket ");
            //strSql.Append("                          WHERE (WorkTicketID = WorkticketInfo_3.MainID)))) AS MaterielID, ");
            //strSql.Append("                  (SELECT WorkingID ");
            //strSql.Append("                 FROM ProductWorkingInfo AS ProductWorkingInfo_3 ");
            //strSql.Append("                 WHERE (ProductWorkingID = WorkticketInfo_3.WorkingID)) AS WorkingID,  ");
            //strSql.Append("              WorkingID AS ttt, ");
            //strSql.Append("                  (SELECT Amount ");
            //strSql.Append("                 FROM WorkTicket AS WorkTicket_5 ");
            //strSql.Append("                 WHERE (WorkTicketID = WorkticketInfo_3.MainID)) AS Amount ");
            //strSql.Append("        FROM WorkticketInfo AS WorkticketInfo_3 ");
            //strSql.Append("        WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) ");
            //strSql.Append("        UNION ALL ");
            //strSql.Append("        SELECT EmployeeID, ");
            //strSql.Append("                  (SELECT MaterielID ");
            //strSql.Append("                 FROM ProduceTaskMain AS ProduceTaskMain_1 ");
            //strSql.Append("                 WHERE (ProduceTaskID = ");
            //strSql.Append("                           (SELECT ProductTaskID ");
            //strSql.Append("                          FROM WorkTicket AS WorkTicket_1 ");
            //strSql.Append("                          WHERE (WorkTicketID = ");
            //strSql.Append("                                    (SELECT MainID ");
            //strSql.Append("                                   FROM WorkticketInfo AS WorkticketInfo_2 ");
            //strSql.Append("                                   WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))))))  ");
            //strSql.Append("              AS MainID, ");
            //strSql.Append("                  (SELECT WorkingID ");
            //strSql.Append("                 FROM ProductWorkingInfo AS ProductWorkingInfo_1 ");
            //strSql.Append("                 WHERE (ProductWorkingID = ");
            //strSql.Append("                           (SELECT WorkingID ");
            //strSql.Append("                          FROM WorkticketInfo AS WorkticketInfo_1 ");
            //strSql.Append("                          WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))))  ");
            //strSql.Append("              AS WorkingID, ");
            //strSql.Append("                  (SELECT WorkingID ");
            //strSql.Append("                 FROM WorkticketInfo AS WorkticketInfo_1 ");
            //strSql.Append("                 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID)) AS ttt, Amount ");
            //strSql.Append("        FROM WorkTicketBreak ");
            //strSql.Append("        WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) ");
            //strSql.Append("        UNION ALL ");
            //strSql.Append("        SELECT HandBackMain.EmployeeID, HandBackInfo.MaterielID, ");
            //strSql.Append("                  (SELECT WorkingID ");
            //strSql.Append("                 FROM ProductWorkingInfo AS ProductWorkingInfo_2 ");
            //strSql.Append("                 WHERE (ProductWorkingID = HandBackInfo.WorkingID)) AS WorkingID,  ");
            //strSql.Append("              HandBackInfo.WorkingID AS ttt, HandBackInfo.Amount ");
            //strSql.Append("        FROM HandBackInfo INNER JOIN ");
            //strSql.Append("              HandBackMain ON HandBackInfo.MainID = HandBackMain.MainID ");
            //strSql.Append("        WHERE (HandBackMain.DateTime >= @DateOne) AND  ");
            //strSql.Append("              (HandBackMain.DateTime <= @DateTwo)) AS WorkticketInfo ");
            //strSql.Append("GROUP BY EmployeeID, WorkingID, MaterielID, ttt ");
            #endregion
            //strSql.Append(" SELECT EmployeeID, (SELECT EmployeeName FROM Employee WHERE (EmployeeID = ");
            //strSql.Append(" PayInfo.EmployeeID)) AS EmployeeName, WorkingID, (SELECT WorkingName FROM Working ");
            //strSql.Append(" WHERE (WorkingID = PayInfo.WorkingID)) AS WorkingName, MaterielID, (SELECT MaterielName ");
            //strSql.Append(" FROM Materiel WHERE (MaterielID = PayInfo.MaterielID)) AS MaterielName, SUM(Amount) ");
            //strSql.Append(" AS Amount, (SELECT Price FROM ProductWorkingInfo WHERE (ProductWorkingID = ");
            //strSql.Append(" PayInfo.ProductWorkingID)) AS Price FROM PayInfo WHERE (DateTime >= @DateOne) AND ");
            //strSql.Append(" (DateTime < @Date) ");
            //strSql.Append(" GROUP BY EmployeeID, WorkingID, MaterielID, ProductWorkingID");

            //strSql.Append(" SELECT   PayInfo.EmployeeID, (SELECT   Name FROM      MiniEmp WHERE   (ID = PayInfo.EmployeeID)) AS EmployeeName, ");
            //strSql.Append(" PayInfo.WorkingID, (SELECT   Name FROM      Working WHERE   (ID = PayInfo.WorkingID)) AS WorkingName, ");
            //strSql.Append(" PayInfo.MaterielID, (SELECT   Name FROM      Materiel WHERE   (ID = PayInfo.MaterielID)) AS MaterielName, ");
            //strSql.Append(" SUM(PayInfo.Amount) AS Amount, (SELECT   Price FROM      ProductWorkingInfo WHERE   (ID = PayInfo.ProductWorkingID)) ");
            //strSql.Append(" AS Price FROM      PayInfo INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON PayInfo.ProductWorkingID = ");
            //strSql.Append(" ProductWorkingInfo_1.ID WHERE   (PayInfo.DateTime >= @DateOne) AND (PayInfo.DateTime < @Date) AND ");
            //strSql.Append(" (ProductWorkingInfo_1.IsCaiC = 1) ");
            //if (EmployeeID > 0)
            //    strSql.Append(" AND  (PayInfo.EmployeeID = @EmployeeID) ");
            //strSql.Append(" GROUP BY PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.ProductWorkingID");
            
            //strSql.Append(" SELECT   PayInfo.EmployeeID, MiniEmp_1.Name AS EmployeeName, PayInfo.WorkingID, Working_1.Name AS WorkingName, PayInfo.MaterielID, ");
            //strSql.Append(" Materiel_1.Name AS MaterielName, SUM(PayInfo.Amount) AS Amount, (SELECT   Price FROM      ProductWorkingInfo WHERE   (ID = ");
            //strSql.Append(" PayInfo.ProductWorkingID)) AS Price FROM      PayInfo INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON PayInfo.ProductWorkingID ");
            //strSql.Append(" = ProductWorkingInfo_1.ID INNER JOIN Working AS Working_1 ON PayInfo.WorkingID = Working_1.ID INNER JOIN Materiel AS Materiel_1 ON ");
            //strSql.Append(" PayInfo.MaterielID = Materiel_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo.EmployeeID = MiniEmp_1.ID WHERE (PayInfo.DateTime >= @DateOne) ");
            //strSql.Append(" AND (PayInfo.DateTime < @Date) AND (ProductWorkingInfo_1.IsCaiC = 1) AND (NOT (MiniEmp_1.PayID IN (48, 49, 50)))");
            //if (EmployeeID > 0)
            //    strSql.Append(" AND (PayInfo.EmployeeID = @EmployeeID) ");
            //strSql.Append(" GROUP BY PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.ProductWorkingID, MiniEmp_1.Name,  Materiel_1.Name, Working_1.Name ");
            //strSql.Append(" UNION ALL SELECT   PayInfo_1.EmployeeID, MiniEmp_1.Name AS EmployeeName, PayInfo_1.WorkingID, Working_1.Name AS WorkingName, ");
            //strSql.Append(" PayInfo_1.MaterielID, '' AS MaterielName, SUM(PayInfo_1.Amount) AS Amount,  PayInfo_1.Price FROM      PayInfo AS PayInfo_1 INNER JOIN ");
            //strSql.Append(" Working AS Working_1 ON PayInfo_1.WorkingID = Working_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo_1.EmployeeID = MiniEmp_1.ID ");
            //strSql.Append(" WHERE   (PayInfo_1.DateTime >= @DateOne) AND (PayInfo_1.DateTime < @Date) ");
            //if (EmployeeID > 0)
            //    strSql.Append(" AND (PayInfo_1.EmployeeID = @EmployeeID) ");
            //strSql.Append(" AND (PayInfo_1.IsDay = 1) GROUP BY PayInfo_1.EmployeeID, PayInfo_1.WorkingID, PayInfo_1.MaterielID, PayInfo_1.ProductWorkingID, MiniEmp_1.Name, ");
            //strSql.Append(" Working_1.Name, PayInfo_1.Price");
            strSql.Append(" SELECT   PayInfo.EmployeeID,  PayInfo.WorkingID, PayInfo.MaterielID, ");
            strSql.Append("  SUM(PayInfo.Amount) AS Amount, (SELECT   Price FROM      ProductWorkingInfo WHERE   (ID = ");
            strSql.Append(" PayInfo.ProductWorkingID)) AS Price FROM      PayInfo INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON PayInfo.ProductWorkingID ");
            strSql.Append(" = ProductWorkingInfo_1.ID INNER JOIN Working AS Working_1 ON PayInfo.WorkingID = Working_1.ID INNER JOIN Materiel AS Materiel_1 ON ");
            strSql.Append(" PayInfo.MaterielID = Materiel_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo.EmployeeID = MiniEmp_1.ID WHERE (PayInfo.DateTime >= @DateOne) ");
            strSql.Append(" AND (PayInfo.DateTime < @Date) ");
            if (!modST.IsTicketNotNeedCaic)
                strSql.Append(" AND (ProductWorkingInfo_1.IsCaiC = 1) ");
            strSql.Append(" AND (NOT (MiniEmp_1.PayID IN (48, 49, 50)))");
            if (EmployeeID > 0)
                strSql.Append(" AND (PayInfo.EmployeeID = @EmployeeID) ");
            strSql.Append(" And (MiniEmp_1.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) ");
            strSql.Append(" GROUP BY PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.ProductWorkingID  ");
            strSql.Append(" UNION ALL SELECT   PayInfo_1.EmployeeID, PayInfo_1.WorkingID,  ");
            strSql.Append(" PayInfo_1.MaterielID, SUM(PayInfo_1.Amount) AS Amount,  PayInfo_1.Price FROM      PayInfo AS PayInfo_1 INNER JOIN ");
            strSql.Append(" Working AS Working_1 ON PayInfo_1.WorkingID = Working_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo_1.EmployeeID = MiniEmp_1.ID ");
            strSql.Append(" WHERE   (PayInfo_1.DateTime >= @DateOne) AND (PayInfo_1.DateTime < @Date) ");
            if (EmployeeID > 0)
                strSql.Append(" AND (PayInfo_1.EmployeeID = @EmployeeID) ");
            strSql.Append(" AND (PayInfo_1.IsDay = 1) And (MiniEmp_1.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) ");
            strSql.Append(" GROUP BY PayInfo_1.EmployeeID, PayInfo_1.WorkingID, PayInfo_1.MaterielID, PayInfo_1.ProductWorkingID,  ");
            strSql.Append("  PayInfo_1.Price");
            DataSet dsInfo = DbHelperSQL.Query(strSql.ToString(), sps);
            dsInfo.Tables[0].TableName = "Info";

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int employeeid = int.Parse(ds.Tables[0].Rows[i]["EmployeeID"].ToString());
                int amount = 0;
                for (int j = 0; j < dsInfo.Tables[0].Rows.Count; j++)
                {
                    if (int.Parse(dsInfo.Tables[0].Rows[j]["EmployeeID"].ToString()) == employeeid)
                    {
                        amount += int.Parse(dsInfo.Tables[0].Rows[j]["Amount"].ToString());
                    }
                }
                ds.Tables[0].Rows[i]["SumAmount"] = amount;
            }
            ds.Tables.Add(dsInfo.Tables[0].Copy());
            dsInfo.Clear();
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   PayInfo.EmployeeID,  PayInfo.WorkingID,  PayInfo.MaterielID, ");
            strSql.Append("  SUM(PayInfo.Amount) AS Amount, (SELECT   Price FROM      ProductWorkingInfo WHERE   (ID = ");
            strSql.Append(" PayInfo.ProductWorkingID)) AS Price FROM      PayInfo INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON PayInfo.ProductWorkingID ");
            strSql.Append(" = ProductWorkingInfo_1.ID INNER JOIN Working AS Working_1 ON PayInfo.WorkingID = Working_1.ID INNER JOIN Materiel AS Materiel_1 ON ");
            strSql.Append(" PayInfo.MaterielID = Materiel_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo.EmployeeID = MiniEmp_1.ID WHERE (PayInfo.DateTime >= @DateOne) ");
            strSql.Append(" AND (PayInfo.DateTime < @Date) AND (ProductWorkingInfo_1.IsCaiC = 1) AND (NOT (MiniEmp_1.PayID IN (48, 49, 50)))");
            strSql.Append("  AND  (',' + MiniEmp_1.DefaultWorkType + ',' NOT LIKE '%,' + CAST(Working_1.WorkTypeID AS nvarchar) + ',%') ");
            if (EmployeeID > 0)
                strSql.Append(" AND (PayInfo.EmployeeID = @EmployeeID) ");
            strSql.Append(" And (MiniEmp_1.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) ");
            strSql.Append(" GROUP BY PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.ProductWorkingID  ");
            //strSql.Append(" UNION ALL SELECT   PayInfo_1.EmployeeID,  PayInfo_1.WorkingID,  ");
            //strSql.Append(" PayInfo_1.MaterielID,  SUM(PayInfo_1.Amount) AS Amount,  PayInfo_1.Price FROM      PayInfo AS PayInfo_1 INNER JOIN ");
            //strSql.Append(" Working AS Working_1 ON PayInfo_1.WorkingID = Working_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo_1.EmployeeID = MiniEmp_1.ID ");
            //strSql.Append(" WHERE   (PayInfo_1.DateTime >= @DateOne) AND (PayInfo_1.DateTime < @Date) ");
            //strSql.Append("  AND  (',' + MiniEmp_1.DefaultWorkType + ',' NOT LIKE '%,' + CAST(Working_1.WorkTypeID AS nvarchar) + ',%') ");
            //if (EmployeeID > 0)
            //    strSql.Append(" AND (PayInfo_1.EmployeeID = @EmployeeID) ");
            //strSql.Append(" And (MiniEmp_1.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) ");
            //strSql.Append(" AND (PayInfo_1.IsDay = 1) GROUP BY PayInfo_1.EmployeeID, PayInfo_1.WorkingID, PayInfo_1.MaterielID, PayInfo_1.ProductWorkingID, ");
            //strSql.Append("  PayInfo_1.Price");
            DataTable dtNoDefault = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            dtNoDefault.TableName = "NoDefault";
            ds.Tables.Add(dtNoDefault.Copy());
            dtNoDefault.Clear();
            try
            {
                ds.Relations.Add("明细", ds.Tables["Main"].Columns["EmployeeID"], ds.Tables["Info"].Columns["EmployeeID"]);
            }
            catch (Exception ex)
            {
            }
            try
            {
                ds.Relations.Add("非默认工种", ds.Tables["Main"].Columns["EmployeeID"], ds.Tables["NoDefault"].Columns["EmployeeID"]);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }
        /// <summary>
        /// 取出没有工价的款号
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public SqlDataReader NoPrice(DateTime BeginDate, DateTime EndDate)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT Materiel.Name FROM Materiel INNER JOIN ProductWorking ON Materiel.ID = ProductWorking.MaterielID INNER JOIN ProduceTask ON Materiel.ID = ");
            strSql.Append(" ProduceTask.MaterielID INNER JOIN (SELECT Workticket.DepartmentTaskInfoID FROM WorkticketInfo INNER JOIN Workticket ON WorkticketInfo.WorkticketID = Workticket.ID ");
            strSql.Append(" WHERE (WorkticketInfo.DateTime >= @BeginDate) AND (WorkticketInfo.DateTime <= @EndDate) GROUP BY Workticket.DepartmentTaskInfoID) AS DTID ON ");
            strSql.Append(" ProduceTask.ID = DTID.DepartmentTaskInfoID WHERE (ProductWorking.Price <= 0) GROUP BY Materiel.Name");
            SqlParameter[] sps ={ new SqlParameter("@BeginDate", BeginDate), new SqlParameter("@EndDate", EndDate) };
            return DbHelperSQL.ExecuteReader(strSql.ToString(), sps);
        }
        /// <summary>
        /// 将工资汇总数据插入到数据库
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <param name="MainID"></param>
        public void PaySum(DateTime BeginDate, DateTime EndDate, int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" INSERT INTO PaySum (EmployeeID, MaterielID, WorkingID, Amount, Price, PayMainID) SELECT EmployeeID, (SELECT MaterielID FROM ProduceTaskMain AS ProduceTaskMain_1 ");
            strSql.Append(" WHERE (ProduceTaskID = WorkticketInfo.ProduceTaskID)) AS MaterielID,  WorkingID, Amount, Price, @MainID AS MainID FROM (SELECT employeeid, (SELECT Price ");
            strSql.Append(" FROM ProductWorkingInfo WHERE (WorkingID = WorkticketInfo_4.WorkingID) AND (MainID = (SELECT ProduceWorkID FROM ProduceTaskMain WHERE (ProduceTaskID = ");
            strSql.Append(" WorkticketInfo_4.ProduceTaskID))))  AS Price, SUM(Amount) AS Amount, ProduceTaskID, WorkingID FROM (SELECT EmployeeID, (SELECT ProductTaskID FROM WorkTicket ");
            strSql.Append(" WHERE (WorkTicketID = WorkticketInfo_3.MainID))  AS ProduceTaskID, WorkingID, (SELECT Amount FROM WorkTicket AS WorkTicket_5 WHERE (WorkTicketID = ");
            strSql.Append(" WorkticketInfo_3.MainID)) AS Amount FROM WorkticketInfo AS WorkticketInfo_3 WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo) UNION ALL SELECT EmployeeID, ");
            strSql.Append(" (SELECT ProductTaskID FROM WorkTicket AS WorkTicket_1 WHERE (WorkTicketID = (SELECT MainID FROM WorkticketInfo AS WorkticketInfo_2 WHERE (InfoID = ");
            strSql.Append(" WorkTicketBreak.WorkTicketInfoID))))  AS MainID, (SELECT WorkingID FROM WorkticketInfo AS WorkticketInfo_1 WHERE (InfoID = WorkTicketBreak.WorkTicketInfoID))  ");
            strSql.Append(" AS WorkingID, Amount FROM WorkTicketBreak WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo))  AS WorkticketInfo_4 GROUP BY ProduceTaskID, WorkingID, EmployeeID) AS WorkticketInfo");
            SqlParameter[] sps ={ new SqlParameter("@DateOne", BeginDate), new SqlParameter("@DateTwo", EndDate), new SqlParameter("@MainID", MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);

        }
        
       /// <summary>
       /// 将统计出的工资金额插入到工资总表
       /// </summary>
       /// <param name="MainID"></param>
        public void PayMoney(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO Pay (EmployeeID, LastRemain, Month, MainID) SELECT SumPay.EmployeeID, LastRemain.LastRemain, SumPay.Month,  SumPay.PayMainID FROM (SELECT PayMainID, ");
            strSql.Append(" EmployeeID, SUM(Price * Amount) AS Month FROM PaySum GROUP BY PayMainID, EmployeeID) AS SumPay LEFT OUTER JOIN (SELECT Pay_2.Remain AS LastRemain, Pay_2.EmployeeID ");
            strSql.Append(" FROM Pay AS Pay_2 INNER JOIN (SELECT MAX(DISTINCT Pay_1.ID) AS Expr1 FROM Pay AS Pay_1 INNER JOIN MiniEmp ON Pay_1.EmployeeID = MiniEmp.ID ");
            strSql.Append(" WHERE (MiniEmp.DimDate = CONVERT(DATETIME,  '1900-01-01 00:00:00', 102)) GROUP BY Pay_1.EmployeeID, MiniEmp.ID) AS tem ON  Pay_2.ID = tem.Expr1 ");
            strSql.Append(" GROUP BY Pay_2.Remain, Pay_2.EmployeeID) AS LastRemain ON  SumPay.EmployeeID = LastRemain.EmployeeID WHERE (SumPay.PayMainID = @MainID)");
            SqlParameter[] sps ={ new SqlParameter("@MainID", MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 更新工资余额
        /// </summary>
        /// <param name="MainID"></param>
        public void UpPay(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE Pay SET Remain = Month + LastRemain WHERE (MainID = @MainID)");
            SqlParameter[] sps ={ new SqlParameter("@MainID", MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 更新审核
        /// </summary>
        /// <param name="model"></param>
        public void UpLock(Hownet.Model.PayMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE PayMain SET IsVerify = @IsEnd, VerifyMan = @UserID, VerifyDateTime = @dt WHERE (ID = @ID)");
            SqlParameter[] sqs ={ new SqlParameter("@IsEnd", model.IsVerify),new SqlParameter("@UserID",model.VerifyMan),
                                    new SqlParameter("@dt",model.VerifyDateTime), new SqlParameter("@ID", model.ID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sqs);
        }
        /// <summary>
        /// 工资条列表
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPayLine(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT PayMain.BegingDate, PayMain.EndDate,(select Sn from employee As qwe where (employeeid=pay.Employeeid)) as Sn,");
            strSql.Append(" (SELECT DepartmentName FROM Department WHERE (DepartmentID = (SELECT DepartmentID FROM Employee ");
            strSql.Append(" WHERE (EmployeeID = Pay.EmployeeID)))) AS DepartmentName, (SELECT EmployeeName FROM Employee AS Employee_1 WHERE (EmployeeID = Pay.EmployeeID)) AS ");
            strSql.Append(" EmployeeName, Pay.Month,  Pay.LastRemain, Pay.Repair, Pay.BoardWages, Pay.Payment, Pay.Fact,  Pay.Remain FROM PayMain INNER JOIN Pay ON PayMain.ID = Pay.MainID ");
            strSql.Append(" WHERE (PayMain.ID = @MID) ORDER BY DepartmentName, Employee");
            SqlParameter[] sps = { new SqlParameter("@MID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回工资表明细带单价
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPayPrice(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT (SELECT EmployeeName FROM Employee WHERE (EmployeeID = Pay.EmployeeID)) AS Employee, (SELECT DepartmentName FROM Department WHERE (DepartmentID = ");
            strSql.Append(" (SELECT DepartmentID FROM Employee AS Employee_2 WHERE (EmployeeID = Pay.EmployeeID)))) AS DepartMentName, (SELECT Sn FROM Employee AS Employee_1 ");
            strSql.Append(" WHERE (EmployeeID = Pay.EmployeeID)) AS Sn, (SELECT MaterielName FROM Materiel WHERE (MaterielID = PaySum.MaterielID)) AS MaterielName, (SELECT WorkingName ");
            strSql.Append(" FROM Working WHERE (WorkingID = PaySum.WorkingID)) AS WorkName, PaySum.Amount,  PaySum.Price, PayMain.BegingDate, PayMain.EndDate, Pay.Remain, Pay.Month, ");
            strSql.Append(" Pay.Payment, Pay.BoardWages, Pay.Repair, Pay.LastRemain, Pay.Fact,  Pay.EmployeeID FROM PayMain INNER JOIN Pay ON PayMain.ID = Pay.MainID INNER JOIN ");
            strSql.Append(" PaySum ON PayMain.ID = PaySum.PayMainID AND Pay.EmployeeID = PaySum.EmployeeID WHERE (PayMain.ID = @mID) GROUP BY PayMain.BegingDate, PayMain.EndDate, ");
            strSql.Append(" Pay.EmployeeID, PaySum.MaterielID, PaySum.WorkingID, PaySum.Price, PaySum.Amount, Pay.Remain, Pay.Month, Pay.Payment, Pay.BoardWages, Pay.Repair, Pay.LastRemain, ");
            strSql.Append(" Pay.Fact ORDER BY Pay.EmployeeID");
            SqlParameter[] sps = { new SqlParameter("@mID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 工资统计数量明细表
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPayAmount(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT (SELECT EmployeeName FROM Employee WHERE (EmployeeID = PaySum.EmployeeID)) AS Employee, (SELECT DepartmentName FROM Department WHERE (DepartmentID = ");
            strSql.Append(" (SELECT DepartmentID FROM Employee AS Employee_2 WHERE (EmployeeID = PaySum.EmployeeID)))) AS DepartmentName, (SELECT Sn FROM Employee AS Employee_1 WHERE ");
            strSql.Append(" (EmployeeID = PaySum.EmployeeID)) AS Sn, (SELECT MaterielName FROM Materiel WHERE (MaterielID = PaySum.MaterielID)) AS MaterielName, (SELECT WorkingName ");
            strSql.Append(" FROM Working WHERE (WorkingID = PaySum.WorkingID)) AS WorkName, PaySum.Amount,  PayMain.BegingDate, PayMain.EndDate FROM PayMain INNER JOIN PaySum ON PayMain.ID ");
            strSql.Append(" = PaySum.PayMainID WHERE (PayMain.ID = @mID) GROUP BY PayMain.BegingDate, PayMain.EndDate, PaySum.MaterielID,  PaySum.WorkingID, PaySum.Amount, PaySum.EmployeeID ");
            strSql.Append(" ORDER BY PaySum.EmployeeID, PaySum.MaterielID, PaySum.WorkingID");
            SqlParameter[] sps = { new SqlParameter("@mID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from PayMain order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 标记手动回收是否已汇总
        /// </summary>
        /// <param name="dateOne">开始日期</param>
        /// <param name="dateTwo">截止日期</param>
        /// <param name="TypeID">0为未汇总，1为已汇总</param>
        public void UpHandIsEnd(DateTime dateOne, DateTime dateTwo, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE HandBackMain SET IsEnd = @TypeID ");
            strSql.Append(" WHERE (DateTime >= @DateOne) AND (DateTime <= @DateTwo)");
            SqlParameter[] sps = {new SqlParameter("@TypeID",TypeID),new SqlParameter("@DateOne",dateOne),
                                 new SqlParameter("@DateTwo",dateTwo)};
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetMoneyList(DateTime dtOne, DateTime dtTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   PayMain.BegingDate, PayMain.EndDate, (SELECT   Name FROM      MiniEmp WHERE   (ID = Pay.EmployeeID)) AS EmployeeName, Pay.Month ");
            strSql.Append(" FROM      Pay INNER JOIN PayMain ON Pay.MainID = PayMain.ID WHERE   (PayMain.BegingDate > @DateOne) AND (PayMain.EndDate < @DateTwo)");
            SqlParameter[] sps = { new SqlParameter("@DateOne", dtOne), new SqlParameter("@DateTwo", dtTwo) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public decimal GetCut(int EmployeeID, DateTime dtOne, DateTime dtTwo)
        {
            StringBuilder strSql = new StringBuilder();
            DateTime dtt = dtTwo.AddDays(1);
            strSql.Append(" SELECT   SUM(Month) AS Money FROM      (SELECT   SUM(PayInfo.Amount * ProductWorkingInfo.Price * MiniEmp.Royalty) AS Month ");
            strSql.Append(" FROM      PayInfo INNER JOIN ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID INNER JOIN MiniEmp ON ");
            strSql.Append(" PayInfo.EmployeeID = MiniEmp.ID WHERE   (PayInfo.DateTime >= @DateOne) AND (PayInfo.DateTime < @Date) AND  (PayInfo.EmployeeID ");
            strSql.Append(" = @EmployeeID) AND (ProductWorkingInfo.IsCaiC = 1) AND (ProductWorkingInfo.IsCut = 1) UNION ALL SELECT   SUM(PayInfo_1.Amount ");
            strSql.Append(" * ProductWorkingInfo_1.Price) AS Month FROM      PayInfo AS PayInfo_1 INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON ");
            strSql.Append(" PayInfo_1.ProductWorkingID = ProductWorkingInfo_1.ID WHERE   (PayInfo_1.DateTime >= @DateOne) AND (PayInfo_1.DateTime < @Date) AND  ");
            strSql.Append(" (PayInfo_1.EmployeeID = @EmployeeID) AND (ProductWorkingInfo_1.IsCaiC = 1) AND  (ProductWorkingInfo_1.IsCut = 0) UNION ALL ");
            strSql.Append(" SELECT   SUM(PayInfo_2.Amount * Working.Price) AS Month FROM      PayInfo AS PayInfo_2 INNER JOIN Working ON PayInfo_2.WorkingID ");
            strSql.Append(" = Working.ID WHERE   (PayInfo_2.DateTime >= @DateOne) AND (PayInfo_2.DateTime < @Date) AND (PayInfo_2.EmployeeID = @EmployeeID) ");
            strSql.Append(" AND (PayInfo_2.IsDay = 1)) AS Tem");
            SqlParameter[] sp = { new SqlParameter("@DateOne", dtOne), new SqlParameter("@Date", dtt), new SqlParameter("@EmployeeID", EmployeeID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sp);
            if (o == null)
                return 0;
            else
                return Convert.ToDecimal(o);
        }
        public void AddPS(DateTime BeginDate, DateTime EndDate,int MainID)
        {
            Hownet.DAL.SysTem dalST = new SysTem();
            Hownet.Model.SysTem modST = dalST.GetModel(dalST.GetMaxId() - 1);
            DateTime dtt = EndDate.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO PaySum (EmployeeID, WorkingID, MaterielID, Amount, Price, PayMainID) ");
            strSql.Append(" SELECT   Pay.EmployeeID, Pay.WorkingID, Pay.MaterielID, Pay.Amount, Pay.Price, @MainID AS Expr1 ");
            strSql.Append(" FROM      (SELECT   PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, SUM(PayInfo.Amount) AS Amount, ");
            strSql.Append(" (SELECT   Price FROM      ProductWorkingInfo WHERE   (ID = PayInfo.ProductWorkingID)) AS Price FROM ");
            strSql.Append(" PayInfo INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON  PayInfo.ProductWorkingID = ");
            strSql.Append(" ProductWorkingInfo_1.ID INNER JOIN Working AS Working_1 ON PayInfo.WorkingID = Working_1.ID INNER JOIN ");
            strSql.Append(" Materiel AS Materiel_1 ON PayInfo.MaterielID = Materiel_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON ");
            strSql.Append(" PayInfo.EmployeeID = MiniEmp_1.ID WHERE   (PayInfo.DateTime >= @DateOne) AND (PayInfo.DateTime < @Date)  AND (NOT (MiniEmp_1.PayID IN (48, 49, 50)))");
            if(!modST.IsTicketNotNeedCaic)
            strSql.Append(" AND (ProductWorkingInfo_1.IsCaiC = 1) ");
            strSql.Append(" GROUP BY PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, ");
            strSql.Append(" PayInfo.ProductWorkingID, MiniEmp_1.Name, Materiel_1.Name, Working_1.Name UNION ALL SELECT  ");
            strSql.Append(" PayInfo_1.EmployeeID, PayInfo_1.WorkingID, PayInfo_1.MaterielID, SUM(PayInfo_1.Amount) AS Amount,  ");
            strSql.Append(" PayInfo_1.Price FROM      PayInfo AS PayInfo_1 INNER JOIN Working AS Working_1 ON PayInfo_1.WorkingID ");
            strSql.Append(" = Working_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo_1.EmployeeID = MiniEmp_1.ID ");
            strSql.Append(" WHERE   (PayInfo_1.DateTime >= @DateOne) AND (PayInfo_1.DateTime < @Date) AND (PayInfo_1.IsDay = 1) ");
            strSql.Append(" GROUP BY PayInfo_1.EmployeeID, PayInfo_1.WorkingID, PayInfo_1.MaterielID, PayInfo_1.ProductWorkingID,  ");
            strSql.Append(" MiniEmp_1.Name, Working_1.Name, PayInfo_1.Price) AS Pay INNER JOIN MiniEmp ON Pay.EmployeeID = MiniEmp.ID ");
            strSql.Append(" WHERE   (MiniEmp.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102))");
            SqlParameter[] sps = { new SqlParameter("@DateOne", BeginDate), new SqlParameter("@Date", dtt), new SqlParameter("@MainID", MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetInfo(DateTime BeginDate, DateTime EndDate)
        {
            DateTime dtt = EndDate.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   PayInfo.EmployeeID, MiniEmp_1.Name AS EmployeeName, PayInfo.WorkingID, Working_1.Name AS WorkingName, PayInfo.MaterielID, ");
            strSql.Append(" Materiel_1.Name AS MaterielName, SUM(PayInfo.Amount) AS Amount, (SELECT   Price FROM      ProductWorkingInfo WHERE   (ID = ");
            strSql.Append(" PayInfo.ProductWorkingID)) AS Price FROM      PayInfo INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON PayInfo.ProductWorkingID ");
            strSql.Append(" = ProductWorkingInfo_1.ID INNER JOIN Working AS Working_1 ON PayInfo.WorkingID = Working_1.ID INNER JOIN Materiel AS Materiel_1 ON ");
            strSql.Append(" PayInfo.MaterielID = Materiel_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo.EmployeeID = MiniEmp_1.ID WHERE (PayInfo.DateTime >= @DateOne) ");
            strSql.Append(" AND (PayInfo.DateTime < @Date) AND (ProductWorkingInfo_1.IsCaiC = 1) ");
            strSql.Append(" GROUP BY PayInfo.EmployeeID, PayInfo.WorkingID, PayInfo.MaterielID, PayInfo.ProductWorkingID, MiniEmp_1.Name,  Materiel_1.Name, Working_1.Name ");
            strSql.Append(" UNION ALL SELECT   PayInfo_1.EmployeeID, MiniEmp_1.Name AS EmployeeName, PayInfo_1.WorkingID, Working_1.Name AS WorkingName, ");
            strSql.Append(" PayInfo_1.MaterielID, '' AS MaterielName, SUM(PayInfo_1.Amount) AS Amount,  PayInfo_1.Price FROM      PayInfo AS PayInfo_1 INNER JOIN ");
            strSql.Append(" Working AS Working_1 ON PayInfo_1.WorkingID = Working_1.ID INNER JOIN MiniEmp AS MiniEmp_1 ON PayInfo_1.EmployeeID = MiniEmp_1.ID ");
            strSql.Append(" WHERE   (PayInfo_1.DateTime >= @DateOne) AND (PayInfo_1.DateTime < @Date) ");
            strSql.Append(" AND (PayInfo_1.IsDay = 1) GROUP BY PayInfo_1.EmployeeID, PayInfo_1.WorkingID, PayInfo_1.MaterielID, PayInfo_1.ProductWorkingID, MiniEmp_1.Name, ");
            strSql.Append(" Working_1.Name, PayInfo_1.Price");
            SqlParameter[] sps = { new SqlParameter("@DateOne", BeginDate),  new SqlParameter("@Date", dtt) };
            DataSet dsInfo = DbHelperSQL.Query(strSql.ToString(), sps);
            dsInfo.Tables[0].TableName = "Info";
            return dsInfo;
        }
        /// <summary>
        /// 返回所有员工的计件工资总金额
        /// </summary>
        /// <param name="BeginDate"></param>
        /// <param name="EndDate"></param>
        /// <returns></returns>
        public DataSet GetTemPayByPWAll(DateTime BeginDate, DateTime EndDate)
        {
            DataSet ds = new DataSet();
            DateTime dtt = EndDate.AddDays(1);
            StringBuilder strSql = new StringBuilder();

            strSql.Append("SELECT   @DateOne AS BeginDate, @DateTwo AS EndDate, 3 AS A, 0 AS MainID, 0 AS IsEnd, 0 AS ID, Employee_4.PayID,  Employee_4.LassMoney, Employee_4.Royalty, ");
            strSql.Append("  Pay.LastRemain, SumPay.EmployeeID as EmpName,  SumPay.Month as Money,Employee_4.DepartmentID, ");
            strSql.Append(" Employee_4.Sn, Employee_4.Deposit AS AllDeposit, Employee_4.NeedDeposit, Employee_4.Deposit AS TemDeposit FROM      MiniEmp AS Employee_4 INNER JOIN ");
            strSql.Append(" (SELECT   SUM(Month) AS Month, EmployeeID FROM      (SELECT   SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS Month, PayInfo.EmployeeID FROM  PayInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID INNER JOIN MiniEmp AS ME ON PayInfo.EmployeeID = ME.ID WHERE   (PayInfo.DateTime >= @DateOne) ");
            strSql.Append(" AND (PayInfo.DateTime < @Date) AND  (ProductWorkingInfo.IsCaiC = 1)  ");
            strSql.Append(" GROUP BY PayInfo.EmployeeID UNION ALL SELECT   SUM(Amount * Price) AS Month, EmployeeID FROM  PayInfo AS PayInfo_1 WHERE (DateTime >= @DateOne) ");
            strSql.Append(" AND (DateTime < @Date) AND (IsDay = 1) ");
            strSql.Append(" GROUP BY EmployeeID) AS TTT GROUP BY EmployeeID) AS SumPay ON Employee_4.ID = SumPay.EmployeeID LEFT OUTER JOIN (SELECT   Pay_2.Remain AS LastRemain, ");
            strSql.Append(" Pay_2.EmployeeID FROM      Pay AS Pay_2 INNER JOIN (SELECT   MAX(DISTINCT Pay_1.ID) AS Expr1 FROM      Pay AS Pay_1 INNER JOIN MiniEmp AS Employee_1 ON ");
            strSql.Append(" Pay_1.EmployeeID = Employee_1.ID WHERE   (Employee_1.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) GROUP BY Pay_1.EmployeeID, Employee_1.ID) AS tem_1 ON Pay_2.ID = tem_1.Expr1 ");
            strSql.Append(" GROUP BY Pay_2.Remain, Pay_2.EmployeeID) AS Pay ON SumPay.EmployeeID = Pay.EmployeeID ");
            strSql.Append(" WHERE   (Employee_4.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102))");
            SqlParameter[] sps = { new SqlParameter("@DateOne", BeginDate), new SqlParameter("@DateTwo", EndDate), new SqlParameter("@Date", dtt)};
            ds = DbHelperSQL.Query(strSql.ToString(), sps);
            return ds;
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
			parameters[0].Value = "PayMain";
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

