using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类PermissionsJobs。
	/// </summary>
	public class PermissionsJobs
	{
		public PermissionsJobs()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "PermissionsJobs"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PermissionsJobs");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.PermissionsJobs model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PermissionsJobs(");
			strSql.Append("ItemsID,PermissionsPropertyID,JobsID)");
			strSql.Append(" values (");
			strSql.Append("@ItemsID,@PermissionsPropertyID,@JobsID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ItemsID", SqlDbType.Int,4),
					new SqlParameter("@PermissionsPropertyID", SqlDbType.Int,4),
					new SqlParameter("@JobsID", SqlDbType.Int,4)};
			parameters[0].Value = model.ItemsID;
			parameters[1].Value = model.PermissionsPropertyID;
			parameters[2].Value = model.JobsID;

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
		public void Update(Hownet.Model.PermissionsJobs model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PermissionsJobs set ");
			strSql.Append("ItemsID=@ItemsID,");
			strSql.Append("PermissionsPropertyID=@PermissionsPropertyID,");
			strSql.Append("JobsID=@JobsID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ItemsID", SqlDbType.Int,4),
					new SqlParameter("@PermissionsPropertyID", SqlDbType.Int,4),
					new SqlParameter("@JobsID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ItemsID;
			parameters[2].Value = model.PermissionsPropertyID;
			parameters[3].Value = model.JobsID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from PermissionsJobs ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.PermissionsJobs GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ItemsID,PermissionsPropertyID,JobsID from PermissionsJobs ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.PermissionsJobs model=new Hownet.Model.PermissionsJobs();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ItemsID"].ToString()!="")
				{
					model.ItemsID=int.Parse(ds.Tables[0].Rows[0]["ItemsID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PermissionsPropertyID"].ToString()!="")
				{
					model.PermissionsPropertyID=int.Parse(ds.Tables[0].Rows[0]["PermissionsPropertyID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JobsID"].ToString()!="")
				{
					model.JobsID=int.Parse(ds.Tables[0].Rows[0]["JobsID"].ToString());
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
			strSql.Append("select 1 as A,ID,ItemsID,PermissionsPropertyID,JobsID ");
			strSql.Append(" FROM PermissionsJobs ");
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
			strSql.Append(" ID,ItemsID,PermissionsPropertyID,JobsID ");
			strSql.Append(" FROM PermissionsJobs ");
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
			parameters[0].Value = "PermissionsJobs";
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

