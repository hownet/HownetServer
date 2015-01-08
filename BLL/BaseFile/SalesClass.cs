using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Hownet.BLL.BaseFile
{
    public class SalesClass
    {
        public DataSet ShowInfo(DataSet ds,int RowID)
        {
            Hownet.Model.SalesOrderInfo modSOI = new Hownet.Model.SalesOrderInfo();
            DataTable dt = new DataTable();
            dt.Columns.Add("Color", typeof(string));
            dt.Rows.Add(dt.NewRow());
            dt.Rows[0]["Color"] = "颜色\\尺码";
            DataRow[] drS = ds.Tables[3].Select("(RowID=" + RowID + ")");
            int n = 0;
            for (int i = 0; i < drS.Length; i++)
            {
                n = i + 1;
                dt.Columns.Add("Columns" + n);
                dt.Rows[0][n] = drS[i]["SizeName"];
            }
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
            n = 0;
            DataRow[] drc = ds.Tables[2].Select("(RowID=" + RowID + ")");
            for (int i = 0; i < drc.Length; i++)
            {
                n = i + 1;
                dt.Rows.Add(dt.NewRow());
                dt.Rows[n][0] = drc[i]["ColorName"];
                dt.Rows[n][dt.Columns.Count - 2] = drc[i]["ColorOneName"].ToString();
                dt.Rows[n][dt.Columns.Count - 1] = drc[i]["ColorTwoName"].ToString();
            }
            n = 0;
            DataTable dtNotAmount = dt.Copy();
            DataTable dtSellAmount = dt.Copy();
            for (int r = 0; r < drS.Length; r++)
            {
                for (int c = 0; c < drc.Length; c++)
                {
                    modSOI.ColorID = int.Parse(drc[c]["ColorID"].ToString());
                    modSOI.SizeID = int.Parse(drS[r]["SizeID"].ToString());
                    modSOI.ColorOneID = int.Parse(drc[c]["ColorOneID"].ToString());
                    modSOI.ColorTwoID = int.Parse(drc[c]["ColorTwoID"].ToString());
                    object ob = ds.Tables[1].Rows[0]["RowID"];
                    object a = ds.Tables[1].Columns.Count;
                    object s = ds.Tables[1].Rows.Count;
                    string sql = "(RowID="+RowID+") and (SizeID=" + modSOI.SizeID + ") and (ColorID=" + modSOI.ColorID + ") and (ColorOneID=" + modSOI.ColorOneID + ") and (ColorTwoID=" + modSOI.ColorTwoID + ")";
                    DataRow[] drrr =ds.Tables[1].Select(sql);
                    if (drrr.Length > 0)
                    {
                        dt.Rows[c + 1][r + 1] = drrr[0]["Amount"];
                        dtNotAmount.Rows[c + 1][r + 1] = drrr[0]["NotAmount"];
                        dtSellAmount.Rows[c + 1][r + 1] = drrr[0]["SellAmount"];
                    }
                }
            }
            dt.Rows.Add(dt.NewRow());
            dtNotAmount.Rows.Add(dtNotAmount.NewRow());
            dtSellAmount.Rows.Add(dtSellAmount.NewRow());
            DataSet dss = new DataSet();
            dss.Tables.Add(dt);
            dss.Tables.Add(dtNotAmount);
            dss.Tables.Add(dtSellAmount);
            return dss;
        }
    }
}
