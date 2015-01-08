using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:BAS_BodyPart
	/// </summary>
	public partial class BAS_BodyPart
	{
		public BAS_BodyPart()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "BAS_BodyPart"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BAS_BodyPart");
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
		public int Add(Hownet.Model.BAS_BodyPart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BAS_BodyPart(");
			strSql.Append("EnName,CnName,Remark,GoodsType,IsDef,IsValid,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,SortIndexNo,PartEnName,MeasuringMethods,SizeError,MainID,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@EnName,@CnName,@Remark,@GoodsType,@IsDef,@IsValid,@Size1,@Size2,@Size3,@Size4,@Size5,@Size6,@Size7,@Size8,@Size9,@Size10,@SortIndexNo,@PartEnName,@MeasuringMethods,@SizeError,@MainID,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EnName", SqlDbType.VarChar,50),
					new SqlParameter("@CnName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@GoodsType", SqlDbType.Char,10),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@Size1", SqlDbType.VarChar,20),
					new SqlParameter("@Size2", SqlDbType.VarChar,20),
					new SqlParameter("@Size3", SqlDbType.VarChar,20),
					new SqlParameter("@Size4", SqlDbType.VarChar,20),
					new SqlParameter("@Size5", SqlDbType.VarChar,20),
					new SqlParameter("@Size6", SqlDbType.VarChar,20),
					new SqlParameter("@Size7", SqlDbType.VarChar,20),
					new SqlParameter("@Size8", SqlDbType.VarChar,20),
					new SqlParameter("@Size9", SqlDbType.VarChar,20),
					new SqlParameter("@Size10", SqlDbType.VarChar,20),
					new SqlParameter("@SortIndexNo", SqlDbType.VarChar,20),
					new SqlParameter("@PartEnName", SqlDbType.VarChar,1000),
					new SqlParameter("@MeasuringMethods", SqlDbType.VarChar,100),
					new SqlParameter("@SizeError", SqlDbType.VarChar,50),
					new SqlParameter("@MainID", SqlDbType.BigInt,8),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
			parameters[0].Value = model.EnName;
			parameters[1].Value = model.CnName;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.GoodsType;
			parameters[4].Value = model.IsDef;
			parameters[5].Value = model.IsValid;
			parameters[6].Value = model.Size1;
			parameters[7].Value = model.Size2;
			parameters[8].Value = model.Size3;
			parameters[9].Value = model.Size4;
			parameters[10].Value = model.Size5;
			parameters[11].Value = model.Size6;
			parameters[12].Value = model.Size7;
			parameters[13].Value = model.Size8;
			parameters[14].Value = model.Size9;
			parameters[15].Value = model.Size10;
			parameters[16].Value = model.SortIndexNo;
			parameters[17].Value = model.PartEnName;
			parameters[18].Value = model.MeasuringMethods;
			parameters[19].Value = model.SizeError;
			parameters[20].Value = model.MainID;
			parameters[21].Value = model.IsEnd;

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
		public bool Update(Hownet.Model.BAS_BodyPart model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BAS_BodyPart set ");
			strSql.Append("EnName=@EnName,");
			strSql.Append("CnName=@CnName,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("GoodsType=@GoodsType,");
			strSql.Append("IsDef=@IsDef,");
			strSql.Append("IsValid=@IsValid,");
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
			strSql.Append("SortIndexNo=@SortIndexNo,");
			strSql.Append("PartEnName=@PartEnName,");
			strSql.Append("MeasuringMethods=@MeasuringMethods,");
			strSql.Append("SizeError=@SizeError,");
			strSql.Append("MainID=@MainID,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EnName", SqlDbType.VarChar,50),
					new SqlParameter("@CnName", SqlDbType.VarChar,50),
					new SqlParameter("@Remark", SqlDbType.VarChar,500),
					new SqlParameter("@GoodsType", SqlDbType.Char,10),
					new SqlParameter("@IsDef", SqlDbType.Bit,1),
					new SqlParameter("@IsValid", SqlDbType.Bit,1),
					new SqlParameter("@Size1", SqlDbType.VarChar,20),
					new SqlParameter("@Size2", SqlDbType.VarChar,20),
					new SqlParameter("@Size3", SqlDbType.VarChar,20),
					new SqlParameter("@Size4", SqlDbType.VarChar,20),
					new SqlParameter("@Size5", SqlDbType.VarChar,20),
					new SqlParameter("@Size6", SqlDbType.VarChar,20),
					new SqlParameter("@Size7", SqlDbType.VarChar,20),
					new SqlParameter("@Size8", SqlDbType.VarChar,20),
					new SqlParameter("@Size9", SqlDbType.VarChar,20),
					new SqlParameter("@Size10", SqlDbType.VarChar,20),
					new SqlParameter("@SortIndexNo", SqlDbType.VarChar,20),
					new SqlParameter("@PartEnName", SqlDbType.VarChar,1000),
					new SqlParameter("@MeasuringMethods", SqlDbType.VarChar,100),
					new SqlParameter("@SizeError", SqlDbType.VarChar,50),
					new SqlParameter("@MainID", SqlDbType.BigInt,8),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.EnName;
			parameters[1].Value = model.CnName;
			parameters[2].Value = model.Remark;
			parameters[3].Value = model.GoodsType;
			parameters[4].Value = model.IsDef;
			parameters[5].Value = model.IsValid;
			parameters[6].Value = model.Size1;
			parameters[7].Value = model.Size2;
			parameters[8].Value = model.Size3;
			parameters[9].Value = model.Size4;
			parameters[10].Value = model.Size5;
			parameters[11].Value = model.Size6;
			parameters[12].Value = model.Size7;
			parameters[13].Value = model.Size8;
			parameters[14].Value = model.Size9;
			parameters[15].Value = model.Size10;
			parameters[16].Value = model.SortIndexNo;
			parameters[17].Value = model.PartEnName;
			parameters[18].Value = model.MeasuringMethods;
			parameters[19].Value = model.SizeError;
			parameters[20].Value = model.MainID;
			parameters[21].Value = model.IsEnd;
			parameters[22].Value = model.ID;

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
			strSql.Append("delete from BAS_BodyPart ");
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
			strSql.Append("delete from BAS_BodyPart ");
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
		public Hownet.Model.BAS_BodyPart GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 EnName,CnName,Remark,GoodsType,IsDef,IsValid,ID,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,SortIndexNo,PartEnName,MeasuringMethods,SizeError,MainID,IsEnd from BAS_BodyPart ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.BAS_BodyPart model=new Hownet.Model.BAS_BodyPart();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
					model.EnName=ds.Tables[0].Rows[0]["EnName"].ToString();
					model.CnName=ds.Tables[0].Rows[0]["CnName"].ToString();
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
					model.GoodsType=ds.Tables[0].Rows[0]["GoodsType"].ToString();
				if(ds.Tables[0].Rows[0]["IsDef"]!=null && ds.Tables[0].Rows[0]["IsDef"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsDef"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsDef"].ToString().ToLower()=="true"))
					{
						model.IsDef=true;
					}
					else
					{
						model.IsDef=false;
					}
				}
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
					model.SortIndexNo=ds.Tables[0].Rows[0]["SortIndexNo"].ToString();
					model.PartEnName=ds.Tables[0].Rows[0]["PartEnName"].ToString();
					model.MeasuringMethods=ds.Tables[0].Rows[0]["MeasuringMethods"].ToString();
					model.SizeError=ds.Tables[0].Rows[0]["SizeError"].ToString();
				if(ds.Tables[0].Rows[0]["MainID"]!=null && ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=long.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
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
			strSql.Append("select  1 as A,EnName,CnName,Remark,GoodsType,IsDef,IsValid,ID,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,SortIndexNo,PartEnName,MeasuringMethods,SizeError,MainID,IsEnd ");
			strSql.Append(" FROM BAS_BodyPart ");
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
			strSql.Append(" EnName,CnName,Remark,GoodsType,IsDef,IsValid,ID,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,SortIndexNo,PartEnName,MeasuringMethods,SizeError,MainID,IsEnd ");
			strSql.Append(" FROM BAS_BodyPart ");
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
			parameters[0].Value = "BAS_BodyPart";
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

