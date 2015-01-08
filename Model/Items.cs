using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Items 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Items
	{
		public Items()
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
		public string Text
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
		/// 
		/// </summary>
		public string FormName
		{
			set;
			get;
		}
		/// <summary>
		/// 是否有下一级
		/// </summary>
		public int IsModule
		{
			set;
			get;
		}
		/// <summary>
		/// 层级数
		/// </summary>
		public int Level
		{
			set;
			get;
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int Orders
		{
			set;
			get;
		}
		/// <summary>
		/// 是否显示
		/// </summary>
		public int IsBar
		{
			set;
			get;
		}
		/// <summary>
		/// 参数
		/// </summary>
		public string Parameter
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

