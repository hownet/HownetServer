using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Hownet.BLL.BaseFile
{
    public class Product2DepotClass
    {
        public DataTable GroupTable(DataTable dt, DataTable dtSouGong)
        {
            bool t = false;
            Hownet.BLL.Materiel bllMat = new Materiel();
            Hownet.BLL.MaterielAttribute bllMA = new MaterielAttribute();
            Hownet.BLL.Department bllDep = new Department();
            DataTable dtMD = dtSouGong.Clone();
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                for (int j = 0; j < dtMD.Rows.Count; j++)
                {
                    t = false;
                    if (dt.DefaultView[i]["MaterielID"].Equals(dtMD.DefaultView[j]["MaterielID"]) && dt.DefaultView[i]["ColorID"].Equals(dtMD.DefaultView[j]["ColorID"]) &&
                          dt.DefaultView[i]["DepartmentID"].Equals(dtMD.DefaultView[j]["TaskID"]) && dt.DefaultView[i]["ProductTaskID"].Equals(dtMD.DefaultView[j]["ProduceTaskID"]) &&
                         dt.DefaultView[i]["SizeID"].Equals(dtMD.DefaultView[j]["SizeID"])&&dt.DefaultView[i]["BrandID"].Equals(dtMD.DefaultView[j]["BrandID"])&&
                         dt.DefaultView[i]["ColorOneID"].Equals(dtMD.DefaultView[j]["ColorOneID"]) && dt.DefaultView[i]["ColorTwoID"].Equals(dtMD.DefaultView[j]["ColorTwoID"]))
                    {
                        dtMD.Rows[j]["EligibleAmount"] = int.Parse(dt.DefaultView[i]["EligibleAmount"].ToString()) + int.Parse(dtMD.DefaultView[j]["EligibleAmount"].ToString());
                        dtMD.Rows[j]["InferiorAmount"] = int.Parse(dt.DefaultView[i]["InferiorAmount"].ToString()) + int.Parse(dtMD.DefaultView[j]["InferiorAmount"].ToString());
                        t = true;
                        break;
                    }
                }
                if (!t)
                {
                    DataRow dr = dtMD.NewRow();
                    dr["MaterielID"] = dt.DefaultView[i]["MaterielID"];
                    dr["ColorID"] = dt.DefaultView[i]["ColorID"];
                    dr["SizeID"] = dt.DefaultView[i]["SizeID"];
                    dr["TaskID"] = dt.DefaultView[i]["DepartmentID"];
                    dr["ProduceTaskID"] = dt.DefaultView[i]["ProductTaskID"];
                    dr["EligibleAmount"] = dt.DefaultView[i]["EligibleAmount"];
                    dr["InferiorAmount"] = dt.DefaultView[i]["InferiorAmount"];
                    dr["BrandID"] = dt.DefaultView[i]["BrandID"];
                    dr["ColorOneID"] = dt.DefaultView[i]["ColorOneID"];
                    dr["ColorTwoID"] = dt.DefaultView[i]["ColorTwoID"];
                    dtMD.Rows.Add(dr);
                }
            }
            for (int i = 0; i < dtSouGong.Rows.Count; i++)
            {

                for (int j = 0; j < dtMD.Rows.Count; j++)
                {
                    t = false;
                    if (dtSouGong.DefaultView[i][2].Equals(dtMD.DefaultView[j][2]) && dtSouGong.DefaultView[i][3].Equals(dtMD.DefaultView[j][3]) &&
                     dtSouGong.DefaultView[i][5].Equals(dtMD.DefaultView[j][5]) && dtSouGong.DefaultView[i][6].Equals(dtMD.DefaultView[j][6]) &&
                    dtSouGong.DefaultView[i][9].Equals(dtMD.DefaultView[j][9]) && dtSouGong.DefaultView[i]["BrandID"].Equals(dtMD.DefaultView[j]["BrandID"])&&
                        dtSouGong.DefaultView[i]["ColorOneID"].Equals(dtMD.DefaultView[j]["ColorOneID"]) && dtSouGong.DefaultView[i]["ColorTwoID"].Equals(dtMD.DefaultView[j]["ColorTwoID"]))
                    {
                        dtMD.Rows[j]["EligibleAmount"] = int.Parse(dtSouGong.DefaultView[i]["EligibleAmount"].ToString()) + int.Parse(dtMD.DefaultView[j]["EligibleAmount"].ToString());
                        dtMD.Rows[j]["InferiorAmount"] = int.Parse(dtSouGong.DefaultView[i]["InferiorAmount"].ToString()) + int.Parse(dtMD.DefaultView[j]["InferiorAmount"].ToString());
                        t = true;
                        break;
                    }
                }
                if (!t)
                {
                    DataRow dr = dtMD.NewRow();
                    dr["MaterielID"] = dtSouGong.DefaultView[i]["MaterielID"];
                    dr["ColorID"] = dtSouGong.DefaultView[i]["ColorID"];
                    dr["SizeID"] = dtSouGong.DefaultView[i]["SizeID"];
                    dr["TaskID"] = dtSouGong.DefaultView[i]["TaskID"];
                    dr["ProduceTaskID"] = dtSouGong.DefaultView[i]["ProduceTaskID"];
                    dr["EligibleAmount"] = dtSouGong.DefaultView[i]["EligibleAmount"];
                    dr["InferiorAmount"] = dtSouGong.DefaultView[i]["InferiorAmount"];
                    dr["BrandID"] = dtSouGong.DefaultView[i]["BrandID"];
                    dr["ColorOneID"] = dtSouGong.DefaultView[i]["ColorOneID"];
                    dr["ColorTwoID"] = dtSouGong.DefaultView[i]["ColorTwoID"];
                    dtMD.Rows.Add(dr);

                }
            }
            DataTable dtMat = bllMat.GetList("(AttributeID=1) OR (AttributeID=5)").Tables[0];
            DataTable dtMA = bllMA.GetAllList().Tables[0];
            DataTable dtDep = bllDep.GetTypeList("·ìÖÆ").Tables[0];
            dtMD.Columns.Add("MaterielName", typeof(string));
            dtMD.Columns.Add("ColorName", typeof(string));
            dtMD.Columns.Add("SizeName", typeof(string));
            dtMD.Columns.Add("DeparmentName", typeof(string));
            dtMD.Columns.Add("BrandName", typeof(string));
            dtMD.Columns.Add("ColorOneName", typeof(string));
            dtMD.Columns.Add("ColorTwoName", typeof(string));
            for (int i = 0; i < dtMD.Rows.Count; i++)
            {
                dtMD.Rows[i]["MaterielName"] = dtMat.Select("(MaterielID=" + dtMD.Rows[i]["MaterielID"] + ")")[0]["MaterielName"];
                dtMD.Rows[i]["ColorName"] = dtMA.Select("(MaterielAttributeID=" + dtMD.Rows[i]["ColorID"] + ")")[0]["MaterielAttributeName"];
                dtMD.Rows[i]["SizeName"] = dtMA.Select("(MaterielAttributeID=" + dtMD.Rows[i]["SizeID"] + ")")[0]["MaterielAttributeName"];
                dtMD.Rows[i]["DeparmentName"] = dtDep.Select("(DepartmentID=" + dtMD.Rows[i]["TaskID"] + ")")[0]["DepartmentName"];
                if (dtMD.Rows[i]["BrandID"].ToString() != "0")
                    dtMD.Rows[i]["BrandName"] = dtMat.Select("(MaterielID=" + dtMD.Rows[i]["BrandID"] + ")")[0]["MaterielName"];
                if (dtMD.Rows[i]["ColorOneID"].ToString() != "0")
                    dtMD.Rows[i]["ColorOneName"] = dtMA.Select("(MaterielAttributeID=" + dtMD.Rows[i]["ColorOneID"] + ")")[0]["MaterielAttributeName"];
                if (dtMD.Rows[i]["ColorTwoID"].ToString() != "0")
                    dtMD.Rows[i]["ColorTwoName"] = dtMA.Select("(MaterielAttributeID=" + dtMD.Rows[i]["ColorTwoID"] + ")")[0]["MaterielAttributeName"];
                object obj = dtMD.Rows[i]["BrandID"];
            }
            return dtMD;
        }
    }
}
