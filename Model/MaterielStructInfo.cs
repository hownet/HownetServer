using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类MaterielStructInfo 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class MaterielStructInfo
    {
        public MaterielStructInfo()
        { }
        #region Model
        /// <summary>
        /// 
        /// </summary>
        public int InfoID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MaterielID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ChildMaterielID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int UsePartID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepartmentID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int UsingTypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MeasureID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Wastage
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MainID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsTogethers
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Price
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsCaic
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Money
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MSIID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int CompanyID
        {
            set;
            get;
        }
        public int ToColorID
        {
            set;
            get;
        }
        public string Remark
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SupplierID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string SupplierSN
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SpecID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string SpecName
        {
            set;
            get;
        }
        /// <summary>
        /// 车间单位
        /// </summary>
        public int TaskMeasureID
        {
            set;
            get;
        }
        /// <summary>
        /// 按车间单位的数量
        /// </summary>
        public decimal TMAmount
        {
            set;
            get;
        }
        public int A
        {
            set;
            get;
        }
        #endregion Model

    }
}

