using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类DepartmentJobs 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class DepartmentJobs
    {
        public DepartmentJobs()
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
        public string JobsName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepartmentID
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
        public int EmployeeCount
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
        public int A
        {
            set;
            get;
        }
        #endregion Model

    }
}

