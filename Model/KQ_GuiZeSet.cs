using System;
namespace Hownet.Model
{
	/// <summary>
	/// KQ_GuiZeSet:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KQ_GuiZeSet
	{
		public KQ_GuiZeSet()
		{}
		#region Model
		/// <summary>
		/// A，用于标识是否被修改
		/// </summary>
		public int A
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set;
			get;
		}
        /// <summary>
        /// 上午上班时间
        /// </summary>
        public string OneTime
        {
            set;
            get;
        }
        /// <summary>
        /// 上午上班最早签到
        /// </summary>
        public string OneTimeUp
        {
            set;
            get;
        }
        /// <summary>
        /// 上午上班最晚签到
        /// </summary>
        public string OneTimeLast
        {
            set;
            get;
        }
        /// <summary>
        /// 上午下班时间
        /// </summary>
        public string TwoTime
        {
            set;
            get;
        }
        /// <summary>
        /// 上午下班最早签退
        /// </summary>
        public string TwoTimeUp
        {
            set;
            get;
        }
        /// <summary>
        /// 上午下班最晚签退
        /// </summary>
        public string TwoTimeLast
        {
            set;
            get;
        }
        /// <summary>
        /// 下午上班时间
        /// </summary>
        public string ThreeTime
        {
            set;
            get;
        }
        /// <summary>
        /// 下午上班最早签到
        /// </summary>
        public string ThreeTimeUp
        {
            set;
            get;
        }
        /// <summary>
        /// 下午上班最晚签退
        /// </summary>
        public string ThreeTimeLast
        {
            set;
            get;
        }
        /// <summary>
        /// 下午下班时间
        /// </summary>
        public string FourTime
        {
            set;
            get;
        }

        /// <summary>
        /// 下午下班最早签退
        /// </summary>
        public string FourTimeUp
        {
            set;
            get;
        }
        /// <summary>
        /// 下午下班最晚签退
        /// </summary>
        public string FourTimeLast
        {
            set;
            get;
        }
        /// <summary>
        /// 加班上班时间
        /// </summary>
        public string FiveTime
        {
            set;
            get;
        }
        /// <summary>
        /// 加班上班最早签到
        /// </summary>
        public string FiveTimeUp
        {
            set;
            get;
        }
        /// <summary>
        /// 加班上班早晚签到
        /// </summary>
        public string FiveTimeLast
        {
            set;
            get;
        }
        /// <summary>
        /// 加班下班时间
        /// </summary>
        public string SixTime
        {
            set;
            get;
        }
        /// <summary>
        /// 加班下班最早签到
        /// </summary>
        public string SixTimeUp
        {
            set;
            get;
        }
        /// <summary>
        /// 加班下班最晚签到
        /// </summary>
        public string SixTimeLast
        {
            set;
            get;
        }
        /// <summary>
        /// 加班签退晚于此时按实际时间计
        /// </summary>
        public string SixLast
        {
            set;
            get;
        }
        /// <summary>
        /// 加班计迟到
        /// </summary>
        public bool SixCD
        {
            set;
            get;
        }
        /// <summary>
        /// 加班计早退
        /// </summary>
        public bool SixZT
        {
            set;
            get;
        }
        /// <summary>
        /// 加班计旷工
        /// </summary>
        public bool SixKG
        {
            set;
            get;
        }
        /// <summary>
        /// 未签到时处理
        /// </summary>
        public int NoQD
        {
            set;
            get;
        }
        /// <summary>
        /// 未签退时处理
        /// </summary>
        public int NoQT
        {
            set;
            get;
        }
        /// <summary>
        /// 一个班次最少分钟数
        /// </summary>
        public int OneWor
        {
            set;
            get;
        }
		#endregion Model

	}
}

