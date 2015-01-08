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
    public partial class frCardReader : Form
    {
        public frCardReader()
        {
            InitializeComponent();
        }
        Hownet.BLL.CardReaderList bllCRL = new Hownet.BLL.CardReaderList();
        Hownet.Model.CardReaderList modCRL = new Hownet.Model.CardReaderList();
        Hownet.BLL.Deparment bllDep = new Hownet.BLL.Deparment();
        DataTable dt = new DataTable();
        private void frCardReader_Load(object sender, EventArgs e)
        {
            dt = bllCRL.GetAllList().Tables[0];
            checkBox1.Checked = true;
            DataTable dtDep = new DataTable();
            dtDep = bllDep.GetList("IsEnd=0").Tables[0];
            DataRow dr = dtDep.NewRow();
            dr["ID"] = 0;
            dr["Name"] = string.Empty;
            dtDep.Rows.Add(dr);
            dtDep.DefaultView.Sort = "ID";
            comboBox1.DataSource = dtDep.DefaultView;
            button1.Enabled = button2.Enabled = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox5.Checked = checkBox3.Checked = checkBox4.Checked = checkBox2.Checked = !checkBox1.Checked;
                SetView();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox5.Checked = checkBox3.Checked = checkBox4.Checked = checkBox1.Checked = !checkBox2.Checked;
                SetView();
            }
        }
        private void SetView()
        {
            if (checkBox1.Checked)
            {
                dt.DefaultView.RowFilter = "TypeID=1";
            }
            else if (checkBox2.Checked)
            {
                dt.DefaultView.RowFilter = "TypeID=2";
            }
            else if (checkBox3.Checked)
            {
                dt.DefaultView.RowFilter = "TypeID=3";
            }
            else if (checkBox4.Checked)
            {
                dt.DefaultView.RowFilter = "TypeID=4";
            }
            else if (checkBox5.Checked)
            {
                dt.DefaultView.RowFilter = "TypeID=5";
            }
            else
            {
                dt.DefaultView.RowFilter = "TypeID=0";
            }
            dataGridView1.DataSource = dt.DefaultView;

        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            button2.Enabled = button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nid = 0;
            try
            {
                nid = Convert.ToInt32(textBox1.Text);
            }
            catch 
            {
                MessageBox.Show("机器号只能填大于0的正整数！");
                return;
            }
            if (nid < 1||nid>254)
            {
                MessageBox.Show("机器号只能填大于0且小于255的正整数！");
                return;
            }
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("请选择使用该机器的部门");
                return;
            }
            for (int i = 0; i <dt.Rows.Count; i++)
            {
                if (nid == Convert.ToInt32(dt.Rows[i]["NID"]))
                {
                    if (modCRL.ID == 0 || (modCRL.ID > 0 && modCRL.ID != Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentRow.Index].Value)))
                    {
                        MessageBox.Show("机器号" + nid.ToString() + "已在使用中！");
                        return;
                    }
                }
            }
            modCRL.A = 1;
            modCRL.NID = nid;
            modCRL.Location = Convert.ToInt32(comboBox1.SelectedValue);
            if (checkBox1.Checked)
                modCRL.TypeID = 1;
            else if (checkBox2.Checked)
                modCRL.TypeID = 2;
            else if (checkBox3.Checked)
                modCRL.TypeID = 3;
            else if (checkBox4.Checked)
                modCRL.TypeID = 4;
            else if (checkBox5.Checked)
                modCRL.TypeID = 5;
            else
                return;
            modCRL.Remark = textBox2.Text.Trim();
            if (modCRL.ID == 0)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = modCRL.ID = bllCRL.Add(modCRL);
                dr["TypeID"] = modCRL.TypeID;
                dr["NID"] = nid;
                dr["Location"] = modCRL.Location;
                dr["Remark"] = modCRL.Remark;
                dr["DeparmentName"] = comboBox1.Text;
                dt.Rows.Add(dr);
            }
            else
            {
                bllCRL.Update(modCRL);
                DataRow[] drs = dt.Select("ID=" + modCRL.ID  );
                drs[0]["TypeID"] = modCRL.TypeID;
                drs[0]["NID"] = nid;
                drs[0]["Location"] = modCRL.Location;
                drs[0]["Remark"] = modCRL.Remark;
                drs[0]["DeparmentName"] = comboBox1.Text;
                dt.AcceptChanges();
            }
           // dt = bllCRL.GetAllList().Tables[0];
            SetView();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modCRL = new Hownet.Model.CardReaderList();
            textBox1.Text = textBox2.Text = "";
            button1.Text = "添加";
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modCRL = new Hownet.Model.CardReaderList();
            modCRL.ID = Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentRow.Index].Value);
            textBox1.Text = dataGridView1["_coNID", dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1["_coRemark", dataGridView1.CurrentRow.Index].Value.ToString();
            comboBox1.SelectedValue = Convert.ToInt32(dataGridView1["_coLocation", dataGridView1.CurrentRow.Index].Value);
            button1.Text = "修改";
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否真的删除？", "请确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                if (checkBox5.Checked)
                {
                    bllCRL.DeleteInfo(Convert.ToInt32(dataGridView1["_coID", dataGridView1.CurrentRow.Index].Value));
                }
                bllCRL.Delete(Convert.ToInt32(dataGridView1["_coID", dataGridView1.CurrentRow.Index].Value));

                dt = bllCRL.GetAllList().Tables[0];
                SetView();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
              checkBox5.Checked=  checkBox2.Checked = checkBox4.Checked = checkBox1.Checked = !checkBox3.Checked;
                SetView();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox5.Checked = checkBox3.Checked = checkBox2.Checked = checkBox1.Checked = !checkBox4.Checked;
                SetView();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox4.Checked = checkBox3.Checked = checkBox2.Checked = checkBox1.Checked = !checkBox5.Checked;
                SetView();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (modCRL.ID > 0)
            {
                Form fr = new frAccessSet(modCRL.ID);
                fr.ShowDialog();
            }
        }
    }
}