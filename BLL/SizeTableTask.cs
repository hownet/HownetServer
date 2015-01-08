using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类SizeTableTask 的摘要说明。
	/// </summary>
	public class SizeTableTask
	{
		private readonly Hownet.DAL.SizeTableTask dal=new Hownet.DAL.SizeTableTask();
		public SizeTableTask()
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
		public int  Add(Hownet.Model.SizeTableTask model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SizeTableTask> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.SizeTableTask model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SizeTableTask> li=DataTableToList(dt);
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
		public Hownet.Model.SizeTableTask GetModel(int ID)
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
		public List<Hownet.Model.SizeTableTask> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.SizeTableTask> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.SizeTableTask> modelList = new List<Hownet.Model.SizeTableTask>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.SizeTableTask model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.SizeTableTask();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					else
					{
						model.ID=0;
					}
					if(dt.Rows[n]["SizeID"].ToString()!="")
					{
						model.SizeID=int.Parse(dt.Rows[n]["SizeID"].ToString());
					}
					else
					{
						model.SizeID=0;
					}
					if(dt.Rows[n]["SizePartID"].ToString()!="")
					{
						model.SizePartID=int.Parse(dt.Rows[n]["SizePartID"].ToString());
					}
					else
					{
						model.SizePartID=0;
					}
					if(dt.Rows[n]["TaskID"].ToString()!="")
					{
						model.TaskID=int.Parse(dt.Rows[n]["TaskID"].ToString());
					}
					else
					{
						model.TaskID=0;
					}
					if(dt.Rows[n]["Length"].ToString()!="")
					{
						model.Length=decimal.Parse(dt.Rows[n]["Length"].ToString());
					}
					else
					{
						model.Length=0;
					}
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
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
        public DataSet GetSizePartIDGroup(int TaskID)
        {
            return dal.GetSizePartIDGroup(TaskID);
        }
        public DataSet GetSizePartIDGroupByMaterielID(int MaterielID)
        {
            return dal.GetSizePartIDGroupByMaterielID(MaterielID);
        }
               /// <summary>
        /// 获取尺码
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataTable GetSize(int TaskID)
        {
            return dal.GetSize(TaskID);
        }
        public DataTable GetSizeByMaterielID(int MaterielID)
        {
            return dal.GetSizeByMaterielID(MaterielID);
        }
        public void DelInfo(int TaskID)
        {
            dal.DelInfo(TaskID);
        }
        public void delInfoByMaterielID(int MaterielID)
        {
            dal.DelInfoByMaterielID(MaterielID);
        }
        public DataSet GetReport(int TaskID)
        {
            return dal.GetReport(TaskID);
        }
        public DataSet GetListNoA()
        {
            return dal.GetListNoA();
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

