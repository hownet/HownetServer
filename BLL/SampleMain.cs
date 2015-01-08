using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类SampleMain 的摘要说明。
	/// </summary>
	public class SampleMain
	{
		private readonly Hownet.DAL.SampleMain dal=new Hownet.DAL.SampleMain();
		public SampleMain()
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
		public int  Add(Hownet.Model.SampleMain model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMain> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.SampleMain model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.SampleMain> li=DataTableToList(dt);
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
		public Hownet.Model.SampleMain GetModel(int ID)
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
		public List<Hownet.Model.SampleMain> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.SampleMain> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.SampleMain> modelList = new List<Hownet.Model.SampleMain>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.SampleMain model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.SampleMain();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    if (dt.Rows[n]["BrandID"].ToString() != "")
                    {
                        model.BrandID = int.Parse(dt.Rows[n]["BrandID"].ToString());
                    }
                    else
                    {
                        model.BrandID = 0;
                    }
                    model.Season = dt.Rows[n]["Season"].ToString();
                    if (dt.Rows[n]["MTID"].ToString() != "")
                    {
                        model.MTID = int.Parse(dt.Rows[n]["MTID"].ToString());
                    }
                    else
                    {
                        model.MTID = 0;
                    }
                    model.Fabric = dt.Rows[n]["Fabric"].ToString();
                    model.MainCloth1 = dt.Rows[n]["MainCloth1"].ToString();
                    model.MainCloth2 = dt.Rows[n]["MainCloth2"].ToString();
                    model.MinorCloth1 = dt.Rows[n]["MinorCloth1"].ToString();
                    model.MinorCloth2 = dt.Rows[n]["MinorCloth2"].ToString();
                    model.MainCloth1Remark = dt.Rows[n]["MainCloth1Remark"].ToString();
                    model.MainCloth2Remak = dt.Rows[n]["MainCloth2Remak"].ToString();
                    model.MinorCloth1Remark = dt.Rows[n]["MinorCloth1Remark"].ToString();
                    model.MinorCloth2Remark = dt.Rows[n]["MinorCloth2Remark"].ToString();
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    model.POID = dt.Rows[n]["POID"].ToString();
                    model.CompanyMateriel = dt.Rows[n]["CompanyMateriel"].ToString();
                    model.MaterielID = dt.Rows[n]["MaterielID"].ToString();
                    if (dt.Rows[n]["SumAmount"].ToString() != "")
                    {
                        model.SumAmount = int.Parse(dt.Rows[n]["SumAmount"].ToString());
                    }
                    else
                    {
                        model.SumAmount = 0;
                    }
                    if (dt.Rows[n]["BackSampleDate"].ToString() != "")
                    {
                        model.BackSampleDate = DateTime.Parse(dt.Rows[n]["BackSampleDate"].ToString());
                    }
                    else
                    {
                        model.BackSampleDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["AskBackDate"].ToString() != "")
                    {
                        model.AskBackDate = DateTime.Parse(dt.Rows[n]["AskBackDate"].ToString());
                    }
                    else
                    {
                        model.AskBackDate = DateTime.Parse("1900-1-1");
                    }
                    model.BillingMan = dt.Rows[n]["BillingMan"].ToString();
                    if (dt.Rows[n]["Counter"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Counter"].ToString() == "1") || (dt.Rows[n]["Counter"].ToString().ToLower() == "true"))
                        {
                            model.Counter = true;
                        }
                        else
                        {
                            model.Counter = false;
                        }
                    }
                    if (dt.Rows[n]["RevisedCounter"].ToString() != "")
                    {
                        if ((dt.Rows[n]["RevisedCounter"].ToString() == "1") || (dt.Rows[n]["RevisedCounter"].ToString().ToLower() == "true"))
                        {
                            model.RevisedCounter = true;
                        }
                        else
                        {
                            model.RevisedCounter = false;
                        }
                    }
                    if (dt.Rows[n]["Approval"].ToString() != "")
                    {
                        if ((dt.Rows[n]["Approval"].ToString() == "1") || (dt.Rows[n]["Approval"].ToString().ToLower() == "true"))
                        {
                            model.Approval = true;
                        }
                        else
                        {
                            model.Approval = false;
                        }
                    }
                    if (dt.Rows[n]["TextSample"].ToString() != "")
                    {
                        if ((dt.Rows[n]["TextSample"].ToString() == "1") || (dt.Rows[n]["TextSample"].ToString().ToLower() == "true"))
                        {
                            model.TextSample = true;
                        }
                        else
                        {
                            model.TextSample = false;
                        }
                    }
                    if (dt.Rows[n]["ShowSample"].ToString() != "")
                    {
                        if ((dt.Rows[n]["ShowSample"].ToString() == "1") || (dt.Rows[n]["ShowSample"].ToString().ToLower() == "true"))
                        {
                            model.ShowSample = true;
                        }
                        else
                        {
                            model.ShowSample = false;
                        }
                    }
                    if (dt.Rows[n]["PhotoSample"].ToString() != "")
                    {
                        if ((dt.Rows[n]["PhotoSample"].ToString() == "1") || (dt.Rows[n]["PhotoSample"].ToString().ToLower() == "true"))
                        {
                            model.PhotoSample = true;
                        }
                        else
                        {
                            model.PhotoSample = false;
                        }
                    }
                    if (dt.Rows[n]["SizeSet1"].ToString() != "")
                    {
                        if ((dt.Rows[n]["SizeSet1"].ToString() == "1") || (dt.Rows[n]["SizeSet1"].ToString().ToLower() == "true"))
                        {
                            model.SizeSet1 = true;
                        }
                        else
                        {
                            model.SizeSet1 = false;
                        }
                    }
                    if (dt.Rows[n]["SizeSet2"].ToString() != "")
                    {
                        if ((dt.Rows[n]["SizeSet2"].ToString() == "1") || (dt.Rows[n]["SizeSet2"].ToString().ToLower() == "true"))
                        {
                            model.SizeSet2 = true;
                        }
                        else
                        {
                            model.SizeSet2 = false;
                        }
                    }
                    if (dt.Rows[n]["SizeSet3"].ToString() != "")
                    {
                        if ((dt.Rows[n]["SizeSet3"].ToString() == "1") || (dt.Rows[n]["SizeSet3"].ToString().ToLower() == "true"))
                        {
                            model.SizeSet3 = true;
                        }
                        else
                        {
                            model.SizeSet3 = false;
                        }
                    }
                    if (dt.Rows[n]["SalesmanSample"].ToString() != "")
                    {
                        if ((dt.Rows[n]["SalesmanSample"].ToString() == "1") || (dt.Rows[n]["SalesmanSample"].ToString().ToLower() == "true"))
                        {
                            model.SalesmanSample = true;
                        }
                        else
                        {
                            model.SalesmanSample = false;
                        }
                    }
                    if (dt.Rows[n]["ProductionSample"].ToString() != "")
                    {
                        if ((dt.Rows[n]["ProductionSample"].ToString() == "1") || (dt.Rows[n]["ProductionSample"].ToString().ToLower() == "true"))
                        {
                            model.ProductionSample = true;
                        }
                        else
                        {
                            model.ProductionSample = false;
                        }
                    }
                    if (dt.Rows[n]["ShipmentSample"].ToString() != "")
                    {
                        if ((dt.Rows[n]["ShipmentSample"].ToString() == "1") || (dt.Rows[n]["ShipmentSample"].ToString().ToLower() == "true"))
                        {
                            model.ShipmentSample = true;
                        }
                        else
                        {
                            model.ShipmentSample = false;
                        }
                    }
                    if (dt.Rows[n]["UpData"].ToString() != "")
                    {
                        model.UpData = int.Parse(dt.Rows[n]["UpData"].ToString());
                    }
                    else
                    {
                        model.UpData = 0;
                    }
                    if (dt.Rows[n]["FillMan"].ToString() != "")
                    {
                        model.FillMan = int.Parse(dt.Rows[n]["FillMan"].ToString());
                    }
                    else
                    {
                        model.FillMan = 0;
                    }
                    if (dt.Rows[n]["IsVerify"].ToString() != "")
                    {
                        model.IsVerify = int.Parse(dt.Rows[n]["IsVerify"].ToString());
                    }
                    else
                    {
                        model.IsVerify = 0;
                    }
                    if (dt.Rows[n]["VerifyMan"].ToString() != "")
                    {
                        model.VerifyMan = int.Parse(dt.Rows[n]["VerifyMan"].ToString());
                    }
                    else
                    {
                        model.VerifyMan = 0;
                    }
                    if (dt.Rows[n]["VerifyDate"].ToString() != "")
                    {
                        model.VerifyDate = DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
                    }
                    else
                    {
                        model.VerifyDate = DateTime.Parse("1900-1-1");
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["Stata"].ToString() != "")
                    {
                        model.Stata = int.Parse(dt.Rows[n]["Stata"].ToString());
                    }
                    else
                    {
                        model.Stata = 0;
                    }
                    if (dt.Rows[n]["OderMainID"].ToString() != "")
                    {
                        model.OderMainID = int.Parse(dt.Rows[n]["OderMainID"].ToString());
                    }
                    else
                    {
                        model.OderMainID = 0;
                    }
                    if (dt.Rows[n]["LastEdit"].ToString() != "")
                    {
                        model.LastEdit = int.Parse(dt.Rows[n]["LastEdit"].ToString());
                    }
                    else
                    {
                        model.LastEdit = 0;
                    }
                    if (dt.Rows[n]["LastEditDate"].ToString() != "")
                    {
                        model.LastEditDate = DateTime.Parse(dt.Rows[n]["LastEditDate"].ToString());
                    }
                    else
                    {
                        model.LastEditDate = DateTime.Parse("1900-1-1");
                    }
                    model.EditRemark = dt.Rows[n]["EditRemark"].ToString();
                    model.GenDan = dt.Rows[n]["GenDan"].ToString();
                    model.BanFangGengDan = dt.Rows[n]["BanFangGengDan"].ToString();
                    model.ZhiYang = dt.Rows[n]["ZhiYang"].ToString();
                    model.CheBan = dt.Rows[n]["CheBan"].ToString();
                    model.BanFangZhuGuang = dt.Rows[n]["BanFangZhuGuang"].ToString();
                    model.ShengChanBu = dt.Rows[n]["ShengChanBu"].ToString();
                    model.Size1 = dt.Rows[n]["Size1"].ToString();
                    model.Size2 = dt.Rows[n]["Size2"].ToString();
                    model.BackAmount = dt.Rows[n]["BackAmount"].ToString();
                    model.HaveOld = dt.Rows[n]["HaveOld"].ToString();
                    model.SizeRefer = dt.Rows[n]["SizeRefer"].ToString();
                    model.TaskRemark = dt.Rows[n]["TaskRemark"].ToString();
                    model.BrandRemark = dt.Rows[n]["BrandRemark"].ToString();
                    model.Images = dt.Rows[n]["Images"].ToString();
                    model.BrandImages = dt.Rows[n]["BrandImages"].ToString();
                    if (dt.Rows[n]["DefaultSTID"].ToString() != "")
                        model.DefaultSTID = Convert.ToInt32(dt.Rows[n]["DefaultSTID"]);
                    else
                        model.DefaultSTID = 0;
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
        public int GetUpData(int ID)
        {
            return dal.GetUpData(ID);
        }
        public void SetDefaultSTID(int STID, int ID)
        {
            dal.SetDefaultSTID(STID, ID);
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

