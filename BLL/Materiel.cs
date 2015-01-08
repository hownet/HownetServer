using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类Materiel 的摘要说明。
	/// </summary>
	public class Materiel
	{
		private readonly Hownet.DAL.Materiel dal=new Hownet.DAL.Materiel();
		public Materiel()
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
		public int  Add(Hownet.Model.Materiel model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Materiel> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Materiel model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
            List<Hownet.Model.Materiel> li = DataTableToList(dt);
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
		public Hownet.Model.Materiel GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
            if (GetHDID.LinesCount == -1)
            {
                GetHDID.CheckReg();
            }
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
		public List<Hownet.Model.Materiel> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.Materiel> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Materiel> modelList = new List<Hownet.Model.Materiel>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Materiel model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.Materiel();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					if(dt.Rows[n]["TypeID"].ToString()!="")
					{
						model.TypeID=int.Parse(dt.Rows[n]["TypeID"].ToString());
					}
					if(dt.Rows[n]["MeasureID"].ToString()!="")
					{
						model.MeasureID=int.Parse(dt.Rows[n]["MeasureID"].ToString());
					}
					model.Sn=dt.Rows[n]["Sn"].ToString();
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["AttributeID"].ToString()!="")
					{
						model.AttributeID=int.Parse(dt.Rows[n]["AttributeID"].ToString());
					}
					if(dt.Rows[n]["SecondMeasureID"].ToString()!="")
					{
						model.SecondMeasureID=int.Parse(dt.Rows[n]["SecondMeasureID"].ToString());
					}
					if(dt.Rows[n]["Conversion"].ToString()!="")
					{
						model.Conversion=decimal.Parse(dt.Rows[n]["Conversion"].ToString());
					}
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						model.IsEnd=int.Parse(dt.Rows[n]["IsEnd"].ToString());
					}
					if(dt.Rows[n]["IsUse"].ToString()!="")
					{
						if((dt.Rows[n]["IsUse"].ToString()=="1")||(dt.Rows[n]["IsUse"].ToString().ToLower()=="true"))
						{
						model.IsUse=true;
						}
						else
						{
							model.IsUse=false;
						}
					}
                    if (dt.Rows[n]["Designers"].ToString() != "")
                    {
                        model.Designers = int.Parse(dt.Rows[n]["Designers"].ToString());
                    }
                    else
                    {
                        model.Designers = 0;
                    }
					model.Image=dt.Rows[n]["Image"].ToString();
                    if (dt.Rows[n]["SelectSpec"].ToString() != "")
                    {
                        model.SelectSpec = int.Parse(dt.Rows[n]["SelectSpec"].ToString());
                    }
                    model.TiaoMaH = dt.Rows[n]["TiaoMaH"].ToString();
                    if (dt.Rows[n]["ChengBengJ"] != null && dt.Rows[n]["ChengBengJ"].ToString() != "")
                    {
                        model.ChengBengJ = decimal.Parse(dt.Rows[n]["ChengBengJ"].ToString());
                    }
                    if (dt.Rows[n]["LingShouJia"] != null && dt.Rows[n]["LingShouJia"].ToString() != "")
                    {
                        model.LingShouJia = decimal.Parse(dt.Rows[n]["LingShouJia"].ToString());
                    }
                    if (dt.Rows[n]["YiJiDaiLiJia"] != null && dt.Rows[n]["YiJiDaiLiJia"].ToString() != "")
                    {
                        model.YiJiDaiLiJia = decimal.Parse(dt.Rows[n]["YiJiDaiLiJia"].ToString());
                    }
                    if (dt.Rows[n]["ErJiDaiLiJia"] != null && dt.Rows[n]["ErJiDaiLiJia"].ToString() != "")
                    {
                        model.ErJiDaiLiJia = decimal.Parse(dt.Rows[n]["ErJiDaiLiJia"].ToString());
                    }
                    if (dt.Rows[n]["SanJiDaiLiJia"] != null && dt.Rows[n]["SanJiDaiLiJia"].ToString() != "")
                    {
                        model.SanJiDaiLiJia = decimal.Parse(dt.Rows[n]["SanJiDaiLiJia"].ToString());
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
        /// 返回BOM窗体左侧树形所需列表
        /// </summary>
        /// <returns></returns>
        /// <param name="AttributeID"></param>
        /// <param name="IsEnd">-1为全部，0为使用中，1为停用</param>
        public DataSet GetLaftTree(int AttributeID, int IsEnd)
        {
            return dal.GetLaftTree(AttributeID, IsEnd);
        }
        public DataSet GetByTypeName(string TypeName)
        {
            return dal.GetByTypeName(TypeName);
        }
        public DataSet GetListAndMeasure()
        {
            return dal.GetListAndMeasure();
        }
        public string GetMTName(int ID)
        {
            return dal.GetMTName(ID);
        }
        /// <summary>
        /// 获取单用量中所有的主料
        /// </summary>
        /// <returns></returns>
        public DataSet GetTogethers()
        {
            return dal.GetTogethers();
        }
        /// <summary>
        /// 用于下拉框显示的列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetLookupList(string strWhere)
        {
            return dal.GetLookupList(strWhere);
        }
        //public DataSet GetTem()
        //{
        //    return dal.GetTem();
        //}
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

