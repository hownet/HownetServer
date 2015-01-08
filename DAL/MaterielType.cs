using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类MaterielType。
	/// </summary>
	public class MaterielType
	{
		public MaterielType()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "MaterielType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MaterielType");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.MaterielType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MaterielType(");
			strSql.Append("ParentID,Name,Sn,IsEnd,IsUse,Remark,AttributeID)");
			strSql.Append(" values (");
			strSql.Append("@ParentID,@Name,@Sn,@IsEnd,@IsUse,@Remark,@AttributeID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@AttributeID", SqlDbType.Int,4)};
			parameters[0].Value = model.ParentID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Sn;
			parameters[3].Value = model.IsEnd;
			parameters[4].Value = model.IsUse;
			parameters[5].Value = model.Remark;
			parameters[6].Value = model.AttributeID;

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
		public void Update(Hownet.Model.MaterielType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MaterielType set ");
			strSql.Append("ParentID=@ParentID,");
			strSql.Append("Name=@Name,");
			strSql.Append("Sn=@Sn,");
			strSql.Append("IsEnd=@IsEnd,");
			strSql.Append("IsUse=@IsUse,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("AttributeID=@AttributeID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,50),
					new SqlParameter("@AttributeID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.ParentID;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Sn;
			parameters[4].Value = model.IsEnd;
			parameters[5].Value = model.IsUse;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.AttributeID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from MaterielType ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.MaterielType GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,ParentID,Name,Sn,IsEnd,IsUse,Remark,AttributeID from MaterielType ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.MaterielType model=new Hownet.Model.MaterielType();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
				}
				model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				model.Sn=ds.Tables[0].Rows[0]["Sn"].ToString();
				if(ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					model.IsEnd=int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsUse"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsUse"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsUse"].ToString().ToLower()=="true"))
					{
						model.IsUse=true;
					}
					else
					{
						model.IsUse=false;
					}
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["AttributeID"].ToString()!="")
				{
					model.AttributeID=int.Parse(ds.Tables[0].Rows[0]["AttributeID"].ToString());
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
			strSql.Append("select 1 as A,ID,ParentID,Name,Sn,IsEnd,IsUse,Remark,AttributeID ");
			strSql.Append(" FROM MaterielType ");
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
			strSql.Append(" ID,ParentID,Name,Sn,IsEnd,IsUse,Remark,AttributeID ");
			strSql.Append(" FROM MaterielType ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetTree()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID, ParentID, Name,AttributeID FROM      MaterielType WHERE   (AttributeID > 1) UNION ALL ");
            strSql.Append(" SELECT   Materiel.ID * - 1 AS ID, MaterielType_1.ID AS ParentID, Materiel.Name,Materiel.AttributeID FROM      Materiel INNER JOIN ");
             strSql.Append(" MaterielType AS MaterielType_1 ON Materiel.TypeID = MaterielType_1.ID WHERE   (Materiel.AttributeID > 1)");
             return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetFinishedTree()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID, ParentID, Name,AttributeID FROM      MaterielType WHERE   (AttributeID = 4) UNION ALL ");
            strSql.Append(" SELECT   Materiel.ID * - 1 AS ID, MaterielType_1.ID AS ParentID, Materiel.Name,Materiel.AttributeID FROM      Materiel INNER JOIN ");
            strSql.Append(" MaterielType AS MaterielType_1 ON Materiel.TypeID = MaterielType_1.ID WHERE   (Materiel.AttributeID = 4)");
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
			parameters[0].Value = "MaterielType";
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

