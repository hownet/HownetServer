using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类SampleMateriel。
	/// </summary>
	public class SampleMateriel
	{
		public SampleMateriel()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SampleMateriel"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SampleMateriel");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.SampleMateriel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SampleMateriel(");
			strSql.Append("MainID,Fabric1,Fabric2,Fabric3,Fabric4,Fabric5,Materiel1,Materiel2,Materiel3,Materiel4,Materiel5,Materiel6,Materiel7,Company1,LH1,Plant1,Company2,LH2,Plant2,SumAmount)");
			strSql.Append(" values (");
			strSql.Append("@MainID,@Fabric1,@Fabric2,@Fabric3,@Fabric4,@Fabric5,@Materiel1,@Materiel2,@Materiel3,@Materiel4,@Materiel5,@Materiel6,@Materiel7,@Company1,@LH1,@Plant1,@Company2,@LH2,@Plant2,@SumAmount)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Fabric1", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric2", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric3", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric4", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric5", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel1", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel2", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel3", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel4", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel5", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel6", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel7", SqlDbType.NVarChar,200),
					new SqlParameter("@Company1", SqlDbType.NVarChar,50),
					new SqlParameter("@LH1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plant1", SqlDbType.NVarChar,50),
					new SqlParameter("@Company2", SqlDbType.NVarChar,50),
					new SqlParameter("@LH2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plant2", SqlDbType.NVarChar,50),
					new SqlParameter("@SumAmount", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.MainID;
			parameters[1].Value = model.Fabric1;
			parameters[2].Value = model.Fabric2;
			parameters[3].Value = model.Fabric3;
			parameters[4].Value = model.Fabric4;
			parameters[5].Value = model.Fabric5;
			parameters[6].Value = model.Materiel1;
			parameters[7].Value = model.Materiel2;
			parameters[8].Value = model.Materiel3;
			parameters[9].Value = model.Materiel4;
			parameters[10].Value = model.Materiel5;
			parameters[11].Value = model.Materiel6;
			parameters[12].Value = model.Materiel7;
			parameters[13].Value = model.Company1;
			parameters[14].Value = model.LH1;
			parameters[15].Value = model.Plant1;
			parameters[16].Value = model.Company2;
			parameters[17].Value = model.LH2;
			parameters[18].Value = model.Plant2;
			parameters[19].Value = model.SumAmount;

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
		public void Update(Hownet.Model.SampleMateriel model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SampleMateriel set ");
			strSql.Append("MainID=@MainID,");
			strSql.Append("Fabric1=@Fabric1,");
			strSql.Append("Fabric2=@Fabric2,");
			strSql.Append("Fabric3=@Fabric3,");
			strSql.Append("Fabric4=@Fabric4,");
			strSql.Append("Fabric5=@Fabric5,");
			strSql.Append("Materiel1=@Materiel1,");
			strSql.Append("Materiel2=@Materiel2,");
			strSql.Append("Materiel3=@Materiel3,");
			strSql.Append("Materiel4=@Materiel4,");
			strSql.Append("Materiel5=@Materiel5,");
			strSql.Append("Materiel6=@Materiel6,");
			strSql.Append("Materiel7=@Materiel7,");
			strSql.Append("Company1=@Company1,");
			strSql.Append("LH1=@LH1,");
			strSql.Append("Plant1=@Plant1,");
			strSql.Append("Company2=@Company2,");
			strSql.Append("LH2=@LH2,");
			strSql.Append("Plant2=@Plant2,");
			strSql.Append("SumAmount=@SumAmount");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Fabric1", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric2", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric3", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric4", SqlDbType.NVarChar,200),
					new SqlParameter("@Fabric5", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel1", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel2", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel3", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel4", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel5", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel6", SqlDbType.NVarChar,200),
					new SqlParameter("@Materiel7", SqlDbType.NVarChar,200),
					new SqlParameter("@Company1", SqlDbType.NVarChar,50),
					new SqlParameter("@LH1", SqlDbType.NVarChar,50),
					new SqlParameter("@Plant1", SqlDbType.NVarChar,50),
					new SqlParameter("@Company2", SqlDbType.NVarChar,50),
					new SqlParameter("@LH2", SqlDbType.NVarChar,50),
					new SqlParameter("@Plant2", SqlDbType.NVarChar,50),
					new SqlParameter("@SumAmount", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MainID;
			parameters[2].Value = model.Fabric1;
			parameters[3].Value = model.Fabric2;
			parameters[4].Value = model.Fabric3;
			parameters[5].Value = model.Fabric4;
			parameters[6].Value = model.Fabric5;
			parameters[7].Value = model.Materiel1;
			parameters[8].Value = model.Materiel2;
			parameters[9].Value = model.Materiel3;
			parameters[10].Value = model.Materiel4;
			parameters[11].Value = model.Materiel5;
			parameters[12].Value = model.Materiel6;
			parameters[13].Value = model.Materiel7;
			parameters[14].Value = model.Company1;
			parameters[15].Value = model.LH1;
			parameters[16].Value = model.Plant1;
			parameters[17].Value = model.Company2;
			parameters[18].Value = model.LH2;
			parameters[19].Value = model.Plant2;
			parameters[20].Value = model.SumAmount;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SampleMateriel ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.SampleMateriel GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MainID,Fabric1,Fabric2,Fabric3,Fabric4,Fabric5,Materiel1,Materiel2,Materiel3,Materiel4,Materiel5,Materiel6,Materiel7,Company1,LH1,Plant1,Company2,LH2,Plant2,SumAmount from SampleMateriel ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.SampleMateriel model=new Hownet.Model.SampleMateriel();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				model.Fabric1=ds.Tables[0].Rows[0]["Fabric1"].ToString();
				model.Fabric2=ds.Tables[0].Rows[0]["Fabric2"].ToString();
				model.Fabric3=ds.Tables[0].Rows[0]["Fabric3"].ToString();
				model.Fabric4=ds.Tables[0].Rows[0]["Fabric4"].ToString();
				model.Fabric5=ds.Tables[0].Rows[0]["Fabric5"].ToString();
				model.Materiel1=ds.Tables[0].Rows[0]["Materiel1"].ToString();
				model.Materiel2=ds.Tables[0].Rows[0]["Materiel2"].ToString();
				model.Materiel3=ds.Tables[0].Rows[0]["Materiel3"].ToString();
				model.Materiel4=ds.Tables[0].Rows[0]["Materiel4"].ToString();
				model.Materiel5=ds.Tables[0].Rows[0]["Materiel5"].ToString();
				model.Materiel6=ds.Tables[0].Rows[0]["Materiel6"].ToString();
				model.Materiel7=ds.Tables[0].Rows[0]["Materiel7"].ToString();
				model.Company1=ds.Tables[0].Rows[0]["Company1"].ToString();
				model.LH1=ds.Tables[0].Rows[0]["LH1"].ToString();
				model.Plant1=ds.Tables[0].Rows[0]["Plant1"].ToString();
				model.Company2=ds.Tables[0].Rows[0]["Company2"].ToString();
				model.LH2=ds.Tables[0].Rows[0]["LH2"].ToString();
				model.Plant2=ds.Tables[0].Rows[0]["Plant2"].ToString();
				model.SumAmount=ds.Tables[0].Rows[0]["SumAmount"].ToString();
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
			strSql.Append("select 1 as A,ID,MainID,Fabric1,Fabric2,Fabric3,Fabric4,Fabric5,Materiel1,Materiel2,Materiel3,Materiel4,Materiel5,Materiel6,Materiel7,Company1,LH1,Plant1,Company2,LH2,Plant2,SumAmount ");
			strSql.Append(" FROM SampleMateriel ");
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
			strSql.Append(" ID,MainID,Fabric1,Fabric2,Fabric3,Fabric4,Fabric5,Materiel1,Materiel2,Materiel3,Materiel4,Materiel5,Materiel6,Materiel7,Company1,LH1,Plant1,Company2,LH2,Plant2,SumAmount ");
			strSql.Append(" FROM SampleMateriel ");
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
			parameters[0].Value = "SampleMateriel";
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

