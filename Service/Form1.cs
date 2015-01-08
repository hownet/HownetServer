using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Service
{
    public partial class Form1 : Form
    {
        public static DateTime LastBackupTime = Convert.ToDateTime("1900-1-1");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReaderCard.BasicTable.dtEmployee;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((int) e.KeyChar)==13)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ReaderCard.BasicTable.dtCarReaderList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fr = new frColumns();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LastBackupTime=  GetLastBackupTime();
            MessageBox.Show(LastBackupTime.ToLongDateString() + " " + LastBackupTime.ToLongTimeString());
        }
        public static DateTime GetLastBackupTime()
        {
            Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
            DataTable dtTem = bllOT.GetList("(Name='备份文件夹位置')").Tables[0];
            string filePath = "C:\\";
            if (dtTem.Rows.Count > 0)
                filePath = dtTem.Rows[0]["Value"].ToString();
            DirectoryInfo di = new DirectoryInfo(filePath);

            FileInfo[] arrFi = di.GetFiles("*.bak");
           // SortAsFileCreationTime(ref arrFi);
            if (arrFi.Length > 0)
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("One");
                dt.Columns.Add("Two", typeof(DateTime));
                for (int i = 0; i < arrFi.Length; i++)
                {
                    dt.Rows.Add(arrFi[i].Name, Convert.ToDateTime(arrFi[i].CreationTime));
                }
                dt.DefaultView.Sort = "Two DESC";
                return Convert.ToDateTime(dt.DefaultView[0]["Two"]);
            }
            else
            {
                return Convert.ToDateTime("1900-1-1");
            }
           
        }

        /// <summary>
        /// C#按创建时间排序（顺序）
        /// </summary>
        /// <param name="arrFi">待排序数组</param>
        private void SortAsFileCreationTime(ref FileInfo[] arrFi)
        {
            Array.Sort(arrFi, delegate(FileInfo x, FileInfo y) { return x.CreationTime.CompareTo(x.CreationTime); });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form fr = new frDataUp();
            fr.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Form fr = new FormServer();
            //fr.ShowDialog();
        }
    }
}
