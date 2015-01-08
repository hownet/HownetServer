using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类ProductWorkingInfo。
	/// </summary>
	public class ProductWorkingInfo
	{
		public ProductWorkingInfo()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "ProductWorkingInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from ProductWorkingInfo");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.ProductWorkingInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into ProductWorkingInfo(");
            strSql.Append("WorkingID,GroupBy,Machine,MachinePart,LineOne,LineTwo,Pin,Stitch,Width,StitchWidth,Remark,MakingsOne,MakingsTwo,MainID,IsTicket,Price,UseTime,FastTime,Orders,MaterielID,ColorID,SpecialWork,PWMID,PWIID,CustOder,IsCaiC,IsCut,CompanyID,IsSpecial,OneAmount,IsCanMove)");
            strSql.Append(" values (");
            strSql.Append("@WorkingID,@GroupBy,@Machine,@MachinePart,@LineOne,@LineTwo,@Pin,@Stitch,@Width,@StitchWidth,@Remark,@MakingsOne,@MakingsTwo,@MainID,@IsTicket,@Price,@UseTime,@FastTime,@Orders,@MaterielID,@ColorID,@SpecialWork,@PWMID,@PWIID,@CustOder,@IsCaiC,@IsCut,@CompanyID,@IsSpecial,@OneAmount,@IsCanMove)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@GroupBy", SqlDbType.Int,4),
					new SqlParameter("@Machine", SqlDbType.Int,4),
					new SqlParameter("@MachinePart", SqlDbType.Int,4),
					new SqlParameter("@LineOne", SqlDbType.Int,4),
					new SqlParameter("@LineTwo", SqlDbType.Int,4),
					new SqlParameter("@Pin", SqlDbType.Int,4),
					new SqlParameter("@Stitch", SqlDbType.Int,4),
					new SqlParameter("@Width", SqlDbType.Int,4),
					new SqlParameter("@StitchWidth", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@MakingsOne", SqlDbType.Int,4),
					new SqlParameter("@MakingsTwo", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsTicket", SqlDbType.Bit,1),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@UseTime", SqlDbType.Decimal,9),
					new SqlParameter("@FastTime", SqlDbType.Decimal,9),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SpecialWork", SqlDbType.Int,4),
					new SqlParameter("@PWMID", SqlDbType.Int,4),
					new SqlParameter("@PWIID", SqlDbType.Int,4),
					new SqlParameter("@CustOder", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCaiC", SqlDbType.Bit,1),
					new SqlParameter("@IsCut", SqlDbType.Bit,1),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@IsSpecial", SqlDbType.Bit,1),
					new SqlParameter("@OneAmount", SqlDbType.Int,4),
					new SqlParameter("@IsCanMove", SqlDbType.Bit,1)};
            parameters[0].Value = model.WorkingID;
            parameters[1].Value = model.GroupBy;
            parameters[2].Value = model.Machine;
            parameters[3].Value = model.MachinePart;
            parameters[4].Value = model.LineOne;
            parameters[5].Value = model.LineTwo;
            parameters[6].Value = model.Pin;
            parameters[7].Value = model.Stitch;
            parameters[8].Value = model.Width;
            parameters[9].Value = model.StitchWidth;
            parameters[10].Value = model.Remark;
            parameters[11].Value = model.MakingsOne;
            parameters[12].Value = model.MakingsTwo;
            parameters[13].Value = model.MainID;
            parameters[14].Value = model.IsTicket;
            parameters[15].Value = model.Price;
            parameters[16].Value = model.UseTime;
            parameters[17].Value = model.FastTime;
            parameters[18].Value = model.Orders;
            parameters[19].Value = model.MaterielID;
            parameters[20].Value = model.ColorID;
            parameters[21].Value = model.SpecialWork;
            parameters[22].Value = model.PWMID;
            parameters[23].Value = model.PWIID;
            parameters[24].Value = model.CustOder;
            parameters[25].Value = model.IsCaiC;
            parameters[26].Value = model.IsCut;
            parameters[27].Value = model.CompanyID;
            parameters[28].Value = model.IsSpecial;
            parameters[29].Value = model.OneAmount;
            parameters[30].Value = model.IsCanMove;

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
        public bool Update(Hownet.Model.ProductWorkingInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProductWorkingInfo set ");
            strSql.Append("WorkingID=@WorkingID,");
            strSql.Append("GroupBy=@GroupBy,");
            strSql.Append("Machine=@Machine,");
            strSql.Append("MachinePart=@MachinePart,");
            strSql.Append("LineOne=@LineOne,");
            strSql.Append("LineTwo=@LineTwo,");
            strSql.Append("Pin=@Pin,");
            strSql.Append("Stitch=@Stitch,");
            strSql.Append("Width=@Width,");
            strSql.Append("StitchWidth=@StitchWidth,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("MakingsOne=@MakingsOne,");
            strSql.Append("MakingsTwo=@MakingsTwo,");
            strSql.Append("MainID=@MainID,");
            strSql.Append("IsTicket=@IsTicket,");
            strSql.Append("Price=@Price,");
            strSql.Append("UseTime=@UseTime,");
            strSql.Append("FastTime=@FastTime,");
            strSql.Append("Orders=@Orders,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("ColorID=@ColorID,");
            strSql.Append("SpecialWork=@SpecialWork,");
            strSql.Append("PWMID=@PWMID,");
            strSql.Append("PWIID=@PWIID,");
            strSql.Append("CustOder=@CustOder,");
            strSql.Append("IsCaiC=@IsCaiC,");
            strSql.Append("IsCut=@IsCut,");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("IsSpecial=@IsSpecial,");
            strSql.Append("OneAmount=@OneAmount,");
            strSql.Append("IsCanMove=@IsCanMove");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@WorkingID", SqlDbType.Int,4),
					new SqlParameter("@GroupBy", SqlDbType.Int,4),
					new SqlParameter("@Machine", SqlDbType.Int,4),
					new SqlParameter("@MachinePart", SqlDbType.Int,4),
					new SqlParameter("@LineOne", SqlDbType.Int,4),
					new SqlParameter("@LineTwo", SqlDbType.Int,4),
					new SqlParameter("@Pin", SqlDbType.Int,4),
					new SqlParameter("@Stitch", SqlDbType.Int,4),
					new SqlParameter("@Width", SqlDbType.Int,4),
					new SqlParameter("@StitchWidth", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,500),
					new SqlParameter("@MakingsOne", SqlDbType.Int,4),
					new SqlParameter("@MakingsTwo", SqlDbType.Int,4),
					new SqlParameter("@MainID", SqlDbType.Int,4),
					new SqlParameter("@IsTicket", SqlDbType.Bit,1),
					new SqlParameter("@Price", SqlDbType.Decimal,9),
					new SqlParameter("@UseTime", SqlDbType.Decimal,9),
					new SqlParameter("@FastTime", SqlDbType.Decimal,9),
					new SqlParameter("@Orders", SqlDbType.Int,4),
					new SqlParameter("@MaterielID", SqlDbType.Int,4),
					new SqlParameter("@ColorID", SqlDbType.Int,4),
					new SqlParameter("@SpecialWork", SqlDbType.Int,4),
					new SqlParameter("@PWMID", SqlDbType.Int,4),
					new SqlParameter("@PWIID", SqlDbType.Int,4),
					new SqlParameter("@CustOder", SqlDbType.NVarChar,50),
					new SqlParameter("@IsCaiC", SqlDbType.Bit,1),
					new SqlParameter("@IsCut", SqlDbType.Bit,1),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@IsSpecial", SqlDbType.Bit,1),
					new SqlParameter("@OneAmount", SqlDbType.Int,4),
					new SqlParameter("@IsCanMove", SqlDbType.Bit,1),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.WorkingID;
            parameters[1].Value = model.GroupBy;
            parameters[2].Value = model.Machine;
            parameters[3].Value = model.MachinePart;
            parameters[4].Value = model.LineOne;
            parameters[5].Value = model.LineTwo;
            parameters[6].Value = model.Pin;
            parameters[7].Value = model.Stitch;
            parameters[8].Value = model.Width;
            parameters[9].Value = model.StitchWidth;
            parameters[10].Value = model.Remark;
            parameters[11].Value = model.MakingsOne;
            parameters[12].Value = model.MakingsTwo;
            parameters[13].Value = model.MainID;
            parameters[14].Value = model.IsTicket;
            parameters[15].Value = model.Price;
            parameters[16].Value = model.UseTime;
            parameters[17].Value = model.FastTime;
            parameters[18].Value = model.Orders;
            parameters[19].Value = model.MaterielID;
            parameters[20].Value = model.ColorID;
            parameters[21].Value = model.SpecialWork;
            parameters[22].Value = model.PWMID;
            parameters[23].Value = model.PWIID;
            parameters[24].Value = model.CustOder;
            parameters[25].Value = model.IsCaiC;
            parameters[26].Value = model.IsCut;
            parameters[27].Value = model.CompanyID;
            parameters[28].Value = model.IsSpecial;
            parameters[29].Value = model.OneAmount;
            parameters[30].Value = model.IsCanMove;
            parameters[31].Value = model.ID;

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
            strSql.Append("delete from ProductWorkingInfo ");
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
            strSql.Append("delete from ProductWorkingInfo ");
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
        public Hownet.Model.ProductWorkingInfo GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,WorkingID,GroupBy,Machine,MachinePart,LineOne,LineTwo,Pin,Stitch,Width,StitchWidth,Remark,MakingsOne,MakingsTwo,MainID,IsTicket,Price,UseTime,FastTime,Orders,MaterielID,ColorID,SpecialWork,PWMID,PWIID,CustOder,IsCaiC,IsCut,CompanyID,IsSpecial,OneAmount,IsCanMove from ProductWorkingInfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
            parameters[0].Value = ID;

            Hownet.Model.ProductWorkingInfo model = new Hownet.Model.ProductWorkingInfo();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["WorkingID"] != null && ds.Tables[0].Rows[0]["WorkingID"].ToString() != "")
                {
                    model.WorkingID = int.Parse(ds.Tables[0].Rows[0]["WorkingID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["GroupBy"] != null && ds.Tables[0].Rows[0]["GroupBy"].ToString() != "")
                {
                    model.GroupBy = int.Parse(ds.Tables[0].Rows[0]["GroupBy"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Machine"] != null && ds.Tables[0].Rows[0]["Machine"].ToString() != "")
                {
                    model.Machine = int.Parse(ds.Tables[0].Rows[0]["Machine"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MachinePart"] != null && ds.Tables[0].Rows[0]["MachinePart"].ToString() != "")
                {
                    model.MachinePart = int.Parse(ds.Tables[0].Rows[0]["MachinePart"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LineOne"] != null && ds.Tables[0].Rows[0]["LineOne"].ToString() != "")
                {
                    model.LineOne = int.Parse(ds.Tables[0].Rows[0]["LineOne"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LineTwo"] != null && ds.Tables[0].Rows[0]["LineTwo"].ToString() != "")
                {
                    model.LineTwo = int.Parse(ds.Tables[0].Rows[0]["LineTwo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Pin"] != null && ds.Tables[0].Rows[0]["Pin"].ToString() != "")
                {
                    model.Pin = int.Parse(ds.Tables[0].Rows[0]["Pin"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Stitch"] != null && ds.Tables[0].Rows[0]["Stitch"].ToString() != "")
                {
                    model.Stitch = int.Parse(ds.Tables[0].Rows[0]["Stitch"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Width"] != null && ds.Tables[0].Rows[0]["Width"].ToString() != "")
                {
                    model.Width = int.Parse(ds.Tables[0].Rows[0]["Width"].ToString());
                }
                if (ds.Tables[0].Rows[0]["StitchWidth"] != null && ds.Tables[0].Rows[0]["StitchWidth"].ToString() != "")
                {
                    model.StitchWidth = int.Parse(ds.Tables[0].Rows[0]["StitchWidth"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Remark"] != null && ds.Tables[0].Rows[0]["Remark"].ToString() != "")
                {
                    model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                }
                if (ds.Tables[0].Rows[0]["MakingsOne"] != null && ds.Tables[0].Rows[0]["MakingsOne"].ToString() != "")
                {
                    model.MakingsOne = int.Parse(ds.Tables[0].Rows[0]["MakingsOne"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MakingsTwo"] != null && ds.Tables[0].Rows[0]["MakingsTwo"].ToString() != "")
                {
                    model.MakingsTwo = int.Parse(ds.Tables[0].Rows[0]["MakingsTwo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MainID"] != null && ds.Tables[0].Rows[0]["MainID"].ToString() != "")
                {
                    model.MainID = int.Parse(ds.Tables[0].Rows[0]["MainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsTicket"] != null && ds.Tables[0].Rows[0]["IsTicket"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsTicket"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsTicket"].ToString().ToLower() == "true"))
                    {
                        model.IsTicket = true;
                    }
                    else
                    {
                        model.IsTicket = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["UseTime"] != null && ds.Tables[0].Rows[0]["UseTime"].ToString() != "")
                {
                    model.UseTime = decimal.Parse(ds.Tables[0].Rows[0]["UseTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FastTime"] != null && ds.Tables[0].Rows[0]["FastTime"].ToString() != "")
                {
                    model.FastTime = decimal.Parse(ds.Tables[0].Rows[0]["FastTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Orders"] != null && ds.Tables[0].Rows[0]["Orders"].ToString() != "")
                {
                    model.Orders = int.Parse(ds.Tables[0].Rows[0]["Orders"].ToString());
                }
                if (ds.Tables[0].Rows[0]["MaterielID"] != null && ds.Tables[0].Rows[0]["MaterielID"].ToString() != "")
                {
                    model.MaterielID = int.Parse(ds.Tables[0].Rows[0]["MaterielID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["ColorID"] != null && ds.Tables[0].Rows[0]["ColorID"].ToString() != "")
                {
                    model.ColorID = int.Parse(ds.Tables[0].Rows[0]["ColorID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SpecialWork"] != null && ds.Tables[0].Rows[0]["SpecialWork"].ToString() != "")
                {
                    model.SpecialWork = int.Parse(ds.Tables[0].Rows[0]["SpecialWork"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PWMID"] != null && ds.Tables[0].Rows[0]["PWMID"].ToString() != "")
                {
                    model.PWMID = int.Parse(ds.Tables[0].Rows[0]["PWMID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PWIID"] != null && ds.Tables[0].Rows[0]["PWIID"].ToString() != "")
                {
                    model.PWIID = int.Parse(ds.Tables[0].Rows[0]["PWIID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CustOder"] != null && ds.Tables[0].Rows[0]["CustOder"].ToString() != "")
                {
                    model.CustOder = ds.Tables[0].Rows[0]["CustOder"].ToString();
                }
                if (ds.Tables[0].Rows[0]["IsCaiC"] != null && ds.Tables[0].Rows[0]["IsCaiC"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCaiC"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCaiC"].ToString().ToLower() == "true"))
                    {
                        model.IsCaiC = true;
                    }
                    else
                    {
                        model.IsCaiC = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["IsCut"] != null && ds.Tables[0].Rows[0]["IsCut"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCut"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCut"].ToString().ToLower() == "true"))
                    {
                        model.IsCut = true;
                    }
                    else
                    {
                        model.IsCut = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["CompanyID"] != null && ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsSpecial"] != null && ds.Tables[0].Rows[0]["IsSpecial"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsSpecial"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsSpecial"].ToString().ToLower() == "true"))
                    {
                        model.IsSpecial = true;
                    }
                    else
                    {
                        model.IsSpecial = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["OneAmount"] != null && ds.Tables[0].Rows[0]["OneAmount"].ToString() != "")
                {
                    model.OneAmount = int.Parse(ds.Tables[0].Rows[0]["OneAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsCanMove"] != null && ds.Tables[0].Rows[0]["IsCanMove"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCanMove"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCanMove"].ToString().ToLower() == "true"))
                    {
                        model.IsCanMove = true;
                    }
                    else
                    {
                        model.IsCanMove = false;
                    }
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
            strSql.Append("select  1 as A,ID,WorkingID,GroupBy,Machine,MachinePart,LineOne,LineTwo,Pin,Stitch,Width,StitchWidth,Remark,MakingsOne,MakingsTwo,MainID,IsTicket,Price,UseTime,FastTime,Orders,MaterielID,ColorID,SpecialWork,PWMID,PWIID,CustOder,IsCaiC,IsCut,CompanyID,IsSpecial,OneAmount,IsCanMove ");
            strSql.Append(" FROM ProductWorkingInfo ");
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
            strSql.Append(" ID,WorkingID,GroupBy,Machine,MachinePart,LineOne,LineTwo,Pin,Stitch,Width,StitchWidth,Remark,MakingsOne,MakingsTwo,MainID,IsTicket,Price,UseTime,FastTime,Orders,MaterielID,ColorID,SpecialWork,PWMID,PWIID,CustOder,IsCaiC,IsCut,CompanyID,IsSpecial,OneAmount,IsCanMove ");
            strSql.Append(" FROM ProductWorkingInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }


        public DataSet GetBoxWork(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID, Orders, WorkingID, (SELECT   Name FROM      Working WHERE   (ID = ProductWorkingInfo.WorkingID)) AS WorkName, ");
            strSql.Append(" (SELECT   IsSpecial FROM      Working AS Working_1 WHERE   (ID = ProductWorkingInfo.WorkingID)) AS IsSpecial,OneAmount ");
             strSql.Append(" FROM      ProductWorkingInfo WHERE   (MainID = @ID) And (IsTicket=1)");
            SqlParameter[] sps = {new SqlParameter("@ID",MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 返回某工艺单下工序ID、顺序入是否为特殊工序
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetBoxWorkID(int MainID,int OneAmount)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID, Orders, WorkingID, ");
            strSql.Append("  IsSpecial ");
            strSql.Append(" FROM      ProductWorkingInfo WHERE   (MainID = @ID) And (OneAmount=@OneAmount)");
            SqlParameter[] sps = { new SqlParameter("@ID", MainID), new SqlParameter("@OneAmount", OneAmount) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetSpecialWork(int MainID,int OneAmount)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT   Working.ID, Working.Name, ProductWorkingInfo.Orders, ProductWorkingInfo.GroupBy,ProductWorkingInfo.ID as PWIID  ");
            //strSql.Append(" FROM      ProductWorkingInfo INNER JOIN Working ON ProductWorkingInfo.WorkingID = Working.ID ");
            //strSql.Append(" WHERE   (Working.IsSpecial = 1) AND (ProductWorkingInfo.MainID = @MainID)");
            strSql.Append("SELECT  ID, SpecialWork,WorkingID, ColorID, CompanyID, MainID,MaterielID FROM      ProductWorkingInfo ");
            strSql.Append(" WHERE   (MainID = @MainID) ");// And (IsSpecial=1)");
            if(OneAmount>-50)
            strSql.Append(" And (OneAmount=@OneAmount)");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID*-1) ,new SqlParameter("@OneAmount",OneAmount)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetGroup(int TaskID, int OneAmount)
        {
            //StringBuilder strSql = new StringBuilder();
            ////strSql.Append(" SELECT   GroupBy FROM      ProductWorkingInfo WHERE   (MainID = @MainID) GROUP BY GroupBy ORDER BY GroupBy");
            //strSql.Append(" SELECT   ProductWorkingInfo.GroupBy FROM      WorkTicketInfo INNER JOIN ");
            //strSql.Append(" WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ");
            //strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            //strSql.Append(" WHERE   (WorkTicket.OneAmount = @OneAmount) AND (ProductWorkingInfo.MainID = @TaskID) ");
            //strSql.Append(" GROUP BY ProductWorkingInfo.GroupBy");

            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT   GroupBy FROM      ProductWorkingInfo WHERE   (MainID = @MainID) GROUP BY GroupBy ORDER BY GroupBy");
            strSql.Append(" SELECT   ProductWorkingInfo.GroupBy FROM      WorkTicketInfo INNER JOIN ");
            strSql.Append(" WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE   (WorkTicket.OneAmount = @OneAmount) AND (WorkTicketInfo.TaskID = @TaskID) ");
            strSql.Append(" GROUP BY ProductWorkingInfo.GroupBy");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@OneAmount", OneAmount) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetGroupTicket(int TaskID, int OneAmount)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT   GroupBy FROM      ProductWorkingInfo WHERE   (MainID = @MainID) GROUP BY GroupBy ORDER BY GroupBy");
            strSql.Append(" SELECT   ProductWorkingInfo.GroupBy FROM      WorkTicketInfo INNER JOIN ");
            strSql.Append(" WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ");
            strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            strSql.Append(" WHERE   (WorkTicket.OneAmount = @OneAmount) AND (ProductWorkingInfo.MainID = @TaskID) ");
            strSql.Append(" GROUP BY ProductWorkingInfo.GroupBy");

            //StringBuilder strSql = new StringBuilder();
            ////strSql.Append(" SELECT   GroupBy FROM      ProductWorkingInfo WHERE   (MainID = @MainID) GROUP BY GroupBy ORDER BY GroupBy");
            //strSql.Append(" SELECT   ProductWorkingInfo.GroupBy FROM      WorkTicketInfo INNER JOIN ");
            //strSql.Append(" WorkTicket ON WorkTicketInfo.MainID = WorkTicket.ID INNER JOIN ");
            //strSql.Append(" ProductWorkingInfo ON WorkTicketInfo.PWorkingInfoID = ProductWorkingInfo.ID ");
            //strSql.Append(" WHERE   (WorkTicket.OneAmount = @OneAmount) AND (WorkTicketInfo.TaskID = @TaskID) ");
            //strSql.Append(" GROUP BY ProductWorkingInfo.GroupBy");
            SqlParameter[] sps = { new SqlParameter("@TaskID", TaskID), new SqlParameter("@OneAmount", OneAmount) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetProWorkListByPW(int MainID, int MaterielID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID, WorkingID, (SELECT   Name FROM      Working WHERE   (ID = Tem.WorkingID)) AS WorkingName  FROM      (SELECT   ID, WorkingID, Orders ");
            strSql.Append(" FROM      ProductWorkingInfo WHERE   (MainID = @MainID) AND ((SELECT   IsSpecial FROM      Working AS Working_1 WHERE   (ID ");
            strSql.Append(" = ProductWorkingInfo.WorkingID)) = 0) UNION ALL SELECT   ID, WorkingID, Orders FROM ProductWorkingInfo AS ProductWorkingInfo_1 ");
            strSql.Append(" WHERE   (SpecialWork > 0) And (MainID = @MainID * - 1)) AS Tem ORDER BY Orders");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 删除一份工艺单数据
        /// </summary>
        public void DeleteByMainID(int MainID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProductWorkingInfo ");
            strSql.Append(" where MainID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = MainID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public void UpWorkPrice(int ID, decimal Price)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update ProductWorkingInfo set ");
            strSql.Append("Price=@Price");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Price", SqlDbType.Decimal,9)};
            parameters[0].Value = ID;
            parameters[1].Value = Price;
            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }
        public DataSet GetInfoList(int MainID)
        {
            DataSet ds = GetList("(MainID=" + MainID + ") order by Orders");
            ds.Tables[0].TableName = "Main";
            StringBuilder strSql = new StringBuilder();
            if (MainID < 0)
                MainID = 0;
            strSql.Append(" SELECT   (SELECT   Name FROM      Color WHERE   (ID = ProductWorkingInfo.ColorID)) AS ColorName, ");
            strSql.Append(" (SELECT   Name FROM      Size WHERE   (ID = ProductWorkingInfo.MaterielID)) AS SizeName, ");
            strSql.Append(" (SELECT   Name FROM      Company WHERE   (ID = ProductWorkingInfo.CompanyID)) AS CompanyName, ");
            strSql.Append(" Working.Name AS WorkingName,  ProductWorkingInfo.Price,ProductWorkingInfo.IsTicket, ProductWorkingInfo.IsCaiC, ProductWorkingInfo.IsCut, ");
            strSql.Append(" ProductWorkingInfo.PWIID,ProductWorkingInfo.OneAmount,ProductWorkingInfo.IsCanMove ");
            strSql.Append(" FROM      ProductWorkingInfo INNER JOIN Working ON ProductWorkingInfo.WorkingID = Working.ID ");
            strSql.Append(" WHERE   (ProductWorkingInfo.MainID =" + MainID * -1 + ")  ");
            ds.Tables.Add(DbHelperSQL.Query(strSql.ToString()).Tables[0].Copy());
            ds.Tables[1].TableName = "Info";
            try
            {
                ds.Relations.Add("普通工序", ds.Tables["Main"].Columns["ID"], ds.Tables["Info"].Columns["PWIID"]);
            }
            catch (Exception ex)
            {
            }
            return ds;
        }
        public int GetPWIDUseCount(int PWIID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(PWorkingInfoID) AS Expr1 FROM      WorkTicketInfo ");
            strSql.Append(" WHERE   (PWorkingInfoID = "+PWIID+")");
            object o = DbHelperSQL.GetSingle(strSql.ToString());
            if (o != null)
                return Convert.ToInt32(o);
            else
                return 0;
        }
        public int GetPWUseCount(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   COUNT(PWorkingID) AS Expr1 FROM      ProductTaskMain WHERE   (PWorkingID = " + MainID + ")");
            return Convert.ToInt32(DbHelperSQL.GetSingle(strSql.ToString()));

        }
        /// <summary>
        /// 某一工艺单中单箱数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetOneAmount(int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   OneAmount FROM      ProductWorkingInfo WHERE   (MainID = @MainID) GROUP BY OneAmount");
            SqlParameter[] sps = { new SqlParameter("@MainID", MainID) };
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
			parameters[0].Value = "ProductWorkingInfo";
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

