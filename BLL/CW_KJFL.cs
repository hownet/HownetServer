using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// CW_KJFL
	/// </summary>
	public partial class CW_KJFL
	{
		private readonly Hownet.DAL.CW_KJFL dal=new Hownet.DAL.CW_KJFL();
		public CW_KJFL()
		{}
		#region  Method

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
		public int  Add(Hownet.Model.CW_KJFL model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.CW_KJFL> li = DataTableToList(dt);
			int a=0;
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					a=Add(li[i]);
				}
			}
				return a;
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Hownet.Model.CW_KJFL model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.CW_KJFL> li = DataTableToList(dt);
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					 dal.Update(li[i]);
				}
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.CW_KJFL GetModel(int ID)
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
		/// 获得前几行数据
		/// </summary>
		public DataSet GetTopList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.CW_KJFL> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.CW_KJFL> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.CW_KJFL> modelList = new List<Hownet.Model.CW_KJFL>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.CW_KJFL model;
                try
                {
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new Hownet.Model.CW_KJFL();
                        if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        model.编号 = dt.Rows[n]["编号"].ToString();
                        model.年 = dt.Rows[n]["年"].ToString();
                        model.月 = dt.Rows[n]["月"].ToString();
                        model.日 = dt.Rows[n]["日"].ToString();
                        model.时间 = dt.Rows[n]["时间"].ToString();
                        model.附件 = dt.Rows[n]["附件"].ToString();
                        model.制单人 = dt.Rows[n]["制单人"].ToString();
                        model.审核 = dt.Rows[n]["审核"].ToString();
                        model.记帐 = dt.Rows[n]["记帐"].ToString();
                        model.财务主管 = dt.Rows[n]["财务主管"].ToString();
                        if (dt.Rows[n]["制单人ID"] != null && dt.Rows[n]["制单人ID"].ToString() != "")
                        {
                            model.制单人ID = int.Parse(dt.Rows[n]["制单人ID"].ToString());
                        }
                        if (dt.Rows[n]["审核ID"] != null && dt.Rows[n]["审核ID"].ToString() != "")
                        {
                            model.审核ID = int.Parse(dt.Rows[n]["审核ID"].ToString());
                        }
                        if (dt.Rows[n]["记帐ID"] != null && dt.Rows[n]["记帐ID"].ToString() != "")
                        {
                            model.记帐ID = int.Parse(dt.Rows[n]["记帐ID"].ToString());
                        }
                        model.财务主管ID = dt.Rows[n]["财务主管ID"].ToString();
                        model.制单日期 = dt.Rows[n]["制单日期"].ToString();
                        model.审核日期 = dt.Rows[n]["审核日期"].ToString();
                        model.记账日期 = dt.Rows[n]["记账日期"].ToString();
                        model.主管审核日期 = dt.Rows[n]["主管审核日期"].ToString();
                        model.帐户 = dt.Rows[n]["帐户"].ToString();
                        if (dt.Rows[n]["帐户ID"] != null && dt.Rows[n]["帐户ID"].ToString() != "")
                        {
                            model.帐户ID = int.Parse(dt.Rows[n]["帐户ID"].ToString());
                        }
                        if (dt.Rows[n]["TypeID"] != null && dt.Rows[n]["TypeID"].ToString() != "")
                        {
                            model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                        }
                        if (dt.Rows[n]["TableID"] != null && dt.Rows[n]["TableID"].ToString() != "")
                        {
                            model.TableID = int.Parse(dt.Rows[n]["TableID"].ToString());
                        }
                        modelList.Add(model);
                    }
                }
                catch (Exception ex)
                {
                }
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}
        public DataSet GetIDList(int TypeID)
        {
            return dal.GetIDList(TypeID);
        }
        public int NewNum(DateTime dt, int TypeID)
        {
            return dal.NewNum(dt, TypeID);
        }
        public DataSet GetInfoList(DateTime dt1, DateTime dt2, int TypeID)
        {
            return dal.GetInfoList(dt1, dt2, TypeID);
        }
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

