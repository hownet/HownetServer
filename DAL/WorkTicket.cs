using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类WorkTicket。
	/// </summary>
	public class WorkTicket
	{
		public WorkTicket()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WorkTicket"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WorkTicket");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.WorkTicket model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into WorkTicket(");
            strSql.Append("ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID,OneAmount)");
            strSql.Append(" values (");
            strSql.Append("@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@Amount,@BoxNum,@TaskID,@DepartmentID,@P2DInfoID,@EligibleAmount,@InferiorAmount,@P2DDepartmentID,@MListID,@BrandID,@OneAmount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@P2DInfoID", SqlDbType.Int,4),
					new SqlParameter("@EligibleAmount", SqlDbType.Int,4),
					new SqlParameter("@InferiorAmount", SqlDbType.Int,4),
					new SqlParameter("@P2DDepartmentID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@OneAmount", SqlDbType.Int,4)};
            parameters[0].Value = model.ColorID;
            parameters[1].Value = model.ColorOneID;
            parameters[2].Value = model.ColorTwoID;
            parameters[3].Value = model.SizeID;
            parameters[4].Value = model.Amount;
            parameters[5].Value = model.BoxNum;
            parameters[6].Value = model.TaskID;
            parameters[7].Value = model.DepartmentID;
            parameters[8].Value = model.P2DInfoID;
            parameters[9].Value = model.EligibleAmount;
            parameters[10].Value = model.InferiorAmount;
            parameters[11].Value = model.P2DDepartmentID;
            parameters[12].Value = model.MListID;
            parameters[13].Value = model.BrandID;
            parameters[14].Value = model.OneAmount;

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
        public void Update(Hownet.Model.WorkTicket model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WorkTicket set ");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("BoxNum=@BoxNum,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("P2DInfoID=@P2DInfoID,");
            strSql.Append("EligibleAmount=@EligibleAmount,");
            strSql.Append("InferiorAmount=@InferiorAmount,");
            strSql.Append("P2DDepartmentID=@P2DDepartmentID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("OneAmount=@OneAmount");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@P2DInfoID", SqlDbType.Int,4),
					new SqlParameter("@EligibleAmount", SqlDbType.Int,4),
					new SqlParameter("@InferiorAmount", SqlDbType.Int,4),
					new SqlParameter("@P2DDepartmentID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@OneAmount", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorOneID;
            parameters[3].Value = model.ColorTwoID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.Amount;
            parameters[6].Value = model.BoxNum;
            parameters[7].Value = model.TaskID;
            parameters[8].Value = model.DepartmentID;
            parameters[9].Value = model.P2DInfoID;
            parameters[10].Value = model.EligibleAmount;
            parameters[11].Value = model.InferiorAmount;
            parameters[12].Value = model.P2DDepartmentID;
            parameters[13].Value = model.MListID;
            parameters[14].Value = model.BrandID;
            parameters[15].Value = model.OneAmount;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WorkTicket ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.WorkTicket GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID,OneAmount from WorkTicket ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.WorkTicket model = new Hownet.Model.WorkTicket();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BoxNum"].ToString() != "")
                {
                    model.BoxNum = int.Parse(ds.Tables[0].Rows[0]["BoxNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepartmentID"].ToString() != "")
                {
                    model.DepartmentID = int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["P2DInfoID"].ToString() != "")
                {
                    model.P2DInfoID = int.Parse(ds.Tables[0].Rows[0]["P2DInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EligibleAmount"].ToString() != "")
                {
                    model.EligibleAmount = int.Parse(ds.Tables[0].Rows[0]["EligibleAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["InferiorAmount"].ToString() != "")
                {
                    model.InferiorAmount = int.Parse(ds.Tables[0].Rows[0]["InferiorAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["P2DDepartmentID"].ToString() != "")
                {
                    model.P2DDepartmentID = int.Parse(ds.Tables[0].Rows[0]["P2DDepartmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OneAmount"].ToString() != "")
                {
                    model.OneAmount = int.Parse(ds.Tables[0].Rows[0]["OneAmount"].ToString());
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
            strSql.Append("select 1 as A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID,OneAmount ");
            strSql.Append(" , (SELECT   DepartmentID FROM      DepartmentTaskMain WHERE   (ID = WorkTicket.DepartmentID)) AS DepID");
            strSql.Append(" FROM WorkTicket ");
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
            strSql.Append(" ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID,OneAmount ");
            strSql.Append(" FROM WorkTicket ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
	
        /// <summary>
        /// 获得不包含列A的数据列表
        /// </summary>
        public DataSet GetListNoA(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID,OneAmount ");
            strSql.Append(" FROM WorkTicket ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetView(int TaskID, int OneAmount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  ID, ColorID, ColorOneID, ColorTwoID, SizeID, Amount, BoxNum, TaskID FROM  WorkTicket ");
            strSql.Append(" WHERE   (TaskID = @TaskID) And (OneAmount=@OneAmount)");
            strSql.Append(" order by BoxNum");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@OneAmount", OneAmount) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 用于显示工序完成情况
        /// </summary>
        /// <param name="TaskID">任务单ID</param>
        /// <returns></returns>
        public DataSet GetWorkList(int TaskID,int TaskDepID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ID, BoxNum AS 箱号,  ");
            strSql.Append(" ColorID AS 颜色, ColorOneID AS 插色一,ColorTwoID AS 插色二, ");
            strSql.Append(" SizeID ");
            strSql.Append(" AS 尺码, Amount AS 数量,BrandID as 商标, (SELECT   DeparmentID FROM      ProductTaskMain WHERE   (ID = WorkTicket.TaskID)) AS 班组 FROM WorkTicket ");
            if (TaskDepID == 0)
                strSql.Append(" WHERE (TaskID = @ID)");
            else
                strSql.Append(" WHERE (DepartmentID = @TaskDepID)");
            SqlParameter[] sps = { new SqlParameter("@ID", TaskID),new SqlParameter("@TaskDepID",TaskDepID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetReport(int TaskID,int TaskDepID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      Color WHERE   (ID = WorkTicket.ColorID)) AS ColorN, (SELECT   Name FROM      Size ");
            strSql.Append(" WHERE   (ID = WorkTicket.SizeID)) AS SizeN, WorkTicket.Amount, WorkTicket.BoxNum, WorkTicket.TaskID,  WorkTicket.ColorID, ");
            strSql.Append(" WorkTicket.SizeID, ProductWorkingInfo.GroupBy FROM      WorkTicket INNER JOIN ProductTaskMain ON WorkTicket.TaskID = ");
            strSql.Append(" ProductTaskMain.ID INNER JOIN ProductWorkingInfo ON ProductTaskMain.PWorkingID = ProductWorkingInfo.MainID ");
            if (TaskDepID > 0)
                strSql.Append(" WHERE   (WorkTicket.DepartmentID = @TaskDepID) ");
            strSql.Append(" GROUP BY WorkTicket.Amount, WorkTicket.BoxNum, WorkTicket.TaskID, WorkTicket.ColorID, WorkTicket.SizeID,  ProductWorkingInfo.GroupBy ");
            strSql.Append(" HAVING   (WorkTicket.TaskID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID),new SqlParameter("@TaskDepID",TaskDepID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetGroupReport(int GroupBy,int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = WorkTicket.ColorID)) AS ColorN, (SELECT   Name FROM      Size ");
            strSql.Append(" WHERE   (ID = WorkTicket.SizeID)) AS SizeN, WorkTicket.Amount, WorkTicket.BoxNum, WorkTicket.TaskID,  WorkTicket.ColorID, ");
            strSql.Append(" WorkTicket.SizeID, ProductWorkingInfo.GroupBy FROM      WorkTicket INNER JOIN ProductTaskMain ON WorkTicket.TaskID = ");
            strSql.Append(" ProductTaskMain.ID INNER JOIN ProductWorkingInfo ON ProductTaskMain.PWorkingID = ProductWorkingInfo.MainID ");
            strSql.Append(" GROUP BY WorkTicket.Amount, WorkTicket.BoxNum, WorkTicket.TaskID, WorkTicket.ColorID, WorkTicket.SizeID,  ProductWorkingInfo.GroupBy ");
            strSql.Append(" HAVING   (WorkTicket.TaskID = @TaskID) AND (ProductWorkingInfo.GroupBy = @GroupBy)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@GroupBy", GroupBy) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 获得只有ID值的列表
        /// </summary>
        public DataSet GetIDList(int TaskID, int OneAmount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Amount,ColorID,SizeID ");
            strSql.Append(" FROM WorkTicket ");
                strSql.Append(" Where (TaskID=@TaskID) And (OneAmount=@OneAmount)");
            strSql.Append(" order by ID");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@OneAmount", OneAmount) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        public DataSet GetInDepotList(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   TOP (1) WorkTicketInfo.Amount, WorkTicket.ColorID, WorkTicket.SizeID, WorkTicket.BoxNum, WorkTicket.MListID, ");
            strSql.Append(" WorkTicket.ColorOneID, WorkTicket.ColorTwoID, WorkTicket.BrandID,(SELECT   DepartmentID FROM      DepartmentTaskMain ");
            strSql.Append(" WHERE   (ID = WorkTicket.DepartmentID)) AS DepID, WorkTicket.DepartmentID, WorkTicket.TaskID, WorkTicket.P2DInfoID, ");
            strSql.Append(" WorkTicket.EligibleAmount, WorkTicket.InferiorAmount, WorkTicket.P2DDepartmentID, WorkTicket.ID,1 as A, WorkTicket.OneAmount FROM   WorkTicketInfo ");
            strSql.Append(" INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID WHERE   (WorkTicket.ID = @ID) ORDER BY WorkTicketInfo.Amount");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 获取单箱数量
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetOneAmount(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   OneAmount FROM      WorkTicket WHERE   (TaskID = @TaskID) ");
            strSql.Append(" GROUP BY OneAmount");
            SqlParameter[] sps = {new SqlParameter("@TaskID",TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetBoxInfo(int ID,int GroupBy)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   WorkTicket.BoxNum, WorkTicket.Amount, (SELECT   Name FROM      Color WHERE   (ID = WorkTicket.ColorID)) AS ColorName,");
            strSql.Append(" (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = WorkTicket.ColorOneID)) AS ColorOneName, (SELECT   Name FROM      Color AS Color_1 ");
            strSql.Append(" WHERE   (ID = WorkTicket.ColorTwoID)) AS ColorTwoName,(SELECT   Name FROM      Size WHERE   (ID = WorkTicket.SizeID)) AS SizeName, ");
            strSql.Append(" (SELECT   Name FROM      Materiel WHERE   (ID = WorkTicket.BrandID)) AS BrandName,(SELECT   Name FROM      Materiel AS Materiel_1 ");
            strSql.Append(" WHERE   (ID = ProductTaskMain.MaterielID)) AS MaterielName FROM      WorkTicket INNER JOIN  ProductTaskMain ON WorkTicket.TaskID = ProductTaskMain.ID ");
            strSql.Append(" WHERE   (WorkTicket.ID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@ID", ID),new SqlParameter("@GroupBy",GroupBy) };
            DataSet ds= DbHelperSQL.Query(strSql.ToString(), sps);
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   TOP (1) Working.Name , WorkTicketInfo.ID, ProductWorkingInfo.IsCanMove,WorkTicketInfo.Amount FROM      WorkTicket INNER JOIN WorkTicketInfo ON WorkTicket.ID = WorkTicketInfo.MainID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN Working ON WorkTicketInfo.WorkingID = Working.ID ");
            strSql.Append(" AND ProductWorkingInfo.WorkingID = Working.ID WHERE   (WorkTicket.ID = @ID) AND (ProductWorkingInfo.IsTicket = 1) AND (WorkTicketInfo.EmployeeID = 0) AND  ");
            strSql.Append(" (ProductWorkingInfo.GroupBy = @GroupBy) ORDER BY ProductWorkingInfo.Orders");
            ds.Tables[0].TableName = "Info";
            ds.Tables.Add(DbHelperSQL.Query(strSql.ToString(), sps).Tables[0].Copy());
            return ds;
        }
        public DataSet GetTickInfo(int TicketID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   WorkTicketInfo.ID, Working.Name, MiniEmp.Name AS EmpName, ProductWorkingInfo.GroupBy, WorkTicketInfo.Amount, WorkTicketInfo.DateTime,ProductWorkingInfo.Orders ");
            strSql.Append(" FROM      WorkTicketInfo INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN ");
            strSql.Append(" Working ON WorkTicketInfo.WorkingID = Working.ID AND ProductWorkingInfo.WorkingID = Working.ID LEFT OUTER JOIN ");
            strSql.Append(" MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID WHERE   (ProductWorkingInfo.IsTicket = 1) AND (WorkTicketInfo.MainID = @ID) ORDER BY ProductWorkingInfo.Orders");//AND (WorkTicketInfo.EmployeeID = 0) 
            SqlParameter[] sps = { new SqlParameter("@ID", TicketID) };
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
			parameters[0].Value = "WorkTicket";
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

