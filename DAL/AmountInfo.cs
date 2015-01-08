using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类AmountInfo。
    /// </summary>
    public class AmountInfo
    {
        public AmountInfo()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "AmountInfo");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AmountInfo");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.AmountInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AmountInfo(");
            strSql.Append("MainID,TableTypeID,ColorID,ColorOneID,ColorTwoID,SizeID,MListID,Amount,NotAmount,NotDepAmount,Remark)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@TableTypeID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@MListID,@Amount,@NotAmount,@NotDepAmount,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Int,4),
					new SqlParameter("@NotDepAmount", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TableTypeID;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorOneID;
            parameters[4].Value = model.ColorTwoID;
            parameters[5].Value = model.SizeID;
            parameters[6].Value = model.MListID;
            parameters[7].Value = model.Amount;
            parameters[8].Value = model.NotAmount;
            parameters[9].Value = model.NotDepAmount;
            parameters[10].Value = model.Remark;

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
        public void Update(Hownet.Model.AmountInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AmountInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("TableTypeID=@TableTypeID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("NotAmount=@NotAmount,");
            strSql.Append("NotDepAmount=@NotDepAmount,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Int,4),
					new SqlParameter("@NotDepAmount", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.TableTypeID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.ColorOneID;
            parameters[5].Value = model.ColorTwoID;
            parameters[6].Value = model.SizeID;
            parameters[7].Value = model.MListID;
            parameters[8].Value = model.Amount;
            parameters[9].Value = model.NotAmount;
            parameters[10].Value = model.NotDepAmount;
            parameters[11].Value = model.Remark;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AmountInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.AmountInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,TableTypeID,ColorID,ColorOneID,ColorTwoID,SizeID,MListID,Amount,NotAmount,NotDepAmount,Remark from AmountInfo ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.AmountInfo model = new Hownet.Model.AmountInfo();
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
                if (ds.Tables[0].Rows[0]["TableTypeID"].ToString() != "")
                {
                    model.TableTypeID = int.Parse(ds.Tables[0].Rows[0]["TableTypeID"].ToString());
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
                if (ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotAmount"].ToString() != "")
                {
                    model.NotAmount = int.Parse(ds.Tables[0].Rows[0]["NotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotDepAmount"].ToString() != "")
                {
                    model.NotDepAmount = int.Parse(ds.Tables[0].Rows[0]["NotDepAmount"].ToString());
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
            strSql.Append("select 1 as A,ID,MainID,TableTypeID,ColorID,ColorOneID,ColorTwoID,SizeID,MListID,Amount,NotAmount,NotDepAmount,Remark,(Amount-NotAmount) as OutAmount  ");
            strSql.Append(" FROM AmountInfo ");
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
            strSql.Append(" ID,MainID,TableTypeID,ColorID,ColorOneID,ColorTwoID,SizeID,MListID,Amount,NotAmount,NotDepAmount,Remark");
            strSql.Append(" FROM AmountInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetColor(int MainID, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();

            //strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = AmountInfo.ColorID)) AS ColorName, ColorID, SUM(Amount) AS SumAmount, ");
            //strSql.Append(" (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = AmountInfo.ColorOneID)) AS ColorOneName, ColorOneID, ");
            //strSql.Append(" (SELECT   Name FROM      Color AS Color_1 WHERE   (ID = AmountInfo.ColorTwoID)) AS ColorTwoName, ColorTwoID, SUM(NotAmount) AS SumNotAmount ");
            //strSql.Append(" FROM      AmountInfo WHERE   (MainID = @MainID) AND (TableTypeID = @TypeID) GROUP BY ColorID, ColorOneID, ColorTwoID ORDER BY MAX(ID)");

            strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = AmountInfo.ColorID)) AS ColorName, ColorID, SUM(Amount) AS SumAmount, SUM(NotAmount)  ");
            strSql.Append(" AS SumNotAmount FROM      AmountInfo WHERE   (MainID = @MainID) AND (TableTypeID = @TypeID) GROUP BY ColorID ORDER BY MAX(ID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID), new SqlParameter("@TypeID", TypeID) };
            DataSet ds= DbHelperSQL.Query(strSql.ToString(), sps);
            ds.Tables[0].TableName = "Color";
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   SUM(Amount) AS SumAmount, (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = AmountInfo.ColorOneID)) AS ColorOneName, ColorOneID, SUM(NotAmount) AS SumNotAmount ");
            strSql.Append(" FROM      AmountInfo WHERE   (MainID = @MainID) AND (TableTypeID = @TypeID) GROUP BY ColorOneID ORDER BY MAX(ID)");
            ds.Tables.Add(DbHelperSQL.Query(strSql.ToString(),sps).Tables[0].Copy());
            ds.Tables[1].TableName="ColorOne";
            strSql.Remove(0, strSql.Length);
            strSql.Append(" SELECT   SUM(Amount) AS SumAmount, (SELECT   Name FROM      Color AS Color_1 WHERE   (ID = AmountInfo.ColorTwoID)) AS ColorTwoName, ColorTwoID, SUM(NotAmount) AS SumNotAmount ");
            strSql.Append(" FROM      AmountInfo WHERE   (MainID = @MainID) AND (TableTypeID = @TypeID) GROUP BY ColorTwoID ORDER BY MAX(ID)");
            ds.Tables.Add(DbHelperSQL.Query(strSql.ToString(),sps).Tables[0].Copy());
            ds.Tables[1].TableName="ColorTwo";
            return ds;
        }
        public DataSet GetSumColor(int MainID, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = AmountInfo.ColorID)) AS ColorName, ColorID, SUM(Amount) AS SumAmount, ");
            strSql.Append(" (SELECT   Name FROM      Color AS Color_2 WHERE   (ID = AmountInfo.ColorOneID)) AS ColorOneName, ColorOneID, ");
            strSql.Append(" (SELECT   Name FROM      Color AS Color_1 WHERE   (ID = AmountInfo.ColorTwoID)) AS ColorTwoName, ColorTwoID, SUM(NotAmount) AS SumNotAmount ");
            strSql.Append(" FROM      AmountInfo WHERE   (MainID = @MainID) AND (TableTypeID = @TypeID) GROUP BY ColorID, ColorOneID, ColorTwoID ORDER BY MAX(ID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID), new SqlParameter("@TypeID", TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSize(int MainID, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   (SELECT   Name FROM      Size WHERE   (ID = AmountInfo.SizeID)) AS SizeName, SizeID, SUM(Amount) AS SumAmount ");
            strSql.Append(" , (SELECT   Orders FROM      Size AS Size_1 WHERE   (ID = AmountInfo.SizeID)) AS Orders");
            strSql.Append(" FROM      AmountInfo WHERE   (MainID = @MainID) AND (TableTypeID = @TypeID) GROUP BY SizeID");
            strSql.Append(" ORDER BY Orders");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID),new SqlParameter("@TypeID",TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public void DelInfo(int MainID, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM AmountInfo WHERE (MainID = @MainID) AND (TableTypeID = @TypeID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID), new SqlParameter("@TypeID", TypeID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 获取出票时的颜色、尺码、数量列表
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetBox(int TaskID,int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ID, ColorID, SizeID, Amount, MListID, (SELECT Name FROM Color ");
            strSql.Append(" WHERE (ID = AmountInfo.ColorID)) AS ColorName, (SELECT Name ");
            strSql.Append(" FROM Size  WHERE (ID = AmountInfo.SizeID)) AS SizeName,ColorOneID,ColorTwoID, ");
            strSql.Append("  MainID FROM AmountInfo WHERE (MainID = @ID) AND (TableTypeID = @TypeID) ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", TaskID),
                    new SqlParameter("@TypeID",TypeID)};
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 获取出票时的颜色、尺码、数量列表，颜色、尺码只有ID值
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetBoxID(int TaskID, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ID, ColorID, SizeID, Amount, MListID,ColorOneID,ColorTwoID, ");
            strSql.Append("  MainID FROM AmountInfo ");
                strSql.Append(" WHERE (MainID = @ID) AND (TableTypeID = @TypeID) ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", TaskID),
                    new SqlParameter("@TypeID",TypeID)};
            return DbHelperSQL.Query(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 审核/弃审成品入库
        /// </summary>
        /// <param name="model"></param>
        /// <param name="t">真为审核入库，假为弃核</param>
        public void UpNotAmount(Model.AmountInfo model ,bool t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AmountInfo set ");
            if(t)
                strSql.Append("NotAmount=NotAmount- @NotAmount");
            else
                strSql.Append("NotAmount=NotAmount+ @NotAmount");
            strSql.Append(" where (MainID=@MainID) And (TableTypeID=@TableTypeID) And (MListID=@MListID)");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Int,4),
                                        new SqlParameter("@MListID",SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TableTypeID;
            parameters[2].Value = model.NotAmount;
            parameters[3].Value = model.MListID;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetGroupColorSize(int TaskID, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ColorID, SizeID,ColorOneID,ColorTwoID, SUM(Amount) AS Amount FROM AmountInfo WHERE   (MainID = @TaskID) AND ");
            strSql.Append(" (TableTypeID = @TypeID) GROUP BY ColorID, SizeID,ColorOneID,ColorTwoID ORDER BY ColorID, SizeID");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TypeID", TypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public void UpNotDepAmount(int TaskID, int TaskDepID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE  AmountInfo SET NotDepAmount = AmountInfo.NotDepAmount - Tem.Amount FROM AmountInfo INNER JOIN ");
            strSql.Append(" (SELECT   MListID, Amount FROM      AmountInfo AS AmountInfo_1 WHERE   (MainID = @TaskDepID) AND ");
            strSql.Append(" (TableTypeID = 37)) AS Tem ON AmountInfo.MListID = Tem.MListID WHERE   (AmountInfo.MainID = @TaskID) ");
            strSql.Append(" AND (AmountInfo.TableTypeID = 1)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TaskDepID", TaskDepID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetSumAmount(int MainID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(Amount) AS Amount, SUM(NotAmount) AS NotAmount, SUM(NotDepAmount) AS NotDepAmount ");
            strSql.Append(" FROM      AmountInfo WHERE   (TableTypeID = @TableTypeID) AND (MainID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID), new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 订单数量转入计划
        /// </summary>
        /// <param name="SaleID"></param>
        /// <param name="PlanID"></param>
        /// <param name="SaleTypeID"></param>
        /// <param name="PlanTypeID"></param>
        public void SaleToPlan(int SaleID, int PlanID, int SaleTypeID, int PlanTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("INSERT INTO AmountInfo (ColorID, ColorOneID, ColorTwoID, SizeID, MListID, Amount, NotAmount, NotDepAmount, Remark, ");
            strSql.Append(" MainID, TableTypeID) SELECT   ColorID, ColorOneID, ColorTwoID, SizeID, MListID, Amount, NotAmount, NotDepAmount, ");
            strSql.Append(" Remark, @PlanID AS Expr1, @PlanTypeID AS Expr2 FROM      AmountInfo AS AmountInfo_1 WHERE   (MainID = @SaleID) AND ");
            strSql.Append(" (TableTypeID = @SaleTypeID)");
            SqlParameter[] sps = {new SqlParameter("@PlanID",PlanID),new SqlParameter("@PlanTypeID",PlanTypeID),
                                  new SqlParameter("@SaleID",SaleID),new SqlParameter("@SaleTypeID",SaleTypeID)};
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 删除一份客户订货合同的明细数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        public void DelSalesBySaleID(int MainID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM AmountInfo FROM      AmountInfo INNER JOIN   SalesOrderInfoList ON AmountInfo.MainID = SalesOrderInfoList.ID ");
            strSql.Append(" WHERE   (SalesOrderInfoList.MainID = @MainID) AND (AmountInfo.TableTypeID = @TableTypeID)");
            SqlParameter[] sps = {new SqlParameter("@MainID",MainID),new SqlParameter("@TableTypeID",TableTypeID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetNoList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ProductTaskMain.ID FROM      ProductTaskMain LEFT OUTER JOIN (SELECT   MainID, TableTypeID ");
            strSql.Append(" FROM      AmountInfo WHERE   (TableTypeID = 1)) AS T ON ProductTaskMain.ID = T.MainID ");
            strSql.Append(" WHERE   (T.MainID IS NULL)");
            return  DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetColorSize(int TaskID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ColorID, SizeID FROM      AmountInfo WHERE   (TableTypeID =  @TypeID) AND (MainID = @TaskID) GROUP BY ColorID, SizeID ORDER BY ColorID, SizeID");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TypeID", TableTypeID) };
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
            parameters[0].Value = "AmountInfo";
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

