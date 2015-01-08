using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类WorkTicketIDBack。
	/// </summary>
	public class WorkTicketIDBack
	{
		public WorkTicketIDBack()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WorkTicketIDBack"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WorkTicketIDBack");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.WorkTicketIDBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WorkTicketIDBack(");
			strSql.Append("DateTime,TicketIDCardID,EmployeeIDCardID,WorkTicketID,WorkingID)");
			strSql.Append(" values (");
			strSql.Append("@DateTime,@TicketIDCardID,@EmployeeIDCardID,@WorkTicketID,@WorkingID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@TicketIDCardID", SqlDbType.NVarChar,20),
					new SqlParameter("@EmployeeIDCardID", SqlDbType.Int,4),
					new SqlParameter("@WorkTicketID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4)};
			parameters[0].Value = model.DateTime;
			parameters[1].Value = model.TicketIDCardID;
			parameters[2].Value = model.EmployeeIDCardID;
			parameters[3].Value = model.WorkTicketID;
			parameters[4].Value = model.WorkingID;

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
		public void Update(Hownet.Model.WorkTicketIDBack model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WorkTicketIDBack set ");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("TicketIDCardID=@TicketIDCardID,");
			strSql.Append("EmployeeIDCardID=@EmployeeIDCardID,");
			strSql.Append("WorkTicketID=@WorkTicketID,");
			strSql.Append("WorkingID=@WorkingID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@TicketIDCardID", SqlDbType.NVarChar,20),
					new SqlParameter("@EmployeeIDCardID", SqlDbType.Int,4),
					new SqlParameter("@WorkTicketID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DateTime;
			parameters[2].Value = model.TicketIDCardID;
			parameters[3].Value = model.EmployeeIDCardID;
			parameters[4].Value = model.WorkTicketID;
			parameters[5].Value = model.WorkingID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from WorkTicketIDBack ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.WorkTicketIDBack GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DateTime,TicketIDCardID,EmployeeIDCardID,WorkTicketID,WorkingID from WorkTicketIDBack ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.WorkTicketIDBack model=new Hownet.Model.WorkTicketIDBack();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
				}
					model.TicketIDCardID=ds.Tables[0].Rows[0]["TicketIDCardID"].ToString().Trim();
				if(ds.Tables[0].Rows[0]["EmployeeIDCardID"].ToString()!="")
				{
					model.EmployeeIDCardID=int.Parse(ds.Tables[0].Rows[0]["EmployeeIDCardID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WorkTicketID"].ToString()!="")
				{
					model.WorkTicketID=int.Parse(ds.Tables[0].Rows[0]["WorkTicketID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WorkingID"].ToString()!="")
				{
					model.WorkingID=int.Parse(ds.Tables[0].Rows[0]["WorkingID"].ToString());
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
			strSql.Append("select ID,DateTime,TicketIDCardID,EmployeeIDCardID,WorkTicketID,WorkingID ");
			strSql.Append(" FROM WorkTicketIDBack ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,DateTime,TicketIDCardID,EmployeeIDCardID,WorkTicketID,WorkingID ");
			strSql.Append(" FROM WorkTicketIDBack ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public void AddPayInfo(int MaterielID,int InfoID,string oderNum)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" INSERT INTO PayInfo (ColorID, SizeID, Amount, BoxNum, DateTime, EmployeeID, ProductWorkingID, ");
            strSql.Append(" WorkingID, Price, OderNum, MaterielID, WorkticketInfoID) SELECT WorkTicket.ColorID, ");
            strSql.Append(" WorkTicket.SizeID, WorkTicket.Amount, WorkTicket.BoxNum, WorkticketInfo.DateTime, ");
            strSql.Append(" WorkticketInfo.EmployeeID, ProductWorkingInfo.ProductWorkingID, ProductWorkingInfo.WorkingID, ");
            strSql.Append(" ProductWorkingInfo.Price, @OderNum, @MaterielID, WorkticketInfo.InfoID FROM WorkticketInfo ");
            strSql.Append(" INNER JOIN WorkTicket ON WorkticketInfo.MainID = WorkTicket.WorkTicketID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkticketInfo.WorkingID = ProductWorkingInfo.ProductWorkingID ");
            strSql.Append(" WHERE (WorkticketInfo.InfoID = @InfoID)");
            SqlParameter[] sps = {new SqlParameter("@OderNum",oderNum),new SqlParameter("@MaterielID",MaterielID),
                                 new SqlParameter("@InfoID",InfoID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetWorkingByTicketID(int GroupBy, int TicketID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ProductWorkingInfo.WorkingID, WorkTicket.Amount, WorkticketInfo.InfoID, ProductWorkingInfo.Orders, ");
            strSql.Append(" Working.WorkingName, ProduceTaskMain.MaterielID, ProduceTaskMain.Num, ProduceTaskMain.DateTime, ");
            strSql.Append(" Materiel.MaterielName, MaterielAttribute_1.MaterielAttributeName AS SizeName,WorkticketInfo.EmployeeID, ");
            strSql.Append(" MaterielAttribute.MaterielAttributeName AS ColorName FROM MaterielAttribute INNER JOIN ");
            strSql.Append(" WorkticketInfo INNER JOIN ProductWorkingInfo ON WorkticketInfo.WorkingID = ");
            strSql.Append(" ProductWorkingInfo.ProductWorkingID INNER JOIN Working ON ProductWorkingInfo.WorkingID ");
            strSql.Append(" = Working.WorkingID INNER JOIN WorkTicket ON WorkticketInfo.MainID = WorkTicket.WorkTicketID ");
            strSql.Append(" INNER JOIN ProduceTaskMain ON WorkTicket.ProductTaskID = ProduceTaskMain.ProduceTaskID INNER ");
            strSql.Append(" JOIN Materiel ON ProduceTaskMain.MaterielID = Materiel.MaterielID ON ");
            strSql.Append(" MaterielAttribute.MaterielAttributeID = WorkTicket.ColorID INNER JOIN MaterielAttribute AS ");
            strSql.Append(" MaterielAttribute_1 ON WorkTicket.SizeID = MaterielAttribute_1.MaterielAttributeID ");
            strSql.Append(" WHERE (WorkticketInfo.MainID = @TicketID) AND (ProductWorkingInfo.GroupBy = @GroupBy) ");
            //strSql.Append(" AND (WorkticketInfo.EmployeeID = 0)");
            strSql.Append("  ORDER BY ProductWorkingInfo.Orders");
            SqlParameter[] sps = { new SqlParameter("@TicketID", TicketID), new SqlParameter("@GroupBy", GroupBy) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public string CountAmount(int EmpID, DateTime dt)
        {
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CAST(SUM(PayInfo.Amount) AS VarChar) + '件' + CAST(CAST(SUM(PayInfo.Amount ");
            strSql.Append(" * ProductWorkingInfo.Price) AS real) AS varchar) + '元' AS Money FROM PayInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ProductWorkingID ");
            strSql.Append(" WHERE (PayInfo.EmployeeID = @EmpID) AND (PayInfo.DateTime > @dt1) AND  (PayInfo.DateTime < @dt2)");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmpID),
                                 new SqlParameter("@dt1",dt1),new SqlParameter("@dt2",dt2)};
            return DbHelperSQL.GetSingle(strSql.ToString(), sps).ToString();
        }
        public DataSet GetKey(int TicketID, int WorkOrder, int SizeID, int ColorID)
        {
            StringBuilder strSql = new StringBuilder();
            if (SizeID == 0 && ColorID == 0)
            {
                strSql.Append(" SELECT ProductWorkingInfo.Orders, Employee.EmployeeName, Working.WorkingName, ");
                strSql.Append(" WorkticketInfo.DateTime, '' AS SizeName, '' AS ColorName FROM WorkTicket INNER JOIN ");
                strSql.Append(" WorkticketInfo ON WorkTicket.WorkTicketID = WorkticketInfo.MainID INNER JOIN ");
                strSql.Append(" ProductWorkingInfo ON WorkticketInfo.WorkingID = ProductWorkingInfo.ProductWorkingID ");
                strSql.Append(" INNER JOIN Working ON ProductWorkingInfo.WorkingID = Working.WorkingID LEFT OUTER JOIN ");
                strSql.Append(" Employee ON WorkticketInfo.EmployeeID = Employee.EmployeeID WHERE (WorkTicket.WorkTicketID = @TicketID)");
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
        public string GetEmployee(int EmpID, int typeID, DateTime dt)
        {
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            if (typeID == 2)
            {
                dt1 = DateTime.Parse(dt.Year.ToString() + "-" + dt.Month.ToString() + "-" + "01");
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CAST(SUM(PayInfo.Amount) AS varchar) + '件' + CAST(CAST(SUM(PayInfo.Amount * ");
            strSql.Append(" ProductWorkingInfo.Price) AS real) AS varchar) + '元' AS Money FROM PayInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON PayInfo.ProductWorkingID = ProductWorkingInfo.ProductWorkingID ");
            strSql.Append(" WHERE (PayInfo.DateTime > @dt1) AND (PayInfo.DateTime < @dt2) AND (PayInfo.EmployeeID = @EmpID)");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmpID),
                                 new SqlParameter("@dt1",dt1),new SqlParameter("@dt2",dt2)};
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (obj != null)
                return obj.ToString();
            else
                return "";
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
			parameters[0].Value = "WorkTicketIDBack";
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

