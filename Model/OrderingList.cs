using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类OrderingList 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class OrderingList
    {
        public OrderingList()
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
        /// 员工ID
        /// </summary>
        public int EmployeeID
        {
            set;
            get;
        }
        /// <summary>
        /// 所订的就餐日期，或就餐日期
        /// </summary>
        public DateTime DateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 订餐
        /// </summary>
        public int OrderOne
        {
            set;
            get;
        }
        /// <summary>
        /// 就餐
        /// </summary>
        public int DinOne
        {
            set;
            get;
        }
        /// <summary>
        /// 订餐刷卡时间
        /// </summary>
        public DateTime OrderOneTime
        {
            set;
            get;
        }
        /// <summary>
        /// 就餐刷卡时间
        /// </summary>
        public DateTime DiningOneTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OrderTwo
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DinTwo
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OrdeTwoTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DiningTwoTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OrderThree
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DinThree
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OrdeThreeTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DiningThreeTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OrderCount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DinCount
        {
            set;
            get;
        }
        public decimal Money
        {
            set;
            get;
        }
        public bool IsSum
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

