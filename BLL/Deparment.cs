using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类Deparment 的摘要说明。
	/// </summary>
	public class Deparment
	{
		private readonly Hownet.DAL.Deparment dal=new Hownet.DAL.Deparment();
		public Deparment()
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
		public int  Add(Hownet.Model.Deparment model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Deparment> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Deparment model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.Deparment> li=DataTableToList(dt);
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
		public Hownet.Model.Deparment GetModel(int ID)
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
		public List<Hownet.Model.Deparment> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.Deparment> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.Deparment> modelList = new List<Hownet.Model.Deparment>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.Deparment model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Deparment();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    model.Name = dt.Rows[n]["Name"].ToString();
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    model.Sn = dt.Rows[n]["Sn"].ToString();
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                    }
                    else
                    {
                        model.IsEnd = 0;
                    }
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    else
                    {
                        model.TypeID = 0;
                    }
                    if (dt.Rows[n]["ParentID"].ToString() != "")
                    {
                        model.ParentID = int.Parse(dt.Rows[n]["ParentID"].ToString());
                    }
                    else
                    {
                        model.ParentID = 0;
                    }
                    if (dt.Rows[n]["CountEmployee"].ToString() != "")
                    {
                        model.CountEmployee = int.Parse(dt.Rows[n]["CountEmployee"].ToString());
                    }
                    model.A = int.Parse(dt.Rows[n]["A"].ToString());
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
        /// 按部门类型查找部门列表
        /// </summary>
        /// <param name="DepartmentTypeName">部门类型</param>
        /// <returns></returns>
        public DataSet GetTypeList(string DepartmentTypeName)
        {
            return dal.GetTypeList(DepartmentTypeName);
        }
        /// <summary>
        /// 按部门类型查找部门列表
        /// </summary>
        /// <param name="DepartmentTypeName">部门类型</param>
        /// <returns></returns>
        public DataSet GetTypeLists(string DepartmentTypeName)
        {
            return dal.GetTypeLists(DepartmentTypeName);
        }
        /// <summary>
        /// 获取某一类型部门的下属部门，主指食堂的桌号及宿舍房间号
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public DataSet GetInfoListByTypeName(string TypeName)
        {
            return dal.GetInfoListByTypeName(TypeName);
        }
         /// <summary>
        /// 某餐桌或宿舍已分配的人数
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="EmpID"></param>
        /// <returns></returns>
        public DataSet GetIsUse(int ID)
        {
            return dal.GetIsUse(ID);
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

