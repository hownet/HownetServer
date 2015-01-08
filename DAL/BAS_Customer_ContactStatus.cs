using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:BAS_Customer_ContactStatus
	/// </summary>
	public partial class BAS_Customer_ContactStatus
	{
		public BAS_Customer_ContactStatus()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AutoInc", "BAS_Customer_ContactStatus"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AutoInc)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BAS_Customer_ContactStatus");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.Int,4)
};
			parameters[0].Value = AutoInc;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.BAS_Customer_ContactStatus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BAS_Customer_ContactStatus(");
			strSql.Append("EnName,CnName,Remark,IsDef,IsValid,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@EnName,@CnName,@Remark,@IsDef,@IsValid,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EnName", SqlDbType.VarChar,50),
					new SqlParameter("@CnName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
			parameters[0].Value = model.EnName;
			parameters[1].Value = model.CnName;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.IsDef;
			parameters[4].Value = model.IsValid;
			parameters[5].Value = model.IsEnd;

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
		public bool Update(Hownet.Model.BAS_Customer_ContactStatus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BAS_Customer_ContactStatus set ");
			strSql.Append("EnName=@EnName,");
			strSql.Append("CnName=@CnName,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsDef=@IsDef,");
			strSql.Append("IsValid=@IsValid,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@EnName", SqlDbType.VarChar,50),
					new SqlParameter("@CnName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@AutoInc", SqlDbType.Int,4)};
			parameters[0].Value = model.EnName;
			parameters[1].Value = model.CnName;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.IsDef;
			parameters[4].Value = model.IsValid;
			parameters[5].Value = model.IsEnd;
			parameters[6].Value = model.AutoInc;

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
		public bool Delete(int AutoInc)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BAS_Customer_ContactStatus ");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.Int,4)
};
			parameters[0].Value = AutoInc;

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
		public bool DeleteList(string AutoInclist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BAS_Customer_ContactStatus ");
			strSql.Append(" where AutoInc in ("+AutoInclist + ")  ");
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
		public Hownet.Model.BAS_Customer_ContactStatus GetModel(int AutoInc)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EnName,CnName,Remark,IsDef,IsValid,AutoInc,IsEnd from BAS_Customer_ContactStatus ");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.Int,4)
};
			parameters[0].Value = AutoInc;

			Hownet.Model.BAS_Customer_ContactStatus model=new Hownet.Model.BAS_Customer_ContactStatus();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					model.EnName=ds.Tables[0].Rows[0]["EnName"].ToString();
					model.CnName=ds.Tables[0].Rows[0]["CnName"].ToString();
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["IsDef"]!=null && ds.Tables[0].Rows[0]["IsDef"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsDef"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsDef"].ToString().ToLower()=="true"))
					{
						model.IsDef=true;
					}
					else
					{
						model.IsDef=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsValid"]!=null && ds.Tables[0].Rows[0]["IsValid"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsValid"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsValid"].ToString().ToLower()=="true"))
					{
						model.IsValid=true;
					}
					else
					{
						model.IsValid=false;
					}
				}
				if(ds.Tables[0].Rows[0]["AutoInc"]!=null && ds.Tables[0].Rows[0]["AutoInc"].ToString()!="")
				{
					model.AutoInc=int.Parse(ds.Tables[0].Rows[0]["AutoInc"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsEnd"]!=null && ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					model.IsEnd=int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
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
			strSql.Append("select  1 as A,EnName,CnName,Remark,IsDef,IsValid,AutoInc,IsEnd ");
			strSql.Append(" FROM BAS_Customer_ContactStatus ");
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
			strSql.Append(" EnName,CnName,Remark,IsDef,IsValid,AutoInc,IsEnd ");
			strSql.Append(" FROM BAS_Customer_ContactStatus ");
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
			parameters[0].Value = "BAS_Customer_ContactStatus";
			parameters[1].Value = "AutoInc";
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

