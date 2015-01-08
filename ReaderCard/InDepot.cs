using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class InDepot
    {
        private static Encoding gb = System.Text.Encoding.GetEncoding("gb2312");
        /// <summary>
        /// 入库处理
        /// </summary>
        /// <param name="Amount">入库数量，工序全部完成自动入库时，设置为-1</param>
        /// <param name="NID">机器号</param>
        public static string InDepotAmount(int Amount, int NID, int _depotID)
        {
            Hownet.BLL.Product2Depot bllP2D = new Hownet.BLL.Product2Depot();
            Hownet.Model.Product2Depot modP2D = new Hownet.Model.Product2Depot();
            Hownet.BLL.Product2DepotInfo bllP2DInfo = new Hownet.BLL.Product2DepotInfo();
            Hownet.Model.Product2DepotInfo modP2DInfo = new Hownet.Model.Product2DepotInfo();
            Hownet.BLL.Repertory bllRep = new Hownet.BLL.Repertory();
            Hownet.Model.Repertory modRep = new Hownet.Model.Repertory();
            Hownet.BLL.AmountInfo bllAI = new Hownet.BLL.AmountInfo();
            DataRow[] drsMain = BasicTable.dtMain.Select("(No=" + NID + ")");
            if (drsMain.Length == 0)
            {
                return ReturnStr(0, NID, "无相关记录");
            }
            bool t = false;
            Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();//有当前卡机的刷卡记录，读出相应分箱记录
            DataTable dttWT = bllWT.GetInDepotList(Convert.ToInt32(drsMain[0]["TicketID"])).Tables[0];
            List<Hownet.Model.WorkTicket> liWT = bllWT.DataTableToList(dttWT);

            if (liWT[0].P2DInfoID > 0 && Amount == -1)
            {
                return ReturnStr(0, NID, "本箱已入库");
            }
            //if (Amount == -1)
            //{

            //}
            #region 记入入库明细
            DataTable dtP2D = new DataTable();
            if (Amount == -1)
            {
                dtP2D = bllP2D.GetList("(DateTime='" + DateTime.Today + "') And (IsVerify=4) And (DepotID=" + _depotID + ")").Tables[0];
                if (dtP2D.Rows.Count == 0)//查出当天已审核的该仓库入库表
                {
                    modP2D = new Hownet.Model.Product2Depot();
                    modP2D.DateTime = DateTime.Today;
                    modP2D.Num = bllP2D.NewNum(modP2D.DateTime);
                    modP2D.DepotID = _depotID;
                    modP2D.IsVerify = 4;
                    modP2D.VerifyMan = 0;
                    modP2D.VerifyDate = modP2D.DateTime;
                    modP2D.UpData = 1;
                    modP2D.A = 1;
                    modP2D.TypeID = 8;
                    modP2D.Remark = "";
                    modP2D.ID = bllP2D.Add(modP2D);
                    dtP2D = bllP2D.GetList("(ID=" + modP2D.ID + ")").Tables[0];
                }
            }
            if (liWT[0].P2DInfoID > 0)//这箱货已有入库单编号
            {
                modP2DInfo = bllP2DInfo.GetModel(liWT[0].P2DInfoID);
                if (Amount == -1)
                {
                    if (modP2DInfo.MainID == Convert.ToInt32(dtP2D.Rows[0]["ID"]))//这个入库单明细的主表，等于今天的自动入库单编号
                    {
                        Amount = Convert.ToInt32(drsMain[0]["Amount"]);
                        modP2DInfo.Amount = modP2DInfo.Amount - liWT[0].EligibleAmount + Amount;//更新入库数量
                        bllP2DInfo.Update(modP2DInfo);
                        t = true;
                    }
                    else
                    {
                        return ReturnStr(0, NID, "已于此前入库");
                    }
                }
                else
                {
                    modP2DInfo.Amount = modP2DInfo.Amount - liWT[0].EligibleAmount + Amount;//更新入库数量
                    bllP2DInfo.Update(modP2DInfo);
                    t = true;
                }
            }
            else
            {
                if (Amount == -1)
                    Amount = Convert.ToInt32(drsMain[0]["Amount"]);
                modP2DInfo = new Hownet.Model.Product2DepotInfo();
                modP2DInfo.A = modP2DInfo.ID = 0;
                modP2DInfo.MainID = Convert.ToInt32(dtP2D.Rows[0]["ID"]);
                modP2DInfo.MaterielID = Convert.ToInt32(drsMain[0]["MaterielID"]);
                modP2DInfo.ColorID = liWT[0].ColorID;
                modP2DInfo.ColorOneID = liWT[0].ColorOneID;
                modP2DInfo.ColorTwoID = liWT[0].ColorTwoID;
                modP2DInfo.DeparmentID = liWT[0].DepartmentID;
                modP2DInfo.SizeID = liWT[0].SizeID;
                modP2DInfo.BrandID = liWT[0].BrandID;
                modP2DInfo.Remark = "";
                modP2DInfo.TaskID = liWT[0].TaskID;
                modP2DInfo.Amount = Amount;
                if (liWT[0].MListID > 0)
                {
                    modP2DInfo.MListID = liWT[0].MListID;
                }
                else
                {
                    Hownet.BLL.MaterielList bllML = new Hownet.BLL.MaterielList();
                    Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
                    modML.A = 1;
                }
                liWT[0].P2DInfoID = modP2DInfo.ID = bllP2DInfo.Add(modP2DInfo);
            }
            #endregion
            #region 更新库存
            try
            {
                DataTable dtRep = bllRep.GetList("(DepartmentID=" + _depotID + ") And (MListID=" + liWT[0].MListID + ")").Tables[0];
                if (dtRep.Rows.Count > 0)
                {
                    modRep = bllRep.GetModel(Convert.ToInt32(dtRep.Rows[0]["ID"]));
                    if (Amount == -1)
                    {
                        modRep.Amount += liWT[0].Amount;
                    }
                    else
                    {
                        if (t)
                        {
                            modRep.Amount = modRep.Amount - liWT[0].EligibleAmount + Amount;
                        }
                        else
                        {
                            modRep.Amount += Amount;
                        }
                    }
                    bllRep.Update(modRep);
                }
                else
                {
                    Hownet.BLL.Materiel bllMat = new Hownet.BLL.Materiel();
                    modRep = new Hownet.Model.Repertory();
                    modRep.ID = modRep.A = 0;
                    modRep.MListID = liWT[0].MListID;
                    modRep.MeasureID = bllMat.GetModel(Convert.ToInt32(drsMain[0]["MaterielID"])).MeasureID;
                    modRep.ColorID = liWT[0].ColorID;
                    modRep.ColorOneID = liWT[0].ColorOneID;
                    modRep.ColorTwoID = liWT[0].ColorTwoID;
                    modRep.SizeID = liWT[0].SizeID;
                    modRep.BrandID = liWT[0].BrandID;
                    modRep.CompanyID = 0;
                    modRep.DepartmentID = _depotID;
                    modRep.Amount = Amount;
                    modRep.MaterielID = Convert.ToInt32(drsMain[0]["MaterielID"]);
                    bllRep.Add(modRep);
                }
            #endregion

                #region 更总生产单在线数量
                List<Hownet.Model.AmountInfo> liAI = bllAI.GetModelList("(MainID=" + liWT[0].TaskID + ") And (TableTypeID=1) And (MListID=" + liWT[0].MListID + ")");
                if (liAI.Count > 0)
                {
                    if (Amount == -1)
                    {
                        liAI[0].NotAmount -= liWT[0].Amount;
                    }
                    else
                    {
                        if (t)
                        {
                            liAI[0].NotAmount = liAI[0].NotAmount + liWT[0].EligibleAmount - Amount;
                        }
                        else
                        {
                            liAI[0].NotAmount -= Amount;
                        }
                    }
                    bllAI.Update(liAI[0]);
                }
                if (liWT[0].TaskID > 0)
                {
                    liAI = bllAI.GetModelList("(MainID=" + liWT[0].DepartmentID + ") And (TableTypeID=37) And (MListID=" + liWT[0].MListID + ")");
                    if (liAI.Count > 0)
                    {
                        if (Amount == -1)
                        {
                            liAI[0].NotAmount -= liWT[0].Amount;
                        }
                        else
                        {
                            if (t)
                            {
                                liAI[0].NotAmount = liAI[0].NotAmount + liWT[0].EligibleAmount - Amount;
                            }
                            else
                            {
                                liAI[0].NotAmount -= Amount;
                            }
                        }
                        bllAI.Update(liAI[0]);
                    }
                }
                #endregion
                #region 更新分箱表
                liWT[0].EligibleAmount = Amount;
                liWT[0].InferiorAmount = liWT[0].Amount - Amount;
                liWT[0].P2DInfoID = modP2DInfo.ID;
                liWT[0].P2DDepartmentID = _depotID;
                bllWT.Update(liWT[0]);
                #endregion
                if (Amount > 0 && t)
                {
                    for (int i = 0; i < drsMain.Length; i++)
                    {
                        drsMain[i].Delete();
                    }
                    BasicTable.dtMain.AcceptChanges();
                }

                DataTable dtttt = bllP2D.GetSumAmount(DateTime.Today, modP2DInfo.DeparmentID).Tables[0];
                string ttt = string.Empty;
                if (dtttt.Rows.Count > 0)
                    ttt = dtttt.Rows[0]["Name"].ToString();
                int l = 15 - gb.GetByteCount(ttt);
                if (l > 0)
                {
                    for (int i = 0; i < l; i++)
                    {
                        ttt = ttt + " ";
                    }
                }
                ttt += dtttt.Rows[0]["Amount"].ToString();
                return ReturnStr(0, NID, ttt);
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
         /// <summary>
        /// 入库处理
        /// </summary>
        /// <param name="Amount">入库数量，工序全部完成自动入库时，设置为-1</param>
        /// <param name="NID">机器号</param>
        public static void UpNotAmount(int Amount, int NID)
        {
            Hownet.BLL.AmountInfo bllAI = new Hownet.BLL.AmountInfo();
            DataRow[] drsMain = BasicTable.dtMain.Select("(No=" + NID + ")");
            if (drsMain.Length == 0)
            {
                return ;
            }
            bool t = false;
            Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();//有当前卡机的刷卡记录，读出相应分箱记录
            DataTable dttWT = bllWT.GetInDepotList(Convert.ToInt32(drsMain[0]["TicketID"])).Tables[0];
            List<Hownet.Model.WorkTicket> liWT = bllWT.DataTableToList(dttWT);

            if (liWT[0].P2DInfoID != 0 && Amount == -1)
            {
                return ;
            }


                #region 更总生产单在线数量
                List<Hownet.Model.AmountInfo> liAI = bllAI.GetModelList("(MainID=" + liWT[0].TaskID + ") And (TableTypeID=1) And (MListID=" + liWT[0].MListID + ")");
                if (liAI.Count > 0)
                {
                    if (Amount == -1)
                    {
                        liAI[0].NotAmount -= liWT[0].Amount;
                    }
                    else
                    {
                        if (t)
                        {
                            liAI[0].NotAmount = liAI[0].NotAmount + liWT[0].EligibleAmount - Amount;
                        }
                        else
                        {
                            liAI[0].NotAmount -= Amount;
                        }
                    }
                    bllAI.Update(liAI[0]);
                }
                if (liWT[0].TaskID > 0)
                {
                    liAI = bllAI.GetModelList("(MainID=" + liWT[0].DepartmentID + ") And (TableTypeID=37) And (MListID=" + liWT[0].MListID + ")");
                    if (liAI.Count > 0)
                    {
                        if (Amount == -1)
                        {
                            liAI[0].NotAmount -= liWT[0].Amount;
                        }
                        else
                        {
                            if (t)
                            {
                                liAI[0].NotAmount = liAI[0].NotAmount + liWT[0].EligibleAmount - Amount;
                            }
                            else
                            {
                                liAI[0].NotAmount -= Amount;
                            }
                        }
                        bllAI.Update(liAI[0]);
                    }
                }
                #endregion
                #region 更新分箱表
                liWT[0].EligibleAmount = Amount;
                liWT[0].InferiorAmount = liWT[0].Amount - Amount;
                liWT[0].P2DInfoID = -1;
                liWT[0].P2DDepartmentID = 0;
                bllWT.Update(liWT[0]);
                #endregion
            }
        }
    }

