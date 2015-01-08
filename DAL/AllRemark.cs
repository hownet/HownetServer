using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:AllRemark
    /// </summary>
    public partial class AllRemark
    {
        public AllRemark()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from AllRemark");
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
        public int Add(Hownet.Model.AllRemark model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into AllRemark(");
            strSql.Append("MainID,TableTypeID,OTID,OTName,Remark)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@TableTypeID,@OTID,@OTName,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@OTID", SqlDbType.Int,4),
					new SqlParameter("@OTName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TableTypeID;
            parameters[2].Value = model.OTID;
            parameters[3].Value = model.OTName;
            parameters[4].Value = model.Remark;

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
        public bool Update(Hownet.Model.AllRemark model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update AllRemark set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("TableTypeID=@TableTypeID,");
            strSql.Append("OTID=@OTID,");
            strSql.Append("OTName=@OTName,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@OTID", SqlDbType.Int,4),
					new SqlParameter("@OTName", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TableTypeID;
            parameters[2].Value = model.OTID;
            parameters[3].Value = model.OTName;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.ID;

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
            strSql.Append("delete from AllRemark ");
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
            strSql.Append("delete from AllRemark ");
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
        public Hownet.Model.AllRemark GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,TableTypeID,OTID,OTName,Remark from AllRemark ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.AllRemark model = new Hownet.Model.AllRemark();
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
                if (ds.Tables[0].Rows[0]["OTID"] != null && ds.Tables[0].Rows[0]["OTID"].ToString() != "")
                {
                    model.OTID = int.Parse(ds.Tables[0].Rows[0]["OTID"].ToString());
                }
                model.OTName = ds.Tables[0].Rows[0]["OTName"].ToString();
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
            strSql.Append("select  1 as A,ID,MainID,TableTypeID,OTID,OTName,Remark ");
            strSql.Append(" FROM AllRemark ");
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
            strSql.Append(" ID,MainID,TableTypeID,OTID,OTName,Remark ");
            strSql.Append(" FROM AllRemark ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetLastList(int CompanyID, int MaterielID,int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT 3 as A ,0 as ID,    AllRemark.MainID, AllRemark.TableTypeID, AllRemark.OTID, AllRemark.OTName, AllRemark.Remark ");
            strSql.Append(" FROM         AllRemark INNER JOIN (SELECT     TOP (1) ID, MaterielID, CompanyID ");
            strSql.Append(" FROM          ProductionPlan WHERE      (MaterielID = @MaterielID) AND (CompanyID = @CompanyID) ");
            strSql.Append(" ORDER BY ID DESC) AS T ON AllRemark.MainID = T.ID WHERE     (AllRemark.TableTypeID = @TableTypeID) ");
            strSql.Append(" ORDER BY AllRemark.ID");

            SqlParameter[] sps = { new SqlParameter("@CompanyID", CompanyID), new SqlParameter("@MaterielID", MaterielID), new SqlParameter("@TableTypeID", TableTypeID) };
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), sps);
            if(ds.Tables[0].Rows.Count==0)
            {
                strSql.Remove(0, strSql.Length);
                strSql.Append(" SELECT  3 as A ,0 as ID,   AllRemark.MainID, AllRemark.TableTypeID, AllRemark.OTID, AllRemark.OTName, AllRemark.Remark ");
                strSql.Append(" FROM         AllRemark INNER JOIN (SELECT     TOP (1) ID, MaterielID, CompanyID ");
                strSql.Append(" FROM          ProductionPlan WHERE       (CompanyID = @CompanyID) ");
                strSql.Append(" ORDER BY ID DESC) AS T ON AllRemark.MainID = T.ID WHERE     (AllRemark.TableTypeID = @TableTypeID) ");
                strSql.Append(" ORDER BY AllRemark.ID");
                ds = DbHelperSQL.Query(strSql.ToString(), sps);
            }
            return ds;
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
            parameters[0].Value = "AllRemark";
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

