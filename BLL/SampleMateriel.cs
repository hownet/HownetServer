using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类SampleMateriel 的摘要说明。
	/// </summary>
	public class SampleMateriel
	{
		private readonly Hownet.DAL.SampleMateriel dal=new Hownet.DAL.SampleMateriel();
		public SampleMateriel()
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
		public int  Add(Hownet.Model.SampleMateriel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMateriel> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.SampleMateriel model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMateriel> li=DataTableToList(dt);
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
		public Hownet.Model.SampleMateriel GetModel(int ID)
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
		public List<Hownet.Model.SampleMateriel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.SampleMateriel> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SampleMateriel> modelList = new List<Hownet.Model.SampleMateriel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SampleMateriel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SampleMateriel();
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
					model.Fabric1=dt.Rows[n]["Fabric1"].ToString();
					model.Fabric2=dt.Rows[n]["Fabric2"].ToString();
					model.Fabric3=dt.Rows[n]["Fabric3"].ToString();
					model.Fabric4=dt.Rows[n]["Fabric4"].ToString();
					model.Fabric5=dt.Rows[n]["Fabric5"].ToString();
					model.Materiel1=dt.Rows[n]["Materiel1"].ToString();
					model.Materiel2=dt.Rows[n]["Materiel2"].ToString();
					model.Materiel3=dt.Rows[n]["Materiel3"].ToString();
					model.Materiel4=dt.Rows[n]["Materiel4"].ToString();
					model.Materiel5=dt.Rows[n]["Materiel5"].ToString();
					model.Materiel6=dt.Rows[n]["Materiel6"].ToString();
					model.Materiel7=dt.Rows[n]["Materiel7"].ToString();
					model.Company1=dt.Rows[n]["Company1"].ToString();
					model.LH1=dt.Rows[n]["LH1"].ToString();
					model.Plant1=dt.Rows[n]["Plant1"].ToString();
					model.Company2=dt.Rows[n]["Company2"].ToString();
					model.LH2=dt.Rows[n]["LH2"].ToString();
					model.Plant2=dt.Rows[n]["Plant2"].ToString();
					model.SumAmount=dt.Rows[n]["SumAmount"].ToString();
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

