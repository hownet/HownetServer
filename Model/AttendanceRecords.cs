using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类AttendanceRecords 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class AttendanceRecords
    {
        public AttendanceRecords()
        { }
        #region Model
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int EmployeeID
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime DateDay
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeOne
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeTwo
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeThree
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeFour
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeFive
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? TimeSix
        {
            set;
            get;
        }
        /// <summary>
        /// 迟到
        /// </summary>
        public int BeLateMin
        {
            set;
            get;
        }
        /// <summary>
        /// 早退
        /// </summary>
        public int LeaveEarlyMin
        {
            set;
            get;
        }
        /// <summary>
        /// 白班分钟数
        /// </summary>
        public int DayWorkMin
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsSum
        {
            set;
            get;
        }
        /// <summary>
        /// 旷工分钟数
        /// </summary>
        public int AbsenteeismMin
        {
            set;
            get;
        }
        /// <summary>
        /// 加班分钟数
        /// </summary>
        public int OvertimeMin
        {
            set;
            get;
        }
        /// <summary>
        /// 是否是午连班
        /// </summary>
        public bool IsWuLianBan
        {
            set;
            get;
        }
        /// <summary>
        /// 是否是晚连班
        /// </summary>
        public bool IsWanLianBan
        {
            set;
            get;
        }
        /// <summary>
        /// 是否是通宵
        /// </summary>
        public bool IsTongXiao
        {
            set;
            get;
        }
        /// <summary>
        /// 深夜班时间
        /// </summary>
        public int LateAtNight
        {
            set;
            get;
        }
        public int A
        {
            set;
            get;
        }
        #endregion Model

    }
}

