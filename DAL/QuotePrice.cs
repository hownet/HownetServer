using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类QuotePrice。
    /// </summary>
    public class QuotePrice
    {
        public QuotePrice()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from QuotePrice");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.QuotePrice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into QuotePrice(");
            strSql.Append("CompanyID,MaterielID,Price,Remark,ColorTypeID,ColorID,Conversion,CompanyMeasureID,DepotMeasureID,DateTime,IsUse,LastAmount,DayMaxAmount,BackDay,CompanySn,MoneyType,BrandID,MTID)");
            strSql.Append(" values (");
            strSql.Append("@CompanyID,@MaterielID,@Price,@Remark,@ColorTypeID,@ColorID,@Conversion,@CompanyMeasureID,@DepotMeasureID,@DateTime,@IsUse,@LastAmount,@DayMaxAmount,@BackDay,@CompanySn,@MoneyType,@BrandID,@MTID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ColorTypeID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@Conversion", SqlDbType.Real,4),
					new SqlParameter("@CompanyMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepotMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@IsUse", SqlDbType.TinyInt,1),
					new SqlParameter("@LastAmount", SqlDbType.Real,4),
					new SqlParameter("@DayMaxAmount", SqlDbType.Real,4),
					new SqlParameter("@BackDay", SqlDbType.Int,4),
					new SqlParameter("@CompanySn", SqlDbType.NVarChar,255),
					new SqlParameter("@MoneyType", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MTID", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.Price;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.ColorTypeID;
            parameters[5].Value = model.ColorID;
            parameters[6].Value = model.Conversion;
            parameters[7].Value = model.CompanyMeasureID;
            parameters[8].Value = model.DepotMeasureID;
            parameters[9].Value = model.DateTime;
            parameters[10].Value = model.IsUse;
            parameters[11].Value = model.LastAmount;
            parameters[12].Value = model.DayMaxAmount;
            parameters[13].Value = model.BackDay;
            parameters[14].Value = model.CompanySn;
            parameters[15].Value = model.MoneyType;
            parameters[16].Value = model.BrandID;
            parameters[17].Value = model.MTID;

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
        public void Update(Hownet.Model.QuotePrice model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update QuotePrice set ");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("Price=@Price,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("ColorTypeID=@ColorTypeID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("Conversion=@Conversion,");
            strSql.Append("CompanyMeasureID=@CompanyMeasureID,");
            strSql.Append("DepotMeasureID=@DepotMeasureID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("LastAmount=@LastAmount,");
            strSql.Append("DayMaxAmount=@DayMaxAmount,");
            strSql.Append("BackDay=@BackDay,");
            strSql.Append("CompanySn=@CompanySn,");
            strSql.Append("MoneyType=@MoneyType,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("MTID=@MTID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@ColorTypeID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@Conversion", SqlDbType.Real,4),
					new SqlParameter("@CompanyMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepotMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@IsUse", SqlDbType.TinyInt,1),
					new SqlParameter("@LastAmount", SqlDbType.Real,4),
					new SqlParameter("@DayMaxAmount", SqlDbType.Real,4),
					new SqlParameter("@BackDay", SqlDbType.Int,4),
					new SqlParameter("@CompanySn", SqlDbType.NVarChar,255),
					new SqlParameter("@MoneyType", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MTID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.CompanyID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.Price;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.ColorTypeID;
            parameters[6].Value = model.ColorID;
            parameters[7].Value = model.Conversion;
            parameters[8].Value = model.CompanyMeasureID;
            parameters[9].Value = model.DepotMeasureID;
            parameters[10].Value = model.DateTime;
            parameters[11].Value = model.IsUse;
            parameters[12].Value = model.LastAmount;
            parameters[13].Value = model.DayMaxAmount;
            parameters[14].Value = model.BackDay;
            parameters[15].Value = model.CompanySn;
            parameters[16].Value = model.MoneyType;
            parameters[17].Value = model.BrandID;
            parameters[18].Value = model.MTID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from QuotePrice ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.QuotePrice GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CompanyID,MaterielID,Price,Remark,ColorTypeID,ColorID,Conversion,CompanyMeasureID,DepotMeasureID,DateTime,IsUse,LastAmount,DayMaxAmount,BackDay,CompanySn,MoneyType,BrandID,MTID from QuotePrice ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.QuotePrice model = new Hownet.Model.QuotePrice();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["ColorTypeID"].ToString() != "")
                {
                    model.ColorTypeID = int.Parse(ds.Tables[0].Rows[0]["ColorTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Conversion"].ToString() != "")
                {
                    model.Conversion = decimal.Parse(ds.Tables[0].Rows[0]["Conversion"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyMeasureID"].ToString() != "")
                {
                    model.CompanyMeasureID = int.Parse(ds.Tables[0].Rows[0]["CompanyMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotMeasureID"].ToString() != "")
                {
                    model.DepotMeasureID = int.Parse(ds.Tables[0].Rows[0]["DepotMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsUse"].ToString() != "")
                {
                    model.IsUse = int.Parse(ds.Tables[0].Rows[0]["IsUse"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastAmount"].ToString() != "")
                {
                    model.LastAmount = decimal.Parse(ds.Tables[0].Rows[0]["LastAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DayMaxAmount"].ToString() != "")
                {
                    model.DayMaxAmount = decimal.Parse(ds.Tables[0].Rows[0]["DayMaxAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackDay"].ToString() != "")
                {
                    model.BackDay = int.Parse(ds.Tables[0].Rows[0]["BackDay"].ToString());
                }
                model.CompanySn = ds.Tables[0].Rows[0]["CompanySn"].ToString();
                if (ds.Tables[0].Rows[0]["MoneyType"].ToString() != "")
                {
                    model.MoneyType = int.Parse(ds.Tables[0].Rows[0]["MoneyType"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MTID"].ToString() != "")
                {
                    model.MTID = int.Parse(ds.Tables[0].Rows[0]["MTID"].ToString());
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
            strSql.Append("select 1 as A,ID,CompanyID,MaterielID,Price,Remark,ColorTypeID,ColorID,Conversion,CompanyMeasureID,DepotMeasureID,DateTime,IsUse,LastAmount,DayMaxAmount,BackDay,CompanySn,MoneyType,BrandID,MTID ");
            strSql.Append(" FROM QuotePrice ");
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
            strSql.Append(" ID,CompanyID,MaterielID,Price,Remark,ColorTypeID,ColorID,Conversion,CompanyMeasureID,DepotMeasureID,DateTime,IsUse,LastAmount,DayMaxAmount,BackDay,CompanySn,MoneyType,BrandID,MTID ");
            strSql.Append(" FROM QuotePrice ");
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
            parameters[0].Value = "QuotePrice";
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

