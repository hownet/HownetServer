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
    public partial class frAbout : Form
    {
        public frAbout()
        {
            InitializeComponent();
        }

        private void frAbout_Load(object sender, EventArgs e)
        {
            if (Hownet.BLL.GetHDID.LinesCount == 0)
            {
                Hownet.BLL.GetHDID.CheckReg();
            }
            if (Hownet.BLL.GetHDID.LinesCount == -1)
            {
                textBox1.Text = Hownet.BLL.GetHDID.md5One();
                tabControl1.SelectedTab = tabPage1;
            }
            else
            {
                label1.Text = "授权给："+Hownet.BLL.GetHDID.ClientName;
                label2.Text = "授权用户数量："+Hownet.BLL.GetHDID.LinesCount.ToString();
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
