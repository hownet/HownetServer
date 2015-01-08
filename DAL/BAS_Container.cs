using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:BAS_Container
	/// </summary>
	public partial class BAS_Container
	{
		public BAS_Container()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "BAS_Container"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BAS_Container");
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
		public int Add(Hownet.Model.BAS_Container model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BAS_Container(");
			strSql.Append("ContName,Volume,Weight,Dimension,IsValid,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@ContName,@Volume,@Weight,@Dimension,@IsValid,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ContName", SqlDbType.VarChar,50),
					new SqlParameter("@Volume", SqlDbType.Float,8),
					new SqlParameter("@Weight", SqlDbType.Float,8),
					new SqlParameter("@Dimension", SqlDbType.VarChar,50),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
			parameters[0].Value = model.ContName;
			parameters[1].Value = model.Volume;
			parameters[2].Value = model.Weight;
			parameters[3].Value = model.Dimension;
			parameters[4].Value = model.IsValid;
			parameters[5].Value = model.IsEnd;

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
		public bool Update(Hownet.Model.BAS_Container model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BAS_Container set ");
			strSql.Append("ContName=@ContName,");
			strSql.Append("Volume=@Volume,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("Dimension=@Dimension,");
			strSql.Append("IsValid=@IsValid,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ContName", SqlDbType.VarChar,50),
					new SqlParameter("@Volume", SqlDbType.Float,8),
					new SqlParameter("@Weight", SqlDbType.Float,8),
					new SqlParameter("@Dimension", SqlDbType.VarChar,50),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.ContName;
			parameters[1].Value = model.Volume;
			parameters[2].Value = model.Weight;
			parameters[3].Value = model.Dimension;
			parameters[4].Value = model.IsValid;
			parameters[5].Value = model.IsEnd;
			parameters[6].Value = model.ID;

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
			strSql.Append("delete from BAS_Container ");
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
			strSql.Append("delete from BAS_Container ");
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
		public Hownet.Model.BAS_Container GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ContName,Volume,Weight,Dimension,IsValid,ID,IsEnd from BAS_Container ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.BAS_Container model=new Hownet.Model.BAS_Container();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					model.ContName=ds.Tables[0].Rows[0]["ContName"].ToString();
				if(ds.Tables[0].Rows[0]["Volume"]!=null && ds.Tables[0].Rows[0]["Volume"].ToString()!="")
				{
					model.Volume=decimal.Parse(ds.Tables[0].Rows[0]["Volume"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Weight"]!=null && ds.Tables[0].Rows[0]["Weight"].ToString()!="")
				{
					model.Weight=decimal.Parse(ds.Tables[0].Rows[0]["Weight"].ToString());
				}
					model.Dimension=ds.Tables[0].Rows[0]["Dimension"].ToString();
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
			strSql.Append("select  1 as A,ContName,Volume,Weight,Dimension,IsValid,ID,IsEnd ");
			strSql.Append(" FROM BAS_Container ");
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
			strSql.Append(" ContName,Volume,Weight,Dimension,IsValid,ID,IsEnd ");
			strSql.Append(" FROM BAS_Container ");
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
			parameters[0].Value = "BAS_Container";
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

