using System;
using System.Data;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类PaySum 的摘要说明。
	/// </summary>
	public class PaySum
	{
		private readonly Hownet.DAL.PaySum dal=new Hownet.DAL.PaySum();
		public PaySum()
		{}
		#region  成员方法

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Hownet.Model.PaySum model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Hownet.Model.PaySum model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.PaySum GetModel(int ID)
		{
			return dal.GetModel(ID);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        /// <summary>
        /// 删除一次工资汇总数量
        /// </summary>
        /// <param name="MainID"></param>
        public void DelPay(int MainID)
        {
            dal.DelPay(MainID);
        }
         /// <summary>
        /// 返回两日期之间所录入工票及手工记录数量
        /// </summary>
        /// <param name="DateOne"></param>
        /// <param name="DateTwo"></param>
        /// <returns></returns>
        public DataSet SumAmount(DateTime DateOne, DateTime DateTwo)
        {
            return dal.SumAmount(DateOne, DateTwo);
        }
        public DataSet SumAmountByPW(DateTime DateOne, DateTime DateTwo, int EmployeeID, bool IsInfo, int MaterielID, int WorkingID, bool SumColor,int DepID)
        {
            return dal.SumAmountByPW(DateOne, DateTwo, EmployeeID, IsInfo, MaterielID, WorkingID, SumColor,DepID);
        }
        public DataSet GetSumAmountByPW(DateTime DateOne, DateTime DateTwo, bool SumColor)
        {
            return dal.GetSumAmountByPW(DateOne, DateTwo, SumColor);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

