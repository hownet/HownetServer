using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//请先添加引用
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类SampleMain。
	/// </summary>
	public class SampleMain
	{
		public SampleMain()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "SampleMain"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SampleMain");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.SampleMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into SampleMain(");
            strSql.Append("CompanyID,BrandID,Season,MTID,Fabric,MainCloth1,MainCloth2,MinorCloth1,MinorCloth2,MainCloth1Remark,MainCloth2Remak,MinorCloth1Remark,MinorCloth2Remark,DateTime,POID,CompanyMateriel,MaterielID,SumAmount,BackSampleDate,AskBackDate,BillingMan,Counter,RevisedCounter,Approval,TextSample,ShowSample,PhotoSample,SizeSet1,SizeSet2,SizeSet3,SalesmanSample,ProductionSample,ShipmentSample,UpData,FillMan,IsVerify,VerifyMan,VerifyDate,Remark,Stata,OderMainID,LastEdit,LastEditDate,EditRemark,GenDan,BanFangGengDan,ZhiYang,CheBan,BanFangZhuGuang,ShengChanBu,Size1,Size2,BackAmount,HaveOld,SizeRefer,TaskRemark,BrandRemark,Images,BrandImages,DefaultSTID)");
            strSql.Append(" values (");
            strSql.Append("@CompanyID,@BrandID,@Season,@MTID,@Fabric,@MainCloth1,@MainCloth2,@MinorCloth1,@MinorCloth2,@MainCloth1Remark,@MainCloth2Remak,@MinorCloth1Remark,@MinorCloth2Remark,@DateTime,@POID,@CompanyMateriel,@MaterielID,@SumAmount,@BackSampleDate,@AskBackDate,@BillingMan,@Counter,@RevisedCounter,@Approval,@TextSample,@ShowSample,@PhotoSample,@SizeSet1,@SizeSet2,@SizeSet3,@SalesmanSample,@ProductionSample,@ShipmentSample,@UpData,@FillMan,@IsVerify,@VerifyMan,@VerifyDate,@Remark,@Stata,@OderMainID,@LastEdit,@LastEditDate,@EditRemark,@GenDan,@BanFangGengDan,@ZhiYang,@CheBan,@BanFangZhuGuang,@ShengChanBu,@Size1,@Size2,@BackAmount,@HaveOld,@SizeRefer,@TaskRemark,@BrandRemark,@Images,@BrandImages,@DefaultSTID)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Season", SqlDbType.NVarChar,50),
					new SqlParameter("@MTID", SqlDbType.Int,4),
					new SqlParameter("@Fabric", SqlDbType.NVarChar,200),
					new SqlParameter("@MainCloth1", SqlDbType.NVarChar,50),
					new SqlParameter("@MainCloth2", SqlDbType.NVarChar,50),
					new SqlParameter("@MinorCloth1", SqlDbType.NVarChar,50),
					new SqlParameter("@MinorCloth2", SqlDbType.NVarChar,50),
					new SqlParameter("@MainCloth1Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@MainCloth2Remak", SqlDbType.NVarChar,200),
					new SqlParameter("@MinorCloth1Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@MinorCloth2Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@POID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyMateriel", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielID", SqlDbType.NVarChar,50),
					new SqlParameter("@SumAmount", SqlDbType.Int,4),
					new SqlParameter("@BackSampleDate", SqlDbType.DateTime),
					new SqlParameter("@AskBackDate", SqlDbType.DateTime),
					new SqlParameter("@BillingMan", SqlDbType.NVarChar,50),
					new SqlParameter("@Counter", SqlDbType.Bit,1),
					new SqlParameter("@RevisedCounter", SqlDbType.Bit,1),
					new SqlParameter("@Approval", SqlDbType.Bit,1),
					new SqlParameter("@TextSample", SqlDbType.Bit,1),
					new SqlParameter("@ShowSample", SqlDbType.Bit,1),
					new SqlParameter("@PhotoSample", SqlDbType.Bit,1),
					new SqlParameter("@SizeSet1", SqlDbType.Bit,1),
					new SqlParameter("@SizeSet2", SqlDbType.Bit,1),
					new SqlParameter("@SizeSet3", SqlDbType.Bit,1),
					new SqlParameter("@SalesmanSample", SqlDbType.Bit,1),
					new SqlParameter("@ProductionSample", SqlDbType.Bit,1),
					new SqlParameter("@ShipmentSample", SqlDbType.Bit,1),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Stata", SqlDbType.Int,4),
					new SqlParameter("@OderMainID", SqlDbType.Int,4),
					new SqlParameter("@LastEdit", SqlDbType.Int,4),
					new SqlParameter("@LastEditDate", SqlDbType.DateTime),
					new SqlParameter("@EditRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@GenDan", SqlDbType.NVarChar,50),
					new SqlParameter("@BanFangGengDan", SqlDbType.NVarChar,50),
					new SqlParameter("@ZhiYang", SqlDbType.NVarChar,50),
					new SqlParameter("@CheBan", SqlDbType.NVarChar,50),
					new SqlParameter("@BanFangZhuGuang", SqlDbType.NVarChar,50),
					new SqlParameter("@ShengChanBu", SqlDbType.NVarChar,50),
					new SqlParameter("@Size1", SqlDbType.NVarChar,50),
					new SqlParameter("@Size2", SqlDbType.NVarChar,50),
					new SqlParameter("@BackAmount", SqlDbType.NVarChar,50),
					new SqlParameter("@HaveOld", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeRefer", SqlDbType.NVarChar,50),
					new SqlParameter("@TaskRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@BrandRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Images", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandImages", SqlDbType.NVarChar,50),
					new SqlParameter("@DefaultSTID", SqlDbType.Int,4)};
            parameters[0].Value = model.CompanyID;
            parameters[1].Value = model.BrandID;
            parameters[2].Value = model.Season;
            parameters[3].Value = model.MTID;
            parameters[4].Value = model.Fabric;
            parameters[5].Value = model.MainCloth1;
            parameters[6].Value = model.MainCloth2;
            parameters[7].Value = model.MinorCloth1;
            parameters[8].Value = model.MinorCloth2;
            parameters[9].Value = model.MainCloth1Remark;
            parameters[10].Value = model.MainCloth2Remak;
            parameters[11].Value = model.MinorCloth1Remark;
            parameters[12].Value = model.MinorCloth2Remark;
            parameters[13].Value = model.DateTime;
            parameters[14].Value = model.POID;
            parameters[15].Value = model.CompanyMateriel;
            parameters[16].Value = model.MaterielID;
            parameters[17].Value = model.SumAmount;
            parameters[18].Value = model.BackSampleDate;
            parameters[19].Value = model.AskBackDate;
            parameters[20].Value = model.BillingMan;
            parameters[21].Value = model.Counter;
            parameters[22].Value = model.RevisedCounter;
            parameters[23].Value = model.Approval;
            parameters[24].Value = model.TextSample;
            parameters[25].Value = model.ShowSample;
            parameters[26].Value = model.PhotoSample;
            parameters[27].Value = model.SizeSet1;
            parameters[28].Value = model.SizeSet2;
            parameters[29].Value = model.SizeSet3;
            parameters[30].Value = model.SalesmanSample;
            parameters[31].Value = model.ProductionSample;
            parameters[32].Value = model.ShipmentSample;
            parameters[33].Value = model.UpData;
            parameters[34].Value = model.FillMan;
            parameters[35].Value = model.IsVerify;
            parameters[36].Value = model.VerifyMan;
            parameters[37].Value = model.VerifyDate;
            parameters[38].Value = model.Remark;
            parameters[39].Value = model.Stata;
            parameters[40].Value = model.OderMainID;
            parameters[41].Value = model.LastEdit;
            parameters[42].Value = model.LastEditDate;
            parameters[43].Value = model.EditRemark;
            parameters[44].Value = model.GenDan;
            parameters[45].Value = model.BanFangGengDan;
            parameters[46].Value = model.ZhiYang;
            parameters[47].Value = model.CheBan;
            parameters[48].Value = model.BanFangZhuGuang;
            parameters[49].Value = model.ShengChanBu;
            parameters[50].Value = model.Size1;
            parameters[51].Value = model.Size2;
            parameters[52].Value = model.BackAmount;
            parameters[53].Value = model.HaveOld;
            parameters[54].Value = model.SizeRefer;
            parameters[55].Value = model.TaskRemark;
            parameters[56].Value = model.BrandRemark;
            parameters[57].Value = model.Images;
            parameters[58].Value = model.BrandImages;
            parameters[59].Value = model.DefaultSTID;

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
        public void Update(Hownet.Model.SampleMain model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update SampleMain set ");
            strSql.Append("CompanyID=@CompanyID,");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("Season=@Season,");
            strSql.Append("MTID=@MTID,");
            strSql.Append("Fabric=@Fabric,");
            strSql.Append("MainCloth1=@MainCloth1,");
            strSql.Append("MainCloth2=@MainCloth2,");
            strSql.Append("MinorCloth1=@MinorCloth1,");
            strSql.Append("MinorCloth2=@MinorCloth2,");
            strSql.Append("MainCloth1Remark=@MainCloth1Remark,");
            strSql.Append("MainCloth2Remak=@MainCloth2Remak,");
            strSql.Append("MinorCloth1Remark=@MinorCloth1Remark,");
            strSql.Append("MinorCloth2Remark=@MinorCloth2Remark,");
            strSql.Append("DateTime=@DateTime,");
            strSql.Append("POID=@POID,");
            strSql.Append("CompanyMateriel=@CompanyMateriel,");
            strSql.Append("MaterielID=@MaterielID,");
            strSql.Append("SumAmount=@SumAmount,");
            strSql.Append("BackSampleDate=@BackSampleDate,");
            strSql.Append("AskBackDate=@AskBackDate,");
            strSql.Append("BillingMan=@BillingMan,");
            strSql.Append("Counter=@Counter,");
            strSql.Append("RevisedCounter=@RevisedCounter,");
            strSql.Append("Approval=@Approval,");
            strSql.Append("TextSample=@TextSample,");
            strSql.Append("ShowSample=@ShowSample,");
            strSql.Append("PhotoSample=@PhotoSample,");
            strSql.Append("SizeSet1=@SizeSet1,");
            strSql.Append("SizeSet2=@SizeSet2,");
            strSql.Append("SizeSet3=@SizeSet3,");
            strSql.Append("SalesmanSample=@SalesmanSample,");
            strSql.Append("ProductionSample=@ProductionSample,");
            strSql.Append("ShipmentSample=@ShipmentSample,");
            strSql.Append("UpData=@UpData,");
            strSql.Append("FillMan=@FillMan,");
            strSql.Append("IsVerify=@IsVerify,");
            strSql.Append("VerifyMan=@VerifyMan,");
            strSql.Append("VerifyDate=@VerifyDate,");
            strSql.Append("Remark=@Remark,");
            strSql.Append("Stata=@Stata,");
            strSql.Append("OderMainID=@OderMainID,");
            strSql.Append("LastEdit=@LastEdit,");
            strSql.Append("LastEditDate=@LastEditDate,");
            strSql.Append("EditRemark=@EditRemark,");
            strSql.Append("GenDan=@GenDan,");
            strSql.Append("BanFangGengDan=@BanFangGengDan,");
            strSql.Append("ZhiYang=@ZhiYang,");
            strSql.Append("CheBan=@CheBan,");
            strSql.Append("BanFangZhuGuang=@BanFangZhuGuang,");
            strSql.Append("ShengChanBu=@ShengChanBu,");
            strSql.Append("Size1=@Size1,");
            strSql.Append("Size2=@Size2,");
            strSql.Append("BackAmount=@BackAmount,");
            strSql.Append("HaveOld=@HaveOld,");
            strSql.Append("SizeRefer=@SizeRefer,");
            strSql.Append("TaskRemark=@TaskRemark,");
            strSql.Append("BrandRemark=@BrandRemark,");
            strSql.Append("Images=@Images,");
            strSql.Append("BrandImages=@BrandImages,");
            strSql.Append("DefaultSTID=@DefaultSTID");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@CompanyID", SqlDbType.Int,4),
					new SqlParameter("@BrandID", SqlDbType.Int,4),
					new SqlParameter("@Season", SqlDbType.NVarChar,50),
					new SqlParameter("@MTID", SqlDbType.Int,4),
					new SqlParameter("@Fabric", SqlDbType.NVarChar,200),
					new SqlParameter("@MainCloth1", SqlDbType.NVarChar,50),
					new SqlParameter("@MainCloth2", SqlDbType.NVarChar,50),
					new SqlParameter("@MinorCloth1", SqlDbType.NVarChar,50),
					new SqlParameter("@MinorCloth2", SqlDbType.NVarChar,50),
					new SqlParameter("@MainCloth1Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@MainCloth2Remak", SqlDbType.NVarChar,200),
					new SqlParameter("@MinorCloth1Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@MinorCloth2Remark", SqlDbType.NVarChar,200),
					new SqlParameter("@DateTime", SqlDbType.DateTime),
					new SqlParameter("@POID", SqlDbType.NVarChar,50),
					new SqlParameter("@CompanyMateriel", SqlDbType.NVarChar,50),
					new SqlParameter("@MaterielID", SqlDbType.NVarChar,50),
					new SqlParameter("@SumAmount", SqlDbType.Int,4),
					new SqlParameter("@BackSampleDate", SqlDbType.DateTime),
					new SqlParameter("@AskBackDate", SqlDbType.DateTime),
					new SqlParameter("@BillingMan", SqlDbType.NVarChar,50),
					new SqlParameter("@Counter", SqlDbType.Bit,1),
					new SqlParameter("@RevisedCounter", SqlDbType.Bit,1),
					new SqlParameter("@Approval", SqlDbType.Bit,1),
					new SqlParameter("@TextSample", SqlDbType.Bit,1),
					new SqlParameter("@ShowSample", SqlDbType.Bit,1),
					new SqlParameter("@PhotoSample", SqlDbType.Bit,1),
					new SqlParameter("@SizeSet1", SqlDbType.Bit,1),
					new SqlParameter("@SizeSet2", SqlDbType.Bit,1),
					new SqlParameter("@SizeSet3", SqlDbType.Bit,1),
					new SqlParameter("@SalesmanSample", SqlDbType.Bit,1),
					new SqlParameter("@ProductionSample", SqlDbType.Bit,1),
					new SqlParameter("@ShipmentSample", SqlDbType.Bit,1),
					new SqlParameter("@UpData", SqlDbType.Int,4),
					new SqlParameter("@FillMan", SqlDbType.Int,4),
					new SqlParameter("@IsVerify", SqlDbType.Int,4),
					new SqlParameter("@VerifyMan", SqlDbType.Int,4),
					new SqlParameter("@VerifyDate", SqlDbType.DateTime),
					new SqlParameter("@Remark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Stata", SqlDbType.Int,4),
					new SqlParameter("@OderMainID", SqlDbType.Int,4),
					new SqlParameter("@LastEdit", SqlDbType.Int,4),
					new SqlParameter("@LastEditDate", SqlDbType.DateTime),
					new SqlParameter("@EditRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@GenDan", SqlDbType.NVarChar,50),
					new SqlParameter("@BanFangGengDan", SqlDbType.NVarChar,50),
					new SqlParameter("@ZhiYang", SqlDbType.NVarChar,50),
					new SqlParameter("@CheBan", SqlDbType.NVarChar,50),
					new SqlParameter("@BanFangZhuGuang", SqlDbType.NVarChar,50),
					new SqlParameter("@ShengChanBu", SqlDbType.NVarChar,50),
					new SqlParameter("@Size1", SqlDbType.NVarChar,50),
					new SqlParameter("@Size2", SqlDbType.NVarChar,50),
					new SqlParameter("@BackAmount", SqlDbType.NVarChar,50),
					new SqlParameter("@HaveOld", SqlDbType.NVarChar,50),
					new SqlParameter("@SizeRefer", SqlDbType.NVarChar,50),
					new SqlParameter("@TaskRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@BrandRemark", SqlDbType.NVarChar,2000),
					new SqlParameter("@Images", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandImages", SqlDbType.NVarChar,50),
					new SqlParameter("@DefaultSTID", SqlDbType.Int,4)};
            parameters[0].Value = model.ID;
            parameters[1].Value = model.CompanyID;
            parameters[2].Value = model.BrandID;
            parameters[3].Value = model.Season;
            parameters[4].Value = model.MTID;
            parameters[5].Value = model.Fabric;
            parameters[6].Value = model.MainCloth1;
            parameters[7].Value = model.MainCloth2;
            parameters[8].Value = model.MinorCloth1;
            parameters[9].Value = model.MinorCloth2;
            parameters[10].Value = model.MainCloth1Remark;
            parameters[11].Value = model.MainCloth2Remak;
            parameters[12].Value = model.MinorCloth1Remark;
            parameters[13].Value = model.MinorCloth2Remark;
            parameters[14].Value = model.DateTime;
            parameters[15].Value = model.POID;
            parameters[16].Value = model.CompanyMateriel;
            parameters[17].Value = model.MaterielID;
            parameters[18].Value = model.SumAmount;
            parameters[19].Value = model.BackSampleDate;
            parameters[20].Value = model.AskBackDate;
            parameters[21].Value = model.BillingMan;
            parameters[22].Value = model.Counter;
            parameters[23].Value = model.RevisedCounter;
            parameters[24].Value = model.Approval;
            parameters[25].Value = model.TextSample;
            parameters[26].Value = model.ShowSample;
            parameters[27].Value = model.PhotoSample;
            parameters[28].Value = model.SizeSet1;
            parameters[29].Value = model.SizeSet2;
            parameters[30].Value = model.SizeSet3;
            parameters[31].Value = model.SalesmanSample;
            parameters[32].Value = model.ProductionSample;
            parameters[33].Value = model.ShipmentSample;
            parameters[34].Value = model.UpData;
            parameters[35].Value = model.FillMan;
            parameters[36].Value = model.IsVerify;
            parameters[37].Value = model.VerifyMan;
            parameters[38].Value = model.VerifyDate;
            parameters[39].Value = model.Remark;
            parameters[40].Value = model.Stata;
            parameters[41].Value = model.OderMainID;
            parameters[42].Value = model.LastEdit;
            parameters[43].Value = model.LastEditDate;
            parameters[44].Value = model.EditRemark;
            parameters[45].Value = model.GenDan;
            parameters[46].Value = model.BanFangGengDan;
            parameters[47].Value = model.ZhiYang;
            parameters[48].Value = model.CheBan;
            parameters[49].Value = model.BanFangZhuGuang;
            parameters[50].Value = model.ShengChanBu;
            parameters[51].Value = model.Size1;
            parameters[52].Value = model.Size2;
            parameters[53].Value = model.BackAmount;
            parameters[54].Value = model.HaveOld;
            parameters[55].Value = model.SizeRefer;
            parameters[56].Value = model.TaskRemark;
            parameters[57].Value = model.BrandRemark;
            parameters[58].Value = model.Images;
            parameters[59].Value = model.BrandImages;
            parameters[60].Value = model.DefaultSTID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from SampleMain ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            DbHelperSQL.ExecuteSql(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.SampleMain GetModel(int ID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,CompanyID,BrandID,Season,MTID,Fabric,MainCloth1,MainCloth2,MinorCloth1,MinorCloth2,MainCloth1Remark,MainCloth2Remak,MinorCloth1Remark,MinorCloth2Remark,DateTime,POID,CompanyMateriel,MaterielID,SumAmount,BackSampleDate,AskBackDate,BillingMan,Counter,RevisedCounter,Approval,TextSample,ShowSample,PhotoSample,SizeSet1,SizeSet2,SizeSet3,SalesmanSample,ProductionSample,ShipmentSample,UpData,FillMan,IsVerify,VerifyMan,VerifyDate,Remark,Stata,OderMainID,LastEdit,LastEditDate,EditRemark,GenDan,BanFangGengDan,ZhiYang,CheBan,BanFangZhuGuang,ShengChanBu,Size1,Size2,BackAmount,HaveOld,SizeRefer,TaskRemark,BrandRemark,Images,BrandImages,DefaultSTID from SampleMain ");
            strSql.Append(" where ID=@ID ");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = ID;

            Hownet.Model.SampleMain model = new Hownet.Model.SampleMain();
            DataSet ds = DbHelperSQL.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CompanyID"].ToString() != "")
                {
                    model.CompanyID = int.Parse(ds.Tables[0].Rows[0]["CompanyID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = int.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                model.Season = ds.Tables[0].Rows[0]["Season"].ToString();
                if (ds.Tables[0].Rows[0]["MTID"].ToString() != "")
                {
                    model.MTID = int.Parse(ds.Tables[0].Rows[0]["MTID"].ToString());
                }
                model.Fabric = ds.Tables[0].Rows[0]["Fabric"].ToString();
                model.MainCloth1 = ds.Tables[0].Rows[0]["MainCloth1"].ToString();
                model.MainCloth2 = ds.Tables[0].Rows[0]["MainCloth2"].ToString();
                model.MinorCloth1 = ds.Tables[0].Rows[0]["MinorCloth1"].ToString();
                model.MinorCloth2 = ds.Tables[0].Rows[0]["MinorCloth2"].ToString();
                model.MainCloth1Remark = ds.Tables[0].Rows[0]["MainCloth1Remark"].ToString();
                model.MainCloth2Remak = ds.Tables[0].Rows[0]["MainCloth2Remak"].ToString();
                model.MinorCloth1Remark = ds.Tables[0].Rows[0]["MinorCloth1Remark"].ToString();
                model.MinorCloth2Remark = ds.Tables[0].Rows[0]["MinorCloth2Remark"].ToString();
                if (ds.Tables[0].Rows[0]["DateTime"].ToString() != "")
                {
                    model.DateTime = DateTime.Parse(ds.Tables[0].Rows[0]["DateTime"].ToString());
                }
                model.POID = ds.Tables[0].Rows[0]["POID"].ToString();
                model.CompanyMateriel = ds.Tables[0].Rows[0]["CompanyMateriel"].ToString();
                model.MaterielID = ds.Tables[0].Rows[0]["MaterielID"].ToString();
                if (ds.Tables[0].Rows[0]["SumAmount"].ToString() != "")
                {
                    model.SumAmount = int.Parse(ds.Tables[0].Rows[0]["SumAmount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BackSampleDate"].ToString() != "")
                {
                    model.BackSampleDate = DateTime.Parse(ds.Tables[0].Rows[0]["BackSampleDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AskBackDate"].ToString() != "")
                {
                    model.AskBackDate = DateTime.Parse(ds.Tables[0].Rows[0]["AskBackDate"].ToString());
                }
                model.BillingMan = ds.Tables[0].Rows[0]["BillingMan"].ToString();
                if (ds.Tables[0].Rows[0]["Counter"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Counter"].ToString() == "1") || (ds.Tables[0].Rows[0]["Counter"].ToString().ToLower() == "true"))
                    {
                        model.Counter = true;
                    }
                    else
                    {
                        model.Counter = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["RevisedCounter"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["RevisedCounter"].ToString() == "1") || (ds.Tables[0].Rows[0]["RevisedCounter"].ToString().ToLower() == "true"))
                    {
                        model.RevisedCounter = true;
                    }
                    else
                    {
                        model.RevisedCounter = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["Approval"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["Approval"].ToString() == "1") || (ds.Tables[0].Rows[0]["Approval"].ToString().ToLower() == "true"))
                    {
                        model.Approval = true;
                    }
                    else
                    {
                        model.Approval = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["TextSample"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["TextSample"].ToString() == "1") || (ds.Tables[0].Rows[0]["TextSample"].ToString().ToLower() == "true"))
                    {
                        model.TextSample = true;
                    }
                    else
                    {
                        model.TextSample = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["ShowSample"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["ShowSample"].ToString() == "1") || (ds.Tables[0].Rows[0]["ShowSample"].ToString().ToLower() == "true"))
                    {
                        model.ShowSample = true;
                    }
                    else
                    {
                        model.ShowSample = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["PhotoSample"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["PhotoSample"].ToString() == "1") || (ds.Tables[0].Rows[0]["PhotoSample"].ToString().ToLower() == "true"))
                    {
                        model.PhotoSample = true;
                    }
                    else
                    {
                        model.PhotoSample = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["SizeSet1"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["SizeSet1"].ToString() == "1") || (ds.Tables[0].Rows[0]["SizeSet1"].ToString().ToLower() == "true"))
                    {
                        model.SizeSet1 = true;
                    }
                    else
                    {
                        model.SizeSet1 = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["SizeSet2"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["SizeSet2"].ToString() == "1") || (ds.Tables[0].Rows[0]["SizeSet2"].ToString().ToLower() == "true"))
                    {
                        model.SizeSet2 = true;
                    }
                    else
                    {
                        model.SizeSet2 = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["SizeSet3"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["SizeSet3"].ToString() == "1") || (ds.Tables[0].Rows[0]["SizeSet3"].ToString().ToLower() == "true"))
                    {
                        model.SizeSet3 = true;
                    }
                    else
                    {
                        model.SizeSet3 = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["SalesmanSample"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["SalesmanSample"].ToString() == "1") || (ds.Tables[0].Rows[0]["SalesmanSample"].ToString().ToLower() == "true"))
                    {
                        model.SalesmanSample = true;
                    }
                    else
                    {
                        model.SalesmanSample = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["ProductionSample"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["ProductionSample"].ToString() == "1") || (ds.Tables[0].Rows[0]["ProductionSample"].ToString().ToLower() == "true"))
                    {
                        model.ProductionSample = true;
                    }
                    else
                    {
                        model.ProductionSample = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["ShipmentSample"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["ShipmentSample"].ToString() == "1") || (ds.Tables[0].Rows[0]["ShipmentSample"].ToString().ToLower() == "true"))
                    {
                        model.ShipmentSample = true;
                    }
                    else
                    {
                        model.ShipmentSample = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["UpData"].ToString() != "")
                {
                    model.UpData = int.Parse(ds.Tables[0].Rows[0]["UpData"].ToString());
                }
                if (ds.Tables[0].Rows[0]["FillMan"].ToString() != "")
                {
                    model.FillMan = int.Parse(ds.Tables[0].Rows[0]["FillMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["IsVerify"].ToString() != "")
                {
                    model.IsVerify = int.Parse(ds.Tables[0].Rows[0]["IsVerify"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyMan"].ToString() != "")
                {
                    model.VerifyMan = int.Parse(ds.Tables[0].Rows[0]["VerifyMan"].ToString());
                }
                if (ds.Tables[0].Rows[0]["VerifyDate"].ToString() != "")
                {
                    model.VerifyDate = DateTime.Parse(ds.Tables[0].Rows[0]["VerifyDate"].ToString());
                }
                model.Remark = ds.Tables[0].Rows[0]["Remark"].ToString();
                if (ds.Tables[0].Rows[0]["Stata"].ToString() != "")
                {
                    model.Stata = int.Parse(ds.Tables[0].Rows[0]["Stata"].ToString());
                }
                if (ds.Tables[0].Rows[0]["OderMainID"].ToString() != "")
                {
                    model.OderMainID = int.Parse(ds.Tables[0].Rows[0]["OderMainID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastEdit"].ToString() != "")
                {
                    model.LastEdit = int.Parse(ds.Tables[0].Rows[0]["LastEdit"].ToString());
                }
                if (ds.Tables[0].Rows[0]["LastEditDate"].ToString() != "")
                {
                    model.LastEditDate = DateTime.Parse(ds.Tables[0].Rows[0]["LastEditDate"].ToString());
                }
                model.EditRemark = ds.Tables[0].Rows[0]["EditRemark"].ToString();
                model.GenDan = ds.Tables[0].Rows[0]["GenDan"].ToString();
                model.BanFangGengDan = ds.Tables[0].Rows[0]["BanFangGengDan"].ToString();
                model.ZhiYang = ds.Tables[0].Rows[0]["ZhiYang"].ToString();
                model.CheBan = ds.Tables[0].Rows[0]["CheBan"].ToString();
                model.BanFangZhuGuang = ds.Tables[0].Rows[0]["BanFangZhuGuang"].ToString();
                model.ShengChanBu = ds.Tables[0].Rows[0]["ShengChanBu"].ToString();
                model.Size1 = ds.Tables[0].Rows[0]["Size1"].ToString();
                model.Size2 = ds.Tables[0].Rows[0]["Size2"].ToString();
                model.BackAmount = ds.Tables[0].Rows[0]["BackAmount"].ToString();
                model.HaveOld = ds.Tables[0].Rows[0]["HaveOld"].ToString();
                model.SizeRefer = ds.Tables[0].Rows[0]["SizeRefer"].ToString();
                model.TaskRemark = ds.Tables[0].Rows[0]["TaskRemark"].ToString();
                model.BrandRemark = ds.Tables[0].Rows[0]["BrandRemark"].ToString();
                model.Images = ds.Tables[0].Rows[0]["Images"].ToString();
                model.BrandImages = ds.Tables[0].Rows[0]["BrandImages"].ToString();
                if (ds.Tables[0].Rows[0]["DefaultSTID"].ToString() != "")
                {
                    model.DefaultSTID = int.Parse(ds.Tables[0].Rows[0]["DefaultSTID"].ToString());
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
            strSql.Append("select 1 as A,ID,CompanyID,BrandID,Season,MTID,Fabric,MainCloth1,MainCloth2,MinorCloth1,MinorCloth2,MainCloth1Remark,MainCloth2Remak,MinorCloth1Remark,MinorCloth2Remark,DateTime,POID,CompanyMateriel,MaterielID,SumAmount,BackSampleDate,AskBackDate,BillingMan,Counter,RevisedCounter,Approval,TextSample,ShowSample,PhotoSample,SizeSet1,SizeSet2,SizeSet3,SalesmanSample,ProductionSample,ShipmentSample,UpData,FillMan,IsVerify,VerifyMan,VerifyDate,Remark,Stata,OderMainID,LastEdit,LastEditDate,EditRemark,GenDan,BanFangGengDan,ZhiYang,CheBan,BanFangZhuGuang,ShengChanBu,Size1,Size2,BackAmount,HaveOld,SizeRefer,TaskRemark,BrandRemark,Images,BrandImages,DefaultSTID ");
            strSql.Append(" FROM SampleMain ");
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
            strSql.Append(" ID,CompanyID,BrandID,Season,MTID,Fabric,MainCloth1,MainCloth2,MinorCloth1,MinorCloth2,MainCloth1Remark,MainCloth2Remak,MinorCloth1Remark,MinorCloth2Remark,DateTime,POID,CompanyMateriel,MaterielID,SumAmount,BackSampleDate,AskBackDate,BillingMan,Counter,RevisedCounter,Approval,TextSample,ShowSample,PhotoSample,SizeSet1,SizeSet2,SizeSet3,SalesmanSample,ProductionSample,ShipmentSample,UpData,FillMan,IsVerify,VerifyMan,VerifyDate,Remark,Stata,OderMainID,LastEdit,LastEditDate,EditRemark,GenDan,BanFangGengDan,ZhiYang,CheBan,BanFangZhuGuang,ShengChanBu,Size1,Size2,BackAmount,HaveOld,SizeRefer,TaskRemark,BrandRemark,Images,BrandImages,DefaultSTID ");
            strSql.Append(" FROM SampleMain ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return DbHelperSQL.Query(strSql.ToString());
        }

        public int GetUpData(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select UpData from SampleMain where id=@ID");
            SqlParameter[] sps = { new SqlParameter("@ID", ID) };
            object o = DbHelperSQL.GetSingle(strSql.ToString(), sps);
            if (o != null)
                return int.Parse(o.ToString());
            else
                return 0;
        }
        public void SetDefaultSTID(int STID,int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("UPDATE  SampleMain SET DefaultSTID = @STID WHERE   (ID = @ID)");
            SqlParameter[] sps = { new SqlParameter("@STID", STID), new SqlParameter("ID", ID) };
            DbHelperSQL.ExecuteSql(strSql.ToString(), sps);
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
			parameters[0].Value = "SampleMain";
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

