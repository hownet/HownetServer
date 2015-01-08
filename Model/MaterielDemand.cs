using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类MaterielDemand 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class MaterielDemand
    {
        public MaterielDemand()
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
        public int ProduceTaskID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MaterielID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorOneID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorTwoID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal NotAllotAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal stockAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal stockNotAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SizeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MeasureID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int MListID
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
        public int IsEnd
        {
            set;
            get;
        }
        /// <summary>
        /// 已备料数量
        /// </summary>
        public decimal RepertoryAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 已申购未采购数量
        /// </summary>
        public decimal NeedAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 已采购未收回数量
        /// </summary>
        public decimal HasStockAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 已出库数量
        /// </summary>
        public decimal OutAmount
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

