using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Color 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Color
	{
		public Color()
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
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sn
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Value
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
		public bool IsUse
		{
			set;
			get;
		}
		/// <summary>
		/// 色系
		/// </summary>
		public int ColorTypeID
		{
			set;
			get;
		}
        public string Remark
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

