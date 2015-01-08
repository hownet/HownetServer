using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类CustomerManagement。
	/// </summary>
	public class CustomerManagement
	{
		public CustomerManagement()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CustomerManagement"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CustomerManagement");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.CustomerManagement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CustomerManagement(");
			strSql.Append("CompanyID,DataTime,Remark,Question,Answer)");
			strSql.Append(" values (");
			strSql.Append("@CompanyID,@DataTime,@Remark,@Question,@Answer)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Question", SqlDbType.NVarChar,4000),
					new SqlParameter("@Answer", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.CompanyID;
			parameters[1].Value = model.DataTime;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.Question;
			parameters[4].Value = model.Answer;

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
		public void Update(Hownet.Model.CustomerManagement model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CustomerManagement set ");
			strSql.Append("CompanyID=@CompanyID,");
			strSql.Append("DataTime=@DataTime,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("Question=@Question,");
			strSql.Append("Answer=@Answer");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DataTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@Question", SqlDbType.NVarChar,4000),
					new SqlParameter("@Answer", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.CompanyID;
			parameters[2].Value = model.DataTime;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.Question;
			parameters[5].Value = model.Answer;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CustomerManagement ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.CustomerManagement GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,CompanyID,DataTime,Remark,Question,Answer from CustomerManagement ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.CustomerManagement model=new Hownet.Model.CustomerManagement();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DataTime"].ToString()!="")
				{
					model.DataTime=DateTime.Parse(ds.Tables[0].Rows[0]["DataTime"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				model.Question=ds.Tables[0].Rows[0]["Question"].ToString();
				model.Answer=ds.Tables[0].Rows[0]["Answer"].ToString();
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
			strSql.Append("select 1 as A,ID,CompanyID,DataTime,Remark,Question,Answer ");
			strSql.Append(" FROM CustomerManagement ");
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
			strSql.Append(" ID,CompanyID,DataTime,Remark,Question,Answer ");
			strSql.Append(" FROM CustomerManagement ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from CustomerManagement order by ID ");
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
			parameters[0].Value = "CustomerManagement";
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

