using System;
namespace Hownet.Model
{
    /// <summary>
    /// MaterielStructMain:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class MaterielStructMain
    {
        public MaterielStructMain()
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
        public int MainID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Ver
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
        public DateTime DateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int CompanyID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int TaskID
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
        public bool IsDefault
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsVerify
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int VerifyManID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime VerifyDateTime
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Executant
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Money
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal WorkingMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 出厂价
        /// </summary>
        public decimal OutPrice
        {
            set;
            get;
        }
        /// <summary>
        /// 材料比
        /// </summary>
        public decimal MaterielPro
        {
            set;
            get;
        }
        /// <summary>
        /// 毛利润
        /// </summary>
        public decimal GrossProfit
        {
            set;
            get;
        }
        /// <summary>
        /// 毛利率
        /// </summary>
        public decimal GrossPro
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal CMT
        {
            set;
            get;
        }
        /// <summary>
        /// 该用量所使用的尺码
        /// </summary>
        public string BySizeName
        {
            set;
            get;
        }
        /// <summary>
        /// 该款式所有的尺码
        /// </summary>
        public string ExSize
        {
            set;
            get;
        }
        /// <summary>
        /// 主副料损耗
        /// </summary>
        public string MaterielLoss
        {
            set;
            get;
        }
        /// <summary>
        /// 包装材料损耗
        /// </summary>
        public string PackLoss
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int FillManID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string FillManName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string VerifyManName
        {
            set;
            get;
        }
        #endregion Model

    }
}

