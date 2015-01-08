using System;
namespace Hownet.Model
{
    /// <summary>
    /// PayMain:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PayMain
    {
        public PayMain()
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
        public DateTime BegingDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime EndDate
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Indexs
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
        public DateTime VerifyDateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int CaicType
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Posting
        {
            set;
            get;
        }
        #endregion Model

    }
}

