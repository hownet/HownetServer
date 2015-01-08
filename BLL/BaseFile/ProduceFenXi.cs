using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace Hownet.BLL.BaseFile
{
    public class ProduceFenXi
    {
        //public DataSet GetMateriel(int TaskID)
        //{
        //    Hownet.BLL.MaterielDemand bllMD = new MaterielDemand();
        //    Hownet.BLL.ProduceTask bllPT = new ProduceTask();
        //    Hownet.BLL.MaterielStruct bllMS = new MaterielStruct();
        //    Hownet.Model.MaterielDemand modMD = new Hownet.Model.MaterielDemand();

        //    DataSet ds = new DataSet();
        //    ds.Tables.Add("PeiLiao");

        //    ds.Tables["PeiLiao"].Clear();
        //    ds.Tables["PeiLiao"].Columns.Clear();

        //    ds.Tables["PeiLiao"].Columns.Add("Color", typeof(string));
        //    ds.Tables["PeiLiao"].Rows.Add(ds.Tables["PeiLiao"].NewRow());
        //    ds.Tables["PeiLiao"].Rows[0]["Color"] = "—’…´\\ŒÔ¡œ";
        //    SqlDataReader materielReader = bllMD.GetMateriel(TaskID);
        //    SqlDataReader colorReader = bllMD.GetColor(TaskID);

        //    int i = 1;
        //    ArrayList ColorList = new ArrayList();
        //    ArrayList MaterielList = new ArrayList();
        //    ColorList.Clear();
        //    MaterielList.Clear();
        //    ColorList.Add(0);
        //    MaterielList.Add(0);

        //    while (materielReader.Read())
        //    {
        //        ds.Tables["PeiLiao"].Columns.Add("Columns" + i);
        //        ds.Tables["PeiLiao"].Rows[0][i] = materielReader[0].ToString();
        //        MaterielList.Add(int.Parse(materielReader[1].ToString()));
        //        i++;
        //    }
        //    materielReader.Close();
        //    for (int c = ds.Tables["PeiLiao"].Columns.Count; c < 12; c++)
        //    {
        //        ds.Tables["PeiLiao"].Columns.Add("Columns" + c);
        //    }
        //    i = 1;
        //    while (colorReader.Read())
        //    {
        //        ds.Tables["PeiLiao"].Rows.Add(ds.Tables["PeiLiao"].NewRow());
        //        ds.Tables["PeiLiao"].Rows[i][0] = colorReader[0].ToString();
        //        ColorList.Add(int.Parse(colorReader[1].ToString()));
        //        i++;
        //    }
        //    colorReader.Close();
        //    modMD.ProduceTaskID = TaskID;
        //    DataTable dt = ds.Tables["PeiLiao"].Copy();
        //    dt.TableName = "Stock";
        //    ds.Tables.Add(dt);
        //    for (int r = 1; r < ColorList.Count; r++)
        //    {
        //        for (int c = 1; c < MaterielList.Count; c++)
        //        {
        //            modMD.ColorID = int.Parse(ColorList[r].ToString());
        //            modMD.MaterielID = int.Parse(MaterielList[c].ToString());
        //            ds.Tables["PeiLiao"].Rows[r][c] = bllMD.GetNotPeiLiaoAmount(modMD);
        //            ds.Tables["Stock"].Rows[r][c] = bllMD.GetNotStockAmount(modMD);
        //        }
        //    }

        //    return ds;
        //}
    }
}
