/**  版本信息模板在安装目录下，可自行修改。
* SampleColorAmount.cs
*
* 功 能： N/A
* 类 名： SampleColorAmount
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
	/// 数据访问类:SampleColorAmount
	/// </summary>
	public partial class SampleColorAmount
	{
		public SampleColorAmount()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SampleColorAmount"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SampleColorAmount");
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
		public int Add(Hownet.Model.SampleColorAmount model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SampleColorAmount(");
            strSql.Append("MainID,ColorID,ColorName,PantoneName,CupName,Size1ID,Size1Name,Size1Amount,Size2ID,Size2Name,Size2Amount,Size3ID,Size3Name,Size3Amount,Size4ID,Size4Name,Size4Amount,Size5ID,Size5Name,Size5Amount,Size6ID,Size6Name,Size6Amount,Size7ID,Size7Name,Size7Amount,Size8ID,Size8Name,Size8Amount,Amount)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@ColorID,@ColorName,@PantoneName,@CupName,@Size1ID,@Size1Name,@Size1Amount,@Size2ID,@Size2Name,@Size2Amount,@Size3ID,@Size3Name,@Size3Amount,@Size4ID,@Size4Name,@Size4Amount,@Size5ID,@Size5Name,@Size5Amount,@Size6ID,@Size6Name,@Size6Amount,@Size7ID,@Size7Name,@Size7Amount,@Size8ID,@Size8Name,@Size8Amount,@Amount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@PantoneName", SqlDbType.NVarChar,50),
					new SqlParameter("@CupName", SqlDbType.NVarChar,10),
					new SqlParameter("@Size1ID", SqlDbType.Int,4),
					new SqlParameter("@Size1Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size1Amount", SqlDbType.Int,4),
					new SqlParameter("@Size2ID", SqlDbType.Int,4),
					new SqlParameter("@Size2Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size2Amount", SqlDbType.Int,4),
					new SqlParameter("@Size3ID", SqlDbType.Int,4),
					new SqlParameter("@Size3Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size3Amount", SqlDbType.Int,4),
					new SqlParameter("@Size4ID", SqlDbType.Int,4),
					new SqlParameter("@Size4Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size4Amount", SqlDbType.Int,4),
					new SqlParameter("@Size5ID", SqlDbType.Int,4),
					new SqlParameter("@Size5Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size5Amount", SqlDbType.Int,4),
					new SqlParameter("@Size6ID", SqlDbType.Int,4),
					new SqlParameter("@Size6Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size6Amount", SqlDbType.Int,4),
					new SqlParameter("@Size7ID", SqlDbType.Int,4),
					new SqlParameter("@Size7Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size7Amount", SqlDbType.Int,4),
					new SqlParameter("@Size8ID", SqlDbType.Int,4),
					new SqlParameter("@Size8Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size8Amount", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorName;
            parameters[3].Value = model.PantoneName;
            parameters[4].Value = model.CupName;
            parameters[5].Value = model.Size1ID;
            parameters[6].Value = model.Size1Name;
            parameters[7].Value = model.Size1Amount;
            parameters[8].Value = model.Size2ID;
            parameters[9].Value = model.Size2Name;
            parameters[10].Value = model.Size2Amount;
            parameters[11].Value = model.Size3ID;
            parameters[12].Value = model.Size3Name;
            parameters[13].Value = model.Size3Amount;
            parameters[14].Value = model.Size4ID;
            parameters[15].Value = model.Size4Name;
            parameters[16].Value = model.Size4Amount;
            parameters[17].Value = model.Size5ID;
            parameters[18].Value = model.Size5Name;
            parameters[19].Value = model.Size5Amount;
            parameters[20].Value = model.Size6ID;
            parameters[21].Value = model.Size6Name;
            parameters[22].Value = model.Size6Amount;
            parameters[23].Value = model.Size7ID;
            parameters[24].Value = model.Size7Name;
            parameters[25].Value = model.Size7Amount;
            parameters[26].Value = model.Size8ID;
            parameters[27].Value = model.Size8Name;
            parameters[28].Value = model.Size8Amount;
            parameters[29].Value = model.Amount;

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
        public bool Update(Hownet.Model.SampleColorAmount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SampleColorAmount set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorName=@ColorName,");
            strSql.Append("PantoneName=@PantoneName,");
            strSql.Append("CupName=@CupName,");
            strSql.Append("Size1ID=@Size1ID,");
            strSql.Append("Size1Name=@Size1Name,");
            strSql.Append("Size1Amount=@Size1Amount,");
            strSql.Append("Size2ID=@Size2ID,");
            strSql.Append("Size2Name=@Size2Name,");
            strSql.Append("Size2Amount=@Size2Amount,");
            strSql.Append("Size3ID=@Size3ID,");
            strSql.Append("Size3Name=@Size3Name,");
            strSql.Append("Size3Amount=@Size3Amount,");
            strSql.Append("Size4ID=@Size4ID,");
            strSql.Append("Size4Name=@Size4Name,");
            strSql.Append("Size4Amount=@Size4Amount,");
            strSql.Append("Size5ID=@Size5ID,");
            strSql.Append("Size5Name=@Size5Name,");
            strSql.Append("Size5Amount=@Size5Amount,");
            strSql.Append("Size6ID=@Size6ID,");
            strSql.Append("Size6Name=@Size6Name,");
            strSql.Append("Size6Amount=@Size6Amount,");
            strSql.Append("Size7ID=@Size7ID,");
            strSql.Append("Size7Name=@Size7Name,");
            strSql.Append("Size7Amount=@Size7Amount,");
            strSql.Append("Size8ID=@Size8ID,");
            strSql.Append("Size8Name=@Size8Name,");
            strSql.Append("Size8Amount=@Size8Amount,");
            strSql.Append("Amount=@Amount");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@PantoneName", SqlDbType.NVarChar,50),
					new SqlParameter("@CupName", SqlDbType.NVarChar,10),
					new SqlParameter("@Size1ID", SqlDbType.Int,4),
					new SqlParameter("@Size1Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size1Amount", SqlDbType.Int,4),
					new SqlParameter("@Size2ID", SqlDbType.Int,4),
					new SqlParameter("@Size2Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size2Amount", SqlDbType.Int,4),
					new SqlParameter("@Size3ID", SqlDbType.Int,4),
					new SqlParameter("@Size3Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size3Amount", SqlDbType.Int,4),
					new SqlParameter("@Size4ID", SqlDbType.Int,4),
					new SqlParameter("@Size4Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size4Amount", SqlDbType.Int,4),
					new SqlParameter("@Size5ID", SqlDbType.Int,4),
					new SqlParameter("@Size5Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size5Amount", SqlDbType.Int,4),
					new SqlParameter("@Size6ID", SqlDbType.Int,4),
					new SqlParameter("@Size6Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size6Amount", SqlDbType.Int,4),
					new SqlParameter("@Size7ID", SqlDbType.Int,4),
					new SqlParameter("@Size7Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size7Amount", SqlDbType.Int,4),
					new SqlParameter("@Size8ID", SqlDbType.Int,4),
					new SqlParameter("@Size8Name", SqlDbType.NVarChar,10),
					new SqlParameter("@Size8Amount", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorName;
            parameters[3].Value = model.PantoneName;
            parameters[4].Value = model.CupName;
            parameters[5].Value = model.Size1ID;
            parameters[6].Value = model.Size1Name;
            parameters[7].Value = model.Size1Amount;
            parameters[8].Value = model.Size2ID;
            parameters[9].Value = model.Size2Name;
            parameters[10].Value = model.Size2Amount;
            parameters[11].Value = model.Size3ID;
            parameters[12].Value = model.Size3Name;
            parameters[13].Value = model.Size3Amount;
            parameters[14].Value = model.Size4ID;
            parameters[15].Value = model.Size4Name;
            parameters[16].Value = model.Size4Amount;
            parameters[17].Value = model.Size5ID;
            parameters[18].Value = model.Size5Name;
            parameters[19].Value = model.Size5Amount;
            parameters[20].Value = model.Size6ID;
            parameters[21].Value = model.Size6Name;
            parameters[22].Value = model.Size6Amount;
            parameters[23].Value = model.Size7ID;
            parameters[24].Value = model.Size7Name;
            parameters[25].Value = model.Size7Amount;
            parameters[26].Value = model.Size8ID;
            parameters[27].Value = model.Size8Name;
            parameters[28].Value = model.Size8Amount;
            parameters[29].Value = model.Amount;
            parameters[30].Value = model.ID;

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
            strSql.Append("delete from SampleColorAmount ");
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
            strSql.Append("delete from SampleColorAmount ");
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
        public Hownet.Model.SampleColorAmount GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,ColorID,ColorName,PantoneName,CupName,Size1ID,Size1Name,Size1Amount,Size2ID,Size2Name,Size2Amount,Size3ID,Size3Name,Size3Amount,Size4ID,Size4Name,Size4Amount,Size5ID,Size5Name,Size5Amount,Size6ID,Size6Name,Size6Amount,Size7ID,Size7Name,Size7Amount,Size8ID,Size8Name,Size8Amount,Amount from SampleColorAmount ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.SampleColorAmount model = new Hownet.Model.SampleColorAmount();
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
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                model.ColorName = ds.Tables[0].Rows[0]["ColorName"].ToString();
                model.PantoneName = ds.Tables[0].Rows[0]["PantoneName"].ToString();
                model.CupName = ds.Tables[0].Rows[0]["CupName"].ToString();
                if (ds.Tables[0].Rows[0]["Size1ID"] != null && ds.Tables[0].Rows[0]["Size1ID"].ToString() != "")
                {
                    model.Size1ID = int.Parse(ds.Tables[0].Rows[0]["Size1ID"].ToString());
                }
                model.Size1Name = ds.Tables[0].Rows[0]["Size1Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size1Amount"] != null && ds.Tables[0].Rows[0]["Size1Amount"].ToString() != "")
                {
                    model.Size1Amount = int.Parse(ds.Tables[0].Rows[0]["Size1Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Size2ID"] != null && ds.Tables[0].Rows[0]["Size2ID"].ToString() != "")
                {
                    model.Size2ID = int.Parse(ds.Tables[0].Rows[0]["Size2ID"].ToString());
                }
                model.Size2Name = ds.Tables[0].Rows[0]["Size2Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size2Amount"] != null && ds.Tables[0].Rows[0]["Size2Amount"].ToString() != "")
                {
                    model.Size2Amount = int.Parse(ds.Tables[0].Rows[0]["Size2Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Size3ID"] != null && ds.Tables[0].Rows[0]["Size3ID"].ToString() != "")
                {
                    model.Size3ID = int.Parse(ds.Tables[0].Rows[0]["Size3ID"].ToString());
                }
                model.Size3Name = ds.Tables[0].Rows[0]["Size3Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size3Amount"] != null && ds.Tables[0].Rows[0]["Size3Amount"].ToString() != "")
                {
                    model.Size3Amount = int.Parse(ds.Tables[0].Rows[0]["Size3Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Size4ID"] != null && ds.Tables[0].Rows[0]["Size4ID"].ToString() != "")
                {
                    model.Size4ID = int.Parse(ds.Tables[0].Rows[0]["Size4ID"].ToString());
                }
                model.Size4Name = ds.Tables[0].Rows[0]["Size4Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size4Amount"] != null && ds.Tables[0].Rows[0]["Size4Amount"].ToString() != "")
                {
                    model.Size4Amount = int.Parse(ds.Tables[0].Rows[0]["Size4Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Size5ID"] != null && ds.Tables[0].Rows[0]["Size5ID"].ToString() != "")
                {
                    model.Size5ID = int.Parse(ds.Tables[0].Rows[0]["Size5ID"].ToString());
                }
                model.Size5Name = ds.Tables[0].Rows[0]["Size5Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size5Amount"] != null && ds.Tables[0].Rows[0]["Size5Amount"].ToString() != "")
                {
                    model.Size5Amount = int.Parse(ds.Tables[0].Rows[0]["Size5Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Size6ID"] != null && ds.Tables[0].Rows[0]["Size6ID"].ToString() != "")
                {
                    model.Size6ID = int.Parse(ds.Tables[0].Rows[0]["Size6ID"].ToString());
                }
                model.Size6Name = ds.Tables[0].Rows[0]["Size6Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size6Amount"] != null && ds.Tables[0].Rows[0]["Size6Amount"].ToString() != "")
                {
                    model.Size6Amount = int.Parse(ds.Tables[0].Rows[0]["Size6Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Size7ID"] != null && ds.Tables[0].Rows[0]["Size7ID"].ToString() != "")
                {
                    model.Size7ID = int.Parse(ds.Tables[0].Rows[0]["Size7ID"].ToString());
                }
                model.Size7Name = ds.Tables[0].Rows[0]["Size7Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size7Amount"] != null && ds.Tables[0].Rows[0]["Size7Amount"].ToString() != "")
                {
                    model.Size7Amount = int.Parse(ds.Tables[0].Rows[0]["Size7Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Size8ID"] != null && ds.Tables[0].Rows[0]["Size8ID"].ToString() != "")
                {
                    model.Size8ID = int.Parse(ds.Tables[0].Rows[0]["Size8ID"].ToString());
                }
                model.Size8Name = ds.Tables[0].Rows[0]["Size8Name"].ToString();
                if (ds.Tables[0].Rows[0]["Size8Amount"] != null && ds.Tables[0].Rows[0]["Size8Amount"].ToString() != "")
                {
                    model.Size8Amount = int.Parse(ds.Tables[0].Rows[0]["Size8Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
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
            strSql.Append("select  1 as A,ID,MainID,ColorID,ColorName,PantoneName,CupName,Size1ID,Size1Name,Size1Amount,Size2ID,Size2Name,Size2Amount,Size3ID,Size3Name,Size3Amount,Size4ID,Size4Name,Size4Amount,Size5ID,Size5Name,Size5Amount,Size6ID,Size6Name,Size6Amount,Size7ID,Size7Name,Size7Amount,Size8ID,Size8Name,Size8Amount,Amount ");
            strSql.Append(" FROM SampleColorAmount ");
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
            strSql.Append(" ID,MainID,ColorID,ColorName,PantoneName,CupName,Size1ID,Size1Name,Size1Amount,Size2ID,Size2Name,Size2Amount,Size3ID,Size3Name,Size3Amount,Size4ID,Size4Name,Size4Amount,Size5ID,Size5Name,Size5Amount,Size6ID,Size6Name,Size6Amount,Size7ID,Size7Name,Size7Amount,Size8ID,Size8Name,Size8Amount,Amount ");
            strSql.Append(" FROM SampleColorAmount ");
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
            strSql.Append("delete from SampleColorAmount ");
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
			parameters[0].Value = "SampleColorAmount";
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

