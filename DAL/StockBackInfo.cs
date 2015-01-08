using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类StockBackInfo。
	/// </summary>
	public class StockBackInfo
	{
		public StockBackInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "StockBackInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StockBackInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.StockBackInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockBackInfo(");
            strSql.Append("MainID,StockInfoID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Price,CompanyMeasureID,DepotMeasureID,Amount,Conversion,Remark,PriceAmount,NotAmount,Money,NotPriceAmount,MListID,CompanyID,BrandID,IsEnd,DemandID,NeedAmount,ExcessAmount,StringTaskID,LastTime,Weight,SpecID,MaterielName,ColorName,ColorOneName,ColorTwoName,SizeName,BrandName,SupplierID,SupplierName,SupplierSN,SpecName,CompanyMaterielName)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@StockInfoID,@MaterielID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@Price,@CompanyMeasureID,@DepotMeasureID,@Amount,@Conversion,@Remark,@PriceAmount,@NotAmount,@Money,@NotPriceAmount,@MListID,@CompanyID,@BrandID,@IsEnd,@DemandID,@NeedAmount,@ExcessAmount,@StringTaskID,@LastTime,@Weight,@SpecID,@MaterielName,@ColorName,@ColorOneName,@ColorTwoName,@SizeName,@BrandName,@SupplierID,@SupplierName,@SupplierSN,@SpecName,@CompanyMaterielName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@StockInfoID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@CompanyMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepotMeasureID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@Conversion", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@PriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@NotPriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@DemandID", SqlDbType.Int,4),
					new SqlParameter("@NeedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ExcessAmount", SqlDbType.Decimal,9),
					new SqlParameter("@StringTaskID", SqlDbType.NVarChar,200),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorOneName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorTwoName", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierID", SqlDbType.Int,4),
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierSN", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyMaterielName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.StockInfoID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.ColorOneID;
            parameters[5].Value = model.ColorTwoID;
            parameters[6].Value = model.SizeID;
            parameters[7].Value = model.Price;
            parameters[8].Value = model.CompanyMeasureID;
            parameters[9].Value = model.DepotMeasureID;
            parameters[10].Value = model.Amount;
            parameters[11].Value = model.Conversion;
            parameters[12].Value = model.Remark;
            parameters[13].Value = model.PriceAmount;
            parameters[14].Value = model.NotAmount;
            parameters[15].Value = model.Money;
            parameters[16].Value = model.NotPriceAmount;
            parameters[17].Value = model.MListID;
            parameters[18].Value = model.CompanyID;
            parameters[19].Value = model.BrandID;
            parameters[20].Value = model.IsEnd;
            parameters[21].Value = model.DemandID;
            parameters[22].Value = model.NeedAmount;
            parameters[23].Value = model.ExcessAmount;
            parameters[24].Value = model.StringTaskID;
            parameters[25].Value = model.LastTime;
            parameters[26].Value = model.Weight;
            parameters[27].Value = model.SpecID;
            parameters[28].Value = model.MaterielName;
            parameters[29].Value = model.ColorName;
            parameters[30].Value = model.ColorOneName;
            parameters[31].Value = model.ColorTwoName;
            parameters[32].Value = model.SizeName;
            parameters[33].Value = model.BrandName;
            parameters[34].Value = model.SupplierID;
            parameters[35].Value = model.SupplierName;
            parameters[36].Value = model.SupplierSN;
            parameters[37].Value = model.SpecName;
            parameters[38].Value = model.CompanyMaterielName;

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
        public bool Update(Hownet.Model.StockBackInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update StockBackInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("StockInfoID=@StockInfoID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("Price=@Price,");
            strSql.Append("CompanyMeasureID=@CompanyMeasureID,");
            strSql.Append("DepotMeasureID=@DepotMeasureID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Conversion=@Conversion,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("PriceAmount=@PriceAmount,");
            strSql.Append("NotAmount=@NotAmount,");
            strSql.Append("Money=@Money,");
            strSql.Append("NotPriceAmount=@NotPriceAmount,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("DemandID=@DemandID,");
            strSql.Append("NeedAmount=@NeedAmount,");
            strSql.Append("ExcessAmount=@ExcessAmount,");
            strSql.Append("StringTaskID=@StringTaskID,");
            strSql.Append("LastTime=@LastTime,");
            strSql.Append("Weight=@Weight,");
            strSql.Append("SpecID=@SpecID,");
            strSql.Append("MaterielName=@MaterielName,");
            strSql.Append("ColorName=@ColorName,");
            strSql.Append("ColorOneName=@ColorOneName,");
            strSql.Append("ColorTwoName=@ColorTwoName,");
            strSql.Append("SizeName=@SizeName,");
            strSql.Append("BrandName=@BrandName,");
            strSql.Append("SupplierID=@SupplierID,");
            strSql.Append("SupplierName=@SupplierName,");
            strSql.Append("SupplierSN=@SupplierSN,");
            strSql.Append("SpecName=@SpecName,");
            strSql.Append("CompanyMaterielName=@CompanyMaterielName");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@StockInfoID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@CompanyMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepotMeasureID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@Conversion", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@PriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@NotPriceAmount", SqlDbType.Decimal,9),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@DemandID", SqlDbType.Int,4),
					new SqlParameter("@NeedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@ExcessAmount", SqlDbType.Decimal,9),
					new SqlParameter("@StringTaskID", SqlDbType.NVarChar,200),
					new SqlParameter("@LastTime", SqlDbType.DateTime),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorOneName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorTwoName", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierID", SqlDbType.Int,4),
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierSN", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyMaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.StockInfoID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.ColorOneID;
            parameters[5].Value = model.ColorTwoID;
            parameters[6].Value = model.SizeID;
            parameters[7].Value = model.Price;
            parameters[8].Value = model.CompanyMeasureID;
            parameters[9].Value = model.DepotMeasureID;
            parameters[10].Value = model.Amount;
            parameters[11].Value = model.Conversion;
            parameters[12].Value = model.Remark;
            parameters[13].Value = model.PriceAmount;
            parameters[14].Value = model.NotAmount;
            parameters[15].Value = model.Money;
            parameters[16].Value = model.NotPriceAmount;
            parameters[17].Value = model.MListID;
            parameters[18].Value = model.CompanyID;
            parameters[19].Value = model.BrandID;
            parameters[20].Value = model.IsEnd;
            parameters[21].Value = model.DemandID;
            parameters[22].Value = model.NeedAmount;
            parameters[23].Value = model.ExcessAmount;
            parameters[24].Value = model.StringTaskID;
            parameters[25].Value = model.LastTime;
            parameters[26].Value = model.Weight;
            parameters[27].Value = model.SpecID;
            parameters[28].Value = model.MaterielName;
            parameters[29].Value = model.ColorName;
            parameters[30].Value = model.ColorOneName;
            parameters[31].Value = model.ColorTwoName;
            parameters[32].Value = model.SizeName;
            parameters[33].Value = model.BrandName;
            parameters[34].Value = model.SupplierID;
            parameters[35].Value = model.SupplierName;
            parameters[36].Value = model.SupplierSN;
            parameters[37].Value = model.SpecName;
            parameters[38].Value = model.CompanyMaterielName;
            parameters[39].Value = model.ID;

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
            strSql.Append("delete from StockBackInfo ");
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
            strSql.Append("delete from StockBackInfo ");
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
        public Hownet.Model.StockBackInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,StockInfoID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Price,CompanyMeasureID,DepotMeasureID,Amount,Conversion,Remark,PriceAmount,NotAmount,Money,NotPriceAmount,MListID,CompanyID,BrandID,IsEnd,DemandID,NeedAmount,ExcessAmount,StringTaskID,LastTime,Weight,SpecID,MaterielName,ColorName,ColorOneName,ColorTwoName,SizeName,BrandName,SupplierID,SupplierName,SupplierSN,SpecName,CompanyMaterielName from StockBackInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.StockBackInfo model = new Hownet.Model.StockBackInfo();
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
                if (ds.Tables[0].Rows[0]["StockInfoID"] != null && ds.Tables[0].Rows[0]["StockInfoID"].ToString() != "")
                {
                    model.StockInfoID = int.Parse(ds.Tables[0].Rows[0]["StockInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorOneID"] != null && ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"] != null && ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"] != null && ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyMeasureID"] != null && ds.Tables[0].Rows[0]["CompanyMeasureID"].ToString() != "")
                {
                    model.CompanyMeasureID = int.Parse(ds.Tables[0].Rows[0]["CompanyMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotMeasureID"] != null && ds.Tables[0].Rows[0]["DepotMeasureID"].ToString() != "")
                {
                    model.DepotMeasureID = int.Parse(ds.Tables[0].Rows[0]["DepotMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Conversion"] != null && ds.Tables[0].Rows[0]["Conversion"].ToString() != "")
                {
                    model.Conversion = decimal.Parse(ds.Tables[0].Rows[0]["Conversion"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["PriceAmount"] != null && ds.Tables[0].Rows[0]["PriceAmount"].ToString() != "")
                {
                    model.PriceAmount = decimal.Parse(ds.Tables[0].Rows[0]["PriceAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotAmount"] != null && ds.Tables[0].Rows[0]["NotAmount"].ToString() != "")
                {
                    model.NotAmount = decimal.Parse(ds.Tables[0].Rows[0]["NotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotPriceAmount"] != null && ds.Tables[0].Rows[0]["NotPriceAmount"].ToString() != "")
                {
                    model.NotPriceAmount = decimal.Parse(ds.Tables[0].Rows[0]["NotPriceAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"] != null && ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"] != null && ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DemandID"] != null && ds.Tables[0].Rows[0]["DemandID"].ToString() != "")
                {
                    model.DemandID = int.Parse(ds.Tables[0].Rows[0]["DemandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NeedAmount"] != null && ds.Tables[0].Rows[0]["NeedAmount"].ToString() != "")
                {
                    model.NeedAmount = decimal.Parse(ds.Tables[0].Rows[0]["NeedAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ExcessAmount"] != null && ds.Tables[0].Rows[0]["ExcessAmount"].ToString() != "")
                {
                    model.ExcessAmount = decimal.Parse(ds.Tables[0].Rows[0]["ExcessAmount"].ToString());
                }
                model.StringTaskID = ds.Tables[0].Rows[0]["StringTaskID"].ToString();
                if (ds.Tables[0].Rows[0]["LastTime"] != null && ds.Tables[0].Rows[0]["LastTime"].ToString() != "")
                {
                    model.LastTime = DateTime.Parse(ds.Tables[0].Rows[0]["LastTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Weight"] != null && ds.Tables[0].Rows[0]["Weight"].ToString() != "")
                {
                    model.Weight = decimal.Parse(ds.Tables[0].Rows[0]["Weight"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SpecID"] != null && ds.Tables[0].Rows[0]["SpecID"].ToString() != "")
                {
                    model.SpecID = int.Parse(ds.Tables[0].Rows[0]["SpecID"].ToString());
                }
                model.MaterielName = ds.Tables[0].Rows[0]["MaterielName"].ToString();
                model.ColorName = ds.Tables[0].Rows[0]["ColorName"].ToString();
                model.ColorOneName = ds.Tables[0].Rows[0]["ColorOneName"].ToString();
                model.ColorTwoName = ds.Tables[0].Rows[0]["ColorTwoName"].ToString();
                model.SizeName = ds.Tables[0].Rows[0]["SizeName"].ToString();
                model.BrandName = ds.Tables[0].Rows[0]["BrandName"].ToString();
                if (ds.Tables[0].Rows[0]["SupplierID"] != null && ds.Tables[0].Rows[0]["SupplierID"].ToString() != "")
                {
                    model.SupplierID = int.Parse(ds.Tables[0].Rows[0]["SupplierID"].ToString());
                }
                model.SupplierName = ds.Tables[0].Rows[0]["SupplierName"].ToString();
                model.SupplierSN = ds.Tables[0].Rows[0]["SupplierSN"].ToString();
                model.SpecName = ds.Tables[0].Rows[0]["SpecName"].ToString();
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
            strSql.Append("select  1 as A,ID,MainID,StockInfoID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Price,CompanyMeasureID,DepotMeasureID,Cast(Amount as Real) as Amount,Conversion,Remark,PriceAmount,NotAmount,Money,NotPriceAmount,MListID,CompanyID,BrandID,IsEnd,DemandID,NeedAmount,ExcessAmount,StringTaskID,LastTime,Weight,SpecID,MaterielName,ColorName,ColorOneName,ColorTwoName,SizeName,BrandName,SupplierID,SupplierName,SupplierSN,SpecName,CompanyMaterielName ");
            strSql.Append(" , (SELECT  cast( IsEnd as bit) as aa FROM      StockBackInfo AS T WHERE   (ID = stockbackinfo.stockinfoid)) AS NeedIsEnd ");
            strSql.Append(",(Select Remark from materiel where (id=stockbackinfo.MaterielID)) as MaterielRemark ");
            strSql.Append(" , (SELECT cast( NotAmount as Real) as NN FROM      StockBackInfo AS TT WHERE   (ID = stockbackinfo.stockinfoid)) AS NotStockAmount ");
            strSql.Append(" FROM StockBackInfo ");
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
            strSql.Append(" ID,MainID,StockInfoID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Price,CompanyMeasureID,DepotMeasureID,Amount,Conversion,Remark,PriceAmount,NotAmount,Money,NotPriceAmount,MListID,CompanyID,BrandID,IsEnd,DemandID,NeedAmount,ExcessAmount,StringTaskID,LastTime,Weight,SpecID,MaterielName,ColorName,ColorOneName,ColorTwoName,SizeName,BrandName,SupplierID,SupplierName,SupplierSN,SpecName,CompanyMaterielName ");
            strSql.Append(" FROM StockBackInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetList(string strWhere)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select  1 as A,ID,MainID,StockInfoID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Price,CompanyMeasureID,DepotMeasureID,Cast(Amount as Real) as Amount,");
        //    strSql.Append(" Conversion,Remark,PriceAmount,Cast(NotAmount as Real) as  NotAmount,Money,NotPriceAmount,MListID,CompanyID,BrandID,IsEnd,DemandID,NeedAmount,ExcessAmount,StringTaskID,LastTime,Weight,SpecID,MaterielName,ColorName,ColorOneName,ColorTwoName,SizeName,BrandName,SupplierID,SupplierName,SupplierSN,SpecName ");
        //    //strSql.Append(", (SELECT   IsEnd FROM      StockBackInfo AS T WHERE   (ID = StockInfoID)) AS NeedIsEnd, ");
        //    //strSql.Append(" (SELECT   Remark FROM      Materiel WHERE   (ID = StockBackInfo.MaterielID)) AS MaterielRemark ");

        //    strSql.Append(" , (SELECT  cast( IsEnd as bit) as aa FROM      StockBackInfo AS T WHERE   (ID = stockbackinfo.stockinfoid)) AS NeedIsEnd ");
        //    strSql.Append(",(Select Remark from materiel where (id=stockbackinfo.MaterielID)) as MaterielRemark ");
        //    strSql.Append(" , (SELECT cast( NotAmount as Real) as NN FROM      StockBackInfo AS TT WHERE   (ID = stockbackinfo.stockinfoid)) AS NotStockAmount ");
        //    strSql.Append(" FROM StockBackInfo ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    return DbHelperSQL.Query(strSql.ToString());
        //}



        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteByMain(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from StockBackInfo ");
            strSql.Append(" where MainID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetStockInfo(int CompanyID,int State)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   StockBackInfo.MaterielID, StockBackInfo.ColorID, StockBackInfo.SizeID, StockBackInfo.Price, StockBackInfo.Amount, StockBackInfo.NotAmount, ");
            strSql.Append("StockBackInfo.Price as StockPrice,");
            strSql.Append(" StockBackInfo.CompanyMeasureID, StockBackInfo.Remark,StockBackInfo.StringTaskID, 0 AS NowAmount, 0 as Money,StockBackInfo.ID FROM      StockBack INNER JOIN StockBackInfo ON ");
            strSql.Append(" StockBack.ID = StockBackInfo.MainID WHERE   (StockBack.IsVerify = 3)  AND (StockBack.State = @State)");
            if (CompanyID > 0)
                strSql.Append(" AND (StockBack.CompanyID = @CompanyID)");
            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID), new SqlParameter("@State", State) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetBackSuppList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 1 as A,ID,MainID,StockInfoID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Price,CompanyMeasureID,DepotMeasureID,Amount,Conversion,Remark,PriceAmount,NotAmount,Money,NotPriceAmount,MListID,0 as DepotAmount,0 as CostPrice ");
            strSql.Append(" FROM StockBackInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        public decimal GetPrice(int CompanyID, int MaterielID, int ColorID, int SizeID, int MeasureID,int State)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   TOP (1) StockBackInfo.Price FROM      StockBackInfo INNER JOIN StockBack ON StockBackInfo.MainID = StockBack.ID WHERE   (StockBack.CompanyID ");
            strSql.Append(" = 4) AND (StockBack.IsVerify = 3) AND (StockBack.State = @State) AND  (StockBackInfo.MaterielID = @MaterielID) AND (StockBackInfo.ColorID = ");
            strSql.Append(" @ColorID) AND  (StockBackInfo.CompanyMeasureID = @CompanyMeasureID) And (StockBackInfo.SizeID=@SizeID) GROUP BY StockBackInfo.Price, StockBackInfo.ID ");
            strSql.Append(" ORDER BY StockBackInfo.ID DESC");
            SqlParameter[] sps = { new SqlParameter("@CompanyID",CompanyID),new SqlParameter("@MaterielID",MaterielID),new SqlParameter("@ColorID",ColorID),
                                 new  SqlParameter("@SizeID",SizeID),new SqlParameter("@CompanyMeasureID",MeasureID),new SqlParameter("@State",State)};
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 0;
            else
                return decimal.Parse(o.ToString());
        }
        public DataSet GetInfo(int MListID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   '采购单' AS TableType, CONVERT(varchar(100), StockBack.DataTime, 112) + REPLACE(STR(StockBack.Num, 3, 0), ' ', '0') ");
            strSql.Append(" AS Num, StockBackInfo.MaterielID, StockBackInfo.ColorID, StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID, StockBackInfo.SizeID, ");
            strSql.Append(" StockBackInfo.BrandID, StockBackInfo.CompanyMeasureID AS MeasureID,StockBackInfo.StringTaskID, CAST(StockBackInfo.NotAmount AS Real) AS Amount, ");
            strSql.Append(" StockBackInfo.MListID, StockBackInfo.ID FROM      StockBack INNER JOIN StockBackInfo ON StockBack.ID = StockBackInfo.MainID ");
            strSql.Append(" WHERE   (StockBackInfo.MListID = @MListID) AND (StockBack.IsVerify = 3) AND (StockBackInfo.IsEnd = 0)");
            SqlParameter[] sps = { new SqlParameter("@MListID", MListID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetTemLinLiaoInfo(int TaskID, int DepotID, int DeparmentTypeID)
        {
            DataSet ds = new DataSet();
            Hownet.DAL.SysTem dalST = new SysTem();
            Hownet.Model.SysTem modST= dalST.GetModel(dalST.GetMaxId() - 1);
            if (modST.MaterielByTask)
            {
                if (DeparmentTypeID == 1||DeparmentTypeID==3)
                {
                    try
                    {
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append("SELECT Cast(0 as bit) as IsSelect,  MaterielDemand.ID AS DemandID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.SizeID,  ");
                        strSql.Append("                MaterielDemand.ColorOneID, MaterielDemand.MListID, 0 AS ID, 3 AS A, 0 AS MainID,  ");
                        strSql.Append("                MaterielDemand.MeasureID AS CompanyMeasureID, '' AS Remark, MaterielDemand.ColorTwoID,  ");
                        strSql.Append("                CAST(MaterielDemand.Amount AS real) AS NeedAmount, CAST(MaterielDemand.OutAmount AS real) AS NotPriceAmount,  ");
                        strSql.Append("                CAST(MaterielDemand.NotAllotAmount AS real) AS NotAmount, CAST(Rep.Amount AS real) AS PriceAmount,  ");
                        strSql.Append("                Rep.ID AS StockInfoID, CAST(0 AS real) AS Amount, 0 AS ExcessAmount, ProductTaskMain.ID AS StringTaskID,  ");
                        strSql.Append("                0 AS BrandID, MaterielDemand.MeasureID AS DepotMeasureID, 1 AS Conversion,  0 AS Price,0 as Weight,  ");
                        strSql.Append("                0 AS Money, 0 AS IsEnd, 0 AS CompanyID ");// 0 AS PriceAmount,0 AS PriceAmount,
                        strSql.Append("FROM      MaterielDemand INNER JOIN ");
                        strSql.Append("                ProductTaskMain ON MaterielDemand.ProduceTaskID = ProductTaskMain.ID LEFT OUTER JOIN ");
                        strSql.Append("                    (SELECT   DepartmentID, Amount, MListID, ID, PlanID ");
                        strSql.Append("                     FROM      Repertory ");
                        strSql.Append("                     WHERE   (DepartmentID = @DepotID)) AS Rep ON ProductTaskMain.ParentID = Rep.PlanID AND  ");
                        strSql.Append("                MaterielDemand.MListID = Rep.MListID ");
                        strSql.Append("WHERE   (MaterielDemand.TableTypeID = 1) AND (MaterielDemand.ProduceTaskID = @TaskID) ORDER BY MaterielDemand.MaterielID,MaterielDemand.ColorID,MaterielDemand.SizeID ");
                        SqlParameter[] sps = { new SqlParameter("TaskID", TaskID), new SqlParameter("@DepotID", DepotID) };
                        ds = DbHelperSQL.Query(strSql.ToString(), sps);
                        try
                        {
                            //ds.Tables[0].Columns.Add("CompanyID", typeof(int));
                            //ds.Tables[0].Columns.Add("ExcessAmount", typeof(decimal));
                            Hownet.DAL.Repertory dalRe = new Repertory();
                            DataTable dtTem = new DataTable();

                            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                            {
                                dtTem = dalRe.GetList("(DepartmentID=" + DepotID + ") And (MListID=" + ds.Tables[0].Rows[i]["MListID"] + ") And (PlanID=0)").Tables[0];
                                if (dtTem.Rows.Count > 0)
                                {
                                    ds.Tables[0].Rows[i]["CompanyID"] = dtTem.Rows[0]["ID"];
                                    ds.Tables[0].Rows[i]["ExcessAmount"] = dtTem.Rows[0]["Amount"];
                                }
                                else
                                {
                                    ds.Tables[0].Rows[i]["CompanyID"] = 0;
                                    ds.Tables[0].Rows[i]["ExcessAmount"] = 0;
                                }
                            }
                            ds.Tables[0].AcceptChanges();
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                        StringBuilder strSql = new StringBuilder();
                        strSql.Append(" SELECT Cast(0 as bit) as IsSelect,  MaterielDemand.ID AS DemandID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.SizeID, ");
                        strSql.Append(" MaterielDemand.ColorOneID, MaterielDemand.MListID, 0 AS ID, 3 AS A, 0 AS MainID, MaterielDemand.MeasureID AS ");
                        strSql.Append(" CompanyMeasureID, '' AS Remark, MaterielDemand.ColorTwoID, CAST(MaterielDemand.Amount AS real) AS NeedAmount, ");
                        strSql.Append(" CAST(MaterielDemand.OutAmount AS real) AS NotPriceAmount, CAST(MaterielDemand.NotAllotAmount AS real) AS NotAmount,0 as Weight, ");
                        strSql.Append(" CAST(Repertory.Amount AS real) AS PriceAmount, Repertory.ID AS StockInfoID, CAST(0 AS real) AS Amount, 0 AS ");
                        strSql.Append(" ExcessAmount, ProductTaskMain.ID AS StringTaskID, 0 AS BrandID, MaterielDemand.MeasureID AS DepotMeasureID, 1 AS ");// 0 AS PriceAmount,0 AS PriceAmount,
                        strSql.Append(" Conversion, 0 AS Price,  0 AS Money, 0 AS IsEnd, 0 AS CompanyID FROM ");
                        strSql.Append(" MaterielDemand INNER JOIN ProductTaskMain ON MaterielDemand.ProduceTaskID = ProductTaskMain.ID INNER JOIN ");
                        strSql.Append(" Repertory ON ProductTaskMain.ParentID = Repertory.PlanID AND MaterielDemand.MListID = Repertory.MListID ");
                        strSql.Append(" WHERE   (MaterielDemand.TableTypeID = 1) AND (MaterielDemand.ProduceTaskID = @TaskID) AND (Repertory.DepartmentID = @DepotID) ORDER BY MaterielDemand.MaterielID,MaterielDemand.ColorID,MaterielDemand.SizeID");
                        SqlParameter[] sps = { new SqlParameter("TaskID", TaskID), new SqlParameter("@DepotID", DepotID) };
                        ds = DbHelperSQL.Query(strSql.ToString(), sps);
                    }
                }
                else if (DeparmentTypeID == 2||DeparmentTypeID==3)
                {
                    StringBuilder strSql = new StringBuilder();
                    strSql.Append("SELECT Cast(0 as bit) as IsSelect,  MaterielDemand.ID AS DemandID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.SizeID, ");
                    strSql.Append("                MaterielDemand.ColorOneID, MaterielDemand.MListID, 0 AS ID, 3 AS A, 0 AS MainID,  ");
                    strSql.Append("                MaterielDemand.MeasureID AS CompanyMeasureID, '' AS Remark, MaterielDemand.ColorTwoID,  ");
                    strSql.Append("                CAST(MaterielDemand.Amount AS real) AS NeedAmount, CAST(MaterielDemand.OutAmount AS real) AS NotPriceAmount, 0 as Weight, ");
                    strSql.Append("                CAST(MaterielDemand.NotAllotAmount AS real) AS NotAmount, CAST(Rep.Amount AS real) AS PriceAmount,  ");
                    strSql.Append("                Rep.ID AS StockInfoID, CAST(0 AS real) AS Amount, 0 AS ExcessAmount, 0 AS BrandID,  ");
                    strSql.Append("                MaterielDemand.MeasureID AS DepotMeasureID, 1 AS Conversion, 0 AS Price, ");// 0 AS PriceAmount, 0 AS PriceAmount, 
                    strSql.Append("                0 AS Money, 0 AS IsEnd, 0 AS CompanyID, MaterielDemand.ProduceTaskID AS StringTaskID ");
                    strSql.Append("FROM      (SELECT   DepartmentID, Amount, MListID, ID, PlanID ");
                    strSql.Append("                 FROM      Repertory ");
                    strSql.Append("                 WHERE   (DepartmentID = @DepotID)) AS Rep RIGHT OUTER JOIN ");
                    strSql.Append("                MaterielDemand ON Rep.PlanID = MaterielDemand.ProduceTaskID AND Rep.MListID = MaterielDemand.MListID ");
                    strSql.Append("WHERE   (MaterielDemand.TableTypeID = 41) AND (MaterielDemand.ProduceTaskID = @TaskID) ORDER BY MaterielDemand.MaterielID,MaterielDemand.ColorID,MaterielDemand.SizeID");
                    SqlParameter[] sps = { new SqlParameter("TaskID", TaskID), new SqlParameter("@DepotID", DepotID) };
                    ds = DbHelperSQL.Query(strSql.ToString(), sps);
                    try
                    {
                        //ds.Tables[0].Columns.Add("CompanyID", typeof(int));
                        //ds.Tables[0].Columns.Add("ExcessAmount", typeof(decimal));
                        Hownet.DAL.Repertory dalRe = new Repertory();
                        DataTable dtTem = new DataTable();

                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            dtTem = dalRe.GetList("(DepartmentID=" + DepotID + ") And (MListID=" + ds.Tables[0].Rows[i]["MListID"] + ") And (PlanID=0)").Tables[0];
                            if (dtTem.Rows.Count > 0)
                            {
                                ds.Tables[0].Rows[i]["CompanyID"] = dtTem.Rows[0]["ID"];
                                ds.Tables[0].Rows[i]["ExcessAmount"] = dtTem.Rows[0]["Amount"];
                            }
                            else
                            {
                                ds.Tables[0].Rows[i]["CompanyID"] = 0;
                                ds.Tables[0].Rows[i]["ExcessAmount"] = 0;
                            }
                        }
                        ds.Tables[0].AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            else
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" SELECT CAST(0 AS bit) AS IsSelect, MaterielDemand.ID AS DemandID,  MaterielDemand.MaterielID, ");
                strSql.Append(" MaterielDemand.ColorID, MaterielDemand.SizeID, MaterielDemand.ColorOneID, MaterielDemand.MListID, ");
                strSql.Append(" 0 AS ID, 3 AS A, 0 AS MainID, MaterielDemand.MeasureID AS CompanyMeasureID, '' AS Remark,0 as Weight, ");
                strSql.Append(" MaterielDemand.ColorTwoID, CAST(MaterielDemand.Amount AS real) AS NeedAmount,  ");
                strSql.Append(" CAST(MaterielDemand.OutAmount AS real) AS NotPriceAmount, CAST(MaterielDemand.NotAllotAmount ");
                strSql.Append(" AS real) AS NotAmount, CAST(Rep.Amount AS real) AS PriceAmount, Rep.ID AS StockInfoID, CAST(0 AS real)  ");
                strSql.Append(" AS Amount, 0 AS ExcessAmount, 0 AS BrandID, MaterielDemand.MeasureID AS DepotMeasureID, 1 AS Conversion,  ");
                strSql.Append("  0 AS Price, 0 AS Money, 0 AS IsEnd, 0 AS CompanyID, "); //0 AS PriceAmount,0 AS PriceAmount,
                strSql.Append(" MaterielDemand.ProduceTaskID AS StringTaskID FROM (SELECT DepartmentID, Amount, MListID, ID, PlanID ");
                strSql.Append(" FROM Repertory WHERE (DepartmentID = @DepotID)) AS Rep RIGHT OUTER JOIN ");
                strSql.Append(" MaterielDemand ON Rep.MListID = MaterielDemand.MListID WHERE (MaterielDemand.TableTypeID = 41) AND ");
                strSql.Append(" (MaterielDemand.ProduceTaskID = @TaskID) ORDER BY MaterielDemand.MaterielID, MaterielDemand.ColorID, ");
                strSql.Append(" MaterielDemand.SizeID");
                SqlParameter[] sps = { new SqlParameter("TaskID", TaskID), new SqlParameter("@DepotID", DepotID) };
                ds = DbHelperSQL.Query(strSql.ToString(), sps);
            }
            return ds;
        }
        public DataSet GetNeedInfoList(int IsEnd, int TypeID, int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  StockBack.Num, CAST(0 AS bit) AS IsSelect, StockBackInfo.ID AS StockInfoID, StockBackInfo.MaterielID, StockBackInfo.ColorID, ");
            strSql.Append(" CONVERT(varchar(100), StockBack.DataTime, 112) +'-'+ REPLACE(STR(StockBack.Num, 3, 0), ' ', '0') ");
            strSql.Append(" AS Num,StockBack.StockRemark,");
            strSql.Append(" StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID, StockBackInfo.SizeID, StockBackInfo.Price,StockBackInfo.Price as StockPrice,StockBackInfo.BrandID, ");
            strSql.Append(" StockBackInfo.DepotMeasureID,cast( StockBackInfo.Amount as real) as Amount, StockBackInfo.Remark AS NeedRemark,StockBackInfo.Weight, ");
            strSql.Append(" cast( StockBackInfo.NotAmount as real) as NotAmount, ");
            strSql.Append("(Select Remark from materiel where (id=stockbackinfo.MaterielID)) as MaterielRemark, ");
            strSql.Append(" StockBackInfo.Money, StockBackInfo.MListID,cast( StockBackInfo.IsEnd as bit) AS NeedIsEnd, StockBackInfo.StringTaskID, 0 AS ID, ");
            strSql.Append(" 3 AS A, StockBack.IsVerify, StockBack.State, StockBack.DataTime FROM      StockBack INNER JOIN StockBackInfo ON ");
            strSql.Append(" StockBack.ID = StockBackInfo.MainID WHERE   (StockBack.State = @TypeID) AND (StockBack.IsVerify > 2) ");
            strSql.Append(" AND (StockBack.IsVerify < 10) ");
            if (IsEnd > -1)
            {
                strSql.Append(" And (StockBackInfo.NotAmount>0) AND (StockBackInfo.IsEnd = @IsEnd)");
            }
            else
            {
            }
            if (CompanyID > 0)
                strSql.Append(" And (StockBack.CompanyID=@CompanyID)");
            SqlParameter[] sps = { new SqlParameter("@IsEnd", IsEnd), new SqlParameter("@TypeID", TypeID), new SqlParameter("@CompanyID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetNeedInfoListQR(int IsEnd, int TypeID, int CompanyID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT  StockBack.Num, CAST(0 AS bit) AS IsSelect, StockBackInfo.ID AS StockInfoID, StockBackInfo.MaterielID, StockBackInfo.ColorID, ");
            strSql.Append(" CONVERT(varchar(100), StockBack.DataTime, 112) +'-'+ REPLACE(STR(StockBack.Num, 3, 0), ' ', '0') ");
            strSql.Append(" AS Num,StockBack.StockRemark,StockBackInfo.Conversion,");
            strSql.Append(" StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID, StockBackInfo.SizeID, StockBackInfo.Price,StockBackInfo.Price as StockPrice,StockBackInfo.BrandID, ");
            strSql.Append(" StockBackInfo.DepotMeasureID, StockBackInfo.CompanyMeasureID,cast( StockBackInfo.Amount as real) as NeedAmount, StockBackInfo.Remark AS NeedRemark,StockBackInfo.Weight, ");
            strSql.Append(" cast( StockBackInfo.NotAmount as real) as NotAmount, ");
            strSql.Append("(Select Remark from materiel where (id=stockbackinfo.MaterielID)) as MaterielRemark, ");
            strSql.Append(" StockBackInfo.MListID,cast( StockBackInfo.IsEnd as bit) AS NeedIsEnd, StockBackInfo.StringTaskID, 0 AS ID, ");
            strSql.Append(" 3 AS A, StockBack.IsVerify, StockBack.State, StockBack.DataTime FROM      StockBack INNER JOIN StockBackInfo ON ");
            strSql.Append(" StockBack.ID = StockBackInfo.MainID WHERE   (StockBack.State = @TypeID) AND (StockBack.IsVerify > 2) ");
            strSql.Append(" AND (StockBack.IsVerify < 10) ");
            if (IsEnd > -1)
            {
                strSql.Append(" And (StockBackInfo.NotAmount>0) AND (StockBackInfo.IsEnd = @IsEnd)");
            }
            else
            {
            }
            if (CompanyID > 0)
                strSql.Append(" And (StockBack.CompanyID=@CompanyID)");
            SqlParameter[] sps = { new SqlParameter("@IsEnd", IsEnd), new SqlParameter("@TypeID", TypeID), new SqlParameter("@CompanyID", CompanyID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetLinLiaoInfo(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Cast(0 as bit) as IsSelect, 1 AS A, CAST(MaterielDemand.Amount AS real) AS NeedAmount, CAST(MaterielDemand.OutAmount AS real) ");
            strSql.Append(" AS NotPriceAmount, CAST(MaterielDemand.NotAllotAmount AS real) AS NotAmount, CAST(Repertory.Amount AS real) ");
            strSql.Append(" AS PriceAmount, StockBackInfo.StockInfoID, StockBackInfo.MaterielID, StockBackInfo.ColorID, StockBackInfo.ColorOneID,StockBackInfo.Price,StockBackInfo.Money,StockBackInfo.Weight, ");
            strSql.Append(" StockBackInfo.ColorTwoID, StockBackInfo.SizeID, StockBackInfo.Price, StockBackInfo.CompanyMeasureID, ");
            strSql.Append(" StockBackInfo.DepotMeasureID, CAST(StockBackInfo.Amount AS real) AS Amount, StockBackInfo.Conversion, ");
            strSql.Append(" StockBackInfo.Remark, StockBackInfo.Money, StockBackInfo.MListID, StockBackInfo.CompanyID,StockBackInfo.Weight, ");
            strSql.Append(" StockBackInfo.SpecID, StockBackInfo.MaterielName, StockBackInfo.ColorName, StockBackInfo.ColorOneName, ");
            strSql.Append(" StockBackInfo.ColorTwoName, StockBackInfo.SizeName, StockBackInfo.BrandName, StockBackInfo.SupplierID, ");
            strSql.Append(" StockBackInfo.SupplierName, StockBackInfo.SupplierSN, StockBackInfo.SpecName,");
            strSql.Append(" StockBackInfo.BrandID, StockBackInfo.IsEnd, StockBackInfo.DemandID, StockBackInfo.StringTaskID,StockBackInfo.SpecID,");
            strSql.Append(" StockBackInfo.ExcessAmount, StockBackInfo.ID, StockBackInfo.MainID FROM      StockBackInfo LEFT OUTER JOIN ");
            strSql.Append(" Repertory ON StockBackInfo.StockInfoID = Repertory.ID LEFT OUTER JOIN MaterielDemand ON StockBackInfo.DemandID ");
            strSql.Append(" = MaterielDemand.ID WHERE   (StockBackInfo.MainID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public void UpIsEnd(int ID,int IsEnd)
        {
            Hownet.Model.StockBackInfo modSBI = GetModel(ID);
            modSBI.IsEnd = IsEnd;
            Update(modSBI);
        }
        /// <summary>
        /// 采购单中有半成品时，获取明细数量以便用于计算所需物料
        /// </summary>
        /// <param name="TypeID">采购订单</param>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetSemi(int TypeID, int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   PlanUseRep.TypeID, StockBackInfo.MainID, StockBackInfo.ID, StockBackInfo.StockInfoID, StockBackInfo.MaterielID, ");
            strSql.Append(" StockBackInfo.ColorID, StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID, StockBackInfo.SizeID, ");
            strSql.Append(" StockBackInfo.Price, StockBackInfo.CompanyMeasureID, StockBackInfo.DepotMeasureID, PlanUseRep.Amount, ");
            strSql.Append(" PlanUseRep.DemandID, StockBackInfo.Conversion, StockBackInfo.Remark, StockBackInfo.PriceAmount, ");
            strSql.Append(" StockBackInfo.NotAmount, StockBackInfo.Money, StockBackInfo.NotPriceAmount, StockBackInfo.MListID,StockBackInfo.Weight, ");
            strSql.Append(" StockBackInfo.CompanyID, StockBackInfo.BrandID, StockBackInfo.IsEnd, StockBackInfo.NeedAmount,StockBackInfo.Weight, ");
            strSql.Append(" StockBackInfo.ExcessAmount, StockBackInfo.StringTaskID, PlanUseRep.TaskID as PlanID FROM      PlanUseRep INNER JOIN ");
            strSql.Append(" StockBackInfo ON PlanUseRep.StockInfoID = StockBackInfo.ID WHERE   (PlanUseRep.TypeID = @TypeID) AND (StockBackInfo.MainID = @MainID)");
            SqlParameter[] sps = {new SqlParameter("@TypeID",TypeID), new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetStockLinLiaoInfo(int StockID, int DepotID)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("SELECT   3 AS A, 0 AS ID, 0 AS MainID, StockMaterielDemand.MaterielID, StockMaterielDemand.ColorID,  ");
                strSql.Append("                StockMaterielDemand.ColorOneID, StockMaterielDemand.ColorTwoID, StockMaterielDemand.SizeID, 0 AS Price,  ");
                strSql.Append("                StockMaterielDemand.MeasureID AS CompanyMeasureID, StockMaterielDemand.MeasureID AS DepotMeasureID,  ");
                strSql.Append("                CAST(0 AS real) AS Amount, 1 AS Conversion, '' AS Remark, 0 AS PriceAmount,  ");
                strSql.Append("                CAST(StockMaterielDemand.NotAllotAmount AS real) AS NotAmount, 0 AS Money,  ");
                strSql.Append("                CAST(StockMaterielDemand.OutAmount AS real) AS NotPriceAmount, StockMaterielDemand.MListID, 0 AS CompanyID, 0 as Weight, ");
                strSql.Append("                0 AS BrandID, StockMaterielDemand.ID AS DemandID, CAST(StockMaterielDemand.Amount AS real) AS NeedAmount,  ");
                strSql.Append("                CAST(Rep.Amount AS real) AS RepertoryAmount, 0 AS ExcessAmount, 0 AS IsEnd,  ");
                strSql.Append("                StockMaterielDemand.MainID AS StockID, CAST(Rep.Amount AS real) AS RepertoryAmount, '' AS StringTaskID ");
                strSql.Append(" ,Rep.ID AS StockInfoID ");
                strSql.Append("FROM      StockMaterielDemand LEFT OUTER JOIN ");
                strSql.Append("                    (SELECT   DepartmentID, Amount, MListID, ID, PlanID ");
                strSql.Append("                     FROM      Repertory ");
                strSql.Append("                     WHERE   (DepartmentID = @DepotID)) AS Rep ON StockMaterielDemand.MListID = Rep.MListID AND  ");
                strSql.Append("                StockMaterielDemand.PlanID = Rep.PlanID ");
                strSql.Append("WHERE   (StockMaterielDemand.MainID = @StockID) ");
                SqlParameter[] sps = { new SqlParameter("StockID", StockID), new SqlParameter("@DepotID", DepotID) };
                DataSet ds = DbHelperSQL.Query(strSql.ToString(), sps);
                return ds;
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        /// <summary>
        /// 返回某单未完成的记录条数
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public int NotIsEnd(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(ID) AS Expr1 FROM      StockBackInfo WHERE   (IsEnd = 0) AND (MainID = @MainID) OR ");
            strSql.Append(" (NotAmount > 0) AND (MainID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        /// <summary>
        /// 返回退货给某供应商时，该供应商之前的收货现有库存大于0的记录
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetBackSupp(int CompanyID, int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   3 AS A, 0 AS ID, 0 AS MainID, Repertory.ID AS DemandID, CAST(Repertory.Amount AS real) AS RepertoryAmount,  ");
            //strSql.Append("                Repertory.PlanID as CompanyID, '' AS Remark, StockBackInfo.MaterielID, StockBackInfo.ColorID, StockBackInfo.ColorOneID,  ");
            //strSql.Append("                StockBackInfo.ColorTwoID, StockBackInfo.SizeID, StockBackInfo.Price, StockBackInfo.CompanyMeasureID,  ");
            //strSql.Append("                 StockBackInfo.MListID, StockBackInfo.ID AS StockInfoID ");
            //strSql.Append("FROM      StockBack INNER JOIN ");
            //strSql.Append("                StockBackInfo ON StockBack.ID = StockBackInfo.MainID INNER JOIN ");
            //strSql.Append("                Repertory ON StockBackInfo.MListID = Repertory.MListID ");
            //strSql.Append("WHERE   (StockBack.State = 24 OR StockBack.State = 49) AND (StockBack.CompanyID = @CompanyID) AND (Repertory.DepartmentID = @DepotID) AND (Repertory.Amount > 0) ");
            strSql.Append("SELECT 3 AS A, 0 AS ID, 0 AS MainID, Repertory.ID AS DemandID,0 as StockInfoID, ");//StockBackInfo.ID AS StockInfoID,");// 
            strSql.Append("      CAST(Repertory.Amount AS real) AS RepertoryAmount,  StockBackInfo.MainID as SBMainID,StockBackInfo.Weight,");
            strSql.Append("      Repertory.PlanID AS CompanyID, '' AS Remark, StockBackInfo.MaterielID,  ");
            strSql.Append("      StockBackInfo.ColorID, StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID,  ");
            strSql.Append("      StockBackInfo.SizeID, StockBackInfo.Price, StockBackInfo.CompanyMeasureID,  ");
            strSql.Append("      StockBackInfo.MListID ");
            strSql.Append("FROM StockBack INNER JOIN ");
            strSql.Append("      StockBackInfo ON StockBack.ID = StockBackInfo.MainID INNER JOIN ");
            strSql.Append("      Repertory ON StockBackInfo.MListID = Repertory.MListID ");
            strSql.Append("WHERE (StockBack.State = 24 OR ");
            strSql.Append("      StockBack.State = 49) AND (StockBack.CompanyID = @CompanyID) AND  ");
            strSql.Append("      (Repertory.DepartmentID = @DepotID) ");
            strSql.Append("GROUP BY Repertory.ID, CAST(Repertory.Amount AS real), Repertory.PlanID,  ");
            strSql.Append("      StockBackInfo.MaterielID, StockBackInfo.ColorID, StockBackInfo.ColorOneID,  ");
            strSql.Append("      StockBackInfo.ColorTwoID, StockBackInfo.SizeID, StockBackInfo.Price,  ");
            strSql.Append("      StockBackInfo.CompanyMeasureID, StockBackInfo.MListID ,  StockBackInfo.MainID , StockBackInfo.ID ");
            strSql.Append(" HAVING (CAST(Repertory.Amount AS real) > 0) ");
            SqlParameter[] sps = {new SqlParameter("@CompanyID",CompanyID),new SqlParameter("@DepotID",DepotID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 退货后更新数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="IsVerify">是审核，原采购单数量增加本次退货数量，弃审则减少</param>
        public void UpBackSupp(int MainID, bool IsVerify)
        {
            StringBuilder strSql = new StringBuilder();
            if (IsVerify)
            {
                strSql.Append("UPDATE  StockBackInfo SET         NotAmount = StockBackInfo.NotAmount + T.SumAmount ");
                strSql.Append(" FROM      (SELECT   StockInfoID, SUM(Amount) AS SumAmount FROM      StockBackInfo AS StockBackInfo_1 ");
                strSql.Append(" WHERE   (MainID = @MainID)  GROUP BY StockInfoID) AS T INNER JOIN ");
                strSql.Append(" StockBackInfo ON T.StockInfoID = StockBackInfo.ID");
            }
            else
            {
                strSql.Append("UPDATE  StockBackInfo SET         NotAmount = StockBackInfo.NotAmount - T.SumAmount ");
                strSql.Append(" FROM      (SELECT   StockInfoID, SUM(Amount) AS SumAmount FROM      StockBackInfo AS StockBackInfo_1 ");
                strSql.Append(" WHERE   (MainID = @MainID)  GROUP BY StockInfoID) AS T INNER JOIN ");
                strSql.Append(" StockBackInfo ON T.StockInfoID = StockBackInfo.ID");
            }
            SqlParameter[] sps = {new SqlParameter("@MainID",MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public void DelByStockInfoID(int StockInfoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from StockBackInfo ");
            strSql.Append(" where StockInfoID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = StockInfoID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 物料加工单的领料明细
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetWXOutList(int MainID, int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  1 as A, ID, MainID, StockInfoID, MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, Price, CompanyMeasureID, ");
            strSql.Append(" DepotMeasureID, Amount, Conversion, Remark, PriceAmount, NotPriceAmount, Money, MListID, ");//Amount - NotAmount AS 
            strSql.Append(" CompanyID, BrandID, IsEnd, DemandID, NeedAmount, StringTaskID, LastTime, Weight, SpecID, MaterielName,NotAmount, ");
            strSql.Append(" ColorName, ColorOneName, ColorTwoName, SizeName, BrandName, SupplierID, SupplierName, SupplierSN, SpecName,");
            strSql.Append(" (SELECT   Amount FROM      Repertory WHERE   (MListID = StockBackInfo.MListID) AND (PlanID = 0) AND (DepartmentID = @DetotID))  ");
            strSql.Append(" AS ExcessAmount FROM      StockBackInfo WHERE   (MainID =@MainID)");
            SqlParameter[] sps = { new SqlParameter("@DetotID", DepotID), new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }

        public DataSet GetMaterielOutList(int State, int CompanyID, int TaskID, DateTime dt1, DateTime dt2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   StockBack.DataTime, StockBack.CompanyID, StockBack.DepotID, StockBack.TaskID, StockBackInfo.MaterielID, ");
            strSql.Append("   (CASE WHEN (StockBack.DeparmentType = 3) THEN (SELECT   Name FROM      company WHERE   (ID = StockBack.CompanyID)) ELSE ");
            strSql.Append(" (SELECT   Name FROM      Deparment WHERE   (ID = StockBack.CompanyID)) END) AS DeparmentName ,");
            strSql.Append(" StockBackInfo.ColorID, StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID, StockBackInfo.SizeID, ");
            strSql.Append(" StockBackInfo.CompanyMeasureID, StockBackInfo.Amount FROM      StockBack INNER JOIN ");
            strSql.Append(" StockBackInfo ON StockBack.ID = StockBackInfo.MainID WHERE   ");
            strSql.Append("  (StockBack.State = @State) AND (StockBack.DataTime > @dt1) AND (StockBack.DataTime < @dt2)");
            if (CompanyID > 0)
                strSql.Append(" AND (StockBack.CompanyID = @CompanyID)");
            if (TaskID > 0)
                strSql.Append(" AND (StockBack.TaskID = @TaslID) ");
            SqlParameter[] sps = { new SqlParameter("@State", State), new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@CompanyID", CompanyID), new SqlParameter("@TaskID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetListForOne(int Top, int CompanyID, int MaterielID, DateTime dt1, DateTime dt2,int Stata)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  ");
            if (Top > 0)
                strSql.Append(" Top (@Top) ");
            strSql.Append("  StockBack.ID, StockBack.CompanyID AS 供应商, StockBack.DataTime AS 日期, StockBack.Num AS 编号, StockBackInfo.MaterielID AS 物料, ");
            strSql.Append(" StockBackInfo.ColorID AS 颜色, StockBackInfo.SizeID AS 尺码, StockBackInfo.Price AS 单价, StockBackInfo.Amount AS 数量, ");
            strSql.Append(" StockBackInfo.CompanyMeasureID AS 单位, StockBackInfo.Money AS 金额 FROM         StockBack INNER JOIN ");
            strSql.Append(" StockBackInfo ON StockBack.ID = StockBackInfo.MainID WHERE     (StockBack.State = "+Stata+") ");
            if (CompanyID > 0)
                strSql.Append(" AND (StockBack.CompanyID = @CompanyID) ");
            if (MaterielID > 0)
                strSql.Append(" AND (StockBackInfo.MaterielID = @MaterielID) ");
            if (dt1 > Convert.ToDateTime("1900-1-1"))
                strSql.Append(" And (StockBack.DataTime>@dt1) And (StockBack.DataTime<@dt2)");
            strSql.Append(" ORDER BY 日期 DESC ");
            SqlParameter[] sps = { new SqlParameter("@Top", Top), new SqlParameter("@CompanyID", CompanyID),new SqlParameter("@MaterielID",MaterielID),new SqlParameter("@dt1",dt1),
                                 new SqlParameter("@dt2",dt2)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        //public DataSet GetWXOutList(int MainID)
        //{
        //}
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
			parameters[0].Value = "StockBackInfo";
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

