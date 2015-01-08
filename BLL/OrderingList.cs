using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类OrderingList 的摘要说明。
    /// </summary>
    public class OrderingList
    {
        private readonly Hownet.DAL.OrderingList dal = new Hownet.DAL.OrderingList();
        public OrderingList()
        { }
        #region  成员方法
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
        public int Add(Hownet.Model.OrderingList model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.OrderingList> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.OrderingList model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.OrderingList> li = DataTableToList(dt);
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
        public Hownet.Model.OrderingList GetModel(int ID)
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
        public List<Hownet.Model.OrderingList> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.OrderingList> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.OrderingList> modelList = new List<Hownet.Model.OrderingList>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.OrderingList model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.OrderingList();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    else
                    {
                        model.ID = 0;
                    }
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    else
                    {
                        model.EmployeeID = 0;
                    }
                    if (dt.Rows[n]["DateTime"].ToString() != "")
                    {
                        model.DateTime = DateTime.Parse(dt.Rows[n]["DateTime"].ToString());
                    }
                    else
                    {
                        model.DateTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderOne"].ToString() != "")
                    {
                        model.OrderOne = int.Parse(dt.Rows[n]["OrderOne"].ToString());
                    }
                    else
                    {
                        model.OrderOne = 0;
                    }
                    if (dt.Rows[n]["DinOne"].ToString() != "")
                    {
                        model.DinOne = int.Parse(dt.Rows[n]["DinOne"].ToString());
                    }
                    else
                    {
                        model.DinOne = 0;
                    }
                    if (dt.Rows[n]["OrderOneTime"].ToString() != "")
                    {
                        model.OrderOneTime = DateTime.Parse(dt.Rows[n]["OrderOneTime"].ToString());
                    }
                    else
                    {
                        model.OrderOneTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["DiningOneTime"].ToString() != "")
                    {
                        model.DiningOneTime = DateTime.Parse(dt.Rows[n]["DiningOneTime"].ToString());
                    }
                    else
                    {
                        model.DiningOneTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderTwo"].ToString() != "")
                    {
                        model.OrderTwo = int.Parse(dt.Rows[n]["OrderTwo"].ToString());
                    }
                    else
                    {
                        model.OrderTwo = 0;
                    }
                    if (dt.Rows[n]["DinTwo"].ToString() != "")
                    {
                        model.DinTwo = int.Parse(dt.Rows[n]["DinTwo"].ToString());
                    }
                    else
                    {
                        model.DinTwo = 0;
                    }
                    if (dt.Rows[n]["OrdeTwoTime"].ToString() != "")
                    {
                        model.OrdeTwoTime = DateTime.Parse(dt.Rows[n]["OrdeTwoTime"].ToString());
                    }
                    else
                    {
                        model.OrdeTwoTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["DiningTwoTime"].ToString() != "")
                    {
                        model.DiningTwoTime = DateTime.Parse(dt.Rows[n]["DiningTwoTime"].ToString());
                    }
                    else
                    {
                        model.DiningTwoTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderThree"].ToString() != "")
                    {
                        model.OrderThree = int.Parse(dt.Rows[n]["OrderThree"].ToString());
                    }
                    else
                    {
                        model.OrderThree = 0;
                    }
                    if (dt.Rows[n]["DinThree"].ToString() != "")
                    {
                        model.DinThree = int.Parse(dt.Rows[n]["DinThree"].ToString());
                    }
                    else
                    {
                        model.DinThree = 0;
                    }
                    if (dt.Rows[n]["OrdeThreeTime"].ToString() != "")
                    {
                        model.OrdeThreeTime = DateTime.Parse(dt.Rows[n]["OrdeThreeTime"].ToString());
                    }
                    else
                    {
                        model.OrdeThreeTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["DiningThreeTime"].ToString() != "")
                    {
                        model.DiningThreeTime = DateTime.Parse(dt.Rows[n]["DiningThreeTime"].ToString());
                    }
                    else
                    {
                        model.DiningThreeTime = DateTime.Parse("1900-1-1");
                    }
                    if (dt.Rows[n]["OrderCount"].ToString() != "")
                    {
                        model.OrderCount = int.Parse(dt.Rows[n]["OrderCount"].ToString());
                    }
                    else
                    {
                        model.OrderCount = 0;
                    }
                    if (dt.Rows[n]["DinCount"].ToString() != "")
                    {
                        model.DinCount = int.Parse(dt.Rows[n]["DinCount"].ToString());
                    }
                    else
                    {
                        model.DinCount = 0;
                    }
                    if (dt.Rows[n]["Money"].ToString() != "")
                    {
                        model.Money = decimal.Parse(dt.Rows[n]["Money"].ToString());
                    }
                    else
                    {
                        model.Money = 0;
                    }
                    if (dt.Rows[n]["IsSum"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsSum"].ToString() == "1") || (dt.Rows[n]["IsSum"].ToString().ToLower() == "true"))
                        {
                            model.IsSum = true;
                        }
                        else
                        {
                            model.IsSum = false;
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
        public DataSet GetOderList(DateTime dt1, DateTime dt2, int DepID, int EmpID)
        {
            DataSet ds = dal.GetOderList(dt1, dt2, DepID, EmpID);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["OrderOneTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["OrderOneTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["DiningOneTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["DiningOneTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["OrdeTwoTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["OrdeTwoTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["DiningTwoTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["DiningTwoTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["OrdeThreeTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["OrdeThreeTime"] = DBNull.Value;
                }
                if (Convert.ToDateTime(ds.Tables[0].Rows[i]["DiningThreeTime"]) == DateTime.Parse("1900-1-1"))
                {
                    ds.Tables[0].Rows[i]["DiningThreeTime"] = DBNull.Value;
                }
            }
            return ds;
        }
        /// <summary>
        /// 获取某段时间的订、就餐总数
        /// </summary>
        /// <param name="dt1">开始日期</param>
        /// <param name="dt2">结束日期</param>
        /// <param name="EmpID">员工ID</param>
        /// <returns></returns>
        public DataSet GetOrderCount(DateTime dt1, DateTime dt2, int EmpID)
        {
            return dal.GetOrderCount(dt1, dt2, EmpID);
        }
        public void CaicMoney(DateTime date)
        {
            DataTable dt = dal.GetIDList(date).Tables[0];
            if (dt.Rows.Count > 0)
            {
                Hownet.BLL.OtherType bllOT = new OtherType();
                List<Hownet.Model.OtherType> list = bllOT.DataTableToList(bllOT.GetTypeList("伙食扣费").Tables[0]);
                decimal ZhaoCan, WuCan, WanCan, NotEat, NotOrder;
                bool IsCaic = false;
                bool IsCaicDay = false;
                bool IsDay = false;
                ZhaoCan = WuCan = WanCan = NotEat = NotOrder = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Name == "早餐")
                        ZhaoCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "午餐")
                        WuCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "晚餐")
                        WanCan = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "订餐后未吃")
                        NotEat = Convert.ToDecimal(list[i].Value);
                    else if (list[i].Name == "未订餐吃饭")
                        NotOrder = Convert.ToDecimal(list[i].Value);
                    else if(list[i].Name == "以下要扣费")
                        IsCaic = (list[i].Value == "1");
                    else if (list[i].Name == "计时不扣正常餐费")
                        IsCaicDay = (list[i].Value == "1");
                }

                if (NotEat > 0 || NotOrder > 0)
                {
                    Hownet.BLL.MiniEmp bllME = new MiniEmp();
                    DataTable dtt = bllME.GetDayList().Tables[0];
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        IsDay = false;
                        if (IsCaicDay)//当有设置了计时不扣正常餐费，并且当前员工为计时工时，IsDay为真
                        {
                            if (dtt.Select("(ID=" + dt.Rows[i]["EmployeeID"] + ")").Length > 0)
                                IsDay = true;
                        }
                        UpMoney(Convert.ToInt32(dt.Rows[i]["ID"]), ZhaoCan, WuCan, WanCan, NotEat, NotOrder, IsCaic, IsDay);
                    }
                }
                else
                {
                    dal.CaicMoneyNotEat(ZhaoCan, WuCan, WanCan, IsCaicDay, date);
                }
            }
        }
        /// <summary>
        /// 计算伙食费
        /// </summary>
        /// <param name="ID">计餐表ID</param>
        /// <param name="ZhaoCan">早餐费用</param>
        /// <param name="WuCan">午餐费用</param>
        /// <param name="WanCan">晚餐费用</param>
        /// <param name="NotEat">有订未吃扣费</param>
        /// <param name="NotOrder">有吃未订扣费</param>
        /// <param name="IsCaic">为真时需扣非正常就餐</param>
        /// <param name="IsDay">为真时计时员工不扣正常就餐</param>
        public void UpMoney(int ID, decimal ZhaoCan, decimal WuCan, decimal WanCan, decimal NotEat, decimal NotOrder, bool IsCaic, bool IsDay)
        {
            Hownet.Model.OrderingList modOL = GetModel(ID);

            modOL.Money = 0;
            if (modOL.OrderOne != modOL.DinOne)
            {
                if (IsCaic)
                {
                    if (modOL.OrderOne == 1)
                        modOL.Money += NotEat;
                    else if (modOL.DinOne == 1)
                        modOL.Money += NotOrder;
                }
                else
                {

                    modOL.Money += ZhaoCan;
                }
            }
            if (modOL.OrderOne == 1 && modOL.DinOne == 1)
            {
                if (!IsDay)
                    modOL.Money += ZhaoCan;
            }
            if (modOL.OrderTwo != modOL.DinTwo)
            {
                if (IsCaic)
                {
                    if (modOL.OrderTwo == 1)
                        modOL.Money += NotEat;
                    else if (modOL.DinTwo == 1)
                        modOL.Money += NotOrder;
                }
                else
                {
                    modOL.Money += WuCan;
                }
            }
            if (modOL.OrderTwo == 1 && modOL.DinTwo == 1)
            {
                if (!IsDay)
                    modOL.Money += WuCan;
            }
            if (modOL.OrderThree != modOL.DinThree)
            {
                if (IsCaic)
                {
                    if (modOL.OrderThree == 1)
                        modOL.Money += NotEat;
                    else if (modOL.DinThree == 1)
                        modOL.Money += NotOrder;
                }
                else
                {
                    modOL.Money += WanCan;
                }
            }
            if (modOL.OrderThree == 1 && modOL.DinThree == 1)
            {
                if (!IsDay)
                    modOL.Money += WanCan;
            }
            Update(modOL);
        }
        public decimal GetMoney(int EmployeeID, DateTime dtOne, DateTime dtTwo, int AllowedCount, decimal ErrorMoney,decimal ZhaoCan,decimal WuCan,decimal WanCan)
        {
            return dal.GetMoney(EmployeeID, dtOne, dtTwo, AllowedCount, ErrorMoney, ZhaoCan, WuCan, WanCan);
        }
        public void UpIsSum(int IsSum, DateTime dtOne, DateTime dtTwo)
        {
            dal.UpIsSum(IsSum, dtOne, dtTwo);
        }
        /// <summary>
        /// 计算只需订餐的伙食费
        /// </summary>
        /// <param name="date"></param>
        public void CaicMoneyNoEat(DateTime date)
        {
             DataTable dt = dal.GetIDList(date).Tables[0];
             if (dt.Rows.Count > 0)
             {
                 Hownet.BLL.OtherType bllOT = new OtherType();
                 List<Hownet.Model.OtherType> list = bllOT.DataTableToList(bllOT.GetTypeList("伙食扣费").Tables[0]);
                 decimal ZhaoCan, WuCan, WanCan, NotEat, NotOrder;
                 bool IsCaic = false;
                 bool IsCaicDay = false;
                 bool IsDay = false;
                 ZhaoCan = WuCan = WanCan = NotEat = NotOrder = 0;
                 for (int i = 0; i < list.Count; i++)
                 {
                     if (list[i].Name == "早餐")
                         ZhaoCan = Convert.ToDecimal(list[i].Value);
                     if (list[i].Name == "午餐")
                         WuCan = Convert.ToDecimal(list[i].Value);
                     else if (list[i].Name == "晚餐")
                         WanCan = Convert.ToDecimal(list[i].Value);
                     //else if (list[i].Name == "订餐后未吃")
                     //    NotEat = Convert.ToDecimal(list[i].Value);
                     //else if (list[i].Name == "未订餐吃饭")
                     //    NotOrder = Convert.ToDecimal(list[i].Value);
                     //else if (list[i].Name == "以下要扣费")
                     //    IsCaic = (list[i].Value == "1");
                     else if (list[i].Name == "计时不扣正常餐费")
                         IsCaicDay = (list[i].Value == "1");
                 }
                 dal.CaicMoneyNotEat(ZhaoCan, WuCan, WanCan, IsDay, date);
             }
        }
         /// <summary>
        /// 获取某天某餐的订餐情况及各桌的订桌人数。
        /// </summary>
        /// <param name="date"></param>
        /// <param name="CanBie"></param>
        /// <returns></returns>
        public DataSet GetTabeList(DateTime date, string CanBie)
        {
            return dal.GetTabeList(date, CanBie);
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

