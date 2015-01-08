using System;
namespace Hownet.Model
{
	/// <summary>
	/// 实体类WorkTicketIDBack 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class WorkTicketIDBack
	{
		public WorkTicketIDBack()
		{}
		#region Model
		private int _id;
		private DateTime _datetime;
		private string _ticketidcardid;
		private int _employeeidcardid;
		private int _workticketid;
		private int _workingid;
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
		public DateTime DateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TicketIDCardID
		{
			set{ _ticketidcardid=value;}
			get{return _ticketidcardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EmployeeIDCardID
		{
			set{ _employeeidcardid=value;}
			get{return _employeeidcardid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WorkTicketID
		{
			set{ _workticketid=value;}
			get{return _workticketid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WorkingID
		{
			set{ _workingid=value;}
			get{return _workingid;}
		}
		#endregion Model

	}
}

