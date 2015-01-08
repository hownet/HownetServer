using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类DepartmentTaskMain。
    /// </summary>
    public class DepartmentTaskMain
    {
        public DepartmentTaskMain()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DepartmentTaskMain");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.DepartmentTaskMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DepartmentTaskMain(");
            strSql.Append("DepartmentID,TaskID,DateTime,LastDate,Remark,Num,IsEnd,PWID)");
            strSql.Append(" values (");
            strSql.Append("@DepartmentID,@TaskID,@DateTime,@LastDate,@Remark,@Num,@IsEnd,@PWID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@PWID", SqlDbType.Int,4)};
            parameters[0].Value = model.DepartmentID;
            parameters[1].Value = model.TaskID;
            parameters[2].Value = model.DateTime;
            parameters[3].Value = model.LastDate;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.Num;
            parameters[6].Value = model.IsEnd;
            parameters[7].Value = model.PWID;

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
        public void Update(Hownet.Model.DepartmentTaskMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DepartmentTaskMain set ");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("LastDate=@LastDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Num=@Num,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("PWID=@PWID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@LastDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@PWID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DepartmentID;
            parameters[2].Value = model.TaskID;
            parameters[3].Value = model.DateTime;
            parameters[4].Value = model.LastDate;
            parameters[5].Value = model.Remark;
            parameters[6].Value = model.Num;
            parameters[7].Value = model.IsEnd;
            parameters[8].Value = model.PWID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DepartmentTaskMain ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.DepartmentTaskMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DepartmentID,TaskID,DateTime,LastDate,Remark,Num,IsEnd,PWID from DepartmentTaskMain ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.DepartmentTaskMain model = new Hownet.Model.DepartmentTaskMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepartmentID"].ToString() != "")
                {
                    model.DepartmentID = int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastDate"].ToString() != "")
                {
                    model.LastDate = DateTime.Parse(ds.Tables[0].Rows[0]["LastDate"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PWID"].ToString() != "")
                {
                    model.PWID = int.Parse(ds.Tables[0].Rows[0]["PWID"].ToString());
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
            strSql.Append("select 1 as A,ID,DepartmentID,TaskID,DateTime,LastDate,Remark,Num,IsEnd,PWID ");
            strSql.Append(" FROM DepartmentTaskMain ");
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
            strSql.Append(" ID,DepartmentID,TaskID,DateTime,LastDate,Remark,Num,IsEnd,PWID ");
            strSql.Append(" FROM DepartmentTaskMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 返回某生产单下已拆分的班组任务列表
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetDepList(int TaskID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT ID, DepartmentID, (SELECT SUM(Amount) AS SumAmount ");
            strSql.Append(" FROM DepartmentTaskInfo WHERE (MainID = DepartmentTaskMain.ID)) AS SumAmount, DateTime, ");
            strSql.Append(" LastDate, Remark, Num, IsEnd FROM DepartmentTaskMain WHERE (TaskID = @TaskID)");
            SqlParameter[] sps = {new SqlParameter("@TaskID",TaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 取得新编号
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public int NewNum(DateTime dt)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select max(Num) as exp1 from DepartmentTaskMain where (DateTime =@dt)  ");
            SqlParameter[] sp = { new SqlParameter("@dt", dt) };
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
        /// 某班组所分配任务列表
        /// </summary>
        /// <param name="DeparmentID"></param>
        /// <returns></returns>
        public DataSet GetListByDeparmentID(int DeparmentID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("SELECT ID, DateTime, Num,(SELECT MaterielName FROM Materiel WHERE (MaterielID = (SELECT MaterielID FROM ProduceTaskMain ");
            //strSql.Append(" WHERE (ProduceTaskID = DepartmentTaskMain.TaskID)))) AS MaterielName,(SELECT DateTime FROM ProduceTaskMain AS ProduceTaskMain_1 ");
            //strSql.Append(" WHERE (ProduceTaskID = DepartmentTaskMain.TaskID)) AS MainDate, (SELECT Num FROM ProduceTaskMain AS ProduceTaskMain_1 ");
            //strSql.Append(" WHERE (ProduceTaskID = DepartmentTaskMain.TaskID)) AS MainNum, (SELECT SUM(Amount) AS SumAmount FROM DepartmentTaskInfo ");
            //strSql.Append(" WHERE (MainID = DepartmentTaskMain.ID)) AS SumAmount FROM DepartmentTaskMain ");
            strSql.Append(" SELECT DepartmentTaskMain.ID, DepartmentTaskMain.DateTime, DepartmentTaskMain.Num, ");
            strSql.Append(" (SELECT SUM(Amount) AS SumAmount FROM DepartmentTaskInfo WHERE (MainID = DepartmentTaskMain.ID)) ");
            strSql.Append(" AS SumAmount, Materiel_1.MaterielName, Materiel_1.MaterielID, ProduceTaskMain_2.BrandID, ");
            strSql.Append(" ProduceTaskMain_2.CompanyID, ProduceTaskMain_2.Num AS MainNum, ProduceTaskMain_2.DateTime AS ");
            strSql.Append(" MainDate FROM Materiel AS Materiel_1 INNER JOIN ProduceTaskMain AS ProduceTaskMain_2 ON  ");
            strSql.Append(" Materiel_1.MaterielID = ProduceTaskMain_2.MaterielID INNER JOIN DepartmentTaskMain ON  ");
            strSql.Append(" ProduceTaskMain_2.ProduceTaskID = DepartmentTaskMain.TaskID");
            if (DeparmentID > 0)
                strSql.Append(" WHERE (DepartmentID = @DepID) ");
            strSql.Append(" ORDER BY ID DESC");
            SqlParameter[] sps = { new SqlParameter("@DepID", DeparmentID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetAllNum()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID , Num, DateTime FROM DepartmentTaskMain");
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
            parameters[0].Value = "DepartmentTaskMain";
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

