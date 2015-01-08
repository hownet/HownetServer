/**  版本信息模板在安装目录下，可自行修改。
* SampleMaterielList.cs
*
* 功 能： N/A
* 类 名： SampleMaterielList
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/1 14:41:31   N/A    初版
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
	/// 数据访问类:SampleMaterielList
	/// </summary>
	public partial class SampleMaterielList
	{
		public SampleMaterielList()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SampleMaterielList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SampleMaterielList");
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
		public int Add(Hownet.Model.SampleMaterielList model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SampleMaterielList(");
            strSql.Append("MainID,MaterielID,MaterielName,CaiPianID,CaiPianName,SpecID,SpecName,Weight,CompanyID,CompanyName,Color1ID,Color1Name,Color2ID,Color2Name,Color3ID,Color3Name,Color4ID,Color4Name,Color5ID,Color5Name,Color6ID,Color6Name,Color7ID,Color7Name,Color8ID,Color8Name,MeasureID,Measurename)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@MaterielID,@MaterielName,@CaiPianID,@CaiPianName,@SpecID,@SpecName,@Weight,@CompanyID,@CompanyName,@Color1ID,@Color1Name,@Color2ID,@Color2Name,@Color3ID,@Color3Name,@Color4ID,@Color4Name,@Color5ID,@Color5Name,@Color6ID,@Color6Name,@Color7ID,@Color7Name,@Color8ID,@Color8Name,@MeasureID,@Measurename)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@CaiPianID", SqlDbType.Int,4),
					new SqlParameter("@CaiPianName", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@Weight", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@Color1ID", SqlDbType.Int,4),
					new SqlParameter("@Color1Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color2ID", SqlDbType.Int,4),
					new SqlParameter("@Color2Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color3ID", SqlDbType.Int,4),
					new SqlParameter("@Color3Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color4ID", SqlDbType.Int,4),
					new SqlParameter("@Color4Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color5ID", SqlDbType.Int,4),
					new SqlParameter("@Color5Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color6ID", SqlDbType.Int,4),
					new SqlParameter("@Color6Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color7ID", SqlDbType.Int,4),
					new SqlParameter("@Color7Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color8ID", SqlDbType.Int,4),
					new SqlParameter("@Color8Name", SqlDbType.NVarChar,10),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Measurename", SqlDbType.NVarChar,10)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.MaterielName;
            parameters[3].Value = model.CaiPianID;
            parameters[4].Value = model.CaiPianName;
            parameters[5].Value = model.SpecID;
            parameters[6].Value = model.SpecName;
            parameters[7].Value = model.Weight;
            parameters[8].Value = model.CompanyID;
            parameters[9].Value = model.CompanyName;
            parameters[10].Value = model.Color1ID;
            parameters[11].Value = model.Color1Name;
            parameters[12].Value = model.Color2ID;
            parameters[13].Value = model.Color2Name;
            parameters[14].Value = model.Color3ID;
            parameters[15].Value = model.Color3Name;
            parameters[16].Value = model.Color4ID;
            parameters[17].Value = model.Color4Name;
            parameters[18].Value = model.Color5ID;
            parameters[19].Value = model.Color5Name;
            parameters[20].Value = model.Color6ID;
            parameters[21].Value = model.Color6Name;
            parameters[22].Value = model.Color7ID;
            parameters[23].Value = model.Color7Name;
            parameters[24].Value = model.Color8ID;
            parameters[25].Value = model.Color8Name;
            parameters[26].Value = model.MeasureID;
            parameters[27].Value = model.Measurename;

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
        public bool Update(Hownet.Model.SampleMaterielList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SampleMaterielList set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("MaterielName=@MaterielName,");
            strSql.Append("CaiPianID=@CaiPianID,");
            strSql.Append("CaiPianName=@CaiPianName,");
            strSql.Append("SpecID=@SpecID,");
            strSql.Append("SpecName=@SpecName,");
            strSql.Append("Weight=@Weight,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("Color1ID=@Color1ID,");
            strSql.Append("Color1Name=@Color1Name,");
            strSql.Append("Color2ID=@Color2ID,");
            strSql.Append("Color2Name=@Color2Name,");
            strSql.Append("Color3ID=@Color3ID,");
            strSql.Append("Color3Name=@Color3Name,");
            strSql.Append("Color4ID=@Color4ID,");
            strSql.Append("Color4Name=@Color4Name,");
            strSql.Append("Color5ID=@Color5ID,");
            strSql.Append("Color5Name=@Color5Name,");
            strSql.Append("Color6ID=@Color6ID,");
            strSql.Append("Color6Name=@Color6Name,");
            strSql.Append("Color7ID=@Color7ID,");
            strSql.Append("Color7Name=@Color7Name,");
            strSql.Append("Color8ID=@Color8ID,");
            strSql.Append("Color8Name=@Color8Name,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("Measurename=@Measurename");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@CaiPianID", SqlDbType.Int,4),
					new SqlParameter("@CaiPianName", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@Weight", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@Color1ID", SqlDbType.Int,4),
					new SqlParameter("@Color1Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color2ID", SqlDbType.Int,4),
					new SqlParameter("@Color2Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color3ID", SqlDbType.Int,4),
					new SqlParameter("@Color3Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color4ID", SqlDbType.Int,4),
					new SqlParameter("@Color4Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color5ID", SqlDbType.Int,4),
					new SqlParameter("@Color5Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color6ID", SqlDbType.Int,4),
					new SqlParameter("@Color6Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color7ID", SqlDbType.Int,4),
					new SqlParameter("@Color7Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Color8ID", SqlDbType.Int,4),
					new SqlParameter("@Color8Name", SqlDbType.NVarChar,10),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Measurename", SqlDbType.NVarChar,10),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.MaterielName;
            parameters[3].Value = model.CaiPianID;
            parameters[4].Value = model.CaiPianName;
            parameters[5].Value = model.SpecID;
            parameters[6].Value = model.SpecName;
            parameters[7].Value = model.Weight;
            parameters[8].Value = model.CompanyID;
            parameters[9].Value = model.CompanyName;
            parameters[10].Value = model.Color1ID;
            parameters[11].Value = model.Color1Name;
            parameters[12].Value = model.Color2ID;
            parameters[13].Value = model.Color2Name;
            parameters[14].Value = model.Color3ID;
            parameters[15].Value = model.Color3Name;
            parameters[16].Value = model.Color4ID;
            parameters[17].Value = model.Color4Name;
            parameters[18].Value = model.Color5ID;
            parameters[19].Value = model.Color5Name;
            parameters[20].Value = model.Color6ID;
            parameters[21].Value = model.Color6Name;
            parameters[22].Value = model.Color7ID;
            parameters[23].Value = model.Color7Name;
            parameters[24].Value = model.Color8ID;
            parameters[25].Value = model.Color8Name;
            parameters[26].Value = model.MeasureID;
            parameters[27].Value = model.Measurename;
            parameters[28].Value = model.ID;

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
            strSql.Append("delete from SampleMaterielList ");
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
            strSql.Append("delete from SampleMaterielList ");
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
        public Hownet.Model.SampleMaterielList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,MaterielID,MaterielName,CaiPianID,CaiPianName,SpecID,SpecName,Weight,CompanyID,CompanyName,Color1ID,Color1Name,Color2ID,Color2Name,Color3ID,Color3Name,Color4ID,Color4Name,Color5ID,Color5Name,Color6ID,Color6Name,Color7ID,Color7Name,Color8ID,Color8Name,MeasureID,Measurename from SampleMaterielList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.SampleMaterielList model = new Hownet.Model.SampleMaterielList();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                model.MaterielName = ds.Tables[0].Rows[0]["MaterielName"].ToString();
                if (ds.Tables[0].Rows[0]["CaiPianID"] != null && ds.Tables[0].Rows[0]["CaiPianID"].ToString() != "")
                {
                    model.CaiPianID = int.Parse(ds.Tables[0].Rows[0]["CaiPianID"].ToString());
                }
                model.CaiPianName = ds.Tables[0].Rows[0]["CaiPianName"].ToString();
                if (ds.Tables[0].Rows[0]["SpecID"] != null && ds.Tables[0].Rows[0]["SpecID"].ToString() != "")
                {
                    model.SpecID = int.Parse(ds.Tables[0].Rows[0]["SpecID"].ToString());
                }
                model.SpecName = ds.Tables[0].Rows[0]["SpecName"].ToString();
                model.Weight = ds.Tables[0].Rows[0]["Weight"].ToString();
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                model.CompanyName = ds.Tables[0].Rows[0]["CompanyName"].ToString();
                if (ds.Tables[0].Rows[0]["Color1ID"] != null && ds.Tables[0].Rows[0]["Color1ID"].ToString() != "")
                {
                    model.Color1ID = int.Parse(ds.Tables[0].Rows[0]["Color1ID"].ToString());
                }
                model.Color1Name = ds.Tables[0].Rows[0]["Color1Name"].ToString();
                if (ds.Tables[0].Rows[0]["Color2ID"] != null && ds.Tables[0].Rows[0]["Color2ID"].ToString() != "")
                {
                    model.Color2ID = int.Parse(ds.Tables[0].Rows[0]["Color2ID"].ToString());
                }
                model.Color2Name = ds.Tables[0].Rows[0]["Color2Name"].ToString();
                if (ds.Tables[0].Rows[0]["Color3ID"] != null && ds.Tables[0].Rows[0]["Color3ID"].ToString() != "")
                {
                    model.Color3ID = int.Parse(ds.Tables[0].Rows[0]["Color3ID"].ToString());
                }
                model.Color3Name = ds.Tables[0].Rows[0]["Color3Name"].ToString();
                if (ds.Tables[0].Rows[0]["Color4ID"] != null && ds.Tables[0].Rows[0]["Color4ID"].ToString() != "")
                {
                    model.Color4ID = int.Parse(ds.Tables[0].Rows[0]["Color4ID"].ToString());
                }
                model.Color4Name = ds.Tables[0].Rows[0]["Color4Name"].ToString();
                if (ds.Tables[0].Rows[0]["Color5ID"] != null && ds.Tables[0].Rows[0]["Color5ID"].ToString() != "")
                {
                    model.Color5ID = int.Parse(ds.Tables[0].Rows[0]["Color5ID"].ToString());
                }
                model.Color5Name = ds.Tables[0].Rows[0]["Color5Name"].ToString();
                if (ds.Tables[0].Rows[0]["Color6ID"] != null && ds.Tables[0].Rows[0]["Color6ID"].ToString() != "")
                {
                    model.Color6ID = int.Parse(ds.Tables[0].Rows[0]["Color6ID"].ToString());
                }
                model.Color6Name = ds.Tables[0].Rows[0]["Color6Name"].ToString();
                if (ds.Tables[0].Rows[0]["Color7ID"] != null && ds.Tables[0].Rows[0]["Color7ID"].ToString() != "")
                {
                    model.Color7ID = int.Parse(ds.Tables[0].Rows[0]["Color7ID"].ToString());
                }
                model.Color7Name = ds.Tables[0].Rows[0]["Color7Name"].ToString();
                if (ds.Tables[0].Rows[0]["Color8ID"] != null && ds.Tables[0].Rows[0]["Color8ID"].ToString() != "")
                {
                    model.Color8ID = int.Parse(ds.Tables[0].Rows[0]["Color8ID"].ToString());
                }
                model.Color8Name = ds.Tables[0].Rows[0]["Color8Name"].ToString();
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                model.Measurename = ds.Tables[0].Rows[0]["Measurename"].ToString();
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
            strSql.Append("select  1 as A,ID,MainID,MaterielID,MaterielName,CaiPianID,CaiPianName,SpecID,SpecName,Weight,CompanyID,CompanyName,Color1ID,Color1Name,Color2ID,Color2Name,Color3ID,Color3Name,Color4ID,Color4Name,Color5ID,Color5Name,Color6ID,Color6Name,Color7ID,Color7Name,Color8ID,Color8Name,MeasureID,Measurename ");
            strSql.Append(" FROM SampleMaterielList ");
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
            strSql.Append(" ID,MainID,MaterielID,MaterielName,CaiPianID,CaiPianName,SpecID,SpecName,Weight,CompanyID,CompanyName,Color1ID,Color1Name,Color2ID,Color2Name,Color3ID,Color3Name,Color4ID,Color4Name,Color5ID,Color5Name,Color6ID,Color6Name,Color7ID,Color7Name,Color8ID,Color8Name,MeasureID,Measurename ");
            strSql.Append(" FROM SampleMaterielList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public bool DeleteByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SampleMaterielList ");
            strSql.Append(" where MainID=@MainID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)
			};
            parameters[0].Value = MainID;

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
			parameters[0].Value = "SampleMaterielList";
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

