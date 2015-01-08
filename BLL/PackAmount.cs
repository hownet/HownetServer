using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// PackAmount
    /// </summary>
    public partial class PackAmount
    {
        private readonly Hownet.DAL.PackAmount dal = new Hownet.DAL.PackAmount();
        public PackAmount()
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
        public int Add(Hownet.Model.PackAmount model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.PackAmount> li = DataTableToList(dt);
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
        public bool Update(Hownet.Model.PackAmount model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据,数据源为DataTable
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.PackAmount> li = DataTableToList(dt);
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
        public Hownet.Model.PackAmount GetModel(int ID)
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
        public List<Hownet.Model.PackAmount> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.PackAmount> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.PackAmount> modelList = new List<Hownet.Model.PackAmount>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.PackAmount model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.PackAmount();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["MListID"] != null && dt.Rows[n]["MListID"].ToString() != "")
                    {
                        model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                    }
                    if (dt.Rows[n]["Amount"] != null && dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    if (dt.Rows[n]["MeasureID"] != null && dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    if (dt.Rows[n]["DepartmentID"] != null && dt.Rows[n]["DepartmentID"].ToString() != "")
                    {
                        model.DepartmentID = int.Parse(dt.Rows[n]["DepartmentID"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"] != null && dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"] != null && dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                    }
                    if (dt.Rows[n]["ColorID"] != null && dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    if (dt.Rows[n]["ColorOneID"] != null && dt.Rows[n]["ColorOneID"].ToString() != "")
                    {
                        model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                    }
                    if (dt.Rows[n]["ColorTwoID"] != null && dt.Rows[n]["ColorTwoID"].ToString() != "")
                    {
                        model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                    }
                    if (dt.Rows[n]["BrandID"] != null && dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    if (dt.Rows[n]["CompanyID"] != null && dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    if (dt.Rows[n]["PlanID"] != null && dt.Rows[n]["PlanID"].ToString() != "")
                    {
                        model.PlanID = int.Parse(dt.Rows[n]["PlanID"].ToString());
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
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
        /// 审核/弃审入库
        /// </summary>
        /// <param name="model"></param>
        /// <param name="t">真为入库，假为出库</param>
        public void InOrOut(Model.PackAmount model, bool t)
        {
            dal.InOrOut(model, t);
        }
        public DataSet GetAmount()
        {
            return dal.GetAmount();
        }
         /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetPackList(int PackID)
        {
            return dal.GetPackList(PackID);
        }
        /// <param name="t">真为审核入库，假为弃审出库</param>
        public bool VerifyStock(int MainID, int PackID, bool t, int VerifyMan)
        {
            try
            {
                Hownet.BLL.StockBack bllSB = new StockBack();
                Hownet.BLL.StockBackInfo bllSBI = new StockBackInfo();
                Hownet.BLL.Repertory bllRep = new Repertory();
                Hownet.BLL.Deparment bllDep = new Deparment();
                
                Hownet.BLL.PackAmount bllPA = new PackAmount();
                Hownet.BLL.MaterielList bllML = new MaterielList();
                Hownet.BLL.Materiel bllMat = new Materiel();
                
                Hownet.Model.PackAmount modPA = new Hownet.Model.PackAmount();
                Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
                Hownet.Model.StockBack modSB = bllSB.GetModel(MainID);
                Hownet.Model.StockBackInfo modSBI = new Hownet.Model.StockBackInfo();
                Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
                Hownet.Model.Deparment modDep = bllDep.GetModel(PackID);
                

                List<Hownet.Model.StockBackInfo> li = bllSBI.DataTableToList(bllSBI.GetList("(MainID=" + MainID + ")").Tables[0]);

                modPA.DepartmentID = PackID;
                for (int i = 0; i < li.Count; i++)
                {
                  modRep.BrandID=  modPA.BrandID = modML.BrandID = li[i].BrandID;
                    modRep.ColorID= modPA.ColorID = modML.ColorID = li[i].ColorID;
                    modRep.ColorOneID= modPA.ColorOneID = modML.ColorOneID = li[i].ColorOneID;
                    modRep.ColorTwoID= modPA.ColorTwoID = modML.ColorTwoID = li[i].ColorTwoID;
                    modRep.SizeID= modPA.SizeID = modML.SizeID = li[i].SizeID;
                    modRep.MaterielID= modPA.MaterielID = modML.MaterielID = li[i].MaterielID;
                    modRep.MeasureID= modPA.MeasureID = modML.MeasureID = bllMat.GetModel(li[i].MaterielID).MeasureID;
                   modRep.PlanID= modPA.PlanID = 0;
                    modRep.Remark= modPA.Remark = string.Empty;
                    modRep.DepartmentID =modPA.DepartmentID= modSB.DepotID;
                    modRep.Amount= modPA.Amount =li[i].Amount;
                    modSBI = bllSBI.GetModel(li[i].StockInfoID);
                    if (modSBI != null)
                    {
                        if (t)
                        {
                            modSBI.NotAmount -= li[i].Amount;
                        }
                        else
                        {
                            modSBI.NotAmount += li[i].Amount;
                        }
                        bllSBI.Update(modSBI);
                    }
                    if (li[i].MListID == 0)
                    {
                         modRep.MListID= modPA.MListID = li[i].MListID = bllML.GetID(modML);
                         bllSBI.Update(li[i]);
                    }
                    else
                    {
                         modRep.MListID= modPA.MListID = li[i].MListID;
                    }
                    if (modDep.TypeID == 39)
                    {
                        bllPA.InOrOut(modPA, t);
                    }
                    else if (modDep.TypeID == 42)
                    {
                        bllRep.InOrOut(modRep, t);
                    }
                }
                if (t)
                {
                    modSB.IsVerify = 3;
                    modSB.VerifyDate = DateTime.Today;
                    modSB.VerifyMan = VerifyMan;
                }
                else
                {
                    modSB.IsVerify = 1;
                    modSB.VerifyDate = DateTime.Parse("1900-1-1");
                    modSB.VerifyMan = 0;
                }
               bllSB. Update(modSB);
               return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataSet GetP2PackList(DateTime dt1, DateTime dt2, int MaterielID, int DeparmentID,int DTID)
        {
            return dal.GetP2PackList(dt1, dt2, MaterielID, DeparmentID,DTID);
        }
        public DataSet GetP2DeoptList(DateTime dt1, DateTime dt2, int MaterielID, int DeparmentID,int DTID)
        {
            return dal.GetP2DeoptList(dt1, dt2, MaterielID, DeparmentID,DTID);
        }
        public DataSet GetLinLiaoList(DateTime dt1, DateTime dt2, int DepID, int MatID,int _deparmentTypeID,int TaskID)
        {
            return dal.GetLinLiaoList(dt1, dt2, DepID, MatID, _deparmentTypeID, TaskID);
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

