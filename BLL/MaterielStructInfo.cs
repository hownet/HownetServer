using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类MaterielStructInfo 的摘要说明。
    /// </summary>
    public class MaterielStructInfo
    {
        private readonly Hownet.DAL.MaterielStructInfo dal = new Hownet.DAL.MaterielStructInfo();
        public MaterielStructInfo()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int InfoID)
        {
            return dal.Exists(InfoID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.MaterielStructInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielStructInfo> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.MaterielStructInfo model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.MaterielStructInfo> li = DataTableToList(dt);
            if (li.Count > 0)
            {
                dal.Update(li[0]);
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int InfoID)
        {

            dal.Delete(InfoID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Hownet.Model.MaterielStructInfo GetModel(int InfoID)
        {

            return dal.GetModel(InfoID);
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
        public List<Hownet.Model.MaterielStructInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.MaterielStructInfo> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MaterielStructInfo> modelList = new List<Hownet.Model.MaterielStructInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MaterielStructInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MaterielStructInfo();
                    if (dt.Rows[n]["InfoID"].ToString() != "")
                    {
                        model.InfoID = int.Parse(dt.Rows[n]["InfoID"].ToString());
                    }
                    else
                    {
                        model.InfoID = 0;
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
                    }
                    if (dt.Rows[n]["ChildMaterielID"].ToString() != "")
                    {
                        model.ChildMaterielID = int.Parse(dt.Rows[n]["ChildMaterielID"].ToString());
                    }
                    else
                    {
                        model.ChildMaterielID = 0;
                    }
                    if (dt.Rows[n]["UsePartID"].ToString() != "")
                    {
                        model.UsePartID = int.Parse(dt.Rows[n]["UsePartID"].ToString());
                    }
                    else
                    {
                        model.UsePartID = 0;
                    }
                    if (dt.Rows[n]["DepartmentID"].ToString() != "")
                    {
                        model.DepartmentID = int.Parse(dt.Rows[n]["DepartmentID"].ToString());
                    }
                    else
                    {
                        model.DepartmentID = 0;
                    }
                    if (dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                    }
                    else
                    {
                        model.Amount = 0;
                    }
                    if (dt.Rows[n]["UsingTypeID"].ToString() != "")
                    {
                        model.UsingTypeID = int.Parse(dt.Rows[n]["UsingTypeID"].ToString());
                    }
                    else
                    {
                        model.UsingTypeID = 0;
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    else
                    {
                        model.MeasureID = 0;
                    }
                    if (dt.Rows[n]["Wastage"].ToString() != "")
                    {
                        model.Wastage = decimal.Parse(dt.Rows[n]["Wastage"].ToString());
                    }
                    else
                    {
                        model.Wastage = 0;
                    }
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    else
                    {
                        model.MainID = 0;
                    }
                    if (dt.Rows[n]["A"].ToString() != "")
                    {
                        model.A = int.Parse(dt.Rows[n]["A"].ToString());
                    }
                    else
                    {
                        model.A = 0;
                    }
                    if (dt.Rows[n]["IsTogethers"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsTogethers"].ToString() == "1") || (dt.Rows[n]["IsTogethers"].ToString().ToLower() == "true"))
                        {
                            model.IsTogethers = true;
                        }
                        else
                        {
                            model.IsTogethers = false;
                        }
                    }
                    if (dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    else
                    {
                        model.Price = 0;
                    }
                    if (dt.Rows[n]["IsCaic"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCaic"].ToString() == "1") || (dt.Rows[n]["IsCaic"].ToString().ToLower() == "true"))
                        {
                            model.IsCaic = true;
                        }
                        else
                        {
                            model.IsCaic = false;
                        }
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    else
                    {
                        model.Money = 0;
                    }
                    if (dt.Rows[n]["MSIID"].ToString() != "")
                    {
                        model.MSIID = int.Parse(dt.Rows[n]["MSIID"].ToString());
                    }
                    else
                    {
                        model.MSIID = 0;
                    }
                    if (dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    else
                    {
                        model.ColorID = 0;
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    if (dt.Rows[n]["ToColorID"].ToString() != "")
                    {
                        model.ToColorID = int.Parse(dt.Rows[n]["ToColorID"].ToString());
                    }
                    else
                    {
                        model.ToColorID = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["SupplierID"] != null && dt.Rows[n]["SupplierID"].ToString() != "")
                    {
                        model.SupplierID = int.Parse(dt.Rows[n]["SupplierID"].ToString());
                    }
                    model.SupplierName = dt.Rows[n]["SupplierName"].ToString();
                    model.SupplierSN = dt.Rows[n]["SupplierSN"].ToString();
                    if (dt.Rows[n]["SpecID"] != null && dt.Rows[n]["SpecID"].ToString() != "")
                    {
                        model.SpecID = int.Parse(dt.Rows[n]["SpecID"].ToString());
                    }
                    model.SpecName = dt.Rows[n]["SpecName"].ToString();
                    if (dt.Rows[n]["TaskMeasureID"] != null && dt.Rows[n]["TaskMeasureID"].ToString() != "")
                    {
                        model.TaskMeasureID = int.Parse(dt.Rows[n]["TaskMeasureID"].ToString());
                    }
                    if (dt.Rows[n]["TMAmount"] != null && dt.Rows[n]["TMAmount"].ToString() != "")
                    {
                        model.TMAmount = decimal.Parse(dt.Rows[n]["TMAmount"].ToString());
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

        /// <summary>
        /// 获得数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  成员方法

        public void Save(List<Hownet.Model.MaterielStructInfo> list,int MainID)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].A == 2)
                {
                    list[i].A = 1;
                    Update(list[i]);
                }
                else if (list[i].A == 3)
                {
                    list[i].A = 1;
                    list[i].MainID = MainID;
                    Add(list[i]);
                }
            }
        }
    }
}

