using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类ChinaZone。
	/// </summary>
	public class ChinaZone
	{
		public ChinaZone()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ChinaZone"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ChinaZone");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZoneID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.ChinaZone model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ChinaZone(");
			strSql.Append("ParentID,OrderNum,InfoNum,Name)");
			strSql.Append(" values (");
			strSql.Append("@ParentID,@OrderNum,@InfoNum,@ZoneName)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ParentID", SqlDbType.NVarChar,6),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@InfoNum", SqlDbType.NVarChar,6),
					new SqlParameter("@ZoneName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ParentID;
			parameters[1].Value = model.OrderNum;
			parameters[2].Value = model.InfoNum;
			parameters[3].Value = model.Name;

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
		public void Update(Hownet.Model.ChinaZone model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ChinaZone set ");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("OrderNum=@OrderNum,");
			strSql.Append("InfoNum=@InfoNum,");
			strSql.Append("Name=@ZoneName");
			strSql.Append(" where ID=@ZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZoneID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.NVarChar,6),
					new SqlParameter("@OrderNum", SqlDbType.Int,4),
					new SqlParameter("@InfoNum", SqlDbType.NVarChar,6),
					new SqlParameter("@ZoneName", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ParentID;
			parameters[2].Value = model.OrderNum;
			parameters[3].Value = model.InfoNum;
			parameters[4].Value = model.Name;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ZoneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ChinaZone ");
			strSql.Append(" where ID=@ZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZoneID", SqlDbType.Int,4)};
			parameters[0].Value = ZoneID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.ChinaZone GetModel(int ZoneID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ParentID,OrderNum,InfoNum,Name from ChinaZone ");
			strSql.Append(" where ID=@ZoneID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ZoneID", SqlDbType.Int,4)};
			parameters[0].Value = ZoneID;

			Hownet.Model.ChinaZone model=new Hownet.Model.ChinaZone();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ZoneID"].ToString());
				}
				model.ParentID=ds.Tables[0].Rows[0]["ParentID"].ToString();
				if(ds.Tables[0].Rows[0]["OrderNum"].ToString()!="")
				{
					model.OrderNum=int.Parse(ds.Tables[0].Rows[0]["OrderNum"].ToString());
				}
				model.InfoNum=ds.Tables[0].Rows[0]["InfoNum"].ToString();
				model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
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
			strSql.Append("select 1 as A,ID,ParentID,OrderNum,InfoNum,Name ");
			strSql.Append(" FROM ChinaZone ");
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
			strSql.Append(" ID,ParentID,OrderNum,InfoNum,Name ");
			strSql.Append(" FROM ChinaZone ");
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
			parameters[0].Value = "ChinaZone";
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

