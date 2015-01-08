using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类SizeBow。
	/// </summary>
	public class SizeBow
	{
		public SizeBow()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SizeBow"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SizeBow");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.SizeBow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SizeBow(");
			strSql.Append("SizeID,BowID,CottonID,TaskID,Sash,OpenSash,PlasticBone,Remark)");
			strSql.Append(" values (");
			strSql.Append("@SizeID,@BowID,@CottonID,@TaskID,@Sash,@OpenSash,@PlasticBone,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BowID", SqlDbType.Int,4),
					new SqlParameter("@CottonID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@Sash", SqlDbType.Int,4),
					new SqlParameter("@OpenSash", SqlDbType.Int,4),
					new SqlParameter("@PlasticBone", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.SizeID;
			parameters[1].Value = model.BowID;
			parameters[2].Value = model.CottonID;
			parameters[3].Value = model.TaskID;
			parameters[4].Value = model.Sash;
			parameters[5].Value = model.OpenSash;
			parameters[6].Value = model.PlasticBone;
			parameters[7].Value = model.Remark;

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
		public void Update(Hownet.Model.SizeBow model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SizeBow set ");
			strSql.Append("SizeID=@SizeID,");
			strSql.Append("BowID=@BowID,");
			strSql.Append("CottonID=@CottonID,");
			strSql.Append("TaskID=@TaskID,");
			strSql.Append("Sash=@Sash,");
			strSql.Append("OpenSash=@OpenSash,");
			strSql.Append("PlasticBone=@PlasticBone,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BowID", SqlDbType.Int,4),
					new SqlParameter("@CottonID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@Sash", SqlDbType.Int,4),
					new SqlParameter("@OpenSash", SqlDbType.Int,4),
					new SqlParameter("@PlasticBone", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.SizeID;
			parameters[2].Value = model.BowID;
			parameters[3].Value = model.CottonID;
			parameters[4].Value = model.TaskID;
			parameters[5].Value = model.Sash;
			parameters[6].Value = model.OpenSash;
			parameters[7].Value = model.PlasticBone;
			parameters[8].Value = model.Remark;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SizeBow ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.SizeBow GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,SizeID,BowID,CottonID,TaskID,Sash,OpenSash,PlasticBone,Remark from SizeBow ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.SizeBow model=new Hownet.Model.SizeBow();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SizeID"].ToString()!="")
				{
					model.SizeID=int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BowID"].ToString()!="")
				{
					model.BowID=int.Parse(ds.Tables[0].Rows[0]["BowID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CottonID"].ToString()!="")
				{
					model.CottonID=int.Parse(ds.Tables[0].Rows[0]["CottonID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TaskID"].ToString()!="")
				{
					model.TaskID=int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Sash"].ToString()!="")
				{
					model.Sash=int.Parse(ds.Tables[0].Rows[0]["Sash"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OpenSash"].ToString()!="")
				{
					model.OpenSash=int.Parse(ds.Tables[0].Rows[0]["OpenSash"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PlasticBone"].ToString()!="")
				{
					model.PlasticBone=int.Parse(ds.Tables[0].Rows[0]["PlasticBone"].ToString());
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
			strSql.Append("select 1 as A,ID,SizeID,BowID,CottonID,TaskID,Sash,OpenSash,PlasticBone,Remark ");
			strSql.Append(" FROM SizeBow ");
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
			strSql.Append(" ID,SizeID,BowID,CottonID,TaskID,Sash,OpenSash,PlasticBone,Remark ");
			strSql.Append(" FROM SizeBow ");
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
			parameters[0].Value = "SizeBow";
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

