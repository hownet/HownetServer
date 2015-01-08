using System;
namespace Hownet.Model
{
	/// <summary>
	/// FixedAssetsOut:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FixedAssetsOut
	{
		public FixedAssetsOut()
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
		/// 资产ID
		/// </summary>
		public int FAID
		{
			set;
			get;
		}
		/// <summary>
		/// 借出日期
		/// </summary>
		public DateTime OutDate
		{
			set;
			get;
		}
		/// <summary>
		/// 预计归还日期
		/// </summary>
		public DateTime ExpectedBackDate
		{
			set;
			get;
		}
		/// <summary>
		/// 实际归还日期
		/// </summary>
		public DateTime ActualBackDate
		{
			set;
			get;
		}
		/// <summary>
		/// 借用部门
		/// </summary>
		public int OutDeparmentID
		{
			set;
			get;
		}
		/// <summary>
		/// 借用人
		/// </summary>
		public int OutUserID
		{
			set;
			get;
		}
		/// <summary>
		/// 批准人
		/// </summary>
		public int VerifyManID
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
		#endregion Model

	}
}

