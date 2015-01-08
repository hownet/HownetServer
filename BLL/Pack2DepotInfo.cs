using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// Pack2DepotInfo
    /// </summary>
    public partial class Pack2DepotInfo
    {
        private readonly Hownet.DAL.Pack2DepotInfo dal = new Hownet.DAL.Pack2DepotInfo();
        public Pack2DepotInfo()
        { }
        #region  Method
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
        public int Add(Hownet.Model.Pack2DepotInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.Pack2DepotInfo> li = DataTableToList(dt);
            int a = 0;
            if (li.Count > 0)
            {
                for (int i = 0; i < li.Count; i++)
                {
                    a = Add(li[i]);
                }
            }
            return a;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Hownet.Model.Pack2DepotInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据,数据源为DataTable
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.Pack2DepotInfo> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                for (int i = 0; i < li.Count; i++)
                {
                    dal.Update(li[i]);
                }
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {

            return dal.Delete(ID);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            return dal.DeleteList(IDlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.Pack2DepotInfo GetModel(int ID)
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
        public List<Hownet.Model.Pack2DepotInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.Pack2DepotInfo> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Pack2DepotInfo> modelList = new List<Hownet.Model.Pack2DepotInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Pack2DepotInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Pack2DepotInfo();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["MainID"] != null && dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    if (dt.Rows[n]["TaskID"] != null && dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"] != null && dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    if (dt.Rows[n]["ColorID"] != null && dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"] != null && dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                    }
                    if (dt.Rows[n]["ColorOneID"] != null && dt.Rows[n]["ColorOneID"].ToString() != "")
                    {
                        model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                    }
                    if (dt.Rows[n]["ColorTwoID"] != null && dt.Rows[n]["ColorTwoID"].ToString() != "")
                    {
                        model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                    }
                    if (dt.Rows[n]["MListID"] != null && dt.Rows[n]["MListID"].ToString() != "")
                    {
                        model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                    }
                    if (dt.Rows[n]["PackAmount"] != null && dt.Rows[n]["PackAmount"].ToString() != "")
                    {
                        model.PackAmount = decimal.Parse(dt.Rows[n]["PackAmount"].ToString());
                    }
                    if (dt.Rows[n]["NowAmount"] != null && dt.Rows[n]["NowAmount"].ToString() != "")
                    {
                        model.NowAmount = decimal.Parse(dt.Rows[n]["NowAmount"].ToString());
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["BrandID"] != null && dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    if (dt.Rows[n]["MeasureID"] != null && dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    if (dt.Rows[n]["PackAmountID"] != null && dt.Rows[n]["PackAmountID"].ToString() != "")
                    {
                        model.PackAmountID = int.Parse(dt.Rows[n]["PackAmountID"].ToString());
                    }
                    if (dt.Rows[n]["DepotMeasureID"] != null && dt.Rows[n]["DepotMeasureID"].ToString() != "")
                    {
                        model.DepotMeasureID = int.Parse(dt.Rows[n]["DepotMeasureID"].ToString());
                    }
                    if (dt.Rows[n]["DepotBrandID"] != null && dt.Rows[n]["DepotBrandID"].ToString() != "")
                    {
                        model.DepotBrandID = int.Parse(dt.Rows[n]["DepotBrandID"].ToString());
                    }
                    if (dt.Rows[n]["DepotInfoID"] != null && dt.Rows[n]["DepotInfoID"].ToString() != "")
                    {
                        model.DepotInfoID = int.Parse(dt.Rows[n]["DepotInfoID"].ToString());
                    }
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
           /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteByMainID(int MainID)
        {
            return dal.DeleteByMainID(MainID);
        }
        public void Verify(int MainID, bool IsVerify)
        {
            Hownet.BLL.Pack2DepotMain bllPDM = new Pack2DepotMain();
            Hownet.Model.Pack2DepotMain modPDM = bllPDM.GetModel(MainID);
            List<Hownet.Model.Pack2DepotInfo> li = DataTableToList(GetList("(MainID=" + MainID + ")").Tables[0]);
            Hownet.BLL.Repertory bllRep = new Repertory();
            Hownet.BLL.PackAmount bllPA = new PackAmount();
            Hownet.BLL.RepertoryList bllRL = new RepertoryList();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Model.MaterielList();
            Hownet.Model.RepertoryList modRL = new Model.RepertoryList();
            DataTable dtRL = new DataTable();
            Hownet.Model.PackAmount modPA = new Hownet.Model.PackAmount();
            Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
            modRep.BrandName = modRep.ColorName = modRep.ColorOneName = modRep.ColorTwoName = modRep.CompanyName = modRep.DeparmentName = modRep.DepotInfoName = modRep.MaterielName = modRep.MeasureName = modRep.Remark = modRep.SizeName = modRep.SpecName = modRep.SupplierName = modRep.SupplierSN = string.Empty;

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
            try
            {
                for (int i = 0; i < li.Count; i++)
                {
                    modPA = bllPA.GetModel(li[i].PackAmountID);
                    if (IsVerify)
                    {
                        if (one > 1 || two > 1)
                        {
                            if (one > 0)
                                modPA.Amount -= ((int)(li[i].NowAmount * two / one));
                        }
                        else
                        {
                            modPA.Amount -= li[i].NowAmount;
                        }
                        if (modPA.Amount < 0)
                            modPA.Amount = 0;
                    }
                    else
                    {
                        if (one > 1 || two > 1)
                        {
                            if (one > 0)
                                modPA.Amount += ((int)(li[i].NowAmount * two / one));
                        }
                        else
                        {
                            modPA.Amount += li[i].NowAmount;
                        }
                    }
                    bllPA.Update(modPA);

                    modRep = new Hownet.Model.Repertory();
                    modRep.BrandName = modRep.ColorName = modRep.ColorOneName = modRep.ColorTwoName = modRep.CompanyName = modRep.DeparmentName = modRep.DepotInfoName = modRep.MaterielName = modRep.MeasureName = modRep.Remark = modRep.SizeName = modRep.SpecName = modRep.SupplierName = modRep.SupplierSN = string.Empty;

                    modRep.DepartmentID = modPDM.DepotID;
                    modRep.BrandID =modML.BrandID= li[i].BrandID;
                    modRep.ColorID =modML.ColorID= li[i].ColorID;
                    modRep.ColorOneID =modML.ColorOneID= li[i].ColorOneID;
                    modRep.ColorTwoID =modML.ColorTwoID= li[i].ColorTwoID;
                    modRep.SizeID =modML.SizeID= li[i].SizeID;
                    modRep.MaterielID =modML.MaterielID= li[i].MaterielID;
                    if (dM > 0)
                    {
                        modRep.MeasureID = dM;
                    }
                    else
                    {
                        modRep.MeasureID = li[i].MeasureID;
                    }
                    modML.MeasureID = modRep.MeasureID;
                    modRep.Amount = li[i].NowAmount;
                    modRep.MListID = li[i].MListID;
                    if(li[i].DepotBrandID>0)
                    {
                     modRep.BrandID=   modML.BrandID = li[i].DepotBrandID;
                        modRep.MListID = bllML.GetID(modML);
                    }
                   modRep.ID= bllRep.InOrOut(modRep, IsVerify);
                   if (li[i].DepotInfoID > 0)
                   {
                       dtRL = bllRL.GetList("(BatchNumber=" + li[i].MListID + ") And (DepotInfoID=" + li[i].DepotInfoID + ")").Tables[0];

                       if (dtRL.Rows.Count == 0)
                       {
                           if (IsVerify)
                           {
                               modRL = new Model.RepertoryList();
                               modRL.A = 1;
                               modRL.NotAmount = modRL.Amount = li[i].NowAmount;
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
                       else if (dtRL.Rows.Count == 1)
                       {
                           modRL = bllRL.GetModel(Convert.ToInt32(dtRL.Rows[0]["ID"]));
                           if (IsVerify)
                               modRL.Amount += li[i].NowAmount;
                           else
                               modRL.Amount -= li[i].NowAmount;
                           bllRL.Update(modRL);
                       }
                       else if (dtRL.Rows.Count > 1)
                       {
                           List<Hownet.Model.RepertoryList> liRL = bllRL.DataTableToList(dtRL);
                           for (int j = 1; j < liRL.Count; j++)
                           {
                               liRL[0].Amount += liRL[j].Amount;
                               bllRL.Delete(liRL[j].ID);
                           }
                           if (IsVerify)
                               liRL[0].Amount += li[i].NowAmount;
                           else
                               liRL[0].Amount -= li[i].NowAmount;
                           bllRL.Update(liRL[0]);
                       }
                   }
                }
                if (!IsVerify)
                {
                    modPDM.IsVerify = 1;
                    modPDM.VerifyDate = Convert.ToDateTime("1900-1-1");
                    modPDM.VerifyMan = 0;
                    bllPDM.Update(modPDM);
                }
            }
            catch (Exception ex)
            {

            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  Method
    }
}

