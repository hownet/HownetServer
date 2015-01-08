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
    public partial class frDepositSet : Form
    {
        public frDepositSet()
        {
            InitializeComponent();
        }
        Hownet.BLL.SysFormula bllSF = new Hownet.BLL.SysFormula();
        List<Hownet.Model.SysFormula> li = new List<Hownet.Model.SysFormula>();
        private void button1_Click(object sender, EventArgs e)
        {
            if (li.Count > 0)
            {
                li[0].Value1 = maskedTextBox1.Text;
                li[0].Value2 = maskedTextBox2.Text;
                bllSF.Update(li[0]);
            }
            else
            {
                Hownet.Model.SysFormula modSF = new Hownet.Model.SysFormula();
                modSF.Value1 = maskedTextBox1.Text;
                modSF.Value2 = maskedTextBox2.Text;
                modSF.TypeID = (int)BaseEnum.Formula.押金;
                modSF.Value3 = modSF.Value4 = modSF.Value5 = modSF.Value6 = modSF.Value7 = modSF.Value8 = modSF.Operator1 = modSF.Operator2 = modSF.Operator3 = modSF.Operator4 = modSF.Operator5 = modSF.Operator6 = modSF.Operator7 = modSF.Operator8 = string.Empty;
                bllSF.Add(modSF);
                this.Close();
            }
        }

        private void frDepositSet_Load(object sender, EventArgs e)
        {
            li = bllSF.GetModelList("(TypeID=" + (int)BaseEnum.Formula.押金 + ")");
            if (li.Count > 0)
            {
                maskedTextBox1.Text = li[0].Value1;
                maskedTextBox2.Text = li[0].Value2;
            }
        }
    }
}
