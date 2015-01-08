using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类PayCosts 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class PayCosts
    {
        public PayCosts()
        { }
        #region Model
        private int _id;
        private DateTime _datetime;
        private int _typeid;
        private string _remark;
        private int _num;
        private int _fillman;
        private DateTime _filldate;
        private int _isverify;
        private int _verifyman;
        private DateTime _verifydate;
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
        public DateTime DateTime
        {
            set { _datetime = value; }
            get { return _datetime; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TypeID
        {
            set { _typeid = value; }
            get { return _typeid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Remark
        {
            set { _remark = value; }
            get { return _remark; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Num
        {
            set { _num = value; }
            get { return _num; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int FillMan
        {
            set { _fillman = value; }
            get { return _fillman; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime FillDate
        {
            set { _filldate = value; }
            get { return _filldate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int IsVerify
        {
            set { _isverify = value; }
            get { return _isverify; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int VerifyMan
        {
            set { _verifyman = value; }
            get { return _verifyman; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime VerifyDate
        {
            set { _verifydate = value; }
            get { return _verifydate; }
        }
        #endregion Model

    }
}

