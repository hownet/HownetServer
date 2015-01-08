using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// PayColumnsSet
	/// </summary>
	public partial class PayColumnsSet
	{
		private readonly Hownet.DAL.PayColumnsSet dal=new Hownet.DAL.PayColumnsSet();
		public PayColumnsSet()
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
		public int  Add(Hownet.Model.PayColumnsSet model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.PayColumnsSet> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.PayColumnsSet model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.PayColumnsSet> li = DataTableToList(dt);
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
		public Hownet.Model.PayColumnsSet GetModel(int ID)
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.PayColumnsSet> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.PayColumnsSet> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.PayColumnsSet> modelList = new List<Hownet.Model.PayColumnsSet>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.PayColumnsSet model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.PayColumnsSet();
                    if (dt.Rows[n]["ID"] != null && dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.Name = dt.Rows[n]["Name"].ToString();
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["TypeID"] != null && dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    if (dt.Rows[n]["Caic"] != null && dt.Rows[n]["Caic"].ToString() != "")
                    {
                        model.Caic = int.Parse(dt.Rows[n]["Caic"].ToString());
                    }
                    model.ColumnsName = dt.Rows[n]["ColumnsName"].ToString();
                    if (dt.Rows[n]["IsCosts"] != null && dt.Rows[n]["IsCosts"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCosts"].ToString() == "1") || (dt.Rows[n]["IsCosts"].ToString().ToLower() == "true"))
                        {
                            model.IsCosts = true;
                        }
                        else
                        {
                            model.IsCosts = false;
                        }
                    }
                    if (dt.Rows[n]["IsBack"] != null && dt.Rows[n]["IsBack"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsBack"].ToString() == "1") || (dt.Rows[n]["IsBack"].ToString().ToLower() == "true"))
                        {
                            model.IsBack = true;
                        }
                        else
                        {
                            model.IsBack = false;
                        }
                    }
                    modelList.Add(model);
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
        public DataSet GetTypeList()
        {
            return dal.GetTypeList();
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

