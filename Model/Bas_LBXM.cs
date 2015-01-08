using System;
namespace Hownet.Model
{
	/// <summary>
	/// Bas_LBXM:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Bas_LBXM
	{
		public Bas_LBXM()
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
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ParentID
		{
			set;
			get;
		}
		#endregion Model

	}
}

