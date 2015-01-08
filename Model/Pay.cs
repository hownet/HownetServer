using System;
namespace Hownet.Model
{
    /// <summary>
    /// Pay:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Pay
    {
        public Pay()
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
        /// 结存
        /// </summary>
        public decimal? Remain
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeID
        {
            set;
            get;
        }
        /// <summary>
        /// 月计件工资
        /// </summary>
        public decimal? Month
        {
            set;
            get;
        }
        /// <summary>
        /// 预支款
        /// </summary>
        public decimal? Payment
        {
            set;
            get;
        }
        /// <summary>
        /// 伙食费
        /// </summary>
        public decimal? BoardWages
        {
            set;
            get;
        }
        /// <summary>
        /// 补贴
        /// </summary>
        public decimal? Repair
        {
            set;
            get;
        }
        /// <summary>
        /// 上月结存
        /// </summary>
        public decimal? LastRemain
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
        /// 实发工资
        /// </summary>
        public decimal? Fact
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool? IsEnd
        {
            set;
            get;
        }
        /// <summary>
        /// 全勤奖
        /// </summary>
        public decimal? FullAttendance
        {
            set;
            get;
        }
        /// <summary>
        /// 罚款
        /// </summary>
        public decimal? Fine
        {
            set;
            get;
        }
        /// <summary>
        /// 押金
        /// </summary>
        public decimal? Deposit
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add1
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add2
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add3
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add4
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Add5
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian1
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian2
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian3
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian4
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Jian5
        {
            set;
            get;
        }
        /// <summary>
        /// 计算了保底后的总工资
        /// </summary>
        public decimal ActualMonth
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool NotFact
        {
            set;
            get;
        }
        #endregion Model

    }
}

