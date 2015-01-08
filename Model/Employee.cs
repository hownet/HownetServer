using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类Employee 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Employee
	{
		public Employee()
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
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// 介绍人
		/// </summary>
		public int IntroducerID
		{
			set;
			get;
		}
		/// <summary>
		/// 身份证
		/// </summary>
		public string IdentityCard
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Sex
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Sn
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int Province
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
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
		/// 到职日期
		/// </summary>
		public DateTime AccessionDate
		{
			set;
			get;
		}
		/// <summary>
		/// 工种
		/// </summary>
		public int WorkTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 工资种类
		/// </summary>
		public int PayID
		{
			set;
			get;
		}
		/// <summary>
		/// 离职日期
		/// </summary>
		public DateTime DimissionDate
		{
			set;
			get;
		}
		/// <summary>
		/// 床铺
		/// </summary>
		public int BedID
		{
			set;
			get;
		}
		/// <summary>
		/// 餐桌
		/// </summary>
		public int TableID
		{
			set;
			get;
		}
		/// <summary>
		/// 部门
		/// </summary>
		public int DepartmentID
		{
			set;
			get;
		}
		/// <summary>
		/// 学位
		/// </summary>
		public int DegreeID
		{
			set;
			get;
		}
		/// <summary>
		/// 政治面貌
		/// </summary>
		public int PolityID
		{
			set;
			get;
		}
		/// <summary>
		/// 紧急联系电话
		/// </summary>
		public string SOSPhone
		{
			set;
			get;
		}
		/// <summary>
		/// 紧急联系人
		/// </summary>
		public string SOSMan
		{
			set;
			get;
		}
		/// <summary>
		/// 现居住地
		/// </summary>
		public string NowAddress
		{
			set;
			get;
		}
		/// <summary>
		/// 填写日期
		/// </summary>
		public DateTime FillDate
		{
			set;
			get;
		}
		/// <summary>
		/// 填写人
		/// </summary>
		public int FillUser
		{
			set;
			get;
		}
		/// <summary>
		/// 固定或保底工资
		/// </summary>
		public decimal LassMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 保底或提成比例
		/// </summary>
		public decimal Royalty
		{
			set;
			get;
		}
		/// <summary>
		/// 照片
		/// </summary>
		public string Image
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsUse
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

