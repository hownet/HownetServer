using System;
namespace Hownet.Model
{
    /// <summary>
    /// 实体类SysTem 。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public class SysTem
    {
        public SysTem()
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
        public string CompanyName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string LinkMan
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Phone
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Fax
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string HDSerie
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Registration
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string BanKName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string BankNO
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string BankUserName
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Direct2Depot
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool Sell4Depot
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool AutoClient
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool BoxOrPic
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int NumType
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string Mobile
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int SellMoney
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool CustOder
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool NotPermissions
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool DepotAllowNegative
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool IsChangedSales
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int BackDepotWorking
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OderOne
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OderTwo
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public int OderThree
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public bool AutoCaicBoardWages
        {
            set;
            get;
        }
        /// <summary>
        /// 默认原料仓库
        /// </summary>
        public int DefaultRawDepot
        {
            set;
            get;
        }
        /// <summary>
        /// 自动收货的成品仓库
        /// </summary>
        public int DefaultDepot
        {
            set;
            get;
        }
        public bool IsShowMoney
        {
            set;
            get;
        }
        public bool CompanyByUser
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal DoubleNotDefaultWTNum
        {
            set;
            get;
        }
        /// <summary>
        /// 订餐间隔时间
        /// </summary>
        public int OrderDays
        {
            set;
            get;
        }
        public bool OrderNeedEat
        {
            set;
            get;
        }
        /// <summary>
        /// 是否检测未完成工序
        /// </summary>
        public bool IsCheckNoWork
        {
            set;
            get;
        }
        /// <summary>
        /// 是否允许普通用户修改数量
        /// </summary>
        public bool IsCanEditAmount
        {
            set;
            get;
        }
        /// <summary>
        /// 服务器是否自动关机
        /// </summary>
        public bool IsAutoClose
        {
            set;
            get;
        }
        /// <summary>
        /// 工资统计，是否不参考“参与统计选项”
        /// </summary>
        public bool IsTicketNotNeedCaic
        {
            set;
            get;
        }
        /// <summary>
        /// 是否显示已离职员工
        /// </summary>
        public bool IsShowOutEmp
        {
            set;
            get;
        }
        /// <summary>
        /// 
        /// </summary>
        public string DataVer
        {
            set;
            get;
        }
        /// <summary>
        /// 材料是否按单采购
        /// </summary>
        public bool MaterielByTask
        {
            set;
            get;
        }
        /// <summary>
        /// 读卡器上数量按工序累计
        /// </summary>
        public bool SumByWorking
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

