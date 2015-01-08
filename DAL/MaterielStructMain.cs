using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类MaterielStructMain。
    /// </summary>
    public class MaterielStructMain
    {
        public MaterielStructMain()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("MainID", "MaterielStructMain");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MaterielStructMain");
            strSql.Append(" where MainID=@MainID ");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MaterielStructMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterielStructMain(");
            strSql.Append("Ver,MaterielID,DateTime,CompanyID,TaskID,Remark,IsDefault,IsVerify,VerifyManID,VerifyDateTime,Executant,Money,WorkingMoney,OutPrice,MaterielPro,GrossProfit,GrossPro,CMT,BySizeName,ExSize,MaterielLoss,PackLoss,FillManID,FillManName,VerifyManName)");
            strSql.Append(" values (");
            strSql.Append("@Ver,@MaterielID,@DateTime,@CompanyID,@TaskID,@Remark,@IsDefault,@IsVerify,@VerifyManID,@VerifyDateTime,@Executant,@Money,@WorkingMoney,@OutPrice,@MaterielPro,@GrossProfit,@GrossPro,@CMT,@BySizeName,@ExSize,@MaterielLoss,@PackLoss,@FillManID,@FillManName,@VerifyManName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Ver", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@IsDefault", SqlDbType.Bit,1),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyManID", SqlDbType.Int,4),
					new SqlParameter("@VerifyDateTime", SqlDbType.DateTime),
					new SqlParameter("@Executant", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@WorkingMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OutPrice", SqlDbType.Decimal,9),
					new SqlParameter("@MaterielPro", SqlDbType.Decimal,9),
					new SqlParameter("@GrossProfit", SqlDbType.Decimal,9),
					new SqlParameter("@GrossPro", SqlDbType.Decimal,9),
					new SqlParameter("@CMT", SqlDbType.Decimal,9),
					new SqlParameter("@BySizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@ExSize", SqlDbType.NVarChar,500),
					new SqlParameter("@MaterielLoss", SqlDbType.NVarChar,500),
					new SqlParameter("@PackLoss", SqlDbType.NVarChar,500),
					new SqlParameter("@FillManID", SqlDbType.Int,4),
					new SqlParameter("@FillManName", SqlDbType.NVarChar,50),
					new SqlParameter("@VerifyManName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Ver;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.DateTime;
            parameters[3].Value = model.CompanyID;
            parameters[4].Value = model.TaskID;
            parameters[5].Value = model.Remark;
            parameters[6].Value = model.IsDefault;
            parameters[7].Value = model.IsVerify;
            parameters[8].Value = model.VerifyManID;
            parameters[9].Value = model.VerifyDateTime;
            parameters[10].Value = model.Executant;
            parameters[11].Value = model.Money;
            parameters[12].Value = model.WorkingMoney;
            parameters[13].Value = model.OutPrice;
            parameters[14].Value = model.MaterielPro;
            parameters[15].Value = model.GrossProfit;
            parameters[16].Value = model.GrossPro;
            parameters[17].Value = model.CMT;
            parameters[18].Value = model.BySizeName;
            parameters[19].Value = model.ExSize;
            parameters[20].Value = model.MaterielLoss;
            parameters[21].Value = model.PackLoss;
            parameters[22].Value = model.FillManID;
            parameters[23].Value = model.FillManName;
            parameters[24].Value = model.VerifyManName;

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
        public bool Update(Hownet.Model.MaterielStructMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MaterielStructMain set ");
            strSql.Append("Ver=@Ver,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsDefault=@IsDefault,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyManID=@VerifyManID,");
            strSql.Append("VerifyDateTime=@VerifyDateTime,");
            strSql.Append("Executant=@Executant,");
            strSql.Append("Money=@Money,");
            strSql.Append("WorkingMoney=@WorkingMoney,");
            strSql.Append("OutPrice=@OutPrice,");
            strSql.Append("MaterielPro=@MaterielPro,");
            strSql.Append("GrossProfit=@GrossProfit,");
            strSql.Append("GrossPro=@GrossPro,");
            strSql.Append("CMT=@CMT,");
            strSql.Append("BySizeName=@BySizeName,");
            strSql.Append("ExSize=@ExSize,");
            strSql.Append("MaterielLoss=@MaterielLoss,");
            strSql.Append("PackLoss=@PackLoss,");
            strSql.Append("FillManID=@FillManID,");
            strSql.Append("FillManName=@FillManName,");
            strSql.Append("VerifyManName=@VerifyManName");
            strSql.Append(" where MainID=@MainID");
            SqlParameter[] parameters = {
					new SqlParameter("@Ver", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@IsDefault", SqlDbType.Bit,1),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyManID", SqlDbType.Int,4),
					new SqlParameter("@VerifyDateTime", SqlDbType.DateTime),
					new SqlParameter("@Executant", SqlDbType.Int,4),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@WorkingMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OutPrice", SqlDbType.Decimal,9),
					new SqlParameter("@MaterielPro", SqlDbType.Decimal,9),
					new SqlParameter("@GrossProfit", SqlDbType.Decimal,9),
					new SqlParameter("@GrossPro", SqlDbType.Decimal,9),
					new SqlParameter("@CMT", SqlDbType.Decimal,9),
					new SqlParameter("@BySizeName", SqlDbType.NVarChar,50),
					new SqlParameter("@ExSize", SqlDbType.NVarChar,500),
					new SqlParameter("@MaterielLoss", SqlDbType.NVarChar,500),
					new SqlParameter("@PackLoss", SqlDbType.NVarChar,500),
					new SqlParameter("@FillManID", SqlDbType.Int,4),
					new SqlParameter("@FillManName", SqlDbType.NVarChar,50),
					new SqlParameter("@VerifyManName", SqlDbType.NVarChar,50),
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = model.Ver;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.DateTime;
            parameters[3].Value = model.CompanyID;
            parameters[4].Value = model.TaskID;
            parameters[5].Value = model.Remark;
            parameters[6].Value = model.IsDefault;
            parameters[7].Value = model.IsVerify;
            parameters[8].Value = model.VerifyManID;
            parameters[9].Value = model.VerifyDateTime;
            parameters[10].Value = model.Executant;
            parameters[11].Value = model.Money;
            parameters[12].Value = model.WorkingMoney;
            parameters[13].Value = model.OutPrice;
            parameters[14].Value = model.MaterielPro;
            parameters[15].Value = model.GrossProfit;
            parameters[16].Value = model.GrossPro;
            parameters[17].Value = model.CMT;
            parameters[18].Value = model.BySizeName;
            parameters[19].Value = model.ExSize;
            parameters[20].Value = model.MaterielLoss;
            parameters[21].Value = model.PackLoss;
            parameters[22].Value = model.FillManID;
            parameters[23].Value = model.FillManName;
            parameters[24].Value = model.VerifyManName;
            parameters[25].Value = model.MainID;

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
        public bool Delete(int MainID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MaterielStructMain ");
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
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string MainIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MaterielStructMain ");
            strSql.Append(" where MainID in (" + MainIDlist + ")  ");
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
        public Hownet.Model.MaterielStructMain GetModel(int MainID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 MainID,Ver,MaterielID,DateTime,CompanyID,TaskID,Remark,IsDefault,IsVerify,VerifyManID,VerifyDateTime,Executant,Money,WorkingMoney,OutPrice,MaterielPro,GrossProfit,GrossPro,CMT,BySizeName,ExSize,MaterielLoss,PackLoss,FillManID,FillManName,VerifyManName from MaterielStructMain ");
            strSql.Append(" where MainID=@MainID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)
};
            parameters[0].Value = MainID;

            Hownet.Model.MaterielStructMain model = new Hownet.Model.MaterielStructMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                model.Ver = ds.Tables[0].Rows[0]["Ver"].ToString();
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"] != null && ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["IsDefault"] != null && ds.Tables[0].Rows[0]["IsDefault"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsDefault"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsDefault"].ToString().ToLower() == "true"))
                    {
                        model.IsDefault = true;
                    }
                    else
                    {
                        model.IsDefault = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsVerify"] != null && ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyManID"] != null && ds.Tables[0].Rows[0]["VerifyManID"].ToString() != "")
                {
                    model.VerifyManID = int.Parse(ds.Tables[0].Rows[0]["VerifyManID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDateTime"] != null && ds.Tables[0].Rows[0]["VerifyDateTime"].ToString() != "")
                {
                    model.VerifyDateTime = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Executant"] != null && ds.Tables[0].Rows[0]["Executant"].ToString() != "")
                {
                    model.Executant = int.Parse(ds.Tables[0].Rows[0]["Executant"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["WorkingMoney"] != null && ds.Tables[0].Rows[0]["WorkingMoney"].ToString() != "")
                {
                    model.WorkingMoney = decimal.Parse(ds.Tables[0].Rows[0]["WorkingMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OutPrice"] != null && ds.Tables[0].Rows[0]["OutPrice"].ToString() != "")
                {
                    model.OutPrice = decimal.Parse(ds.Tables[0].Rows[0]["OutPrice"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielPro"] != null && ds.Tables[0].Rows[0]["MaterielPro"].ToString() != "")
                {
                    model.MaterielPro = decimal.Parse(ds.Tables[0].Rows[0]["MaterielPro"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GrossProfit"] != null && ds.Tables[0].Rows[0]["GrossProfit"].ToString() != "")
                {
                    model.GrossProfit = decimal.Parse(ds.Tables[0].Rows[0]["GrossProfit"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GrossPro"] != null && ds.Tables[0].Rows[0]["GrossPro"].ToString() != "")
                {
                    model.GrossPro = decimal.Parse(ds.Tables[0].Rows[0]["GrossPro"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CMT"] != null && ds.Tables[0].Rows[0]["CMT"].ToString() != "")
                {
                    model.CMT = decimal.Parse(ds.Tables[0].Rows[0]["CMT"].ToString());
                }
                model.BySizeName = ds.Tables[0].Rows[0]["BySizeName"].ToString();
                model.ExSize = ds.Tables[0].Rows[0]["ExSize"].ToString();
                model.MaterielLoss = ds.Tables[0].Rows[0]["MaterielLoss"].ToString();
                model.PackLoss = ds.Tables[0].Rows[0]["PackLoss"].ToString();
                if (ds.Tables[0].Rows[0]["FillManID"] != null && ds.Tables[0].Rows[0]["FillManID"].ToString() != "")
                {
                    model.FillManID = int.Parse(ds.Tables[0].Rows[0]["FillManID"].ToString());
                }
                model.FillManName = ds.Tables[0].Rows[0]["FillManName"].ToString();
                model.VerifyManName = ds.Tables[0].Rows[0]["VerifyManName"].ToString();
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
            strSql.Append("select  1 as A,MainID,Ver,MaterielID,DateTime,CompanyID,TaskID,Remark,IsDefault,IsVerify,VerifyManID,VerifyDateTime,Executant,Money,WorkingMoney,OutPrice,MaterielPro,GrossProfit,GrossPro,CMT,BySizeName,ExSize,MaterielLoss,PackLoss,FillManID,FillManName,VerifyManName ");
            strSql.Append(" FROM MaterielStructMain ");
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
            strSql.Append(" MainID,Ver,MaterielID,DateTime,CompanyID,TaskID,Remark,IsDefault,IsVerify,VerifyManID,VerifyDateTime,Executant,Money,WorkingMoney,OutPrice,MaterielPro,GrossProfit,GrossPro,CMT,BySizeName,ExSize,MaterielLoss,PackLoss,FillManID,FillManName,VerifyManName ");
            strSql.Append(" FROM MaterielStructMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 更新某款号的物料结构单IsDefault为假
        /// </summary>
        /// <param name="MaterielID"></param>
        public void UpDefault(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" UPDATE MaterielStructMain SET IsDefault = 0 WHERE (MaterielID = @MaterielID)");
            SqlParameter[] sps ={ new SqlParameter("@MaterielID", MaterielID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回某款号的默认物料结构单编号
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public int GetIsDefaultID(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MainID FROM MaterielStructMain WHERE (MaterielID = @MaterielID) AND (IsDefault = 1)");
            SqlParameter[] sps ={ new SqlParameter("@MaterielID", MaterielID) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }
        /// <summary>
        /// 要把主表ID返回某物料结构
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetBomListByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ChildMaterielID AS MaterielID, (SELECT Name FROM Materiel WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.ChildMaterielID)) AS MaterielName, (SELECT Name FROM CaiPian WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.UsePartID)) AS PartName, (SELECT Name FROM OtherType WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.DepartmentID)) AS DepartmentName, Cast( Amount as Real) as Amount, UsingTypeID, (SELECT Name FROM Measure WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.MeasureID)) AS MeasureName,  Wastage,IsTogethers,Price,TMAmount,TaskMeasureID FROM MaterielStructInfo WHERE (MainID = @MainID)");
            SqlParameter[] sps ={ new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回某物料的下一级结构(一般只用于半成品等只有一个版本的)
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetBomListByMateriel(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ChildMaterielID AS MaterielID, (SELECT Name FROM Materiel WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.ChildMaterielID)) AS MaterielName, (SELECT Name FROM CaiPian WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.UsePartID)) AS PartName, (SELECT Name FROM OtherType WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.DepartmentID)) AS DepartmentName,  Amount, UsingTypeID, ");
            strSql.Append("  (SELECT Name FROM Measure WHERE (ID = ");
            strSql.Append(" MaterielStructInfo.MeasureID)) AS MeasureName,  Wastage,IsTogethers FROM MaterielStructInfo WHERE (MaterielID = @MaterielID)");
            SqlParameter[] sps ={ new SqlParameter("@MaterielID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回某生产单所用物料结构
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetDemandList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT InfoID,MaterielID, ChildMaterielID, UsePartID, DepartmentID, Amount, UsingTypeID, MeasureID, Wastage, (SELECT AttributeID FROM Materiel ");
            strSql.Append(" WHERE (ID = MaterielStructInfo.ChildMaterielID)) AS AttributeID FROM MaterielStructInfo WHERE (MainID = @MainID) And (IsCaic=1)");
            SqlParameter[] sps ={ new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        /// <summary>
        /// 返回某物料的下一级结构*主指半成品
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetDemandChildMateriel(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT MaterielID, ChildMaterielID, UsePartID, DepartmentID, Amount, UsingTypeID, MeasureID, Wastage, (SELECT AttributeID FROM Materiel ");
            //strSql.Append(" WHERE (ID = MaterielStructInfo.ChildMaterielID)) AS AttributeID FROM MaterielStructInfo WHERE (MaterielID = @MainID)");
            strSql.Append("SELECT MaterielStructInfo.InfoID,  MaterielStructInfo.ChildMaterielID, MaterielStructInfo.UsePartID, MaterielStructInfo.DepartmentID, MaterielStructInfo.Amount, ");
            strSql.Append(" MaterielStructInfo.UsingTypeID, MaterielStructInfo.MeasureID, MaterielStructInfo.Wastage,(SELECT   AttributeID FROM      Materiel ");
            strSql.Append(" WHERE   (ID = MaterielStructInfo.ChildMaterielID)) AS AttributeID, MaterielStructMain.MaterielID FROM MaterielStructInfo INNER JOIN ");
            strSql.Append(" MaterielStructMain ON MaterielStructInfo.MainID = MaterielStructMain.MainID WHERE   (MaterielStructMain.MaterielID = @MaterielID * - 1) AND (MaterielStructInfo.IsCaic = 1)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 判断某BOMID是否已使用
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool CheckBomID(int ID)
        {
            bool t = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(ProduceTaskID) AS Expr2 FROM ProduceTaskMain WHERE (BomID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sps).ToString() != "0")
            {
                t = true;
            }
            return t;
        }
        /// <summary>
        /// 判断某半成品或外加工材料是否有使用
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool CheckWuliao(int ID)
        {
            bool t = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(InfoID) AS Expr1 FROM MaterielStructInfo WHERE (MainID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sps).ToString() != "0")
            {
                t = true;
            }
            return t;
        }
        /// <summary>
        /// 多表下返回某款号的主物料结构 ID列表
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetIDList(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT MainID FROM MaterielStructMain WHERE (MaterielID = @MaterielID) order by MainID");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetInfoIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select MainID from MaterielStructMain");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int CountUse(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT COUNT(ProduceTaskID) AS Expr1 FROM ProduceTaskMain WHERE (BomID = @BomID)");
            SqlParameter[] sps = {new SqlParameter("@BomID",MainID) };
            return int.Parse(DbHelperSQL.GetSingle(strSql.ToString(), sps).ToString());
        }
        public DataSet GetBrandList(int BrandID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ChildMaterielID, Amount, DepartmentID, UsingTypeID, MeasureID, Wastage, ");
            strSql.Append(" (SELECT AttributeID FROM Materiel WHERE (ID = MaterielStructInfo.ChildMaterielID)) AS AttributeID ");
            strSql.Append(" FROM MaterielStructInfo WHERE (MaterielID = @BrandID)");
            SqlParameter[] sps = { new SqlParameter("@BrandID", BrandID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetPrintList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT     TOP (200) Materiel.Name AS 材料名称, MaterielStructInfo.TMAmount AS 用量, Measure_1.Name AS 车间单位, MaterielStructInfo.UsingTypeID, ");
            strSql.Append(" MaterielStructInfo.Amount, Measure.Name AS 默认单位 FROM         MaterielStructInfo INNER JOIN ");
            strSql.Append(" Materiel ON MaterielStructInfo.ChildMaterielID = Materiel.ID LEFT OUTER JOIN Measure ON MaterielStructInfo.MeasureID = Measure.ID LEFT OUTER JOIN ");
            strSql.Append(" Measure AS Measure_1 ON MaterielStructInfo.TaskMeasureID = Measure_1.ID WHERE     (MaterielStructInfo.MainID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
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
            parameters[0].Value = "MaterielStructMain";
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

