using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:Mesg
	/// </summary>
	public partial class Mesg
	{
		public Mesg()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Mesg"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Mesg");
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
		public int Add(Hownet.Model.Mesg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Mesg(");
			strSql.Append("FillManID,FillMan,FillDate,LastDate,Title,TextContent,IsEnd,Remark)");
			strSql.Append(" values (");
			strSql.Append("@FillManID,@FillMan,@FillDate,@LastDate,@Title,@TextContent,@IsEnd,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FillManID", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.NVarChar,50),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Title", SqlDbType.NVarChar,4000),
					new SqlParameter("@TextContent", SqlDbType.Text),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.FillManID;
			parameters[1].Value = model.FillMan;
			parameters[2].Value = model.FillDate;
			parameters[3].Value = model.LastDate;
			parameters[4].Value = model.Title;
			parameters[5].Value = model.TextContent;
			parameters[6].Value = model.IsEnd;
			parameters[7].Value = model.Remark;

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
		public bool Update(Hownet.Model.Mesg model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Mesg set ");
			strSql.Append("FillManID=@FillManID,");
			strSql.Append("FillMan=@FillMan,");
			strSql.Append("FillDate=@FillDate,");
			strSql.Append("LastDate=@LastDate,");
			strSql.Append("Title=@Title,");
			strSql.Append("TextContent=@TextContent,");
			strSql.Append("IsEnd=@IsEnd,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FillManID", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.NVarChar,50),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Title", SqlDbType.NVarChar,4000),
					new SqlParameter("@TextContent", SqlDbType.Text),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.FillManID;
			parameters[1].Value = model.FillMan;
			parameters[2].Value = model.FillDate;
			parameters[3].Value = model.LastDate;
			parameters[4].Value = model.Title;
			parameters[5].Value = model.TextContent;
			parameters[6].Value = model.IsEnd;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.ID;

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
			strSql.Append("delete from Mesg ");
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
			strSql.Append("delete from Mesg ");
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
		public Hownet.Model.Mesg GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FillManID,FillMan,FillDate,LastDate,Title,TextContent,IsEnd,Remark from Mesg ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.Mesg model=new Hownet.Model.Mesg();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FillManID"]!=null && ds.Tables[0].Rows[0]["FillManID"].ToString()!="")
				{
					model.FillManID=int.Parse(ds.Tables[0].Rows[0]["FillManID"].ToString());
				}
					model.FillMan=ds.Tables[0].Rows[0]["FillMan"].ToString();
				if(ds.Tables[0].Rows[0]["FillDate"]!=null && ds.Tables[0].Rows[0]["FillDate"].ToString()!="")
				{
					model.FillDate=DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LastDate"]!=null && ds.Tables[0].Rows[0]["LastDate"].ToString()!="")
				{
					model.LastDate=DateTime.Parse(ds.Tables[0].Rows[0]["LastDate"].ToString());
				}
					model.Title=ds.Tables[0].Rows[0]["Title"].ToString();
					model.TextContent=ds.Tables[0].Rows[0]["TextContent"].ToString();
				if(ds.Tables[0].Rows[0]["IsEnd"]!=null && ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					model.IsEnd=int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
				}
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
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
			strSql.Append("select  1 as A,ID,FillManID,FillMan,FillDate,LastDate,Title,TextContent,IsEnd,Remark ");
			strSql.Append(" FROM Mesg ");
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
			strSql.Append(" ID,FillManID,FillMan,FillDate,LastDate,Title,TextContent,IsEnd,Remark ");
			strSql.Append(" FROM Mesg ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetMesgList(DateTime dt1, DateTime dt2, int FillManID, int ToID, int IsEnd)
        {
            StringBuilder ssss = new StringBuilder();
            ssss.Append(" SELECT   1 AS A, Mesg.ID, Mesg.FillManID, Mesg.FillMan, Mesg.FillDate, Mesg.LastDate, Mesg.Title, Mesg.IsEnd, Mesg.Remark, ");
            ssss.Append(" SUBSTRING(Mesg.TextContent, 0, 20) + '...' AS TextContent FROM      Mesg  ");
            string strSql = " Where (Mesg.FillDate>'" + dt1 + "') And (Mesg.FillDate<'" + dt2 + "')";
            if (FillManID > 0)
                strSql += " And (Mesg.FillManID=" + FillManID + ")";
            if (IsEnd > 0)
                strSql += " And (Mesg.IsEnd=" + IsEnd + ")";
            if (ToID > 0)
                strSql += " And (MesgInfo.ToID=" + ToID + ")";
            if (ToID == 0)
            {
                return DbHelperSQL.Query(ssss.ToString()+ strSql);
            }
            else
            {
                ssss.Append(" INNER JOIN                 MesgInfo ON Mesg.ID = MesgInfo.MainID ");
                ssss.Append(strSql);
                ssss.Append(" GROUP BY Mesg.ID, Mesg.FillManID, Mesg.FillMan, Mesg.FillDate, Mesg.LastDate, Mesg.Title, Mesg.IsEnd, Mesg.Remark, ");
                ssss.Append(" SUBSTRING(Mesg.TextContent, 0, 20)");
                return DbHelperSQL.Query(ssss.ToString());
            }
        }
        public int GetNotComplete(int ToID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(MesgInfo.ID) AS Expr1 FROM      Mesg INNER JOIN MesgInfo ON Mesg.ID = MesgInfo.MainID ");
            strSql.Append(" WHERE   (MesgInfo.IsComplete = 0) AND (Mesg.IsEnd = 1) ");
            if (ToID > 0)
                strSql.Append(" AND (MesgInfo.ToID = " + ToID + ")");
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
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
			parameters[0].Value = "Mesg";
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

