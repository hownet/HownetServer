using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:Bas_LBXM
	/// </summary>
	public partial class Bas_LBXM
	{
		public Bas_LBXM()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Bas_LBXM"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Bas_LBXM");
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
		public int Add(Hownet.Model.Bas_LBXM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Bas_LBXM(");
			strSql.Append("Name,ParentID)");
			strSql.Append(" values (");
			strSql.Append("@Name,@ParentID)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.ParentID;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Hownet.Model.Bas_LBXM model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Bas_LBXM set ");
			strSql.Append("Name=@Name,");
			strSql.Append("ParentID=@ParentID");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@ParentID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.ParentID;
			parameters[2].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Bas_LBXM ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Bas_LBXM ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
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
		public Hownet.Model.Bas_LBXM GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Name,ParentID from Bas_LBXM ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.Bas_LBXM model=new Hownet.Model.Bas_LBXM();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
					model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				if(ds.Tables[0].Rows[0]["ParentID"]!=null && ds.Tables[0].Rows[0]["ParentID"].ToString()!="")
				{
					model.ParentID=int.Parse(ds.Tables[0].Rows[0]["ParentID"].ToString());
				}
				model.A=1;
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  1 as A,ID,Name,ParentID ");
			strSql.Append(" FROM Bas_LBXM ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,Name,ParentID ");
			strSql.Append(" FROM Bas_LBXM ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}
        public DataSet GetTreeList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  1 as A,ID,Name,ID as IDS, ParentID  ");
            strSql.Append(" FROM Bas_LBXM ORDER BY ID");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetFilterList(string s)
        {
            try
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append("select  ID ");
                strSql.Append(" FROM Bas_LBXM Where (Name Like '" + s + "') ");
                DataTable dt = DbHelperSQL.Query(strSql.ToString()).Tables[0];
                DataSet ds = new DataSet();
                if (dt.Rows.Count > 0)
                {
                    strSql.Remove(0, strSql.Length);
                    strSql.Append("select  1 as A,ID,Name, ParentID ");
                    strSql.Append(" FROM Bas_LBXM Where 1=2");
                    ds = DbHelperSQL.Query(strSql.ToString());
                    DataTable dtT = ds.Tables[0].Clone();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        strSql.Remove(0, strSql.Length);
                        strSql.Append(" with ");
                        strSql.Append(" RTU1 as(  select 1 as A, ID ,Name, ParentID from Bas_LBXM ),   ");
                        strSql.Append(" RTU2 as(  select * from RTU1 where ID='" + dt.Rows[i][0] + "'  union all  select RTU1.* from RTU2 inner join RTU1    ");
                        strSql.Append(" on RTU2.ParentID=RTU1.ID  )      select * from RTU2 ");
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
                                if (dtT.Rows[i]["ID"].ToString() == ds.Tables[0].Rows[j]["ID"].ToString())
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
			parameters[0].Value = "Bas_LBXM";
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

