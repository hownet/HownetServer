using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类SizeTableInfo 的摘要说明。
	/// </summary>
	public class SizeTableInfo
	{
		private readonly Hownet.DAL.SizeTableInfo dal=new Hownet.DAL.SizeTableInfo();
		public SizeTableInfo()
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
		public int  Add(Hownet.Model.SizeTableInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SizeTableInfo> li=DataTableToList(dt);
			if(li.Count>0)
			{
				return dal.Add(li[0]);
			}
			else
			{
				return 0;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Hownet.Model.SizeTableInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SizeTableInfo> li=DataTableToList(dt);
			if(li.Count>0)
			{
				dal.Update(li[0]);
			}
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
		public Hownet.Model.SizeTableInfo GetModel(int ID)
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
		public List<Hownet.Model.SizeTableInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.SizeTableInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SizeTableInfo> modelList = new List<Hownet.Model.SizeTableInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SizeTableInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SizeTableInfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					else
					{
						model.MainID=0;
					}
					model.Orders=dt.Rows[n]["Orders"].ToString();
					if(dt.Rows[n]["Measurement"].ToString()!="")
					{
						model.Measurement=int.Parse(dt.Rows[n]["Measurement"].ToString());
					}
					else
					{
						model.Measurement=0;
					}
					model.Size1=dt.Rows[n]["Size1"].ToString();
					model.Size2=dt.Rows[n]["Size2"].ToString();
					model.Size3=dt.Rows[n]["Size3"].ToString();
					model.Size4=dt.Rows[n]["Size4"].ToString();
					model.Size5=dt.Rows[n]["Size5"].ToString();
					model.Size6=dt.Rows[n]["Size6"].ToString();
					model.Size7=dt.Rows[n]["Size7"].ToString();
					model.Size8=dt.Rows[n]["Size8"].ToString();
					model.Size9=dt.Rows[n]["Size9"].ToString();
					model.Size10=dt.Rows[n]["Size10"].ToString();
					model.Size11=dt.Rows[n]["Size11"].ToString();
					model.Size12=dt.Rows[n]["Size12"].ToString();
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
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
        public DataSet GetInfoList(int MainID)
        {
            return dal.GetInfoList(MainID);
        }
		/// <summary>
		/// 获得分页数据列表
		/// </summary>
		//public DataSet GetPageList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

