using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类StockBackInfoList。
	/// </summary>
	public class StockBackInfoList
	{
		public StockBackInfoList()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "StockBackInfoList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from StockBackInfoList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.StockBackInfoList model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into StockBackInfoList(");
            strSql.Append("InfoID,Amount,Remark,IsOK,BatchNumber,NotAmount,SpecID,QRID,DepotInfoID,MainID,NowAmount,RListID)");
            strSql.Append(" values (");
            strSql.Append("@InfoID,@Amount,@Remark,@IsOK,@BatchNumber,@NotAmount,@SpecID,@QRID,@DepotInfoID,@MainID,@NowAmount,@RListID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@IsOK", SqlDbType.Bit,1),
					new SqlParameter("@BatchNumber", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@QRID", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@NowAmount", SqlDbType.Decimal,9),
					new SqlParameter("@RListID", SqlDbType.Int,4)};
            parameters[0].Value = model.InfoID;
            parameters[1].Value = model.Amount;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.IsOK;
            parameters[4].Value = model.BatchNumber;
            parameters[5].Value = model.NotAmount;
            parameters[6].Value = model.SpecID;
            parameters[7].Value = model.QRID;
            parameters[8].Value = model.DepotInfoID;
            parameters[9].Value = model.MainID;
            parameters[10].Value = model.NowAmount;
            parameters[11].Value = model.RListID;

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
        public bool Update(Hownet.Model.StockBackInfoList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update StockBackInfoList set ");
            strSql.Append("InfoID=@InfoID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsOK=@IsOK,");
            strSql.Append("BatchNumber=@BatchNumber,");
            strSql.Append("NotAmount=@NotAmount,");
            strSql.Append("SpecID=@SpecID,");
            strSql.Append("QRID=@QRID,");
            strSql.Append("DepotInfoID=@DepotInfoID,");
            strSql.Append("MainID=@MainID,");
            strSql.Append("NowAmount=@NowAmount,");
            strSql.Append("RListID=@RListID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@InfoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@IsOK", SqlDbType.Bit,1),
					new SqlParameter("@BatchNumber", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@QRID", SqlDbType.NVarChar,50),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@NowAmount", SqlDbType.Decimal,9),
					new SqlParameter("@RListID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.InfoID;
            parameters[1].Value = model.Amount;
            parameters[2].Value = model.Remark;
            parameters[3].Value = model.IsOK;
            parameters[4].Value = model.BatchNumber;
            parameters[5].Value = model.NotAmount;
            parameters[6].Value = model.SpecID;
            parameters[7].Value = model.QRID;
            parameters[8].Value = model.DepotInfoID;
            parameters[9].Value = model.MainID;
            parameters[10].Value = model.NowAmount;
            parameters[11].Value = model.RListID;
            parameters[12].Value = model.ID;

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
            strSql.Append("delete from StockBackInfoList ");
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
            strSql.Append("delete from StockBackInfoList ");
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
        public Hownet.Model.StockBackInfoList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,InfoID,Amount,Remark,IsOK,BatchNumber,NotAmount,SpecID,QRID,DepotInfoID,MainID,NowAmount,RListID from StockBackInfoList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.StockBackInfoList model = new Hownet.Model.StockBackInfoList();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["InfoID"] != null && ds.Tables[0].Rows[0]["InfoID"].ToString() != "")
                {
                    model.InfoID = int.Parse(ds.Tables[0].Rows[0]["InfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["IsOK"] != null && ds.Tables[0].Rows[0]["IsOK"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsOK"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsOK"].ToString().ToLower() == "true"))
                    {
                        model.IsOK = true;
                    }
                    else
                    {
                        model.IsOK = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["BatchNumber"] != null && ds.Tables[0].Rows[0]["BatchNumber"].ToString() != "")
                {
                    model.BatchNumber = int.Parse(ds.Tables[0].Rows[0]["BatchNumber"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotAmount"] != null && ds.Tables[0].Rows[0]["NotAmount"].ToString() != "")
                {
                    model.NotAmount = decimal.Parse(ds.Tables[0].Rows[0]["NotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SpecID"] != null && ds.Tables[0].Rows[0]["SpecID"].ToString() != "")
                {
                    model.SpecID = int.Parse(ds.Tables[0].Rows[0]["SpecID"].ToString());
                }
                model.QRID = ds.Tables[0].Rows[0]["QRID"].ToString();
                if (ds.Tables[0].Rows[0]["DepotInfoID"] != null && ds.Tables[0].Rows[0]["DepotInfoID"].ToString() != "")
                {
                    model.DepotInfoID = int.Parse(ds.Tables[0].Rows[0]["DepotInfoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowAmount"] != null && ds.Tables[0].Rows[0]["NowAmount"].ToString() != "")
                {
                    model.NowAmount = decimal.Parse(ds.Tables[0].Rows[0]["NowAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["RListID"] != null && ds.Tables[0].Rows[0]["RListID"].ToString() != "")
                {
                    model.RListID = int.Parse(ds.Tables[0].Rows[0]["RListID"].ToString());
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
            strSql.Append("select  1 as A,ID,InfoID,Amount,Remark,IsOK,BatchNumber,NotAmount,SpecID,QRID,DepotInfoID,MainID,NowAmount,RListID ");
            strSql.Append(" FROM StockBackInfoList ");
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
            strSql.Append(" ID,InfoID,Amount,Remark,IsOK,BatchNumber,NotAmount,SpecID,QRID,DepotInfoID,MainID,NowAmount,RListID ");
            strSql.Append(" FROM StockBackInfoList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }



        public bool DeleteByInfoID(int InfoID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from StockBackInfoList ");
            strSql.Append(" where InfoID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
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

        public bool DeleteByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from StockBackInfoList ");
            strSql.Append(" where MainID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
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
			parameters[0].Value = "StockBackInfoList";
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

