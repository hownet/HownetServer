using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类WorkTicketIDCard。
	/// </summary>
	public class WorkTicketIDCard
	{
		public WorkTicketIDCard()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WorkTicketIDCard"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WorkTicketIDCard");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.WorkTicketIDCard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into WorkTicketIDCard(");
            strSql.Append("TicketID,IDCardNo,IsEnd,GroupBy,TaskID,FishWork,Num,MaterielName,ColorName,SizeName,ColorID,SizeID,BoxNum,MaterielID,ColorOneName,ColorTwoName,ColorOneID,ColorTwoID)");
            strSql.Append(" values (");
            strSql.Append("@TicketID,@IDCardNo,@IsEnd,@GroupBy,@TaskID,@FishWork,@Num,@MaterielName,@ColorName,@SizeName,@ColorID,@SizeID,@BoxNum,@MaterielID,@ColorOneName,@ColorTwoName,@ColorOneID,@ColorTwoID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TicketID", SqlDbType.Int,4),
					new SqlParameter("@IDCardNo", SqlDbType.BigInt,8),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@GroupBy", SqlDbType.TinyInt,1),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@FishWork", SqlDbType.Bit,1),
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorTwoName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4)};
            parameters[0].Value = model.TicketID;
            parameters[1].Value = model.IDCardNo;
            parameters[2].Value = model.IsEnd;
            parameters[3].Value = model.GroupBy;
            parameters[4].Value = model.TaskID;
            parameters[5].Value = model.FishWork;
            parameters[6].Value = model.Num;
            parameters[7].Value = model.MaterielName;
            parameters[8].Value = model.ColorName;
            parameters[9].Value = model.SizeName;
            parameters[10].Value = model.ColorID;
            parameters[11].Value = model.SizeID;
            parameters[12].Value = model.BoxNum;
            parameters[13].Value = model.MaterielID;
            parameters[14].Value = model.ColorOneName;
            parameters[15].Value = model.ColorTwoName;
            parameters[16].Value = model.ColorOneID;
            parameters[17].Value = model.ColorTwoID;

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
        public bool Update(Hownet.Model.WorkTicketIDCard model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WorkTicketIDCard set ");
            strSql.Append("TicketID=@TicketID,");
            strSql.Append("IDCardNo=@IDCardNo,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("GroupBy=@GroupBy,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("FishWork=@FishWork,");
            strSql.Append("Num=@Num,");
            strSql.Append("MaterielName=@MaterielName,");
            strSql.Append("ColorName=@ColorName,");
            strSql.Append("SizeName=@SizeName,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("BoxNum=@BoxNum,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorOneName=@ColorOneName,");
            strSql.Append("ColorTwoName=@ColorTwoName,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@TicketID", SqlDbType.Int,4),
					new SqlParameter("@IDCardNo", SqlDbType.BigInt,8),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@GroupBy", SqlDbType.TinyInt,1),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@FishWork", SqlDbType.Bit,1),
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorTwoName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.TicketID;
            parameters[1].Value = model.IDCardNo;
            parameters[2].Value = model.IsEnd;
            parameters[3].Value = model.GroupBy;
            parameters[4].Value = model.TaskID;
            parameters[5].Value = model.FishWork;
            parameters[6].Value = model.Num;
            parameters[7].Value = model.MaterielName;
            parameters[8].Value = model.ColorName;
            parameters[9].Value = model.SizeName;
            parameters[10].Value = model.ColorID;
            parameters[11].Value = model.SizeID;
            parameters[12].Value = model.BoxNum;
            parameters[13].Value = model.MaterielID;
            parameters[14].Value = model.ColorOneName;
            parameters[15].Value = model.ColorTwoName;
            parameters[16].Value = model.ColorOneID;
            parameters[17].Value = model.ColorTwoID;
            parameters[18].Value = model.ID;

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
            strSql.Append("delete from WorkTicketIDCard ");
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
            strSql.Append("delete from WorkTicketIDCard ");
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
        public Hownet.Model.WorkTicketIDCard GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ID,TicketID,IDCardNo,IsEnd,GroupBy,TaskID,FishWork,Num,MaterielName,ColorName,SizeName,ColorID,SizeID,BoxNum,MaterielID,ColorOneName,ColorTwoName,ColorOneID,ColorTwoID from WorkTicketIDCard ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.WorkTicketIDCard model = new Hownet.Model.WorkTicketIDCard();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TicketID"].ToString() != "")
                {
                    model.TicketID = int.Parse(ds.Tables[0].Rows[0]["TicketID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IDCardNo"].ToString() != "")
                {
                    model.IDCardNo = long.Parse(ds.Tables[0].Rows[0]["IDCardNo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsEnd"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsEnd"].ToString().ToLower() == "true"))
                    {
                        model.IsEnd = true;
                    }
                    else
                    {
                        model.IsEnd = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["GroupBy"].ToString() != "")
                {
                    model.GroupBy = int.Parse(ds.Tables[0].Rows[0]["GroupBy"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FishWork"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["FishWork"].ToString() == "1") || (ds.Tables[0].Rows[0]["FishWork"].ToString().ToLower() == "true"))
                    {
                        model.FishWork = true;
                    }
                    else
                    {
                        model.FishWork = false;
                    }
                }
                model.Num = ds.Tables[0].Rows[0]["Num"].ToString();
                model.MaterielName = ds.Tables[0].Rows[0]["MaterielName"].ToString();
                model.ColorName = ds.Tables[0].Rows[0]["ColorName"].ToString();
                model.SizeName = ds.Tables[0].Rows[0]["SizeName"].ToString();
                if (ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BoxNum"].ToString() != "")
                {
                    model.BoxNum = int.Parse(ds.Tables[0].Rows[0]["BoxNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                model.ColorOneName = ds.Tables[0].Rows[0]["ColorOneName"].ToString();
                model.ColorTwoName = ds.Tables[0].Rows[0]["ColorTwoName"].ToString();
                if (ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
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
            strSql.Append("select 1 as A,ID,TicketID,IDCardNo,IsEnd,GroupBy,TaskID,FishWork,Num,MaterielName,ColorName,SizeName,ColorID,SizeID,BoxNum,MaterielID,ColorOneName,ColorTwoName,ColorOneID,ColorTwoID ");
            strSql.Append(" FROM WorkTicketIDCard ");
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
            strSql.Append(" ID,TicketID,IDCardNo,IsEnd,GroupBy,TaskID,FishWork,Num,MaterielName,ColorName,SizeName,ColorID,SizeID,BoxNum,MaterielID,ColorOneName,ColorTwoName,ColorOneID,ColorTwoID ");
            strSql.Append(" FROM WorkTicketIDCard ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        public DataSet CheckCard(int CardID,int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT 1 as A,ID,TicketID,IDCardNo,IsEnd,GroupBy,TaskID,FishWork,Num,MaterielName,ColorName,SizeName,ColorID,SizeID,BoxNum,MaterielID,ColorOneName,ColorTwoName,ColorOneID,ColorTwoID FROM WorkTicketIDCard ");
            strSql.Append(" WHERE (IDCardNo = @ID) AND (TaskID <> @TaskID) Order By TicketID DESC");
            SqlParameter[] sps = { new SqlParameter("@ID", CardID), new SqlParameter("@TaskID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WorkTicketIDCard set ");
            strSql.Append("IsEnd=@IsEnd ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1)};
            parameters[0].Value = ID;
            parameters[1].Value = true;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetListByCardID(int CardID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ID,TicketID, IDCardNo, GroupBy, TaskID FROM WorkTicketIDCard ");
            strSql.Append(" WHERE (IsEnd = 0) AND (IDCardNo = @CardID)");
            SqlParameter[] sps = { new SqlParameter("@CardID", CardID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public void UpdateFishWork(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WorkTicketIDCard set ");
            strSql.Append("FishWork=@IsEnd ,IsEnd=@IsEnd");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1)};
            parameters[0].Value = ID;
            parameters[1].Value = true;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetAllListByCardID(int CardID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT   WorkTicketIDCard.ID, WorkTicketIDCard.TicketID, WorkTicketIDCard.IDCardNo, WorkTicketIDCard.GroupBy,  WorkTicketIDCard.TaskID, WorkTicketIDCard.IsEnd, ");
            //strSql.Append(" CONVERT(varchar(100), ProductTaskMain.DateTime, 112) + REPLACE(STR(ProductTaskMain.Num, 3, 0), ' ', '0') AS Num, Materiel.Name AS MaterielName,  Color.Name AS ColorName, ");
            //strSql.Append(" Size.Name AS SizeName, Working.Name AS WorkingName, MiniEmp.Name AS MiniEmpName, WorkTicketInfo.DateTime, WorkTicketInfo.PWorkingInfoID, WorkTicketInfo.Amount, ");
            //strSql.Append(" WorkTicketInfo.WorkingID, WorkTicket.ColorID, WorkTicket.SizeID, WorkTicket.BoxNum, ProductWorkingInfo.Price,ProductWorkingInfo.Orders, WorkTicketInfo.EmployeeID, ");
            //strSql.Append("  ProductTaskMain.MaterielID, WorkTicketInfo.ID AS InfoID,ProductWorkingInfo.FastTime,Working.WorkTypeID FROM WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID ");
            //strSql.Append(" = WorkTicket.ID INNER JOIN WorkTicketIDCard ON WorkTicket.ID = WorkTicketIDCard.TicketID INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            //strSql.Append(" AND WorkTicketIDCard.GroupBy = ProductWorkingInfo.GroupBy INNER JOIN ProductTaskMain ON WorkTicketIDCard.TaskID = ProductTaskMain.ID INNER JOIN Materiel ON ");
            //strSql.Append(" ProductTaskMain.MaterielID = Materiel.ID INNER JOIN Color ON WorkTicket.ColorID = Color.ID INNER JOIN Size ON WorkTicket.SizeID = Size.ID INNER JOIN ");
            //strSql.Append(" Working ON WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID WHERE   (WorkTicketIDCard.IDCardNo = @CardID) ");
            //strSql.Append(" AND (ProductWorkingInfo.IsTicket = 1)   ORDER BY ProductWorkingInfo.Orders");//AND (WorkTicketIDCard.IsEnd = 0)
            strSql.Append(" SELECT   WorkTicketIDCard.ID, WorkTicketIDCard.TicketID, WorkTicketIDCard.IDCardNo, WorkTicketIDCard.GroupBy,  WorkTicketIDCard.TaskID, ");
            strSql.Append(" WorkTicketIDCard.IsEnd, Working.Name AS WorkingName, MiniEmp.Name AS MiniEmpName, WorkTicketInfo.DateTime, WorkTicketInfo.PWorkingInfoID, ");
            strSql.Append(" WorkTicketInfo.Amount, WorkTicketInfo.WorkingID, ProductWorkingInfo.Price, ProductWorkingInfo.Orders, WorkTicketInfo.EmployeeID,ProductWorkingInfo.IsCanMove, ");
            strSql.Append(" WorkTicketInfo.ID AS InfoID, ProductWorkingInfo.FastTime, Working.WorkTypeID, WorkTicketIDCard.Num, WorkTicketIDCard.MaterielName, ");
            strSql.Append(" WorkTicketIDCard.ColorName, WorkTicketIDCard.SizeName, WorkTicketIDCard.ColorID, WorkTicketIDCard.SizeID, WorkTicketIDCard.BoxNum, ");
            strSql.Append(" WorkTicketIDCard.MaterielID,WorkTicketIDCard.Num,MiniEmp.Sn as EmpSN FROM      WorkTicketInfo INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ");
            strSql.Append(" ProductWorkingInfo.ID INNER JOIN WorkTicketIDCard ON ProductWorkingInfo.GroupBy = WorkTicketIDCard.GroupBy AND WorkTicketInfo.MainID ");
            strSql.Append(" = WorkTicketIDCard.TicketID INNER JOIN Working ON WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN MiniEmp ON WorkTicketInfo.EmployeeID ");
            strSql.Append(" = MiniEmp.ID WHERE   (ProductWorkingInfo.IsTicket = 1) AND (WorkTicketIDCard.IDCardNo = @CardID) ORDER BY ProductWorkingInfo.Orders");
            SqlParameter[] sps = { new SqlParameter("@CardID", CardID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetAllListByTicketID(int TicketID, int GroupBy)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT   WorkTicketIDCard.ID, WorkTicketIDCard.TicketID, WorkTicketIDCard.IDCardNo, WorkTicketIDCard.GroupBy,  WorkTicketIDCard.TaskID, WorkTicketIDCard.IsEnd, ");
            //strSql.Append(" CONVERT(varchar(100), ProductTaskMain.DateTime, 112) + REPLACE(STR(ProductTaskMain.Num, 3, 0), ' ', '0') AS Num, Materiel.Name AS MaterielName,  Color.Name AS ColorName, ");
            //strSql.Append(" Size.Name AS SizeName, Working.Name AS WorkingName, MiniEmp.Name AS MiniEmpName, WorkTicketInfo.DateTime, WorkTicketInfo.PWorkingInfoID, WorkTicketInfo.Amount, ");
            //strSql.Append(" WorkTicketInfo.WorkingID, WorkTicket.ColorID, WorkTicket.SizeID, WorkTicket.BoxNum, ProductWorkingInfo.Price,ProductWorkingInfo.Orders, WorkTicketInfo.EmployeeID, ");
            //strSql.Append("  ProductTaskMain.MaterielID, WorkTicketInfo.ID AS InfoID,ProductWorkingInfo.FastTime,Working.WorkTypeID FROM WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID ");
            //strSql.Append(" = WorkTicket.ID INNER JOIN WorkTicketIDCard ON WorkTicket.ID = WorkTicketIDCard.TicketID INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            //strSql.Append(" AND WorkTicketIDCard.GroupBy = ProductWorkingInfo.GroupBy INNER JOIN ProductTaskMain ON WorkTicketIDCard.TaskID = ProductTaskMain.ID INNER JOIN Materiel ON ");
            //strSql.Append(" ProductTaskMain.MaterielID = Materiel.ID INNER JOIN Color ON WorkTicket.ColorID = Color.ID INNER JOIN Size ON WorkTicket.SizeID = Size.ID INNER JOIN ");
            //strSql.Append(" Working ON WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID WHERE   (WorkTicketIDCard.IDCardNo = @CardID) ");
            //strSql.Append(" AND (ProductWorkingInfo.IsTicket = 1)   ORDER BY ProductWorkingInfo.Orders");//AND (WorkTicketIDCard.IsEnd = 0)
            strSql.Append(" SELECT   WorkTicketIDCard.ID, WorkTicketIDCard.TicketID, WorkTicketIDCard.IDCardNo, WorkTicketIDCard.GroupBy,  WorkTicketIDCard.TaskID, ");
            strSql.Append(" WorkTicketIDCard.IsEnd, Working.Name AS WorkingName, MiniEmp.Name AS MiniEmpName, WorkTicketInfo.DateTime, WorkTicketInfo.PWorkingInfoID, ");
            strSql.Append(" WorkTicketInfo.Amount, WorkTicketInfo.WorkingID, ProductWorkingInfo.Price, ProductWorkingInfo.Orders, WorkTicketInfo.EmployeeID,ProductWorkingInfo.IsCanMove, ");
            strSql.Append(" WorkTicketInfo.ID AS InfoID, ProductWorkingInfo.FastTime, Working.WorkTypeID, WorkTicketIDCard.Num, WorkTicketIDCard.MaterielName, ");
            strSql.Append(" WorkTicketIDCard.ColorName, WorkTicketIDCard.SizeName, WorkTicketIDCard.ColorID, WorkTicketIDCard.SizeID, WorkTicketIDCard.BoxNum, ");
            strSql.Append(" WorkTicketIDCard.MaterielID,WorkTicketIDCard.Num FROM      WorkTicketInfo INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ");
            strSql.Append(" ProductWorkingInfo.ID INNER JOIN WorkTicketIDCard ON ProductWorkingInfo.GroupBy = WorkTicketIDCard.GroupBy AND WorkTicketInfo.MainID ");
            strSql.Append(" = WorkTicketIDCard.TicketID INNER JOIN Working ON WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN MiniEmp ON WorkTicketInfo.EmployeeID ");
            strSql.Append(" = MiniEmp.ID WHERE   (ProductWorkingInfo.IsTicket = 1) AND (WorkTicketIDCard.TicketID = @TicketID) And (WorkTicketIDCard.GroupBy=@GroupBy) ORDER BY ProductWorkingInfo.Orders");
            SqlParameter[] sps = { new SqlParameter("@TicketID", TicketID) ,new SqlParameter("@GroupBy",GroupBy)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int UpIDCardNo(int TicketID, int GroupBy, int IDCardNo, int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE  WorkTicketIDCard SET IDCardNo = @IDCardNo WHERE   (TicketID = @TicketID) AND (GroupBy = @GroupBy) AND (TaskID = @TaskID)");
            SqlParameter[] sps = {new SqlParameter("@TicketID",TicketID),new SqlParameter("@GroupBy",GroupBy),
                                  new SqlParameter("@IDCardNo",IDCardNo),new SqlParameter("@TaskID",TaskID)};
            return DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet PrintLable(int TaskID, int TicketID, int GroupBy, int ColorID, int SizeID,int OneAmount)
        {
            Hownet.DAL.ProductTaskMain dalPTM = new ProductTaskMain();
            Hownet.Model.ProductTaskMain modPTM =dalPTM. GetModel(TaskID);
            Hownet.DAL.Materiel dalMat = new Materiel();
            Hownet.Model.Materiel modMat = dalMat.GetModel(modPTM.MaterielID);
            Hownet.DAL.Measure dalMea = new Measure();
            Hownet.Model.Measure modMea = dalMea.GetModel(modMat.MeasureID);
            string mea = string.Empty;
            if (modMea != null)
                mea = modMea.Name;
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   WorkTicketIDCard.IDCardNo, '第' + CAST(WorkTicket.BoxNum AS nvarchar) + '箱，' AS BoxNum, WorkTicket.BoxNum as BN,");
            //strSql.Append(" Color.Name AS ColorName, Size.Name AS SizeName, '第' + CAST(WorkTicketIDCard.GroupBy AS nvarchar) ");
            //strSql.Append(" + '组' AS GroupBy, Materiel.Name AS MaterielName, CAST(WorkTicket.Amount AS nvarchar) + '件' AS Amount ");
            //strSql.Append(" ,(Select Name from Materiel where (id=workticket.BrandID)) as BrandName,WorkTicketIDCard.GroupBy as GB ");
            //strSql.Append(" FROM Color INNER JOIN ");
            //strSql.Append(" WorkTicket ON Color.ID = WorkTicket.ColorID INNER JOIN Size ON WorkTicket.SizeID = Size.ID INNER JOIN ");
            //strSql.Append(" WorkTicketIDCard ON WorkTicket.ID = WorkTicketIDCard.TicketID INNER JOIN ProductTaskMain ON WorkTicketIDCard.TaskID ");
            //strSql.Append(" = ProductTaskMain.ID INNER JOIN Materiel ON ProductTaskMain.MaterielID = Materiel.ID  ");
            strSql.Append("SELECT (CAST(WorkTicketIDCard.TicketID AS nvarchar)+cast( WorkTicketIDCard.GroupBy as nvarchar)) as QR,  WorkTicketIDCard.IDCardNo, '第' + CAST(WorkTicket.BoxNum AS nvarchar) + '箱，' AS BoxNum,WorkTicket.BoxNum as BN, ProductTaskMain.BedNO, ");
            strSql.Append(" WorkTicket.BoxNum AS BN, Color.Name AS ColorName, Size.Name AS SizeName,  '第' + CAST(WorkTicketIDCard.GroupBy ");
            strSql.Append("AS nvarchar) + '组' AS GroupBy, Materiel_1.Name AS MaterielName,  CAST(WorkTicket.Amount AS nvarchar) + '" + mea + "' AS Amount,WorkTicketIDCard.GroupBy as CaiPian, ");
            strSql.Append("(SELECT   Name FROM      Materiel WHERE   (ID = ProductTaskMain.BrandID)) AS BrandName, WorkTicketIDCard.GroupBy AS GB, ");
            strSql.Append(" Color_1.Name AS ColorOneName, Color_2.Name AS ColorTwoName FROM      Color INNER JOIN WorkTicket ON Color.ID = ");
            strSql.Append(" WorkTicket.ColorID INNER JOIN Size ON WorkTicket.SizeID = Size.ID INNER JOIN WorkTicketIDCard ON WorkTicket.ID = ");
            strSql.Append(" WorkTicketIDCard.TicketID INNER JOIN ProductTaskMain ON WorkTicketIDCard.TaskID = ProductTaskMain.ID INNER JOIN ");
            strSql.Append(" Materiel AS Materiel_1 ON ProductTaskMain.MaterielID = Materiel_1.ID LEFT OUTER JOIN Color AS Color_1 ON ");
            strSql.Append(" WorkTicket.ColorOneID = Color_1.ID LEFT OUTER JOIN Color AS Color_2 ON WorkTicket.ColorTwoID = Color_2.ID");
            strSql.Append(" WHERE (WorkTicketIDCard.TaskID = @TaskID) And (WorkTicket.OneAmount=@OneAmount)");
            if (TicketID > 0)
                strSql.Append(" And (WorkTicketIDCard.TicketID = @TicketID) ");
            if (GroupBy > 0)
                strSql.Append(" AND (WorkTicketIDCard.GroupBy = @GroupBy) ");
            if (ColorID > 0)
                strSql.Append(" And (WorkTicket.ColorID=@ColorID) ");
            if (SizeID > 0)
                strSql.Append(" And (WorkTicket.SizeID=@SizeID) ");
            strSql.Append(" ORDER BY WorkTicketIDCard.GroupBy, WorkTicket.BoxNum");
            SqlParameter[] sps = {new SqlParameter("@TicketID",TicketID),new SqlParameter("@GroupBy",GroupBy),
                                  new SqlParameter("@ColorID",ColorID),new SqlParameter("@TaskID",TaskID),
                                  new SqlParameter("@SizeID",SizeID),new SqlParameter("@OneAmount",OneAmount)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet PrintQR(int TaskID)
        {
            //Hownet.DAL.ProductTaskMain dalPTM = new ProductTaskMain();
            //Hownet.Model.ProductTaskMain modPTM = dalPTM.GetModel(TaskID);
            //Hownet.DAL.Materiel dalMat = new Materiel();
            //Hownet.Model.Materiel modMat = dalMat.GetModel(modPTM.MaterielID);
            //Hownet.DAL.Measure dalMea = new Measure();
            //Hownet.Model.Measure modMea = dalMea.GetModel(modMat.MeasureID);
            //string mea = string.Empty;
            //if (modMea != null)
            //    mea = modMea.Name;
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   WorkTicketIDCard.IDCardNo, '第' + CAST(WorkTicket.BoxNum AS nvarchar) + '箱，' AS BoxNum,WorkTicket.BoxNum as BN, ProductTaskMain.BedNO,");
            //strSql.Append(" cast( WorkTicketIDCard.TicketID as nvarchar ) +cast( WorkTicketIDCard.GroupBy as nvarchar) AS GB, ");
            //strSql.Append(" WorkTicket.BoxNum AS BN, Color.Name AS ColorName, Size.Name AS SizeName,  '第' + CAST(WorkTicketIDCard.GroupBy ");
            //strSql.Append("AS nvarchar) + '组' AS GroupBy, Materiel_1.Name AS MaterielName,  CAST(WorkTicket.Amount AS nvarchar) + '" + mea + "' AS Amount, ");
            //strSql.Append("(SELECT   Name FROM      Materiel WHERE   (ID = ProductTaskMain.BrandID)) AS BrandName,  ");
            //strSql.Append(" Color_1.Name AS ColorOneName, Color_2.Name AS ColorTwoName FROM      Color INNER JOIN WorkTicket ON Color.ID = ");
            //strSql.Append(" WorkTicket.ColorID INNER JOIN Size ON WorkTicket.SizeID = Size.ID INNER JOIN WorkTicketIDCard ON WorkTicket.ID = ");
            //strSql.Append(" WorkTicketIDCard.TicketID INNER JOIN ProductTaskMain ON WorkTicketIDCard.TaskID = ProductTaskMain.ID INNER JOIN ");
            //strSql.Append(" Materiel AS Materiel_1 ON ProductTaskMain.MaterielID = Materiel_1.ID LEFT OUTER JOIN Color AS Color_1 ON ");
            //strSql.Append(" WorkTicket.ColorOneID = Color_1.ID LEFT OUTER JOIN Color AS Color_2 ON WorkTicket.ColorTwoID = Color_2.ID");
            //strSql.Append(" WHERE (WorkTicketIDCard.TaskID = @TaskID)");
            strSql.Append(" SELECT   '第' + CAST(WorkTicket.BoxNum AS nvarchar) + '箱，' AS BoxNum, WorkTicket.BoxNum AS BN, ");
            strSql.Append(" CAST(WorkTicket.ID AS nvarchar) + CAST(ProductWorkingInfo.GroupBy AS nvarchar) AS GB, ProductTaskMain.BedNO, ");
            strSql.Append(" WorkTicket.BoxNum AS BN, Color.Name AS ColorName, Size.Name AS SizeName, Materiel_1.Name AS MaterielName, ");
            strSql.Append(" CAST(WorkTicket.Amount AS nvarchar) + '件' AS Amount,(SELECT   Name FROM      Materiel ");
            strSql.Append(" WHERE   (ID = ProductTaskMain.BrandID)) AS BrandName, ProductWorkingInfo.GroupBy, WorkTicket.TaskID, ");
            strSql.Append(" ProductWorkingInfo.MainID, WorkTicket.ID, ProductTaskMain.BrandID FROM      Materiel AS Materiel_1 INNER JOIN ");
            strSql.Append(" ProductTaskMain ON Materiel_1.ID = ProductTaskMain.MaterielID INNER JOIN Color INNER JOIN ");
            strSql.Append(" WorkTicket ON Color.ID = WorkTicket.ColorID INNER JOIN Size ON WorkTicket.SizeID = Size.ID ON ProductTaskMain.ID ");
            strSql.Append(" = WorkTicket.TaskID INNER JOIN ProductWorkingInfo ON ProductTaskMain.PWorkingID = ProductWorkingInfo.MainID ");
            strSql.Append(" GROUP BY '第' + CAST(WorkTicket.BoxNum AS nvarchar) + '箱，', WorkTicket.BoxNum, ProductTaskMain.BedNO, Color.Name, ");
            strSql.Append(" Size.Name, Materiel_1.Name, CAST(WorkTicket.Amount AS nvarchar) + '件', ProductWorkingInfo.GroupBy, ");
            strSql.Append(" WorkTicket.TaskID, ProductWorkingInfo.MainID, WorkTicket.ID, '第' + CAST(ProductWorkingInfo.GroupBy AS nvarchar)  ");
            strSql.Append(" + '组', ProductTaskMain.BrandID HAVING   (WorkTicket.TaskID = @TaskID) ORDER BY '第' + CAST(ProductWorkingInfo.GroupBy AS nvarchar) + '组', BoxNum");


            //strSql.Append(" ORDER BY WorkTicketIDCard.GroupBy, WorkTicket.BoxNum");
            SqlParameter[] sps = {new SqlParameter("@TaskID",TaskID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public void DelMore()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM WorkTicketIDCard FROM      WorkTicketIDCard INNER JOIN (SELECT   MIN(WorkTicketIDCard_2.TicketID) ");
            strSql.Append(" AS TicketID, WorkTicketIDCard_2.IDCardNo FROM      WorkTicketIDCard AS WorkTicketIDCard_2 INNER JOIN (SELECT  ");
            strSql.Append(" IDCardNo, COUNT(ID) AS Expr1 FROM      WorkTicketIDCard AS WorkTicketIDCard_1 GROUP BY IDCardNo HAVING   (COUNT(ID) ");
            strSql.Append(" > 1)) AS Tem ON WorkTicketIDCard_2.IDCardNo = Tem.IDCardNo GROUP BY WorkTicketIDCard_2.IDCardNo) AS TT ON ");
            strSql.Append(" WorkTicketIDCard.TicketID = TT.TicketID AND WorkTicketIDCard.IDCardNo = TT.IDCardNo");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }
        public DataSet GetWorkOverList(int CardID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  WorkTicketInfo.ID,");
           // strSql.Append(" WorkTicketIDCard.ColorName AS 颜色, WorkTicketIDCard.SizeName AS 尺码, ");
            //strSql.Append(" WorkTicketIDCard.BoxNum AS 箱号, WorkTicketIDCard.GroupBy AS 分组, ");
            strSql.Append(" Working.Name AS 工序, WorkTicketInfo.Amount AS 数量, MiniEmp.Name AS 员工, ");
            strSql.Append(" WorkTicketInfo.DateTime AS 日期   FROM WorkTicketInfo INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN ");
            strSql.Append(" WorkTicketIDCard ON ProductWorkingInfo.GroupBy = WorkTicketIDCard.GroupBy AND ");
            strSql.Append(" WorkTicketInfo.MainID = WorkTicketIDCard.TicketID INNER JOIN Working ON ");
            strSql.Append(" WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN ");
            strSql.Append(" MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID ");
            strSql.Append(" WHERE (ProductWorkingInfo.IsTicket = 1) AND (WorkTicketIDCard.IDCardNo = @CardID) ");
            strSql.Append(" ORDER BY ProductWorkingInfo.Orders");
            SqlParameter[] sps = {new SqlParameter("@CardID",CardID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetWorkOverListByTicketID(int TicketID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT  WorkTicketInfo.ID,");
            //// strSql.Append(" WorkTicketIDCard.ColorName AS 颜色, WorkTicketIDCard.SizeName AS 尺码, ");
            ////strSql.Append(" WorkTicketIDCard.BoxNum AS 箱号, WorkTicketIDCard.GroupBy AS 分组, ");
            //strSql.Append(" Working.Name AS 工序, WorkTicketInfo.Amount AS 数量, MiniEmp.Name AS 员工, ");
            //strSql.Append(" WorkTicketInfo.DateTime AS 日期   FROM WorkTicketInfo INNER JOIN ");
            //strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN ");
            //strSql.Append(" WorkTicketIDCard ON ProductWorkingInfo.GroupBy = WorkTicketIDCard.GroupBy AND ");
            //strSql.Append(" WorkTicketInfo.MainID = WorkTicketIDCard.TicketID INNER JOIN Working ON ");
            //strSql.Append(" WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN ");
            //strSql.Append(" MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID ");
            //strSql.Append(" WHERE (ProductWorkingInfo.IsTicket = 1) AND (WorkTicketIDCard.TicketID = @TicketID) ");
            //strSql.Append(" ORDER BY ProductWorkingInfo.Orders");


           // StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   WorkTicketInfo.ID, Working.Name AS 工序, WorkTicketInfo.Amount AS 数量, MiniEmp.Name AS 员工, ");
            strSql.Append(" WorkTicketInfo.DateTime AS 日期 FROM      WorkTicketInfo INNER JOIN ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID INNER JOIN ");
            strSql.Append(" Working ON WorkTicketInfo.WorkingID = Working.ID LEFT OUTER JOIN MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID ");
            strSql.Append(" WHERE   (ProductWorkingInfo.IsTicket = 1) AND (WorkTicketInfo.MainID =  @TicketID) ORDER BY ProductWorkingInfo.Orders"); 
            SqlParameter[] sps = { new SqlParameter("@TicketID", TicketID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int GetID(int CardID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ID FROM WorkTicketIDCard WHERE (IDCardNo = @CardID)");
            SqlParameter[] sps = { new SqlParameter("@CardID", CardID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        /// <summary>
        /// 用于平板显示的工序完成情况
        /// </summary>
        /// <param name="CardID"></param>
        /// <returns></returns>
        public DataSet GetListForPad(int CardID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   WorkTicketInfo.ID, Working.Name AS WorkingName, WorkTicketInfo.Amount, MiniEmp.Name AS EmpName,  ");
            strSql.Append(" WorkTicketInfo.DateTime, ProductWorkingInfo.GroupBy, ProductWorkingInfo.Orders FROM      WorkTicketIDCard INNER JOIN ");
            strSql.Append(" WorkTicketInfo ON WorkTicketIDCard.TicketID = WorkTicketInfo.MainID INNER JOIN Working ON WorkTicketInfo.WorkingID = Working.ID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID LEFT OUTER JOIN MiniEmp ON WorkTicketInfo.EmployeeID = MiniEmp.ID ");
            strSql.Append(" WHERE   (WorkTicketIDCard.IDCardNo = @CardID) ORDER BY ProductWorkingInfo.Orders");
            SqlParameter[] sps = { new SqlParameter("@CardID", CardID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int GetCountRows()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(*) AS Expr1 FROM      WorkTicketIDCard");
            object o = DbHelperSQL.GetSingle(strSql.ToString());
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        public DataSet GetEmpWork(int EmployeeID)
        {
            DateTime dtOne = DateTime.Now.Date.AddMilliseconds(-1);
            DateTime dtTwo = dtOne.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT PayInfo.EmployeeID, 0 AS NID, Materiel.Name AS MaterielName, Working.Name AS WorkName, SUM(PayInfo.Amount) AS Expr1 ");
            strSql.Append(" FROM      PayInfo INNER JOIN Materiel ON PayInfo.MaterielID = Materiel.ID INNER JOIN ");
            strSql.Append(" Working ON PayInfo.WorkingID = Working.ID WHERE   (PayInfo.EmployeeID = @EmployeeID) AND (PayInfo.DateTime > ");
            strSql.Append(" @dtOne) AND (PayInfo.DateTime < @dtTwo) GROUP BY PayInfo.EmployeeID, Materiel.Name, Working.Name ORDER BY MaterielName, WorkName");
            SqlParameter[] sps = { new SqlParameter("@EmployeeID", EmployeeID), new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo) };
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
			parameters[0].Value = "WorkTicketIDCard";
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

