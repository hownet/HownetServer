using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:BAS_FlowUpStatus
	/// </summary>
	public partial class BAS_FlowUpStatus
	{
		public BAS_FlowUpStatus()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("AutoInc", "BAS_FlowUpStatus"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int AutoInc)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BAS_FlowUpStatus");
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
		public int Add(Hownet.Model.BAS_FlowUpStatus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BAS_FlowUpStatus(");
			strSql.Append("Code,CnName,EnName,SuccessRate,IsValid,Remark,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@Code,@CnName,@EnName,@SuccessRate,@IsValid,@Remark,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,50),
					new SqlParameter("@CnName", SqlDbType.VarChar,50),
					new SqlParameter("@EnName", SqlDbType.VarChar,50),
					new SqlParameter("@SuccessRate", SqlDbType.Float,8),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
			parameters[0].Value = model.Code;
			parameters[1].Value = model.CnName;
			parameters[2].Value = model.EnName;
			parameters[3].Value = model.SuccessRate;
			parameters[4].Value = model.IsValid;
			parameters[5].Value = model.Remark;
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
		public bool Update(Hownet.Model.BAS_FlowUpStatus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BAS_FlowUpStatus set ");
			strSql.Append("Code=@Code,");
			strSql.Append("CnName=@CnName,");
			strSql.Append("EnName=@EnName,");
			strSql.Append("SuccessRate=@SuccessRate,");
			strSql.Append("IsValid=@IsValid,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@Code", SqlDbType.VarChar,50),
					new SqlParameter("@CnName", SqlDbType.VarChar,50),
					new SqlParameter("@EnName", SqlDbType.VarChar,50),
					new SqlParameter("@SuccessRate", SqlDbType.Float,8),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@AutoInc", SqlDbType.Int,4)};
			parameters[0].Value = model.Code;
			parameters[1].Value = model.CnName;
			parameters[2].Value = model.EnName;
			parameters[3].Value = model.SuccessRate;
			parameters[4].Value = model.IsValid;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.IsEnd;
			parameters[7].Value = model.AutoInc;

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
			strSql.Append("delete from BAS_FlowUpStatus ");
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
			strSql.Append("delete from BAS_FlowUpStatus ");
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
		public Hownet.Model.BAS_FlowUpStatus GetModel(int AutoInc)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Code,CnName,EnName,SuccessRate,IsValid,Remark,AutoInc,IsEnd from BAS_FlowUpStatus ");
			strSql.Append(" where AutoInc=@AutoInc");
			SqlParameter[] parameters = {
					new SqlParameter("@AutoInc", SqlDbType.Int,4)
};
			parameters[0].Value = AutoInc;

			Hownet.Model.BAS_FlowUpStatus model=new Hownet.Model.BAS_FlowUpStatus();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					model.Code=ds.Tables[0].Rows[0]["Code"].ToString();
					model.CnName=ds.Tables[0].Rows[0]["CnName"].ToString();
					model.EnName=ds.Tables[0].Rows[0]["EnName"].ToString();
				if(ds.Tables[0].Rows[0]["SuccessRate"]!=null && ds.Tables[0].Rows[0]["SuccessRate"].ToString()!="")
				{
					model.SuccessRate=decimal.Parse(ds.Tables[0].Rows[0]["SuccessRate"].ToString());
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
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
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
			strSql.Append("select  1 as A,Code,CnName,EnName,SuccessRate,IsValid,Remark,AutoInc,IsEnd ");
			strSql.Append(" FROM BAS_FlowUpStatus ");
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
			strSql.Append(" Code,CnName,EnName,SuccessRate,IsValid,Remark,AutoInc,IsEnd ");
			strSql.Append(" FROM BAS_FlowUpStatus ");
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
			parameters[0].Value = "BAS_FlowUpStatus";
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

