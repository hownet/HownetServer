using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:Bas_TestingScheme
	/// </summary>
	public partial class Bas_TestingScheme
	{
		public Bas_TestingScheme()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(long AutoInc)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Bas_TestingScheme");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.BigInt)
};
			parameters[0].Value = AutoInc;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(Hownet.Model.Bas_TestingScheme model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Bas_TestingScheme(");
			strSql.Append("SchemeName,SchemeEnName,SchemeProduct,SchemeContent,Remark,SchemeAutoInc,IsDef,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@SchemeName,@SchemeEnName,@SchemeProduct,@SchemeContent,@Remark,@SchemeAutoInc,@IsDef,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SchemeName", SqlDbType.VarChar,200),
					new SqlParameter("@SchemeEnName", SqlDbType.VarChar,200),
					new SqlParameter("@SchemeProduct", SqlDbType.VarChar,200),
					new SqlParameter("@SchemeContent", SqlDbType.VarChar,1000),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@SchemeAutoInc", SqlDbType.VarChar,500),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
			parameters[0].Value = model.SchemeName;
			parameters[1].Value = model.SchemeEnName;
			parameters[2].Value = model.SchemeProduct;
			parameters[3].Value = model.SchemeContent;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.SchemeAutoInc;
			parameters[6].Value = model.IsDef;
			parameters[7].Value = model.IsEnd;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt64(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Hownet.Model.Bas_TestingScheme model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Bas_TestingScheme set ");
			strSql.Append("SchemeName=@SchemeName,");
			strSql.Append("SchemeEnName=@SchemeEnName,");
			strSql.Append("SchemeProduct=@SchemeProduct,");
			strSql.Append("SchemeContent=@SchemeContent,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("SchemeAutoInc=@SchemeAutoInc,");
			strSql.Append("IsDef=@IsDef,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@SchemeName", SqlDbType.VarChar,200),
					new SqlParameter("@SchemeEnName", SqlDbType.VarChar,200),
					new SqlParameter("@SchemeProduct", SqlDbType.VarChar,200),
					new SqlParameter("@SchemeContent", SqlDbType.VarChar,1000),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@SchemeAutoInc", SqlDbType.VarChar,500),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@AutoInc", SqlDbType.BigInt,8)};
			parameters[0].Value = model.SchemeName;
			parameters[1].Value = model.SchemeEnName;
			parameters[2].Value = model.SchemeProduct;
			parameters[3].Value = model.SchemeContent;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.SchemeAutoInc;
			parameters[6].Value = model.IsDef;
			parameters[7].Value = model.IsEnd;
			parameters[8].Value = model.AutoInc;

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
		public bool Delete(long AutoInc)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Bas_TestingScheme ");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.BigInt)
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
			strSql.Append("delete from Bas_TestingScheme ");
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
		public Hownet.Model.Bas_TestingScheme GetModel(long AutoInc)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SchemeName,SchemeEnName,SchemeProduct,SchemeContent,Remark,AutoInc,SchemeAutoInc,IsDef,IsEnd from Bas_TestingScheme ");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.BigInt)
};
			parameters[0].Value = AutoInc;

			Hownet.Model.Bas_TestingScheme model=new Hownet.Model.Bas_TestingScheme();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					model.SchemeName=ds.Tables[0].Rows[0]["SchemeName"].ToString();
					model.SchemeEnName=ds.Tables[0].Rows[0]["SchemeEnName"].ToString();
					model.SchemeProduct=ds.Tables[0].Rows[0]["SchemeProduct"].ToString();
					model.SchemeContent=ds.Tables[0].Rows[0]["SchemeContent"].ToString();
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["AutoInc"]!=null && ds.Tables[0].Rows[0]["AutoInc"].ToString()!="")
				{
					model.AutoInc=long.Parse(ds.Tables[0].Rows[0]["AutoInc"].ToString());
				}
					model.SchemeAutoInc=ds.Tables[0].Rows[0]["SchemeAutoInc"].ToString();
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
			strSql.Append("select  1 as A,SchemeName,SchemeEnName,SchemeProduct,SchemeContent,Remark,AutoInc,SchemeAutoInc,IsDef,IsEnd ");
			strSql.Append(" FROM Bas_TestingScheme ");
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
			strSql.Append(" SchemeName,SchemeEnName,SchemeProduct,SchemeContent,Remark,AutoInc,SchemeAutoInc,IsDef,IsEnd ");
			strSql.Append(" FROM Bas_TestingScheme ");
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
			parameters[0].Value = "Bas_TestingScheme";
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

