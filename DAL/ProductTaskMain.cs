using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类ProductTaskMain。
	/// </summary>
	public class ProductTaskMain
	{
		public ProductTaskMain()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ProductTaskMain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProductTaskMain");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ProductTaskMain model)
        {
           
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ProductTaskMain(");
            strSql.Append("SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,ParentID,DeparmentType,Price)");
            strSql.Append(" values (");
            strSql.Append("@SalesOrderInfoID,@MaterielID,@BrandID,@Num,@DateTime,@LastDate,@Remark,@PWorkingID,@BomID,@CompanyID,@IsTicket,@IsBom,@IsVerify,@VerifyDate,@VerifyMan,@DeparmentID,@UpData,@FillDate,@FilMan,@TicketDate,@BedNO,@PackingMethodID,@SewingRemark,@ParentID,@DeparmentType,@Price)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SalesOrderInfoID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@PWorkingID", SqlDbType.Int,4),
					new SqlParameter("@BomID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@IsTicket", SqlDbType.Bit,1),
					new SqlParameter("@IsBom", SqlDbType.Bit,1),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FilMan", SqlDbType.Int,4),
					new SqlParameter("@TicketDate", SqlDbType.DateTime),
					new SqlParameter("@BedNO", SqlDbType.NVarChar,50),
					new SqlParameter("@PackingMethodID", SqlDbType.Int,4),
					new SqlParameter("@SewingRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentType", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9)};
            parameters[0].Value = model.SalesOrderInfoID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.BrandID;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.DateTime;
            parameters[5].Value = model.LastDate;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.PWorkingID;
            parameters[8].Value = model.BomID;
            parameters[9].Value = model.CompanyID;
            parameters[10].Value = model.IsTicket;
            parameters[11].Value = model.IsBom;
            parameters[12].Value = model.IsVerify;
            parameters[13].Value = model.VerifyDate;
            parameters[14].Value = model.VerifyMan;
            parameters[15].Value = model.DeparmentID;
            parameters[16].Value = model.UpData;
            parameters[17].Value = model.FillDate;
            parameters[18].Value = model.FilMan;
            parameters[19].Value = model.TicketDate;
            parameters[20].Value = model.BedNO;
            parameters[21].Value = model.PackingMethodID;
            parameters[22].Value = model.SewingRemark;
            parameters[23].Value = model.ParentID;
            parameters[24].Value = model.DeparmentType;
            parameters[25].Value = model.Price;

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
        public bool Update(Hownet.Model.ProductTaskMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProductTaskMain set ");
            strSql.Append("SalesOrderInfoID=@SalesOrderInfoID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("Num=@Num,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("LastDate=@LastDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("PWorkingID=@PWorkingID,");
            strSql.Append("BomID=@BomID,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("IsTicket=@IsTicket,");
            strSql.Append("IsBom=@IsBom,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("DeparmentID=@DeparmentID,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("FilMan=@FilMan,");
            strSql.Append("TicketDate=@TicketDate,");
            strSql.Append("BedNO=@BedNO,");
            strSql.Append("PackingMethodID=@PackingMethodID,");
            strSql.Append("SewingRemark=@SewingRemark,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("DeparmentType=@DeparmentType,");
            strSql.Append("Price=@Price");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@SalesOrderInfoID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@PWorkingID", SqlDbType.Int,4),
					new SqlParameter("@BomID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@IsTicket", SqlDbType.Bit,1),
					new SqlParameter("@IsBom", SqlDbType.Bit,1),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FilMan", SqlDbType.Int,4),
					new SqlParameter("@TicketDate", SqlDbType.DateTime),
					new SqlParameter("@BedNO", SqlDbType.NVarChar,50),
					new SqlParameter("@PackingMethodID", SqlDbType.Int,4),
					new SqlParameter("@SewingRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentType", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.SalesOrderInfoID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.BrandID;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.DateTime;
            parameters[5].Value = model.LastDate;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.PWorkingID;
            parameters[8].Value = model.BomID;
            parameters[9].Value = model.CompanyID;
            parameters[10].Value = model.IsTicket;
            parameters[11].Value = model.IsBom;
            parameters[12].Value = model.IsVerify;
            parameters[13].Value = model.VerifyDate;
            parameters[14].Value = model.VerifyMan;
            parameters[15].Value = model.DeparmentID;
            parameters[16].Value = model.UpData;
            parameters[17].Value = model.FillDate;
            parameters[18].Value = model.FilMan;
            parameters[19].Value = model.TicketDate;
            parameters[20].Value = model.BedNO;
            parameters[21].Value = model.PackingMethodID;
            parameters[22].Value = model.SewingRemark;
            parameters[23].Value = model.ParentID;
            parameters[24].Value = model.DeparmentType;
            parameters[25].Value = model.Price;
            parameters[26].Value = model.ID;

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
            strSql.Append("delete from ProductTaskMain ");
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
            strSql.Append("delete from ProductTaskMain ");
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
        public Hownet.Model.ProductTaskMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,ParentID,DeparmentType,Price from ProductTaskMain ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.ProductTaskMain model = new Hownet.Model.ProductTaskMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SalesOrderInfoID"] != null && ds.Tables[0].Rows[0]["SalesOrderInfoID"].ToString() != "")
                {
                    model.SalesOrderInfoID = int.Parse(ds.Tables[0].Rows[0]["SalesOrderInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"] != null && ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastDate"] != null && ds.Tables[0].Rows[0]["LastDate"].ToString() != "")
                {
                    model.LastDate = DateTime.Parse(ds.Tables[0].Rows[0]["LastDate"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["PWorkingID"] != null && ds.Tables[0].Rows[0]["PWorkingID"].ToString() != "")
                {
                    model.PWorkingID = int.Parse(ds.Tables[0].Rows[0]["PWorkingID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BomID"] != null && ds.Tables[0].Rows[0]["BomID"].ToString() != "")
                {
                    model.BomID = int.Parse(ds.Tables[0].Rows[0]["BomID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsTicket"] != null && ds.Tables[0].Rows[0]["IsTicket"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsTicket"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsTicket"].ToString().ToLower() == "true"))
                    {
                        model.IsTicket = true;
                    }
                    else
                    {
                        model.IsTicket = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsBom"] != null && ds.Tables[0].Rows[0]["IsBom"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsBom"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsBom"].ToString().ToLower() == "true"))
                    {
                        model.IsBom = true;
                    }
                    else
                    {
                        model.IsBom = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsVerify"] != null && ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"] != null && ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"] != null && ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DeparmentID"] != null && ds.Tables[0].Rows[0]["DeparmentID"].ToString() != "")
                {
                    model.DeparmentID = int.Parse(ds.Tables[0].Rows[0]["DeparmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"] != null && ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"] != null && ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FilMan"] != null && ds.Tables[0].Rows[0]["FilMan"].ToString() != "")
                {
                    model.FilMan = int.Parse(ds.Tables[0].Rows[0]["FilMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TicketDate"] != null && ds.Tables[0].Rows[0]["TicketDate"].ToString() != "")
                {
                    model.TicketDate = DateTime.Parse(ds.Tables[0].Rows[0]["TicketDate"].ToString());
                }
                model.BedNO = ds.Tables[0].Rows[0]["BedNO"].ToString();
                if (ds.Tables[0].Rows[0]["PackingMethodID"] != null && ds.Tables[0].Rows[0]["PackingMethodID"].ToString() != "")
                {
                    model.PackingMethodID = int.Parse(ds.Tables[0].Rows[0]["PackingMethodID"].ToString());
                }
                model.SewingRemark = ds.Tables[0].Rows[0]["SewingRemark"].ToString();
                if (ds.Tables[0].Rows[0]["ParentID"] != null && ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DeparmentType"] != null && ds.Tables[0].Rows[0]["DeparmentType"].ToString() != "")
                {
                    model.DeparmentType = int.Parse(ds.Tables[0].Rows[0]["DeparmentType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
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
            strSql.Append("select  1 as A,ID,SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,ParentID,DeparmentType,Price ");
            strSql.Append(" ,(Select TrueName from Users where (ID=ProductTaskMain.FilMan)) as Fill,(Select TrueName from Users where (ID=ProductTaskMain.VerifyMan)) as Verify");
            strSql.Append(" , (CASE WHEN (DeparmentType = 3) THEN (SELECT   Name FROM      company WHERE   (ID = ProductTaskMain.DeparmentID)) ELSE (SELECT   Name FROM      Deparment WHERE   (ID = ProductTaskMain.DeparmentID)) END) AS DeparmentName");
            strSql.Append(" FROM ProductTaskMain ");
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
            strSql.Append(" ID,SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,ParentID,DeparmentType,Price ");
            strSql.Append(" FROM ProductTaskMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }



        //本厂生产制单
        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from ProductTaskMain Where ParentID>-2 order by ID ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int NewNum(DateTime dt,int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            if (TypeID == 0)
            {
                strSql.Append("SELECT   MAX(Num) AS Expr1 FROM      ProductTaskMain");
            }
            else if (TypeID == 1)
            {
                strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProductTaskMain WHERE   (YEAR(DateTime) = YEAR(@dt))");
            }
            else if (TypeID == 2)
            {
                strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProductTaskMain WHERE   (YEAR(DateTime) = YEAR(@dt)) AND (MONTH(DateTime) = MONTH(@dt))");
            }
            else if (TypeID == 3)
            {
                strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProductTaskMain WHERE   (DateTime = @dt)");
            }
            SqlParameter[] sps = { new SqlParameter("@dt", dt) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
        public DataSet GetTicketMain(int TaskID,int TaskDepID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID, ColorID, ColorOneID,ColorTwoID,");
            strSql.Append(" SizeID, Amount, BoxNum, (SELECT   DepartmentID FROM      ProductTaskMain WHERE   (ID = WorkTicket.TaskID)) AS DepID ");
            strSql.Append(" FROM      WorkTicket");
            if (TaskDepID == 0)
                strSql.Append(" WHERE   (TaskID = @TaskID)");
            else
                strSql.Append(" WHERE   (DepartmentID = @TaskDepID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TaskDepID", TaskDepID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetTicketInfo(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   WorkTicketInfo.MainID,ProductWorkingInfo.Orders, Working.Name AS WorkName, WorkTicketInfo.DateTime, (SELECT   Name  FROM      MiniEmp ");
            //strSql.Append(" WHERE   (ID = WorkTicketInfo.EmployeeID)) AS Employee, WorkTicketInfo.ID,WorkTicketInfo.Amount,1 as A,WorkTicketInfo.IsDel, ");
            //strSql.Append(" WorkTicketInfo.PWorkingInfoID,WorkTicketInfo.EmployeeID,WorkTicketInfo.BackID,WorkTicketInfo.NotAmount,WorkTicketInfo.TaskID,WorkTicketInfo.WorkingID");
            //strSql.Append(" FROM      WorkTicketInfo INNER JOIN ");
            //strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN Working ON ProductWorkingInfo.WorkingID = Working.ID ");
            //strSql.Append(" WHERE   (WorkTicketInfo.MainID = @MainID) ORDER BY ProductWorkingInfo.Orders");
            strSql.Append("SELECT   WorkTicketInfo.MainID, ProductWorkingInfo.Orders, WorkTicketInfo.DateTime, WorkTicketInfo.EmployeeID, ");
            strSql.Append(" WorkTicketInfo.ID, WorkTicketInfo.Amount,WorkTicketInfo.OutAmount, 1 AS A, WorkTicketInfo.IsDel, WorkTicketInfo.PWorkingInfoID, ");
            strSql.Append(" WorkTicketInfo.BackID, WorkTicketInfo.NotAmount, WorkTicketInfo.TaskID, WorkTicketInfo.WorkingID FROM ");
            strSql.Append(" WorkTicketInfo INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE   (WorkTicketInfo.MainID = @MainID) ORDER BY ProductWorkingInfo.Orders");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetReport(int TaskID,int TaskDepID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT  WorkTicket.BoxNum,WorkTicket.Amount as BoxAmount,WorkTicketInfo.Amount, Color.Name AS ColorName, Working.Name AS WorkName, ");
            //strSql.Append(" Size.Name AS SizeName, ProductWorkingInfo.GroupBy, ProductWorkingInfo.Orders,ProductWorkingInfo.CustOder, WorkTicketInfo.WorkingID, ");
            //strSql.Append(" WorkTicket.TaskID, WorkTicket.ID FROM      Size INNER JOIN WorkTicket INNER JOIN ");
            //strSql.Append(" Color ON WorkTicket.ColorID = Color.ID ON Size.ID = WorkTicket.SizeID INNER JOIN ProductWorkingInfo INNER JOIN ");
            //strSql.Append(" WorkTicketInfo ON ProductWorkingInfo.ID = WorkTicketInfo.PWorkingInfoID INNER JOIN ");
            //strSql.Append(" Working ON ProductWorkingInfo.WorkingID = Working.ID ON WorkTicket.ID = WorkTicketInfo.MainID ");
            //strSql.Append(" WHERE   (WorkTicket.TaskID = @TaskID) AND (ProductWorkingInfo.IsTicket = 1) ");
            //if (TaskDepID > 0)
            //    strSql.Append(" AND (WorkTicket.DepartmentID = @TaskDepID) ");
            //strSql.Append(" ORDER BY ProductWorkingInfo.Orders DESC");
            strSql.Append(" SELECT   WorkTicket.BoxNum, WorkTicket.Amount AS BoxAmount, WorkTicketInfo.Amount, (SELECT   Name FROM      Color ");
            strSql.Append(" WHERE   (ID = WorkTicket.ColorID)) AS ColorName, Working.Name AS WorkName, (SELECT   Name FROM      Size ");
            strSql.Append(" WHERE   (ID = WorkTicket.SizeID)) AS SizeName, ProductWorkingInfo.GroupBy, ProductWorkingInfo.Orders, ");
            strSql.Append(" ProductWorkingInfo.CustOder, WorkTicketInfo.WorkingID, WorkTicket.TaskID, WorkTicket.ID FROM      WorkTicket INNER JOIN ");
            strSql.Append(" ProductWorkingInfo INNER JOIN WorkTicketInfo ON ProductWorkingInfo.ID = WorkTicketInfo.PWorkingInfoID INNER JOIN ");
            strSql.Append(" Working ON ProductWorkingInfo.WorkingID = Working.ID ON WorkTicket.ID = WorkTicketInfo.MainID ");
            strSql.Append(" WHERE   (WorkTicket.TaskID = @TaskID) AND (ProductWorkingInfo.IsTicket = 1) ORDER BY ProductWorkingInfo.Orders DESC");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TaskDepID", TaskDepID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetTickInfo(int TaskID,int TaskDepID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = WorkTicket.ColorID)) AS ColorName, ");
            strSql.Append(" (SELECT   Name FROM      Size WHERE   (ID = WorkTicket.SizeID)) AS SizeName, Amount, BoxNum ");
            strSql.Append(" ,  (SELECT   Name FROM      Deparment WHERE   (ID = (SELECT   DepartmentID FROM      DepartmentTaskMain ");
            strSql.Append(" WHERE   (ID = WorkTicket.DepartmentID)))) AS DeparmentName FROM      WorkTicket");
            if (TaskDepID == 0)
                strSql.Append(" WHERE   (TaskID = @TaskID)");
            else
                strSql.Append(" WHERE   (DepartmentID = @TaskDepID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID),new SqlParameter("@TaskDepID",TaskDepID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetNum(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Num,DateTime ");
            strSql.Append(" FROM ProductTaskMain  WHERE   (ID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int Count()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(ID) AS Expr1 FROM      ProductTaskMain");
            return int.Parse(DbHelperSQL.GetSingle(strSql.ToString()).ToString());
        }
        public DataSet GetNumList()
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) + REPLACE(STR(Num, 3, 0), ' ', '0') AS Num, ID,(SELECT   Name ");
            // strSql.Append(" FROM      Materiel WHERE   (ID = ProductTaskMain.MaterielID)) AS MaterielName FROM      ProductTaskMain");
            //strSql.Append(" SELECT   CONVERT(varchar(100), ProductionPlan.DateTime, 112) + '-' + REPLACE(STR(ProductionPlan.Num, 3, 0), ' ', '0') ");
            //strSql.Append(" AS Num, ProductTaskMain.ID,(SELECT   Name FROM      Materiel WHERE   (ID = ProductTaskMain.MaterielID)) AS MaterielName, ");
            //strSql.Append(" ProductTaskMain.BedNO FROM      ProductTaskMain INNER JOIN ProductionPlan ON ProductTaskMain.ParentID = ProductionPlan.ID");
            strSql.Append(" SELECT   CONVERT(varchar(100), ProductTaskMain.DateTime, 112) + '-' + CAST(ProductTaskMain.Num AS varchar) ");
            strSql.Append(" AS Num, ProductTaskMain.ID, ProductTaskMain.BedNO, Materiel_1.Name AS MaterielName, ProductTaskMain.ParentID ");
            strSql.Append(" FROM      ProductTaskMain LEFT OUTER JOIN Materiel AS Materiel_1 ON ProductTaskMain.MaterielID = Materiel_1.ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetTaskList(int TableTypeID, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  BedNO, CONVERT(varchar(100), DateTime, 112) + CAST(Num AS varchar)+ '-'+ BedNO AS Num,DeparmentID, ID, MaterielID,ParentID, DeparmentType,IsTicket,PWorkingID,");
            strSql.Append(" (CASE WHEN (DeparmentType = 3) THEN (SELECT   Name FROM      company WHERE   (ID = ProductTaskMain.DeparmentID)) ELSE (SELECT   Name FROM      Deparment WHERE   (ID = ProductTaskMain.DeparmentID)) END) AS DeparmentName ,");
            strSql.Append("  (SELECT   FillMan FROM      SalesOrderInfoList WHERE   (ID = (SELECT   SalesOrderInfoID FROM      ProductionPlan WHERE   (ID = ProductTaskMain.ParentID)))) AS FillMans, ");
            strSql.Append(" CompanyID, BrandID, DateTime, (SELECT   SUM(Amount) AS SumAmount FROM AmountInfo WHERE (MainID = ");
            strSql.Append(" ProductTaskMain.ID) AND (TableTypeID = @TableTypeID)) AS SumAmount,IsVerify,(select TypeID from materiel where (ID=ProductTaskMain.MaterielID)) as TypeID  ");
            strSql.Append(",LastDate, ");//(Select FilMan from ProductionPlan where (ID=ProductTaskMain.ParentID))
            strSql.Append("  (SELECT   SUM(NotAmount) AS SumAmount FROM AmountInfo WHERE (MainID = ");
            strSql.Append(" ProductTaskMain.ID) AND (TableTypeID = @TableTypeID)) AS NotAmount ");
            strSql.Append(" FROM ProductTaskMain ");
            if (strWhere.Length > 0)
                strSql.Append(" where " + strWhere);
            strSql.Append("  ORDER BY DateTime");
            SqlParameter[] sps = { new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetGroupWorkingList(int MaterielID, int BrandID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID, SUM(AmountInfo.NotAmount) ");
            strSql.Append(" AS Amount FROM      AmountInfo INNER JOIN ProductTaskMain ON AmountInfo.MainID = ProductTaskMain.ID WHERE ");
            strSql.Append(" (AmountInfo.TableTypeID = 1) GROUP BY AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, ");
            strSql.Append(" AmountInfo.SizeID, ProductTaskMain.MaterielID,  ProductTaskMain.BrandID  HAVING   (ProductTaskMain.MaterielID = @MaterielID) AND (ProductTaskMain.BrandID = @BrandID)");
            SqlParameter[] sps = { new SqlParameter("@BrandID", BrandID), new SqlParameter("@MaterielID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetToDepList(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Deparment.Name + '，' + CAST(SUM(AmountInfo.Amount) AS nvarchar) + '件' AS Name, DepartmentTaskMain.ID ");
            strSql.Append(" FROM      DepartmentTaskMain INNER JOIN AmountInfo ON DepartmentTaskMain.ID = AmountInfo.MainID INNER JOIN ");
            strSql.Append(" Deparment ON DepartmentTaskMain.DepartmentID = Deparment.ID WHERE   (AmountInfo.TableTypeID = 37) AND ");
            strSql.Append(" (DepartmentTaskMain.TaskID = @TaskID) GROUP BY DepartmentTaskMain.ID, Deparment.Name");
            SqlParameter[] sps = { new SqlParameter("@TaskID",TaskID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetWorkAmount(int MaterielID, int BrandID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID, SUM(AmountInfo.NotAmount) ");
            strSql.Append(" AS Amount FROM      ProductTaskMain INNER JOIN AmountInfo ON ProductTaskMain.ID = AmountInfo.MainID WHERE   ");
            strSql.Append(" (ProductTaskMain.MaterielID = @MaterielID) AND (ProductTaskMain.BrandID = @BrandID) AND  (AmountInfo.TableTypeID = ");
            strSql.Append(" @TableTypeID) AND (ProductTaskMain.IsVerify = 3) And (AmountInfo.NotAmount > 0) And (ProductTaskMain.IsTicket=1)");
            strSql.Append(" GROUP BY AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, ");
            strSql.Append(" AmountInfo.SizeID    ");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID), new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetWorkAmountByCS(int MaterielID, int BrandID, int TableTypeID, int ColorID, int ColorOneID, int ColorTwoID, int SizeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID, SUM(AmountInfo.NotAmount) ");
            strSql.Append(" AS Amount FROM      ProductTaskMain INNER JOIN AmountInfo ON ProductTaskMain.ID = AmountInfo.MainID WHERE   ");
            strSql.Append(" (ProductTaskMain.MaterielID = @MaterielID) AND (ProductTaskMain.BrandID = @BrandID) And (ProductTaskMain.IsTicket=1) AND  (AmountInfo.TableTypeID = ");
            strSql.Append(" @TableTypeID) AND (ProductTaskMain.IsVerify = 3) AND (AmountInfo.NotAmount > 0) GROUP BY AmountInfo.ColorID, ");
            strSql.Append(" AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID HAVING   (AmountInfo.ColorID = @ColorID) AND ");
            strSql.Append(" (AmountInfo.ColorOneID = @ColorOneID) AND  (AmountInfo.ColorTwoID = @ColorTwoID) AND (AmountInfo.SizeID = @SizeID)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID), new SqlParameter("@TableTypeID", TableTypeID) ,
                                 new SqlParameter("@ColorID",ColorID),new SqlParameter("@ColorOneID",ColorOneID),new SqlParameter("@ColorTwoID",ColorTwoID),
                                 new SqlParameter("@SizeID",SizeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public bool CheckNum(DateTime dt, int Num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   DateTime, Num FROM  ProductTaskMain WHERE   (DateTime = @dt) AND (Num = @Num)");
            SqlParameter[] sps = { new SqlParameter("@dt", dt), new SqlParameter("@Num", Num) };
            if (DbHelperSQL.Query(strSql.ToString(), sps).Tables[0].Rows.Count == 0)
                return true;
            else
                return false;
        }
        public DataSet GetNumListByDeparmentID(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) +'-'+ CAST(Num AS varchar)+'-'+BedNO AS Num,BedNO, ID,(SELECT   Name ");
            strSql.Append(" FROM      Materiel WHERE   (ID = ProductTaskMain.MaterielID)) AS MaterielName,ParentID,DeparmentID,MaterielID FROM      ProductTaskMain");
            strSql.Append(" where (IsVerify=3) ");
            if (strWhere.Length > 0)
                strSql.Append(" And" + strWhere);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public bool CheckHasToDepot(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(ID) AS Expr1 FROM      Product2DepotInfo WHERE   (TaskID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps))>0;
        }
        public void UpAmount(int TaskID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" UPDATE  AmountInfo SET         NotDepAmount = 0, NotAmount = 0 ");
            strSql.Append(" WHERE   (MainID = @TaskID) AND (TableTypeID = @TableTypeID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 获取生产单的款号
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public string GetMaterielName(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Materiel_1.Name AS MaterielName FROM      Materiel AS Materiel_1 INNER JOIN ");
            strSql.Append(" ProductTaskMain ON Materiel_1.ID = ProductTaskMain.MaterielID WHERE   (ProductTaskMain.ID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return o.ToString();
            else
                return string.Empty;
        }
        /// <summary>
        /// 获取该生产单的领料记录
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetLinLiaoList(int TaskID,int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID FROM      StockBack WHERE   (State = @TypeID) AND (TaskID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TypeID", TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        //委外生产制单
        public DataSet GetWWIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from ProductTaskMain  Where ParentID=-3 order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取某款号的新床号
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public int GetMaxBedNO(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(CAST(BedNO AS int)) AS Expr1 FROM      ProductTaskMain ");// WHERE   (MaterielID = @MaterielID)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps)) + 1;
        }
        /// <summary>
        /// 返回汇总的数据
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataSet GetSumTaskList(DateTime dt1, DateTime dt2, int MatID, int DeparmentID,string DepName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  0 as ID,0 as IsVerify, ProductTaskMain.MaterielID, ProductTaskMain.PWorkingID, SUM(AmountInfo.Amount) AS SumAmount ");
            if(DeparmentID>0)
                strSql.Append(" ,'" + DepName + "' as DeparmentName");
            strSql.Append(" FROM      ProductTaskMain INNER JOIN AmountInfo ON ProductTaskMain.ID = AmountInfo.MainID ");
            strSql.Append(" WHERE   (AmountInfo.TableTypeID = 1) AND (ProductTaskMain.DateTime > @dt1) AND (ProductTaskMain.DateTime < @dt2) ");
            if (MatID > 0)
                strSql.Append(" And   (ProductTaskMain.MaterielID = @MatID) ");
            if(DeparmentID>0)
                strSql.Append(" And   (ProductTaskMain.DeparmentID = @DeparmentID) ");
            strSql.Append(" GROUP BY ProductTaskMain.MaterielID, ProductTaskMain.PWorkingID");

            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2),new SqlParameter("@MatID",MatID),new SqlParameter("@DeparmentID",DeparmentID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 某款号使用某工艺单的数量
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <returns></returns>
        public DataSet GetSumAmount(DateTime dt1, DateTime dt2, int MatID, int PWID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   AmountInfo.ColorID, AmountInfo.SizeID, SUM(AmountInfo.Amount) AS Amount, AmountInfo.ColorOneID, AmountInfo.ColorTwoID ");
            strSql.Append(" FROM      ProductTaskMain INNER JOIN AmountInfo ON ProductTaskMain.ID = AmountInfo.MainID ");
            strSql.Append(" WHERE   (AmountInfo.TableTypeID = 1) AND (ProductTaskMain.DateTime > @dt1) AND (ProductTaskMain.DateTime < @dt2) AND  ");
            strSql.Append(" (ProductTaskMain.MaterielID = @MatID) AND (ProductTaskMain.PWorkingID = @PWID) GROUP BY AmountInfo.ColorID, AmountInfo.SizeID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@MatID", MatID), new SqlParameter("@PWID", PWID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetTicketInfoCard(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = WorkTicket.ColorID)) AS ColorName, (SELECT   Name FROM      Size ");
            strSql.Append(" WHERE   (ID = WorkTicket.SizeID)) AS SizeName, WorkTicket.Amount, WorkTicket.BoxNum, WorkTicketIDCard.IDCardNo, WorkTicketIDCard.GroupBy ");
            strSql.Append(" FROM      WorkTicket LEFT OUTER JOIN WorkTicketIDCard ON WorkTicket.ID = WorkTicketIDCard.TicketID WHERE   (WorkTicket.TaskID = " + MainID + ")");
            return DbHelperSQL.Query(strSql.ToString());

        }
        public DataSet GetMaterielByDeparmentID(int DeparmentID, int DeparmentTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Materiel.ID, Materiel.Name FROM      Materiel INNER JOIN ProductTaskMain ON Materiel.ID = ProductTaskMain.MaterielID ");
            strSql.Append(" WHERE   (ProductTaskMain.DeparmentType = " + DeparmentTypeID + ") AND (ProductTaskMain.DeparmentID = " + DeparmentID + ") GROUP BY Materiel.ID, Materiel.Name");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetTaskListByMaterielName(string MaterielName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append( " SELECT     TOP (200) ProductTaskMain.ID, CONVERT(varchar(10), ProductTaskMain.DateTime, 120) AS DateTime, ProductTaskMain.Num, ProductTaskMain.BedNO, ");
            strSql.Append(" (CASE WHEN (DeparmentType = 3) THEN (SELECT     Name FROM company WHERE      (ID = ProductTaskMain.DeparmentID)) ELSE (SELECT     Name "); 
            strSql.Append(" FROM          Deparment WHERE      (ID = ProductTaskMain.DeparmentID)) END) AS DeparmentName, Materiel_1.Name AS BrandName, SUM(AmountInfo.Amount) AS Amount, ");
            strSql.Append(" SUM(AmountInfo.NotAmount) AS NotAmount FROM         ProductTaskMain INNER JOIN Materiel ON ProductTaskMain.MaterielID = Materiel.ID INNER JOIN ");
            strSql.Append(" AmountInfo ON ProductTaskMain.ID = AmountInfo.MainID INNER JOIN Materiel AS Materiel_1 ON ProductTaskMain.BrandID = Materiel_1.ID ");
            strSql.Append(" WHERE     (Materiel.Name = @Name) AND (AmountInfo.TableTypeID = 1) GROUP BY CONVERT(varchar(10), ProductTaskMain.DateTime, 120), ProductTaskMain.Num, ");
            strSql.Append(" ProductTaskMain.BedNO, ProductTaskMain.DeparmentType,  ProductTaskMain.DeparmentID, ProductTaskMain.ID, Materiel_1.Name  ORDER BY DateTime DESC ");
            SqlParameter[] sps = {new SqlParameter("@Name",MaterielName) };
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
			parameters[0].Value = "ProductTaskMain";
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

