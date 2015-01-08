using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类OrderingList。
    /// </summary>
    public class OrderingList
    {
        public OrderingList()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from OrderingList");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.OrderingList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into OrderingList(");
            strSql.Append("EmployeeID,DateTime,OrderOne,DinOne,OrderOneTime,DiningOneTime,OrderTwo,DinTwo,OrdeTwoTime,DiningTwoTime,OrderThree,DinThree,OrdeThreeTime,DiningThreeTime,OrderCount,DinCount,Money,IsSum)");
            strSql.Append(" values (");
            strSql.Append("@EmployeeID,@DateTime,@OrderOne,@DinOne,@OrderOneTime,@DiningOneTime,@OrderTwo,@DinTwo,@OrdeTwoTime,@DiningTwoTime,@OrderThree,@DinThree,@OrdeThreeTime,@DiningThreeTime,@OrderCount,@DinCount,@Money,@IsSum)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@OrderOne", SqlDbType.Int,4),
					new SqlParameter("@DinOne", SqlDbType.Int,4),
					new SqlParameter("@OrderOneTime", SqlDbType.DateTime),
					new SqlParameter("@DiningOneTime", SqlDbType.DateTime),
					new SqlParameter("@OrderTwo", SqlDbType.Int,4),
					new SqlParameter("@DinTwo", SqlDbType.Int,4),
					new SqlParameter("@OrdeTwoTime", SqlDbType.DateTime),
					new SqlParameter("@DiningTwoTime", SqlDbType.DateTime),
					new SqlParameter("@OrderThree", SqlDbType.Int,4),
					new SqlParameter("@DinThree", SqlDbType.Int,4),
					new SqlParameter("@OrdeThreeTime", SqlDbType.DateTime),
					new SqlParameter("@DiningThreeTime", SqlDbType.DateTime),
					new SqlParameter("@OrderCount", SqlDbType.Int,4),
					new SqlParameter("@DinCount", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsSum", SqlDbType.Bit,1)};
            parameters[0].Value = model.EmployeeID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.OrderOne;
            parameters[3].Value = model.DinOne;
            parameters[4].Value = model.OrderOneTime;
            parameters[5].Value = model.DiningOneTime;
            parameters[6].Value = model.OrderTwo;
            parameters[7].Value = model.DinTwo;
            parameters[8].Value = model.OrdeTwoTime;
            parameters[9].Value = model.DiningTwoTime;
            parameters[10].Value = model.OrderThree;
            parameters[11].Value = model.DinThree;
            parameters[12].Value = model.OrdeThreeTime;
            parameters[13].Value = model.DiningThreeTime;
            parameters[14].Value = model.OrderCount;
            parameters[15].Value = model.DinCount;
            parameters[16].Value = model.Money;
            parameters[17].Value = model.IsSum;

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
        public void Update(Hownet.Model.OrderingList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update OrderingList set ");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("OrderOne=@OrderOne,");
            strSql.Append("DinOne=@DinOne,");
            strSql.Append("OrderOneTime=@OrderOneTime,");
            strSql.Append("DiningOneTime=@DiningOneTime,");
            strSql.Append("OrderTwo=@OrderTwo,");
            strSql.Append("DinTwo=@DinTwo,");
            strSql.Append("OrdeTwoTime=@OrdeTwoTime,");
            strSql.Append("DiningTwoTime=@DiningTwoTime,");
            strSql.Append("OrderThree=@OrderThree,");
            strSql.Append("DinThree=@DinThree,");
            strSql.Append("OrdeThreeTime=@OrdeThreeTime,");
            strSql.Append("DiningThreeTime=@DiningThreeTime,");
            strSql.Append("OrderCount=@OrderCount,");
            strSql.Append("DinCount=@DinCount,");
            strSql.Append("Money=@Money,");
            strSql.Append("IsSum=@IsSum");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@OrderOne", SqlDbType.Int,4),
					new SqlParameter("@DinOne", SqlDbType.Int,4),
					new SqlParameter("@OrderOneTime", SqlDbType.DateTime),
					new SqlParameter("@DiningOneTime", SqlDbType.DateTime),
					new SqlParameter("@OrderTwo", SqlDbType.Int,4),
					new SqlParameter("@DinTwo", SqlDbType.Int,4),
					new SqlParameter("@OrdeTwoTime", SqlDbType.DateTime),
					new SqlParameter("@DiningTwoTime", SqlDbType.DateTime),
					new SqlParameter("@OrderThree", SqlDbType.Int,4),
					new SqlParameter("@DinThree", SqlDbType.Int,4),
					new SqlParameter("@OrdeThreeTime", SqlDbType.DateTime),
					new SqlParameter("@DiningThreeTime", SqlDbType.DateTime),
					new SqlParameter("@OrderCount", SqlDbType.Int,4),
					new SqlParameter("@DinCount", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@IsSum", SqlDbType.Bit,1)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.DateTime;
            parameters[3].Value = model.OrderOne;
            parameters[4].Value = model.DinOne;
            parameters[5].Value = model.OrderOneTime;
            parameters[6].Value = model.DiningOneTime;
            parameters[7].Value = model.OrderTwo;
            parameters[8].Value = model.DinTwo;
            parameters[9].Value = model.OrdeTwoTime;
            parameters[10].Value = model.DiningTwoTime;
            parameters[11].Value = model.OrderThree;
            parameters[12].Value = model.DinThree;
            parameters[13].Value = model.OrdeThreeTime;
            parameters[14].Value = model.DiningThreeTime;
            parameters[15].Value = model.OrderCount;
            parameters[16].Value = model.DinCount;
            parameters[17].Value = model.Money;
            parameters[18].Value = model.IsSum;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from OrderingList ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.OrderingList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,EmployeeID,DateTime,OrderOne,DinOne,OrderOneTime,DiningOneTime,OrderTwo,DinTwo,OrdeTwoTime,DiningTwoTime,OrderThree,DinThree,OrdeThreeTime,DiningThreeTime,OrderCount,DinCount,Money,IsSum from OrderingList ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.OrderingList model = new Hownet.Model.OrderingList();
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
                if (ds.Tables[0].Rows[0]["OrderOne"].ToString() != "")
                {
                    model.OrderOne = int.Parse(ds.Tables[0].Rows[0]["OrderOne"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DinOne"].ToString() != "")
                {
                    model.DinOne = int.Parse(ds.Tables[0].Rows[0]["DinOne"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderOneTime"].ToString() != "")
                {
                    model.OrderOneTime = DateTime.Parse(ds.Tables[0].Rows[0]["OrderOneTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DiningOneTime"].ToString() != "")
                {
                    model.DiningOneTime = DateTime.Parse(ds.Tables[0].Rows[0]["DiningOneTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderTwo"].ToString() != "")
                {
                    model.OrderTwo = int.Parse(ds.Tables[0].Rows[0]["OrderTwo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DinTwo"].ToString() != "")
                {
                    model.DinTwo = int.Parse(ds.Tables[0].Rows[0]["DinTwo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrdeTwoTime"].ToString() != "")
                {
                    model.OrdeTwoTime = DateTime.Parse(ds.Tables[0].Rows[0]["OrdeTwoTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DiningTwoTime"].ToString() != "")
                {
                    model.DiningTwoTime = DateTime.Parse(ds.Tables[0].Rows[0]["DiningTwoTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderThree"].ToString() != "")
                {
                    model.OrderThree = int.Parse(ds.Tables[0].Rows[0]["OrderThree"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DinThree"].ToString() != "")
                {
                    model.DinThree = int.Parse(ds.Tables[0].Rows[0]["DinThree"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrdeThreeTime"].ToString() != "")
                {
                    model.OrdeThreeTime = DateTime.Parse(ds.Tables[0].Rows[0]["OrdeThreeTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DiningThreeTime"].ToString() != "")
                {
                    model.DiningThreeTime = DateTime.Parse(ds.Tables[0].Rows[0]["DiningThreeTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderCount"].ToString() != "")
                {
                    model.OrderCount = int.Parse(ds.Tables[0].Rows[0]["OrderCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DinCount"].ToString() != "")
                {
                    model.DinCount = int.Parse(ds.Tables[0].Rows[0]["DinCount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
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
            strSql.Append("select 1 as A,ID,EmployeeID,DateTime,OrderOne,DinOne,OrderOneTime,DiningOneTime,OrderTwo,DinTwo,OrdeTwoTime,DiningTwoTime,OrderThree,DinThree,OrdeThreeTime,DiningThreeTime,OrderCount,DinCount,Money,IsSum ");
            strSql.Append(" FROM OrderingList ");
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
            strSql.Append(" ID,EmployeeID,DateTime,OrderOne,DinOne,OrderOneTime,DiningOneTime,OrderTwo,DinTwo,OrdeTwoTime,DiningTwoTime,OrderThree,DinThree,OrdeThreeTime,DiningThreeTime,OrderCount,DinCount,Money,IsSum ");
            strSql.Append(" FROM OrderingList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetOderList(DateTime dt1, DateTime dt2, int DepID, int EmpID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   MiniEmp.DepartmentID, OrderingList.ID, OrderingList.EmployeeID, OrderingList.DateTime, OrderingList.OrderOne, ");
            strSql.Append(" OrderingList.DinOne, OrderingList.OrderOneTime, OrderingList.DiningOneTime, OrderingList.OrderTwo, ");
            strSql.Append(" OrderingList.DinTwo, OrderingList.OrdeTwoTime, OrderingList.DiningTwoTime, OrderingList.OrderThree, ");
            strSql.Append(" OrderingList.DinThree, OrderingList.OrdeThreeTime, OrderingList.DiningThreeTime, OrderingList.OrderCount, ");
            strSql.Append(" OrderingList.Money,OrderingList.IsSum,");
            strSql.Append(" OrderingList.DinCount FROM OrderingList INNER JOIN MiniEmp ON OrderingList.EmployeeID = MiniEmp.ID ");
            strSql.Append(" WHERE  (OrderingList.DateTime > @dt1) AND  (OrderingList.DateTime < @dt2)");
            if (DepID > 0)
                strSql.Append("AND (MiniEmp.DepartmentID = @DepID)  ");
            if (EmpID > 0)
                strSql.Append("AND (OrderingList.EmployeeID = @EmpID) ");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@DepID", DepID), new SqlParameter("@EmpID", EmpID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetOrderCount(DateTime dt1, DateTime dt2, int EmpID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(OrderOne) AS OrderOne, SUM(DinOne) AS DinOne, SUM(OrderTwo) AS OrderTwo, SUM(DinTwo) AS DinTwo, ");
            strSql.Append(" SUM(OrderThree) AS OrderThree, SUM(DinThree) AS DinThree FROM      OrderingList WHERE   (DateTime > @dt1) AND ");
            strSql.Append(" (DateTime < @dt2) ");
            if (EmpID > 0)
                strSql.Append(" AND (EmployeeID = @EmpID)");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@EmpID", EmpID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetIDList(DateTime date)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID,EmployeeID FROM      OrderingList WHERE   (IsSum = 0) AND (DateTime < @date) order by ID");
            SqlParameter[] sps = { new SqlParameter("@date", date) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public decimal GetMoney(int EmployeeID, DateTime dtOne, DateTime dtTwo, int AllowedCount, decimal ErrorMoney, decimal ZhaoCan, decimal WuCan, decimal WanCan)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(ABS(OrderOne - DinOne) + ABS(OrderTwo - DinTwo) + ABS(OrderThree - DinThree)) AS aa,");
            strSql.Append(" SUM(Money) AS Money, SUM(ABS(OrderOne - DinOne)) AS Zhao, SUM(ABS(OrderTwo - DinTwo)) AS WU, ");
            strSql.Append(" SUM(ABS(OrderThree - DinThree))  AS Wan,EmployeeID FROM      OrderingList ");
            strSql.Append(" WHERE   (EmployeeID = @EmployeeID) AND (DateTime >= @dtOne) AND (DateTime < @dtTwo) GROUP BY EmployeeID");
            SqlParameter[] sps = { new SqlParameter("@EmployeeID", EmployeeID), new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo) };
            DataTable dt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
          
            if (dt.Rows.Count > 0)
            {

                try
                {
                    decimal money = Convert.ToDecimal(dt.Rows[0]["Money"]);
                    int a = Convert.ToInt32(dt.Rows[0]["aa"]);
                    if (AllowedCount > 0)
                    {
                        if (a > AllowedCount)
                        {
                            money -= AllowedCount * ErrorMoney;
                            money += AllowedCount * WuCan;
                        }
                        else
                        {
                            money -= a * ErrorMoney;
                            money += a * WuCan;
                        }
                    }
                    return money;
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

            
        }
        public void UpIsSum(int IsSum, DateTime dtOne, DateTime dtTwo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE  OrderingList SET IsSum = @IsSum WHERE   (DateTime > @dtOne) AND (DateTime < @dtTwo)");
            SqlParameter[] sps = {new SqlParameter("@IsSum",IsSum), new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo) }; ;
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 计算只需订餐的伙食费
        /// </summary>
        /// <param name="ZhaoCan">早餐</param>
        /// <param name="WuCan">午餐</param>
        /// <param name="WanCan">晚餐</param>
        /// <param name="IsDay">计时工是否扣伙食费</param>
        public void CaicMoneyNotEat(decimal ZhaoCan, decimal WuCan, decimal WanCan,  bool IsDay,DateTime date)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" UPDATE  OrderingList SET   Money = (OrderingList.OrderOne * @ZhaoCan + OrderingList.OrderTwo * @WuCan)  ");
                strSql.Append(" + OrderingList.OrderThree * @WanCan FROM      MiniEmp INNER JOIN OrderingList ON MiniEmp.ID = OrderingList.EmployeeID ");
                strSql.Append(" WHERE   (OrderingList.DateTime < @Date)  AND (OrderingList.IsSum = 0)");// AND (MiniEmp.PayID IN (48, 49, 50))");
                SqlParameter[] parameters = {
					new SqlParameter("@ZhaoCan", SqlDbType.Decimal,9),
					new SqlParameter("@WuCan", SqlDbType.Decimal ,9),
					new SqlParameter("@WanCan", SqlDbType.Decimal,9),
					new SqlParameter("@Date", SqlDbType.DateTime)};
                parameters[0].Value = ZhaoCan;
                parameters[1].Value = WuCan;
                parameters[2].Value = WanCan;
                parameters[3].Value = date;
                DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
                if (!IsDay)
                {
                    strSql.Remove(0, strSql.Length);
                    strSql.Append(" UPDATE  OrderingList SET         Money = 0  FROM      MiniEmp INNER JOIN   OrderingList ON MiniEmp.ID = OrderingList.EmployeeID ");
                    strSql.Append(" WHERE   (OrderingList.DateTime < @Date) AND (MiniEmp.PayID IN (48, 49, 50)) AND (OrderingList.IsSum = 0)");
                    SqlParameter[] sps = { new SqlParameter("@Date", date) };
                    DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                }
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 获取某天某餐的订餐情况及各桌的订桌人数。
        /// </summary>
        /// <param name="date"></param>
        /// <param name="CanBie"></param>
        /// <returns></returns>
        public DataSet GetTabeList(DateTime date, string CanBie)
        {

            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("SELECT   MiniEmp.Name, MiniEmp.TableID, OrderingList.DateTime FROM      OrderingList INNER JOIN MiniEmp ON OrderingList.EmployeeID = MiniEmp.ID ");
                strSql.Append(" WHERE   (OrderingList.DateTime = @Date) And (OrderingList." + CanBie + "=1)");
                SqlParameter[] sps = { new SqlParameter("@Date", date) };
                ds.Tables.Add(DbHelperSQL.Query(strSql.ToString(), sps).Tables[0].Copy());
                ds.Tables[0].TableName = "list";

                strSql.Remove(0, strSql.Length);
                strSql.Append("SELECT   MiniEmp.TableID, Deparment.CountEmployee, COUNT(OrderingList.ID) AS CountEmp,  Deparment_1.Name + Deparment.Name AS TabName ");
                strSql.Append(" FROM      OrderingList INNER JOIN MiniEmp ON OrderingList.EmployeeID = MiniEmp.ID INNER JOIN Deparment ON MiniEmp.TableID = ");
                strSql.Append(" Deparment.ID INNER JOIN Deparment AS Deparment_1 ON Deparment.ParentID = Deparment_1.ID ");
                strSql.Append(" WHERE   (OrderingList.DateTime = @Date)  And (OrderingList." + CanBie + "=1)" );
                strSql.Append(" GROUP BY MiniEmp.TableID, Deparment.CountEmployee, Deparment.Name, Deparment_1.Name");
                ds.Tables.Add(DbHelperSQL.Query(strSql.ToString(), sps).Tables[0].Copy());
                ds.Tables[1].TableName = "Dep";

                strSql.Remove(0, strSql.Length);
                strSql.Append(" SELECT   MAX(Deparment.CountEmployee) AS Expr1, OtherType.Name FROM      Deparment INNER JOIN Deparment AS Deparment_1 ON Deparment.ParentID = Deparment_1.ID ");
                strSql.Append(" INNER JOIN OtherType ON Deparment_1.TypeID = OtherType.ID GROUP BY OtherType.Name HAVING   (OtherType.Name = N'食堂')");
                ds.Tables.Add(DbHelperSQL.Query(strSql.ToString()).Tables[0].Copy());
                ds.Tables[2].TableName = "MaxEmp";

            }
            catch (Exception ex)
            {
            }
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
            parameters[0].Value = "OrderingList";
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

