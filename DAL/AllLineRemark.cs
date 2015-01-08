using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:AllLineRemark
    /// </summary>
    public partial class AllLineRemark
    {
        public AllLineRemark()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AllLineRemark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.AllLineRemark model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AllLineRemark(");
            strSql.Append("MainID,TableTypeID,Remark1,Remark2,Remark3,Remark4,Remark5,Remark6,Remark7,Remark8)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@TableTypeID,@Remark1,@Remark2,@Remark3,@Remark4,@Remark5,@Remark6,@Remark7,@Remark8)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark1", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark2", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark3", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark4", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark5", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark6", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark7", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark8", SqlDbType.NVarChar,4000)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TableTypeID;
            parameters[2].Value = model.Remark1;
            parameters[3].Value = model.Remark2;
            parameters[4].Value = model.Remark3;
            parameters[5].Value = model.Remark4;
            parameters[6].Value = model.Remark5;
            parameters[7].Value = model.Remark6;
            parameters[8].Value = model.Remark7;
            parameters[9].Value = model.Remark8;

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
        public bool Update(Hownet.Model.AllLineRemark model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AllLineRemark set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("TableTypeID=@TableTypeID,");
            strSql.Append("Remark1=@Remark1,");
            strSql.Append("Remark2=@Remark2,");
            strSql.Append("Remark3=@Remark3,");
            strSql.Append("Remark4=@Remark4,");
            strSql.Append("Remark5=@Remark5,");
            strSql.Append("Remark6=@Remark6,");
            strSql.Append("Remark7=@Remark7,");
            strSql.Append("Remark8=@Remark8");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark1", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark2", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark3", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark4", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark5", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark6", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark7", SqlDbType.NVarChar,4000),
					new SqlParameter("@Remark8", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TableTypeID;
            parameters[2].Value = model.Remark1;
            parameters[3].Value = model.Remark2;
            parameters[4].Value = model.Remark3;
            parameters[5].Value = model.Remark4;
            parameters[6].Value = model.Remark5;
            parameters[7].Value = model.Remark6;
            parameters[8].Value = model.Remark7;
            parameters[9].Value = model.Remark8;
            parameters[10].Value = model.ID;

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
            strSql.Append("delete from AllLineRemark ");
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
            strSql.Append("delete from AllLineRemark ");
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
        public Hownet.Model.AllLineRemark GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,TableTypeID,Remark1,Remark2,Remark3,Remark4,Remark5,Remark6,Remark7,Remark8 from AllLineRemark ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.AllLineRemark model = new Hownet.Model.AllLineRemark();
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
                if (ds.Tables[0].Rows[0]["TableTypeID"] != null && ds.Tables[0].Rows[0]["TableTypeID"].ToString() != "")
                {
                    model.TableTypeID = int.Parse(ds.Tables[0].Rows[0]["TableTypeID"].ToString());
                }
                model.Remark1 = ds.Tables[0].Rows[0]["Remark1"].ToString();
                model.Remark2 = ds.Tables[0].Rows[0]["Remark2"].ToString();
                model.Remark3 = ds.Tables[0].Rows[0]["Remark3"].ToString();
                model.Remark4 = ds.Tables[0].Rows[0]["Remark4"].ToString();
                model.Remark5 = ds.Tables[0].Rows[0]["Remark5"].ToString();
                model.Remark6 = ds.Tables[0].Rows[0]["Remark6"].ToString();
                model.Remark7 = ds.Tables[0].Rows[0]["Remark7"].ToString();
                model.Remark8 = ds.Tables[0].Rows[0]["Remark8"].ToString();
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
            strSql.Append("select  1 as A,ID,MainID,TableTypeID,Remark1,Remark2,Remark3,Remark4,Remark5,Remark6,Remark7,Remark8 ");
            strSql.Append(" FROM AllLineRemark ");
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
            strSql.Append(" ID,MainID,TableTypeID,Remark1,Remark2,Remark3,Remark4,Remark5,Remark6,Remark7,Remark8 ");
            strSql.Append(" FROM AllLineRemark ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
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
            parameters[0].Value = "AllLineRemark";
            parameters[1].Value = "ID";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  Method
    }
}

