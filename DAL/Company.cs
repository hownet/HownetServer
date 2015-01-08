using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类Company。
    /// </summary>
    public class Company
    {
        public Company()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Company");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Company model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Company(");
            strSql.Append("Name,Sn,LinkMan,Mabile,Phone,Fax,Email,Country,Province,City,Address,Remark,TypeID,IsEnd,IsUse,LoanMoney,LoanDate,LastMoney,UserID,BankName,BankNO,BankUserName,MaxMoney,County,Weight)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Sn,@LinkMan,@Mabile,@Phone,@Fax,@Email,@Country,@Province,@City,@Address,@Remark,@TypeID,@IsEnd,@IsUse,@LoanMoney,@LoanDate,@LastMoney,@UserID,@BankName,@BankNO,@BankUserName,@MaxMoney,@County,@Weight)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@Sn", SqlDbType.NVarChar,8),
					new SqlParameter("@LinkMan", SqlDbType.NVarChar,8),
					new SqlParameter("@Mabile", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Country", SqlDbType.NVarChar,100),
					new SqlParameter("@Province", SqlDbType.NVarChar,100),
					new SqlParameter("@City", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,1000),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@LoanMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LoanDate", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@BankName", SqlDbType.NVarChar,50),
					new SqlParameter("@BankNO", SqlDbType.NVarChar,50),
					new SqlParameter("@BankUserName", SqlDbType.NVarChar,50),
					new SqlParameter("@MaxMoney", SqlDbType.Decimal,9),
					new SqlParameter("@County", SqlDbType.NVarChar,50),
					new SqlParameter("@Weight", SqlDbType.Decimal,9)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Sn;
            parameters[2].Value = model.LinkMan;
            parameters[3].Value = model.Mabile;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.Fax;
            parameters[6].Value = model.Email;
            parameters[7].Value = model.Country;
            parameters[8].Value = model.Province;
            parameters[9].Value = model.City;
            parameters[10].Value = model.Address;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.TypeID;
            parameters[13].Value = model.IsEnd;
            parameters[14].Value = model.IsUse;
            parameters[15].Value = model.LoanMoney;
            parameters[16].Value = model.LoanDate;
            parameters[17].Value = model.LastMoney;
            parameters[18].Value = model.UserID;
            parameters[19].Value = model.BankName;
            parameters[20].Value = model.BankNO;
            parameters[21].Value = model.BankUserName;
            parameters[22].Value = model.MaxMoney;
            parameters[23].Value = model.County;
            parameters[24].Value = model.Weight;

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
        public bool Update(Hownet.Model.Company model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Company set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Sn=@Sn,");
            strSql.Append("LinkMan=@LinkMan,");
            strSql.Append("Mabile=@Mabile,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("Fax=@Fax,");
            strSql.Append("Email=@Email,");
            strSql.Append("Country=@Country,");
            strSql.Append("Province=@Province,");
            strSql.Append("City=@City,");
            strSql.Append("Address=@Address,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("LoanMoney=@LoanMoney,");
            strSql.Append("LoanDate=@LoanDate,");
            strSql.Append("LastMoney=@LastMoney,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("BankName=@BankName,");
            strSql.Append("BankNO=@BankNO,");
            strSql.Append("BankUserName=@BankUserName,");
            strSql.Append("MaxMoney=@MaxMoney,");
            strSql.Append("County=@County,");
            strSql.Append("Weight=@Weight");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@Sn", SqlDbType.NVarChar,8),
					new SqlParameter("@LinkMan", SqlDbType.NVarChar,8),
					new SqlParameter("@Mabile", SqlDbType.NVarChar,50),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Fax", SqlDbType.NVarChar,50),
					new SqlParameter("@Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Country", SqlDbType.NVarChar,100),
					new SqlParameter("@Province", SqlDbType.NVarChar,100),
					new SqlParameter("@City", SqlDbType.NVarChar,100),
					new SqlParameter("@Address", SqlDbType.NVarChar,1000),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@LoanMoney", SqlDbType.Decimal,9),
					new SqlParameter("@LoanDate", SqlDbType.DateTime),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@BankName", SqlDbType.NVarChar,50),
					new SqlParameter("@BankNO", SqlDbType.NVarChar,50),
					new SqlParameter("@BankUserName", SqlDbType.NVarChar,50),
					new SqlParameter("@MaxMoney", SqlDbType.Decimal,9),
					new SqlParameter("@County", SqlDbType.NVarChar,50),
					new SqlParameter("@Weight", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Sn;
            parameters[2].Value = model.LinkMan;
            parameters[3].Value = model.Mabile;
            parameters[4].Value = model.Phone;
            parameters[5].Value = model.Fax;
            parameters[6].Value = model.Email;
            parameters[7].Value = model.Country;
            parameters[8].Value = model.Province;
            parameters[9].Value = model.City;
            parameters[10].Value = model.Address;
            parameters[11].Value = model.Remark;
            parameters[12].Value = model.TypeID;
            parameters[13].Value = model.IsEnd;
            parameters[14].Value = model.IsUse;
            parameters[15].Value = model.LoanMoney;
            parameters[16].Value = model.LoanDate;
            parameters[17].Value = model.LastMoney;
            parameters[18].Value = model.UserID;
            parameters[19].Value = model.BankName;
            parameters[20].Value = model.BankNO;
            parameters[21].Value = model.BankUserName;
            parameters[22].Value = model.MaxMoney;
            parameters[23].Value = model.County;
            parameters[24].Value = model.Weight;
            parameters[25].Value = model.ID;

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
            strSql.Append("delete from Company ");
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
            strSql.Append("delete from Company ");
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
        public Hownet.Model.Company GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,Sn,LinkMan,Mabile,Phone,Fax,Email,Country,Province,City,Address,Remark,TypeID,IsEnd,IsUse,LoanMoney,LoanDate,LastMoney,UserID,BankName,BankNO,BankUserName,MaxMoney,County,Weight from Company ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.Company model = new Hownet.Model.Company();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                model.Sn = ds.Tables[0].Rows[0]["Sn"].ToString();
                model.LinkMan = ds.Tables[0].Rows[0]["LinkMan"].ToString();
                model.Mabile = ds.Tables[0].Rows[0]["Mabile"].ToString();
                model.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                model.Fax = ds.Tables[0].Rows[0]["Fax"].ToString();
                model.Email = ds.Tables[0].Rows[0]["Email"].ToString();
                model.Country = ds.Tables[0].Rows[0]["Country"].ToString();
                model.Province = ds.Tables[0].Rows[0]["Province"].ToString();
                model.City = ds.Tables[0].Rows[0]["City"].ToString();
                model.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"] != null && ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsUse"] != null && ds.Tables[0].Rows[0]["IsUse"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsUse"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsUse"].ToString().ToLower() == "true"))
                    {
                        model.IsUse = true;
                    }
                    else
                    {
                        model.IsUse = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["LoanMoney"] != null && ds.Tables[0].Rows[0]["LoanMoney"].ToString() != "")
                {
                    model.LoanMoney = decimal.Parse(ds.Tables[0].Rows[0]["LoanMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LoanDate"] != null && ds.Tables[0].Rows[0]["LoanDate"].ToString() != "")
                {
                    model.LoanDate = DateTime.Parse(ds.Tables[0].Rows[0]["LoanDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastMoney"] != null && ds.Tables[0].Rows[0]["LastMoney"].ToString() != "")
                {
                    model.LastMoney = decimal.Parse(ds.Tables[0].Rows[0]["LastMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserID"] != null && ds.Tables[0].Rows[0]["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                }
                model.BankName = ds.Tables[0].Rows[0]["BankName"].ToString();
                model.BankNO = ds.Tables[0].Rows[0]["BankNO"].ToString();
                model.BankUserName = ds.Tables[0].Rows[0]["BankUserName"].ToString();
                if (ds.Tables[0].Rows[0]["MaxMoney"] != null && ds.Tables[0].Rows[0]["MaxMoney"].ToString() != "")
                {
                    model.MaxMoney = decimal.Parse(ds.Tables[0].Rows[0]["MaxMoney"].ToString());
                }
                model.County = ds.Tables[0].Rows[0]["County"].ToString();
                if (ds.Tables[0].Rows[0]["Weight"] != null && ds.Tables[0].Rows[0]["Weight"].ToString() != "")
                {
                    model.Weight = decimal.Parse(ds.Tables[0].Rows[0]["Weight"].ToString());
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
            strSql.Append("select  1 as A,ID,Name,Sn,LinkMan,Mabile,Phone,Fax,Email,Country,Province,City,Address,Remark,TypeID,IsEnd,IsUse,LoanMoney,LoanDate,LastMoney,UserID,BankName,BankNO,BankUserName,MaxMoney,County,Weight ");
            strSql.Append(" FROM Company ");
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
            strSql.Append(" ID,Name,Sn,LinkMan,Mabile,Phone,Fax,Email,Country,Province,City,Address,Remark,TypeID,IsEnd,IsUse,LoanMoney,LoanDate,LastMoney,UserID,BankName,BankNO,BankUserName,MaxMoney,County,Weight ");
            strSql.Append(" FROM Company ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetListByUserID(int UserID, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 1 as A,ID,Name,Sn,LinkMan,Mabile,Phone,Fax,Email,Country,Province,City,County,Address,Remark,TypeID,IsEnd,IsUse,LoanMoney,LoanDate,LastMoney,UserID,BankName,BankNO,BankUserName,MaxMoney,County,Weight ");
            strSql.Append(" FROM Company ");
            if (UserID > 0)
            {
                strSql.Append(" where (UserID=" + UserID + ")");
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" And " + strWhere);
                }
            }
            else
            {
                if (strWhere.Trim() != "")
                {
                    strSql.Append(" where " + strWhere);
                }
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        public void UpLastMoney(int CompanyID, decimal Money)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Company set ");
            strSql.Append("LastMoney=@LastMoney");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@LastMoney", SqlDbType.Decimal,9)};
            parameters[0].Value = CompanyID;
            parameters[1].Value = Money;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetExpressReport()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Name as 名称,LinkMan as 联系人,Mabile as 手机,Phone as 电话,Province as 省,City as 市,County as 县, Address as 地址 FROM Company Where (IsEnd=0)");
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
            parameters[0].Value = "Company";
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

