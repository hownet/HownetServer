using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
    /// <summary>
    /// 业务逻辑类AttendanceRecords 的摘要说明。
    /// </summary>
    public class AttendanceRecords
    {
        private readonly Hownet.DAL.AttendanceRecords dal = new Hownet.DAL.AttendanceRecords();
        public AttendanceRecords()
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
        public int Add(Hownet.Model.AttendanceRecords model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 增加一条数据,数据源为DataTable
        /// </summary>
        public int AddByDt(DataTable dt)
        {
            List<Hownet.Model.AttendanceRecords> li = DataTableToList(dt);
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
        public void Update(Hownet.Model.AttendanceRecords model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateByDt(DataTable dt)
        {
            List<Hownet.Model.AttendanceRecords> li = DataTableToList(dt);
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
        public Hownet.Model.AttendanceRecords GetModel(int ID)
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
        public List<Hownet.Model.AttendanceRecords> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Hownet.Model.AttendanceRecords> DataTableToList(DataTable dt)
        {
            List<Hownet.Model.AttendanceRecords> modelList = new List<Hownet.Model.AttendanceRecords>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Hownet.Model.AttendanceRecords model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.AttendanceRecords();
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
                    if (dt.Rows[n]["DateDay"].ToString() != "")
                    {
                        model.DateDay = DateTime.Parse(dt.Rows[n]["DateDay"].ToString());
                    }
                    //else
                    //{
                    //    model.DateDay = DateTime.Parse("1900-1-1");
                    //}
                    if (dt.Rows[n]["TimeOne"].ToString() != "")
                    {
                        model.TimeOne = DateTime.Parse(dt.Rows[n]["TimeOne"].ToString());
                    }
                    //else
                    //{
                    //    model.TimeOne = DateTime.Parse("1900-1-1");
                    //}
                    if (dt.Rows[n]["TimeTwo"].ToString() != "")
                    {
                        model.TimeTwo = DateTime.Parse(dt.Rows[n]["TimeTwo"].ToString());
                    }
                    //else
                    //{
                    //    model.TimeTwo = DateTime.Parse("1900-1-1");
                    //}
                    if (dt.Rows[n]["TimeThree"].ToString() != "")
                    {
                        model.TimeThree = DateTime.Parse(dt.Rows[n]["TimeThree"].ToString());
                    }
                    //else
                    //{
                    //    model.TimeThree = DateTime.Parse("1900-1-1");
                    //}
                    if (dt.Rows[n]["TimeFour"].ToString() != "")
                    {
                        model.TimeFour = DateTime.Parse(dt.Rows[n]["TimeFour"].ToString());
                    }
                    //else
                    //{
                    //    model.TimeFour = DateTime.Parse("1900-1-1");
                    //}
                    if (dt.Rows[n]["TimeFive"].ToString() != "")
                    {
                        model.TimeFive = DateTime.Parse(dt.Rows[n]["TimeFive"].ToString());
                    }
                    //else
                    //{
                    //    model.TimeFive = DateTime.Parse("1900-1-1");
                    //}
                    if (dt.Rows[n]["TimeSix"].ToString() != "")
                    {
                        model.TimeSix = DateTime.Parse(dt.Rows[n]["TimeSix"].ToString());
                    }
                    //else
                    //{
                    //    model.TimeSix = DateTime.Parse("1900-1-1");
                    //}
                    if (dt.Rows[n]["BeLateMin"].ToString() != "")
                    {
                        model.BeLateMin = int.Parse(dt.Rows[n]["BeLateMin"].ToString());
                    }
                    else
                    {
                        model.BeLateMin = 0;
                    }
                    if (dt.Rows[n]["LeaveEarlyMin"].ToString() != "")
                    {
                        model.LeaveEarlyMin = int.Parse(dt.Rows[n]["LeaveEarlyMin"].ToString());
                    }
                    else
                    {
                        model.LeaveEarlyMin = 0;
                    }
                    if (dt.Rows[n]["DayWorkMin"].ToString() != "")
                    {
                        model.DayWorkMin = int.Parse(dt.Rows[n]["DayWorkMin"].ToString());
                    }
                    else
                    {
                        model.DayWorkMin = 0;
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
                    if (dt.Rows[n]["AbsenteeismMin"].ToString() != "")
                    {
                        model.AbsenteeismMin = int.Parse(dt.Rows[n]["AbsenteeismMin"].ToString());
                    }
                    else
                    {
                        model.AbsenteeismMin = 0;
                    }
                    if (dt.Rows[n]["OvertimeMin"].ToString() != "")
                    {
                        model.OvertimeMin = int.Parse(dt.Rows[n]["OvertimeMin"].ToString());
                    }
                    else
                    {
                        model.OvertimeMin = 0;
                    }
                    if (dt.Rows[n]["IsWuLianBan"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsWuLianBan"].ToString() == "1") || (dt.Rows[n]["IsWuLianBan"].ToString().ToLower() == "true"))
                        {
                            model.IsWuLianBan = true;
                        }
                        else
                        {
                            model.IsWuLianBan = false;
                        }
                    }
                    if (dt.Rows[n]["IsWanLianBan"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsWanLianBan"].ToString() == "1") || (dt.Rows[n]["IsWanLianBan"].ToString().ToLower() == "true"))
                        {
                            model.IsWanLianBan = true;
                        }
                        else
                        {
                            model.IsWanLianBan = false;
                        }
                    }
                    if (dt.Rows[n]["IsTongXiao"].ToString() != "")
                    {
                        if ((dt.Rows[n]["IsTongXiao"].ToString() == "1") || (dt.Rows[n]["IsTongXiao"].ToString().ToLower() == "true"))
                        {
                            model.IsTongXiao = true;
                        }
                        else
                        {
                            model.IsTongXiao = false;
                        }
                    }
                    if (dt.Rows[n]["LateAtNight"].ToString() != "")
                    {
                        model.LateAtNight = int.Parse(dt.Rows[n]["LateAtNight"].ToString());
                    }
                    else
                    {
                        model.LateAtNight = 0;
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
         /// <summary>
        /// 获得某员工前一天刷卡记录，用于查看是否有通宵
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public DataTable GetYesterday(int EmployeeID)
        {
            return dal.GetYesterday(EmployeeID);
        }
        public DataSet GetSumRecords(DateTime dtOne, DateTime dtTwo)
        {
            return dal.GetSumRecords(dtOne, dtTwo);
        }
        public void CaicMinute(int ID)
        {
            try
            {
                Hownet.Model.AttendanceRecords modAR = GetModel(ID);
                modAR.DayWorkMin = modAR.AbsenteeismMin = modAR.BeLateMin = modAR.OvertimeMin = modAR.LeaveEarlyMin =modAR.LateAtNight= 0;
                Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
                DataTable dtAttRules = bllOT.GetTypeList("考勤设置").Tables[0];
                bool IsCaic = Convert.ToInt32(bllOT.GetList("(Name='按实际刷卡计时')").Tables[0].Rows[0]["Value"]) == 1;
                int a = 0;
                if (IsCaic)
                {
                    if (modAR.TimeOne.HasValue && modAR.TimeTwo.HasValue)
                    {
                        TimeSpan ts = (TimeSpan)(modAR.TimeTwo - modAR.TimeOne);
                        a = ts.Hours * 60 + ts.Minutes;
                        if (a > 0)
                            modAR.DayWorkMin += a;
                    }
                    if (modAR.TimeThree.HasValue && modAR.TimeFour.HasValue)
                    {
                        TimeSpan ts = (TimeSpan)(modAR.TimeFour - modAR.TimeThree);
                        a = ts.Hours * 60 + ts.Minutes;
                        if (a > 0)
                            modAR.DayWorkMin += a;
                    }
                    if (modAR.TimeFive.HasValue && modAR.TimeSix.HasValue)
                    {
                        DateTime ddN = Convert.ToDateTime(modAR.DateDay.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='lThree')")[0]["Value"]);//晚上加班下班时间，用于判断晚班有深夜班时间
                        if (!(ddN < (DateTime)(modAR.TimeSix))) //晚上下班提前或正常下班的。
                        {
                            TimeSpan ts = (TimeSpan)(modAR.TimeSix - modAR.TimeFive);
                            a = ts.Hours * 60 + ts.Minutes;
                            if (a > 0)
                                modAR.OvertimeMin = a;
                        }
                        else//超过夜班下班时间的。
                        {
                            TimeSpan ts = (TimeSpan)(ddN - modAR.TimeFive);
                            a = ts.Hours * 60 + ts.Minutes;
                            if (a > 0)
                                modAR.OvertimeMin = a;
                            ts = (TimeSpan)(modAR.TimeSix - ddN);
                            a = ts.Hours * 60 + ts.Minutes;
                            if (a > 0)
                                modAR.LateAtNight = a;
                        }
                    }
                }
                else
                {
                    DateTime dt = modAR.DateDay;
                    DateTime one = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='One')")[0]["Value"].ToString());
                    DateTime lone = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='lOne')")[0]["Value"].ToString());
                    DateTime two = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='Two')")[0]["Value"].ToString());
                    DateTime ltwo = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='lTwo')")[0]["Value"].ToString());
                    DateTime three = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='Three')")[0]["Value"].ToString());
                    DateTime lthree = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='lThree')")[0]["Value"].ToString());
                    if (modAR.TimeOne.HasValue && modAR.TimeTwo.HasValue)
                    {

                        if (modAR.TimeTwo < lone)
                            lone = Convert.ToDateTime(modAR.TimeTwo);
                        if (modAR.TimeOne > one)
                            one = Convert.ToDateTime(modAR.TimeOne);
                        TimeSpan ts = (TimeSpan)(lone - one);
                        a = ts.Hours * 60 + ts.Minutes;
                        if (a > 0)
                            modAR.DayWorkMin += a;
                    }
                    if (modAR.TimeThree.HasValue && modAR.TimeFour.HasValue)
                    {
                        if (modAR.TimeFour < ltwo)
                            ltwo = Convert.ToDateTime(modAR.TimeFour);
                        if (modAR.TimeThree > two)
                            two = Convert.ToDateTime(modAR.TimeThree);
                        TimeSpan ts = (TimeSpan)(ltwo - two);
                        a = ts.Hours * 60 + ts.Minutes;
                        if (a > 0)
                            modAR.DayWorkMin += a;
                    }
                    if (modAR.TimeFive.HasValue && modAR.TimeSix.HasValue)
                    {
                        if (!(lthree < (DateTime)(modAR.TimeSix))) //晚上下班提前或正常下班的。
                        {
                            if (modAR.TimeFive > three)
                                three = Convert.ToDateTime(modAR.TimeFive);
                            TimeSpan ts = (TimeSpan)(modAR.TimeSix - three);
                            a = ts.Hours * 60 + ts.Minutes;
                            if (a > 0)
                                modAR.OvertimeMin = a;
                        }
                        else//超过夜班下班时间的。
                        {
                            if (modAR.TimeFive > three)
                                three = Convert.ToDateTime(modAR.TimeFive);
                            TimeSpan ts = (TimeSpan)(lthree - three);
                            a = ts.Hours * 60 + ts.Minutes;
                            if (a > 0)
                                modAR.OvertimeMin = a;
                            ts = (TimeSpan)(modAR.TimeSix - lthree);
                            a = ts.Hours * 60 + ts.Minutes;
                            if (a > 0)
                                modAR.LateAtNight = a;
                        }
                    }
                }
                Update(modAR);
            }
            catch (Exception ex)
            {
            }
            
            ////try
            ////{
            //Hownet.BLL.OtherType bllOT = new OtherType();
            //DataTable dtAttRules = bllOT.GetTypeList("考勤设置").Tables[0];
            //Hownet.Model.AttendanceRecords modAR = GetModel(ID);
            //modAR.DayWorkMin = modAR.AbsenteeismMin = modAR.BeLateMin = modAR.OvertimeMin = modAR.LeaveEarlyMin = 0;
            //if (modAR.TimeOne.HasValue && modAR.TimeTwo.HasValue)
            //{
            //    TimeSpan ts = (TimeSpan)(modAR.TimeTwo - modAR.TimeOne);
            //    if (ts.Minutes > 0)
            //        modAR.DayWorkMin += ts.Hours * 60 + ts.Minutes;
            //}
            //if (modAR.TimeThree.HasValue && modAR.TimeFour.HasValue)
            //{
            //    TimeSpan ts = (TimeSpan)(modAR.TimeFour - modAR.TimeThree);
            //    if (ts.Minutes > 0)
            //        modAR.DayWorkMin += ts.Hours * 60 + ts.Minutes;
            //}
            //if (modAR.TimeFive.HasValue && modAR.TimeSix.HasValue)
            //{
            //    DateTime ddN = Convert.ToDateTime(modAR.DateDay.Date.ToShortDateString() + " " + dtAttRules.Select("(Name='lThree')")[0]["Value"]);//晚上加班下班时间，用于判断晚班有深夜班时间
            //    if (!(ddN < (DateTime)(modAR.TimeSix))) //晚上下班提前或正常下班的。
            //    {
            //        TimeSpan ts = (TimeSpan)(modAR.TimeSix - modAR.TimeFive);
            //        if (ts.Minutes > 0)
            //            modAR.OvertimeMin = ts.Hours * 60 + ts.Minutes;
            //    }
            //    else//超过夜班下班时间的。
            //    {
            //        TimeSpan ts = (TimeSpan)(ddN - modAR.TimeFive);
            //        if (ts.Minutes > 0)
            //            modAR.OvertimeMin = ts.Hours * 60 + ts.Minutes;
            //        ts = (TimeSpan)(modAR.TimeSix - ddN);
            //        if (ts.Minutes > 0)
            //            modAR.LateAtNight = ts.Hours * 60 + ts.Minutes;
            //    }
            //}
            ////}
            ////catch (Exception ex)
            ////{
            ////}
            //Update(modAR);

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

