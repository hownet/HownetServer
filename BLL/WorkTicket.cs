using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类WorkTicket 的摘要说明。
	/// </summary>
	public class WorkTicket
	{
		private readonly Hownet.DAL.WorkTicket dal=new Hownet.DAL.WorkTicket();
		public WorkTicket()
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
		public int  Add(Hownet.Model.WorkTicket model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicket> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.WorkTicket model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicket> li=DataTableToList(dt);
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
		public Hownet.Model.WorkTicket GetModel(int ID)
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
		public List<Hownet.Model.WorkTicket> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.WorkTicket> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.WorkTicket> modelList = new List<Hownet.Model.WorkTicket>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.WorkTicket model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.WorkTicket();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["ColorID"].ToString()!="")
					{
						model.ColorID=int.Parse(dt.Rows[n]["ColorID"].ToString());
					}
					if(dt.Rows[n]["ColorOneID"].ToString()!="")
					{
						model.ColorOneID=int.Parse(dt.Rows[n]["ColorOneID"].ToString());
					}
					if(dt.Rows[n]["ColorTwoID"].ToString()!="")
					{
						model.ColorTwoID=int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
					}
					if(dt.Rows[n]["SizeID"].ToString()!="")
					{
						model.SizeID=int.Parse(dt.Rows[n]["SizeID"].ToString());
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=int.Parse(dt.Rows[n]["Amount"].ToString());
					}
					if(dt.Rows[n]["BoxNum"].ToString()!="")
					{
						model.BoxNum=int.Parse(dt.Rows[n]["BoxNum"].ToString());
					}
					if(dt.Rows[n]["TaskID"].ToString()!="")
					{
						model.TaskID=int.Parse(dt.Rows[n]["TaskID"].ToString());
					}
					if(dt.Rows[n]["DepartmentID"].ToString()!="")
					{
						model.DepartmentID=int.Parse(dt.Rows[n]["DepartmentID"].ToString());
					}
					if(dt.Rows[n]["P2DInfoID"].ToString()!="")
					{
						model.P2DInfoID=int.Parse(dt.Rows[n]["P2DInfoID"].ToString());
					}
					if(dt.Rows[n]["EligibleAmount"].ToString()!="")
					{
						model.EligibleAmount=int.Parse(dt.Rows[n]["EligibleAmount"].ToString());
					}
					if(dt.Rows[n]["InferiorAmount"].ToString()!="")
					{
						model.InferiorAmount=int.Parse(dt.Rows[n]["InferiorAmount"].ToString());
					}
					if(dt.Rows[n]["P2DDepartmentID"].ToString()!="")
					{
						model.P2DDepartmentID=int.Parse(dt.Rows[n]["P2DDepartmentID"].ToString());
					}
					if(dt.Rows[n]["MListID"].ToString()!="")
					{
						model.MListID=int.Parse(dt.Rows[n]["MListID"].ToString());
					}
					if(dt.Rows[n]["BrandID"].ToString()!="")
					{
						model.BrandID=int.Parse(dt.Rows[n]["BrandID"].ToString());
					}
                    if (dt.Rows[n]["OneAmount"].ToString() != "")
                    {
                        model.OneAmount = int.Parse(dt.Rows[n]["OneAmount"].ToString());
                    }
                    else
                    {
                        model.OneAmount = 0;
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
        /// 获得不包含列A的数据列表
        /// </summary>
        public DataSet GetListNoA(string strWhere)
        {
            return dal.GetListNoA(strWhere);
        }
        public void Save(byte[] bb, int ProductWorkID, int TaskID)
        {
            DataTable Main = Hownet.BLL.BaseFile.ZipDt.Byte2Ds(bb).Tables[0];
            Main.Columns.Add("OneAmount", typeof(int));
            for (int i = 0; i < Main.Rows.Count; i++)
            {
                Main.Rows[i]["OneAmount"] = 0;
            }
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
            Hownet.Model.WorkTicket modWK = new Hownet.Model.WorkTicket();
            Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
            Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
            Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
            Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            Hownet.BLL.Materiel bllMat = new Materiel();
            Hownet.Model.Materiel modMat = bllMat.GetModel(modPTM.MaterielID);
            DataTable dtInfo = bllWkInfo.GetListNoA("(ID=0)").Tables[0];
            //DataSet dsPt = bllPTI.GetBoxID(TaskID, 1);

            //DataTable dtPWIAmount = bllPWI.GetOneAmount(ProductWorkID).Tables[0];
            //int _PJAmount = 0, _WAmount = 0;
            ////dtTem.Columns.Add("ColorID", typeof(string));
            ////   dtTem.Columns.Add("SizeID", typeof(string));
            ////   dtTem.Columns.Add("Amount", typeof(string));
            ////   dtTem.Columns.Add("BoxNum", typeof(string));
            //int BoxNum = Main.Rows.Count + 1;
            //int z = 0;
            //int j = 0;
            //for (int g = 0; g < dtPWIAmount.Rows.Count; g++)
            //{
            //    #region 有预设数量分箱
            //    if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) > 0)
            //    {
            //        _PJAmount = Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]);
            //        _WAmount = Convert.ToInt32(_PJAmount * 1.5);
            //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
            //        {
            //            //某数量少于尾箱数量，直接取该数量
            //            if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < _WAmount)
            //            {
            //                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
            //                    dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, _PJAmount);
            //                BoxNum++;
            //            }
            //            else
            //            {
            //                int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % _PJAmount;
            //                if (x <= (_WAmount - _PJAmount))
            //                {
            //                    z = 3;
            //                }
            //                if (x == 0)
            //                {
            //                    z = 1;
            //                }
            //                if (x > (_WAmount - _PJAmount))
            //                {
            //                    z = 2;
            //                }
            //                switch (z)
            //                {
            //                    case 1:
            //                        {

            //                            for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount)); j++)
            //                            {

            //                                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount,
            //                                    j, _PJAmount);
            //                            }
            //                            BoxNum = j;
            //                            break;
            //                        }
            //                    case 2:
            //                        {

            //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount); j++)
            //                            {
            //                                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"],
            //                                    dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, _PJAmount);
            //                            }

            //                            Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, _PJAmount);
            //                            BoxNum = j + 1;
            //                            break;
            //                        }
            //                    case 3:
            //                        {

            //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount) - 1; j++)
            //                            {
            //                                //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
            //                                Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, _PJAmount);
            //                            }
            //                            Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (_PJAmount + x),
            //                                j, _PJAmount);
            //                            BoxNum = j + 1;
            //                            break;
            //                        }
            //                }
            //            }
            //        }
            //    }
            //    #endregion
            //    #region 各色各码总数分为一箱
            //    if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) == -1)
            //    {
            //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
            //        {
            //            Main.Rows.Add(dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
            //                dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, -1);
            //            BoxNum++;
            //        }
            //    }
            //    #endregion
            //}
            try
            {
                bool t = false;
                DataSet dsPw = bllPWI.GetBoxWork(ProductWorkID);
                DataTable dtSpecial = bllPWI.GetList("(MainID=" + ProductWorkID * -1 + ")").Tables[0];//查出特殊工序明细表
                DataRow[] ddrs;
                if (dtSpecial.Rows.Count == 0)
                {

                    #region 没有特殊工序
                    for (int r = 0; r < Main.Rows.Count; r++)
                    {
                        modML = new Hownet.Model.MaterielList();
                        modML.ColorID = modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
                        modML.SizeID = modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
                        modML.ColorOneID = modWK.ColorOneID = Convert.ToInt32(Main.DefaultView[r]["ColorOneID"]);
                        modML.ColorTwoID = modWK.ColorTwoID = Convert.ToInt32(Main.DefaultView[r]["ColorTwoID"]);
                        modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
                        modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
                        modML.MaterielID = modPTM.MaterielID;
                        modML.BrandID = modPTM.BrandID;
                        modML.MeasureID = modMat.MeasureID;
                        modWK.MListID = bllML.GetID(modML);
                        modWK.TaskID = TaskID;
                        modWK.DepartmentID = modPTM.DeparmentID;
                        modWK.OneAmount = Convert.ToInt32(Main.DefaultView[r]["OneAmount"]);
                        int mainID = bllWT.Add(modWK);
                        ddrs = dsPw.Tables[0].Select("(OneAmount=" + modWK.OneAmount + ")");
                        for (int c = 0; c < ddrs.Length; c++)
                        {
                            modWKI.EmployeeID = 0;
                            modWKI.PWorkingInfoID = int.Parse(ddrs[c]["ID"].ToString());
                            modWKI.WorkingID = int.Parse(ddrs[c]["WorkingID"].ToString());
                            modWKI.MainID = mainID;
                            modWKI.OutAmount = modWKI.Amount = modWKI.NotAmount = modWK.Amount;
                            modWKI.TaskID = TaskID;

                            //bllWkInfo.Add(modWKI);
                            dtInfo.Rows.Add(0, modWKI.MainID,modWKI.DateTime, modWKI.IsDel, modWKI.PWorkingInfoID, modWKI.EmployeeID, modWKI.BackID, modWKI.Amount, modWKI.NotAmount, modWKI.TaskID, modWKI.WorkingID, modWKI.OutAmount);
                        }
                    }

                }
                    #endregion
                #region 特殊工序
                else
                {
                    DataRow[] drs;
                    for (int r = 0; r < Main.Rows.Count; r++)
                    {
                        modML = new Hownet.Model.MaterielList();
                        modML.ColorID = modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
                        modML.SizeID = modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
                        modML.ColorOneID = modWK.ColorOneID = Convert.ToInt32(Main.DefaultView[r]["ColorOneID"]);
                        modML.ColorTwoID = modWK.ColorTwoID = Convert.ToInt32(Main.DefaultView[r]["ColorTwoID"]);
                        modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
                        modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
                        modML.MaterielID = modPTM.MaterielID;
                        modML.BrandID = modPTM.BrandID;
                        modML.MeasureID = modMat.MeasureID;
                        modWK.MListID = bllML.GetID(modML);
                        modWK.TaskID = TaskID;
                        modWK.DepartmentID = modPTM.DeparmentID;
                        modWK.OneAmount = Convert.ToInt32(Main.DefaultView[r]["OneAmount"]);
                        int mainID = bllWT.Add(modWK);
                        for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                        {
                            t = false;
                            modWKI.EmployeeID = 0;
                            int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
                            modWKI.WorkingID = w;
                            modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
                            if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//判断某道工序是否是特殊工序
                            {

                                //有特定客户、特定尺码、特定颜色的特殊工序
                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                if (drs.Length == 0)
                                {
                                    //有特定尺码、特定颜色的特殊工序
                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                    if (drs.Length == 0)
                                    {
                                        //有特定尺码、特定客户的特殊工序
                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                        if (drs.Length == 0)
                                        {
                                            //有特定客户、特定颜色的特殊工序
                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=0)");
                                            if (drs.Length == 0)
                                            {
                                                //只有特定颜色的特殊工序
                                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=0) And (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ")");
                                                if (drs.Length == 0)
                                                {
                                                    //有只特定客户的特殊工序
                                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) and (MaterielID=0)");
                                                    if (drs.Length == 0)
                                                    {
                                                        //有只特定尺码的特殊工序
                                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=" + Main.Rows[r]["SizeID"] + ") and (ColorID=0) and (CompanyID=0)");
                                                        if (drs.Length == 0)
                                                        {
                                                            //不分颜色、客户的特殊工序
                                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=0)");
                                                            if (drs.Length == 0)
                                                            {
                                                                t = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (drs.Length > 0)
                                {
                                    modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                                    modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                                    if (modWKI.WorkingID == 0)
                                        t = true;
                                }
                            }
                            modWKI.MainID = mainID;
                            modWKI.OutAmount = modWKI.Amount = modWKI.NotAmount = modWK.Amount;
                            modWKI.TaskID = TaskID;
                            if (!t)
                                //bllWkInfo.Add(modWKI);//有特殊工序的普通工序，则添加记录，否则不添加
                                dtInfo.Rows.Add(0, modWKI.MainID,modWKI.DateTime, modWKI.IsDel, modWKI.PWorkingInfoID, modWKI.EmployeeID, modWKI.BackID, modWKI.Amount, modWKI.NotAmount, modWKI.TaskID, modWKI.WorkingID, modWKI.OutAmount);
                        }
                    }
                }

                #endregion
                DAL.BaseFile.MakeBox.AddWorkTicketInfo(dtInfo);
            }
            catch (Exception ex)
            {
            }
        }
        public DataSet GetView(int TaskID,int OneAmount)
        {
            return dal.GetView(TaskID,OneAmount);
        }
             /// <summary>
        /// 用于显示工序完成情况
        /// </summary>
        /// <param name="TaskID">任务单ID</param>
        /// <returns></returns>
        public DataSet GetWorkList(int TaskID,int TaskDepID)
        {
            return dal.GetWorkList(TaskID,TaskDepID);
        }
        public DataSet GetReport(int TaskID, int TaskDepID)
        {
            return dal.GetReport(TaskID,TaskDepID);
        }
        public DataSet GetGroupReport(int GroupBy, int TaskID)
        {
            return dal.GetGroupReport(GroupBy, TaskID);
        }
        /// <summary>
        /// 获得只有ID值的列表
        /// </summary>
        public DataSet GetIDList(int TaskID,int OneAmount)
        {
            return dal.GetIDList(TaskID, OneAmount);
        }
        public DataSet GetInDepotList(int ID)
        {
            return dal.GetInDepotList(ID);
        }
        /// <summary>
        /// 获取单箱数量
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetOneAmount(int TaskID)
        {
            return dal.GetOneAmount(TaskID);
        }
        public DataSet GetBoxInfo(int ID,int GroupBy)
        {
            return dal.GetBoxInfo(ID,GroupBy);
        }
        public DataSet GetTickInfo(int TicketID)
        {
            return dal.GetTickInfo(TicketID);
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

