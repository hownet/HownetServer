using System;
namespace Hownet.Model
{
    /// <summary>
    /// Materiel:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Materiel
    {
        public Materiel()
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
        public int TypeID
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
        public string Sn
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
        public int AttributeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SecondMeasureID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Conversion
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
        /// 
        /// </summary>
        public bool IsUse
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Image
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Designers
        {
            set;
            get;
        }
        /// <summary>
        /// 所需要的规格。0为不需要，1为颜色，2为尺码，3为颜色和尺码
        /// </summary>
        public int SelectSpec
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string TiaoMaH
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ChengBengJ
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal LingShouJia
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal YiJiDaiLiJia
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal ErJiDaiLiJia
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal SanJiDaiLiJia
        {
            set;
            get;
        }
        #endregion Model

    }
}

