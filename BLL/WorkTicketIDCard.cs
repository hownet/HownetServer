using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类WorkTicketIDCard 的摘要说明。
	/// </summary>
	public class WorkTicketIDCard
	{
		private readonly Hownet.DAL.WorkTicketIDCard dal=new Hownet.DAL.WorkTicketIDCard();
		public WorkTicketIDCard()
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
		public int  Add(Hownet.Model.WorkTicketIDCard model)
		{
			return dal.Add(model);
		}
        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDCard> li = DataTableToList(dt);
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
		public void Update(Hownet.Model.WorkTicketIDCard model)
		{
			dal.Update(model);
		}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDCard> li = DataTableToList(dt);
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
		public Hownet.Model.WorkTicketIDCard GetModel(int ID)
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
		public List<Hownet.Model.WorkTicketIDCard> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.WorkTicketIDCard> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.WorkTicketIDCard> modelList = new List<Hownet.Model.WorkTicketIDCard>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.WorkTicketIDCard model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.WorkTicketIDCard();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    if (dt.Rows[n]["TicketID"].ToString() != "")
                    {
                        model.TicketID = int.Parse(dt.Rows[n]["TicketID"].ToString());
                    }
                    model.IDCardNo =Convert.ToInt64( dt.Rows[n]["IDCardNo"]);//.ToString().Trim();
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsEnd"].ToString() == "1") || (dt.Rows[n]["IsEnd"].ToString().ToLower() == "true"))
                        {
                            model.IsEnd = true;
                        }
                        else
                        {
                            model.IsEnd = false;
                        }
                    }
                    if (dt.Rows[n]["GroupBy"].ToString() != "")
                    {
                        model.GroupBy = int.Parse(dt.Rows[n]["GroupBy"].ToString());
                    }
                    if (dt.Rows[n]["TaskID"].ToString() != "")
                    {
                        model.TaskID = int.Parse(dt.Rows[n]["TaskID"].ToString());
                    }
                    if (dt.Rows[n]["FishWork"].ToString() != "")
                    {
                        if ((dt.Rows[n]["FishWork"].ToString() == "1") || (dt.Rows[n]["FishWork"].ToString().ToLower() == "true"))
                        {
                            model.FishWork = true;
                        }
                        else
                        {
                            model.FishWork = false;
                        }
                    }
                    model.Num = dt.Rows[n]["Num"].ToString();
                    model.MaterielName = dt.Rows[n]["MaterielName"].ToString();
                    model.ColorName = dt.Rows[n]["ColorName"].ToString();
                    model.SizeName = dt.Rows[n]["SizeName"].ToString();
                    if (dt.Rows[n]["ColorID"].ToString() != "")
                    {
                        model.ColorID = int.Parse(dt.Rows[n]["ColorID"].ToString());
                    }
                    if (dt.Rows[n]["SizeID"].ToString() != "")
                    {
                        model.SizeID = int.Parse(dt.Rows[n]["SizeID"].ToString());
                    }
                    if (dt.Rows[n]["BoxNum"].ToString() != "")
                    {
                        model.BoxNum = int.Parse(dt.Rows[n]["BoxNum"].ToString());
                    }
                    if (dt.Rows[n]["MaterielID"].ToString() != "")
                    {
                        model.MaterielID = int.Parse(dt.Rows[n]["MaterielID"].ToString());
                    }
                    model.ColorOneName = dt.Rows[n]["ColorOneName"].ToString();
                    model.ColorTwoName = dt.Rows[n]["ColorTwoName"].ToString();
                    if (dt.Rows[n]["ColorOneID"].ToString() != "")
                    {
                        model.ColorOneID = int.Parse(dt.Rows[n]["ColorOneID"].ToString());
                    }
                    if (dt.Rows[n]["ColorTwoID"].ToString() != "")
                    {
                        model.ColorTwoID = int.Parse(dt.Rows[n]["ColorTwoID"].ToString());
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
        public DataSet GetView(int TaskID, int OneAmount)
        {
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            DataTable dt = bllWT.GetView(TaskID,OneAmount).Tables[0];
            DataTable dtPwi = new DataTable();
            dtPwi = bllPWI.GetGroup(TaskID,OneAmount).Tables[0];
            DataTable dtInfo = dal.GetList("(TaskID=" + TaskID + ")").Tables[0];
            if (dtPwi.Rows.Count > 0)
            {
                for (int i = 0; i < dtPwi.Rows.Count; i++)
                {
                    dt.Columns.Add(dtPwi.Rows[i]["GroupBy"].ToString(), typeof(int));
                }
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dtPwi.Rows.Count; j++)
                {
                    DataRow[] drs = dtInfo.Select("(TicketID=" + dt.Rows[i]["ID"] + ") and (GroupBy=" + dtPwi.Rows[j]["GroupBy"] + ")");
                    if (drs.Length > 0)
                        dt.Rows[i][dtPwi.Rows[j]["GroupBy"].ToString()] = drs[0]["IDCardNo"];
                }
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt.Copy());
            return ds;
        }
        /// <summary>
        /// 真为已使用未收回，假为未使用
        /// </summary>
        /// <param name="CardID"></param>
        /// <returns>真为已使用未收回，假为未使用</returns>
        public DataSet CheckCard(int CardID,int TaskID)
        {
            return dal.CheckCard(CardID,TaskID);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByID(int ID)
        {
            dal.Update(ID);
        }
        public DataSet GetListByCardID(int CardID)
        {
            return dal.GetListByCardID(CardID);
        }
        public void UpdateFishWork(int ID)
        {
            dal.UpdateFishWork(ID);
        }
        public DataSet GetAllListByCardID(int CardID)
        {
            return dal.GetAllListByCardID(CardID);
        }
        public DataSet GetAllListByTicketID(int TicketID, int GroupBy)
        {
            return dal.GetAllListByTicketID(TicketID, GroupBy);
        }
        public DataSet GetdtMain()
        {
            DataTable dtMain = new DataTable();
            dtMain.TableName = "dtMain";
            dtMain.Columns.Add("ID", typeof(int));//工票发卡表ID
            dtMain.Columns.Add("CardID", typeof(int));//箱头卡号
            dtMain.Columns.Add("No", typeof(int));//机器号
            dtMain.Columns.Add("Date", typeof(DateTime));//时间
            dtMain.Columns.Add("TicketID", typeof(int));//工票分箱ID
            dtMain.Columns.Add("WorkingID", typeof(int));//等记录的工序ID
            dtMain.Columns.Add("InfoID", typeof(int));//工票明细表ID，指当前工人所要记录的ID
            dtMain.Columns.Add("MaterielID", typeof(int));//款号
            dtMain.Columns.Add("OderNum", typeof(string));//箱号
            dtMain.Columns.Add("GroupBy", typeof(int));//卡号分组
            dtMain.Columns.Add("MaterielName", typeof(string));//款号
            dtMain.Columns.Add("SizeName", typeof(string));//尺码
            dtMain.Columns.Add("ColorName", typeof(string));//颜色
            dtMain.Columns.Add("Amount", typeof(int));//数量
            dtMain.Columns.Add("EmployeeID", typeof(int));//员工ID
            dtMain.Columns.Add("EmployeeName", typeof(string));
            dtMain.Columns.Add("IsEnd", typeof(bool));//当前未完成工序，是否为该组最后一道
            dtMain.Columns.Add("WorkingName", typeof(string));//等记录的工序名，与WorkingID关联，如果员工刷卡记录之后，更新为下一道等记录的工序
            dtMain.Columns.Add("WorkTypeID", typeof(int));//工序的所属工种
            dtMain.Columns.Add("TaskNum", typeof(string));
            dtMain.Columns.Add("MacAddress", typeof(string));
            dtMain.Columns.Add("WorkingList", typeof(int));
            dtMain.Columns.Add("EmpSN", typeof(string));
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            ds.Tables.Add(dtMain);
            return ds;
        }
        public DataSet GetEmpWork(int EmployeeID)
        {
            return dal.GetEmpWork(EmployeeID);
        }
        public DataSet GetPaddtMain()
        {
            DataTable dtMain = new DataTable();
            dtMain.TableName = "dtMain";
            dtMain.Columns.Add("ID", typeof(int));//工票发卡表ID
            dtMain.Columns.Add("CardID", typeof(int));//箱头卡号
            dtMain.Columns.Add("No", typeof(int));//机器号
            dtMain.Columns.Add("Date", typeof(DateTime));//时间
            dtMain.Columns.Add("TicketID", typeof(int));//工票分箱ID
            dtMain.Columns.Add("WorkingID", typeof(int));//等记录的工序ID
            dtMain.Columns.Add("InfoID", typeof(int));//工票明细表ID，指当前工人所要记录的ID
            dtMain.Columns.Add("MaterielID", typeof(int));//款号
            dtMain.Columns.Add("OderNum", typeof(string));//箱号
            dtMain.Columns.Add("GroupBy", typeof(int));//卡号分组
            dtMain.Columns.Add("MaterielName", typeof(string));//款号
            dtMain.Columns.Add("SizeName", typeof(string));//尺码
            dtMain.Columns.Add("ColorName", typeof(string));//颜色
            dtMain.Columns.Add("Amount", typeof(int));//数量
            dtMain.Columns.Add("EmployeeID", typeof(int));//员工ID
            dtMain.Columns.Add("EmployeeName", typeof(string));
            dtMain.Columns.Add("IsEnd", typeof(bool));//当前未完成工序，是否为该组最后一道
            dtMain.Columns.Add("WorkingName", typeof(string));//等记录的工序名，与WorkingID关联，如果员工刷卡记录之后，更新为下一道等记录的工序
            dtMain.Columns.Add("WorkTypeID", typeof(int));//工序的所属工种
            dtMain.Columns.Add("TaskNum", typeof(string));
            dtMain.Columns.Add("MacAddress", typeof(string));
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            ds.Tables.Add(dtMain);
            return ds;
        }
        public int UpIDCardNo(int TicketID, int GroupBy, int IDCardNo, int TaskID)
        {
            return dal.UpIDCardNo(TicketID, GroupBy, IDCardNo, TaskID);
        }
        public DataSet PrintLable(int TaskID, int TicketID, int GroupBy, int ColorID, int SizeID,int OneAmount)
        {
            return dal.PrintLable(TaskID, TicketID, GroupBy, ColorID, SizeID,OneAmount);
        }
        public void DelMore()
        {
            dal.DelMore();
        }
        public DataSet GetWorkOverList(int CardID)
        {
            return dal.GetWorkOverList(CardID);
        }
        public DataSet GetWorkOverListByTicketID(int TicketID)
        {
            return dal.GetWorkOverListByTicketID(TicketID);
        }
        public int GetID(int CardID)
        {
            return dal.GetID(CardID);
        }
         /// <summary>
        /// 用于平板显示的工序完成情况
        /// </summary>
        /// <param name="CardID"></param>
        /// <returns></returns>
        public DataSet GetListForPad(int CardID)
        {
            return dal.GetListForPad(CardID);
        }
        public int GetCountRows()
        {
            return dal.GetCountRows();
        }
        public DataSet PrintQR(int TaskID)
        {
            return dal.PrintQR(TaskID);
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

