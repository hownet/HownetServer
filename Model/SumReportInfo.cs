using System;
namespace Hownet.Model
{
    /// <summary>
    /// SumReportInfo:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class SumReportInfo
    {
        public SumReportInfo()
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
        public int ColorOneID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorTwoID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SizeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal LastAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal InAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal OutAmount
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
        #endregion Model

    }
}

