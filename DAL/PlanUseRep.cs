using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类PlanUseRep。
	/// </summary>
	public class PlanUseRep
	{
		public PlanUseRep()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "PlanUseRep"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from PlanUseRep");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.PlanUseRep model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into PlanUseRep(");
            strSql.Append("RelatedID,Amount,DemandID,TypeID,MListID,TaskID,StockInfoID,NotAmount,IsEnd)");
            strSql.Append(" values (");
            strSql.Append("@RelatedID,@Amount,@DemandID,@TypeID,@MListID,@TaskID,@StockInfoID,@NotAmount,@IsEnd)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@RelatedID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@DemandID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@StockInfoID", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
            parameters[0].Value = model.RelatedID;
            parameters[1].Value = model.Amount;
            parameters[2].Value = model.DemandID;
            parameters[3].Value = model.TypeID;
            parameters[4].Value = model.MListID;
            parameters[5].Value = model.TaskID;
            parameters[6].Value = model.StockInfoID;
            parameters[7].Value = model.NotAmount;
            parameters[8].Value = model.IsEnd;

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
        public void Update(Hownet.Model.PlanUseRep model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PlanUseRep set ");
            strSql.Append("RelatedID=@RelatedID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("DemandID=@DemandID,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("StockInfoID=@StockInfoID,");
            strSql.Append("NotAmount=@NotAmount,");
            strSql.Append("IsEnd=@IsEnd");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@RelatedID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@DemandID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@StockInfoID", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@IsEnd", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.RelatedID;
            parameters[2].Value = model.Amount;
            parameters[3].Value = model.DemandID;
            parameters[4].Value = model.TypeID;
            parameters[5].Value = model.MListID;
            parameters[6].Value = model.TaskID;
            parameters[7].Value = model.StockInfoID;
            parameters[8].Value = model.NotAmount;
            parameters[9].Value = model.IsEnd;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PlanUseRep ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.PlanUseRep GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,RelatedID,Amount,DemandID,TypeID,MListID,TaskID,StockInfoID,NotAmount,IsEnd from PlanUseRep ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.PlanUseRep model = new Hownet.Model.PlanUseRep();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RelatedID"].ToString() != "")
                {
                    model.RelatedID = int.Parse(ds.Tables[0].Rows[0]["RelatedID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DemandID"].ToString() != "")
                {
                    model.DemandID = int.Parse(ds.Tables[0].Rows[0]["DemandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StockInfoID"].ToString() != "")
                {
                    model.StockInfoID = int.Parse(ds.Tables[0].Rows[0]["StockInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotAmount"].ToString() != "")
                {
                    model.NotAmount = decimal.Parse(ds.Tables[0].Rows[0]["NotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
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
            strSql.Append("select 1 as A,ID,RelatedID,Amount,DemandID,TypeID,MListID,TaskID,StockInfoID,NotAmount,IsEnd ");
            strSql.Append(" FROM PlanUseRep ");
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
            strSql.Append(" ID,RelatedID,Amount,DemandID,TypeID,MListID,TaskID,StockInfoID,NotAmount,IsEnd ");
            strSql.Append(" FROM PlanUseRep ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public decimal GetAmount(int MListID, int TypeID, string strTask)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SUM(Amount) AS Amount, SUM(NotAmount) AS NotAmount FROM      PlanUseRep ");
            strSql.Append(" WHERE   (TypeID = @TypeID) AND (MListID = @MListID) AND (TaskID IN ("+strTask+")) And (IsEnd=0)");
            SqlParameter[] sps = { new SqlParameter("@MListID", MListID), new SqlParameter("@TypeID", TypeID)};
            DataTable dt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            //if (dt.Rows.Count == 0)
            //    return 0;
            //else
                try
                {
                    decimal a = Convert.ToDecimal(dt.Rows[0]["NotAmount"]);
                    return Convert.ToDecimal(dt.Rows[0]["NotAmount"]);
                }
                catch (Exception ex)
                {
                    return 0;
                }
        }
        public decimal GetNeedStock(int MListID, int DemandID, int RepTypeID, int NeedTypeID, int StockTypeID, int PeiLiaoTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   stockNotAmount, (SELECT  sum(NotAmount) as NotAmount FROM      PlanUseRep WHERE   (DemandID = @DemandID) AND ");
            strSql.Append(" (MListID = @MListID) AND (TypeID = @RepTypeID) And (IsEnd=0)) AS RepAmount,(SELECT sum(NotAmount) as  NotAmount FROM      PlanUseRep ");
            strSql.Append(" AS PlanUseRep_2 WHERE   (DemandID = @DemandID) AND (MListID = @MListID) AND (TypeID = @NeedTypeID) And (IsEnd=0)) AS ");
            strSql.Append(" NeedAmount, (SELECT  sum(NotAmount) as NotAmount FROM PlanUseRep AS PlanUseRep_1 WHERE   (DemandID = @DemandID) AND ");
            strSql.Append(" (MListID = @MListID) AND (TypeID = @StockTypeID) And (IsEnd=0)) AS StockAmount, (SELECT   SUM(NotAmount) AS NotAmount ");
            strSql.Append(" FROM      PlanUseRep AS PlanUseRep_1 WHERE   (DemandID = @DemandID) AND (MListID = @MListID) AND (TypeID = ");
            strSql.Append(" @PeiLiaoTypeID) And (IsEnd=0)) AS PeiLiaoAmount FROM      MaterielDemand WHERE   (ID = @DemandID)");
            SqlParameter[] sps = { new SqlParameter("@DemandID",DemandID),new SqlParameter("@MListID",MListID),
                                 new SqlParameter("@RepTypeID",RepTypeID),new SqlParameter("@NeedTypeID",NeedTypeID),
                                 new SqlParameter("@StockTypeID",StockTypeID),new SqlParameter("@PeiLiaoTypeID",PeiLiaoTypeID)};
            DataTable dt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            if (dt.Rows.Count == 0)
                return 0;
            else
            {
                decimal amount = Convert.ToDecimal(dt.Rows[0]["stockNotAmount"]);
                decimal repamount = 0;
                decimal needamount = 0;
                decimal stockamount = 0;
                decimal peiliaoamount = 0;
                try
                {
                    repamount = Convert.ToDecimal(dt.Rows[0]["RepAmount"]);
                }
                catch
                {
                }
                try
                {
                    needamount = Convert.ToDecimal(dt.Rows[0]["NeedAmount"]);
                }
                catch
                {
                }
                try
                {
                    stockamount = Convert.ToDecimal(dt.Rows[0]["StockAmount"]);
                }
                catch
                {
                }
                try
                {
                    peiliaoamount = Convert.ToDecimal(dt.Rows[0]["PeiLiaoAmount"]);
                }
                catch { }
                return amount - repamount - needamount - stockamount;
            }
        }
        /// <summary>
        /// 删除某一采购单的分订单明细，扣减物料拆分中已采购数量
        /// </summary>
        /// <param name="MainID"></param>
        public void DelStockByStockMainID(int MainID)
        {
            try
            {
                //更新物料拆分表的已采购数量
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE  MaterielDemand SET         HasStockAmount = MaterielDemand.HasStockAmount - PlanUseRep.Amount ");
                strSql.Append(" ,NeedAmount = MaterielDemand.NeedAmount + PlanUseRep.Amount");
                strSql.Append(" FROM      PlanUseRep INNER JOIN StockBackInfo ON PlanUseRep.StockInfoID = StockBackInfo.ID INNER JOIN ");
                strSql.Append(" MaterielDemand ON PlanUseRep.DemandID = MaterielDemand.ID WHERE   (StockBackInfo.MainID = @MainID)");
                SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                strSql.Remove(0, strSql.Length);
                //更新申购单
                strSql.Append("UPDATE  StockBackInfo SET  IsEnd = 0, NotAmount = StockBackInfo.NotAmount + StockBackInfo_1.Amount ");
                strSql.Append(" FROM      StockBackInfo AS StockBackInfo_1 INNER JOIN StockBackInfo ON StockBackInfo_1.StockInfoID = StockBackInfo.ID ");
                strSql.Append(" WHERE   (StockBackInfo_1.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                strSql.Remove(0, strSql.Length);
                //更新申购单PR表
                strSql.Append("UPDATE  PlanUseRep SET  Amount = PlanUseRep.Amount + PlanUseRep_1.Amount, ");
                strSql.Append(" NotAmount = PlanUseRep.NotAmount + PlanUseRep_1.Amount ");
                strSql.Append(" FROM      PlanUseRep AS PlanUseRep_1 INNER JOIN StockBackInfo ON PlanUseRep_1.StockInfoID = ");
                strSql.Append(" StockBackInfo.ID INNER JOIN PlanUseRep ON PlanUseRep_1.RelatedID = PlanUseRep.ID ");
                strSql.Append(" WHERE   (StockBackInfo.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                strSql.Remove(0, strSql.Length);
                //删除采购单PR表
                strSql.Append("DELETE FROM PlanUseRep FROM      PlanUseRep INNER JOIN StockBackInfo ON PlanUseRep.StockInfoID = StockBackInfo.ID ");
                strSql.Append(" WHERE   (StockBackInfo.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 删除某一申购单的分订单明细，扣减物料拆分中已采购数量
        /// </summary>
        /// <param name="MainID"></param>
        public void DelNeedByStockMainID(int MainID)
        {
            try
            {
                //更新物料拆分表的已申购数量
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE  MaterielDemand SET  ");
                strSql.Append(" NeedAmount = MaterielDemand.NeedAmount - PlanUseRep.Amount");
                strSql.Append(" FROM      PlanUseRep INNER JOIN StockBackInfo ON PlanUseRep.StockInfoID = StockBackInfo.ID INNER JOIN ");
                strSql.Append(" MaterielDemand ON PlanUseRep.DemandID = MaterielDemand.ID WHERE   (StockBackInfo.MainID = @MainID)");
                SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                strSql.Remove(0, strSql.Length);
                //删除采购单PR表
                strSql.Append("DELETE FROM PlanUseRep FROM      PlanUseRep INNER JOIN StockBackInfo ON PlanUseRep.StockInfoID = StockBackInfo.ID ");
                strSql.Append(" WHERE   (StockBackInfo.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
            }
            catch (Exception ex)
            {
            }
        }
        /// <summary>
        /// 弃审采购收货，更新系列表。
        /// </summary>
        /// <param name="MainID"></param>
        public void DelStockBackByMainID(int MainID)
        {
            try
            {
                //更新物料拆分表的已采购数量和已备料数量
                StringBuilder strSql = new StringBuilder();
                strSql.Append("UPDATE  MaterielDemand SET         RepertoryAmount = MaterielDemand.RepertoryAmount - PlanUseRep.Amount ");
                strSql.Append(" ,HasStockAmount = MaterielDemand.HasStockAmount + PlanUseRep.Amount");
                strSql.Append(" FROM      PlanUseRep INNER JOIN StockBackInfo ON PlanUseRep.StockInfoID = StockBackInfo.ID INNER JOIN ");
                strSql.Append(" MaterielDemand ON PlanUseRep.DemandID = MaterielDemand.ID WHERE   (StockBackInfo.MainID = @MainID)");
                SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                strSql.Remove(0, strSql.Length);
                //更新采购购单
                //strSql.Append("UPDATE  StockBackInfo SET  IsEnd = 0, NotAmount = StockBackInfo.NotAmount + StockBackInfo_1.Amount ");
                //strSql.Append(" FROM      StockBackInfo AS StockBackInfo_1 INNER JOIN StockBackInfo ON StockBackInfo_1.StockInfoID = StockBackInfo.ID ");

                strSql.Append(" UPDATE  StockBackInfo SET    NotAmount = StockBackInfo.NotAmount + StockBackInfo_1.Amount, IsEnd = 0 ");
                strSql.Append(" FROM      StockBackInfo AS StockBackInfo_1 INNER JOIN StockBackInfo ON StockBackInfo_1.StockInfoID = StockBackInfo.ID");

                strSql.Append(" WHERE   (StockBackInfo_1.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                //更新库存数量
                strSql.Remove(0, strSql.Length);
                strSql.Append(" UPDATE  Repertory SET         Amount = Repertory.Amount - PlanUseRep.NotAmount FROM      StockBackInfo INNER JOIN ");
                strSql.Append(" PlanUseRep ON StockBackInfo.ID = PlanUseRep.StockInfoID INNER JOIN Repertory ON PlanUseRep.MListID = ");
                strSql.Append(" Repertory.MListID AND PlanUseRep.TaskID = Repertory.PlanID INNER JOIN StockBack ON StockBackInfo.MainID ");
                strSql.Append(" = StockBack.ID AND Repertory.DepartmentID = StockBack.DepotID WHERE   (StockBackInfo.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                strSql.Remove(0, strSql.Length);
                //更新采购单PR表
                strSql.Append("UPDATE  PlanUseRep SET         NotAmount = PlanUseRep.NotAmount + PlanUseRep_1.Amount ");
                strSql.Append(" FROM      PlanUseRep AS PlanUseRep_1 INNER JOIN StockBackInfo ON PlanUseRep_1.StockInfoID = ");
                strSql.Append(" StockBackInfo.ID INNER JOIN PlanUseRep ON PlanUseRep_1.RelatedID = PlanUseRep.ID ");
                strSql.Append(" WHERE   (StockBackInfo.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
                strSql.Remove(0, strSql.Length);
                //删除采购收货单PR表
                strSql.Append("DELETE FROM PlanUseRep FROM      PlanUseRep INNER JOIN StockBackInfo ON PlanUseRep.StockInfoID = StockBackInfo.ID ");
                strSql.Append(" WHERE   (StockBackInfo.MainID = @MainID)");
                DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
            }
            catch (Exception ex)
            {
            }
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
			parameters[0].Value = "PlanUseRep";
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

