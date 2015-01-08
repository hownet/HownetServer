/**  版本信息模板在安装目录下，可自行修改。
* Sample.cs
*
* 功 能： N/A
* 类 名： Sample
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/1 14:41:30   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:Sample
	/// </summary>
	public partial class Sample
	{
		public Sample()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Sample"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Sample");
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
		public int Add(Hownet.Model.Sample model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Sample(");
            strSql.Append("StrNum,Num,Titlle,CompanyName,CompanyID,MaterielName,MaterielID,TypeName,PlanDate,SeriesName,OpenDate,LastDate,StockBackDate,TechDate,Remark,FillManID,FillManName,VerifyID,VerifyName,FillDate,VerifyDate,UpData,ProductName)");
            strSql.Append(" values (");
            strSql.Append("@StrNum,@Num,@Titlle,@CompanyName,@CompanyID,@MaterielName,@MaterielID,@TypeName,@PlanDate,@SeriesName,@OpenDate,@LastDate,@StockBackDate,@TechDate,@Remark,@FillManID,@FillManName,@VerifyID,@VerifyName,@FillDate,@VerifyDate,@UpData,@ProductName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@StrNum", SqlDbType.NVarChar,10),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Titlle", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@PlanDate", SqlDbType.DateTime),
					new SqlParameter("@SeriesName", SqlDbType.NVarChar,50),
					new SqlParameter("@OpenDate", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@StockBackDate", SqlDbType.DateTime),
					new SqlParameter("@TechDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@FillManID", SqlDbType.Int,4),
					new SqlParameter("@FillManName", SqlDbType.NVarChar,50),
					new SqlParameter("@VerifyID", SqlDbType.Int,4),
					new SqlParameter("@VerifyName", SqlDbType.NVarChar,50),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.StrNum;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.Titlle;
            parameters[3].Value = model.CompanyName;
            parameters[4].Value = model.CompanyID;
            parameters[5].Value = model.MaterielName;
            parameters[6].Value = model.MaterielID;
            parameters[7].Value = model.TypeName;
            parameters[8].Value = model.PlanDate;
            parameters[9].Value = model.SeriesName;
            parameters[10].Value = model.OpenDate;
            parameters[11].Value = model.LastDate;
            parameters[12].Value = model.StockBackDate;
            parameters[13].Value = model.TechDate;
            parameters[14].Value = model.Remark;
            parameters[15].Value = model.FillManID;
            parameters[16].Value = model.FillManName;
            parameters[17].Value = model.VerifyID;
            parameters[18].Value = model.VerifyName;
            parameters[19].Value = model.FillDate;
            parameters[20].Value = model.VerifyDate;
            parameters[21].Value = model.UpData;
            parameters[22].Value = model.ProductName;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(Hownet.Model.Sample model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Sample set ");
            strSql.Append("StrNum=@StrNum,");
            strSql.Append("Num=@Num,");
            strSql.Append("Titlle=@Titlle,");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("MaterielName=@MaterielName,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("TypeName=@TypeName,");
            strSql.Append("PlanDate=@PlanDate,");
            strSql.Append("SeriesName=@SeriesName,");
            strSql.Append("OpenDate=@OpenDate,");
            strSql.Append("LastDate=@LastDate,");
            strSql.Append("StockBackDate=@StockBackDate,");
            strSql.Append("TechDate=@TechDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("FillManID=@FillManID,");
            strSql.Append("FillManName=@FillManName,");
            strSql.Append("VerifyID=@VerifyID,");
            strSql.Append("VerifyName=@VerifyName,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("ProductName=@ProductName");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@StrNum", SqlDbType.NVarChar,10),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@Titlle", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@TypeName", SqlDbType.NVarChar,50),
					new SqlParameter("@PlanDate", SqlDbType.DateTime),
					new SqlParameter("@SeriesName", SqlDbType.NVarChar,50),
					new SqlParameter("@OpenDate", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@StockBackDate", SqlDbType.DateTime),
					new SqlParameter("@TechDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@FillManID", SqlDbType.Int,4),
					new SqlParameter("@FillManName", SqlDbType.NVarChar,50),
					new SqlParameter("@VerifyID", SqlDbType.Int,4),
					new SqlParameter("@VerifyName", SqlDbType.NVarChar,50),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@ProductName", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.StrNum;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.Titlle;
            parameters[3].Value = model.CompanyName;
            parameters[4].Value = model.CompanyID;
            parameters[5].Value = model.MaterielName;
            parameters[6].Value = model.MaterielID;
            parameters[7].Value = model.TypeName;
            parameters[8].Value = model.PlanDate;
            parameters[9].Value = model.SeriesName;
            parameters[10].Value = model.OpenDate;
            parameters[11].Value = model.LastDate;
            parameters[12].Value = model.StockBackDate;
            parameters[13].Value = model.TechDate;
            parameters[14].Value = model.Remark;
            parameters[15].Value = model.FillManID;
            parameters[16].Value = model.FillManName;
            parameters[17].Value = model.VerifyID;
            parameters[18].Value = model.VerifyName;
            parameters[19].Value = model.FillDate;
            parameters[20].Value = model.VerifyDate;
            parameters[21].Value = model.UpData;
            parameters[22].Value = model.ProductName;
            parameters[23].Value = model.ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sample ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            int rows = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Sample ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = DbHelperSQL.ExecuteSql(strSql.ToString());
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
        public Hownet.Model.Sample GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,StrNum,Num,Titlle,CompanyName,CompanyID,MaterielName,MaterielID,TypeName,PlanDate,SeriesName,OpenDate,LastDate,StockBackDate,TechDate,Remark,FillManID,FillManName,VerifyID,VerifyName,FillDate,VerifyDate,UpData,ProductName from Sample ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.Sample model = new Hownet.Model.Sample();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.StrNum = ds.Tables[0].Rows[0]["StrNum"].ToString();
                if (ds.Tables[0].Rows[0]["Num"] != null && ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                model.Titlle = ds.Tables[0].Rows[0]["Titlle"].ToString();
                model.CompanyName = ds.Tables[0].Rows[0]["CompanyName"].ToString();
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                model.MaterielName = ds.Tables[0].Rows[0]["MaterielName"].ToString();
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                model.TypeName = ds.Tables[0].Rows[0]["TypeName"].ToString();
                if (ds.Tables[0].Rows[0]["PlanDate"] != null && ds.Tables[0].Rows[0]["PlanDate"].ToString() != "")
                {
                    model.PlanDate = DateTime.Parse(ds.Tables[0].Rows[0]["PlanDate"].ToString());
                }
                model.SeriesName = ds.Tables[0].Rows[0]["SeriesName"].ToString();
                if (ds.Tables[0].Rows[0]["OpenDate"] != null && ds.Tables[0].Rows[0]["OpenDate"].ToString() != "")
                {
                    model.OpenDate = DateTime.Parse(ds.Tables[0].Rows[0]["OpenDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastDate"] != null && ds.Tables[0].Rows[0]["LastDate"].ToString() != "")
                {
                    model.LastDate = DateTime.Parse(ds.Tables[0].Rows[0]["LastDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StockBackDate"] != null && ds.Tables[0].Rows[0]["StockBackDate"].ToString() != "")
                {
                    model.StockBackDate = DateTime.Parse(ds.Tables[0].Rows[0]["StockBackDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TechDate"] != null && ds.Tables[0].Rows[0]["TechDate"].ToString() != "")
                {
                    model.TechDate = DateTime.Parse(ds.Tables[0].Rows[0]["TechDate"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["FillManID"] != null && ds.Tables[0].Rows[0]["FillManID"].ToString() != "")
                {
                    model.FillManID = int.Parse(ds.Tables[0].Rows[0]["FillManID"].ToString());
                }
                model.FillManName = ds.Tables[0].Rows[0]["FillManName"].ToString();
                if (ds.Tables[0].Rows[0]["VerifyID"] != null && ds.Tables[0].Rows[0]["VerifyID"].ToString() != "")
                {
                    model.VerifyID = int.Parse(ds.Tables[0].Rows[0]["VerifyID"].ToString());
                }
                model.VerifyName = ds.Tables[0].Rows[0]["VerifyName"].ToString();
                if (ds.Tables[0].Rows[0]["FillDate"] != null && ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"] != null && ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"] != null && ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                model.ProductName = ds.Tables[0].Rows[0]["ProductName"].ToString();
                model.A = 1;
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
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  1 as A,ID,StrNum,Num,Titlle,CompanyName,CompanyID,MaterielName,MaterielID,TypeName,PlanDate,SeriesName,OpenDate,LastDate,StockBackDate,TechDate,Remark,FillManID,FillManName,VerifyID,VerifyName,FillDate,VerifyDate,UpData,ProductName ");
            strSql.Append(" FROM Sample ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,StrNum,Num,Titlle,CompanyName,CompanyID,MaterielName,MaterielID,TypeName,PlanDate,SeriesName,OpenDate,LastDate,StockBackDate,TechDate,Remark,FillManID,FillManName,VerifyID,VerifyName,FillDate,VerifyDate,UpData,ProductName ");
            strSql.Append(" FROM Sample ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from Sample  order by ID ");
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
			parameters[0].Value = "Sample";
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

