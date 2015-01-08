using System;
namespace Hownet.Model
{
	/// <summary>
	/// BAS_ExchangeRate:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BAS_ExchangeRate
	{
		public BAS_ExchangeRate()
		{}
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
		public int SourceCurrency
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int TargetCurrency
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ExchangeRate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsValid
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
		public int IsEnd
		{
			set;
			get;
		}
		#endregion Model

	}
}

