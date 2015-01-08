using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Items。
	/// </summary>
	public class Items
	{
		public Items()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Items"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Items");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.Items model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Items(");
			strSql.Append("Text,ParentID,FormName,IsModule,Level,Orders,IsBar,Parameter)");
			strSql.Append(" values (");
			strSql.Append("@Text,@ParentID,@FormName,@IsModule,@Level,@Orders,@IsBar,@Parameter)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Text", SqlDbType.NVarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@FormName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsModule", SqlDbType.TinyInt,1),
					new SqlParameter("@Level", SqlDbType.Int,4),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@IsBar", SqlDbType.TinyInt,1),
					new SqlParameter("@Parameter", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Text;
			parameters[1].Value = model.ParentID;
			parameters[2].Value = model.FormName;
			parameters[3].Value = model.IsModule;
			parameters[4].Value = model.Level;
			parameters[5].Value = model.Orders;
			parameters[6].Value = model.IsBar;
			parameters[7].Value = model.Parameter;

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
		public void Update(Hownet.Model.Items model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Items set ");
			strSql.Append("Text=@Text,");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("FormName=@FormName,");
			strSql.Append("IsModule=@IsModule,");
			strSql.Append("Level=@Level,");
			strSql.Append("Orders=@Orders,");
			strSql.Append("IsBar=@IsBar,");
			strSql.Append("Parameter=@Parameter");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Text", SqlDbType.NVarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@FormName", SqlDbType.NVarChar,50),
					new SqlParameter("@IsModule", SqlDbType.TinyInt,1),
					new SqlParameter("@Level", SqlDbType.Int,4),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@IsBar", SqlDbType.TinyInt,1),
					new SqlParameter("@Parameter", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Text;
			parameters[2].Value = model.ParentID;
			parameters[3].Value = model.FormName;
			parameters[4].Value = model.IsModule;
			parameters[5].Value = model.Level;
			parameters[6].Value = model.Orders;
			parameters[7].Value = model.IsBar;
			parameters[8].Value = model.Parameter;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Items ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.Items GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Text,ParentID,FormName,IsModule,Level,Orders,IsBar,Parameter from Items ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.Items model=new Hownet.Model.Items();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.Text=ds.Tables[0].Rows[0]["Text"].ToString();
				if(ds.Tables[0].Rows[0]["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
				}
				model.FormName=ds.Tables[0].Rows[0]["FormName"].ToString();
				if(ds.Tables[0].Rows[0]["IsModule"].ToString()!="")
				{
					model.IsModule=int.Parse(ds.Tables[0].Rows[0]["IsModule"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Level"].ToString()!="")
				{
					model.Level=int.Parse(ds.Tables[0].Rows[0]["Level"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Orders"].ToString()!="")
				{
					model.Orders=int.Parse(ds.Tables[0].Rows[0]["Orders"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsBar"].ToString()!="")
				{
					model.IsBar=int.Parse(ds.Tables[0].Rows[0]["IsBar"].ToString());
				}
				model.Parameter=ds.Tables[0].Rows[0]["Parameter"].ToString();
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
			strSql.Append("select 1 as A,ID,Text,ParentID,FormName,IsModule,Level,Orders,IsBar,Parameter ");
			strSql.Append(" FROM Items ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
          //  strSql.Append(" ORDER BY Orders ");
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
			strSql.Append(" ID,Text,ParentID,FormName,IsModule,Level,Orders,IsBar,Parameter ");
			strSql.Append(" FROM Items ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetPUList(int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   PermissionsUser.ItemsID AS ID, PermissionsUser.PermissionsPropertyID, Items.ParentID, Items.FormName, ");
            strSql.Append(" Items.Text, Items.Orders FROM PermissionsUser INNER JOIN Items ON PermissionsUser.ItemsID = Items.ID ");
            strSql.Append(" WHERE   (Items.ParentID > - 1) AND (PermissionsUser.UserID = @UserID)");
            SqlParameter[] sps = {new SqlParameter("@UserID",UserID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int DeleteNoText()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM Items WHERE     (FormName = N'') AND (ParentID > 0)");
           return DbHelperSQL.ExecuteSql(strSql.ToString());
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
			parameters[0].Value = "Items";
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

