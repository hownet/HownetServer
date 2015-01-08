using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class BasicTable
    {
        //public static string AttendanceNID
        //{
        //    set;
        //    get;
        //}
        //public static string[] NID
        //{
        //    set;
        //    get;
        //}
        public static Hownet.Model.WorkTicketInfo modWTI ;
        public static int BackDepotWorkingID
        {
            set;
            get;
        }
        private static DataTable _dt;
        public static DataTable dt
        {
            get
            {
                if(_dt==null|| _dt.Columns.Count==0)
                {
                    _dt = new DataTable();
                    _dt.Columns.Add("客户端", typeof(string));
                    _dt.Columns.Add("用户名", typeof(string));
                    _dt.Columns.Add("连接时间", typeof(string));
                    _dt.Columns.Add("验证时间", typeof(string));
                    _dt.Columns.Add("用户ID", typeof(string));
                    _dt.Columns.Add("端口号", typeof(string));
                    _dt.Columns.Add("GUID", typeof(string));
                }
                return _dt;
            }
        }
        public static int DefaultDepot
        {
            set;
            get;
        }
        /// <summary>
        /// 考勤规则记录
        /// </summary>
        public static DataTable dtAttRules
        {
            set;
            get;
        }
        
        /// <summary>
        /// 用于刷卡计件时的员工列表
        /// </summary>
        public static DataTable dtEmployee
        {
            set;
            get;
        }
        /// <summary>
        /// 上班时间表
        /// </summary>
        public static DataTable dtWorkTime
        {
            set;
            get;
        }
        /// <summary>
        /// 用于刷卡计件时的箱头卡对应表
        /// </summary>
        public static DataTable dtWTCard
        {
            set;
            get;
        }
        public static DataTable dtWorkType
        {
            set;
            get;
        }
        /// <summary>
        /// 用于记录员工工作明细
        /// </summary>
        public static DataTable dtEmpWorkList
        {
            set;
            get;
        }
        public static bool IsCheckKQ
        {
            set;
            get;
        }
        /// <summary>
        /// 处理刷卡事件时的主表
        /// </summary>
        public static DataTable dtMain
        {
            set;
            get;
        }
        public static DataTable dtCarReaderList
        {
            set;
            get;
        }
        public static DataSet dsPU
        {
            set;
            get;
        }
        public static DataTable dtSysTem
        {
            set;
            get;
        }
        public static Hownet.BLL.WorkTicketIDCard bllWTIDC
        {
            set;
            get;
        }
        public static Hownet.BLL.MiniEmp bllME
        {
            set;
            get;
        }
        public static Hownet.BLL.WorkTicketInfo bllWTI
        {
            set;
            get;
        }
        public static Hownet.BLL.OtherType bllOT
        {
            set;
            get;
        }
        public static Hownet.BLL.AttendanceRecords bllAR
        {
            set;
            get;
        }
        public static Hownet.BLL.SysTem bllST
        {
            set;
            get;
        }
        public static Hownet.BLL.CardReaderList bllCRL
        {
            set;
            get;
        }
        public static Hownet.BLL.WorkType bllWType
        {
            set;
            get;
        }
        public static Hownet.Model.SysTem modST
        {
            set;
            get;

        }
        public static Hownet.BLL.PermissionsUser bllPU
        {
            set;
            get;
        }
        public static bool IsShowMoney
        {
            set;
            get;
        }
        public static string 就餐成功
        {
            set;
            get;
        }
        public static string 重复就餐
        {
            set;
            get;
        }
        public static string 未订吃饭
        {
            set;
            get;
        }
        public static void SetCate()
        {
            Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
            List<Hownet.Model.OtherType> list = bllOT.DataTableToList(bllOT.GetTypeList("伙食扣费").Tables[0]);
            for (int i = 0; i < list.Count; i++)
            {
                 if (list[i].Name == "就餐成功")
                {
                    就餐成功 = list[i].Value;
                }
                else if (list[i].Name == "重复就餐")
                {
                    重复就餐 = list[i].Value;
                }
                else if (list[i].Name == "未订吃饭")
                {
                    未订吃饭 = list[i].Value;
                }
            }
        }
    }
}
