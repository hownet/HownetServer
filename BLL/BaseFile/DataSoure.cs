using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Hownet.BLL.BaseFile
{
    public class DataSoure
    {
        public DataView getDS(string TypeName)
        {

            if (TypeName == "Measure")
            {
                Hownet.BLL.Measure bllM = new Measure();
                return bllM.GetAllList().Tables[0].DefaultView;
            }
            else if (TypeName == "Company")
            {
                Hownet.BLL.Company bllC = new Company();
                return bllC.GetList("TypeID=1").Tables[0].DefaultView;
            }
            else if (TypeName == "Materiel")
            {
                Hownet.BLL.Materiel bllMat = new Materiel();
                return bllMat.GetList("AttributeID=1").Tables[0].DefaultView;
            }
            else if (TypeName == "VerifyMan")
            {
                Hownet.BLL.Users bllU = new Users();
                return bllU.GetAllList().Tables[0].DefaultView;
            }
            else if (TypeName == "ProductsType")
            {
                Hownet.BLL.MaterielType bllMT = new MaterielType();
                return bllMT.GetList("AttributeID=1").Tables[0].DefaultView;
            }
            else
            {
                DataView dv = new DataView();
                return dv;
            }

        }
        public DataTable ClientOK()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(5,"等待客戶確認");
            dt.Rows.Add(6,"客戶確認通過");
            dt.Rows.Add(7,"客戶取消本單");
            dt.Rows.Add(8, "公司取消本單");
            return dt;
        }
        public DataTable UpTypeID()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Rows.Add(1, "請求方");
            dt.Rows.Add(2, "客戶方");
            return dt;
        }
        public int AddNew(string TypeName, string NewName)
        {
            int id = 0;
            if (TypeName == "Measure")
            {
                Hownet.BLL.Measure bllM = new Measure();
                Hownet.Model.Measure modM = new Hownet.Model.Measure();
                modM.Name = NewName;
                modM.Sn = "";
                id = bllM.Add(modM);
            }
            return id;
        }
        public string DMember(string TypeName)
        {
            if (TypeName == "Company" || TypeName == "SupplierF" || TypeName == "SupplierD")
            {
                return "MiniName";
            }
            else if (TypeName == "CountryMoney")
            {
                return "CNMoneyName";
            }
            else if (TypeName == "Payment")
            {
                return "EnName";
            }
            else if (TypeName == "VerifyMan")
            {
                return "TrueName";
            }
            else if (TypeName == "ProductsType")
            {
                return "TypeName";
            }
            else
            {
                return "Name";
            }
        }
        public string VMember(string TypeName)
        {
            if (TypeName == "VerifyMan")
            {
                return "UserID";
            }
            else if (TypeName == "ProductsType")
            {
                return "MaterielTypeID";
            }
            else
            {
                return "ID";
            }
        }
        public string ColName(string TypeName)
        {
            if (TypeName == "Measure")
            {
                return "單位-Name";
            }
            else if (TypeName == "Company")
            {
                return "客戶-MiniName";
            }
            else if (TypeName == "SupplierF" || TypeName == "SupplierD")
            {
                return "供應商-MiniName";
            }
            else if (TypeName == "Materiel")
            {
                return "公司款號-Name";
            }
            else if (TypeName == "CountryMoney")
            {
                return "幣種-CNMoneyName";
            }
            else if (TypeName == "Payment")
            {
                return "付款方式-EnName";
            }
            else if (TypeName == "Fabrics")
            {
                return "大身布種-Name";
            }
            else if (TypeName == "VerifyMan")
            {
                return "審核人-TrueName";
            }
            else if (TypeName == "BackAddress")
            {
                return "送貨地址-Name";
            }
            else if (TypeName == "Depot")
            {
                return "倉庫-Name";
            }
            else if (TypeName == "ProductsType")
            {
                return "款式類型-TypeName";
            }
            else if (TypeName == "Deparment")
            {
                return "所屬部門-Name";
            }
            else
            {
                return "名稱-Name";
            }
        }
        public static DataTable NeedIsVerify
        {
            get
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Rows.Add(1, "申請中");
                dt.Rows.Add(2, "審核未通過");
                dt.Rows.Add(3, "已審核未采購");
                dt.Rows.Add(4, "采購中");
                dt.Rows.Add(5, "采購已完成");
                return dt;
            }
        }

    }
}
