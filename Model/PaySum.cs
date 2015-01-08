using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类PaySum 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	public class PaySum
	{
		public PaySum()
		{}
		#region Model
		private int _id;
		private int _materielid;
		private int _workingid;
		private int? _amount;
		private decimal? _price;
		private DateTime? _datetime;
		private int _employeeid;
		private int _paymainid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int MaterielID
		{
			set{ _materielid=value;}
			get{return _materielid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WorkingID
		{
			set{ _workingid=value;}
			get{return _workingid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EmployeeID
		{
			set{ _employeeid=value;}
			get{return _employeeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int PayMainID
		{
			set{ _paymainid=value;}
			get{return _paymainid;}
		}
		#endregion Model

	}
}

