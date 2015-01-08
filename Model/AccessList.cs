using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类AccessList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class AccessList
	{
		public AccessList()
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
		public int AccessID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int EmployeeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string PassWord
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

