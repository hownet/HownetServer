using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类WorkTicketInfo。
	/// </summary>
	public class WorkTicketInfo
	{
		public WorkTicketInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WorkTicketInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WorkTicketInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.WorkTicketInfo model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into WorkTicketInfo(");
            strSql.Append("MainID,DateTime,IsDel,PWorkingInfoID,EmployeeID,BackID,Amount,NotAmount,TaskID,WorkingID,OutAmount)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@DateTime,@IsDel,@PWorkingInfoID,@EmployeeID,@BackID,@Amount,@NotAmount,@TaskID,@WorkingID,@OutAmount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@IsDel", SqlDbType.Bit,1),
					new SqlParameter("@PWorkingInfoID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@BackID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@OutAmount", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.IsDel;
            parameters[3].Value = model.PWorkingInfoID;
            parameters[4].Value = model.EmployeeID;
            parameters[5].Value = model.BackID;
            parameters[6].Value = model.Amount;
            parameters[7].Value = model.NotAmount;
            parameters[8].Value = model.TaskID;
            parameters[9].Value = model.WorkingID;
            parameters[10].Value = model.OutAmount;

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
        public bool Update(Hownet.Model.WorkTicketInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WorkTicketInfo set ");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("IsDel=@IsDel,");
            strSql.Append("PWorkingInfoID=@PWorkingInfoID,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("BackID=@BackID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("NotAmount=@NotAmount,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("WorkingID=@WorkingID,");
            strSql.Append("OutAmount=@OutAmount");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@IsDel", SqlDbType.Bit,1),
					new SqlParameter("@PWorkingInfoID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@BackID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@OutAmount", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.IsDel;
            parameters[2].Value = model.PWorkingInfoID;
            parameters[3].Value = model.EmployeeID;
            parameters[4].Value = model.BackID;
            parameters[5].Value = model.Amount;
            parameters[6].Value = model.NotAmount;
            parameters[7].Value = model.TaskID;
            parameters[8].Value = model.WorkingID;
            parameters[9].Value = model.OutAmount;
            parameters[10].Value = model.ID;
            parameters[11].Value = model.MainID;

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
            strSql.Append("delete from WorkTicketInfo ");
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
        public bool Delete(int ID, int MainID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WorkTicketInfo ");
            strSql.Append(" where ID=@ID and MainID=@MainID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = ID;
            parameters[1].Value = MainID;

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
            strSql.Append("delete from WorkTicketInfo ");
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
        public Hownet.Model.WorkTicketInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,DateTime,IsDel,PWorkingInfoID,EmployeeID,BackID,Amount,NotAmount,TaskID,WorkingID,OutAmount from WorkTicketInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.WorkTicketInfo model = new Hownet.Model.WorkTicketInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsDel"] != null && ds.Tables[0].Rows[0]["IsDel"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsDel"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsDel"].ToString().ToLower() == "true"))
                    {
                        model.IsDel = true;
                    }
                    else
                    {
                        model.IsDel = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["PWorkingInfoID"] != null && ds.Tables[0].Rows[0]["PWorkingInfoID"].ToString() != "")
                {
                    model.PWorkingInfoID = int.Parse(ds.Tables[0].Rows[0]["PWorkingInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmployeeID"] != null && ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackID"] != null && ds.Tables[0].Rows[0]["BackID"].ToString() != "")
                {
                    model.BackID = int.Parse(ds.Tables[0].Rows[0]["BackID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotAmount"] != null && ds.Tables[0].Rows[0]["NotAmount"].ToString() != "")
                {
                    model.NotAmount = int.Parse(ds.Tables[0].Rows[0]["NotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"] != null && ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["WorkingID"] != null && ds.Tables[0].Rows[0]["WorkingID"].ToString() != "")
                {
                    model.WorkingID = int.Parse(ds.Tables[0].Rows[0]["WorkingID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OutAmount"] != null && ds.Tables[0].Rows[0]["OutAmount"].ToString() != "")
                {
                    model.OutAmount = int.Parse(ds.Tables[0].Rows[0]["OutAmount"].ToString());
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
            strSql.Append("select  1 as A,ID,MainID,DateTime,IsDel,PWorkingInfoID,EmployeeID,BackID,Amount,NotAmount,TaskID,WorkingID,OutAmount ");
            strSql.Append(" FROM WorkTicketInfo ");
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
            strSql.Append(" ID,MainID,DateTime,IsDel,PWorkingInfoID,EmployeeID,BackID,Amount,NotAmount,TaskID,WorkingID,OutAmount ");
            strSql.Append(" FROM WorkTicketInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得不包括列A数据列表
        /// </summary>
        public DataSet GetListNoA(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,MainID,DateTime,IsDel,PWorkingInfoID,EmployeeID,BackID,Amount,NotAmount,TaskID,WorkingID,OutAmount ");
            strSql.Append(" FROM WorkTicketInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetBoolAdd(int TaskID, int BoxNum, int WorkingID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT    MainID, DateTime, EmployeeID, BackID, ID, IsDel, PWorkingInfoID, Amount, NotAmount, TaskID, WorkingID,OutAmount,1 as A  FROM      WorkTicketInfo ");
            strSql.Append(" WHERE    ((SELECT   BoxNum FROM      WorkTicket ");
            strSql.Append(" WHERE   (ID = WorkTicketInfo.MainID)) = @BoxNum) AND (TaskID = @TaskID) AND (WorkingID = @WorkingID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@BoxNum", BoxNum), new SqlParameter("@WorkingID", WorkingID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 删除一条已记录的条码
        /// </summary>
        /// <param name="ID"></param>
        public void DelBar(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WorkTicketInfo set ");
            strSql.Append("DateTime=NULL,");
            strSql.Append("EmployeeID=0, BackID=0");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = { new SqlParameter("@ID", SqlDbType.Int, 4) };
            parameters[0].Value = ID;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public bool CheckWorking(int TaskID, int PWIID,int OneAmount)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   TOP (1) ID FROM      WorkTicketInfo ");
            //    strSql.Append(" WHERE   (PWorkingInfoID = @PWIID) AND (TaskID = @TaskID)");
            strSql.Append("SELECT   TOP (1) WorkTicketInfo.ID FROM      WorkTicketInfo INNER JOIN ");
            strSql.Append(" WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID WHERE   (WorkTicketInfo.PWorkingInfoID ");
            strSql.Append(" = @PWIID) AND (WorkTicket.TaskID = @TaskID) AND (WorkTicket.OneAmount = @OneAmount)");
            SqlParameter[] sps = { new SqlParameter("@PWIID", PWIID), new SqlParameter("@TaskID", TaskID), new SqlParameter("@OneAmount", OneAmount) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return false;
            else
                return true;
        }
        public DataSet GetSpecialTicketLine(int TaskID, int PWIID, int TaskDepID, int DPWID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   WorkTicketInfo.ID, WorkTicketInfo.PWorkingInfoID, (SELECT   Name FROM      Color WHERE   (ID = WorkTicket.ColorID)) AS ColorName, ");
            strSql.Append(" (SELECT   Name FROM      Size WHERE   (ID = WorkTicket.SizeID)) AS SizeName, WorkTicket.BoxNum, WorkTicketInfo.Amount, ");
            strSql.Append(" (SELECT   Name FROM      Working WHERE   (ID = WorkTicketInfo.WorkingID)) AS WorkName, WorkTicketInfo.TaskID, WorkTicketInfo.WorkingID,  ");
            strSql.Append(" ProductWorkingInfo.Orders, ProductWorkingInfo.GroupBy FROM      WorkTicketInfo INNER JOIN ProductWorkingInfo ON ");
            strSql.Append(" WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID    ");
            if (TaskDepID == 0)
                strSql.Append(" WHERE   (WorkTicketInfo.TaskID = @TaskID) AND (ProductWorkingInfo.PWIID = @PWIID)");
            else
                strSql.Append(" WHERE   (WorkTicket.DepartmentID = @TaskDepID) AND (ProductWorkingInfo.PWIID = @DPWID)");
            SqlParameter[] sps = { new SqlParameter("@PWIID", PWIID), new SqlParameter("@TaskID", TaskID) ,
                                 new SqlParameter("@TaskDepID",TaskDepID),new SqlParameter("@DPWID",DPWID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetTicketLine(int TaskID, int PWIID,int TaskDepID,int DPWID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   WorkTicketInfo.ID, WorkTicketInfo.PWorkingInfoID, (SELECT   Name FROM      Color WHERE   (ID = WorkTicket.ColorID)) AS ColorName, ");
            strSql.Append("  (SELECT   Name FROM      Size WHERE   (ID = WorkTicket.SizeID)) AS SizeName, WorkTicket.BoxNum, WorkTicketInfo.Amount, (SELECT   Name ");
            strSql.Append(" FROM      Working WHERE   (ID = WorkTicketInfo.WorkingID)) AS WorkName, WorkTicketInfo.TaskID, WorkTicketInfo.WorkingID,  ");
           strSql.Append(" ProductWorkingInfo.Orders, ProductWorkingInfo.GroupBy FROM      WorkTicketInfo INNER JOIN ProductWorkingInfo ON ");
            strSql.Append(" WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID ");
            if(TaskDepID==0)
            strSql.Append(" WHERE   (WorkTicketInfo.TaskID = @TaskID) AND (WorkTicketInfo.PWorkingInfoID = @PWIID)");
            else
                strSql.Append(" WHERE   (WorkTicket.DepartmentID = @TaskDepID) AND (WorkTicketInfo.PWorkingInfoID = @DPWID)");
            SqlParameter[] sps = { new SqlParameter("@PWIID", PWIID), new SqlParameter("@TaskID", TaskID),
                                 new SqlParameter("@TaskDepID",TaskDepID),new SqlParameter("@DPWID",DPWID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 用于显示工序执行情况
        /// </summary>
        /// <param name="TaskID">生产单ID</param>
        /// <returns></returns>
        public DataSet GetWorkListByPW(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT WorkTicketInfo.MainID,  WorkTicket.BoxNum, WorkTicketInfo.WorkingID, (SELECT   Name FROM      MiniEmp WHERE   (ID ");
            strSql.Append(" = WorkTicketInfo.EmployeeID)) AS EmployeeName, WorkTicketInfo.DateTime ");
            strSql.Append(" , (SELECT   DeparmentID FROM      ProductTaskMain WHERE   (ID = WorkTicket.TaskID)) AS DepID");
            strSql.Append(" FROM      WorkTicket INNER JOIN ");
            strSql.Append(" WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID WHERE   (WorkTicket.TaskID = @ID)");
            strSql.Append(" order by WorkTicket.BoxNum");
            SqlParameter[] sps = { new SqlParameter("@ID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 用于显示工序执行情况
        /// </summary>
        /// <param name="TaskID">生产单ID</param>
        /// <returns></returns>
        public DataSet GetDepWorkListByPW(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   WorkTicket.BoxNum, WorkTicketInfo.WorkingID, (SELECT   Name FROM      MiniEmp WHERE   (ID ");
            strSql.Append(" = WorkTicketInfo.EmployeeID)) AS EmployeeName, WorkTicketInfo.DateTime ");
            strSql.Append(" , (SELECT   DepartmentID FROM      DepartmentTaskMain WHERE   (ID = WorkTicket.DepartmentID)) AS DepID");
            strSql.Append(" FROM      WorkTicket INNER JOIN ");
            strSql.Append(" WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID WHERE   (WorkTicket.DepartmentID = @ID)");
            strSql.Append(" order by WorkTicket.BoxNum");
            SqlParameter[] sps = { new SqlParameter("@ID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public void AddPayInfo(int MaterielID, int InfoID, string oderNum)
        {

            StringBuilder strSql = new StringBuilder();
            Hownet.DAL.ProductTaskMain dalPTM = new ProductTaskMain();
            int a = 0;
            try
            {
                a = dalPTM.GetModel(GetModel(InfoID).TaskID).MaterielID;
            }
            catch (Exception ex)
            {
                a = MaterielID;
            }
            strSql.Append("INSERT INTO PayInfo (ColorID, SizeID, Amount, BoxNum, DateTime, EmployeeID, ProductWorkingID, WorkingID, Price, OderNum, MaterielID,  ");
            strSql.Append(" WorkticketInfoID,IsDay) SELECT   WorkTicket.ColorID, WorkTicket.SizeID, WorkTicketInfo.Amount, WorkTicket.BoxNum, WorkTicketInfo.DateTime,  ");
            strSql.Append(" WorkTicketInfo.EmployeeID, ProductWorkingInfo.ID AS Expr3, ProductWorkingInfo.WorkingID, ProductWorkingInfo.Price, @OderNum ");
            strSql.Append(" AS Expr1, @MaterielID AS Expr2, WorkTicketInfo.ID,0 FROM      WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID ");
            strSql.Append(" = WorkTicket.ID INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE   (WorkTicketInfo.ID = @InfoID)");
            SqlParameter[] sps = {new SqlParameter("@OderNum", oderNum),new SqlParameter("@MaterielID",a),
                                 new SqlParameter("@InfoID",InfoID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetWorkingByTicketID(int GroupBy, int TicketID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ProductWorkingInfo.WorkingID, WorkTicket.Amount, WorkTicketInfo.ID AS InfoID, ProductWorkingInfo.Orders, ");
            strSql.Append(" Working.Name AS WorkingName, ProductTaskMain.MaterielID, ProductTaskMain.Num, ProductTaskMain.DateTime,  ");
            strSql.Append(" Materiel.Name AS MaterielName, WorkTicketInfo.EmployeeID, Color.Name AS ColorName, Size.Name AS SizeName FROM      WorkTicketInfo INNER JOIN ");
            strSql.Append(" Size INNER JOIN WorkTicket ON Size.ID = WorkTicket.SizeID INNER JOIN Color ON WorkTicket.ColorID = Color.ID ON ");
            strSql.Append(" WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN ");
            strSql.Append(" Working ON WorkTicketInfo.WorkingID = Working.ID INNER JOIN Materiel INNER JOIN ProductTaskMain ON Materiel.ID = ");
            strSql.Append(" ProductTaskMain.MaterielID ON WorkTicket.TaskID = ProductTaskMain.ID WHERE   (WorkTicket.ID = @TicketID) AND ");
            strSql.Append(" (ProductWorkingInfo.GroupBy = @GroupBy) ORDER BY ProductWorkingInfo.Orders");
            SqlParameter[] sps = { new SqlParameter("@TicketID", TicketID), new SqlParameter("@GroupBy", GroupBy) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public string CountAmount(int EmpID, DateTime dt, bool IsShowMoney)
        {
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(PayInfo.Amount) AS Amount, CAST(SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS real) AS ");
            strSql.Append("  Money FROM      PayInfo INNER JOIN ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE   (PayInfo.DateTime > @dt1) AND (PayInfo.DateTime < @dt2) AND (PayInfo.EmployeeID = @EmpID)");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmpID),
                                 new SqlParameter("@dt1",dt1),new SqlParameter("@dt2",dt2)};
            DataTable dtt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            if (dtt.Rows.Count > 0)
            {
                if (IsShowMoney)
                {
                    string lblzj = string.Format("{0:F1}", Convert.ToDouble(dtt.Rows[0]["Money"]));

                    return dtt.Rows[0]["Amount"].ToString() + "  " + lblzj;// +"元";
                }
                else
                    return dtt.Rows[0]["Amount"].ToString() + "  ";
            }
            else
            {
                return string.Empty;
            }
        }
        public string CountAmountByWorking(int EmpID, DateTime dt, bool IsShowMoney, int WorkingID)
        {
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(PayInfo.Amount) AS Amount, CAST(SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS real) AS ");
            strSql.Append("  Money FROM      PayInfo INNER JOIN ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE   (PayInfo.DateTime > @dt1) AND (PayInfo.DateTime < @dt2) AND (PayInfo.EmployeeID = @EmpID) And (ProductWorkingInfo.ID=@WorkingID)");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmpID),
                                 new SqlParameter("@dt1",dt1),new SqlParameter("@dt2",dt2),new SqlParameter("@WorkingID",WorkingID)};
            DataTable dtt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            if (dtt.Rows.Count > 0)
            {
                if (IsShowMoney)
                {
                    string lblzj = string.Format("{0:F1}", Convert.ToDouble(dtt.Rows[0]["Money"]));

                    return dtt.Rows[0]["Amount"].ToString() + "  " + lblzj;// +"元";
                }
                else
                    return dtt.Rows[0]["Amount"].ToString() + "  ";
            }
            else
            {
                return string.Empty;
            }
        }
        public DataSet GetKey(int TicketID, int WorkOrder, int SizeID, int ColorID)
        {
            StringBuilder strSql = new StringBuilder();
            if (SizeID == 0 && ColorID == 0)
            {
                //strSql.Append(" SELECT ProductWorkingInfo.Orders, Employee.EmployeeName, Working.WorkingName, ");
                //strSql.Append(" WorkticketInfo.DateTime, '' AS SizeName, '' AS ColorName FROM WorkTicket INNER JOIN ");
                //strSql.Append(" WorkticketInfo ON WorkTicket.WorkTicketID = WorkticketInfo.MainID INNER JOIN ");
                //strSql.Append(" ProductWorkingInfo ON WorkticketInfo.WorkingID = ProductWorkingInfo.ProductWorkingID ");
                //strSql.Append(" INNER JOIN Working ON ProductWorkingInfo.WorkingID = Working.WorkingID LEFT OUTER JOIN ");
                //strSql.Append(" Employee ON WorkticketInfo.EmployeeID = Employee.EmployeeID WHERE (WorkTicket.WorkTicketID = @TicketID)");
                strSql.Append("SELECT   WorkTicketInfo.DateTime, '' AS SizeName, '' AS ColorName, Working.Name AS WorkingName,  MiniEmp.Name AS EmployeeName , WorkTicketInfo.WorkingID");
                strSql.Append(" FROM      WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID INNER JOIN Working ON ");
                strSql.Append(" WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID ");
                strSql.Append(" WHERE   (WorkTicket.ID = @TicketID) AND (Working.ID = @Orders)");
            }
            else
            {
                strSql.Append("SELECT ProductWorkingInfo.Orders, Working.WorkingName, SUM(WorkTicket.Amount)  ");
                strSql.Append("      AS Amount, MaterielAttribute.MaterielAttributeName AS ColorName,  ");
                strSql.Append("      MaterielAttribute_1.MaterielAttributeName AS SizeName ");
                strSql.Append("FROM MaterielAttribute INNER JOIN ");
                strSql.Append("      WorkTicket INNER JOIN ");
                strSql.Append("      WorkticketInfo ON WorkTicket.WorkTicketID = WorkticketInfo.MainID INNER JOIN ");
                strSql.Append("      ProductWorkingInfo ON  ");
                strSql.Append("      WorkticketInfo.WorkingID = ProductWorkingInfo.ProductWorkingID INNER JOIN ");
                strSql.Append("      Working ON ProductWorkingInfo.WorkingID = Working.WorkingID INNER JOIN ");
                strSql.Append("      ProduceTaskMain ON  ");
                strSql.Append("      WorkTicket.ProductTaskID = ProduceTaskMain.ProduceTaskID INNER JOIN ");
                strSql.Append("      WorkTicket AS WorkTicket_1 ON  ");
                strSql.Append("      ProduceTaskMain.ProduceTaskID = WorkTicket_1.ProductTaskID ON  ");
                strSql.Append("      MaterielAttribute.MaterielAttributeID = WorkTicket.ColorID INNER JOIN ");
                strSql.Append("      MaterielAttribute AS MaterielAttribute_1 ON  ");
                strSql.Append("      WorkTicket.SizeID = MaterielAttribute_1.MaterielAttributeID ");
                strSql.Append("WHERE (WorkTicket_1.WorkTicketID = @TicketID) AND (WorkticketInfo.EmployeeID > 0) ");
                strSql.Append("GROUP BY ProductWorkingInfo.Orders, Working.WorkingName,  ");
                strSql.Append("      MaterielAttribute.MaterielAttributeName, MaterielAttribute.Sn,  ");
                strSql.Append("      MaterielAttribute_1.MaterielAttributeName, MaterielAttribute_1.Sn ");
                strSql.Append("HAVING (ProductWorkingInfo.Orders = @Orders) AND (MaterielAttribute.Sn = @ColorID) AND  ");
                strSql.Append("      (MaterielAttribute_1.Sn = @SizeID) ");
            }
            SqlParameter[] sps = { new SqlParameter("@TicketID",TicketID),
                                 new SqlParameter("@Orders",WorkOrder),
                                 new SqlParameter("@ColorID",SizeID),
                                 new SqlParameter("@SizeID",ColorID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DateTime GetDateTime()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT GETDATE() AS Date ");
            return (DateTime)(DbHelperSQL.GetSingle(strSql.ToString()));
        }
        public string GetEmployee(int EmpID, int typeID, DateTime dt, bool IsShowMoney)
        {
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            if (typeID == 2)
            {
                Hownet.DAL.SysTem dalST = new SysTem();
                Hownet.Model.SysTem modST = dalST.GetModel(dalST.GetMaxId() - 1);
                if (modST.Registration.Trim() != string.Empty)
                {
                    dt1 = DateTime.Parse(dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + modST.Registration);
                }
                else
                {
                    dt1 = DateTime.Parse(dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + "01");
                }
            }
            if (dt1 > DateTime.Now.Date)
                dt1 = dt1.AddMonths(-1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(PayInfo.Amount) AS Amount, CAST(SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS real) AS ");
            strSql.Append("  Money  FROM PayInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE (PayInfo.DateTime > @dt1) AND (PayInfo.DateTime < @dt2) AND (PayInfo.EmployeeID = @EmpID)");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmpID),
                                 new SqlParameter("@dt1",dt1),new SqlParameter("@dt2",dt2)};
            DataTable dtt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            if (dtt.Rows.Count > 0)
            {
                try
                {
                    if (IsShowMoney)
                    {
                        string lblzj = string.Format("{0:F1}", Convert.ToDouble(dtt.Rows[0]["Money"]));
                        return dtt.Rows[0]["Amount"].ToString() + "  " + lblzj;// +"元";
                    }
                    else
                        return dtt.Rows[0]["Amount"].ToString() + "  ";
                }
                catch
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }
        public DataSet GetEmployeeNum(int EmpID, int typeID)
        {
            DateTime dt1 =DateTime.Now.Date.AddSeconds(-1);
            DateTime dt2 =DateTime.Now.Date.AddDays(1);
            if (typeID == 2)
            {
                dt1 = DateTime.Parse(DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + "01");
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(PayInfo.Amount) AS Amount, CAST(SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS real) AS ");
            strSql.Append("  Money  FROM PayInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE (PayInfo.DateTime > @dt1) AND (PayInfo.DateTime < @dt2) AND (PayInfo.EmployeeID = @EmpID)");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmpID),
                                 new SqlParameter("@dt1",dt1),new SqlParameter("@dt2",dt2)};
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }
        public string GetEmpSum(int EmpID, DateTime dt1, DateTime dt2, bool IsShowMoney)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(PayInfo.Amount) AS Amount, CAST(SUM(PayInfo.Amount * ProductWorkingInfo.Price) AS real) AS ");
            strSql.Append("  Money  FROM PayInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE (PayInfo.DateTime > @dt1) AND (PayInfo.DateTime < @dt2) AND (PayInfo.EmployeeID = @EmpID)");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmpID),
                                 new SqlParameter("@dt1",dt1),new SqlParameter("@dt2",dt2)};
            DataTable dtt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            if (dtt.Rows.Count > 0)
            {
                try
                {
                    if (IsShowMoney)
                    {
                        string lblzj = string.Format("{0:F1}", Convert.ToDouble(dtt.Rows[0]["Money"]));
                        return dtt.Rows[0]["Amount"].ToString() + "  " + lblzj;// +"元";
                    }
                    else
                        return dtt.Rows[0]["Amount"].ToString() + "  ";
                }
                catch
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 整箱全为一个人完成时，根据条码更新工票明细
        /// </summary>
        /// <param name="ID">工票明细表ID，为条码录入</param>
        /// <param name="EmployeeID">交工票的员工</param>
        /// <param name="dt">回收日期</param>
        /// <returns></returns>
        public void GetBarBack(int ID, int EmployeeID, DateTime dt, int BackID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WorkticketInfo set ");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("EmployeeID=@EmployeeID, ");
            strSql.Append("BackID=@BackID ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = { new SqlParameter("@ID", ID), new SqlParameter("@DateTime", dt), new SqlParameter("@EmployeeID", EmployeeID), new SqlParameter("@BackID", BackID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetFristReport(int TaskID, int GroupID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   WorkTicketInfo.ID AS Info,ProductWorkingInfo.WorkingID, (SELECT   Name FROM      Working WHERE   (ID = ");
            strSql.Append(" ProductWorkingInfo.WorkingID)) AS WorkingName, (SELECT   Name FROM Color WHERE   (ID = WorkTicket.ColorID)) AS ");
            strSql.Append(" ColorName, (SELECT   Name FROM      Size WHERE   (ID = WorkTicket.SizeID)) AS SizeName, WorkTicket.Amount, ");
            strSql.Append(" WorkTicket.BoxNum, WorkTicket.ID AS MainID,  WorkTicket.ID, ProductWorkingInfo.GroupBy, ProductWorkingInfo.Orders ");
            strSql.Append(" FROM      WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ProductTaskMain ");
            strSql.Append(" ON WorkTicket.TaskID = ProductTaskMain.ID INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ");
            strSql.Append(" ProductWorkingInfo.ID WHERE   (ProductWorkingInfo.GroupBy = @GroupID) AND (ProductWorkingInfo.IsTicket = 1) AND ");
            strSql.Append(" (WorkTicket.TaskID = @PTID) ORDER BY WorkTicket.ID, ProductWorkingInfo.GroupBy, ProductWorkingInfo.Orders DESC");
            SqlParameter[] sps = { new SqlParameter("@PTID", TaskID),
                                 new SqlParameter("@GroupID",GroupID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetGroupColorSize(int TaskID, int ColorID, int SizeID,int ColorOneID,int ColorTwoID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   SUM(Expr1) AS Amount, WorkingID, SUM(NotAmount) AS NotAmount FROM (SELECT   0 AS Expr1, SUM(WorkTicketInfo.Amount) ");
            //strSql.Append(" AS NotAmount, WorkTicketInfo.WorkingID FROM WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID ");
            //strSql.Append(" WHERE   (WorkTicket.TaskID = @TaskID) AND (WorkTicket.ColorID = @ColorID) AND (WorkTicket.SizeID = @SizeID) AND (WorkTicketInfo.EmployeeID = 0) ");
            //strSql.Append(" GROUP BY WorkTicketInfo.WorkingID UNION ALL SELECT   SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID ");
            //strSql.Append(" FROM WorkTicket AS WorkTicket_1 INNER JOIN WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID ");
            //strSql.Append(" WHERE (WorkTicket_1.TaskID = @TaskID) AND (WorkTicket_1.ColorID = @ColorID) AND (WorkTicket_1.SizeID = @SizeID) AND ");
            //strSql.Append(" (WorkTicketInfo_1.EmployeeID > 0) GROUP BY WorkTicketInfo_1.WorkingID) AS T GROUP BY WorkingID");
            strSql.Append(" SELECT   SUM(Expr1) AS Amount, WorkingID, SUM(NotAmount) AS NotAmount, Orders ");
            strSql.Append(" FROM      (SELECT   0 AS Expr1, SUM(WorkTicketInfo.Amount) AS NotAmount, WorkTicketInfo.WorkingID,  ProductWorkingInfo.Orders ");
            strSql.Append(" FROM      WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE   (WorkTicket.TaskID = @TaskID) AND (WorkTicket.ColorID = @ColorID) AND (WorkTicket.SizeID = @SizeID) AND ");
            strSql.Append(" (WorkTicket.ColorOneID = @ColorOneID) And (WorkTicket.ColorTwoID = @ColorTwoID) And ");
            strSql.Append(" (WorkTicketInfo.EmployeeID = 0) GROUP BY WorkTicketInfo.WorkingID, ProductWorkingInfo.Orders ");
            strSql.Append(" UNION ALL SELECT   SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID,  ");
            strSql.Append(" ProductWorkingInfo_1.Orders FROM      WorkTicket AS WorkTicket_1 INNER JOIN ");
            strSql.Append(" WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo AS ProductWorkingInfo_1 ON  ");
            strSql.Append(" WorkTicketInfo_1.PWorkingInfoID = ProductWorkingInfo_1.ID ");
            strSql.Append(" WHERE   (WorkTicket_1.TaskID = @TaskID) AND (WorkTicket_1.ColorID = @ColorID) AND  ");
            strSql.Append(" (WorkTicket_1.ColorOneID = @ColorOneID) And (WorkTicket_1.ColorTwoID = @ColorTwoID) And ");
            strSql.Append(" (WorkTicket_1.SizeID = @SizeID) AND (WorkTicketInfo_1.EmployeeID > 0) ");
            strSql.Append(" GROUP BY WorkTicketInfo_1.WorkingID, ProductWorkingInfo_1.Orders) AS T GROUP BY WorkingID, Orders ORDER BY Orders");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@ColorID", ColorID), new SqlParameter("@SizeID", SizeID), new SqlParameter("@ColorTwoID", ColorTwoID), new SqlParameter("@ColorOneID", ColorOneID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回汇总的分色号完成情况
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <returns></returns>
        public DataSet GetSUMCS(DateTime dt1, DateTime dt2, int MatID, int PWID, int ColorID, int SizeID, int ColorOneID, int ColorTwoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(Expr1) AS Amount, SUM(NotAmount) AS NotAmount, WorkingID, Orders ");
            strSql.Append("FROM      (SELECT   0 AS Expr1, SUM(WorkTicketInfo.Amount) AS NotAmount, WorkTicketInfo.WorkingID,  ");
            strSql.Append("                                 ProductWorkingInfo.Orders ");
            strSql.Append("                 FROM      WorkTicket INNER JOIN ");
            strSql.Append("                                 WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID INNER JOIN ");
            strSql.Append("                                 ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN ");
            strSql.Append("                                 ProductTaskMain ON WorkTicket.TaskID = ProductTaskMain.ID ");
            strSql.Append("                 WHERE   (WorkTicket.ColorID = @ColorID) AND (WorkTicket.SizeID = @SizeID)  AND  (WorkTicket.ColorOneID = @ColorOneID) And (WorkTicket.ColorTwoID = @ColorTwoID) And (WorkTicketInfo.EmployeeID = 0)  ");
            strSql.Append("                                 AND (ProductWorkingInfo.MainID = @PWID) AND (ProductTaskMain.MaterielID = @MatID) AND  ");
            strSql.Append("                                 (ProductTaskMain.DateTime > @dt1) AND (ProductTaskMain.DateTime < @dt2) ");
            strSql.Append("                 GROUP BY WorkTicketInfo.WorkingID, ProductWorkingInfo.Orders ");
            strSql.Append("                 UNION ALL ");
            strSql.Append("                 SELECT   SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID,  ");
            strSql.Append("                                 ProductWorkingInfo_1.Orders ");
            strSql.Append("                 FROM      WorkTicket AS WorkTicket_1 INNER JOIN ");
            strSql.Append("                                 WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID INNER JOIN ");
            strSql.Append("                                 ProductWorkingInfo AS ProductWorkingInfo_1 ON  ");
            strSql.Append("                                 WorkTicketInfo_1.PWorkingInfoID = ProductWorkingInfo_1.ID INNER JOIN ");
            strSql.Append("                                 ProductTaskMain AS ProductTaskMain_1 ON WorkTicket_1.TaskID = ProductTaskMain_1.ID ");
            strSql.Append("                 WHERE   (WorkTicket_1.ColorID = @ColorID) AND (WorkTicket_1.SizeID = @SizeID) AND  (WorkTicket_1.ColorOneID = @ColorOneID) And (WorkTicket_1.ColorTwoID = @ColorTwoID) And ");
            strSql.Append("                                 (WorkTicketInfo_1.EmployeeID > 0) AND (ProductTaskMain_1.MaterielID = @MatID) AND  ");
            strSql.Append("                                 (ProductTaskMain_1.PWorkingID = @PWID) AND (ProductTaskMain_1.DateTime > @dt1) AND  ");
            strSql.Append("                                 (ProductTaskMain_1.DateTime < @dt2) ");
            strSql.Append("                 GROUP BY WorkTicketInfo_1.WorkingID, ProductWorkingInfo_1.Orders) AS T ");
            strSql.Append("GROUP BY WorkingID, Orders ");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@MatID", MatID), new SqlParameter("@PWID", PWID), new SqlParameter("@ColorID", ColorID), new SqlParameter("@SizeID", SizeID), new SqlParameter("@ColorTwoID", ColorTwoID), new SqlParameter("@ColorOneID", ColorOneID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回汇总的完成情况
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <returns></returns>
        public DataSet GetSUMNotCS(DateTime dt1, DateTime dt2, int MatID, int PWID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(Expr1) AS Amount, SUM(NotAmount) AS NotAmount, WorkingID, Orders ");
            strSql.Append("FROM      (SELECT   0 AS Expr1, SUM(WorkTicketInfo.Amount) AS NotAmount, WorkTicketInfo.WorkingID,  ");
            strSql.Append("                                 ProductWorkingInfo.Orders ");
            strSql.Append("                 FROM      WorkTicket INNER JOIN ");
            strSql.Append("                                 WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID INNER JOIN ");
            strSql.Append("                                 ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN ");
            strSql.Append("                                 ProductTaskMain ON WorkTicket.TaskID = ProductTaskMain.ID ");
            strSql.Append("                 WHERE    (WorkTicketInfo.EmployeeID = 0)  ");
            strSql.Append("                                 AND (ProductWorkingInfo.MainID = @PWID) AND (ProductTaskMain.MaterielID = @MatID) AND  ");
            strSql.Append("                                 (ProductTaskMain.DateTime > @dt1) AND (ProductTaskMain.DateTime < @dt2) ");
            strSql.Append("                 GROUP BY WorkTicketInfo.WorkingID, ProductWorkingInfo.Orders ");
            strSql.Append("                 UNION ALL ");
            strSql.Append("                 SELECT   SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID,  ");
            strSql.Append("                                 ProductWorkingInfo_1.Orders ");
            strSql.Append("                 FROM      WorkTicket AS WorkTicket_1 INNER JOIN ");
            strSql.Append("                                 WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID INNER JOIN ");
            strSql.Append("                                 ProductWorkingInfo AS ProductWorkingInfo_1 ON  ");
            strSql.Append("                                 WorkTicketInfo_1.PWorkingInfoID = ProductWorkingInfo_1.ID INNER JOIN ");
            strSql.Append("                                 ProductTaskMain AS ProductTaskMain_1 ON WorkTicket_1.TaskID = ProductTaskMain_1.ID ");
            strSql.Append("                      WHERE           (WorkTicketInfo_1.EmployeeID > 0) AND (ProductTaskMain_1.MaterielID = @MatID) AND  ");
            strSql.Append("                                 (ProductTaskMain_1.PWorkingID = @PWID) AND (ProductTaskMain_1.DateTime > @dt1) AND  ");
            strSql.Append("                                 (ProductTaskMain_1.DateTime < @dt2) ");
            strSql.Append("                 GROUP BY WorkTicketInfo_1.WorkingID, ProductWorkingInfo_1.Orders) AS T ");
            strSql.Append("GROUP BY WorkingID, Orders ");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@MatID", MatID), new SqlParameter("@PWID", PWID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 整单工序完成情况
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetWorkFishByTaskID(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT   SUM(Expr1) AS Amount, WorkingID, SUM(NotAmount) AS NotAmount FROM      (SELECT   0 AS Expr1, SUM(WorkTicketInfo.Amount) ");
            //strSql.Append(" AS NotAmount, WorkTicketInfo.WorkingID FROM      WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID ");
            //strSql.Append(" WHERE   (WorkTicket.TaskID = @TaskID) AND (WorkTicketInfo.EmployeeID = 0) GROUP BY WorkTicketInfo.WorkingID UNION ALL ");
            //strSql.Append(" SELECT   SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID FROM      WorkTicket AS WorkTicket_1 INNER JOIN ");
            //strSql.Append(" WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID WHERE   (WorkTicket_1.TaskID = @TaskID) AND ");
            //strSql.Append(" (WorkTicketInfo_1.EmployeeID > 0) GROUP BY WorkTicketInfo_1.WorkingID) AS T GROUP BY WorkingID");
            strSql.Append(" SELECT   SUM(Expr1) AS Amount, WorkingID, SUM(NotAmount) AS NotAmount, Orders ");
            strSql.Append(" FROM      (SELECT   0 AS Expr1, SUM(WorkTicketInfo.Amount) AS NotAmount, WorkTicketInfo.WorkingID,  ");
            strSql.Append(" ProductWorkingInfo.Orders FROM      WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID WHERE   (WorkTicket.TaskID = @TaskID) AND ");
            strSql.Append(" (WorkTicketInfo.EmployeeID = 0) GROUP BY WorkTicketInfo.WorkingID, ProductWorkingInfo.Orders UNION ALL ");
            strSql.Append(" SELECT   SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID, ProductWorkingInfo_1.Orders ");
            strSql.Append(" FROM      WorkTicket AS WorkTicket_1 INNER JOIN WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID ");
            strSql.Append(" INNER JOIN ProductWorkingInfo AS ProductWorkingInfo_1 ON  WorkTicketInfo_1.PWorkingInfoID = ProductWorkingInfo_1.ID ");
            strSql.Append(" WHERE   (WorkTicket_1.TaskID = @TaskID) AND (WorkTicketInfo_1.EmployeeID > 0) GROUP BY WorkTicketInfo_1.WorkingID, ");
            strSql.Append(" ProductWorkingInfo_1.Orders) AS T GROUP BY WorkingID, Orders ORDER BY Orders");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 生产线在线数量
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <param name="BrandID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <returns></returns>
        public DataSet GetWorking(int MaterielID,int BrandID, int ColorID, int SizeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(Expr1) AS Amount, WorkingID, SUM(NotAmount) AS NotAmount FROM (SELECT   0 AS Expr1, SUM(WorkTicketInfo.Amount) ");
            strSql.Append(" AS NotAmount, WorkTicketInfo.WorkingID FROM      WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID ");
            strSql.Append(" INNER JOIN ProductTaskMain ON WorkTicket.TaskID = ProductTaskMain.ID WHERE   (WorkTicket.ColorID = @ColorID) AND (WorkTicket.SizeID ");
            strSql.Append(" = @SizeID) AND (WorkTicketInfo.EmployeeID = 0) AND (ProductTaskMain.MaterielID = @MaterielID) AND (ProductTaskMain.BrandID = @BrandID) ");
            strSql.Append(" AND  (ProductTaskMain.IsVerify = 3) ");
            strSql.Append(" GROUP BY WorkTicketInfo.WorkingID UNION ALL SELECT   SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID ");
            strSql.Append(" FROM WorkTicket AS WorkTicket_1 INNER JOIN WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID INNER JOIN ");
            strSql.Append(" ProductTaskMain AS ProductTaskMain_1 ON WorkTicket_1.TaskID = ProductTaskMain_1.ID WHERE   (WorkTicket_1.ColorID = @ColorID) AND ");
            strSql.Append(" (WorkTicket_1.SizeID = @SizeID) AND  (WorkTicketInfo_1.EmployeeID > 0) AND (ProductTaskMain_1.MaterielID = @MaterielID) AND  ");
            strSql.Append("  (ProductTaskMain_1.IsVerify = 3) AND ");
            strSql.Append(" (ProductTaskMain_1.BrandID = @BrandID) GROUP BY WorkTicketInfo_1.WorkingID) AS T GROUP BY WorkingID ");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID), new SqlParameter("@ColorID", ColorID), new SqlParameter("@SizeID", SizeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public bool CheckNotWork(int TaskID, int dtmID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(WorkTicketInfo.ID) AS Expr1 FROM WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID ");
            strSql.Append(" WHERE   (WorkTicket.TaskID = @TaskID)  AND (WorkTicketInfo.EmployeeID > 0)");
            SqlParameter[] sps = {new SqlParameter("@TaskID",TaskID),new SqlParameter("@DTMID",dtmID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return false;
            if (Convert.ToInt32(o) == 0)
                return false;
            else
                return true;
        }
        public void DeleteTicket(int TaskID, int DTMID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" DELETE FROM WorkTicketIDCard FROM      WorkTicket INNER JOIN WorkTicketIDCard ON WorkTicket.ID = WorkTicketIDCard.TicketID ");
            strSql.Append(" WHERE   (WorkTicket.TaskID = @TaskID) ");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID)};
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
            strSql.Remove(0, strSql.Length);
            strSql.Append("DELETE FROM WorkTicketInfo  ");
            strSql.Append(" WHERE   (TaskID = @TaskID) ");
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
            strSql.Remove(0, strSql.Length);
            strSql.Append("DELETE FROM WorkTicket WHERE   (TaskID = @TaskID) ");
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 修改某份货的未完成工序数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="Amount"></param>
        public void UpNoWorkingAmount(int MainID, int Amount,int GroupBy)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" UPDATE    TOP (200) WorkTicketInfo SET              Amount = @Amount FROM         WorkTicketInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID WHERE     (WorkTicketInfo.EmployeeID = 0) ");
            strSql.Append(" AND (ProductWorkingInfo.GroupBy = @GroupBy) AND (WorkTicketInfo.MainID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID), new SqlParameter("@Amount", Amount), new SqlParameter("@GroupBy", GroupBy) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public void AddPayInfoByID(int WTIID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" INSERT INTO PayInfo (EmployeeID, DateTime, MaterielID, Amount, WorkingID, ProductWorkingID, WorkticketInfoID, ColorID, SizeID, BoxNum,  ");
            strSql.Append(" OderNum, IsSum, IsDay, Price, BreakID) SELECT   WorkTicketInfo.EmployeeID, WorkTicketInfo.DateTime, ProductTaskMain.MaterielID, WorkTicketInfo.Amount,  ");
            strSql.Append(" WorkTicketInfo.WorkingID, WorkTicketInfo.PWorkingInfoID, WorkTicketInfo.ID, WorkTicket.ColorID, WorkTicket.SizeID, ");
            strSql.Append(" WorkTicket.BoxNum, CONVERT(varchar(100), ProductTaskMain.DateTime, 112) + '-' + CAST(ProductTaskMain.Num AS varchar) AS Num, 0 AS Expr1, 0 AS Expr2, 0 AS Expr3, 0 AS Expr4 ");
            strSql.Append(" FROM      WorkTicketInfo INNER JOIN  WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ProductTaskMain ON WorkTicket.TaskID = ProductTaskMain.ID ");
            strSql.Append(" WHERE   (WorkTicketInfo.ID = " + WTIID + ")");
            try
            {
                DbHelperSQL.ExecuteSql(strSql.ToString());
            }
            catch
            {
            }
        }
        public int GetID(int TaskID, int BoxNum, string WorkingName,int SizeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   WorkTicketInfo.ID FROM      WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ");
            strSql.Append(" Working ON WorkTicketInfo.WorkingID = Working.ID WHERE   (Working.Name = @WName) AND (WorkTicket.BoxNum = @BoxNum) ");
            strSql.Append(" AND (WorkTicketInfo.TaskID = @TaskID) And (WorkTicketInfo.EmployeeID = 0)  AND (WorkTicket.SizeID = @SizeID) ");
            SqlParameter[] sps = { new SqlParameter("@WName", WorkingName), new SqlParameter("@BoxNum", BoxNum), new SqlParameter("@TaskID", TaskID), new SqlParameter("@SizeID", SizeID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        public DateTime GetLastDate(int EmployeeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   TOP (1) DateTime FROM      PayInfo WHERE   (EmployeeID = @EmployeeID) ORDER BY DateTime DESC");
            SqlParameter[] sps = { new SqlParameter("@EmployeeID", EmployeeID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return Convert.ToDateTime(o);
            else
                return Convert.ToDateTime("1900-1-1");
        }
        public int GetNotAmountByOrders(int TaskID, int ColorID, int SizeID, int WorkingID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(WorkTicketInfo.NotAmount) AS Expr1 FROM      WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID ");
            strSql.Append(" WHERE   (WorkTicketInfo.TaskID = " + TaskID + ") ");
            if (ColorID > 0)
                strSql.Append(" AND (WorkTicket.ColorID = " + ColorID + ")");
            if (SizeID > 0)
                strSql.Append(" AND (WorkTicket.SizeID = " + SizeID + ") ");
            strSql.Append(" AND (WorkTicketInfo.WorkingID  = " + WorkingID + ")");
            strSql.Append(" AND (WorkTicketInfo.EmployeeID = 0)");
            object o = DbHelperSQL.GetSingle(strSql.ToString());
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        public int GetNotAmountByMateriel(DateTime dt1, DateTime dt2, int MaterielID, int ColorID, int SizeID, int WorkingID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(WorkTicketInfo.NotAmount) AS Expr1 FROM      WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ProductTaskMain ON WorkTicket.TaskID = ProductTaskMain.ID ");
            strSql.Append(" WHERE   (ProductTaskMain.MaterielID = "+MaterielID+") ");

            strSql.Append(" AND (WorkTicketInfo.WorkingID = " + WorkingID + ") ");
            if (ColorID > 0)
                strSql.Append(" AND (WorkTicket.ColorID =  " + ColorID + ") ");
            if (SizeID > 0)
                strSql.Append(" AND (WorkTicket.SizeID = " + SizeID + ") ");
            strSql.Append(" AND (WorkTicketInfo.EmployeeID = 0) And  (ProductTaskMain.DateTime > @dt1) AND (ProductTaskMain.DateTime < @dt2) ");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(),sps);
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        public DataSet GetStringWorkFishByTaskID(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
    
            strSql.Append(" SELECT     T.Orders, Working.Name, SUM(T.Expr1) AS Amount, SUM(T.NotAmount) AS NotAmount ");
            strSql.Append(" FROM         (SELECT     0 AS Expr1, SUM(WorkTicketInfo.Amount) AS NotAmount, WorkTicketInfo.WorkingID, ProductWorkingInfo.Orders ");
            strSql.Append(" FROM          WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID WHERE      (WorkTicket.TaskID = @TaskID) AND ");
            strSql.Append(" (WorkTicketInfo.EmployeeID = 0) GROUP BY WorkTicketInfo.WorkingID, ProductWorkingInfo.Orders UNION ALL ");
            strSql.Append(" SELECT     SUM(WorkTicketInfo_1.Amount) AS Expr1, 0 AS qwe, WorkTicketInfo_1.WorkingID, ProductWorkingInfo_1.Orders ");
            strSql.Append(" FROM         WorkTicket AS WorkTicket_1 INNER JOIN WorkTicketInfo AS WorkTicketInfo_1 ON WorkTicket_1.ID = WorkTicketInfo_1.MainID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo AS ProductWorkingInfo_1 ON WorkTicketInfo_1.PWorkingInfoID = ProductWorkingInfo_1.ID ");
            strSql.Append(" WHERE     (WorkTicket_1.TaskID = @TaskID) AND (WorkTicketInfo_1.EmployeeID > 0) GROUP BY WorkTicketInfo_1.WorkingID, ProductWorkingInfo_1.Orders) ");
            strSql.Append(" AS T INNER JOIN Working ON T.WorkingID = Working.ID GROUP BY T.Orders, Working.Name ORDER BY T.Orders");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
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
			parameters[0].Value = "WorkTicketInfo";
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

