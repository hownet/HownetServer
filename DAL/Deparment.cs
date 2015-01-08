using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Deparment。
	/// </summary>
	public class Deparment
	{
		public Deparment()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Deparment"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Deparment");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Deparment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Deparment(");
            strSql.Append("Name,Remark,Sn,IsEnd,TypeID,ParentID,CountEmployee)");
            strSql.Append(" values (");
            strSql.Append("@Name,@Remark,@Sn,@IsEnd,@TypeID,@ParentID,@CountEmployee)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@CountEmployee", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Remark;
            parameters[2].Value = model.Sn;
            parameters[3].Value = model.IsEnd;
            parameters[4].Value = model.TypeID;
            parameters[5].Value = model.ParentID;
            parameters[6].Value = model.CountEmployee;

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
        public bool Update(Hownet.Model.Deparment model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update Deparment set ");
            strSql.Append("Name=@Name,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Sn=@Sn,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("TypeID=@TypeID,");
            strSql.Append("ParentID=@ParentID,");
            strSql.Append("CountEmployee=@CountEmployee");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@Sn", SqlDbType.NVarChar,50),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@TypeID", SqlDbType.Int,4),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@CountEmployee", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.Remark;
            parameters[2].Value = model.Sn;
            parameters[3].Value = model.IsEnd;
            parameters[4].Value = model.TypeID;
            parameters[5].Value = model.ParentID;
            parameters[6].Value = model.CountEmployee;
            parameters[7].Value = model.ID;

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
            strSql.Append("delete from Deparment ");
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
            strSql.Append("delete from Deparment ");
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
        public Hownet.Model.Deparment GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ID,Name,Remark,Sn,IsEnd,TypeID,ParentID,CountEmployee from Deparment ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.Deparment model = new Hownet.Model.Deparment();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                model.Sn = ds.Tables[0].Rows[0]["Sn"].ToString();
                if (ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TypeID"].ToString() != "")
                {
                    model.TypeID = int.Parse(ds.Tables[0].Rows[0]["TypeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ParentID"].ToString() != "")
                {
                    model.ParentID = int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CountEmployee"].ToString() != "")
                {
                    model.CountEmployee = int.Parse(ds.Tables[0].Rows[0]["CountEmployee"].ToString());
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
            strSql.Append("select 1 as A,ID,Name,Remark,Sn,IsEnd,TypeID,ParentID,CountEmployee ");
            strSql.Append(" FROM Deparment ");
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
            strSql.Append(" ID,Name,Remark,Sn,IsEnd,TypeID,ParentID,CountEmployee ");
            strSql.Append(" FROM Deparment ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 按部门类型查找部门列表
        /// </summary>
        /// <param name="DepartmentTypeName">部门类型</param>
        /// <returns></returns>
        public DataSet GetTypeList(string DepartmentTypeName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT CAST(0 AS bit) AS T,ID,0 as A, Name FROM Deparment WHERE (TypeID = (SELECT Top 1 ID FROM OtherType ");
            strSql.Append(" WHERE (Name = @DepartmentTypeName))) And (ParentID=0)");
            SqlParameter[] sps = { new SqlParameter("@DepartmentTypeName", DepartmentTypeName) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 按部门类型查找部门列表
        /// </summary>
        /// <param name="DepartmentTypeName">部门类型</param>
        /// <returns></returns>
        public DataSet GetTypeLists(string DepartmentTypeName)
        {
            StringBuilder strSql = new StringBuilder();
//            strSql.Append("SELECT CAST(0 AS bit) AS T,ID,0 as A,(select name from othertype where (ID=Deparment.TypeID)) as TypeName, Name FROM Deparment WHERE (ParentID=0) And(  ");

            strSql.Append(" SELECT   CAST(0 AS bit) AS T, Deparment.ID, 0 AS A,(SELECT   Name FROM      OtherType WHERE   (ID = Deparment.TypeID)) AS TypeName, ");
            strSql.Append(" Deparment.Name, Deparment.TypeID, OtherType_1.Name AS Expr1 FROM      Deparment INNER JOIN OtherType AS OtherType_1 ON Deparment.TypeID = OtherType_1.ID ");
            strSql.Append(" WHERE   (Deparment.ParentID = 0) ");
            
            
            string[] dd = DepartmentTypeName.Split(',');
            if(dd.Length>0)
            {
                strSql.Append(" AND ");
            }
            for (int i = 0; i < dd.Length; i++)
            {
                strSql.Append("(OtherType_1.Name = N'" + dd[i] + "') OR");
            }
            strSql.Remove(strSql.Length - 2, 2);
          //  strSql.Append(")");
          //  SqlParameter[] sps = { new SqlParameter("@DepartmentTypeName", DepartmentTypeName) };
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 获取某一类型部门的下属部门，主指食堂的桌号及宿舍房间号
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public DataSet GetInfoListByTypeName(string TypeName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Deparment.Name + '-' + Deparment_1.Name AS Name, Deparment_1.ID,Deparment_1.IsEnd FROM      Deparment INNER JOIN ");
            strSql.Append(" OtherType ON Deparment.TypeID = OtherType.ID INNER JOIN Deparment AS Deparment_1 ON Deparment.ID = Deparment_1.ParentID ");
            strSql.Append(" WHERE   (OtherType.Name = @TypeName)");
            SqlParameter[] sps = {new SqlParameter("@TypeName",TypeName) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 某餐桌或宿舍已分配的人数
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="EmpID"></param>
        /// <returns></returns>
        public DataSet GetIsUse(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   Deparment.CountEmployee, COUNT(MiniEmp.ID) AS CountUse  FROM      MiniEmp INNER JOIN  Deparment ON MiniEmp.TableID = Deparment.ID ");
            strSql.Append(" WHERE   (MiniEmp.TableID = @ID)  GROUP BY Deparment.CountEmployee");
            SqlParameter[] sps = {new SqlParameter("@ID",ID) };
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
			parameters[0].Value = "Deparment";
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

