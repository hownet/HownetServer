using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:KQ_UserInfoList
	/// </summary>
	public partial class KQ_UserInfoList
	{
		public KQ_UserInfoList()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "KQ_UserInfoList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from KQ_UserInfoList");
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
		public int Add(Hownet.Model.KQ_UserInfoList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KQ_UserInfoList(");
			strSql.Append("UserID,EmpID,Name,FingerIndex,FingerTemplate,Privilege,Password,enabled,No,CompanySN)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@EmpID,@Name,@FingerIndex,@FingerTemplate,@Privilege,@Password,@enabled,@No,@CompanySN)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@EmpID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FingerIndex", SqlDbType.Int,4),
					new SqlParameter("@FingerTemplate", SqlDbType.NVarChar,4000),
					new SqlParameter("@Privilege", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.NVarChar,50),
					new SqlParameter("@enabled", SqlDbType.Bit,1),
					new SqlParameter("@No", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanySN", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.EmpID;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.FingerIndex;
			parameters[4].Value = model.FingerTemplate;
			parameters[5].Value = model.Privilege;
			parameters[6].Value = model.Password;
			parameters[7].Value = model.enabled;
			parameters[8].Value = model.No;
			parameters[9].Value = model.CompanySN;

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
		public bool Update(Hownet.Model.KQ_UserInfoList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KQ_UserInfoList set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("EmpID=@EmpID,");
			strSql.Append("Name=@Name,");
			strSql.Append("FingerIndex=@FingerIndex,");
			strSql.Append("FingerTemplate=@FingerTemplate,");
			strSql.Append("Privilege=@Privilege,");
			strSql.Append("Password=@Password,");
			strSql.Append("enabled=@enabled,");
			strSql.Append("No=@No,");
			strSql.Append("CompanySN=@CompanySN");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@EmpID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@FingerIndex", SqlDbType.Int,4),
					new SqlParameter("@FingerTemplate", SqlDbType.NVarChar,4000),
					new SqlParameter("@Privilege", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.NVarChar,50),
					new SqlParameter("@enabled", SqlDbType.Bit,1),
					new SqlParameter("@No", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanySN", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.EmpID;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.FingerIndex;
			parameters[4].Value = model.FingerTemplate;
			parameters[5].Value = model.Privilege;
			parameters[6].Value = model.Password;
			parameters[7].Value = model.enabled;
			parameters[8].Value = model.No;
			parameters[9].Value = model.CompanySN;
			parameters[10].Value = model.ID;

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
			strSql.Append("delete from KQ_UserInfoList ");
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
			strSql.Append("delete from KQ_UserInfoList ");
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
		public Hownet.Model.KQ_UserInfoList GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserID,EmpID,Name,FingerIndex,FingerTemplate,Privilege,Password,enabled,No,CompanySN from KQ_UserInfoList ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.KQ_UserInfoList model=new Hownet.Model.KQ_UserInfoList();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EmpID"]!=null && ds.Tables[0].Rows[0]["EmpID"].ToString()!="")
				{
					model.EmpID=int.Parse(ds.Tables[0].Rows[0]["EmpID"].ToString());
				}
					model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				if(ds.Tables[0].Rows[0]["FingerIndex"]!=null && ds.Tables[0].Rows[0]["FingerIndex"].ToString()!="")
				{
					model.FingerIndex=int.Parse(ds.Tables[0].Rows[0]["FingerIndex"].ToString());
				}
					model.FingerTemplate=ds.Tables[0].Rows[0]["FingerTemplate"].ToString();
					model.Privilege=ds.Tables[0].Rows[0]["Privilege"].ToString();
					model.Password=ds.Tables[0].Rows[0]["Password"].ToString();
				if(ds.Tables[0].Rows[0]["enabled"]!=null && ds.Tables[0].Rows[0]["enabled"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["enabled"].ToString()=="1")||(ds.Tables[0].Rows[0]["enabled"].ToString().ToLower()=="true"))
					{
						model.enabled=true;
					}
					else
					{
						model.enabled=false;
					}
				}
					model.No=ds.Tables[0].Rows[0]["No"].ToString();
					model.CompanySN=ds.Tables[0].Rows[0]["CompanySN"].ToString();
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
			strSql.Append("select  1 as A,ID,UserID,EmpID,Name,FingerIndex,FingerTemplate,Privilege,Password,enabled,No,CompanySN ");
			strSql.Append(" FROM KQ_UserInfoList ");
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
			strSql.Append(" ID,UserID,EmpID,Name,FingerIndex,FingerTemplate,Privilege,Password,enabled,No,CompanySN ");
			strSql.Append(" FROM KQ_UserInfoList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetUserList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   UserID, EmpID FROM      KQ_UserInfoList GROUP BY UserID, EmpID");
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
			parameters[0].Value = "KQ_UserInfoList";
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

