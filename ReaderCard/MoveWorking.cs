using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
  public  class MoveWorking
    {
      private static Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
        /// <summary>
        /// 移动工序
        /// </summary>
        /// <param name="CID">按键指令</param>
        /// <param name="NID">机器号</param>
      public static string MoveWorkingID(int NID, int CID)
      {
          //if (CID != 2 && CID != 8)
          //{
          //    ReturnStr(2, NID, "指令错误       2为向前8为向后");
          //    return;
          //}

          DataRow[] drs;
          string _workingName = string.Empty;
          drs = BasicTable.dtMain.Select("(No=" + NID + ") ");//查找箱头卡刷卡记录
          if (drs.Length == 0)
          {
              return ReturnStr(2, NID, "没有箱号记录");
          }
          else
          {
              DataRow[] ddrs = BasicTable.dtWTCard.Select("(IDCardNo='" + drs[0]["CardID"] + "') ", "Orders");
              if (ddrs.Length > 0)
              {
                  if (Convert.ToInt32(drs[0]["InfoID"]) == 0)//主表记录InfoID为0时，显示该箱最后一条记录。
                  {
                      drs[0]["InfoID"] = ddrs[ddrs.Length - 1]["InfoID"];
                      drs[0]["WorkingID"] = ddrs[ddrs.Length - 1]["WorkingID"];
                      drs[0]["WorkingName"] = _workingName = ddrs[ddrs.Length - 1]["WorkingName"].ToString();
                      drs[0]["EmployeeID"] = ddrs[ddrs.Length - 1]["EmployeeID"];
                      drs[0]["WorkingName"] = ddrs[ddrs.Length - 1]["WorkingName"];
                      drs[0]["WorkTypeID"] = ddrs[ddrs.Length - 1]["WorkTypeID"];
                      return ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[ddrs.Length - 1]["EmpSN"]+ ddrs[ddrs.Length - 1]["MiniEmpName"].ToString());

                  }
                  else
                  {
                      for (int i = 0; i < ddrs.Length; i++)
                      {
                          if (ddrs[i]["InfoID"].Equals(drs[0]["InfoID"]))//循环到当前主表保存的工序，再做调整
                          {
                              if (CID == 0)
                              {
                                  if (i > 0)
                                  {
                                      drs[0]["InfoID"] = ddrs[i - 1]["InfoID"];
                                      drs[0]["WorkingID"] = ddrs[i - 1]["WorkingID"];
                                      drs[0]["WorkingName"] = _workingName = ddrs[i - 1]["WorkingName"].ToString();
                                      drs[0]["EmployeeID"] = ddrs[i - 1]["EmployeeID"];
                                      drs[0]["WorkingName"] = ddrs[i - 1]["WorkingName"];
                                      drs[0]["WorkTypeID"] = ddrs[i - 1]["WorkTypeID"];
                                      return ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[i - 1]["EmpSN"] + ddrs[i - 1]["MiniEmpName"].ToString());

                                  }
                                  else
                                  {
                                      return ReturnStr(2, NID, "已是第一道工序");

                                  }
                              }
                              //else if (CID == 8)
                              //{
                              //    if (Convert.ToBoolean(ddrs[i]["IsCanMove"]))
                              //    {
                              //        if (i < (ddrs.Length - 1))
                              //        {
                              //            drs[0]["InfoID"] = ddrs[i + 1]["InfoID"];
                              //            drs[0]["WorkingID"] = ddrs[i + 1]["WorkingID"];
                              //            drs[0]["WorkingName"] = _workingName = ddrs[i + 1]["WorkingName"].ToString();
                              //            drs[0]["EmployeeID"] = ddrs[i + 1]["EmployeeID"];
                              //            drs[0]["WorkingName"] = ddrs[i + 1]["WorkingName"];
                              //            drs[0]["WorkTypeID"] = ddrs[i + 1]["WorkTypeID"];
                              //            return ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[i + 1]["MiniEmpName"].ToString());
                              //        }
                              //        else
                              //        {
                              //            return ReturnStr(2, NID, "已是最后的工序");
                              //        }
                              //    }
                              //    else
                              //    {
                              //        return ReturnStr(2, NID, "不能向下翻！");
                              //    }
                              //}
                              else
                              {
                                  if (Convert.ToBoolean(ddrs[i]["IsCanMove"]))
                                  {
                                      if (i < (ddrs.Length - 1))
                                      {
                                          int a = 0;
                                          if ((i + CID) < ddrs.Length - 1)
                                          {
                                              a = i + CID;
                                          }
                                          else
                                          {
                                              a = ddrs.Length - 1;
                                          }
                                          drs[0]["InfoID"] = ddrs[a]["InfoID"];
                                          drs[0]["WorkingID"] = ddrs[a]["WorkingID"];
                                          drs[0]["WorkingName"] = _workingName = ddrs[a]["WorkingName"].ToString();
                                          drs[0]["EmployeeID"] = ddrs[a]["EmployeeID"];
                                          drs[0]["WorkingName"] = ddrs[a]["WorkingName"];
                                          drs[0]["WorkTypeID"] = ddrs[a]["WorkTypeID"];
                                          return ReturnStr(0, NID, GetSendOneString(_workingName) + ddrs[a]["EmpSN"] + ddrs[a]["MiniEmpName"].ToString());
                                      }
                                      else
                                      {
                                          return ReturnStr(2, NID, "已是最后的工序");
                                      }
                                  }
                                  else
                                  {
                                      return ReturnStr(2, NID, "不能向下翻！");
                                  }
                              }
                          }
                      }
                      return ReturnStr(2, NID, "错误");
                  }
              }
              else
              {
                  return ReturnStr(2, NID, "没有箱号记录");
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
