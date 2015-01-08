using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类ProduceSellInfo。
	/// </summary>
	public class ProduceSellInfo
	{
		public ProduceSellInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ProduceSellInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProduceSellInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ProduceSellInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ProduceSellInfo(");
            strSql.Append("MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BrandID,MListID,SalesInfoID,MeasureID,SelesID,RepertoryListID,RepertoryID,PSOID)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@MaterielID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@Amount,@BrandID,@MListID,@SalesInfoID,@MeasureID,@SelesID,@RepertoryListID,@RepertoryID,@PSOID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Real,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@SalesInfoID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@SelesID", SqlDbType.Int,4),
					new SqlParameter("@RepertoryListID", SqlDbType.Int,4),
					new SqlParameter("@RepertoryID", SqlDbType.Int,4),
					new SqlParameter("@PSOID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorOneID;
            parameters[4].Value = model.ColorTwoID;
            parameters[5].Value = model.SizeID;
            parameters[6].Value = model.Amount;
            parameters[7].Value = model.BrandID;
            parameters[8].Value = model.MListID;
            parameters[9].Value = model.SalesInfoID;
            parameters[10].Value = model.MeasureID;
            parameters[11].Value = model.SelesID;
            parameters[12].Value = model.RepertoryListID;
            parameters[13].Value = model.RepertoryID;
            parameters[14].Value = model.PSOID;

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
        public bool Update(Hownet.Model.ProduceSellInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProduceSellInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("SalesInfoID=@SalesInfoID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("SelesID=@SelesID,");
            strSql.Append("RepertoryListID=@RepertoryListID,");
            strSql.Append("RepertoryID=@RepertoryID,");
            strSql.Append("PSOID=@PSOID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Real,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@SalesInfoID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@SelesID", SqlDbType.Int,4),
					new SqlParameter("@RepertoryListID", SqlDbType.Int,4),
					new SqlParameter("@RepertoryID", SqlDbType.Int,4),
					new SqlParameter("@PSOID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorOneID;
            parameters[4].Value = model.ColorTwoID;
            parameters[5].Value = model.SizeID;
            parameters[6].Value = model.Amount;
            parameters[7].Value = model.BrandID;
            parameters[8].Value = model.MListID;
            parameters[9].Value = model.SalesInfoID;
            parameters[10].Value = model.MeasureID;
            parameters[11].Value = model.SelesID;
            parameters[12].Value = model.RepertoryListID;
            parameters[13].Value = model.RepertoryID;
            parameters[14].Value = model.PSOID;
            parameters[15].Value = model.ID;

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
            strSql.Append("delete from ProduceSellInfo ");
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
            strSql.Append("delete from ProduceSellInfo ");
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
        public Hownet.Model.ProduceSellInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BrandID,MListID,SalesInfoID,MeasureID,SelesID,RepertoryListID,RepertoryID,PSOID from ProduceSellInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.ProduceSellInfo model = new Hownet.Model.ProduceSellInfo();
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
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"] != null && ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SalesInfoID"] != null && ds.Tables[0].Rows[0]["SalesInfoID"].ToString() != "")
                {
                    model.SalesInfoID = int.Parse(ds.Tables[0].Rows[0]["SalesInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SelesID"] != null && ds.Tables[0].Rows[0]["SelesID"].ToString() != "")
                {
                    model.SelesID = int.Parse(ds.Tables[0].Rows[0]["SelesID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RepertoryListID"] != null && ds.Tables[0].Rows[0]["RepertoryListID"].ToString() != "")
                {
                    model.RepertoryListID = int.Parse(ds.Tables[0].Rows[0]["RepertoryListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RepertoryID"] != null && ds.Tables[0].Rows[0]["RepertoryID"].ToString() != "")
                {
                    model.RepertoryID = int.Parse(ds.Tables[0].Rows[0]["RepertoryID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PSOID"] != null && ds.Tables[0].Rows[0]["PSOID"].ToString() != "")
                {
                    model.PSOID = int.Parse(ds.Tables[0].Rows[0]["PSOID"].ToString());
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
            strSql.Append("select  1 as A,ID,MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BrandID,MListID,SalesInfoID,MeasureID,SelesID,RepertoryListID,RepertoryID,PSOID,0 as RowID ");
            strSql.Append(" FROM ProduceSellInfo ");
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
            strSql.Append(" ID,MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BrandID,MListID,SalesInfoID,MeasureID,SelesID,RepertoryListID,RepertoryID,PSOID ");
            strSql.Append(" FROM ProduceSellInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteInfo(int PSOID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProduceSellInfo ");
            strSql.Append(" where (PSOID=@PSOID) ");//And (MaterielID=@MaterielID) And (BrandID=@BrandID) ");
            SqlParameter[] parameters = {
					new SqlParameter("@PSOID", SqlDbType.Int,4)};
            parameters[0].Value = PSOID;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProduceSellInfo ");
            strSql.Append(" where (MainID=@MainID)  ");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetReport(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      Materiel WHERE   (ID = ProduceSellInfo.MaterielID)) AS MaterielName, ");
            strSql.Append(" (SELECT   Name FROM      Materiel AS Materiel_1 WHERE   (ID = ProduceSellInfo.BrandID)) AS BrandName, ");
            strSql.Append(" (SELECT   Name FROM      Color WHERE   (ID = ProduceSellInfo.ColorID)) AS ColorName, ProduceSellInfo.Amount, ");
            strSql.Append("  (SELECT   Name FROM      Color AS Color_1 WHERE   (ID = ProduceSellInfo.ColorOneID)) AS ColorOneName,");
            strSql.Append("  (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = ProduceSellInfo.ColorTwoID)) AS ColorTwoName,");
            strSql.Append(" Size.Name AS SizeName FROM      ProduceSellInfo INNER JOIN Size ON ProduceSellInfo.SizeID = Size.ID ");
            strSql.Append(" WHERE   (ProduceSellInfo.MainID = @MainID) ORDER BY Size.Orders");
            SqlParameter[] sps = { new SqlParameter("@MainID",MainID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public int CheckSellAmount(int MainID, int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(Repertory.ID) AS Expr1 FROM      Repertory INNER JOIN (SELECT   MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, ");
            strSql.Append(" BrandID, MeasureID, SUM(Amount) AS Amount FROM      ProduceSellInfo AS ProduceSellInfo_1 WHERE   (MainID = @MainID) GROUP BY MaterielID, ");
            strSql.Append(" ColorID, ColorOneID, ColorTwoID, SizeID, BrandID, MeasureID) AS ProduceSellInfo ON  Repertory.MaterielID = ProduceSellInfo.MaterielID AND ");
            strSql.Append(" Repertory.ColorID = ProduceSellInfo.ColorID AND Repertory.ColorOneID = ProduceSellInfo.ColorOneID AND Repertory.ColorTwoID = ");
            strSql.Append(" ProduceSellInfo.ColorTwoID AND Repertory.SizeID = ProduceSellInfo.SizeID AND Repertory.BrandID = ProduceSellInfo.BrandID AND ");
            strSql.Append(" Repertory.MeasureID = ProduceSellInfo.MeasureID WHERE   (Repertory.DepartmentID = @DepotID) AND (Repertory.Amount - ProduceSellInfo.Amount < 0)");
            SqlParameter[] sps = {new SqlParameter("@MainID",MainID),new SqlParameter("@DepotID",DepotID) };
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString(), sps));
        }
        public DataSet GetColorSumAmount(int MainID, int SalesID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Color.Name, ProduceSellInfo.Amount FROM      Color INNER JOIN ProduceSellInfo ON Color.ID = ProduceSellInfo.ColorID ");
            strSql.Append(" WHERE   (ProduceSellInfo.MainID = @MainID) AND (ProduceSellInfo.SelesID = @SelesID) GROUP BY Color.Name, ProduceSellInfo.Amount");
            SqlParameter[] sps = {new SqlParameter("@MainID",MainID),new SqlParameter("@SelesID",SalesID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSumAmount(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT     MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, SUM(Amount) AS Amount, BrandID, SelesID  FROM         ProduceSellInfo ");
            strSql.Append(" WHERE     (MainID = "+MainID+") GROUP BY MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID , BrandID, SelesID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetListForOne(int Top, int CompanyID, int MaterielID, DateTime dt1, DateTime dt2)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT  ");
            if (Top > 0)
                strSql.Append(" Top (@Top) ");
            strSql.Append(" ProduceSell.ID, ProduceSell.CompanyID AS 客户,ProduceSell.DateTime AS 日期, ProduceSell.Num AS 编号,  ProduceSellOne.MaterielID AS 款号, ");
            strSql.Append(" ProduceSellOne.BrandID AS 商标, ProduceSellOne.Amount AS 数量, ProduceSellOne.MeasureID AS 单位, ProduceSellOne.Price AS 单价, ");
            strSql.Append(" ProduceSellOne.Money AS 金额, ProduceSellOne.Remark as 备注,ProduceSell.IsVerify as 状态,ProduceSellOne.BoxMeasureID as 销售单位 FROM  ProduceSell INNER JOIN  ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID ");
            strSql.Append(" Where (ProduceSell.State=21) ");
           if (CompanyID > 0)
                strSql.Append(" AND (ProduceSell.CompanyID = @CompanyID) ");
            if(MaterielID>0)
                strSql.Append(" AND (ProduceSellOne.MaterielID = @MaterielID) ");
            if (dt1 > Convert.ToDateTime("1900-1-1"))
                strSql.Append(" And (ProduceSell.DateTime>@dt1) And (ProduceSell.DateTime<@dt2)");
            strSql.Append(" GROUP BY ProduceSell.ID, ProduceSell.CompanyID, ProduceSell.Num, ProduceSell.DateTime, ProduceSellOne.MaterielID, ProduceSellOne.BrandID, ");
            strSql.Append(" ProduceSellOne.Amount, ProduceSellOne.MeasureID, ProduceSellOne.Price, ProduceSellOne.Money, ProduceSellOne.Remark,ProduceSell.IsVerify,ProduceSellOne.BoxMeasureID Order By 日期 DESC");
            SqlParameter[] sps = { new SqlParameter("@Top", Top), new SqlParameter("@CompanyID", CompanyID),new SqlParameter("@MaterielID",MaterielID),new SqlParameter("@dt1",dt1),
                                 new SqlParameter("@dt2",dt2)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSumColor(int PSOID)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = ProduceSellInfo.ColorID)) AS ColorName, ColorID, SUM(Amount) AS SumAmount, ");
            strSql.Append(" (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = ProduceSellInfo.ColorOneID)) AS ColorOneName, ColorOneID, ");
            strSql.Append(" (SELECT   Name FROM      Color AS Color_1 WHERE   (ID = ProduceSellInfo.ColorTwoID)) AS ColorTwoName, ColorTwoID ");
            strSql.Append(" FROM      ProduceSellInfo WHERE   (PSOID = @PSOID) GROUP BY ColorID, ColorOneID, ColorTwoID ORDER BY MAX(ID)");
            SqlParameter[] sps = { new SqlParameter("@PSOID", PSOID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSize(int PSOID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      Size WHERE   (ID = ProduceSellInfo.SizeID)) AS SizeName, SizeID, SUM(Amount) AS SumAmount ");
            strSql.Append(" , (SELECT   Orders FROM      Size AS Size_1 WHERE   (ID = ProduceSellInfo.SizeID)) AS Orders");
            strSql.Append(" FROM      ProduceSellInfo WHERE   (PSOID = @PSOID) GROUP BY SizeID");
            strSql.Append(" ORDER BY Orders");
            SqlParameter[] sps = { new SqlParameter("@PSOID", PSOID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
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
			parameters[0].Value = "ProduceSellInfo";
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

