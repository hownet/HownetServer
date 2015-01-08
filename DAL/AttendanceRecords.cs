using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类AttendanceRecords。
    /// </summary>
    public class AttendanceRecords
    {
        public AttendanceRecords()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AttendanceRecords");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.AttendanceRecords model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AttendanceRecords(");
            strSql.Append("EmployeeID,DateDay,TimeOne,TimeTwo,TimeThree,TimeFour,TimeFive,TimeSix,BeLateMin,LeaveEarlyMin,DayWorkMin,IsSum,AbsenteeismMin,OvertimeMin,IsWuLianBan,IsWanLianBan,IsTongXiao,LateAtNight)");
            strSql.Append(" values (");
            strSql.Append("@EmployeeID,@DateDay,@TimeOne,@TimeTwo,@TimeThree,@TimeFour,@TimeFive,@TimeSix,@BeLateMin,@LeaveEarlyMin,@DayWorkMin,@IsSum,@AbsenteeismMin,@OvertimeMin,@IsWuLianBan,@IsWanLianBan,@IsTongXiao,@LateAtNight)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateDay", SqlDbType.DateTime),
					new SqlParameter("@TimeOne", SqlDbType.DateTime),
					new SqlParameter("@TimeTwo", SqlDbType.DateTime),
					new SqlParameter("@TimeThree", SqlDbType.DateTime),
					new SqlParameter("@TimeFour", SqlDbType.DateTime),
					new SqlParameter("@TimeFive", SqlDbType.DateTime),
					new SqlParameter("@TimeSix", SqlDbType.DateTime),
					new SqlParameter("@BeLateMin", SqlDbType.Int,4),
					new SqlParameter("@LeaveEarlyMin", SqlDbType.Int,4),
					new SqlParameter("@DayWorkMin", SqlDbType.Int,4),
					new SqlParameter("@IsSum", SqlDbType.Bit,1),
					new SqlParameter("@AbsenteeismMin", SqlDbType.Int,4),
					new SqlParameter("@OvertimeMin", SqlDbType.Int,4),
					new SqlParameter("@IsWuLianBan", SqlDbType.Bit,1),
					new SqlParameter("@IsWanLianBan", SqlDbType.Bit,1),
					new SqlParameter("@IsTongXiao", SqlDbType.Bit,1),
					new SqlParameter("@LateAtNight", SqlDbType.Int,4)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.DateDay;
            parameters[2].Value = model.TimeOne;
            parameters[3].Value = model.TimeTwo;
            parameters[4].Value = model.TimeThree;
            parameters[5].Value = model.TimeFour;
            parameters[6].Value = model.TimeFive;
            parameters[7].Value = model.TimeSix;
            parameters[8].Value = model.BeLateMin;
            parameters[9].Value = model.LeaveEarlyMin;
            parameters[10].Value = model.DayWorkMin;
            parameters[11].Value = model.IsSum;
            parameters[12].Value = model.AbsenteeismMin;
            parameters[13].Value = model.OvertimeMin;
            parameters[14].Value = model.IsWuLianBan;
            parameters[15].Value = model.IsWanLianBan;
            parameters[16].Value = model.IsTongXiao;
            parameters[17].Value = model.LateAtNight;

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
        public void Update(Hownet.Model.AttendanceRecords model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AttendanceRecords set ");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("DateDay=@DateDay,");
            strSql.Append("TimeOne=@TimeOne,");
            strSql.Append("TimeTwo=@TimeTwo,");
            strSql.Append("TimeThree=@TimeThree,");
            strSql.Append("TimeFour=@TimeFour,");
            strSql.Append("TimeFive=@TimeFive,");
            strSql.Append("TimeSix=@TimeSix,");
            strSql.Append("BeLateMin=@BeLateMin,");
            strSql.Append("LeaveEarlyMin=@LeaveEarlyMin,");
            strSql.Append("DayWorkMin=@DayWorkMin,");
            strSql.Append("IsSum=@IsSum,");
            strSql.Append("AbsenteeismMin=@AbsenteeismMin,");
            strSql.Append("OvertimeMin=@OvertimeMin,");
            strSql.Append("IsWuLianBan=@IsWuLianBan,");
            strSql.Append("IsWanLianBan=@IsWanLianBan,");
            strSql.Append("IsTongXiao=@IsTongXiao,");
            strSql.Append("LateAtNight=@LateAtNight");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateDay", SqlDbType.DateTime),
					new SqlParameter("@TimeOne", SqlDbType.DateTime),
					new SqlParameter("@TimeTwo", SqlDbType.DateTime),
					new SqlParameter("@TimeThree", SqlDbType.DateTime),
					new SqlParameter("@TimeFour", SqlDbType.DateTime),
					new SqlParameter("@TimeFive", SqlDbType.DateTime),
					new SqlParameter("@TimeSix", SqlDbType.DateTime),
					new SqlParameter("@BeLateMin", SqlDbType.Int,4),
					new SqlParameter("@LeaveEarlyMin", SqlDbType.Int,4),
					new SqlParameter("@DayWorkMin", SqlDbType.Int,4),
					new SqlParameter("@IsSum", SqlDbType.Bit,1),
					new SqlParameter("@AbsenteeismMin", SqlDbType.Int,4),
					new SqlParameter("@OvertimeMin", SqlDbType.Int,4),
					new SqlParameter("@IsWuLianBan", SqlDbType.Bit,1),
					new SqlParameter("@IsWanLianBan", SqlDbType.Bit,1),
					new SqlParameter("@IsTongXiao", SqlDbType.Bit,1),
					new SqlParameter("@LateAtNight", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.DateDay;
            parameters[3].Value = model.TimeOne;
            parameters[4].Value = model.TimeTwo;
            parameters[5].Value = model.TimeThree;
            parameters[6].Value = model.TimeFour;
            parameters[7].Value = model.TimeFive;
            parameters[8].Value = model.TimeSix;
            parameters[9].Value = model.BeLateMin;
            parameters[10].Value = model.LeaveEarlyMin;
            parameters[11].Value = model.DayWorkMin;
            parameters[12].Value = model.IsSum;
            parameters[13].Value = model.AbsenteeismMin;
            parameters[14].Value = model.OvertimeMin;
            parameters[15].Value = model.IsWuLianBan;
            parameters[16].Value = model.IsWanLianBan;
            parameters[17].Value = model.IsTongXiao;
            parameters[18].Value = model.LateAtNight;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AttendanceRecords ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.AttendanceRecords GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,EmployeeID,DateDay,TimeOne,TimeTwo,TimeThree,TimeFour,TimeFive,TimeSix,BeLateMin,LeaveEarlyMin,DayWorkMin,IsSum,AbsenteeismMin,OvertimeMin,IsWuLianBan,IsWanLianBan,IsTongXiao,LateAtNight from AttendanceRecords ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.AttendanceRecords model = new Hownet.Model.AttendanceRecords();
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
                if (ds.Tables[0].Rows[0]["DateDay"].ToString() != "")
                {
                    model.DateDay = DateTime.Parse(ds.Tables[0].Rows[0]["DateDay"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeOne"].ToString() != "")
                {
                    model.TimeOne = DateTime.Parse(ds.Tables[0].Rows[0]["TimeOne"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeTwo"].ToString() != "")
                {
                    model.TimeTwo = DateTime.Parse(ds.Tables[0].Rows[0]["TimeTwo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeThree"].ToString() != "")
                {
                    model.TimeThree = DateTime.Parse(ds.Tables[0].Rows[0]["TimeThree"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeFour"].ToString() != "")
                {
                    model.TimeFour = DateTime.Parse(ds.Tables[0].Rows[0]["TimeFour"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeFive"].ToString() != "")
                {
                    model.TimeFive = DateTime.Parse(ds.Tables[0].Rows[0]["TimeFive"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TimeSix"].ToString() != "")
                {
                    model.TimeSix = DateTime.Parse(ds.Tables[0].Rows[0]["TimeSix"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BeLateMin"].ToString() != "")
                {
                    model.BeLateMin = int.Parse(ds.Tables[0].Rows[0]["BeLateMin"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LeaveEarlyMin"].ToString() != "")
                {
                    model.LeaveEarlyMin = int.Parse(ds.Tables[0].Rows[0]["LeaveEarlyMin"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DayWorkMin"].ToString() != "")
                {
                    model.DayWorkMin = int.Parse(ds.Tables[0].Rows[0]["DayWorkMin"].ToString());
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
                if (ds.Tables[0].Rows[0]["AbsenteeismMin"].ToString() != "")
                {
                    model.AbsenteeismMin = int.Parse(ds.Tables[0].Rows[0]["AbsenteeismMin"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OvertimeMin"].ToString() != "")
                {
                    model.OvertimeMin = int.Parse(ds.Tables[0].Rows[0]["OvertimeMin"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsWuLianBan"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsWuLianBan"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsWuLianBan"].ToString().ToLower() == "true"))
                    {
                        model.IsWuLianBan = true;
                    }
                    else
                    {
                        model.IsWuLianBan = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsWanLianBan"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsWanLianBan"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsWanLianBan"].ToString().ToLower() == "true"))
                    {
                        model.IsWanLianBan = true;
                    }
                    else
                    {
                        model.IsWanLianBan = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsTongXiao"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsTongXiao"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsTongXiao"].ToString().ToLower() == "true"))
                    {
                        model.IsTongXiao = true;
                    }
                    else
                    {
                        model.IsTongXiao = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["LateAtNight"].ToString() != "")
                {
                    model.LateAtNight = int.Parse(ds.Tables[0].Rows[0]["LateAtNight"].ToString());
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
            strSql.Append("select 1 as A,ID,EmployeeID,DateDay,TimeOne,TimeTwo,TimeThree,TimeFour,TimeFive,TimeSix,BeLateMin,LeaveEarlyMin,DayWorkMin,IsSum,AbsenteeismMin,OvertimeMin,IsWuLianBan,IsWanLianBan,IsTongXiao,LateAtNight ");
            strSql.Append(" FROM AttendanceRecords ");
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
            strSql.Append(" ID,EmployeeID,DateDay,TimeOne,TimeTwo,TimeThree,TimeFour,TimeFive,TimeSix,BeLateMin,LeaveEarlyMin,DayWorkMin,IsSum,AbsenteeismMin,OvertimeMin,IsWuLianBan,IsWanLianBan,IsTongXiao,LateAtNight ");
            strSql.Append(" FROM AttendanceRecords ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得某员工前一天刷卡记录，用于查看是否有通宵
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public DataTable GetYesterday(int EmployeeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  1 as A, MAX(ID) AS ID, EmployeeID, DateDay, TimeOne, TimeTwo, TimeThree, TimeFour, TimeFive, TimeSix, BeLateMin, ");
            strSql.Append(" LeaveEarlyMin, DayWorkMin, IsSum, AbsenteeismMin, OvertimeMin, IsWuLianBan, IsWanLianBan, IsTongXiao, LateAtNight ");
            strSql.Append(" FROM      AttendanceRecords WHERE   (EmployeeID = @EmployeeID) GROUP BY EmployeeID, DateDay, TimeOne, TimeTwo, ");
            strSql.Append(" TimeThree, TimeFour, TimeFive, TimeSix, BeLateMin, LeaveEarlyMin, DayWorkMin, AbsenteeismMin, OvertimeMin, LateAtNight, ");
            strSql.Append(" IsSum, IsWuLianBan, IsWanLianBan, IsTongXiao");
            SqlParameter[] sps = { new SqlParameter("@EmployeeID", EmployeeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
        }
        public DataSet GetSumRecords(DateTime dtOne, DateTime dtTwo)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" SELECT   CaicDayMoney.DayMoney, CaicDayMoney.NightMoney, CaicDayMoney.LateAtNightMoney, CaicDayMoney.TXBT, ");
                strSql.Append(" MiniEmp.DepartmentID, SUM(AttendanceRecords.DayWorkMin) AS DayWorkMin, SUM(AttendanceRecords.LateAtNight) ");
                strSql.Append(" AS LateAtNight, SUM(AttendanceRecords.OvertimeMin) AS OvertimeMin, AttendanceRecords.EmployeeID, ");
                strSql.Append(" SUM(CAST(AttendanceRecords.IsTongXiao AS int)) AS IsTongXiao, ");
                strSql.Append(" CaicDayMoney.DayMoney * SUM(AttendanceRecords.DayWorkMin) / 60 AS DayMoneys, ");
                strSql.Append(" CaicDayMoney.NightMoney * SUM(AttendanceRecords.OvertimeMin) / 60 AS NightMoneys, ");
                strSql.Append(" CaicDayMoney.LateAtNightMoney * SUM(AttendanceRecords.LateAtNight) / 60 AS LateAtNightMoneys, ");
                strSql.Append(" CaicDayMoney.TXBT * SUM(CAST(AttendanceRecords.IsTongXiao AS int))  AS TXBTs, ");
                strSql.Append(" ((CaicDayMoney.DayMoney * SUM(AttendanceRecords.DayWorkMin) ");
                strSql.Append(" / 60 + CaicDayMoney.NightMoney * SUM(AttendanceRecords.OvertimeMin) / 60) ");
                strSql.Append(" + CaicDayMoney.LateAtNightMoney * SUM(AttendanceRecords.LateAtNight) / 60) ");
                strSql.Append(" + CaicDayMoney.TXBT * SUM(CAST(AttendanceRecords.IsTongXiao AS int)) AS Moneys ");
                strSql.Append(" FROM      AttendanceRecords INNER JOIN ");
                strSql.Append(" MiniEmp ON AttendanceRecords.EmployeeID = MiniEmp.ID INNER JOIN ");
                strSql.Append(" CaicDayMoney ON MiniEmp.LassMoney = CaicDayMoney.ID ");
                strSql.Append(" WHERE   (AttendanceRecords.DateDay > @dateOne) AND (AttendanceRecords.DateDay < @dateTwo) ");
                strSql.Append(" GROUP BY CaicDayMoney.DayMoney, CaicDayMoney.NightMoney, CaicDayMoney.LateAtNightMoney, CaicDayMoney.TXBT, ");
                strSql.Append(" MiniEmp.DepartmentID, AttendanceRecords.EmployeeID");
                SqlParameter[] sps = { new SqlParameter("@dateOne", dtOne), new SqlParameter("@dateTwo", dtTwo) };
                return DbHelperSQL.Query(strSql.ToString(), sps);
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
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
            parameters[0].Value = "AttendanceRecords";
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

