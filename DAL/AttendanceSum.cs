using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类AttendanceSum。
	/// </summary>
	public class AttendanceSum
	{
		public AttendanceSum()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "AttendanceSum"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AttendanceSum");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.AttendanceSum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into AttendanceSum(");
			strSql.Append("EmployeeID,MainID,DayWorkMin,DayWorkTime,BelateMin,LeaveEarlyMin,AbsenteeismMin,Money,OvertimeMin,OvertimeTime)");
			strSql.Append(" values (");
			strSql.Append("@EmployeeID,@MainID,@DayWorkMin,@DayWorkTime,@BelateMin,@LeaveEarlyMin,@AbsenteeismMin,@Money,@OvertimeMin,@OvertimeTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@DayWorkMin", SqlDbType.Int,4),
					new SqlParameter("@DayWorkTime", SqlDbType.DateTime),
					new SqlParameter("@BelateMin", SqlDbType.Int,4),
					new SqlParameter("@LeaveEarlyMin", SqlDbType.Int,4),
					new SqlParameter("@AbsenteeismMin", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@OvertimeMin", SqlDbType.Int,4),
					new SqlParameter("@OvertimeTime", SqlDbType.DateTime)};
			parameters[0].Value = model.EmployeeID;
			parameters[1].Value = model.MainID;
			parameters[2].Value = model.DayWorkMin;
			parameters[3].Value = model.DayWorkTime;
			parameters[4].Value = model.BelateMin;
			parameters[5].Value = model.LeaveEarlyMin;
			parameters[6].Value = model.AbsenteeismMin;
			parameters[7].Value = model.Money;
			parameters[8].Value = model.OvertimeMin;
			parameters[9].Value = model.OvertimeTime;

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
		public void Update(Hownet.Model.AttendanceSum model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update AttendanceSum set ");
			strSql.Append("EmployeeID=@EmployeeID,");
			strSql.Append("MainID=@MainID,");
			strSql.Append("DayWorkMin=@DayWorkMin,");
			strSql.Append("DayWorkTime=@DayWorkTime,");
			strSql.Append("BelateMin=@BelateMin,");
			strSql.Append("LeaveEarlyMin=@LeaveEarlyMin,");
			strSql.Append("AbsenteeismMin=@AbsenteeismMin,");
			strSql.Append("Money=@Money,");
			strSql.Append("OvertimeMin=@OvertimeMin,");
			strSql.Append("OvertimeTime=@OvertimeTime");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@DayWorkMin", SqlDbType.Int,4),
					new SqlParameter("@DayWorkTime", SqlDbType.DateTime),
					new SqlParameter("@BelateMin", SqlDbType.Int,4),
					new SqlParameter("@LeaveEarlyMin", SqlDbType.Int,4),
					new SqlParameter("@AbsenteeismMin", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@OvertimeMin", SqlDbType.Int,4),
					new SqlParameter("@OvertimeTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.EmployeeID;
			parameters[2].Value = model.MainID;
			parameters[3].Value = model.DayWorkMin;
			parameters[4].Value = model.DayWorkTime;
			parameters[5].Value = model.BelateMin;
			parameters[6].Value = model.LeaveEarlyMin;
			parameters[7].Value = model.AbsenteeismMin;
			parameters[8].Value = model.Money;
			parameters[9].Value = model.OvertimeMin;
			parameters[10].Value = model.OvertimeTime;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from AttendanceSum ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.AttendanceSum GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,EmployeeID,MainID,DayWorkMin,DayWorkTime,BelateMin,LeaveEarlyMin,AbsenteeismMin,Money,OvertimeMin,OvertimeTime from AttendanceSum ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.AttendanceSum model=new Hownet.Model.AttendanceSum();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EmployeeID"].ToString()!="")
				{
					model.EmployeeID=int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DayWorkMin"].ToString()!="")
				{
					model.DayWorkMin=int.Parse(ds.Tables[0].Rows[0]["DayWorkMin"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DayWorkTime"].ToString()!="")
				{
					model.DayWorkTime=DateTime.Parse(ds.Tables[0].Rows[0]["DayWorkTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BelateMin"].ToString()!="")
				{
					model.BelateMin=int.Parse(ds.Tables[0].Rows[0]["BelateMin"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LeaveEarlyMin"].ToString()!="")
				{
					model.LeaveEarlyMin=int.Parse(ds.Tables[0].Rows[0]["LeaveEarlyMin"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AbsenteeismMin"].ToString()!="")
				{
					model.AbsenteeismMin=int.Parse(ds.Tables[0].Rows[0]["AbsenteeismMin"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Money"].ToString()!="")
				{
					model.Money=decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OvertimeMin"].ToString()!="")
				{
					model.OvertimeMin=int.Parse(ds.Tables[0].Rows[0]["OvertimeMin"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OvertimeTime"].ToString()!="")
				{
					model.OvertimeTime=DateTime.Parse(ds.Tables[0].Rows[0]["OvertimeTime"].ToString());
				}
				model.A=1;
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
			strSql.Append("select 1 as A,ID,EmployeeID,MainID,DayWorkMin,DayWorkTime,BelateMin,LeaveEarlyMin,AbsenteeismMin,Money,OvertimeMin,OvertimeTime ");
			strSql.Append(" FROM AttendanceSum ");
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
			strSql.Append(" ID,EmployeeID,MainID,DayWorkMin,DayWorkTime,BelateMin,LeaveEarlyMin,AbsenteeismMin,Money,OvertimeMin,OvertimeTime ");
			strSql.Append(" FROM AttendanceSum ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
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
			parameters[0].Value = "AttendanceSum";
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

