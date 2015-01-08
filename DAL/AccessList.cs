using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类AccessList。
	/// </summary>
	public class AccessList
	{
		public AccessList()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "AccessList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from AccessList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.AccessList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AccessList(");
            strSql.Append("AccessID,EmployeeID,PassWord,Remark)");
            strSql.Append(" values (");
            strSql.Append("@AccessID,@EmployeeID,@PassWord,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@AccessID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@PassWord", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
            parameters[0].Value = model.AccessID;
            parameters[1].Value = model.EmployeeID;
            parameters[2].Value = model.PassWord;
            parameters[3].Value = model.Remark;

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
        public void Update(Hownet.Model.AccessList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AccessList set ");
            strSql.Append("AccessID=@AccessID,");
            strSql.Append("EmployeeID=@EmployeeID,");
            strSql.Append("PassWord=@PassWord,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@AccessID", SqlDbType.Int,4),
					new SqlParameter("@EmployeeID", SqlDbType.Int,4),
					new SqlParameter("@PassWord", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.AccessID;
            parameters[2].Value = model.EmployeeID;
            parameters[3].Value = model.PassWord;
            parameters[4].Value = model.Remark;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from AccessList ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.AccessList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,AccessID,EmployeeID,PassWord,Remark from AccessList ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.AccessList model = new Hownet.Model.AccessList();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AccessID"].ToString() != "")
                {
                    model.AccessID = int.Parse(ds.Tables[0].Rows[0]["AccessID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["EmployeeID"].ToString() != "")
                {
                    model.EmployeeID = int.Parse(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                }
                model.PassWord = ds.Tables[0].Rows[0]["PassWord"].ToString();
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
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
            strSql.Append("select 1 as A,ID,AccessID,EmployeeID,PassWord,Remark ");
            strSql.Append(" FROM AccessList ");
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
            strSql.Append(" ID,AccessID,EmployeeID,PassWord,Remark ");
            strSql.Append(" FROM AccessList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 查找某一机器下的可开门员工
        /// </summary>
        /// <param name="AccessID"></param>
        /// <returns></returns>
        public DataSet GetListByAccessID(int AccessID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   MiniEmp.Name, MiniEmp.ID AS EmployeeID, T.Remark, T.PassWord, T.ID, T.AccessID, Deparment.Name ");
            strSql.Append(" AS DeparmentName FROM      MiniEmp INNER JOIN Deparment ON MiniEmp.DepartmentID = Deparment.ID LEFT OUTER ");
            strSql.Append(" JOIN (SELECT   EmployeeID, ID, AccessID, Remark, PassWord FROM      AccessList WHERE   (AccessID = @AccessID)) ");
            strSql.Append(" AS T ON MiniEmp.ID = T.EmployeeID");
            SqlParameter[] sps = { new SqlParameter("@AccessID", AccessID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 判断某人是否可以打开某门禁
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="NID"></param>
        /// <returns></returns>
        public bool CheckIsCanOpenDoor(int EmployeeID, int NID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   AccessList.EmployeeID, CardReaderList.NID FROM      AccessList INNER JOIN ");
            strSql.Append(" CardReaderList ON AccessList.AccessID = CardReaderList.ID WHERE   (AccessList.EmployeeID = ");
            strSql.Append(" @EmployeeID) AND (CardReaderList.NID = @NID)");
            SqlParameter[] sps = { new SqlParameter("@EmployeeID", EmployeeID), new SqlParameter("@NID", NID) };
            return DbHelperSQL.Query(strSql.ToString(), sps).Tables[0].Rows.Count > 0;
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
			parameters[0].Value = "AccessList";
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

