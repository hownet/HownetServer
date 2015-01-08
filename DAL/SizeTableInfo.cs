using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类SizeTableInfo。
	/// </summary>
	public class SizeTableInfo
	{
		public SizeTableInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SizeTableInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SizeTableInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.SizeTableInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SizeTableInfo(");
			strSql.Append("MainID,Orders,Measurement,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12)");
			strSql.Append(" values (");
			strSql.Append("@MainID,@Orders,@Measurement,@Size1,@Size2,@Size3,@Size4,@Size5,@Size6,@Size7,@Size8,@Size9,@Size10,@Size11,@Size12)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Orders", SqlDbType.NVarChar,10),
					new SqlParameter("@Measurement", SqlDbType.Int,4),
					new SqlParameter("@Size1", SqlDbType.NVarChar,50),
					new SqlParameter("@Size2", SqlDbType.NVarChar,50),
					new SqlParameter("@Size3", SqlDbType.NVarChar,50),
					new SqlParameter("@Size4", SqlDbType.NVarChar,50),
					new SqlParameter("@Size5", SqlDbType.NVarChar,50),
					new SqlParameter("@Size6", SqlDbType.NVarChar,50),
					new SqlParameter("@Size7", SqlDbType.NVarChar,50),
					new SqlParameter("@Size8", SqlDbType.NVarChar,50),
					new SqlParameter("@Size9", SqlDbType.NVarChar,50),
					new SqlParameter("@Size10", SqlDbType.NVarChar,50),
					new SqlParameter("@Size11", SqlDbType.NVarChar,50),
					new SqlParameter("@Size12", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.MainID;
			parameters[1].Value = model.Orders;
			parameters[2].Value = model.Measurement;
			parameters[3].Value = model.Size1;
			parameters[4].Value = model.Size2;
			parameters[5].Value = model.Size3;
			parameters[6].Value = model.Size4;
			parameters[7].Value = model.Size5;
			parameters[8].Value = model.Size6;
			parameters[9].Value = model.Size7;
			parameters[10].Value = model.Size8;
			parameters[11].Value = model.Size9;
			parameters[12].Value = model.Size10;
			parameters[13].Value = model.Size11;
			parameters[14].Value = model.Size12;

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
		public void Update(Hownet.Model.SizeTableInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SizeTableInfo set ");
			strSql.Append("MainID=@MainID,");
			strSql.Append("Orders=@Orders,");
			strSql.Append("Measurement=@Measurement,");
			strSql.Append("Size1=@Size1,");
			strSql.Append("Size2=@Size2,");
			strSql.Append("Size3=@Size3,");
			strSql.Append("Size4=@Size4,");
			strSql.Append("Size5=@Size5,");
			strSql.Append("Size6=@Size6,");
			strSql.Append("Size7=@Size7,");
			strSql.Append("Size8=@Size8,");
			strSql.Append("Size9=@Size9,");
			strSql.Append("Size10=@Size10,");
			strSql.Append("Size11=@Size11,");
			strSql.Append("Size12=@Size12");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Orders", SqlDbType.NVarChar,10),
					new SqlParameter("@Measurement", SqlDbType.Int,4),
					new SqlParameter("@Size1", SqlDbType.NVarChar,50),
					new SqlParameter("@Size2", SqlDbType.NVarChar,50),
					new SqlParameter("@Size3", SqlDbType.NVarChar,50),
					new SqlParameter("@Size4", SqlDbType.NVarChar,50),
					new SqlParameter("@Size5", SqlDbType.NVarChar,50),
					new SqlParameter("@Size6", SqlDbType.NVarChar,50),
					new SqlParameter("@Size7", SqlDbType.NVarChar,50),
					new SqlParameter("@Size8", SqlDbType.NVarChar,50),
					new SqlParameter("@Size9", SqlDbType.NVarChar,50),
					new SqlParameter("@Size10", SqlDbType.NVarChar,50),
					new SqlParameter("@Size11", SqlDbType.NVarChar,50),
					new SqlParameter("@Size12", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MainID;
			parameters[2].Value = model.Orders;
			parameters[3].Value = model.Measurement;
			parameters[4].Value = model.Size1;
			parameters[5].Value = model.Size2;
			parameters[6].Value = model.Size3;
			parameters[7].Value = model.Size4;
			parameters[8].Value = model.Size5;
			parameters[9].Value = model.Size6;
			parameters[10].Value = model.Size7;
			parameters[11].Value = model.Size8;
			parameters[12].Value = model.Size9;
			parameters[13].Value = model.Size10;
			parameters[14].Value = model.Size11;
			parameters[15].Value = model.Size12;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SizeTableInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.SizeTableInfo GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MainID,Orders,Measurement,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12 from SizeTableInfo ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.SizeTableInfo model=new Hownet.Model.SizeTableInfo();
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
				model.Orders=ds.Tables[0].Rows[0]["Orders"].ToString();
				if(ds.Tables[0].Rows[0]["Measurement"].ToString()!="")
				{
					model.Measurement=int.Parse(ds.Tables[0].Rows[0]["Measurement"].ToString());
				}
				model.Size1=ds.Tables[0].Rows[0]["Size1"].ToString();
				model.Size2=ds.Tables[0].Rows[0]["Size2"].ToString();
				model.Size3=ds.Tables[0].Rows[0]["Size3"].ToString();
				model.Size4=ds.Tables[0].Rows[0]["Size4"].ToString();
				model.Size5=ds.Tables[0].Rows[0]["Size5"].ToString();
				model.Size6=ds.Tables[0].Rows[0]["Size6"].ToString();
				model.Size7=ds.Tables[0].Rows[0]["Size7"].ToString();
				model.Size8=ds.Tables[0].Rows[0]["Size8"].ToString();
				model.Size9=ds.Tables[0].Rows[0]["Size9"].ToString();
				model.Size10=ds.Tables[0].Rows[0]["Size10"].ToString();
				model.Size11=ds.Tables[0].Rows[0]["Size11"].ToString();
				model.Size12=ds.Tables[0].Rows[0]["Size12"].ToString();
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
			strSql.Append("select 1 as A,ID,MainID,Orders,Measurement,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12 ");
			strSql.Append(" FROM SizeTableInfo ");
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
			strSql.Append(" ID,MainID,Orders,Measurement,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12 ");
			strSql.Append(" FROM SizeTableInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetInfoList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID, MainID, Orders, Measurement, Size1, Size2, Size3, Size4, Size5, Size6, Size7, Size8, Size9, ");
            strSql.Append(" Size10, Size11, Size12, (SELECT   EnName FROM SizePart WHERE   (ID = SizeTableInfo.Measurement)) AS EnName, ");
            strSql.Append(" (SELECT Name FROM SizePart AS SizePart_1 WHERE (ID = SizeTableInfo.Measurement)) AS Name,1 as A FROM SizeTableInfo ");
            strSql.Append(" WHERE   (MainID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
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
			parameters[0].Value = "SizeTableInfo";
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

