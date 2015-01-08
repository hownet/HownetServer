using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类ProductionPlan 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ProductionPlan
	{
		public ProductionPlan()
		{}
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
		public int SalesOrderInfoID
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
		public int BrandID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Num
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
		public DateTime LastDate
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
		public int PWorkingID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int BomID
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
		public bool IsTicket
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsBom
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
		public DateTime VerifyDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int VerifyMan
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int DeparmentID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int UpData
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FillDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int FilMan
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TicketDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string BedNO
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int PackingMethodID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SewingRemark
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
		public int ParentID
		{
			set;
			get;
		}
        /// <summary>
        /// 相关联计划单号
        /// </summary>
        public string AssociatedID
        {
            set;
            get;
        }
        /// <summary>
        /// 相关联款号
        /// </summary>
        public int AssociatedMatID
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

