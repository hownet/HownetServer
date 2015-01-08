using System;
namespace Hownet.Model
{
    /// <summary>
    /// VouchersInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class VouchersInfo
    {
        public VouchersInfo()
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
        public int MainID
        {
            set;
            get;
        }
        /// <summary>
        /// 摘要
        /// </summary>
        public string Summary
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int AccountsOne
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int AccountsTwo
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
        /// <summary>
        /// 
        /// </summary>
        public bool IsPosting
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string AOne
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ATwo
        {
            set;
            get;
        }
        #endregion Model

    }
}

