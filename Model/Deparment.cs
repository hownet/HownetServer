using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Deparment 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
    [Serializable]
    public class Deparment
    {
        public Deparment()
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
        public string Sn
        {
            set;
            get;
        }
        public int IsEnd
        {
            set;
            get;
        }
        public int TypeID
        {
            set;
            get;
        }
        public int ParentID
        {
            set;
            get;
        }
        public int CountEmployee
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

