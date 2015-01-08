using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类DayWorking。
	/// </summary>
	public class DayWorking
	{
		public DayWorking()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "DayWorking"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DayWorking");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.DayWorking model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DayWorking(");
            strSql.Append("DateTime,FillMan,VerifyMan,VerifyDate,UpData,Num,Remark,FillDate,EmployeeID,IsEnd,IsVerify)");
            strSql.Append(" values (");
            strSql.Append("@DateTime,@FillMan,@VerifyMan,@VerifyDate,@UpData,@Num,@Remark,@FillDate,@EmployeeID,@IsEnd,@IsVerify)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.FillMan;
            parameters[2].Value = model.VerifyMan;
            parameters[3].Value = model.VerifyDate;
            parameters[4].Value = model.UpData;
            parameters[5].Value = model.Num;
            parameters[6].Value = model.Remark;
            parameters[7].Value = model.FillDate;
            parameters[8].Value = model.EmployeeID;
            parameters[9].Value = model.IsEnd;
            parameters[10].Value = model.IsVerify;

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
        public void Update(Hownet.Model.DayWorking model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DayWorking set ");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("Num=@Num,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("IsVerify=@IsVerify");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.FillMan;
            parameters[3].Value = model.VerifyMan;
            parameters[4].Value = model.VerifyDate;
            parameters[5].Value = model.UpData;
            parameters[6].Value = model.Num;
            parameters[7].Value = model.Remark;
            parameters[8].Value = model.FillDate;
            parameters[9].Value = model.EmployeeID;
            parameters[10].Value = model.IsEnd;
            parameters[11].Value = model.IsVerify;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DayWorking ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.DayWorking GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DateTime,FillMan,VerifyMan,VerifyDate,UpData,Num,Remark,FillDate,EmployeeID,IsEnd,IsVerify from DayWorking ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.DayWorking model = new Hownet.Model.DayWorking();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
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
            strSql.Append("select 1 as A,ID,DateTime,FillMan,VerifyMan,VerifyDate,UpData,Num,Remark,FillDate,EmployeeID,IsEnd,IsVerify ");
            strSql.Append(" FROM DayWorking ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by ID");
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
            strSql.Append(" ID,DateTime,FillMan,VerifyMan,VerifyDate,UpData,Num,Remark,FillDate,EmployeeID,IsEnd,IsVerify ");
            strSql.Append(" FROM DayWorking ");
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
            strSql.Append("Select ID from DayWorking order by ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 取得新编号
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public int NewNum(DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            strSql.Append("Select max(Num) as exp1 from DayWorking where (datetime >@dt1) and (datetime<@dt2) ");
            SqlParameter[] sp = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sp) != null)
            {
                return int.Parse(DbHelperSQL.GetSingle(strSql.ToString(), sp).ToString()) + 1;
            }
            else
            {
                return 1;
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
			parameters[0].Value = "DayWorking";
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

