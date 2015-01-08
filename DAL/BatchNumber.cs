using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类BatchNumber。
	/// </summary>
	public class BatchNumber
	{
		public BatchNumber()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "BatchNumber"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BatchNumber");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.BatchNumber model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BatchNumber(");
			strSql.Append("Number,Remark,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,CompanyID)");
			strSql.Append(" values (");
			strSql.Append("@Number,@Remark,@MaterielID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@BrandID,@MeasureID,@CompanyID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
			parameters[0].Value = model.Number;
			parameters[1].Value = model.Remark;
			parameters[2].Value = model.MaterielID;
			parameters[3].Value = model.ColorID;
			parameters[4].Value = model.ColorOneID;
			parameters[5].Value = model.ColorTwoID;
			parameters[6].Value = model.SizeID;
			parameters[7].Value = model.BrandID;
			parameters[8].Value = model.MeasureID;
			parameters[9].Value = model.CompanyID;

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
		public void Update(Hownet.Model.BatchNumber model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BatchNumber set ");
			strSql.Append("Number=@Number,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("MaterielID=@MaterielID,");
			strSql.Append("ColorID=@ColorID,");
			strSql.Append("ColorOneID=@ColorOneID,");
			strSql.Append("ColorTwoID=@ColorTwoID,");
			strSql.Append("SizeID=@SizeID,");
			strSql.Append("BrandID=@BrandID,");
			strSql.Append("MeasureID=@MeasureID,");
			strSql.Append("CompanyID=@CompanyID");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Number", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Number;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.MaterielID;
			parameters[4].Value = model.ColorID;
			parameters[5].Value = model.ColorOneID;
			parameters[6].Value = model.ColorTwoID;
			parameters[7].Value = model.SizeID;
			parameters[8].Value = model.BrandID;
			parameters[9].Value = model.MeasureID;
			parameters[10].Value = model.CompanyID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from BatchNumber ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.BatchNumber GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Number,Remark,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,CompanyID from BatchNumber ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.BatchNumber model=new Hownet.Model.BatchNumber();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Number"].ToString()!="")
				{
					model.Number=int.Parse(ds.Tables[0].Rows[0]["Number"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["MaterielID"].ToString()!="")
				{
					model.MaterielID=int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ColorID"].ToString()!="")
				{
					model.ColorID=int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ColorOneID"].ToString()!="")
				{
					model.ColorOneID=int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ColorTwoID"].ToString()!="")
				{
					model.ColorTwoID=int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SizeID"].ToString()!="")
				{
					model.SizeID=int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BrandID"].ToString()!="")
				{
					model.BrandID=int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MeasureID"].ToString()!="")
				{
					model.MeasureID=int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
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
			strSql.Append("select 1 as A,ID,Number,Remark,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,CompanyID ");
			strSql.Append(" FROM BatchNumber ");
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
			strSql.Append(" ID,Number,Remark,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,CompanyID ");
			strSql.Append(" FROM BatchNumber ");
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
			parameters[0].Value = "BatchNumber";
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

