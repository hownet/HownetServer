using System;
namespace Hownet.Model
{
    /// <summary>
    /// Bas_KJKM:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Bas_KJKM
    {
        public Bas_KJKM()
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
        public int Orders
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Num
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ParentID
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
        public decimal Money
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
        /// <summary>
        /// 
        /// </summary>
        public decimal DebitMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CreditMoney
        {
            set;
            get;
        }
        public int MoneyType
        {
            set;
            get;
        }
        #endregion Model

    }
}

