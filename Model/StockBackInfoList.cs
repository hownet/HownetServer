using System;
namespace Hownet.Model
{
    /// <summary>
    /// StockBackInfoList:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class StockBackInfoList
    {
        public StockBackInfoList()
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
        public int InfoID
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
        public string Remark
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsOK
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int BatchNumber
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal NotAmount
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
        public string QRID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepotInfoID
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
        public decimal NowAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int RListID
        {
            set;
            get;
        }
        #endregion Model

    }
}

