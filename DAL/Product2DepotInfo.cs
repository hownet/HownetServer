using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Product2DepotInfo。
	/// </summary>
	public class Product2DepotInfo
	{
		public Product2DepotInfo()
		{}
		#region  成员方法



        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Product2DepotInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Product2DepotInfo(");
            strSql.Append("MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MListID,Remark,TaskID,DeparmentID,Amount,Price,Money,Weight,DepotInfoID)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@MaterielID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@BrandID,@MListID,@Remark,@TaskID,@DeparmentID,@Amount,@Price,@Money,@Weight,@DepotInfoID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorOneID;
            parameters[4].Value = model.ColorTwoID;
            parameters[5].Value = model.SizeID;
            parameters[6].Value = model.BrandID;
            parameters[7].Value = model.MListID;
            parameters[8].Value = model.Remark;
            parameters[9].Value = model.TaskID;
            parameters[10].Value = model.DeparmentID;
            parameters[11].Value = model.Amount;
            parameters[12].Value = model.Price;
            parameters[13].Value = model.Money;
            parameters[14].Value = model.Weight;
            parameters[15].Value = model.DepotInfoID;

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
        public bool Update(Hownet.Model.Product2DepotInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Product2DepotInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("DeparmentID=@DeparmentID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("Price=@Price,");
            strSql.Append("Money=@Money,");
            strSql.Append("Weight=@Weight,");
            strSql.Append("DepotInfoID=@DepotInfoID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorOneID;
            parameters[4].Value = model.ColorTwoID;
            parameters[5].Value = model.SizeID;
            parameters[6].Value = model.BrandID;
            parameters[7].Value = model.MListID;
            parameters[8].Value = model.Remark;
            parameters[9].Value = model.TaskID;
            parameters[10].Value = model.DeparmentID;
            parameters[11].Value = model.Amount;
            parameters[12].Value = model.Price;
            parameters[13].Value = model.Money;
            parameters[14].Value = model.Weight;
            parameters[15].Value = model.DepotInfoID;
            parameters[16].Value = model.ID;

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
            strSql.Append("delete from Product2DepotInfo ");
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
            strSql.Append("delete from Product2DepotInfo ");
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
        public Hownet.Model.Product2DepotInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MListID,Remark,TaskID,DeparmentID,Amount,Price,Money,Weight,DepotInfoID from Product2DepotInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.Product2DepotInfo model = new Hownet.Model.Product2DepotInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
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
                if (ds.Tables[0].Rows[0]["SizeID"] != null && ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"] != null && ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["TaskID"] != null && ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DeparmentID"] != null && ds.Tables[0].Rows[0]["DeparmentID"].ToString() != "")
                {
                    model.DeparmentID = int.Parse(ds.Tables[0].Rows[0]["DeparmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"] != null && ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = int.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Weight"] != null && ds.Tables[0].Rows[0]["Weight"].ToString() != "")
                {
                    model.Weight = decimal.Parse(ds.Tables[0].Rows[0]["Weight"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotInfoID"] != null && ds.Tables[0].Rows[0]["DepotInfoID"].ToString() != "")
                {
                    model.DepotInfoID = int.Parse(ds.Tables[0].Rows[0]["DepotInfoID"].ToString());
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
            strSql.Append("select  1 as A,ID,MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MListID,Remark,TaskID,DeparmentID,Amount,Price,Money,Weight,DepotInfoID ");
            strSql.Append(" FROM Product2DepotInfo ");
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
            strSql.Append(" ID,MainID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MListID,Remark,TaskID,DeparmentID,Amount,Price,Money,Weight,DepotInfoID ");
            strSql.Append(" FROM Product2DepotInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除一组数据
        /// </summary>
        public void DeleteByMainID(int MainID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Product2DepotInfo ");
            strSql.Append(" where MainID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
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
			parameters[0].Value = "Product2DepotInfo";
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

