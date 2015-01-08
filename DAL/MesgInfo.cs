using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:MesgInfo
	/// </summary>
	public partial class MesgInfo
	{
		public MesgInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "MesgInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MesgInfo");
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
		public int Add(Hownet.Model.MesgInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MesgInfo(");
			strSql.Append("MainID,ToID,ToMan,Remark,IsRead,IsEnd,IsComplete,LastDateTime,CompleteDateTime)");
			strSql.Append(" values (");
			strSql.Append("@MainID,@ToID,@ToMan,@Remark,@IsRead,@IsEnd,@IsComplete,@LastDateTime,@CompleteDateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@ToID", SqlDbType.Int,4),
					new SqlParameter("@ToMan", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@IsRead", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@IsComplete", SqlDbType.Bit,1),
					new SqlParameter("@LastDateTime", SqlDbType.DateTime),
					new SqlParameter("@CompleteDateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.MainID;
			parameters[1].Value = model.ToID;
			parameters[2].Value = model.ToMan;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.IsRead;
			parameters[5].Value = model.IsEnd;
			parameters[6].Value = model.IsComplete;
			parameters[7].Value = model.LastDateTime;
			parameters[8].Value = model.CompleteDateTime;

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
		public bool Update(Hownet.Model.MesgInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MesgInfo set ");
			strSql.Append("MainID=@MainID,");
			strSql.Append("ToID=@ToID,");
			strSql.Append("ToMan=@ToMan,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsRead=@IsRead,");
			strSql.Append("IsEnd=@IsEnd,");
			strSql.Append("IsComplete=@IsComplete,");
			strSql.Append("LastDateTime=@LastDateTime,");
			strSql.Append("CompleteDateTime=@CompleteDateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@ToID", SqlDbType.Int,4),
					new SqlParameter("@ToMan", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@IsRead", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@IsComplete", SqlDbType.Bit,1),
					new SqlParameter("@LastDateTime", SqlDbType.DateTime),
					new SqlParameter("@CompleteDateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.MainID;
			parameters[1].Value = model.ToID;
			parameters[2].Value = model.ToMan;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.IsRead;
			parameters[5].Value = model.IsEnd;
			parameters[6].Value = model.IsComplete;
			parameters[7].Value = model.LastDateTime;
			parameters[8].Value = model.CompleteDateTime;
			parameters[9].Value = model.ID;

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
			strSql.Append("delete from MesgInfo ");
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
			strSql.Append("delete from MesgInfo ");
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
		public Hownet.Model.MesgInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MainID,ToID,ToMan,Remark,IsRead,IsEnd,IsComplete,LastDateTime,CompleteDateTime from MesgInfo ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.MesgInfo model=new Hownet.Model.MesgInfo();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MainID"]!=null && ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ToID"]!=null && ds.Tables[0].Rows[0]["ToID"].ToString()!="")
				{
					model.ToID=int.Parse(ds.Tables[0].Rows[0]["ToID"].ToString());
				}
					model.ToMan=ds.Tables[0].Rows[0]["ToMan"].ToString();
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["IsRead"]!=null && ds.Tables[0].Rows[0]["IsRead"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsRead"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsRead"].ToString().ToLower()=="true"))
					{
						model.IsRead=true;
					}
					else
					{
						model.IsRead=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsEnd"]!=null && ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsEnd"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsEnd"].ToString().ToLower()=="true"))
					{
						model.IsEnd=true;
					}
					else
					{
						model.IsEnd=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsComplete"]!=null && ds.Tables[0].Rows[0]["IsComplete"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsComplete"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsComplete"].ToString().ToLower()=="true"))
					{
						model.IsComplete=true;
					}
					else
					{
						model.IsComplete=false;
					}
				}
				if(ds.Tables[0].Rows[0]["LastDateTime"]!=null && ds.Tables[0].Rows[0]["LastDateTime"].ToString()!="")
				{
					model.LastDateTime=DateTime.Parse(ds.Tables[0].Rows[0]["LastDateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CompleteDateTime"]!=null && ds.Tables[0].Rows[0]["CompleteDateTime"].ToString()!="")
				{
					model.CompleteDateTime=DateTime.Parse(ds.Tables[0].Rows[0]["CompleteDateTime"].ToString());
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
			strSql.Append("select  1 as A,ID,MainID,ToID,ToMan,Remark,IsRead,IsEnd,IsComplete,LastDateTime,CompleteDateTime ");
			strSql.Append(" FROM MesgInfo ");
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
			strSql.Append(" ID,MainID,ToID,ToMan,Remark,IsRead,IsEnd,IsComplete,LastDateTime,CompleteDateTime ");
			strSql.Append(" FROM MesgInfo ");
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
			parameters[0].Value = "MesgInfo";
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

