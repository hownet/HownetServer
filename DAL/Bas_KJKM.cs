using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:Bas_KJKM
	/// </summary>
	public partial class Bas_KJKM
	{
		public Bas_KJKM()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Bas_KJKM"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Bas_KJKM");
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
		public int Add(Hownet.Model.Bas_KJKM model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Bas_KJKM(");
            strSql.Append("Orders,Num,Name,ParentID,Remark,Money,CompanyID,DebitMoney,CreditMoney,MoneyType)");
            strSql.Append(" values (");
            strSql.Append("@Orders,@Num,@Name,@ParentID,@Remark,@Money,@CompanyID,@DebitMoney,@CreditMoney,@MoneyType)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DebitMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreditMoney", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyType", SqlDbType.Int,4)};
            parameters[0].Value = model.Orders;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.ParentID;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.Money;
            parameters[6].Value = model.CompanyID;
            parameters[7].Value = model.DebitMoney;
            parameters[8].Value = model.CreditMoney;
            parameters[9].Value = model.MoneyType;

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
        public bool Update(Hownet.Model.Bas_KJKM model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Bas_KJKM set ");
            strSql.Append("Orders=@Orders,");
            strSql.Append("Num=@Num,");
            strSql.Append("Name=@Name,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Money=@Money,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("DebitMoney=@DebitMoney,");
            strSql.Append("CreditMoney=@CreditMoney,");
            strSql.Append("MoneyType=@MoneyType");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Money", SqlDbType.Decimal,9),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@DebitMoney", SqlDbType.Decimal,9),
					new SqlParameter("@CreditMoney", SqlDbType.Decimal,9),
					new SqlParameter("@MoneyType", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Orders;
            parameters[1].Value = model.Num;
            parameters[2].Value = model.Name;
            parameters[3].Value = model.ParentID;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.Money;
            parameters[6].Value = model.CompanyID;
            parameters[7].Value = model.DebitMoney;
            parameters[8].Value = model.CreditMoney;
            parameters[9].Value = model.MoneyType;
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
            strSql.Append("delete from Bas_KJKM ");
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
            strSql.Append("delete from Bas_KJKM ");
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
        public Hownet.Model.Bas_KJKM GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Orders,Num,Name,ParentID,Remark,Money,CompanyID,DebitMoney,CreditMoney,MoneyType from Bas_KJKM ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.Bas_KJKM model = new Hownet.Model.Bas_KJKM();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Orders"] != null && ds.Tables[0].Rows[0]["Orders"].ToString() != "")
                {
                    model.Orders = int.Parse(ds.Tables[0].Rows[0]["Orders"].ToString());
                }
                model.Num = ds.Tables[0].Rows[0]["Num"].ToString();
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["ParentID"] != null && ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["Money"] != null && ds.Tables[0].Rows[0]["Money"].ToString() != "")
                {
                    model.Money = decimal.Parse(ds.Tables[0].Rows[0]["Money"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DebitMoney"] != null && ds.Tables[0].Rows[0]["DebitMoney"].ToString() != "")
                {
                    model.DebitMoney = decimal.Parse(ds.Tables[0].Rows[0]["DebitMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CreditMoney"] != null && ds.Tables[0].Rows[0]["CreditMoney"].ToString() != "")
                {
                    model.CreditMoney = decimal.Parse(ds.Tables[0].Rows[0]["CreditMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MoneyType"] != null && ds.Tables[0].Rows[0]["MoneyType"].ToString() != "")
                {
                    model.MoneyType = int.Parse(ds.Tables[0].Rows[0]["MoneyType"].ToString());
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
            strSql.Append("select  1 as A,ID,Orders,Num,Name,ParentID,Remark,Money,CompanyID,DebitMoney,CreditMoney,MoneyType ");
            strSql.Append(" FROM Bas_KJKM ");
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
            strSql.Append(" ID,Orders,Num,Name,ParentID,Remark,Money,CompanyID,DebitMoney,CreditMoney,MoneyType ");
            strSql.Append(" FROM Bas_KJKM ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetTreeList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  1 as A,ID,Orders,cast( Num as int ) as Num,Num as Nums,Name,cast( ParentID as int) as ParentID ,Remark ,Money,CompanyID,DebitMoney,CreditMoney,MoneyType ");
            strSql.Append(" FROM Bas_KJKM ORDER BY Orders");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetFilterList(string s)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select  Num ");
                strSql.Append(" FROM Bas_KJKM Where (Name Like '" + s + "') ");
                DataTable dt = DbHelperSQL.Query(strSql.ToString()).Tables[0];
                DataSet ds = new DataSet();
                if (dt.Rows.Count > 0)
                {
                    strSql.Remove(0, strSql.Length);
                    strSql.Append("select  1 as A,ID,Orders,cast( Num as int ) as Num,Num as Nums,Name,cast( ParentID as int) as ParentID,Money,CompanyID,DebitMoney,CreditMoney,MoneyType ");
                    strSql.Append(" FROM Bas_KJKM Where 1=2");
                    ds = DbHelperSQL.Query(strSql.ToString());
                    DataTable dtT = ds.Tables[0].Clone();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        strSql.Remove(0, strSql.Length);
                        strSql.Append(" with ");
                        strSql.Append(" RTU1 as(  select 1 as A, ID ,Orders,cast( Num as int ) as Num,Num as Nums,Name,cast( ParentID as int) as ParentID,Money,CompanyID,DebitMoney,CreditMoney,MoneyType from Bas_KJKM ),   ");
                        strSql.Append(" RTU2 as(  select * from RTU1 where Num='" + dt.Rows[i][0] + "'  union all  select RTU1.* from RTU2 inner join RTU1    ");
                        strSql.Append(" on RTU2.ParentID=RTU1.Num  )      select * from RTU2 ");
                        DataTable dtTem = DbHelperSQL.Query(strSql.ToString()).Tables[0];
                        if (dtTem.Rows.Count > 0)
                        {
                            for (int j = 0; j < dtTem.Rows.Count; j++)
                            {
                                dtT.Rows.Add(dtTem.Rows[j].ItemArray);
                            }
                        }
                    }
                    if (dtT.Rows.Count > 0)
                    {
                        bool t = false;
                        for (int i = 0; i < dtT.Rows.Count; i++)
                        {
                            t = false;
                            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                            {
                                if (dtT.Rows[i]["Num"].ToString() == ds.Tables[0].Rows[j]["Num"].ToString())
                                {
                                    t = true;
                                    break;
                                }
                            }
                            if (!t)
                            {
                                ds.Tables[0].Rows.Add(dtT.Rows[i].ItemArray);
                            }
                        }
                    }
                }

                return ds;
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public DataSet GetMoneyKJKM()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID, Name,Money FROM      Bas_KJKM WHERE   (Num = N'1001') UNION ALL SELECT   ID, Name,Money FROM      Bas_KJKM AS Bas_KJKM_1 WHERE   (ParentID = 1002)");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int GetMaxNum(int ParentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   MAX(Num) AS Num FROM      Bas_KJKM WHERE   (ParentID = " + ParentID + ")");
            object o = DbHelperSQL.GetSingle(strSql.ToString());
            if (o != null)
                return Convert.ToInt32(o) + 1;
            else
                return Convert.ToInt32(ParentID.ToString() + "001");
        }
        public int GetMaxOrders()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   MAX(Orders) AS Expr1 FROM      Bas_KJKM WHERE   (Orders < 10000)  ");
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));
        }
        public object UpMoney(int ParentID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(Money) AS Expr1 FROM      Bas_KJKM WHERE   (ParentID = "+ParentID+")");
            object o = DbHelperSQL.GetSingle(strSql.ToString());
            return o;
        }
        public DataTable GetParent()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT     ParentID AS Expr1 FROM         Bas_KJKM GROUP BY ParentID HAVING      (ParentID > 1000)");
            DataTable dt = DbHelperSQL.Query(strSql.ToString()).Tables[0];
            return dt;
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
            parameters[0].Value = "Bas_KJKM";
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

