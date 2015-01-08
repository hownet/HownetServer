using System;
namespace Hownet.Model
{
    /// <summary>
    /// PayColumnsSet:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PayColumnsSet
    {
        public PayColumnsSet()
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
        /// 列类型，1为扣减后需累加到员工，2为增加项，3为扣费项
        /// </summary>
        public int TypeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Caic
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string ColumnsName
        {
            set;
            get;
        }
        /// <summary>
        /// 是费用类型
        /// </summary>
        public bool IsCosts
        {
            set;
            get;
        }
        /// <summary>
        /// 扣款项，需要归还员工
        /// </summary>
        public bool IsBack
        {
            set;
            get;
        }
        #endregion Model

    }
}

