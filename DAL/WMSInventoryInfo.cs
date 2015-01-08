using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类WMSInventoryInfo。
	/// </summary>
	public class WMSInventoryInfo
	{
		public WMSInventoryInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "WMSInventoryInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WMSInventoryInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.WMSInventoryInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into WMSInventoryInfo(");
            strSql.Append("MainID,MaterielID,BrandID,ColorID,ColorOneID,ColorTwoID,SizeID,MeasureID,PreviousNumber,NowAmount,ChangeAmount,Remark,CompanyID,MListID,RepertoryID)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@MaterielID,@BrandID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@MeasureID,@PreviousNumber,@NowAmount,@ChangeAmount,@Remark,@CompanyID,@MListID,@RepertoryID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@PreviousNumber", SqlDbType.Decimal,9),
					new SqlParameter("@NowAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@RepertoryID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.BrandID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.ColorOneID;
            parameters[5].Value = model.ColorTwoID;
            parameters[6].Value = model.SizeID;
            parameters[7].Value = model.MeasureID;
            parameters[8].Value = model.PreviousNumber;
            parameters[9].Value = model.NowAmount;
            parameters[10].Value = model.ChangeAmount;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.CompanyID;
            parameters[13].Value = model.MListID;
            parameters[14].Value = model.RepertoryID;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
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
        public void Update(Hownet.Model.WMSInventoryInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update WMSInventoryInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("PreviousNumber=@PreviousNumber,");
            strSql.Append("NowAmount=@NowAmount,");
            strSql.Append("ChangeAmount=@ChangeAmount,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("RepertoryID=@RepertoryID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@PreviousNumber", SqlDbType.Decimal,9),
					new SqlParameter("@NowAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ChangeAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@RepertoryID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.BrandID;
            parameters[4].Value = model.ColorID;
            parameters[5].Value = model.ColorOneID;
            parameters[6].Value = model.ColorTwoID;
            parameters[7].Value = model.SizeID;
            parameters[8].Value = model.MeasureID;
            parameters[9].Value = model.PreviousNumber;
            parameters[10].Value = model.NowAmount;
            parameters[11].Value = model.ChangeAmount;
            parameters[12].Value = model.Remark;
            parameters[13].Value = model.CompanyID;
            parameters[14].Value = model.MListID;
            parameters[15].Value = model.RepertoryID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from WMSInventoryInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.WMSInventoryInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,MaterielID,BrandID,ColorID,ColorOneID,ColorTwoID,SizeID,MeasureID,PreviousNumber,NowAmount,ChangeAmount,Remark,CompanyID,MListID,RepertoryID from WMSInventoryInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.WMSInventoryInfo model = new Hownet.Model.WMSInventoryInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PreviousNumber"].ToString() != "")
                {
                    model.PreviousNumber = decimal.Parse(ds.Tables[0].Rows[0]["PreviousNumber"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowAmount"].ToString() != "")
                {
                    model.NowAmount = decimal.Parse(ds.Tables[0].Rows[0]["NowAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ChangeAmount"].ToString() != "")
                {
                    model.ChangeAmount = decimal.Parse(ds.Tables[0].Rows[0]["ChangeAmount"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RepertoryID"].ToString() != "")
                {
                    model.RepertoryID = int.Parse(ds.Tables[0].Rows[0]["RepertoryID"].ToString());
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
            strSql.Append("select 1 as A,ID,MainID,MaterielID,BrandID,ColorID,ColorOneID,ColorTwoID,SizeID,MeasureID,PreviousNumber,NowAmount,ChangeAmount,Remark,CompanyID,MListID,RepertoryID ");
            strSql.Append(" FROM WMSInventoryInfo ");
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
            strSql.Append(" ID,MainID,MaterielID,BrandID,ColorID,ColorOneID,ColorTwoID,SizeID,MeasureID,PreviousNumber,NowAmount,ChangeAmount,Remark,CompanyID,MListID,RepertoryID ");
            strSql.Append(" FROM WMSInventoryInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
			parameters[0].Value = "WMSInventoryInfo";
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

