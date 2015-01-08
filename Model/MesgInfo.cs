using System;
namespace Hownet.Model
{
	/// <summary>
	/// MesgInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MesgInfo
	{
		public MesgInfo()
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
		public int MainID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ToID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ToMan
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
		public bool IsRead
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsEnd
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsComplete
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LastDateTime
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CompleteDateTime
		{
			set;
			get;
		}
		#endregion Model

	}
}

