using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类StockMaterielDemand。
	/// </summary>
	public class StockMaterielDemand
	{
		public StockMaterielDemand()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "StockMaterielDemand"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StockMaterielDemand");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.StockMaterielDemand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into StockMaterielDemand(");
			strSql.Append("PlanID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,MainID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount)");
			strSql.Append(" values (");
			strSql.Append("@PlanID,@MaterielID,@ColorID,@ColorOneID,@ColorTwoID,@Amount,@NotAllotAmount,@stockAmount,@stockNotAmount,@SizeID,@MeasureID,@DepID,@MListID,@MainID,@IsEnd,@RepertoryAmount,@NeedAmount,@HasStockAmount,@OutAmount)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PlanID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAllotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockNotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@RepertoryAmount", SqlDbType.Decimal,9),
					new SqlParameter("@NeedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@HasStockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OutAmount", SqlDbType.Decimal,9)};
			parameters[0].Value = model.PlanID;
			parameters[1].Value = model.MaterielID;
			parameters[2].Value = model.ColorID;
			parameters[3].Value = model.ColorOneID;
			parameters[4].Value = model.ColorTwoID;
			parameters[5].Value = model.Amount;
			parameters[6].Value = model.NotAllotAmount;
			parameters[7].Value = model.stockAmount;
			parameters[8].Value = model.stockNotAmount;
			parameters[9].Value = model.SizeID;
			parameters[10].Value = model.MeasureID;
			parameters[11].Value = model.DepID;
			parameters[12].Value = model.MListID;
			parameters[13].Value = model.MainID;
			parameters[14].Value = model.IsEnd;
			parameters[15].Value = model.RepertoryAmount;
			parameters[16].Value = model.NeedAmount;
			parameters[17].Value = model.HasStockAmount;
			parameters[18].Value = model.OutAmount;

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
		public void Update(Hownet.Model.StockMaterielDemand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update StockMaterielDemand set ");
			strSql.Append("PlanID=@PlanID,");
			strSql.Append("MaterielID=@MaterielID,");
			strSql.Append("ColorID=@ColorID,");
			strSql.Append("ColorOneID=@ColorOneID,");
			strSql.Append("ColorTwoID=@ColorTwoID,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("NotAllotAmount=@NotAllotAmount,");
			strSql.Append("stockAmount=@stockAmount,");
			strSql.Append("stockNotAmount=@stockNotAmount,");
			strSql.Append("SizeID=@SizeID,");
			strSql.Append("MeasureID=@MeasureID,");
			strSql.Append("DepID=@DepID,");
			strSql.Append("MListID=@MListID,");
			strSql.Append("MainID=@MainID,");
			strSql.Append("IsEnd=@IsEnd,");
			strSql.Append("RepertoryAmount=@RepertoryAmount,");
			strSql.Append("NeedAmount=@NeedAmount,");
			strSql.Append("HasStockAmount=@HasStockAmount,");
			strSql.Append("OutAmount=@OutAmount");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PlanID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAllotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockNotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@RepertoryAmount", SqlDbType.Decimal,9),
					new SqlParameter("@NeedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@HasStockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OutAmount", SqlDbType.Decimal,9)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PlanID;
			parameters[2].Value = model.MaterielID;
			parameters[3].Value = model.ColorID;
			parameters[4].Value = model.ColorOneID;
			parameters[5].Value = model.ColorTwoID;
			parameters[6].Value = model.Amount;
			parameters[7].Value = model.NotAllotAmount;
			parameters[8].Value = model.stockAmount;
			parameters[9].Value = model.stockNotAmount;
			parameters[10].Value = model.SizeID;
			parameters[11].Value = model.MeasureID;
			parameters[12].Value = model.DepID;
			parameters[13].Value = model.MListID;
			parameters[14].Value = model.MainID;
			parameters[15].Value = model.IsEnd;
			parameters[16].Value = model.RepertoryAmount;
			parameters[17].Value = model.NeedAmount;
			parameters[18].Value = model.HasStockAmount;
			parameters[19].Value = model.OutAmount;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from StockMaterielDemand ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.StockMaterielDemand GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,PlanID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,MainID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount from StockMaterielDemand ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.StockMaterielDemand model=new Hownet.Model.StockMaterielDemand();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PlanID"].ToString()!="")
				{
					model.PlanID=int.Parse(ds.Tables[0].Rows[0]["PlanID"].ToString());
				}
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
				if(ds.Tables[0].Rows[0]["Amount"].ToString()!="")
				{
					model.Amount=decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NotAllotAmount"].ToString()!="")
				{
					model.NotAllotAmount=decimal.Parse(ds.Tables[0].Rows[0]["NotAllotAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["stockAmount"].ToString()!="")
				{
					model.stockAmount=decimal.Parse(ds.Tables[0].Rows[0]["stockAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["stockNotAmount"].ToString()!="")
				{
					model.stockNotAmount=decimal.Parse(ds.Tables[0].Rows[0]["stockNotAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SizeID"].ToString()!="")
				{
					model.SizeID=int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MeasureID"].ToString()!="")
				{
					model.MeasureID=int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DepID"].ToString()!="")
				{
					model.DepID=int.Parse(ds.Tables[0].Rows[0]["DepID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MListID"].ToString()!="")
				{
					model.MListID=int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					model.IsEnd=int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
				}
				if(ds.Tables[0].Rows[0]["RepertoryAmount"].ToString()!="")
				{
					model.RepertoryAmount=decimal.Parse(ds.Tables[0].Rows[0]["RepertoryAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NeedAmount"].ToString()!="")
				{
					model.NeedAmount=decimal.Parse(ds.Tables[0].Rows[0]["NeedAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["HasStockAmount"].ToString()!="")
				{
					model.HasStockAmount=decimal.Parse(ds.Tables[0].Rows[0]["HasStockAmount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OutAmount"].ToString()!="")
				{
					model.OutAmount=decimal.Parse(ds.Tables[0].Rows[0]["OutAmount"].ToString());
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
			strSql.Append("select 1 as A,ID,PlanID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,MainID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount ");
			strSql.Append(" FROM StockMaterielDemand ");
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
			strSql.Append(" ID,PlanID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,MainID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount ");
			strSql.Append(" FROM StockMaterielDemand ");
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
			parameters[0].Value = "StockMaterielDemand";
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

