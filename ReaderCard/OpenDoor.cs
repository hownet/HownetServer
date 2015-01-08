using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class OpenDoor
    {
      private static Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
        /// <summary>
        /// 移动工序
        /// </summary>
        /// <param name="CID">卡号</param>
        /// <param name="NID">机器号</param>
      public static string OpenDooring(int NID, int CID)
      {
          DataRow[] drEm = BasicTable.dtEmployee.Select("(IDCardID=" + CID + ")");//是否有对应员工，没有就再次查询数据库，以添加新员工，如仍没有，见则转为查询是否为箱头卡
          if (drEm.Length == 0)
          {
              return ReturnStr(2, NID, "错误的卡号");
          }
          else
          {
              Hownet.BLL.AccessList bllAL = new Hownet.BLL.AccessList();
              if (bllAL.CheckIsCanOpenDoor(Convert.ToInt32(drEm[0]["ID"]), NID))
              {
                  return ReturnStr(5, NID, "欢迎" + drEm[0]["Name"].ToString());
              }
              else
              {
                  return ReturnStr(2, NID, "无权限");
              }
          }
      }
        private static string ReturnStr(int TypeID, int NID, string messs)
        {
            return TypeID.ToString() + "," + NID.ToString() + "," + messs;
        }
        private static string GetSendOneString(string strMes)
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
    }
}
