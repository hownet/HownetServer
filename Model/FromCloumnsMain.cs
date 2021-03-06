﻿using System;
namespace Hownet.Model
{
    /// <summary>
    /// FromCloumnsMain:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class FromCloumnsMain
    {
        public FromCloumnsMain()
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
        public string ClassName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string CFormName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string EFormName
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

