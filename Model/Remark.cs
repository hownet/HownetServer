using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Remark 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Remark
	{
		public Remark()
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
		public int TableTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remarks
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

