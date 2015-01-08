using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace Hownet.BLL.BaseFile
{
    public class MakBox
    {
        //public DataTable MakBoxOne(int TaskID, int PjAmount, int WAmount, int TableTypeID)
        //{

        //    int BoxNum = 1;
        //    int z = 0;
        //    int j = 0;
        //    Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
        //    Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
        //    Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
        //    DataSet dsPt = bllPTI.GetBox(TaskID, TableTypeID);
        //    // DataSet dsColor = bllPT.GetColor("(ProduceTaskID='" + TaskID + "')");
        //    //  DataSet dsSize = bllPT.GetSize("(ProduceTaskID='" + TaskID + "')");
        //    DataTable dtBox = new DataTable();
        //    dtBox.Columns.Add("ColorID", typeof(int));
        //    dtBox.Columns.Add("SizeID", typeof(int));
        //    dtBox.Columns.Add("ColorOneID", typeof(int));
        //    dtBox.Columns.Add("ColorTwoID", typeof(int));
        //    dtBox.Columns.Add("Amount", typeof(int));
        //    dtBox.Columns.Add("BoxNum", typeof(int));
        //    dtBox.Columns.Add("ColorName", typeof(string));
        //    dtBox.Columns.Add("SizeName", typeof(string));
        //    dtBox.Columns.Add("MListID", typeof(int));

        //    if (modPTM.PWorkingID != 0)
        //    {
        //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
        //        {
        //            //某数量少于尾箱数量，直接取该数量
        //            if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < WAmount)
        //            {
        //                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                    int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()),
        //                    int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()), BoxNum, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(),
        //                    dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                BoxNum++;
        //            }
        //            else
        //            {
        //                int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % PjAmount;
        //                if (x <= (WAmount - PjAmount))
        //                {
        //                    z = 3;
        //                }
        //                if (x == 0)
        //                {
        //                    z = 1;
        //                }
        //                if (x > (WAmount - PjAmount))
        //                {
        //                    z = 2;
        //                }
        //                switch (z)
        //                {
        //                    case 1:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount)); j++)
        //                            {
        //                                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                     int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), PjAmount,
        //                                    j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            }
        //                            BoxNum = j;
        //                            break;
        //                        }
        //                    case 2:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount); j++)
        //                            {
        //                                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                     int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), PjAmount,
        //                                    j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            }

        //                            dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                 int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), x,
        //                                j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                    case 3:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount) - 1; j++)
        //                            {
        //                                dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                     int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), PjAmount,
        //                                    j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            }
        //                            dtBox.Rows.Add(int.Parse(dsPt.Tables[0].DefaultView[r]["ColorID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["SizeID"].ToString()),
        //                                 int.Parse(dsPt.Tables[0].DefaultView[r]["ColorOneID"].ToString()), int.Parse(dsPt.Tables[0].DefaultView[r]["ColorTwoID"].ToString()), (PjAmount + x),
        //                                j, dsPt.Tables[0].DefaultView[r]["ColorName"].ToString(), dsPt.Tables[0].DefaultView[r]["SizeName"].ToString(), dsPt.Tables[0].DefaultView[r]["MListID"]);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                }
        //            }
        //        }
        //    }
        //    return dtBox;
        //}
        //public void MakBoxThree(int ProductWorkID, int TaskID, int PjAmount, int WAmount, int MaterielID, int BrandID, int TableTypeID)
        //{
        //    DataTable Main = MakBoxOne(TaskID, PjAmount, WAmount, TableTypeID);
        //    Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
        //    Hownet.BLL.WorkTicket bllWT = new WorkTicket();
        //    Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
        //    Hownet.Model.WorkTicket modWK = new Hownet.Model.WorkTicket();
        //    Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
        //    bool t = false;
        //    DataSet dsPw = bllPWI.GetBoxWork(ProductWorkID);
        //    DataTable dtSpecial = bllPWI.GetList("(PWMID=" + ProductWorkID + ")").Tables[0];//查出特殊工序明细表
        //    if (dtSpecial.Rows.Count == 0)
        //    {
        //        #region 没有特殊工序
        //        for (int r = 0; r < Main.Rows.Count; r++)
        //        {
        //            modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
        //            modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
        //            modWK.ColorOneID = int.Parse(Main.DefaultView[r]["ColorOneID"].ToString());
        //            modWK.ColorTwoID = int.Parse(Main.DefaultView[r]["ColorTwoID"].ToString());
        //            modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
        //            modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
        //            modWK.MListID = int.Parse(Main.DefaultView[r]["MListID"].ToString());
        //            modWK.TaskID = TaskID;
        //            int mainID = bllWT.Add(modWK);
        //            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
        //            {
        //                modWKI.EmployeeID = 0;
        //                modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
        //                modWKI.WorkingID = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
        //                modWKI.MainID = mainID;
        //                modWKI.Amount = modWKI.NotAmount = modWK.Amount;
        //                modWKI.TaskID = TaskID;
        //                bllWkInfo.Add(modWKI);
        //            }
        //        }
        //    }
        //        #endregion
        //    #region 特殊工序
        //    else
        //    {
        //        for (int r = 0; r < Main.Rows.Count; r++)
        //        {
        //            modWK.ColorID = int.Parse(Main.DefaultView[r]["ColorID"].ToString());
        //            modWK.SizeID = int.Parse(Main.DefaultView[r]["SizeID"].ToString());
        //            modWK.ColorOneID = 0;
        //            modWK.ColorTwoID = 0;
        //            modWK.BoxNum = int.Parse(Main.DefaultView[r]["BoxNum"].ToString());
        //            modWK.Amount = int.Parse(Main.DefaultView[r]["Amount"].ToString());
        //            modWK.MListID = int.Parse(Main.DefaultView[r]["MListID"].ToString());
        //            modWK.TaskID = TaskID;
        //            int mainID = bllWT.Add(modWK);
        //            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
        //            {
        //                t = false;
        //                modWKI.EmployeeID = 0;
        //                int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
        //                modWKI.WorkingID = w;
        //                modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
        //                if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//判断某道工序是否是特殊工序
        //                {
        //                    DataRow[] drs = dtSpecial.Select("(SpecialWork=" + w + ") and (ColorID=" + modWK.ColorID + ")");
        //                    if (drs.Length > 0)//在特殊工序列表中，是否有当前颜色记录
        //                    {
        //                        modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
        //                        modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
        //                    }
        //                    else
        //                    {
        //                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (ColorID=0)");//是否有通用颜色工序
        //                        if (drs.Length > 0)
        //                        {
        //                            modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
        //                            modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
        //                        }
        //                        else
        //                        {
        //                            t = true;
        //                        }
        //                    }
        //                }
        //                modWKI.MainID = mainID;
        //                modWKI.Amount = modWKI.NotAmount = modWK.Amount;
        //                modWKI.TaskID = TaskID;
        //                if (!t)
        //                    bllWkInfo.Add(modWKI);//有特殊工序的普通工序，则添加记录，否则不添加
        //            }
        //        }
        //    }
        //    #endregion
        //}
        //public void MakBoxOneID(int TaskID, int PjAmount, int WAmount, int TableTypeID, int BrandID)
        //{

        //    int BoxNum = 1;
        //    int z = 0;
        //    int j = 0;
        //    Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
        //    Hownet.BLL.WorkTicket bllWT = new WorkTicket();
        //    Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
        //    Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
        //    DataSet dsPt = bllPTI.GetBoxID(TaskID, TableTypeID, 0);
        //    // DataSet dsColor = bllPT.GetColor("(ProduceTaskID='" + TaskID + "')");
        //    //  DataSet dsSize = bllPT.GetSize("(ProduceTaskID='" + TaskID + "')");
        //    DataTable dtBox = bllWT.GetListNoA("(ID=0)").Tables[0];
        //    //dtBox.Columns.Add("ColorID", typeof(int));
        //    //dtBox.Columns.Add("SizeID", typeof(int));
        //    //dtBox.Columns.Add("ColorOneID", typeof(int));
        //    //dtBox.Columns.Add("ColorTwoID", typeof(int));
        //    //dtBox.Columns.Add("Amount", typeof(int));
        //    //dtBox.Columns.Add("BoxNum", typeof(int));
        //    //dtBox.Columns.Add("MListID", typeof(int));
        //    if (modPTM.PWorkingID != 0)
        //    {
        //        for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
        //        {
        //            //某数量少于尾箱数量，直接取该数量
        //            if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < WAmount)
        //            {
        //                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
        //                    dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                BoxNum++;
        //            }
        //            else
        //            {
        //                int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % PjAmount;
        //                if (x <= (WAmount - PjAmount))
        //                {
        //                    z = 3;
        //                }
        //                if (x == 0)
        //                {
        //                    z = 1;
        //                }
        //                if (x > (WAmount - PjAmount))
        //                {
        //                    z = 2;
        //                }
        //                switch (z)
        //                {
        //                    case 1:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount)); j++)
        //                            {

        //                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                   dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], PjAmount,
        //                                    j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            }
        //                            BoxNum = j;
        //                            break;
        //                        }
        //                    case 2:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount); j++)
        //                            {
        //                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"], dsPt.Tables[0].DefaultView[r]["ColorTwoID"],
        //                                    dsPt.Tables[0].DefaultView[r]["SizeID"], PjAmount, j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            }

        //                            dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                    case 3:
        //                        {

        //                            for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / PjAmount) - 1; j++)
        //                            {
        //                                //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
        //                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                   dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], PjAmount, j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            }
        //                            dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
        //                                dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (PjAmount + x),
        //                                j, TaskID, 0, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID);
        //                            BoxNum = j + 1;
        //                            break;
        //                        }
        //                }
        //            }
        //        }
        //    }
        //    DAL.BaseFile.MakeBox.AddWorkTicket(dtBox);
        //}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProductWorkID">生产任务中工艺单ID</param>
        /// <param name="TaskID">生产任务ID</param>
        /// <param name="PjAmount">平均箱数量</param>
        /// <param name="WAmount">尾箱数量</param>
        /// <param name="MaterielID">款号</param>
        /// <param name="BrandID">商标</param>
        /// <param name="TableTypeID">单据类型</param>
        public void MakBoxThreeID(int ProductWorkID, int TaskID, int PjAmount, int WAmount, int MaterielID, int BrandID, int TableTypeID)
        {
            try
            {
                //MakBoxOneID(TaskID, PjAmount, WAmount, TableTypeID,BrandID);
                #region WorkTicket表
                int BoxNum = 1;
                int z = 0;
                int j = 0;
                int _PJAmount = 0;
                int _WAmount = 0;
                //  int CompanyID = 0;
                Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
                Hownet.BLL.WorkTicket bllWT = new WorkTicket();
                Hownet.BLL.AmountInfo bllPTI = new AmountInfo();
                Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
                Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
                DataSet dsPt = bllPTI.GetBoxID(TaskID, TableTypeID);
                DataTable dtBox = bllWT.GetListNoA("(ID=0)").Tables[0];
                DataTable dtPWIAmount = bllPWI.GetOneAmount(modPTM.PWorkingID).Tables[0];
                if (modPTM.PWorkingID != 0)
                {
                    for (int g = 0; g < dtPWIAmount.Rows.Count; g++)
                    {
                        #region 正常分箱
                        if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) == 0)
                        {
                            _PJAmount = PjAmount;
                            _WAmount = WAmount;
                            for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
                            {
                                //某数量少于尾箱数量，直接取该数量
                                if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < _WAmount)
                                {
                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                        dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
                                        dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                    BoxNum++;
                                }
                                else
                                {
                                    int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % _PJAmount;
                                    if (x <= (_WAmount - _PJAmount))
                                    {
                                        z = 3;
                                    }
                                    if (x == 0)
                                    {
                                        z = 1;
                                    }
                                    if (x > (_WAmount - _PJAmount))
                                    {
                                        z = 2;
                                    }
                                    switch (z)
                                    {
                                        case 1:
                                            {

                                                for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount)); j++)
                                                {

                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount,
                                                        j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                }
                                                BoxNum = j;
                                                break;
                                            }
                                        case 2:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount); j++)
                                                {
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"], dsPt.Tables[0].DefaultView[r]["ColorTwoID"],
                                                        dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                }

                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                        case 3:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount) - 1; j++)
                                                {
                                                    //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                }
                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (_PJAmount + x),
                                                    j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, 0);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                        #endregion
                        #region 有预设数量分箱
                        if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) > 0)
                        {
                            _PJAmount = Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]);
                            _WAmount = Convert.ToInt32(_PJAmount * 1.5);
                            for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
                            {
                                //某数量少于尾箱数量，直接取该数量
                                if (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) < _WAmount)
                                {
                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                        dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
                                        dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                    BoxNum++;
                                }
                                else
                                {
                                    int x = int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) % _PJAmount;
                                    if (x <= (_WAmount - _PJAmount))
                                    {
                                        z = 3;
                                    }
                                    if (x == 0)
                                    {
                                        z = 1;
                                    }
                                    if (x > (_WAmount - _PJAmount))
                                    {
                                        z = 2;
                                    }
                                    switch (z)
                                    {
                                        case 1:
                                            {

                                                for (j = BoxNum; j < (BoxNum + (int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount)); j++)
                                                {

                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount,
                                                        j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                }
                                                BoxNum = j;
                                                break;
                                            }
                                        case 2:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount); j++)
                                                {
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"], dsPt.Tables[0].DefaultView[r]["ColorTwoID"],
                                                        dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                }

                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], x, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                        case 3:
                                            {

                                                for (j = BoxNum; j < (BoxNum + int.Parse(dsPt.Tables[0].DefaultView[r]["Amount"].ToString()) / _PJAmount) - 1; j++)
                                                {
                                                    //  A,ID,ColorID,ColorOneID,ColorTwoID,SizeID,Amount,BoxNum,TaskID,DepartmentID,P2DInfoID,EligibleAmount,InferiorAmount,P2DDepartmentID,MListID,BrandID
                                                    dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                       dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], _PJAmount, j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                }
                                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"], (_PJAmount + x),
                                                    j, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, _PJAmount);
                                                BoxNum = j + 1;
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                        #endregion
                        #region 各色各码总数分为一箱
                        if (Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]) == -1)
                        {
                            for (int r = 0; r < dsPt.Tables[0].Rows.Count; r++)
                            {
                                dtBox.Rows.Add(0, dsPt.Tables[0].DefaultView[r]["ColorID"], dsPt.Tables[0].DefaultView[r]["ColorOneID"],
                                    dsPt.Tables[0].DefaultView[r]["ColorTwoID"], dsPt.Tables[0].DefaultView[r]["SizeID"],
                                    dsPt.Tables[0].DefaultView[r]["Amount"], BoxNum, TaskID, modPTM.DeparmentID, 0, 0, 0, 0, dsPt.Tables[0].DefaultView[r]["MListID"], BrandID, -1);
                                BoxNum++;
                            }
                        }
                        #endregion
                    }
                }
                DAL.BaseFile.MakeBox.AddWorkTicket(dtBox);
                #endregion

                Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
                Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
                bool t = false;
                DataTable Main = new DataTable();
                DataTable dtInfo = bllWkInfo.GetListNoA("(ID=0)").Tables[0];
                DataSet dsPw = new DataSet();
                DataTable dtSpecial = new DataTable();
                for (int g = 0; g < dtPWIAmount.Rows.Count; g++)
                {
                    Main = bllWT.GetIDList(TaskID, Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"])).Tables[0];
                    dsPw = bllPWI.GetBoxWorkID(ProductWorkID, Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"]));
                    dtSpecial = bllPWI.GetSpecialWork(ProductWorkID, Convert.ToInt32(dtPWIAmount.Rows[g]["OneAmount"])).Tables[0];//查出特殊工序明细表
                    DateTime dtNull = DateTime.Parse("1900-1-1");
                    if (dtSpecial.Rows.Count == 0)
                    {
                        #region 没有特殊工序
                        for (int r = 0; r < Main.Rows.Count; r++)
                        {
                            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                            {
                                dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, dsPw.Tables[0].DefaultView[c]["ID"], 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, dsPw.Tables[0].DefaultView[c]["WorkingID"], Main.Rows[r]["Amount"]);
                            }
                        }
                    }
                        #endregion
                    #region 特殊工序
                    else
                    {
                        DataRow[] drs;
                        for (int r = 0; r < Main.Rows.Count; r++)
                        {
                            for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                            {
                                t = false;
                                modWKI.EmployeeID = 0;
                                int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
                                modWKI.WorkingID = w;
                                modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
                                if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//判断某道工序是否是特殊工序
                                {
                                    //if (modPTM.CompanyID > 0)
                                    //{
                                    //有特定客户、特定尺码、特定颜色的特殊工序
                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                    if (drs.Length == 0)
                                    {
                                        //有特定尺码、特定颜色的特殊工序
                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                        if (drs.Length == 0)
                                        {
                                            //有特定尺码、特定客户的特殊工序
                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                            if (drs.Length == 0)
                                            {
                                                //有特定客户、特定颜色的特殊工序
                                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=0)");
                                                if (drs.Length == 0)
                                                {
                                                    //只有特定颜色的特殊工序
                                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=0) And (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ")");
                                                    if (drs.Length == 0)
                                                    {
                                                        //有只特定客户的特殊工序
                                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) and (MaterielID=0)");
                                                        if (drs.Length == 0)
                                                        {
                                                            //有只特定尺码的特殊工序
                                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=" + Main.Rows[r]["SizeID"] + ") and (ColorID=0) and (CompanyID=0)");
                                                            if (drs.Length == 0)
                                                            {
                                                                //不分颜色、客户的特殊工序
                                                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=0)");
                                                                if (drs.Length == 0)
                                                                {
                                                                    t = true;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (drs.Length > 0)
                                    {
                                        modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                                        modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                                        if (modWKI.WorkingID == 0)
                                            t = true;
                                    }
                                }
                                if (!t)
                                    dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, modWKI.PWorkingInfoID, 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, modWKI.WorkingID, Main.Rows[r]["Amount"]);
                            }
                        }
                    #endregion
                    }
                }
                DAL.BaseFile.MakeBox.AddWorkTicketInfo(dtInfo);
            }
            catch (Exception ex)
            {
            }
        }
        public void MakClothing(int TaskID)
        {
            Hownet.BLL.ProductTaskMain bllPTM = new ProductTaskMain();
            Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(TaskID);
            Hownet.BLL.WorkTicket bllWT = new WorkTicket();
            Hownet.BLL.WorkTicketInfo bllWkInfo = new WorkTicketInfo();
            Hownet.Model.WorkTicketInfo modWKI = new Hownet.Model.WorkTicketInfo();
            Hownet.BLL.ProductWorkingInfo bllPWI = new ProductWorkingInfo();
            bool t = false;
            DataTable Main = new DataTable();
            DataTable dtInfo = bllWkInfo.GetListNoA("(ID=0)").Tables[0];
            DataSet dsPw = new DataSet();
            DataTable dtSpecial = new DataTable();

            Main = bllWT.GetIDList(TaskID, 0).Tables[0];
            dsPw = bllPWI.GetBoxWorkID(modPTM.PWorkingID, 0);
            dtSpecial = bllPWI.GetSpecialWork(modPTM.PWorkingID, 0).Tables[0];//查出特殊工序明细表
            DateTime dtNull = DateTime.Parse("1900-1-1");
            try
            {
                if (dtSpecial.Rows.Count == 0)
                {
                    #region 没有特殊工序
                    for (int r = 0; r < Main.Rows.Count; r++)
                    {
                        for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                        {
                            dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, dsPw.Tables[0].DefaultView[c]["ID"], 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, dsPw.Tables[0].DefaultView[c]["WorkingID"], Main.Rows[r]["Amount"]);
                        }
                    }
                }
                    #endregion
                #region 特殊工序
                else
                {
                    DataRow[] drs;
                    for (int r = 0; r < Main.Rows.Count; r++)
                    {
                        for (int c = 0; c < dsPw.Tables[0].Rows.Count; c++)
                        {
                            t = false;
                            modWKI.EmployeeID = 0;
                            int w = int.Parse(dsPw.Tables[0].DefaultView[c]["WorkingID"].ToString());
                            modWKI.WorkingID = w;
                            modWKI.PWorkingInfoID = int.Parse(dsPw.Tables[0].DefaultView[c]["ID"].ToString());
                            if ((bool.Parse(dsPw.Tables[0].DefaultView[c]["IsSpecial"].ToString())))//判断某道工序是否是特殊工序
                            {
                                //if (modPTM.CompanyID > 0)
                                //{
                                //有特定客户、特定尺码、特定颜色的特殊工序
                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                if (drs.Length == 0)
                                {
                                    //有特定尺码、特定颜色的特殊工序
                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                    if (drs.Length == 0)
                                    {
                                        //有特定尺码、特定客户的特殊工序
                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) And (MaterielID=" + Main.Rows[r]["SizeID"] + ")");
                                        if (drs.Length == 0)
                                        {
                                            //有特定客户、特定颜色的特殊工序
                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=" + Main.Rows[r]["ColorID"] + ") And (MaterielID=0)");
                                            if (drs.Length == 0)
                                            {
                                                //只有特定颜色的特殊工序
                                                drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=0) And (CompanyID=0) and (ColorID=" + Main.Rows[r]["ColorID"] + ")");
                                                if (drs.Length == 0)
                                                {
                                                    //有只特定客户的特殊工序
                                                    drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=" + modPTM.CompanyID + ") and (ColorID=0) and (MaterielID=0)");
                                                    if (drs.Length == 0)
                                                    {
                                                        //有只特定尺码的特殊工序
                                                        drs = dtSpecial.Select("(SpecialWork=" + w + ") and (MaterielID=" + Main.Rows[r]["SizeID"] + ") and (ColorID=0) and (CompanyID=0)");
                                                        if (drs.Length == 0)
                                                        {
                                                            //不分颜色、客户的特殊工序
                                                            drs = dtSpecial.Select("(SpecialWork=" + w + ") and (CompanyID=0) and (ColorID=0)");
                                                            if (drs.Length == 0)
                                                            {
                                                                t = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                                if (drs.Length > 0)
                                {
                                    modWKI.WorkingID = int.Parse(drs[0]["WorkingID"].ToString());
                                    modWKI.PWorkingInfoID = int.Parse(drs[0]["ID"].ToString());
                                    if (modWKI.WorkingID == 0)
                                        t = true;
                                }
                            }
                            if (!t)
                                dtInfo.Rows.Add(0, Main.Rows[r]["ID"], DBNull.Value, 0, modWKI.PWorkingInfoID, 0, 0, Main.Rows[r]["Amount"], Main.Rows[r]["Amount"], TaskID, modWKI.WorkingID, Main.Rows[r]["Amount"]);
                        }
                    }
                #endregion
                }

                DAL.BaseFile.MakeBox.AddWorkTicketInfo(dtInfo);
            }
            catch (Exception ex)
            {
            }
        }
    }
}
