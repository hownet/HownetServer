using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类CardReaderList 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class CardReaderList
	{
		public CardReaderList()
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
		/// 机器号
		/// </summary>
		public int NID
		{
			set;
			get;
		}
		/// <summary>
		/// 位置（部门）
		/// </summary>
		public int Location
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
		/// 1为考勤，2为成品入库，3为订餐，4为就餐
		/// </summary>
		public int TypeID
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

