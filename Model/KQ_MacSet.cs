using System;
namespace Hownet.Model
{
	/// <summary>
	/// KQ_MacSet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KQ_MacSet
	{
		public KQ_MacSet()
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
		public string IPAddress
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Port
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int MacNumber
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComPort
		{
			set;
			get;
		}
        /// <summary>
        /// 
        /// </summary>
        public bool IsDefault
        {
            set;
            get;
        }
		#endregion Model

	}
}

