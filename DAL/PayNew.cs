using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:PayNew
	/// </summary>
	public partial class PayNew
	{
		public PayNew()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "PayNew"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PayNew");
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
		public int Add(Hownet.Model.PayNew model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into PayNew(");
			strSql.Append("EmployeeID,MainID,Month,GuDing1,GuDing2,GuDing3,GuDing4,GuDing5,Add1,Add2,Add3,Add4,Add5,Add6,Add7,Add8,Add9,Add10,Jian1,Jian2,Jian3,Jian4,Jian5,Jian6,Jian7,Jian8,Jian9,Jian10,JiShuanHGZ,Fact,Remain,LastRemain,Remark)");
			strSql.Append(" values (");
			strSql.Append("@EmployeeID,@MainID,@Month,@GuDing1,@GuDing2,@GuDing3,@GuDing4,@GuDing5,@Add1,@Add2,@Add3,@Add4,@Add5,@Add6,@Add7,@Add8,@Add9,@Add10,@Jian1,@Jian2,@Jian3,@Jian4,@Jian5,@Jian6,@Jian7,@Jian8,@Jian9,@Jian10,@JiShuanHGZ,@Fact,@Remain,@LastRemain,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Month", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing1", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing2", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing3", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing4", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing5", SqlDbType.Decimal,9),
					new SqlParameter("@Add1", SqlDbType.Decimal,9),
					new SqlParameter("@Add2", SqlDbType.Decimal,9),
					new SqlParameter("@Add3", SqlDbType.Decimal,9),
					new SqlParameter("@Add4", SqlDbType.Decimal,9),
					new SqlParameter("@Add5", SqlDbType.Decimal,9),
					new SqlParameter("@Add6", SqlDbType.Decimal,9),
					new SqlParameter("@Add7", SqlDbType.Decimal,9),
					new SqlParameter("@Add8", SqlDbType.Decimal,9),
					new SqlParameter("@Add9", SqlDbType.Decimal,9),
					new SqlParameter("@Add10", SqlDbType.Decimal,9),
					new SqlParameter("@Jian1", SqlDbType.Decimal,9),
					new SqlParameter("@Jian2", SqlDbType.Decimal,9),
					new SqlParameter("@Jian3", SqlDbType.Decimal,9),
					new SqlParameter("@Jian4", SqlDbType.Decimal,9),
					new SqlParameter("@Jian5", SqlDbType.Decimal,9),
					new SqlParameter("@Jian6", SqlDbType.Decimal,9),
					new SqlParameter("@Jian7", SqlDbType.Decimal,9),
					new SqlParameter("@Jian8", SqlDbType.Decimal,9),
					new SqlParameter("@Jian9", SqlDbType.Decimal,9),
					new SqlParameter("@Jian10", SqlDbType.Decimal,9),
					new SqlParameter("@JiShuanHGZ", SqlDbType.Decimal,9),
					new SqlParameter("@Fact", SqlDbType.Decimal,9),
					new SqlParameter("@Remain", SqlDbType.Decimal,9),
					new SqlParameter("@LastRemain", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
			parameters[0].Value = model.EmployeeID;
			parameters[1].Value = model.MainID;
			parameters[2].Value = model.Month;
			parameters[3].Value = model.GuDing1;
			parameters[4].Value = model.GuDing2;
			parameters[5].Value = model.GuDing3;
			parameters[6].Value = model.GuDing4;
			parameters[7].Value = model.GuDing5;
			parameters[8].Value = model.Add1;
			parameters[9].Value = model.Add2;
			parameters[10].Value = model.Add3;
			parameters[11].Value = model.Add4;
			parameters[12].Value = model.Add5;
			parameters[13].Value = model.Add6;
			parameters[14].Value = model.Add7;
			parameters[15].Value = model.Add8;
			parameters[16].Value = model.Add9;
			parameters[17].Value = model.Add10;
			parameters[18].Value = model.Jian1;
			parameters[19].Value = model.Jian2;
			parameters[20].Value = model.Jian3;
			parameters[21].Value = model.Jian4;
			parameters[22].Value = model.Jian5;
			parameters[23].Value = model.Jian6;
			parameters[24].Value = model.Jian7;
			parameters[25].Value = model.Jian8;
			parameters[26].Value = model.Jian9;
			parameters[27].Value = model.Jian10;
			parameters[28].Value = model.JiShuanHGZ;
			parameters[29].Value = model.Fact;
			parameters[30].Value = model.Remain;
			parameters[31].Value = model.LastRemain;
			parameters[32].Value = model.Remark;

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
		public bool Update(Hownet.Model.PayNew model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update PayNew set ");
			strSql.Append("EmployeeID=@EmployeeID,");
			strSql.Append("MainID=@MainID,");
			strSql.Append("Month=@Month,");
			strSql.Append("GuDing1=@GuDing1,");
			strSql.Append("GuDing2=@GuDing2,");
			strSql.Append("GuDing3=@GuDing3,");
			strSql.Append("GuDing4=@GuDing4,");
			strSql.Append("GuDing5=@GuDing5,");
			strSql.Append("Add1=@Add1,");
			strSql.Append("Add2=@Add2,");
			strSql.Append("Add3=@Add3,");
			strSql.Append("Add4=@Add4,");
			strSql.Append("Add5=@Add5,");
			strSql.Append("Add6=@Add6,");
			strSql.Append("Add7=@Add7,");
			strSql.Append("Add8=@Add8,");
			strSql.Append("Add9=@Add9,");
			strSql.Append("Add10=@Add10,");
			strSql.Append("Jian1=@Jian1,");
			strSql.Append("Jian2=@Jian2,");
			strSql.Append("Jian3=@Jian3,");
			strSql.Append("Jian4=@Jian4,");
			strSql.Append("Jian5=@Jian5,");
			strSql.Append("Jian6=@Jian6,");
			strSql.Append("Jian7=@Jian7,");
			strSql.Append("Jian8=@Jian8,");
			strSql.Append("Jian9=@Jian9,");
			strSql.Append("Jian10=@Jian10,");
			strSql.Append("JiShuanHGZ=@JiShuanHGZ,");
			strSql.Append("Fact=@Fact,");
			strSql.Append("Remain=@Remain,");
			strSql.Append("LastRemain=@LastRemain,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Month", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing1", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing2", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing3", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing4", SqlDbType.Decimal,9),
					new SqlParameter("@GuDing5", SqlDbType.Decimal,9),
					new SqlParameter("@Add1", SqlDbType.Decimal,9),
					new SqlParameter("@Add2", SqlDbType.Decimal,9),
					new SqlParameter("@Add3", SqlDbType.Decimal,9),
					new SqlParameter("@Add4", SqlDbType.Decimal,9),
					new SqlParameter("@Add5", SqlDbType.Decimal,9),
					new SqlParameter("@Add6", SqlDbType.Decimal,9),
					new SqlParameter("@Add7", SqlDbType.Decimal,9),
					new SqlParameter("@Add8", SqlDbType.Decimal,9),
					new SqlParameter("@Add9", SqlDbType.Decimal,9),
					new SqlParameter("@Add10", SqlDbType.Decimal,9),
					new SqlParameter("@Jian1", SqlDbType.Decimal,9),
					new SqlParameter("@Jian2", SqlDbType.Decimal,9),
					new SqlParameter("@Jian3", SqlDbType.Decimal,9),
					new SqlParameter("@Jian4", SqlDbType.Decimal,9),
					new SqlParameter("@Jian5", SqlDbType.Decimal,9),
					new SqlParameter("@Jian6", SqlDbType.Decimal,9),
					new SqlParameter("@Jian7", SqlDbType.Decimal,9),
					new SqlParameter("@Jian8", SqlDbType.Decimal,9),
					new SqlParameter("@Jian9", SqlDbType.Decimal,9),
					new SqlParameter("@Jian10", SqlDbType.Decimal,9),
					new SqlParameter("@JiShuanHGZ", SqlDbType.Decimal,9),
					new SqlParameter("@Fact", SqlDbType.Decimal,9),
					new SqlParameter("@Remain", SqlDbType.Decimal,9),
					new SqlParameter("@LastRemain", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.EmployeeID;
			parameters[1].Value = model.MainID;
			parameters[2].Value = model.Month;
			parameters[3].Value = model.GuDing1;
			parameters[4].Value = model.GuDing2;
			parameters[5].Value = model.GuDing3;
			parameters[6].Value = model.GuDing4;
			parameters[7].Value = model.GuDing5;
			parameters[8].Value = model.Add1;
			parameters[9].Value = model.Add2;
			parameters[10].Value = model.Add3;
			parameters[11].Value = model.Add4;
			parameters[12].Value = model.Add5;
			parameters[13].Value = model.Add6;
			parameters[14].Value = model.Add7;
			parameters[15].Value = model.Add8;
			parameters[16].Value = model.Add9;
			parameters[17].Value = model.Add10;
			parameters[18].Value = model.Jian1;
			parameters[19].Value = model.Jian2;
			parameters[20].Value = model.Jian3;
			parameters[21].Value = model.Jian4;
			parameters[22].Value = model.Jian5;
			parameters[23].Value = model.Jian6;
			parameters[24].Value = model.Jian7;
			parameters[25].Value = model.Jian8;
			parameters[26].Value = model.Jian9;
			parameters[27].Value = model.Jian10;
			parameters[28].Value = model.JiShuanHGZ;
			parameters[29].Value = model.Fact;
			parameters[30].Value = model.Remain;
			parameters[31].Value = model.LastRemain;
			parameters[32].Value = model.Remark;
			parameters[33].Value = model.ID;

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
			strSql.Append("delete from PayNew ");
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
			strSql.Append("delete from PayNew ");
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
		public Hownet.Model.PayNew GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,EmployeeID,MainID,Month,GuDing1,GuDing2,GuDing3,GuDing4,GuDing5,Add1,Add2,Add3,Add4,Add5,Add6,Add7,Add8,Add9,Add10,Jian1,Jian2,Jian3,Jian4,Jian5,Jian6,Jian7,Jian8,Jian9,Jian10,JiShuanHGZ,Fact,Remain,LastRemain,Remark from PayNew ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.PayNew model=new Hownet.Model.PayNew();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EmployeeID"]!=null && ds.Tables[0].Rows[0]["EmployeeID"].ToString()!="")
				{
					model.EmployeeID=int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MainID"]!=null && ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Month"]!=null && ds.Tables[0].Rows[0]["Month"].ToString()!="")
				{
					model.Month=decimal.Parse(ds.Tables[0].Rows[0]["Month"].ToString());
				}
				if(ds.Tables[0].Rows[0]["GuDing1"]!=null && ds.Tables[0].Rows[0]["GuDing1"].ToString()!="")
				{
					model.GuDing1=decimal.Parse(ds.Tables[0].Rows[0]["GuDing1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["GuDing2"]!=null && ds.Tables[0].Rows[0]["GuDing2"].ToString()!="")
				{
					model.GuDing2=decimal.Parse(ds.Tables[0].Rows[0]["GuDing2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["GuDing3"]!=null && ds.Tables[0].Rows[0]["GuDing3"].ToString()!="")
				{
					model.GuDing3=decimal.Parse(ds.Tables[0].Rows[0]["GuDing3"].ToString());
				}
				if(ds.Tables[0].Rows[0]["GuDing4"]!=null && ds.Tables[0].Rows[0]["GuDing4"].ToString()!="")
				{
					model.GuDing4=decimal.Parse(ds.Tables[0].Rows[0]["GuDing4"].ToString());
				}
				if(ds.Tables[0].Rows[0]["GuDing5"]!=null && ds.Tables[0].Rows[0]["GuDing5"].ToString()!="")
				{
					model.GuDing5=decimal.Parse(ds.Tables[0].Rows[0]["GuDing5"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add1"]!=null && ds.Tables[0].Rows[0]["Add1"].ToString()!="")
				{
					model.Add1=decimal.Parse(ds.Tables[0].Rows[0]["Add1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add2"]!=null && ds.Tables[0].Rows[0]["Add2"].ToString()!="")
				{
					model.Add2=decimal.Parse(ds.Tables[0].Rows[0]["Add2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add3"]!=null && ds.Tables[0].Rows[0]["Add3"].ToString()!="")
				{
					model.Add3=decimal.Parse(ds.Tables[0].Rows[0]["Add3"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add4"]!=null && ds.Tables[0].Rows[0]["Add4"].ToString()!="")
				{
					model.Add4=decimal.Parse(ds.Tables[0].Rows[0]["Add4"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add5"]!=null && ds.Tables[0].Rows[0]["Add5"].ToString()!="")
				{
					model.Add5=decimal.Parse(ds.Tables[0].Rows[0]["Add5"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add6"]!=null && ds.Tables[0].Rows[0]["Add6"].ToString()!="")
				{
					model.Add6=decimal.Parse(ds.Tables[0].Rows[0]["Add6"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add7"]!=null && ds.Tables[0].Rows[0]["Add7"].ToString()!="")
				{
					model.Add7=decimal.Parse(ds.Tables[0].Rows[0]["Add7"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add8"]!=null && ds.Tables[0].Rows[0]["Add8"].ToString()!="")
				{
					model.Add8=decimal.Parse(ds.Tables[0].Rows[0]["Add8"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add9"]!=null && ds.Tables[0].Rows[0]["Add9"].ToString()!="")
				{
					model.Add9=decimal.Parse(ds.Tables[0].Rows[0]["Add9"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Add10"]!=null && ds.Tables[0].Rows[0]["Add10"].ToString()!="")
				{
					model.Add10=decimal.Parse(ds.Tables[0].Rows[0]["Add10"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian1"]!=null && ds.Tables[0].Rows[0]["Jian1"].ToString()!="")
				{
					model.Jian1=decimal.Parse(ds.Tables[0].Rows[0]["Jian1"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian2"]!=null && ds.Tables[0].Rows[0]["Jian2"].ToString()!="")
				{
					model.Jian2=decimal.Parse(ds.Tables[0].Rows[0]["Jian2"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian3"]!=null && ds.Tables[0].Rows[0]["Jian3"].ToString()!="")
				{
					model.Jian3=decimal.Parse(ds.Tables[0].Rows[0]["Jian3"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian4"]!=null && ds.Tables[0].Rows[0]["Jian4"].ToString()!="")
				{
					model.Jian4=decimal.Parse(ds.Tables[0].Rows[0]["Jian4"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian5"]!=null && ds.Tables[0].Rows[0]["Jian5"].ToString()!="")
				{
					model.Jian5=decimal.Parse(ds.Tables[0].Rows[0]["Jian5"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian6"]!=null && ds.Tables[0].Rows[0]["Jian6"].ToString()!="")
				{
					model.Jian6=decimal.Parse(ds.Tables[0].Rows[0]["Jian6"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian7"]!=null && ds.Tables[0].Rows[0]["Jian7"].ToString()!="")
				{
					model.Jian7=decimal.Parse(ds.Tables[0].Rows[0]["Jian7"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian8"]!=null && ds.Tables[0].Rows[0]["Jian8"].ToString()!="")
				{
					model.Jian8=decimal.Parse(ds.Tables[0].Rows[0]["Jian8"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian9"]!=null && ds.Tables[0].Rows[0]["Jian9"].ToString()!="")
				{
					model.Jian9=decimal.Parse(ds.Tables[0].Rows[0]["Jian9"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Jian10"]!=null && ds.Tables[0].Rows[0]["Jian10"].ToString()!="")
				{
					model.Jian10=decimal.Parse(ds.Tables[0].Rows[0]["Jian10"].ToString());
				}
				if(ds.Tables[0].Rows[0]["JiShuanHGZ"]!=null && ds.Tables[0].Rows[0]["JiShuanHGZ"].ToString()!="")
				{
					model.JiShuanHGZ=decimal.Parse(ds.Tables[0].Rows[0]["JiShuanHGZ"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Fact"]!=null && ds.Tables[0].Rows[0]["Fact"].ToString()!="")
				{
					model.Fact=decimal.Parse(ds.Tables[0].Rows[0]["Fact"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Remain"]!=null && ds.Tables[0].Rows[0]["Remain"].ToString()!="")
				{
					model.Remain=decimal.Parse(ds.Tables[0].Rows[0]["Remain"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LastRemain"]!=null && ds.Tables[0].Rows[0]["LastRemain"].ToString()!="")
				{
					model.LastRemain=decimal.Parse(ds.Tables[0].Rows[0]["LastRemain"].ToString());
				}
					model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
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
			strSql.Append("select  1 as A,ID,EmployeeID,MainID,Month,GuDing1,GuDing2,GuDing3,GuDing4,GuDing5,Add1,Add2,Add3,Add4,Add5,Add6,Add7,Add8,Add9,Add10,Jian1,Jian2,Jian3,Jian4,Jian5,Jian6,Jian7,Jian8,Jian9,Jian10,JiShuanHGZ,Fact,Remain,LastRemain,Remark ");
			strSql.Append(" FROM PayNew ");
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
			strSql.Append(" ID,EmployeeID,MainID,Month,GuDing1,GuDing2,GuDing3,GuDing4,GuDing5,Add1,Add2,Add3,Add4,Add5,Add6,Add7,Add8,Add9,Add10,Jian1,Jian2,Jian3,Jian4,Jian5,Jian6,Jian7,Jian8,Jian9,Jian10,JiShuanHGZ,Fact,Remain,LastRemain,Remark ");
			strSql.Append(" FROM PayNew ");
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
			parameters[0].Value = "PayNew";
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

