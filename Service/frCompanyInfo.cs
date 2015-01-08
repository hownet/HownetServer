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
    public partial class frCompanyInfo : Form
    {
        public frCompanyInfo()
        {
            InitializeComponent();
        }
        private Hownet.BLL.SysTem bllST = new Hownet.BLL.SysTem();
        private Hownet.Model.SysTem modST = new Hownet.Model.SysTem();
        Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
        DataTable dtOT = new DataTable();
     //   private DataSet ds = new DataSet();
        private int ID = 0;
        private void frCompanyInfo_Load(object sender, EventArgs e)
        {
            dtOT = bllOT.GetList("(TypeID=" + (int)Hownet.BLL.Enums.OtherType.系统设置 + ")").Tables[0];
            DataRow[] drs = dtOT.Select("(Name='物料使用条码出入仓')");
            if (drs.Length == 0)
            {
                DataTable dtTem = dtOT.Clone();
                DataRow dr = dtTem.NewRow();
                dr["A"] = 1;
                dr["ID"] = 0;
                dr["Name"] = "物料使用条码出入仓";
                dr["TypeID"] = (int)Hownet.BLL.Enums.OtherType.系统设置;
                dr["Value"] = "False";
                dtTem.Rows.Add(dr);
                bllOT.AddByDt(dtTem);
            }
            else
            {
                try
                {
                    _chb物料使用条码出入仓.Checked = Convert.ToBoolean(drs[0]["Value"]);
                }
                catch (Exception ex)
                {
                }
            }

            drs = dtOT.Select("(Name='成品需按货架存放')");
            if (drs.Length == 0)
            {
                DataTable dtTem = dtOT.Clone();
                DataRow dr = dtTem.NewRow();
                dr["A"] = 1;
                dr["ID"] = 0;
                dr["Name"] = "成品需按货架存放";
                dr["TypeID"] = (int)Hownet.BLL.Enums.OtherType.系统设置;
                dr["Value"] = "False";
                dtTem.Rows.Add(dr);
                bllOT.AddByDt(dtTem);
            }
            else
            {
                try
                {
                    _chb成品需按货架存放.Checked = Convert.ToBoolean(drs[0]["Value"]);
                }
                catch (Exception ex)
                {
                }
            }
            drs = dtOT.Select("(Name='分组显示为部位')");
            if (drs.Length == 0)
            {
                DataTable dtTem = dtOT.Clone();
                DataRow dr = dtTem.NewRow();
                dr["A"] = 1;
                dr["ID"] = 0;
                dr["Name"] = "分组显示为部位";
                dr["TypeID"] = (int)Hownet.BLL.Enums.OtherType.系统设置;
                dr["Value"] = "False";
                dtTem.Rows.Add(dr);
                bllOT.AddByDt(dtTem);
            }
            else
            {
                try
                {
                    _chb分组显示为部位.Checked = Convert.ToBoolean(drs[0]["Value"]);
                }
                catch (Exception ex)
                {
                }
            }
             drs = dtOT.Select("(Name='备份文件夹位置')");
            if (drs.Length == 0)
            {
                DataTable dtTem = dtOT.Clone();
                DataRow dr = dtTem.NewRow();
                dr["A"] = 1;
                dr["ID"] = 0;
                dr["Name"] = "备份文件夹位置";
                dr["TypeID"] = (int)Hownet.BLL.Enums.OtherType.系统设置;
                dr["Value"] = @"E:\Backup";
                dtTem.Rows.Add(dr);
                bllOT.AddByDt(dtTem);
            }
            else
            {
                try
                {
                    _teBackUpDir.Text = drs[0]["Value"].ToString();
                }
                catch (Exception ex)
                {
                }
            }
            int _id = bllST.GetMaxId() - 1;
          //  ds = bllST.GetList("(ID=" + _id + ")");
            modST = bllST.GetModel(_id);
            Hownet.BLL.Working bllW=new Hownet.BLL.Working();
            Hownet.BLL.Deparment bllD = new Hownet.BLL.Deparment();
            _coBackDepot.DataSource = bllW.GetList("(IsSpecial=0)").Tables[0];
            DataTable dtD=bllD.GetList("(TypeID=42)").Tables[0];
            _coDefaultRaw.DataSource = dtD;
            DataTable dtDD= bllD.GetList("(TypeID=42) OR (TypeID=39)").Tables[0];
            //DataRow dr = dtDD.NewRow();
            //dr["ID"] = 0;
            //dr["Name"] = string.Empty;
            //dtDD.Rows.Add(dr);
            _coDefaultDepot.DataSource = dtDD;
            if (modST != null)
            {
                ID = modST.ID;
                _address.Text = modST.Address;
                _bank.Text = modST.BanKName;
                _bankID.Text = modST.BankNO;
                _bankUser.Text = modST.BankUserName;
                _comName.Text = modST.CompanyName;
                _fax.Text = modST.Fax;
                _linkMan.Text = modST.LinkMan;
                _phone.Text = modST.Phone;
                _ceDirect.Checked = modST.Direct2Depot;
                _ceSell.Checked = modST.Sell4Depot;
                _ceAutoClient.Checked = modST.AutoClient;
                _chBoxOrPic.Checked = modST.BoxOrPic;
                _Mobile.Text = modST.Mobile;
                _coNumType.SelectedIndex = modST.NumType;
                _coSellMoney.SelectedIndex = modST.SellMoney;
                _ceCustom.Checked = modST.CustOder;
                _chNotPermissions.Checked = modST.NotPermissions;
                _ceDepotAllowNegative.Checked = modST.DepotAllowNegative;
                _ceIsChangedSales.Checked = modST.IsChangedSales;
                _coBackDepot.SelectedValue = modST.BackDepotWorking;
                _mbOderOne.Text = modST.OderOne.ToString().PadLeft(2, '0');
                _mbOderTwo.Text = modST.OderTwo.ToString().PadLeft(2, '0');
                _mbOrderThree.Text = modST.OderThree.ToString().PadLeft(2, '0');
                _ceAutoCaicBoardWages.Checked = modST.AutoCaicBoardWages;
                _coDefaultRaw.SelectedValue = modST.DefaultRawDepot;
                _coDefaultDepot.SelectedValue = modST.DefaultDepot;
                _ceIsShowMoney.Checked = modST.IsShowMoney;
                _ceCompanyByUser.Checked = modST.CompanyByUser;
                _teDoubleNotDefaultWTNum.Text = modST.DoubleNotDefaultWTNum.ToString();
                _meOrderDays.Text = modST.OrderDays.ToString();
                _ceOrderNeedEat.Checked = modST.OrderNeedEat;
                _ceIsCheckNoWork.Checked = modST.IsCheckNoWork;
                _ceIsCanEditAmount.Checked = modST.IsCanEditAmount;
                _ceIsAutoClose.Checked = modST.IsAutoClose;
                _ceIsTicketNotNeedCaic.Checked = modST.IsTicketNotNeedCaic;
                _ceIsShowOutEmp.Checked = modST.IsShowOutEmp;
                _chMaterielByTask.Checked = modST.MaterielByTask;
                _chMaterielByTask.Enabled = bllST.CheckCanSetMatByTask();
                _ceSumByWorking.Checked = modST.SumByWorking;
                _tbRegistration.Text = modST.Registration;

            }
            else
            {
                modST = new Hownet.Model.SysTem();
                _coDefaultRaw.SelectedValue = _coDefaultDepot.SelectedValue = 0;
                _teDoubleNotDefaultWTNum.Text = "0";
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modST.Address = _address.Text.Trim();
            modST.BanKName = _bank.Text.Trim();
            modST.BankNO = _bankID.Text.Trim();
            modST.BankUserName = _bankUser.Text.Trim();
            modST.CompanyName = _comName.Text.Trim();
            modST.Fax = _fax.Text.Trim();
            modST.LinkMan = _linkMan.Text.Trim();
            modST.Mobile = _Mobile.Text.Trim();
            modST.Phone = _phone.Text.Trim();
            modST.Sell4Depot = _ceSell.Checked;
            modST.Direct2Depot = _ceDirect.Checked;
            modST.AutoClient = _ceAutoClient.Checked;
            modST.BoxOrPic = _chBoxOrPic.Checked;
            modST.CustOder = _ceCustom.Checked;
            modST.NotPermissions = _chNotPermissions.Checked;
            modST.DepotAllowNegative = _ceDepotAllowNegative.Checked;
            modST.IsChangedSales = _ceIsChangedSales.Checked;
            modST.Registration = _tbRegistration.Text.Trim().PadLeft(2, '0');
            if (modST.Registration != string.Empty)
            {
                try
                {
                    int day = Convert.ToInt32(modST.Registration);
                    if (day > 28)
                    {
                        MessageBox.Show("日期填写不正确");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("日期填写不正确");
                    return;
                }
            }
            try
            {
                modST.OderOne = Convert.ToInt32(_mbOderOne.Text);
            }
            catch
            {
                modST.OderOne = 9;
            }
            try
            {
                modST.OderTwo = Convert.ToInt32(_mbOderTwo.Text);
            }
            catch
            {
                modST.OderTwo = 15;
            }
            try
            {
                modST.OderThree = Convert.ToInt32(_mbOrderThree.Text);
            }
            catch
            {
                modST.OderThree = 19;
            }
            if (_coBackDepot.SelectedIndex > -1)
                modST.BackDepotWorking = Convert.ToInt32(_coBackDepot.SelectedValue);
            else
                modST.BackDepotWorking = 0;
            if (_coNumType.SelectedIndex > -1)
                modST.NumType = _coNumType.SelectedIndex;
            else
                modST.NumType = 0;
            if (_coSellMoney.SelectedIndex > -1)
                modST.SellMoney = _coSellMoney.SelectedIndex;
            else
                modST.SellMoney = 0;
            modST.AutoCaicBoardWages = _ceAutoCaicBoardWages.Checked;
            if (_coDefaultRaw.SelectedIndex > -1)
                modST.DefaultRawDepot = Convert.ToInt32(_coDefaultRaw.SelectedValue);
            else
                modST.DefaultRawDepot = 0;
            if (_coDefaultDepot.SelectedIndex > -1)
                modST.DefaultDepot = Convert.ToInt32(_coDefaultDepot.SelectedValue);
            else
                modST.DefaultDepot = 0;
            modST.IsShowMoney = _ceIsShowMoney.Checked;
            modST.CompanyByUser = _ceCompanyByUser.Checked;
            try
            {
                modST.DoubleNotDefaultWTNum = Convert.ToDecimal(_teDoubleNotDefaultWTNum.Text);
            }
            catch
            {
                modST.DoubleNotDefaultWTNum = 0;
            }
            try
            {
                modST.OrderDays = Convert.ToInt32(_meOrderDays.Text);
            }
            catch
            {
                modST.OrderDays = 0;
            }
            modST.OrderNeedEat = _ceOrderNeedEat.Checked;
            modST.IsCheckNoWork = _ceIsCheckNoWork.Checked;
            modST.IsCanEditAmount = _ceIsCanEditAmount.Checked;
            modST.IsAutoClose =_ceIsAutoClose.Checked;
            modST.IsTicketNotNeedCaic = _ceIsTicketNotNeedCaic.Checked;
            modST.IsShowOutEmp = _ceIsShowOutEmp.Checked;
            modST.MaterielByTask = _chMaterielByTask.Checked;
            modST.SumByWorking = _ceSumByWorking.Checked;
            if (ID > 0)
                bllST.Update(modST);
            else
                modST.ID = ID = bllST.Add(modST);
            DataTable dtTem = bllOT.GetList("(Name='物料使用条码出入仓')").Tables[0];
            dtTem.Rows[0]["Value"] = _chb物料使用条码出入仓.Checked;
            bllOT.UpdateByDt(dtTem);

            dtTem = bllOT.GetList("(Name='成品需按货架存放')").Tables[0];
            dtTem.Rows[0]["Value"] = _chb成品需按货架存放.Checked;
            bllOT.UpdateByDt(dtTem);

            dtTem = bllOT.GetList("(Name='分组显示为部位')").Tables[0];
            dtTem.Rows[0]["Value"] =_chb分组显示为部位 .Checked;
            bllOT.UpdateByDt(dtTem);

            dtTem = bllOT.GetList("(Name='备份文件夹位置')").Tables[0];
            dtTem.Rows[0]["Value"] =_teBackUpDir.Text;
            bllOT.UpdateByDt(dtTem);

            MessageBox.Show("保存成功！");
            BaseClass.dsSysTem = bllST.GetList("(ID=" + ID + ")");
            ReaderCard.BasicTable.BackDepotWorkingID = modST.BackDepotWorking;
            ReaderCard.BasicTable.DefaultDepot = modST.DefaultDepot;
            ReaderCard.BasicTable.IsShowMoney = modST.IsShowMoney;
            ReaderCard.BasicTable.modST = ReaderCard.BasicTable.bllST.GetModel(ReaderCard.BasicTable.bllST.GetMaxId() - 1);
            FileTransportService fts = new FileTransportService();
            fts.SetDataTable();
            //ReaderCard.BasicTable.AttendanceNID = BaseClass.dsSysTem.Tables[0].Rows[0]["AttendanceNID"].ToString();
            //ReaderCard.BasicTable.NID = ReaderCard.BasicTable.AttendanceNID.Split(',');
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Close();
        }

        private void _ceSell_CheckedChanged(object sender, EventArgs e)
        {
            _chBoxOrPic.Checked = _ceSell.Checked;
        }

        private void _chBoxOrPic_CheckedChanged(object sender, EventArgs e)
        {
            _ceSell.Checked = _chBoxOrPic.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form fr = new ReaderCard.frCardReader();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fr = new ReaderCard.frDepositSet();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fr = new frFinishedMeasure();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            
            dialog.Description = "请选择文件路径";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                _teBackUpDir.Text = foldPath;
                MessageBox.Show("已选择文件夹:" + foldPath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
