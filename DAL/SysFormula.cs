using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类SysFormula。
    /// </summary>
    public class SysFormula
    {
        public SysFormula()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from SysFormula");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SysFormula model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SysFormula(");
            strSql.Append("Operator1,Value1,Operator2,Value2,Operator3,Value3,Operator4,Value4,Operator5,Value5,Operator6,Value6,Operator7,Value7,Operator8,Value8,TypeID)");
            strSql.Append(" values (");
            strSql.Append("@Operator1,@Value1,@Operator2,@Value2,@Operator3,@Value3,@Operator4,@Value4,@Operator5,@Value5,@Operator6,@Value6,@Operator7,@Value7,@Operator8,@Value8,@TypeID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Operator1", SqlDbType.NVarChar,50),
					new SqlParameter("@Value1", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator2", SqlDbType.NVarChar,50),
					new SqlParameter("@Value2", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator3", SqlDbType.NVarChar,50),
					new SqlParameter("@Value3", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator4", SqlDbType.NVarChar,50),
					new SqlParameter("@Value4", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator5", SqlDbType.NVarChar,50),
					new SqlParameter("@Value5", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator6", SqlDbType.NVarChar,50),
					new SqlParameter("@Value6", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator7", SqlDbType.NVarChar,50),
					new SqlParameter("@Value7", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator8", SqlDbType.NVarChar,50),
					new SqlParameter("@Value8", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4)};
            parameters[0].Value = model.Operator1;
            parameters[1].Value = model.Value1;
            parameters[2].Value = model.Operator2;
            parameters[3].Value = model.Value2;
            parameters[4].Value = model.Operator3;
            parameters[5].Value = model.Value3;
            parameters[6].Value = model.Operator4;
            parameters[7].Value = model.Value4;
            parameters[8].Value = model.Operator5;
            parameters[9].Value = model.Value5;
            parameters[10].Value = model.Operator6;
            parameters[11].Value = model.Value6;
            parameters[12].Value = model.Operator7;
            parameters[13].Value = model.Value7;
            parameters[14].Value = model.Operator8;
            parameters[15].Value = model.Value8;
            parameters[16].Value = model.TypeID;

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
        public void Update(Hownet.Model.SysFormula model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SysFormula set ");
            strSql.Append("Operator1=@Operator1,");
            strSql.Append("Value1=@Value1,");
            strSql.Append("Operator2=@Operator2,");
            strSql.Append("Value2=@Value2,");
            strSql.Append("Operator3=@Operator3,");
            strSql.Append("Value3=@Value3,");
            strSql.Append("Operator4=@Operator4,");
            strSql.Append("Value4=@Value4,");
            strSql.Append("Operator5=@Operator5,");
            strSql.Append("Value5=@Value5,");
            strSql.Append("Operator6=@Operator6,");
            strSql.Append("Value6=@Value6,");
            strSql.Append("Operator7=@Operator7,");
            strSql.Append("Value7=@Value7,");
            strSql.Append("Operator8=@Operator8,");
            strSql.Append("Value8=@Value8,");
            strSql.Append("TypeID=@TypeID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Operator1", SqlDbType.NVarChar,50),
					new SqlParameter("@Value1", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator2", SqlDbType.NVarChar,50),
					new SqlParameter("@Value2", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator3", SqlDbType.NVarChar,50),
					new SqlParameter("@Value3", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator4", SqlDbType.NVarChar,50),
					new SqlParameter("@Value4", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator5", SqlDbType.NVarChar,50),
					new SqlParameter("@Value5", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator6", SqlDbType.NVarChar,50),
					new SqlParameter("@Value6", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator7", SqlDbType.NVarChar,50),
					new SqlParameter("@Value7", SqlDbType.NVarChar,50),
					new SqlParameter("@Operator8", SqlDbType.NVarChar,50),
					new SqlParameter("@Value8", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Operator1;
            parameters[2].Value = model.Value1;
            parameters[3].Value = model.Operator2;
            parameters[4].Value = model.Value2;
            parameters[5].Value = model.Operator3;
            parameters[6].Value = model.Value3;
            parameters[7].Value = model.Operator4;
            parameters[8].Value = model.Value4;
            parameters[9].Value = model.Operator5;
            parameters[10].Value = model.Value5;
            parameters[11].Value = model.Operator6;
            parameters[12].Value = model.Value6;
            parameters[13].Value = model.Operator7;
            parameters[14].Value = model.Value7;
            parameters[15].Value = model.Operator8;
            parameters[16].Value = model.Value8;
            parameters[17].Value = model.TypeID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SysFormula ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.SysFormula GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Operator1,Value1,Operator2,Value2,Operator3,Value3,Operator4,Value4,Operator5,Value5,Operator6,Value6,Operator7,Value7,Operator8,Value8,TypeID from SysFormula ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.SysFormula model = new Hownet.Model.SysFormula();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Operator1 = ds.Tables[0].Rows[0]["Operator1"].ToString();
                model.Value1 = ds.Tables[0].Rows[0]["Value1"].ToString();
                model.Operator2 = ds.Tables[0].Rows[0]["Operator2"].ToString();
                model.Value2 = ds.Tables[0].Rows[0]["Value2"].ToString();
                model.Operator3 = ds.Tables[0].Rows[0]["Operator3"].ToString();
                model.Value3 = ds.Tables[0].Rows[0]["Value3"].ToString();
                model.Operator4 = ds.Tables[0].Rows[0]["Operator4"].ToString();
                model.Value4 = ds.Tables[0].Rows[0]["Value4"].ToString();
                model.Operator5 = ds.Tables[0].Rows[0]["Operator5"].ToString();
                model.Value5 = ds.Tables[0].Rows[0]["Value5"].ToString();
                model.Operator6 = ds.Tables[0].Rows[0]["Operator6"].ToString();
                model.Value6 = ds.Tables[0].Rows[0]["Value6"].ToString();
                model.Operator7 = ds.Tables[0].Rows[0]["Operator7"].ToString();
                model.Value7 = ds.Tables[0].Rows[0]["Value7"].ToString();
                model.Operator8 = ds.Tables[0].Rows[0]["Operator8"].ToString();
                model.Value8 = ds.Tables[0].Rows[0]["Value8"].ToString();
                if (ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
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
            strSql.Append("select 1 as A,ID,Operator1,Value1,Operator2,Value2,Operator3,Value3,Operator4,Value4,Operator5,Value5,Operator6,Value6,Operator7,Value7,Operator8,Value8,TypeID ");
            strSql.Append(" FROM SysFormula ");
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
            strSql.Append(" ID,Operator1,Value1,Operator2,Value2,Operator3,Value3,Operator4,Value4,Operator5,Value5,Operator6,Value6,Operator7,Value7,Operator8,Value8,TypeID ");
            strSql.Append(" FROM SysFormula ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        //补贴设置
        public DataSet GetBuTie(object WorkTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT 1 as A, ID,  CAST(Operator1 AS Int) AS Operator1, CAST(Value1 AS Real) AS Value1,");
            strSql.Append(" Operator2, Value2, Operator3, Value3, Operator4, Value4, Operator5, Value5, ");
            strSql.Append(" Operator6, Value6, Operator7, Value7, Operator8,Value8,TypeID FROM SysFormula WHERE   (TypeID = 2) And (Value8=" + WorkTypeID + ")");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除补贴设置中非本工种的其余设置
        /// </summary>
        /// <param name="WTID"></param>
        public void DelNoWTID(object WTID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("DELETE FROM    SysFormula WHERE   (TypeID = 2) AND (Value8 <> @WTID)");
            SqlParameter[] sps = { new SqlParameter("@WTID", WTID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(),sps);
        }
        public DataSet GetBuTieList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   CAST(Operator1 AS Real) AS Money, CAST(Value1 AS Real) AS BiLi,Value8");
            strSql.Append("  FROM SysFormula WHERE   (TypeID = 2)");
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
            parameters[0].Value = "SysFormula";
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

