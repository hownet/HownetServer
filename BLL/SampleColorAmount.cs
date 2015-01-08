/**  版本信息模板在安装目录下，可自行修改。
* SampleColorAmount.cs
*
* 功 能： N/A
* 类 名： SampleColorAmount
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/1 14:41:31   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// SampleColorAmount
	/// </summary>
	public partial class SampleColorAmount
	{
		private readonly Hownet.DAL.SampleColorAmount dal=new Hownet.DAL.SampleColorAmount();
		public SampleColorAmount()
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
		public int  Add(Hownet.Model.SampleColorAmount model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SampleColorAmount> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.SampleColorAmount model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SampleColorAmount> li = DataTableToList(dt);
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
		public Hownet.Model.SampleColorAmount GetModel(int ID)
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
		public List<Hownet.Model.SampleColorAmount> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.SampleColorAmount> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SampleColorAmount> modelList = new List<Hownet.Model.SampleColorAmount>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SampleColorAmount model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SampleColorAmount();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"]!=null && dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["ColorID"]!=null && dt.Rows[n]["ColorID"].ToString()!="")
					{
						model.ColorID=int.Parse(dt.Rows[n]["ColorID"].ToString());
					}
					model.ColorName=dt.Rows[n]["ColorName"].ToString();
					model.PantoneName=dt.Rows[n]["PantoneName"].ToString();
					model.CupName=dt.Rows[n]["CupName"].ToString();
					if(dt.Rows[n]["Size1ID"]!=null && dt.Rows[n]["Size1ID"].ToString()!="")
					{
						model.Size1ID=int.Parse(dt.Rows[n]["Size1ID"].ToString());
					}
					model.Size1Name=dt.Rows[n]["Size1Name"].ToString();
					if(dt.Rows[n]["Size1Amount"]!=null && dt.Rows[n]["Size1Amount"].ToString()!="")
					{
						model.Size1Amount=int.Parse(dt.Rows[n]["Size1Amount"].ToString());
					}
					if(dt.Rows[n]["Size2ID"]!=null && dt.Rows[n]["Size2ID"].ToString()!="")
					{
						model.Size2ID=int.Parse(dt.Rows[n]["Size2ID"].ToString());
					}
					model.Size2Name=dt.Rows[n]["Size2Name"].ToString();
					if(dt.Rows[n]["Size2Amount"]!=null && dt.Rows[n]["Size2Amount"].ToString()!="")
					{
						model.Size2Amount=int.Parse(dt.Rows[n]["Size2Amount"].ToString());
					}
					if(dt.Rows[n]["Size3ID"]!=null && dt.Rows[n]["Size3ID"].ToString()!="")
					{
						model.Size3ID=int.Parse(dt.Rows[n]["Size3ID"].ToString());
					}
					model.Size3Name=dt.Rows[n]["Size3Name"].ToString();
					if(dt.Rows[n]["Size3Amount"]!=null && dt.Rows[n]["Size3Amount"].ToString()!="")
					{
						model.Size3Amount=int.Parse(dt.Rows[n]["Size3Amount"].ToString());
					}
					if(dt.Rows[n]["Size4ID"]!=null && dt.Rows[n]["Size4ID"].ToString()!="")
					{
						model.Size4ID=int.Parse(dt.Rows[n]["Size4ID"].ToString());
					}
					model.Size4Name=dt.Rows[n]["Size4Name"].ToString();
					if(dt.Rows[n]["Size4Amount"]!=null && dt.Rows[n]["Size4Amount"].ToString()!="")
					{
						model.Size4Amount=int.Parse(dt.Rows[n]["Size4Amount"].ToString());
					}
					if(dt.Rows[n]["Size5ID"]!=null && dt.Rows[n]["Size5ID"].ToString()!="")
					{
						model.Size5ID=int.Parse(dt.Rows[n]["Size5ID"].ToString());
					}
					model.Size5Name=dt.Rows[n]["Size5Name"].ToString();
					if(dt.Rows[n]["Size5Amount"]!=null && dt.Rows[n]["Size5Amount"].ToString()!="")
					{
						model.Size5Amount=int.Parse(dt.Rows[n]["Size5Amount"].ToString());
					}
					if(dt.Rows[n]["Size6ID"]!=null && dt.Rows[n]["Size6ID"].ToString()!="")
					{
						model.Size6ID=int.Parse(dt.Rows[n]["Size6ID"].ToString());
					}
					model.Size6Name=dt.Rows[n]["Size6Name"].ToString();
					if(dt.Rows[n]["Size6Amount"]!=null && dt.Rows[n]["Size6Amount"].ToString()!="")
					{
						model.Size6Amount=int.Parse(dt.Rows[n]["Size6Amount"].ToString());
					}
					if(dt.Rows[n]["Size7ID"]!=null && dt.Rows[n]["Size7ID"].ToString()!="")
					{
						model.Size7ID=int.Parse(dt.Rows[n]["Size7ID"].ToString());
					}
					model.Size7Name=dt.Rows[n]["Size7Name"].ToString();
					if(dt.Rows[n]["Size7Amount"]!=null && dt.Rows[n]["Size7Amount"].ToString()!="")
					{
						model.Size7Amount=int.Parse(dt.Rows[n]["Size7Amount"].ToString());
					}
					if(dt.Rows[n]["Size8ID"]!=null && dt.Rows[n]["Size8ID"].ToString()!="")
					{
						model.Size8ID=int.Parse(dt.Rows[n]["Size8ID"].ToString());
					}
					model.Size8Name=dt.Rows[n]["Size8Name"].ToString();
					if(dt.Rows[n]["Size8Amount"]!=null && dt.Rows[n]["Size8Amount"].ToString()!="")
					{
						model.Size8Amount=int.Parse(dt.Rows[n]["Size8Amount"].ToString());
					}
                    if (dt.Rows[n]["Amount"] != null && dt.Rows[n]["Amount"].ToString() != "")
                    {
                        model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
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
        public bool DeleteByMainID(int MainID)
        {
            return dal.DeleteByMainID(MainID);
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

