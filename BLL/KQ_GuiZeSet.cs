using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// KQ_GuiZeSet
	/// </summary>
	public partial class KQ_GuiZeSet
	{
		private readonly Hownet.DAL.KQ_GuiZeSet dal=new Hownet.DAL.KQ_GuiZeSet();
		public KQ_GuiZeSet()
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
		public int  Add(Hownet.Model.KQ_GuiZeSet model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_GuiZeSet> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.KQ_GuiZeSet model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.KQ_GuiZeSet> li = DataTableToList(dt);
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
		public Hownet.Model.KQ_GuiZeSet GetModel(int ID)
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
		public List<Hownet.Model.KQ_GuiZeSet> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.KQ_GuiZeSet> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.KQ_GuiZeSet> modelList = new List<Hownet.Model.KQ_GuiZeSet>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.KQ_GuiZeSet model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.KQ_GuiZeSet();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.OneTime=dt.Rows[n]["OneTime"].ToString();
					model.OneTimeUp=dt.Rows[n]["OneTimeUp"].ToString();
					model.OneTimeLast=dt.Rows[n]["OneTimeLast"].ToString();
					model.TwoTime=dt.Rows[n]["TwoTime"].ToString();
					model.TwoTimeUp=dt.Rows[n]["TwoTimeUp"].ToString();
					model.TwoTimeLast=dt.Rows[n]["TwoTimeLast"].ToString();
					model.ThreeTime=dt.Rows[n]["ThreeTime"].ToString();
					model.ThreeTimeUp=dt.Rows[n]["ThreeTimeUp"].ToString();
					model.ThreeTimeLast=dt.Rows[n]["ThreeTimeLast"].ToString();
					model.FourTime=dt.Rows[n]["FourTime"].ToString();
					model.FourTimeUp=dt.Rows[n]["FourTimeUp"].ToString();
					model.FourTimeLast=dt.Rows[n]["FourTimeLast"].ToString();
					model.FiveTime=dt.Rows[n]["FiveTime"].ToString();
					model.FiveTimeUp=dt.Rows[n]["FiveTimeUp"].ToString();
					model.FiveTimeLast=dt.Rows[n]["FiveTimeLast"].ToString();
					model.SixTime=dt.Rows[n]["SixTime"].ToString();
					model.SixTimeUp=dt.Rows[n]["SixTimeUp"].ToString();
					model.SixTimeLast=dt.Rows[n]["SixTimeLast"].ToString();
					model.SixLast=dt.Rows[n]["SixLast"].ToString();
					if(dt.Rows[n]["SixCD"]!=null && dt.Rows[n]["SixCD"].ToString()!="")
					{
						if((dt.Rows[n]["SixCD"].ToString()=="1")||(dt.Rows[n]["SixCD"].ToString().ToLower()=="true"))
						{
						model.SixCD=true;
						}
						else
						{
							model.SixCD=false;
						}
					}
					if(dt.Rows[n]["SixZT"]!=null && dt.Rows[n]["SixZT"].ToString()!="")
					{
						if((dt.Rows[n]["SixZT"].ToString()=="1")||(dt.Rows[n]["SixZT"].ToString().ToLower()=="true"))
						{
						model.SixZT=true;
						}
						else
						{
							model.SixZT=false;
						}
					}
					if(dt.Rows[n]["SixKG"]!=null && dt.Rows[n]["SixKG"].ToString()!="")
					{
						if((dt.Rows[n]["SixKG"].ToString()=="1")||(dt.Rows[n]["SixKG"].ToString().ToLower()=="true"))
						{
						model.SixKG=true;
						}
						else
						{
							model.SixKG=false;
						}
					}
					if(dt.Rows[n]["NoQD"]!=null && dt.Rows[n]["NoQD"].ToString()!="")
					{
						model.NoQD=int.Parse(dt.Rows[n]["NoQD"].ToString());
					}
					if(dt.Rows[n]["NoQT"]!=null && dt.Rows[n]["NoQT"].ToString()!="")
					{
						model.NoQT=int.Parse(dt.Rows[n]["NoQT"].ToString());
					}
					if(dt.Rows[n]["OneWor"]!=null && dt.Rows[n]["OneWor"].ToString()!="")
					{
						model.OneWor=int.Parse(dt.Rows[n]["OneWor"].ToString());
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

