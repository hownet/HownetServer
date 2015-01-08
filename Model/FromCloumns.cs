using System;
namespace Hownet.Model
{
    /// <summary>
    /// FromCloumns:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class FromCloumns
    {
        public FromCloumns()
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
        public string Fileds
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string CName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Width
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsShow
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsCanEdit
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsCanFilter
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsCanGroup
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsCanSort
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsFix
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
        public string EName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int UserID
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
        public bool IsMust
        {
            set;
            get;
        }
        public int TypeID
        {
            set;
            get;
        }
        public int OrderBy
        {
            set;
            get;
        }
        #endregion Model

    }
}

