using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类WorkTicket 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class WorkTicket
	{
		public WorkTicket()
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
		public int SizeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Amount
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int BoxNum
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
		public int DepartmentID
		{
			set;
			get;
		}
		/// <summary>
		/// 整箱入库时，入库单明细ID
		/// </summary>
		public int P2DInfoID
		{
			set;
			get;
		}
		/// <summary>
		/// 合格品
		/// </summary>
		public int EligibleAmount
		{
			set;
			get;
		}
		/// <summary>
		/// 次品
		/// </summary>
		public int InferiorAmount
		{
			set;
			get;
		}
		/// <summary>
		/// 整箱入库时，入库部门
		/// </summary>
		public int P2DDepartmentID
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
		public int BrandID
		{
			set;
			get;
		}
        public int OneAmount
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

