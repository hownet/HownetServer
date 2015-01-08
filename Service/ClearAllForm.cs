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
    public partial class ClearAllForm : Form
    {
        public ClearAllForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "hownet289232")
            {
                Hownet.BLL.SysTem bllST = new Hownet.BLL.SysTem();
                bllST.ClearAll();
                this.Close();
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("密码错误！");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
