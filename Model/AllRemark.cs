using System;
namespace Hownet.Model
{
    /// <summary>
    /// AllRemark:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class AllRemark
    {
        public AllRemark()
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
        public int TableTypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OTID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string OTName
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
        #endregion Model

    }
}

