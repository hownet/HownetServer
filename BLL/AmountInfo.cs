using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类AmountInfo 的摘要说明。
	/// </summary>
	public class AmountInfo
	{
		private readonly Hownet.DAL.AmountInfo dal=new Hownet.DAL.AmountInfo();
		public AmountInfo()
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
		public int  Add(Hownet.Model.AmountInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.AmountInfo> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.AmountInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.AmountInfo> li=DataTableToList(dt);
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
		public Hownet.Model.AmountInfo GetModel(int ID)
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
		public List<Hownet.Model.AmountInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.AmountInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.AmountInfo> modelList = new List<Hownet.Model.AmountInfo>();
            try
            {
                int rowsCount = dt.Rows.Count;
                if (rowsCount > 0)
                {
                    Hownet.Model.AmountInfo model;
                    for (int n = 0; n < rowsCount; n++)
                    {
                        model = new Hownet.Model.AmountInfo();
                        if (dt.Rows[n]["ID"].ToString() != "")
                        {
                            model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                        }
                        if (dt.Rows[n]["MainID"].ToString() != "")
                        {
                            model.MainID = int.Parse(dt.Rows[n]["MainID"].ToString());
                        }
                        if (dt.Rows[n]["TableTypeID"].ToString() != "")
                        {
                            model.TableTypeID = int.Parse(dt.Rows[n]["TableTypeID"].ToString());
                        }
                        if (dt.Rows[n]["ColorID"].ToString() != "")
                        {
                            model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                        }
                        if (dt.Rows[n]["ColorOneID"].ToString() != "")
                        {
                            model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                        }
                        if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                        {
                            model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
                        }
                        if (dt.Rows[n]["SizeID"].ToString() != "")
                        {
                            model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                        }
                        if (dt.Rows[n]["MListID"].ToString() != "")
                        {
                            model.MListID = int.Parse(dt.Rows[n]["MListID"].ToString());
                        }
                        if (dt.Rows[n]["Amount"].ToString() != "")
                        {
                            model.Amount = int.Parse(dt.Rows[n]["Amount"].ToString());
                        }
                        if (dt.Rows[n]["NotAmount"].ToString() != "")
                        {
                            model.NotAmount = int.Parse(dt.Rows[n]["NotAmount"].ToString());
                        }
                        if (dt.Rows[n]["NotDepAmount"].ToString() != "")
                        {
                            model.NotDepAmount = int.Parse(dt.Rows[n]["NotDepAmount"].ToString());
                        }
                        model.Remark = dt.Rows[n]["Remark"].ToString();
                        model.A = int.Parse(dt.Rows[n]["A"].ToString());
                        modelList.Add(model);
                    }
                }
            }
            catch (Exception ex)
            {
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
        /// 三个颜色分三个表汇总
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetColor(int MainID, int TypeID)
        {
            return dal.GetColor(MainID,TypeID);
        }
        /// <summary>
        /// 三个颜色的汇总
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TypeID"></param>
        /// <returns></returns>
        public DataSet GetSumColor(int MainID, int TypeID)
        {
            return dal.GetSumColor(MainID, TypeID);
        }
        public DataSet GetSize(int MainID, int TypeID)
        {
            return dal.GetSize(MainID,TypeID);
        }
        public void DelInfo(int MainID, int TypeID)
        {
            dal.DelInfo(MainID,TypeID);
        }
              /// <summary>
        /// 获取出票时的颜色、尺码、数量列表
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetBox(int TaskID, int TypeID)
        {
            return dal.GetBox(TaskID, TypeID);
        }
                /// <summary>
        /// 获取出票时的颜色、尺码、数量列表，颜色、尺码只有ID值
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetBoxID(int TaskID, int TypeID)
        {
            return dal.GetBoxID(TaskID, TypeID);
        }
        /// <summary>
        /// 审核/弃审成品入库
        /// </summary>
        /// <param name="model"></param>
        /// <param name="t">真为审核入库，假为弃核</param>
        public void UpNotAmount(Model.AmountInfo model, bool t)
        {
            dal.UpNotAmount(model, t);
        }
        public DataSet GetGroupColorSize(int TaskID, int TypeID)
        {
            return dal.GetGroupColorSize(TaskID, TypeID);
        }
        public void UpNotDepAmount(int TaskID, int TaskDepID)
        {
            dal.UpNotDepAmount(TaskID, TaskDepID);
        }
        public DataSet GetSumAmount(int MainID, int TableTypeID)
        {
            return dal.GetSumAmount(MainID, TableTypeID);
        }
        /// <summary>
        /// 订单数量转入计划
        /// </summary>
        /// <param name="SaleID"></param>
        /// <param name="PlanID"></param>
        /// <param name="SaleTypeID"></param>
        /// <param name="PlanTypeID"></param>
        public void SaleToPlan(int SaleID, int PlanID, int SaleTypeID, int PlanTypeID)
        {
            dal.SaleToPlan(SaleID, PlanID, SaleTypeID, PlanTypeID);
        }
        /// <summary>
        /// 删除一份客户订货合同的明细数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        public void DelSalesBySaleID(int MainID, int TableTypeID)
        {
            dal.DelSalesBySaleID(MainID, TableTypeID);
        }
        public void InNoList(int MainID)
        {
            try
            {
                DataTable dt = new DataTable();
                if (MainID == 0)
                {
                    dt = dal.GetNoList().Tables[0];
                }
                else
                {
                    dt.Columns.Add("ID", typeof(int));
                    dt.Rows.Add(MainID);
                }
                if (dt.Rows.Count > 0)
                {

                    Hownet.BLL.Size bllS = new Size();
                    Hownet.BLL.ClothAmount bllCA = new ClothAmount();
                    Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
                    Hownet.BLL.Materiel bllMat = new Materiel();
                    Hownet.BLL.MaterielList bllML = new MaterielList();
                    Hownet.Model.AmountInfo modAI = new Hownet.Model.AmountInfo();
                    Hownet.Model.ProductTaskMain modPTM = new Hownet.Model.ProductTaskMain();
                    Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
                    DataTable dtCA = new DataTable();
                    DataTable dtSize = bllS.GetAllList().Tables[0];
                    DataTable dtMat = bllMat.GetList("(AttributeID=4)").Tables[0];
                    DataTable dtTem = new DataTable();
                    int[] li = new int[15];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        modPTM = bllPTM.GetModel(Convert.ToInt32(dt.Rows[i]["ID"]));
                        if (GetList("(MainID=" + modPTM.ID + ") And (TableTypeID=1)").Tables[0].Rows.Count == 0)
                        {
                            dtCA = bllCA.GetList("(MainID=" + dt.Rows[i]["ID"] + ") order by ID").Tables[0];


                            //DelInfo(modPTM.ID, 1);
                            if (dtCA.Rows.Count > 0)
                            {
                                for (int j = 0; j < dtCA.Rows.Count; j++)
                                {
                                    if (Convert.ToInt32(dtCA.Rows[j]["ColorID"]) == 0)//颜色ID为0，查询出尺码ID
                                    {
                                        li = new int[15];
                                        for (int s = 1; s < 16; s++)
                                        {
                                            if (dtCA.Rows[j]["Size" + s.ToString()].ToString() != string.Empty)//尺码不为空，查询尺码ID
                                            {
                                                DataRow[] drSize = dtSize.Select("(Name='" + dtCA.Rows[j]["Size" + s.ToString()] + "')");
                                                if (drSize.Length > 0)
                                                {
                                                    li[s - 1] = Convert.ToInt32(drSize[0]["ID"]);
                                                }
                                                else
                                                {
                                                    li[s - 1] = 0;
                                                }
                                            }
                                            else
                                            {
                                                li[s - 1] = 0;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        for (int m = 0; m < 15; m++)
                                        {
                                            if (li[m] > 0)
                                            {
                                                modAI = new Hownet.Model.AmountInfo();
                                                modAI.A = 1;
                                                modAI.Amount = Convert.ToInt32(dtCA.Rows[j]["Size" + (m + 1).ToString()]);
                                                modML.ColorID = modAI.ColorID = Convert.ToInt32(dtCA.Rows[j]["ColorID"]);
                                                modML.BrandID = modPTM.BrandID;
                                                modML.ColorOneID = modAI.ColorOneID = 0;
                                                modML.ColorTwoID = modAI.ColorTwoID = 0;
                                                modML.MaterielID = modPTM.MaterielID;
                                                modML.SizeID = modAI.SizeID = li[m];
                                                modML.MeasureID = Convert.ToInt32(dtMat.Select("(ID=" + modML.MaterielID + ")")[0]["MeasureID"]);
                                                modAI.ID = 0;
                                                modAI.MainID = Convert.ToInt32(dtCA.Rows[j]["MainID"]);
                                                modAI.MListID = bllML.GetID(modML);
                                                modAI.NotAmount = modAI.Amount;
                                                modAI.NotDepAmount = modAI.Amount;
                                                modAI.Remark = string.Empty;
                                                modAI.TableTypeID = 1;
                                                dtTem = GetList("(MainID=" + modPTM.ID + ") And (TableTypeID=1) And (MListID=" + modAI.MListID + ")").Tables[0];
                                                if (dtTem.Rows.Count == 0)
                                                {
                                                    Add(modAI);
                                                }
                                                else
                                                {
                                                    Hownet.Model.AmountInfo modAAI = GetModel(Convert.ToInt32(dtTem.Rows[0]["ID"]));
                                                    modAAI.Amount += modAI.Amount;
                                                    modAAI.NotDepAmount += modAI.NotDepAmount;
                                                    modAAI.NotAmount += modAI.NotAmount;
                                                    Update(modAAI);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        public DataSet GetColorSize(int TaskID, int TableTypeID)
        {
            return dal.GetColorSize(TaskID, TableTypeID);
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

