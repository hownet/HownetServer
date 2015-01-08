using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:VouchersMain
	/// </summary>
	public partial class VouchersMain
	{
		public VouchersMain()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "VouchersMain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from VouchersMain");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.VouchersMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into VouchersMain(");
            strSql.Append("FillDate,FillMan,CaiKuai,CKDate,JiZhang,JZDate,FuHe,FHDate,ZhiZheng,ZZDate,SumNum,Num,AttachmentSum,DateTime,MainID)");
            strSql.Append(" values (");
            strSql.Append("@FillDate,@FillMan,@CaiKuai,@CKDate,@JiZhang,@JZDate,@FuHe,@FHDate,@ZhiZheng,@ZZDate,@SumNum,@Num,@AttachmentSum,@DateTime,@MainID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@CaiKuai", SqlDbType.Int,4),
					new SqlParameter("@CKDate", SqlDbType.DateTime),
					new SqlParameter("@JiZhang", SqlDbType.Int,4),
					new SqlParameter("@JZDate", SqlDbType.DateTime),
					new SqlParameter("@FuHe", SqlDbType.Int,4),
					new SqlParameter("@FHDate", SqlDbType.DateTime),
					new SqlParameter("@ZhiZheng", SqlDbType.Int,4),
					new SqlParameter("@ZZDate", SqlDbType.DateTime),
					new SqlParameter("@SumNum", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@AttachmentSum", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@MainID", SqlDbType.Int,4)};
            parameters[0].Value = model.FillDate;
            parameters[1].Value = model.FillMan;
            parameters[2].Value = model.CaiKuai;
            parameters[3].Value = model.CKDate;
            parameters[4].Value = model.JiZhang;
            parameters[5].Value = model.JZDate;
            parameters[6].Value = model.FuHe;
            parameters[7].Value = model.FHDate;
            parameters[8].Value = model.ZhiZheng;
            parameters[9].Value = model.ZZDate;
            parameters[10].Value = model.SumNum;
            parameters[11].Value = model.Num;
            parameters[12].Value = model.AttachmentSum;
            parameters[13].Value = model.DateTime;
            parameters[14].Value = model.MainID;

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
        public bool Update(Hownet.Model.VouchersMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update VouchersMain set ");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("CaiKuai=@CaiKuai,");
            strSql.Append("CKDate=@CKDate,");
            strSql.Append("JiZhang=@JiZhang,");
            strSql.Append("JZDate=@JZDate,");
            strSql.Append("FuHe=@FuHe,");
            strSql.Append("FHDate=@FHDate,");
            strSql.Append("ZhiZheng=@ZhiZheng,");
            strSql.Append("ZZDate=@ZZDate,");
            strSql.Append("SumNum=@SumNum,");
            strSql.Append("Num=@Num,");
            strSql.Append("AttachmentSum=@AttachmentSum,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("MainID=@MainID");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@CaiKuai", SqlDbType.Int,4),
					new SqlParameter("@CKDate", SqlDbType.DateTime),
					new SqlParameter("@JiZhang", SqlDbType.Int,4),
					new SqlParameter("@JZDate", SqlDbType.DateTime),
					new SqlParameter("@FuHe", SqlDbType.Int,4),
					new SqlParameter("@FHDate", SqlDbType.DateTime),
					new SqlParameter("@ZhiZheng", SqlDbType.Int,4),
					new SqlParameter("@ZZDate", SqlDbType.DateTime),
					new SqlParameter("@SumNum", SqlDbType.Int,4),
					new SqlParameter("@Num", SqlDbType.Int,4),
					new SqlParameter("@AttachmentSum", SqlDbType.Int,4),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.FillDate;
            parameters[1].Value = model.FillMan;
            parameters[2].Value = model.CaiKuai;
            parameters[3].Value = model.CKDate;
            parameters[4].Value = model.JiZhang;
            parameters[5].Value = model.JZDate;
            parameters[6].Value = model.FuHe;
            parameters[7].Value = model.FHDate;
            parameters[8].Value = model.ZhiZheng;
            parameters[9].Value = model.ZZDate;
            parameters[10].Value = model.SumNum;
            parameters[11].Value = model.Num;
            parameters[12].Value = model.AttachmentSum;
            parameters[13].Value = model.DateTime;
            parameters[14].Value = model.MainID;
            parameters[15].Value = model.ID;

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
            strSql.Append("delete from VouchersMain ");
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
            strSql.Append("delete from VouchersMain ");
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
        public Hownet.Model.VouchersMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ID,FillDate,FillMan,CaiKuai,CKDate,JiZhang,JZDate,FuHe,FHDate,ZhiZheng,ZZDate,SumNum,Num,AttachmentSum,DateTime,MainID from VouchersMain ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.VouchersMain model = new Hownet.Model.VouchersMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CaiKuai"].ToString() != "")
                {
                    model.CaiKuai = int.Parse(ds.Tables[0].Rows[0]["CaiKuai"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CKDate"].ToString() != "")
                {
                    model.CKDate = DateTime.Parse(ds.Tables[0].Rows[0]["CKDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JiZhang"].ToString() != "")
                {
                    model.JiZhang = int.Parse(ds.Tables[0].Rows[0]["JiZhang"].ToString());
                }
                if (ds.Tables[0].Rows[0]["JZDate"].ToString() != "")
                {
                    model.JZDate = DateTime.Parse(ds.Tables[0].Rows[0]["JZDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FuHe"].ToString() != "")
                {
                    model.FuHe = int.Parse(ds.Tables[0].Rows[0]["FuHe"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FHDate"].ToString() != "")
                {
                    model.FHDate = DateTime.Parse(ds.Tables[0].Rows[0]["FHDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ZhiZheng"].ToString() != "")
                {
                    model.ZhiZheng = int.Parse(ds.Tables[0].Rows[0]["ZhiZheng"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ZZDate"].ToString() != "")
                {
                    model.ZZDate = DateTime.Parse(ds.Tables[0].Rows[0]["ZZDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SumNum"].ToString() != "")
                {
                    model.SumNum = int.Parse(ds.Tables[0].Rows[0]["SumNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Num"].ToString() != "")
                {
                    model.Num = int.Parse(ds.Tables[0].Rows[0]["Num"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AttachmentSum"].ToString() != "")
                {
                    model.AttachmentSum = int.Parse(ds.Tables[0].Rows[0]["AttachmentSum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
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
            strSql.Append("select 1 as A,ID,FillDate,FillMan,CaiKuai,CKDate,JiZhang,JZDate,FuHe,FHDate,ZhiZheng,ZZDate,SumNum,Num,AttachmentSum,DateTime,MainID ");
            strSql.Append(" FROM VouchersMain ");
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
            strSql.Append(" ID,FillDate,FillMan,CaiKuai,CKDate,JiZhang,JZDate,FuHe,FHDate,ZhiZheng,ZZDate,SumNum,Num,AttachmentSum,DateTime,MainID ");
            strSql.Append(" FROM VouchersMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public DataSet GetIDList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select ID from VouchersMain  order by ID");
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
			parameters[0].Value = "VouchersMain";
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

