using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类MiniEmp 的摘要说明。
	/// </summary>
	public class MiniEmp
	{
		private readonly Hownet.DAL.MiniEmp dal=new Hownet.DAL.MiniEmp();
		public MiniEmp()
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
		public int  Add(Hownet.Model.MiniEmp model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.MiniEmp> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.MiniEmp model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.MiniEmp> li=DataTableToList(dt);
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
		public Hownet.Model.MiniEmp GetModel(int ID)
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
		public List<Hownet.Model.MiniEmp> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.MiniEmp> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.MiniEmp> modelList = new List<Hownet.Model.MiniEmp>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.MiniEmp model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.MiniEmp();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    model.Name = dt.Rows[n]["Name"].ToString();
                    if (dt.Rows[n]["IntroducerID"].ToString() != "")
                    {
                        model.IntroducerID = int.Parse(dt.Rows[n]["IntroducerID"].ToString());
                    }
                    else
                    {
                        model.IntroducerID = 0;
                    }
                    model.IdentityCard = dt.Rows[n]["IdentityCard"].ToString();
                    if (dt.Rows[n]["Sex"].ToString() != "")
                    {
                        model.Sex = int.Parse(dt.Rows[n]["Sex"].ToString());
                    }
                    else
                    {
                        model.Sex = 0;
                    }
                    model.Sn = dt.Rows[n]["Sn"].ToString();
                    if (dt.Rows[n]["Province"].ToString() != "")
                    {
                        model.Province = int.Parse(dt.Rows[n]["Province"].ToString());
                    }
                    else
                    {
                        model.Province = 0;
                    }
                    model.Address = dt.Rows[n]["Address"].ToString();
                    model.Phone = dt.Rows[n]["Phone"].ToString();
                    if (dt.Rows[n]["AccDate"].ToString() != "")
                    {
                        model.AccDate = DateTime.Parse(dt.Rows[n]["AccDate"].ToString());
                    }
                    else
                    {
                        model.AccDate = DateTime.Parse("1900-1-1");
                    }
                    model.WorkTypeID = dt.Rows[n]["WorkTypeID"].ToString();
                    if (dt.Rows[n]["PayID"].ToString() != "")
                    {
                        model.PayID = int.Parse(dt.Rows[n]["PayID"].ToString());
                    }
                    else
                    {
                        model.PayID = 0;
                    }
                    if (dt.Rows[n]["DimDate"].ToString() != "")
                    {
                        model.DimDate = DateTime.Parse(dt.Rows[n]["DimDate"].ToString());
                    }
                    else
                    {
                        model.DimDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["BedID"].ToString() != "")
                    {
                        model.BedID = int.Parse(dt.Rows[n]["BedID"].ToString());
                    }
                    else
                    {
                        model.BedID = 0;
                    }
                    if (dt.Rows[n]["TableID"].ToString() != "")
                    {
                        model.TableID = int.Parse(dt.Rows[n]["TableID"].ToString());
                    }
                    else
                    {
                        model.TableID = 0;
                    }
                    if (dt.Rows[n]["DepartmentID"].ToString() != "")
                    {
                        model.DepartmentID = int.Parse(dt.Rows[n]["DepartmentID"].ToString());
                    }
                    else
                    {
                        model.DepartmentID = 0;
                    }
                    if (dt.Rows[n]["DegreeID"].ToString() != "")
                    {
                        model.DegreeID = int.Parse(dt.Rows[n]["DegreeID"].ToString());
                    }
                    else
                    {
                        model.DegreeID = 0;
                    }
                    if (dt.Rows[n]["PolityID"].ToString() != "")
                    {
                        model.PolityID = int.Parse(dt.Rows[n]["PolityID"].ToString());
                    }
                    else
                    {
                        model.PolityID = 0;
                    }
                    model.SOSPhone = dt.Rows[n]["SOSPhone"].ToString();
                    model.SOSMan = dt.Rows[n]["SOSMan"].ToString();
                    model.NowAddress = dt.Rows[n]["NowAddress"].ToString();
                    if (dt.Rows[n]["FillDate"].ToString() != "")
                    {
                        model.FillDate = DateTime.Parse(dt.Rows[n]["FillDate"].ToString());
                    }
                    else
                    {
                        model.FillDate = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["FillUser"].ToString() != "")
                    {
                        model.FillUser = int.Parse(dt.Rows[n]["FillUser"].ToString());
                    }
                    else
                    {
                        model.FillUser = 0;
                    }
                    if (dt.Rows[n]["LassMoney"].ToString() != "")
                    {
                        model.LassMoney = decimal.Parse(dt.Rows[n]["LassMoney"].ToString());
                    }
                    else
                    {
                        model.LassMoney = 0;
                    }
                    if (dt.Rows[n]["Royalty"].ToString() != "")
                    {
                        model.Royalty = decimal.Parse(dt.Rows[n]["Royalty"].ToString());
                    }
                    else
                    {
                        model.Royalty = 0;
                    }
                    model.Image = dt.Rows[n]["Image"].ToString();
                    if (dt.Rows[n]["IsUse"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsUse"].ToString() == "1") || (dt.Rows[n]["IsUse"].ToString().ToLower() == "true"))
                        {
                            model.IsUse = true;
                        }
                        else
                        {
                            model.IsUse = false;
                        }
                    }
                    if (dt.Rows[n]["City"].ToString() != "")
                    {
                        model.City = int.Parse(dt.Rows[n]["City"].ToString());
                    }
                    else
                    {
                        model.City = 0;
                    }
                    if (dt.Rows[n]["County"].ToString() != "")
                    {
                        model.County = int.Parse(dt.Rows[n]["County"].ToString());
                    }
                    else
                    {
                        model.County = 0;
                    }
                    model.Remark = dt.Rows[n]["Remark"].ToString();
                    if (dt.Rows[n]["IDCardID"].ToString() != "")
                    {
                        model.IDCardID = Int64.Parse(dt.Rows[n]["IDCardID"].ToString());
                    }
                    if (dt.Rows[n]["IsEnd"].ToString() != "")
                    {
                        model.IsEnd = int.Parse(dt.Rows[n]["IsEnd"].ToString());
                    }
                    else
                    {
                        model.IsEnd = 0;
                    }
                    if (dt.Rows[n]["Deposit"].ToString() != "")
                    {
                        model.Deposit = decimal.Parse(dt.Rows[n]["Deposit"].ToString());
                    }
                    else
                    {
                        model.Deposit = 0;
                    }
                    if (dt.Rows[n]["NeedDeposit"].ToString() != "")
                    {
                        model.NeedDeposit = decimal.Parse(dt.Rows[n]["NeedDeposit"].ToString());
                    }
                    else
                    {
                        model.NeedDeposit = 0;
                    }
                    model.DefaultWorkType = dt.Rows[n]["DefaultWorkType"].ToString();
                    if (dt.Rows[n]["BoardWages"] != null && dt.Rows[n]["BoardWages"].ToString() != "")
                    {
                        model.BoardWages = decimal.Parse(dt.Rows[n]["BoardWages"].ToString());
                    }
                    if (dt.Rows[n]["HeTongDate"] != null && dt.Rows[n]["HeTongDate"].ToString() != "")
                    {
                        model.HeTongDate = DateTime.Parse(dt.Rows[n]["HeTongDate"].ToString());
                    }
                    model.HeTongAmount = dt.Rows[n]["HeTongAmount"].ToString();
                    if (dt.Rows[n]["HeTongDQDate"] != null && dt.Rows[n]["HeTongDQDate"].ToString() != "")
                    {
                        model.HeTongDQDate = DateTime.Parse(dt.Rows[n]["HeTongDQDate"].ToString());
                    }
                    if (dt.Rows[n]["IsCaicTiCheng"] != null && dt.Rows[n]["IsCaicTiCheng"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsCaicTiCheng"].ToString() == "1") || (dt.Rows[n]["IsCaicTiCheng"].ToString().ToLower() == "true"))
                        {
                            model.IsCaicTiCheng = true;
                        }
                        else
                        {
                            model.IsCaicTiCheng = false;
                        }
                    }
                    if (dt.Rows[n]["MaxAmountDay"] != null && dt.Rows[n]["MaxAmountDay"].ToString() != "")
                    {
                        model.MaxAmountDay = int.Parse(dt.Rows[n]["MaxAmountDay"].ToString());
                    }
                    model.BankNO = dt.Rows[n]["BankNO"].ToString();
                    model.BankAccountName = dt.Rows[n]["BankAccountName"].ToString();
                    model.BankName = dt.Rows[n]["BankName"].ToString();
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
        /// 取得非记时的在职工人名单
        /// </summary>
        /// <returns></returns>
        public DataSet GetWorkList()
        {
            return dal.GetWorkList();
        }
                /// <summary>
        /// 取得记时的在职工人名单
        /// </summary>
        /// <returns></returns>
        public DataSet GetDayList()
        {
            return dal.GetDayList();
        }
                /// <summary>
        /// 按ID取出人名
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetName(int ID)
        {
            return dal.GetName(ID);
        }
                /// <summary>
        /// 根据ID取出Sn
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string GetSn(int ID)
        {
            return dal.GetSn(ID);
        }
        /// <summary>
        /// 按编号取出ID
        /// </summary>
        /// <param name="Sn"></param>
        /// <returns></returns>
        public int GetID(string Sn)
        {
            return dal.GetID(Sn);
        }
        public DataSet GetCosts(decimal money)
        {
            return dal.GetCosts(money);
        }
        public DataSet GetView()
        {
            return dal.GetView();
        }
        public DataSet GetViewList()
        {
            DataSet ds = dal.GetViewList();
            Hownet.DAL.WorkType dalWT = new Hownet.DAL.WorkType();
            DataTable dtWT = dalWT.GetList("").Tables[0];
            ds.Tables[0].Columns.Add("WorkTypeName", typeof(string));
            ds.Tables[0].Columns.Add("DefaultWT", typeof(string));
            string ss = string.Empty;
            string dd = string.Empty;
            string nnn = string.Empty;
            string mmm = string.Empty;
            DataRow[] drs;
            try
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    ss = ds.Tables[0].Rows[i]["WorkTypeID"].ToString();
                    dd = ds.Tables[0].Rows[i]["DefaultWorkType"].ToString();
                    nnn = string.Empty;
                    mmm = string.Empty;
                    if (ss.IndexOf(',') > -1)
                    {
                        string[] aaa = ss.Split(',');
                        for (int j = 0; j < aaa.Length; j++)
                        {
                            drs = dtWT.Select("(ID=" + int.Parse(aaa[j]) + ")");
                            if (drs.Length > 0)
                                nnn = nnn + drs[0]["Name"].ToString() + ",";
                            //DataTable dtt = dalWT.GetList("(ID=" + int.Parse(aaa[j]) + ")").Tables[0];
                            //if (dtt.Rows.Count > 0)
                            //    nnn = nnn + dtt.Rows[0]["Name"].ToString() + ",";
                        }
                    }
                    else if (ss.Length > 0)
                    {
                        drs = dtWT.Select("(ID=" + int.Parse(ss) + ")");
                        if (drs.Length > 0)
                            nnn = nnn + drs[0]["Name"].ToString() + ",";
                        //DataTable dtt = dalWT.GetList("(ID=" + int.Parse(ss) + ")").Tables[0];
                        //if (dtt.Rows.Count > 0)
                        //    nnn = nnn + dtt.Rows[0]["Name"].ToString() + ",";
                    }
                    if (nnn.Length > 0)
                        nnn = nnn.Remove(nnn.Length - 1, 1);
                    ds.Tables[0].Rows[i]["WorkTypeName"] = nnn;

                    if (dd.IndexOf(',') > -1)
                    {
                        string[] aaa = dd.Split(',');
                        for (int j = 0; j < aaa.Length; j++)
                        {
                            drs = dtWT.Select("(ID=" + int.Parse(aaa[j]) + ")");
                            if (drs.Length > 0)
                                mmm = mmm + drs[0]["Name"].ToString() + ",";
                            //DataTable dtt = dalWT.GetList("(ID=" + int.Parse(aaa[j]) + ")").Tables[0];
                            //if (dtt.Rows.Count > 0)
                            //    nnn = nnn + dtt.Rows[0]["Name"].ToString() + ",";
                        }
                    }
                    else if (dd.Length > 0)
                    {
                        drs = dtWT.Select("(ID=" + int.Parse(dd) + ")");
                        if (drs.Length > 0)
                            mmm = mmm + drs[0]["Name"].ToString() + ",";
                        //DataTable dtt = dalWT.GetList("(ID=" + int.Parse(ss) + ")").Tables[0];
                        //if (dtt.Rows.Count > 0)
                        //    nnn = nnn + dtt.Rows[0]["Name"].ToString() + ",";
                    }
                    if (mmm.Length > 0)
                        mmm = mmm.Remove(mmm.Length - 1, 1);
                    ds.Tables[0].Rows[i]["DefaultWT"] = mmm;
                }
            }
            catch (Exception ex)
            {
            }
            return ds;
        }
        public string GetMaxSn()
        {
            return dal.GetMaxSn();
        }
        public void UpDeposit(int EmployeeID, decimal Deposit,bool t)
        {
            dal.UpDeposit(EmployeeID, Deposit,t);
        }
        /// <summary>
        /// 返回某期的补贴数量
        /// </summary>
        /// <returns></returns>
        public DataSet GetBuTieList(int PayMainID)
        {
            Hownet.BLL.SysFormula bllSF = new SysFormula();
            Hownet.BLL.Pay bllP = new Pay();
            DataSet ds = new DataSet();
            DataTable dtSF = bllSF.GetBuTieList().Tables[0];//补贴的工种
            int WTID = 0;
            if (dtSF.Rows.Count > 0)
            {
                try
                {
                    WTID = Convert.ToInt32(dtSF.Rows[0]["Value8"]);
                    ds = dal.GetBuTieList(WTID, PayMainID);
                }
                catch (Exception ex)
                {
                }
            }
            ds.Tables[0].Columns.Add("BiLi", typeof(decimal));
            ds.Tables[0].Columns.Add("BuTie", typeof(decimal));
            dtSF.DefaultView.Sort = "Money Desc";
            decimal money = 0;
            for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
            {
                money = Convert.ToDecimal(ds.Tables[0].Rows[j]["Month"]);//该员工当月工资
                for (int i = 0; i < dtSF.DefaultView.Count; i++)//循环找出当月工资大于等于补贴设置的金额
                {
                    if (!(money < Convert.ToDecimal(dtSF.DefaultView[i]["Money"])))
                    {
                        ds.Tables[0].Rows[j]["BiLi"] = dtSF.DefaultView[i]["BiLi"];
                        ds.Tables[0].Rows[j]["BuTie"] = money * Convert.ToDecimal(dtSF.DefaultView[j]["BiLi"]);
                        break;
                    }
                }
            }
            return ds;
        }
          /// <summary>
        /// 已经统计工资的次数
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public int GetCaicPayCount(int EmployeeID)
        {
            return dal.GetCaicPayCount(EmployeeID);
        }
        /// <summary>
        /// 获取某类部门下的所有员工
        /// </summary>
        /// <param name="DepTypeID"></param>
        /// <returns></returns>
        public DataSet GetListByDepTypeID(int DepTypeID)
        {
            return dal.GetListByDepTypeID(DepTypeID);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <param name="TypeID">0为当天，1为当月</param>
        /// <returns></returns>
        public DataSet GetSumAmount(int EmployeeID,int TypeID)
        {
            return dal.GetSumAmount(EmployeeID,TypeID);
        }
        public DataSet GetSumAmountByID(int EmployeeID, DateTime dt1,DateTime dt2)
        {
            return dal.GetSumAmountByID(EmployeeID, dt1,dt2);
        }
        public bool GetSumAmountByEMP(int EmployeeID)
        {
            return dal.GetSumAmountByEMP(EmployeeID);
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

