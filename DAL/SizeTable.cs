using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类SizeTable。
    /// </summary>
    public class SizeTable
    {
        public SizeTable()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SizeTable");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SizeTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SizeTable(");
            strSql.Append("MainID,TableTypeID,FillMan,ZhiYang,BanFangZhuGuan,ShengChangBu,LastEditDate,LastEditMan,IsVerify,VerifyMan,VerifyDate,Remark,Images,LastEditRemark,MeasureID,DateTime,UpData)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@TableTypeID,@FillMan,@ZhiYang,@BanFangZhuGuan,@ShengChangBu,@LastEditDate,@LastEditMan,@IsVerify,@VerifyMan,@VerifyDate,@Remark,@Images,@LastEditRemark,@MeasureID,@DateTime,@UpData)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@ZhiYang", SqlDbType.Int,4),
					new SqlParameter("@BanFangZhuGuan", SqlDbType.Int,4),
					new SqlParameter("@ShengChangBu", SqlDbType.Int,4),
					new SqlParameter("@LastEditDate", SqlDbType.DateTime),
					new SqlParameter("@LastEditMan", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Images", SqlDbType.NVarChar,50),
					new SqlParameter("@LastEditRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TableTypeID;
            parameters[2].Value = model.FillMan;
            parameters[3].Value = model.ZhiYang;
            parameters[4].Value = model.BanFangZhuGuan;
            parameters[5].Value = model.ShengChangBu;
            parameters[6].Value = model.LastEditDate;
            parameters[7].Value = model.LastEditMan;
            parameters[8].Value = model.IsVerify;
            parameters[9].Value = model.VerifyMan;
            parameters[10].Value = model.VerifyDate;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.Images;
            parameters[13].Value = model.LastEditRemark;
            parameters[14].Value = model.MeasureID;
            parameters[15].Value = model.DateTime;
            parameters[16].Value = model.UpData;

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
        public void Update(Hownet.Model.SizeTable model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SizeTable set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("TableTypeID=@TableTypeID,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("ZhiYang=@ZhiYang,");
            strSql.Append("BanFangZhuGuan=@BanFangZhuGuan,");
            strSql.Append("ShengChangBu=@ShengChangBu,");
            strSql.Append("LastEditDate=@LastEditDate,");
            strSql.Append("LastEditMan=@LastEditMan,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Images=@Images,");
            strSql.Append("LastEditRemark=@LastEditRemark,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("UpData=@UpData");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TableTypeID", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@ZhiYang", SqlDbType.Int,4),
					new SqlParameter("@BanFangZhuGuan", SqlDbType.Int,4),
					new SqlParameter("@ShengChangBu", SqlDbType.Int,4),
					new SqlParameter("@LastEditDate", SqlDbType.DateTime),
					new SqlParameter("@LastEditMan", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Images", SqlDbType.NVarChar,50),
					new SqlParameter("@LastEditRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@UpData", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.MainID;
            parameters[2].Value = model.TableTypeID;
            parameters[3].Value = model.FillMan;
            parameters[4].Value = model.ZhiYang;
            parameters[5].Value = model.BanFangZhuGuan;
            parameters[6].Value = model.ShengChangBu;
            parameters[7].Value = model.LastEditDate;
            parameters[8].Value = model.LastEditMan;
            parameters[9].Value = model.IsVerify;
            parameters[10].Value = model.VerifyMan;
            parameters[11].Value = model.VerifyDate;
            parameters[12].Value = model.Remark;
            parameters[13].Value = model.Images;
            parameters[14].Value = model.LastEditRemark;
            parameters[15].Value = model.MeasureID;
            parameters[16].Value = model.DateTime;
            parameters[17].Value = model.UpData;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SizeTable ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.SizeTable GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,TableTypeID,FillMan,ZhiYang,BanFangZhuGuan,ShengChangBu,LastEditDate,LastEditMan,IsVerify,VerifyMan,VerifyDate,Remark,Images,LastEditRemark,MeasureID,DateTime,UpData from SizeTable ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.SizeTable model = new Hownet.Model.SizeTable();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TableTypeID"].ToString() != "")
                {
                    model.TableTypeID = int.Parse(ds.Tables[0].Rows[0]["TableTypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ZhiYang"].ToString() != "")
                {
                    model.ZhiYang = int.Parse(ds.Tables[0].Rows[0]["ZhiYang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BanFangZhuGuan"].ToString() != "")
                {
                    model.BanFangZhuGuan = int.Parse(ds.Tables[0].Rows[0]["BanFangZhuGuan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ShengChangBu"].ToString() != "")
                {
                    model.ShengChangBu = int.Parse(ds.Tables[0].Rows[0]["ShengChangBu"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastEditDate"].ToString() != "")
                {
                    model.LastEditDate = DateTime.Parse(ds.Tables[0].Rows[0]["LastEditDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastEditMan"].ToString() != "")
                {
                    model.LastEditMan = int.Parse(ds.Tables[0].Rows[0]["LastEditMan"].ToString());
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
                model.Images = ds.Tables[0].Rows[0]["Images"].ToString();
                model.LastEditRemark = ds.Tables[0].Rows[0]["LastEditRemark"].ToString();
                if (ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
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
            strSql.Append("select 1 as A,ID,MainID,TableTypeID,FillMan,ZhiYang,BanFangZhuGuan,ShengChangBu,LastEditDate,LastEditMan,IsVerify,VerifyMan,VerifyDate,Remark,Images,LastEditRemark,MeasureID,DateTime,UpData ");
            strSql.Append(" FROM SizeTable ");
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
            strSql.Append(" ID,MainID,TableTypeID,FillMan,ZhiYang,BanFangZhuGuan,ShengChangBu,LastEditDate,LastEditMan,IsVerify,VerifyMan,VerifyDate,Remark,Images,LastEditRemark,MeasureID,DateTime,UpData ");
            strSql.Append(" FROM SizeTable ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int GetUpData(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select UpData from SizeTable where id=@ID");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return int.Parse(o.ToString());
            else
                return 0;
        }
        public DataSet GetTaskSTList(int TaskID, int TableTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   SizeTable.ID, SampleMain.DefaultSTID FROM      OderMain INNER JOIN TaskMain ON OderMain.ID = ");
            strSql.Append(" TaskMain.OderMainID INNER JOIN SizeTable ON OderMain.SampleMainID = SizeTable.MainID INNER JOIN ");
            strSql.Append(" SampleMain ON OderMain.SampleMainID = SampleMain.ID WHERE   (TaskMain.ID = @TaskID) AND (SizeTable.TableTypeID = @TableTypeID)");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@TableTypeID", TableTypeID) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
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
            parameters[0].Value = "SizeTable";
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

