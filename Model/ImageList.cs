using System;
namespace Hownet.Model
{
	/// <summary>
	/// ImageList:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ImageList
	{
		public ImageList()
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
		public string Remark
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Image
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int MainID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int TableTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string SerName
		{
			set;
			get;
		}
		#endregion Model

	}
}

