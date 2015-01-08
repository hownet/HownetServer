using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Holidays 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Holidays
	{
		public Holidays()
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
		/// 假期类型，1为工人请假，2为工厂放假，3为午连班，4为晚连班，5为通宵
		/// </summary>
		public int TypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeOne
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime TimeTwo
		{
			set;
			get;
		}
		/// <summary>
		/// 为0时指所有工人
		/// </summary>
		public int EmployeeID
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
		public int MainID
		{
			set;
			get;
		}
		/// <summary>
		/// 放假期间，是否发放工资
		/// </summary>
		public bool IsCaicMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 假期分钟数
		/// </summary>
		public int Times
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

