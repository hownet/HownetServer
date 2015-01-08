using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类WMSInventoryInfo 的摘要说明。
	/// </summary>
	public class WMSInventoryInfo
	{
		private readonly Hownet.DAL.WMSInventoryInfo dal=new Hownet.DAL.WMSInventoryInfo();
		public WMSInventoryInfo()
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
		public int  Add(Hownet.Model.WMSInventoryInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.WMSInventoryInfo> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.WMSInventoryInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.WMSInventoryInfo> li=DataTableToList(dt);
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
		public Hownet.Model.WMSInventoryInfo GetModel(int ID)
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
		public List<Hownet.Model.WMSInventoryInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.WMSInventoryInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.WMSInventoryInfo> modelList = new List<Hownet.Model.WMSInventoryInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.WMSInventoryInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.WMSInventoryInfo();
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
					if(dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					else
					{
						model.MaterielID=0;
					}
					if(dt.Rows[n]["BrandID"].ToString()!="")
					{
						model.BrandID=int.Parse(dt.Rows[n]["BrandID"].ToString());
					}
					else
					{
						model.BrandID=0;
					}
					if(dt.Rows[n]["ColorID"].ToString()!="")
					{
						model.ColorID=int.Parse(dt.Rows[n]["ColorID"].ToString());
					}
					else
					{
						model.ColorID=0;
					}
					if(dt.Rows[n]["ColorOneID"].ToString()!="")
					{
						model.ColorOneID=int.Parse(dt.Rows[n]["ColorOneID"].ToString());
					}
					else
					{
						model.ColorOneID=0;
					}
					if(dt.Rows[n]["ColorTwoID"].ToString()!="")
					{
						model.ColorTwoID=int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
					}
					else
					{
						model.ColorTwoID=0;
					}
					if(dt.Rows[n]["SizeID"].ToString()!="")
					{
						model.SizeID=int.Parse(dt.Rows[n]["SizeID"].ToString());
					}
					else
					{
						model.SizeID=0;
					}
					if(dt.Rows[n]["MeasureID"].ToString()!="")
					{
						model.MeasureID=int.Parse(dt.Rows[n]["MeasureID"].ToString());
					}
					else
					{
						model.MeasureID=0;
					}
					if(dt.Rows[n]["PreviousNumber"].ToString()!="")
					{
						model.PreviousNumber=decimal.Parse(dt.Rows[n]["PreviousNumber"].ToString());
					}
					else
					{
						model.PreviousNumber=0;
					}
					if(dt.Rows[n]["NowAmount"].ToString()!="")
					{
						model.NowAmount=decimal.Parse(dt.Rows[n]["NowAmount"].ToString());
					}
					else
					{
						model.NowAmount=0;
					}
					if(dt.Rows[n]["ChangeAmount"].ToString()!="")
					{
						model.ChangeAmount=decimal.Parse(dt.Rows[n]["ChangeAmount"].ToString());
					}
					else
					{
						model.ChangeAmount=0;
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					else
					{
						model.CompanyID=0;
					}
					if(dt.Rows[n]["MListID"].ToString()!="")
					{
						model.MListID=int.Parse(dt.Rows[n]["MListID"].ToString());
					}
					else
					{
						model.MListID=0;
					}
                    if (dt.Rows[n]["RepertoryID"].ToString() != "")
                    {
                        model.RepertoryID = int.Parse(dt.Rows[n]["RepertoryID"].ToString());
                    }
                    else
                    {
                        model.RepertoryID = 0;
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
        /// 
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="t">真为审核，假为弃审</param>
        public void Verify(int MainID, bool t)
        {
            Hownet.BLL.ProduceSell bllPS = new ProduceSell();
            Hownet.Model.ProduceSell modPS = bllPS.GetModel(MainID);
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            Hownet.BLL.Repertory bllRe = new Repertory();
            Hownet.Model.Repertory modRe = new Hownet.Model.Repertory();
            List<Hownet.Model.WMSInventoryInfo> li = GetModelList("(MainID=" + MainID + ")");
            if (li.Count > 0)
            {
                for (int i = 0; i < li.Count; i++)
                {
                    if (li[i].RepertoryID > 0)
                    {
                        modRe = bllRe.GetModel(li[i].RepertoryID);
                        modRe.Amount = li[i].NowAmount;
                        bllRe.Update(modRe);
                    }
                    else
                    {
                        modRe = new Hownet.Model.Repertory();
                        modML = new Hownet.Model.MaterielList();
                        modRe.BrandID = modML.BrandID = li[i].BrandID;
                        modRe.ColorID = modML.ColorID = li[i].ColorID;
                        modRe.ColorOneID = modML.ColorOneID = li[i].ColorOneID;
                        modRe.ColorTwoID = modML.ColorTwoID = li[i].ColorTwoID;
                        modRe.CompanyID = li[i].CompanyID;
                        modRe.DepartmentID = modPS.Depot;
                        modRe.MaterielID = modML.MaterielID = li[i].MaterielID;
                        modRe.MeasureID = modML.MeasureID = li[i].MeasureID;
                        modRe.SizeID = modML.SizeID = li[i].SizeID;
                        modRe.MListID = li[i].MListID = bllML.GetID(modML);
                        modRe.Amount = li[i].NowAmount;
                        li[i].RepertoryID = bllRe.Add(modRe);
                        Update(li[i]);
                    }
                }
            }

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

