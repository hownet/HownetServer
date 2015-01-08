using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类HandBackMain。
	/// </summary>
	public class HandBackMain
	{
		public HandBackMain()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("MainID", "HandBackMain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int MainID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from HandBackMain");
			strSql.Append(" where MainID=@MainID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
			parameters[0].Value = MainID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.HandBackMain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into HandBackMain(");
			strSql.Append("DateTime,Num,EmployeeID,Remark,IsVerify,VerifyManID,VerifyDateTime,IsEnd)");
			strSql.Append(" values (");
			strSql.Append("@DateTime,@Num,@EmployeeID,@Remark,@IsVerify,@VerifyManID,@VerifyDateTime,@IsEnd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyManID", SqlDbType.Int,4),
					new SqlParameter("@VerifyDateTime", SqlDbType.DateTime),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.DateTime;
			parameters[1].Value = model.Num;
			parameters[2].Value = model.EmployeeID;
			parameters[3].Value = model.Remark;
			parameters[4].Value = model.IsVerify;
			parameters[5].Value = model.VerifyManID;
			parameters[6].Value = model.VerifyDateTime;
			parameters[7].Value = model.IsEnd;

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
		public void Update(Hownet.Model.HandBackMain model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update HandBackMain set ");
			strSql.Append("DateTime=@DateTime,");
			strSql.Append("Num=@Num,");
			strSql.Append("EmployeeID=@EmployeeID,");
			strSql.Append("Remark=@Remark,");
			strSql.Append("IsVerify=@IsVerify,");
			strSql.Append("VerifyManID=@VerifyManID,");
			strSql.Append("VerifyDateTime=@VerifyDateTime,");
			strSql.Append("IsEnd=@IsEnd");
			strSql.Append(" where MainID=@MainID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyManID", SqlDbType.Int,4),
					new SqlParameter("@VerifyDateTime", SqlDbType.DateTime),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1)};
			parameters[0].Value = model.MainID;
			parameters[1].Value = model.DateTime;
			parameters[2].Value = model.Num;
			parameters[3].Value = model.EmployeeID;
			parameters[4].Value = model.Remark;
			parameters[5].Value = model.IsVerify;
			parameters[6].Value = model.VerifyManID;
			parameters[7].Value = model.VerifyDateTime;
			parameters[8].Value = model.IsEnd;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int MainID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete HandBackMain ");
			strSql.Append(" where MainID=@MainID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
			parameters[0].Value = MainID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.HandBackMain GetModel(int MainID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 MainID,DateTime,Num,EmployeeID,Remark,IsVerify,VerifyManID,VerifyDateTime,IsEnd from HandBackMain ");
			strSql.Append(" where MainID=@MainID ");
			SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4)};
			parameters[0].Value = MainID;

			Hownet.Model.HandBackMain model=new Hownet.Model.HandBackMain();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["MainID"].ToString()!="")
				{
					model.MainID=int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DateTime"].ToString()!="")
				{
					model.DateTime=DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Num"].ToString()!="")
				{
					model.Num=int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
				}
				if(ds.Tables[0].Rows[0]["EmployeeID"].ToString()!="")
				{
					model.EmployeeID=int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
				}
				model.Remark=ds.Tables[0].Rows[0]["Remark"].ToString();
				if(ds.Tables[0].Rows[0]["IsVerify"].ToString()!="")
				{
					model.IsVerify=int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
				}
				if(ds.Tables[0].Rows[0]["VerifyManID"].ToString()!="")
				{
					model.VerifyManID=int.Parse(ds.Tables[0].Rows[0]["VerifyManID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["VerifyDateTime"].ToString()!="")
				{
					model.VerifyDateTime=DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsEnd"].ToString()!="")
				{
					model.IsEnd=int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
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
			strSql.Append("select MainID,DateTime,Num,EmployeeID,Remark,IsVerify,VerifyManID,VerifyDateTime,IsEnd ");
			strSql.Append(" FROM HandBackMain ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select MainID from HandBackMain order by MainID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 查出所有工序
        /// </summary>
        /// <returns></returns>
        public DataSet GetWork()
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT ID, WorkingID, IsUse, (SELECT WorkingName FROM Working ");
            //strSql.Append(" WHERE (WorkingID = HadnBackPrice.WorkingID)) AS WorkingName, MaterielID, ");
            //strSql.Append(" Price FROM HadnBackPrice");
            strSql.Append(" SELECT WorkingID, (SELECT WorkingName FROM Working WHERE (WorkingID = ");
            strSql.Append(" ProductWorkingInfo.WorkingID)) AS WorkingName, Price, (SELECT MaterielID ");
            strSql.Append(" FROM ProductWorkingMain WHERE (ProdWorkID = ProductWorkingInfo.MainID)) AS MaterielID, ");
            strSql.Append(" ProductWorkingID AS ID FROM ProductWorkingInfo");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetWorkByPW()
        {
            StringBuilder strSql = new StringBuilder();
            ////strSql.Append(" SELECT ProductWorkingID as WorkingID, (SELECT WorkingName FROM Working WHERE (WorkingID = ");
            ////strSql.Append(" ProductWorkingInfo.WorkingID)) AS WorkingName, Price, (SELECT MaterielID ");
            ////strSql.Append(" FROM ProductWorkingMain WHERE (ProdWorkID = ProductWorkingInfo.MainID)) AS MaterielID, ");
            ////strSql.Append(" ProductWorkingID AS ID FROM ProductWorkingInfo");
            ////strSql.Append(" SELECT ProductWorkingID , (SELECT WorkingName FROM Working WHERE (WorkingID = ");
            ////strSql.Append(" Tem.WorkingID)) AS WorkingName, Price, MaterielID, ID,WorkingID FROM (SELECT ProductWorkingID, WorkingID, Price, ");
            ////strSql.Append(" (SELECT MaterielID FROM ProductWorkingMain WHERE (ProdWorkID = ProductWorkingInfo.MainID)) AS MaterielID,  ");
            ////strSql.Append(" ProductWorkingID AS ID FROM ProductWorkingInfo WHERE (NOT ((SELECT MaterielID FROM ProductWorkingMain ");
            ////strSql.Append(" AS ProductWorkingMain_1 WHERE (ProdWorkID = ProductWorkingInfo.MainID)) IS NULL)) UNION ALL ");
            ////strSql.Append(" SELECT ProductWorkingID, WorkingID, Price, MaterielID, ProductWorkingID AS ID FROM ProductWorkingInfo ");
            ////strSql.Append(" AS ProductWorkingInfo_1 WHERE (MaterielID > 0)) AS Tem");
            //strSql.Append("SELECT   ProductWorkingInfo.WorkingID, ProductWorkingInfo.Price, Working.Name AS WorkingName, (SELECT   MaterielID FROM ");
            //strSql.Append(" ProductWorkingMain AS ProductWorkingMain_1 WHERE   (ID = ProductWorkingInfo.MainID)) AS MaterielID, ProductWorkingInfo.ID AS PWID ");
            //strSql.Append(" FROM      ProductWorkingInfo INNER JOIN Working ON ProductWorkingInfo.WorkingID = Working.ID WHERE   (Working.IsSpecial = 0) AND ");
            //strSql.Append(" (ProductWorkingInfo.PWMID = 0) UNION ALL SELECT   WorkingID, Price, (SELECT   Name FROM      Working AS Working_1 WHERE   (ID = ");
            //strSql.Append(" ProductWorkingInfo_1.WorkingID)) AS WorkingName, (SELECT   MaterielID FROM      ProductWorkingMain AS ProductWorkingMain_1 ");
            //strSql.Append(" WHERE   (ID = ProductWorkingInfo_1.PWMID)) AS MaterielID, ID AS PWID FROM      ProductWorkingInfo AS ProductWorkingInfo_1 ");
            //strSql.Append(" WHERE   (PWMID > 0) ");
            strSql.Append(" SELECT   ProductWorkingInfo.WorkingID, ProductWorkingInfo.Price, Working.Name AS WorkingName, (SELECT   MaterielID ");
            strSql.Append(" FROM      ProductWorkingMain AS ProductWorkingMain_1 WHERE   (ID = ProductWorkingInfo.MainID)) AS MaterielID, ");
            strSql.Append(" ProductWorkingInfo.ID AS PWID FROM      ProductWorkingInfo INNER JOIN  Working ON ProductWorkingInfo.WorkingID ");
            strSql.Append(" = Working.ID WHERE   (Working.IsSpecial = 0) AND (ProductWorkingInfo.PWIID = 0) UNION ALL SELECT   WorkingID, Price, ");
            strSql.Append(" (SELECT   Name FROM      Working AS Working_1 WHERE   (ID = ProductWorkingInfo_1.WorkingID)) AS WorkingName, ");
            strSql.Append(" (SELECT   MaterielID FROM      ProductWorkingMain AS ProductWorkingMain_1 WHERE   (ID = ProductWorkingInfo_1.MainID ");
            strSql.Append(" * - 1)) AS MaterielID, ID AS PWID FROM      ProductWorkingInfo AS ProductWorkingInfo_1 WHERE   (PWIID > 0)");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 取得新编号
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public int NewNum(DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            DateTime dt1 = dt.Date.AddSeconds(-1);
            DateTime dt2 = dt.Date.AddDays(1);
            strSql.Append("Select max(Num) as exp1 from HandBackMain where (datetime >@dt1) and (datetime<@dt2) ");
            SqlParameter[] sp = { new SqlParameter("@dt1", dt1), new SqlParameter("@dt2", dt2) };
            if (DbHelperSQL.GetSingle(strSql.ToString(), sp) != null)
            {
                return int.Parse(DbHelperSQL.GetSingle(strSql.ToString(), sp).ToString()) + 1;
            }
            else
            {
                return 1;
            }
        }
        /// <summary>
        /// 更新是否审核
        /// </summary>
        public void UpVerify(Hownet.Model.HandBackMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update HandBackMain set ");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyDateTime=@VerifyDateTime,");
            strSql.Append("VerifyManID=@VerifyManID");
            strSql.Append(" where MainID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.TinyInt,1),
					new SqlParameter("@VerifyDateTime", SqlDbType.DateTime),
					new SqlParameter("@VerifyManID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.IsVerify;
            parameters[2].Value = model.VerifyDateTime;
            parameters[3].Value = model.VerifyManID;

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
			parameters[0].Value = "HandBackMain";
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

