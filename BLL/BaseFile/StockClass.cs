using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;

namespace Hownet.BLL.BaseFile
{
  public  class StockClass
    {
        /// <summary>
        /// 根据生产订单编号取得BOM拆分后的物料需求
        /// </summary>
        /// <param name="li"></param>
        /// <returns></returns>
        public DataTable GetStockOne(ArrayList li)
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
            dt.Columns.Add("stockAmount", typeof(decimal));
            dt.Columns.Add("stockNotAmount", typeof(decimal));
            dt.Columns.Add("MeasureID", typeof(int));
            dt.Columns.Add("ProduceTaskNum", typeof(string));
            dt.Columns.Add("ProduceName", typeof(int));

            DataTable dtMD = dt.Clone();
            DataTable dtPL = new DataTable();
            dtPL.TableName = "dtPL";
            dtPL.Columns.Add("DemandID", typeof(int));
            dtPL.Columns.Add("MaterielID", typeof(int));
            dtPL.Columns.Add("ColorID", typeof(int));
            dtPL.Columns.Add("ColorOneID", typeof(int));
            dtPL.Columns.Add("ColorTwoID", typeof(int));
            dtPL.Columns.Add("SizeID", typeof(int));
            dtPL.Columns.Add("ColorNum", typeof(string));
            dtPL.Columns.Add("GuiGe1", typeof(string));
            dtPL.Columns.Add("GuiGe2", typeof(string));
            //dtPL.Columns.Add("MListID", typeof(int));
            dtPL.Columns.Add("stockAmount", typeof(decimal));
            dtPL.Columns.Add("stockNotAmount", typeof(decimal));
            dtPL.Columns.Add("NowAmount", typeof(decimal));
            dtPL.Columns.Add("TemAmount", typeof(decimal));
            dtPL.Columns.Add("MeasureID", typeof(int));
            dtPL.Columns.Add("A", typeof(string));
            dtPL.Columns.Add("ProduceTaskNum", typeof(string));
            dtPL.Columns.Add("ProduceName", typeof(int));
            for (int i = 0; i < li.Count; i++)
            {
                int TaskID = int.Parse(li[i].ToString());
                //TaskID = dalPTM.GetID(TaskID);
                DataSet ds = dalMD.GetStock(TaskID);
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
                dr["stockAmount"] = dt.DefaultView[i]["stockAmount"];
                dr["stockNotAmount"] = dt.DefaultView[i]["stockNotAmount"];
                dr["TemAmount"] = dt.DefaultView[i]["stockNotAmount"];
                dr["MeasureID"] = dt.DefaultView[i]["MeasureID"];
                dr["ProduceTaskNum"] = dt.DefaultView[i]["ProduceTaskNum"];
                dr["ProduceName"] = dt.DefaultView[i]["ProduceName"];
                //  dr["DemandID"] = dt.DefaultView[i]["DemandID"];
                dtPL.Rows.Add(dr);

            }
            return dtPL;
        }
        public DataTable GroupTable(DataTable dt)
        {
            bool t = false;
            DataTable dtMD = dt.Clone();
            decimal temAmount = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.DefaultView[i]["NowAmount"] != null && dt.DefaultView[i]["NowAmount"].ToString() != string.Empty)
                {
                    for (int j = 0; j < dtMD.Rows.Count; j++)
                    {
                        if (dt.DefaultView[i]["MaterielID"].Equals(dtMD.DefaultView[j]["MaterielID"]) && dt.DefaultView[i]["ColorID"].Equals(dtMD.DefaultView[j]["ColorID"]) &&
                            dt.DefaultView[i]["MeasureID"].Equals(dtMD.DefaultView[j]["MeasureID"]) && dt.DefaultView[i]["ColorOneID"].Equals(dtMD.DefaultView[j]["ColorOneID"]) &&
                            dt.DefaultView[i]["ColorTwoID"].Equals(dtMD.DefaultView[j]["ColorTwoID"]) && dt.DefaultView[i]["SizeID"].Equals(dtMD.DefaultView[j]["SizeID"]))
                        {
                            dtMD.Rows[j]["stockAmount"] = decimal.Parse(dt.DefaultView[i]["stockAmount"].ToString()) + decimal.Parse(dtMD.DefaultView[j]["stockAmount"].ToString());
                            dtMD.Rows[j]["stockNotAmount"] = decimal.Parse(dt.DefaultView[i]["stockNotAmount"].ToString()) + decimal.Parse(dtMD.DefaultView[j]["stockNotAmount"].ToString());
                            if (dt.DefaultView[i]["NowAmount"] != null && dt.DefaultView[i]["NowAmount"].ToString() != string.Empty)
                                temAmount = decimal.Parse(dt.DefaultView[i]["NowAmount"].ToString());
                            if (dtMD.DefaultView[j]["NowAmount"] != null && dtMD.DefaultView[j]["NowAmount"].ToString() != string.Empty)
                                temAmount += decimal.Parse(dtMD.DefaultView[j]["NowAmount"].ToString());
                            dtMD.Rows[j]["NowAmount"] = temAmount;
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
                        dr["NowAmount"] = dt.DefaultView[i]["NowAmount"];
                        dr["stockNotAmount"] = dt.DefaultView[i]["stockNotAmount"];
                        dr["stockAmount"] = dt.DefaultView[i]["stockAmount"];
                        dr["MeasureID"] = dt.DefaultView[i]["MeasureID"];
                        // dr["MListID"] = dt.DefaultView[i]["MListID"];
                        //dr[""] = dt.DefaultView[i][""];
                        dtMD.Rows.Add(dr);
                    }
                }
            }
            return dtMD;
        }
    }
}
