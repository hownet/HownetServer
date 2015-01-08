using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类Product2Depot 的摘要说明。
	/// </summary>
	public class Product2Depot
	{
		private readonly Hownet.DAL.Product2Depot dal=new Hownet.DAL.Product2Depot();
		public Product2Depot()
		{}
		#region  成员方法

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.Product2Depot model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.Product2Depot> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                return dal.Add(li[0]);
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Hownet.Model.Product2Depot model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.Product2Depot> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int ID)
        {

            dal.Delete(ID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.Product2Depot GetModel(int ID)
        {

            return dal.GetModel(ID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetTopList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.Product2Depot> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.Product2Depot> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Product2Depot> modelList = new List<Hownet.Model.Product2Depot>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Product2Depot model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Product2Depot();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    if (dt.Rows[n]["Num"].ToString() != "")
                    {
                        model.Num = int.Parse(dt.Rows[n]["Num"].ToString());
                    }
                    if (dt.Rows[n]["DepotID"].ToString() != "")
                    {
                        model.DepotID = int.Parse(dt.Rows[n]["DepotID"].ToString());
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    if (dt.Rows[n]["VerifyMan"].ToString() != "")
                    {
                        model.VerifyMan = int.Parse(dt.Rows[n]["VerifyMan"].ToString());
                    }
                    if (dt.Rows[n]["VerifyDate"].ToString() != "")
                    {
                        model.VerifyDate = DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
                    }
                    if (dt.Rows[n]["UpData"].ToString() != "")
                    {
                        model.UpData = int.Parse(dt.Rows[n]["UpData"].ToString());
                    }
                    if (dt.Rows[n]["TypeID"] != null && dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    if (dt.Rows[n]["DeparmentID"] != null && dt.Rows[n]["DeparmentID"].ToString() != "")
                    {
                        model.DeparmentID = int.Parse(dt.Rows[n]["DeparmentID"].ToString());
                    }
                    if (dt.Rows[n]["DeparmentTypeID"] != null && dt.Rows[n]["DeparmentTypeID"].ToString() != "")
                    {
                        model.DeparmentTypeID = int.Parse(dt.Rows[n]["DeparmentTypeID"].ToString());
                    }
                    if (dt.Rows[n]["Weight"] != null && dt.Rows[n]["Weight"].ToString() != "")
                    {
                        model.Weight = decimal.Parse(dt.Rows[n]["Weight"].ToString());
                    }
                    model.A = int.Parse(dt.Rows[n]["A"].ToString());
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }
        public DataSet GetIDList(int TypeID)
        {
            return dal.GetIDList(TypeID);
        }
        public int NewNum(DateTime dt)
        {
            return dal.NewNum(dt);
        }
        /// <summary>
        /// 审核/弃审入库单
        /// </summary>
        /// <param name="ID">入库单ID</param>
        /// <param name="t">真为审核入库，假为弃审出库</param>
        public void Verify(int ID, bool t,int VerifyMan,int DepotID,int TypeID)
        {
            if (TypeID ==(int) Enums.TableType.P2D)
            {
                try
                {
                    Hownet.BLL.Product2DepotInfo bllP2DI = new Product2DepotInfo();
                    Hownet.BLL.AmountInfo bllAI = new AmountInfo();
                    Hownet.BLL.Repertory bllRep = new Repertory();
                    Hownet.BLL.MaterielList bllML = new MaterielList();
                    Hownet.BLL.Materiel bllMat = new Materiel();
                    Hownet.Model.AmountInfo modAI = new Hownet.Model.AmountInfo();
                    Hownet.Model.Repertory modRep = new Model.Repertory();
                    Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
                    Hownet.BLL.RepertoryList bllRL = new RepertoryList();
                    Hownet.Model.RepertoryList modRL = new Model.RepertoryList();
                    DataTable dtRL = new DataTable();
                    Hownet.Model.Product2Depot modP2D = GetModel(ID);
                    DataTable dtP2DI = bllP2DI.GetList("(MainID=" + ID + ")").Tables[0];
                    List<Hownet.Model.Product2DepotInfo> li = bllP2DI.DataTableToList(bllP2DI.GetList("(MainID=" + ID + ")").Tables[0]);
                    modAI.TableTypeID = 1;
                    Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
                    DataTable dtOT = bllOT.GetTypeList("成品单位").Tables[0];
                    decimal one = 1;
                    decimal two = 1;
                    int dM = 0;
                   
                    if (dtOT.Rows.Count > 0)
                    {
                        one = Convert.ToDecimal(dtOT.Select("(Name='车间换算')")[0]["Value"]);
                        two = Convert.ToDecimal(dtOT.Select("(Name='仓储换算')")[0]["Value"]);
                        dM = Convert.ToInt32(dtOT.Select("(Name='仓储单位')")[0]["Value"]);
                    }


                    for (int i = 0; i < li.Count; i++)
                    {
                        modRep=new Model.Repertory();
                        modRep.DepartmentID = DepotID;
                        modRep.BrandName = modRep.ColorName = modRep.ColorOneName = modRep.ColorTwoName = modRep.CompanyName = modRep.DeparmentName = modRep.DepotInfoName = modRep.MaterielName = modRep.MeasureName = modRep.Remark = modRep.SizeName = modRep.SpecName = modRep.SupplierName = modRep.SupplierSN = string.Empty;

                        modRep.BrandID = modML.BrandID = li[i].BrandID;
                        modRep.ColorID = modML.ColorID = li[i].ColorID;
                        modRep.ColorOneID = modML.ColorOneID = li[i].ColorOneID;
                        modRep.ColorTwoID = modML.ColorTwoID = li[i].ColorTwoID;
                        modRep.SizeID = modML.SizeID = li[i].SizeID;
                        modRep.MaterielID = modML.MaterielID = li[i].MaterielID;
                        modRep.MeasureID = modML.MeasureID = bllMat.GetModel(li[i].MaterielID).MeasureID;
                        modAI.MainID = li[i].TaskID;
                        modRep.Amount = modAI.NotAmount = li[i].Amount;
                        modRep.MListID = modAI.MListID = li[i].MListID;
                        if (li[i].MListID == 0)
                        {

                            modAI.MListID = li[i].MListID = bllML.GetID(modML);
                            bllP2DI.Update(li[i]);
                            if (dM > 0)
                                modML.MeasureID = dM;
                            modRep.MListID = bllML.GetID(modML);

                        }
                        else
                        {
                            if (dM > 0)
                                modML.MeasureID = dM;
                            modRep.MListID = bllML.GetID(modML);
                        }
                        if (li[i].TaskID > 0)
                        {
                            if (t)
                            {
                                if (one > 1 || two > 1)
                                {
                                    modAI.Amount -= ((int)(li[i].Amount * two / one));
                                }
                                else
                                {
                                    modAI.Amount -= li[i].Amount;
                                }
                                if (modAI.Amount < 0)
                                    modAI.Amount = 0;
                            }
                            else
                            {
                                if (one > 1 || two > 1)
                                {
                                    modAI.Amount += ((int)(li[i].Amount * two / one));
                                }
                                else
                                {
                                    modAI.Amount += li[i].Amount;
                                }
                            }


                            bllAI.UpNotAmount(modAI, t);
                        }
                        if (dM > 0)
                        {
                            modRep.MeasureID = dM;
                        }
                        else
                        {
                            modRep.MeasureID = modML.MeasureID;
                        }
                      modRep.ID=  bllRep.InOrOut(modRep, t);
                        if(li[i].DepotInfoID>0)
                        {
                            dtRL = bllRL.GetList("(BatchNumber=" + li[i].MListID + ") And (DepotInfoID=" + li[i].DepotInfoID + ")").Tables[0];
                            
                            if(dtRL.Rows.Count==0 )
                            {
                                if (t)
                                {
                                    modRL = new Model.RepertoryList();
                                    modRL.A = 1;
                                    modRL.NotAmount = modRL.Amount = li[i].Amount;
                                    modRL.BatchNumber = li[i].MListID;
                                    modRL.DateTime = DateTime.Now;
                                    modRL.DepotInfoID = li[i].DepotInfoID;
                                    modRL.DepotInfoName = string.Empty;
                                    modRL.ID = 0;
                                    modRL.IsEnd = false;
                                    modRL.MainID = modRep.ID;
                                    modRL.PlanID = 0;
                                    modRL.QRID = li[i].MListID.ToString();
                                    modRL.Remark = string.Empty;
                                    modRL.SpecID = 0;
                                    modRL.SpecName = string.Empty;
                                    modRL.StockListID = 0;
                                    bllRL.Add(modRL);
                                }
                            }
                            else if(dtRL.Rows.Count==1)
                            {
                                modRL=bllRL.GetModel(Convert.ToInt32(dtRL.Rows[0]["ID"]));
                                if (t)
                                    modRL.Amount += li[i].Amount;
                                else
                                    modRL.Amount -= li[i].Amount;
                                bllRL.Update(modRL);
                            }
                            else if(dtRL.Rows.Count>1)
                            {
                                List<Hownet.Model.RepertoryList> liRL = bllRL.DataTableToList(dtRL);
                                for(int j=1;j<liRL.Count;j++)
                                {
                                    liRL[0].Amount += liRL[j].Amount;
                                    bllRL.Delete(liRL[j].ID);
                                }
                                if (t)
                                    liRL[0].Amount += li[i].Amount;
                                else
                                    liRL[0].Amount -= li[i].Amount;
                                bllRL.Update(liRL[0]);
                            }
                        }
                    }
                    if (t)
                    {
                        modP2D.IsVerify = 3;
                        modP2D.VerifyDate = DateTime.Today;
                        modP2D.VerifyMan = VerifyMan;
                    }
                    else
                    {
                        modP2D.IsVerify = 1;
                        modP2D.VerifyDate = DateTime.Parse("1900-1-1");
                        modP2D.VerifyMan = 0;
                    }
                    Update(modP2D);
                }
                 catch (Exception ex)
                {

                }
            }
            else if (TypeID ==(int) Enums.TableType.P2Pack)
            {
                try
                {
                    Hownet.BLL.Product2DepotInfo bllP2DI = new Product2DepotInfo();
                    Hownet.BLL.AmountInfo bllAI = new AmountInfo();
                    Hownet.BLL.PackAmount bllPA = new PackAmount();
                    Hownet.BLL.MaterielList bllML = new MaterielList();
                    Hownet.BLL.Materiel bllMat = new Materiel();
                    Hownet.Model.AmountInfo modAI = new Hownet.Model.AmountInfo();
                    Hownet.Model.PackAmount modPA = new Hownet.Model.PackAmount();
                    Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
                    Hownet.Model.Product2Depot modP2D = GetModel(ID);
                    Hownet.BLL.OtherType bllOT = new OtherType();
                    DataTable dtOT = bllOT.GetTypeList("成品单位").Tables[0];
                    int TaskMeasureID = 0;
                    DataRow[] drs = dtOT.Select("(Name='车间单位')");
                    if (drs.Length == 1)
                        TaskMeasureID = Convert.ToInt32(drs[0]["Value"]);
                    List<Hownet.Model.Product2DepotInfo> li = bllP2DI.DataTableToList(bllP2DI.GetList("(MainID=" + ID + ")").Tables[0]);
                    modAI.TableTypeID = 1;
                    modPA.DepartmentID = DepotID;
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (li[i].MaterielID > 0)
                        {
                            modPA.BrandID = modML.BrandID = li[i].BrandID;
                            modPA.ColorID = modML.ColorID = li[i].ColorID;
                            modPA.ColorOneID = modML.ColorOneID = li[i].ColorOneID;
                            modPA.ColorTwoID = modML.ColorTwoID = li[i].ColorTwoID;
                            modPA.SizeID = modML.SizeID = li[i].SizeID;
                            modPA.MaterielID = modML.MaterielID = li[i].MaterielID;
                            modML.MeasureID = bllMat.GetModel(li[i].MaterielID).MeasureID;
                            if (TaskMeasureID > 0)
                                modPA.MeasureID = TaskMeasureID;
                            else
                                modPA.MeasureID = modML.MeasureID;
                            modAI.MainID = li[i].TaskID;
                            modPA.PlanID = li[i].TaskID;
                            modPA.Remark = string.Empty;
                            modPA.Amount = modAI.NotAmount = li[i].Amount;

                            if (li[i].ColorID > 0 && li[i].SizeID > 0)
                            {
                                if (li[i].MListID == 0)
                                {
                                    modAI.MListID = modPA.MListID = li[i].MListID = bllML.GetID(modML);
                                    bllP2DI.Update(li[i]);
                                }
                                else
                                {
                                    modAI.MListID = modPA.MListID = li[i].MListID;
                                }
                                bllAI.UpNotAmount(modAI, t);
                                bllPA.InOrOut(modPA, t);
                            }
                        }
                        else
                        {
                            bllP2DI.Delete(li[i].ID);
                        }
                    }
                    if (t)
                    {
                        modP2D.IsVerify = 3;
                        modP2D.VerifyDate = DateTime.Today;
                        modP2D.VerifyMan = VerifyMan;
                    }
                    else
                    {
                        modP2D.IsVerify = 1;
                        modP2D.VerifyDate = DateTime.Parse("1900-1-1");
                        modP2D.VerifyMan = 0;
                    }
                    Update(modP2D);
                }
                catch (Exception ex)
                {
                }
            }
        }
        public DataSet GetSumAmount(DateTime dt, int DepotID)
        {
            return dal.GetSumAmount(dt, DepotID);
        }
        public DataSet GetP2dListByComID(DateTime dt1, DateTime dt2, int DeparmentID, int DepTypeID)
        {
            return dal.GetP2dListByComID(dt1, dt2, DeparmentID, DepTypeID);
        }
        /// <summary>
        /// 获得分页数据列表
        /// </summary>
        //public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  成员方法
    }
}

