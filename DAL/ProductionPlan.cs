using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类ProductionPlan。
	/// </summary>
	public class ProductionPlan
	{
		public ProductionPlan()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ProductionPlan"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProductionPlan");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.ProductionPlan model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ProductionPlan(");
            strSql.Append("SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,TypeID,ParentID,AssociatedID,AssociatedMatID)");
            strSql.Append(" values (");
            strSql.Append("@SalesOrderInfoID,@MaterielID,@BrandID,@Num,@DateTime,@LastDate,@Remark,@PWorkingID,@BomID,@CompanyID,@IsTicket,@IsBom,@IsVerify,@VerifyDate,@VerifyMan,@DeparmentID,@UpData,@FillDate,@FilMan,@TicketDate,@BedNO,@PackingMethodID,@SewingRemark,@TypeID,@ParentID,@AssociatedID,@AssociatedMatID)");
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
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@AssociatedID", SqlDbType.NVarChar,50),
					new SqlParameter("@AssociatedMatID", SqlDbType.Int,4)};
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
            parameters[23].Value = model.TypeID;
            parameters[24].Value = model.ParentID;
            parameters[25].Value = model.AssociatedID;
            parameters[26].Value = model.AssociatedMatID;

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
        public bool Update(Hownet.Model.ProductionPlan model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProductionPlan set ");
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
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("AssociatedID=@AssociatedID,");
            strSql.Append("AssociatedMatID=@AssociatedMatID");
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
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@AssociatedID", SqlDbType.NVarChar,50),
					new SqlParameter("@AssociatedMatID", SqlDbType.Int,4),
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
            parameters[23].Value = model.TypeID;
            parameters[24].Value = model.ParentID;
            parameters[25].Value = model.AssociatedID;
            parameters[26].Value = model.AssociatedMatID;
            parameters[27].Value = model.ID;

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
            strSql.Append("delete from ProductionPlan ");
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
            strSql.Append("delete from ProductionPlan ");
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
        public Hownet.Model.ProductionPlan GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,TypeID,ParentID,AssociatedID,AssociatedMatID from ProductionPlan ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.ProductionPlan model = new Hownet.Model.ProductionPlan();
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
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ParentID"] != null && ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }

                    model.AssociatedID = ds.Tables[0].Rows[0]["AssociatedID"].ToString();
               
                if (ds.Tables[0].Rows[0]["AssociatedMatID"] != null && ds.Tables[0].Rows[0]["AssociatedMatID"].ToString() != "")
                {
                    model.AssociatedMatID = int.Parse(ds.Tables[0].Rows[0]["AssociatedMatID"].ToString());
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
            strSql.Append("select  1 as A,ID,SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,TypeID,ParentID,AssociatedID,AssociatedMatID ");
            strSql.Append(" ,(Select TrueName from Users where (ID=ProductionPlan.FilMan)) as Fill,(Select TrueName from Users where (ID=ProductionPlan.VerifyMan)) as Verify");
            strSql.Append(" ,(SELECT   Name FROM      Deparment  WHERE   (ID = ProductionPlan.DeparmentID)) AS DeparmentName ");
            strSql.Append(" FROM ProductionPlan ");
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
            strSql.Append(" ID,SalesOrderInfoID,MaterielID,BrandID,Num,DateTime,LastDate,Remark,PWorkingID,BomID,CompanyID,IsTicket,IsBom,IsVerify,VerifyDate,VerifyMan,DeparmentID,UpData,FillDate,FilMan,TicketDate,BedNO,PackingMethodID,SewingRemark,TypeID,ParentID,AssociatedID,AssociatedMatID ");
            strSql.Append(" FROM ProductionPlan ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }



        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from ProductionPlan  order by ID");//Where (TypeID=0)
            return DbHelperSQL.Query(strSql.ToString());
        }
        //public int NewNum(DateTime dt)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProductionPlan WHERE   (DateTime = @dt)");
        //    SqlParameter[] sps = { new SqlParameter("@dt", dt) };
        //    object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
        //    if (o == null)
        //        return 1;
        //    else
        //        return int.Parse(o.ToString()) + 1;
        //}
        public bool CheckNum(DateTime dt, int Num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   DateTime, Num FROM  ProductionPlan WHERE   (DateTime = @dt) AND (Num = @Num)");
            SqlParameter[] sps = { new SqlParameter("@dt", dt), new SqlParameter("@Num", Num) };
            if (DbHelperSQL.Query(strSql.ToString(), sps).Tables[0].Rows.Count == 0)
                return true;
            else
                return false;
        }
        public int NewNum(DateTime dt, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            if (TypeID == 0)
            {
                strSql.Append("SELECT   MAX(Num) AS Expr1 FROM      ProductionPlan");
            }
            else if (TypeID == 1)
            {
                strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProductionPlan WHERE   (YEAR(DateTime) = YEAR(@dt))");
            }
            else if (TypeID == 2)
            {
                strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProductionPlan WHERE   (YEAR(DateTime) = YEAR(@dt)) AND (MONTH(DateTime) = MONTH(@dt))");
            }
            else if (TypeID == 3)
            {
                strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      ProductionPlan WHERE   (DateTime = @dt)");
            }
            SqlParameter[] sps = { new SqlParameter("@dt", dt) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
        public DataSet GetTaskList(int TableTypeID, int TypeID, bool IsVerify)
        {
            StringBuilder strSql = new StringBuilder();
            //if (TypeID == 0)
            //    strSql.Append("SELECT  Num,  ");
            //else if (TypeID == 1)
            //    strSql.Append("SELECT   CONVERT(varchar(4), DateTime, 120) +'-'+ REPLACE(STR(Num, 3, 0), ' ', '0') AS Num,  ");
            //else if (TypeID == 2)
            //    strSql.Append("SELECT    CAST(YEAR(DateTime) AS nvarchar(50)) + CAST(MONTH(DateTime) AS nvarchar(50))+'-'+ REPLACE(STR(Num, 3, 0), ' ', '0') AS Num,  ");
            //else if (TypeID == 3)
            strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) +'-'+ CAST(Num AS varchar) AS Num,  ");
                strSql.Append(" ID,cast(0 as bit) as IsSelect, MaterielID,BedNO,CompanyID, BrandID,DeparmentID, DateTime,IsVerify,PWorkingID, (SELECT   SUM(Amount) AS SumAmount FROM AmountInfo WHERE (MainID = ");
            strSql.Append(" ProductionPlan.ID) AND (TableTypeID = @TableTypeID)) AS SumAmount FROM ProductionPlan Where (IsVerify>2) And (IsVerify<20)");
            if (!IsVerify)
                strSql.Append(" And (DeparmentID<1)");
            strSql.Append(" ORDER BY DateTime");
            SqlParameter[] sps = { new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public bool CheckCanDelete(int PlanID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(ID) AS Expr1 FROM      ProductTaskMain WHERE   (ParentID = @PlanID)");
            SqlParameter[] sps = { new SqlParameter("@PlanID", PlanID) };
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps)) == 0;
        }
        /// <summary>
        /// 查询某生产计划的入库数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet Get2Depot(int MainID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(AmountInfo.Amount - AmountInfo.NotAmount) AS Amount, AmountInfo.ColorID, AmountInfo.ColorOneID, ");
            strSql.Append(" AmountInfo.ColorTwoID, AmountInfo.SizeID FROM      AmountInfo INNER JOIN ProductTaskMain ON AmountInfo.MainID ");
            strSql.Append(" = ProductTaskMain.ID WHERE   (ProductTaskMain.ParentID = @MainID) AND (AmountInfo.TableTypeID = @TableTypeID) ");
            strSql.Append(" GROUP BY AmountInfo.ColorID, AmountInfo.ColorOneID, AmountInfo.ColorTwoID, AmountInfo.SizeID");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID), new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 查找裁剪单的床号
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public int GetMaxTask(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(ID) AS Expr1 FROM      ProductTaskMain WHERE   (ParentID = @MainID)");
             SqlParameter[] sps = { new SqlParameter("@MainID", MainID)};
             return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps)) + 1;
        }
        /// <summary>
        /// 取得编号
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetNum(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CONVERT(varchar(100), ProductionPlan.DateTime, 112) + '-' + CAST(ProductionPlan.Num AS varchar) ");
            strSql.Append(" + '/' + Materiel.Name AS Num FROM      ProductionPlan INNER JOIN Materiel ON ProductionPlan.MaterielID = Materiel.ID ");
            strSql.Append(" WHERE   (ProductionPlan.ID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return string.Empty;
            else
                return o.ToString();
        }
        /// <summary>
        /// 取得该生产计划已生成的裁剪单数量
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public int GetTMCount(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(ID) AS Expr1 FROM      ProductTaskMain WHERE   (ParentID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps));
        }
        /// <summary>
        /// 取得可以合并的生产计划
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetMerge(int MaterielID,int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT cast(0 as bit) as IsSelect,  ID, IsVerify, BrandID, MaterielID,CompanyID, (SELECT   SUM(Amount) AS Amount FROM      AmountInfo ");
            strSql.Append(" WHERE   (MainID = ProductionPlan.ID) AND (TableTypeID = @TableTypeID)) AS Amount, CONVERT(varchar(100),  ");
            strSql.Append(" DateTime, 112) + '-' + CAST(Num AS varchar) AS Num FROM      ProductionPlan WHERE (TypeID=0) And (IsVerify = 3) AND (MaterielID = @MaterielID)");
            SqlParameter[] sps = {new SqlParameter("@MaterielID",MaterielID),new SqlParameter("@TableTypeID",TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        public DataSet GetMergeAmount(string StrID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   0 AS ID, 0 AS MainID, 0 AS A, '' AS Remark,0 as MListID, ColorID, ColorOneID, ColorTwoID, SizeID,  SUM(Amount) ");//MListID,
            strSql.Append(" AS Amount, SUM(NotAmount) AS NotAmount, SUM(NotDepAmount) AS NotDepAmount, TableTypeID FROM      AmountInfo ");
            strSql.Append(" WHERE   (TableTypeID = " + TableTypeID + ") AND (MainID IN (" + StrID + ")) GROUP BY ColorID, ColorOneID, ColorTwoID, ");
            strSql.Append(" SizeID,  TableTypeID");//MListID,
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetPlanList(int TableTypeID, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) + CAST(Num AS varchar) AS Num, ID, MaterielID,Remark, ");
            strSql.Append(" (Select FillMan from SalesOrderInfoList where (ID=ProductionPlan.SalesOrderInfoID)) as FillMan,");
            strSql.Append(" (Select Remark from SalesOrderInfoList Where (ID=ProductionPlan.SalesOrderInfoID)) as SRemark,PWorkingID,");
            //strSql.Append("  (SELECT   SUM(NotAmount) AS SumAmount FROM AmountInfo WHERE (MainID = ");
            //strSql.Append(" ProductionPlan.ID) AND (TableTypeID = @TableTypeID)) AS NotAmount ,");
            strSql.Append(" CompanyID, BrandID, DateTime,LastDate,DeparmentID, (SELECT   SUM(Amount) AS SumAmount FROM AmountInfo WHERE (MainID = ");
            strSql.Append(" ProductionPlan.ID) AND (TableTypeID = @TableTypeID)) AS SumAmount,IsVerify,(select TypeID from materiel where (ID=ProductionPlan.MaterielID)) as TypeID,LastDate FROM ProductionPlan ");//,FilMan
            if (strWhere.Length > 0)
                strSql.Append(" where " + strWhere);
            strSql.Append("  ORDER BY DateTime");
            SqlParameter[] sps = { new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetNumList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) + REPLACE(STR(Num, 3, 0), ' ', '0') AS Num, ID,(SELECT   Name ");
            // strSql.Append(" FROM      Materiel WHERE   (ID = ProductTaskMain.MaterielID)) AS MaterielName FROM      ProductTaskMain");
            strSql.Append(" SELECT   CONVERT(varchar(100), ProductionPlan.DateTime, 112) + '-' +  CAST(Num AS varchar)");//REPLACE(STR(ProductionPlan.Num, 3, 0), ' ', '0')
            strSql.Append(" + '-' + Materiel.Name AS Num, ProductionPlan.ID FROM      ProductionPlan INNER JOIN ");
            strSql.Append(" Materiel ON ProductionPlan.MaterielID = Materiel.ID ");
            if (strWhere.Length > 0)
            {
                strSql.Append(" Where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());

        }
        public DataSet GetNumListForLinLiao(string strWhere)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("SELECT   CONVERT(varchar(100), DateTime, 112) +'-'+ CAST(Num AS varchar) AS Num,0 as BedNO, ID,(SELECT   Name ");
                strSql.Append(" FROM      Materiel WHERE   (ID = ProductionPlan.MaterielID)) AS MaterielName,ID as ParentID,DeparmentID,MaterielID FROM      ProductionPlan");
                strSql.Append(" where (IsVerify>2) ");
                if (strWhere.Length > 0)
                    strSql.Append(" And" + strWhere);
                return DbHelperSQL.Query(strSql.ToString());
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        /// <summary>
        /// 获取某款号的打版师
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetDesigners(int ID )
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MiniEmp.Name FROM      MiniEmp INNER JOIN Materiel ON MiniEmp.ID = Materiel.Designers ");
            strSql.Append(" WHERE   (Materiel.ID = @ID)");
            SqlParameter[] sps = {new SqlParameter("@ID",ID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return o.ToString();
            else
                return string.Empty;
        }
        /// <summary>
        /// 根据编号，获取任务单ID和款号
        /// </summary>
        /// <param name="Num"></param>
        /// <returns></returns>
        public DataSet GetListByNum(string Num)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      Materiel WHERE   (ID = ProductionPlan.MaterielID)) AS MaterielName, ID ");
            strSql.Append(" FROM      ProductionPlan WHERE   (CONVERT(varchar(100), DateTime, 112) + '-' + REPLACE(STR(Num, 3, 0), ' ', '0') = @Num)");
            SqlParameter[] sps = { new SqlParameter("@Num", Num) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 合并的计划单所合并单的备料
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPPMDList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   MaterielDemand.MListID, SUM(MaterielDemand.RepertoryAmount) AS RepertoryAmount FROM      ProductionPlan INNER JOIN MaterielDemand ON ProductionPlan.ID = MaterielDemand.ProduceTaskID ");
            strSql.Append(" WHERE   (MaterielDemand.TableTypeID = 41) AND (ProductionPlan.DeparmentID = @MainID) GROUP BY MaterielDemand.MListID");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }
        /// <summary>
        /// 计划单物料合并后，将被合并计划单所在仓物料数归0
        /// </summary>
        /// <param name="MainID"></param>
        public void UpPPMDList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE  MaterielDemand SET         RepertoryAmount = 0 FROM      ProductionPlan INNER JOIN MaterielDemand ON ProductionPlan.ID = MaterielDemand.ProduceTaskID ");
            strSql.Append(" WHERE   (MaterielDemand.TableTypeID = 41) AND (ProductionPlan.DeparmentID =  @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);

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
			parameters[0].Value = "ProductionPlan";
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

