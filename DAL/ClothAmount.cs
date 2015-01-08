using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:ClothAmount
    /// </summary>
    public partial class ClothAmount
    {
        public ClothAmount()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ClothAmount");
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
        public int Add(Hownet.Model.ClothAmount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ClothAmount(");
            strSql.Append("MainID,BoxNum,ColorID,ColorName,BrandID,BrandName,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12,Size13,Size14,Size15,SumAmount)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@BoxNum,@ColorID,@ColorName,@BrandID,@BrandName,@Size1,@Size2,@Size3,@Size4,@Size5,@Size6,@Size7,@Size8,@Size9,@Size10,@Size11,@Size12,@Size13,@Size14,@Size15,@SumAmount)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,50),
					new SqlParameter("@Size1", SqlDbType.NVarChar,50),
					new SqlParameter("@Size2", SqlDbType.NVarChar,50),
					new SqlParameter("@Size3", SqlDbType.NVarChar,50),
					new SqlParameter("@Size4", SqlDbType.NVarChar,50),
					new SqlParameter("@Size5", SqlDbType.NVarChar,50),
					new SqlParameter("@Size6", SqlDbType.NVarChar,50),
					new SqlParameter("@Size7", SqlDbType.NVarChar,50),
					new SqlParameter("@Size8", SqlDbType.NVarChar,50),
					new SqlParameter("@Size9", SqlDbType.NVarChar,50),
					new SqlParameter("@Size10", SqlDbType.NVarChar,50),
					new SqlParameter("@Size11", SqlDbType.NVarChar,50),
					new SqlParameter("@Size12", SqlDbType.NVarChar,50),
					new SqlParameter("@Size13", SqlDbType.NVarChar,50),
					new SqlParameter("@Size14", SqlDbType.NVarChar,50),
					new SqlParameter("@Size15", SqlDbType.NVarChar,50),
					new SqlParameter("@SumAmount", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.BoxNum;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorName;
            parameters[4].Value = model.BrandID;
            parameters[5].Value = model.BrandName;
            parameters[6].Value = model.Size1;
            parameters[7].Value = model.Size2;
            parameters[8].Value = model.Size3;
            parameters[9].Value = model.Size4;
            parameters[10].Value = model.Size5;
            parameters[11].Value = model.Size6;
            parameters[12].Value = model.Size7;
            parameters[13].Value = model.Size8;
            parameters[14].Value = model.Size9;
            parameters[15].Value = model.Size10;
            parameters[16].Value = model.Size11;
            parameters[17].Value = model.Size12;
            parameters[18].Value = model.Size13;
            parameters[19].Value = model.Size14;
            parameters[20].Value = model.Size15;
            parameters[21].Value = model.SumAmount;

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
        public bool Update(Hownet.Model.ClothAmount model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ClothAmount set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("BoxNum=@BoxNum,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorName=@ColorName,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("BrandName=@BrandName,");
            strSql.Append("Size1=@Size1,");
            strSql.Append("Size2=@Size2,");
            strSql.Append("Size3=@Size3,");
            strSql.Append("Size4=@Size4,");
            strSql.Append("Size5=@Size5,");
            strSql.Append("Size6=@Size6,");
            strSql.Append("Size7=@Size7,");
            strSql.Append("Size8=@Size8,");
            strSql.Append("Size9=@Size9,");
            strSql.Append("Size10=@Size10,");
            strSql.Append("Size11=@Size11,");
            strSql.Append("Size12=@Size12,");
            strSql.Append("Size13=@Size13,");
            strSql.Append("Size14=@Size14,");
            strSql.Append("Size15=@Size15,");
            strSql.Append("SumAmount=@SumAmount");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@BoxNum", SqlDbType.NVarChar,50),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorName", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,50),
					new SqlParameter("@Size1", SqlDbType.NVarChar,50),
					new SqlParameter("@Size2", SqlDbType.NVarChar,50),
					new SqlParameter("@Size3", SqlDbType.NVarChar,50),
					new SqlParameter("@Size4", SqlDbType.NVarChar,50),
					new SqlParameter("@Size5", SqlDbType.NVarChar,50),
					new SqlParameter("@Size6", SqlDbType.NVarChar,50),
					new SqlParameter("@Size7", SqlDbType.NVarChar,50),
					new SqlParameter("@Size8", SqlDbType.NVarChar,50),
					new SqlParameter("@Size9", SqlDbType.NVarChar,50),
					new SqlParameter("@Size10", SqlDbType.NVarChar,50),
					new SqlParameter("@Size11", SqlDbType.NVarChar,50),
					new SqlParameter("@Size12", SqlDbType.NVarChar,50),
					new SqlParameter("@Size13", SqlDbType.NVarChar,50),
					new SqlParameter("@Size14", SqlDbType.NVarChar,50),
					new SqlParameter("@Size15", SqlDbType.NVarChar,50),
					new SqlParameter("@SumAmount", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.BoxNum;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorName;
            parameters[4].Value = model.BrandID;
            parameters[5].Value = model.BrandName;
            parameters[6].Value = model.Size1;
            parameters[7].Value = model.Size2;
            parameters[8].Value = model.Size3;
            parameters[9].Value = model.Size4;
            parameters[10].Value = model.Size5;
            parameters[11].Value = model.Size6;
            parameters[12].Value = model.Size7;
            parameters[13].Value = model.Size8;
            parameters[14].Value = model.Size9;
            parameters[15].Value = model.Size10;
            parameters[16].Value = model.Size11;
            parameters[17].Value = model.Size12;
            parameters[18].Value = model.Size13;
            parameters[19].Value = model.Size14;
            parameters[20].Value = model.Size15;
            parameters[21].Value = model.SumAmount;
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
            strSql.Append("delete from ClothAmount ");
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
            strSql.Append("delete from ClothAmount ");
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
        public Hownet.Model.ClothAmount GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,BoxNum,ColorID,ColorName,BrandID,BrandName,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12,Size13,Size14,Size15,SumAmount from ClothAmount ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.ClothAmount model = new Hownet.Model.ClothAmount();
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
                model.BoxNum = ds.Tables[0].Rows[0]["BoxNum"].ToString();
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                model.ColorName = ds.Tables[0].Rows[0]["ColorName"].ToString();
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                model.BrandName = ds.Tables[0].Rows[0]["BrandName"].ToString();
                model.Size1 = ds.Tables[0].Rows[0]["Size1"].ToString();
                model.Size2 = ds.Tables[0].Rows[0]["Size2"].ToString();
                model.Size3 = ds.Tables[0].Rows[0]["Size3"].ToString();
                model.Size4 = ds.Tables[0].Rows[0]["Size4"].ToString();
                model.Size5 = ds.Tables[0].Rows[0]["Size5"].ToString();
                model.Size6 = ds.Tables[0].Rows[0]["Size6"].ToString();
                model.Size7 = ds.Tables[0].Rows[0]["Size7"].ToString();
                model.Size8 = ds.Tables[0].Rows[0]["Size8"].ToString();
                model.Size9 = ds.Tables[0].Rows[0]["Size9"].ToString();
                model.Size10 = ds.Tables[0].Rows[0]["Size10"].ToString();
                model.Size11 = ds.Tables[0].Rows[0]["Size11"].ToString();
                model.Size12 = ds.Tables[0].Rows[0]["Size12"].ToString();
                model.Size13 = ds.Tables[0].Rows[0]["Size13"].ToString();
                model.Size14 = ds.Tables[0].Rows[0]["Size14"].ToString();
                model.Size15 = ds.Tables[0].Rows[0]["Size15"].ToString();
                model.SumAmount = ds.Tables[0].Rows[0]["SumAmount"].ToString();
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
            strSql.Append("select  1 as A,ID,MainID,BoxNum,ColorID,ColorName,BrandID,BrandName,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12,Size13,Size14,Size15,SumAmount ");
            strSql.Append(" FROM ClothAmount ");
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
            strSql.Append(" ID,MainID,BoxNum,ColorID,ColorName,BrandID,BrandName,Size1,Size2,Size3,Size4,Size5,Size6,Size7,Size8,Size9,Size10,Size11,Size12,Size13,Size14,Size15,SumAmount ");
            strSql.Append(" FROM ClothAmount ");
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
            parameters[0].Value = "ClothAmount";
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

