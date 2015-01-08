using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类SalesPrice 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class SalesPrice
    {
        public SalesPrice()
        { }
        #region Model
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
        public int MTID
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
        public int SalesID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Amount
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
        public int A
        {
            set;
            get;
        }
        #endregion Model

    }
}

