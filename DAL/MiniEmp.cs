using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类MiniEmp。
	/// </summary>
	public class MiniEmp
	{
		public MiniEmp()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "MiniEmp"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MiniEmp");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MiniEmp model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into MiniEmp(");
            strSql.Append("Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccDate,WorkTypeID,PayID,DimDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse,City,County,Remark,IDCardID,IsEnd,Deposit,NeedDeposit,DefaultWorkType,BoardWages,HeTongDate,HeTongAmount,HeTongDQDate,IsCaicTiCheng,MaxAmountDay,BankNO,BankAccountName,BankName)");
            strSql.Append(" values (");
            strSql.Append("@Name,@IntroducerID,@IdentityCard,@Sex,@Sn,@Province,@Address,@Phone,@AccDate,@WorkTypeID,@PayID,@DimDate,@BedID,@TableID,@DepartmentID,@DegreeID,@PolityID,@SOSPhone,@SOSMan,@NowAddress,@FillDate,@FillUser,@LassMoney,@Royalty,@Image,@IsUse,@City,@County,@Remark,@IDCardID,@IsEnd,@Deposit,@NeedDeposit,@DefaultWorkType,@BoardWages,@HeTongDate,@HeTongAmount,@HeTongDQDate,@IsCaicTiCheng,@MaxAmountDay,@BankNO,@BankAccountName,@BankName)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,12),
					new SqlParameter("@IntroducerID", SqlDbType.Int,4),
					new SqlParameter("@IdentityCard", SqlDbType.NVarChar,18),
					new SqlParameter("@Sex", SqlDbType.TinyInt,1),
					new SqlParameter("@Sn", SqlDbType.NVarChar,11),
					new SqlParameter("@Province", SqlDbType.Int,4),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@Phone", SqlDbType.NVarChar,18),
					new SqlParameter("@AccDate", SqlDbType.DateTime),
					new SqlParameter("@WorkTypeID", SqlDbType.NVarChar,200),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@DimDate", SqlDbType.DateTime),
					new SqlParameter("@BedID", SqlDbType.Int,4),
					new SqlParameter("@TableID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@DegreeID", SqlDbType.Int,4),
					new SqlParameter("@PolityID", SqlDbType.Int,4),
					new SqlParameter("@SOSPhone", SqlDbType.NVarChar,18),
					new SqlParameter("@SOSMan", SqlDbType.NVarChar,12),
					new SqlParameter("@NowAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillUser", SqlDbType.Int,4),
					new SqlParameter("@LassMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Royalty", SqlDbType.Decimal,9),
					new SqlParameter("@Image", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@City", SqlDbType.Int,4),
					new SqlParameter("@County", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@IDCardID", SqlDbType.BigInt,8),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@Deposit", SqlDbType.Decimal,9),
					new SqlParameter("@NeedDeposit", SqlDbType.Decimal,9),
					new SqlParameter("@DefaultWorkType", SqlDbType.NVarChar,500),
					new SqlParameter("@BoardWages", SqlDbType.Decimal,9),
					new SqlParameter("@HeTongDate", SqlDbType.DateTime),
					new SqlParameter("@HeTongAmount", SqlDbType.NVarChar,50),
					new SqlParameter("@HeTongDQDate", SqlDbType.DateTime),
					new SqlParameter("@IsCaicTiCheng", SqlDbType.Bit,1),
					new SqlParameter("@MaxAmountDay", SqlDbType.Int,4),
					new SqlParameter("@BankNO", SqlDbType.NVarChar,50),
					new SqlParameter("@BankAccountName", SqlDbType.NVarChar,50),
					new SqlParameter("@BankName", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.IntroducerID;
            parameters[2].Value = model.IdentityCard;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.Sn;
            parameters[5].Value = model.Province;
            parameters[6].Value = model.Address;
            parameters[7].Value = model.Phone;
            parameters[8].Value = model.AccDate;
            parameters[9].Value = model.WorkTypeID;
            parameters[10].Value = model.PayID;
            parameters[11].Value = model.DimDate;
            parameters[12].Value = model.BedID;
            parameters[13].Value = model.TableID;
            parameters[14].Value = model.DepartmentID;
            parameters[15].Value = model.DegreeID;
            parameters[16].Value = model.PolityID;
            parameters[17].Value = model.SOSPhone;
            parameters[18].Value = model.SOSMan;
            parameters[19].Value = model.NowAddress;
            parameters[20].Value = model.FillDate;
            parameters[21].Value = model.FillUser;
            parameters[22].Value = model.LassMoney;
            parameters[23].Value = model.Royalty;
            parameters[24].Value = model.Image;
            parameters[25].Value = model.IsUse;
            parameters[26].Value = model.City;
            parameters[27].Value = model.County;
            parameters[28].Value = model.Remark;
            parameters[29].Value = model.IDCardID;
            parameters[30].Value = model.IsEnd;
            parameters[31].Value = model.Deposit;
            parameters[32].Value = model.NeedDeposit;
            parameters[33].Value = model.DefaultWorkType;
            parameters[34].Value = model.BoardWages;
            parameters[35].Value = model.HeTongDate;
            parameters[36].Value = model.HeTongAmount;
            parameters[37].Value = model.HeTongDQDate;
            parameters[38].Value = model.IsCaicTiCheng;
            parameters[39].Value = model.MaxAmountDay;
            parameters[40].Value = model.BankNO;
            parameters[41].Value = model.BankAccountName;
            parameters[42].Value = model.BankName;

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
        public bool Update(Hownet.Model.MiniEmp model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update MiniEmp set ");
            strSql.Append("Name=@Name,");
            strSql.Append("IntroducerID=@IntroducerID,");
            strSql.Append("IdentityCard=@IdentityCard,");
            strSql.Append("Sex=@Sex,");
            strSql.Append("Sn=@Sn,");
            strSql.Append("Province=@Province,");
            strSql.Append("Address=@Address,");
            strSql.Append("Phone=@Phone,");
            strSql.Append("AccDate=@AccDate,");
            strSql.Append("WorkTypeID=@WorkTypeID,");
            strSql.Append("PayID=@PayID,");
            strSql.Append("DimDate=@DimDate,");
            strSql.Append("BedID=@BedID,");
            strSql.Append("TableID=@TableID,");
            strSql.Append("DepartmentID=@DepartmentID,");
            strSql.Append("DegreeID=@DegreeID,");
            strSql.Append("PolityID=@PolityID,");
            strSql.Append("SOSPhone=@SOSPhone,");
            strSql.Append("SOSMan=@SOSMan,");
            strSql.Append("NowAddress=@NowAddress,");
            strSql.Append("FillDate=@FillDate,");
            strSql.Append("FillUser=@FillUser,");
            strSql.Append("LassMoney=@LassMoney,");
            strSql.Append("Royalty=@Royalty,");
            strSql.Append("Image=@Image,");
            strSql.Append("IsUse=@IsUse,");
            strSql.Append("City=@City,");
            strSql.Append("County=@County,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("IDCardID=@IDCardID,");
            strSql.Append("IsEnd=@IsEnd,");
            strSql.Append("Deposit=@Deposit,");
            strSql.Append("NeedDeposit=@NeedDeposit,");
            strSql.Append("DefaultWorkType=@DefaultWorkType,");
            strSql.Append("BoardWages=@BoardWages,");
            strSql.Append("HeTongDate=@HeTongDate,");
            strSql.Append("HeTongAmount=@HeTongAmount,");
            strSql.Append("HeTongDQDate=@HeTongDQDate,");
            strSql.Append("IsCaicTiCheng=@IsCaicTiCheng,");
            strSql.Append("MaxAmountDay=@MaxAmountDay,");
            strSql.Append("BankNO=@BankNO,");
            strSql.Append("BankAccountName=@BankAccountName,");
            strSql.Append("BankName=@BankName");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@Name", SqlDbType.NVarChar,12),
					new SqlParameter("@IntroducerID", SqlDbType.Int,4),
					new SqlParameter("@IdentityCard", SqlDbType.NVarChar,18),
					new SqlParameter("@Sex", SqlDbType.TinyInt,1),
					new SqlParameter("@Sn", SqlDbType.NVarChar,11),
					new SqlParameter("@Province", SqlDbType.Int,4),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@Phone", SqlDbType.NVarChar,18),
					new SqlParameter("@AccDate", SqlDbType.DateTime),
					new SqlParameter("@WorkTypeID", SqlDbType.NVarChar,200),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@DimDate", SqlDbType.DateTime),
					new SqlParameter("@BedID", SqlDbType.Int,4),
					new SqlParameter("@TableID", SqlDbType.Int,4),
					new SqlParameter("@DepartmentID", SqlDbType.Int,4),
					new SqlParameter("@DegreeID", SqlDbType.Int,4),
					new SqlParameter("@PolityID", SqlDbType.Int,4),
					new SqlParameter("@SOSPhone", SqlDbType.NVarChar,18),
					new SqlParameter("@SOSMan", SqlDbType.NVarChar,12),
					new SqlParameter("@NowAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@FillDate", SqlDbType.DateTime),
					new SqlParameter("@FillUser", SqlDbType.Int,4),
					new SqlParameter("@LassMoney", SqlDbType.Decimal,9),
					new SqlParameter("@Royalty", SqlDbType.Decimal,9),
					new SqlParameter("@Image", SqlDbType.NVarChar,50),
					new SqlParameter("@IsUse", SqlDbType.Bit,1),
					new SqlParameter("@City", SqlDbType.Int,4),
					new SqlParameter("@County", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@IDCardID", SqlDbType.BigInt,8),
					new SqlParameter("@IsEnd", SqlDbType.Int,4),
					new SqlParameter("@Deposit", SqlDbType.Decimal,9),
					new SqlParameter("@NeedDeposit", SqlDbType.Decimal,9),
					new SqlParameter("@DefaultWorkType", SqlDbType.NVarChar,500),
					new SqlParameter("@BoardWages", SqlDbType.Decimal,9),
					new SqlParameter("@HeTongDate", SqlDbType.DateTime),
					new SqlParameter("@HeTongAmount", SqlDbType.NVarChar,50),
					new SqlParameter("@HeTongDQDate", SqlDbType.DateTime),
					new SqlParameter("@IsCaicTiCheng", SqlDbType.Bit,1),
					new SqlParameter("@MaxAmountDay", SqlDbType.Int,4),
					new SqlParameter("@BankNO", SqlDbType.NVarChar,50),
					new SqlParameter("@BankAccountName", SqlDbType.NVarChar,50),
					new SqlParameter("@BankName", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.Name;
            parameters[1].Value = model.IntroducerID;
            parameters[2].Value = model.IdentityCard;
            parameters[3].Value = model.Sex;
            parameters[4].Value = model.Sn;
            parameters[5].Value = model.Province;
            parameters[6].Value = model.Address;
            parameters[7].Value = model.Phone;
            parameters[8].Value = model.AccDate;
            parameters[9].Value = model.WorkTypeID;
            parameters[10].Value = model.PayID;
            parameters[11].Value = model.DimDate;
            parameters[12].Value = model.BedID;
            parameters[13].Value = model.TableID;
            parameters[14].Value = model.DepartmentID;
            parameters[15].Value = model.DegreeID;
            parameters[16].Value = model.PolityID;
            parameters[17].Value = model.SOSPhone;
            parameters[18].Value = model.SOSMan;
            parameters[19].Value = model.NowAddress;
            parameters[20].Value = model.FillDate;
            parameters[21].Value = model.FillUser;
            parameters[22].Value = model.LassMoney;
            parameters[23].Value = model.Royalty;
            parameters[24].Value = model.Image;
            parameters[25].Value = model.IsUse;
            parameters[26].Value = model.City;
            parameters[27].Value = model.County;
            parameters[28].Value = model.Remark;
            parameters[29].Value = model.IDCardID;
            parameters[30].Value = model.IsEnd;
            parameters[31].Value = model.Deposit;
            parameters[32].Value = model.NeedDeposit;
            parameters[33].Value = model.DefaultWorkType;
            parameters[34].Value = model.BoardWages;
            parameters[35].Value = model.HeTongDate;
            parameters[36].Value = model.HeTongAmount;
            parameters[37].Value = model.HeTongDQDate;
            parameters[38].Value = model.IsCaicTiCheng;
            parameters[39].Value = model.MaxAmountDay;
            parameters[40].Value = model.BankNO;
            parameters[41].Value = model.BankAccountName;
            parameters[42].Value = model.BankName;
            parameters[43].Value = model.ID;

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
            strSql.Append("delete from MiniEmp ");
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
            strSql.Append("delete from MiniEmp ");
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
        public Hownet.Model.MiniEmp GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccDate,WorkTypeID,PayID,DimDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse,City,County,Remark,IDCardID,IsEnd,Deposit,NeedDeposit,DefaultWorkType,BoardWages,HeTongDate,HeTongAmount,HeTongDQDate,IsCaicTiCheng,MaxAmountDay,BankNO,BankAccountName,BankName from MiniEmp ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
            parameters[0].Value = ID;

            Hownet.Model.MiniEmp model = new Hownet.Model.MiniEmp();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"] != null && ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                model.Name = ds.Tables[0].Rows[0]["Name"].ToString();
                if (ds.Tables[0].Rows[0]["IntroducerID"] != null && ds.Tables[0].Rows[0]["IntroducerID"].ToString() != "")
                {
                    model.IntroducerID = int.Parse(ds.Tables[0].Rows[0]["IntroducerID"].ToString());
                }
                model.IdentityCard = ds.Tables[0].Rows[0]["IdentityCard"].ToString();
                if (ds.Tables[0].Rows[0]["Sex"] != null && ds.Tables[0].Rows[0]["Sex"].ToString() != "")
                {
                    model.Sex = int.Parse(ds.Tables[0].Rows[0]["Sex"].ToString());
                }
                model.Sn = ds.Tables[0].Rows[0]["Sn"].ToString();
                if (ds.Tables[0].Rows[0]["Province"] != null && ds.Tables[0].Rows[0]["Province"].ToString() != "")
                {
                    model.Province = int.Parse(ds.Tables[0].Rows[0]["Province"].ToString());
                }
                model.Address = ds.Tables[0].Rows[0]["Address"].ToString();
                model.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
                if (ds.Tables[0].Rows[0]["AccDate"] != null && ds.Tables[0].Rows[0]["AccDate"].ToString() != "")
                {
                    model.AccDate = DateTime.Parse(ds.Tables[0].Rows[0]["AccDate"].ToString());
                }
                model.WorkTypeID = ds.Tables[0].Rows[0]["WorkTypeID"].ToString();
                if (ds.Tables[0].Rows[0]["PayID"] != null && ds.Tables[0].Rows[0]["PayID"].ToString() != "")
                {
                    model.PayID = int.Parse(ds.Tables[0].Rows[0]["PayID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DimDate"] != null && ds.Tables[0].Rows[0]["DimDate"].ToString() != "")
                {
                    model.DimDate = DateTime.Parse(ds.Tables[0].Rows[0]["DimDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BedID"] != null && ds.Tables[0].Rows[0]["BedID"].ToString() != "")
                {
                    model.BedID = int.Parse(ds.Tables[0].Rows[0]["BedID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["TableID"] != null && ds.Tables[0].Rows[0]["TableID"].ToString() != "")
                {
                    model.TableID = int.Parse(ds.Tables[0].Rows[0]["TableID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DepartmentID"] != null && ds.Tables[0].Rows[0]["DepartmentID"].ToString() != "")
                {
                    model.DepartmentID = int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DegreeID"] != null && ds.Tables[0].Rows[0]["DegreeID"].ToString() != "")
                {
                    model.DegreeID = int.Parse(ds.Tables[0].Rows[0]["DegreeID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PolityID"] != null && ds.Tables[0].Rows[0]["PolityID"].ToString() != "")
                {
                    model.PolityID = int.Parse(ds.Tables[0].Rows[0]["PolityID"].ToString());
                }
                model.SOSPhone = ds.Tables[0].Rows[0]["SOSPhone"].ToString();
                model.SOSMan = ds.Tables[0].Rows[0]["SOSMan"].ToString();
                model.NowAddress = ds.Tables[0].Rows[0]["NowAddress"].ToString();
                if (ds.Tables[0].Rows[0]["FillDate"] != null && ds.Tables[0].Rows[0]["FillDate"].ToString() != "")
                {
                    model.FillDate = DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillUser"] != null && ds.Tables[0].Rows[0]["FillUser"].ToString() != "")
                {
                    model.FillUser = int.Parse(ds.Tables[0].Rows[0]["FillUser"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LassMoney"] != null && ds.Tables[0].Rows[0]["LassMoney"].ToString() != "")
                {
                    model.LassMoney = decimal.Parse(ds.Tables[0].Rows[0]["LassMoney"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Royalty"] != null && ds.Tables[0].Rows[0]["Royalty"].ToString() != "")
                {
                    model.Royalty = decimal.Parse(ds.Tables[0].Rows[0]["Royalty"].ToString());
                }
                model.Image = ds.Tables[0].Rows[0]["Image"].ToString();
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
                if (ds.Tables[0].Rows[0]["City"] != null && ds.Tables[0].Rows[0]["City"].ToString() != "")
                {
                    model.City = int.Parse(ds.Tables[0].Rows[0]["City"].ToString());
                }
                if (ds.Tables[0].Rows[0]["County"] != null && ds.Tables[0].Rows[0]["County"].ToString() != "")
                {
                    model.County = int.Parse(ds.Tables[0].Rows[0]["County"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["IDCardID"] != null && ds.Tables[0].Rows[0]["IDCardID"].ToString() != "")
                {
                    model.IDCardID = long.Parse(ds.Tables[0].Rows[0]["IDCardID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsEnd"] != null && ds.Tables[0].Rows[0]["IsEnd"].ToString() != "")
                {
                    model.IsEnd = int.Parse(ds.Tables[0].Rows[0]["IsEnd"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Deposit"] != null && ds.Tables[0].Rows[0]["Deposit"].ToString() != "")
                {
                    model.Deposit = decimal.Parse(ds.Tables[0].Rows[0]["Deposit"].ToString());
                }
                if (ds.Tables[0].Rows[0]["NeedDeposit"] != null && ds.Tables[0].Rows[0]["NeedDeposit"].ToString() != "")
                {
                    model.NeedDeposit = decimal.Parse(ds.Tables[0].Rows[0]["NeedDeposit"].ToString());
                }
                model.DefaultWorkType = ds.Tables[0].Rows[0]["DefaultWorkType"].ToString();
                if (ds.Tables[0].Rows[0]["BoardWages"] != null && ds.Tables[0].Rows[0]["BoardWages"].ToString() != "")
                {
                    model.BoardWages = decimal.Parse(ds.Tables[0].Rows[0]["BoardWages"].ToString());
                }
                if (ds.Tables[0].Rows[0]["HeTongDate"] != null && ds.Tables[0].Rows[0]["HeTongDate"].ToString() != "")
                {
                    model.HeTongDate = DateTime.Parse(ds.Tables[0].Rows[0]["HeTongDate"].ToString());
                }
                model.HeTongAmount = ds.Tables[0].Rows[0]["HeTongAmount"].ToString();
                if (ds.Tables[0].Rows[0]["HeTongDQDate"] != null && ds.Tables[0].Rows[0]["HeTongDQDate"].ToString() != "")
                {
                    model.HeTongDQDate = DateTime.Parse(ds.Tables[0].Rows[0]["HeTongDQDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsCaicTiCheng"] != null && ds.Tables[0].Rows[0]["IsCaicTiCheng"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["IsCaicTiCheng"].ToString() == "1") || (ds.Tables[0].Rows[0]["IsCaicTiCheng"].ToString().ToLower() == "true"))
                    {
                        model.IsCaicTiCheng = true;
                    }
                    else
                    {
                        model.IsCaicTiCheng = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["MaxAmountDay"] != null && ds.Tables[0].Rows[0]["MaxAmountDay"].ToString() != "")
                {
                    model.MaxAmountDay = int.Parse(ds.Tables[0].Rows[0]["MaxAmountDay"].ToString());
                }
                model.BankNO = ds.Tables[0].Rows[0]["BankNO"].ToString();
                model.BankAccountName = ds.Tables[0].Rows[0]["BankAccountName"].ToString();
                model.BankName = ds.Tables[0].Rows[0]["BankName"].ToString();
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
            strSql.Append("select  1 as A,ID,Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccDate,WorkTypeID,PayID,DimDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse,City,County,Remark,IDCardID,IsEnd,Deposit,NeedDeposit,DefaultWorkType,BoardWages,HeTongDate,HeTongAmount,HeTongDQDate,IsCaicTiCheng,MaxAmountDay,BankNO,BankAccountName,BankName ");
            strSql.Append(" ,(Select Name From Deparment Where (ID=MiniEmp.DepartmentID)) as DepartmentName");
            strSql.Append(" FROM MiniEmp ");
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
            strSql.Append(" ID,Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccDate,WorkTypeID,PayID,DimDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse,City,County,Remark,IDCardID,IsEnd,Deposit,NeedDeposit,DefaultWorkType,BoardWages,HeTongDate,HeTongAmount,HeTongDQDate,IsCaicTiCheng,MaxAmountDay,BankNO,BankAccountName,BankName ");
            strSql.Append(" FROM MiniEmp ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

      

        /// <summary>
        /// 取得非记时的在职工人名单
        /// </summary>
        /// <returns></returns>
        public DataSet GetWorkList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   Name, Sn, ID, IsEnd,(SELECT   Name FROM      Deparment WHERE   (ID = MiniEmp.DepartmentID)) AS DepartmentName,IsCaicTiCheng,BoardWages ,IDCardID ");
            strSql.Append(" FROM      MiniEmp WHERE   (DimDate IS NULL) OR  (DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102))");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 取得记时的在职工人名单
        /// </summary>
        /// <returns></returns>
        public DataSet GetDayList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID, PayID FROM      MiniEmp WHERE   (DimDate IS NULL OR ");
            strSql.Append(" DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) AND (PayID IN (48, 49, 50))");
            return DbHelperSQL.Query(strSql.ToString());
        }
        /// <summary>
        /// 按ID取出人名
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetName(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Name from MiniEmp where (ID=@ID)");
            SqlParameter[] sp = { new SqlParameter("@ID", ID) };
            return DbHelperSQL.GetSingle(strSql.ToString(), sp).ToString();
        }
        /// <summary>
        /// 根据ID取出Sn
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetSn(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Sn from MiniEmp where (ID=@ID)");
            SqlParameter[] sp = { new SqlParameter("@ID", ID) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sp);
            if (obj != null)
                return obj.ToString();
            else
                return string.Empty;
        }
        /// <summary>
        /// 按编号取出ID
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns></returns>
        public int GetID(string Sn)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID from MiniEmp where (Sn=@Sn) and  (DimDate IS NULL OR DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102))");
            SqlParameter[] sp = { new SqlParameter("@Sn", Sn) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), sp);
            if (obj != null)
            {
                return int.Parse(obj.ToString());
            }
            else
            {
                return 0;
            }
        }
        public DataSet GetCosts(decimal money)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT ID as EmployeeID, @Money AS Money, '' AS Remark, 0 AS ID, 3 AS A,0 as MainID,cast( 0 as bit) as IsDeposit  FROM MiniEmp ");
            strSql.Append(" WHERE (DimDate IS Null) OR  (DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102))");
            SqlParameter[] sps = { new SqlParameter("@Money", money) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        public DataSet GetView()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   ID, Name,Sn, IDCardID,WorkTypeID,DepartmentID FROM      MiniEmp ");
            strSql.Append(" WHERE   ( (DimDate IS NULL)) OR (DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102))");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public DataSet GetViewList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   ID,Sn, Name, (SELECT   Name FROM      Deparment WHERE   (ID = MiniEmp.DepartmentID)) AS DepartmentName,DepartmentID, ");
            strSql.Append(" WorkTypeID,   CASE sex WHEN '1' THEN '男' WHEN '2' ");
            strSql.Append(" THEN '女' END AS Sex, Phone, IdentityCard,PayID, AccDate,IsEnd,DefaultWorkType,Deposit,NeedDeposit,IDCardID,DimDate,DepartmentID,BankNO,BankAccountName,BankName FROM      MiniEmp");
            return DbHelperSQL.Query(strSql.ToString());
        }
        public string GetMaxSn()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MAX(CAST(Sn AS int)) AS Expr1 FROM      MiniEmp");
            object o= DbHelperSQL.GetSingle(strSql.ToString());
            if (o != null)
                return o.ToString();
            else
                return string.Empty;
        }
        public void UpDeposit(int EmployeeID, decimal Deposit, bool t)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE  MiniEmp SET      ");
            if (t)
                strSql.Append(" Deposit =Deposit+ @Deposit ");
            else
                strSql.Append(" Deposit =Deposit- @Deposit ");
            strSql.Append(" WHERE   (ID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@Deposit", Deposit), new SqlParameter("@ID", EmployeeID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
        }
        public DataSet GetBuTieList(int WTID,int MainID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT MiniEmp.DepartmentID,  MiniEmp.ID, Pay.Month FROM      MiniEmp INNER JOIN Pay ON MiniEmp.ID = Pay.EmployeeID ");
            strSql.Append(" WHERE   (LEN(MiniEmp.WorkTypeID) - LEN(REPLACE(MiniEmp.WorkTypeID, ',', '')) < 4) AND (MiniEmp.DimDate IS NULL OR ");
            strSql.Append(" MiniEmp.DimDate = CONVERT(DATETIME, '1900-01-01 00:00:00', 102)) AND (',' + MiniEmp.WorkTypeID + ',' LIKE '%," +WTID + ",%') AND (Pay.MainID = @MainID)");
            SqlParameter[] sps = { new SqlParameter("@WTID", WTID), new SqlParameter("@MainID", MainID) };
            return DbHelperSQL.Query(strSql.ToString(),sps);
        }
        /// <summary>
        /// 已经统计工资的次数
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public int GetCaicPayCount(int EmployeeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   COUNT(Pay.EmployeeID) AS Expr1 FROM      Pay INNER JOIN PayMain ON Pay.MainID = PayMain.ID ");
            strSql.Append(" WHERE   (PayMain.IsVerify = 3) AND (Pay.EmployeeID = @EmployeeID)");
            SqlParameter[] sps = { new SqlParameter("@EmployeeID", EmployeeID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o == null)
                return 0;
            else
                return Convert.ToInt32(o);
        }
        /// <summary>
        /// 获取某类部门下的所有员工
        /// </summary>
        /// <param name="DepTypeID"></param>
        /// <returns></returns>
        public DataSet GetListByDepTypeID(int DepTypeID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT   MiniEmp.ID, MiniEmp.Name FROM      Deparment INNER JOIN MiniEmp ON Deparment.ID = MiniEmp.DepartmentID ");
            strSql.Append(" WHERE   (Deparment.TypeID = @TypeID)");
            SqlParameter[] sps = { new SqlParameter("@TypeID", DepTypeID) };
            return DbHelperSQL.Query(strSql.ToString(), sps);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="TypeID">0为当天，1为当月</param>
        /// <returns></returns>
        public DataSet GetSumAmount(int EmployeeID, int TypeID)
        {
            DateTime dtOne = DateTime.Today;
            DateTime dtTwo = dtOne.AddDays(1);
            if (TypeID == 1)
                dtOne = DateTime.Today.AddDays(DateTime.Today.Day * -1 + 1);

            if (TypeID == 1)
            {
                Hownet.DAL.SysTem dalST = new SysTem();
                Hownet.Model.SysTem modST = dalST.GetModel(dalST.GetMaxId() - 1);
                if (modST.Registration.Trim() != string.Empty)
                {
                    dtOne = DateTime.Parse(dtOne.Year.ToString() + "-" + dtOne.Month.ToString() + "-" + modST.Registration);
                }
                else
                {
                    dtOne = DateTime.Parse(dtOne.Year.ToString() + "-" + dtOne.Month.ToString() + "-" + "01");
                }
            }
            if (dtOne > DateTime.Now.Date)
                dtOne = dtOne.AddMonths(-1);
            StringBuilder strSql = new StringBuilder();
          //  strSql.Append(" SELECT   Materiel.Name AS Materiel, Working.Name AS WorkingName, SUM(PayInfo.Amount) AS Amount, CONVERT(varchar(10), PayInfo.DateTime, 120) AS DateTime  FROM      PayInfo INNER JOIN ");
            //strSql.Append(" MiniEmp ON PayInfo.EmployeeID = MiniEmp.ID INNER JOIN Materiel ON PayInfo.MaterielID = Materiel.ID INNER JOIN ");
           // strSql.Append(" Working ON PayInfo.WorkingID = Working.ID WHERE   (PayInfo.DateTime < @dtTwo) AND (PayInfo.DateTime >= @dtOne) AND (MiniEmp.IDCardID = @CardID) ");
            //strSql.Append(" GROUP BY PayInfo.WorkingID, PayInfo.MaterielID, MiniEmp.Name, MiniEmp.Sn, Materiel.Name, Working.Name ORDER BY PayInfo.MaterielID, PayInfo.WorkingID, CONVERT(varchar(10), PayInfo.DateTime, 120)  ");
            strSql.Append("SELECT     Materiel.Name AS Materiel, Working.Name AS WorkingName, SUM(PayInfo.Amount) AS Amount,RIGHT( CONVERT(varchar(10), PayInfo.DateTime, 120),5) AS DateTime ");
            strSql.Append(" FROM         PayInfo INNER JOIN MiniEmp ON PayInfo.EmployeeID = MiniEmp.ID INNER JOIN Materiel ON PayInfo.MaterielID = Materiel.ID INNER JOIN ");
            strSql.Append(" Working ON PayInfo.WorkingID = Working.ID WHERE     (PayInfo.DateTime < @dtTwo) AND (PayInfo.DateTime >= @dtOne) AND (MiniEmp.IDCardID = @CardID) "); 
            strSql.Append(" GROUP BY PayInfo.WorkingID, PayInfo.MaterielID, MiniEmp.Name, MiniEmp.Sn, Materiel.Name, Working.Name, CONVERT(varchar(10), PayInfo.DateTime, 120) ");
            strSql.Append(" ORDER BY DateTime, Materiel, WorkingName");
            
            SqlParameter[] sps = {new SqlParameter("@CardID",EmployeeID),
                                 new SqlParameter("@dtOne",dtOne),
                                 new SqlParameter("@dtTwo",dtTwo)};
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }
        public DataSet GetSumAmountByID(int EmployeeID, DateTime dt1,DateTime dt2)
        {
            //DateTime dtOne = DateTime.Today;
            //DateTime dtTwo = dtOne.AddDays(1);
            //if (TypeID == 1)
            //    dtOne = DateTime.Today.AddDays(DateTime.Today.Day * -1 + 1);
            //StringBuilder strSql = new StringBuilder();
            //strSql.Append(" SELECT   Materiel.Name AS Materiel, Working.Name AS WorkingName, SUM(PayInfo.Amount) AS Amount FROM      PayInfo INNER JOIN ");
            //strSql.Append(" MiniEmp ON PayInfo.EmployeeID = MiniEmp.ID INNER JOIN Materiel ON PayInfo.MaterielID = Materiel.ID INNER JOIN ");
            //strSql.Append(" Working ON PayInfo.WorkingID = Working.ID WHERE   (PayInfo.DateTime < @dtTwo) AND (PayInfo.DateTime >= @dtOne) AND (MiniEmp.ID = @CardID) ");
            //strSql.Append(" GROUP BY PayInfo.WorkingID, PayInfo.MaterielID, MiniEmp.Name, MiniEmp.Sn, Materiel.Name, Working.Name ORDER BY PayInfo.MaterielID, PayInfo.WorkingID ");
            //SqlParameter[] sps = {new SqlParameter("@CardID",EmployeeID),
            //                     new SqlParameter("@dtOne",dtOne),
            //                     new SqlParameter("@dtTwo",dtTwo)};
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT     Materiel.Name AS Materiel, Working.Name AS WorkingName, SUM(PayInfo.Amount) AS Amount,RIGHT( CONVERT(varchar(10), PayInfo.DateTime, 120),5) AS DateTime ");
            strSql.Append(" FROM         PayInfo INNER JOIN MiniEmp ON PayInfo.EmployeeID = MiniEmp.ID INNER JOIN Materiel ON PayInfo.MaterielID = Materiel.ID INNER JOIN ");
            strSql.Append(" Working ON PayInfo.WorkingID = Working.ID WHERE     (PayInfo.DateTime < @dtTwo) AND (PayInfo.DateTime >= @dtOne) AND (MiniEmp.IDCardID = @CardID) ");
            strSql.Append(" GROUP BY PayInfo.WorkingID, PayInfo.MaterielID, MiniEmp.Name, MiniEmp.Sn, Materiel.Name, Working.Name, CONVERT(varchar(10), PayInfo.DateTime, 120) ");
            strSql.Append(" ORDER BY DateTime, Materiel, WorkingName");

            SqlParameter[] sps = {new SqlParameter("@CardID",EmployeeID),
                                 new SqlParameter("@dtOne",dt1),
                                 new SqlParameter("@dtTwo",dt2)};
            return DbHelperSQL.Query(strSql.ToString(), sps);
            return DbHelperSQL.Query(strSql.ToString(), sps);

        }
        public bool GetSumAmountByEMP(int EmployeeID)
        {
            DateTime dtOne = DateTime.Today;
            DateTime dtTwo = dtOne.AddDays(1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" SELECT   SUM(PayInfo.Amount) AS Amount, MiniEmp.MaxAmountDay FROM      PayInfo INNER JOIN MiniEmp ON PayInfo.EmployeeID = MiniEmp.ID ");
            strSql.Append(" WHERE   (PayInfo.DateTime >= @dt1) AND (PayInfo.DateTime < @dt2) AND (PayInfo.EmployeeID = @EmpID) GROUP BY MiniEmp.MaxAmountDay");
            SqlParameter[] sps = {new SqlParameter("@EmpID",EmployeeID),new SqlParameter("@dt1",dtOne),new SqlParameter("@dt2",dtTwo)};
            DataTable dt = DbHelperSQL.Query(strSql.ToString(), sps).Tables[0];
            if (dt.Rows.Count == 0)//没有记录，则是可以继续刷卡
            { return false; }
            else
            {
                if (Convert.ToInt32(dt.Rows[0][1]) == 0)//没有设置最大数量，可以继续刷卡
                    return false;
                else
                    return Convert.ToInt32(dt.Rows[0][0]) > Convert.ToInt32(dt.Rows[0][1]);//如果已刷数量大于设置数量，不能继续刷卡
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
			parameters[0].Value = "MiniEmp";
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

