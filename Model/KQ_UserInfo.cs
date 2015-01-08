using System;
namespace Hownet.Model
{
	/// <summary>
	/// KQ_UserInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KQ_UserInfo
	{
		public KQ_UserInfo()
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
		public int UserID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int EmpID
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
        public int Privilege
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int Password
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int enabled
        {
            set;
            get;
        }
		#endregion Model

	}
}

