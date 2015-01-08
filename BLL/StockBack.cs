using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类StockBack 的摘要说明。
    /// </summary>
    public class StockBack
    {
        private readonly Hownet.DAL.StockBack dal = new Hownet.DAL.StockBack();
        public StockBack()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int ID)
        {
            return dal.Exists(ID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.StockBack model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.StockBack> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.StockBack model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.StockBack> li = DataTableToList(dt);
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
        public Hownet.Model.StockBack GetModel(int ID)
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
        public List<Hownet.Model.StockBack> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.StockBack> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.StockBack> modelList = new List<Hownet.Model.StockBack>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.StockBack model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.StockBack();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["DataTime"].ToString() != "")
                    {
                        model.DataTime = DateTime.Parse(dt.Rows[n]["DataTime"].ToString());
                    }
                    else
                    {
                        model.DataTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["Num"].ToString() != "")
                    {
                        model.Num = int.Parse(dt.Rows[n]["Num"].ToString());
                    }
                    else
                    {
                        model.Num = 0;
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    else
                    {
                        model.Money = 0;
                    }
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    else
                    {
                        model.IsVerify = 0;
                    }
                    if (dt.Rows[n]["VerifyMan"].ToString() != "")
                    {
                        model.VerifyMan = int.Parse(dt.Rows[n]["VerifyMan"].ToString());
                    }
                    else
                    {
                        model.VerifyMan = 0;
                    }
                    if (dt.Rows[n]["VerifyDate"].ToString() != "")
                    {
                        model.VerifyDate = DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
                    }
                    else
                    {
                        model.VerifyDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["DepotID"].ToString() != "")
                    {
                        model.DepotID = int.Parse(dt.Rows[n]["DepotID"].ToString());
                    }
                    else
                    {
                        model.DepotID = 0;
                    }
                    if (dt.Rows[n]["LastMoney"].ToString() != "")
                    {
                        model.LastMoney = decimal.Parse(dt.Rows[n]["LastMoney"].ToString());
                    }
                    else
                    {
                        model.LastMoney = 0;
                    }
                    if (dt.Rows[n]["BackMoney"].ToString() != "")
                    {
                        model.BackMoney = decimal.Parse(dt.Rows[n]["BackMoney"].ToString());
                    }
                    else
                    {
                        model.BackMoney = 0;
                    }
                    if (dt.Rows[n]["FillDate"].ToString() != "")
                    {
                        model.FillDate = DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
                    }
                    else
                    {
                        model.FillDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["FillMan"].ToString() != "")
                    {
                        model.FillMan = int.Parse(dt.Rows[n]["FillMan"].ToString());
                    }
                    else
                    {
                        model.FillMan = 0;
                    }
                    if (dt.Rows[n]["UpData"].ToString() != "")
                    {
                        model.UpData = int.Parse(dt.Rows[n]["UpData"].ToString());
                    }
                    else
                    {
                        model.UpData = 0;
                    }
                    if (dt.Rows[n]["State"].ToString() != "")
                    {
                        model.State = int.Parse(dt.Rows[n]["State"].ToString());
                    }
                    else
                    {
                        model.State = 0;
                    }
                    if (dt.Rows[n]["BackDate"].ToString() != "")
                    {
                        model.BackDate = DateTime.Parse(dt.Rows[n]["BackDate"].ToString());
                    }
                    else
                    {
                        model.BackDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    else
                    {
                        model.TaskID = 0;
                    }
                    model.StockRemark = dt.Rows[n]["StockRemark"].ToString();
                    if (dt.Rows[n]["DeparmentType"] != null && dt.Rows[n]["DeparmentType"].ToString() != "")
                    {
                        model.DeparmentType = int.Parse(dt.Rows[n]["DeparmentType"].ToString());
                    }
                    if (dt.Rows[n]["Weight"] != null && dt.Rows[n]["Weight"].ToString() != "")
                    {
                        model.Weight = decimal.Parse(dt.Rows[n]["Weight"].ToString());
                    }
                    if (dt.Rows[n]["OtherTypeID"] != null && dt.Rows[n]["OtherTypeID"].ToString() != "")
                    {
                        model.OtherTypeID = int.Parse(dt.Rows[n]["OtherTypeID"].ToString());
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
        public DataSet GetIDList(int Stata)
        {
            return dal.GetIDList(Stata);
        }
        public DataSet GetStockLinLiaoIDList(int StockID, int Stata)
        {
            return dal.GetStockLinLiaoIDList(StockID, Stata);
        }
        public int NewNum(DateTime dt,int TypeID,int CompanyID)
        {
            return dal.NewNum(dt,  TypeID, CompanyID);
        }
        /// <summary>
        /// 审核/弃审入库单
        /// </summary>
        /// <param name="ID">入库单ID</param>
        /// <param name="t">真为审核入库，假为弃审出库</param>
        public void Verify(int ID, bool t, int Depot)
        {
            Hownet.BLL.SysTem bllST = new SysTem();
            Hownet.Model.SysTem modST = bllST.GetModel(bllST.GetMaxId() - 1);
            Hownet.BLL.StockBackInfo bllSBI = new StockBackInfo();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            Hownet.BLL.Repertory bllRep = new Repertory();
            Hownet.BLL.StockBackInfoList bllSBIL = new StockBackInfoList();
            Hownet.BLL.RepertoryList bllRL = new RepertoryList();
            List<Hownet.Model.StockBackInfoList> liSBIL;
            Hownet.Model.RepertoryList modRL;
            Hownet.Model.Repertory modRep;
            Hownet.Model.StockBackInfo modSBI;
            Hownet.Model.StockBack modSB=GetModel(ID);
            List<Hownet.Model.StockBackInfo> li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + ID + ")").Tables[0]);
            for (int i = 0; i < li.Count; i++)
            {
                if(li[i].StockInfoID>0)
                {
                    modSBI = bllSBI.GetModel(li[i].StockInfoID);
                    modSBI.NotAmount -= li[i].Amount;
                    //if (dt.Rows[i]["NeedIsEnd"] != null && dt.Rows[i]["NeedIsEnd"] != DBNull.Value && dt.Rows[i]["NeedIsEnd"].ToString() != string.Empty)
                    //    modSBI.IsEnd = Convert.ToInt32(dt.Rows[i]["NeedIsEnd"]);

                    bllSBI.Update(modSBI);
                }
                if (li[i].MListID == 0)
                {
                    modML.BrandID = li[i].BrandID;
                    modML.ColorID = li[i].ColorID;
                    modML.ColorOneID = li[i].ColorOneID;
                    modML.ColorTwoID = li[i].ColorTwoID;
                    modML.SizeID = li[i].SizeID;
                    modML.MaterielID = li[i].MaterielID;
                    modML.MeasureID = li[i].CompanyMeasureID;

                    li[i].MListID = bllML.GetID(modML);
                    bllSBI.Update(li[i]);
                }
                liSBIL = bllSBIL.DataTableToList(bllSBIL.GetList("(InfoID=" + li[i].ID + ")").Tables[0]);
                if (liSBIL.Count > 0)
                {
                    for (int j = 0; j < liSBIL.Count; j++)
                    {
                        if (t)
                        {
                            liSBIL[j].BatchNumber = li[i].MListID;
                            bllSBIL.Update(liSBIL[j]);
                            modRL = new Hownet.Model.RepertoryList();
                            modRL.A = 1;
                            modRL.Amount = modRL.NotAmount = liSBIL[j].Amount;
                            modRL.BatchNumber = liSBIL[j].BatchNumber;
                            modRL.DateTime = DateTime.Now;
                            modRL.DepotInfoID = liSBIL[j].DepotInfoID;
                            modRL.DepotInfoName = string.Empty;
                            modRL.ID = 0;
                            modRL.IsEnd = false;
                            modRL.MainID = ID;
                            modRL.Remark = liSBIL[j].Remark;
                            modRL.SpecID = liSBIL[j].SpecID;
                            modRL.SpecName = string.Empty;
                            modRL.StockListID = liSBIL[j].ID;
                            modRL.QRID = liSBIL[j].ID.ToString();
                            bllRL.Add(modRL);
                        }
                        else
                        {
                            bllRL.DeleteByStockInfoID(liSBIL[j].ID);
                        }
                    }
                }
                if ((!modST.MaterielByTask)&&(modSB.State!=(int)Hownet.BLL.Enums.TableType._采购部收货))
                {
                    modRep = new Hownet.Model.Repertory();
                    modRep.BrandID = li[i].BrandID;
                    modRep.ColorID = li[i].ColorID;
                    modRep.ColorOneID = li[i].ColorOneID;
                    modRep.ColorTwoID = li[i].ColorTwoID;
                    modRep.SizeID = li[i].SizeID;
                    modRep.MaterielID = li[i].MaterielID;
                    modRep.MeasureID = li[i].CompanyMeasureID;
                    modRep.MListID = li[i].MListID;
                    modRep.Amount = li[i].Amount;
                    modRep.DepartmentID = Depot;
                    modRep.Price = li[i].Price;
                    modRep.Money = li[i].Money;
                    bllRep.InOrOut(modRep, t);
                }
               if(modSB.State==(int)Hownet.BLL.Enums.TableType._采购部收货)
               {
                   modRep = new Hownet.Model.Repertory();
                   modRep.BrandID = li[i].BrandID;
                   modRep.ColorID = li[i].ColorID;
                   modRep.ColorOneID = li[i].ColorOneID;
                   modRep.ColorTwoID = li[i].ColorTwoID;
                   modRep.SizeID = li[i].SizeID;
                   modRep.MaterielID = li[i].MaterielID;
                   modRep.MeasureID = li[i].CompanyMeasureID;
                   modRep.MListID = li[i].MListID;
                   modRep.Amount = li[i].Amount;
                   modRep.DepartmentID = Depot;
                   modRep.Price = li[i].Price;
                   modRep.Money = li[i].Money;
                   bllRep.InOrOut(modRep, t);
               }

            }
           // Hownet.Model.StockBack modSB = GetModel(ID);
            if (modSB.State == (int)Hownet.BLL.Enums.TableType.P2D)
            {
                if (modSB.CompanyID > 0)
                {
                    Hownet.BLL.Company bllCom= new Company();
                    Hownet.Model.Company modCom = bllCom.GetModel(modSB.CompanyID);
                    if (t)//收货
                    {
                        modCom.Weight -= modSB.Weight;
                    }
                    else
                    {
                        modCom.Weight += modSB.Weight;
                    }
                    bllCom.Update(modCom);
                }
            }

        }
        /// <summary>
        /// 获取采购未完成数量
        /// </summary>
        /// <param name="AttributeID"></param>
        /// <returns></returns>
        public DataSet GetNotBack(int AttributeID)
        {
            return dal.GetNotBack(AttributeID);
        }
        /// <summary>
        /// 判断领料数量是否超过库存
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public bool CheckLinLiao(int MainID)
        {
            return dal.CheckLinLiao(MainID);
        }
        /// <summary>
        /// 领料后更新
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t">真为领料，假为退料</param>
        public void UpDemand(int MainID,bool t)
        {
            Hownet.BLL.StockBackInfo bllSBI=new StockBackInfo();
            Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
            Hownet.Model.MaterielDemand modMD;
            List<Hownet.Model.StockBackInfo> li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + MainID + ")").Tables[0]);
            for (int i = 0; i < li.Count; i++)
            {
                modMD = bllMD.GetModel(li[i].StockInfoID);
                if (t)
                {
                    modMD.NotAllotAmount -= li[i].Amount;
                }
                else
                {
                    modMD.NotAllotAmount += li[i].Amount;
                }
                bllMD.Update(modMD);
            }
        }
        /// <summary>
        /// 获取某物料采购量超过请购的数量
        /// </summary>
        /// <param name="MListID"></param>
        /// <returns></returns>
        public decimal GetExcessAmount(int MListID)
        {
            return dal.GetExcessAmount(MListID);
        }
        public DataSet GetStockList(DateTime dt1, DateTime dt2, int CompanyID, int MaterielID, int TypeID,bool InIsEnd)
        {
            return dal.GetStockList(dt1, dt2, CompanyID, MaterielID, TypeID,InIsEnd);
        }
        public DataSet GetStockListByNum(int Num, int TypeID)
        {
            return dal.GetStockListByNum(Num, TypeID);
        }
        /// <summary>
        /// 将某类单据明细标记为已完成
        /// </summary>
        /// <param name="TypeID"></param>
        public void UpIsEnd(int TypeID)
        {
            dal.UpIsEnd(TypeID);
        }
        /// <summary>
        /// 判断某申购单是否可以弃审
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool NeedStockCheckCanUnVerify(int ID)
        {
            return dal.NeedStockCheckCanUnVerify(ID);
        }
        public DataSet GetSum(DateTime dtOne, DateTime dtTwo, int TypeID)
        {
            return dal.GetSum(dtOne, dtTwo, TypeID);
        }
        public DataSet GetInfoList(DateTime dt1, DateTime dt2, int CompanyID, bool IsSum)
        {
            return dal.GetInfoList(dt1, dt2, CompanyID, IsSum);
        }
        public DataSet GetLinLiaoInfoList(int PTMID)
        {
            return dal.GetLinLiaoInfoList(PTMID);
        }
        /// <summary>
        /// 审核外协加工单
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="IsVerify"></param>
        /// <param name="VerifyManID"></param>
        /// <returns></returns>
        public int  VerifyWX(int MainID, bool IsVerify,int VerifyManID)
        {
            try
            {
                Hownet.Model.StockBack modSB = GetModel(MainID);
                if (IsVerify)
                {
                    modSB.IsVerify = 3;
                    modSB.VerifyDate = DateTime.Now;
                    modSB.VerifyMan = VerifyManID;
                }
                else
                {
                    modSB.IsVerify = 1;
                    modSB.VerifyDate = Convert.ToDateTime("1900-1-1");
                    modSB.VerifyMan = 0;
                }
                Update(modSB);
                Hownet.BLL.StockBackInfo bllSBI = new StockBackInfo();
                List<Hownet.Model.StockBackInfo> li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + modSB.ID + ") And (MListID=0)").Tables[0]);
                Hownet.BLL.MaterielList bllML = new MaterielList();
                Hownet.Model.MaterielList modML;
                if (li.Count > 0)
                {
                    for (int i = 0; i < li.Count; i++)
                    {
                        modML = new Hownet.Model.MaterielList();
                        modML.BrandID = li[i].BrandID;
                        modML.ColorID = li[i].ColorID;
                        modML.ColorOneID = li[i].ColorOneID;
                        modML.ColorTwoID = li[i].ColorTwoID;
                        modML.MaterielID = li[i].MaterielID;
                        modML.MeasureID = li[i].CompanyMeasureID;
                        modML.SizeID = li[i].SizeID;
                        modML.SpecID = 0;
                        li[i].MListID = bllML.GetID(modML);
                        bllSBI.Update(li[i]);
                    }
                }
                li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + modSB.ID * -1 + ") And (MListID=0)").Tables[0]);
                if (li.Count > 0)
                {
                    for (int i = 0; i < li.Count; i++)
                    {
                        modML = new Hownet.Model.MaterielList();
                        modML.BrandID = li[i].BrandID;
                        modML.ColorID = li[i].ColorID;
                        modML.ColorOneID = li[i].ColorOneID;
                        modML.ColorTwoID = li[i].ColorTwoID;
                        modML.MaterielID = li[i].MaterielID;
                        modML.MeasureID = li[i].CompanyMeasureID;
                        modML.SizeID = li[i].SizeID;
                        modML.SpecID = 0;
                        li[i].MListID = bllML.GetID(modML);
                        bllSBI.Update(li[i]);
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public DataSet GetWXOutList(int CompanyID, int DepotID, int State)
        {
            return dal.GetWXOutList(CompanyID, DepotID, State);
        }
        /// <summary>
        /// 审核外协领料单
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="IsVerify">真为入库，假为出库</param>
        /// <param name="VerifyManID"></param>
        /// <returns></returns>
        public int VerifyWXOut(int MainID, bool IsVerify, int VerifyManID)
        {
            try
            {
                Hownet.Model.StockBack modSB = GetModel(MainID);
                if (IsVerify)
                {
                    modSB.IsVerify = 3;
                    modSB.VerifyDate = DateTime.Now;
                    modSB.VerifyMan = VerifyManID;
                }
                else
                {
                    modSB.IsVerify = 1;
                    modSB.VerifyDate = Convert.ToDateTime("1900-1-1");
                    modSB.VerifyMan = 0;
                }
                Update(modSB);
                Hownet.BLL.StockBackInfo bllSBI = new StockBackInfo();
                Hownet.Model.StockBackInfo modSBI;
                List<Hownet.Model.StockBackInfo> li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + modSB.ID + ")").Tables[0]);
                Hownet.BLL.Repertory bllR = new Repertory();
                Hownet.Model.Repertory modR;
                if (li.Count > 0)
                {
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (li[i].StockInfoID > 0)
                        {
                            modSBI = bllSBI.GetModel(li[i].StockInfoID);
                            if (IsVerify)
                            {
                                modSBI.NotPriceAmount += li[i].Amount;
                                modSBI.NotAmount -= li[i].Amount;

                           }
                            else
                            {
                                modSBI.NotPriceAmount -= li[i].Amount;
                                modSBI.NotAmount += li[i].Amount;
                            }
                            li[i].NotPriceAmount = modSBI.NotPriceAmount;
                            li[i].NotAmount = modSBI.NotAmount;
                            bllSBI.Update(li[i]);
                            bllSBI.Update(modSBI);
                        }
                        if (li[i].DemandID > 0)
                        {
                            modR = bllR.GetModel(li[i].DemandID);
                            if (IsVerify)
                            {
                                modR.Amount -= li[i].Amount;
                                if (modR.Amount < 0)
                                    modR.Amount = 0;
                            }
                            else
                            {
                                modR.Amount += li[i].Amount;
                            }
                            bllR.Update(modR);
                        }

                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// 审核外协来料单
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="IsVerify"></param>
        /// <param name="VerifyManID"></param>
        /// <returns></returns>
        public int VerifyWXIn(int MainID, bool IsVerify, int VerifyManID)
        {
            try
            {
                Hownet.Model.StockBack modSB = GetModel(MainID);
                if (IsVerify)
                {
                    modSB.IsVerify = 3;
                    modSB.VerifyDate = DateTime.Now;
                    modSB.VerifyMan = VerifyManID;
                }
                else
                {
                    modSB.IsVerify = 1;
                    modSB.VerifyDate = Convert.ToDateTime("1900-1-1");
                    modSB.VerifyMan = 0;
                }
                Update(modSB);
                Hownet.BLL.StockBackInfo bllSBI = new StockBackInfo();
                Hownet.BLL.MaterielList bllML = new MaterielList();
                Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
                Hownet.Model.StockBackInfo modSBI;
                List<Hownet.Model.StockBackInfo> li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + modSB.ID + ")").Tables[0]);
                Hownet.BLL.Repertory bllR = new Repertory();
                Hownet.Model.Repertory modR;
                if (li.Count > 0)
                {
                    for (int i = 0; i < li.Count; i++)
                    {
                        if (li[i].StockInfoID > 0)
                        {
                            modSBI = bllSBI.GetModel(li[i].StockInfoID);
                            if (IsVerify)
                            {
                                modSBI.NotPriceAmount += li[i].Amount;
                                modSBI.NotAmount -= li[i].Amount;

                            }
                            else
                            {
                                modSBI.NotPriceAmount -= li[i].Amount;
                                modSBI.NotAmount += li[i].Amount;
                            }
                            li[i].NotPriceAmount = modSBI.NotPriceAmount;
                            li[i].NotAmount = modSBI.NotAmount;
                            bllSBI.Update(li[i]);
                            bllSBI.Update(modSBI);
                        }
                        if (li[i].MListID == 0)
                        {
                            modML.BrandID = li[i].BrandID;
                            modML.ColorID = li[i].ColorID;
                            modML.ColorOneID = li[i].ColorOneID;
                            modML.ColorTwoID = li[i].ColorTwoID;
                            modML.SizeID = li[i].SizeID;
                            modML.MaterielID = li[i].MaterielID;
                            modML.MeasureID = li[i].CompanyMeasureID;
                            modML.SpecID = 0;
                            li[i].MListID = bllML.GetID(modML);
                            bllSBI.Update(li[i]);
                        }
                        modR = new Hownet.Model.Repertory();
                        modR.Amount = li[i].Amount;
                        modR.MListID = li[i].MListID;
                        modR.MeasureID = li[i].CompanyMeasureID;
                        modR.DepartmentID = modSB.DepotID;
                        modR.BrandID = li[i].BrandID;
                        modR.BrandName = li[i].BrandName;
                        modR.ColorID = li[i].ColorID;
                        modR.ColorName = li[i].ColorName;
                        modR.ColorOneID = li[i].ColorOneID;
                        modR.ColorOneName = li[i].ColorOneName;
                        modR.ColorTwoID = li[i].ColorTwoID;
                        modR.ColorTwoName = li[i].ColorTwoName;
                        modR.CompanyID = li[i].CompanyID;
                        modR.CompanyName = string.Empty;
                        modR.DeparmentName = string.Empty;
                        modR.DepartmentID = modSB.DepotID;
                        modR.DepotInfoID = 0;
                        modR.DepotInfoName = string.Empty;
                        modR.ID = 0;
                        modR.MaterielID = li[i].MaterielID;
                        modR.MaterielName = li[i].MaterielName;
                        modR.MeasureName = string.Empty;
                        modR.PlanID = 0;
                        modR.Remark = string.Empty;
                        modR.SizeID = li[i].SizeID;
                        modR.SizeName = li[i].SizeName;
                        modR.SpecID = li[i].SpecID;
                        modR.SpecName = li[i].SpecName;
                        modR.SupplierID = 0;
                        modR.SupplierName = string.Empty;
                        modR.SupplierSN = string.Empty;
                        bllR.InOrOut(modR, IsVerify);

                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        /// <summary>
        /// 成品采购收货单主表
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetFinshedBackMain(int MainID)
        {
            return dal.GetFinshedBackMain(MainID);
        }
        public DataSet GetReport(int MainID)
        {
            return dal.GetReport(MainID);
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

