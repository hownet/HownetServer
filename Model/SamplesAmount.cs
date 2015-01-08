using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类SamplesAmount 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SamplesAmount
	{
		public SamplesAmount()
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
		public int MainID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int MainTableTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ColorID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SizeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Amount
		{
			set;
			get;
		}
		/// <summary>
		/// 樣版類型，1為影相辦，2為生產辦，3為測試版
		/// </summary>
		public int SamplesID
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
		public int A
		{
		set;
		get;
		}
		#endregion Model

	}
}

