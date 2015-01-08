using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类Employee。
	/// </summary>
	public class Employee
	{
		public Employee()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Employee"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Employee");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Employee(");
			strSql.Append("Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccessionDate,WorkTypeID,PayID,DimissionDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse)");
			strSql.Append(" values (");
			strSql.Append("@Name,@IntroducerID,@IdentityCard,@Sex,@Sn,@Province,@Address,@Phone,@AccessionDate,@WorkTypeID,@PayID,@DimissionDate,@BedID,@TableID,@DepartmentID,@DegreeID,@PolityID,@SOSPhone,@SOSMan,@NowAddress,@FillDate,@FillUser,@LassMoney,@Royalty,@Image,@IsUse)");
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
					new SqlParameter("@AccessionDate", SqlDbType.DateTime),
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@DimissionDate", SqlDbType.DateTime),
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
					new SqlParameter("@IsUse", SqlDbType.Bit,1)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.IntroducerID;
			parameters[2].Value = model.IdentityCard;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.Sn;
			parameters[5].Value = model.Province;
			parameters[6].Value = model.Address;
			parameters[7].Value = model.Phone;
			parameters[8].Value = model.AccessionDate;
			parameters[9].Value = model.WorkTypeID;
			parameters[10].Value = model.PayID;
			parameters[11].Value = model.DimissionDate;
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

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
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
		public void Update(Hownet.Model.Employee model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Employee set ");
			strSql.Append("Name=@Name,");
			strSql.Append("IntroducerID=@IntroducerID,");
			strSql.Append("IdentityCard=@IdentityCard,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("Sn=@Sn,");
			strSql.Append("Province=@Province,");
			strSql.Append("Address=@Address,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("AccessionDate=@AccessionDate,");
			strSql.Append("WorkTypeID=@WorkTypeID,");
			strSql.Append("PayID=@PayID,");
			strSql.Append("DimissionDate=@DimissionDate,");
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
			strSql.Append("IsUse=@IsUse");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Name", SqlDbType.NVarChar,12),
					new SqlParameter("@IntroducerID", SqlDbType.Int,4),
					new SqlParameter("@IdentityCard", SqlDbType.NVarChar,18),
					new SqlParameter("@Sex", SqlDbType.TinyInt,1),
					new SqlParameter("@Sn", SqlDbType.NVarChar,11),
					new SqlParameter("@Province", SqlDbType.Int,4),
					new SqlParameter("@Address", SqlDbType.NVarChar,255),
					new SqlParameter("@Phone", SqlDbType.NVarChar,18),
					new SqlParameter("@AccessionDate", SqlDbType.DateTime),
					new SqlParameter("@WorkTypeID", SqlDbType.Int,4),
					new SqlParameter("@PayID", SqlDbType.Int,4),
					new SqlParameter("@DimissionDate", SqlDbType.DateTime),
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
					new SqlParameter("@IsUse", SqlDbType.Bit,1)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.IntroducerID;
			parameters[3].Value = model.IdentityCard;
			parameters[4].Value = model.Sex;
			parameters[5].Value = model.Sn;
			parameters[6].Value = model.Province;
			parameters[7].Value = model.Address;
			parameters[8].Value = model.Phone;
			parameters[9].Value = model.AccessionDate;
			parameters[10].Value = model.WorkTypeID;
			parameters[11].Value = model.PayID;
			parameters[12].Value = model.DimissionDate;
			parameters[13].Value = model.BedID;
			parameters[14].Value = model.TableID;
			parameters[15].Value = model.DepartmentID;
			parameters[16].Value = model.DegreeID;
			parameters[17].Value = model.PolityID;
			parameters[18].Value = model.SOSPhone;
			parameters[19].Value = model.SOSMan;
			parameters[20].Value = model.NowAddress;
			parameters[21].Value = model.FillDate;
			parameters[22].Value = model.FillUser;
			parameters[23].Value = model.LassMoney;
			parameters[24].Value = model.Royalty;
			parameters[25].Value = model.Image;
			parameters[26].Value = model.IsUse;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Employee ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.Employee GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccessionDate,WorkTypeID,PayID,DimissionDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse from Employee ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			Hownet.Model.Employee model=new Hownet.Model.Employee();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				model.Name=ds.Tables[0].Rows[0]["Name"].ToString();
				if(ds.Tables[0].Rows[0]["IntroducerID"].ToString()!="")
				{
					model.IntroducerID=int.Parse(ds.Tables[0].Rows[0]["IntroducerID"].ToString());
				}
				model.IdentityCard=ds.Tables[0].Rows[0]["IdentityCard"].ToString();
				if(ds.Tables[0].Rows[0]["Sex"].ToString()!="")
				{
					model.Sex=int.Parse(ds.Tables[0].Rows[0]["Sex"].ToString());
				}
				model.Sn=ds.Tables[0].Rows[0]["Sn"].ToString();
				if(ds.Tables[0].Rows[0]["Province"].ToString()!="")
				{
					model.Province=int.Parse(ds.Tables[0].Rows[0]["Province"].ToString());
				}
				model.Address=ds.Tables[0].Rows[0]["Address"].ToString();
				model.Phone=ds.Tables[0].Rows[0]["Phone"].ToString();
				if(ds.Tables[0].Rows[0]["AccessionDate"].ToString()!="")
				{
					model.AccessionDate=DateTime.Parse(ds.Tables[0].Rows[0]["AccessionDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["WorkTypeID"].ToString()!="")
				{
					model.WorkTypeID=int.Parse(ds.Tables[0].Rows[0]["WorkTypeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PayID"].ToString()!="")
				{
					model.PayID=int.Parse(ds.Tables[0].Rows[0]["PayID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DimissionDate"].ToString()!="")
				{
					model.DimissionDate=DateTime.Parse(ds.Tables[0].Rows[0]["DimissionDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BedID"].ToString()!="")
				{
					model.BedID=int.Parse(ds.Tables[0].Rows[0]["BedID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["TableID"].ToString()!="")
				{
					model.TableID=int.Parse(ds.Tables[0].Rows[0]["TableID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DepartmentID"].ToString()!="")
				{
					model.DepartmentID=int.Parse(ds.Tables[0].Rows[0]["DepartmentID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["DegreeID"].ToString()!="")
				{
					model.DegreeID=int.Parse(ds.Tables[0].Rows[0]["DegreeID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["PolityID"].ToString()!="")
				{
					model.PolityID=int.Parse(ds.Tables[0].Rows[0]["PolityID"].ToString());
				}
				model.SOSPhone=ds.Tables[0].Rows[0]["SOSPhone"].ToString();
				model.SOSMan=ds.Tables[0].Rows[0]["SOSMan"].ToString();
				model.NowAddress=ds.Tables[0].Rows[0]["NowAddress"].ToString();
				if(ds.Tables[0].Rows[0]["FillDate"].ToString()!="")
				{
					model.FillDate=DateTime.Parse(ds.Tables[0].Rows[0]["FillDate"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FillUser"].ToString()!="")
				{
					model.FillUser=int.Parse(ds.Tables[0].Rows[0]["FillUser"].ToString());
				}
				if(ds.Tables[0].Rows[0]["LassMoney"].ToString()!="")
				{
					model.LassMoney=decimal.Parse(ds.Tables[0].Rows[0]["LassMoney"].ToString());
				}
				if(ds.Tables[0].Rows[0]["Royalty"].ToString()!="")
				{
					model.Royalty=decimal.Parse(ds.Tables[0].Rows[0]["Royalty"].ToString());
				}
				model.Image=ds.Tables[0].Rows[0]["Image"].ToString();
				if(ds.Tables[0].Rows[0]["IsUse"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsUse"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsUse"].ToString().ToLower()=="true"))
					{
						model.IsUse=true;
					}
					else
					{
						model.IsUse=false;
					}
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
			strSql.Append("select 1 as A,ID,Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccessionDate,WorkTypeID,PayID,DimissionDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse ");
			strSql.Append(" FROM Employee ");
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
			strSql.Append(" ID,Name,IntroducerID,IdentityCard,Sex,Sn,Province,Address,Phone,AccessionDate,WorkTypeID,PayID,DimissionDate,BedID,TableID,DepartmentID,DegreeID,PolityID,SOSPhone,SOSMan,NowAddress,FillDate,FillUser,LassMoney,Royalty,Image,IsUse ");
			strSql.Append(" FROM Employee ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
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
			parameters[0].Value = "Employee";
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

