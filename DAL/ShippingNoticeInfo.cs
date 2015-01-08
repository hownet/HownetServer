using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类ShippingNoticeInfo。
    /// </summary>
    public class ShippingNoticeInfo
    {
        public ShippingNoticeInfo()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ShippingNoticeInfo");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ShippingNoticeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ShippingNoticeInfo(");
            strSql.Append("MainID,CompanyID,MaterielID,BrandID,Amount,MeasureID,OnePackaging,TwoPackaging,LastTime,Remark)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@CompanyID,@MaterielID,@BrandID,@Amount,@MeasureID,@OnePackaging,@TwoPackaging,@LastTime,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@OnePackaging", SqlDbType.NVarChar,500),
					new SqlParameter("@TwoPackaging", SqlDbType.NVarChar,500),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.CompanyID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.BrandID;
            parameters[4].Value = model.Amount;
            parameters[5].Value = model.MeasureID;
            parameters[6].Value = model.OnePackaging;
            parameters[7].Value = model.TwoPackaging;
            parameters[8].Value = model.LastTime;
            parameters[9].Value = model.Remark;

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
        public void Update(Hownet.Model.ShippingNoticeInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ShippingNoticeInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("OnePackaging=@OnePackaging,");
            strSql.Append("TwoPackaging=@TwoPackaging,");
            strSql.Append("LastTime=@LastTime,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@OnePackaging", SqlDbType.NVarChar,500),
					new SqlParameter("@TwoPackaging", SqlDbType.NVarChar,500),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.CompanyID;
            parameters[3].Value = model.MaterielID;
            parameters[4].Value = model.BrandID;
            parameters[5].Value = model.Amount;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.OnePackaging;
            parameters[8].Value = model.TwoPackaging;
            parameters[9].Value = model.LastTime;
            parameters[10].Value = model.Remark;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ShippingNoticeInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.ShippingNoticeInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,CompanyID,MaterielID,BrandID,Amount,MeasureID,OnePackaging,TwoPackaging,LastTime,Remark from ShippingNoticeInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.ShippingNoticeInfo model = new Hownet.Model.ShippingNoticeInfo();
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
                if (ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                model.OnePackaging = ds.Tables[0].Rows[0]["OnePackaging"].ToString();
                model.TwoPackaging = ds.Tables[0].Rows[0]["TwoPackaging"].ToString();
                if (ds.Tables[0].Rows[0]["LastTime"].ToString() != "")
                {
                    model.LastTime = DateTime.Parse(ds.Tables[0].Rows[0]["LastTime"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
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
            strSql.Append("select 1 as A,ID,MainID,CompanyID,MaterielID,BrandID,Amount,MeasureID,OnePackaging,TwoPackaging,LastTime,Remark ");
            strSql.Append(" FROM ShippingNoticeInfo ");
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
            strSql.Append(" ID,MainID,CompanyID,MaterielID,BrandID,Amount,MeasureID,OnePackaging,TwoPackaging,LastTime,Remark ");
            strSql.Append(" FROM ShippingNoticeInfo ");
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
            parameters[0].Value = "ShippingNoticeInfo";
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

