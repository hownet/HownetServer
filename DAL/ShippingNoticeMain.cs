using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类ShippingNoticeMain。
    /// </summary>
    public class ShippingNoticeMain
    {
        public ShippingNoticeMain()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ShippingNoticeMain");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ShippingNoticeMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ShippingNoticeMain(");
            strSql.Append("DateTime,UpData,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,Remark,DeparmentID)");
            strSql.Append(" values (");
            strSql.Append("@DateTime,@UpData,@Num,@FillMan,@FillDate,@IsVerify,@VerifyMan,@VerifyDate,@Remark,@DeparmentID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4)};
            parameters[0].Value = model.DateTime;
            parameters[1].Value = model.UpData;
            parameters[2].Value = model.Num;
            parameters[3].Value = model.FillMan;
            parameters[4].Value = model.FillDate;
            parameters[5].Value = model.IsVerify;
            parameters[6].Value = model.VerifyMan;
            parameters[7].Value = model.VerifyDate;
            parameters[8].Value = model.Remark;
            parameters[9].Value = model.DeparmentID;

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
        public void Update(Hownet.Model.ShippingNoticeMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ShippingNoticeMain set ");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("Num=@Num,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("DeparmentID=@DeparmentID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@DeparmentID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.UpData;
            parameters[3].Value = model.Num;
            parameters[4].Value = model.FillMan;
            parameters[5].Value = model.FillDate;
            parameters[6].Value = model.IsVerify;
            parameters[7].Value = model.VerifyMan;
            parameters[8].Value = model.VerifyDate;
            parameters[9].Value = model.Remark;
            parameters[10].Value = model.DeparmentID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ShippingNoticeMain ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.ShippingNoticeMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DateTime,UpData,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,Remark,DeparmentID from ShippingNoticeMain ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.ShippingNoticeMain model = new Hownet.Model.ShippingNoticeMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["DeparmentID"].ToString() != "")
                {
                    model.DeparmentID = int.Parse(ds.Tables[0].Rows[0]["DeparmentID"].ToString());
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
            strSql.Append("select 1 as A,ID,DateTime,UpData,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,Remark,DeparmentID ");
            strSql.Append(" FROM ShippingNoticeMain ");
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
            strSql.Append(" ID,DateTime,UpData,Num,FillMan,FillDate,IsVerify,VerifyMan,VerifyDate,Remark,DeparmentID ");
            strSql.Append(" FROM ShippingNoticeMain ");
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
            parameters[0].Value = "ShippingNoticeMain";
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

