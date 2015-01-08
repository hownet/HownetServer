using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类MaterielStructInfo。
    /// </summary>
    public class MaterielStructInfo
    {
        public MaterielStructInfo()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int InfoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MaterielStructInfo");
            strSql.Append(" where InfoID=@InfoID ");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)};
            parameters[0].Value = InfoID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MaterielStructInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterielStructInfo(");
            strSql.Append("MaterielID,ChildMaterielID,UsePartID,DepartmentID,Amount,UsingTypeID,MeasureID,Wastage,MainID,IsTogethers,Price,IsCaic,Money,MSIID,ColorID,CompanyID,ToColorID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,TaskMeasureID,TMAmount)");
            strSql.Append(" values (");
            strSql.Append("@MaterielID,@ChildMaterielID,@UsePartID,@DepartmentID,@Amount,@UsingTypeID,@MeasureID,@Wastage,@MainID,@IsTogethers,@Price,@IsCaic,@Money,@MSIID,@ColorID,@CompanyID,@ToColorID,@Remark,@SupplierID,@SupplierName,@SupplierSN,@SpecID,@SpecName,@TaskMeasureID,@TMAmount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ChildMaterielID", SqlDbType.Int,4),
					new SqlParameter("@UsePartID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@UsingTypeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Wastage", SqlDbType.Decimal,5),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsTogethers", SqlDbType.Bit,1),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@IsCaic", SqlDbType.Bit,1),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@MSIID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@ToColorID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@SupplierID", SqlDbType.Int,4),
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierSN", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@TaskMeasureID", SqlDbType.Int,4),
					new SqlParameter("@TMAmount", SqlDbType.Decimal,9)};
            parameters[0].Value = model.MaterielID;
            parameters[1].Value = model.ChildMaterielID;
            parameters[2].Value = model.UsePartID;
            parameters[3].Value = model.DepartmentID;
            parameters[4].Value = model.Amount;
            parameters[5].Value = model.UsingTypeID;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.Wastage;
            parameters[8].Value = model.MainID;
            parameters[9].Value = model.IsTogethers;
            parameters[10].Value = model.Price;
            parameters[11].Value = model.IsCaic;
            parameters[12].Value = model.Money;
            parameters[13].Value = model.MSIID;
            parameters[14].Value = model.ColorID;
            parameters[15].Value = model.CompanyID;
            parameters[16].Value = model.ToColorID;
            parameters[17].Value = model.Remark;
            parameters[18].Value = model.SupplierID;
            parameters[19].Value = model.SupplierName;
            parameters[20].Value = model.SupplierSN;
            parameters[21].Value = model.SpecID;
            parameters[22].Value = model.SpecName;
            parameters[23].Value = model.TaskMeasureID;
            parameters[24].Value = model.TMAmount;

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
        public bool Update(Hownet.Model.MaterielStructInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MaterielStructInfo set ");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ChildMaterielID=@ChildMaterielID,");
            strSql.Append("UsePartID=@UsePartID,");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("UsingTypeID=@UsingTypeID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("Wastage=@Wastage,");
            strSql.Append("MainID=@MainID,");
            strSql.Append("IsTogethers=@IsTogethers,");
            strSql.Append("Price=@Price,");
            strSql.Append("IsCaic=@IsCaic,");
            strSql.Append("Money=@Money,");
            strSql.Append("MSIID=@MSIID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("ToColorID=@ToColorID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("SupplierID=@SupplierID,");
            strSql.Append("SupplierName=@SupplierName,");
            strSql.Append("SupplierSN=@SupplierSN,");
            strSql.Append("SpecID=@SpecID,");
            strSql.Append("SpecName=@SpecName,");
            strSql.Append("TaskMeasureID=@TaskMeasureID,");
            strSql.Append("TMAmount=@TMAmount");
            strSql.Append(" where InfoID=@InfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ChildMaterielID", SqlDbType.Int,4),
					new SqlParameter("@UsePartID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@UsingTypeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Wastage", SqlDbType.Decimal,5),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsTogethers", SqlDbType.Bit,1),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@IsCaic", SqlDbType.Bit,1),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@MSIID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@ToColorID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@SupplierID", SqlDbType.Int,4),
					new SqlParameter("@SupplierName", SqlDbType.NVarChar,50),
					new SqlParameter("@SupplierSN", SqlDbType.NVarChar,50),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@TaskMeasureID", SqlDbType.Int,4),
					new SqlParameter("@TMAmount", SqlDbType.Decimal,9),
					new SqlParameter("@InfoID", SqlDbType.Int,4)};
            parameters[0].Value = model.MaterielID;
            parameters[1].Value = model.ChildMaterielID;
            parameters[2].Value = model.UsePartID;
            parameters[3].Value = model.DepartmentID;
            parameters[4].Value = model.Amount;
            parameters[5].Value = model.UsingTypeID;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.Wastage;
            parameters[8].Value = model.MainID;
            parameters[9].Value = model.IsTogethers;
            parameters[10].Value = model.Price;
            parameters[11].Value = model.IsCaic;
            parameters[12].Value = model.Money;
            parameters[13].Value = model.MSIID;
            parameters[14].Value = model.ColorID;
            parameters[15].Value = model.CompanyID;
            parameters[16].Value = model.ToColorID;
            parameters[17].Value = model.Remark;
            parameters[18].Value = model.SupplierID;
            parameters[19].Value = model.SupplierName;
            parameters[20].Value = model.SupplierSN;
            parameters[21].Value = model.SpecID;
            parameters[22].Value = model.SpecName;
            parameters[23].Value = model.TaskMeasureID;
            parameters[24].Value = model.TMAmount;
            parameters[25].Value = model.InfoID;

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
        public bool Delete(int InfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MaterielStructInfo ");
            strSql.Append(" where InfoID=@InfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = InfoID;

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
        public bool DeleteList(string InfoIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MaterielStructInfo ");
            strSql.Append(" where InfoID in (" + InfoIDlist + ")  ");
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
        public Hownet.Model.MaterielStructInfo GetModel(int InfoID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 InfoID,MaterielID,ChildMaterielID,UsePartID,DepartmentID,Amount,UsingTypeID,MeasureID,Wastage,MainID,IsTogethers,Price,IsCaic,Money,MSIID,ColorID,CompanyID,ToColorID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,TaskMeasureID,TMAmount from MaterielStructInfo ");
            strSql.Append(" where InfoID=@InfoID");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4)
			};
            parameters[0].Value = InfoID;

            Hownet.Model.MaterielStructInfo model = new Hownet.Model.MaterielStructInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["InfoID"] != null && ds.Tables[0].Rows[0]["InfoID"].ToString() != "")
                {
                    model.InfoID = int.Parse(ds.Tables[0].Rows[0]["InfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ChildMaterielID"] != null && ds.Tables[0].Rows[0]["ChildMaterielID"].ToString() != "")
                {
                    model.ChildMaterielID = int.Parse(ds.Tables[0].Rows[0]["ChildMaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UsePartID"] != null && ds.Tables[0].Rows[0]["UsePartID"].ToString() != "")
                {
                    model.UsePartID = int.Parse(ds.Tables[0].Rows[0]["UsePartID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepartmentID"] != null && ds.Tables[0].Rows[0]["DepartmentID"].ToString() != "")
                {
                    model.DepartmentID = int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UsingTypeID"] != null && ds.Tables[0].Rows[0]["UsingTypeID"].ToString() != "")
                {
                    model.UsingTypeID = int.Parse(ds.Tables[0].Rows[0]["UsingTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Wastage"] != null && ds.Tables[0].Rows[0]["Wastage"].ToString() != "")
                {
                    model.Wastage = decimal.Parse(ds.Tables[0].Rows[0]["Wastage"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsTogethers"] != null && ds.Tables[0].Rows[0]["IsTogethers"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsTogethers"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsTogethers"].ToString().ToLower() == "true"))
                    {
                        model.IsTogethers = true;
                    }
                    else
                    {
                        model.IsTogethers = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsCaic"] != null && ds.Tables[0].Rows[0]["IsCaic"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCaic"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCaic"].ToString().ToLower() == "true"))
                    {
                        model.IsCaic = true;
                    }
                    else
                    {
                        model.IsCaic = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MSIID"] != null && ds.Tables[0].Rows[0]["MSIID"].ToString() != "")
                {
                    model.MSIID = int.Parse(ds.Tables[0].Rows[0]["MSIID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ToColorID"] != null && ds.Tables[0].Rows[0]["ToColorID"].ToString() != "")
                {
                    model.ToColorID = int.Parse(ds.Tables[0].Rows[0]["ToColorID"].ToString());
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
                if (ds.Tables[0].Rows[0]["TaskMeasureID"] != null && ds.Tables[0].Rows[0]["TaskMeasureID"].ToString() != "")
                {
                    model.TaskMeasureID = int.Parse(ds.Tables[0].Rows[0]["TaskMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TMAmount"] != null && ds.Tables[0].Rows[0]["TMAmount"].ToString() != "")
                {
                    model.TMAmount = decimal.Parse(ds.Tables[0].Rows[0]["TMAmount"].ToString());
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
            strSql.Append("select  1 as A,InfoID,MaterielID,ChildMaterielID,UsePartID,DepartmentID,Amount,UsingTypeID,MeasureID,Wastage,MainID,IsTogethers,Price,IsCaic,Money,MSIID,ColorID,CompanyID,ToColorID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,TaskMeasureID,TMAmount ");
            strSql.Append(", (SELECT AttributeID FROM Materiel WHERE (ID = MaterielStructInfo.ChildMaterielID)) AS AttribID ");
            strSql.Append(" FROM MaterielStructInfo ");
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
            strSql.Append(" InfoID,MaterielID,ChildMaterielID,UsePartID,DepartmentID,Amount,UsingTypeID,MeasureID,Wastage,MainID,IsTogethers,Price,IsCaic,Money,MSIID,ColorID,CompanyID,ToColorID,Remark,SupplierID,SupplierName,SupplierSN,SpecID,SpecName,TaskMeasureID,TMAmount ");
            strSql.Append(" FROM MaterielStructInfo ");
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
            parameters[0].Value = "MaterielStructInfo";
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

