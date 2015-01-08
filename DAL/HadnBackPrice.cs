using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类HadnBackPrice。
	/// </summary>
	public class HadnBackPrice
	{
		public HadnBackPrice()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "HadnBackPrice"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HadnBackPrice");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.HadnBackPrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HadnBackPrice(");
			strSql.Append("MaterielID,WorkingID,Price,DateTime,IsUse)");
			strSql.Append(" values (");
			strSql.Append("@MaterielID,@WorkingID,@Price,@DateTime,@IsUse)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@IsUse", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.MaterielID;
			parameters[1].Value = model.WorkingID;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.DateTime;
			parameters[4].Value = model.IsUse;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public void Update(Hownet.Model.HadnBackPrice model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HadnBackPrice set ");
			strSql.Append("MaterielID=@MaterielID,");
			strSql.Append("WorkingID=@WorkingID,");
			strSql.Append("Price=@Price,");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("IsUse=@IsUse");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@IsUse", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MaterielID;
			parameters[2].Value = model.WorkingID;
			parameters[3].Value = model.Price;
			parameters[4].Value = model.DateTime;
			parameters[5].Value = model.IsUse;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete HadnBackPrice ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.HadnBackPrice GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MaterielID,WorkingID,Price,DateTime,IsUse from HadnBackPrice ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.HadnBackPrice model=new Hownet.Model.HadnBackPrice();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["MaterielID"].ToString()!="")
				{
					model.MaterielID=int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WorkingID"].ToString()!="")
				{
					model.WorkingID=int.Parse(ds.Tables[0].Rows[0]["WorkingID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Price"].ToString()!="")
				{
					model.Price=decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsUse"].ToString()!="")
				{
					model.IsUse=int.Parse(ds.Tables[0].Rows[0]["IsUse"].ToString());
				}
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,MaterielID,WorkingID,Price,DateTime,IsUse,1 as A ");
			strSql.Append(" FROM HadnBackPrice ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
            strSql.Append(" order by isuse");
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 返回成品款号
        /// </summary>
        /// <returns></returns>
        public DataSet GetMateriel()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select MaterielID,MaterielName from materiel where (attributeid=1) order by materielname");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 判断某工价是否已汇总
        /// </summary>
        /// <param name="priceID"></param>
        /// <returns></returns>
        public bool CheckPriceUsed(int priceID)
        {
            bool t = true;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(HandBackMain.MainID) AS Expr1 FROM HandBackMain INNER JOIN ");
            strSql.Append(" HandBackInfo ON HandBackMain.MainID = HandBackInfo.MainID ");
            strSql.Append(" WHERE (HandBackInfo.PriceID = @PriceID) AND (HandBackMain.IsEnd = 1)");
            SqlParameter[] sps = { new SqlParameter("@PriceID", priceID) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sps).Equals(0))
            {
                t = false;
            }
            return t;
        }
        /// <summary>
        /// 返回某工序在其它款号中的现在工价
        /// </summary>
        /// <param name="WorkID"></param>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetOtherPrice(int WorkID, int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT Price, DateTime, (SELECT MaterielName FROM Materiel WHERE (MaterielID = ");
            strSql.Append(" HadnBackPrice.MaterielID)) AS MaterielName FROM HadnBackPrice WHERE (WorkingID ");
            strSql.Append(" = @WorkID) AND (IsUse = 1) AND (MaterielID <> @MaterielID)");
            SqlParameter[] sps = { new SqlParameter("@WorkID", WorkID), new SqlParameter("@MaterielID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 判断某工序是否已使用
        /// </summary>
        /// <param name="priceID"></param>
        /// <returns></returns>
        public bool CheckUse(int priceID)
        {
            bool t = false;
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(InfoID) AS Expr1 FROM HandBackInfo WHERE (PriceID = @ID)");
            SqlParameter[] sps = {new SqlParameter("@ID",priceID) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sps).Equals(0))
            {
                t = false;
            }
            return t;
        }
        public void UpBackPrice(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE HandBackInfo SET Price = HadnBackPrice.Price,  Money = HandBackInfo.Amount * HadnBackPrice.Price ");
            strSql.Append(" FROM HandBackMain INNER JOIN HandBackInfo ON HandBackMain.MainID = HandBackInfo.MainID INNER JOIN ");
            strSql.Append(" HadnBackPrice ON HandBackInfo.PriceID = HadnBackPrice.ID WHERE (HandBackMain.IsEnd = 0) AND (HandBackInfo.PriceID = @PriceID)");
            SqlParameter[] sps = { new SqlParameter("@PriceID", ID) };
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
			parameters[0].Value = "HadnBackPrice";
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

