using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:ItemsText
	/// </summary>
	public partial class ItemsText
	{
		public ItemsText()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ItemsText"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ItemsText");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ItemsText model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ItemsText(");
            strSql.Append("ItemsID,UserID,ColumnsName,ShowText,IsVisible,Widths)");
            strSql.Append(" values (");
            strSql.Append("@ItemsID,@UserID,@ColumnsName,@ShowText,@IsVisible,@Widths)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemsID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ColumnsName", SqlDbType.NVarChar,50),
					new SqlParameter("@ShowText", SqlDbType.NVarChar,50),
					new SqlParameter("@IsVisible", SqlDbType.Bit,1),
					new SqlParameter("@Widths", SqlDbType.Int,4)};
            parameters[0].Value = model.ItemsID;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.ColumnsName;
            parameters[3].Value = model.ShowText;
            parameters[4].Value = model.IsVisible;
            parameters[5].Value = model.Widths;

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
        public bool Update(Hownet.Model.ItemsText model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ItemsText set ");
            strSql.Append("ItemsID=@ItemsID,");
            strSql.Append("UserID=@UserID,");
            strSql.Append("ColumnsName=@ColumnsName,");
            strSql.Append("ShowText=@ShowText,");
            strSql.Append("IsVisible=@IsVisible,");
            strSql.Append("Widths=@Widths");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ItemsID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@ColumnsName", SqlDbType.NVarChar,50),
					new SqlParameter("@ShowText", SqlDbType.NVarChar,50),
					new SqlParameter("@IsVisible", SqlDbType.Bit,1),
					new SqlParameter("@Widths", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.ItemsID;
            parameters[1].Value = model.UserID;
            parameters[2].Value = model.ColumnsName;
            parameters[3].Value = model.ShowText;
            parameters[4].Value = model.IsVisible;
            parameters[5].Value = model.Widths;
            parameters[6].Value = model.ID;

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
            strSql.Append("delete from ItemsText ");
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
            strSql.Append("delete from ItemsText ");
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
        public Hownet.Model.ItemsText GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ID,ItemsID,UserID,ColumnsName,ShowText,IsVisible,Widths from ItemsText ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.ItemsText model = new Hownet.Model.ItemsText();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ItemsID"].ToString() != "")
                {
                    model.ItemsID = int.Parse(ds.Tables[0].Rows[0]["ItemsID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UserID"].ToString() != "")
                {
                    model.UserID = int.Parse(ds.Tables[0].Rows[0]["UserID"].ToString());
                }
                model.ColumnsName = ds.Tables[0].Rows[0]["ColumnsName"].ToString();
                model.ShowText = ds.Tables[0].Rows[0]["ShowText"].ToString();
                if (ds.Tables[0].Rows[0]["IsVisible"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsVisible"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsVisible"].ToString().ToLower() == "true"))
                    {
                        model.IsVisible = true;
                    }
                    else
                    {
                        model.IsVisible = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Widths"].ToString() != "")
                {
                    model.Widths = int.Parse(ds.Tables[0].Rows[0]["Widths"].ToString());
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
            strSql.Append("select 1 as A,ID,ItemsID,UserID,ColumnsName,ShowText,IsVisible,Widths ");
            strSql.Append(" FROM ItemsText ");
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
            strSql.Append(" ID,ItemsID,UserID,ColumnsName,ShowText,IsVisible,Widths ");
            strSql.Append(" FROM ItemsText ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        /// <summary>
        /// 获取某表单显示时的列表头，以及是否显示等设置
        /// </summary>
        /// <param name="FromText"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public DataSet GetHeadText(string FromText, int UserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ItemsText.UserID, ItemsText.ColumnsName, ItemsText.ShowText, ItemsText.IsVisible,ItemsText.Widths ");
            strSql.Append(" FROM      Items INNER JOIN ItemsText ON Items.ID = ItemsText.ItemsID ");
            strSql.Append(" WHERE   (Items.Text = @FormText) AND (ItemsText.UserID = @UserID)");
            SqlParameter[] sps = {new SqlParameter("@FormText",FromText),new SqlParameter("@UserID",UserID) };
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), sps);
            if (ds.Tables[0].Rows.Count == 0)
            {
              
                strSql.Remove(0, strSql.Length);
                strSql.Append(" SELECT   ItemsText.UserID, ItemsText.ColumnsName, ItemsText.ShowText, ItemsText.IsVisible,ItemsText.Widths  ");
                strSql.Append(" FROM      Items INNER JOIN ItemsText ON Items.ID = ItemsText.ItemsID ");
                strSql.Append(" WHERE   (Items.Text = @FormText) AND (ItemsText.UserID = 0)");
                ds = DbHelperSQL.Query(strSql.ToString(), sps);
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
			parameters[0].Value = "ItemsText";
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

