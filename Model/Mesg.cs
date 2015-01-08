using System;
namespace Hownet.Model
{
	/// <summary>
	/// Mesg:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Mesg
	{
		public Mesg()
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
		public int ID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int FillManID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FillMan
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
		public DateTime LastDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string TextContent
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
		public string Remark
		{
			set;
			get;
		}
		#endregion Model

	}
}

