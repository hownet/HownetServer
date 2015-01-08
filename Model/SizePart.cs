using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类SizePart 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class SizePart
    {
        public SizePart()
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
        public string Name
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
        public string EnName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsEnd
        {
            set;
            get;
        }
        /// <summary>
        /// 允许误差
        /// </summary>
        public string Tolerance
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

