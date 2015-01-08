using System;
namespace Hownet.Model
{
	/// <summary>
	/// BAS_Country:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BAS_Country
	{
		public BAS_Country()
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
		public string Code
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string EnName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string CnName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int? RegionID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool? IsDef
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
		public string CreditRank
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

