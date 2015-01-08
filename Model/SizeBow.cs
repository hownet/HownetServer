using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类SizeBow 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class SizeBow
	{
		public SizeBow()
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
		/// 钢弓
		/// </summary>
		public int BowID
		{
			set;
			get;
		}
		/// <summary>
		/// 棉碗
		/// </summary>
		public int CottonID
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
		/// 肩带
		/// </summary>
		public int Sash
		{
			set;
			get;
		}
		/// <summary>
		/// 透明肩带/背带
		/// </summary>
		public int OpenSash
		{
			set;
			get;
		}
		/// <summary>
		/// 胶骨
		/// </summary>
		public int PlasticBone
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

