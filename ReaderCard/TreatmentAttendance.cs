using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class TreatmentAttendance
    {
        DateTime dt;


        Int64 CardID;
        string NID = string.Empty;
        DataTable dtAR;
        Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
        Hownet.BLL.AttendanceRecords bllAR = new Hownet.BLL.AttendanceRecords();
        Hownet.Model.AttendanceRecords modAR;
        public TreatmentAttendance(string Nid, string CID)
        {
            NID = Nid;
            CardID = int.Parse(CID);

        }
        public string TrAtt()
        {
            try
            {
                DateTime dt = DateTime.Now;
                string mes = string.Empty;
                DataRow[] drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CardID + ")");//是否有对应员工，没有就再次查询数据库，以添加新员工，如仍没有，见则转为查询是否为箱头卡
                if (drEm.Length == 0)
                {
                    BasicTable.dtEmployee = BasicTable.bllME.GetView().Tables[0];
                    drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CardID + ")");
                    if (drEm.Length == 0)
                    {
                        mes = "2," + NID + ",卡号错误！";
                        return mes;
                    }
                }
                int EmployeeID = int.Parse(drEm[0]["ID"].ToString());
                string EmployeeName = drEm[0]["Name"].ToString();
                DataRow[] drs;
                if (dt.Hour < 6)
                    dtAR = bllAR.GetList("(EmployeeID=" + EmployeeID + ") And (DateDay='" + dt.Date.AddDays(-1) + "')").Tables[0];
                else
                    dtAR = bllAR.GetList("(EmployeeID=" + EmployeeID + ") And (DateDay='" + dt.Date + "')").Tables[0];
                long one = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='One')")[0]["Value"].ToString()).Ticks;
                long lone = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lOne')")[0]["Value"].ToString()).Ticks;
                long two = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='Two')")[0]["Value"].ToString()).Ticks;
                long ltwo = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lTwo')")[0]["Value"].ToString()).Ticks;
                long three = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='Three')")[0]["Value"].ToString()).Ticks;
                long lthree = Convert.ToDateTime(dt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lThree')")[0]["Value"].ToString()).Ticks;
                if (lthree < three)
                {
                    lthree = Convert.ToDateTime(dt.AddDays(1).Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lThree')")[0]["Value"].ToString()).Ticks;
                }

                long now = dt.Ticks;
                long[] longs = new long[] { one, lone, two, ltwo, three, lthree };
                long tem = 9223372036854775806;
                int temName = 0;
                for (int i = 0; i < longs.Length; i++)
                {
                    if (now - longs[i] > 0)
                    {
                        if ((now - longs[i]) < tem)
                        {
                            tem = now - longs[i];
                            temName = i;
                        }
                    }
                    else
                    {
                        if ((now - longs[i]) * -1 < tem)
                        {
                            tem = (now - longs[i]) * -1;
                            temName = i;
                        }
                    }
                }
                //int a = int.Parse(dt.Hour.ToString().PadLeft(2, '0') + dt.Minute.ToString().PadLeft(2, '0'));
                //int b = 9999;
                //int c = 0;
                //int d = 0;
                //int h = dt.Hour;
                //int m = dt.Minute;
                //if (m == 0)//如果是整点，换为上一小时60分钟
                //{
                //    h -= 1;
                //    m = 60;
                //}
                //int ah, am;
                //for (int i = 0; i < BasicTable.dtAttRules.Rows.Count; i++)
                //{
                //    string[] ss = BasicTable.dtAttRules.Rows[i]["Value"].ToString().Split(':');//班次设置
                //    ah = int.Parse(ss[0]);
                //    am = int.Parse(ss[1]);
                //    if (am == 0)
                //    {
                //        ah -= 1;
                //        am = 60;
                //    }
                //    d = int.Parse(Math.Abs(h - ah).ToString().PadLeft(2, '0') + Math.Abs(m - am).ToString().PadLeft(2, '0'));
                //    if (d < b)
                //    {
                //        b = d;
                //        c = i;
                //    }
                //}

                string atTime = string.Empty;
                //  string otName = BasicTable.dtAttRules.Rows[c]["Name"].ToString();
                string timeFileds = string.Empty;
                if (temName == 0)
                {
                    atTime = "上午上班";
                    timeFileds = "TimeOne";
                }
                else if (temName == 1)
                {
                    atTime = "上午下班";
                    timeFileds = "TimeTwo";
                }
                else if (temName == 2)
                {
                    atTime = "下午上班";
                    timeFileds = "TimeThree";
                }
                else if (temName == 3)
                {
                    atTime = "下午下班";
                    timeFileds = "TimeFour";
                }
                else if (temName == 4)
                {
                    atTime = "加班上班";
                    timeFileds = "TimeFive";
                }
                else if (temName == 5)
                {
                    atTime = "加班下班";
                    timeFileds = "TimeSix";
                }
                if (temName == 0 && dt < Convert.ToDateTime(dt.Date.ToShortDateString() + " 04:00:00"))
                {
                    temName = 5;
                    atTime = "加班下班";
                    timeFileds = "TimeSix";
                }
                bool t = false;
                if (dtAR.Rows.Count == 0)//如果没有当天的刷卡记录
                {
                    DataTable dttt = bllAR.GetYesterday(EmployeeID);
                    if (dttt.Rows.Count > 0)//如果是新记录，判断是否为前一晚通宵的下班卡。
                    {
                        if (Convert.ToDateTime(dttt.Rows[0]["DateDay"]) == dt.Date.AddDays(-1) && Convert.ToBoolean(dttt.Rows[0]["IsTongXiao"]))
                        {
                            t = true;
                            if (dttt.Rows[0]["TimeSix"].ToString().Trim() == string.Empty)
                            {
                                dttt.Rows[0]["TimeSix"] = dt;
                                bllAR.UpdateByDt(dttt);
                                CaicMinute(Convert.ToInt32(dttt.Rows[0]["ID"]));
                                mes = "通宵下班成功";
                            }
                            else
                            {
                                mes = "通宵下班已刷卡";
                            }
                        }
                    }
                    if (!t)
                    {
                        DataRow dr = dtAR.NewRow();
                        dr["EmployeeID"] = EmployeeID;
                        dr["DateDay"] = dt.Date;
                        dr[timeFileds] = dt;//.Hour.ToString().PadLeft(2, '0') + ":" + dt.Minute.ToString().PadLeft(2, '0'); ;
                        dr["A"] = 1;
                        dtAR.Rows.Add(dr);
                        bllAR.AddByDt(dtAR);
                        mes = atTime + " 成功";
                    }
                }
                else
                {

                    if (dtAR.Rows[0][timeFileds].ToString().Trim() != string.Empty)
                    {
                        mes = atTime.Substring(0, 4) + "已刷卡";
                    }
                    else
                    {
                        dtAR.Rows[0][timeFileds] = dt;//.Hour.ToString().PadLeft(2, '0') + ":" + dt.Minute.ToString().PadLeft(2, '0');
                        bllAR.UpdateByDt(dtAR);
                        if (temName == 1 || temName == 3 || temName == 5)
                        {
                            CaicMinute(Convert.ToInt32(dtAR.Rows[0]["ID"]));
                        }

                        mes = atTime.Substring(0, 4) + " 成功";
                    }
                }


                mes = "2," + NID + "," + GetSendOneString(EmployeeName + dt.Hour.ToString() + "时" + dt.Minute.ToString() + "分") + mes;
                return mes;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        private string GetSendOneString(string strMes)
        {
            int l = 15 - gb.GetByteCount(strMes);
            if (l > 0)
            {
                for (int i = 0; i < l; i++)
                {
                    strMes = strMes + " ";
                }
            }
            else
            {
                strMes = strMes.Substring(0, 6);
            }
            return strMes;
        }
        private void CaicMinute(int ID)
        {
            try
            {
                modAR = bllAR.GetModel(ID);

                int a = 0;
                modAR.DayWorkMin = modAR.AbsenteeismMin = modAR.BeLateMin = modAR.OvertimeMin = modAR.LeaveEarlyMin = modAR.LateAtNight = 0;
                Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
                bool IsCaic = Convert.ToInt32(bllOT.GetList("(Name='按实际刷卡计时')").Tables[0].Rows[0]["Value"]) == 1;
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
                        DateTime ddN = Convert.ToDateTime(modAR.DateDay.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lThree')")[0]["Value"]);//晚上加班下班时间，用于判断晚班有深夜班时间
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
                    DateTime ddt = modAR.DateDay;
                    DateTime one = Convert.ToDateTime(ddt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='One')")[0]["Value"].ToString());
                    DateTime lone = Convert.ToDateTime(ddt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lOne')")[0]["Value"].ToString());
                    DateTime two = Convert.ToDateTime(ddt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='Two')")[0]["Value"].ToString());
                    DateTime ltwo = Convert.ToDateTime(ddt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lTwo')")[0]["Value"].ToString());
                    DateTime three = Convert.ToDateTime(ddt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='Three')")[0]["Value"].ToString());
                    DateTime lthree = Convert.ToDateTime(ddt.Date.ToShortDateString() + " " + BasicTable.dtAttRules.Select("(Name='lThree')")[0]["Value"].ToString());
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
            }
            catch (Exception ex)
            {
            }
            bllAR.Update(modAR);
        }
    }
}
