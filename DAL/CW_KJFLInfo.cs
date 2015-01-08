using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:CW_KJFLInfo
	/// </summary>
	public partial class CW_KJFLInfo
	{
		public CW_KJFLInfo()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "CW_KJFLInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CW_KJFLInfo");
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
		public int Add(Hownet.Model.CW_KJFLInfo model)
		{
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into CW_KJFLInfo(");
            strSql.Append("MainID,项目名称,项目名称ID,款号,款号ID,客户订单编号,客户订单ID,客户,客户ID,费用类别,费用类别ID,金额,手续费,备注,报销人,报销人ID,二级科目,二级科目ID,报销部门,报销部门ID)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@项目名称,@项目名称ID,@款号,@款号ID,@客户订单编号,@客户订单ID,@客户,@客户ID,@费用类别,@费用类别ID,@金额,@手续费,@备注,@报销人,@报销人ID,@二级科目,@二级科目ID,@报销部门,@报销部门ID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@项目名称", SqlDbType.NVarChar,50),
					new SqlParameter("@项目名称ID", SqlDbType.Int,4),
					new SqlParameter("@款号", SqlDbType.NVarChar,50),
					new SqlParameter("@款号ID", SqlDbType.Int,4),
					new SqlParameter("@客户订单编号", SqlDbType.NVarChar,50),
					new SqlParameter("@客户订单ID", SqlDbType.Int,4),
					new SqlParameter("@客户", SqlDbType.NVarChar,50),
					new SqlParameter("@客户ID", SqlDbType.Int,4),
					new SqlParameter("@费用类别", SqlDbType.NVarChar,50),
					new SqlParameter("@费用类别ID", SqlDbType.Int,4),
					new SqlParameter("@金额", SqlDbType.Decimal,9),
					new SqlParameter("@手续费", SqlDbType.Decimal,9),
					new SqlParameter("@备注", SqlDbType.NVarChar,2000),
					new SqlParameter("@报销人", SqlDbType.NVarChar,50),
					new SqlParameter("@报销人ID", SqlDbType.Int,4),
					new SqlParameter("@二级科目", SqlDbType.NVarChar,50),
					new SqlParameter("@二级科目ID", SqlDbType.Int,4),
					new SqlParameter("@报销部门", SqlDbType.NVarChar,50),
					new SqlParameter("@报销部门ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.项目名称;
            parameters[2].Value = model.项目名称ID;
            parameters[3].Value = model.款号;
            parameters[4].Value = model.款号ID;
            parameters[5].Value = model.客户订单编号;
            parameters[6].Value = model.客户订单ID;
            parameters[7].Value = model.客户;
            parameters[8].Value = model.客户ID;
            parameters[9].Value = model.费用类别;
            parameters[10].Value = model.费用类别ID;
            parameters[11].Value = model.金额;
            parameters[12].Value = model.手续费;
            parameters[13].Value = model.备注;
            parameters[14].Value = model.报销人;
            parameters[15].Value = model.报销人ID;
            parameters[16].Value = model.二级科目;
            parameters[17].Value = model.二级科目ID;
            parameters[18].Value = model.报销部门;
            parameters[19].Value = model.报销部门ID;

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
        public bool Update(Hownet.Model.CW_KJFLInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update CW_KJFLInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("项目名称=@项目名称,");
            strSql.Append("项目名称ID=@项目名称ID,");
            strSql.Append("款号=@款号,");
            strSql.Append("款号ID=@款号ID,");
            strSql.Append("客户订单编号=@客户订单编号,");
            strSql.Append("客户订单ID=@客户订单ID,");
            strSql.Append("客户=@客户,");
            strSql.Append("客户ID=@客户ID,");
            strSql.Append("费用类别=@费用类别,");
            strSql.Append("费用类别ID=@费用类别ID,");
            strSql.Append("金额=@金额,");
            strSql.Append("手续费=@手续费,");
            strSql.Append("备注=@备注,");
            strSql.Append("报销人=@报销人,");
            strSql.Append("报销人ID=@报销人ID,");
            strSql.Append("二级科目=@二级科目,");
            strSql.Append("二级科目ID=@二级科目ID,");
            strSql.Append("报销部门=@报销部门,");
            strSql.Append("报销部门ID=@报销部门ID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@项目名称", SqlDbType.NVarChar,50),
					new SqlParameter("@项目名称ID", SqlDbType.Int,4),
					new SqlParameter("@款号", SqlDbType.NVarChar,50),
					new SqlParameter("@款号ID", SqlDbType.Int,4),
					new SqlParameter("@客户订单编号", SqlDbType.NVarChar,50),
					new SqlParameter("@客户订单ID", SqlDbType.Int,4),
					new SqlParameter("@客户", SqlDbType.NVarChar,50),
					new SqlParameter("@客户ID", SqlDbType.Int,4),
					new SqlParameter("@费用类别", SqlDbType.NVarChar,50),
					new SqlParameter("@费用类别ID", SqlDbType.Int,4),
					new SqlParameter("@金额", SqlDbType.Decimal,9),
					new SqlParameter("@手续费", SqlDbType.Decimal,9),
					new SqlParameter("@备注", SqlDbType.NVarChar,2000),
					new SqlParameter("@报销人", SqlDbType.NVarChar,50),
					new SqlParameter("@报销人ID", SqlDbType.Int,4),
					new SqlParameter("@二级科目", SqlDbType.NVarChar,50),
					new SqlParameter("@二级科目ID", SqlDbType.Int,4),
					new SqlParameter("@报销部门", SqlDbType.NVarChar,50),
					new SqlParameter("@报销部门ID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.项目名称;
            parameters[2].Value = model.项目名称ID;
            parameters[3].Value = model.款号;
            parameters[4].Value = model.款号ID;
            parameters[5].Value = model.客户订单编号;
            parameters[6].Value = model.客户订单ID;
            parameters[7].Value = model.客户;
            parameters[8].Value = model.客户ID;
            parameters[9].Value = model.费用类别;
            parameters[10].Value = model.费用类别ID;
            parameters[11].Value = model.金额;
            parameters[12].Value = model.手续费;
            parameters[13].Value = model.备注;
            parameters[14].Value = model.报销人;
            parameters[15].Value = model.报销人ID;
            parameters[16].Value = model.二级科目;
            parameters[17].Value = model.二级科目ID;
            parameters[18].Value = model.报销部门;
            parameters[19].Value = model.报销部门ID;
            parameters[20].Value = model.ID;

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
            strSql.Append("delete from CW_KJFLInfo ");
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
            strSql.Append("delete from CW_KJFLInfo ");
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
        public Hownet.Model.CW_KJFLInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,项目名称,项目名称ID,款号,款号ID,客户订单编号,客户订单ID,客户,客户ID,费用类别,费用类别ID,金额,手续费,备注,报销人,报销人ID,二级科目,二级科目ID,报销部门,报销部门ID from CW_KJFLInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.CW_KJFLInfo model = new Hownet.Model.CW_KJFLInfo();
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
                model.项目名称 = ds.Tables[0].Rows[0]["项目名称"].ToString();
                if (ds.Tables[0].Rows[0]["项目名称ID"] != null && ds.Tables[0].Rows[0]["项目名称ID"].ToString() != "")
                {
                    model.项目名称ID = int.Parse(ds.Tables[0].Rows[0]["项目名称ID"].ToString());
                }
                model.款号 = ds.Tables[0].Rows[0]["款号"].ToString();
                if (ds.Tables[0].Rows[0]["款号ID"] != null && ds.Tables[0].Rows[0]["款号ID"].ToString() != "")
                {
                    model.款号ID = int.Parse(ds.Tables[0].Rows[0]["款号ID"].ToString());
                }
                model.客户订单编号 = ds.Tables[0].Rows[0]["客户订单编号"].ToString();
                if (ds.Tables[0].Rows[0]["客户订单ID"] != null && ds.Tables[0].Rows[0]["客户订单ID"].ToString() != "")
                {
                    model.客户订单ID = int.Parse(ds.Tables[0].Rows[0]["客户订单ID"].ToString());
                }
                model.客户 = ds.Tables[0].Rows[0]["客户"].ToString();
                if (ds.Tables[0].Rows[0]["客户ID"] != null && ds.Tables[0].Rows[0]["客户ID"].ToString() != "")
                {
                    model.客户ID = int.Parse(ds.Tables[0].Rows[0]["客户ID"].ToString());
                }
                model.费用类别 = ds.Tables[0].Rows[0]["费用类别"].ToString();
                if (ds.Tables[0].Rows[0]["费用类别ID"] != null && ds.Tables[0].Rows[0]["费用类别ID"].ToString() != "")
                {
                    model.费用类别ID = int.Parse(ds.Tables[0].Rows[0]["费用类别ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["金额"] != null && ds.Tables[0].Rows[0]["金额"].ToString() != "")
                {
                    model.金额 = decimal.Parse(ds.Tables[0].Rows[0]["金额"].ToString());
                }
                if (ds.Tables[0].Rows[0]["手续费"] != null && ds.Tables[0].Rows[0]["手续费"].ToString() != "")
                {
                    model.手续费 = decimal.Parse(ds.Tables[0].Rows[0]["手续费"].ToString());
                }
                model.备注 = ds.Tables[0].Rows[0]["备注"].ToString();
                model.报销人 = ds.Tables[0].Rows[0]["报销人"].ToString();
                if (ds.Tables[0].Rows[0]["报销人ID"] != null && ds.Tables[0].Rows[0]["报销人ID"].ToString() != "")
                {
                    model.报销人ID = int.Parse(ds.Tables[0].Rows[0]["报销人ID"].ToString());
                }
                model.二级科目 = ds.Tables[0].Rows[0]["二级科目"].ToString();
                if (ds.Tables[0].Rows[0]["二级科目ID"] != null && ds.Tables[0].Rows[0]["二级科目ID"].ToString() != "")
                {
                    model.二级科目ID = int.Parse(ds.Tables[0].Rows[0]["二级科目ID"].ToString());
                }
                model.报销部门 = ds.Tables[0].Rows[0]["报销部门"].ToString();
                if (ds.Tables[0].Rows[0]["报销部门ID"] != null && ds.Tables[0].Rows[0]["报销部门ID"].ToString() != "")
                {
                    model.报销部门ID = int.Parse(ds.Tables[0].Rows[0]["报销部门ID"].ToString());
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
            strSql.Append("select  1 as A,ID,MainID,项目名称,项目名称ID,款号,款号ID,客户订单编号,客户订单ID,客户,客户ID,费用类别,费用类别ID,金额,手续费,备注,报销人,报销人ID,二级科目,二级科目ID,报销部门,报销部门ID ");
            strSql.Append(" FROM CW_KJFLInfo ");
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
            strSql.Append(" ID,MainID,项目名称,项目名称ID,款号,款号ID,客户订单编号,客户订单ID,客户,客户ID,费用类别,费用类别ID,金额,手续费,备注,报销人,报销人ID,二级科目,二级科目ID,报销部门,报销部门ID ");
            strSql.Append(" FROM CW_KJFLInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public void DeleteByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from CW_KJFLInfo ");
            strSql.Append(" where MainID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);

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
			parameters[0].Value = "CW_KJFLInfo";
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

