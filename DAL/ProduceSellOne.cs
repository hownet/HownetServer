using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类ProduceSellOne。
	/// </summary>
	public class ProduceSellOne
	{
		public ProduceSellOne()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ProduceSellOne"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProduceSellOne");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ProduceSellOne model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ProduceSellOne(");
            strSql.Append("MaterielID,Price,Amount,Money,Remark,MainID,MeasureID,BoxMeasureID,Conversion,BoxMeasureAmount,BrandID,SalesOrderInfoID,RemarkID,MTID,SellRemark,CompanyMaterielName)");
            strSql.Append(" values (");
            strSql.Append("@MaterielID,@Price,@Amount,@Money,@Remark,@MainID,@MeasureID,@BoxMeasureID,@Conversion,@BoxMeasureAmount,@BrandID,@SalesOrderInfoID,@RemarkID,@MTID,@SellRemark,@CompanyMaterielName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Real,4),
					new SqlParameter("@Amount", SqlDbType.Real,4),
					new SqlParameter("@Money", SqlDbType.Real,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@BoxMeasureID", SqlDbType.Int,4),
					new SqlParameter("@Conversion", SqlDbType.Int,4),
					new SqlParameter("@BoxMeasureAmount", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@SalesOrderInfoID", SqlDbType.Int,4),
					new SqlParameter("@RemarkID", SqlDbType.Int,4),
					new SqlParameter("@MTID", SqlDbType.Int,4),
					new SqlParameter("@SellRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@CompanyMaterielName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.MaterielID;
            parameters[1].Value = model.Price;
            parameters[2].Value = model.Amount;
            parameters[3].Value = model.Money;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.MainID;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.BoxMeasureID;
            parameters[8].Value = model.Conversion;
            parameters[9].Value = model.BoxMeasureAmount;
            parameters[10].Value = model.BrandID;
            parameters[11].Value = model.SalesOrderInfoID;
            parameters[12].Value = model.RemarkID;
            parameters[13].Value = model.MTID;
            parameters[14].Value = model.SellRemark;
            parameters[15].Value = model.CompanyMaterielName;

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
        public bool Update(Hownet.Model.ProduceSellOne model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProduceSellOne set ");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("Price=@Price,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Money=@Money,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("MainID=@MainID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("BoxMeasureID=@BoxMeasureID,");
            strSql.Append("Conversion=@Conversion,");
            strSql.Append("BoxMeasureAmount=@BoxMeasureAmount,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("SalesOrderInfoID=@SalesOrderInfoID,");
            strSql.Append("RemarkID=@RemarkID,");
            strSql.Append("MTID=@MTID,");
            strSql.Append("SellRemark=@SellRemark,");
            strSql.Append("CompanyMaterielName=@CompanyMaterielName");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Real,4),
					new SqlParameter("@Amount", SqlDbType.Real,4),
					new SqlParameter("@Money", SqlDbType.Real,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@BoxMeasureID", SqlDbType.Int,4),
					new SqlParameter("@Conversion", SqlDbType.Int,4),
					new SqlParameter("@BoxMeasureAmount", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@SalesOrderInfoID", SqlDbType.Int,4),
					new SqlParameter("@RemarkID", SqlDbType.Int,4),
					new SqlParameter("@MTID", SqlDbType.Int,4),
					new SqlParameter("@SellRemark", SqlDbType.NVarChar,4000),
					new SqlParameter("@CompanyMaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MaterielID;
            parameters[1].Value = model.Price;
            parameters[2].Value = model.Amount;
            parameters[3].Value = model.Money;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.MainID;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.BoxMeasureID;
            parameters[8].Value = model.Conversion;
            parameters[9].Value = model.BoxMeasureAmount;
            parameters[10].Value = model.BrandID;
            parameters[11].Value = model.SalesOrderInfoID;
            parameters[12].Value = model.RemarkID;
            parameters[13].Value = model.MTID;
            parameters[14].Value = model.SellRemark;
            parameters[15].Value = model.CompanyMaterielName;
            parameters[16].Value = model.ID;

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
            strSql.Append("delete from ProduceSellOne ");
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
            strSql.Append("delete from ProduceSellOne ");
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
        public Hownet.Model.ProduceSellOne GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MaterielID,Price,Amount,Money,Remark,MainID,MeasureID,BoxMeasureID,Conversion,BoxMeasureAmount,BrandID,SalesOrderInfoID,RemarkID,MTID,SellRemark,CompanyMaterielName from ProduceSellOne ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.ProduceSellOne model = new Hownet.Model.ProduceSellOne();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BoxMeasureID"] != null && ds.Tables[0].Rows[0]["BoxMeasureID"].ToString() != "")
                {
                    model.BoxMeasureID = int.Parse(ds.Tables[0].Rows[0]["BoxMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Conversion"] != null && ds.Tables[0].Rows[0]["Conversion"].ToString() != "")
                {
                    model.Conversion = int.Parse(ds.Tables[0].Rows[0]["Conversion"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BoxMeasureAmount"] != null && ds.Tables[0].Rows[0]["BoxMeasureAmount"].ToString() != "")
                {
                    model.BoxMeasureAmount = int.Parse(ds.Tables[0].Rows[0]["BoxMeasureAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SalesOrderInfoID"] != null && ds.Tables[0].Rows[0]["SalesOrderInfoID"].ToString() != "")
                {
                    model.SalesOrderInfoID = int.Parse(ds.Tables[0].Rows[0]["SalesOrderInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RemarkID"] != null && ds.Tables[0].Rows[0]["RemarkID"].ToString() != "")
                {
                    model.RemarkID = int.Parse(ds.Tables[0].Rows[0]["RemarkID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MTID"] != null && ds.Tables[0].Rows[0]["MTID"].ToString() != "")
                {
                    model.MTID = int.Parse(ds.Tables[0].Rows[0]["MTID"].ToString());
                }
                model.SellRemark = ds.Tables[0].Rows[0]["SellRemark"].ToString();
                model.CompanyMaterielName = ds.Tables[0].Rows[0]["CompanyMaterielName"].ToString();
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
            strSql.Append("select row_number() over (order by ID) as RowID,  1 as A,ID,MaterielID,Price,Amount,Money,Remark,MainID,MeasureID,BoxMeasureID,Conversion,BoxMeasureAmount,BrandID,SalesOrderInfoID,RemarkID,MTID,SellRemark,CompanyMaterielName ");
            strSql.Append(" FROM ProduceSellOne ");
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
            strSql.Append(" ID,MaterielID,Price,Amount,Money,Remark,MainID,MeasureID,BoxMeasureID,Conversion,BoxMeasureAmount,BrandID,SalesOrderInfoID,RemarkID,MTID,SellRemark,CompanyMaterielName ");
            strSql.Append(" FROM ProduceSellOne ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public void DeleteByMain(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProduceSellOne ");
            strSql.Append(" where MainID=@MainID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 某客户订单的发货记录
        /// </summary>
        /// <param name="SalesID"></param>
        /// <returns></returns>
        public int CountSellSales(int SalesID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(ID) AS Expr1 FROM      ProduceSellOne WHERE   (SalesOrderInfoID = @SaleID)");
            SqlParameter[] sps = {new SqlParameter("@SaleID",SalesID) };
            return int.Parse(DbHelperSQL.GetSingle(strSql.ToString(), sps).ToString());
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
			parameters[0].Value = "ProduceSellOne";
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

