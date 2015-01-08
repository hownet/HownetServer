using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类MaterielList。
	/// </summary>
	public class MaterielList
	{
		public MaterielList()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "MaterielList"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MaterielList");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MaterielList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MaterielList(");
            strSql.Append("MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,SpecID)");
            strSql.Append(" values (");
            strSql.Append("@MaterielID,@ColorID,@ColorOneID,@ColorTwoID,@SizeID,@BrandID,@MeasureID,@SpecID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@SpecID", SqlDbType.Int,4)};
            parameters[0].Value = model.MaterielID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorOneID;
            parameters[3].Value = model.ColorTwoID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.BrandID;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.SpecID;

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
        public bool Update(Hownet.Model.MaterielList model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MaterielList set ");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("ColorOneID=@ColorOneID,");
            strSql.Append("ColorTwoID=@ColorTwoID,");
            strSql.Append("SizeID=@SizeID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("SpecID=@SpecID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@SpecID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.MaterielID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorOneID;
            parameters[3].Value = model.ColorTwoID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.BrandID;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.SpecID;
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
            strSql.Append("delete from MaterielList ");
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
            strSql.Append("delete from MaterielList ");
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
        public Hownet.Model.MaterielList GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,SpecID from MaterielList ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.MaterielList model = new Hownet.Model.MaterielList();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorOneID"] != null && ds.Tables[0].Rows[0]["ColorOneID"].ToString() != "")
                {
                    model.ColorOneID = int.Parse(ds.Tables[0].Rows[0]["ColorOneID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorTwoID"] != null && ds.Tables[0].Rows[0]["ColorTwoID"].ToString() != "")
                {
                    model.ColorTwoID = int.Parse(ds.Tables[0].Rows[0]["ColorTwoID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SizeID"] != null && ds.Tables[0].Rows[0]["SizeID"].ToString() != "")
                {
                    model.SizeID = int.Parse(ds.Tables[0].Rows[0]["SizeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SpecID"] != null && ds.Tables[0].Rows[0]["SpecID"].ToString() != "")
                {
                    model.SpecID = int.Parse(ds.Tables[0].Rows[0]["SpecID"].ToString());
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
            strSql.Append("select  1 as A,ID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,SpecID ");
            strSql.Append(" FROM MaterielList ");
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
            strSql.Append(" ID,MaterielID,ColorID,ColorOneID,ColorTwoID,SizeID,BrandID,MeasureID,SpecID ");
            strSql.Append(" FROM MaterielList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        public int GetID(Hownet.Model.MaterielList model)
        {
            StringBuilder strSql = new StringBuilder();
            int id = 0;
            strSql.Append(" SELECT ID FROM MaterielList WHERE (MaterielID = @MaterielID) AND (ColorID = @ColorID) AND  ");
            strSql.Append(" (ColorOneID = @ColorOneID) AND (ColorTwoID = @ColorTwoID) AND (SizeID = @SizeID) And (BrandID= @BrandID) And (MeasureID=@MeasureID) And (SpecID=@SpecID)");
            SqlParameter[] parameters = {
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@ColorOneID", SqlDbType.Int,4),
					new SqlParameter("@ColorTwoID", SqlDbType.Int,4),
					new SqlParameter("@SizeID", SqlDbType.Int,4),
                    new SqlParameter("@BrandID",SqlDbType.Int,4),
                    new SqlParameter("@MeasureID",SqlDbType.Int,4),
                    new SqlParameter("@SpecID",SqlDbType.Int,4)};
            parameters[0].Value = model.MaterielID;
            parameters[1].Value = model.ColorID;
            parameters[2].Value = model.ColorOneID;
            parameters[3].Value = model.ColorTwoID;
            parameters[4].Value = model.SizeID;
            parameters[5].Value = model.BrandID;
            parameters[6].Value = model.MeasureID;
            parameters[7].Value = model.SpecID;
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
                id = Add(model);
            else
                id = int.Parse(obj.ToString());
            return id;
        }
        /// <summary>
        /// 在物料分析时获取某一类的物料列表
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet GetFenXi(int AttributeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   '1' AS Stata, MaterielList.MaterielID, MaterielList.ColorID, MaterielList.ColorOneID, MaterielList.ColorTwoID, ");
            strSql.Append(" MaterielList.SizeID, MaterielList.BrandID, MaterielList.ID as MListID, Materiel_3.AttributeID, Materiel_3.MeasureID,Materiel_3.TypeID FROM ");
            strSql.Append(" MaterielList INNER JOIN Materiel AS Materiel_3 ON MaterielList.MaterielID = Materiel_3.ID  WHERE (Materiel_3.AttributeID = @AttributeID)");
            SqlParameter[] sps = { new SqlParameter("@AttributeID", AttributeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
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
			parameters[0].Value = "MaterielList";
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

