using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace Host
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service”。
    public class Service : IService
    {
        Hownet.BLL.Materiel bllMat = new Hownet.BLL.Materiel();
        #region IService Members getMsg

        public string getMsg()
        {
            Console.WriteLine("getMsg service has bean statred!");
            return string.Format("现在服务器时间{0}", DateTime.Now);
        }

        #endregion

        #region IService Members setMsg

        public string setMsg(string msg)
        {
            Console.WriteLine("setMsg service has bean started!");
            Console.WriteLine("receive msg:{0}", msg);
            return string.Format("现在服务器时间{0}, 消息内容{1}", DateTime.Now, msg);
        }

        #endregion

        #region IService Members getData

        public Data getData()
        {
            Console.WriteLine("getData service has bean started!");
            Data data = new Data();
            data.Name = "Mush Service";
            data.age = 20;
            data.msg = "This is a data form service_HelloData";
            data.array = new string[3] { "string1", "string2", "string3" };

            return data;
        }

        #endregion

        #region IService Members setData

        public Data setData(Data data)
        {
            Console.WriteLine("setData service has bean started!");
            data.msg = "This MSG has bean changed by service!!!";

            return data;
        }

        #endregion

        #region IService Members GetList

        public DataSet GetList()
        {
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            DataTable dt = new DataTable();
            dt.TableName = "dt";
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "DSF");
            ds.Tables.Add(dt);
            return ds;
        }

        #endregion

        #region IService Members PadCarID
        /// <summary>
        /// 
        /// </summary>
        /// <param name="CarID">参数格式：类型+IP地址+卡号（中间用“+”分开），例如：1+192.168.1.3+0012345678</param>
        /// <returns></returns>
        public string PadCarID(string CarID)
        {
            Console.WriteLine("PadCarID service has bean started!");
            string[] ss = CarID.Split('+');
            if (ss[0] == "1")//1为刷卡
            {
                ReaderCard.PadCarID tc = new ReaderCard.PadCarID(CarID);
                string aa = tc.Treatment();
                return aa;
                if (ss[2] == "0012345678")//模拟判断这是工序卡
                {
                    string sss = bllMat.GetAllList().Tables[0].Rows.Count.ToString();
                    return "1+123#，黑色，32# ，60，订碗" + sss;//工序卡返回的前面是1
                }
                else if (ss[2] == "0001234567")//模拟判断这是员工卡
                {
                    return "2+张三";//员工卡前面返回的是2
                }
                else
                {
                    return "3+错误的卡号";//不是在本系统中使用的卡，返回前面是3，此时不需要其它的操作
                }
            }
            else if (ss[0] == "2")//2为点击工序列表中某一行
            {
                ReaderCard.PadCarID tc = new ReaderCard.PadCarID(CarID);
                string aa = tc.Treatment();
                return aa;
                return "4+123#,黑色，32#，60，包装";//返回点击工序列表某一行后的信息，前面是4，不需要其它操作
            }
            else if (ss[0] == "3")//3为缝制要求
            {
                return "5+做好做好做好做好做好做好做好做好做好";//返回缝制要求，前面是5，不需要其它操作
            }
            else
            {
                return "3+错误";//其它类型的错误，不需要其它操作
            }
        }

        #endregion

        #region IService Members GetWorkingList

        /// <summary>
        /// 刷的卡是工序卡，即上一事件返回的面是1
        /// </summary>
        /// <param name="CarID"></param>
        /// <returns></returns>
        public string GetWorkingList(string CarID)
        {
            Console.WriteLine("GetWorkingList service has bean started!");
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));//ID，不用显示出来
            dt.Columns.Add("WorkingName", typeof(string));//工序名
            dt.Columns.Add("Amount", typeof(string));//数量
            dt.Columns.Add("EmpName", typeof(string));//员工
            dt.Columns.Add("DateTime", typeof(string));//时间
            dt.Columns.Add("GroupBy", typeof(string));//分组
            dt.Columns.Add("Orders", typeof(string));//顺序号

            //DataRow[] drs = ReaderCard.BasicTable.dtMain.Select("(CardID=" + Convert.ToInt32(CarID) + ")");
            DataTable dtt = ReaderCard.BasicTable.bllWTIDC.GetListForPad(Convert.ToInt32(CarID)).Tables[0];
            for (int i = 0; i < dtt.Rows.Count; i++)
            {
                DataRow dr = dt.NewRow();
                if (dtt.Rows[i]["EmpName"] == null || dtt.Rows[i]["EmpName"].ToString() == string.Empty)
                {
                    dr["EmpName"] = string.Empty;
                    dr["DateTime"] = string.Empty;
                }
                else
                {
                    dr["EmpName"] = dtt.Rows[i]["EmpName"];
                    dr["DateTime"] = dtt.Rows[i]["DateTime"];
                }
                dr["ID"] = dtt.Rows[i]["ID"];
                dr["WorkingName"] = dtt.Rows[i]["WorkingName"];
                dr["Amount"] = dtt.Rows[i]["Amount"];
                dr["GroupBy"] = dtt.Rows[i]["GroupBy"];
                dr["Orders"] = dtt.Rows[i]["Orders"];
                dt.Rows.Add(dr.ItemArray);
            }
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "dt";
            string ss = ds.GetXml();
            ss = ss.Replace("\r\n", string.Empty);
            ss = ss.Replace(" ", string.Empty);
            return ss;
        }

        #endregion

        #region IService Members GetEmpDay

        /// <summary>
        /// 返回某员工当天的产量
        /// </summary>
        /// <param name="CardID">员工卡卡号</param>
        /// <returns></returns>
        public string GetEmpDay(string CarID)
        {
            DataSet ds = ReaderCard.BasicTable.bllME.GetSumAmount(Convert.ToInt32(CarID), 0);
            ds.DataSetName = "ds";
            ds.Tables[0].TableName = "dt";
            string ss = ds.GetXml();
            ss = ss.Replace("\r\n", string.Empty);
            ss = ss.Replace(" ", string.Empty);
            return ss;
        }

        #endregion

        #region IService Members GetEmpMonth

        /// <summary>
        /// 返回某员工当月的产量
        /// </summary>
        /// <param name="CardID">员工卡卡号</param>
        /// <returns></returns>
        public string GetEmpMonth(string CarID)
        {
            DataSet ds = ReaderCard.BasicTable.bllME.GetSumAmount(Convert.ToInt32(CarID), 1);
            ds.DataSetName = "ds";
            ds.Tables[0].TableName = "dt";
            string ss = ds.GetXml();
            ss = ss.Replace("\r\n", string.Empty);
            ss = ss.Replace(" ", string.Empty);
            return ss;
        }

        #endregion
    }
}
