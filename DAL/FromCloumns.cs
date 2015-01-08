using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:FromCloumns
    /// </summary>
    public partial class FromCloumns
    {
        public FromCloumns()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from FromCloumns");
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
        public int Add(Hownet.Model.FromCloumns model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into FromCloumns(");
            strSql.Append("Fileds,CName,Width,IsShow,IsCanEdit,IsCanFilter,IsCanGroup,IsCanSort,IsFix,Remark,EName,UserID,MainID,IsMust,TypeID,OrderBy)");
            strSql.Append(" values (");
            strSql.Append("@Fileds,@CName,@Width,@IsShow,@IsCanEdit,@IsCanFilter,@IsCanGroup,@IsCanSort,@IsFix,@Remark,@EName,@UserID,@MainID,@IsMust,@TypeID,@OrderBy)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Fileds", SqlDbType.NVarChar,50),
					new SqlParameter("@CName", SqlDbType.NVarChar,50),
					new SqlParameter("@Width", SqlDbType.Int,4),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@IsCanEdit", SqlDbType.Bit,1),
					new SqlParameter("@IsCanFilter", SqlDbType.Bit,1),
					new SqlParameter("@IsCanGroup", SqlDbType.Bit,1),
					new SqlParameter("@IsCanSort", SqlDbType.Bit,1),
					new SqlParameter("@IsFix", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@EName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsMust", SqlDbType.Bit,1),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4)};
            parameters[0].Value = model.Fileds;
            parameters[1].Value = model.CName;
            parameters[2].Value = model.Width;
            parameters[3].Value = model.IsShow;
            parameters[4].Value = model.IsCanEdit;
            parameters[5].Value = model.IsCanFilter;
            parameters[6].Value = model.IsCanGroup;
            parameters[7].Value = model.IsCanSort;
            parameters[8].Value = model.IsFix;
            parameters[9].Value = model.Remark;
            parameters[10].Value = model.EName;
            parameters[11].Value = model.UserID;
            parameters[12].Value = model.MainID;
            parameters[13].Value = model.IsMust;
            parameters[14].Value = model.TypeID;
            parameters[15].Value = model.OrderBy;

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
        public bool Update(Hownet.Model.FromCloumns model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update FromCloumns set ");
            strSql.Append("Fileds=@Fileds,");
            strSql.Append("CName=@CName,");
            strSql.Append("Width=@Width,");
            strSql.Append("IsShow=@IsShow,");
            strSql.Append("IsCanEdit=@IsCanEdit,");
            strSql.Append("IsCanFilter=@IsCanFilter,");
            strSql.Append("IsCanGroup=@IsCanGroup,");
            strSql.Append("IsCanSort=@IsCanSort,");
            strSql.Append("IsFix=@IsFix,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("EName=@EName,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("MainID=@MainID,");
            strSql.Append("IsMust=@IsMust,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("OrderBy=@OrderBy");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Fileds", SqlDbType.NVarChar,50),
					new SqlParameter("@CName", SqlDbType.NVarChar,50),
					new SqlParameter("@Width", SqlDbType.Int,4),
					new SqlParameter("@IsShow", SqlDbType.Bit,1),
					new SqlParameter("@IsCanEdit", SqlDbType.Bit,1),
					new SqlParameter("@IsCanFilter", SqlDbType.Bit,1),
					new SqlParameter("@IsCanGroup", SqlDbType.Bit,1),
					new SqlParameter("@IsCanSort", SqlDbType.Bit,1),
					new SqlParameter("@IsFix", SqlDbType.Bit,1),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@EName", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsMust", SqlDbType.Bit,1),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@OrderBy", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Fileds;
            parameters[1].Value = model.CName;
            parameters[2].Value = model.Width;
            parameters[3].Value = model.IsShow;
            parameters[4].Value = model.IsCanEdit;
            parameters[5].Value = model.IsCanFilter;
            parameters[6].Value = model.IsCanGroup;
            parameters[7].Value = model.IsCanSort;
            parameters[8].Value = model.IsFix;
            parameters[9].Value = model.Remark;
            parameters[10].Value = model.EName;
            parameters[11].Value = model.UserID;
            parameters[12].Value = model.MainID;
            parameters[13].Value = model.IsMust;
            parameters[14].Value = model.TypeID;
            parameters[15].Value = model.OrderBy;
            parameters[16].Value = model.ID;

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
            strSql.Append("delete from FromCloumns ");
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
            strSql.Append("delete from FromCloumns ");
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
        public Hownet.Model.FromCloumns GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Fileds,CName,Width,IsShow,IsCanEdit,IsCanFilter,IsCanGroup,IsCanSort,IsFix,Remark,EName,UserID,MainID,IsMust,TypeID,OrderBy from FromCloumns ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.FromCloumns model = new Hownet.Model.FromCloumns();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Fileds = ds.Tables[0].Rows[0]["Fileds"].ToString();
                model.CName = ds.Tables[0].Rows[0]["CName"].ToString();
                if (ds.Tables[0].Rows[0]["Width"] != null && ds.Tables[0].Rows[0]["Width"].ToString() != "")
                {
                    model.Width = int.Parse(ds.Tables[0].Rows[0]["Width"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsShow"] != null && ds.Tables[0].Rows[0]["IsShow"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsShow"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsShow"].ToString().ToLower() == "true"))
                    {
                        model.IsShow = true;
                    }
                    else
                    {
                        model.IsShow = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCanEdit"] != null && ds.Tables[0].Rows[0]["IsCanEdit"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCanEdit"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCanEdit"].ToString().ToLower() == "true"))
                    {
                        model.IsCanEdit = true;
                    }
                    else
                    {
                        model.IsCanEdit = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCanFilter"] != null && ds.Tables[0].Rows[0]["IsCanFilter"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCanFilter"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCanFilter"].ToString().ToLower() == "true"))
                    {
                        model.IsCanFilter = true;
                    }
                    else
                    {
                        model.IsCanFilter = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCanGroup"] != null && ds.Tables[0].Rows[0]["IsCanGroup"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCanGroup"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCanGroup"].ToString().ToLower() == "true"))
                    {
                        model.IsCanGroup = true;
                    }
                    else
                    {
                        model.IsCanGroup = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCanSort"] != null && ds.Tables[0].Rows[0]["IsCanSort"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCanSort"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCanSort"].ToString().ToLower() == "true"))
                    {
                        model.IsCanSort = true;
                    }
                    else
                    {
                        model.IsCanSort = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsFix"] != null && ds.Tables[0].Rows[0]["IsFix"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsFix"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsFix"].ToString().ToLower() == "true"))
                    {
                        model.IsFix = true;
                    }
                    else
                    {
                        model.IsFix = false;
                    }
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                model.EName = ds.Tables[0].Rows[0]["EName"].ToString();
                if (ds.Tables[0].Rows[0]["UserID"] != null && ds.Tables[0].Rows[0]["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsMust"] != null && ds.Tables[0].Rows[0]["IsMust"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsMust"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsMust"].ToString().ToLower() == "true"))
                    {
                        model.IsMust = true;
                    }
                    else
                    {
                        model.IsMust = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OrderBy"] != null && ds.Tables[0].Rows[0]["OrderBy"].ToString() != "")
                {
                    model.OrderBy = int.Parse(ds.Tables[0].Rows[0]["OrderBy"].ToString());
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
            strSql.Append("select  1 as A,ID,Fileds,CName,Width,IsShow,IsCanEdit,IsCanFilter,IsCanGroup,IsCanSort,IsFix,Remark,EName,UserID,MainID,IsMust,TypeID,OrderBy ");
            strSql.Append(" FROM FromCloumns ");
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
            strSql.Append(" ID,Fileds,CName,Width,IsShow,IsCanEdit,IsCanFilter,IsCanGroup,IsCanSort,IsFix,Remark,EName,UserID,MainID,IsMust,TypeID,OrderBy ");
            strSql.Append(" FROM FromCloumns ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetFC(int MainID,int UserID)
        {
            DataSet ds = GetList("(TypeID=1) And (MainID=" + MainID + ") And (UserID=" + UserID * -1 + ")");
            if(ds.Tables[0].Rows.Count==0)
            {
                ds = GetList("(TypeID=1) And (MainID=" + MainID + ") And (UserID=" + UserID  + ") And (IsShow=1)");
                if(ds.Tables[0].Rows.Count==0)
                {
                    ds = GetList("(TypeID=1) And (MainID=" + MainID + ") And (UserID=0) And (IsShow=1)");
                }
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
            parameters[0].Value = "FromCloumns";
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

