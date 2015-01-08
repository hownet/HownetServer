using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类WorkTicketInfo 的摘要说明。
	/// </summary>
	public class WorkTicketInfo
	{
		private readonly Hownet.DAL.WorkTicketInfo dal=new Hownet.DAL.WorkTicketInfo();
		public WorkTicketInfo()
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
		public int  Add(Hownet.Model.WorkTicketInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicketInfo> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.WorkTicketInfo model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.WorkTicketInfo> li=DataTableToList(dt);
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
		public Hownet.Model.WorkTicketInfo GetModel(int ID)
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
		public List<Hownet.Model.WorkTicketInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.WorkTicketInfo> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.WorkTicketInfo> modelList = new List<Hownet.Model.WorkTicketInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.WorkTicketInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.WorkTicketInfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["DateTime"].ToString()!="")
					{
						model.DateTime=DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
					}
					if(dt.Rows[n]["IsDel"].ToString()!="")
					{
						if((dt.Rows[n]["IsDel"].ToString()=="1")||(dt.Rows[n]["IsDel"].ToString().ToLower()=="true"))
						{
						model.IsDel=true;
						}
						else
						{
							model.IsDel=false;
						}
					}
					if(dt.Rows[n]["PWorkingInfoID"].ToString()!="")
					{
						model.PWorkingInfoID=int.Parse(dt.Rows[n]["PWorkingInfoID"].ToString());
					}
					if(dt.Rows[n]["EmployeeID"].ToString()!="")
					{
						model.EmployeeID=int.Parse(dt.Rows[n]["EmployeeID"].ToString());
					}
					if(dt.Rows[n]["BackID"].ToString()!="")
					{
						model.BackID=int.Parse(dt.Rows[n]["BackID"].ToString());
					}
					if(dt.Rows[n]["Amount"].ToString()!="")
					{
						model.Amount=int.Parse(dt.Rows[n]["Amount"].ToString());
					}
					if(dt.Rows[n]["NotAmount"].ToString()!="")
					{
						model.NotAmount=int.Parse(dt.Rows[n]["NotAmount"].ToString());
					}
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    if (dt.Rows[n]["WorkingID"].ToString() != "")
					{
                        model.WorkingID = int.Parse(dt.Rows[n]["WorkingID"].ToString());
					}
                    if (dt.Rows[n]["OutAmount"] != null && dt.Rows[n]["OutAmount"].ToString() != "")
                    {
                        model.OutAmount = int.Parse(dt.Rows[n]["OutAmount"].ToString());
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
        /// 获得不包括列A数据列表
        /// </summary>
        public DataSet GetListNoA(string strWhere)
        {
            return dal.GetListNoA(strWhere);
        }
        public DataSet GetBoolAdd(int TaskID, int BoxNum, int WorkingID)
        {
            return dal.GetBoolAdd(TaskID, BoxNum, WorkingID);
        }
                /// <summary>
        /// 删除一条已记录的条码
        /// </summary>
        /// <param name="ID"></param>
        public void DelBar(int ID)
        {
            dal.DelBar(ID);
        }
        public bool CheckWorking(int TaskID, int PWIID, int CompanyID)
        {
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            Hownet.BLL.Working bllW = new Working();
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.Model.ProductWorkingInfo modPWI = new Hownet.Model.ProductWorkingInfo();
            modPWI = bllPWI.GetModel(PWIID);
            if (!modPWI.IsSpecial)//不是特殊工序
            {
                if (!dal.CheckWorking(TaskID, PWIID,modPWI.OneAmount))//已生成工票中没有这道工序
                {
                    Hownet.Model.WorkTicketInfo modWTI;
                    DataTable dtWT = new DataTable();
                    dtWT = bllWT.GetList("(TaskID=" + TaskID + ") And (OneAmount=" + modPWI.OneAmount + ")").Tables[0];
                    for (int i = 0; i < dtWT.Rows.Count; i++)
                    {
                        modWTI = new Hownet.Model.WorkTicketInfo();
                        modWTI.NotAmount = modWTI.Amount = int.Parse(dtWT.Rows[i]["Amount"].ToString());
                        modWTI.BackID = 0;
                        modWTI.DateTime = null;
                        modWTI.EmployeeID = 0;
                        modWTI.IsDel = false;
                        modWTI.MainID = int.Parse(dtWT.Rows[i]["ID"].ToString());

                        if (TaskID > 0)
                        {
                            modWTI.TaskID = TaskID;
                            modWTI.PWorkingInfoID = PWIID;
                        }
                        modWTI.WorkingID = modPWI.WorkingID;
                        Add(modWTI);
                    }
                }
                return true;
            }
            else
            {
                DataTable dtTem = bllPWI.GetList("(PWIID=" + modPWI.ID + ")").Tables[0];
                List<Hownet.Model.ProductWorkingInfo> li = bllPWI.DataTableToList(dtTem);//是特殊工序时，查找其构成的普通工序
                if (li.Count == 0)
                    return false;
                for (int i = 0; i < li.Count; i++)
                {
                    if (dal.CheckWorking(TaskID, li[i].ID,  li[i].OneAmount))
                    {
                        return true;
                    }
                }
                Hownet.Model.WorkTicketInfo modWTI;
                DataTable dtWT = new DataTable();
                dtWT = bllWT.GetList("(TaskID=" + TaskID + ") And (OneAmount=" + li[0].OneAmount + ")").Tables[0];
                DataRow[] drs;
                bool t = false;
                for (int i = 0; i < dtWT.Rows.Count; i++)
                {
                    t = false;
                    modWTI = new Hownet.Model.WorkTicketInfo();
                    modWTI.NotAmount = modWTI.Amount = int.Parse(dtWT.Rows[i]["Amount"].ToString());
                    modWTI.BackID = 0;
                    modWTI.DateTime = null;
                    modWTI.EmployeeID = 0;
                    modWTI.IsDel = false;
                    modWTI.MainID = int.Parse(dtWT.Rows[i]["ID"].ToString());
                    if (TaskID > 0)
                        modWTI.TaskID = TaskID;
                    //if (CompanyID > 0)
                    //{
                        drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And (MaterielID="+dtWT.Rows[i]["SizeID"]+")");//同客户同颜色同尺码
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=0) And (MaterielID=" + dtWT.Rows[i]["SizeID"] + ")");//同客户同尺码无颜色
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And (MaterielID=0)");//同客户同颜色无尺码
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And  (MaterielID=" + dtWT.Rows[i]["SizeID"] + ")");//无客户同颜色同尺码
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=" + CompanyID + ") And (ColorID=0) And (MaterielID=0)");//仅客户
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=" + dtWT.Rows[i]["ColorID"] + ") And (MaterielID=0)");//仅颜色
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=0) And (MaterielID=" + dtWT.Rows[i]["SizeID"] + ")");//仅尺码
                        }
                        if (drs.Length == 0)
                        {
                            drs = dtTem.Select("(CompanyID=0) And (ColorID=0) And (MaterielID=0)");//无客户无颜色无尺码
                        }
                        if (drs.Length > 0)
                        {
                            modWTI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                            modWTI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                        }
                        else
                        {
                            t = true;
                        }
                    //}
                    //else
                    //{
                    //    drs = dtTem.Select("(CompanyID=0) And (ColorID=" + dtWT.Rows[i]["ColorID"] + ")");
                    //    if (drs.Length == 0)
                    //    {
                    //        drs = dtTem.Select("(CompanyID=0) And (ColorID=0)");
                    //    }
                    //    if (drs.Length > 0)
                    //    {
                    //        modWTI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                    //        modWTI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                    //    }
                    //    else
                    //    {
                    //        t = true;
                    //    }
                    //}

                    if (!t)
                        Add(modWTI);
                }
            }

            return true;
        }
        public DataSet GetTicketLine(int TaskID, int PWIID, int TaskDepID, int DPWID)
        {
            DataSet ds = new DataSet();
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            Hownet.Model.ProductWorkingInfo modPWI = new Hownet.Model.ProductWorkingInfo();
            if (TaskDepID == 0)
                modPWI = bllPWI.GetModel(PWIID);
            else
                modPWI = bllPWI.GetModel(DPWID);
            if (!modPWI.IsSpecial)//不是特殊工序
            {
                return dal.GetTicketLine(TaskID, PWIID, TaskDepID, DPWID);
            }
            else
            {
               return dal.GetSpecialTicketLine(TaskID, PWIID, TaskDepID, DPWID);
            }
            if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
            {
                ds.Tables.Clear();
                ds = dal.GetSpecialTicketLine(TaskID, PWIID,TaskDepID,DPWID);
            }
            return ds;
        }
        /// <summary>
        /// 用于显示工序执行情况
        /// </summary>
        /// <param name="TaskID">生产单ID</param>
        /// <returns></returns>
        public DataSet GetWorkListByPW(int TaskID, int PWMID, int MaterielID,int TaskDepID)
        {
            try
            {
                Hownet.BLL.WorkTicket bllWT = new WorkTicket();
                Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
                DataSet ds = new DataSet();
                //if (TaskDepID == 0)
                    ds = dal.GetWorkListByPW(TaskID);
                //else
                    //ds = dal.GetDepWorkListByPW(TaskDepID);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.Tables[0].Columns.Add("EmpDate", typeof(string));
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        if (ds.Tables[0].Rows[i]["DateTime"].ToString() != "" && (DateTime)(ds.Tables[0].Rows[i]["DateTime"]) != DateTime.Parse("1900-1-1"))
                        {
                            ds.Tables[0].Rows[i]["EmpDate"] = ds.Tables[0].Rows[i]["EmployeeName"].ToString() + "/" + ((DateTime)(ds.Tables[0].Rows[i]["DateTime"])).ToString();
                        }
                        else
                            ds.Tables[0].Rows[i]["EmpDate"] = " ";
                    }
                }
                DataTable dtPWI = new DataTable();
                if (TaskDepID == 0)
                {
                    dtPWI = bllPWI.GetProWorkListByPW(PWMID, MaterielID).Tables[0];
                }
                else
                {
                    Hownet.BLL.DepartmentTaskMain bllDTM = new DepartmentTaskMain();
                    Hownet.Model.DepartmentTaskMain modDtm = bllDTM.GetModel(TaskDepID);
                    dtPWI = bllPWI.GetProWorkListByPW(modDtm.PWID, MaterielID).Tables[0];
                }
                DataTable dt = bllWT.GetWorkList(TaskID, TaskDepID).Tables[0].Copy();
                if (dtPWI.Rows.Count > 0)
                {
                    for (int i = 0; i < dtPWI.Rows.Count; i++)
                    {
                        try
                        {
                            dt.Columns.Add(dtPWI.Rows[i]["WorkingName"].ToString(), typeof(string));
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                object box = dt.Rows[j]["箱号"];
                                object wor = dtPWI.Rows[i]["ID"];
                                DataRow[] drs = ds.Tables[0].Select("(MainID=" + dt.Rows[j]["ID"] + ") And (WorkingID=" + dtPWI.Rows[i]["WorkingID"] + ")");
                                if (drs.Length > 0)
                                {
                                    object obj = drs[0]["EmpDate"];
                                    dt.Rows[j][dtPWI.Rows[i]["WorkingName"].ToString()] = drs[0]["EmpDate"];
                                }
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                DataSet dsss = new DataSet();
                dsss.Tables.Add(dt);
                return dsss;
            }
            catch (Exception ex)
            {
                return new DataSet();
            }
        }
        public void AddPayInfo(int MaterielID, int InfoID, string oderNum)
        {
            dal.AddPayInfo(MaterielID, InfoID, oderNum);
        }
        public DataSet GetWorkingByTicketID(int GroupBy, int TicketID)
        {
            return dal.GetWorkingByTicketID(GroupBy, TicketID);
        }
        public string CountAmount(int EmpID, DateTime dt,bool IsShowMoney)
        {
            return dal.CountAmount(EmpID, dt,IsShowMoney);
        }
        public string CountAmountByWorking(int EmpID, DateTime dt, bool IsShowMoney, int WorkingID)
        {
            return dal.CountAmountByWorking(EmpID, dt, IsShowMoney, WorkingID);
        }
        public DataSet GetKey(int TicketID, int WorkOrder, int SizeID, int ColorID)
        {
            return dal.GetKey(TicketID, WorkOrder, SizeID, ColorID);
        }
        public DateTime GetDateTime()
        {
            return dal.GetDateTime();
        }
        public string GetEmployee(int EmpID, int typeID, DateTime dt, bool IsShowMoney)
        {
            return dal.GetEmployee(EmpID, typeID, dt,IsShowMoney);
        }
        public DataSet GetEmployeeNum(int EmpID, int typeID)
        {
            return dal.GetEmployeeNum(EmpID, typeID);
        }
        public string GetEmpSum(int EmpID, DateTime dt1, DateTime dt2, bool IsShowMoney)
        {
            return dal.GetEmpSum(EmpID, dt1, dt2, IsShowMoney);
        }
                /// <summary>
        /// 整箱全为一个人完成时，根据条码更新工票明细
        /// </summary>
        /// <param name="ID">工票明细表ID，为条码录入</param>
        /// <param name="EmployeeID">交工票的员工</param>
        /// <param name="dt">回收日期</param>
        /// <returns></returns>
        public void GetBarBack(int ID, int EmployeeID, DateTime dt, int BackID)
        {
            dal.GetBarBack(ID, EmployeeID, dt, BackID);
        }
        /// <summary>
        /// 获取分前后道打印时的各道明细
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="GroupID"></param>
        /// <returns></returns>
        public DataSet GetFristReport(int TaskID, int GroupID)
        {
            return dal.GetFristReport(TaskID, GroupID);
        }
        public DataSet GetGroupColorSize(int TaskID, int ColorID, int SizeID, int ColorOneID, int ColorTwoID)
        {
            return dal.GetGroupColorSize(TaskID, ColorID, SizeID,ColorOneID,ColorTwoID);
        }
          /// <summary>
        /// 返回汇总的分色号完成情况
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <returns></returns>
        public DataSet GetSUMCS(DateTime dt1, DateTime dt2, int MatID, int PWID, int ColorID, int SizeID, int ColorOneID, int ColorTwoID)
        {
            return dal.GetSUMCS(dt1, dt2, MatID, PWID, ColorID, SizeID, ColorOneID, ColorTwoID);
        }
               /// <summary>
        /// 返回汇总的完成情况
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <param name="MatID"></param>
        /// <param name="PWID"></param>
        /// <returns></returns>
        public DataSet GetSUMNotCS(DateTime dt1, DateTime dt2, int MatID, int PWID)
        {
            return dal.GetSUMNotCS(dt1, dt2, MatID, PWID);
        }
        public DataSet GetWorkFishByTaskID(int TaskID)
        {
            return dal.GetWorkFishByTaskID(TaskID);
        }
        public DataSet GetWorking(int MaterielID, int BrandID, int ColorID, int SizeID)
        {
            return dal.GetWorking(MaterielID,BrandID, ColorID, SizeID);
        }
        public bool CheckNotWork(int TaskID, int dtmID)
        {
            return dal.CheckNotWork(TaskID, dtmID);
        }
        public void DeleteTicket(int TaskID, int DTMID)
        {
            dal.DeleteTicket(TaskID, DTMID);
        }
                /// <summary>
        /// 修改某份货的未完成工序数量
        /// </summary>
        /// <param name="MainID"></param>
        /// <param name="Amount"></param>
        public void UpNoWorkingAmount(int MainID, int Amount, int GroupBy)
        {
            dal.UpNoWorkingAmount(MainID, Amount,GroupBy);
        }
        public string UpWorkEmp(int MainID, string WorkingName,int EmpID)
        {
            string aaa = string.Empty;
            Hownet.BLL.Working bllW = new Working();
            
            DataTable dtW = bllW.GetList("(Name='" + WorkingName + "')").Tables[0];
            if (dtW.Rows.Count > 0)
            {
                DataTable dt = dal.GetList("(MainID=" + MainID + ") And (WorkingID=" + dtW.Rows[0]["ID"] + ")").Tables[0];
                if (dt.Rows.Count ==1)
                {
                    Hownet.Model.WorkTicketInfo modWTI = GetModel(Convert.ToInt32(dt.Rows[0]["ID"]));
                    modWTI.EmployeeID = EmpID;
                    modWTI.DateTime = DateTime.Now;
                    Update(modWTI);

                    Hownet.BLL.WorkTicket bllWT = new WorkTicket();
                    Hownet.BLL.ProductTaskMain bllPTM=new ProductTaskMain();
                    
                    Hownet.Model.WorkTicket modWT = bllWT.GetModel(modWTI.MainID);
                    Hownet.Model.ProductTaskMain modPTM=bllPTM.GetModel(modWT.TaskID);
                    Hownet.BLL.PayInfo bllPI = new PayInfo();
                    Hownet.Model.PayInfo modPI = new Hownet.Model.PayInfo();
                    modPI.A = 3;
                    modPI.Amount = modWTI.Amount;
                    modPI.BoxNum = modWT.BoxNum;
                    modPI.BreakID = 1;
                    modPI.ColorID = modWT.ColorID;
                    modPI.DateTime = DateTime.Now;
                    modPI.EmployeeID = EmpID;
                    modPI.ID = 0;
                    modPI.IsDay = false;
                    modPI.IsSum = false;
                    modPI.MaterielID = modPTM.MaterielID;
                    modPI.OderNum = modPTM.DateTime.ToString("yyyyMMdd") + modPTM.Num.ToString().PadLeft(3, '0');
                    modPI.Price = 0;
                    modPI.ProductWorkingID = modWTI.PWorkingInfoID;
                    modPI.SizeID = modWT.SizeID;
                    modPI.WorkingID = modWTI.WorkingID;
                    modPI.WorkticketInfoID = modWTI.ID;
                    bllPI.Add(modPI);
                    aaa = DateTime.Now.ToString();
                }
            }
            return aaa;
        }
        public void AddPayInfoByID(int WTIID)
        {
            dal.AddPayInfoByID(WTIID);
        }
        public int GetID(int TaskID, int BoxNum, string WorkingName,int SizeID)
        {
            return dal.GetID(TaskID, BoxNum, WorkingName,SizeID);
        }
        /// <summary>
        /// 返回 某员工之前最后一次刷卡时间
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public DateTime GetLastDate(int EmployeeID)
        {
            return dal.GetLastDate(EmployeeID);
        }
        /// <summary>
        /// 返回某制某颜色、尺码的未领数量，即第一个工序的未完成数量
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <param name="TopID"></param>
        /// <param name="PWIID"></param>
        /// <returns></returns>
        public int GetNotAmountByOrders(int TaskID, int ColorID, int SizeID, int WorkingID)
        {
            return dal.GetNotAmountByOrders(TaskID, ColorID, SizeID, WorkingID);
        }
        /// <summary>
        /// 返回某款号某颜色、尺码的未领数量，即第一个工序的未完成数量
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="ColorID"></param>
        /// <param name="SizeID"></param>
        /// <param name="TopID"></param>
        /// <param name="PWIID"></param>
        /// <returns></returns>
        public int GetNotAmountByMateriel(DateTime dt1,DateTime dt2, int MaterielID, int ColorID, int SizeID, int WorkingID)
        {
            return dal.GetNotAmountByMateriel(dt1,dt2, MaterielID, ColorID, SizeID, WorkingID);
        }
        public DataSet GetStringWorkFishByTaskID(int TaskID)
        {
            return dal.GetStringWorkFishByTaskID(TaskID);
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

