using System;
namespace Hownet.Model
{
    /// <summary>
    /// Product2Depot:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Product2Depot
    {
        public Product2Depot()
        { }
        #region Model
        /// <summary>
        /// A，用于标识是否被修改
        /// </summary>
        public int A
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Num
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepotID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsVerify
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int VerifyMan
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime VerifyDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int UpData
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int TypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DeparmentID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DeparmentTypeID
        {
            set;
            get;
        }
        public decimal Weight
        {
            set;
            get;
        }
        #endregion Model

    }
}

