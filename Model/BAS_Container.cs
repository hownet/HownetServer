using System;
namespace Hownet.Model
{
	/// <summary>
	/// BAS_Container:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BAS_Container
	{
		public BAS_Container()
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
		public string ContName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Volume
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Weight
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Dimension
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

