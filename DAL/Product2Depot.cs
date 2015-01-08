using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Product2Depot。
	/// </summary>
	public class Product2Depot
	{
		public Product2Depot()
		{}
		#region  成员方法



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Product2Depot model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Product2Depot(");
            strSql.Append("DateTime,Num,DepotID,Remark,IsVerify,VerifyMan,VerifyDate,UpData,TypeID,DeparmentID,DeparmentTypeID,Weight)");
            strSql.Append(" values (");
            strSql.Append("@DateTime,@Num,@DepotID,@Remark,@IsVerify,@VerifyMan,@VerifyDate,@UpData,@TypeID,@DeparmentID,@DeparmentTypeID,@Weight)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DepotID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentTypeID", SqlDbType.Int,4),
					new SqlParameter("@Weight", SqlDbType.Decimal,9)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.DepotID;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.IsVerify;
            parameters[5].Value = model.VerifyMan;
            parameters[6].Value = model.VerifyDate;
            parameters[7].Value = model.UpData;
            parameters[8].Value = model.TypeID;
            parameters[9].Value = model.DeparmentID;
            parameters[10].Value = model.DeparmentTypeID;
            parameters[11].Value = model.Weight;

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
        public bool Update(Hownet.Model.Product2Depot model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Product2Depot set ");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("Num=@Num,");
            strSql.Append("DepotID=@DepotID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("DeparmentID=@DeparmentID,");
            strSql.Append("DeparmentTypeID=@DeparmentTypeID,");
            strSql.Append("Weight=@Weight");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@DepotID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentTypeID", SqlDbType.Int,4),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.DepotID;
            parameters[3].Value = model.Remark;
            parameters[4].Value = model.IsVerify;
            parameters[5].Value = model.VerifyMan;
            parameters[6].Value = model.VerifyDate;
            parameters[7].Value = model.UpData;
            parameters[8].Value = model.TypeID;
            parameters[9].Value = model.DeparmentID;
            parameters[10].Value = model.DeparmentTypeID;
            parameters[11].Value = model.Weight;
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
            strSql.Append("delete from Product2Depot ");
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
            strSql.Append("delete from Product2Depot ");
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
        public Hownet.Model.Product2Depot GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DateTime,Num,DepotID,Remark,IsVerify,VerifyMan,VerifyDate,UpData,TypeID,DeparmentID,DeparmentTypeID,Weight from Product2Depot ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.Product2Depot model = new Hownet.Model.Product2Depot();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"] != null && ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotID"] != null && ds.Tables[0].Rows[0]["DepotID"].ToString() != "")
                {
                    model.DepotID = int.Parse(ds.Tables[0].Rows[0]["DepotID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["IsVerify"] != null && ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"] != null && ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"] != null && ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"] != null && ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DeparmentID"] != null && ds.Tables[0].Rows[0]["DeparmentID"].ToString() != "")
                {
                    model.DeparmentID = int.Parse(ds.Tables[0].Rows[0]["DeparmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DeparmentTypeID"] != null && ds.Tables[0].Rows[0]["DeparmentTypeID"].ToString() != "")
                {
                    model.DeparmentTypeID = int.Parse(ds.Tables[0].Rows[0]["DeparmentTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Weight"] != null && ds.Tables[0].Rows[0]["Weight"].ToString() != "")
                {
                    model.Weight = decimal.Parse(ds.Tables[0].Rows[0]["Weight"].ToString());
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
            strSql.Append("select  1 as A,ID,DateTime,Num,DepotID,Remark,IsVerify,VerifyMan,VerifyDate,UpData,TypeID,DeparmentID,DeparmentTypeID,Weight ");
            strSql.Append(" FROM Product2Depot ");
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
            strSql.Append(" ID,DateTime,Num,DepotID,Remark,IsVerify,VerifyMan,VerifyDate,UpData,TypeID,DeparmentID,DeparmentTypeID,Weight ");
            strSql.Append(" FROM Product2Depot ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetIDList(int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from Product2Depot Where (TypeID="+TypeID+") order by ID ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int NewNum(DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(Num) AS Expr1 FROM      Product2Depot WHERE   (DateTime = @dt)");
            SqlParameter[] sps = { new SqlParameter("@dt", dt) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return int.Parse(o.ToString()) + 1;
        }
        public DataSet GetSumAmount(DateTime dt, int DepotID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Deparment.Name, SUM(Product2DepotInfo.Amount) AS Amount FROM      Product2Depot INNER JOIN ");
            strSql.Append(" Product2DepotInfo ON Product2Depot.ID = Product2DepotInfo.MainID INNER JOIN Deparment ON ");
            strSql.Append(" Product2DepotInfo.DeparmentID = Deparment.ID WHERE   (Product2Depot.DateTime = @DateTime) AND ");
            strSql.Append(" (Product2DepotInfo.DeparmentID = @DeparmentID) GROUP BY Deparment.Name");
            SqlParameter[] sps = { new SqlParameter("@DateTime", dt), new SqlParameter("@DeparmentID", DepotID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetP2dListByComID(DateTime dt1, DateTime dt2, int DeparmentID,int DepTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Product2DepotInfo.MaterielID, Product2DepotInfo.ColorID, Product2DepotInfo.SizeID, Product2DepotInfo.Amount, ");
            strSql.Append(" Product2DepotInfo.Price, Product2DepotInfo.Money, Product2Depot.DateTime, Product2Depot.ID,Product2DepotInfo.BrandID, ");
            strSql.Append(" (CASE WHEN (Product2Depot.DeparmentTypeID = 3) ");
            strSql.Append(" THEN Product2Depot.DeparmentID * - 1 ELSE Product2Depot.DeparmentID END) AS DeparmentID FROM      Product2Depot INNER JOIN ");
            strSql.Append(" Product2DepotInfo ON Product2Depot.ID = Product2DepotInfo.MainID WHERE   (Product2Depot.DateTime > @dt1) ");
            strSql.Append(" AND (Product2Depot.DateTime < @dt2) ");
            if (DeparmentID > 0)
                strSql.Append(" AND (Product2Depot.DeparmentID = @DepID) AND (Product2Depot.DeparmentTypeID = @TypeID)");
            SqlParameter[] sps = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2), new SqlParameter("@DepID", DeparmentID), new SqlParameter("@TypeID", DepTypeID) };
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
			parameters[0].Value = "Product2Depot";
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

