using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class EditAmount
    {
        private static Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
        /// <summary>
        /// 入库处理
        /// </summary>
        /// <param name="Amount">入库数量，工序全部完成自动入库时，设置为-1</param>
        /// <param name="NID">机器号</param>
        public static string EditWorkAmount(int Amount, int NID,int GroupBy)
        {
            try
            {
                DateTime dt = DateTime.Now;
                DataRow[] drs = BasicTable.dtMain.Select("(No=" + NID + ") ");
                if (drs.Length == 0)
                {
                    return ReturnStr(0, NID, "没有箱号记录");
                }
                else
                {
                    if (int.Parse(drs[0]["EmployeeID"].ToString()) == 0)
                    {
                        if (((DateTime)(drs[0]["Date"])).AddSeconds(30) > dt)//30秒内刷员工卡
                        {
                            Hownet.BLL.WorkTicketInfo bllWTI = new Hownet.BLL.WorkTicketInfo();
                            DataRow[] dddrs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + drs[0]["CardID"] + ")", "Amount DESC");
                            if (dddrs.Length == 0)//第一道工序
                            {
                                if (Convert.ToInt32(drs[0]["Amount"]) < Amount)
                                {
                                    return ReturnStr(0, NID, "不能超过原数量！");
                                }
                                else
                                {
                                    bllWTI.UpNoWorkingAmount(Convert.ToInt32(drs[0]["TicketID"]), Amount, Convert.ToInt32(drs[0]["GroupBy"]));
                                    DataRow[] ddrs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + drs[0]["CardID"] + ")");
                                    for (int i = 0; i < ddrs.Length; i++)
                                    {
                                        ddrs[i].Delete();
                                    }
                                    ReaderCard.BasicTable.dtWTCard.AcceptChanges();
                                    return ReturnStr(0, NID, "数量已修改！");
                                }
                            }
                            else
                            {
                                if (Convert.ToInt32(dddrs[0]["Amount"]) < Amount)
                                {
                                    return ReturnStr(0, NID, "不能超过前数量！");
                                }
                                else
                                {
                                    bllWTI.UpNoWorkingAmount(Convert.ToInt32(drs[0]["TicketID"]), Amount, Convert.ToInt32(drs[0]["GroupBy"]));
                                    DataRow[] ddrs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + drs[0]["CardID"] + ")");
                                    for (int i = 0; i < ddrs.Length; i++)
                                    {
                                        ddrs[i].Delete();
                                    }
                                    ReaderCard.BasicTable.dtWTCard.AcceptChanges();
                                    return ReturnStr(0, NID, "数量已修改！");
                                }
                            }
                        }
                        else
                        {
                            return ReturnStr(0, NID, "已超时！");
                        }
                    }
                }
                return ReturnStr(0, NID, "");
            }
            catch (Exception ex)
            {
                return ReturnStr(0, NID, "错误");
            }
        }
        private static string ReturnStr(int TypeID, int NID, string messs)
        {
            return TypeID.ToString() + "," + NID.ToString() + "," + messs;
        }
    }
}
