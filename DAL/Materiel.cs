using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Materiel。
	/// </summary>
	public class Materiel
	{
		public Materiel()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Materiel"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Materiel");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Materiel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Materiel(");
            strSql.Append("Name,TypeID,MeasureID,Sn,Remark,AttributeID,SecondMeasureID,Conversion,IsEnd,IsUse,Image,Designers,SelectSpec,TiaoMaH,ChengBengJ,LingShouJia,YiJiDaiLiJia,ErJiDaiLiJia,SanJiDaiLiJia)");
            strSql.Append(" values (");
            strSql.Append("@Name,@TypeID,@MeasureID,@Sn,@Remark,@AttributeID,@SecondMeasureID,@Conversion,@IsEnd,@IsUse,@Image,@Designers,@SelectSpec,@TiaoMaH,@ChengBengJ,@LingShouJia,@YiJiDaiLiJia,@ErJiDaiLiJia,@SanJiDaiLiJia)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@AttributeID", SqlDbType.Int,4),
					new SqlParameter("@SecondMeasureID", SqlDbType.Int,4),
					new SqlParameter("@Conversion", SqlDbType.Decimal,9),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Image", SqlDbType.NVarChar,50),
					new SqlParameter("@Designers", SqlDbType.Int,4),
					new SqlParameter("@SelectSpec", SqlDbType.Int,4),
					new SqlParameter("@TiaoMaH", SqlDbType.NVarChar,50),
					new SqlParameter("@ChengBengJ", SqlDbType.Decimal,9),
					new SqlParameter("@LingShouJia", SqlDbType.Decimal,9),
					new SqlParameter("@YiJiDaiLiJia", SqlDbType.Decimal,9),
					new SqlParameter("@ErJiDaiLiJia", SqlDbType.Decimal,9),
					new SqlParameter("@SanJiDaiLiJia", SqlDbType.Decimal,9)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.MeasureID;
            parameters[3].Value = model.Sn;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.AttributeID;
            parameters[6].Value = model.SecondMeasureID;
            parameters[7].Value = model.Conversion;
            parameters[8].Value = model.IsEnd;
            parameters[9].Value = model.IsUse;
            parameters[10].Value = model.Image;
            parameters[11].Value = model.Designers;
            parameters[12].Value = model.SelectSpec;
            parameters[13].Value = model.TiaoMaH;
            parameters[14].Value = model.ChengBengJ;
            parameters[15].Value = model.LingShouJia;
            parameters[16].Value = model.YiJiDaiLiJia;
            parameters[17].Value = model.ErJiDaiLiJia;
            parameters[18].Value = model.SanJiDaiLiJia;

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
        public bool Update(Hownet.Model.Materiel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Materiel set ");
            strSql.Append("Name=@Name,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("MeasureID=@MeasureID,");
            strSql.Append("Sn=@Sn,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("AttributeID=@AttributeID,");
            strSql.Append("SecondMeasureID=@SecondMeasureID,");
            strSql.Append("Conversion=@Conversion,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("Image=@Image,");
            strSql.Append("Designers=@Designers,");
            strSql.Append("SelectSpec=@SelectSpec,");
            strSql.Append("TiaoMaH=@TiaoMaH,");
            strSql.Append("ChengBengJ=@ChengBengJ,");
            strSql.Append("LingShouJia=@LingShouJia,");
            strSql.Append("YiJiDaiLiJia=@YiJiDaiLiJia,");
            strSql.Append("ErJiDaiLiJia=@ErJiDaiLiJia,");
            strSql.Append("SanJiDaiLiJia=@SanJiDaiLiJia");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@MeasureID", SqlDbType.Int,4),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@AttributeID", SqlDbType.Int,4),
					new SqlParameter("@SecondMeasureID", SqlDbType.Int,4),
					new SqlParameter("@Conversion", SqlDbType.Decimal,9),
					new SqlParameter("@IsEnd", SqlDbType.TinyInt,1),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@Image", SqlDbType.NVarChar,50),
					new SqlParameter("@Designers", SqlDbType.Int,4),
					new SqlParameter("@SelectSpec", SqlDbType.Int,4),
					new SqlParameter("@TiaoMaH", SqlDbType.NVarChar,50),
					new SqlParameter("@ChengBengJ", SqlDbType.Decimal,9),
					new SqlParameter("@LingShouJia", SqlDbType.Decimal,9),
					new SqlParameter("@YiJiDaiLiJia", SqlDbType.Decimal,9),
					new SqlParameter("@ErJiDaiLiJia", SqlDbType.Decimal,9),
					new SqlParameter("@SanJiDaiLiJia", SqlDbType.Decimal,9),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.TypeID;
            parameters[2].Value = model.MeasureID;
            parameters[3].Value = model.Sn;
            parameters[4].Value = model.Remark;
            parameters[5].Value = model.AttributeID;
            parameters[6].Value = model.SecondMeasureID;
            parameters[7].Value = model.Conversion;
            parameters[8].Value = model.IsEnd;
            parameters[9].Value = model.IsUse;
            parameters[10].Value = model.Image;
            parameters[11].Value = model.Designers;
            parameters[12].Value = model.SelectSpec;
            parameters[13].Value = model.TiaoMaH;
            parameters[14].Value = model.ChengBengJ;
            parameters[15].Value = model.LingShouJia;
            parameters[16].Value = model.YiJiDaiLiJia;
            parameters[17].Value = model.ErJiDaiLiJia;
            parameters[18].Value = model.SanJiDaiLiJia;
            parameters[19].Value = model.ID;

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
            strSql.Append("delete from Materiel ");
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
            strSql.Append("delete from Materiel ");
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
        public Hownet.Model.Materiel GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,TypeID,MeasureID,Sn,Remark,AttributeID,SecondMeasureID,Conversion,IsEnd,IsUse,Image,Designers,SelectSpec,TiaoMaH,ChengBengJ,LingShouJia,YiJiDaiLiJia,ErJiDaiLiJia,SanJiDaiLiJia from Materiel ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.Materiel model = new Hownet.Model.Materiel();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["TypeID"] != null && ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MeasureID"] != null && ds.Tables[0].Rows[0]["MeasureID"].ToString() != "")
                {
                    model.MeasureID = int.Parse(ds.Tables[0].Rows[0]["MeasureID"].ToString());
                }
                model.Sn = ds.Tables[0].Rows[0]["Sn"].ToString();
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["AttributeID"] != null && ds.Tables[0].Rows[0]["AttributeID"].ToString() != "")
                {
                    model.AttributeID = int.Parse(ds.Tables[0].Rows[0]["AttributeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SecondMeasureID"] != null && ds.Tables[0].Rows[0]["SecondMeasureID"].ToString() != "")
                {
                    model.SecondMeasureID = int.Parse(ds.Tables[0].Rows[0]["SecondMeasureID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Conversion"] != null && ds.Tables[0].Rows[0]["Conversion"].ToString() != "")
                {
                    model.Conversion = decimal.Parse(ds.Tables[0].Rows[0]["Conversion"].ToString());
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
                model.Image = ds.Tables[0].Rows[0]["Image"].ToString();
                if (ds.Tables[0].Rows[0]["Designers"] != null && ds.Tables[0].Rows[0]["Designers"].ToString() != "")
                {
                    model.Designers = int.Parse(ds.Tables[0].Rows[0]["Designers"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SelectSpec"] != null && ds.Tables[0].Rows[0]["SelectSpec"].ToString() != "")
                {
                    model.SelectSpec = int.Parse(ds.Tables[0].Rows[0]["SelectSpec"].ToString());
                }
                model.TiaoMaH = ds.Tables[0].Rows[0]["TiaoMaH"].ToString();
                if (ds.Tables[0].Rows[0]["ChengBengJ"] != null && ds.Tables[0].Rows[0]["ChengBengJ"].ToString() != "")
                {
                    model.ChengBengJ = decimal.Parse(ds.Tables[0].Rows[0]["ChengBengJ"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LingShouJia"] != null && ds.Tables[0].Rows[0]["LingShouJia"].ToString() != "")
                {
                    model.LingShouJia = decimal.Parse(ds.Tables[0].Rows[0]["LingShouJia"].ToString());
                }
                if (ds.Tables[0].Rows[0]["YiJiDaiLiJia"] != null && ds.Tables[0].Rows[0]["YiJiDaiLiJia"].ToString() != "")
                {
                    model.YiJiDaiLiJia = decimal.Parse(ds.Tables[0].Rows[0]["YiJiDaiLiJia"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ErJiDaiLiJia"] != null && ds.Tables[0].Rows[0]["ErJiDaiLiJia"].ToString() != "")
                {
                    model.ErJiDaiLiJia = decimal.Parse(ds.Tables[0].Rows[0]["ErJiDaiLiJia"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SanJiDaiLiJia"] != null && ds.Tables[0].Rows[0]["SanJiDaiLiJia"].ToString() != "")
                {
                    model.SanJiDaiLiJia = decimal.Parse(ds.Tables[0].Rows[0]["SanJiDaiLiJia"].ToString());
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
            strSql.Append("select  1 as A,ID,Name,TypeID,MeasureID,Sn,Remark,AttributeID,SecondMeasureID,Conversion,IsEnd,IsUse,Image,Designers,SelectSpec,TiaoMaH,ChengBengJ,LingShouJia,YiJiDaiLiJia,ErJiDaiLiJia,SanJiDaiLiJia ");
            strSql.Append(" FROM Materiel ");
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
            strSql.Append(" ID,Name,TypeID,MeasureID,Sn,Remark,AttributeID,SecondMeasureID,Conversion,IsEnd,IsUse,Image,Designers,SelectSpec,TiaoMaH,ChengBengJ,LingShouJia,YiJiDaiLiJia,ErJiDaiLiJia,SanJiDaiLiJia ");
            strSql.Append(" FROM Materiel ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 返回BOM窗体左侧树形所需列表
        /// </summary>
        /// <returns></returns>
        /// <param name="AttributeID"></param>
        /// <param name="IsEnd">-1为全部，0为使用中，1为停用</param>
        public DataSet GetLaftTree(int AttributeID, int IsEnd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,Name FROM Materiel ");
            strSql.Append(" where (AttributeID=@AttributeID) ");
            if (IsEnd > -1)
                strSql.Append("and (IsEnd=@IsEnd)");
            SqlParameter[] sps = { new SqlParameter("@AttributeID", AttributeID), new SqlParameter("@IsEnd", IsEnd) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        //public bool CheckDuplicate(string Name, string Sn)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select 1 as A,ID,Name,TypeID,MeasureID,Sn,Remark,AttributeID,SecondMeasureID,Conversion,IsEnd,IsUse,Image,Designers ");
        //    strSql.Append(" FROM Materiel ");
        //}
        public DataSet GetByTypeName(string TypeName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Materiel.ID, Materiel.Name FROM      Materiel INNER JOIN MaterielType ON Materiel.TypeID = MaterielType.ID ");
            strSql.Append(" WHERE   (MaterielType.ParentID = (SELECT   ID FROM      MaterielType AS MaterielType_1 WHERE   (Name = @TypeName))) ");
            strSql.Append(" UNION ALL SELECT   Materiel_1.ID, Materiel_1.Name FROM      MaterielType AS MaterielType_2 INNER JOIN Materiel AS ");
            strSql.Append(" Materiel_1 ON MaterielType_2.ID = Materiel_1.TypeID WHERE   (MaterielType_2.Name = @TypeName)");
            SqlParameter[] sps = { new SqlParameter("@TypeName", TypeName) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetListAndMeasure()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID,Name,AttributeID,MeasureID,Image from Materiel");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public string GetMTName(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select (select Name from MaterielType Where (ID=Materiel.TypeID)) as MTName from Materiel Where (ID=@ID) ");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            return DbHelperSQL.GetSingle(strSql.ToString(), sps).ToString();
        }
         /// <summary>
        /// 获取单用量中所有的主料
        /// </summary>
        /// <returns></returns>
        public DataSet GetTogethers()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ChildMaterielID AS MaterielID, (SELECT   Name FROM      Materiel WHERE   (ID = ");
            strSql.Append(" MaterielStructInfo.ChildMaterielID)) AS MaterielName FROM      MaterielStructInfo ");
            strSql.Append(" WHERE   (IsTogethers = 1) GROUP BY ChildMaterielID ORDER BY MaterielID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 用于下拉框显示的列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetLookupList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 1 as A,ID,Name,TypeID,MeasureID,Sn,AttributeID,IsEnd,Image,Designers ");
            strSql.Append(" FROM Materiel ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        //public DataSet GetTem()
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append(" SELECT   Materiel.Name, Free.dbo.Attribute.Name AS Expr1 FROM      Materiel INNER JOIN ");
        //    strSql.Append(" Free.dbo.Attribute ON Materiel.AttributeID = Free.dbo.Attribute.ID");
        //    return DbHelperSQL.Query(strSql.ToString());
        //}
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
			parameters[0].Value = "Materiel";
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

