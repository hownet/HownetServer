using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类ProductWorkingMain。
	/// </summary>
	public class ProductWorkingMain
	{
		public ProductWorkingMain()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ProductWorkingMain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProductWorkingMain");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.ProductWorkingMain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into ProductWorkingMain(");
			strSql.Append("MaterielID,CompanyID,TaskID,DateTime,Ver,FillDate,FillMan,VerifyDate,VerifyMan,IsDefault,IsEnd,IsUse,Remark)");
			strSql.Append(" values (");
			strSql.Append("@MaterielID,@CompanyID,@TaskID,@DateTime,@Ver,@FillDate,@FillMan,@VerifyDate,@VerifyMan,@IsDefault,@IsEnd,@IsUse,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Ver", SqlDbType.NVarChar,100),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@IsDefault", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.MaterielID;
			parameters[1].Value = model.CompanyID;
			parameters[2].Value = model.TaskID;
			parameters[3].Value = model.DateTime;
			parameters[4].Value = model.Ver;
			parameters[5].Value = model.FillDate;
			parameters[6].Value = model.FillMan;
			parameters[7].Value = model.VerifyDate;
			parameters[8].Value = model.VerifyMan;
			parameters[9].Value = model.IsDefault;
			parameters[10].Value = model.IsEnd;
			parameters[11].Value = model.IsUse;
			parameters[12].Value = model.Remark;

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
		public void Update(Hownet.Model.ProductWorkingMain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update ProductWorkingMain set ");
			strSql.Append("MaterielID=@MaterielID,");
			strSql.Append("CompanyID=@CompanyID,");
			strSql.Append("TaskID=@TaskID,");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("Ver=@Ver,");
			strSql.Append("FillDate=@FillDate,");
			strSql.Append("FillMan=@FillMan,");
			strSql.Append("VerifyDate=@VerifyDate,");
			strSql.Append("VerifyMan=@VerifyMan,");
			strSql.Append("IsDefault=@IsDefault,");
			strSql.Append("IsEnd=@IsEnd,");
			strSql.Append("IsUse=@IsUse,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Ver", SqlDbType.NVarChar,100),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@IsDefault", SqlDbType.Bit,1),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MaterielID;
			parameters[2].Value = model.CompanyID;
			parameters[3].Value = model.TaskID;
			parameters[4].Value = model.DateTime;
			parameters[5].Value = model.Ver;
			parameters[6].Value = model.FillDate;
			parameters[7].Value = model.FillMan;
			parameters[8].Value = model.VerifyDate;
			parameters[9].Value = model.VerifyMan;
			parameters[10].Value = model.IsDefault;
			parameters[11].Value = model.IsEnd;
			parameters[12].Value = model.IsUse;
			parameters[13].Value = model.Remark;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from ProductWorkingMain ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.ProductWorkingMain GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,MaterielID,CompanyID,TaskID,DateTime,Ver,FillDate,FillMan,VerifyDate,VerifyMan,IsDefault,IsEnd,IsUse,Remark from ProductWorkingMain ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.ProductWorkingMain model=new Hownet.Model.ProductWorkingMain();
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
				if(ds.Tables[0].Rows[0]["CompanyID"].ToString()!="")
				{
					model.CompanyID=int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TaskID"].ToString()!="")
				{
					model.TaskID=int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
				}
				model.Ver=ds.Tables[0].Rows[0]["Ver"].ToString();
				if(ds.Tables[0].Rows[0]["FillDate"].ToString()!="")
				{
					model.FillDate=DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FillMan"].ToString()!="")
				{
					model.FillMan=int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
				}
				if(ds.Tables[0].Rows[0]["VerifyDate"].ToString()!="")
				{
					model.VerifyDate=DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["VerifyMan"].ToString()!="")
				{
					model.VerifyMan=int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsDefault"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsDefault"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsDefault"].ToString().ToLower()=="true"))
					{
						model.IsDefault=true;
					}
					else
					{
						model.IsDefault=false;
					}
				}
				if(ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					model.IsEnd=int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsUse"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsUse"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsUse"].ToString().ToLower()=="true"))
					{
						model.IsUse=true;
					}
					else
					{
						model.IsUse=false;
					}
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				model.A=1;
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
			strSql.Append("select 1 as A,ID,MaterielID,CompanyID,TaskID,DateTime,Ver,FillDate,FillMan,VerifyDate,VerifyMan,IsDefault,IsEnd,IsUse,Remark ");
			strSql.Append(" FROM ProductWorkingMain ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,MaterielID,CompanyID,TaskID,DateTime,Ver,FillDate,FillMan,VerifyDate,VerifyMan,IsDefault,IsEnd,IsUse,Remark ");
			strSql.Append(" FROM ProductWorkingMain ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        /// <summary>
        /// 多表下返回某款号的主工艺要求ID列表
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet GetIDList(int MaterielID,int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ID FROM ProductWorkingMain WHERE (MaterielID = @MaterielID) And (TaskID=@TaskID) order by ID");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID),new SqlParameter("@TaskID",TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 更新某款号的工艺单IsDefault为假
        /// </summary>
        /// <param name="MaterielID"></param>
        public void UpDefault(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" UPDATE ProductWorkingMain SET IsDefault = 0 WHERE (MaterielID = @MaterielID)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回某款号的默认工艺单编号
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public int GetIsDefaultID(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID FROM ProductWorkingMain WHERE (MaterielID = @MaterielID) AND (IsDefault = 1)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
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
        public DataSet GetViewList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,MaterielID,Remark ");
            strSql.Append(" FROM ProductWorkingMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetInfoList(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   GroupBy, IsTicket, Price, Orders,CustOder, (SELECT   Name FROM      Working WHERE   (ID = ProductWorkingInfo.WorkingID)) AS WorkName ");
            strSql.Append(" FROM      ProductWorkingInfo WHERE   (MainID = @MainID) And (MainID>0)");
            SqlParameter[] sps = { new SqlParameter("@MainID",MainID)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSetPrice(int WorkingID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ProductWorkingMain.MaterielID, ProductWorkingMain.Remark, ProductWorkingInfo.Price, ProductWorkingInfo.ID ");
            strSql.Append(" , CAST(0 AS bit) AS IsSelect");
            strSql.Append(" FROM      ProductWorkingInfo INNER JOIN ProductWorkingMain ON ProductWorkingInfo.MainID = ProductWorkingMain.ID ");
            strSql.Append(" WHERE   (ProductWorkingInfo.WorkingID = @WorkingID) AND (ProductWorkingMain.MaterielID > 0) ORDER BY ProductWorkingMain.MaterielID");
            SqlParameter[] sps = {new SqlParameter("@WorkingID",WorkingID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetWorkPriceList(int MaterielID, int WorkingID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(DISTINCT PayMain.EndDate) AS 截止日期, PaySum.Price AS 工价 FROM      PaySum INNER JOIN PayMain ON PaySum.PayMainID = PayMain.ID ");
            strSql.Append(" GROUP BY PaySum.MaterielID, PaySum.WorkingID, PaySum.Price HAVING   (PaySum.MaterielID = @MaterielID) AND (PaySum.WorkingID = @WorkingID) ORDER BY 截止日期");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@WorkingID", WorkingID) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        public decimal GetWorkingMoney(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            if (MaterielID < 0)
                MaterielID = MaterielID * -1;
            strSql.Append(" SELECT   SUM(ProductWorkingInfo.Price) AS Expr1 FROM      ProductWorkingInfo INNER JOIN ProductWorkingMain ON ProductWorkingInfo.MainID = ProductWorkingMain.ID ");
            strSql.Append(" WHERE   (ProductWorkingMain.IsDefault = 1) AND (ProductWorkingMain.MaterielID = @MaterielID)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID)};
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
            {
                return Convert.ToDecimal(o);
            }
            else
            {
                return 0;
            }
        }
        public DataSet GetSetNoPrice()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT     ProductWorkingMain.MaterielID, ProductWorkingMain.Remark, ProductWorkingMain.FillDate, ProductWorkingInfo.Orders, ");
            strSql.Append(" ProductWorkingInfo.WorkingID, ProductWorkingInfo.Price, ProductWorkingInfo.ID, 1 AS A ");
            strSql.Append(" FROM         ProductWorkingInfo INNER JOIN ProductWorkingMain ON ProductWorkingInfo.MainID = ProductWorkingMain.ID ");
            strSql.Append(" WHERE     (ProductWorkingMain.TaskID = 0) AND (ProductWorkingInfo.Price = 0) AND (ProductWorkingInfo.IsTicket = 1) AND ");
            strSql.Append(" (ProductWorkingInfo.IsCaiC = 1) ORDER BY ProductWorkingInfo.MainID");
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
			parameters[0].Value = "ProductWorkingMain";
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

