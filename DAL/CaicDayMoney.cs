using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类CaicDayMoney。
	/// </summary>
	public class CaicDayMoney
	{
		public CaicDayMoney()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CaicDayMoney"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CaicDayMoney");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.CaicDayMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CaicDayMoney(");
			strSql.Append("DayMoney,NightMoney,LateAtNightMoney,Remark,TXBT)");
			strSql.Append(" values (");
			strSql.Append("@DayMoney,@NightMoney,@LateAtNightMoney,@Remark,@TXBT)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NightMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LateAtNightMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@TXBT", SqlDbType.Decimal,9)};
			parameters[0].Value = model.DayMoney;
			parameters[1].Value = model.NightMoney;
			parameters[2].Value = model.LateAtNightMoney;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.TXBT;

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
		public void Update(Hownet.Model.CaicDayMoney model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CaicDayMoney set ");
			strSql.Append("DayMoney=@DayMoney,");
			strSql.Append("NightMoney=@NightMoney,");
			strSql.Append("LateAtNightMoney=@LateAtNightMoney,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("TXBT=@TXBT");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DayMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NightMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LateAtNightMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@TXBT", SqlDbType.Decimal,9)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.DayMoney;
			parameters[2].Value = model.NightMoney;
			parameters[3].Value = model.LateAtNightMoney;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.TXBT;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from CaicDayMoney ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.CaicDayMoney GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,DayMoney,NightMoney,LateAtNightMoney,Remark,TXBT from CaicDayMoney ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.CaicDayMoney model=new Hownet.Model.CaicDayMoney();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DayMoney"].ToString()!="")
				{
					model.DayMoney=decimal.Parse(ds.Tables[0].Rows[0]["DayMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NightMoney"].ToString()!="")
				{
					model.NightMoney=decimal.Parse(ds.Tables[0].Rows[0]["NightMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LateAtNightMoney"].ToString()!="")
				{
					model.LateAtNightMoney=decimal.Parse(ds.Tables[0].Rows[0]["LateAtNightMoney"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["TXBT"].ToString()!="")
				{
					model.TXBT=decimal.Parse(ds.Tables[0].Rows[0]["TXBT"].ToString());
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
			strSql.Append("select 1 as A,ID,DayMoney,NightMoney,LateAtNightMoney,Remark,TXBT ");
			strSql.Append(" FROM CaicDayMoney ");
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
			strSql.Append(" ID,DayMoney,NightMoney,LateAtNightMoney,Remark,TXBT ");
			strSql.Append(" FROM CaicDayMoney ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetLookupList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   '白班￥' + CAST(CAST(DayMoney AS real) AS varchar) + '，晚班￥' + CAST(CAST(NightMoney AS real) AS varchar) ");
            strSql.Append(" + '，深夜班￥' + CAST(CAST(LateAtNightMoney AS real) AS varchar) + '，通宵补贴￥' + CAST(CAST(TXBT AS real) ");
            strSql.Append(" AS varchar) AS Name, Remark, CAST(DayMoney AS real) AS DayMoney, ID, CAST(NightMoney AS real) AS NightMoney, ");
            strSql.Append(" CAST(LateAtNightMoney AS real) AS LateAtNightMoney, CAST(TXBT AS Real) AS TXBT FROM      CaicDayMoney");
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
			parameters[0].Value = "CaicDayMoney";
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

