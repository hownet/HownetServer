using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类ProductTaskMain 的摘要说明。
	/// </summary>
	public class ProductTaskMain
	{
		private readonly Hownet.DAL.ProductTaskMain dal=new Hownet.DAL.ProductTaskMain();
		public ProductTaskMain()
		{}
		#region  成员方法

		/// <summary>
        /// 得到最大IDGetTaskList
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
		public int  Add(Hownet.Model.ProductTaskMain model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.ProductTaskMain> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.ProductTaskMain model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.ProductTaskMain> li=DataTableToList(dt);
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
		public Hownet.Model.ProductTaskMain GetModel(int ID)
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
		public List<Hownet.Model.ProductTaskMain> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.ProductTaskMain> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.ProductTaskMain> modelList = new List<Hownet.Model.ProductTaskMain>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.ProductTaskMain model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.ProductTaskMain();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["SalesOrderInfoID"].ToString()!="")
					{
						model.SalesOrderInfoID=int.Parse(dt.Rows[n]["SalesOrderInfoID"].ToString());
					}
					if(dt.Rows[n]["MaterielID"].ToString()!="")
					{
						model.MaterielID=int.Parse(dt.Rows[n]["MaterielID"].ToString());
					}
					if(dt.Rows[n]["BrandID"].ToString()!="")
					{
						model.BrandID=int.Parse(dt.Rows[n]["BrandID"].ToString());
					}
					if(dt.Rows[n]["Num"].ToString()!="")
					{
						model.Num=int.Parse(dt.Rows[n]["Num"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}
					if(dt.Rows[n]["LastDate"].ToString()!="")
					{
						model.LastDate=DateTime.Parse(dt.Rows[n]["LastDate"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["PWorkingID"].ToString()!="")
					{
						model.PWorkingID=int.Parse(dt.Rows[n]["PWorkingID"].ToString());
					}
					if(dt.Rows[n]["BomID"].ToString()!="")
					{
						model.BomID=int.Parse(dt.Rows[n]["BomID"].ToString());
					}
					if(dt.Rows[n]["CompanyID"].ToString()!="")
					{
						model.CompanyID=int.Parse(dt.Rows[n]["CompanyID"].ToString());
					}
					if(dt.Rows[n]["IsTicket"].ToString()!="")
					{
						if((dt.Rows[n]["IsTicket"].ToString()=="1")||(dt.Rows[n]["IsTicket"].ToString().ToLower()=="true"))
						{
						model.IsTicket=true;
						}
						else
						{
							model.IsTicket=false;
						}
					}
					if(dt.Rows[n]["IsBom"].ToString()!="")
					{
						if((dt.Rows[n]["IsBom"].ToString()=="1")||(dt.Rows[n]["IsBom"].ToString().ToLower()=="true"))
						{
						model.IsBom=true;
						}
						else
						{
							model.IsBom=false;
						}
					}
					if(dt.Rows[n]["IsVerify"].ToString()!="")
					{
						model.IsVerify=int.Parse(dt.Rows[n]["IsVerify"].ToString());
					}
					if(dt.Rows[n]["VerifyDate"].ToString()!="")
					{
						model.VerifyDate=DateTime.Parse(dt.Rows[n]["VerifyDate"].ToString());
					}
					if(dt.Rows[n]["VerifyMan"].ToString()!="")
					{
						model.VerifyMan=int.Parse(dt.Rows[n]["VerifyMan"].ToString());
					}
					if(dt.Rows[n]["DeparmentID"].ToString()!="")
					{
						model.DeparmentID=int.Parse(dt.Rows[n]["DeparmentID"].ToString());
					}
					if(dt.Rows[n]["UpData"].ToString()!="")
					{
						model.UpData=int.Parse(dt.Rows[n]["UpData"].ToString());
					}
					if(dt.Rows[n]["FillDate"].ToString()!="")
					{
						model.FillDate=DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
					}
					if(dt.Rows[n]["FilMan"].ToString()!="")
					{
						model.FilMan=int.Parse(dt.Rows[n]["FilMan"].ToString());
					}
                    if (dt.Rows[n]["TicketDate"].ToString() != "")
                    {
                        model.TicketDate = DateTime.Parse(dt.Rows[n]["TicketDate"].ToString());
                    }
                    model.BedNO = dt.Rows[n]["BedNO"].ToString();
                    if (dt.Rows[n]["PackingMethodID"].ToString() != "")
                    {
                        model.PackingMethodID = int.Parse(dt.Rows[n]["PackingMethodID"].ToString());
                    }
                    else
                    {
                        model.PackingMethodID = 0;
                    }
                    model.SewingRemark = dt.Rows[n]["SewingRemark"].ToString();
                    if (dt.Rows[n]["ParentID"].ToString() != "")
                    {
                        model.ParentID = int.Parse(dt.Rows[n]["ParentID"].ToString());
                    }
                    else
                    {
                        model.ParentID = 0;
                    }
                    if (dt.Rows[n]["DeparmentType"] != null && dt.Rows[n]["DeparmentType"].ToString() != "")
                    {
                        model.DeparmentType = int.Parse(dt.Rows[n]["DeparmentType"].ToString());
                    }
                    if (dt.Rows[n]["Price"] != null && dt.Rows[n]["Price"].ToString() != "")
                    {
                        model.Price = decimal.Parse(dt.Rows[n]["Price"].ToString());
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
        public DataSet GetIDList()
        {
            if (GetHDID.LinesCount == -1)
            {
                GetHDID.CheckReg();
            }
            DataSet ds = dal.GetIDList();
            if (GetHDID.LinesCount == -1 && ds.Tables[0].Rows.Count > 50)
            {
                return new DataSet();
            }
            else
            {
                return ds;
            }
        }
        public int NewNum(DateTime dt,int TypeID)
        {
            return dal.NewNum(dt,TypeID);
        }
        public DataSet GetTicketMain(int TaskID, int TaskDepID)
        {
            return dal.GetTicketMain(TaskID, TaskDepID);
        }
        public DataSet GetTicketInfo(int MainID)
        {
            return dal.GetTicketInfo(MainID);
        }
        public DataSet GetReport(int TaskID, int TaskDepID)
        {
            return dal.GetReport(TaskID, TaskDepID);
        }
        public DataSet GetTickInfo(int TaskID,int TaskDepID)
        {
            return dal.GetTickInfo(TaskID,TaskDepID);
        }
        public string GetNum(int TaskID)
        {
            DataTable dt = dal.GetNum(TaskID).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return ((DateTime)(dt.Rows[0]["DateTime"])).ToString("yyyyMMdd") + dt.Rows[0]["Num"].ToString().PadLeft(3, '0');
            }
            else
                return "";
        }
        public int Count()
        {
            return dal.Count();
        }
        public DataSet GetNumList()
        {
            return dal.GetNumList();
        }
        public DataSet GetTaskList(int TableTypeID,string strWhere)
        {
            return dal.GetTaskList(TableTypeID,strWhere);
        }
        public DataSet GetGroupWorkingList(int MaterielID, int BrandID)
        {
            return dal.GetGroupWorkingList(MaterielID, BrandID);
        }
        public DataSet GetToDepList(int TaskID)
        {
            return dal.GetToDepList(TaskID);
        }
        public DataSet GetWorkAmount(int MaterielID, int BrandID, int TableTypeID)
        {
            return dal.GetWorkAmount(MaterielID, BrandID, TableTypeID);
        }
        public DataSet GetWorkAmountByCS(int MaterielID, int BrandID, int TableTypeID, int ColorID, int ColorOneID, int ColorTwoID, int SizeID)
        {
            return dal.GetWorkAmountByCS(MaterielID, BrandID, TableTypeID, ColorID, ColorOneID, ColorTwoID, SizeID);
        }
        public bool CheckNum(DateTime dt, int Num)
        {
            return dal.CheckNum(dt, Num);
        }
        public DataSet GetNumListByDeparmentID(string strWhere)
        {
            return dal.GetNumListByDeparmentID(strWhere);
        }
        public bool CheckHasToDepot(int TaskID)
        {
            return dal.CheckHasToDepot(TaskID);
        }
        public void UpAmount(int TaskID, int TableTypeID)
        {
            dal.UpAmount(TaskID, TableTypeID);
        }
        /// <summary>
        /// 获取生产单的款号
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public string GetMaterielName(int TaskID)
        {
            return dal.GetMaterielName(TaskID);
        }
        /// <summary>
        /// 获取该生产单的领料记录
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataSet GetLinLiaoList(int TaskID,int TypeID)
        {
            return dal.GetLinLiaoList(TaskID,TypeID);
        }
         //委外生产制单
        public DataSet GetWWIDList()
        {
            return dal.GetWWIDList();
        }
        /// <summary>
        /// 获取某款号的新床号
        /// </summary>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public int GetMaxBedNO(int MaterielID)
        {
            return dal.GetMaxBedNO(MaterielID);
        }
          /// <summary>
        /// 返回汇总的数据
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public DataSet GetSumTaskList(DateTime dt1, DateTime dt2, int MatID, int DeparmentID, string DepName)
        {
            return dal.GetSumTaskList(dt1, dt2, MatID, DeparmentID, DepName);
        }
           /// <summary>
        /// 某款号使用某工艺单的数量
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <returns></returns>
        public DataSet GetSumAmount(DateTime dt1, DateTime dt2, int MatID, int PWID)
        {
            return dal.GetSumAmount(dt1, dt2, MatID, PWID);
        }
        public DataSet GetTicketInfoCard(int MainID)
        {
            return dal.GetTicketInfoCard(MainID);
        }
        public DataSet GetMaterielByDeparmentID(int DeparmentID, int DeparmentTypeID)
        {
            return dal.GetMaterielByDeparmentID(DeparmentID, DeparmentTypeID);
        }
        public DataSet GetSchedule(int TaskID, int MaterielID,DateTime dt1,DateTime dt2,int PWID)
        {
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            Hownet.BLL.WorkTicketInfo bllWTI = new WorkTicketInfo();
            Hownet.BLL.AmountInfo bllAI = new AmountInfo();
            Hownet.BLL.OtherType bllOT = new OtherType();
            Hownet.BLL.Materiel bllM=new Materiel();
            DataTable dtOT = bllOT.GetTypeList("进度工序").Tables[0];
            DataTable dt = new DataTable();
            dt.TableName = "dt";
            dt.Columns.Add("款号", typeof(string));
            dt.Columns.Add("颜色", typeof(int));
            dt.Columns.Add("尺码", typeof(int));
            dt.Columns.Add("未领", typeof(int));
            for (int i = 0; i < dtOT.Rows.Count; i++)
            {
                dt.Columns.Add(dtOT.Rows[i]["Name"].ToString(), typeof(int));
            }
            dt.Columns.Add("合计", typeof(int));
            int _colCount = dt.Columns.Count;
            int _Amount = 0;
            int _aaa = 0;
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            if (TaskID > 0)
            {
                #region 按制单
                Hownet.Model.ProductTaskMain modPTM = GetModel(TaskID);
                if (modPTM.IsTicket)
                {
                    try
                    {
                        DataTable dtAI = bllAI.GetColorSize(TaskID, 1).Tables[0];
                        DataTable dtPWI = bllPWI.GetTopList(1, "(MainID=" + modPTM.PWorkingID + ") And (IsTicket=1)", "Orders").Tables[0];
                        Hownet.Model.Materiel modM = bllM.GetModel(modPTM.MaterielID);
                        for (int i = 0; i < dtAI.Rows.Count; i++)
                        {
                            _Amount = 0;
                            DataRow dr = dt.NewRow();
                            dr["款号"] =modM. Name;
                            dr["颜色"] = dtAI.Rows[i]["ColorID"];
                            dr["尺码"] = dtAI.Rows[i]["SizeID"];
                            _aaa = bllWTI.GetNotAmountByOrders(TaskID, Convert.ToInt32(dtAI.Rows[i]["ColorID"]), Convert.ToInt32(dtAI.Rows[i]["SizeID"]), Convert.ToInt32(dtPWI.Rows[0]["WorkingID"]));
                            if (_aaa > 0)
                                dr["未领"] = _Amount = _aaa;
                            else
                                dr["未领"] = DBNull.Value;
                            for (int j = 0; j < dtOT.Rows.Count; j++)
                            {
                                _aaa = bllWTI.GetNotAmountByOrders(TaskID, Convert.ToInt32(dtAI.Rows[i]["ColorID"]), Convert.ToInt32(dtAI.Rows[i]["SizeID"]), Convert.ToInt32(dtOT.Rows[j]["Value"]));
                                if (_aaa > 0)
                                    dr[j + 4] = _aaa;
                                else
                                    dr[j + 4] = DBNull.Value;
                                _Amount += _aaa;
                            }
                            dr[_colCount - 1] = _Amount;
                            dt.Rows.Add(dr);
                        }
                        DataRow drr = dt.NewRow();
                        drr[0] = modM.Name + "小计";
                        drr[1] = 0;
                        drr[2] = 0;
                        _Amount = 0;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            if (dt.Rows[i][3].ToString() != string.Empty)
                                _Amount += Convert.ToInt32(dt.Rows[i][3]);
                        }
                        drr[3] = _Amount;
                        //  _Amount=0;
                        for (int i = 0; i < dtOT.Rows.Count; i++)
                        {
                            drr[i + 4] = bllWTI.GetNotAmountByOrders(TaskID, 0, 0, Convert.ToInt32(dtOT.Rows[i]["Value"]));
                            _Amount += Convert.ToInt32(drr[i + 4]);
                        }
                        drr[_colCount - 1] = _Amount;
                        dt.Rows.Add(drr);
                        ds.Tables.Add(dt);
                    }
                    catch (Exception ex)
                    {
                    }
                }
                #endregion
            }
            else if (MaterielID > 0)
            {
                try
                {
                    DataTable dtAI = GetSumAmount(dt1, dt2, MaterielID, PWID).Tables[0];
                    DataTable dtPWI = bllPWI.GetTopList(1, "(MainID=" + PWID + ") And (IsTicket=1)", "Orders").Tables[0];
                    Hownet.Model.Materiel modM = bllM.GetModel(MaterielID);
                    for (int i = 0; i < dtAI.Rows.Count; i++)
                    {
                        _Amount = 0;
                        DataRow dr = dt.NewRow();
                        dr["款号"] = modM.Name;
                        dr["颜色"] = dtAI.Rows[i]["ColorID"];
                        dr["尺码"] = dtAI.Rows[i]["SizeID"];


                        _aaa = bllWTI.GetNotAmountByMateriel(dt1,dt2, MaterielID, Convert.ToInt32(dtAI.Rows[i]["ColorID"]), Convert.ToInt32(dtAI.Rows[i]["SizeID"]), Convert.ToInt32(dtPWI.Rows[0]["WorkingID"]));
                        if (_aaa > 0)
                            dr["未领"] = _Amount = _aaa;
                        else
                            dr["未领"] = DBNull.Value;
                        for (int j = 0; j < dtOT.Rows.Count; j++)
                        {
                            _aaa = bllWTI.GetNotAmountByMateriel(dt1, dt2, MaterielID, Convert.ToInt32(dtAI.Rows[i]["ColorID"]), Convert.ToInt32(dtAI.Rows[i]["SizeID"]), Convert.ToInt32(dtOT.Rows[j]["Value"]));
                            if (_aaa > 0)
                                dr[j + 4] = _aaa;
                            else
                                dr[j + 4] = DBNull.Value;
                            _Amount += _aaa;
                        }
                        dr[_colCount - 1] = _Amount;
                        dt.Rows.Add(dr);
                    }
                    DataRow drr = dt.NewRow();
                    drr[0] = modM.Name + "小计";
                    drr[1] = 0;
                    drr[2] = 0;
                    _Amount = 0;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i][3].ToString() != string.Empty)
                            _Amount += Convert.ToInt32(dt.Rows[i][3]);
                    }
                    drr[3] = _Amount;
                    //  _Amount=0;
                    for (int i = 0; i < dtOT.Rows.Count; i++)
                    {
                        drr[i + 4] = bllWTI.GetNotAmountByMateriel(dt1, dt2, MaterielID, 0, 0, Convert.ToInt32(dtOT.Rows[i]["Value"]));
                        _Amount += Convert.ToInt32(drr[i + 4]);
                    }
                    drr[_colCount - 1] = _Amount;
                    dt.Rows.Add(drr);
                    ds.Tables.Add(dt);
                }
                catch (Exception ex)
                {
                }

            }
            return ds;
        }
        /// <summary>
        /// 返回某一款号最新的200个记录，
        /// </summary>
        /// <param name="MaterielName"></param>
        /// <returns></returns>
        public DataSet GetTaskListByMaterielName(string MaterielName)
        {
            return dal.GetTaskListByMaterielName(MaterielName);
        }
        public int VerifyInDepot(int MainID, bool t, int TableTypeID)
        {
            Hownet.BLL.AmountInfo bllAI = new AmountInfo();
            Hownet.BLL.Materiel bllMat=new Materiel();
           
            Hownet.Model.ProductTaskMain modPTM = GetModel(MainID);
            List<Hownet.Model.AmountInfo> liAI = bllAI.DataTableToList(bllAI.GetList("(MainID=" + MainID + ") And (TableTypeID=" + TableTypeID + ")").Tables[0]);
            Hownet.BLL.Repertory bllRe = new Repertory();
            Hownet.Model.Repertory modRe;
            Hownet.Model.Materiel modMat=bllMat.GetModel(modPTM.MaterielID);
            int a = 0;
            if(liAI.Count>0)
            {
                for(int i=0;i<liAI.Count;i++)
                {
                    modRe = new Model.Repertory();
                    modRe.Amount = liAI[i].Amount;
                    modRe.BrandID = modPTM.BrandID;
                    modRe.ColorID = liAI[i].ColorID;
                    modRe.ColorOneID = liAI[i].ColorOneID;
                    modRe.ColorTwoID = liAI[i].ColorTwoID;
                    modRe.DepartmentID = modPTM.DeparmentID;
                    modRe.MaterielID = modPTM.MaterielID;
                    modRe.MeasureID = modMat.MeasureID;
                    modRe.MListID = liAI[i].MListID;
                    modRe.SizeID = liAI[i].SizeID;
                    bllRe.InOrOut(modRe, t);
                }
            }
            return a;
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

