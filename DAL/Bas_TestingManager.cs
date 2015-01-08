using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:Bas_TestingManager
	/// </summary>
	public partial class Bas_TestingManager
	{
		public Bas_TestingManager()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AutoInc", "Bas_TestingManager"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AutoInc)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Bas_TestingManager");
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
		public int Add(Hownet.Model.Bas_TestingManager model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Bas_TestingManager(");
			strSql.Append("TestingNo,ProCnName,ProEnName,QualityReq_C,QualityReq_E,StandardReq_C,StandardReq_E,Remark,IsDef,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@TestingNo,@ProCnName,@ProEnName,@QualityReq_C,@QualityReq_E,@StandardReq_C,@StandardReq_E,@Remark,@IsDef,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@TestingNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProCnName", SqlDbType.VarChar,200),
					new SqlParameter("@ProEnName", SqlDbType.VarChar,200),
					new SqlParameter("@QualityReq_C", SqlDbType.Text),
					new SqlParameter("@QualityReq_E", SqlDbType.Text),
					new SqlParameter("@StandardReq_C", SqlDbType.Text),
					new SqlParameter("@StandardReq_E", SqlDbType.Text),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
			parameters[0].Value = model.TestingNo;
			parameters[1].Value = model.ProCnName;
			parameters[2].Value = model.ProEnName;
			parameters[3].Value = model.QualityReq_C;
			parameters[4].Value = model.QualityReq_E;
			parameters[5].Value = model.StandardReq_C;
			parameters[6].Value = model.StandardReq_E;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.IsDef;
			parameters[9].Value = model.IsEnd;

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
		public bool Update(Hownet.Model.Bas_TestingManager model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Bas_TestingManager set ");
			strSql.Append("TestingNo=@TestingNo,");
			strSql.Append("ProCnName=@ProCnName,");
			strSql.Append("ProEnName=@ProEnName,");
			strSql.Append("QualityReq_C=@QualityReq_C,");
			strSql.Append("QualityReq_E=@QualityReq_E,");
			strSql.Append("StandardReq_C=@StandardReq_C,");
			strSql.Append("StandardReq_E=@StandardReq_E,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsDef=@IsDef,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@TestingNo", SqlDbType.VarChar,50),
					new SqlParameter("@ProCnName", SqlDbType.VarChar,200),
					new SqlParameter("@ProEnName", SqlDbType.VarChar,200),
					new SqlParameter("@QualityReq_C", SqlDbType.Text),
					new SqlParameter("@QualityReq_E", SqlDbType.Text),
					new SqlParameter("@StandardReq_C", SqlDbType.Text),
					new SqlParameter("@StandardReq_E", SqlDbType.Text),
					new SqlParameter("@Remark", SqlDbType.VarChar,1000),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@AutoInc", SqlDbType.Int,4)};
			parameters[0].Value = model.TestingNo;
			parameters[1].Value = model.ProCnName;
			parameters[2].Value = model.ProEnName;
			parameters[3].Value = model.QualityReq_C;
			parameters[4].Value = model.QualityReq_E;
			parameters[5].Value = model.StandardReq_C;
			parameters[6].Value = model.StandardReq_E;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.IsDef;
			parameters[9].Value = model.IsEnd;
			parameters[10].Value = model.AutoInc;

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
			strSql.Append("delete from Bas_TestingManager ");
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
			strSql.Append("delete from Bas_TestingManager ");
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
		public Hownet.Model.Bas_TestingManager GetModel(int AutoInc)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 TestingNo,ProCnName,ProEnName,QualityReq_C,QualityReq_E,StandardReq_C,StandardReq_E,Remark,AutoInc,IsDef,IsEnd from Bas_TestingManager ");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.Int,4)
};
			parameters[0].Value = AutoInc;

			Hownet.Model.Bas_TestingManager model=new Hownet.Model.Bas_TestingManager();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					model.TestingNo=ds.Tables[0].Rows[0]["TestingNo"].ToString();
					model.ProCnName=ds.Tables[0].Rows[0]["ProCnName"].ToString();
					model.ProEnName=ds.Tables[0].Rows[0]["ProEnName"].ToString();
					model.QualityReq_C=ds.Tables[0].Rows[0]["QualityReq_C"].ToString();
					model.QualityReq_E=ds.Tables[0].Rows[0]["QualityReq_E"].ToString();
					model.StandardReq_C=ds.Tables[0].Rows[0]["StandardReq_C"].ToString();
					model.StandardReq_E=ds.Tables[0].Rows[0]["StandardReq_E"].ToString();
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["AutoInc"]!=null && ds.Tables[0].Rows[0]["AutoInc"].ToString()!="")
				{
					model.AutoInc=int.Parse(ds.Tables[0].Rows[0]["AutoInc"].ToString());
				}
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
			strSql.Append("select  1 as A,TestingNo,ProCnName,ProEnName,QualityReq_C,QualityReq_E,StandardReq_C,StandardReq_E,Remark,AutoInc,IsDef,IsEnd ");
			strSql.Append(" FROM Bas_TestingManager ");
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
			strSql.Append(" TestingNo,ProCnName,ProEnName,QualityReq_C,QualityReq_E,StandardReq_C,StandardReq_E,Remark,AutoInc,IsDef,IsEnd ");
			strSql.Append(" FROM Bas_TestingManager ");
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
			parameters[0].Value = "Bas_TestingManager";
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

