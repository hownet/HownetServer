using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:FixedAssetsOut
	/// </summary>
	public partial class FixedAssetsOut
	{
		public FixedAssetsOut()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "FixedAssetsOut"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FixedAssetsOut");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.FixedAssetsOut model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FixedAssetsOut(");
			strSql.Append("FAID,OutDate,ExpectedBackDate,ActualBackDate,OutDeparmentID,OutUserID,VerifyManID,Remark)");
			strSql.Append(" values (");
			strSql.Append("@FAID,@OutDate,@ExpectedBackDate,@ActualBackDate,@OutDeparmentID,@OutUserID,@VerifyManID,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FAID", SqlDbType.Int,4),
					new SqlParameter("@OutDate", SqlDbType.DateTime),
					new SqlParameter("@ExpectedBackDate", SqlDbType.DateTime),
					new SqlParameter("@ActualBackDate", SqlDbType.DateTime),
					new SqlParameter("@OutDeparmentID", SqlDbType.Int,4),
					new SqlParameter("@OutUserID", SqlDbType.Int,4),
					new SqlParameter("@VerifyManID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.FAID;
			parameters[1].Value = model.OutDate;
			parameters[2].Value = model.ExpectedBackDate;
			parameters[3].Value = model.ActualBackDate;
			parameters[4].Value = model.OutDeparmentID;
			parameters[5].Value = model.OutUserID;
			parameters[6].Value = model.VerifyManID;
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
		public bool Update(Hownet.Model.FixedAssetsOut model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FixedAssetsOut set ");
			strSql.Append("FAID=@FAID,");
			strSql.Append("OutDate=@OutDate,");
			strSql.Append("ExpectedBackDate=@ExpectedBackDate,");
			strSql.Append("ActualBackDate=@ActualBackDate,");
			strSql.Append("OutDeparmentID=@OutDeparmentID,");
			strSql.Append("OutUserID=@OutUserID,");
			strSql.Append("VerifyManID=@VerifyManID,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@FAID", SqlDbType.Int,4),
					new SqlParameter("@OutDate", SqlDbType.DateTime),
					new SqlParameter("@ExpectedBackDate", SqlDbType.DateTime),
					new SqlParameter("@ActualBackDate", SqlDbType.DateTime),
					new SqlParameter("@OutDeparmentID", SqlDbType.Int,4),
					new SqlParameter("@OutUserID", SqlDbType.Int,4),
					new SqlParameter("@VerifyManID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.FAID;
			parameters[1].Value = model.OutDate;
			parameters[2].Value = model.ExpectedBackDate;
			parameters[3].Value = model.ActualBackDate;
			parameters[4].Value = model.OutDeparmentID;
			parameters[5].Value = model.OutUserID;
			parameters[6].Value = model.VerifyManID;
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
			strSql.Append("delete from FixedAssetsOut ");
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
			strSql.Append("delete from FixedAssetsOut ");
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
		public Hownet.Model.FixedAssetsOut GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ID,FAID,OutDate,ExpectedBackDate,ActualBackDate,OutDeparmentID,OutUserID,VerifyManID,Remark from FixedAssetsOut ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.FixedAssetsOut model=new Hownet.Model.FixedAssetsOut();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FAID"].ToString()!="")
				{
					model.FAID=int.Parse(ds.Tables[0].Rows[0]["FAID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OutDate"].ToString()!="")
				{
					model.OutDate=DateTime.Parse(ds.Tables[0].Rows[0]["OutDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ExpectedBackDate"].ToString()!="")
				{
					model.ExpectedBackDate=DateTime.Parse(ds.Tables[0].Rows[0]["ExpectedBackDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ActualBackDate"].ToString()!="")
				{
					model.ActualBackDate=DateTime.Parse(ds.Tables[0].Rows[0]["ActualBackDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OutDeparmentID"].ToString()!="")
				{
					model.OutDeparmentID=int.Parse(ds.Tables[0].Rows[0]["OutDeparmentID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OutUserID"].ToString()!="")
				{
					model.OutUserID=int.Parse(ds.Tables[0].Rows[0]["OutUserID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["VerifyManID"].ToString()!="")
				{
					model.VerifyManID=int.Parse(ds.Tables[0].Rows[0]["VerifyManID"].ToString());
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
			strSql.Append("select 1 as A,ID,FAID,OutDate,ExpectedBackDate,ActualBackDate,OutDeparmentID,OutUserID,VerifyManID,Remark ");
			strSql.Append(" FROM FixedAssetsOut ");
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
			strSql.Append(" ID,FAID,OutDate,ExpectedBackDate,ActualBackDate,OutDeparmentID,OutUserID,VerifyManID,Remark ");
			strSql.Append(" FROM FixedAssetsOut ");
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
			parameters[0].Value = "FixedAssetsOut";
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

