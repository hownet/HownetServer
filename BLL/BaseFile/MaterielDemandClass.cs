using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Hownet.BLL.BaseFile
{
    public class MaterielDemandClass
    {
        public DataSet accountDemand(int TaskID, int BOMID, int TableTypeID, byte[] bb, byte[] bbai,int CompanyID,int BrandID)
        {
            Hownet.BLL.AmountInfo bllAI = new AmountInfo();
            Hownet.BLL.MaterielStructMain bllMSM = new MaterielStructMain();
            Hownet.BLL.MaterielStructInfo bllMSI = new MaterielStructInfo();
            Hownet.BLL.ProductionPlan bllPTM = new ProductionPlan();
            Hownet.BLL.Materiel bllMa = new Materiel();
            Hownet.BLL.OtherType bllOT = new OtherType();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            Hownet.Model.ProductionPlan modPTM = bllPTM.GetModel(TaskID);
            Hownet.Model.AmountInfo modAI = new Hownet.Model.AmountInfo();
            Hownet.Model.MaterielStructInfo modMSI = new Hownet.Model.MaterielStructInfo();
            DataTable dtInfo = new DataTable();
            //定义并取得订单中各颜色的总数。
            DataTable dtColor = new DataTable();
            DataTable dtColorOne = new DataTable();
            DataTable dtColorTwo = new DataTable();
            DataTable dtAllColor = new DataTable();
            dtColor.TableName = "ColorInfo";
            //定义并取得订单中各尺码的总数
            DataTable dtSize = new DataTable();
            dtSize.TableName = "SizeInfo";
            //定义拆分后的清单表
            DataTable DemandInfo = new DataTable();
            try
            {
                DemandInfo.Columns.Add("MaterielID", typeof(int));
                DemandInfo.Columns.Add("ColorID", typeof(int));
                DemandInfo.Columns.Add("ColorOneID", typeof(int));
                DemandInfo.Columns.Add("ColorTwoID", typeof(int));
                DemandInfo.Columns.Add("SizeID", typeof(int));
                DemandInfo.Columns.Add("stockAmount", typeof(double));
                DemandInfo.Columns.Add("Amount", typeof(double));
                DemandInfo.Columns.Add("MeasureID", typeof(int));
                DemandInfo.Columns.Add("AttribID", typeof(int));
                DemandInfo.Columns.Add("Stata", typeof(int));
                DemandInfo.Columns.Add("DepID", typeof(int));
                DemandInfo.Columns.Add("ID", typeof(int));
                DemandInfo.Columns.Add("A", typeof(int));

                if (bbai.Length==0)
                {
                    dtInfo = bllAI.GetList("(MainID=" + TaskID + ")").Tables[0];
                    DataSet dsColor = bllAI.GetColor(TaskID, TableTypeID);
                    dtColor = dsColor.Tables[0];
                    dtColorOne = dsColor.Tables[1];
                    dtColorTwo = dsColor.Tables[2];
                    dtSize = bllAI.GetSize(TaskID, TableTypeID).Tables[0];
                }
                else
                {
                    dtInfo = Hownet.BLL.BaseFile.ZipDt.Byte2Ds(bbai).Tables[0];
                    DataSet dsColor = bllAI.GetColor(0, 0);
                    dtColor = dsColor.Tables[0];
                    dtColorOne = dsColor.Tables[1];
                    dtColorTwo = dsColor.Tables[2];
                    dtSize = bllAI.GetSize(0, 0).Tables[0];
                    dtAllColor = bllAI.GetSumColor(0, 0).Tables[0];
                    string strWhere = string.Empty;
                    for (int i = 0; i < dtInfo.Rows.Count; i++)
                    {
                        strWhere = "(ColorID=" + dtInfo.Rows[i]["ColorID"] + ") ";//And (ColorOneID=" + dtInfo.Rows[i]["ColorOneID"] + ") And (ColorTwoID=" + dtInfo.Rows[i]["ColorTwoID"] + ")";
                        if (dtColor.Select(strWhere).Length == 0)
                        {
                            dtColor.Rows.Add(dtColor.NewRow());
                            dtColor.Rows[dtColor.Rows.Count - 1]["ColorID"] = dtInfo.Rows[i]["ColorID"];
                            //dtColor.Rows[dtColor.Rows.Count - 1]["ColorOneID"] = dtInfo.Rows[i]["ColorOneID"];
                            //dtColor.Rows[dtColor.Rows.Count - 1]["ColorTwoID"] = dtInfo.Rows[i]["ColorTwoID"];
                        }
                        if (dtSize.Select("(SizeID=" + dtInfo.Rows[i]["SizeID"] + ")").Length == 0)
                        {
                            dtSize.Rows.Add(dtSize.NewRow());
                            dtSize.Rows[dtSize.Rows.Count - 1]["SizeID"] = dtInfo.Rows[i]["SizeID"];
                        }
                        if (Convert.ToInt32(dtInfo.Rows[i]["ColorOneID"]) > 0)
                        {
                            if (dtColorOne.Select("(ColorOneID=" + dtInfo.Rows[i]["ColorOneID"] + ")").Length == 0)
                            {
                                dtColorOne.Rows.Add(dtColorOne.NewRow());
                                dtColorOne.Rows[dtColorOne.Rows.Count - 1]["ColorOneID"] = dtInfo.Rows[i]["ColorOneID"];
                            }
                        }
                        if (Convert.ToInt32(dtInfo.Rows[i]["ColorOneID"]) > 0)
                        {
                            if (dtColorTwo.Select("(ColorTwoID=" + dtInfo.Rows[i]["ColorTwoID"] + ")").Length == 0)
                            {
                                dtColorTwo.Rows.Add(dtColorTwo.NewRow());
                                dtColorTwo.Rows[dtColorTwo.Rows.Count - 1]["ColorTwoID"] = dtInfo.Rows[i]["ColorTwoID"];
                            }
                        }
                        strWhere = "(ColorID=" + dtInfo.Rows[i]["ColorID"] + ") And (ColorOneID=" + dtInfo.Rows[i]["ColorOneID"] + ") And (ColorTwoID=" + dtInfo.Rows[i]["ColorTwoID"] + ")";
                        if (dtAllColor.Select(strWhere).Length == 0)
                        {
                            dtAllColor.Rows.Add(dtAllColor.NewRow());
                            dtAllColor.Rows[dtAllColor.Rows.Count - 1]["ColorID"] = dtInfo.Rows[i]["ColorID"];
                            dtAllColor.Rows[dtAllColor.Rows.Count - 1]["ColorOneID"] = dtInfo.Rows[i]["ColorOneID"];
                            dtAllColor.Rows[dtAllColor.Rows.Count - 1]["ColorTwoID"] = dtInfo.Rows[i]["ColorTwoID"];
                        }
                    }
                    DataRow[] drs;
                    int _amount = 0;
                    for (int i = 0; i < dtColor.Rows.Count; i++)
                    {
                        _amount = 0;
                        strWhere = "(ColorID=" + dtColor.Rows[i]["ColorID"] + ") ";//And (ColorOneID=" + dtColor.Rows[i]["ColorOneID"] + ") And (ColorTwoID=" + dtColor.Rows[i]["ColorTwoID"] + ")";
                        drs = dtInfo.Select(strWhere);
                        for (int r = 0; r < drs.Length; r++)
                        {
                            _amount += Convert.ToInt32(drs[r]["Amount"]);
                        }
                        dtColor.Rows[i]["SumAmount"] = dtColor.Rows[i]["SumNotAmount"] = _amount;
                    }
                    for (int i = 0; i < dtColorOne.Rows.Count; i++)
                    {
                        _amount = 0;
                        strWhere = "(ColorOneID=" + dtColorOne.Rows[i]["ColorOneID"] + ") ";//And (ColorOneID=" + dtColor.Rows[i]["ColorOneID"] + ") And (ColorTwoID=" + dtColor.Rows[i]["ColorTwoID"] + ")";
                        drs = dtInfo.Select(strWhere);
                        for (int r = 0; r < drs.Length; r++)
                        {
                            _amount += Convert.ToInt32(drs[r]["Amount"]);
                        }
                        dtColorOne.Rows[i]["SumAmount"] = dtColorOne.Rows[i]["SumNotAmount"] = _amount;
                    }
                    for (int i = 0; i < dtColorTwo.Rows.Count; i++)
                    {
                        _amount = 0;
                        strWhere = "(ColorTwoID=" + dtColorTwo.Rows[i]["ColorTwoID"] + ") ";//And (ColorOneID=" + dtColor.Rows[i]["ColorOneID"] + ") And (ColorTwoID=" + dtColor.Rows[i]["ColorTwoID"] + ")";
                        drs = dtInfo.Select(strWhere);
                        for (int r = 0; r < drs.Length; r++)
                        {
                            _amount += Convert.ToInt32(drs[r]["Amount"]);
                        }
                        dtColorTwo.Rows[i]["SumAmount"] = dtColorTwo.Rows[i]["SumNotAmount"] = _amount;
                    }
                    for (int i = 0; i < dtSize.Rows.Count; i++)
                    {
                        _amount = 0;
                        strWhere = "(SizeID=" + dtSize.Rows[i]["SizeID"] + ")";
                        drs = dtInfo.Select(strWhere);
                        for (int r = 0; r < drs.Length; r++)
                        {
                            object o = drs[r]["Amount"];
                            if (drs[r]["Amount"] != DBNull.Value || drs[r]["Amount"].ToString() != string.Empty)
                                _amount += Convert.ToInt32(drs[r]["Amount"]);
                        }
                        dtSize.Rows[i]["SumAmount"] = _amount;
                    }
                    for(int i=0;i<dtAllColor.Rows.Count;i++)
                    {
                        _amount = 0;
                        strWhere = "(ColorID=" + dtAllColor.Rows[i]["ColorID"] + ") And (ColorOneID=" + dtAllColor.Rows[i]["ColorOneID"] + ") And (ColorTwoID=" + dtAllColor.Rows[i]["ColorTwoID"] + ")";
                        drs = dtInfo.Select(strWhere);
                        for(int r=0;r<drs.Length;r++)
                        {
                            _amount += Convert.ToInt32(drs[r]["Amount"]);
                        }
                        dtAllColor.Rows[i]["SumAmount"] = dtAllColor.Rows[i]["SumNotAmount"] = _amount;
                    }
                }
                DataTable dtSizeBow = Hownet.BLL.BaseFile.ZipDt.Byte2Ds(bb).Tables[0];
                //  DataTable dtSizeBow = bllSB.GetList("(TaskID=" + TaskID + ")").Tables[0];
                #region 钢弓
                int depFZID = bllOT.GetID("缝制");
                if (dtSizeBow.Rows.Count > 0)
                {
                    DataRow[] drsbow;
                    for (int c = 0; c < dtSize.Rows.Count; c++)
                    {
                        //int maID = bllMa.GetID(bllSB.GetBowValue(TaskID, int.Parse(dtSize.DefaultView[c]["SumAmount"].ToString())));
                        drsbow = dtSizeBow.Select("(SizeID=" + dtSize.Rows[c]["SizeID"] + ")");
                        if (drsbow.Length > 0)
                        {
                            int maID = int.Parse(drsbow[0]["BowID"].ToString());
                            if (maID > 0)
                            {
                                Hownet.Model.Materiel modMa = bllMa.GetModel(maID);
                                ArrayList li = new ArrayList();
                                li.Clear();
                                li.Add(maID.ToString());
                                li.Add("0");
                                li.Add("0");
                                li.Add("0");
                                li.Add("0");
                                li.Add(dtSize.DefaultView[c]["SumAmount"].ToString());
                                li.Add(dtSize.DefaultView[c]["SumAmount"].ToString());
                                li.Add(modMa.MeasureID.ToString());
                                li.Add(modMa.AttributeID.ToString());
                                li.Add("1");
                                li.Add(depFZID.ToString());
                                string[] ros = (string[])li.ToArray(typeof(string));
                                DemandInfo.Rows.Add(ros);
                            }
                        }
                    }
                #endregion
                    #region 透明肩带
                    for (int c = 0; c < dtSize.Rows.Count; c++)
                    {
                        drsbow = dtSizeBow.Select("(SizeID=" + dtSize.Rows[c]["SizeID"] + ")");
                        if (drsbow.Length > 0)
                        {
                            int maID = int.Parse(drsbow[0]["OpenSash"].ToString());
                            if (maID > 0)
                            {
                                Hownet.Model.Materiel modMa = bllMa.GetModel(maID);
                                ArrayList li = new ArrayList();
                                li.Clear();
                                li.Add(maID.ToString());
                                li.Add("0");
                                li.Add("0");
                                li.Add("0");
                                li.Add("0");
                                li.Add(dtSize.DefaultView[c]["SumAmount"].ToString());
                                li.Add(dtSize.DefaultView[c]["SumAmount"].ToString());
                                li.Add(modMa.MeasureID.ToString());
                                li.Add(modMa.AttributeID.ToString());
                                li.Add("1");
                                li.Add(depFZID.ToString());
                                string[] ros = (string[])li.ToArray(typeof(string));
                                DemandInfo.Rows.Add(ros);
                            }
                        }
                    }
                    #endregion
                    #region 胶骨
                    for (int c = 0; c < dtSize.Rows.Count; c++)
                    {
                        drsbow = dtSizeBow.Select("(SizeID=" + dtSize.Rows[c]["SizeID"] + ")");
                        if (drsbow.Length > 0)
                        {
                            int maID = int.Parse(drsbow[0]["PlasticBone"].ToString());
                            if (maID > 0)
                            {
                                Hownet.Model.Materiel modMa = bllMa.GetModel(maID);
                                ArrayList li = new ArrayList();
                                li.Clear();
                                li.Add(maID.ToString());
                                li.Add("0");
                                li.Add("0");
                                li.Add("0");
                                li.Add("0");
                                li.Add(dtSize.DefaultView[c]["SumAmount"].ToString());
                                li.Add(dtSize.DefaultView[c]["SumAmount"].ToString());
                                li.Add(modMa.MeasureID.ToString());
                                li.Add(modMa.AttributeID.ToString());
                                li.Add("1");
                                li.Add(depFZID.ToString());
                                string[] ros = (string[])li.ToArray(typeof(string));
                                DemandInfo.Rows.Add(ros);
                            }
                        }
                    }
                    #endregion
                    #region 棉碗
                    for (int c = 0; c < dtSize.Rows.Count; c++)
                    {
                        drsbow = dtSizeBow.Select("(SizeID=" + dtSize.Rows[c]["SizeID"] + ")");
                        //int maID = bllMa.GetID(bllSB.GetCottonValue(TaskID, int.Parse(dtSize.DefaultView[c]["SumAmount"].ToString())));
                        if (drsbow.Length > 0)
                        {
                            int maID = int.Parse(drsbow[0]["CottonID"].ToString());
                            if (maID > 0)
                            {
                                Hownet.Model.Materiel modMa = bllMa.GetModel(maID);
                                ArrayList li = new ArrayList();

                                modAI.SizeID = int.Parse(dtSize.DefaultView[c]["SizeID"].ToString());
                                for (int i = 0; i < dtColor.Rows.Count; i++)
                                {
                                    li.Clear();
                                    li.Add(maID.ToString());
                                    modAI.ColorID = int.Parse(dtColor.DefaultView[i]["ColorID"].ToString());
                                    li.Add(modAI.ColorID.ToString());
                                    li.Add("0");
                                    li.Add("0");
                                    li.Add("0");
                                    DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorID=" + modAI.ColorID + ")");
                                    if (drs.Length > 0)
                                    {
                                        if (drs[0]["Amount"].ToString() != "")
                                            modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                        else
                                            modAI.Amount = 0;
                                        li.Add(modAI.Amount.ToString());
                                        li.Add(modAI.Amount.ToString());
                                        li.Add(modMa.MeasureID.ToString());
                                        li.Add(modMa.AttributeID.ToString());
                                        li.Add("1");
                                        li.Add(depFZID.ToString());
                                        string[] ros = (string[])li.ToArray(typeof(string));
                                        DemandInfo.Rows.Add(ros);
                                    }
                                }
                            }
                        }
                    }
                    #endregion
                    #region 成品肩带
                    for (int c = 0; c < dtSize.Rows.Count; c++)
                    {
                        drsbow = dtSizeBow.Select("(SizeID=" + dtSize.Rows[c]["SizeID"] + ")");
                        if (drsbow.Length > 0)
                        {
                            int maID = int.Parse(drsbow[0]["Sash"].ToString());
                            if (maID > 0)
                            {
                                Hownet.Model.Materiel modMa = bllMa.GetModel(maID);
                                ArrayList li = new ArrayList();

                                modAI.SizeID = int.Parse(dtSize.DefaultView[c]["SizeID"].ToString());
                                for (int i = 0; i < dtColor.Rows.Count; i++)
                                {
                                    li.Clear();
                                    li.Add(maID.ToString());
                                    modAI.ColorID = int.Parse(dtColor.DefaultView[i]["ColorID"].ToString());
                                    li.Add(modAI.ColorID.ToString());
                                    li.Add("0");
                                    li.Add("0");
                                    li.Add("0");
                                    DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorID=" + modAI.ColorID + ")");
                                    if (drs.Length > 0)
                                    {
                                        if (drs[0]["Amount"].ToString() != "")
                                            modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                        else
                                            modAI.Amount = 0;
                                        li.Add(modAI.Amount.ToString());
                                        li.Add(modAI.Amount.ToString());
                                        li.Add(modMa.MeasureID.ToString());
                                        li.Add(modMa.AttributeID.ToString());
                                        li.Add("1");
                                        li.Add(depFZID.ToString());
                                        string[] ros = (string[])li.ToArray(typeof(string));
                                        DemandInfo.Rows.Add(ros);
                                    }
                                }
                            }
                        }
                    }
                }
                    #endregion
                try
                {
                    DataTable dtBrand = bllMSM.GetBrandList(BrandID).Tables[0];
                    if (dtBrand.Rows.Count > 0)
                    {
                        for (int r = 0; r < dtBrand.Rows.Count; r++)
                        {
                            int a = int.Parse(dtBrand.DefaultView[r]["UsingTypeID"].ToString());
                            if (a < 4 || a > 7)
                            {
                                #region 按主色、不用颜色、特殊配色
                                for (int c = 0; c < dtColor.Rows.Count; c++)
                                {
                                    DataRow dr = DemandInfo.NewRow();
                                    dr["MaterielID"] = dtBrand.DefaultView[r]["ChildMaterielID"];
                                    switch (a)
                                    {
                                        case 1://按主色
                                            {
                                                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 2://按插色一
                                            {
                                                dr["ColorID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 3://按插色二
                                            {
                                                dr["ColorID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }

                                        case 8://按主色+插色一
                                            {
                                                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                                                dr["colorOneID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 9://按主色+插色二
                                            {
                                                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                                                dr["colorOneID"] = dtColorOne.DefaultView[c]["ColorTwoID"];
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 10://按插色一+插色二
                                            {
                                                dr["ColorID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                                                dr["colorOneID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 11://按主色+插色一+插色二
                                            {
                                                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                                                dr["colorOneID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                                                dr["ColorTwoID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 12://都不用
                                            {
                                                dr["ColorID"] = 0;
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                    }
                                    double amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(dtBrand.DefaultView[r]["Wastage"].ToString()));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString());
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = dtBrand.DefaultView[r]["MeasureID"];
                                    dr["AttribID"] = dtBrand.DefaultView[r]["AttributeID"];
                                    dr["Stata"] = 1;
                                    if (dtBrand.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = dtBrand.DefaultView[r]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    DemandInfo.Rows.Add(dr);
                                }
                                #endregion
                            }
                            else
                            {
                                #region 按尺码、主色+尺码
                                for (int c = 0; c < dtSize.Rows.Count; c++)
                                {
                                    modAI.SizeID = int.Parse(dtSize.DefaultView[c]["SizeID"].ToString());
                                    if (a == 4)
                                    {
                                        DataRow dr = DemandInfo.NewRow();
                                        dr["MaterielID"] = dtBrand.DefaultView[r]["ChildMaterielID"];
                                        dr["MeasureID"] = dtBrand.DefaultView[r]["MeasureID"];
                                        dr["AttribID"] = dtBrand.DefaultView[r]["AttributeID"];
                                        dr["Stata"] = 1;
                                        if (dtBrand.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                        {
                                            dr["DepID"] = dtBrand.DefaultView[r]["DepartmentID"];
                                        }
                                        else
                                        {
                                            dr["DepID"] = 0;
                                        }
                                        dr["ColorID"] = 0;
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = dtSize.DefaultView[c]["SizeID"];
                                        double amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * double.Parse(dtSize.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(dtBrand.DefaultView[r]["Wastage"].ToString()));
                                        dr["StockAmount"] = amount.ToString("N5");
                                        amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * double.Parse(dtSize.DefaultView[c]["SumAmount"].ToString());
                                        dr["Amount"] = amount.ToString("N5");
                                        DemandInfo.Rows.Add(dr);
                                    }
                                    else if (a == 5)
                                    {
                                        for (int i = 0; i < dtColor.Rows.Count; i++)
                                        {
                                            DataRow dr = DemandInfo.NewRow();
                                            dr["MaterielID"] = dtBrand.DefaultView[r]["ChildMaterielID"];
                                            dr["MeasureID"] = dtBrand.DefaultView[r]["MeasureID"];
                                            dr["AttribID"] = dtBrand.DefaultView[r]["AttributeID"];
                                            dr["Stata"] = 1;
                                            if (dtBrand.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                            {
                                                dr["DepID"] = dtBrand.DefaultView[r]["DepartmentID"];
                                            }
                                            else
                                            {
                                                dr["DepID"] = 0;
                                            }
                                            modAI.ColorID = int.Parse(dtColor.DefaultView[i]["ColorID"].ToString());
                                            dr["ColorID"] = modAI.ColorID;
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = modAI.SizeID;
                                            DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorID=" + modAI.ColorID + ")");
                                            if (drs.Length > 0)
                                            {
                                                if (drs[0]["Amount"].ToString() != "")
                                                    modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                                else
                                                    modAI.Amount = 0;
                                                double amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(dtBrand.DefaultView[r]["Wastage"].ToString()));
                                                dr["StockAmount"] = amount.ToString("N5");
                                                amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                dr["Amount"] = amount.ToString("N5");
                                                DemandInfo.Rows.Add(dr);
                                            }
                                        }
                                    }
                                    //插色一+尺码
                                    else if (a == 6)
                                    {
                                        for (int i = 0; i < dtColorOne.Rows.Count; i++)
                                        {
                                            DataRow dr = DemandInfo.NewRow();
                                            dr["MaterielID"] = dtBrand.DefaultView[r]["ChildMaterielID"];
                                            dr["MeasureID"] = dtBrand.DefaultView[r]["MeasureID"];
                                            dr["AttribID"] = dtBrand.DefaultView[r]["AttributeID"];
                                            dr["Stata"] = 1;
                                            if (dtBrand.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                            {
                                                dr["DepID"] = dtBrand.DefaultView[r]["DepartmentID"];
                                            }
                                            else
                                            {
                                                dr["DepID"] = 0;
                                            }
                                            modAI.ColorID = int.Parse(dtColorOne.DefaultView[i]["ColorOneID"].ToString());
                                            dr["ColorID"] = modAI.ColorID;
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = modAI.SizeID;
                                            DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorOneID=" + modAI.ColorOneID + ")");
                                            if (drs.Length > 0)
                                            {
                                                if (drs[0]["Amount"].ToString() != "")
                                                    modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                                else
                                                    modAI.Amount = 0;
                                                double amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(dtBrand.DefaultView[r]["Wastage"].ToString()));
                                                dr["StockAmount"] = amount.ToString("N5");
                                                amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                dr["Amount"] = amount.ToString("N5");
                                                DemandInfo.Rows.Add(dr);
                                            }
                                        }
                                    }
                                    //插色二+尺码
                                    else if (a == 7)
                                    {
                                        for (int i = 0; i < dtColorTwo.Rows.Count; i++)
                                        {
                                            DataRow dr = DemandInfo.NewRow();
                                            dr["MaterielID"] = dtBrand.DefaultView[r]["ChildMaterielID"];
                                            dr["MeasureID"] = dtBrand.DefaultView[r]["MeasureID"];
                                            dr["AttribID"] = dtBrand.DefaultView[r]["AttributeID"];
                                            dr["Stata"] = 1;
                                            if (dtBrand.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                            {
                                                dr["DepID"] = dtBrand.DefaultView[r]["DepartmentID"];
                                            }
                                            else
                                            {
                                                dr["DepID"] = 0;
                                            }
                                            modAI.ColorID = int.Parse(dtColorTwo.DefaultView[i]["ColorTwoID"].ToString());
                                            dr["ColorID"] = modAI.ColorID;
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = modAI.SizeID;
                                            DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorTwoID=" + modAI.ColorTwoID + ")");
                                            if (drs.Length > 0)
                                            {
                                                if (drs[0]["Amount"].ToString() != "")
                                                    modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                                else
                                                    modAI.Amount = 0;
                                                double amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(dtBrand.DefaultView[r]["Wastage"].ToString()));
                                                dr["StockAmount"] = amount.ToString("N5");
                                                amount = double.Parse(dtBrand.DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                dr["Amount"] = amount.ToString("N5");
                                                DemandInfo.Rows.Add(dr);
                                            }
                                        }
                                    }
                                }
                                #endregion
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                }
                //取得该款号的BOM清单
                DataSet ds = bllMSM.GetDemandList(BOMID);
                bool t = false;
                if (ds.Tables.Count > 0)
                {
                    for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
                    {
                        int a = int.Parse(ds.Tables[0].DefaultView[r]["UsingTypeID"].ToString());
                        if (a < 4 || a > 7)
                        {
                            if (a == 1)
                            {
                                for (int c = 0; c < dtColor.Rows.Count; c++)
                                {
                                    try
                                    {
                                        DataRow dr = DemandInfo.NewRow();
                                        t = false;
                                        dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                        dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                        dr["StockAmount"] = amount.ToString("N5");
                                        amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString());
                                        dr["Amount"] = amount.ToString("N5");
                                        dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                        dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                        dr["Stata"] = 1;
                                        if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                        {
                                            dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                        }
                                        else
                                        {
                                            dr["DepID"] = 0;
                                        }
                                        if (!t)
                                            DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 2)//按插色一
                            {
                                for (int c = 0; c < dtColorOne.Rows.Count; c++)
                                {
                                    try{
                                    DataRow dr = DemandInfo.NewRow();
                                    t = false;
                                    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                    dr["ColorID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                                    dr["colorOneID"] = 0;
                                    dr["ColorTwoID"] = 0;
                                    dr["SizeID"] = 0;
                                    double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColorOne.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColorOne.DefaultView[c]["SumAmount"].ToString());
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                    dr["Stata"] = 1;
                                    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    if (!t)
                                        DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 3)//按插色二
                            {
                                for (int c = 0; c < dtColorTwo.Rows.Count; c++)
                                {
                                    try{
                                    DataRow dr = DemandInfo.NewRow();
                                    t = false;
                                    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                    dr["ColorID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                                    dr["colorOneID"] = 0;
                                    dr["ColorTwoID"] = 0;
                                    dr["SizeID"] = 0;
                                    double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColorTwo.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColorTwo.DefaultView[c]["SumAmount"].ToString());
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                    dr["Stata"] = 1;
                                    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    if (!t)
                                        DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 8)//按主色+插色一
                            {
                                for (int c = 0; c < dtAllColor.Rows.Count; c++)
                                {
                                    try{
                                    DataRow dr = DemandInfo.NewRow();
                                    t = false;
                                    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                    dr["ColorID"] = dtAllColor.DefaultView[c]["ColorID"];
                                    dr["colorOneID"] = dtAllColor.DefaultView[c]["ColorOneID"];
                                    dr["ColorTwoID"] = 0;
                                    dr["SizeID"] = 0;
                                    double amount = Convert.ToDouble(ds.Tables[0].DefaultView[r]["Amount"]) * Convert.ToDouble(dtAllColor.DefaultView[c]["SumAmount"]) * (1 + Convert.ToDouble(ds.Tables[0].DefaultView[r]["Wastage"]));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = Convert.ToDouble(ds.Tables[0].DefaultView[r]["Amount"]) * Convert.ToDouble(dtAllColor.DefaultView[c]["SumAmount"]);
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                    dr["Stata"] = 1;
                                    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    if (!t)
                                        DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 9)//按主色+插色二
                            {
                                for (int c = 0; c < dtAllColor.Rows.Count; c++)
                                {
                                    try{
                                    DataRow dr = DemandInfo.NewRow();
                                    t = false;
                                    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                    dr["ColorID"] = dtAllColor.DefaultView[c]["ColorID"];
                                    dr["colorOneID"] = dtAllColor.DefaultView[c]["ColorTwoID"];
                                    dr["ColorTwoID"] = 0;
                                    dr["SizeID"] = 0;
                                    double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtAllColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtAllColor.DefaultView[c]["SumAmount"].ToString());
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                    dr["Stata"] = 1;
                                    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    if (!t)
                                        DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 10)//按插色一+插色二
                            {
                                for (int c = 0; c < dtAllColor.Rows.Count; c++)
                                {
                                    try{
                                    DataRow dr = DemandInfo.NewRow();
                                    t = false;
                                    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                    dr["ColorID"] = dtAllColor.DefaultView[c]["ColorOneID"];
                                    dr["colorOneID"] = dtAllColor.DefaultView[c]["ColorTwoID"];
                                    dr["ColorTwoID"] = 0;
                                    dr["SizeID"] = 0;
                                    double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtAllColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtAllColor.DefaultView[c]["SumAmount"].ToString());
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                    dr["Stata"] = 1;
                                    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    if (!t)
                                        DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 11)//按主色+插色一+插色二
                            {
                                for (int c = 0; c < dtAllColor.Rows.Count; c++)
                                {
                                    try{
                                    DataRow dr = DemandInfo.NewRow();
                                    t = false;
                                    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                    dr["ColorID"] = dtAllColor.DefaultView[c]["ColorID"];
                                    dr["colorOneID"] = dtAllColor.DefaultView[c]["ColorOneID"];
                                    dr["ColorTwoID"] = dtAllColor.DefaultView[c]["ColorTwoID"]; ;
                                    dr["SizeID"] = 0;
                                    double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtAllColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtAllColor.DefaultView[c]["SumAmount"].ToString());
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                    dr["Stata"] = 1;
                                    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    if (!t)
                                        DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 12)//都不用
                            {
                                for (int c = 0; c < dtColor.Rows.Count; c++)
                                {
                                    try
                                    {
                                        DataRow dr = DemandInfo.NewRow();
                                        t = false;
                                        dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                        dr["ColorID"] = 0;
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                        dr["StockAmount"] = amount.ToString("N5");
                                        amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString());
                                        dr["Amount"] = amount.ToString("N5");
                                        dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                        dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                        dr["Stata"] = 1;
                                        if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                        {
                                            dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                        }
                                        else
                                        {
                                            dr["DepID"] = 0;
                                        }
                                        if (!t)
                                            DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            else if (a == 13)
                            {
                                for (int c = 0; c < dtColor.Rows.Count; c++)
                                {
                                    try
                                    {
                                        DataRow dr = DemandInfo.NewRow();
                                        t = false;
                                        dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                        DataTable dtSC = bllMSI.GetList("(MSIID=" + ds.Tables[0].DefaultView[r]["InfoID"] + ")").Tables[0];// bllSC.GetList("(MaterielID=" + ds.Tables[0].DefaultView[r]["ChildMaterielID"] + ")").Tables[0];
                                        if (dtSC.Rows.Count == 0)
                                            break;
                                        DataRow[] drs = dtSC.Select("(ColorID=" + dtColor.DefaultView[c]["ColorID"] + ") And (CompanyID=" + CompanyID + ")");
                                        if (drs.Length == 0)
                                        {
                                            drs = dtSC.Select("(ColorID=" + dtColor.DefaultView[c]["ColorID"] + ") And (CompanyID=0)");
                                            if (drs.Length == 0)
                                            {
                                                drs = dtSC.Select("(ColorID=0) And (CompanyID=0)");
                                                if (drs.Length == 0)
                                                {
                                                    t = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (Convert.ToInt32(drs[0]["ChildMaterielID"]) > 0)
                                            dr["MaterielID"] = drs[0]["ChildMaterielID"];
                                        if (Convert.ToInt32(drs[0]["ToColorID"]) > 0)
                                            dr["ColorID"] = drs[0]["ToColorID"];
                                        else
                                            dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                        dr["StockAmount"] = amount.ToString("N5");
                                        amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString());
                                        dr["Amount"] = amount.ToString("N5");
                                        dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                        dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                        dr["Stata"] = 1;
                                        if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                        {
                                            dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                        }
                                        else
                                        {
                                            dr["DepID"] = 0;
                                        }
                                        if (!t)
                                            DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                            }
                            //for (int c = 0; c < dtColor.Rows.Count; c++)
                            //{
                            //    DataRow dr = DemandInfo.NewRow();
                            //    t = false;
                            //    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                            //    #region 使用方法
                            //    switch (a)
                            //    {
                            //        case 12://都不用
                            //            {
                            //                dr["ColorID"] = 0;
                            //                dr["colorOneID"] = 0;
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        #region 特殊配色
                            //        case 13://特殊配色
                            //            {
                            //                DataTable dtSC = bllMSI.GetList("(MSIID=" + ds.Tables[0].DefaultView[r]["InfoID"] + ")").Tables[0];// bllSC.GetList("(MaterielID=" + ds.Tables[0].DefaultView[r]["ChildMaterielID"] + ")").Tables[0];
                            //                if (dtSC.Rows.Count == 0)
                            //                    break;
                            //                DataRow[] drs = dtSC.Select("(ColorID=" + dtColor.DefaultView[c]["ColorID"] + ") And (CompanyID=" + CompanyID + ")");
                            //                if (drs.Length == 0)
                            //                {
                            //                    drs = dtSC.Select("(ColorID=" + dtColor.DefaultView[c]["ColorID"] + ") And (CompanyID=0)");
                            //                    if (drs.Length == 0)
                            //                    {
                            //                        drs = dtSC.Select("(ColorID=0) And (CompanyID=0)");
                            //                        if (drs.Length == 0)
                            //                        {
                            //                            t = true;
                            //                            break;
                            //                        }
                            //                    }
                            //                }
                            //                if (Convert.ToInt32(drs[0]["ChildMaterielID"]) > 0)
                            //                    dr["MaterielID"] = drs[0]["ChildMaterielID"];
                            //                if (Convert.ToInt32(drs[0]["ToColorID"]) > 0)
                            //                    dr["ColorID"] = drs[0]["ToColorID"];
                            //                else
                            //                    dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                            //                dr["colorOneID"] = 0;
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        #endregion
                            //    }
                            //    #endregion
                            //    double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                            //    dr["StockAmount"] = amount.ToString("N5");
                            //    amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString());
                            //    dr["Amount"] = amount.ToString("N5");
                            //    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                            //    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                            //    dr["Stata"] = 1;
                            //    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                            //    {
                            //        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                            //    }
                            //    else
                            //    {
                            //        dr["DepID"] = 0;
                            //    }
                            //    if (!t)
                            //        DemandInfo.Rows.Add(dr);
                            //}

                            //for (int c = 0; c < dtColor.Rows.Count; c++)
                            //{
                            //    DataRow dr = DemandInfo.NewRow();
                            //    t = false;
                            //    dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                            //    #region 使用方法
                            //    switch (a)
                            //    {
                            //        case 1://按主色
                            //            {
                            //                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                            //                dr["colorOneID"] = 0;
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        case 2://按插色一
                            //            {
                            //                dr["ColorID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                            //                dr["colorOneID"] = 0;
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        case 3://按插色二
                            //            {
                            //                dr["ColorID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                            //                dr["colorOneID"] = 0;
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }

                            //        case 8://按主色+插色一
                            //            {
                            //                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                            //                dr["colorOneID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        case 9://按主色+插色二
                            //            {
                            //                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                            //                dr["colorOneID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        case 10://按插色一+插色二
                            //            {
                            //                dr["ColorID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                            //                dr["colorOneID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        case 11://按主色+插色一+插色二
                            //            {
                            //                dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                            //                dr["colorOneID"] = dtColorOne.DefaultView[c]["ColorOneID"];
                            //                dr["ColorTwoID"] = dtColorTwo.DefaultView[c]["ColorTwoID"];
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        case 12://都不用
                            //            {
                            //                dr["ColorID"] = 0;
                            //                dr["colorOneID"] = 0;
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        #region 特殊配色
                            //        case 13://特殊配色
                            //            {
                            //                DataTable dtSC = bllMSI.GetList("(MSIID=" + ds.Tables[0].DefaultView[r]["InfoID"] + ")").Tables[0];// bllSC.GetList("(MaterielID=" + ds.Tables[0].DefaultView[r]["ChildMaterielID"] + ")").Tables[0];
                            //                if (dtSC.Rows.Count == 0)
                            //                    break;
                            //                DataRow[] drs = dtSC.Select("(ColorID=" + dtColor.DefaultView[c]["ColorID"] + ") And (CompanyID=" + CompanyID + ")");
                            //                if (drs.Length == 0)
                            //                {
                            //                    drs = dtSC.Select("(ColorID=" + dtColor.DefaultView[c]["ColorID"] + ") And (CompanyID=0)");
                            //                    if (drs.Length == 0)
                            //                    {
                            //                        drs = dtSC.Select("(ColorID=0) And (CompanyID=0)");
                            //                        if (drs.Length == 0)
                            //                        {
                            //                            t = true;
                            //                            break;
                            //                        }
                            //                    }
                            //                }
                            //                if (Convert.ToInt32(drs[0]["ChildMaterielID"]) > 0)
                            //                    dr["MaterielID"] = drs[0]["ChildMaterielID"];
                            //                if (Convert.ToInt32(drs[0]["ToColorID"]) > 0)
                            //                    dr["ColorID"] = drs[0]["ToColorID"];
                            //                else
                            //                    dr["ColorID"] = dtColor.DefaultView[c]["ColorID"];
                            //                dr["colorOneID"] = 0;
                            //                dr["ColorTwoID"] = 0;
                            //                dr["SizeID"] = 0;
                            //                break;
                            //            }
                            //        #endregion
                            //    }
                            //    #endregion
                            //    double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                            //    dr["StockAmount"] = amount.ToString("N5");
                            //    amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtColor.DefaultView[c]["SumAmount"].ToString());
                            //    dr["Amount"] = amount.ToString("N5");
                            //    dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                            //    dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                            //    dr["Stata"] = 1;
                            //    if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                            //    {
                            //        dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                            //    }
                            //    else
                            //    {
                            //        dr["DepID"] = 0;
                            //    }
                            //    if (!t)
                            //        DemandInfo.Rows.Add(dr);
                            //}
                        }
                        else
                        {
                            for (int c = 0; c < dtSize.Rows.Count; c++)
                            {
                                modAI.SizeID = int.Parse(dtSize.DefaultView[c]["SizeID"].ToString());

                                #region 与尺码相关的BOM
                                switch (a)
                                {
                                    case 4://按尺码
                                        {
                                            DataRow dr = DemandInfo.NewRow();
                                            dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                            dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                            dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                            dr["Stata"] = 1;
                                            if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                            {
                                                dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                            }
                                            else
                                            {
                                                dr["DepID"] = 0;
                                            }
                                            dr["ColorID"] = 0;
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = dtSize.DefaultView[c]["SizeID"];
                                            double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtSize.DefaultView[c]["SumAmount"].ToString()) * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                            dr["StockAmount"] = amount.ToString("N5");
                                            amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * double.Parse(dtSize.DefaultView[c]["SumAmount"].ToString());
                                            dr["Amount"] = amount.ToString("N5");
                                            DemandInfo.Rows.Add(dr);
                                            break;
                                        }
                                    case 5://按主色+尺码
                                        {
                                            for (int i = 0; i < dtColor.Rows.Count; i++)
                                            {
                                                DataRow dr = DemandInfo.NewRow();
                                                dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                                dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                                dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                                dr["Stata"] = 1;
                                                if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                                {
                                                    dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                                }
                                                else
                                                {
                                                    dr["DepID"] = 0;
                                                }
                                                modAI.ColorID = int.Parse(dtColor.DefaultView[i]["ColorID"].ToString());
                                                dr["ColorID"] = modAI.ColorID;
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = modAI.SizeID;
                                                DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorID=" + modAI.ColorID + ")");
                                                if (drs.Length > 0)
                                                {
                                                    for (int m = 0; m < drs.Length; m++)
                                                    {
                                                        if (drs[m]["Amount"].ToString() != "")
                                                            modAI.Amount = int.Parse(drs[m]["Amount"].ToString());
                                                        else
                                                            modAI.Amount = 0;
                                                        double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                                        dr["StockAmount"] = amount.ToString("N5");
                                                        amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                        dr["Amount"] = amount.ToString("N5");
                                                        DemandInfo.Rows.Add(dr.ItemArray);
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                    case 6://按插色一+尺码
                                        {
                                            for (int i = 0; i < dtColorOne.Rows.Count; i++)
                                            {
                                                DataRow dr = DemandInfo.NewRow();
                                                dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                                dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                                dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                                dr["Stata"] = 1;
                                                if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                                {
                                                    dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                                }
                                                else
                                                {
                                                    dr["DepID"] = 0;
                                                }
                                                modAI.ColorID = int.Parse(dtColorOne.DefaultView[i]["ColorOneID"].ToString());
                                                dr["ColorID"] = modAI.ColorID;
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = modAI.SizeID;
                                                DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorOneID=" + modAI.ColorID + ")");
                                                if (drs.Length > 0)
                                                {
                                                    for (int m = 0; m < drs.Length; m++)
                                                    {
                                                        if (drs[m]["Amount"].ToString() != "")
                                                            modAI.Amount = int.Parse(drs[m]["Amount"].ToString());
                                                        else
                                                            modAI.Amount = 0;
                                                        double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                                        dr["StockAmount"] = amount.ToString("N5");
                                                        amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                        dr["Amount"] = amount.ToString("N5");
                                                        DemandInfo.Rows.Add(dr.ItemArray);
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                    case 7://按插色二+尺码
                                        {
                                            for (int i = 0; i < dtColorTwo.Rows.Count; i++)
                                            {
                                                DataRow dr = DemandInfo.NewRow();
                                                dr["MaterielID"] = ds.Tables[0].DefaultView[r]["ChildMaterielID"];
                                                dr["MeasureID"] = ds.Tables[0].DefaultView[r]["MeasureID"];
                                                dr["AttribID"] = ds.Tables[0].DefaultView[r]["AttributeID"];
                                                dr["Stata"] = 1;
                                                if (ds.Tables[0].DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                                {
                                                    dr["DepID"] = ds.Tables[0].DefaultView[r]["DepartmentID"];
                                                }
                                                else
                                                {
                                                    dr["DepID"] = 0;
                                                }
                                                modAI.ColorID = int.Parse(dtColorTwo.DefaultView[i]["ColorTwoID"].ToString());
                                                dr["ColorID"] = modAI.ColorID;
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = modAI.SizeID;
                                                DataRow[] drs = dtInfo.Select("(SizeID=" + modAI.SizeID + ") and (ColorTwoID=" + modAI.ColorID + ")");
                                                if (drs.Length > 0)
                                                {
                                                    for (int m = 0; m < drs.Length; m++)
                                                    {
                                                        if (drs[m]["Amount"].ToString() != "")
                                                            modAI.Amount = int.Parse(drs[m]["Amount"].ToString());
                                                        else
                                                            modAI.Amount = 0;
                                                        double amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(ds.Tables[0].DefaultView[r]["Wastage"].ToString()));
                                                        dr["StockAmount"] = amount.ToString("N5");
                                                        amount = double.Parse(ds.Tables[0].DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                        dr["Amount"] = amount.ToString("N5");
                                                        DemandInfo.Rows.Add(dr.ItemArray);
                                                    }
                                                }
                                            }
                                            break;
                                        }
                                }
                                #endregion
                            }
                        }
                    }
                }
                else
                {
                    DemandInfo.Rows.Add(DemandInfo.NewRow());
                }
                DataTable dtDemand = GroupTableOne(DemandInfo);
                for (int r = 0; r < dtDemand.Rows.Count; r++)
                {
                    object o = dtDemand.Rows[r]["AttribID"];
                    object aaaa = dtDemand.Rows[r]["Stata"];
                    if (int.Parse(dtDemand.Rows[r]["AttribID"].ToString()) < 4 && dtDemand.Rows[r]["Stata"].ToString() == "1")
                    {
                        object mmm = dtDemand.DefaultView[r]["MaterielID"];
                        DataSet dsMs = bllMSM.GetDemandChildMateriel(int.Parse(dtDemand.DefaultView[r]["MaterielID"].ToString()));
                        for (int c = 0; c < dsMs.Tables[0].Rows.Count; c++)
                        {
                            DataRow dr = dtDemand.NewRow();
                            t = false;
                            dr["MaterielID"] = dsMs.Tables[0].DefaultView[c]["ChildMaterielID"];
                            #region 使用方法
                            int a = int.Parse(dsMs.Tables[0].DefaultView[c]["UsingTypeID"].ToString());
                            switch (a)
                            {
                                case 1://按主色
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                case 2://按插色一
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                case 3://按插色二
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                case 4://按尺码
                                    {
                                        dr["ColorID"] = 0;
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                        break;
                                    }
                                case 5://按主色+尺码
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                        break;
                                    }
                                case 6://按插色一+尺码
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                        break;
                                    }
                                case 7://按插色二+尺码
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                        break;
                                    }
                                case 8://按主色+插色一
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                        dr["colorOneID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                case 9://按主色+插色二
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                        dr["colorOneID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                case 10://按插色一+插色二
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                        dr["colorOneID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                case 11://按主色+插色一+插色二
                                    {
                                        dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                        dr["colorOneID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                        dr["ColorTwoID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                case 12://都不用
                                    {
                                        dr["ColorID"] = 0;
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                #region 特殊配色
                                case 13://特殊配色
                                    {
                                        DataTable dtSC = bllMSI.GetList("(MSIID=" + dsMs.Tables[0].DefaultView[c]["InfoID"] + ")").Tables[0];// bllSC.GetList("(MaterielID=" + ds.Tables[0].DefaultView[r]["ChildMaterielID"] + ")").Tables[0];
                                        if (dtSC.Rows.Count == 0)
                                            break;
                                        DataRow[] drs = dtSC.Select("(ColorID=" + dtDemand.DefaultView[r]["ColorID"] + ") And (CompanyID=" + CompanyID + ")");
                                        if (drs.Length == 0)
                                        {
                                            drs = dtSC.Select("(ColorID=" + dtDemand.DefaultView[r]["ColorID"] + ") And (CompanyID=0)");
                                            if (drs.Length == 0)
                                            {
                                                drs = dtSC.Select("(ColorID=0) And (CompanyID=0)");
                                                if (drs.Length == 0)
                                                {
                                                    t = true;
                                                    break;
                                                }
                                            }
                                        }
                                        if (Convert.ToInt32(drs[0]["ChildMaterielID"]) > 0)
                                            dr["MaterielID"] = drs[0]["ChildMaterielID"];
                                        if (Convert.ToInt32(drs[0]["ToColorID"]) > 0)
                                            dr["ColorID"] = drs[0]["ToColorID"];
                                        else
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                        dr["colorOneID"] = 0;
                                        dr["ColorTwoID"] = 0;
                                        dr["SizeID"] = 0;
                                        break;
                                    }
                                #endregion
                            }
                            #endregion
                            object g = dtDemand.DefaultView[r]["Amount"];
                            double amount = double.Parse(dsMs.Tables[0].DefaultView[c]["Amount"].ToString()) * double.Parse(dtDemand.DefaultView[r]["Amount"].ToString()) * (1 + double.Parse(dsMs.Tables[0].DefaultView[c]["Wastage"].ToString()));
                            dr["StockAmount"] = amount.ToString("N5");
                            amount = double.Parse(dsMs.Tables[0].DefaultView[c]["Amount"].ToString()) * double.Parse(dtDemand.DefaultView[r]["Amount"].ToString());
                            dr["Amount"] = amount.ToString("N5");
                            dr["MeasureID"] = dsMs.Tables[0].DefaultView[c]["MeasureID"];
                            dr["AttribID"] = dsMs.Tables[0].DefaultView[c]["AttributeID"];
                            dr["Stata"] = 1;
                            string dep = dsMs.Tables[0].DefaultView[c]["DepartmentID"].ToString();
                            if (dsMs.Tables[0].DefaultView[c]["DepartmentID"].ToString() != string.Empty)
                            {
                                dr["DepID"] = dsMs.Tables[0].DefaultView[c]["DepartmentID"];
                            }
                            else
                            {
                                dr["DepID"] = 0;
                            }
                            if (!t)
                                dtDemand.Rows.Add(dr);
                        }
                    }
                    dtDemand.Rows[r]["Stata"] = "2";
                }
                DataTable dtddd = GroupTableOne(dtDemand);
                //DataTable dtee = GroupTableOne(dtddd);
                DataTable ddddd = GroupTableOne(dtddd);
                ddddd.Columns.Add("stockNotAmount", typeof(double));
                ddddd.Columns.Add("NotAllotAmount", typeof(double));
                ddddd.Columns.Add("ProduceTaskID", typeof(int));
                ddddd.Columns.Add("MListID", typeof(int));
                ddddd.Columns.Add("TableTypeID", typeof(int));
                ddddd.Columns.Add("IsEnd", typeof(int));
                ddddd.Columns.Add("RepertoryAmount", typeof(decimal));
                //  ddddd.Columns.Add("UseStockLast", typeof(decimal));
                ddddd.Columns.Add("HasStockAmount", typeof(decimal));
                ddddd.Columns.Add("NeedAmount", typeof(decimal));
                ddddd.Columns.Add("OutAmount", typeof(decimal));
                //  ddddd.Columns.Add("StockInfoID", typeof(int));
                for (int i = 0; i < ddddd.Rows.Count; i++)
                {
                    try
                    {
                        modML = new Hownet.Model.MaterielList();
                        ddddd.Rows[i]["NotAllotAmount"] = ddddd.Rows[i]["Amount"];
                        ddddd.Rows[i]["stockNotAmount"] = ddddd.Rows[i]["stockAmount"];
                        ddddd.Rows[i]["A"] = 3;
                        ddddd.Rows[i]["RepertoryAmount"] = ddddd.Rows[i]["HasStockAmount"] = ddddd.Rows[i]["ID"] = 0;
                        ddddd.Rows[i]["ProduceTaskID"] = TaskID;
                        modML.BrandID = 0;
                        modML.ColorID = Convert.ToInt32(ddddd.Rows[i]["ColorID"]);
                        modML.ColorOneID = Convert.ToInt32(ddddd.Rows[i]["ColorOneID"]);
                        modML.ColorTwoID = Convert.ToInt32(ddddd.Rows[i]["ColorTwoID"]);
                        modML.MaterielID = Convert.ToInt32(ddddd.Rows[i]["MaterielID"]);
                        modML.MeasureID = Convert.ToInt32(ddddd.Rows[i]["MeasureID"]);
                        modML.SizeID = Convert.ToInt32(ddddd.Rows[i]["SizeID"]);
                        ddddd.Rows[i]["MListID"] = bllML.GetID(modML);
                        ddddd.Rows[i]["TableTypeID"] = TableTypeID;
                        ddddd.Rows[i]["NeedAmount"] = ddddd.Rows[i]["OutAmount"] = ddddd.Rows[i]["IsEnd"] = 0;
                    }
                    catch (Exception ex)
                    {
                    }
                    //  ddddd.Rows[i]["StockInfoID"] = 0;
                }
                ddddd.TableName = "ddddd";

                DataSet dss = new DataSet();
                dss.Tables.Add(ddddd);
                return dss;
                //return GroupTable(dtDemand);
            }
            catch (Exception ex)
            {
                DataSet dsssss = new DataSet();
                return dsssss;
            }
        }
        public DataSet GroupTable(DataTable DemandInfo)
        {
            //DataTable dtMateriel = new DataTable();
            //dtMateriel.Columns.Add("ID", typeof(int));
            //dtMateriel.Columns.Add("Name", typeof(string));
            //dtMateriel.Columns.Add("Measure", typeof(string));
            //DataTable dtColor = new DataTable();
            //dtColor.Columns.Add("ID", typeof(int));
            //dtColor.Columns.Add("Name", typeof(string));
            //dtColor.Columns.Add("OneID", typeof(int));
            //dtColor.Columns.Add("OneName", typeof(string));
            //dtColor.Columns.Add("TwoID", typeof(int));
            //dtColor.Columns.Add("TwoName", typeof(string));
            //dtColor.Columns.Add("SizeID", typeof(int));
            //dtColor.Columns.Add("SizeName", typeof(string));
            DataTable dt = DemandInfo.Clone();
            dt.Columns.Add("MaterielName", typeof(string));
            dt.Columns.Add("ColorName", typeof(string));
            dt.Columns.Add("ColorOne", typeof(string));
            dt.Columns.Add("ColorTwo", typeof(string));
            dt.Columns.Add("Size", typeof(string));
            dt.Columns.Add("Measure", typeof(string));
            Hownet.BLL.Color bllC = new Color();
            Hownet.BLL.Size bllS = new Size();
            Hownet.BLL.Materiel bllMat = new Materiel();
            Hownet.BLL.Measure bllMea = new Measure();
            DataTable dtColor = bllC.GetAllList().Tables[0];
            DataTable dtSize = bllS.GetAllList().Tables[0];
            DataTable dtMat = bllMat.GetAllList().Tables[0];
            DataTable dtMea = bllMea.GetAllList().Tables[0];
            bool t = false;
            for (int r = 0; r < DemandInfo.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Rows.Count; c++)
                {
                    t = false;
                    if (DemandInfo.DefaultView[r]["MaterielID"].Equals(dt.DefaultView[c]["MaterielID"]) && DemandInfo.DefaultView[r]["ColorID"].Equals(dt.DefaultView[c]["ColorID"]) && DemandInfo.DefaultView[r]["ColorOneID"].Equals(dt.DefaultView[c]["ColorOneID"])
                        && DemandInfo.DefaultView[r]["ColorTwoID"].Equals(dt.DefaultView[c]["ColorTwoID"]) && DemandInfo.DefaultView[r]["SizeID"].Equals(dt.DefaultView[c]["SizeID"])
                        && DemandInfo.DefaultView[r]["DepID"].Equals(dt.DefaultView[c]["DepID"]))
                    {
                        object obj = dt.DefaultView[c]["DepID"];
                        dt.Rows[c]["Amount"] = Add(dt.DefaultView[c]["Amount"], DemandInfo.DefaultView[r]["Amount"]);
                        dt.Rows[c]["stockAmount"] = Add(dt.DefaultView[c]["stockAmount"], DemandInfo.DefaultView[r]["stockAmount"]);
                        dt.Rows[c]["NotAllotAmount"] = Add(dt.DefaultView[c]["NotAllotAmount"], DemandInfo.DefaultView[r]["NotAllotAmount"]);
                        dt.Rows[c]["stockNotAmount"] = Add(dt.DefaultView[c]["stockNotAmount"], DemandInfo.DefaultView[r]["stockNotAmount"]);
                        t = true;
                        break;
                    }
                }
                if (!t)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaterielID"] = DemandInfo.DefaultView[r]["MaterielID"];
                    dr["ColorID"] = DemandInfo.DefaultView[r]["ColorID"];
                    dr["ColorOneID"] = DemandInfo.DefaultView[r]["ColorOneID"];
                    dr["ColorTwoID"] = DemandInfo.DefaultView[r]["ColorTwoID"];
                    dr["SizeID"] = DemandInfo.DefaultView[r]["SizeID"];
                    dr["stockAmount"] = DemandInfo.DefaultView[r]["stockAmount"];
                    dr["Amount"] = DemandInfo.DefaultView[r]["Amount"];
                    dr["MeasureID"] = DemandInfo.DefaultView[r]["MeasureID"];
                    //dr["AttribID"] = DemandInfo.DefaultView[r]["AttribID"];
                    dr["DepID"] = DemandInfo.DefaultView[r]["DepID"];
                    dr["NotAllotAmount"] = DemandInfo.DefaultView[r]["NotAllotAmount"];
                    dr["stockNotAmount"] = DemandInfo.DefaultView[r]["stockNotAmount"];
                    dr["MaterielName"] = dtMat.Select("(MaterielID=" + DemandInfo.DefaultView[r]["MaterielID"] + ")")[0]["MaterielName"];
                    DataRow[] drcolor;
                    if (DemandInfo.DefaultView[r]["ColorID"].ToString() != "")
                    {
                        drcolor = dtColor.Select("(ID=" + DemandInfo.DefaultView[r]["ColorID"] + ")");
                        if (drcolor.Length > 0)
                        {
                            dr["ColorName"] = drcolor[0]["Name"];
                        }
                    }
                    if (DemandInfo.DefaultView[r]["ColorOneID"].ToString() != "")
                    {
                        drcolor = dtColor.Select("(ID=" + DemandInfo.DefaultView[r]["ColorOneID"] + ")");
                        if (drcolor.Length > 0)
                        {
                            dr["ColorOne"] = drcolor[0]["Name"];
                        }
                    }
                    if (DemandInfo.DefaultView[r]["ColorTwoID"].ToString() != "")
                    {
                        drcolor = dtColor.Select("(ID=" + DemandInfo.DefaultView[r]["ColorTwoID"] + ")");
                        if (drcolor.Length > 0)
                        {
                            dr["ColorTwo"] = drcolor[0]["Name"];
                        }
                        drcolor = dtSize.Select("(ID=" + DemandInfo.DefaultView[r]["SizeID"] + ")");
                        if (drcolor.Length > 0)
                        {
                            dr["Size"] = drcolor[0]["Name"];
                        }
                    }
                    drcolor = dtMea.Select("(ID=" + DemandInfo.DefaultView[r]["MeasureID"] + ")");
                    if (drcolor.Length > 0)
                    {
                        dr["Measure"] = drcolor[0]["Name"];
                    }
                    dt.Rows.Add(dr);
                }
            }
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    t = false;
            //    for (int j = 0; j < dtColor.Rows.Count; j++)
            //    {
            //        t = false;
            //        if (dt.DefaultView[i]["ColorID"].Equals(dtColor.DefaultView[j]["ID"]) && dt.DefaultView[i]["ColorOneID"].Equals(dtColor.DefaultView[j]["OneID"])
            //            && dt.DefaultView[i]["ColorTwoID"].Equals(dtColor.DefaultView[j]["TwoID"]) && dt.DefaultView[i]["SizeID"].Equals(dtColor.DefaultView[j]["SizeID"]))
            //        {
            //            t = true;
            //            break;
            //        }
            //    }
            //    if (!t)
            //    {
            //        DataRow dr = dtColor.NewRow();
            //        dr["ID"] = dt.DefaultView[i]["ColorID"];
            //        dr["OneID"] = dt.DefaultView[i]["ColorOneID"];
            //        dr["TwoID"] = dt.DefaultView[i]["ColorTwoID"];
            //        dr["SizeID"] = dt.DefaultView[i]["SizeID"];
            //        dr["Name"] = dt.DefaultView[i]["ColorName"] ;
            //        dr["OneName"] = dt.DefaultView[i]["ColorOne"] ;
            //        dr["TwoName"] = dt.DefaultView[i]["ColorTwo"] ;
            //        dr["SizeName"] = dt.DefaultView[i]["Size"] ;
            //        dtColor.Rows.Add(dr);
            //    }
            //}
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    t = false;
            //    for (int j = 0; j < dtMateriel.Rows.Count; j++)
            //    {
            //        t = false;
            //        if (dt.DefaultView[i]["MaterielID"].Equals(dtMateriel.DefaultView[j]["ID"]))
            //        {
            //            t = true;
            //            break;
            //        }
            //    }
            //    if (!t)
            //    {
            //        DataRow dr = dtMateriel.NewRow();
            //        dr["ID"] = dt.DefaultView[i]["MaterielID"];
            //        dr["Name"] = dt.DefaultView[i]["MaterielName"];
            //        dr["Measure"] = bllMat.GetMeasureName(int.Parse(dt.DefaultView[i]["MaterielID"].ToString()));
            //        dtMateriel.Rows.Add(dr);
            //    }
            //}
            DataSet ds = new DataSet();
            dt.DefaultView.Sort = "MaterielName";
            dt.TableName = "dt";
            ds.Tables.Add(dt);
            //dtColor.TableName = "dtColor";
            //ds.Tables.Add(dtColor);
            //dtMateriel.TableName = "dtMateriel";
            //dtMateriel.DefaultView.Sort = "Name";
            //ds.Tables.Add(dtMateriel);
            return ds;
        }
        public DataTable GroupTableOne(DataTable DemandInfo)
        {
            DataTable dt = DemandInfo.Clone();
            bool t = false;
            for (int r = 0; r < DemandInfo.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Rows.Count; c++)
                {
                    t = false;
                    if (DemandInfo.DefaultView[r]["MaterielID"].Equals(dt.DefaultView[c]["MaterielID"]) && DemandInfo.DefaultView[r]["ColorID"].Equals(dt.DefaultView[c]["ColorID"]) && DemandInfo.DefaultView[r]["ColorOneID"].Equals(dt.DefaultView[c]["ColorOneID"])
                        && DemandInfo.DefaultView[r]["ColorTwoID"].Equals(dt.DefaultView[c]["ColorTwoID"]) && DemandInfo.DefaultView[r]["SizeID"].Equals(dt.DefaultView[c]["SizeID"])
                        && DemandInfo.DefaultView[r]["DepID"].Equals(dt.DefaultView[c]["DepID"]))
                    {
                        object obj = dt.DefaultView[c]["DepID"];
                        dt.Rows[c]["Amount"] = Add(dt.DefaultView[c]["Amount"], DemandInfo.DefaultView[r]["Amount"]);
                        dt.Rows[c]["stockAmount"] = Add(dt.DefaultView[c]["stockAmount"], DemandInfo.DefaultView[r]["stockAmount"]);
                        //dt.Rows[c]["NotAllotAmount"] = Add(dt.DefaultView[c]["NotAllotAmount"], DemandInfo.DefaultView[r]["NotAllotAmount"]);
                        //dt.Rows[c]["stockNotAmount"] = Add(dt.DefaultView[c]["stockNotAmount"], DemandInfo.DefaultView[r]["stockNotAmount"]);
                        t = true;
                        break;
                    }
                }
                if (!t)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaterielID"] = DemandInfo.DefaultView[r]["MaterielID"];
                    dr["ColorID"] = DemandInfo.DefaultView[r]["ColorID"];
                    dr["ColorOneID"] = DemandInfo.DefaultView[r]["ColorOneID"];
                    dr["ColorTwoID"] = DemandInfo.DefaultView[r]["ColorTwoID"];
                    dr["SizeID"] = DemandInfo.DefaultView[r]["SizeID"];
                    dr["stockAmount"] = DemandInfo.DefaultView[r]["stockAmount"];
                    dr["Amount"] = DemandInfo.DefaultView[r]["Amount"];
                    dr["MeasureID"] = DemandInfo.DefaultView[r]["MeasureID"];
                    dr["AttribID"] = DemandInfo.DefaultView[r]["AttribID"];
                    dr["DepID"] = DemandInfo.DefaultView[r]["DepID"];
                    dr["Stata"] = DemandInfo.DefaultView[r]["Stata"];
                    //dr["NotAllotAmount"] = DemandInfo.DefaultView[r]["NotAllotAmount"];
                    //dr["stockNotAmount"] = DemandInfo.DefaultView[r]["stockNotAmount"];
                    object a = DemandInfo.DefaultView[r]["AttribID"];
                    dt.Rows.Add(dr);

                }
            }
            return dt;
        }
        public DataTable GroupTableTwo(DataTable DemandInfo)
        {
            DataTable dt = DemandInfo.Clone();
            bool t = false;
            for (int r = 0; r < DemandInfo.Rows.Count; r++)
            {
                for (int c = 0; c < dt.Rows.Count; c++)
                {
                    t = false;
                    if (DemandInfo.DefaultView[r]["MaterielID"].Equals(dt.DefaultView[c]["MaterielID"]) && DemandInfo.DefaultView[r]["ColorID"].Equals(dt.DefaultView[c]["ColorID"]) && DemandInfo.DefaultView[r]["ColorOneID"].Equals(dt.DefaultView[c]["ColorOneID"])
                        && DemandInfo.DefaultView[r]["ColorTwoID"].Equals(dt.DefaultView[c]["ColorTwoID"]) && DemandInfo.DefaultView[r]["SizeID"].Equals(dt.DefaultView[c]["SizeID"])
                        && DemandInfo.DefaultView[r]["DepID"].Equals(dt.DefaultView[c]["DepID"]) && DemandInfo.DefaultView[r]["PlanID"].Equals(dt.DefaultView[c]["PlanID"]))
                    {
                        object obj = dt.DefaultView[c]["DepID"];
                        dt.Rows[c]["Amount"] = Add(dt.DefaultView[c]["Amount"], DemandInfo.DefaultView[r]["Amount"]);
                        dt.Rows[c]["stockAmount"] = Add(dt.DefaultView[c]["stockAmount"], DemandInfo.DefaultView[r]["stockAmount"]);
                        //dt.Rows[c]["NotAllotAmount"] = Add(dt.DefaultView[c]["NotAllotAmount"], DemandInfo.DefaultView[r]["NotAllotAmount"]);
                        //dt.Rows[c]["stockNotAmount"] = Add(dt.DefaultView[c]["stockNotAmount"], DemandInfo.DefaultView[r]["stockNotAmount"]);
                        t = true;
                        break;
                    }
                }
                if (!t)
                {
                    DataRow dr = dt.NewRow();
                    dr["MaterielID"] = DemandInfo.DefaultView[r]["MaterielID"];
                    dr["ColorID"] = DemandInfo.DefaultView[r]["ColorID"];
                    dr["ColorOneID"] = DemandInfo.DefaultView[r]["ColorOneID"];
                    dr["ColorTwoID"] = DemandInfo.DefaultView[r]["ColorTwoID"];
                    dr["SizeID"] = DemandInfo.DefaultView[r]["SizeID"];
                    dr["stockAmount"] = DemandInfo.DefaultView[r]["stockAmount"];
                    dr["Amount"] = DemandInfo.DefaultView[r]["Amount"];
                    dr["MeasureID"] = DemandInfo.DefaultView[r]["MeasureID"];
                    dr["AttribID"] = DemandInfo.DefaultView[r]["AttribID"];
                    dr["DepID"] = DemandInfo.DefaultView[r]["DepID"];
                    dr["Stata"] = DemandInfo.DefaultView[r]["Stata"];
                    dr["PlanID"] = DemandInfo.DefaultView[r]["PlanID"];
                    //dr["NotAllotAmount"] = DemandInfo.DefaultView[r]["NotAllotAmount"];
                    //dr["stockNotAmount"] = DemandInfo.DefaultView[r]["stockNotAmount"];
                    object a = DemandInfo.DefaultView[r]["AttribID"];
                    dt.Rows.Add(dr);

                }
            }
            return dt;
        }
        /// <summary>
        /// 物料分析中的的需请购量
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetNeedStock(string strWhere,int DepotID,string strTask)
        {
            Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
            Hownet.BLL.Color bllC = new Color();
            Hownet.BLL.Size bllS = new Size();
            Hownet.BLL.Repertory bllRe = new Repertory();
            Hownet.BLL.StockBack bllSB = new StockBack();
            Hownet.BLL.PlanUseRep bllPR = new Hownet.BLL.PlanUseRep();
            DataTable dtC = bllC.GetAllList().Tables[0];
            DataTable dtS = bllS.GetAllList().Tables[0];
            DataSet dsMD = bllMD.GetNeedAmount(strWhere,strTask);
            dsMD.Tables[0].Columns.Add("Specif", typeof(string));//规格
            dsMD.Tables[0].Columns.Add("RepAmount", typeof(decimal));//库存余量
            dsMD.Tables[0].Columns.Add("UseRepertAmount", typeof(decimal));//使用库存余量
            dsMD.Tables[0].Columns.Add("NowNeedAmount", typeof(decimal));//需申购数量
            dsMD.Tables[0].Columns.Add("StockLast", typeof(decimal));//使用采购余量
            dsMD.Tables[0].Columns.Add("IsS", typeof(bool));
          //  dsMD.Tables[0].Columns.Add("OutNeed", typeof(decimal));
            //dsMD.Tables[0].Columns.Add("NeedNotAmount", typeof(decimal));//已申购数量
            //dsMD.Tables[0].Columns.Add("StockNotAmount", typeof(decimal));//已采购数量
            //dsMD.Tables[0].Columns.Add("HasRepertAmount", typeof(decimal));//库存已备料
            //dsMD.Tables[0].Columns.Add("HasLinLiao", typeof(decimal));//车间已领数量
            string specif = string.Empty;
            try
            {
                for (int i = 0; i < dsMD.Tables[0].Rows.Count; i++)
                {
                    specif = string.Empty;
                    if (Convert.ToInt32(dsMD.Tables[0].Rows[i]["ColorID"]) > 0)
                        specif = dtC.Select("(ID=" + dsMD.Tables[0].Rows[i]["ColorID"] + ")")[0]["Name"].ToString() + ";";
                    if (Convert.ToInt32(dsMD.Tables[0].Rows[i]["ColorOneID"]) > 0)
                        specif += dtC.Select("(ID=" + dsMD.Tables[0].Rows[i]["ColorOneID"] + ")")[0]["Name"].ToString() + ";";
                    if (Convert.ToInt32(dsMD.Tables[0].Rows[i]["ColorTwoID"]) > 0)
                        specif += dtC.Select("(ID=" + dsMD.Tables[0].Rows[i]["ColorTwoID"] + ")")[0]["Name"].ToString() + ";";
                    if (Convert.ToInt32(dsMD.Tables[0].Rows[i]["SizeID"]) > 0)
                        specif += dtS.Select("(ID=" + dsMD.Tables[0].Rows[i]["SizeID"] + ")")[0]["Name"].ToString();
                    dsMD.Tables[0].Rows[i]["Specif"] = specif;
                    dsMD.Tables[0].Rows[i]["IsS"] = false;
                    dsMD.Tables[0].Rows[i]["RepAmount"] =Convert.ToDouble( bllRe.GetNotUseAmount(Convert.ToInt32(dsMD.Tables[0].Rows[i]["MListID"]), DepotID));
                    dsMD.Tables[0].Rows[i]["StockLast"] =Convert.ToDouble(  bllSB.GetExcessAmount(Convert.ToInt32(dsMD.Tables[0].Rows[i]["MListID"])));
                    dsMD.Tables[0].Rows[i]["UseRepertAmount"] = 0;// bllPR.GetAmount(Convert.ToInt32(dsMD.Tables[0].Rows[i]["MListID"]), (int)PlanUseRep.使用原仓存, strTask);
                    //dsMD.Tables[0].Rows[i]["NeedNotAmount"] =Convert.ToDouble(  bllPR.GetAmount(Convert.ToInt32(dsMD.Tables[0].Rows[i]["MListID"]), (int)PlanUseRep.已申购数量, strTask));
                    //dsMD.Tables[0].Rows[i]["StockNotAmount"] = Convert.ToDouble( bllPR.GetAmount(Convert.ToInt32(dsMD.Tables[0].Rows[i]["MListID"]), (int)PlanUseRep.已采购数量, strTask));
                    //dsMD.Tables[0].Rows[i]["HasLinLiao"] =Convert.ToDouble(  bllPR.GetAmount(Convert.ToInt32(dsMD.Tables[0].Rows[i]["MListID"]), (int)PlanUseRep.车间已领用数量, strTask));
                    //dsMD.Tables[0].Rows[i]["HasRepertAmount"] =bllRe.GetPlanAmount( Convert.ToDouble(  bllPR.GetAmount(Convert.ToInt32(dsMD.Tables[0].Rows[i]["MListID"]), (int)PlanUseRep.库存已备料数量, strTask));
                }

            }
            catch (Exception ex)
            {
            }
            return dsMD;
        }
        public enum PlanUseRep
        {
            使用原仓存 = 1,
            使用采购余量 = 2,
            已申购数量 = 3,
            已采购数量 = 4,
            车间已领用数量 = 5,
            库存已备料数量 = 6
        }
        /// <summary>
        /// 半成品拆分
        /// </summary>
        /// <param name="bb"></param>
        /// <param name="MainID"></param>
        /// <param name="TableTypeID"></param>
        /// <returns></returns>
        public DataSet GetSemiNeed(byte[] bb, int MainID)
        {
            
                DataSet ds = new DataSet();
                ds.DataSetName = "ds";
                try
                {
                DataTable dtSemi = new DataTable();
                if (bb.Length > 0)
                {
                    dtSemi = ZipDt.Byte2Ds(bb).Tables[0];
                    dtSemi.Columns.Add("AttribID", typeof(int));
                    Hownet.BLL.Materiel bllM = new Materiel();
                    for (int i = 0; i < dtSemi.Rows.Count; i++)
                    {
                        if (dtSemi.Rows[i]["MaterielID"] != null && dtSemi.Rows[i]["MaterielID"].ToString() != "0")
                        {
                            dtSemi.Rows[i]["AttribID"] = bllM.GetList("(ID=" + dtSemi.Rows[i]["MaterielID"] + ")").Tables[0].Rows[0]["AttributeID"];
                        }
                    }
                  //  Hownet.BLL.StockMaterielDemand bllSMD = new StockMaterielDemand();
                    Hownet.BLL.StockBackInfo bllSMD = new StockBackInfo();
                    DataTable DemandInfo = bllSMD.GetList("(ID=0)").Tables[0];
                    DemandInfo.Columns.Add("stockAmount",typeof(decimal));
                                            DemandInfo.Columns.Add("NotAllotAmount",typeof(decimal));
                                            DemandInfo.Columns.Add("stockNotAmount", typeof(decimal));
                                            DemandInfo.Columns.Add("MeasureID", typeof(int));
                                            DemandInfo.Columns.Add("DepID", typeof(int));
                                            DemandInfo.Columns.Add("PlanID", typeof(int));
                    DemandInfo.Columns.Add("AttribID", typeof(int));
                    DemandInfo.Columns.Add("Stata", typeof(int));
                    DataTable dtMSI = new DataTable();
                    Hownet.BLL.MaterielStructInfo bllMSI = new MaterielStructInfo();
                    Hownet.BLL.MaterielList bllML = new MaterielList();
                    Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
                    Hownet.Model.AmountInfo modAI = new Hownet.Model.AmountInfo();
                    // double _amount = 0;
                    for (int i = 0; i < dtSemi.Rows.Count; i++)
                    {
                        dtMSI.Clear();
                        //取得该款号的BOM清单
                        dtMSI = bllMSI.GetList("(MaterielID=" + Convert.ToInt32(dtSemi.Rows[i]["MaterielID"]) + ")").Tables[0];
                        if (dtMSI.Rows.Count > 0)
                        {
                            for (int r = 0; r < dtMSI.Rows.Count; r++)
                            {
                                int a = int.Parse(dtMSI.DefaultView[r]["UsingTypeID"].ToString());
                                if (a < 4 || a > 7)
                                {
                                    DataRow dr = DemandInfo.NewRow();
                                    dr["MaterielID"] = dtMSI.DefaultView[r]["ChildMaterielID"];
                                    #region 使用方法
                                    switch (a)
                                    {
                                        case 1://按主色
                                            {
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 2://按插色一
                                            {
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorOneID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 3://按插色二
                                            {
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorTwoID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }

                                        case 8://按主色+插色一
                                            {
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorID"];
                                                dr["colorOneID"] = dtSemi.Rows[i]["ColorOneID"];
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 9://按主色+插色二
                                            {
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorID"];
                                                dr["colorOneID"] = dtSemi.Rows[i]["ColorTwoID"];
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 10://按插色一+插色二
                                            {
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorOneID"];
                                                dr["colorOneID"] = dtSemi.Rows[i]["ColorTwoID"];
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 11://按主色+插色一+插色二
                                            {
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorID"];
                                                dr["colorOneID"] = dtSemi.Rows[i]["ColorOneID"];
                                                dr["ColorTwoID"] = dtSemi.Rows[i]["ColorTwoID"];
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                        case 12://都不用
                                            {
                                                dr["ColorID"] = 0;
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = 0;
                                                break;
                                            }
                                    #endregion
                                    }
                                    try
                                    {
                                        double amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * double.Parse(dtSemi.Rows[i]["Amount"].ToString()) * (1 + double.Parse(dtMSI.DefaultView[r]["Wastage"].ToString()));
                                       // dr["StockAmount"] = amount.ToString("N5");
                                        amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * double.Parse(dtSemi.Rows[i]["Amount"].ToString());
                                        dr["Amount"] = amount;
                                        dr["MeasureID"] = dtMSI.DefaultView[r]["MeasureID"];
                                        dr["AttribID"] = dtMSI.DefaultView[r]["AttribID"];
                                        //dr["PlanID"] = dtSemi.Rows[i]["PlanID"];
                                        dr["Stata"] = 1;
                                        //if (dtMSI.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                        //{
                                        //    dr["DepID"] = dtMSI.DefaultView[r]["DepartmentID"];
                                        //}
                                        //else
                                        //{
                                        //    dr["DepID"] = 0;
                                        //}

                                        DemandInfo.Rows.Add(dr);
                                    }
                                    catch (Exception ex)
                                    {
                                    }
                                }
                                else
                                {
                                    #region 与尺码相关的BOM
                                    switch (a)
                                    {
                                        case 4://按尺码
                                            {
                                                DataRow dr = DemandInfo.NewRow();
                                                dr["MaterielID"] = dtMSI.DefaultView[r]["ChildMaterielID"];
                                                dr["MeasureID"] = dtMSI.DefaultView[r]["MeasureID"];
                                                dr["AttribID"] = dtMSI.DefaultView[r]["AttribID"];
                                                dr["Stata"] = 1;
                                                if (dtMSI.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                                {
                                                    dr["DepID"] = dtMSI.DefaultView[r]["DepartmentID"];
                                                }
                                                else
                                                {
                                                    dr["DepID"] = 0;
                                                }
                                                dr["ColorID"] = 0;
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = dtSemi.Rows[i]["SizeID"];
                                                double amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * double.Parse(dtSemi.Rows[i]["Amount"].ToString()) * (1 + double.Parse(dtMSI.DefaultView[r]["Wastage"].ToString()));
                                                dr["StockAmount"] = amount.ToString("N5");
                                                dr["PlanID"] = dtSemi.Rows[i]["PlanID"];
                                                amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * double.Parse(dtSemi.Rows[i]["Amount"].ToString());
                                                dr["Amount"] = amount.ToString("N5");
                                                DemandInfo.Rows.Add(dr);
                                                break;
                                            }
                                        case 5://按主色+尺码
                                            {
                                                DataRow dr = DemandInfo.NewRow();
                                                dr["MaterielID"] = dtMSI.DefaultView[r]["ChildMaterielID"];
                                                dr["MeasureID"] = dtMSI.DefaultView[r]["MeasureID"];
                                                dr["AttribID"] = dtMSI.DefaultView[r]["AttribID"];
                                                dr["Stata"] = 1;
                                                if (dtMSI.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                                {
                                                    dr["DepID"] = dtMSI.DefaultView[r]["DepartmentID"];
                                                }
                                                else
                                                {
                                                    dr["DepID"] = 0;
                                                }
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = dtSemi.Rows[i]["SizeID"];
                                                DataRow[] drs = dtSemi.Select("(SizeID=" + dtSemi.Rows[i]["SizeID"] + ") and (ColorID=" + dtSemi.Rows[i]["ColorID"] + ")");
                                                if (drs.Length > 0)
                                                {
                                                    if (drs[0]["Amount"].ToString() != "")
                                                        modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                                    else
                                                        modAI.Amount = 0;
                                                    double amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(dtMSI.DefaultView[r]["Wastage"].ToString()));
                                                    dr["PlanID"] = dtSemi.Rows[i]["PlanID"];
                                                    dr["StockAmount"] = amount.ToString("N5");
                                                    amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                    dr["Amount"] = amount.ToString("N5");
                                                    DemandInfo.Rows.Add(dr);
                                                }
                                                break;
                                            }
                                        case 6://按插色一+尺码
                                            {
                                                DataRow dr = DemandInfo.NewRow();
                                                dr["MaterielID"] = dtMSI.DefaultView[r]["ChildMaterielID"];
                                                dr["MeasureID"] = dtMSI.DefaultView[r]["MeasureID"];
                                                dr["AttribID"] = dtMSI.DefaultView[r]["AttribID"];
                                                dr["Stata"] = 1;
                                                if (dtMSI.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                                {
                                                    dr["DepID"] = dtMSI.DefaultView[r]["DepartmentID"];
                                                }
                                                else
                                                {
                                                    dr["DepID"] = 0;
                                                }
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = dtSemi.Rows[i]["SizeID"];
                                                DataRow[] drs = dtSemi.Select("(SizeID=" + dtSemi.Rows[i]["SizeID"] + ") and (ColorID=" + dtSemi.Rows[i]["ColorID"] + ")");
                                                if (drs.Length > 0)
                                                {
                                                    if (drs[0]["Amount"].ToString() != "")
                                                        modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                                    else
                                                        modAI.Amount = 0;
                                                    double amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(dtMSI.DefaultView[r]["Wastage"].ToString()));
                                                    dr["StockAmount"] = amount.ToString("N5");
                                                    dr["PlanID"] = dtSemi.Rows[i]["PlanID"];
                                                    amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                    dr["Amount"] = amount.ToString("N5");
                                                    DemandInfo.Rows.Add(dr);
                                                }
                                                break;
                                            }
                                        case 7://按插色二+尺码
                                            {
                                                DataRow dr = DemandInfo.NewRow();
                                                dr["MaterielID"] = dtMSI.DefaultView[r]["ChildMaterielID"];
                                                dr["MeasureID"] = dtMSI.DefaultView[r]["MeasureID"];
                                                dr["AttribID"] = dtMSI.DefaultView[r]["AttribID"];
                                                dr["Stata"] = 1;
                                                if (dtMSI.DefaultView[r]["DepartmentID"].ToString() != string.Empty)
                                                {
                                                    dr["DepID"] = dtMSI.DefaultView[r]["DepartmentID"];
                                                }
                                                else
                                                {
                                                    dr["DepID"] = 0;
                                                }
                                                dr["ColorID"] = dtSemi.Rows[i]["ColorID"];
                                                dr["colorOneID"] = 0;
                                                dr["ColorTwoID"] = 0;
                                                dr["SizeID"] = dtSemi.Rows[i]["SizeID"];
                                                DataRow[] drs = dtSemi.Select("(SizeID=" + dtSemi.Rows[i]["SizeID"] + ") and (ColorID=" + dtSemi.Rows[i]["ColorID"] + ")");
                                                if (drs.Length > 0)
                                                {
                                                    if (drs[0]["Amount"].ToString() != "")
                                                        modAI.Amount = int.Parse(drs[0]["Amount"].ToString());
                                                    else
                                                        modAI.Amount = 0;
                                                    double amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * modAI.Amount * (1 + double.Parse(dtMSI.DefaultView[r]["Wastage"].ToString()));
                                                    dr["StockAmount"] = amount.ToString("N5");
                                                    dr["PlanID"] = dtSemi.Rows[i]["PlanID"];
                                                    amount = double.Parse(dtMSI.DefaultView[r]["Amount"].ToString()) * modAI.Amount;
                                                    dr["Amount"] = amount.ToString("N5");
                                                    DemandInfo.Rows.Add(dr);
                                                }
                                                break;
                                            }
                                    }
                                    #endregion
                                }
                            }
                        }
                    }
                    DataTable dtDemand = GroupTableTwo(DemandInfo);
                    for (int r = 0; r < dtDemand.Rows.Count; r++)
                    {
                        object o = dtDemand.DefaultView[r]["AttribID"];
                        object aaaa = dtDemand.DefaultView[r]["Stata"];
                        if (int.Parse(dtDemand.DefaultView[r]["AttribID"].ToString()) < 4 && dtDemand.DefaultView[r]["Stata"].ToString() == "1" && int.Parse(dtDemand.DefaultView[r]["AttribID"].ToString()) > 1)
                        {
                            object mmm = dtDemand.DefaultView[r]["MaterielID"];
                            DataSet dsMs = bllMSI.GetList("(MaterielID=" + dtDemand.DefaultView[r]["MaterielID"] + ")");
                            for (int c = 0; c < dsMs.Tables[0].Rows.Count; c++)
                            {
                                DataRow dr = dtDemand.NewRow();

                                dr["MaterielID"] = dsMs.Tables[0].DefaultView[c]["ChildMaterielID"];
                                #region 使用方法
                                int a = int.Parse(dsMs.Tables[0].DefaultView[c]["UsingTypeID"].ToString());
                                switch (a)
                                {
                                    case 1://按主色
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                    case 2://按插色一
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                    case 3://按插色二
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                    case 4://按尺码
                                        {
                                            dr["ColorID"] = 0;
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                            break;
                                        }
                                    case 5://按主色+尺码
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                            break;
                                        }
                                    case 6://按插色一+尺码
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                            break;
                                        }
                                    case 7://按插色二+尺码
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = dtDemand.DefaultView[r]["SizeID"];
                                            break;
                                        }
                                    case 8://按主色+插色一
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                            dr["colorOneID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                    case 9://按主色+插色二
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                            dr["colorOneID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                    case 10://按插色一+插色二
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                            dr["colorOneID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                    case 11://按主色+插色一+插色二
                                        {
                                            dr["ColorID"] = dtDemand.DefaultView[r]["ColorID"];
                                            dr["colorOneID"] = dtDemand.DefaultView[r]["ColorOneID"];
                                            dr["ColorTwoID"] = dtDemand.DefaultView[r]["ColorTwoID"];
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                    case 12://都不用
                                        {
                                            dr["ColorID"] = 0;
                                            dr["colorOneID"] = 0;
                                            dr["ColorTwoID"] = 0;
                                            dr["SizeID"] = 0;
                                            break;
                                        }
                                }
                                #endregion
                                try
                                {
                                    object g = dtDemand.DefaultView[r]["Amount"];
                                    double amount = double.Parse(dsMs.Tables[0].DefaultView[c]["Amount"].ToString()) * double.Parse(dtDemand.DefaultView[r]["Amount"].ToString()) * (1 + double.Parse(dsMs.Tables[0].DefaultView[c]["Wastage"].ToString()));
                                    dr["StockAmount"] = amount.ToString("N5");
                                    amount = double.Parse(dsMs.Tables[0].DefaultView[c]["Amount"].ToString()) * double.Parse(dtDemand.DefaultView[r]["Amount"].ToString());
                                    dr["Amount"] = amount.ToString("N5");
                                    dr["MeasureID"] = dsMs.Tables[0].DefaultView[c]["MeasureID"];
                                    dr["AttribID"] = dsMs.Tables[0].DefaultView[c]["AttribID"];
                                    dr["Stata"] = 1;
                                    string dep = dsMs.Tables[0].DefaultView[c]["DepartmentID"].ToString();
                                    if (dsMs.Tables[0].DefaultView[c]["DepartmentID"].ToString() != string.Empty)
                                    {
                                        dr["DepID"] = dsMs.Tables[0].DefaultView[c]["DepartmentID"];
                                    }
                                    else
                                    {
                                        dr["DepID"] = 0;
                                    }
                                    dtDemand.Rows.Add(dr);
                                }
                                catch (Exception ex)
                                {
                                }
                            }
                        }
                        dtDemand.Rows[r]["Stata"] = "2";
                    }

                    DataTable ddddd = GroupTableTwo(dtDemand);
                    //ddddd.Columns.Add("StockInfoID", typeof(int));
                    for (int i = 0; i < ddddd.Rows.Count; i++)
                    {
                        modML = new Hownet.Model.MaterielList();
                        ddddd.Rows[i]["NotAmount"] = ddddd.Rows[i]["Amount"];
                   //     ddddd.Rows[i]["stockNotAmount"] = ddddd.Rows[i]["stockAmount"];
                        ddddd.Rows[i]["A"] = 4;
                        ddddd.Rows[i]["ID"] = 0;
                        modML.BrandID = 0;
                        modML.ColorID = Convert.ToInt32(ddddd.Rows[i]["ColorID"]);
                        modML.ColorOneID = Convert.ToInt32(ddddd.Rows[i]["ColorOneID"]);
                        modML.ColorTwoID = Convert.ToInt32(ddddd.Rows[i]["ColorTwoID"]);
                        modML.MaterielID = Convert.ToInt32(ddddd.Rows[i]["MaterielID"]);
                        ddddd.Rows[i]["CompanyMeasureID"] = modML.MeasureID = Convert.ToInt32(ddddd.Rows[i]["MeasureID"]);
                        modML.SizeID = Convert.ToInt32(ddddd.Rows[i]["SizeID"]);
                        ddddd.Rows[i]["MListID"] = bllML.GetID(modML);
                        ddddd.Rows[i]["MainID"] = MainID;
                        ddddd.Rows[i]["IsEnd"] = 0;
                        
                      //  ddddd.Rows[i]["RepertoryAmount"] = ddddd.Rows[i]["NeedAmount"] = ddddd.Rows[i]["HasStockAmount"] = ddddd.Rows[i]["OutAmount"] = 0;
                      //  ddddd.Rows[i]["StockInfoID"] = 0;
                    }
                    ddddd.TableName = "ddddd";
                    ds.Tables.Add(ddddd);
                }
            }
            catch (Exception ex)
            {
            }
            return ds;
        }

        public DataSet BomNotAmount(int AttributeID, int MaterielID, int CompanyID)
        {
           // bool t = false;
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.DAL.MaterielDemand dalMD = new Hownet.DAL.MaterielDemand();
            Hownet.BLL.MaterielStructMain bllMs = new MaterielStructMain();

            DataSet ds = new DataSet();
            //if (MaterielID == 0 && CompanyID == 0)
            //{
            //    ds = bllML.GetFenXi(AttributeID);
            // ds.Tables[0].Columns.Add("Demand", typeof(double));
            //    ds.Tables[0].Columns.Add("Amount", typeof(double));
            //    ds.Tables[0].Columns.Add("StockNotBack", typeof(double));
            //    ds.Tables[0].Columns.Add("NotAmount", typeof(double));
            //    ds.Tables[0].Columns.Add("NeedNotAmount", typeof(double));
            //    DataTable dtM = dalMD.BomNotAmount(AttributeID).Tables[0];
            //    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //    {
            //        for (int r = 0; r < dtM.Rows.Count; r++)
            //        {
            //            //t = false;
            //            if (ds.Tables[0].DefaultView[i]["MListID"].ToString() == dtM.DefaultView[r]["MListID"].ToString())
            //            {
            //               // t = true;
            //                ds.Tables[0].Rows[i]["Demand"] = dtM.Rows[r]["Demand"];
            //                break;
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    if (CompanyID == 0 && MaterielID > 0)
            //    {
            //        ds = dalMD.BomNotAmountByTogethers(AttributeID, MaterielID);
            //        ds.Tables[0].Columns.Add("Amount", typeof(double));
            //        ds.Tables[0].Columns.Add("StockNotBack", typeof(double));
            //        ds.Tables[0].Columns.Add("NotAmount", typeof(double));
            //        ds.Tables[0].Columns.Add("NeedNotAmount", typeof(double));

            //    }
            //    if (CompanyID > 0 && MaterielID == 0)
            //    {
            //        ds = dalMD.BomNotAmountByCompanyID(AttributeID, CompanyID);
            //        ds.Tables[0].Columns.Add("Amount", typeof(double));
            //        ds.Tables[0].Columns.Add("StockNotBack", typeof(double));
            //        ds.Tables[0].Columns.Add("NotAmount", typeof(double));
            //        ds.Tables[0].Columns.Add("NeedNotAmount", typeof(double));
            //    }
            //    if (CompanyID > 0 && MaterielID > 0)
            //    {
            //        ds = dalMD.BomNotAmountByToAndCom(AttributeID, MaterielID, CompanyID);
            //        ds.Tables[0].Columns.Add("Amount", typeof(double));
            //        ds.Tables[0].Columns.Add("StockNotBack", typeof(double));
            //        ds.Tables[0].Columns.Add("NotAmount", typeof(double));
            //        ds.Tables[0].Columns.Add("NeedNotAmount", typeof(double));
            //    }
            //}
            //Hownet.BLL.Materiel bllMat = new Materiel();
            //#region 库存数量
            //Hownet.BLL.Repertory bllR = new Repertory();
            //DataTable dtR = bllR.GetFenXi(AttributeID).Tables[0];
            //if (dtR.Rows.Count > 0)
            //{
            //    try
            //    {
            //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //        {
            //            for (int r = 0; r < dtR.Rows.Count; r++)
            //            {
            //                //t = false;
            //                if (ds.Tables[0].DefaultView[i]["MListID"].ToString() == dtR.DefaultView[r]["MListID"].ToString())
            //                {
            //                   // t = true;
            //                    ds.Tables[0].Rows[i]["Amount"] = dtR.Rows[r]["Amount"];
            //                    break;
            //                }
            //            }
            //        }
            //    }
            //    catch //(Exception ex)
            //    {
            //    }
            //}
            //#endregion
            ////   将采购未到数量添加到物料结构的Stock列.

            //#region 采购数量
            //Hownet.BLL.StockBack bllSB = new StockBack();
            //DataTable dsT = bllSB.GetNotBack(AttributeID).Tables[0];
            //for (int r = 0; r < ds.Tables[0].Rows.Count; r++)
            //{
            //    for (int c = 0; c < dsT.Rows.Count; c++)
            //    {
            //        if (ds.Tables[0].DefaultView[r]["MListID"].ToString() == dsT.DefaultView[c]["MListID"].ToString())
            //        {
            //            ds.Tables[0].Rows[r]["StockNotBack"] = dsT.DefaultView[c]["StockNotBack"];
            //            break;
            //        }
            //    }
            //}
            //#endregion
            //ds.Tables[0].Columns.Add("NeedAmount", typeof(double));
            ////ds.Tables[0].Columns.Add("AttributeID", typeof(int));
            //ds.Tables[0].Columns.Add("A", typeof(int));
            //double stockNotBack, Amount, Demand;
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    stockNotBack = Amount = Demand = 0;
            //    if (ds.Tables[0].Rows[i]["StockNotBack"].ToString() != string.Empty)
            //        stockNotBack = Convert.ToDouble(ds.Tables[0].Rows[i]["StockNotBack"]);
            //    if (ds.Tables[0].Rows[i]["Amount"].ToString() != string.Empty)
            //        Amount = Convert.ToDouble(ds.Tables[0].Rows[i]["Amount"]);
            //    if (ds.Tables[0].Rows[i]["Demand"].ToString() != string.Empty)
            //        Demand = Convert.ToDouble(ds.Tables[0].Rows[i]["Demand"]);
            //    ds.Tables[0].Rows[i]["NotAmount"] = Amount + stockNotBack - Demand;
            //    ds.Tables[0].Rows[i]["A"] = 0;
            //}
            return ds;
        }

        private object Add(object a, object b)
        {
            if (a is DBNull || a.ToString() == string.Empty)
            {
                return b;
            }
            if (b is DBNull || b.ToString() == string.Empty)
            {
                return a;
            }
            return ((double.Parse(a.ToString()) + (double.Parse(b.ToString()))));
        }

    }
}
