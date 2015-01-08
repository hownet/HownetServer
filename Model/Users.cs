using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Users 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Users
	{
		public Users()
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
		/// 登录名
		/// </summary>
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] Password
		{
			set;
			get;
		}
		/// <summary>
		/// 真实姓名
		/// </summary>
		public string TrueName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
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
		public int DepartmentID
		{
			set;
			get;
		}
		/// <summary>
		/// 状态
		/// </summary>
		public int State
		{
			set;
			get;
		}
        /// <summary>
        /// 职位
        /// </summary>
        public int JobsID
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

