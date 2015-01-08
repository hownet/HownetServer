using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类PlanUseRep 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class PlanUseRep
	{
		public PlanUseRep()
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
		/// 相关表明细ID，与TypeID相关,当TypeID为采购单时，此处为申购单ID
		/// </summary>
		public int RelatedID
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
		/// 物料计算表ID
		/// </summary>
		public int DemandID
		{
			set;
			get;
		}
		/// <summary>
		/// 1为使用库存余量，2为使用采购余量
		/// </summary>
		public int TypeID
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
		/// 计划单ID
		/// </summary>
		public int TaskID
		{
			set;
			get;
		}
		/// <summary>
		/// 请购单明细ID
		/// </summary>
		public int StockInfoID
		{
			set;
			get;
		}
        public decimal NotAmount
        {
            set;
            get;
        }
        public int IsEnd
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

