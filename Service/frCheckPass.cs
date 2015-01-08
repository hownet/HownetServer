using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Service
{
    public partial class frCheckPass : Form
    {
        public frCheckPass()
        {
            InitializeComponent();
        }
        Hownet.BLL.Users bllU = new Hownet.BLL.Users();
        private void button1_Click(object sender, EventArgs e)
        {
           
            string pass = Encrypt(textBox1.Text.Trim(), "howneter");
            byte[] bb = Convert.FromBase64String(pass);

            if (bllU.CheckUser(Convert.ToInt32(bllU.GetTopList(1, "", "ID").Tables[0].Rows[0]["ID"]), bb))
            {
                this.Close();
                Form fr = new frPermissions();
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("密码错误！");
                textBox1.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string Encrypt(string pToEncrypt, string sKey)
        {

            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(pToEncrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                return str;
            }
        }
    }
}
