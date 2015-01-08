using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:CW_KJFL
	/// </summary>
	public partial class CW_KJFL
	{
		public CW_KJFL()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CW_KJFL"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CW_KJFL");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.CW_KJFL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CW_KJFL(");
            strSql.Append("编号,年,月,日,时间,附件,制单人,审核,记帐,财务主管,制单人ID,审核ID,记帐ID,财务主管ID,制单日期,审核日期,记账日期,主管审核日期,帐户,帐户ID,TypeID,TableID)");
            strSql.Append(" values (");
            strSql.Append("@编号,@年,@月,@日,@时间,@附件,@制单人,@审核,@记帐,@财务主管,@制单人ID,@审核ID,@记帐ID,@财务主管ID,@制单日期,@审核日期,@记账日期,@主管审核日期,@帐户,@帐户ID,@TypeID,@TableID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.NVarChar,50),
					new SqlParameter("@年", SqlDbType.NChar,4),
					new SqlParameter("@月", SqlDbType.NChar,2),
					new SqlParameter("@日", SqlDbType.NChar,2),
					new SqlParameter("@时间", SqlDbType.NChar,10),
					new SqlParameter("@附件", SqlDbType.NVarChar,50),
					new SqlParameter("@制单人", SqlDbType.NVarChar,50),
					new SqlParameter("@审核", SqlDbType.NVarChar,50),
					new SqlParameter("@记帐", SqlDbType.NVarChar,50),
					new SqlParameter("@财务主管", SqlDbType.NVarChar,50),
					new SqlParameter("@制单人ID", SqlDbType.Int,4),
					new SqlParameter("@审核ID", SqlDbType.Int,4),
					new SqlParameter("@记帐ID", SqlDbType.Int,4),
					new SqlParameter("@财务主管ID", SqlDbType.NVarChar,50),
					new SqlParameter("@制单日期", SqlDbType.NVarChar,50),
					new SqlParameter("@审核日期", SqlDbType.NVarChar,50),
					new SqlParameter("@记账日期", SqlDbType.NVarChar,50),
					new SqlParameter("@主管审核日期", SqlDbType.NVarChar,50),
					new SqlParameter("@帐户", SqlDbType.NVarChar,50),
					new SqlParameter("@帐户ID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TableID", SqlDbType.Int,4)};
            parameters[0].Value = model.编号;
            parameters[1].Value = model.年;
            parameters[2].Value = model.月;
            parameters[3].Value = model.日;
            parameters[4].Value = model.时间;
            parameters[5].Value = model.附件;
            parameters[6].Value = model.制单人;
            parameters[7].Value = model.审核;
            parameters[8].Value = model.记帐;
            parameters[9].Value = model.财务主管;
            parameters[10].Value = model.制单人ID;
            parameters[11].Value = model.审核ID;
            parameters[12].Value = model.记帐ID;
            parameters[13].Value = model.财务主管ID;
            parameters[14].Value = model.制单日期;
            parameters[15].Value = model.审核日期;
            parameters[16].Value = model.记账日期;
            parameters[17].Value = model.主管审核日期;
            parameters[18].Value = model.帐户;
            parameters[19].Value = model.帐户ID;
            parameters[20].Value = model.TypeID;
            parameters[21].Value = model.TableID;

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
        public bool Update(Hownet.Model.CW_KJFL model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CW_KJFL set ");
            strSql.Append("编号=@编号,");
            strSql.Append("年=@年,");
            strSql.Append("月=@月,");
            strSql.Append("日=@日,");
            strSql.Append("时间=@时间,");
            strSql.Append("附件=@附件,");
            strSql.Append("制单人=@制单人,");
            strSql.Append("审核=@审核,");
            strSql.Append("记帐=@记帐,");
            strSql.Append("财务主管=@财务主管,");
            strSql.Append("制单人ID=@制单人ID,");
            strSql.Append("审核ID=@审核ID,");
            strSql.Append("记帐ID=@记帐ID,");
            strSql.Append("财务主管ID=@财务主管ID,");
            strSql.Append("制单日期=@制单日期,");
            strSql.Append("审核日期=@审核日期,");
            strSql.Append("记账日期=@记账日期,");
            strSql.Append("主管审核日期=@主管审核日期,");
            strSql.Append("帐户=@帐户,");
            strSql.Append("帐户ID=@帐户ID,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("TableID=@TableID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@编号", SqlDbType.NVarChar,50),
					new SqlParameter("@年", SqlDbType.NChar,4),
					new SqlParameter("@月", SqlDbType.NChar,2),
					new SqlParameter("@日", SqlDbType.NChar,2),
					new SqlParameter("@时间", SqlDbType.NChar,10),
					new SqlParameter("@附件", SqlDbType.NVarChar,50),
					new SqlParameter("@制单人", SqlDbType.NVarChar,50),
					new SqlParameter("@审核", SqlDbType.NVarChar,50),
					new SqlParameter("@记帐", SqlDbType.NVarChar,50),
					new SqlParameter("@财务主管", SqlDbType.NVarChar,50),
					new SqlParameter("@制单人ID", SqlDbType.Int,4),
					new SqlParameter("@审核ID", SqlDbType.Int,4),
					new SqlParameter("@记帐ID", SqlDbType.Int,4),
					new SqlParameter("@财务主管ID", SqlDbType.NVarChar,50),
					new SqlParameter("@制单日期", SqlDbType.NVarChar,50),
					new SqlParameter("@审核日期", SqlDbType.NVarChar,50),
					new SqlParameter("@记账日期", SqlDbType.NVarChar,50),
					new SqlParameter("@主管审核日期", SqlDbType.NVarChar,50),
					new SqlParameter("@帐户", SqlDbType.NVarChar,50),
					new SqlParameter("@帐户ID", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@TableID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.编号;
            parameters[1].Value = model.年;
            parameters[2].Value = model.月;
            parameters[3].Value = model.日;
            parameters[4].Value = model.时间;
            parameters[5].Value = model.附件;
            parameters[6].Value = model.制单人;
            parameters[7].Value = model.审核;
            parameters[8].Value = model.记帐;
            parameters[9].Value = model.财务主管;
            parameters[10].Value = model.制单人ID;
            parameters[11].Value = model.审核ID;
            parameters[12].Value = model.记帐ID;
            parameters[13].Value = model.财务主管ID;
            parameters[14].Value = model.制单日期;
            parameters[15].Value = model.审核日期;
            parameters[16].Value = model.记账日期;
            parameters[17].Value = model.主管审核日期;
            parameters[18].Value = model.帐户;
            parameters[19].Value = model.帐户ID;
            parameters[20].Value = model.TypeID;
            parameters[21].Value = model.TableID;
            parameters[22].Value = model.ID;

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
            strSql.Append("delete from CW_KJFL ");
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
            strSql.Append("delete from CW_KJFL ");
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
        public Hownet.Model.CW_KJFL GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,编号,年,月,日,时间,附件,制单人,审核,记帐,财务主管,制单人ID,审核ID,记帐ID,财务主管ID,制单日期,审核日期,记账日期,主管审核日期,帐户,帐户ID,TypeID,TableID from CW_KJFL ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.CW_KJFL model = new Hownet.Model.CW_KJFL();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.编号 = ds.Tables[0].Rows[0]["编号"].ToString();
                model.年 = ds.Tables[0].Rows[0]["年"].ToString();
                model.月 = ds.Tables[0].Rows[0]["月"].ToString();
                model.日 = ds.Tables[0].Rows[0]["日"].ToString();
                model.时间 = ds.Tables[0].Rows[0]["时间"].ToString();
                model.附件 = ds.Tables[0].Rows[0]["附件"].ToString();
                model.制单人 = ds.Tables[0].Rows[0]["制单人"].ToString();
                model.审核 = ds.Tables[0].Rows[0]["审核"].ToString();
                model.记帐 = ds.Tables[0].Rows[0]["记帐"].ToString();
                model.财务主管 = ds.Tables[0].Rows[0]["财务主管"].ToString();
                if (ds.Tables[0].Rows[0]["制单人ID"] != null && ds.Tables[0].Rows[0]["制单人ID"].ToString() != "")
                {
                    model.制单人ID = int.Parse(ds.Tables[0].Rows[0]["制单人ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["审核ID"] != null && ds.Tables[0].Rows[0]["审核ID"].ToString() != "")
                {
                    model.审核ID = int.Parse(ds.Tables[0].Rows[0]["审核ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["记帐ID"] != null && ds.Tables[0].Rows[0]["记帐ID"].ToString() != "")
                {
                    model.记帐ID = int.Parse(ds.Tables[0].Rows[0]["记帐ID"].ToString());
                }
                model.财务主管ID = ds.Tables[0].Rows[0]["财务主管ID"].ToString();
                model.制单日期 = ds.Tables[0].Rows[0]["制单日期"].ToString();
                model.审核日期 = ds.Tables[0].Rows[0]["审核日期"].ToString();
                model.记账日期 = ds.Tables[0].Rows[0]["记账日期"].ToString();
                model.主管审核日期 = ds.Tables[0].Rows[0]["主管审核日期"].ToString();
                model.帐户 = ds.Tables[0].Rows[0]["帐户"].ToString();
                if (ds.Tables[0].Rows[0]["帐户ID"] != null && ds.Tables[0].Rows[0]["帐户ID"].ToString() != "")
                {
                    model.帐户ID = int.Parse(ds.Tables[0].Rows[0]["帐户ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TableID"] != null && ds.Tables[0].Rows[0]["TableID"].ToString() != "")
                {
                    model.TableID = int.Parse(ds.Tables[0].Rows[0]["TableID"].ToString());
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
            strSql.Append("select  1 as A,ID,编号,年,月,日,时间,附件,制单人,制单日期,审核,审核日期,记帐,记账日期,财务主管,制单人ID,审核ID,记帐ID,财务主管ID,主管审核日期,帐户,帐户ID,TypeID,TableID ");
            strSql.Append(" FROM CW_KJFL ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by ID");
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
            strSql.Append(" ID,编号,年,月,日,时间,附件,制单人,审核,记帐,财务主管,制单人ID,审核ID,记帐ID,财务主管ID,制单日期,审核日期,记账日期,主管审核日期,帐户,帐户ID,TypeID,TableID ");
            strSql.Append(" FROM CW_KJFL ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetIDList(int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" Select ID From CW_KJFL where (TypeID=" + TypeID + ") Order by ID ");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int NewNum(DateTime dt,int TypeID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(CAST(编号 AS int)) AS Num FROM      CW_KJFL WHERE   (年 = @Year) AND (月 = @Month) And (TypeID=" + TypeID + ") ");
            SqlParameter[] sps = { new SqlParameter("@Year", dt.Year.ToString()), new SqlParameter("@Month", dt.Month.ToString().PadLeft(2, '0')) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 1;
            else
                return Convert.ToInt32(o) + 1;
        }
        public DataSet GetInfoList(DateTime dt1, DateTime dt2, int TypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   CW_KJFL.编号, CW_KJFL.时间, CW_KJFLInfo.项目名称, CW_KJFL.制单人, CW_KJFL.审核, CW_KJFL.记帐, ");
            strSql.Append(" CW_KJFLInfo.费用类别, CW_KJFLInfo.二级科目, CW_KJFL.TypeID, CW_KJFLInfo.款号, CW_KJFLInfo.金额, CW_KJFLInfo.手续费, CW_KJFL.ID ");
            strSql.Append(" FROM      CW_KJFL INNER JOIN CW_KJFLInfo ON CW_KJFL.ID = CW_KJFLInfo.MainID WHERE   (CW_KJFL.TypeID = "+TypeID+") ");
            strSql.Append(" And (CAST(年 + '-' + 月 + '-' + 日  AS datetime)>'" + dt1 + "') And (CAST(年 + '-' + 月 + '-' + 日  AS datetime)<'" + dt2 + "')");
            strSql.Append(" ORDER BY CW_KJFL.ID");
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
			parameters[0].Value = "CW_KJFL";
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

