using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Service
{
    public partial class frFinishedMeasure : Form
    {
        public frFinishedMeasure()
        {
            InitializeComponent();
        }
        Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
        Hownet.BLL.Measure bllMea = new Hownet.BLL.Measure();
        DataTable dtOT = new DataTable();
        DataTable dtMea = new DataTable();
        List<Hownet.Model.OtherType> li;
        Hownet.BLL.PackAmount bllPA = new Hownet.BLL.PackAmount();
        private void frFinishedMeasure_Load(object sender, EventArgs e)
        {
            dtMea = bllMea.GetAllList().Tables[0];
            comboBox1.DataSource = dtMea.Copy();
            comboBox2.DataSource = dtMea.Copy();
            comboBox3.DataSource = dtMea.Copy();
            dtOT = bllOT.GetTypeList("成品单位").Tables[0];
            if (dtOT.Rows.Count == 0)
            {
                Hownet.Model.OtherType modOT = new Hownet.Model.OtherType();
                modOT.A = 1;
                modOT.Name = "成品单位";
                modOT.TypeID = 0;
                modOT.Value = "0";
                int _id = bllOT.Add(modOT);
                modOT.TypeID = _id;
                modOT.Name = "默认单位";
                modOT.Value = "1";
                bllOT.Add(modOT);

                modOT.TypeID = _id;
                modOT.Name = "仓储单位";
                bllOT.Add(modOT);

                modOT.TypeID = _id;
                modOT.Name = "仓储换算";
                bllOT.Add(modOT);

                modOT.TypeID = _id;
                modOT.Name = "车间单位";
                bllOT.Add(modOT);

                modOT.TypeID = _id;
                modOT.Name = "车间换算";
                bllOT.Add(modOT);
                dtOT = bllOT.GetTypeList("成品单位").Tables[0];
            }
            li = bllOT.DataTableToList(dtOT);
            comboBox1.SelectedValue = Convert.ToInt32(dtOT.Select("(Name='默认单位')")[0]["Value"]);
            comboBox2.SelectedValue = Convert.ToInt32(dtOT.Select("(Name='车间单位')")[0]["Value"]);
            comboBox3.SelectedValue = Convert.ToInt32(dtOT.Select("(Name='仓储单位')")[0]["Value"]);
            textBox1.Text = dtOT.Select("(Name='车间换算')")[0]["Value"].ToString();
            textBox2.Text = dtOT.Select("(Name='仓储换算')")[0]["Value"].ToString();
            if (bllPA.GetAllList().Tables[0].Rows.Count > 0)
            {
                comboBox1.Enabled = comboBox2.Enabled = comboBox3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal aaa = Convert.ToDecimal(textBox1.Text.Trim());
                decimal bbbb = Convert.ToDecimal(textBox2.Text.Trim());
            }
            catch
            {
                MessageBox.Show("换算率只能是数字");
                return;
            }
            Hownet.Model.OtherType modOT = bllOT.GetModel(Convert.ToInt32(Convert.ToInt32(dtOT.Select("(Name='默认单位')")[0]["ID"])));
            modOT.Value = comboBox1.SelectedValue.ToString();
            bllOT.Update(modOT);

            modOT = bllOT.GetModel(Convert.ToInt32(Convert.ToInt32(dtOT.Select("(Name='车间单位')")[0]["ID"])));
            modOT.Value = comboBox2.SelectedValue.ToString();
            bllOT.Update(modOT);

            modOT = bllOT.GetModel(Convert.ToInt32(Convert.ToInt32(dtOT.Select("(Name='仓储单位')")[0]["ID"])));
            modOT.Value = comboBox3.SelectedValue.ToString();
            bllOT.Update(modOT);

            modOT = bllOT.GetModel(Convert.ToInt32(Convert.ToInt32(dtOT.Select("(Name='车间换算')")[0]["ID"])));
            modOT.Value = textBox1.Text.Trim();
            bllOT.Update(modOT);

            modOT = bllOT.GetModel(Convert.ToInt32(Convert.ToInt32(dtOT.Select("(Name='仓储换算')")[0]["ID"])));
            modOT.Value = textBox2.Text.Trim();
            bllOT.Update(modOT);

        }
    }
}
