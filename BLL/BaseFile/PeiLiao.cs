using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Hownet.BLL.BaseFile
{
    public class PeiLiao
    {
        public DataTable GetPeiLiaoOne(ArrayList li, int DepID)
        {
            Hownet.DAL.MaterielDemand dalMD = new Hownet.DAL.MaterielDemand();
            Hownet.DAL.ProduceTaskMain dalPTM = new Hownet.DAL.ProduceTaskMain();
            Hownet.DAL.MaterielList dalML = new Hownet.DAL.MaterielList();

            DataTable dt = new DataTable();
            dt.Columns.Add("DemandID", typeof(int));
            dt.Columns.Add("MaterielID", typeof(int));
            dt.Columns.Add("ColorID", typeof(int));
            dt.Columns.Add("ColorOneID", typeof(int));
            dt.Columns.Add("ColorTwoID", typeof(int));
            dt.Columns.Add("SizeID", typeof(int));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("NotAllotAmount", typeof(decimal));
            dt.Columns.Add("MeasureID", typeof(int));
            dt.Columns.Add("ProduceTaskNum", typeof(string));
            dt.Columns.Add("ProduceName", typeof(int));
            dt.Columns.Add("DepID", typeof(int));
            dt.Columns.Add("A", typeof(int));
            dt.Columns.Add("Price", typeof(string));
            DataTable dtPL = new DataTable();
            dtPL.TableName = "dtPL";
            dtPL.Columns.Add("DemandID", typeof(int));
            dtPL.Columns.Add("MaterielID", typeof(int));
            dtPL.Columns.Add("ColorID", typeof(int));
            dtPL.Columns.Add("ColorOneID", typeof(int));
            dtPL.Columns.Add("ColorTwoID", typeof(int));
            dtPL.Columns.Add("SizeID", typeof(int));
            //dtPL.Columns.Add("MListID", typeof(int));
            dtPL.Columns.Add("Amount", typeof(decimal));
            dtPL.Columns.Add("NotAllotAmount", typeof(decimal));
            dtPL.Columns.Add("TemNotAllotAmount", typeof(decimal));
            dtPL.Columns.Add("NowAmount", typeof(decimal));
            dtPL.Columns.Add("TemAmount", typeof(decimal));
            dtPL.Columns.Add("MeasureID", typeof(int));
            dtPL.Columns.Add("A", typeof(string));
            dtPL.Columns.Add("ProduceTaskNum", typeof(string));
            dtPL.Columns.Add("ProduceName", typeof(int));
            dtPL.Columns.Add("DepID", typeof(int));
            dtPL.Columns.Add("RowID", typeof(int));
            dtPL.Columns.Add("ID", typeof(int));
            dtPL.Columns.Add("Price", typeof(string));
            for (int i = 0; i < li.Count; i++)
            {
                int TaskID = int.Parse(li[i].ToString());
                //TaskID = dalPTM.GetID(TaskID);
                DataSet ds = dalMD.GetPeiLiao(TaskID,DepID);
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    DataRow dr = dt.NewRow();
                    dr.ItemArray = ds.Tables[0].Rows[j].ItemArray;
                    dt.Rows.Add(dr);
                }
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Hownet.Model.MaterielList modML = dalML.GetModel(int.Parse(dt.DefaultView[i]["MListID"].ToString()));
                DataRow dr = dtPL.NewRow();
                dr["DemandID"] = dt.DefaultView[i]["DemandID"];
                dr["MaterielID"] = dt.DefaultView[i]["MaterielID"];
                dr["ColorID"] = dt.DefaultView[i]["ColorID"];
                dr["ColorOneID"] = dt.DefaultView[i]["ColorOneID"];
                dr["ColorTwoID"] = dt.DefaultView[i]["ColorTwoID"];
                dr["SizeID"] = dt.DefaultView[i]["SizeID"];
                dr["Amount"] = dt.DefaultView[i]["Amount"];
                dr["NotAllotAmount"] = dt.DefaultView[i]["NotAllotAmount"];
                dr["TemNotAllotAmount"] = dt.DefaultView[i]["NotAllotAmount"];
                dr["MeasureID"] = dt.DefaultView[i]["MeasureID"];
                dr["ProduceTaskNum"] = ID2Num(dt.DefaultView[i]["ProduceTaskNum"].ToString());
                dr["ProduceName"] = dt.DefaultView[i]["ProduceName"];
                dr["DepID"] = dt.DefaultView[i]["DepID"];
                dr["RowID"] = i;
                dr["A"] = dt.DefaultView[i]["A"];
                dr["TemAmount"] =dr["ID"]= 0;
                dr["Price"] = dt.DefaultView[i]["Price"];
                dtPL.Rows.Add(dr);
            }
            dtPL.Columns.Add("MinXi", typeof(string));
            dtPL.Columns.Add("Remark", typeof(string));
            return dtPL;
        }
        public DataTable GroupTable(DataTable dt)
        {
            bool t = false;
            DataTable dtMD = dt.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dtMD.Rows.Count; j++)
                {
                    t = false;
                    if (dt.DefaultView[i]["MaterielID"].Equals(dtMD.DefaultView[j]["MaterielID"]) && dt.DefaultView[i]["ColorID"].Equals(dtMD.DefaultView[j]["ColorID"]) &&
                          dt.DefaultView[i]["DefaultMeasureID"].Equals(dtMD.DefaultView[j]["DefaultMeasureID"]) && dt.DefaultView[i]["ColorOneID"].Equals(dtMD.DefaultView[j]["ColorOneID"]) &&
                          dt.DefaultView[i]["ColorTwoID"].Equals(dtMD.DefaultView[j]["ColorTwoID"]) && dt.DefaultView[i]["SizeID"].Equals(dtMD.DefaultView[j]["SizeID"]) &&
                          dt.DefaultView[i]["DepID"].Equals(dtMD.DefaultView[j]["DepID"]))
                    {
                        dtMD.Rows[j]["Amount"] = decimal.Parse(dt.DefaultView[i]["Amount"].ToString()) + decimal.Parse(dtMD.DefaultView[j]["Amount"].ToString());
                        dtMD.Rows[j]["NotAllotAmount"] = decimal.Parse(dt.DefaultView[i]["NotAllotAmount"].ToString()) + decimal.Parse(dtMD.DefaultView[j]["NotAllotAmount"].ToString());
                        decimal amount = 0;
                        if (dt.DefaultView[i]["NowAmount"].ToString() != string.Empty)
                        {
                            amount = decimal.Parse(dt.DefaultView[i]["NowAmount"].ToString());
                        }
                        if (dtMD.DefaultView[j]["NowAmount"].ToString() != string.Empty)
                        {
                            amount = amount + decimal.Parse(dtMD.DefaultView[j]["NowAmount"].ToString());
                        }
                        if (amount != 0)
                        {
                            dtMD.Rows[j]["NowAmount"] = amount;
                        }
                        else
                        {
                            dtMD.Rows[j]["NowAmount"] = DBNull.Value;
                        }
                        t = true;
                        break;
                    }
                }
                if (!t)
                {
                    DataRow dr = dtMD.NewRow();
                    dr["MaterielID"] = dt.DefaultView[i]["MaterielID"];
                    dr["ColorID"] = dt.DefaultView[i]["ColorID"];
                    dr["ColorOneID"] = dt.DefaultView[i]["ColorOneID"];
                    dr["ColorTwoID"] = dt.DefaultView[i]["ColorTwoID"];
                    dr["SizeID"] = dt.DefaultView[i]["SizeID"];
                    dr["Amount"] = dt.DefaultView[i]["Amount"];
                    dr["NotAllotAmount"] = dt.DefaultView[i]["NotAllotAmount"];
                    dr["NowAmount"] = dt.DefaultView[i]["NowAmount"];
                    dr["DefaultMeasureID"] = dt.DefaultView[i]["DefaultMeasureID"];
                    dr["DepID"] = dt.DefaultView[i]["DepID"];
                    //dr["DepID"] = dt.DefaultView[i]["DepID"];
                    //   dr["MListID"] = dt.DefaultView[i]["MListID"];
                    //dr[""] = dt.DefaultView[i][""];
                    dtMD.Rows.Add(dr);
                }
            }
            return dtMD;
        }
        public string Num2ID(string Nums)
        {
            string IDs = string.Empty;
            Hownet.BLL.ProduceTaskMain bllPTM = new ProduceTaskMain();
            ArrayList li = new ArrayList();
            string[] split = Nums.Split(new Char[] { ',' });
            foreach (string a in split)
            {
                if (a.Trim() != "")
                {
                    li.Add(bllPTM.GetID(a.Trim().ToString()));
                }
            }
            for (int i = 0; i < li.Count; i++)
            {
                IDs = IDs + li[i].ToString() + ",";
            }
            if (IDs.Length > 0)
            {
                IDs = IDs.Remove(IDs.Length - 1);
            }
            return IDs;
        }
        public string ID2Num(string IDs)
        {
            string Nums = string.Empty;
            ArrayList li = new ArrayList();
            Num Num = new Num();
            Hownet.BLL.ProduceTaskMain bllPTM = new ProduceTaskMain();
            Hownet.Model.ProduceTaskMain modPTM;
            string[] split = IDs.Split(new Char[] { ',' });
            foreach (string a in split)
            {
                if (a.Trim() != "")
                    li.Add(a.Trim());
            }
            for (int i = 0; i < li.Count; i++)
            {
                modPTM = bllPTM.GetModel(int.Parse(li[i].ToString()));
                //Nums = Nums + modPTM.DateTime.ToString("yyyyMMdd") + Num.GetNum(modPTM.Num.ToString()) + ",";
            }
            if (Nums.Length > 0)
            {
                Nums = Nums.Remove(Nums.Length - 1);
            }
            return Nums;
        }
        public DataTable GetWaiXie(ArrayList li)
        {
            Hownet.DAL.MaterielDemand dalMD = new Hownet.DAL.MaterielDemand();
            Hownet.DAL.ProduceTaskMain dalPTM = new Hownet.DAL.ProduceTaskMain();
            Hownet.DAL.MaterielList dalML = new Hownet.DAL.MaterielList();

            DataTable dt = new DataTable();
            dt.Columns.Add("DemandID", typeof(int));
            dt.Columns.Add("MaterielID", typeof(int));
            dt.Columns.Add("ColorID", typeof(int));
            dt.Columns.Add("ColorOneID", typeof(int));
            dt.Columns.Add("ColorTwoID", typeof(int));
            dt.Columns.Add("SizeID", typeof(int));
            dt.Columns.Add("Amount", typeof(decimal));
            dt.Columns.Add("NotAllotAmount", typeof(decimal));
            dt.Columns.Add("DefaultMeasureID", typeof(int));
            dt.Columns.Add("ProduceTaskNum", typeof(string));
            dt.Columns.Add("ProduceName", typeof(int));
            dt.Columns.Add("DepID", typeof(int));
            dt.Columns.Add("A", typeof(int));
            DataTable dtPL = new DataTable();
            dtPL.TableName = "dtPL";
            dtPL.Columns.Add("DemandID", typeof(int));
            dtPL.Columns.Add("MaterielID", typeof(int));
            dtPL.Columns.Add("ColorID", typeof(int));
            dtPL.Columns.Add("ColorOneID", typeof(int));
            dtPL.Columns.Add("ColorTwoID", typeof(int));
            dtPL.Columns.Add("SizeID", typeof(int));
            //dtPL.Columns.Add("MListID", typeof(int));
            dtPL.Columns.Add("Amount", typeof(decimal));
            dtPL.Columns.Add("NotAmount", typeof(decimal));
            dtPL.Columns.Add("TemNotAmount", typeof(decimal));
            dtPL.Columns.Add("NowAmount", typeof(decimal));
            dtPL.Columns.Add("TemAmount", typeof(decimal));
            dtPL.Columns.Add("MeasureID", typeof(int));
            dtPL.Columns.Add("A", typeof(string));
            dtPL.Columns.Add("ProduceTaskNum", typeof(string));
            dtPL.Columns.Add("ProduceName", typeof(int));
            dtPL.Columns.Add("DepID", typeof(int));
            dtPL.Columns.Add("RowID", typeof(int));
            dtPL.Columns.Add("ID", typeof(int));
            for (int i = 0; i < li.Count; i++)
            {
                int TaskID = int.Parse(li[i].ToString());
                //TaskID = dalPTM.GetID(TaskID);
                DataSet ds = dalMD.GetWXList(TaskID);
                for (int j = 0; j < ds.Tables[0].Rows.Count; j++)
                {
                    DataRow dr = dt.NewRow();
                    dr.ItemArray = ds.Tables[0].Rows[j].ItemArray;
                    dt.Rows.Add(dr);
                }
            }


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Hownet.Model.MaterielList modML = dalML.GetModel(int.Parse(dt.DefaultView[i]["MListID"].ToString()));
                DataRow dr = dtPL.NewRow();
                dr["DemandID"] = dt.DefaultView[i]["DemandID"];
                dr["MaterielID"] = dt.DefaultView[i]["MaterielID"];
                dr["ColorID"] = dt.DefaultView[i]["ColorID"];
                dr["ColorOneID"] = dt.DefaultView[i]["ColorOneID"];
                dr["ColorTwoID"] = dt.DefaultView[i]["ColorTwoID"];
                dr["SizeID"] = dt.DefaultView[i]["SizeID"];
                dr["Amount"] = dt.DefaultView[i]["Amount"];
                dr["NotAmount"] = dt.DefaultView[i]["NotAllotAmount"];
                dr["TemNotAmount"] = dt.DefaultView[i]["NotAllotAmount"];
                dr["MeasureID"] = dt.DefaultView[i]["DefaultMeasureID"];
                dr["ProduceTaskNum"] = ID2Num(dt.DefaultView[i]["ProduceTaskNum"].ToString());
                dr["ProduceName"] = dt.DefaultView[i]["ProduceName"];
                dr["DepID"] = dt.DefaultView[i]["DepID"];
                dr["RowID"] = i;
                dr["A"] = dt.DefaultView[i]["A"];
                dr["TemAmount"] = dr["ID"] = 0;
                dtPL.Rows.Add(dr);
            }
            dtPL.Columns.Add("MinXi", typeof(string));
            dtPL.Columns.Add("Remark", typeof(string));
            return dtPL;
        }
    }
}
