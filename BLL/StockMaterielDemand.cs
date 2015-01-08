using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类StockMaterielDemand 的摘要说明。
	/// </summary>
	public class StockMaterielDemand
	{
		private readonly Hownet.DAL.StockMaterielDemand dal=new Hownet.DAL.StockMaterielDemand();
		public StockMaterielDemand()
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
		public int  Add(Hownet.Model.StockMaterielDemand model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.StockMaterielDemand> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.StockMaterielDemand model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.StockMaterielDemand> li=DataTableToList(dt);
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
		public Hownet.Model.StockMaterielDemand GetModel(int ID)
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
		public List<Hownet.Model.StockMaterielDemand> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.StockMaterielDemand> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.StockMaterielDemand> modelList = new List<Hownet.Model.StockMaterielDemand>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                try
                {
                    Hownet.Model.StockMaterielDemand model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new Hownet.Model.StockMaterielDemand();
                        if (dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        else
                        {
                            model.ID = 0;
                        }
                        if (dt.Rows[n]["PlanID"].ToString() != "")
                        {
                            model.PlanID = int.Parse(dt.Rows[n]["PlanID"].ToString());
                        }
                        else
                        {
                            model.PlanID = 0;
                        }
                        if (dt.Rows[n]["MaterielID"].ToString() != "")
                        {
                            model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                        }
                        else
                        {
                            model.MaterielID = 0;
                        }
                        if (dt.Rows[n]["ColorID"].ToString() != "")
                        {
                            model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                        }
                        else
                        {
                            model.ColorID = 0;
                        }
                        if (dt.Rows[n]["ColorOneID"].ToString() != "")
                        {
                            model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                        }
                        else
                        {
                            model.ColorOneID = 0;
                        }
                        if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                        {
                            model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                        }
                        else
                        {
                            model.ColorTwoID = 0;
                        }
                        if (dt.Rows[n]["Amount"].ToString() != "")
                        {
                            model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
                        }
                        else
                        {
                            model.Amount = 0;
                        }
                        if (dt.Rows[n]["NotAllotAmount"].ToString() != "")
                        {
                            model.NotAllotAmount = decimal.Parse(dt.Rows[n]["NotAllotAmount"].ToString());
                        }
                        else
                        {
                            model.NotAllotAmount = 0;
                        }
                        if (dt.Rows[n]["stockAmount"].ToString() != "")
                        {
                            model.stockAmount = decimal.Parse(dt.Rows[n]["stockAmount"].ToString());
                        }
                        else
                        {
                            model.stockAmount = 0;
                        }
                        if (dt.Rows[n]["stockNotAmount"].ToString() != "")
                        {
                            model.stockNotAmount = decimal.Parse(dt.Rows[n]["stockNotAmount"].ToString());
                        }
                        else
                        {
                            model.stockNotAmount = 0;
                        }
                        if (dt.Rows[n]["SizeID"].ToString() != "")
                        {
                            model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                        }
                        else
                        {
                            model.SizeID = 0;
                        }
                        if (dt.Rows[n]["MeasureID"].ToString() != "")
                        {
                            model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                        }
                        else
                        {
                            model.MeasureID = 0;
                        }
                        if (dt.Rows[n]["DepID"].ToString() != "")
                        {
                            model.DepID = int.Parse(dt.Rows[n]["DepID"].ToString());
                        }
                        else
                        {
                            model.DepID = 0;
                        }
                        if (dt.Rows[n]["MListID"].ToString() != "")
                        {
                            model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                        }
                        else
                        {
                            model.MListID = 0;
                        }
                        if (dt.Rows[n]["MainID"].ToString() != "")
                        {
                            model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                        }
                        else
                        {
                            model.MainID = 0;
                        }
                        if (dt.Rows[n]["IsEnd"].ToString() != "")
                        {
                            model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                        }
                        else
                        {
                            model.IsEnd = 0;
                        }
                        if (dt.Rows[n]["RepertoryAmount"].ToString() != "")
                        {
                            model.RepertoryAmount = decimal.Parse(dt.Rows[n]["RepertoryAmount"].ToString());
                        }
                        else
                        {
                            model.RepertoryAmount = 0;
                        }
                        if (dt.Rows[n]["NeedAmount"].ToString() != "")
                        {
                            model.NeedAmount = decimal.Parse(dt.Rows[n]["NeedAmount"].ToString());
                        }
                        else
                        {
                            model.NeedAmount = 0;
                        }
                        if (dt.Rows[n]["HasStockAmount"].ToString() != "")
                        {
                            model.HasStockAmount = decimal.Parse(dt.Rows[n]["HasStockAmount"].ToString());
                        }
                        else
                        {
                            model.HasStockAmount = 0;
                        }
                        if (dt.Rows[n]["OutAmount"].ToString() != "")
                        {
                            model.OutAmount = decimal.Parse(dt.Rows[n]["OutAmount"].ToString());
                        }
                        else
                        {
                            model.OutAmount = 0;
                        }
                        model.A = int.Parse(dt.Rows[n]["A"].ToString());
                        modelList.Add(model);
                    }
                }
                catch (Exception ex)
                { }
            
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

