using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Pay。
	/// </summary>
	public class Pay
	{
		public Pay()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Pay"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Pay");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Pay model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Pay(");
            strSql.Append("Remain,EmployeeID,Month,Payment,BoardWages,Repair,LastRemain,MainID,Fact,IsEnd,FullAttendance,Fine,Deposit,Add1,Add2,Add3,Add4,Add5,Jian1,Jian2,Jian3,Jian4,Jian5,ActualMonth,NotFact)");
            strSql.Append(" values (");
            strSql.Append("@Remain,@EmployeeID,@Month,@Payment,@BoardWages,@Repair,@LastRemain,@MainID,@Fact,@IsEnd,@FullAttendance,@Fine,@Deposit,@Add1,@Add2,@Add3,@Add4,@Add5,@Jian1,@Jian2,@Jian3,@Jian4,@Jian5,@ActualMonth,@NotFact)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Remain", SqlDbType.Real,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Month", SqlDbType.Real,4),
					new SqlParameter("@Payment", SqlDbType.Real,4),
					new SqlParameter("@BoardWages", SqlDbType.Real,4),
					new SqlParameter("@Repair", SqlDbType.Real,4),
					new SqlParameter("@LastRemain", SqlDbType.Real,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Fact", SqlDbType.Real,4),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@FullAttendance", SqlDbType.Real,4),
					new SqlParameter("@Fine", SqlDbType.Real,4),
					new SqlParameter("@Deposit", SqlDbType.Real,4),
					new SqlParameter("@Add1", SqlDbType.Real,4),
					new SqlParameter("@Add2", SqlDbType.Real,4),
					new SqlParameter("@Add3", SqlDbType.Real,4),
					new SqlParameter("@Add4", SqlDbType.Real,4),
					new SqlParameter("@Add5", SqlDbType.Real,4),
					new SqlParameter("@Jian1", SqlDbType.Real,4),
					new SqlParameter("@Jian2", SqlDbType.Real,4),
					new SqlParameter("@Jian3", SqlDbType.Real,4),
					new SqlParameter("@Jian4", SqlDbType.Real,4),
					new SqlParameter("@Jian5", SqlDbType.Real,4),
					new SqlParameter("@ActualMonth", SqlDbType.Real,4),
					new SqlParameter("@NotFact", SqlDbType.Bit,1)};
            parameters[0].Value = model.Remain;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.Month;
            parameters[3].Value = model.Payment;
            parameters[4].Value = model.BoardWages;
            parameters[5].Value = model.Repair;
            parameters[6].Value = model.LastRemain;
            parameters[7].Value = model.MainID;
            parameters[8].Value = model.Fact;
            parameters[9].Value = model.IsEnd;
            parameters[10].Value = model.FullAttendance;
            parameters[11].Value = model.Fine;
            parameters[12].Value = model.Deposit;
            parameters[13].Value = model.Add1;
            parameters[14].Value = model.Add2;
            parameters[15].Value = model.Add3;
            parameters[16].Value = model.Add4;
            parameters[17].Value = model.Add5;
            parameters[18].Value = model.Jian1;
            parameters[19].Value = model.Jian2;
            parameters[20].Value = model.Jian3;
            parameters[21].Value = model.Jian4;
            parameters[22].Value = model.Jian5;
            parameters[23].Value = model.ActualMonth;
            parameters[24].Value = model.NotFact;

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
        public bool Update(Hownet.Model.Pay model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Pay set ");
            strSql.Append("Remain=@Remain,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("Month=@Month,");
            strSql.Append("Payment=@Payment,");
            strSql.Append("BoardWages=@BoardWages,");
            strSql.Append("Repair=@Repair,");
            strSql.Append("LastRemain=@LastRemain,");
            strSql.Append("MainID=@MainID,");
            strSql.Append("Fact=@Fact,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("FullAttendance=@FullAttendance,");
            strSql.Append("Fine=@Fine,");
            strSql.Append("Deposit=@Deposit,");
            strSql.Append("Add1=@Add1,");
            strSql.Append("Add2=@Add2,");
            strSql.Append("Add3=@Add3,");
            strSql.Append("Add4=@Add4,");
            strSql.Append("Add5=@Add5,");
            strSql.Append("Jian1=@Jian1,");
            strSql.Append("Jian2=@Jian2,");
            strSql.Append("Jian3=@Jian3,");
            strSql.Append("Jian4=@Jian4,");
            strSql.Append("Jian5=@Jian5,");
            strSql.Append("ActualMonth=@ActualMonth,");
            strSql.Append("NotFact=@NotFact");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Remain", SqlDbType.Real,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Month", SqlDbType.Real,4),
					new SqlParameter("@Payment", SqlDbType.Real,4),
					new SqlParameter("@BoardWages", SqlDbType.Real,4),
					new SqlParameter("@Repair", SqlDbType.Real,4),
					new SqlParameter("@LastRemain", SqlDbType.Real,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Fact", SqlDbType.Real,4),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@FullAttendance", SqlDbType.Real,4),
					new SqlParameter("@Fine", SqlDbType.Real,4),
					new SqlParameter("@Deposit", SqlDbType.Real,4),
					new SqlParameter("@Add1", SqlDbType.Real,4),
					new SqlParameter("@Add2", SqlDbType.Real,4),
					new SqlParameter("@Add3", SqlDbType.Real,4),
					new SqlParameter("@Add4", SqlDbType.Real,4),
					new SqlParameter("@Add5", SqlDbType.Real,4),
					new SqlParameter("@Jian1", SqlDbType.Real,4),
					new SqlParameter("@Jian2", SqlDbType.Real,4),
					new SqlParameter("@Jian3", SqlDbType.Real,4),
					new SqlParameter("@Jian4", SqlDbType.Real,4),
					new SqlParameter("@Jian5", SqlDbType.Real,4),
					new SqlParameter("@ActualMonth", SqlDbType.Real,4),
					new SqlParameter("@NotFact", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Remain;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.Month;
            parameters[3].Value = model.Payment;
            parameters[4].Value = model.BoardWages;
            parameters[5].Value = model.Repair;
            parameters[6].Value = model.LastRemain;
            parameters[7].Value = model.MainID;
            parameters[8].Value = model.Fact;
            parameters[9].Value = model.IsEnd;
            parameters[10].Value = model.FullAttendance;
            parameters[11].Value = model.Fine;
            parameters[12].Value = model.Deposit;
            parameters[13].Value = model.Add1;
            parameters[14].Value = model.Add2;
            parameters[15].Value = model.Add3;
            parameters[16].Value = model.Add4;
            parameters[17].Value = model.Add5;
            parameters[18].Value = model.Jian1;
            parameters[19].Value = model.Jian2;
            parameters[20].Value = model.Jian3;
            parameters[21].Value = model.Jian4;
            parameters[22].Value = model.Jian5;
            parameters[23].Value = model.ActualMonth;
            parameters[24].Value = model.NotFact;
            parameters[25].Value = model.ID;

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
            strSql.Append("delete from Pay ");
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
            strSql.Append("delete from Pay ");
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
        public Hownet.Model.Pay GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Remain,EmployeeID,Month,Payment,BoardWages,Repair,LastRemain,MainID,Fact,IsEnd,FullAttendance,Fine,Deposit,Add1,Add2,Add3,Add4,Add5,Jian1,Jian2,Jian3,Jian4,Jian5,ActualMonth,NotFact from Pay ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.Pay model = new Hownet.Model.Pay();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Remain"] != null && ds.Tables[0].Rows[0]["Remain"].ToString() != "")
                {
                    model.Remain = decimal.Parse(ds.Tables[0].Rows[0]["Remain"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmployeeID"] != null && ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Month"] != null && ds.Tables[0].Rows[0]["Month"].ToString() != "")
                {
                    model.Month = decimal.Parse(ds.Tables[0].Rows[0]["Month"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Payment"] != null && ds.Tables[0].Rows[0]["Payment"].ToString() != "")
                {
                    model.Payment = decimal.Parse(ds.Tables[0].Rows[0]["Payment"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BoardWages"] != null && ds.Tables[0].Rows[0]["BoardWages"].ToString() != "")
                {
                    model.BoardWages = decimal.Parse(ds.Tables[0].Rows[0]["BoardWages"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Repair"] != null && ds.Tables[0].Rows[0]["Repair"].ToString() != "")
                {
                    model.Repair = decimal.Parse(ds.Tables[0].Rows[0]["Repair"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastRemain"] != null && ds.Tables[0].Rows[0]["LastRemain"].ToString() != "")
                {
                    model.LastRemain = decimal.Parse(ds.Tables[0].Rows[0]["LastRemain"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Fact"] != null && ds.Tables[0].Rows[0]["Fact"].ToString() != "")
                {
                    model.Fact = decimal.Parse(ds.Tables[0].Rows[0]["Fact"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"] != null && ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
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
                if (ds.Tables[0].Rows[0]["FullAttendance"] != null && ds.Tables[0].Rows[0]["FullAttendance"].ToString() != "")
                {
                    model.FullAttendance = decimal.Parse(ds.Tables[0].Rows[0]["FullAttendance"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Fine"] != null && ds.Tables[0].Rows[0]["Fine"].ToString() != "")
                {
                    model.Fine = decimal.Parse(ds.Tables[0].Rows[0]["Fine"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Deposit"] != null && ds.Tables[0].Rows[0]["Deposit"].ToString() != "")
                {
                    model.Deposit = decimal.Parse(ds.Tables[0].Rows[0]["Deposit"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Add1"] != null && ds.Tables[0].Rows[0]["Add1"].ToString() != "")
                {
                    model.Add1 = decimal.Parse(ds.Tables[0].Rows[0]["Add1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Add2"] != null && ds.Tables[0].Rows[0]["Add2"].ToString() != "")
                {
                    model.Add2 = decimal.Parse(ds.Tables[0].Rows[0]["Add2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Add3"] != null && ds.Tables[0].Rows[0]["Add3"].ToString() != "")
                {
                    model.Add3 = decimal.Parse(ds.Tables[0].Rows[0]["Add3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Add4"] != null && ds.Tables[0].Rows[0]["Add4"].ToString() != "")
                {
                    model.Add4 = decimal.Parse(ds.Tables[0].Rows[0]["Add4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Add5"] != null && ds.Tables[0].Rows[0]["Add5"].ToString() != "")
                {
                    model.Add5 = decimal.Parse(ds.Tables[0].Rows[0]["Add5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Jian1"] != null && ds.Tables[0].Rows[0]["Jian1"].ToString() != "")
                {
                    model.Jian1 = decimal.Parse(ds.Tables[0].Rows[0]["Jian1"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Jian2"] != null && ds.Tables[0].Rows[0]["Jian2"].ToString() != "")
                {
                    model.Jian2 = decimal.Parse(ds.Tables[0].Rows[0]["Jian2"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Jian3"] != null && ds.Tables[0].Rows[0]["Jian3"].ToString() != "")
                {
                    model.Jian3 = decimal.Parse(ds.Tables[0].Rows[0]["Jian3"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Jian4"] != null && ds.Tables[0].Rows[0]["Jian4"].ToString() != "")
                {
                    model.Jian4 = decimal.Parse(ds.Tables[0].Rows[0]["Jian4"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Jian5"] != null && ds.Tables[0].Rows[0]["Jian5"].ToString() != "")
                {
                    model.Jian5 = decimal.Parse(ds.Tables[0].Rows[0]["Jian5"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ActualMonth"] != null && ds.Tables[0].Rows[0]["ActualMonth"].ToString() != "")
                {
                    model.ActualMonth = decimal.Parse(ds.Tables[0].Rows[0]["ActualMonth"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotFact"] != null && ds.Tables[0].Rows[0]["NotFact"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["NotFact"].ToString() == "1") || (ds.Tables[0].Rows[0]["NotFact"].ToString().ToLower() == "true"))
                    {
                        model.NotFact = true;
                    }
                    else
                    {
                        model.NotFact = false;
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
            strSql.Append("select  1 as A,ID,Remain,EmployeeID,Month,Payment,BoardWages,Repair,LastRemain,MainID,Fact,IsEnd,FullAttendance,Fine,Deposit,Add1,Add2,Add3,Add4,Add5,Jian1,Jian2,Jian3,Jian4,Jian5,ActualMonth,NotFact ");
            strSql.Append(" FROM Pay ");
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
            strSql.Append(" ID,Remain,EmployeeID,Month,Payment,BoardWages,Repair,LastRemain,MainID,Fact,IsEnd,FullAttendance,Fine,Deposit,Add1,Add2,Add3,Add4,Add5,Jian1,Jian2,Jian3,Jian4,Jian5,ActualMonth,NotFact ");
            strSql.Append(" FROM Pay ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 取得工人工资及明细
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetEmpPay(int MainID)
        {
            DataSet ds = new DataSet();
            DataSet dsInfo = new DataSet();
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select ID,(SELECT BegingDate FROM PayMain WHERE (ID = Pay.MainID)) AS BegingDate, ");
            //strSql.Append(" (SELECT EndDate FROM PayMain AS PayMain_1 WHERE (ID = Pay.MainID)) AS EndDate,(select Departmentname from Department where (Departmentid=(select DepartmentID from employee where (employeeid=pay. EmployeeID)))) as DepartmentName , ");
            //strSql.Append("(select employeename from employee where (employeeid=pay.employeeid)) as EmployeeName, (select Sn from employee as qwe where (employeeid=pay.employeeid)) as Sn,Month,LastRemain,Repair,BoardWages,Payment,Fact,Remain,MainID,IsEnd,EmployeeID ");
            //strSql.Append(" FROM Pay where (MainID=@MainID)");
            //strSql.Append(" SELECT Pay.ID, (SELECT BegingDate FROM PayMain WHERE (ID = Pay.MainID)) AS BegingDate, ");
            //strSql.Append(" (SELECT EndDate FROM PayMain AS PayMain_1 WHERE (ID = Pay.MainID)) AS EndDate, 1 as A,");
            //strSql.Append(" (SELECT DepartmentName FROM Department WHERE (DepartmentID = Employee_2.DepartmentID)) ");
            //strSql.Append(" AS DepartmentName, Pay.Month, Pay.LastRemain, Pay.Repair, Pay.BoardWages, Pay.Payment, ");
            //strSql.Append(" Pay.Fact, Pay.Remain, Pay.MainID, Pay.IsEnd, Pay.EmployeeID, Employee_2.EmployeeName,  ");
            //strSql.Append(" Employee_2.Sn, (SELECT OtherTypeName FROM OtherType WHERE (OtherTypeID = Employee_2.PayID)) ");
            //strSql.Append(" AS PayName, Employee_2.LassMoney, Employee_2.Royalty, Employee_2.PayID FROM Pay INNER JOIN ");
            //strSql.Append(" Employee AS Employee_2 ON Pay.EmployeeID = Employee_2.EmployeeID WHERE (Pay.MainID = @MainID)");


            //strSql.Append("SELECT   Pay.ID, 0 as PayID,0 as LassMoney,0 as Royalty,(SELECT   BegingDate FROM      PayMain WHERE   (ID = Pay.MainID)) AS BegingDate, (SELECT   EndDate ");
            //strSql.Append(" FROM      PayMain AS PayMain_1 WHERE   (ID = Pay.MainID)) AS EndDate, 1 AS A, (SELECT   Name FROM      Deparment ");
            //strSql.Append(" WHERE   (ID = MiniEmp.DepartmentID)) AS DepartmentName, Pay.Month, Pay.LastRemain,Pay.Fine, Pay.Repair,Pay.FullAttendance, Pay.BoardWages, Pay.Deposit,");
            //strSql.Append(" Pay.Payment, Pay.Fact, Pay.Remain, Pay.MainID, Pay.IsEnd, Pay.EmployeeID, MiniEmp.Name,  MiniEmp.Sn,MiniEmp.Deposit as AllDeposit FROM      Pay INNER JOIN ");
            //strSql.Append(" MiniEmp ON Pay.EmployeeID = MiniEmp.ID WHERE   (Pay.MainID = @MainID)");

            strSql.Append("SELECT   Pay.ID, (SELECT   BegingDate FROM      PayMain WHERE   (ID = Pay.MainID)) AS BegingDate, (SELECT   EndDate ");
            strSql.Append(" FROM      PayMain AS PayMain_1 WHERE   (ID = Pay.MainID)) AS EndDate, 1 AS A, Pay.Month, Pay.LastRemain, Pay.Fine, Pay.Repair, Pay.FullAttendance, ");
            strSql.Append(" Pay.BoardWages, Pay.Deposit, Pay.Payment, Pay.Fact, Pay.Remain, Pay.MainID, Pay.IsEnd, Pay.EmployeeID,  MiniEmp.DepartmentID, MiniEmp.Sn, ");
            strSql.Append(" MiniEmp.Deposit AS AllDeposit, MiniEmp.PayID, MiniEmp.LassMoney,MiniEmp.BankNO,MiniEmp.BankAccountName,MiniEmp.BankName,  MiniEmp.Royalty, MiniEmp.NeedDeposit, MiniEmp.Deposit AS TemDeposit ");
            strSql.Append(" ,Pay.Add1, Pay.Add2, Pay.Add3, Pay.Add4, Pay.Add5, Pay.Jian1, Pay.Jian2, Pay.Jian3, Pay.Jian4, Pay.Jian5, Pay.ActualMonth,Pay.NotFact ");
            strSql.Append(" FROM      Pay INNER JOIN MiniEmp ON Pay.EmployeeID = MiniEmp.ID WHERE   (Pay.MainID = @MainID)");
            SqlParameter[] sp ={ new SqlParameter("MainID", MainID) };

            ds = DbHelperSQL.Query(strSql.ToString(), sp);
            ds.Tables[0].TableName = "Main";
           // ds.Tables[0].Columns.Add("SumAmount", typeof(int));
            strSql.Remove(0, strSql.Length);
            //strSql.Append("select (select Employeename from employee where (employeeid=paysum.employeeid)) as EmployeeName ,(select Materielname from materiel where (materielid=paysum.MaterielID)) as MaterielName, ");
            //strSql.Append(" (select workingname from working where (workingid=paysum.WorkingID)) as WorkingName,MaterielID,WorkingID, ");
            //strSql.Append(" Amount,Price,Amount*Price as Money, EmployeeID ");
            //strSql.Append(" FROM PaySum where (PayMainID=@MainID)");
            strSql.Append("SELECT   MaterielID, WorkingID, Amount, Price,  Amount * Price AS Money, EmployeeID ");
            strSql.Append(" FROM      PaySum WHERE   (PayMainID = @MainID)");

            SqlParameter[] sp1 ={ new SqlParameter("MainID", MainID) };
            dsInfo = DbHelperSQL.Query(strSql.ToString(), sp1);
            dsInfo.Tables[0].TableName = "Info";
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    int employeeid = int.Parse(ds.Tables[0].Rows[i]["EmployeeID"].ToString());
            //    int amount = 0;
            //    for (int j = 0; j < dsInfo.Tables[0].Rows.Count; j++)
            //    {
            //        if (int.Parse(dsInfo.Tables[0].Rows[j]["EmployeeID"].ToString()) == employeeid)
            //        {
            //            amount += int.Parse(dsInfo.Tables[0].Rows[j]["Amount"].ToString());
            //        }
            //    }
            //    ds.Tables[0].Rows[i]["SumAmount"] = amount;
            //}
            ds.Tables.Add(dsInfo.Tables[0].Copy());
            dsInfo.Clear();
            strSql.Remove(0, strSql.Length);
            Hownet.DAL.SysTem dalST = new SysTem();
            Hownet.Model.SysTem modST = dalST.GetModel(dalST.GetMaxId()-1);
            DataTable dtNoDefault =new DataTable();
            if (modST.DoubleNotDefaultWTNum > 0)
            {
                strSql.Append("SELECT   PaySum.MaterielID, PaySum.WorkingID, PaySum.Amount, PaySum.Price, PaySum.Amount * PaySum.Price AS Money, ");
                strSql.Append(" PaySum.EmployeeID FROM      PaySum INNER JOIN MiniEmp AS MiniEmp_1 ON PaySum.EmployeeID = MiniEmp_1.ID INNER JOIN ");
                strSql.Append(" Working ON PaySum.WorkingID = Working.ID WHERE   (PaySum.PayMainID = @MainID) AND (',' + MiniEmp_1.DefaultWorkType ");
                strSql.Append(" + ',' NOT LIKE '%,' + CAST(Working.WorkTypeID AS nvarchar) + ',%') AND (PaySum.MaterielID > 0) ");
                dtNoDefault = DbHelperSQL.Query(strSql.ToString(), sp1).Tables[0];
            }
            else
            {
                strSql.Append("SELECT   PaySum.MaterielID, PaySum.WorkingID, PaySum.Amount, PaySum.Price, PaySum.Amount * PaySum.Price AS Money, ");
                strSql.Append(" PaySum.EmployeeID FROM      PaySum Where (ID=0)");
                dtNoDefault = DbHelperSQL.Query(strSql.ToString(), sp1).Tables[0];
            }
            dtNoDefault.TableName = "NoDefault";
            ds.Tables.Add(dtNoDefault.Copy());
            dtNoDefault.Clear();
            try
            {
                ds.Relations.Add("明细", ds.Tables["Main"].Columns["EmployeeID"], ds.Tables["Info"].Columns["EmployeeID"]);
            }
            catch
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
        /// 删除一次工资统计
        /// </summary>
        /// <param name="MainID"></param>
        public void DelPay(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete Pay ");
            strSql.Append(" where MainID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
			parameters[0].Value = "Pay";
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

