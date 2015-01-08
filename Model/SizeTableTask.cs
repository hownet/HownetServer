using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类SizeTableTask 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SizeTableTask
	{
		public SizeTableTask()
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
		public int SizeID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int SizePartID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int TaskID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal Length
		{
			set;
			get;
		}
        public int MaterielID
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

