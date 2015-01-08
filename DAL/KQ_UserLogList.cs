using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:KQ_UserLogList
	/// </summary>
	public partial class KQ_UserLogList
	{
		public KQ_UserLogList()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "KQ_UserLogList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from KQ_UserLogList");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.KQ_UserLogList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KQ_UserLogList(");
			strSql.Append("UserID,Nian,Yue,Ri,Shi,Fen,Miao,CompanySN,OldID,DateOne,TimeOne,DateTime)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@Nian,@Yue,@Ri,@Shi,@Fen,@Miao,@CompanySN,@OldID,@DateOne,@TimeOne,@DateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Nian", SqlDbType.Int,4),
					new SqlParameter("@Yue", SqlDbType.Int,4),
					new SqlParameter("@Ri", SqlDbType.Int,4),
					new SqlParameter("@Shi", SqlDbType.Int,4),
					new SqlParameter("@Fen", SqlDbType.Int,4),
					new SqlParameter("@Miao", SqlDbType.Int,4),
					new SqlParameter("@CompanySN", SqlDbType.NVarChar,50),
					new SqlParameter("@OldID", SqlDbType.Int,4),
					new SqlParameter("@DateOne", SqlDbType.NVarChar,50),
					new SqlParameter("@TimeOne", SqlDbType.NVarChar,50),
					new SqlParameter("@DateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.Nian;
			parameters[2].Value = model.Yue;
			parameters[3].Value = model.Ri;
			parameters[4].Value = model.Shi;
			parameters[5].Value = model.Fen;
			parameters[6].Value = model.Miao;
			parameters[7].Value = model.CompanySN;
			parameters[8].Value = model.OldID;
			parameters[9].Value = model.DateOne;
			parameters[10].Value = model.TimeOne;
			parameters[11].Value = model.DateTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Hownet.Model.KQ_UserLogList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KQ_UserLogList set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("Nian=@Nian,");
			strSql.Append("Yue=@Yue,");
			strSql.Append("Ri=@Ri,");
			strSql.Append("Shi=@Shi,");
			strSql.Append("Fen=@Fen,");
			strSql.Append("Miao=@Miao,");
			strSql.Append("CompanySN=@CompanySN,");
			strSql.Append("OldID=@OldID,");
			strSql.Append("DateOne=@DateOne,");
			strSql.Append("TimeOne=@TimeOne,");
			strSql.Append("DateTime=@DateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@Nian", SqlDbType.Int,4),
					new SqlParameter("@Yue", SqlDbType.Int,4),
					new SqlParameter("@Ri", SqlDbType.Int,4),
					new SqlParameter("@Shi", SqlDbType.Int,4),
					new SqlParameter("@Fen", SqlDbType.Int,4),
					new SqlParameter("@Miao", SqlDbType.Int,4),
					new SqlParameter("@CompanySN", SqlDbType.NVarChar,50),
					new SqlParameter("@OldID", SqlDbType.Int,4),
					new SqlParameter("@DateOne", SqlDbType.NVarChar,50),
					new SqlParameter("@TimeOne", SqlDbType.NVarChar,50),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.Nian;
			parameters[2].Value = model.Yue;
			parameters[3].Value = model.Ri;
			parameters[4].Value = model.Shi;
			parameters[5].Value = model.Fen;
			parameters[6].Value = model.Miao;
			parameters[7].Value = model.CompanySN;
			parameters[8].Value = model.OldID;
			parameters[9].Value = model.DateOne;
			parameters[10].Value = model.TimeOne;
			parameters[11].Value = model.DateTime;
			parameters[12].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KQ_UserLogList ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KQ_UserLogList ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Hownet.Model.KQ_UserLogList GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserID,Nian,Yue,Ri,Shi,Fen,Miao,CompanySN,OldID,DateOne,TimeOne,DateTime from KQ_UserLogList ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.KQ_UserLogList model=new Hownet.Model.KQ_UserLogList();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Nian"]!=null && ds.Tables[0].Rows[0]["Nian"].ToString()!="")
				{
					model.Nian=int.Parse(ds.Tables[0].Rows[0]["Nian"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Yue"]!=null && ds.Tables[0].Rows[0]["Yue"].ToString()!="")
				{
					model.Yue=int.Parse(ds.Tables[0].Rows[0]["Yue"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Ri"]!=null && ds.Tables[0].Rows[0]["Ri"].ToString()!="")
				{
					model.Ri=int.Parse(ds.Tables[0].Rows[0]["Ri"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Shi"]!=null && ds.Tables[0].Rows[0]["Shi"].ToString()!="")
				{
					model.Shi=int.Parse(ds.Tables[0].Rows[0]["Shi"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Fen"]!=null && ds.Tables[0].Rows[0]["Fen"].ToString()!="")
				{
					model.Fen=int.Parse(ds.Tables[0].Rows[0]["Fen"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Miao"]!=null && ds.Tables[0].Rows[0]["Miao"].ToString()!="")
				{
					model.Miao=int.Parse(ds.Tables[0].Rows[0]["Miao"].ToString());
				}
					model.CompanySN=ds.Tables[0].Rows[0]["CompanySN"].ToString();
				if(ds.Tables[0].Rows[0]["OldID"]!=null && ds.Tables[0].Rows[0]["OldID"].ToString()!="")
				{
					model.OldID=int.Parse(ds.Tables[0].Rows[0]["OldID"].ToString());
				}
					model.DateOne=ds.Tables[0].Rows[0]["DateOne"].ToString();
					model.TimeOne=ds.Tables[0].Rows[0]["TimeOne"].ToString();
				if(ds.Tables[0].Rows[0]["DateTime"]!=null && ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
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
			strSql.Append("select  1 as A,ID,UserID,Nian,Yue,Ri,Shi,Fen,Miao,CompanySN,OldID,DateOne,TimeOne,DateTime ");
			strSql.Append(" FROM KQ_UserLogList ");
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
			strSql.Append(" ID,UserID,Nian,Yue,Ri,Shi,Fen,Miao,CompanySN,OldID,DateOne,TimeOne,DateTime ");
			strSql.Append(" FROM KQ_UserLogList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetLogsList(int UserID, DateTime dt1, DateTime dt2)
        {
            try
            {
                dt1 = dt1.Date.AddMilliseconds(-1);
                dt2 = dt2.Date.AddDays(1);
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" SELECT   KQ_UserLogList.UserID, KQ_UserLogList.DateTime, KQ_UserInfo.Name FROM      KQ_UserLogList INNER JOIN ");
                strSql.Append(" KQ_UserInfo ON KQ_UserLogList.UserID = KQ_UserInfo.UserID WHERE    (KQ_UserLogList.DateTime > @dt1) AND (KQ_UserLogList.DateTime < @dt2)");
                if (UserID > 0)
                    strSql.Append(" AND (KQ_UserLogList.UserID = @UserID) ");
                SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@UserID", UserID) };
                return DbHelperSQL.Query(strSql.ToString(),sps);
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public DataSet GetLogsUser( DateTime dt1, DateTime dt2)
        {
            dt1 = dt1.Date.AddMilliseconds(-1);
            dt2 = dt2.Date.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   KQ_UserInfo.UserID, KQ_UserInfo.Name FROM      KQ_UserInfo INNER JOIN KQ_UserLogList ON KQ_UserInfo.UserID = KQ_UserLogList.UserID ");
            strSql.Append(" WHERE   (KQ_UserLogList.DateTime > @dt1) AND (KQ_UserLogList.DateTime < @dt2) GROUP BY KQ_UserInfo.UserID, KQ_UserInfo.Name");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
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
			parameters[0].Value = "KQ_UserLogList";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

