using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Working 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Working
	{
		public Working()
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
		public int WorkTypeID
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
		public bool IsUse
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
        public bool IsSpecial
        {
            set;
            get;
        }
        public decimal Price
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

