using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:FixedAssets
	/// </summary>
	public partial class FixedAssets
	{
		public FixedAssets()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "FixedAssets"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from FixedAssets");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.FixedAssets model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into FixedAssets(");
			strSql.Append("Sn,Barcode,Name,FATypeID,Spec,CompanyID,GBCode,More,DateOfOut,UseDeparmentID,UseTypeID,StoreAccess,Custodian,Amount,MeasureID,Price,AddTypeID,OldMoney,NowMoney,Depreciation,ResidualValue,UseDate,Interval,DepreciationYear,DepreciationMonth,Remark,IsOut)");
			strSql.Append(" values (");
			strSql.Append("@Sn,@Barcode,@Name,@FATypeID,@Spec,@CompanyID,@GBCode,@More,@DateOfOut,@UseDeparmentID,@UseTypeID,@StoreAccess,@Custodian,@Amount,@MeasureID,@Price,@AddTypeID,@OldMoney,@NowMoney,@Depreciation,@ResidualValue,@UseDate,@Interval,@DepreciationYear,@DepreciationMonth,@Remark,@IsOut)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@Barcode", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,500),
					new SqlParameter("@FATypeID", SqlDbType.Int,4),
					new SqlParameter("@Spec", SqlDbType.NVarChar,500),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@GBCode", SqlDbType.NVarChar,50),
					new SqlParameter("@More", SqlDbType.NVarChar,4000),
					new SqlParameter("@DateOfOut", SqlDbType.DateTime),
					new SqlParameter("@UseDeparmentID", SqlDbType.Int,4),
					new SqlParameter("@UseTypeID", SqlDbType.Int,4),
					new SqlParameter("@StoreAccess", SqlDbType.NVarChar,500),
					new SqlParameter("@Custodian", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Real,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@AddTypeID", SqlDbType.Int,4),
					new SqlParameter("@OldMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Depreciation", SqlDbType.Int,4),
					new SqlParameter("@ResidualValue", SqlDbType.Decimal,9),
					new SqlParameter("@UseDate", SqlDbType.DateTime),
					new SqlParameter("@Interval", SqlDbType.Int,4),
					new SqlParameter("@DepreciationYear", SqlDbType.Int,4),
					new SqlParameter("@DepreciationMonth", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@IsOut", SqlDbType.Bit,1)};
			parameters[0].Value = model.Sn;
			parameters[1].Value = model.Barcode;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.FATypeID;
			parameters[4].Value = model.Spec;
			parameters[5].Value = model.CompanyID;
			parameters[6].Value = model.GBCode;
			parameters[7].Value = model.More;
			parameters[8].Value = model.DateOfOut;
			parameters[9].Value = model.UseDeparmentID;
			parameters[10].Value = model.UseTypeID;
			parameters[11].Value = model.StoreAccess;
			parameters[12].Value = model.Custodian;
			parameters[13].Value = model.Amount;
			parameters[14].Value = model.MeasureID;
			parameters[15].Value = model.Price;
			parameters[16].Value = model.AddTypeID;
			parameters[17].Value = model.OldMoney;
			parameters[18].Value = model.NowMoney;
			parameters[19].Value = model.Depreciation;
			parameters[20].Value = model.ResidualValue;
			parameters[21].Value = model.UseDate;
			parameters[22].Value = model.Interval;
			parameters[23].Value = model.DepreciationYear;
			parameters[24].Value = model.DepreciationMonth;
			parameters[25].Value = model.Remark;
			parameters[26].Value = model.IsOut;

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
		public bool Update(Hownet.Model.FixedAssets model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update FixedAssets set ");
			strSql.Append("Sn=@Sn,");
			strSql.Append("Barcode=@Barcode,");
			strSql.Append("Name=@Name,");
			strSql.Append("FATypeID=@FATypeID,");
			strSql.Append("Spec=@Spec,");
			strSql.Append("CompanyID=@CompanyID,");
			strSql.Append("GBCode=@GBCode,");
			strSql.Append("More=@More,");
			strSql.Append("DateOfOut=@DateOfOut,");
			strSql.Append("UseDeparmentID=@UseDeparmentID,");
			strSql.Append("UseTypeID=@UseTypeID,");
			strSql.Append("StoreAccess=@StoreAccess,");
			strSql.Append("Custodian=@Custodian,");
			strSql.Append("Amount=@Amount,");
			strSql.Append("MeasureID=@MeasureID,");
			strSql.Append("Price=@Price,");
			strSql.Append("AddTypeID=@AddTypeID,");
			strSql.Append("OldMoney=@OldMoney,");
			strSql.Append("NowMoney=@NowMoney,");
			strSql.Append("Depreciation=@Depreciation,");
			strSql.Append("ResidualValue=@ResidualValue,");
			strSql.Append("UseDate=@UseDate,");
			strSql.Append("Interval=@Interval,");
			strSql.Append("DepreciationYear=@DepreciationYear,");
			strSql.Append("DepreciationMonth=@DepreciationMonth,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsOut=@IsOut");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@Barcode", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,500),
					new SqlParameter("@FATypeID", SqlDbType.Int,4),
					new SqlParameter("@Spec", SqlDbType.NVarChar,500),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@GBCode", SqlDbType.NVarChar,50),
					new SqlParameter("@More", SqlDbType.NVarChar,4000),
					new SqlParameter("@DateOfOut", SqlDbType.DateTime),
					new SqlParameter("@UseDeparmentID", SqlDbType.Int,4),
					new SqlParameter("@UseTypeID", SqlDbType.Int,4),
					new SqlParameter("@StoreAccess", SqlDbType.NVarChar,500),
					new SqlParameter("@Custodian", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Real,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@AddTypeID", SqlDbType.Int,4),
					new SqlParameter("@OldMoney", SqlDbType.Decimal,9),
					new SqlParameter("@NowMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Depreciation", SqlDbType.Int,4),
					new SqlParameter("@ResidualValue", SqlDbType.Decimal,9),
					new SqlParameter("@UseDate", SqlDbType.DateTime),
					new SqlParameter("@Interval", SqlDbType.Int,4),
					new SqlParameter("@DepreciationYear", SqlDbType.Int,4),
					new SqlParameter("@DepreciationMonth", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@IsOut", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Sn;
			parameters[1].Value = model.Barcode;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.FATypeID;
			parameters[4].Value = model.Spec;
			parameters[5].Value = model.CompanyID;
			parameters[6].Value = model.GBCode;
			parameters[7].Value = model.More;
			parameters[8].Value = model.DateOfOut;
			parameters[9].Value = model.UseDeparmentID;
			parameters[10].Value = model.UseTypeID;
			parameters[11].Value = model.StoreAccess;
			parameters[12].Value = model.Custodian;
			parameters[13].Value = model.Amount;
			parameters[14].Value = model.MeasureID;
			parameters[15].Value = model.Price;
			parameters[16].Value = model.AddTypeID;
			parameters[17].Value = model.OldMoney;
			parameters[18].Value = model.NowMoney;
			parameters[19].Value = model.Depreciation;
			parameters[20].Value = model.ResidualValue;
			parameters[21].Value = model.UseDate;
			parameters[22].Value = model.Interval;
			parameters[23].Value = model.DepreciationYear;
			parameters[24].Value = model.DepreciationMonth;
			parameters[25].Value = model.Remark;
			parameters[26].Value = model.IsOut;
			parameters[27].Value = model.ID;

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
			strSql.Append("delete from FixedAssets ");
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
			strSql.Append("delete from FixedAssets ");
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
		public Hownet.Model.FixedAssets GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1  ID,Sn,Barcode,Name,FATypeID,Spec,CompanyID,GBCode,More,DateOfOut,UseDeparmentID,UseTypeID,StoreAccess,Custodian,Amount,MeasureID,Price,AddTypeID,OldMoney,NowMoney,Depreciation,ResidualValue,UseDate,Interval,DepreciationYear,DepreciationMonth,Remark,IsOut from FixedAssets ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.FixedAssets model=new Hownet.Model.FixedAssets();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.Sn=ds.Tables[0].Rows[0]["Sn"].ToString();
				model.Barcode=ds.Tables[0].Rows[0]["Barcode"].ToString();
				model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				if(ds.Tables[0].Rows[0]["FATypeID"].ToString()!="")
				{
					model.FATypeID=int.Parse(ds.Tables[0].Rows[0]["FATypeID"].ToString());
				}
				model.Spec=ds.Tables[0].Rows[0]["Spec"].ToString();
				if(ds.Tables[0].Rows[0]["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
				}
				model.GBCode=ds.Tables[0].Rows[0]["GBCode"].ToString();
				model.More=ds.Tables[0].Rows[0]["More"].ToString();
				if(ds.Tables[0].Rows[0]["DateOfOut"].ToString()!="")
				{
					model.DateOfOut=DateTime.Parse(ds.Tables[0].Rows[0]["DateOfOut"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UseDeparmentID"].ToString()!="")
				{
					model.UseDeparmentID=int.Parse(ds.Tables[0].Rows[0]["UseDeparmentID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UseTypeID"].ToString()!="")
				{
					model.UseTypeID=int.Parse(ds.Tables[0].Rows[0]["UseTypeID"].ToString());
				}
				model.StoreAccess=ds.Tables[0].Rows[0]["StoreAccess"].ToString();
				if(ds.Tables[0].Rows[0]["Custodian"].ToString()!="")
				{
					model.Custodian=int.Parse(ds.Tables[0].Rows[0]["Custodian"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Amount"].ToString()!="")
				{
					model.Amount=decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MeasureID"].ToString()!="")
				{
					model.MeasureID=int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["AddTypeID"].ToString()!="")
				{
					model.AddTypeID=int.Parse(ds.Tables[0].Rows[0]["AddTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OldMoney"].ToString()!="")
				{
					model.OldMoney=decimal.Parse(ds.Tables[0].Rows[0]["OldMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NowMoney"].ToString()!="")
				{
					model.NowMoney=decimal.Parse(ds.Tables[0].Rows[0]["NowMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Depreciation"].ToString()!="")
				{
					model.Depreciation=int.Parse(ds.Tables[0].Rows[0]["Depreciation"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ResidualValue"].ToString()!="")
				{
					model.ResidualValue=decimal.Parse(ds.Tables[0].Rows[0]["ResidualValue"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UseDate"].ToString()!="")
				{
					model.UseDate=DateTime.Parse(ds.Tables[0].Rows[0]["UseDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Interval"].ToString()!="")
				{
					model.Interval=int.Parse(ds.Tables[0].Rows[0]["Interval"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DepreciationYear"].ToString()!="")
				{
					model.DepreciationYear=int.Parse(ds.Tables[0].Rows[0]["DepreciationYear"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DepreciationMonth"].ToString()!="")
				{
					model.DepreciationMonth=int.Parse(ds.Tables[0].Rows[0]["DepreciationMonth"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["IsOut"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsOut"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsOut"].ToString().ToLower()=="true"))
					{
						model.IsOut=true;
					}
					else
					{
						model.IsOut=false;
					}
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
			strSql.Append("select 1 as A,ID,Sn,Barcode,Name,FATypeID,Spec,CompanyID,GBCode,More,DateOfOut,UseDeparmentID,UseTypeID,StoreAccess,Custodian,Amount,MeasureID,Price,AddTypeID,OldMoney,NowMoney,Depreciation,ResidualValue,UseDate,Interval,DepreciationYear,DepreciationMonth,Remark,IsOut ");
			strSql.Append(" FROM FixedAssets ");
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
			strSql.Append(" ID,Sn,Barcode,Name,FATypeID,Spec,CompanyID,GBCode,More,DateOfOut,UseDeparmentID,UseTypeID,StoreAccess,Custodian,Amount,MeasureID,Price,AddTypeID,OldMoney,NowMoney,Depreciation,ResidualValue,UseDate,Interval,DepreciationYear,DepreciationMonth,Remark,IsOut ");
			strSql.Append(" FROM FixedAssets ");
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
			parameters[0].Value = "FixedAssets";
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

