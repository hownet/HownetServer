using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// KQ_MacSet
	/// </summary>
	public partial class KQ_MacSet
	{
		private readonly Hownet.DAL.KQ_MacSet dal=new Hownet.DAL.KQ_MacSet();
		public KQ_MacSet()
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
		public int  Add(Hownet.Model.KQ_MacSet model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_MacSet> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.KQ_MacSet model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_MacSet> li = DataTableToList(dt);
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
		public Hownet.Model.KQ_MacSet GetModel(int ID)
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
        public DataSet GetTopList(int Top, string strWhere, string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.KQ_MacSet> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.KQ_MacSet> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.KQ_MacSet> modelList = new List<Hownet.Model.KQ_MacSet>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.KQ_MacSet model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.KQ_MacSet();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.IPAddress=dt.Rows[n]["IPAddress"].ToString();
					if(dt.Rows[n]["Port"]!=null && dt.Rows[n]["Port"].ToString()!="")
					{
						model.Port=int.Parse(dt.Rows[n]["Port"].ToString());
					}
					if(dt.Rows[n]["MacNumber"]!=null && dt.Rows[n]["MacNumber"].ToString()!="")
					{
						model.MacNumber=int.Parse(dt.Rows[n]["MacNumber"].ToString());
					}
					model.ComPort=dt.Rows[n]["ComPort"].ToString();
                    if (dt.Rows[n]["IsDefault"] != null && dt.Rows[n]["IsDefault"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsDefault"].ToString() == "1") || (dt.Rows[n]["IsDefault"].ToString().ToLower() == "true"))
                        {
                            model.IsDefault = true;
                        }
                        else
                        {
                            model.IsDefault = false;
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

