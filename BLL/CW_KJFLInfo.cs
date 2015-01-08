using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// CW_KJFLInfo
	/// </summary>
	public partial class CW_KJFLInfo
	{
		private readonly Hownet.DAL.CW_KJFLInfo dal=new Hownet.DAL.CW_KJFLInfo();
		public CW_KJFLInfo()
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
		public int  Add(Hownet.Model.CW_KJFLInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.CW_KJFLInfo> li = DataTableToList(dt);
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
		public bool Update(Hownet.Model.CW_KJFLInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.CW_KJFLInfo> li = DataTableToList(dt);
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
		public Hownet.Model.CW_KJFLInfo GetModel(int ID)
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
		public List<Hownet.Model.CW_KJFLInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.CW_KJFLInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.CW_KJFLInfo> modelList = new List<Hownet.Model.CW_KJFLInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.CW_KJFLInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.CW_KJFLInfo();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"]!=null && dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					model.项目名称=dt.Rows[n]["项目名称"].ToString();
					if(dt.Rows[n]["项目名称ID"]!=null && dt.Rows[n]["项目名称ID"].ToString()!="")
					{
						model.项目名称ID=int.Parse(dt.Rows[n]["项目名称ID"].ToString());
					}
					model.款号=dt.Rows[n]["款号"].ToString();
					if(dt.Rows[n]["款号ID"]!=null && dt.Rows[n]["款号ID"].ToString()!="")
					{
						model.款号ID=int.Parse(dt.Rows[n]["款号ID"].ToString());
					}
					model.客户订单编号=dt.Rows[n]["客户订单编号"].ToString();
					if(dt.Rows[n]["客户订单ID"]!=null && dt.Rows[n]["客户订单ID"].ToString()!="")
					{
						model.客户订单ID=int.Parse(dt.Rows[n]["客户订单ID"].ToString());
					}
					model.客户=dt.Rows[n]["客户"].ToString();
					if(dt.Rows[n]["客户ID"]!=null && dt.Rows[n]["客户ID"].ToString()!="")
					{
						model.客户ID=int.Parse(dt.Rows[n]["客户ID"].ToString());
					}
					model.费用类别=dt.Rows[n]["费用类别"].ToString();
					if(dt.Rows[n]["费用类别ID"]!=null && dt.Rows[n]["费用类别ID"].ToString()!="")
					{
						model.费用类别ID=int.Parse(dt.Rows[n]["费用类别ID"].ToString());
					}
					if(dt.Rows[n]["金额"]!=null && dt.Rows[n]["金额"].ToString()!="")
					{
						model.金额=decimal.Parse(dt.Rows[n]["金额"].ToString());
					}
					if(dt.Rows[n]["手续费"]!=null && dt.Rows[n]["手续费"].ToString()!="")
					{
						model.手续费=decimal.Parse(dt.Rows[n]["手续费"].ToString());
					}
					model.备注=dt.Rows[n]["备注"].ToString();
					model.报销人=dt.Rows[n]["报销人"].ToString();
					if(dt.Rows[n]["报销人ID"]!=null && dt.Rows[n]["报销人ID"].ToString()!="")
					{
						model.报销人ID=int.Parse(dt.Rows[n]["报销人ID"].ToString());
					}
                    model.二级科目 = dt.Rows[n]["二级科目"].ToString();
                    if (dt.Rows[n]["二级科目ID"] != null && dt.Rows[n]["二级科目ID"].ToString() != "")
                    {
                        model.二级科目ID = int.Parse(dt.Rows[n]["二级科目ID"].ToString());
                    }
                    model.报销部门 = dt.Rows[n]["报销部门"].ToString();
                    if (dt.Rows[n]["报销部门ID"] != null && dt.Rows[n]["报销部门ID"].ToString() != "")
                    {
                        model.报销部门ID = int.Parse(dt.Rows[n]["报销部门ID"].ToString());
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
        public void DeleteByMainID(int MainID)
        {
            dal.DeleteByMainID(MainID);
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

