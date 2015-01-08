using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReaderCard
{
    public partial class frAccessSet : Form
    {
        public frAccessSet()
        {
            InitializeComponent();
        }
        private int _AccessID = 0;
        public frAccessSet(int AccessID)
            : this()
        {
            _AccessID = AccessID;
        }
        Hownet.BLL.CardReaderList bllCRL = new Hownet.BLL.CardReaderList();
        Hownet.BLL.AccessList bllAL = new Hownet.BLL.AccessList();
        DataTable dtList = new DataTable();
        private void frAccessSet_Load(object sender, EventArgs e)
        {
            DataTable dt = bllCRL.GetList("(ID=" + _AccessID + ")").Tables[0];
            if (dt.Rows.Count > 0)
            {
                label1.Text = "机器号：" + dt.Rows[0]["NID"].ToString();
                label2.Text = "位置：" + dt.Rows[0]["DeparmentName"].ToString();
                dtList = bllAL.GetListByAccessID(_AccessID).Tables[0];
                dtList.Columns.Add("IsSelect", typeof(bool));
                dataGridView1.DataSource = dtList;
                for(int i=0;i<dataGridView1.Rows.Count;i++)
                {
                    if (dataGridView1["_coID", i].Value.ToString() != string.Empty)
                    {
                        dataGridView1["_coIsSelect", i].Value = true;
                    }
                    else
                    {
                        dataGridView1["_coIsSelect", i].Value = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hownet.Model.AccessList modAL;
            dtList.AcceptChanges();
            for (int i = 0; i <dtList.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dtList.Rows[i]["IsSelect"]))
                {
                    if (dtList.Rows[i]["ID"].ToString() == "")
                    {
                        modAL = new Hownet.Model.AccessList();
                        modAL.A = 1;
                        modAL.AccessID = _AccessID;
                        modAL.EmployeeID = Convert.ToInt32(dtList.Rows[i]["EmployeeID"]);
                        modAL.ID = 0;
                        modAL.Remark = dtList.Rows[i]["Remark"].ToString();
                        modAL.PassWord = dtList.Rows[i]["PassWord"].ToString();
                        dtList.Rows[i]["ID"] = bllAL.Add(modAL);
                    }
                }
                else
                {
                    if (dtList.Rows[i]["ID"].ToString() != "")
                    {
                        bllAL.Delete(Convert.ToInt32(dtList.Rows[i]["ID"]));
                    }
                }
            }
        }
    }
}
