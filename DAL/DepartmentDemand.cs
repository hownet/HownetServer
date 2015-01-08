using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
    /// <summary>
    /// 数据访问类DepartmentDemand。
    /// </summary>
    public class DepartmentDemand
    {
        public DepartmentDemand()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from DepartmentDemand");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            return DbHelperSQL.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.DepartmentDemand model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into DepartmentDemand(");
            strSql.Append("DepartmentTaskID,MaterielID,ColorID,ColorTwoID,Amount,NotAmount,SizeID,MeasureID,DepID,ColorOneID,MListID)");
            strSql.Append(" values (");
            strSql.Append("@DepartmentTaskID,@MaterielID,@ColorID,@ColorTwoID,@Amount,@NotAmount,@SizeID,@MeasureID,@DepID,@ColorOneID,@MListID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@DepartmentTaskID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4)};
            parameters[0].Value = model.DepartmentTaskID;
            parameters[1].Value = model.MaterielID;
            parameters[2].Value = model.ColorID;
            parameters[3].Value = model.ColorTwoID;
            parameters[4].Value = model.Amount;
            parameters[5].Value = model.NotAmount;
            parameters[6].Value = model.SizeID;
            parameters[7].Value = model.MeasureID;
            parameters[8].Value = model.DepID;
            parameters[9].Value = model.ColorOneID;
            parameters[10].Value = model.MListID;

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
        public void Update(Hownet.Model.DepartmentDemand model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DepartmentDemand set ");
            strSql.Append("DepartmentTaskID=@DepartmentTaskID,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("Amount=@Amount,");
            strSql.Append("NotAmount=@NotAmount,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("DepID=@DepID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("MListID=@MListID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentTaskID", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@Amount", SqlDbType.Decimal,9),
					new SqlParameter("@NotAmount", SqlDbType.Decimal,9),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@DepID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@MListID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.DepartmentTaskID;
            parameters[2].Value = model.MaterielID;
            parameters[3].Value = model.ColorID;
            parameters[4].Value = model.ColorTwoID;
            parameters[5].Value = model.Amount;
            parameters[6].Value = model.NotAmount;
            parameters[7].Value = model.SizeID;
            parameters[8].Value = model.MeasureID;
            parameters[9].Value = model.DepID;
            parameters[10].Value = model.ColorOneID;
            parameters[11].Value = model.MListID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DepartmentDemand ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.DepartmentDemand GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,DepartmentTaskID,MaterielID,ColorID,ColorTwoID,Amount,NotAmount,SizeID,MeasureID,DepID,ColorOneID,MListID from DepartmentDemand ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.DepartmentDemand model = new Hownet.Model.DepartmentDemand();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepartmentTaskID"].ToString() != "")
                {
                    model.DepartmentTaskID = int.Parse(ds.Tables[0].Rows[0]["DepartmentTaskID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Amount"].ToString() != "")
                {
                    model.Amount = decimal.Parse(ds.Tables[0].Rows[0]["Amount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NotAmount"].ToString() != "")
                {
                    model.NotAmount = decimal.Parse(ds.Tables[0].Rows[0]["NotAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepID"].ToString() != "")
                {
                    model.DepID = int.Parse(ds.Tables[0].Rows[0]["DepID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MListID"].ToString() != "")
                {
                    model.MListID = int.Parse(ds.Tables[0].Rows[0]["MListID"].ToString());
                }
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
            strSql.Append("select ID,DepID,ColorOneID,DepartmentTaskID,MaterielID,ColorID,ColorTwoID, ");
            strSql.Append(" Amount,NotAmount,NotAmount as NotAllotAmount, SizeID,MeasureID,MListID ");
            strSql.Append(" FROM DepartmentDemand ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 某部门任务的应配料数量
        /// </summary>
        /// <param name="DepotID"></param>
        /// <param name="DepTaskID"></param>
        /// <returns></returns>
        public DataSet GetPeiLiao(int DepotID, int DepTaskID)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT 0 as ID,DepartmentDemand.ID as DemandID, DepartmentDemand.MaterielID, DepartmentDemand.ColorID,0 as A, ");
            //strSql.Append(" DepartmentDemand.ColorTwoID, DepartmentDemand.Amount, DepartmentDemand.NotAmount,DepartmentDemand.NotAmount as Tem, ");
            //strSql.Append(" DepartmentDemand.SizeID, DepartmentDemand.MeasureID, DepartmentDemand.ColorOneID, ");
            //strSql.Append(" Repertory.Amount AS RepAmount,Repertory.ID as RepertoryID FROM DepartmentDemand LEFT OUTER JOIN (SELECT ID, Amount, ");
            //strSql.Append(" MaxAmount, MinAmount, NotAmount, DepartmentID, MaterielID, SizeID, ColorID, ColorOneID, ");
            //strSql.Append(" ColorTwoID, MeasureID, Price, InferiorAmount, BrandID FROM Repertory AS Repertory_1 ");
            //strSql.Append(" WHERE (DepartmentID = @depotID)) AS Repertory ON DepartmentDemand.MaterielID = ");
            //strSql.Append(" Repertory.MaterielID AND DepartmentDemand.ColorID = Repertory.ColorID AND ");
            //strSql.Append(" DepartmentDemand.ColorTwoID = Repertory.ColorTwoID AND DepartmentDemand.ColorOneID = ");
            //strSql.Append(" Repertory.ColorOneID AND DepartmentDemand.SizeID = Repertory.SizeID WHERE ");
            //strSql.Append(" (DepartmentDemand.DepID = 38) AND (DepartmentDemand.DepartmentTaskID = @TaskID)");
            strSql.Append(" SELECT 0 AS ID, ID AS DemandID, 0 AS A, MaterielID, ColorID, ColorOneID, ColorTwoID, ");
            strSql.Append(" Amount, SizeID, NotAmount AS Tem, MeasureID, MListID,(Amount - NotAmount) as PeiLiaoAmount , ");
            strSql.Append(" (Amount - NotAmount) as TemAmount,(SELECT ID FROM Repertory ");
            strSql.Append(" WHERE (MListID = DepartmentDemand.MListID) AND (DepartmentID = @DepotID)) ");
            strSql.Append(" AS RepertoryID, (SELECT Amount AS RepAmount FROM Repertory AS Repertory_1 ");
            strSql.Append(" WHERE (MListID = DepartmentDemand.MListID) AND (DepartmentID = @DepotID)) ");
            strSql.Append(" AS RepertoryID, NotAmount FROM DepartmentDemand WHERE (DepID = 38) AND (DepartmentTaskID = @TaskID)");
            SqlParameter[] sps = {new SqlParameter("@depotID",DepotID),new SqlParameter("@TaskID",DepTaskID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        /// <param name="t">真为审核配料，假为弃审</param>
        public void Update(Hownet.Model.DepartmentDemand model,bool t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DepartmentDemand set ");
            if (t)
                strSql.Append(" NotAmount=NotAmount- @NotAmount ");
            else
                strSql.Append(" NotAmount=NotAmount+ @NotAmount ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@NotAmount", SqlDbType.Real,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.Amount;

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
            parameters[0].Value = "DepartmentDemand";
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

