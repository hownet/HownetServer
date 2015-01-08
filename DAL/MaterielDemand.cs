using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类MaterielDemand。
    /// </summary>
    public class MaterielDemand
    {
        public MaterielDemand()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("ID", "MaterielDemand");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MaterielDemand");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MaterielDemand model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterielDemand(");
            strSql.Append("ProduceTaskID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,TableTypeID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount)");
            strSql.Append(" values (");
            strSql.Append("@ProduceTaskID,@MaterielID,@ColorID,@ColorOneID,@ColorTwoID,@Amount,@NotAllotAmount,@stockAmount,@stockNotAmount,@SizeID,@MeasureID,@DepID,@MListID,@TableTypeID,@IsEnd,@RepertoryAmount,@NeedAmount,@HasStockAmount,@OutAmount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ProduceTaskID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAllotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockNotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@RepertoryAmount", SqlDbType.Decimal,9),
					new SqlParameter("@NeedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@HasStockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OutAmount", SqlDbType.Decimal,9)};
            parameters[0].Value = model.ProduceTaskID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorOneID;
            parameters[4].Value = model.ColorTwoID;
            parameters[5].Value = model.Amount;
            parameters[6].Value = model.NotAllotAmount;
            parameters[7].Value = model.stockAmount;
            parameters[8].Value = model.stockNotAmount;
            parameters[9].Value = model.SizeID;
            parameters[10].Value = model.MeasureID;
            parameters[11].Value = model.DepID;
            parameters[12].Value = model.MListID;
            parameters[13].Value = model.TableTypeID;
            parameters[14].Value = model.IsEnd;
            parameters[15].Value = model.RepertoryAmount;
            parameters[16].Value = model.NeedAmount;
            parameters[17].Value = model.HasStockAmount;
            parameters[18].Value = model.OutAmount;

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
        public void Update(Hownet.Model.MaterielDemand model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MaterielDemand set ");
            strSql.Append("ProduceTaskID=@ProduceTaskID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("NotAllotAmount=@NotAllotAmount,");
            strSql.Append("stockAmount=@stockAmount,");
            strSql.Append("stockNotAmount=@stockNotAmount,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("DepID=@DepID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("TableTypeID=@TableTypeID,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("RepertoryAmount=@RepertoryAmount,");
            strSql.Append("NeedAmount=@NeedAmount,");
            strSql.Append("HasStockAmount=@HasStockAmount,");
            strSql.Append("OutAmount=@OutAmount");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@ProduceTaskID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAllotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@stockNotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@RepertoryAmount", SqlDbType.Decimal,9),
					new SqlParameter("@NeedAmount", SqlDbType.Decimal,9),
					new SqlParameter("@HasStockAmount", SqlDbType.Decimal,9),
					new SqlParameter("@OutAmount", SqlDbType.Decimal,9)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.ProduceTaskID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.ColorOneID;
            parameters[5].Value = model.ColorTwoID;
            parameters[6].Value = model.Amount;
            parameters[7].Value = model.NotAllotAmount;
            parameters[8].Value = model.stockAmount;
            parameters[9].Value = model.stockNotAmount;
            parameters[10].Value = model.SizeID;
            parameters[11].Value = model.MeasureID;
            parameters[12].Value = model.DepID;
            parameters[13].Value = model.MListID;
            parameters[14].Value = model.TableTypeID;
            parameters[15].Value = model.IsEnd;
            parameters[16].Value = model.RepertoryAmount;
            parameters[17].Value = model.NeedAmount;
            parameters[18].Value = model.HasStockAmount;
            parameters[19].Value = model.OutAmount;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MaterielDemand ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.MaterielDemand GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,ProduceTaskID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,TableTypeID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount from MaterielDemand ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.MaterielDemand model = new Hownet.Model.MaterielDemand();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ProduceTaskID"].ToString() != "")
                {
                    model.ProduceTaskID = int.Parse(ds.Tables[0].Rows[0]["ProduceTaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
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
                if (ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotAllotAmount"].ToString() != "")
                {
                    model.NotAllotAmount = decimal.Parse(ds.Tables[0].Rows[0]["NotAllotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["stockAmount"].ToString() != "")
                {
                    model.stockAmount = decimal.Parse(ds.Tables[0].Rows[0]["stockAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["stockNotAmount"].ToString() != "")
                {
                    model.stockNotAmount = decimal.Parse(ds.Tables[0].Rows[0]["stockNotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepID"].ToString() != "")
                {
                    model.DepID = int.Parse(ds.Tables[0].Rows[0]["DepID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TableTypeID"].ToString() != "")
                {
                    model.TableTypeID = int.Parse(ds.Tables[0].Rows[0]["TableTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RepertoryAmount"].ToString() != "")
                {
                    model.RepertoryAmount = decimal.Parse(ds.Tables[0].Rows[0]["RepertoryAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NeedAmount"].ToString() != "")
                {
                    model.NeedAmount = decimal.Parse(ds.Tables[0].Rows[0]["NeedAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["HasStockAmount"].ToString() != "")
                {
                    model.HasStockAmount = decimal.Parse(ds.Tables[0].Rows[0]["HasStockAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OutAmount"].ToString() != "")
                {
                    model.OutAmount = decimal.Parse(ds.Tables[0].Rows[0]["OutAmount"].ToString());
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
            strSql.Append("select 1 as A,ID,ProduceTaskID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,TableTypeID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount ");
            strSql.Append(" ,(Select AttributeID from materiel WHERE   (id=MaterielDemand.MaterielID)) as AttribID, 0 as Stata ");
            strSql.Append(" FROM MaterielDemand ");
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
            strSql.Append(" ID,ProduceTaskID,MaterielID,ColorID,ColorOneID,ColorTwoID,Amount,NotAllotAmount,stockAmount,stockNotAmount,SizeID,MeasureID,DepID,MListID,TableTypeID,IsEnd,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount ");
            strSql.Append(" FROM MaterielDemand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 取得生产单拆分后的列表
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetTask(int TaskID, int TableTypeID)
        {
            DataSet ds = new DataSet();
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT ID as DemandID, MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, Amount, NotAllotAmount,  MeasureID, stockAmount, stockNotAmount, ");
            //strSql.Append(" (Select MaterielName from Materiel where (materielid=materieldemand.materielid)) as MaterielName , ");
            //strSql.Append(" (SELECT Num FROM ProduceTaskMain WHERE (ProduceTaskID = MaterielDemand.ProduceTaskID)) AS ProduceTaskNum,(SELECT MaterielID  FROM ProduceTaskMain AS ProduceTask_1 ");
            //strSql.Append(" WHERE (ProduceTaskID = MaterielDemand.ProduceTaskID)) AS ProduceName,DepID FROM MaterielDemand WHERE (ProduceTaskID = @ID)");
            strSql.Append(" SELECT ID , MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID,MListID, MeasureID,Cast(Amount as Real ) as Amount,Cast(NotAllotAmount as Real) as NotAllotAmount,Cast(stockAmount as Real) as stockAmount,Cast(stockNotAmount as Real) as stockNotAmount, ");
            strSql.Append("  DepID FROM MaterielDemand WHERE (ProduceTaskID = @ID) And (TableTypeID=@TableTypeID)");
            SqlParameter[] sps = { new SqlParameter("@ID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
            ds = DbHelperSQL.Query(strSql.ToString(), sps);
            ds.Tables[0].TableName = "dt";
            //strSql.Remove(0, strSql.Length);
            //strSql.Append("SELECT MaterielID AS ID, (SELECT MaterielName FROM Materiel WHERE (MaterielID = MaterielDemand.MaterielID)) ");
            //strSql.Append(" AS Name, (SELECT MeasureName FROM Measure WHERE (MeasureID = MaterielDemand.MeasureID)) AS Measure ");
            //strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @ID) GROUP BY MaterielID, MeasureID");
            //DataSet dss = DbHelperSQL.Query(strSql.ToString(), sps);
            //dss.Tables[0].TableName = "dtMateriel";
            //ds.Tables.Add(dss.Tables[0].Copy());
            //dss.Tables.Clear();
            //strSql.Remove(0, strSql.Length);
            //strSql.Append(" SELECT ColorID AS ID, ColorOneID AS OneID, ColorTwoID AS TwoID, SizeID, (SELECT MaterielAttributeName ");
            //strSql.Append(" FROM MaterielAttribute WHERE (MaterielAttributeID = MaterielDemand.ColorID)) AS Name, (SELECT MaterielAttributeName ");
            //strSql.Append(" FROM MaterielAttribute AS MaterielAttribute_3 WHERE (MaterielAttributeID = MaterielDemand.ColorOneID)) AS OneName, ");
            //strSql.Append(" (SELECT MaterielAttributeName FROM MaterielAttribute AS MaterielAttribute_2 WHERE (MaterielAttributeID = MaterielDemand.ColorTwoID)) AS TwoName, ");
            //strSql.Append(" (SELECT MaterielAttributeName FROM MaterielAttribute AS MaterielAttribute_1 WHERE (MaterielAttributeID = MaterielDemand.SizeID)) AS SizeName ");
            //strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @ID) GROUP BY ColorID, ColorOneID, ColorTwoID, SizeID");
            //DataSet dsco = DbHelperSQL.Query(strSql.ToString(), sps);
            //dsco.Tables[0].TableName = "dtColor";
            //ds.Tables.Add(dsco.Tables[0].Copy());
            //dsco.Tables.Clear();
            return ds;
        }
        ///// <summary>
        ///// 获取配料单所需显示
        ///// </summary>
        ///// <param name="TaskID"></param>
        ///// <returns></returns>
        //public DataSet GetPeiLiao(int TaskID, int DepID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    //strSql.Append("SELECT MaterielDemand.ID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, ");
        //    //strSql.Append(" MaterielDemand.ColorTwoID, MaterielDemand.SizeID, MaterielDemand.Amount, MaterielDemand.NotAllotAmount, ");
        //    //strSql.Append(" MaterielDemand.MeasureID AS DefaultMeasureID, MaterielDemand.ProduceTaskID, (SELECT MaterielID FROM ");
        //    //strSql.Append(" ProduceTaskMain WHERE (ProduceTaskID = MaterielDemand.ProduceTaskID)) AS ProduceTaskName, MaterielDemand.DepID, ");
        //    //strSql.Append(" 0 AS A, Repertory.Price FROM MaterielDemand LEFT OUTER JOIN Repertory ON MaterielDemand.MaterielID = ");
        //    //strSql.Append(" Repertory.MaterielID AND MaterielDemand.ColorID = Repertory.ColorID AND MaterielDemand.ColorOneID = ");
        //    //strSql.Append(" Repertory.ColorOneID AND MaterielDemand.ColorTwoID = Repertory.ColorTwoID AND MaterielDemand.SizeID = ");
        //    //strSql.Append(" Repertory.SizeID WHERE (MaterielDemand.ProduceTaskID = @ID) AND (Repertory.DepartmentID = @DepID) ");
        //    strSql.Append(" SELECT MaterielDemand.ID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, ");
        //    strSql.Append(" MaterielDemand.ColorTwoID, MaterielDemand.SizeID,MaterielDemand.MListID, MaterielDemand.Amount, MaterielDemand.NotAllotAmount,  ");
        //    strSql.Append(" MaterielDemand.MeasureID AS DefaultMeasureID, MaterielDemand.ProduceTaskID, (SELECT MaterielID FROM ProduceTaskMain ");
        //    strSql.Append(" WHERE (ProduceTaskID = MaterielDemand.ProduceTaskID)) AS ProduceTaskName, MaterielDemand.DepID, 0 AS A, Repertory.Price ");
        //    strSql.Append(" FROM MaterielDemand LEFT OUTER JOIN (SELECT ID, Amount, MaxAmount, MinAmount, NotAmount, DepartmentID,  ");
        //    strSql.Append(" MaterielID, SizeID, ColorID, ColorOneID, ColorTwoID, MeasureID, Price, InferiorAmount, BrandID ");
        //    strSql.Append(" FROM Repertory AS Repertory_1 WHERE (DepartmentID = @DepID)) AS Repertory ON  MaterielDemand.MaterielID ");
        //    strSql.Append(" = Repertory.MaterielID AND MaterielDemand.ColorID = Repertory.ColorID AND MaterielDemand.ColorOneID = ");
        //    strSql.Append(" Repertory.ColorOneID AND MaterielDemand.ColorTwoID = Repertory.ColorTwoID AND MaterielDemand.SizeID = ");
        //    strSql.Append(" Repertory.SizeID WHERE (MaterielDemand.ProduceTaskID = @ID) And (TableTypeID=@TableTypeID)");
        //    SqlParameter[] sps = { new SqlParameter("@ID", TaskID), new SqlParameter("@DepID", DepID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 查出某单某物料的未配料数量
        ///// </summary>
        ///// <param name="Num"></param>
        ///// <param name="MListID"></param>
        ///// <returns></returns>
        //public decimal GetNotAmount(int ID)
        //{
        //    decimal amount = 0;
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("SELECT NotAllotAmount FROM MaterielDemand WHERE (ID=@ID)");
        //    SqlParameter[] sps = { new SqlParameter("@ID", ID) };
        //    object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
        //    if (obj != null)
        //    {
        //        amount = decimal.Parse(obj.ToString());
        //    }
        //    return amount;
        //}
        ///// <summary>
        ///// 更新未领料数量
        ///// </summary>
        //public void UpdateNot(Hownet.Model.MaterielDemand model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("update MaterielDemand set ");
        //    strSql.Append("NotAllotAmount=@NotAllotAmount");
        //    strSql.Append(" where ID=@ID ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@ID", SqlDbType.Int,4),
        //            new SqlParameter("@NotAllotAmount", SqlDbType.Real,4)};
        //    parameters[0].Value = model.ID;
        //    parameters[1].Value = model.NotAllotAmount;
        //    DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //}
        ///// <summary>
        ///// 获取采购单所需显示
        ///// </summary>
        ///// <param name="TaskID"></param>
        ///// <returns></returns>
        //public DataSet GetStock(int TaskID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT ID as DemandID, MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID,  stockAmount, stockNotAmount,MeasureID,(SELECT Num FROM ProduceTaskMain ");
        //    strSql.Append(" WHERE (producetaskID = MaterielDemand.ProduceTaskID)) AS ProduceTaskNum, (SELECT MaterielID FROM ProduceTaskMain AS ProduceTask_1 ");
        //    strSql.Append(" WHERE (producetaskID = MaterielDemand.ProduceTaskID)) AS ProduceName FROM MaterielDemand where (ProduceTaskID=@ID) ");
        //    strSql.Append(" And (TableTypeID=@TableTypeID) ");
        //    SqlParameter[] sps = { new SqlParameter("@ID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 查出某单某物料的未采购数量
        ///// </summary>
        ///// <param name="Num"></param>
        ///// <param name="MListID"></param>
        ///// <returns></returns>
        //public decimal GetNotStockAmount(int Num, int MListID, int TableTypeID)
        //{
        //    decimal amount = 0;
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("SELECT stockNotAmount FROM MaterielDemand WHERE ((SELECT Num FROM ProduceTask ");
        //    strSql.Append(" WHERE (ID = MaterielDemand.ProduceTaskID)) = @Num) AND  (MListID = @MListID) And (TableTypeID=@TableTypeID)");
        //    SqlParameter[] sps = { new SqlParameter("@Num", Num), new SqlParameter("@MListID", MListID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    object obj = DbHelperSQL.GetSingle(strSql.ToString(), sps);
        //    if (obj != null)
        //    {
        //        amount = decimal.Parse(obj.ToString());
        //    }
        //    return amount;
        //}
        ///// <summary>
        ///// 更新未采购数量
        ///// </summary>
        //public void UpdateStockNot(Hownet.Model.MaterielDemand model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("update MaterielDemand set ");
        //    strSql.Append("stockNotAmount=@NotAllotAmount");
        //    strSql.Append(" where ID=@ID ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@ID", SqlDbType.Int,4),
        //            new SqlParameter("@NotAllotAmount", SqlDbType.Real,4)};
        //    parameters[0].Value = model.ID;
        //    parameters[1].Value = model.stockNotAmount;
        //    DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //}
        ///// <summary>
        ///// 更新未配货数量
        ///// </summary>
        ///// <param name="model"></param>
        ///// <param name="t">真为退料入库，假为配料出库</param>
        //public void UpPeiLiaokNot(Hownet.Model.MaterielDemand model, bool t)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("update MaterielDemand set ");
        //    if (t)
        //        strSql.Append("NotAllotAmount=NotAllotAmount+@NotAllotAmount");
        //    else
        //        strSql.Append("NotAllotAmount=NotAllotAmount-@NotAllotAmount");
        //    strSql.Append(" where ID=@ID ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@ID", SqlDbType.Int,4),
        //            new SqlParameter("@NotAllotAmount", SqlDbType.Real,4)};
        //    parameters[0].Value = model.ID;
        //    parameters[1].Value = model.NotAllotAmount;
        //    DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //}
        ///// <summary>
        ///// 取得未配货数量
        ///// </summary>
        ///// <param name="AttributeID">物料属性，4为原料，3为外加工，2为半成品，1为成品</param>
        ///// <returns></returns>
        //public DataSet BomNotAmount(int AttributeID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    //strSql.Append(" SELECT MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, MListID,  SUM(NotAllotAmount) AS NotAllotAmount, MeasureID,   SUM(stockNotAmount) AS StockNotAmount, ");
        //    //strSql.Append(" (SELECT AttributeID FROM Materiel WHERE (MaterielID = MaterielDemand.MaterielID)) AS AttributeID, '1' AS Stata ");
        //    //strSql.Append(" FROM MaterielDemand WHERE (NotAllotAmount > 0)");
        //    ////strSql.Append(" WHERE (NotAllotAmount > 0) AND ((SELECT IsEnd FROM ProduceTaskMain  WHERE (ProduceTaskID = MaterielDemand.ProduceTaskID)) = 0) ");
        //    //strSql.Append(" GROUP BY MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, MeasureID, MListID");
        //    //strSql.Append(" HAVING ((SELECT AttributeID FROM Materiel AS Materiel_1 WHERE (MaterielID = MaterielDemand.MaterielID)) = @AttID)");
        //    //strSql.Append(" SELECT MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, SUM(NotAllotAmount)  AS NotAllotAmount, MeasureID, SUM(StockNotAmount) AS StockNotAmount, ");
        //    //strSql.Append(" AttributeID, Stata FROM (SELECT MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, SUM(NotAllotAmount) AS NotAllotAmount, MeasureID, SUM(stockNotAmount) ");
        //    //strSql.Append(" AS StockNotAmount,(SELECT AttributeID FROM Materiel WHERE (MaterielID = MaterielDemand.MaterielID)) AS AttributeID, '1' AS Stata FROM MaterielDemand ");
        //    //strSql.Append(" WHERE (NotAllotAmount > 0) GROUP BY MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, MeasureID HAVING ((SELECT AttributeID FROM Materiel AS Materiel_1 ");
        //    //strSql.Append(" WHERE (MaterielID = MaterielDemand.MaterielID)) = @AttID) UNION ALL SELECT MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, SUM(NotAmount) ");
        //    //strSql.Append(" AS NotAmount, (SELECT DefaultMeasureID FROM Materiel AS Materiel_2 WHERE (MaterielID = MachiningNeedAmount.MaterielID)) AS MeasureID,  0 AS StockAMount, ");
        //    //strSql.Append(" (SELECT AttributeID FROM Materiel AS Materiel_1 WHERE (MaterielID = MachiningNeedAmount.MaterielID)) AS AttributeID, 1 AS Stata FROM MachiningNeedAmount ");
        //    //strSql.Append(" WHERE (NotAmount > 0) GROUP BY MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID HAVING ((SELECT AttributeID FROM Materiel AS Materiel_1 ");
        //    //strSql.Append(" WHERE (MaterielID = MachiningNeedAmount.MaterielID)) = @AttID))  AS Tem GROUP BY MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, MeasureID, AttributeID, Stata");
        //    strSql.Append(" SELECT MListID, SUM(NotAllotAmount) AS Demand FROM MaterielDemand WHERE ((SELECT AttributeID ");
        //    strSql.Append(" FROM Materiel AS Materiel_1 WHERE (MaterielID = MaterielDemand.MaterielID)) = @AttID) AND  ");
        //    strSql.Append(" (NotAllotAmount > 0) AND ((SELECT IsEnd FROM ProduceTaskMain ");
        //    strSql.Append(" WHERE (ProduceTaskID = MaterielDemand.ProduceTaskID)) < 8) And (TableTypeID=@TableTypeID) GROUP BY MListID");
        //    SqlParameter[] sps = { new SqlParameter("@AttID", AttributeID), new SqlParameter("TableTypeID", TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        //public DataSet BomNotAmountByTogethers(int AttributeID, int MaterielID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("SELECT MaterielDemand.MListID, SUM(MaterielDemand.NotAllotAmount) AS Demand,  '1' AS Stata, ");
        //    strSql.Append(" (SELECT AttributeID FROM Materiel AS Materiel_1 WHERE (MaterielID = MaterielDemand.MaterielID)) ");
        //    strSql.Append(" AS AttributeID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, ");
        //    strSql.Append(" MaterielDemand.ColorTwoID, (SELECT DefaultMeasureID FROM Materiel WHERE (MaterielID = ");
        //    strSql.Append(" MaterielDemand.MaterielID)) AS MeasureID FROM MaterielDemand INNER JOIN ProduceTaskMain ON  ");
        //    strSql.Append(" MaterielDemand.ProduceTaskID = ProduceTaskMain.ProduceTaskID INNER JOIN MaterielStructMain ON ");
        //    strSql.Append(" ProduceTaskMain.BomID = MaterielStructMain.MainID INNER JOIN MaterielStructInfo ON ");
        //    strSql.Append(" MaterielStructMain.MainID = MaterielStructInfo.MainID WHERE (ProduceTaskMain.IsEnd < 8) AND ");
        //    strSql.Append(" (MaterielDemand.NotAllotAmount > 0) AND (MaterielStructInfo.IsTogethers = 1) AND ");
        //    strSql.Append(" (MaterielStructInfo.ChildMaterielID = @MaterielID) AND ((SELECT AttributeID FROM Materiel AS ");
        //    strSql.Append(" Materiel_1 WHERE (MaterielID = MaterielDemand.MaterielID)) = @AttID) GROUP BY ");
        //    strSql.Append(" MaterielDemand.MListID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, ");
        //    strSql.Append(" MaterielDemand.ColorTwoID");
        //    SqlParameter[] sps = { new SqlParameter("@AttID", AttributeID), new SqlParameter("@MaterielID", MaterielID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        //public DataSet BomNotAmountByCompanyID(int AttributeID, int CompanyID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT MaterielDemand.MListID, SUM(MaterielDemand.NotAllotAmount) AS Demand, '1' AS Stata, ");
        //    strSql.Append(" (SELECT AttributeID FROM Materiel AS Materiel_1 WHERE (MaterielID = MaterielDemand.MaterielID)) ");
        //    strSql.Append(" AS AttributeID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, ");
        //    strSql.Append(" MaterielDemand.ColorTwoID,(SELECT DefaultMeasureID FROM Materiel WHERE (MaterielID = ");
        //    strSql.Append(" MaterielDemand.MaterielID)) AS MeasureID FROM MaterielDemand INNER JOIN ProduceTaskMain ON ");
        //    strSql.Append(" MaterielDemand.ProduceTaskID = ProduceTaskMain.ProduceTaskID WHERE (ProduceTaskMain.IsEnd < 8) ");
        //    strSql.Append(" AND (MaterielDemand.NotAllotAmount > 0) AND ((SELECT AttributeID FROM Materiel AS Materiel_1 ");
        //    strSql.Append(" WHERE (MaterielID = MaterielDemand.MaterielID)) = @AttID) AND (ProduceTaskMain.CompanyID = ");
        //    strSql.Append(" @CompanyID) GROUP BY MaterielDemand.MListID, MaterielDemand.MaterielID, ");
        //    strSql.Append(" MaterielDemand.ColorID, MaterielDemand.ColorOneID, MaterielDemand.ColorTwoID");
        //    SqlParameter[] sps = { new SqlParameter("@AttID", AttributeID), new SqlParameter("@CompanyID", CompanyID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        //public DataSet BomNotAmountByToAndCom(int AttributeID, int MaterielID, int CompanyID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("SELECT MaterielDemand.MListID, SUM(MaterielDemand.NotAllotAmount) AS Demand,  '1' AS Stata, ");
        //    strSql.Append(" (SELECT AttributeID FROM Materiel AS Materiel_1 WHERE (MaterielID = MaterielDemand.MaterielID)) ");
        //    strSql.Append(" AS AttributeID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, ");
        //    strSql.Append(" MaterielDemand.ColorTwoID, (SELECT DefaultMeasureID FROM Materiel WHERE (MaterielID = ");
        //    strSql.Append(" MaterielDemand.MaterielID)) AS MeasureID FROM MaterielDemand INNER JOIN ProduceTaskMain ON  ");
        //    strSql.Append(" MaterielDemand.ProduceTaskID = ProduceTaskMain.ProduceTaskID INNER JOIN MaterielStructMain ON ");
        //    strSql.Append(" ProduceTaskMain.BomID = MaterielStructMain.MainID INNER JOIN MaterielStructInfo ON ");
        //    strSql.Append(" MaterielStructMain.MainID = MaterielStructInfo.MainID WHERE (ProduceTaskMain.IsEnd < 8) AND ");
        //    strSql.Append(" (MaterielDemand.NotAllotAmount > 0) AND (MaterielStructInfo.IsTogethers = 1) AND ");
        //    strSql.Append(" (MaterielStructInfo.ChildMaterielID = @MaterielID) AND ((SELECT AttributeID FROM Materiel AS ");
        //    strSql.Append(" Materiel_1 WHERE (MaterielID = MaterielDemand.MaterielID)) = @AttID) And ");
        //    strSql.Append("(ProduceTaskMain.CompanyID = @CompanyID) GROUP BY ");
        //    strSql.Append(" MaterielDemand.MListID, MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, ");
        //    strSql.Append(" MaterielDemand.ColorTwoID");
        //    SqlParameter[] sps = { new SqlParameter("@AttID", AttributeID), 
        //                             new SqlParameter("@MaterielID", MaterielID), 
        //                             new SqlParameter("@CompanyID", CompanyID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 获取颜色
        ///// </summary>
        ///// <param name="TaskID"></param>
        ///// <returns></returns>
        //public SqlDataReader GetColor(int TaskID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT (SELECT MaterielAttributeName FROM MaterielAttribute WHERE (MaterielAttributeID = MaterielDemand.ColorID)) AS ColorName, ColorID ");
        //    strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @ID) And (TableTypeID=@TableTypeID) AND (ColorID > 0) GROUP BY ColorID");
        //    SqlParameter[] sps = { new SqlParameter("@ID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    return DbHelperSQL.ExecuteReader(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 获得物料名
        ///// </summary>
        ///// <param name="TaskID"></param>
        ///// <returns></returns>
        //public SqlDataReader GetMateriel(int TaskID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT (SELECT MaterielName FROM Materiel WHERE (ID = MaterielDemand.MaterielID)) AS MaterielName, MaterielID ");
        //    strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @ID) AND (ColorID > 0) And (TableTypeID=@TableTypeID) GROUP BY MaterielID");
        //    SqlParameter[] sps = { new SqlParameter("@ID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    return DbHelperSQL.ExecuteReader(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 取得未配货数量
        ///// </summary>
        ///// <param name="mod"></param>
        ///// <returns></returns>
        //public string GetNotPeiLiaoAmount(Hownet.Model.MaterielDemand mod)
        //{
        //    string val = string.Empty;
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT NotAllotAmount FROM MaterielDemand WHERE (ProduceTaskID = @ID) AND (ColorID = @ColorID) AND (MaterielID = @MaterielID)");
        //    SqlParameter[] sq = { new SqlParameter("@ID", mod.ProduceTaskID), new SqlParameter("@ColorID", mod.ColorID), new SqlParameter("@MaterielID", mod.MaterielID) };
        //    object obj = DbHelperSQL.GetSingle(strSql.ToString(), sq);
        //    if (obj != null)
        //    {
        //        val = obj.ToString();
        //    }
        //    return val;
        //}
        ///// <summary>
        ///// 取得未采购数量
        ///// </summary>
        ///// <param name="mod"></param>
        ///// <returns></returns>
        //public string GetNotStockAmount(Hownet.Model.MaterielDemand mod)
        //{
        //    string val = string.Empty;
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT stockNotAmount FROM MaterielDemand WHERE (ProduceTaskID = @ID) AND (ColorID = @ColorID) AND (MaterielID = @MaterielID)");
        //    SqlParameter[] sq = { new SqlParameter("@ID", mod.ProduceTaskID), new SqlParameter("@ColorID", mod.ColorID), new SqlParameter("@MaterielID", mod.MaterielID) };
        //    object obj = DbHelperSQL.GetSingle(strSql.ToString(), sq);
        //    if (obj != null)
        //    {
        //        val = obj.ToString();
        //    }
        //    return val;
        //}
        ///// <summary>
        ///// 返回领料分析图表的数据
        ///// </summary>
        ///// <returns></returns>
        //public DataSet GetFenXiList(Hownet.Model.MaterielDemand model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    if (model.ColorID == 0)
        //    {
        //        strSql.Append("SELECT (SELECT MaterielAttributeName FROM MaterielAttribute WHERE (MaterielAttributeID = MaterielDemand.ColorID)) AS Name, Amount,  Amount - NotAllotAmount AS PeiLiaoAmount ");
        //        strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @TaskID) AND (MaterielID = @MaterielID) and (colorID>0)");
        //    }
        //    if (model.MaterielID == 0)
        //    {
        //        strSql.Append(" SELECT (SELECT MaterielName FROM Materiel WHERE (MaterielID = MaterielDemand.MaterielID)) AS Name, Amount,  Amount - NotAllotAmount AS PeiLiaoAmount ");
        //        strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @TaskID) AND (ColorID = @ColorID)");
        //    }
        //    SqlParameter[] sps = { new SqlParameter("@TaskID", model.ProduceTaskID), new SqlParameter("@MaterielID", model.MaterielID), new SqlParameter("@ColorID", model.ColorID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 返回分析时所需的物料名
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public DataSet GetFenXiMaterielID(Hownet.Model.MaterielDemand model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT Materiel.MaterielName,MaterielDemand.MaterielID FROM MaterielDemand INNER JOIN Materiel ON MaterielDemand.MaterielID = Materiel.MaterielID ");
        //    strSql.Append(" WHERE (MaterielDemand.ProduceTaskID = @TaskID) ");
        //    if (model.DepID != 0)
        //        strSql.Append(" AND (DepID = @DepID) ");
        //    strSql.Append(" GROUP BY Materiel.MaterielName, MaterielDemand.MaterielID");
        //    SqlParameter[] sps = { new SqlParameter("@TaskID", model.ProduceTaskID), new SqlParameter("@DepID", model.DepID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 返回某生产单中物料所具有颜色
        ///// </summary>
        ///// <param name="TaskID"></param>
        ///// <returns></returns>
        //public DataSet GetFenXiColor(int TaskID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT ColorID AS ID, (SELECT MaterielAttributeName FROM MaterielAttribute WHERE (MaterielAttributeID = MaterielDemand.ColorID)) AS ColorName ");
        //    strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @TaskID) And (TableTypeID=@TableTypeID) GROUP BY ColorID HAVING (ColorID > 0)");
        //    SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 物料需求汇总所表列表
        ///// </summary>
        ///// <param name="TaskID"></param>
        ///// <returns></returns>
        //public DataSet GetTaskAtion(int TaskID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("SELECT MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, stockAmount, Amount,  MeasureID, ");
        //    strSql.Append(" 1 AS AttribID, 1 AS Stata, DepID, stockNotAmount, NotAllotAmount FROM MaterielDemand ");
        //    strSql.Append(" WHERE (ProduceTaskID = @ID) And (TableTypeID=@TableTypeID)");
        //    SqlParameter[] sps = { new SqlParameter("@ID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 配料单获取需加工列表
        ///// </summary>
        ///// <param name="TaskID"></param>
        ///// <returns></returns>
        //public DataSet GetWXList(int TaskID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("SELECT ID, MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, stockAmount, stockNotAmount, ");
        //    strSql.Append(" MeasureID AS DefaultMeasureID, ProduceTaskID, (SELECT MaterielID FROM ProduceTaskMain ");
        //    strSql.Append(" WHERE (ProduceTaskID = MaterielDemand.ProduceTaskID)) AS ProduceTaskName, DepID, 0 AS A ");
        //    strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @ID) And (TableTypeID=@TableTypeID) AND ((SELECT AttributeID FROM Materiel ");
        //    strSql.Append(" WHERE (MaterielID = MaterielDemand.MaterielID)) = 3)");
        //    SqlParameter[] sps = { new SqlParameter("@ID", TaskID), new SqlParameter("TableTypeID", TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 更新分部门领料后的未配料数量
        ///// </summary>
        ///// <param name="t">真为审核减少，假为弃审增加</param>
        //public void UpDepPeiLiao(Hownet.Model.MaterielDemand model, bool t)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("update MaterielDemand set ");
        //    if (t)
        //        strSql.Append("NotAllotAmount=NotAllotAmount- @NotAllotAmount ");
        //    else
        //        strSql.Append("NotAllotAmount=NotAllotAmount+ @NotAllotAmount ");
        //    strSql.Append(" where (ProduceTaskID=@ProduceTaskID) and ");
        //    strSql.Append("(MaterielID=@MaterielID) and ");
        //    strSql.Append("(ColorID=@ColorID) and ");
        //    strSql.Append("(ColorOneID=@ColorOneID) and ");
        //    strSql.Append(" (ColorTwoID=@ColorTwoID) and (SizeID=@SizeID)");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@ProduceTaskID", SqlDbType.Int,4),
        //            new SqlParameter("@MaterielID", SqlDbType.Int,4),
        //            new SqlParameter("@ColorID", SqlDbType.Int,4),
        //            new SqlParameter("@ColorOneID", SqlDbType.Int,4),
        //            new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
        //            new SqlParameter("@NotAllotAmount", SqlDbType.Real,4),
        //            new SqlParameter("@SizeID",SqlDbType.Int,4)};
        //    parameters[0].Value = model.ProduceTaskID;
        //    parameters[1].Value = model.MaterielID;
        //    parameters[2].Value = model.ColorID;
        //    parameters[3].Value = model.ColorOneID;
        //    parameters[4].Value = model.ColorTwoID;
        //    parameters[5].Value = model.NotAllotAmount;
        //    parameters[6].Value = model.SizeID;

        //    DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //}
        ///// <summary>
        ///// 返回用于外协出库原料时所能扣减数量的列表
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public DataSet GetWXList(Hownet.Model.MaterielDemand model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT NotAllotAmount, ID FROM MaterielDemand WHERE (NotAllotAmount > 0) AND ");
        //    strSql.Append(" ((SELECT OtherTypeName FROM OtherType WHERE (OtherTypeID = MaterielDemand.DepID)) ");
        //    strSql.Append(" = '外加工') AND  (MaterielID = @MatID) AND (ColorID = @CoID) AND (ColorOneID = @CoOneID) AND ");
        //    strSql.Append(" (ColorTwoID = @CoTwoID) AND (SizeID = @SizeID) ORDER BY ID");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@MatID", SqlDbType.Int,4),
        //            new SqlParameter("@CoID", SqlDbType.Int,4),
        //            new SqlParameter("@CoOneID", SqlDbType.Int,4),
        //            new SqlParameter("@CoTwoID", SqlDbType.Int,4),
        //            new SqlParameter("@SizeID",SqlDbType.Int,4)};
        //    parameters[0].Value = model.MaterielID;
        //    parameters[1].Value = model.ColorID;
        //    parameters[2].Value = model.ColorOneID;
        //    parameters[3].Value = model.ColorTwoID;
        //    parameters[4].Value = model.SizeID;
        //    return DbHelperSQL.Query(strSql.ToString(), parameters);
        //}
        ///// <summary>
        ///// 更新分部门领料后的未配料数量
        ///// </summary>
        ///// <param name="t">真为审核减少，假为弃审增加</param>
        //public void UpDepPeiLiao(int ID, decimal Amount, bool t)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("update MaterielDemand set ");
        //    if (t)
        //        strSql.Append("NotAllotAmount=NotAllotAmount- @NotAllotAmount ");
        //    else
        //        strSql.Append("NotAllotAmount=NotAllotAmount+ @NotAllotAmount ");
        //    strSql.Append(" where (ID=@ID) ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@ID", SqlDbType.Int,4),
        //            new SqlParameter("@NotAllotAmount", SqlDbType.Real,4)};
        //    parameters[0].Value = ID;
        //    parameters[1].Value = Amount;
        //    DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        //}
        //public DataSet GetPeiLiao(int DepotID, int TaskID, int OTID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT 0 AS ID, ID AS DemandID, 0 AS A, MaterielID, ColorID, ColorOneID, ColorTwoID, ");
        //    strSql.Append(" Amount, NotAllotAmount AS NotAmount, SizeID,MListID, NotAllotAmount AS Tem, MeasureID, MListID, ");
        //    strSql.Append(" (Amount - NotAllotAmount ) as PeiLiaoAmount ,(Amount - NotAllotAmount ) as TemAmount,");
        //    strSql.Append(" (SELECT ID FROM Repertory WHERE (MListID = MaterielDemand.MListID) AND (DepartmentID = @DepotID))  ");
        //    strSql.Append(" AS RepertoryID, (SELECT Amount  FROM Repertory AS Repertory_1 ");
        //    strSql.Append(" WHERE (MListID = MaterielDemand.MListID) AND (DepartmentID = @DepotID)) AS RepAmount ");
        //    strSql.Append(" FROM MaterielDemand WHERE (DepID = @OTID) AND (ProduceTaskID = @TaskID) And (TableTypeID=@TableTypeID)");
        //    SqlParameter[] sps = { new SqlParameter("@OTID", OTID), new SqlParameter("@DepotID", DepotID), 
        //                             new SqlParameter("@TaskID", TaskID),new SqlParameter("@TableTypeID",TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        //public DataSet GetOutList(int TaskID, int TableTypeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT MaterielID, ColorID, ColorOneID, ColorTwoID, Amount, NotAllotAmount, ");
        //    strSql.Append(" Amount - NotAllotAmount AS OutAmount, SizeID, MeasureID, (SELECT TOP 1 Price ");
        //    strSql.Append(" FROM Repertory WHERE (MListID = MaterielDemand.MListID)) AS Price ");
        //    strSql.Append(" FROM MaterielDemand WHERE (ProduceTaskID = @TaskID) And (TableTypeID=@TableTypeID)");
        //    SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        ///// <summary>
        ///// 取得未配货数量，计划单审核后未分配生产单，已经审核后的生产单
        ///// </summary>
        ///// <param name="AttributeID"></param>
        ///// <returns></returns>
        //public DataSet BomNotAmount(int AttributeID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("SELECT   MListID, CAST(SUM(Demand) AS real) AS Demand FROM (SELECT   MaterielDemand.MListID, ");
        //    strSql.Append(" MaterielDemand.NotAllotAmount AS Demand FROM MaterielDemand INNER JOIN ProductionPlan ON ");
        //    strSql.Append(" MaterielDemand.ProduceTaskID = ProductionPlan.ID INNER JOIN Materiel ON MaterielDemand.MaterielID ");
        //    strSql.Append(" = Materiel.ID WHERE   (ProductionPlan.IsVerify = 3) AND (MaterielDemand.NotAllotAmount > 0) AND ");
        //    strSql.Append(" (MaterielDemand.TableTypeID = 41) AND (Materiel.AttributeID = @AttributeID) And (MaterielDemand.IsEnd=0) UNION ALL ");
        //    strSql.Append(" SELECT   MaterielDemand_1.MListID, MaterielDemand_1.NotAllotAmount AS Demand FROM  ");
        //    strSql.Append(" MaterielDemand AS MaterielDemand_1 INNER JOIN ProductTaskMain ON MaterielDemand_1.ProduceTaskID ");
        //    strSql.Append(" = ProductTaskMain.ID INNER JOIN Materiel AS Materiel_1 ON MaterielDemand_1.MaterielID = Materiel_1.ID ");
        //    strSql.Append(" WHERE   (ProductTaskMain.IsVerify = 3) AND (MaterielDemand_1.NotAllotAmount > 0) AND (MaterielDemand_1.IsEnd=0) And");
        //    strSql.Append(" (MaterielDemand_1.TableTypeID = 1) AND (Materiel_1.AttributeID = @AttributeID)) AS T GROUP BY MListID");
        //    SqlParameter[] sps = { new SqlParameter("@AttributeID", AttributeID) };
        //    return DbHelperSQL.Query(strSql.ToString(), sps);
        //}
        /// <summary>
        /// 取得某一未配货物料的明细
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet ShowInfo(int MListID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   T.TableType, T.Num, MaterielList.MaterielID, MaterielList.ColorID, MaterielList.ColorOneID, MaterielList.ColorTwoID, ");
            strSql.Append(" MaterielList.SizeID, MaterielList.BrandID, MaterielList.MeasureID,Cast(T.Demand as Real) as Amount, T.MListID, T.ID FROM (SELECT   '计划单' AS ");
            strSql.Append(" TableType, CONVERT(varchar(100), ProductionPlan.DateTime, 112) + REPLACE(STR(ProductionPlan.Num, 3, 0), ' ', '0') AS Num, ");
            strSql.Append(" MaterielDemand.MListID, MaterielDemand.NotAllotAmount AS Demand, MaterielDemand.ID FROM MaterielDemand INNER JOIN ");
            strSql.Append(" ProductionPlan ON MaterielDemand.ProduceTaskID = ProductionPlan.ID WHERE   (ProductionPlan.IsVerify = 3) AND ");
            strSql.Append(" (MaterielDemand.NotAllotAmount > 0) AND (MaterielDemand.TableTypeID = 41) AND (MaterielDemand.IsEnd = 0) AND  ");
            strSql.Append(" (MaterielDemand.MListID = @MListID) UNION ALL SELECT   '生产单' AS TableType, CONVERT(varchar(100), ProductTaskMain.DateTime, ");
            strSql.Append(" 112) + REPLACE(STR(ProductTaskMain.Num, 3, 0), ' ', '0') AS Num, MaterielDemand_1.MListID, MaterielDemand_1.NotAllotAmount AS ");
            strSql.Append(" Demand, MaterielDemand_1.ID FROM MaterielDemand AS MaterielDemand_1 INNER JOIN ProductTaskMain ON MaterielDemand_1.ProduceTaskID ");
            strSql.Append(" = ProductTaskMain.ID WHERE   (ProductTaskMain.IsVerify = 3) AND (MaterielDemand_1.NotAllotAmount > 0) AND  (MaterielDemand_1.TableTypeID ");
            strSql.Append(" = 1) AND (MaterielDemand_1.IsEnd = 0) AND (MaterielDemand_1.MListID = @MListID)) AS T INNER JOIN MaterielList ON T.MListID = MaterielList.ID");
            SqlParameter[] sps = { new SqlParameter("@MListID", MListID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 删除某次已计算的物料需求
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        public void DelNeed(int MainID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM MaterielDemand WHERE   (ProduceTaskID = @MainID) AND (TableTypeID = @TableTypeID)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID), new SqlParameter("@TableTypeID", TableTypeID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 在物料计划时，返回一系列计划单的物料情况
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNeedAmount(string strWhere, string strTask)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT   MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, MeasureID, MListID, ");
            //strSql.Append(" CAST(SUM(Amount) AS real) AS Amount, CAST(SUM(NotAllotAmount) AS real) AS NotAllotAmount, CAST(SUM(stockAmount) ");
            //strSql.Append(" AS real) AS stockAmount, CAST(SUM(stockNotAmount) AS real) AS stockNotAmount ");
            //strSql.Append(" ,CAST(SUM(RepertoryAmount) AS real) AS RepertoryAmount,CAST(SUM(HasStockAmount) AS real) AS HasStockAmount ");
            //strSql.Append(" ,CAST(SUM(NeedAmount) AS real) AS NeedAmount,CAST(SUM(OutAmount) AS real) AS OutAmount ");
            //strSql.Append(" FROM MaterielDemand WHERE   ");
            //strSql.Append(strWhere + strTask + "))");
            //strSql.Append("GROUP BY MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, MeasureID, MListID");

            strSql.Append("SELECT   MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, MaterielDemand.ColorTwoID, ");
            strSql.Append(" MaterielDemand.SizeID, MaterielDemand.MeasureID, MaterielDemand.MListID, CAST(SUM(MaterielDemand.Amount) ");
            strSql.Append(" AS real) AS Amount, CAST(SUM(MaterielDemand.NotAllotAmount) AS real) AS NotAllotAmount, ");
            strSql.Append(" CAST(SUM(MaterielDemand.stockAmount) AS real) AS stockAmount, CAST(SUM(MaterielDemand.stockNotAmount) ");
            strSql.Append(" AS real) AS stockNotAmount, CAST(SUM(MaterielDemand.RepertoryAmount) AS real) AS RepertoryAmount, ");
            strSql.Append(" (Select Remark FROM Materiel Where (ID=MaterielDemand.MaterielID)) as MaterielRemark ,");
            strSql.Append(" CAST(SUM(MaterielDemand.HasStockAmount) AS real) AS HasStockAmount, CAST(SUM(MaterielDemand.NeedAmount) ");
            strSql.Append(" AS real) AS NeedAmount, CAST(SUM(MaterielDemand.OutAmount) AS real) AS OutAmount, t.OutNeed ");
            strSql.Append(" FROM      MaterielDemand LEFT OUTER JOIN (SELECT   CAST(sum( StockBackInfo_1.NotAmount * - 1 ) AS real) AS OutNeed, ");
            strSql.Append(" StockBackInfo.MListID FROM      StockBackInfo INNER JOIN StockBack ON StockBackInfo.MainID = StockBack.ID INNER JOIN ");
            strSql.Append(" StockBackInfo AS StockBackInfo_1 ON StockBackInfo.StockInfoID = StockBackInfo_1.ID WHERE   (StockBackInfo.Amount ");
            strSql.Append(" = StockBackInfo.NotAmount) AND (StockBackInfo_1.NotAmount * - 1 > 0) AND (StockBackInfo.IsEnd = 0) AND (StockBack.State ");
            strSql.Append(" = 23) GROUP BY StockBackInfo.MListID) AS t ON MaterielDemand.MListID = t.MListID WHERE  "); //(MaterielDemand.IsEnd = 0) AND (MaterielDemand.TableTypeID = 41) 
            strSql.Append(strWhere + strTask + "))");
            strSql.Append(" GROUP BY MaterielDemand.MaterielID, MaterielDemand.ColorID, MaterielDemand.ColorOneID, MaterielDemand.ColorTwoID, ");
            strSql.Append(" MaterielDemand.SizeID, MaterielDemand.MeasureID, MaterielDemand.MListID, t.OutNeed");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取在一些计划单中，使用某物料的明细，用于分配使用库存量或使用采购余量
        /// </summary>
        /// <param name="MListID"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNeedAmountByMListID(int MListID, string strWhere,int TypeID,string strTaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ProduceTaskID,MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, MeasureID, MListID,  CAST(stockAmount ");
            strSql.Append(" AS real) AS stockAmount, CAST(stockNotAmount AS real) AS stockNotAmount ,ID ");
            strSql.Append(" ,RepertoryAmount,NeedAmount,HasStockAmount,OutAmount FROM      MaterielDemand WHERE (MListID = " + MListID + ") And ");
            strSql.Append(strWhere + strTaskID + "))");
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            ds.Tables[0].Columns.Add("Num", typeof(string));
            if (ds.Tables[0].Rows.Count > 0)
            {
                Hownet.DAL.ProductionPlan dalPP = new ProductionPlan();
                DataTable dtPP = new DataTable();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    dtPP = dalPP.GetList("(ID=" + ds.Tables[0].Rows[i]["ProduceTaskID"] + ")").Tables[0];
                    if (TypeID == 0)
                        ds.Tables[0].Rows[i]["Num"] = dtPP.Rows[0]["Num"];
                    else if (TypeID == 1)
                        ds.Tables[0].Rows[i]["Num"] = Convert.ToDateTime(dtPP.Rows[0]["DateTime"]).Year.ToString() + "-" + dtPP.Rows[0]["Num"].ToString().PadLeft(3, '0');
                    else if (TypeID == 2)
                        ds.Tables[0].Rows[i]["Num"] = Convert.ToDateTime(dtPP.Rows[0]["DateTime"]).ToString("yyyyMMdd").Substring(0,6) + "-" + dtPP.Rows[0]["Num"].ToString().PadLeft(3, '0');
                    else if (TypeID == 3)
                        ds.Tables[0].Rows[i]["Num"] = Convert.ToDateTime(dtPP.Rows[0]["DateTime"]).ToString("yyyyMMdd")+ "-" + dtPP.Rows[0]["Num"].ToString().PadLeft(3, '0'); ;
                }
            }
            return ds;
        }
        /// <summary>
        /// 查找某生产计划或生产单的数量，用于手动增加申购单
        /// </summary>
        /// <param name="PlanID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet GetListByPlanID(int PlanID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   3 AS A, 0 AS ID, 0 AS MainID, 0 AS StockInfoID, MaterielID, ColorID, ColorOneID, ColorTwoID, SizeID, 0 AS Price, ");
            strSql.Append(" MeasureID AS CompanyMeasureID, MeasureID AS DepotMeasureID, 1 AS Conversion, '' AS Remark, 0 AS PriceAmount, ");
            strSql.Append(" 0 AS NotAmount, 0 AS Money, 0 AS NotPriceAmount, MListID, 0 AS CompanyID, 0 AS BrandID, 0 AS IsEnd, ");
            strSql.Append(" (Select Remark FROM Materiel Where (ID=MaterielDemand.MaterielID)) as MaterielRemark ,");
            strSql.Append(" ID AS DemandID, 0 AS NeedAmount, 0 AS ExcessAmount, ProduceTaskID AS StringTaskID FROM      MaterielDemand ");
            strSql.Append(" WHERE   (TableTypeID = @TableTypeID) AND (ProduceTaskID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TableTypeID", TableTypeID), new SqlParameter("@TaskID", PlanID) };
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
            parameters[0].Value = "MaterielDemand";
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

