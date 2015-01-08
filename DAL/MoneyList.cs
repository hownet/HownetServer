using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:MoneyList
    /// </summary>
    public partial class MoneyList
    {
        public MoneyList()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from MoneyList");
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
        public int Add(Hownet.Model.MoneyList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MoneyList(");
            strSql.Append("KJKMID,DateTime,InMoney,OutMoney,Money,TableID,TypeID,Remark)");
            strSql.Append(" values (");
            strSql.Append("@KJKMID,@DateTime,@InMoney,@OutMoney,@Money,@TableID,@TypeID,@Remark)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@KJKMID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@InMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OutMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@TableID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000)};
            parameters[0].Value = model.KJKMID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.InMoney;
            parameters[3].Value = model.OutMoney;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.TableID;
            parameters[6].Value = model.TypeID;
            parameters[7].Value = model.Remark;

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
        public bool Update(Hownet.Model.MoneyList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MoneyList set ");
            strSql.Append("KJKMID=@KJKMID,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("InMoney=@InMoney,");
            strSql.Append("OutMoney=@OutMoney,");
            strSql.Append("Money=@Money,");
            strSql.Append("TableID=@TableID,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("Remark=@Remark");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@KJKMID", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@InMoney", SqlDbType.Decimal,9),
					new SqlParameter("@OutMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@TableID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.KJKMID;
            parameters[1].Value = model.DateTime;
            parameters[2].Value = model.InMoney;
            parameters[3].Value = model.OutMoney;
            parameters[4].Value = model.Money;
            parameters[5].Value = model.TableID;
            parameters[6].Value = model.TypeID;
            parameters[7].Value = model.Remark;
            parameters[8].Value = model.ID;

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
            strSql.Append("delete from MoneyList ");
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
            strSql.Append("delete from MoneyList ");
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
        public Hownet.Model.MoneyList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,KJKMID,DateTime,InMoney,OutMoney,Money,TableID,TypeID,Remark from MoneyList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.MoneyList model = new Hownet.Model.MoneyList();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["KJKMID"] != null && ds.Tables[0].Rows[0]["KJKMID"].ToString() != "")
                {
                    model.KJKMID = int.Parse(ds.Tables[0].Rows[0]["KJKMID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"] != null && ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["InMoney"] != null && ds.Tables[0].Rows[0]["InMoney"].ToString() != "")
                {
                    model.InMoney = decimal.Parse(ds.Tables[0].Rows[0]["InMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OutMoney"] != null && ds.Tables[0].Rows[0]["OutMoney"].ToString() != "")
                {
                    model.OutMoney = decimal.Parse(ds.Tables[0].Rows[0]["OutMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TableID"] != null && ds.Tables[0].Rows[0]["TableID"].ToString() != "")
                {
                    model.TableID = int.Parse(ds.Tables[0].Rows[0]["TableID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
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
            strSql.Append("select  1 as A,ID,KJKMID,DateTime,InMoney,OutMoney,Money,TableID,TypeID,Remark ");
            strSql.Append(" FROM MoneyList ");
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
            strSql.Append(" ID,KJKMID,DateTime,InMoney,OutMoney,Money,TableID,TypeID,Remark ");
            strSql.Append(" FROM MoneyList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public decimal GetLastMoney(int KJKMID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   TOP (1) Money FROM      MoneyList WHERE   (KJKMID = @KMID) ORDER BY ID DESC");
            SqlParameter[] sps = { new SqlParameter("@KMID", KJKMID) };
            DataTable dt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return Convert.ToDecimal(dt.Rows[0]["Money"]);
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 是否可以弃审单据
        /// </summary>
        /// <param name="CompanyID"></param>
        /// <param name="TypeID"></param>
        /// <param name="TableID"></param>
        /// <returns></returns>
        public int CanUnVerify(int KJKMID, int TypeID, int TableID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID FROM      MoneyList WHERE   (KJKMID = @KJKMID) AND (ID > (SELECT   ID ");
            strSql.Append(" FROM      MoneyList AS MoneyList_1 WHERE   (KJKMID = @KJKMID) AND (TypeID = @TypeID) AND (TableID = @TableID)))");
            SqlParameter[] sps = { new SqlParameter("@KJKMID", KJKMID), new SqlParameter("@TypeID", TypeID), new SqlParameter("@TableID", TableID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 0;
            else
                return 1;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteLog(int KJKMID, int TypeID, int TableID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from MoneyList ");
            strSql.Append(" where (KJKMID=@ID) And (TypeID=@TypeID) And (TableID=@TableID) ");
            SqlParameter[] parameters = { new SqlParameter("@ID", KJKMID), new SqlParameter("@TypeID", TypeID), new SqlParameter("@TableID", TableID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 平衡会计科目与流水帐余额
        /// </summary>
        public void Balance()
        {
            Hownet.DAL.Bas_KJKM dalBK = new Bas_KJKM();
            DataTable dtKJKM = dalBK.GetMoneyKJKM().Tables[0];
            Hownet.Model.MoneyList modML;
            for (int i = 0; i < dtKJKM.Rows.Count; i++)
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(" SELECT   MAX(ID) AS aaa FROM      MoneyList WHERE   (KJKMID = "+dtKJKM.Rows[i]["ID"]+")");
                object o = DbHelperSQL.GetSingle(strSql.ToString());
                if (o != null)
                {
                    modML = GetModel(Convert.ToInt32(o));
                    modML.Money = Convert.ToDecimal(dtKJKM.Rows[i]["Money"]);
                    modML.Remark = "平衡----" + modML.Remark;
                    Update(modML);
                }
            }
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
            parameters[0].Value = "MoneyList";
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

