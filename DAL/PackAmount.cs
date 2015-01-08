using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:PackAmount
    /// </summary>
    public partial class PackAmount
    {
        public PackAmount()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PackAmount");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.PackAmount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PackAmount(");
            strSql.Append("MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark)");
            strSql.Append(" values (");
            strSql.Append("@MListID,@Amount,@MeasureID,@DepartmentID,@MaterielID,@SizeID,@ColorID,@ColorOneID,@ColorTwoID,@BrandID,@CompanyID,@PlanID,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@PlanID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
            parameters[0].Value = model.MListID;
            parameters[1].Value = model.Amount;
            parameters[2].Value = model.MeasureID;
            parameters[3].Value = model.DepartmentID;
            parameters[4].Value = model.MaterielID;
            parameters[5].Value = model.SizeID;
            parameters[6].Value = model.ColorID;
            parameters[7].Value = model.ColorOneID;
            parameters[8].Value = model.ColorTwoID;
            parameters[9].Value = model.BrandID;
            parameters[10].Value = model.CompanyID;
            parameters[11].Value = model.PlanID;
            parameters[12].Value = model.Remark;

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
        public bool Update(Hownet.Model.PackAmount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PackAmount set ");
            strSql.Append("MListID=@MListID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("PlanID=@PlanID,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@PlanID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MListID;
            parameters[1].Value = model.Amount;
            parameters[2].Value = model.MeasureID;
            parameters[3].Value = model.DepartmentID;
            parameters[4].Value = model.MaterielID;
            parameters[5].Value = model.SizeID;
            parameters[6].Value = model.ColorID;
            parameters[7].Value = model.ColorOneID;
            parameters[8].Value = model.ColorTwoID;
            parameters[9].Value = model.BrandID;
            parameters[10].Value = model.CompanyID;
            parameters[11].Value = model.PlanID;
            parameters[12].Value = model.Remark;
            parameters[13].Value = model.ID;

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
            strSql.Append("delete from PackAmount ");
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
            strSql.Append("delete from PackAmount ");
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
        public Hownet.Model.PackAmount GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark from PackAmount ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.PackAmount model = new Hownet.Model.PackAmount();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"] != null && ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepartmentID"] != null && ds.Tables[0].Rows[0]["DepartmentID"].ToString() != "")
                {
                    model.DepartmentID = int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"] != null && ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
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
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PlanID"] != null && ds.Tables[0].Rows[0]["PlanID"].ToString() != "")
                {
                    model.PlanID = int.Parse(ds.Tables[0].Rows[0]["PlanID"].ToString());
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
            strSql.Append("select  1 as A,ID,MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark ");
            strSql.Append(" FROM PackAmount ");
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
            strSql.Append(" ID,MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark ");
            strSql.Append(" FROM PackAmount ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 审核/弃审入库
        /// </summary>
        /// <param name="model"></param>
        /// <param name="t">真为入库，假为出库</param>
        public void InOrOut(Model.PackAmount model, bool t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PackAmount set ");
            if (t)
                strSql.Append("Amount=Amount+ @Amount ");
            else
                strSql.Append("Amount=Amount- @Amount");
            strSql.Append(" where (MListID=@MListID) And (DepartmentID=@DepartmentID) And (MeasureID=@MeasureID) And(PlanID=@PlanID)");
            SqlParameter[] parameters = {
			        new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
                    new SqlParameter("@PlanID",SqlDbType.Int,4)};
            parameters[0].Value = model.MListID;
            parameters[1].Value = model.Amount;
            parameters[2].Value = model.MeasureID;
            parameters[3].Value = model.DepartmentID;
            parameters[4].Value = model.PlanID;
            if (DbHelperSQL.ExecuteSql(strSql.ToString(), parameters) == 0 && t)
            {
                Add(model);
            }
        }
        public DataSet GetAmount()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Materiel.Name AS MaterielName, Materiel_1.Name AS BrandName, Color.Name AS ColorName,(Select Name From Color as C where (C.ID=PackAmount.ColorOneID)) As ColorOneName, ");
            strSql.Append("(Select Name From Color as CC where (CC.ID=PackAmount.ColorTwoID)) As ColorTwoName, Size.Name AS SizeName, CAST(PackAmount.Amount AS real) AS Amount, CONVERT(varchar(100), ");
            strSql.Append(" ProductionPlan.DateTime, 112) + '-' + REPLACE(STR(ProductionPlan.Num, 3, 0), ' ', '0') ");
            strSql.Append(" + '-' + REPLACE(STR(ProductTaskMain.Num, 3, 0), ' ', '0') AS Num FROM      Color INNER JOIN ");
            strSql.Append(" PackAmount ON Color.ID = PackAmount.ColorID INNER JOIN Size ON PackAmount.SizeID = Size.ID INNER JOIN ");
            strSql.Append(" Materiel ON PackAmount.MaterielID = Materiel.ID INNER JOIN Materiel AS Materiel_1 ON PackAmount.BrandID ");
            strSql.Append(" = Materiel_1.ID LEFT OUTER  JOIN ProductTaskMain ON PackAmount.PlanID = ProductTaskMain.ID LEFT OUTER JOIN ");
            strSql.Append(" ProductionPlan ON ProductTaskMain.ParentID = ProductionPlan.ID WHERE   (CAST(PackAmount.Amount AS real) > 0)");
            return DbHelperSQL.Query(strSql.ToString());

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetPackList(int PackID)
        {
            Hownet.DAL.OtherType dalOT = new OtherType();
            DataTable dtOT = dalOT.GetTypeList("成品单位").Tables[0];
            int PackMeasureID = 0;
            DataRow[] drs = dtOT.Select("(Name='仓储单位')");
            if (drs.Length == 1)
                PackMeasureID = Convert.ToInt32(drs[0]["Value"]);
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  1 as A,0 as ID, ID as PackAmountID,MListID,cast( Amount as real) as PackAmount,0 as MainID, 0 as NowAmount, MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID as TaskID,Remark," + PackMeasureID + " as DepotMeasureID,BrandID as DepotBrandID,0 as DepotInfoID ");
            strSql.Append(" FROM PackAmount where (Amount>0) And (DepartmentID="+PackID+") Order by PlanID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetP2PackList(DateTime dt1, DateTime dt2, int MaterielID, int DeparmentID,int DTID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Product2Depot.DateTime, Product2Depot.DeparmentID, Product2DepotInfo.MaterielID, ");
            strSql.Append(" Product2DepotInfo.ColorID, Product2DepotInfo.ColorOneID, Product2DepotInfo.ColorTwoID, ");
            strSql.Append(" Product2DepotInfo.SizeID, Product2DepotInfo.BrandID, Product2DepotInfo.TaskID, ");
            strSql.Append("   (CASE WHEN (Product2Depot.DeparmentTypeID = 3) THEN (SELECT     Name FROM          company WHERE      (ID = Product2Depot.DeparmentID)) ELSE ");
            strSql.Append(" (SELECT     Name FROM          Deparment WHERE      (ID = Product2Depot.DeparmentID)) END) AS DepName ,");
            strSql.Append(" Product2DepotInfo.Amount FROM      Product2DepotInfo INNER JOIN Product2Depot ON Product2DepotInfo.MainID = Product2Depot.ID ");
            strSql.Append(" WHERE Product2Depot.IsVerify=3 And   (Product2Depot.TypeID = 46) AND (Product2Depot.DateTime > @dt1 AND Product2Depot.DateTime < @dt2) And ( Product2Depot.DeparmentTypeID=" + DTID + ")");
            if(DeparmentID>0)
                strSql.Append(" AND (Product2Depot.DeparmentID = @DepID) ");
            if(MaterielID>0)
                strSql.Append(" AND (Product2DepotInfo.MaterielID = @MatID)");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@DepID", DeparmentID), new SqlParameter("@MatID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetP2DeoptList(DateTime dt1, DateTime dt2, int MaterielID, int DeparmentID,int DTID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Product2Depot.DateTime, Product2Depot.DeparmentID, Product2DepotInfo.MaterielID, ");
            strSql.Append(" Product2DepotInfo.ColorID, Product2DepotInfo.ColorOneID, Product2DepotInfo.ColorTwoID, ");
            strSql.Append(" Product2DepotInfo.SizeID, Product2DepotInfo.BrandID, Product2DepotInfo.TaskID, ");
            strSql.Append("   (CASE WHEN (Product2Depot.DeparmentTypeID = 3) THEN (SELECT     Name FROM          company WHERE      (ID = Product2Depot.DeparmentID)) ELSE ");
            strSql.Append(" (SELECT     Name FROM          Deparment WHERE      (ID = Product2Depot.DeparmentID)) END) AS DepName ,");
            strSql.Append(" Product2DepotInfo.Amount FROM      Product2DepotInfo INNER JOIN Product2Depot ON Product2DepotInfo.MainID = Product2Depot.ID ");
            strSql.Append(" WHERE Product2Depot.IsVerify=3 And   (Product2Depot.TypeID = 8) AND (Product2Depot.DateTime > @dt1 AND Product2Depot.DateTime < @dt2) And ( Product2Depot.DeparmentTypeID="+DTID+")");
            if (DeparmentID > 0)
                strSql.Append(" AND (Product2Depot.DeparmentID = @DepID) ");
            if (MaterielID > 0)
                strSql.Append(" AND (Product2DepotInfo.MaterielID = @MatID)");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@DepID", DeparmentID), new SqlParameter("@MatID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetLinLiaoList(DateTime dt1, DateTime dt2, int DepID, int MatID, int _deparmentTypeID,int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   StockBack.Num,  StockBack.DataTime, StockBackInfo.ID, StockBackInfo.MainID, StockBackInfo.StockInfoID, StockBackInfo.MaterielID, StockBack.DepotID, StockBackInfo.ColorID, ");
            strSql.Append(" StockBackInfo.ColorOneID, StockBackInfo.ColorTwoID, StockBackInfo.SizeID, StockBackInfo.CompanyMeasureID, StockBackInfo.Amount, StockBackInfo.Remark,StockBack.State, ");
            strSql.Append(" StockBackInfo.MListID, (CASE WHEN (DeparmentType = 3) THEN (SELECT     Name ");
            strSql.Append(" FROM          company WHERE      (ID = StockBack.Companyid)) ELSE (SELECT     Name FROM          Deparment WHERE      (ID = StockBack.Companyid)) END) AS DepName, ");
            strSql.Append(" StockBackInfo.Price, StockBackInfo.Money FROM         StockBack INNER JOIN  StockBackInfo ON StockBack.ID = StockBackInfo.MainID ");
            strSql.Append(" WHERE     (StockBack.IsVerify = 3) AND (StockBack.DataTime >= @dt1) AND (StockBack.DataTime < @dt2) AND (StockBack.State = 60) ");//(StockBack.CompanyID = @DepID) And 
            if(TaskID>0)
            strSql.Append(" And (StockBack.TaskID=" + TaskID + ")");

            strSql.Append(" union all ");
            strSql.Append(" SELECT   StockBack_1.Num,  StockBack_1.DataTime, StockBackInfo_1.ID, StockBackInfo_1.MainID, StockBackInfo_1.StockInfoID, StockBackInfo_1.MaterielID, StockBack_1.DepotID, ");
            strSql.Append(" StockBackInfo_1.ColorID, StockBackInfo_1.ColorOneID, StockBackInfo_1.ColorTwoID, StockBackInfo_1.SizeID, StockBackInfo_1.CompanyMeasureID,");
            strSql.Append(" StockBackInfo_1.Amount, StockBackInfo_1.Remark, StockBack_1.State, StockBackInfo_1.MListID, (CASE WHEN (StockBack_1.DeparmentType = 3) THEN (SELECT     Name  FROM          company ");
            strSql.Append(" WHERE      (ID = StockBack_1.Companyid)) ELSE (SELECT     Name FROM          Deparment WHERE      (ID = StockBack_1.Companyid)) END) AS DepName, ");
            strSql.Append(" StockBackInfo_1.Price, StockBackInfo_1.Money FROM         StockBack AS StockBack_1 INNER JOIN StockBackInfo AS StockBackInfo_1 ON StockBack_1.ID = ");
            strSql.Append(" StockBackInfo_1.MainID LEFT OUTER JOIN ProductTaskMain ON StockBack_1.TaskID = ProductTaskMain.ID ");
            strSql.Append(" WHERE     (StockBack_1.IsVerify = 3) AND (StockBack_1.DataTime >= @dt1) AND (StockBack_1.DataTime < @dt2) AND (StockBack_1.State = 26) ");
            if(TaskID>0)
            strSql.Append(" AND (ProductTaskMain.ParentID = " + TaskID + ")");

            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@DepID", DepID), new SqlParameter("@MatID", MatID) };
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
            parameters[0].Value = "PackAmount";
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

