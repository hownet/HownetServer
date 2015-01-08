using System;
namespace Hownet.Model
{
    /// <summary>
    /// FinanceSet:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class FinanceSet
    {
        public FinanceSet()
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
        public int Levels
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Lengths
        {
            set;
            get;
        }
        #endregion Model

    }
}

