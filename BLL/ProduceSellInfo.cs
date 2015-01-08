using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类ProduceSellInfo 的摘要说明。
	/// </summary>
	public class ProduceSellInfo
	{
		private readonly Hownet.DAL.ProduceSellInfo dal=new Hownet.DAL.ProduceSellInfo();
		public ProduceSellInfo()
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
		public int  Add(Hownet.Model.ProduceSellInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ProduceSellInfo> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.ProduceSellInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ProduceSellInfo> li=DataTableToList(dt);
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
		public Hownet.Model.ProduceSellInfo GetModel(int ID)
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
		public List<Hownet.Model.ProduceSellInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.ProduceSellInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.ProduceSellInfo> modelList = new List<Hownet.Model.ProduceSellInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.ProduceSellInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.ProduceSellInfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					if(dt.Rows[n]["ColorID"].ToString()!="")
					{
						model.ColorID=int.Parse(dt.Rows[n]["ColorID"].ToString());
					}
					if(dt.Rows[n]["ColorOneID"].ToString()!="")
					{
						model.ColorOneID=int.Parse(dt.Rows[n]["ColorOneID"].ToString());
					}
					if(dt.Rows[n]["ColorTwoID"].ToString()!="")
					{
						model.ColorTwoID=int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
					}
					if(dt.Rows[n]["SizeID"].ToString()!="")
					{
						model.SizeID=int.Parse(dt.Rows[n]["SizeID"].ToString());
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
                        model.Amount = decimal.Parse(dt.Rows[n]["Amount"].ToString());
					}
					if(dt.Rows[n]["BrandID"].ToString()!="")
					{
						model.BrandID=int.Parse(dt.Rows[n]["BrandID"].ToString());
					}
					if(dt.Rows[n]["MListID"].ToString()!="")
					{
						model.MListID=int.Parse(dt.Rows[n]["MListID"].ToString());
					}
                    if (dt.Rows[n]["SalesInfoID"].ToString() != "")
                    {
                        model.SalesInfoID = int.Parse(dt.Rows[n]["SalesInfoID"].ToString());
                    }
                    else
                    {
                        model.SalesInfoID = 0;
                    }
                    if (dt.Rows[n]["MeasureID"].ToString() != "")
                    {
                        model.MeasureID = int.Parse(dt.Rows[n]["MeasureID"].ToString());
                    }
                    else
                    {
                        model.MeasureID = 0;
                    }
                    if (dt.Rows[n]["SelesID"].ToString() != "")
                    {
                        model.SelesID = int.Parse(dt.Rows[n]["SelesID"].ToString());
                    }
                    else
                    {
                        model.SelesID = 0;
                    }
                    if (dt.Rows[n]["RepertoryListID"] != null && dt.Rows[n]["RepertoryListID"].ToString() != "")
                    {
                        model.RepertoryListID = int.Parse(dt.Rows[n]["RepertoryListID"].ToString());
                    }
                    if (dt.Rows[n]["RepertoryID"] != null && dt.Rows[n]["RepertoryID"].ToString() != "")
                    {
                        model.RepertoryID = int.Parse(dt.Rows[n]["RepertoryID"].ToString());
                    }
                    if (dt.Rows[n]["PSOID"] != null && dt.Rows[n]["PSOID"].ToString() != "")
                    {
                        model.PSOID = int.Parse(dt.Rows[n]["PSOID"].ToString());
                    }
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
        /// 删除一条数据
        /// </summary>
        public void DeleteInfo(int PSOID)
        {
            dal.DeleteInfo(PSOID);
        }
            /// <summary>
        /// 删除一条数据
        /// </summary>
        public void DeleteByMainID(int MainID)
        {
            dal.DeleteByMainID(MainID);
        }
        public DataSet GetReport(int MainID)
        {
            return dal.GetReport(MainID);
        }
        public int CheckSellAmount(int MainID, int DepotID)
        {
            int a = dal.CheckSellAmount(MainID, DepotID);
            return dal.CheckSellAmount(MainID, DepotID);
        }
        public DataSet GetColorSumAmount(int MainID, int SalesID)
        {
            return dal.GetColorSumAmount(MainID, SalesID);
        }
        public DataSet GetSumAmount(int MainID)
        {
            return dal.GetSumAmount(MainID);
        }
        public DataSet GetListForOne(int Top, int CompanyID, int MaterielID, DateTime dt1, DateTime dt2)
        {
            return dal.GetListForOne(Top, CompanyID, MaterielID, dt1, dt2);
        }
        /// <summary>
        /// 三个颜色的汇总
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetSumColor(int PSOID)
        {
            return dal.GetSumColor(PSOID);
        }
        public DataSet GetSize(int PSOID)
        {
            return dal.GetSize(PSOID);
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

