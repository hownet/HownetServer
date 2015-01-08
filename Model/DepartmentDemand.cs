using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类DepartmentDemand 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public class DepartmentDemand
    {
        public DepartmentDemand()
        { }
        #region Model
        private int _id;
        private int _depid;
        private int _coloroneid;
        private int _departmenttaskid;
        private int _materielid;
        private int _colorid;
        private int _colortwoid;
        private decimal _amount;
        private decimal _notamount;
        private int _sizeid;
        private int _measureid;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepID
        {
            set { _depid = value; }
            get { return _depid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorOneID
        {
            set { _coloroneid = value; }
            get { return _coloroneid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DepartmentTaskID
        {
            set { _departmenttaskid = value; }
            get { return _departmenttaskid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MaterielID
        {
            set { _materielid = value; }
            get { return _materielid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorID
        {
            set { _colorid = value; }
            get { return _colorid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ColorTwoID
        {
            set { _colortwoid = value; }
            get { return _colortwoid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal NotAmount
        {
            set { _notamount = value; }
            get { return _notamount; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int SizeID
        {
            set { _sizeid = value; }
            get { return _sizeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int MeasureID
        {
            set { _measureid = value; }
            get { return _measureid; }
        }
        public int MListID { get; set; }
        #endregion Model

    }
}

