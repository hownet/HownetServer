using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类Repertory。
    /// </summary>
    public class Repertory
    {
        public Repertory()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "Repertory");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Repertory");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Repertory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Repertory(");
            strSql.Append("MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,MaterielName,ColorName,SizeName,ColorOneName,ColorTwoName,BrandName,CompanyName,MeasureName,DeparmentName,DepotInfoID,DepotInfoName,Price,Money)");
            strSql.Append(" values (");
            strSql.Append("@MListID,@Amount,@MeasureID,@DepartmentID,@MaterielID,@SizeID,@ColorID,@ColorOneID,@ColorTwoID,@BrandID,@CompanyID,@PlanID,@Remark,@SupplierID,@SupplierName,@SupplierSN,@SpecID,@SpecName,@MaterielName,@ColorName,@SizeName,@ColorOneName,@ColorTwoName,@BrandName,@CompanyName,@MeasureName,@DeparmentName,@DepotInfoID,@DepotInfoName,@Price,@Money)");
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
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@SupplierID", SqlDbType.Int,4),
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierSN", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorOneName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorTwoName", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@MeasureName", SqlDbType.NVarChar,50),
					new SqlParameter("@DeparmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@DepotInfoName", SqlDbType.NVarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9)};
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
            if (model.Remark == null)
                model.Remark = string.Empty;
            parameters[12].Value = model.Remark;
            parameters[13].Value = model.SupplierID;
            if (model.SupplierName == null)
                model.SupplierName = string.Empty;
            parameters[14].Value = model.SupplierName;
            if (model.SupplierSN == null)
                model.SupplierSN = string.Empty;
            parameters[15].Value = model.SupplierSN;
            parameters[16].Value = model.SpecID;
            if (model.SpecName == null)
                model.SpecName = string.Empty;
            parameters[17].Value = model.SpecName;
            if (model.MaterielName == null)
                model.MaterielName = string.Empty;
            parameters[18].Value = model.MaterielName;
            if (model.ColorName == null)
                model.ColorName = string.Empty;
            parameters[19].Value = model.ColorName;
            if (model.SizeName == null)
                model.SizeName = string.Empty;
            parameters[20].Value = model.SizeName;
            if (model.ColorOneName == null)
                model.ColorOneName = string.Empty;
            parameters[21].Value = model.ColorOneName;
            if (model.ColorTwoName == null)
                model.ColorTwoName = string.Empty;
            parameters[22].Value = model.ColorTwoName;
            if (model.BrandName == null)
                model.BrandName = string.Empty;
            parameters[23].Value = model.BrandName;
            if (model.CompanyName == null)
                model.CompanyName = string.Empty;
            parameters[24].Value = model.CompanyName;
            if (model.MeasureName == null)
                model.MeasureName = string.Empty;
            parameters[25].Value = model.MeasureName;
            if (model.DeparmentName == null)
                model.DeparmentName = string.Empty;
            parameters[26].Value = model.DeparmentName;
            parameters[27].Value = model.DepotInfoID;
            if (model.DepotInfoName == null)
                model.DepotInfoName = string.Empty;
            parameters[28].Value = model.DepotInfoName;
            parameters[29].Value = model.Price;
            parameters[30].Value = model.Money;

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
        public bool Update(Hownet.Model.Repertory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Repertory set ");
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
            strSql.Append("Remark=@Remark,");
            strSql.Append("SupplierID=@SupplierID,");
            strSql.Append("SupplierName=@SupplierName,");
            strSql.Append("SupplierSN=@SupplierSN,");
            strSql.Append("SpecID=@SpecID,");
            strSql.Append("SpecName=@SpecName,");
            strSql.Append("MaterielName=@MaterielName,");
            strSql.Append("ColorName=@ColorName,");
            strSql.Append("SizeName=@SizeName,");
            strSql.Append("ColorOneName=@ColorOneName,");
            strSql.Append("ColorTwoName=@ColorTwoName,");
            strSql.Append("BrandName=@BrandName,");
            strSql.Append("CompanyName=@CompanyName,");
            strSql.Append("MeasureName=@MeasureName,");
            strSql.Append("DeparmentName=@DeparmentName,");
            strSql.Append("DepotInfoID=@DepotInfoID,");
            strSql.Append("DepotInfoName=@DepotInfoName,");
            strSql.Append("Price=@Price,");
            strSql.Append("Money=@Money");
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
					new SqlParameter("@SupplierID", SqlDbType.Int,4),
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierSN", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorOneName", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorTwoName", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyName", SqlDbType.NVarChar,50),
					new SqlParameter("@MeasureName", SqlDbType.NVarChar,50),
					new SqlParameter("@DeparmentName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@DepotInfoName", SqlDbType.NVarChar,50),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
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
            parameters[13].Value = model.SupplierID;
            parameters[14].Value = model.SupplierName;
            parameters[15].Value = model.SupplierSN;
            parameters[16].Value = model.SpecID;
            parameters[17].Value = model.SpecName;
            parameters[18].Value = model.MaterielName;
            parameters[19].Value = model.ColorName;
            parameters[20].Value = model.SizeName;
            parameters[21].Value = model.ColorOneName;
            parameters[22].Value = model.ColorTwoName;
            parameters[23].Value = model.BrandName;
            parameters[24].Value = model.CompanyName;
            parameters[25].Value = model.MeasureName;
            parameters[26].Value = model.DeparmentName;
            parameters[27].Value = model.DepotInfoID;
            parameters[28].Value = model.DepotInfoName;
            parameters[29].Value = model.Price;
            parameters[30].Value = model.Money;
            parameters[31].Value = model.ID;

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
            strSql.Append("delete from Repertory ");
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
            strSql.Append("delete from Repertory ");
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
        public Hownet.Model.Repertory GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,MaterielName,ColorName,SizeName,ColorOneName,ColorTwoName,BrandName,CompanyName,MeasureName,DeparmentName,DepotInfoID,DepotInfoName,Price,Money from Repertory ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.Repertory model = new Hownet.Model.Repertory();
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
                if (ds.Tables[0].Rows[0]["SupplierID"] != null && ds.Tables[0].Rows[0]["SupplierID"].ToString() != "")
                {
                    model.SupplierID = int.Parse(ds.Tables[0].Rows[0]["SupplierID"].ToString());
                }
                model.SupplierName = ds.Tables[0].Rows[0]["SupplierName"].ToString();
                model.SupplierSN = ds.Tables[0].Rows[0]["SupplierSN"].ToString();
                if (ds.Tables[0].Rows[0]["SpecID"] != null && ds.Tables[0].Rows[0]["SpecID"].ToString() != "")
                {
                    model.SpecID = int.Parse(ds.Tables[0].Rows[0]["SpecID"].ToString());
                }
                model.SpecName = ds.Tables[0].Rows[0]["SpecName"].ToString();
                model.MaterielName = ds.Tables[0].Rows[0]["MaterielName"].ToString();
                model.ColorName = ds.Tables[0].Rows[0]["ColorName"].ToString();
                model.SizeName = ds.Tables[0].Rows[0]["SizeName"].ToString();
                model.ColorOneName = ds.Tables[0].Rows[0]["ColorOneName"].ToString();
                model.ColorTwoName = ds.Tables[0].Rows[0]["ColorTwoName"].ToString();
                model.BrandName = ds.Tables[0].Rows[0]["BrandName"].ToString();
                model.CompanyName = ds.Tables[0].Rows[0]["CompanyName"].ToString();
                model.MeasureName = ds.Tables[0].Rows[0]["MeasureName"].ToString();
                model.DeparmentName = ds.Tables[0].Rows[0]["DeparmentName"].ToString();
                if (ds.Tables[0].Rows[0]["DepotInfoID"] != null && ds.Tables[0].Rows[0]["DepotInfoID"].ToString() != "")
                {
                    model.DepotInfoID = int.Parse(ds.Tables[0].Rows[0]["DepotInfoID"].ToString());
                }
                model.DepotInfoName = ds.Tables[0].Rows[0]["DepotInfoName"].ToString();
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
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
            strSql.Append("select  1 as A,ID,MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,MaterielName,ColorName,SizeName,ColorOneName,ColorTwoName,BrandName,CompanyName,MeasureName,DeparmentName,DepotInfoID,DepotInfoName,Price,Money ");
            strSql.Append(" FROM Repertory ");
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
            strSql.Append(" ID,MListID,Amount,MeasureID,DepartmentID,MaterielID,SizeID,ColorID,ColorOneID,ColorTwoID,BrandID,CompanyID,PlanID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,MaterielName,ColorName,SizeName,ColorOneName,ColorTwoName,BrandName,CompanyName,MeasureName,DeparmentName,DepotInfoID,DepotInfoName,Price,Money ");
            strSql.Append(" FROM Repertory ");
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
        public int InOrOut(Model.Repertory model, bool t)
        {
            int ID = 0;
            if (t)
            {
                DataTable dtRep = GetList("(MListID=" + model.MListID + ") And (DepartmentID=" + model.DepartmentID + ") And (MeasureID=" + model.MeasureID + ")").Tables[0];
                if (dtRep.Rows.Count > 0)
                {
                    decimal amount = Convert.ToDecimal(dtRep.Rows[0]["Amount"]) + model.Amount; ;
                    decimal money = Convert.ToDecimal(dtRep.Rows[0]["Money"]) + model.Money;
                    try
                    {
                        model.Price = money / amount;
                    }
                    catch
                    {

                    }
                    ID = Convert.ToInt32(dtRep.Rows[0]["ID"]);
                }
            }
            
            StringBuilder strSql = new StringBuilder();
            



            strSql.Append("update Repertory set ");
            if (t)
                strSql.Append("Amount=Amount+ @Amount,Price=@Price,Money=(Amount+ @Amount)*@Price ");
            else
                strSql.Append("Amount=Amount- @Amount,Money=(Amount- @Amount)*Price");
            strSql.Append(" where (MListID=@MListID) And (DepartmentID=@DepartmentID) And (MeasureID=@MeasureID) ");
            SqlParameter[] parameters = {
			        new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
                    new SqlParameter("@Price",SqlDbType.Decimal,9)};
            parameters[0].Value = model.MListID;
            parameters[1].Value = model.Amount;
            parameters[2].Value = model.MeasureID;
            parameters[3].Value = model.DepartmentID;
            parameters[4].Value = model.Price;
            int r = DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
            if (r == 0 && t)
            {
              ID=  Add(model);
            }
            else if (r == 0 && !t)
            {
               // model.Amount = model.Amount * -1;
               //ID= Add(model);
                return -1;
            }
            return ID;
        }
        /// <summary>
        /// 成品库存列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetProductList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Materiel.Name AS MaterielName, Color.Name AS ColorName, Size.Name AS SizeName,  Materiel_1.Name AS BrandName, ");
            strSql.Append("  (SELECT   Name FROM      Color AS color_1 WHERE   (ID = Repertory.ColorOneID)) AS ColorOneName, ");
            strSql.Append(" (SELECT   Name FROM      Color AS color_2 WHERE   (ID = Repertory.ColorTwoID)) AS ColorTwoName,");
            strSql.Append(" CAST(Repertory.Amount AS Real) AS Amount FROM      Repertory INNER JOIN Materiel ON Repertory.MaterielID = Materiel.ID INNER JOIN ");
            strSql.Append(" Color ON Repertory.ColorID = Color.ID INNER JOIN Size ON Repertory.SizeID = Size.ID LEFT OUTER JOIN Materiel AS Materiel_1 ON ");
            strSql.Append(" Repertory.BrandID = Materiel_1.ID WHERE   (Materiel.AttributeID = 4) And (Repertory.Amount<>0) ORDER BY MaterielName, Size.Orders");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetColor(int MaterielID, int BrandID, int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   (SELECT   Name FROM  Color WHERE   (ID = Repertory.ColorID)) AS ColorName, ColorID, CAST(SUM(Amount) AS real) AS SumAmount, ");
            strSql.Append(" (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = Repertory.ColorOneID)) AS ColorOneName, ColorOneID, (SELECT   Name ");
            strSql.Append(" FROM      Color AS Color_1 WHERE   (ID = Repertory.ColorTwoID)) AS ColorTwoName, ColorTwoID FROM      Repertory ");
            strSql.Append(" WHERE   (MaterielID = @MaterielID) AND (BrandID = @BrandID) AND (DepartmentID = @DepotID) And (Amount>-1) ");
            strSql.Append(" GROUP BY ColorID, ColorOneID, ColorTwoID");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID), new SqlParameter("@DepotID", DepotID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSize(int MaterielID, int BrandID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      Size WHERE   (ID = Repertory.SizeID)) AS SizeName, SizeID, CAST(SUM(Amount) AS real) AS SumAmount ");
            strSql.Append(" FROM      Repertory WHERE   (MaterielID = @MaterielID) AND (BrandID = @BrandID) And (Amount>-1) GROUP BY SizeID");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 成品库存列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetMaterielList(int DepotID, int MTID,int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            string ddd = string.Empty;
            string mmm = string.Empty;
            strSql.Append("SELECT  1 as A,Repertory.ID,Repertory.MListID, Repertory.MeasureID, Repertory.MaterielID, Repertory.SizeID, Repertory.ColorID, Repertory.ColorOneID, Repertory.ColorTwoID, Repertory.BrandID,Repertory.Remark, Repertory.DepartmentID,Materiel.Remark as MaterielRemark,Color.Remark as ColorRemark,");
            strSql.Append(" Repertory.PlanID, CAST(SUM(Repertory.Amount) AS real) AS Amount, Materiel.TypeID,Materiel.AttributeID,Materiel.ChengBengJ,CAST(Materiel.ChengBengJ * Repertory.Amount AS real) as ChengBengJMoney, Materiel.YiJiDaiLiJia,CAST(Materiel.YiJiDaiLiJia * Repertory.Amount AS real) as YiJiDaiLiJiaMoney FROM  Repertory INNER JOIN ");
            strSql.Append(" Materiel ON Repertory.MaterielID = Materiel.ID  LEFT OUTER JOIN Color ON Repertory.ColorID = Color.ID Where (Amount<>0) ");
            if (DepotID > 0 || MTID > 0)
            {
                strSql.Append(" And   ");
                if (DepotID > 0)
                    ddd = " (Repertory.DepartmentID = @DepotID) ";
                if (MTID > 0)
                    mmm = "(Materiel.TypeID = @MTID)";
                if (DepotID > 0 && MTID > 0)
                    ddd = ddd + " And ";
                
            }
            strSql.Append(ddd);
            strSql.Append(mmm);
            if (MaterielID > 0)
                strSql.Append(" And ( Repertory.MaterielID=" + MaterielID + ")");

            strSql.Append(" GROUP BY Repertory.ID,Repertory.MeasureID, Repertory.MaterielID, Repertory.SizeID, Repertory.ColorID, Materiel.Remark,Repertory.BrandID,Repertory.Remark, Repertory.DepartmentID, Repertory.ColorOneID, Repertory.ColorTwoID,Color.Remark,");
            strSql.Append(" Repertory.PlanID, Materiel.TypeID,Materiel.AttributeID,Materiel.ChengBengJ,Materiel.YiJiDaiLiJia,Materiel.ChengBengJ*Amount,Materiel.YiJiDaiLiJia * Repertory.Amount,Repertory.MListID");
            //strSql.Append("   GROUP BY Materiel_2.Name, Repertory.MaterielID, Repertory.ColorID, Repertory.SizeID, Repertory.MeasureID ");
            //strSql.Append(" ORDER BY Repertory.MaterielID, Repertory.ColorID, Repertory.SizeID ");
            SqlParameter[] sps = { new SqlParameter("@DepotID", DepotID), new SqlParameter("@MTID", MTID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public decimal GetAmountByModel(Hownet.Model.Repertory model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Amount FROM      Repertory WHERE   (MListID = @MListID) AND (DepartmentID = @DepID)");
            SqlParameter[] sps = { new SqlParameter("@MListID", model.MListID), new SqlParameter("@DepID", model.DepartmentID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return Convert.ToDecimal(o);
            else
                return 0;
        }
        public DataSet GetGroupList(int MaterielID, int BrandID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(Amount) AS Amount, SizeID, ColorID, ColorOneID, ColorTwoID, DepartmentID FROM      Repertory ");
            strSql.Append(" GROUP BY SizeID, ColorID, ColorOneID, ColorTwoID, DepartmentID, BrandID, MaterielID HAVING   (BrandID = ");
            strSql.Append(" @BrandID) AND (MaterielID = @MaterielID)");
            SqlParameter[] sps = { new SqlParameter("@BrandID", BrandID), new SqlParameter("@MaterielID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetReAmount(int MaterielID, int BrandID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ColorID, ColorOneID, ColorTwoID, SizeID,Cast( SUM(Amount) as Real) AS Amount FROM      Repertory ");
            strSql.Append(" WHERE   (MaterielID = @MaterielID) AND (BrandID = @BrandID) And (Amount > 0) GROUP BY SizeID, ColorID, ColorOneID, ");
            strSql.Append(" ColorTwoID  ");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 为分析窗体获取库存数量
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet GetFenXi(int AttributeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CAST(SUM(Repertory.Amount) AS real) AS Amount, Repertory.MListID FROM Repertory INNER JOIN ");
            strSql.Append(" Materiel ON Repertory.MaterielID = Materiel.ID WHERE (Materiel.AttributeID = @AttID) AND (Repertory.Amount > 0) ");
            strSql.Append(" GROUP BY Repertory.MListID ");
            SqlParameter[] sps = { new SqlParameter("@Attid", AttributeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回某种物料没有计划单占用的数量
        /// </summary>
        /// <param name="MListID"></param>
        /// <returns></returns>
        public decimal GetNotUseAmount(int MListID, int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   CAST(SUM(Amount) AS real) AS RepAmount FROM  Repertory WHERE   (MListID = " + MListID + ") And (PlanID=0) And (DepartmentID=" + DepotID + ")");
            object o = DbHelperSQL.GetSingle(strSql.ToString());
            if (o != null)
                return Convert.ToDecimal(o);
            else
                return 0;
        }
        /// <summary>
        /// 获取某处仓库中某类物料没有被生产计划占用的数量，用于库存盘点
        /// </summary>
        /// <param name="DepotID"></param>
        /// <param name="MTID"></param>
        /// <returns></returns>
        public DataSet GetInventory(int DepotID, int MTID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Repertory.MaterielID, Repertory.BrandID, Repertory.ColorID, Repertory.ColorOneID, Repertory.ColorTwoID, ");
            strSql.Append(" Repertory.SizeID, Repertory.MeasureID, Repertory.Amount AS PreviousNumber, Repertory.Amount AS NowAmount, ");
            strSql.Append(" Repertory.CompanyID, Repertory.MListID, Repertory.ID AS RepertoryID, 0 AS ID, 0 AS MainID, 0 AS ChangeAmount, '' AS ");
            strSql.Append(" Remark, 3 AS A FROM      Repertory INNER JOIN Materiel ON Repertory.MaterielID = Materiel.ID WHERE ");
            strSql.Append(" (Repertory.DepartmentID = @DepotID) AND (Repertory.PlanID = 0)");
            if (MTID > 0)
                strSql.Append(" And (Materiel.TypeID = @MTID) ");
            SqlParameter[] sps = { new SqlParameter("@MTID", MTID), new SqlParameter("@DepotID", DepotID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 调拨单中调出仓的明细数量
        /// </summary>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetStorageList(int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   3 AS A, 0 AS ID, 0 AS MainID, ID AS StockInfoID, MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, 0 AS Price, ");
            strSql.Append(" MeasureID AS CompanyMeasureID, MeasureID AS DepotMeasureID, CAST(0 AS real) AS Amount, 1 AS Conversion, ");
            strSql.Append(" '' AS Remark, 0 AS PriceAmount, 0 AS NotAmount, 0 AS Money, 0 AS NotPriceAmount, MListID, CompanyID, BrandID, ");
            strSql.Append(" 0 AS IsEnd, PlanID AS DemandID, Amount AS NeedAmount, 0 AS ExcessAmount, '' AS StringTaskID ");
            strSql.Append(" ,0 as Weight ,0 as SpecID,'' as MaterielName,'' as ColorName,'' as ColorOneName,'' as ColorTwoName,'' as SizeName ");
            strSql.Append(" ,'' as BrandName,0 as SupplierID,'' as SupplierName,'' as SupplierSN,'' as SpecName ");
            strSql.Append(" FROM      Repertory ");
            strSql.Append(" WHERE   (DepartmentID = @DeoptID) AND (Amount > 0)");
            SqlParameter[] sps = { new SqlParameter("@DeoptID", DepotID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 在弃审生产计划时，删除已有的库存信息
        /// </summary>
        /// <param name="PlanID"></param>
        /// <returns></returns>
        public void DelByPlanID(int PlanID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Repertory ");
            strSql.Append(" where PlanID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = PlanID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetMaterielInOrOut(DateTime dtOne, DateTime dtTwo, DateTime dtThree)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Repertory.MaterielID, Materiel.Name AS 款号, CAST(SUM(Repertory.Amount) AS real) AS 现有库存 ");
            strSql.Append(" FROM      Repertory INNER JOIN Materiel ON Repertory.MaterielID = Materiel.ID WHERE   (Materiel.AttributeID = 4) ");
            strSql.Append(" GROUP BY Repertory.MaterielID, Materiel.Name, Materiel.AttributeID");
            SqlParameter[] sps = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo), new SqlParameter("@dtThree", dtThree) };
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), sps);
            ds.Tables[0].Columns.Add("开始库存", typeof(int));
            ds.Tables[0].Columns.Add("期间入库数", typeof(int));
            ds.Tables[0].Columns.Add("期间销售数", typeof(int));
            ds.Tables[0].Columns.Add("期间退货数", typeof(int));
            ds.Tables[0].Columns.Add("止到现入库数", typeof(int));
            ds.Tables[0].Columns.Add("止到现销售数", typeof(int));
            ds.Tables[0].Columns.Add("止到现退货数", typeof(int));
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   Repertory.MaterielID, SUM(Product2DepotInfo.Amount) AS 止到现入库数 FROM      Repertory INNER JOIN ");
            strSql.Append(" Product2Depot INNER JOIN Product2DepotInfo ON Product2Depot.ID = Product2DepotInfo.MainID ON  Repertory.MaterielID = Product2DepotInfo.ID ");
            strSql.Append(" WHERE   (Product2Depot.DateTime > @dtThree) GROUP BY Repertory.MaterielID");
            DataSet ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            DataRow[] drs;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["止到现入库数"] = drs[0]["止到现入库数"];
                }
            }


            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   SUM(Product2DepotInfo.Amount) AS 期间入库数, Product2DepotInfo.MaterielID FROM      Product2Depot INNER JOIN ");
            strSql.Append(" Product2DepotInfo ON Product2Depot.ID = Product2DepotInfo.MainID WHERE   (Product2Depot.DateTime > @dtOne) AND ");
            strSql.Append(" (Product2Depot.DateTime < @dtTwo) GROUP BY Product2DepotInfo.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["期间入库数"] = drs[0]["期间入库数"];
                }
            }

            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellOne.MaterielID, SUM(ProduceSellOne.Amount) AS 止到现销售数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID WHERE   (ProduceSell.DateTime > @dtThree) And (State=21) GROUP BY ProduceSellOne.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["止到现销售数"] = drs[0]["止到现销售数"];
                }
            }

            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellOne.MaterielID, SUM(ProduceSellOne.Amount) AS 止到现退货数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID WHERE   (ProduceSell.DateTime > @dtThree) And (State=22) GROUP BY ProduceSellOne.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["止到现退货数"] = drs[0]["止到现退货数"];
                }
            }

            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellOne.MaterielID, SUM(ProduceSellOne.Amount) AS 期间销售数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID WHERE   (ProduceSell.DateTime > @dtOne) AND (ProduceSell.DateTime < @dtTwo)  And (State=21)  ");
            strSql.Append(" GROUP BY ProduceSellOne.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["期间销售数"] = drs[0]["期间销售数"];
                }
            }
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellOne.MaterielID, SUM(ProduceSellOne.Amount) AS 期间退货数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellOne ON ProduceSell.ID = ProduceSellOne.MainID WHERE   (ProduceSell.DateTime > @dtOne) AND (ProduceSell.DateTime < @dtTwo)  And (State=22)  ");
            strSql.Append(" GROUP BY ProduceSellOne.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["期间退货数"] = drs[0]["期间退货数"];
                }
            }
            int Amount, Qin, Zin, Qout, Zout, Qtui, Ztui;
            Amount = Qin = Zin = Qout = Zout = Qtui = Ztui = 0;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Amount = Convert.ToInt32(ds.Tables[0].Rows[i]["现有库存"]);
                if (ds.Tables[0].Rows[i]["期间入库数"] != null && ds.Tables[0].Rows[i]["期间入库数"].ToString() != string.Empty)
                    Qin = Convert.ToInt32(ds.Tables[0].Rows[i]["期间入库数"]);
                if (ds.Tables[0].Rows[i]["期间销售数"] != null && ds.Tables[0].Rows[i]["期间销售数"].ToString() != string.Empty)
                    Qout = Convert.ToInt32(ds.Tables[0].Rows[i]["期间销售数"]);
                if (ds.Tables[0].Rows[i]["止到现销售数"] != null && ds.Tables[0].Rows[i]["止到现销售数"].ToString() != string.Empty)
                    Zout = Convert.ToInt32(ds.Tables[0].Rows[i]["止到现销售数"]);

                if (ds.Tables[0].Rows[i]["期间退货数"] != null && ds.Tables[0].Rows[i]["期间退货数"].ToString() != string.Empty)
                    Qtui = Convert.ToInt32(ds.Tables[0].Rows[i]["期间退货数"]);
                if (ds.Tables[0].Rows[i]["止到现退货数"] != null && ds.Tables[0].Rows[i]["止到现退货数"].ToString() != string.Empty)
                    Ztui = Convert.ToInt32(ds.Tables[0].Rows[i]["止到现退货数"]);
                ds.Tables[0].Rows[i]["开始库存"] = Amount + Zout - Zin + Qout - Qin - Ztui - Qtui;
            }
            return ds;
        }
        public DataSet GetSumReport(DateTime dtOne, DateTime dtTwo, DateTime dtThree)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Repertory.MaterielID, Materiel.Name AS 款号, Repertory.ColorID,Repertory.SizeID, CAST(SUM(Repertory.Amount) AS real) AS 现有库存 ");
            strSql.Append(" FROM      Repertory INNER JOIN Materiel ON Repertory.MaterielID = Materiel.ID WHERE   (Materiel.AttributeID = 4) ");
            strSql.Append(" GROUP BY Repertory.MaterielID, Materiel.Name,Repertory.ColorID,Repertory.SizeID, Materiel.AttributeID");
            SqlParameter[] sps = { new SqlParameter("@dtOne", dtOne), new SqlParameter("@dtTwo", dtTwo), new SqlParameter("@dtThree", dtThree) };
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), sps);
            ds.Tables[0].Columns.Add("开始库存", typeof(int));
            ds.Tables[0].Columns.Add("期间入库数", typeof(int));
            ds.Tables[0].Columns.Add("期间销售数", typeof(int));
            ds.Tables[0].Columns.Add("期间退货数", typeof(int));
            ds.Tables[0].Columns.Add("止到现入库数", typeof(int));
            ds.Tables[0].Columns.Add("止到现销售数", typeof(int));
            ds.Tables[0].Columns.Add("止到现退货数", typeof(int));
            ds.Tables[0].Columns.Add("结束库存", typeof(int));
            ds.Tables[0].Columns.Add("颜色", typeof(string));
            ds.Tables[0].Columns.Add("尺码", typeof(string));
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT     SUM(止到现入库数) AS 止到现入库数, MaterielID, ColorID, SizeID FROM         (SELECT     SUM(Product2DepotInfo.Amount) AS 止到现入库数, Product2DepotInfo.MaterielID, ");
            strSql.Append(" Product2DepotInfo.ColorID, Product2DepotInfo.SizeID FROM          Repertory INNER JOIN Product2Depot INNER JOIN Product2DepotInfo ON Product2Depot.ID = Product2DepotInfo.MainID ");
            strSql.Append(" ON Repertory.MaterielID = Product2DepotInfo.MaterielID INNER JOIN Deparment ON Product2Depot.DepotID = Deparment.ID WHERE      (Product2Depot.DateTime > @dtThree) AND (Deparment.TypeID = 42) ");
            strSql.Append(" GROUP BY Product2DepotInfo.MaterielID, Product2DepotInfo.ColorID, Product2DepotInfo.SizeID UNION ALL SELECT     SUM(Pack2DepotInfo.NowAmount) AS 止到现入库数, Pack2DepotInfo.MaterielID, ");
            strSql.Append(" Pack2DepotInfo.ColorID, Pack2DepotInfo.SizeID FROM         Pack2DepotMain INNER JOIN Pack2DepotInfo ON Pack2DepotMain.ID = Pack2DepotInfo.MainID INNER JOIN ");
            strSql.Append(" Deparment AS Deparment_1 ON Pack2DepotMain.DepotID = Deparment_1.ID WHERE     (Deparment_1.TypeID = 42) AND (Pack2DepotMain.DateTime > @dtThree) ");
            strSql.Append(" GROUP BY Pack2DepotInfo.MaterielID, Pack2DepotInfo.ColorID, Pack2DepotInfo.SizeID) AS T GROUP BY MaterielID, ColorID, SizeID");
            DataSet ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            DataRow[] drs;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ") And (ColorID=" + ds.Tables[0].Rows[i]["ColorID"] + ") And (SizeID=" + ds.Tables[0].Rows[i]["SizeID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["止到现入库数"] = drs[0]["止到现入库数"];
                }
            }


            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT     SUM(期间入库数) AS 期间入库数, MaterielID, ColorID, SizeID FROM         (SELECT     SUM(Product2DepotInfo.Amount) AS 期间入库数, Product2DepotInfo.MaterielID, ");
            strSql.Append(" Product2DepotInfo.ColorID, Product2DepotInfo.SizeID FROM          Product2Depot INNER JOIN Product2DepotInfo ON Product2Depot.ID = Product2DepotInfo.MainID INNER JOIN ");
            strSql.Append(" Deparment ON Product2Depot.DepotID = Deparment.ID WHERE      (Product2Depot.DateTime > @dtOne) AND (Product2Depot.DateTime < @dtTwo) AND (Deparment.TypeID = 42) ");
            strSql.Append(" GROUP BY Product2DepotInfo.MaterielID, Product2DepotInfo.ColorID, Product2DepotInfo.SizeID UNION ALL ");
            strSql.Append(" SELECT     SUM(Pack2DepotInfo.NowAmount) AS 期间入库数, Pack2DepotInfo.MaterielID, Pack2DepotInfo.ColorID, Pack2DepotInfo.SizeID FROM         Pack2DepotMain INNER JOIN ");
            strSql.Append(" Pack2DepotInfo ON Pack2DepotMain.ID = Pack2DepotInfo.MainID INNER JOIN Deparment AS Deparment_1 ON Pack2DepotMain.DepotID = Deparment_1.ID ");
            strSql.Append(" WHERE     (Deparment_1.TypeID = 42) AND (Pack2DepotMain.DateTime > @dtOne) AND (Pack2DepotMain.DateTime < @dtTwo) GROUP BY Pack2DepotInfo.MaterielID, Pack2DepotInfo.ColorID, ");
            strSql.Append(" Pack2DepotInfo.SizeID) AS T GROUP BY MaterielID, ColorID, SizeID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ") And (ColorID=" + ds.Tables[0].Rows[i]["ColorID"] + ") And (SizeID=" + ds.Tables[0].Rows[i]["SizeID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["期间入库数"] = drs[0]["期间入库数"];
                }
            }

            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellInfo.MaterielID,ProduceSellInfo.ColorID,ProduceSellInfo.SizeID, SUM(ProduceSellInfo.Amount) AS 止到现销售数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellInfo ON ProduceSell.ID = ProduceSellInfo.MainID WHERE   (ProduceSell.DateTime > @dtThree) And (State=21) GROUP BY ProduceSellInfo.ColorID,ProduceSellInfo.SizeID,ProduceSellInfo.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ") And (ColorID=" + ds.Tables[0].Rows[i]["ColorID"] + ") And (SizeID=" + ds.Tables[0].Rows[i]["SizeID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["止到现销售数"] = drs[0]["止到现销售数"];
                }
            }

            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellInfo.MaterielID,ProduceSellInfo.ColorID,ProduceSellInfo.SizeID, SUM(ProduceSellInfo.Amount) AS 止到现退货数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellInfo ON ProduceSell.ID = ProduceSellInfo.MainID WHERE   (ProduceSell.DateTime > @dtThree) And (State=22) GROUP BY ProduceSellInfo.ColorID,ProduceSellInfo.SizeID,ProduceSellInfo.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ") And (ColorID=" + ds.Tables[0].Rows[i]["ColorID"] + ") And (SizeID=" + ds.Tables[0].Rows[i]["SizeID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["止到现退货数"] = drs[0]["止到现退货数"];
                }
            }

            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellInfo.MaterielID,ProduceSellInfo.ColorID,ProduceSellInfo.SizeID, SUM(ProduceSellInfo.Amount) AS 期间销售数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellInfo ON ProduceSell.ID = ProduceSellInfo.MainID WHERE   (ProduceSell.DateTime > @dtOne) AND (ProduceSell.DateTime < @dtTwo)  And (State=21)  ");
            strSql.Append(" GROUP BY ProduceSellInfo.ColorID,ProduceSellInfo.SizeID,ProduceSellInfo.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ") And (ColorID=" + ds.Tables[0].Rows[i]["ColorID"] + ") And (SizeID=" + ds.Tables[0].Rows[i]["SizeID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["期间销售数"] = drs[0]["期间销售数"];
                }
            }
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   ProduceSellInfo.MaterielID,ProduceSellInfo.ColorID,ProduceSellInfo.SizeID, SUM(ProduceSellInfo.Amount) AS 期间退货数 FROM      ProduceSell INNER JOIN ");
            strSql.Append(" ProduceSellInfo ON ProduceSell.ID = ProduceSellInfo.MainID WHERE   (ProduceSell.DateTime > @dtOne) AND (ProduceSell.DateTime < @dtTwo)  And (State=22)  ");
            strSql.Append(" GROUP BY ProduceSellInfo.ColorID,ProduceSellInfo.SizeID,ProduceSellInfo.MaterielID");
            ds1 = DbHelperSQL.Query(strSql.ToString(), sps);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                drs = ds1.Tables[0].Select("(MaterielID=" + ds.Tables[0].Rows[i]["MaterielID"] + ") And (ColorID=" + ds.Tables[0].Rows[i]["ColorID"] + ") And (SizeID=" + ds.Tables[0].Rows[i]["SizeID"] + ")");
                if (drs.Length > 0)
                {
                    ds.Tables[0].Rows[i]["期间退货数"] = drs[0]["期间退货数"];
                }
            }
            int Amount, Qin, Zin, Qout, Zout, Qtui, Ztui;
            Amount = Qin = Zin = Qout = Zout = Qtui = Ztui = 0;
            Hownet.DAL.Color dalColor = new Color();
            Hownet.DAL.Size dalSize = new Size();
            DataTable dtColor = dalColor.GetList("").Tables[0];
            DataTable dtSize = dalSize.GetList("").Tables[0];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Amount = Qin = Zin = Qout = Zout = Qtui = Ztui = 0;
                Amount = Convert.ToInt32(ds.Tables[0].Rows[i]["现有库存"]);
                if (ds.Tables[0].Rows[i]["期间入库数"] != null && ds.Tables[0].Rows[i]["期间入库数"].ToString() != string.Empty)
                    Qin = Convert.ToInt32(ds.Tables[0].Rows[i]["期间入库数"]);
                if (ds.Tables[0].Rows[i]["止到现入库数"] != null && ds.Tables[0].Rows[i]["止到现入库数"].ToString() != string.Empty)
                    Zin = Convert.ToInt32(ds.Tables[0].Rows[i]["止到现入库数"]);
                if (ds.Tables[0].Rows[i]["期间销售数"] != null && ds.Tables[0].Rows[i]["期间销售数"].ToString() != string.Empty)
                    Qout = Convert.ToInt32(ds.Tables[0].Rows[i]["期间销售数"]);
                if (ds.Tables[0].Rows[i]["止到现销售数"] != null && ds.Tables[0].Rows[i]["止到现销售数"].ToString() != string.Empty)
                    Zout = Convert.ToInt32(ds.Tables[0].Rows[i]["止到现销售数"]);

                if (ds.Tables[0].Rows[i]["期间退货数"] != null && ds.Tables[0].Rows[i]["期间退货数"].ToString() != string.Empty)
                    Qtui = Convert.ToInt32(ds.Tables[0].Rows[i]["期间退货数"]);
                if (ds.Tables[0].Rows[i]["止到现退货数"] != null && ds.Tables[0].Rows[i]["止到现退货数"].ToString() != string.Empty)
                    Ztui = Convert.ToInt32(ds.Tables[0].Rows[i]["止到现退货数"]);
                ds.Tables[0].Rows[i]["开始库存"] = Amount + Zout - Zin + Qout - Qin - Ztui - Qtui;
                ds.Tables[0].Rows[i]["结束库存"] = Amount + Zout - Zin - Ztui;
                drs = dtColor.Select("(ID=" + ds.Tables[0].Rows[i]["ColorID"] + ")");
                if (drs.Length > 0)
                    ds.Tables[0].Rows[i]["颜色"] = drs[0]["Name"];
                drs = dtSize.Select("(ID=" + ds.Tables[0].Rows[i]["SizeID"] + ")");
                if (drs.Length > 0)
                    ds.Tables[0].Rows[i]["尺码"] = drs[0]["Name"];
            }
            return ds;
        }
        /// <summary>
        /// 获取合并后计划单所被合并单在库存中的材料
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetPPList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Repertory.MListID, SUM(Repertory.Amount) AS Amount, Repertory.MeasureID, Repertory.DepartmentID, Repertory.MaterielID, Repertory.SizeID, Repertory.ColorID, Repertory.ColorOneID, Repertory.ColorTwoID,  ");
            strSql.Append(" Repertory.BrandID FROM      ProductionPlan INNER JOIN Repertory ON ProductionPlan.ID = Repertory.PlanID WHERE   (ProductionPlan.DeparmentID = @MainID ) ");
            strSql.Append(" GROUP BY Repertory.MListID, Repertory.MeasureID, Repertory.DepartmentID, Repertory.MaterielID, Repertory.SizeID, Repertory.ColorID, Repertory.ColorOneID, Repertory.ColorTwoID, Repertory.BrandID");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 删除合并后计划单所被合并单在库存中的材料
        /// </summary>
        /// <param name="MainID"></param>
        public void DelPPList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" DELETE FROM Repertory FROM      ProductionPlan INNER JOIN Repertory ON ProductionPlan.ID = Repertory.PlanID WHERE   (ProductionPlan.DeparmentID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
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
            parameters[0].Value = "Repertory";
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

