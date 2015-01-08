using System;
namespace Hownet.Model
{
    /// <summary>
    /// MoneyInOrOut:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MoneyInOrOut
    {
        public MoneyInOrOut()
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
        public int Num
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
        public int CompanyID
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
        public string Remark
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
        public decimal LastMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ChangMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int FillMan
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FillDate
        {
            set;
            get;
        }
        /// <summary>
        /// 会计科目 
        /// </summary>
        public int KJKMID
        {
            set;
            get;
        }
        /// <summary>
        /// 手续费
        /// </summary>
        public decimal Fees
        {
            set;
            get;
        }
        #endregion Model

    }
}

