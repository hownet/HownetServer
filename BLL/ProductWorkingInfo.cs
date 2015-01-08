using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类ProductWorkingInfo 的摘要说明。
	/// </summary>
	public class ProductWorkingInfo
	{
		private readonly Hownet.DAL.ProductWorkingInfo dal=new Hownet.DAL.ProductWorkingInfo();
		public ProductWorkingInfo()
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
		public int  Add(Hownet.Model.ProductWorkingInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ProductWorkingInfo> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.ProductWorkingInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ProductWorkingInfo> li=DataTableToList(dt);
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
		public Hownet.Model.ProductWorkingInfo GetModel(int ID)
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
		public List<Hownet.Model.ProductWorkingInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.ProductWorkingInfo> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.ProductWorkingInfo> modelList = new List<Hownet.Model.ProductWorkingInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.ProductWorkingInfo model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.ProductWorkingInfo();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["WorkingID"].ToString() != "")
                    {
                        model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
                    }
                    else
                    {
                        model.WorkingID = 0;
                    }
                    if (dt.Rows[n]["GroupBy"].ToString() != "")
                    {
                        model.GroupBy = int.Parse(dt.Rows[n]["GroupBy"].ToString());
                    }
                    else
                    {
                        model.GroupBy = 0;
                    }
                    if (dt.Rows[n]["Machine"].ToString() != "")
                    {
                        model.Machine = int.Parse(dt.Rows[n]["Machine"].ToString());
                    }
                    else
                    {
                        model.Machine = 0;
                    }
                    if (dt.Rows[n]["MachinePart"].ToString() != "")
                    {
                        model.MachinePart = int.Parse(dt.Rows[n]["MachinePart"].ToString());
                    }
                    else
                    {
                        model.MachinePart = 0;
                    }
                    if (dt.Rows[n]["LineOne"].ToString() != "")
                    {
                        model.LineOne = int.Parse(dt.Rows[n]["LineOne"].ToString());
                    }
                    else
                    {
                        model.LineOne = 0;
                    }
                    if (dt.Rows[n]["LineTwo"].ToString() != "")
                    {
                        model.LineTwo = int.Parse(dt.Rows[n]["LineTwo"].ToString());
                    }
                    else
                    {
                        model.LineTwo = 0;
                    }
                    if (dt.Rows[n]["Pin"].ToString() != "")
                    {
                        model.Pin = int.Parse(dt.Rows[n]["Pin"].ToString());
                    }
                    else
                    {
                        model.Pin = 0;
                    }
                    if (dt.Rows[n]["Stitch"].ToString() != "")
                    {
                        model.Stitch = int.Parse(dt.Rows[n]["Stitch"].ToString());
                    }
                    else
                    {
                        model.Stitch = 0;
                    }
                    if (dt.Rows[n]["Width"].ToString() != "")
                    {
                        model.Width = int.Parse(dt.Rows[n]["Width"].ToString());
                    }
                    else
                    {
                        model.Width = 0;
                    }
                    if (dt.Rows[n]["StitchWidth"].ToString() != "")
                    {
                        model.StitchWidth = int.Parse(dt.Rows[n]["StitchWidth"].ToString());
                    }
                    else
                    {
                        model.StitchWidth = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["MakingsOne"].ToString() != "")
                    {
                        model.MakingsOne = int.Parse(dt.Rows[n]["MakingsOne"].ToString());
                    }
                    else
                    {
                        model.MakingsOne = 0;
                    }
                    if (dt.Rows[n]["MakingsTwo"].ToString() != "")
                    {
                        model.MakingsTwo = int.Parse(dt.Rows[n]["MakingsTwo"].ToString());
                    }
                    else
                    {
                        model.MakingsTwo = 0;
                    }
                    if (dt.Rows[n]["MainID"].ToString() != "")
                    {
                        model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                    }
                    else
                    {
                        model.MainID = 0;
                    }
                    if (dt.Rows[n]["IsTicket"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsTicket"].ToString() == "1") || (dt.Rows[n]["IsTicket"].ToString().ToLower() == "true"))
                        {
                            model.IsTicket = true;
                        }
                        else
                        {
                            model.IsTicket = false;
                        }
                    }
                    if (dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
                    }
                    else
                    {
                        model.Price = 0;
                    }
                    if (dt.Rows[n]["UseTime"].ToString() != "")
                    {
                        model.UseTime = decimal.Parse(dt.Rows[n]["UseTime"].ToString());
                    }
                    else
                    {
                        model.UseTime = 0;
                    }
                    if (dt.Rows[n]["FastTime"].ToString() != "")
                    {
                        model.FastTime = decimal.Parse(dt.Rows[n]["FastTime"].ToString());
                    }
                    else
                    {
                        model.FastTime = 0;
                    }
                    if (dt.Rows[n]["Orders"].ToString() != "")
                    {
                        model.Orders = int.Parse(dt.Rows[n]["Orders"].ToString());
                    }
                    else
                    {
                        model.Orders = 0;
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    else
                    {
                        model.MaterielID = 0;
                    }
                    if (dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    else
                    {
                        model.ColorID = 0;
                    }
                    if (dt.Rows[n]["SpecialWork"].ToString() != "")
                    {
                        model.SpecialWork = int.Parse(dt.Rows[n]["SpecialWork"].ToString());
                    }
                    else
                    {
                        model.SpecialWork = 0;
                    }
                    if (dt.Rows[n]["PWMID"].ToString() != "")
                    {
                        model.PWMID = int.Parse(dt.Rows[n]["PWMID"].ToString());
                    }
                    else
                    {
                        model.PWMID = 0;
                    }
                    if (dt.Rows[n]["PWIID"].ToString() != "")
                    {
                        model.PWIID = int.Parse(dt.Rows[n]["PWIID"].ToString());
                    }
                    else
                    {
                        model.PWIID = 0;
                    }
                    model.CustOder = dt.Rows[n]["CustOder"].ToString();
                    if (dt.Rows[n]["IsCaiC"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCaiC"].ToString() == "1") || (dt.Rows[n]["IsCaiC"].ToString().ToLower() == "true"))
                        {
                            model.IsCaiC = true;
                        }
                        else
                        {
                            model.IsCaiC = false;
                        }
                    }
                    if (dt.Rows[n]["IsCut"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCut"].ToString() == "1") || (dt.Rows[n]["IsCut"].ToString().ToLower() == "true"))
                        {
                            model.IsCut = true;
                        }
                        else
                        {
                            model.IsCut = false;
                        }
                    }
                    if (dt.Rows[n]["CompanyID"].ToString() != "")
                    {
                        model.CompanyID = int.Parse(dt.Rows[n]["CompanyID"].ToString());
                    }
                    else
                    {
                        model.CompanyID = 0;
                    }
                    if (dt.Rows[n]["IsSpecial"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsSpecial"].ToString() == "1") || (dt.Rows[n]["IsSpecial"].ToString().ToLower() == "true"))
                        {
                            model.IsSpecial = true;
                        }
                        else
                        {
                            model.IsSpecial = false;
                        }
                    }
                    if (dt.Rows[n]["OneAmount"].ToString() != "")
                    {
                        model.OneAmount = int.Parse(dt.Rows[n]["OneAmount"].ToString());
                    }
                    else
                    {
                        model.OneAmount = 0;
                    }
                    if (dt.Rows[n]["IsCanMove"] != null && dt.Rows[n]["IsCanMove"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCanMove"].ToString() == "1") || (dt.Rows[n]["IsCanMove"].ToString().ToLower() == "true"))
                        {
                            model.IsCanMove = true;
                        }
                        else
                        {
                            model.IsCanMove = false;
                        }
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
        public DataSet GetBoxWork(int MainID)
        {
            return dal.GetBoxWork(MainID);
        }
                /// <summary>
        /// 返回某工艺单下工序ID、顺序入是否为特殊工序
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
        public DataSet GetBoxWorkID(int MainID, int OneAmount)
        {
            return dal.GetBoxWorkID(MainID,OneAmount);
        }
        public DataSet GetSpecialWork(int MainID,int OneAmount)
        {
            return dal.GetSpecialWork(MainID,OneAmount);
        }
       public bool CheckSpecial(int MainID)
       {
           bool t = true;
           DataTable dt = dal.GetList("(MainID=" + MainID  + ") And (IsSpecial=1)").Tables[0];// dal.GetSpecialWork(MainID, -100).Tables[0];
           DataTable dtInfo = dal.GetList("(MainID=" + MainID*-1 + ")").Tables[0];
           if (dt.Rows.Count > 0)
           {
               for (int i = 0; i < dt.Rows.Count; i++)
               {
                   DataRow[] drs = dtInfo.Select("(SpecialWork=" + int.Parse(dt.DefaultView[i]["WorkingID"].ToString()) + ")");
                   if (drs.Length == 0)
                   {
                       t = false;
                       break;
                   }
               }
           }
           return t;
       }
       public bool CheckWorkSpecial(int PWIID)
       {
           if (dal.GetList("(SpecialWork=" + PWIID + ") And (ColorID=0)").Tables[0].Rows.Count > 0)
               return true;
           else
               return false;
       }
       public DataSet GetGroup(int TaskID,int OneAmount)
       {
           return dal.GetGroup(TaskID, OneAmount);
       }
       public DataSet GetGroupTicket(int TaskID, int OneAmount)
       {
           return dal.GetGroupTicket(TaskID, OneAmount);
       }
       public DataSet GetProWorkListByPW(int MainID, int MaterielID)
       {
           return dal.GetProWorkListByPW(MainID, MaterielID);
       }
       public void DeleteByMainID(int MainID)
       {
           dal.DeleteByMainID(MainID);
       }
       public void UpWorkPrice(int ID, decimal Price)
       {
           dal.UpWorkPrice(ID, Price);
       }
       public DataSet GetInfoList(int MainID)
       {
           return dal.GetInfoList(MainID);
       }
       /// <summary>
       /// 某工艺单明细使用情况
       /// </summary>
       /// <param name="PWIID"></param>
       /// <returns></returns>
       public int GetPWIDUseCount(int PWIID)
       {
           return dal.GetPWIDUseCount(PWIID);
       }
        /// <summary>
        /// 某工艺单使用情况
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
       public int GetPWUseCount(int MainID)
       {
           return dal.GetPWUseCount(MainID);
       }
        /// <summary>
        /// 某一工艺单中单箱数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <returns></returns>
       public DataSet GetOneAmount(int MainID)
       {
           return dal.GetOneAmount(MainID);
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

