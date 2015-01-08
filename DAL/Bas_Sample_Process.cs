using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:Bas_Sample_Process
	/// </summary>
	public partial class Bas_Sample_Process
	{
		public Bas_Sample_Process()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Bas_Sample_Process"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Bas_Sample_Process");
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
		public int Add(Hownet.Model.Bas_Sample_Process model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Bas_Sample_Process(");
			strSql.Append("ProcessType,RuleCnName,RuleEnName,Rule_E,Rule_C,IsDef,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@ProcessType,@RuleCnName,@RuleEnName,@Rule_E,@Rule_C,@IsDef,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ProcessType", SqlDbType.VarChar,50),
					new SqlParameter("@RuleCnName", SqlDbType.VarChar,50),
					new SqlParameter("@RuleEnName", SqlDbType.VarChar,50),
					new SqlParameter("@Rule_E", SqlDbType.VarChar,1000),
					new SqlParameter("@Rule_C", SqlDbType.VarChar,1000),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
			parameters[0].Value = model.ProcessType;
			parameters[1].Value = model.RuleCnName;
			parameters[2].Value = model.RuleEnName;
			parameters[3].Value = model.Rule_E;
			parameters[4].Value = model.Rule_C;
			parameters[5].Value = model.IsDef;
			parameters[6].Value = model.IsEnd;

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
		public bool Update(Hownet.Model.Bas_Sample_Process model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Bas_Sample_Process set ");
			strSql.Append("ProcessType=@ProcessType,");
			strSql.Append("RuleCnName=@RuleCnName,");
			strSql.Append("RuleEnName=@RuleEnName,");
			strSql.Append("Rule_E=@Rule_E,");
			strSql.Append("Rule_C=@Rule_C,");
			strSql.Append("IsDef=@IsDef,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ProcessType", SqlDbType.VarChar,50),
					new SqlParameter("@RuleCnName", SqlDbType.VarChar,50),
					new SqlParameter("@RuleEnName", SqlDbType.VarChar,50),
					new SqlParameter("@Rule_E", SqlDbType.VarChar,1000),
					new SqlParameter("@Rule_C", SqlDbType.VarChar,1000),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ProcessType;
			parameters[1].Value = model.RuleCnName;
			parameters[2].Value = model.RuleEnName;
			parameters[3].Value = model.Rule_E;
			parameters[4].Value = model.Rule_C;
			parameters[5].Value = model.IsDef;
			parameters[6].Value = model.IsEnd;
			parameters[7].Value = model.ID;

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
			strSql.Append("delete from Bas_Sample_Process ");
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
			strSql.Append("delete from Bas_Sample_Process ");
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
		public Hownet.Model.Bas_Sample_Process GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ProcessType,RuleCnName,RuleEnName,Rule_E,Rule_C,IsDef,ID,IsEnd from Bas_Sample_Process ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.Bas_Sample_Process model=new Hownet.Model.Bas_Sample_Process();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					model.ProcessType=ds.Tables[0].Rows[0]["ProcessType"].ToString();
					model.RuleCnName=ds.Tables[0].Rows[0]["RuleCnName"].ToString();
					model.RuleEnName=ds.Tables[0].Rows[0]["RuleEnName"].ToString();
					model.Rule_E=ds.Tables[0].Rows[0]["Rule_E"].ToString();
					model.Rule_C=ds.Tables[0].Rows[0]["Rule_C"].ToString();
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
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
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
			strSql.Append("select  1 as A,ProcessType,RuleCnName,RuleEnName,Rule_E,Rule_C,IsDef,ID,IsEnd ");
			strSql.Append(" FROM Bas_Sample_Process ");
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
			strSql.Append(" ProcessType,RuleCnName,RuleEnName,Rule_E,Rule_C,IsDef,ID,IsEnd ");
			strSql.Append(" FROM Bas_Sample_Process ");
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
			parameters[0].Value = "Bas_Sample_Process";
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

