using System;
namespace Hownet.Model
{
	/// <summary>
	/// ItemsText:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ItemsText
	{
		public ItemsText()
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
		public int ItemsID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ColumnsName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShowText
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsVisible
		{
			set;
			get;
		}
        public int Widths
        {
            set;
            get;
        }
		#endregion Model

	}
}

