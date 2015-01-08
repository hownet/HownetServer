using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类NumPrefix。
	/// </summary>
	public class NumPrefix
	{
		public NumPrefix()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "NumPrefix"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NumPrefix");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.NumPrefix model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NumPrefix(");
			strSql.Append("FormName,Prefix,Length,TypeID,FormID,Rules)");
			strSql.Append(" values (");
			strSql.Append("@FormName,@Prefix,@Length,@TypeID,@FormID,@Rules)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@FormName", SqlDbType.NVarChar,50),
					new SqlParameter("@Prefix", SqlDbType.NVarChar,50),
					new SqlParameter("@Length", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@FormID", SqlDbType.Int,4),
					new SqlParameter("@Rules", SqlDbType.Int,4)};
			parameters[0].Value = model.FormName;
			parameters[1].Value = model.Prefix;
			parameters[2].Value = model.Length;
			parameters[3].Value = model.TypeID;
			parameters[4].Value = model.FormID;
			parameters[5].Value = model.Rules;

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
		public void Update(Hownet.Model.NumPrefix model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NumPrefix set ");
			strSql.Append("FormName=@FormName,");
			strSql.Append("Prefix=@Prefix,");
			strSql.Append("Length=@Length,");
			strSql.Append("TypeID=@TypeID,");
			strSql.Append("FormID=@FormID,");
			strSql.Append("Rules=@Rules");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@FormName", SqlDbType.NVarChar,50),
					new SqlParameter("@Prefix", SqlDbType.NVarChar,50),
					new SqlParameter("@Length", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@FormID", SqlDbType.Int,4),
					new SqlParameter("@Rules", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.FormName;
			parameters[2].Value = model.Prefix;
			parameters[3].Value = model.Length;
			parameters[4].Value = model.TypeID;
			parameters[5].Value = model.FormID;
			parameters[6].Value = model.Rules;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NumPrefix ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.NumPrefix GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,FormName,Prefix,Length,TypeID,FormID,Rules from NumPrefix ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.NumPrefix model=new Hownet.Model.NumPrefix();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.FormName=ds.Tables[0].Rows[0]["FormName"].ToString();
				model.Prefix=ds.Tables[0].Rows[0]["Prefix"].ToString();
				if(ds.Tables[0].Rows[0]["Length"].ToString()!="")
				{
					model.Length=int.Parse(ds.Tables[0].Rows[0]["Length"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FormID"].ToString()!="")
				{
					model.FormID=int.Parse(ds.Tables[0].Rows[0]["FormID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Rules"].ToString()!="")
				{
					model.Rules=int.Parse(ds.Tables[0].Rows[0]["Rules"].ToString());
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
			strSql.Append("select 1 as A,ID,FormName,Prefix,Length,TypeID,FormID,Rules ");
			strSql.Append(" FROM NumPrefix ");
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
			strSql.Append(" ID,FormName,Prefix,Length,TypeID,FormID,Rules ");
			strSql.Append(" FROM NumPrefix ");
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
			parameters[0].Value = "NumPrefix";
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

