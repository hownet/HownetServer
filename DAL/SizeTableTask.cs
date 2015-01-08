using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类SizeTableTask。
	/// </summary>
	public class SizeTableTask
	{
		public SizeTableTask()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SizeTableTask"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SizeTableTask");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SizeTableTask model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SizeTableTask(");
            strSql.Append("SizeID,SizePartID,TaskID,Length,MaterielID)");
            strSql.Append(" values (");
            strSql.Append("@SizeID,@SizePartID,@TaskID,@Length,@MaterielID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@SizePartID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@Length", SqlDbType.Decimal,9),
					new SqlParameter("@MaterielID", SqlDbType.Int,4)};
            parameters[0].Value = model.SizeID;
            parameters[1].Value = model.SizePartID;
            parameters[2].Value = model.TaskID;
            parameters[3].Value = model.Length;
            parameters[4].Value = model.MaterielID;

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
        public void Update(Hownet.Model.SizeTableTask model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SizeTableTask set ");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("SizePartID=@SizePartID,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("Length=@Length,");
            strSql.Append("MaterielID=@MaterielID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@SizePartID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@Length", SqlDbType.Decimal,9),
					new SqlParameter("@MaterielID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.SizeID;
            parameters[2].Value = model.SizePartID;
            parameters[3].Value = model.TaskID;
            parameters[4].Value = model.Length;
            parameters[5].Value = model.MaterielID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SizeTableTask ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.SizeTableTask GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,SizeID,SizePartID,TaskID,Length,MaterielID from SizeTableTask ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.SizeTableTask model = new Hownet.Model.SizeTableTask();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizePartID"].ToString() != "")
                {
                    model.SizePartID = int.Parse(ds.Tables[0].Rows[0]["SizePartID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Length"].ToString() != "")
                {
                    model.Length = decimal.Parse(ds.Tables[0].Rows[0]["Length"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
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
            strSql.Append("select 1 as A,ID,SizeID,SizePartID,TaskID,cast(Length as Real) as Length ,MaterielID ");
            strSql.Append(" FROM SizeTableTask ");
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
            strSql.Append(" ID,SizeID,SizePartID,TaskID,Length,MaterielID ");
            strSql.Append(" FROM SizeTableTask ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetSizePartIDGroup(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT SizePartID, (SELECT Name FROM SizePart WHERE (ID = SizeTableTask.SizePartID)) ");
            strSql.Append(" AS SizePartName FROM SizeTableTask WHERE (TaskID = @TaskID) GROUP BY SizePartID");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSizePartIDGroupByMaterielID(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            if (MaterielID < 0)
            {
                strSql.Append("SELECT   SizeTableTask.SizePartID, SizePart_1.Tolerance, SizePart_1.Name FROM      SizeTableTask INNER JOIN ");
                strSql.Append(" SizePart AS SizePart_1 ON SizeTableTask.SizePartID = SizePart_1.ID WHERE   (SizeTableTask.MaterielID = @MaterielID) ");
                strSql.Append(" And (SizeTableTask.TaskID=-1) GROUP BY SizeTableTask.SizePartID, SizePart_1.Tolerance, SizePart_1.Name");
            }
            else
            {
                strSql.Append("SELECT   SizeTableTask.SizePartID, SizePart_1.Tolerance, SizePart_1.Name FROM      SizeTableTask INNER JOIN ");
                strSql.Append(" SizePart AS SizePart_1 ON SizeTableTask.SizePartID = SizePart_1.ID WHERE   ");
                strSql.Append(" (SizeTableTask.TaskID=@MaterielID) GROUP BY SizeTableTask.SizePartID, SizePart_1.Tolerance, SizePart_1.Name");
            }
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 获取尺码
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataTable GetSize(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT (SELECT Name FROM Size WHERE (ID = SizeTableTask.SizeID)) AS SizeName, SizeID ");
            strSql.Append("  FROM SizeTableTask WHERE (TaskID = @ID) GROUP BY SizeID");
            SqlParameter[] sps = { new SqlParameter("@ID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
        }
        public DataTable GetSizeByMaterielID(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT (SELECT Name FROM Size WHERE (ID = SizeTableTask.SizeID)) AS SizeName, SizeID ");
            strSql.Append("  FROM SizeTableTask WHERE (TaskID = -1) and (MaterielID=@ID) GROUP BY SizeID");
            SqlParameter[] sps = { new SqlParameter("@ID", MaterielID) };
            return DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
        }
        public void DelInfo(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM SizeTableTask WHERE   (TaskID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public void DelInfoByMaterielID(int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM SizeTableTask WHERE  (TaskID=-1) And  (MaterielID = @MaterielID)");
            SqlParameter[] sps = { new SqlParameter("@MaterielID", MaterielID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetReport(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Size.Name AS SizeName, SizePart.Name AS SizePartName, CAST(SizeTableTask.Length AS Real) AS Length ");
            strSql.Append(" FROM SizePart INNER JOIN SizeTableTask ON SizePart.ID = SizeTableTask.SizePartID INNER JOIN ");
            strSql.Append(" Size ON SizeTableTask.SizeID = Size.ID WHERE   (SizeTableTask.TaskID = @TaskID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetListNoA()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID,SizeID,SizePartID,TaskID,Length,MaterielID From SizeTableTask where (id=0)");
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
			parameters[0].Value = "SizeTableTask";
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

