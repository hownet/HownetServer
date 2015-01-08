using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Hownet.BLL.BaseFile
{
    public class OrderTask
    {
        public DataTable SizePart(int TaskID)
        {
            Hownet.BLL.SizeTable bllST = new Hownet.BLL.SizeTable();
            Hownet.Model.SizeTable modST = new Hownet.Model.SizeTable();
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            DataTable dt = new DataTable();
            dt.TableName = "Size";
            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Part", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["Part"] = "部位\\尺码";
            SqlDataReader myReader = pti.GetSize(TaskID);


            int i = 1;
            ArrayList SizeList = new ArrayList();
            ArrayList PartList = new ArrayList();
            SizeList.Clear();
            PartList.Clear();
            SizeList.Add(0);
            PartList.Add(0);

            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
                dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            SqlDataReader Part = bllST.GetPart(TaskID);
            for (int c = dt.Columns.Count; c < 12; c++)
            {
                dt.Columns.Add("Columns" + c);
            }
            i = 1;
            while (Part.Read())
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = Part[0].ToString();
                PartList.Add(int.Parse(Part[1].ToString()));
                i++;
            }
            Part.Close();
            for (int r = 1; r < SizeList.Count; r++)
            {
                for (int c = 1; c < PartList.Count; c++)
                {
                    modST.SizeID = int.Parse(SizeList[r].ToString());
                    modST.SizePartID = int.Parse(PartList[c].ToString());
                    modST.ProduceTaskID = TaskID;

                    dt.Rows[c][r] = bllST.GetValue(modST);
                }
            }
            return dt;
        }
        public void SaveSizePart(DataTable dt, int TaskID)
        {
            Hownet.BLL.SizePart bllSP = new SizePart();
            Hownet.BLL.SizeTable bllSt = new SizeTable();
            Hownet.BLL.MaterielAttribute blMa = new MaterielAttribute();
            Hownet.Model.SizeTable modST = new Hownet.Model.SizeTable();
            ArrayList PartList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            bllSt.DelTask(TaskID);
            PartList.Clear();
            SizeList.Clear();
            PartList.Add(0);
            SizeList.Add(0);
            for (int r = 1; r < dt.Rows.Count - 1; r++)
            {
                int partID = 0;
                if (dt.DefaultView[r]["Part"].ToString() != string.Empty)
                {
                    partID = bllSP.GetID(dt.DefaultView[r]["Part"].ToString());
                }
                PartList.Add(partID);
            }
            for (int c = 1; c < dt.Columns.Count; c++)
            {
                int sizeID = 0;
                if (dt.DefaultView[0][c].ToString() != string.Empty)
                {
                    sizeID = blMa.GetID(dt.DefaultView[0][c].ToString(), 2);
                }
                SizeList.Add(sizeID);
            }
            for (int r = 0; r < PartList.Count; r++)
            {
                if (PartList[r].ToString() != "0")
                {
                    for (int c = 0; c < SizeList.Count; c++)
                    {
                        if (SizeList[c].ToString() != "0")
                        {
                            if (dt.DefaultView[r][c].ToString() != string.Empty && dt.DefaultView[r][c].ToString() != "0")
                            {
                                modST.ProduceTaskID = TaskID;
                                modST.SizeID = int.Parse(SizeList[c].ToString());
                                modST.SizePartID = int.Parse(PartList[r].ToString());
                                modST.Length = decimal.Parse(dt.DefaultView[r][c].ToString());
                                bllSt.Add(modST);
                            }
                        }
                    }
                }
            }
        }
        public DataSet PrintTask(int TaskID)
        {

            Hownet.BLL.ProduceTaskMain bllPTM = new ProduceTaskMain();
            //Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            //Hownet.BLL.Materiel bllMa = new Materiel();
            Hownet.BLL.MaterielStructMain bllMSM = new MaterielStructMain();
            //Hownet.Model.ProduceTaskInfo modPti = new Hownet.Model.ProduceTaskInfo();

            DataSet ds = bllPTM.GetReport(TaskID);
            ds.Tables[0].TableName = "Task";
            ds.Tables.Add(SizePart(TaskID));
            //int materielID = int.Parse(ds.Tables[0].DefaultView[0]["MaterielID"].ToString());
            //DataSet matDs = bllMa.GetList("(MaterielID='" + materielID + "')");
            //matDs.Tables[0].TableName = "Imges";
            //ds.Tables.Add(matDs.Tables[0].Copy());

            DataSet dsMs = bllMSM.GetBomListByMainID(bllPTM.GetModel(TaskID).BomID);
            dsMs.Tables[0].TableName = "BOM";
            ds.Tables.Add(dsMs.Tables[0].Copy());
            ds.Tables.Add(SizeBow(TaskID));
            return ds;
        }
        public DataTable SizeBow(int TaskID)
        {
            Hownet.BLL.SizeBow bllSB = new SizeBow();
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            int SizeID = 0;
            DataTable dt = new DataTable();
            dt.TableName = "Bow";
            dt.Clear();
            dt.Columns.Clear();

            dt.Columns.Add("Part", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows.Add(dt.NewRow());
            dt.Rows[1]["Part"] = "模具";
            dt.Rows[2]["Part"] = "钢弓";
            SqlDataReader myReader = pti.GetSize(TaskID);

            int i = 1;
            ArrayList SizeList = new ArrayList();

            SizeList.Clear();
            SizeList.Add(0);


            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
                dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            for (int c = dt.Columns.Count; c < 12; c++)
            {
                dt.Columns.Add("Columns" + c);
            }

            for (int r = 1; r < SizeList.Count; r++)
            {

                SizeID = int.Parse(SizeList[r].ToString());
                dt.Rows[2][r] = bllSB.GetBowValue(TaskID, SizeID);
                dt.Rows[1][r] = bllSB.GetCottonValue(TaskID, SizeID);
            }
            return dt;
        }
        public void SaveBow(DataTable dt, int TaskID)
        {
            Hownet.BLL.SizeBow bllSB = new SizeBow();
            Hownet.BLL.Materiel bllMat = new Materiel();
            Hownet.BLL.MaterielAttribute blMa = new MaterielAttribute();
            Hownet.Model.SizeBow modSB = new Hownet.Model.SizeBow();
            int sizeID = 0;
            modSB.ProduceTaskID = TaskID;
            for (int c = 1; c < dt.Columns.Count; c++)
            {
                if (dt.DefaultView[0][c].ToString() != string.Empty)
                {
                    sizeID = blMa.GetID(dt.DefaultView[0][c].ToString(), 2);
                    modSB.SizeID = sizeID;
                    if (dt.DefaultView[2][c] != null && dt.DefaultView[2][c].ToString() != string.Empty)
                        modSB.BowID = bllMat.GetID(dt.DefaultView[2][c].ToString());
                    if (dt.DefaultView[1][c] != null && dt.DefaultView[2][c].ToString() != string.Empty)
                        modSB.CottonID = bllMat.GetID(dt.DefaultView[1][c].ToString());
                    modSB.SizeBowID = bllSB.SelectSize(TaskID, sizeID);
                    if (modSB.SizeBowID != 0)
                    {
                        bllSB.Update(modSB);
                    }
                    else
                    {
                        bllSB.Add(modSB);
                    }
                }
            }
        }
        /// <summary>
        /// 显示生产单明细
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="t">真加空行，假不加</param>
        /// <returns></returns>
        public DataSet ShowInfo(int TaskID, bool t)
        {
            bool f = false;
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.Model.ProduceTaskInfo modPti = new Hownet.Model.ProduceTaskInfo();
            Hownet.BLL.SizeBow bllSB = new SizeBow();
            Hownet.BLL.SizeTable bllST = new SizeTable();

            DataTable dtSBInfo = bllSB.GetListByTask(TaskID).Tables[0];
            DataTable dtSTInfo = bllST.GetListByTask(TaskID).Tables[0];
            DataTable dtInfo = pti.GetList("(MainID=" + TaskID + ")").Tables[0];
            DataTable dtSizePart = bllST.GetSizePartIDGroup(TaskID).Tables[0];
            DataTable dt = new DataTable();
            DataTable dtSB = new DataTable();
            DataTable dtST = new DataTable();
            dt.Columns.Add("Color", typeof(string));
            dtSB.Columns.Add("SizeBow", typeof(string));
            dtST.Columns.Add("SizePart", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dtSB.Rows.Add(dtSB.NewRow());
            dtST.Rows.Add(dtST.NewRow());
            dtST.Rows[0]["SizePart"] = 0;
            dt.Rows[0]["Color"] = "颜色\\尺码";
            if (dtSBInfo.Rows.Count > 0)
                f = true;
            SqlDataReader myReader = pti.GetSize(TaskID);

            int i = 1;
            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
                dtSB.Columns.Add("Columns" + i);
                dtST.Columns.Add("Columns" + i);
                dtST.Rows[0][i] = dtSB.Rows[0][i] = dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            for (int c = dt.Columns.Count; c < 12; c++)
            {
                dt.Columns.Add("Columns" + c);
            }
            dt.Columns.Add("SumNum");
            dt.Rows[0]["SumNum"] = "合计";
            dt.Columns.Add("ColorOne", typeof(string));
            dt.Columns.Add("ColorTwo", typeof(string));
            dt.Rows[0]["ColorOne"] = "插色一";
            dt.Rows[0]["ColorTwo"] = "插色二";
            SqlDataReader ColorReader = pti.GetColor(TaskID);
            i = 1;
            while (ColorReader.Read())
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = ColorReader[0].ToString();
                dt.Rows[i][dt.Columns.Count - 2] = ColorReader[3].ToString();
                dt.Rows[i][dt.Columns.Count - 1] = ColorReader[5].ToString();
                ColorList.Add(int.Parse(ColorReader[1].ToString()));
                ColorOneList.Add(int.Parse(ColorReader[4].ToString()));
                ColorTwoList.Add(int.Parse(ColorReader[6].ToString()));
                i++;
            }
            dtSB.Rows.Add(dtSB.NewRow());
            dtSB.Rows.Add(dtSB.NewRow());
            dtSB.Rows.Add(dtSB.NewRow());
            dtSB.Rows.Add(dtSB.NewRow());
            dtSB.Rows.Add(dtSB.NewRow());
            dtSB.Rows[1][0] = "钢弓";
            dtSB.Rows[2][0] = "棉碗";
            dtSB.Rows[3][0] = "成品肩带";
            dtSB.Rows[4][0] = "透明背带";
            dtSB.Rows[5][0] = "胶骨";
            ColorReader.Close();
            if (dtSizePart.Rows.Count > 0)
            {

                for (int a = 0; a < dtSizePart.Rows.Count; a++)
                {
                    object obj = dtSizePart.Rows[a][0].ToString();
                    dtST.Rows.Add(dtST.NewRow());
                    dtST.Rows[a + 1][0] = dtSizePart.Rows[a]["SizePartID"];
                }
            }
            DataTable dtNotAmount = dt.Copy();
            DataTable dtBackAmount = dt.Copy();
            for (int r = 1; r < SizeList.Count; r++)
            {
                modPti.SizeID = int.Parse(SizeList[r].ToString());
                for (int c = 1; c < ColorList.Count; c++)
                {
                    modPti.ColorID = int.Parse(ColorList[c].ToString());
                    modPti.ColorOneID = int.Parse(ColorOneList[c].ToString());
                    modPti.ColorTwoID = int.Parse(ColorTwoList[c].ToString());
                    modPti.MainID = TaskID;
                    string sql = "(SizeID=" + modPti.SizeID + ") and (ColorID=" + modPti.ColorID + ") and (ColorOneID=" + modPti.ColorOneID + ") and (ColorTwoID=" + modPti.ColorTwoID + ")";
                    DataRow[] drs = dtInfo.Select(sql);
                    if (drs.Length > 0)
                    {
                        dt.Rows[c][r] = drs[0]["Amount"];
                        dtNotAmount.Rows[c][r] = drs[0]["NotAmount"];
                        dtBackAmount.Rows[c][r] = drs[0]["BackAmount"];
                    }
                }
                if (f)
                {
                    DataRow[] drSb = dtSBInfo.Select("(SizeID=" + modPti.SizeID + ")");
                    if (drSb.Length > 0)
                    {
                        dtSB.Rows[1][r] = drSb[0]["BowName"];
                        dtSB.Rows[2][r] = drSb[0]["CottonName"];
                        dtSB.Rows[3][r] = drSb[0]["SashName"];
                        dtSB.Rows[4][r] = drSb[0]["OpenSashName"];
                        dtSB.Rows[5][r] = drSb[0]["PlasticBoneName"];
                    }
                }
                if (dtSTInfo.Rows.Count > 0)
                {
                    for (int a = 0; a < dtSizePart.Rows.Count; a++)
                    {
                        string aaaa = "(SizeID=" + modPti.SizeID + ") and (SizePartID=" + dtSizePart.Rows[a]["SizePartID"] + ")";
                        DataRow[] drSt = dtSTInfo.Select(aaaa);
                        if (drSt.Length > 0)
                        {
                            dtST.Rows[a + 1][r] = drSt[0]["Length"];
                        }
                    }
                }
            }
            if (t)
            {
                //for (int r = dt.Rows.Count; r < 11; r++)
                //{
                //    DataRow dr = dt.NewRow();
                //    dt.Rows.Add(dr);
                //}
                dt.Rows.Add(dt.NewRow());
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dtSB);
            ds.Tables.Add(dtST);
            ds.Tables.Add(dtNotAmount);
            ds.Tables.Add(dtBackAmount);
            return ds;
        }
        public DataTable ShowNotAmount(int TaskID)
        {
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.Model.ProduceTaskInfo modPti = new Hownet.Model.ProduceTaskInfo();
            DataTable dtInfo = pti.GetList("(MainID=" + TaskID + ")").Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("Color", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["Color"] = "颜色\\尺码";
            SqlDataReader myReader = pti.GetSize(TaskID);

            int i = 1;
            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
                dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            for (int c = dt.Columns.Count; c < 12; c++)
            {
                dt.Columns.Add("Columns" + c);
            }
            dt.Columns.Add("SumNum");
            dt.Rows[0]["SumNum"] = "合计";
            dt.Columns.Add("ColorOne", typeof(string));
            dt.Columns.Add("ColorTwo", typeof(string));
            dt.Rows[0]["ColorOne"] = "插色一";
            dt.Rows[0]["ColorTwo"] = "插色二";
            SqlDataReader ColorReader = pti.GetColor(TaskID);
            i = 1;
            while (ColorReader.Read())
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = ColorReader[0].ToString();
                dt.Rows[i][dt.Columns.Count - 2] = ColorReader[3].ToString();
                dt.Rows[i][dt.Columns.Count - 1] = ColorReader[5].ToString();
                ColorList.Add(int.Parse(ColorReader[1].ToString()));
                ColorOneList.Add(int.Parse(ColorReader[4].ToString()));
                ColorTwoList.Add(int.Parse(ColorReader[6].ToString()));
                i++;
            }
            ColorReader.Close();
            for (int r = 1; r < SizeList.Count; r++)
            {
                for (int c = 1; c < ColorList.Count; c++)
                {
                    modPti.ColorID = int.Parse(ColorList[c].ToString());

                    modPti.SizeID = int.Parse(SizeList[r].ToString());
                    modPti.ColorOneID = int.Parse(ColorOneList[c].ToString());
                    modPti.ColorTwoID = int.Parse(ColorTwoList[c].ToString());
                    modPti.MainID = TaskID;
                    string sql = "(SizeID=" + modPti.SizeID + ") and (ColorID=" + modPti.ColorID + ") and (ColorOneID=" + modPti.ColorOneID + ") and (ColorTwoID=" + modPti.ColorTwoID + ")";
                    DataRow[] drs = dtInfo.Select(sql);
                    if (drs.Length > 0)
                        dt.Rows[c][r] = drs[0]["NotAmount"];
                    //dt.Rows[c][r] = pti.GetNotValue(modPti);
                }
            }
            return dt;
        }
        public void SaveInfo(DataTable dt, int TaskID, int MaterielID,int BrandID)
        {
            Hownet.BLL.MaterielAttribute blMa = new Hownet.BLL.MaterielAttribute();
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            Hownet.Model.ProduceTaskMain modPTM = new Hownet.Model.ProduceTaskMain();
            Hownet.Model.ProduceTaskInfo modPTI = new Hownet.Model.ProduceTaskInfo();

            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            for (int r = 1; r < dt.Rows.Count - 1; r++)
            {
                int colorID = 0;
                if (dt.DefaultView[r]["Color"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["Color"].ToString(), 1);
                }
                ColorList.Add(colorID);
                colorID = 0;
                if (dt.DefaultView[r]["ColorOne"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["ColorOne"].ToString(), 1);
                }
                ColorOneList.Add(colorID);
                colorID = 0;
                if (dt.DefaultView[r]["ColorTwo"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["ColorTwo"].ToString(), 1);
                }
                ColorTwoList.Add(colorID);
            }
            for (int c = 1; c < dt.Columns.Count - 3; c++)
            {
                int sizeID = 0;
                if (dt.DefaultView[0][c].ToString() != string.Empty)
                {
                    sizeID = blMa.GetID(dt.DefaultView[0][c].ToString(), 2);
                }
                SizeList.Add(sizeID);
            }
            for (int r = 0; r < ColorList.Count; r++)
            {
                if (ColorList[r].ToString() != "0")
                {
                    for (int c = 0; c < SizeList.Count; c++)
                    {
                        if (SizeList[c].ToString() != "0")
                        {
                            if (dt.DefaultView[r][c].ToString() != string.Empty && dt.DefaultView[r][c].ToString() != "0")
                            {
                                modML.ColorID = modPTI.ColorID = int.Parse(ColorList[r].ToString());
                                modML.SizeID = modPTI.SizeID = int.Parse(SizeList[c].ToString());
                                modML.ColorOneID = modPTI.ColorOneID = int.Parse(ColorOneList[r].ToString());
                                modML.ColorTwoID = modPTI.ColorTwoID = int.Parse(ColorTwoList[r].ToString());
                                modML.MaterielID = MaterielID;
                                modML.BrandID = BrandID;
                                modPTI.MListID = bllML.GetID(modML);
                                modPTI.Amount = int.Parse(dt.DefaultView[r][c].ToString());
                                modPTI.MainID = TaskID;
                                modPTI.NotDepAmount = modPTI.NotAmount = modPTI.Amount;
                                pti.Add(modPTI);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProductID"></param>
        /// <param name="TaskID"></param>
        /// <param name="MaterielID"></param>
        /// <returns></returns>
        public DataSet ShowDarwOne(int ProductID, int TaskID, int MaterielID, int MainID)
        {

            DataSet ds = new DataSet();
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.BLL.ProductCaiPian bllPCP = new ProductCaiPian();
            Hownet.BLL.DarwOne bllDO = new DarwOne();
            Hownet.BLL.DarwInfo bllDI = new DarwInfo();
            DataTable dtDarwOne = bllDO.GetList("(MainID=" + MainID + ")").Tables[0];
            DataTable dtDarwInfo = bllDI.GetList("(MainID=" + MainID + ")").Tables[0];
            DataTable dtCP = bllPCP.GetList("(ProductID=" + ProductID + ") And (MaterielID=" + MaterielID + ")").Tables[0];
            DataTable dtOne = new DataTable();//One
            dtOne.TableName = "One";
            DataTable dtInfo = new DataTable();
            dtInfo.TableName = "Info";
            dtOne.Columns.Add("CaiPian", typeof(int));
            dtInfo.Columns.Add("Color", typeof(int));
            dtInfo.Columns.Add("Amont", typeof(decimal));
            DataTable dtSize = pti.GetSizeTable(TaskID);
            DataTable dtColor = pti.GetColorTable(TaskID);
            for (int i = 0; i < dtSize.Rows.Count; i++)
            {
                dtOne.Columns.Add("Columns" + i.ToString(), typeof(decimal));
                dtInfo.Columns.Add("Columns" + i.ToString(), typeof(decimal));

            }
            for (int j = 0; j < dtCP.Rows.Count; j++)
            {
                DataRow dr = dtOne.NewRow();
                dr["CaiPian"] = dtCP.Rows[j]["CaiPianID"];
                dtOne.Rows.Add(dr);
            }
            for (int i = 0; i < dtColor.Rows.Count; i++)
            {
                DataRow dr = dtInfo.NewRow();
                dr["Color"] = dtColor.Rows[i][1].ToString();
                dtInfo.Rows.Add(dr);
            }
            for (int i = 0; i < dtSize.Rows.Count; i++)
            {
                for (int j = 0; j < dtCP.Rows.Count; j++)
                {
                    DataRow[] drs = dtDarwOne.Select("(CaiPianID=" + dtCP.Rows[j]["CaiPianID"] + ") and (SizeID=" + dtSize.Rows[i]["SizeID"] + ")");
                    if (drs.Length > 0)
                        dtOne.Rows[j][i + 1] = drs[0]["Amount"];
                }
                for (int j = 0; j < dtColor.Rows.Count; j++)
                {
                    DataRow[] drs = dtDarwInfo.Select("(ColorID=" + dtColor.Rows[j]["ColorID"] + ") and (SizeID=" + dtSize.Rows[i]["SizeID"] + ")");
                    if (drs.Length > 0)
                        dtInfo.Rows[j][i + 1] = drs[0]["RiseAmount"];
                }

            }
            ds.Tables.Add(dtOne);
            ds.Tables.Add(dtInfo);
            return ds;
        }
        /// <summary>
        /// 显示未分配到班组的数量
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataTable ShowNotDepAmount(int TaskID)
        {
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.Model.ProduceTaskInfo modPti = new Hownet.Model.ProduceTaskInfo();
            DataTable dtInfo = pti.GetList("(MainID=" + TaskID + ")").Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("Color", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["Color"] = "颜色\\尺码";
            SqlDataReader myReader = pti.GetSize(TaskID);

            int i = 1;
            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
                dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            //for (int c = dt.Columns.Count; c < 12; c++)
            //{
            //    dt.Columns.Add("Columns" + c);
            //}
            dt.Columns.Add("Columns" + dt.Columns.Count);
            dt.Columns.Add("SumNum");
            dt.Rows[0]["SumNum"] = "合计";
            dt.Columns.Add("ColorOne", typeof(string));
            dt.Columns.Add("ColorTwo", typeof(string));
            dt.Rows[0]["ColorOne"] = "插色一";
            dt.Rows[0]["ColorTwo"] = "插色二";
            SqlDataReader ColorReader = pti.GetColor(TaskID);
            i = 1;
            while (ColorReader.Read())
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = ColorReader[0].ToString();
                dt.Rows[i][dt.Columns.Count - 2] = ColorReader[3].ToString();
                dt.Rows[i][dt.Columns.Count - 1] = ColorReader[5].ToString();
                ColorList.Add(int.Parse(ColorReader[1].ToString()));
                ColorOneList.Add(int.Parse(ColorReader[4].ToString()));
                ColorTwoList.Add(int.Parse(ColorReader[6].ToString()));
                i++;
            }
            ColorReader.Close();
            for (int r = 1; r < SizeList.Count; r++)
            {
                for (int c = 1; c < ColorList.Count; c++)
                {
                    modPti.ColorID = int.Parse(ColorList[c].ToString());

                    modPti.SizeID = int.Parse(SizeList[r].ToString());
                    modPti.ColorOneID = int.Parse(ColorOneList[c].ToString());
                    modPti.ColorTwoID = int.Parse(ColorTwoList[c].ToString());
                    modPti.MainID = TaskID;
                    string sql = "(SizeID=" + modPti.SizeID + ") and (ColorID=" + modPti.ColorID + ") and (ColorOneID=" + modPti.ColorOneID + ") and (ColorTwoID=" + modPti.ColorTwoID + ")";
                    DataRow[] drs = dtInfo.Select(sql);
                    if (drs.Length > 0)
                        dt.Rows[c][r] = drs[0]["NotDepAmount"];
                }
            }
            dt.Rows.Add(dt.NewRow());
            return dt;
        }
        /// <summary>
        /// 显示分配到班组的数量
        /// </summary>
        /// <param name="TaskID"></param>
        /// <returns></returns>
        public DataTable ShowDepAmount(int TaskID, int DepTaskID)
        {
            Hownet.BLL.DepartmentTaskInfo bllDTI = new DepartmentTaskInfo();
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.Model.ProduceTaskInfo modPti = new Hownet.Model.ProduceTaskInfo();
            DataTable dtInfo = bllDTI.GetList("(MainID=" + DepTaskID + ")").Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("Color", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["Color"] = "颜色\\尺码";
            SqlDataReader myReader = pti.GetSize(TaskID);

            int i = 1;
            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
                dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            //for (int c = dt.Columns.Count; c < 12; c++)
            //{
            //    dt.Columns.Add("Columns" + c);
            //}
            dt.Columns.Add("Columns" + dt.Columns.Count);
            dt.Columns.Add("SumNum");
            dt.Rows[0]["SumNum"] = "合计";
            dt.Columns.Add("ColorOne", typeof(string));
            dt.Columns.Add("ColorTwo", typeof(string));
            dt.Rows[0]["ColorOne"] = "插色一";
            dt.Rows[0]["ColorTwo"] = "插色二";
            SqlDataReader ColorReader = pti.GetColor(TaskID);
            i = 1;
            while (ColorReader.Read())
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = ColorReader[0].ToString();
                dt.Rows[i][dt.Columns.Count - 2] = ColorReader[3].ToString();
                dt.Rows[i][dt.Columns.Count - 1] = ColorReader[5].ToString();
                ColorList.Add(int.Parse(ColorReader[1].ToString()));
                ColorOneList.Add(int.Parse(ColorReader[4].ToString()));
                ColorTwoList.Add(int.Parse(ColorReader[6].ToString()));
                i++;
            }
            ColorReader.Close();
            for (int r = 1; r < SizeList.Count; r++)
            {
                for (int c = 1; c < ColorList.Count; c++)
                {
                    modPti.ColorID = int.Parse(ColorList[c].ToString());

                    modPti.SizeID = int.Parse(SizeList[r].ToString());
                    modPti.ColorOneID = int.Parse(ColorOneList[c].ToString());
                    modPti.ColorTwoID = int.Parse(ColorTwoList[c].ToString());
                    modPti.MainID = TaskID;
                    string sql = "(SizeID=" + modPti.SizeID + ") and (ColorID=" + modPti.ColorID + ") and (ColorOneID=" + modPti.ColorOneID + ") and (ColorTwoID=" + modPti.ColorTwoID + ")";
                    DataRow[] drs = dtInfo.Select(sql);
                    if (drs.Length > 0)
                        dt.Rows[c][r] = drs[0]["NotAmount"];
                }
            }
            dt.Rows.Add(dt.NewRow());
            return dt;
        }
        public void SaveDepInfo(DataTable dt, int TaskID, int DepTaskID,int BrandID,int MaterielID)
        {
            Hownet.BLL.MaterielAttribute blMa = new Hownet.BLL.MaterielAttribute();
            Hownet.BLL.ProduceTaskInfo bllPTI = new ProduceTaskInfo();
            //Hownet.Model.ProduceTaskMain modPTM = new Hownet.Model.ProduceTaskMain();
            Hownet.Model.ProduceTaskInfo modPTI = new Hownet.Model.ProduceTaskInfo();
            Hownet.BLL.DepartmentTaskInfo bllDTI = new DepartmentTaskInfo();
            Hownet.Model.DepartmentTaskInfo modDTI = new Hownet.Model.DepartmentTaskInfo();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            for (int r = 1; r < dt.Rows.Count - 1; r++)
            {
                int colorID = 0;
                if (dt.DefaultView[r]["Color"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["Color"].ToString(), 1);
                }
                ColorList.Add(colorID);
                colorID = 0;
                if (dt.DefaultView[r]["ColorOne"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["ColorOne"].ToString(), 1);
                }
                ColorOneList.Add(colorID);
                colorID = 0;
                if (dt.DefaultView[r]["ColorTwo"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["ColorTwo"].ToString(), 1);
                }
                ColorTwoList.Add(colorID);
            }
            for (int c = 1; c < dt.Columns.Count - 3; c++)
            {
                int sizeID = 0;
                if (dt.DefaultView[0][c].ToString() != string.Empty)
                {
                    sizeID = blMa.GetID(dt.DefaultView[0][c].ToString(), 2);
                }
                SizeList.Add(sizeID);
            }
            for (int r = 0; r < ColorList.Count; r++)
            {
                if (ColorList[r].ToString() != "0")
                {
                    for (int c = 0; c < SizeList.Count; c++)
                    {
                        if (SizeList[c].ToString() != "0")
                        {
                            if (dt.DefaultView[r][c].ToString() != string.Empty && dt.DefaultView[r][c].ToString() != "0")
                            {
                                modML.ColorID = modPTI.ColorID = modDTI.ColorID = int.Parse(ColorList[r].ToString());
                                modML.SizeID = modPTI.SizeID = modDTI.SizeID = int.Parse(SizeList[c].ToString());
                                modML.ColorOneID = modPTI.ColorOneID = modDTI.ColorOneID = int.Parse(ColorOneList[r].ToString());
                                modML.ColorTwoID = modPTI.ColorTwoID = modDTI.ColorTwoID = int.Parse(ColorTwoList[r].ToString());
                                modML.MaterielID = MaterielID;
                                modML.BrandID = BrandID;
                                modPTI.Amount = modDTI.Amount = int.Parse(dt.DefaultView[r][c].ToString());
                                modDTI.MainID = DepTaskID;
                                modPTI.MainID = TaskID;
                                modDTI.NotAmount = modDTI.Amount;
                                modDTI.MListID = bllML.GetID(modML);
                                bllDTI.Add(modDTI);
                                bllPTI.UpNotDepAmount(modPTI);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 显示生产单明细
        /// </summary>
        /// <param name="TaskID"></param>
        /// <param name="t">真加空行，假不加</param>
        /// <returns></returns>
        public DataSet ShowInfoList(int TaskID, bool t)
        {
            bool f = false;
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.Model.ProduceTaskInfo modPti = new Hownet.Model.ProduceTaskInfo();
            DataTable dtInfo = pti.GetList("(MainID=" + TaskID + ")").Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("Color", typeof(string));

            dt.Rows.Add(dt.NewRow());

            dt.Rows[0]["Color"] = "颜色\\尺码";

            SqlDataReader myReader = pti.GetSize(TaskID);

            int i = 1;
            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
 dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            for (int c = dt.Columns.Count; c < 12; c++)
            {
                dt.Columns.Add("Columns" + c);
            }
            dt.Columns.Add("SumNum");
            dt.Rows[0]["SumNum"] = "合计";
            dt.Columns.Add("ColorOne", typeof(string));
            dt.Columns.Add("ColorTwo", typeof(string));
            dt.Rows[0]["ColorOne"] = "插色一";
            dt.Rows[0]["ColorTwo"] = "插色二";
            SqlDataReader ColorReader = pti.GetColor(TaskID);
            i = 1;
            while (ColorReader.Read())
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = ColorReader[0].ToString();
                dt.Rows[i][dt.Columns.Count - 2] = ColorReader[3].ToString();
                dt.Rows[i][dt.Columns.Count - 1] = ColorReader[5].ToString();
                ColorList.Add(int.Parse(ColorReader[1].ToString()));
                ColorOneList.Add(int.Parse(ColorReader[4].ToString()));
                ColorTwoList.Add(int.Parse(ColorReader[6].ToString()));
                i++;
            }

            ColorReader.Close();
            for (int r = 1; r < SizeList.Count; r++)
            {
                modPti.SizeID = int.Parse(SizeList[r].ToString());
                for (int c = 1; c < ColorList.Count; c++)
                {
                    modPti.ColorID = int.Parse(ColorList[c].ToString());
                    modPti.ColorOneID = int.Parse(ColorOneList[c].ToString());
                    modPti.ColorTwoID = int.Parse(ColorTwoList[c].ToString());
                    modPti.MainID = TaskID;
                    string sql = "(SizeID=" + modPti.SizeID + ") and (ColorID=" + modPti.ColorID + ") and (ColorOneID=" + modPti.ColorOneID + ") and (ColorTwoID=" + modPti.ColorTwoID + ")";
                    DataRow[] drs = dtInfo.Select(sql);
                    if (drs.Length > 0)
                        dt.Rows[c][r] = drs[0]["Amount"];
                }
                
            }
            if (t)
            {
                //for (int r = dt.Rows.Count; r < 11; r++)
                //{
                //    DataRow dr = dt.NewRow();
                //    dt.Rows.Add(dr);
                //}
                dt.Rows.Add(dt.NewRow());
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }
        public void SaveTemInfo(DataTable dt, int TaskID, int MaterielID)
        {
            Hownet.BLL.MaterielAttribute blMa = new Hownet.BLL.MaterielAttribute();
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.BLL.MaterielList bllML = new MaterielList();
            Hownet.Model.MaterielList modML = new Hownet.Model.MaterielList();
            Hownet.Model.ProduceTaskInfo modPTI = new Hownet.Model.ProduceTaskInfo();

            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            for (int r = 1; r < dt.Rows.Count - 1; r++)
            {
                int colorID = 0;
                if (dt.DefaultView[r]["Color"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["Color"].ToString(), 1);
                }
                ColorList.Add(colorID);
                colorID = 0;
                if (dt.DefaultView[r]["ColorOne"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["ColorOne"].ToString(), 1);
                }
                ColorOneList.Add(colorID);
                colorID = 0;
                if (dt.DefaultView[r]["ColorTwo"].ToString() != string.Empty)
                {
                    colorID = blMa.GetID(dt.DefaultView[r]["ColorTwo"].ToString(), 1);
                }
                ColorTwoList.Add(colorID);
            }
            for (int c = 1; c < dt.Columns.Count - 3; c++)
            {
                int sizeID = 0;
                if (dt.DefaultView[0][c].ToString() != string.Empty)
                {
                    sizeID = blMa.GetID(dt.DefaultView[0][c].ToString(), 2);
                }
                SizeList.Add(sizeID);
            }
            for (int r = 0; r < ColorList.Count; r++)
            {
                if (ColorList[r].ToString() != "0")
                {
                    for (int c = 0; c < SizeList.Count; c++)
                    {
                        if (SizeList[c].ToString() != "0")
                        {
                            if (dt.DefaultView[r][c].ToString() != string.Empty && dt.DefaultView[r][c].ToString() != "0")
                            {
                                modML.ColorID = modPTI.ColorID = int.Parse(ColorList[r].ToString());
                                modML.SizeID = modPTI.SizeID = int.Parse(SizeList[c].ToString());
                                modML.ColorOneID = modPTI.ColorOneID = int.Parse(ColorOneList[r].ToString());
                                modML.ColorTwoID = modPTI.ColorTwoID = int.Parse(ColorTwoList[r].ToString());
                                modML.MaterielID = MaterielID;
                                modML.BrandID =0;
                                modPTI.MListID = bllML.GetID(modML);
                                modPTI.Amount = int.Parse(dt.DefaultView[r][c].ToString());
                                modPTI.MainID = TaskID;
                                modPTI.NotDepAmount = modPTI.NotAmount = modPTI.Amount;
                                pti.Add(modPTI);
                            }
                        }
                    }
                }
            }
        }
        public DataSet ShowTemInfo(int TaskID, bool t)
        {
            bool f = false;
            Hownet.BLL.ProduceTaskInfo pti = new ProduceTaskInfo();
            Hownet.Model.ProduceTaskInfo modPti = new Hownet.Model.ProduceTaskInfo();

            DataTable dtInfo = pti.GetList("(MainID=" + TaskID + ")").Tables[0];
            DataTable dt = new DataTable();
            dt.Columns.Add("Color", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["Color"] = "颜色\\尺码";
            SqlDataReader myReader = pti.GetSize(TaskID);

            int i = 1;
            ArrayList ColorList = new ArrayList();
            ArrayList SizeList = new ArrayList();
            ArrayList ColorOneList = new ArrayList();
            ArrayList ColorTwoList = new ArrayList();
            ColorList.Clear();
            ColorOneList.Clear();
            ColorTwoList.Clear();
            SizeList.Clear();
            ColorList.Add(0);
            SizeList.Add(0);
            ColorOneList.Add(0);
            ColorTwoList.Add(0);
            while (myReader.Read())
            {
                dt.Columns.Add("Columns" + i);
                dt.Rows[0][i] = myReader[0].ToString();
                SizeList.Add(int.Parse(myReader[1].ToString()));
                i++;
            }
            myReader.Close();
            for (int c = dt.Columns.Count; c < 8; c++)
            {
                dt.Columns.Add("Columns" + c);
            }
            dt.Columns.Add("SumNum");
            dt.Rows[0]["SumNum"] = "合计";
            dt.Columns.Add("ColorOne", typeof(string));
            dt.Columns.Add("ColorTwo", typeof(string));
            dt.Rows[0]["ColorOne"] = "插色一";
            dt.Rows[0]["ColorTwo"] = "插色二";
            SqlDataReader ColorReader = pti.GetColor(TaskID);
            i = 1;
            while (ColorReader.Read())
            {
                dt.Rows.Add(dt.NewRow());
                dt.Rows[i][0] = ColorReader[0].ToString();
                dt.Rows[i][dt.Columns.Count - 2] = ColorReader[3].ToString();
                dt.Rows[i][dt.Columns.Count - 1] = ColorReader[5].ToString();
                ColorList.Add(int.Parse(ColorReader[1].ToString()));
                ColorOneList.Add(int.Parse(ColorReader[4].ToString()));
                ColorTwoList.Add(int.Parse(ColorReader[6].ToString()));
                i++;
            }
            ColorReader.Close();
            DataTable dtNotAmount = dt.Copy();
            DataTable dtBackAmount = dt.Copy();
            for (int r = 1; r < SizeList.Count; r++)
            {
                modPti.SizeID = int.Parse(SizeList[r].ToString());
                for (int c = 1; c < ColorList.Count; c++)
                {
                    modPti.ColorID = int.Parse(ColorList[c].ToString());
                    modPti.ColorOneID = int.Parse(ColorOneList[c].ToString());
                    modPti.ColorTwoID = int.Parse(ColorTwoList[c].ToString());
                    modPti.MainID = TaskID;
                    string sql = "(SizeID=" + modPti.SizeID + ") and (ColorID=" + modPti.ColorID + ") and (ColorOneID=" + modPti.ColorOneID + ") and (ColorTwoID=" + modPti.ColorTwoID + ")";
                    DataRow[] drs = dtInfo.Select(sql);
                    if (drs.Length > 0)
                    {
                        dt.Rows[c][r] = drs[0]["Amount"];
                        dtNotAmount.Rows[c][r] = drs[0]["NotAmount"];
                        dtBackAmount.Rows[c][r] = drs[0]["BackAmount"];
                    }
                }

            }
            if (t)
            {
                //for (int r = dt.Rows.Count; r < 11; r++)
                //{
                //    DataRow dr = dt.NewRow();
                //    dt.Rows.Add(dr);
                //}
                dt.Rows.Add(dt.NewRow());
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.Tables.Add(dtNotAmount);
            ds.Tables.Add(dtBackAmount);
            return ds;
        }
    }
}
