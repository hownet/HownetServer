using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:SumReoprtMain
    /// </summary>
    public partial class SumReoprtMain
    {
        public SumReoprtMain()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SumReoprtMain");
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
        public int Add(Hownet.Model.SumReoprtMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SumReoprtMain(");
            strSql.Append("TypeID,DateTime,OneDate,TwoDate,Remark,UpData,VerifyMan,VerifyDate,FillMan,IsVerify)");
            strSql.Append(" values (");
            strSql.Append("@TypeID,@DateTime,@OneDate,@TwoDate,@Remark,@UpData,@VerifyMan,@VerifyDate,@FillMan,@IsVerify)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@OneDate", SqlDbType.DateTime),
					new SqlParameter("@TwoDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4)};
            parameters[0].Value = model.TypeID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.OneDate;
            parameters[3].Value = model.TwoDate;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.UpData;
            parameters[6].Value = model.VerifyMan;
            parameters[7].Value = model.VerifyDate;
            parameters[8].Value = model.FillMan;
            parameters[9].Value = model.IsVerify;

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
        public bool Update(Hownet.Model.SumReoprtMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SumReoprtMain set ");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("OneDate=@OneDate,");
            strSql.Append("TwoDate=@TwoDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("IsVerify=@IsVerify");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@OneDate", SqlDbType.DateTime),
					new SqlParameter("@TwoDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.TypeID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.OneDate;
            parameters[3].Value = model.TwoDate;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.UpData;
            parameters[6].Value = model.VerifyMan;
            parameters[7].Value = model.VerifyDate;
            parameters[8].Value = model.FillMan;
            parameters[9].Value = model.IsVerify;
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
            strSql.Append("delete from SumReoprtMain ");
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
            strSql.Append("delete from SumReoprtMain ");
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
        public Hownet.Model.SumReoprtMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,TypeID,DateTime,OneDate,TwoDate,Remark,UpData,VerifyMan,VerifyDate,FillMan,IsVerify from SumReoprtMain ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.SumReoprtMain model = new Hownet.Model.SumReoprtMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OneDate"] != null && ds.Tables[0].Rows[0]["OneDate"].ToString() != "")
                {
                    model.OneDate = DateTime.Parse(ds.Tables[0].Rows[0]["OneDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TwoDate"] != null && ds.Tables[0].Rows[0]["TwoDate"].ToString() != "")
                {
                    model.TwoDate = DateTime.Parse(ds.Tables[0].Rows[0]["TwoDate"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["UpData"] != null && ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"] != null && ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"] != null && ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"] != null && ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"] != null && ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
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
            strSql.Append("select  1 as A,ID,TypeID,DateTime,OneDate,TwoDate,Remark,UpData,VerifyMan,VerifyDate,FillMan,IsVerify ");
            strSql.Append(" FROM SumReoprtMain ");
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
            strSql.Append(" ID,TypeID,DateTime,OneDate,TwoDate,Remark,UpData,VerifyMan,VerifyDate,FillMan,IsVerify ");
            strSql.Append(" FROM SumReoprtMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetIDList(int state)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from SumReoprtMain where (TypeID=" + state + ") order by ID");
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
            parameters[0].Value = "SumReoprtMain";
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

