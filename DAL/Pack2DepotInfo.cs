using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类:Pack2DepotInfo
    /// </summary>
    public partial class Pack2DepotInfo
    {
        public Pack2DepotInfo()
        { }
        #region  Method
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Pack2DepotInfo");
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
        public int Add(Hownet.Model.Pack2DepotInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Pack2DepotInfo(");
            strSql.Append("MainID,TaskID,MaterielID,ColorID,SizeID,ColorOneID,ColorTwoID,MListID,PackAmount,NowAmount,Remark,BrandID,MeasureID,PackAmountID,DepotMeasureID,DepotBrandID,DepotInfoID)");
            strSql.Append(" values (");
            strSql.Append("@MainID,@TaskID,@MaterielID,@ColorID,@SizeID,@ColorOneID,@ColorTwoID,@MListID,@PackAmount,@NowAmount,@Remark,@BrandID,@MeasureID,@PackAmountID,@DepotMeasureID,@DepotBrandID,@DepotInfoID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@PackAmount", SqlDbType.Real,4),
					new SqlParameter("@NowAmount", SqlDbType.Real,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@PackAmountID", SqlDbType.Int,4),
					new SqlParameter("@DepotMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepotBrandID", SqlDbType.Int,4),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TaskID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.ColorOneID;
            parameters[6].Value = model.ColorTwoID;
            parameters[7].Value = model.MListID;
            parameters[8].Value = model.PackAmount;
            parameters[9].Value = model.NowAmount;
            parameters[10].Value = model.Remark;
            parameters[11].Value = model.BrandID;
            parameters[12].Value = model.MeasureID;
            parameters[13].Value = model.PackAmountID;
            parameters[14].Value = model.DepotMeasureID;
            parameters[15].Value = model.DepotBrandID;
            parameters[16].Value = model.DepotInfoID;

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
        public bool Update(Hownet.Model.Pack2DepotInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Pack2DepotInfo set ");
            strSql.Append("MainID=@MainID,");
            strSql.Append("TaskID=@TaskID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("MListID=@MListID,");
            strSql.Append("PackAmount=@PackAmount,");
            strSql.Append("NowAmount=@NowAmount,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("PackAmountID=@PackAmountID,");
            strSql.Append("DepotMeasureID=@DepotMeasureID,");
            strSql.Append("DepotBrandID=@DepotBrandID,");
            strSql.Append("DepotInfoID=@DepotInfoID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@TaskID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4),
					new SqlParameter("@PackAmount", SqlDbType.Real,4),
					new SqlParameter("@NowAmount", SqlDbType.Real,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,4000),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@PackAmountID", SqlDbType.Int,4),
					new SqlParameter("@DepotMeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepotBrandID", SqlDbType.Int,4),
					new SqlParameter("@DepotInfoID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MainID;
            parameters[1].Value = model.TaskID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.ColorOneID;
            parameters[6].Value = model.ColorTwoID;
            parameters[7].Value = model.MListID;
            parameters[8].Value = model.PackAmount;
            parameters[9].Value = model.NowAmount;
            parameters[10].Value = model.Remark;
            parameters[11].Value = model.BrandID;
            parameters[12].Value = model.MeasureID;
            parameters[13].Value = model.PackAmountID;
            parameters[14].Value = model.DepotMeasureID;
            parameters[15].Value = model.DepotBrandID;
            parameters[16].Value = model.DepotInfoID;
            parameters[17].Value = model.ID;

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
            strSql.Append("delete from Pack2DepotInfo ");
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
            strSql.Append("delete from Pack2DepotInfo ");
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
        public Hownet.Model.Pack2DepotInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MainID,TaskID,MaterielID,ColorID,SizeID,ColorOneID,ColorTwoID,MListID,PackAmount,NowAmount,Remark,BrandID,MeasureID,PackAmountID,DepotMeasureID,DepotBrandID,DepotInfoID from Pack2DepotInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.Pack2DepotInfo model = new Hownet.Model.Pack2DepotInfo();
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
                if (ds.Tables[0].Rows[0]["TaskID"] != null && ds.Tables[0].Rows[0]["TaskID"].ToString() != "")
                {
                    model.TaskID = int.Parse(ds.Tables[0].Rows[0]["TaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"] != null && ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorOneID"] != null && ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"] != null && ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"] != null && ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PackAmount"] != null && ds.Tables[0].Rows[0]["PackAmount"].ToString() != "")
                {
                    model.PackAmount = decimal.Parse(ds.Tables[0].Rows[0]["PackAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NowAmount"] != null && ds.Tables[0].Rows[0]["NowAmount"].ToString() != "")
                {
                    model.NowAmount = decimal.Parse(ds.Tables[0].Rows[0]["NowAmount"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PackAmountID"] != null && ds.Tables[0].Rows[0]["PackAmountID"].ToString() != "")
                {
                    model.PackAmountID = int.Parse(ds.Tables[0].Rows[0]["PackAmountID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotMeasureID"] != null && ds.Tables[0].Rows[0]["DepotMeasureID"].ToString() != "")
                {
                    model.DepotMeasureID = int.Parse(ds.Tables[0].Rows[0]["DepotMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotBrandID"] != null && ds.Tables[0].Rows[0]["DepotBrandID"].ToString() != "")
                {
                    model.DepotBrandID = int.Parse(ds.Tables[0].Rows[0]["DepotBrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepotInfoID"] != null && ds.Tables[0].Rows[0]["DepotInfoID"].ToString() != "")
                {
                    model.DepotInfoID = int.Parse(ds.Tables[0].Rows[0]["DepotInfoID"].ToString());
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
            strSql.Append("select  1 as A,ID,MainID,TaskID,MaterielID,ColorID,SizeID,ColorOneID,ColorTwoID,MListID,PackAmount,NowAmount,Remark,BrandID,MeasureID,PackAmountID,DepotMeasureID,DepotBrandID,DepotInfoID ");
            strSql.Append(" FROM Pack2DepotInfo ");
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
            strSql.Append(" ID,MainID,TaskID,MaterielID,ColorID,SizeID,ColorOneID,ColorTwoID,MListID,PackAmount,NowAmount,Remark,BrandID,MeasureID,PackAmountID,DepotMeasureID,DepotBrandID,DepotInfoID ");
            strSql.Append(" FROM Pack2DepotInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByMainID(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Pack2DepotInfo ");
            strSql.Append(" where (MainID = " + MainID + ")  ");
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
            parameters[0].Value = "Pack2DepotInfo";
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

