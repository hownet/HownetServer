using System;
namespace Hownet.Model
{
	/// <summary>
	/// Bas_TestingScheme:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Bas_TestingScheme
	{
		public Bas_TestingScheme()
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
		public string SchemeName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchemeEnName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchemeProduct
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchemeContent
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
		public long AutoInc
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SchemeAutoInc
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
		public int IsEnd
		{
			set;
			get;
		}
		#endregion Model

	}
}

