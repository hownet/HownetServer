using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类PayInfo。
    /// </summary>
    public class PayInfo
    {
        public PayInfo()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PayInfo");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.PayInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PayInfo(");
            strSql.Append("EmployeeID,DateTime,MaterielID,WorkingID,Amount,Price,ProductWorkingID,WorkticketInfoID,IsSum,BreakID,ColorID,SizeID,BoxNum,OderNum,IsDay)");
            strSql.Append(" values (");
            strSql.Append("@EmployeeID,@DateTime,@MaterielID,@WorkingID,@Amount,@Price,@ProductWorkingID,@WorkticketInfoID,@IsSum,@BreakID,@ColorID,@SizeID,@BoxNum,@OderNum,@IsDay)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@ProductWorkingID", SqlDbType.Int,4),
					new SqlParameter("@WorkticketInfoID", SqlDbType.Int,4),
					new SqlParameter("@IsSum", SqlDbType.Bit,1),
					new SqlParameter("@BreakID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.Int,4),
					new SqlParameter("@OderNum", SqlDbType.NVarChar,50),
					new SqlParameter("@IsDay", SqlDbType.Bit,4)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.WorkingID;
            parameters[4].Value = model.Amount;
            parameters[5].Value = model.Price;
            parameters[6].Value = model.ProductWorkingID;
            parameters[7].Value = model.WorkticketInfoID;
            parameters[8].Value = model.IsSum;
            parameters[9].Value = model.BreakID;
            parameters[10].Value = model.ColorID;
            parameters[11].Value = model.SizeID;
            parameters[12].Value = model.BoxNum;
            parameters[13].Value = model.OderNum;
            parameters[14].Value = model.IsDay;

            try
            {
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
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Hownet.Model.PayInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PayInfo set ");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("WorkingID=@WorkingID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Price=@Price,");
            strSql.Append("ProductWorkingID=@ProductWorkingID,");
            strSql.Append("WorkticketInfoID=@WorkticketInfoID,");
            strSql.Append("IsSum=@IsSum,");
            strSql.Append("BreakID=@BreakID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("BoxNum=@BoxNum,");
            strSql.Append("OderNum=@OderNum,");
            strSql.Append("IsDay=@IsDay");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@ProductWorkingID", SqlDbType.Int,4),
					new SqlParameter("@WorkticketInfoID", SqlDbType.Int,4),
					new SqlParameter("@IsSum", SqlDbType.Bit,1),
					new SqlParameter("@BreakID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.Int,4),
					new SqlParameter("@OderNum", SqlDbType.NVarChar,50),
					new SqlParameter("@IsDay", SqlDbType.Bit,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.DateTime;
            parameters[3].Value = model.MaterielID;
            parameters[4].Value = model.WorkingID;
            parameters[5].Value = model.Amount;
            parameters[6].Value = model.Price;
            parameters[7].Value = model.ProductWorkingID;
            parameters[8].Value = model.WorkticketInfoID;
            parameters[9].Value = model.IsSum;
            parameters[10].Value = model.BreakID;
            parameters[11].Value = model.ColorID;
            parameters[12].Value = model.SizeID;
            parameters[13].Value = model.BoxNum;
            parameters[14].Value = model.OderNum;
            parameters[15].Value = model.IsDay;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.PayInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,EmployeeID,DateTime,MaterielID,WorkingID,Amount,Price,ProductWorkingID,WorkticketInfoID,IsSum,BreakID,ColorID,SizeID,BoxNum,OderNum,IsDay from PayInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.PayInfo model = new Hownet.Model.PayInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
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
                if (ds.Tables[0].Rows[0]["ProductWorkingID"].ToString() != "")
                {
                    model.ProductWorkingID = int.Parse(ds.Tables[0].Rows[0]["ProductWorkingID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["WorkticketInfoID"].ToString() != "")
                {
                    model.WorkticketInfoID = int.Parse(ds.Tables[0].Rows[0]["WorkticketInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsSum"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsSum"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsSum"].ToString().ToLower() == "true"))
                    {
                        model.IsSum = true;
                    }
                    else
                    {
                        model.IsSum = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["BreakID"].ToString() != "")
                {
                    model.BreakID = int.Parse(ds.Tables[0].Rows[0]["BreakID"].ToString());
                }
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
                model.OderNum = ds.Tables[0].Rows[0]["OderNum"].ToString();
                if (ds.Tables[0].Rows[0]["IsDay"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsDay"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsDay"].ToString().ToLower() == "true"))
                    {
                        model.IsDay = true;
                    }
                    else
                    {
                        model.IsDay = false;
                    }
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
            strSql.Append("select 1 as A,ID,EmployeeID,DateTime,MaterielID,WorkingID,Amount,Price,ProductWorkingID,WorkticketInfoID,IsSum,BreakID,ColorID,SizeID,BoxNum,OderNum,IsDay ");
            strSql.Append(" FROM PayInfo ");
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
            strSql.Append(" ID,EmployeeID,DateTime,MaterielID,WorkingID,Amount,Price,ProductWorkingID,WorkticketInfoID,IsSum,BreakID,ColorID,SizeID,BoxNum,OderNum,IsDay ");
            strSql.Append(" FROM PayInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 弃审手动回收
        /// </summary>
        public void DeleteHand(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayInfo ");
            strSql.Append(" where ColorID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        
        public void DelByInfoID(DateTime dt, int ID, int BreakID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" DELETE FROM PayInfo WHERE (DateTime = @dt) And (WorkticketInfoID = @ID) AND (BreakID = @BreakID)");
            SqlParameter[] sps = {new SqlParameter("@dt",dt), new SqlParameter("@ID", ID), new SqlParameter("@BreakID", BreakID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetBackList(DateTime dt, int EmployeeID)
        {
            DateTime dtOne = dt.AddSeconds(-1);
            DateTime dtTwo = dt.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID, EmployeeID, DateTime, MaterielID, WorkingID, Amount, (SELECT   Price FROM      ProductWorkingInfo ");
            strSql.Append(" WHERE   (ID = PayInfo.ProductWorkingID)) AS Price, ProductWorkingID, WorkticketInfoID,  ");
            strSql.Append(" IsSum, BreakID, ColorID, SizeID, BoxNum, OderNum, Amount * Price AS Money,1 as A,IsDay FROM      PayInfo ");
            strSql.Append(" WHERE   (DateTime > @dtOne) AND (DateTime < @dtTwo) AND (EmployeeID = @EmployeeID) And (SIzeID>0) And (IsDay=0)"); 
            SqlParameter[] sps = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo), new SqlParameter("@EmployeeID", EmployeeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetDayList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT CAST(CONVERT(varchar(10), DateTime, 20) AS DateTime) AS DateTime ");
            strSql.Append(" FROM PayInfo GROUP BY CAST(CONVERT(varchar(10), DateTime, 20) AS DateTime) ORDER BY DateTime");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetDayReport(DateTime dt)
        {
            DateTime dtOne = dt.AddSeconds(-1);
            DateTime dtTwo = dt.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      MiniEmp WHERE   (ID = PayInfo.EmployeeID)) AS EmpName, EmployeeID,");
            strSql.Append("(Select Sn from MiniEmp where (ID= PayInfo.EmployeeID)) AS Sn,");
            strSql.Append(" (SELECT   Name FROM      Materiel WHERE   (ID = PayInfo.MaterielID)) AS MaterielName, ");
            strSql.Append("  (SELECT   Name FROM      Working WHERE   (ID = PayInfo.WorkingID)) AS WorkingName, SUM(Amount) AS ");
            strSql.Append(" Amount,  (SELECT   Name FROM      Deparment WHERE   (ID = (SELECT   DepartmentID ");
            strSql.Append(" FROM      MiniEmp AS MiniEmp_1 WHERE   (ID = PayInfo.EmployeeID)))) AS DeparmentName FROM   ");
            strSql.Append(" PayInfo WHERE   (DateTime > @dtOne) AND (DateTime < @dtTwo) And (IsDay=0)");
            strSql.Append(" GROUP BY EmployeeID, MaterielID, WorkingID");
            SqlParameter[] sps = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo), new SqlParameter("@dt", dt) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 获取需要新添加到PayInfo表的记录
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="BoxNum"></param>
        /// <param name="WorkingID"></param>
        /// <returns></returns>
        public DataSet GetAddPayInfo(int TaskID, int BoxNum, int WorkingID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   0 AS ID, WorkTicketInfo.EmployeeID, WorkTicketInfo.DateTime, (SELECT   MaterielID FROM      ProductTaskMain ");
            strSql.Append(" WHERE   (ID = WorkTicketInfo.TaskID)) AS MaterielID, WorkTicketInfo.WorkingID, WorkTicketInfo.Amount,  ");
            strSql.Append(" ProductWorkingInfo_1.Price, WorkTicketInfo.PWorkingInfoID AS ProductWorkingID, ");
            strSql.Append(" WorkTicketInfo.ID AS WorkticketInfoID, 0 AS IsSum, WorkTicketInfo.BackID as BreakID, WorkTicket.ColorID, WorkTicket.SizeID, ");
            strSql.Append(" WorkTicket.BoxNum, ' ' AS OderNum ,Price*WorkTicketInfo.Amount as Money,1 as A ,0 as IsDay FROM      WorkTicketInfo INNER JOIN WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo AS ProductWorkingInfo_1 ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo_1.ID ");
            strSql.Append(" WHERE    ((SELECT   BoxNum FROM      WorkTicket ");
            strSql.Append(" WHERE   (ID = WorkTicketInfo.MainID)) = @BoxNum)  AND (WorkTicketInfo.TaskID = @TaskID) AND  (WorkTicketInfo.WorkingID = @WorkingID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@BoxNum", BoxNum), new SqlParameter("@WorkingID", WorkingID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetEmpWorkList(int EmployeeID, DateTime dtOne, DateTime dtTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CONVERT(varchar(10), DateTime, 120) AS DateTime, SUM(Amount) AS Amount ");
            strSql.Append("  FROM      PayInfo WHERE   (DateTime > @DateOne) AND (DateTime < @DateTwo) AND (EmployeeID = ");
            strSql.Append(" @EmployeeID) And (IsDay=0) GROUP BY CONVERT(varchar(10), DateTime, 120), EmployeeID ORDER BY DateTime");
            SqlParameter[] sps = { new SqlParameter("@DateOne", dtOne), new SqlParameter("@DateTwo", dtTwo), new SqlParameter("@EmployeeID", EmployeeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public void DelDayWorking(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PayInfo ");
            strSql.Append(" where BoxNum=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 根据分箱工序ID，删除一条记录
        /// </summary>
        /// <param name="WTIID"></param>
        public void DelByWTInfoID( int WTIID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" DELETE FROM PayInfo WHERE (WorkticketInfoID = @ID) ");
            SqlParameter[] sps = { new SqlParameter("@ID", WTIID) };
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
            parameters[0].Value = "PayInfo";
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

