using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类RepertoryList。
	/// </summary>
	public class RepertoryList
	{
		public RepertoryList()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "RepertoryList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from RepertoryList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.RepertoryList model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into RepertoryList(");
            strSql.Append("Amount,MainID,Remark,NotAmount,StockListID,BatchNumber,IsEnd,SpecID,SpecName,DepotInfoID,DepotInfoName,DateTime,PlanID,QRID)");
            strSql.Append(" values (");
            strSql.Append("@Amount,@MainID,@Remark,@NotAmount,@StockListID,@BatchNumber,@IsEnd,@SpecID,@SpecName,@DepotInfoID,@DepotInfoName,@DateTime,@PlanID,@QRID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@StockListID", SqlDbType.Int,4),
					new SqlParameter("@BatchNumber", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@DepotInfoName", SqlDbType.NVarChar,50),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@PlanID", SqlDbType.Int,4),
                    new SqlParameter("@QRID",SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Amount;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.NotAmount;
            parameters[4].Value = model.StockListID;
            parameters[5].Value = model.BatchNumber;
            parameters[6].Value = model.IsEnd;
            parameters[7].Value = model.SpecID;
            parameters[8].Value = model.SpecName;
            parameters[9].Value = model.DepotInfoID;
            parameters[10].Value = model.DepotInfoName;
            parameters[11].Value = model.DateTime;
            parameters[12].Value = model.PlanID;
            parameters[13].Value = model.QRID;

            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                if(model.QRID=="0")
                {
                    model.ID = Convert.ToInt32(obj);
                    model.QRID = (model.ID * -1).ToString();
                    Update(model);
                }
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hownet.Model.RepertoryList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RepertoryList set ");
            strSql.Append("Amount=@Amount,");
            strSql.Append("MainID=@MainID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("NotAmount=@NotAmount,");
            strSql.Append("StockListID=@StockListID,");
            strSql.Append("BatchNumber=@BatchNumber,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("SpecID=@SpecID,");
            strSql.Append("SpecName=@SpecName,");
            strSql.Append("DepotInfoID=@DepotInfoID,");
            strSql.Append("DepotInfoName=@DepotInfoName,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("PlanID=@PlanID, ");
            strSql.Append("QRID=@QRID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@StockListID", SqlDbType.Int,4),
					new SqlParameter("@BatchNumber", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.Bit,1),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@SpecName", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@DepotInfoName", SqlDbType.NVarChar,50),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@PlanID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4),
                    new SqlParameter("@QRID",SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Amount;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.NotAmount;
            parameters[4].Value = model.StockListID;
            parameters[5].Value = model.BatchNumber;
            parameters[6].Value = model.IsEnd;
            parameters[7].Value = model.SpecID;
            parameters[8].Value = model.SpecName;
            parameters[9].Value = model.DepotInfoID;
            parameters[10].Value = model.DepotInfoName;
            parameters[11].Value = model.DateTime;
            parameters[12].Value = model.PlanID;
            parameters[13].Value = model.ID;
            parameters[14].Value = model.QRID;

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
            strSql.Append("delete from RepertoryList ");
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
            strSql.Append("delete from RepertoryList ");
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
        public Hownet.Model.RepertoryList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Amount,MainID,Remark,NotAmount,StockListID,BatchNumber,IsEnd,SpecID,SpecName,DepotInfoID,DepotInfoName,DateTime,PlanID,QRID  from RepertoryList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.RepertoryList model = new Hownet.Model.RepertoryList();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["NotAmount"] != null && ds.Tables[0].Rows[0]["NotAmount"].ToString() != "")
                {
                    model.NotAmount = decimal.Parse(ds.Tables[0].Rows[0]["NotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StockListID"] != null && ds.Tables[0].Rows[0]["StockListID"].ToString() != "")
                {
                    model.StockListID = int.Parse(ds.Tables[0].Rows[0]["StockListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BatchNumber"] != null && ds.Tables[0].Rows[0]["BatchNumber"].ToString() != "")
                {
                    model.BatchNumber = int.Parse(ds.Tables[0].Rows[0]["BatchNumber"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"] != null && ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsEnd"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsEnd"].ToString().ToLower() == "true"))
                    {
                        model.IsEnd = true;
                    }
                    else
                    {
                        model.IsEnd = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["SpecID"] != null && ds.Tables[0].Rows[0]["SpecID"].ToString() != "")
                {
                    model.SpecID = int.Parse(ds.Tables[0].Rows[0]["SpecID"].ToString());
                }
                model.SpecName = ds.Tables[0].Rows[0]["SpecName"].ToString();
                if (ds.Tables[0].Rows[0]["DepotInfoID"] != null && ds.Tables[0].Rows[0]["DepotInfoID"].ToString() != "")
                {
                    model.DepotInfoID = int.Parse(ds.Tables[0].Rows[0]["DepotInfoID"].ToString());
                }
                model.DepotInfoName = ds.Tables[0].Rows[0]["DepotInfoName"].ToString();
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PlanID"] != null && ds.Tables[0].Rows[0]["PlanID"].ToString() != "")
                {
                    model.PlanID = int.Parse(ds.Tables[0].Rows[0]["PlanID"].ToString());
                }
                model.QRID = ds.Tables[0].Rows[0]["QRID"].ToString();
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
            strSql.Append("select  1 as A,ID,Amount,MainID,Remark,NotAmount,StockListID,BatchNumber,IsEnd,SpecID,SpecName,DepotInfoID,DepotInfoName,DateTime,PlanID,QRID ");
            strSql.Append(" FROM RepertoryList ");
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
            strSql.Append(" ID,Amount,MainID,Remark,NotAmount,StockListID,BatchNumber,IsEnd,SpecID,SpecName,DepotInfoID,DepotInfoName,DateTime,PlanID,QRID ");
            strSql.Append(" FROM RepertoryList ");
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
        public bool DeleteByStockInfoID(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from RepertoryList ");
            strSql.Append(" where StockListID=@ID");
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
        public void UpPlanID(int ID, int PlanID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update RepertoryList set PlanID=@PlanID Where (ID=@ID)");
            SqlParameter[] sps = { new SqlParameter("@PlanID", PlanID), new SqlParameter("@ID", ID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 根据款号和商标，返回库存数量
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <param name="BrandID"></param>
        /// <param name="DepotID"></param>
        /// <returns></returns>
        public DataSet GetListByMB(int MaterielID,int BrandID,int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT     1 AS A, RepertoryList.ID AS RepertoryListID, RepertoryList.Amount AS RLAmount, RepertoryList.DepotInfoID, Repertory.ID AS RepertoryID, ");
            strSql.Append(" Repertory.MListID, Repertory.MeasureID, Repertory.MaterielID, Repertory.SizeID, Repertory.ColorID, Repertory.ColorOneID, Repertory.ColorTwoID, ");
            strSql.Append(" Repertory.BrandID, Repertory.Amount AS RepertoryAmount FROM         Size RIGHT OUTER  JOIN Repertory ON Size.ID = Repertory.SizeID LEFT OUTER JOIN ");
            strSql.Append(" RepertoryList ON Repertory.MListID = RepertoryList.BatchNumber AND Repertory.ID = RepertoryList.MainID WHERE     (Repertory.MaterielID = @MaterielID) ");
            strSql.Append(" AND (Repertory.BrandID = @BrandID) AND (Repertory.DepartmentID = @DepotID) ORDER BY Repertory.ColorID, Size.Orders");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@BrandID", BrandID), new SqlParameter("@DepotID", DepotID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }
     //   public DataSet GetListForInventory(int )
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
			parameters[0].Value = "RepertoryList";
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

