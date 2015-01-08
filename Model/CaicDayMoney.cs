using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类CaicDayMoney 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class CaicDayMoney
	{
		public CaicDayMoney()
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
		public decimal DayMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal NightMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal LateAtNightMoney
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
		/// 通宵补贴
		/// </summary>
		public decimal TXBT
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

