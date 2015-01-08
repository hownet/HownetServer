using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类OtherType 的摘要说明。
	/// </summary>
	public class OtherType
	{
		private readonly Hownet.DAL.OtherType dal=new Hownet.DAL.OtherType();
		public OtherType()
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
		public bool Exists(int OtherTypeID)
		{
			return dal.Exists(OtherTypeID);
		}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Hownet.Model.OtherType model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.OtherType> li = DataTableToList(dt);
            if (li.Count > 0)
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
        public void Update(Hownet.Model.OtherType model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.OtherType> li = DataTableToList(dt);
            if (li.Count > 0)
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
        public Hownet.Model.OtherType GetModel(int ID)
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
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.OtherType> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.OtherType> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.OtherType> modelList = new List<Hownet.Model.OtherType>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.OtherType model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.OtherType();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.Name = dt.Rows[n]["Name"].ToString();
                    if (dt.Rows[n]["TypeID"].ToString() != "")
                    {
                        model.TypeID = int.Parse(dt.Rows[n]["TypeID"].ToString());
                    }
                    model.Value = dt.Rows[n]["Value"].ToString();
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
        /// 返回特定类型下的子类型
        /// </summary>
        /// <param name="TypeName">类型名</param>
        /// <returns></returns>
        public DataSet GetTypeList(string TypeName)
        {
            return dal.GetTypeList(TypeName);
        }
        /// <summary>
        /// 为列表添加 新增 选项
        /// </summary>
        /// <param name="dt"></param>
        public DataTable AddEditAndAdd(DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr["ID"] = -1;
            dr["Name"] = "新增";
            dr["TypeID"] = 0;
            dt.Rows.Add(dr);
            return dt;
        }
        /// <summary>
        /// 返回一类型的ID，不存在则返回0
        /// </summary>
        /// <param name="TypeName"></param>
        /// <returns></returns>
        public int GetID(string TypeName)
        {
            return dal.GetID(TypeName);
        }
        public DataSet GetWorkTime()
        {
            return dal.GetWorkTime();
        }
        /// <summary>
        /// 获取某一类值为数字的列
        /// </summary>
        /// <param name="TypeName"></param>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNumValue()
        {
            return dal.GetNumValue();
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  成员方法
    }
}

