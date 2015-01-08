using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类CardReaderList。
	/// </summary>
	public class CardReaderList
	{
		public CardReaderList()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CardReaderList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CardReaderList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.CardReaderList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CardReaderList(");
			strSql.Append("NID,Location,Remark,TypeID)");
			strSql.Append(" values (");
			strSql.Append("@NID,@Location,@Remark,@TypeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@NID", SqlDbType.Int,4),
					new SqlParameter("@Location", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@TypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.NID;
			parameters[1].Value = model.Location;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.TypeID;

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
		public void Update(Hownet.Model.CardReaderList model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CardReaderList set ");
			strSql.Append("NID=@NID,");
			strSql.Append("Location=@Location,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("TypeID=@TypeID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@NID", SqlDbType.Int,4),
					new SqlParameter("@Location", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@TypeID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.NID;
			parameters[2].Value = model.Location;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.TypeID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CardReaderList ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.CardReaderList GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,NID,Location,Remark,TypeID from CardReaderList ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.CardReaderList model=new Hownet.Model.CardReaderList();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NID"].ToString()!="")
				{
					model.NID=int.Parse(ds.Tables[0].Rows[0]["NID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Location"].ToString()!="")
				{
					model.Location=int.Parse(ds.Tables[0].Rows[0]["Location"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["TypeID"].ToString()!="")
				{
					model.TypeID=int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
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
			strSql.Append("select 1 as A,ID,NID,Location,Remark,TypeID ");
            strSql.Append(" ,(Select name from Deparment where (id=CardReaderList.Location)) as DeparmentName");
			strSql.Append(" FROM CardReaderList ");
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
			strSql.Append(" ID,NID,Location,Remark,TypeID ");
			strSql.Append(" FROM CardReaderList ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 删除门禁机下的员工权限
        /// </summary>
        public void DeleteInfo(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM AccessList WHERE   (AccessID = @AccessID)");
            SqlParameter[] sps = {new SqlParameter("@AccessID",ID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
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
			parameters[0].Value = "CardReaderList";
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

