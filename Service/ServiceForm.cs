using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Configuration;
using System.ServiceModel.Channels;
using System.Reflection;
using System.Speech.Synthesis;
using System.Xml;
using System.Data.SQLite;
using System.Net;
using SanNiuSignal;

namespace Service
{
    public partial class ServiceForm : Form
    {
        public ServiceForm()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;  //检查非法跨线程调用，关闭
        }

        ServiceHost serviceHost = new ServiceHost(typeof(FileTransportService));
        ServiceHost host = new ServiceHost(typeof(Host.Service));

        ServiceHost hostAZ = new ServiceHost(typeof(Services.Services));


        
        public static string Dir = System.Windows.Forms.Application.StartupPath;
        private bool _isClose = false;
        //Hownet.BLL.SysTem bllST = new Hownet.BLL.SysTem();
        //Hownet.BLL.OtherType bllOT = new Hownet.BLL.OtherType();
        //Hownet.BLL.WorkTicketIDCard bllWTIDC = new Hownet.BLL.WorkTicketIDCard();
        //Hownet.BLL.MiniEmp bllME = new Hownet.BLL.MiniEmp();
        //   Uri uri = new Uri(ConfigurationManager.AppSettings["conAddress"]);//从配置文件中读取服务的Url
        //  ServiceHost host = new ServiceHost(typeof(ChatService), new Uri(ConfigurationManager.AppSettings["conAddress"]));
        private void ServiceForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            //watch.Reset();
            //watch.Start();
            //Hownet.BLL.Materiel bllMat = new Hownet.BLL.Materiel();
            //DataTable dt = bllMat.GetAllList().Tables[0];

            //SQLiteConnection.CreateFile(".\\a.db");//创建SQL文件  
            //SQLiteConnection con = new SQLiteConnection();//建立连接  
            //SQLiteConnectionStringBuilder sqlstr = new SQLiteConnectionStringBuilder();//构建连接字符串  
            //sqlstr.DataSource = ".\\a.db";
            ////sqlstr.Password = "irelia";
            //con.ConnectionString = sqlstr.ToString();
            //con.Open();//打开连接              
            //con.Close();//关闭连接  

            try
            {
                Maticsoft.DBUtility.DbHelperSQL.connOpen();
                serviceHost.Open();
                Thread.Sleep(50);
                host.Open();
                Thread.Sleep(50);
                hostAZ.Open();

                dataGridView1.DataSource = ReaderCard.BasicTable.dt;
                ReaderCard.BasicTable.bllME = new Hownet.BLL.MiniEmp();
                ReaderCard.BasicTable.bllWTI = new Hownet.BLL.WorkTicketInfo();
                ReaderCard.BasicTable.bllWTIDC = new Hownet.BLL.WorkTicketIDCard();
                ReaderCard.BasicTable.bllOT = new Hownet.BLL.OtherType();
                ReaderCard.BasicTable.bllAR = new Hownet.BLL.AttendanceRecords();
                ReaderCard.BasicTable.bllST = new Hownet.BLL.SysTem();
                ReaderCard.BasicTable.bllCRL = new Hownet.BLL.CardReaderList();
                ReaderCard.BasicTable.bllWType = new Hownet.BLL.WorkType();
                ReaderCard.BasicTable.bllPU = new Hownet.BLL.PermissionsUser();
                ReaderCard.BasicTable.bllST.UpDatabase();
                //}
                if (!Directory.Exists(Dir + @"\UploadFile\"))
                    Directory.CreateDirectory(Dir + @"\UploadFile\");
                if (!Directory.Exists(Dir + @"\Backup\"))
                    Directory.CreateDirectory(Dir + @"\Backup\");
                BaseClass.dsSysTem = ReaderCard.BasicTable.bllST.GetList("(ID=" + (ReaderCard.BasicTable.bllST.GetMaxId() - 1) + ")");

                ReaderCard.BasicTable.dtAttRules = ReaderCard.BasicTable.bllOT.GetTypeList("考勤设置").Tables[0];
                ReaderCard.BasicTable.dtWTCard = ReaderCard.BasicTable.bllWTIDC.GetAllListByCardID(0).Tables[0];
                ReaderCard.BasicTable.dtEmployee = ReaderCard.BasicTable.bllME.GetView().Tables[0];
                ReaderCard.BasicTable.dtMain = ReaderCard.BasicTable.bllWTIDC.GetdtMain().Tables[0];
                ReaderCard.BasicTable.dtEmpWorkList = ReaderCard.BasicTable.bllWTIDC.GetEmpWork(0).Tables[0];
                ReaderCard.BasicTable.dtWorkTime = ReaderCard.BasicTable.bllOT.GetWorkTime().Tables[0];
                ReaderCard.BasicTable.dtCarReaderList = ReaderCard.BasicTable.bllCRL.GetAllList().Tables[0];
                ReaderCard.BasicTable.dtWorkType = ReaderCard.BasicTable.bllWType.GetAllList().Tables[0];
                ReaderCard.BasicTable.dsPU = ReaderCard.BasicTable.bllPU.GetAllList();
                ReaderCard.BasicTable.modST = ReaderCard.BasicTable.bllST.GetModel(ReaderCard.BasicTable.bllST.GetMaxId() - 1);
                DataTable dtKQ=ReaderCard.BasicTable.bllOT.GetList("(Name='刷上班卡后才能计件')" ).Tables[0];
                if (dtKQ.Rows.Count == 0)
                {
                    DataRow dr = dtKQ.NewRow();
                    dr["A"] = 1;
                    dr["ID"] = 0;
                    dr["Name"] = "刷上班卡后才能计件";
                    dr["TypeID"] = -1;
                    dr["Value"] = 0;
                    dtKQ.Rows.Add(dr);
                    dtKQ.Rows[0]["ID"] = ReaderCard.BasicTable.bllOT.AddByDt(dtKQ);
                }
                ReaderCard.BasicTable.IsCheckKQ = Convert.ToInt32(dtKQ.Rows[0]["Value"]) == 1;
                if (BaseClass.dsSysTem.Tables.Count > 0)
                {
                    ReaderCard.BasicTable.BackDepotWorkingID = Convert.ToInt32(BaseClass.dsSysTem.Tables[0].Rows[0]["BackDepotWorking"]);
                    ReaderCard.BasicTable.DefaultDepot = Convert.ToInt32(BaseClass.dsSysTem.Tables[0].Rows[0]["DefaultDepot"]);
                    ReaderCard.BasicTable.IsShowMoney = Convert.ToBoolean(BaseClass.dsSysTem.Tables[0].Rows[0]["IsShowMoney"]);
                }
                // GetNum();
                Hownet.BLL.GetHDID.CheckReg();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                _isClose = true;
                Application.Exit();
                //Maticsoft.DBUtility.DbHelperSQL.connOpen();
            }

            
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                object o = dataGridView1[0, 0].Value;
                if (o == null || o.ToString().Trim() == "")
                {
                    dataGridView1.Rows.RemoveAt(i);
                    break;
                }
            }
        }
        private void GetNum()
        {
            if (File.Exists("strSql.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load("strSql.xml");
                XmlNodeList nodeList = xmlDoc.SelectSingleNode("TNumList").ChildNodes;//获取Employees节点的所有子节点
                int ver = Convert.ToInt32(ReaderCard.BasicTable.modST.DataVer);
                string strSql = string.Empty;
                foreach (XmlNode xn in nodeList)//遍历所有子节点
                {
                    XmlElement xe = (XmlElement)xn;//将子节点类型转换为XmlElement类型
                    if (Convert.ToInt32(xe.ChildNodes[0].InnerText) > ver)
                    {
                        strSql = xe.ChildNodes[1].InnerText;
                        if (strSql.Length > 0)
                        {
                            Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(strSql);
                            ReaderCard.BasicTable.modST.DataVer = xe.ChildNodes[0].InnerText;
                        }
                    }

                }
                ReaderCard.BasicTable.bllST.Update(ReaderCard.BasicTable.modST);
            }
        }
        private void 开启服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serviceHost = new ServiceHost(typeof(FileTransportService));
                serviceHost.Open();
            }
            catch { }
        }

        private void 停止服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serviceHost.Close();
            }
            catch { }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否真的退出？退出后客户端将不能正常工作！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0))
            {
                _isClose = true;
                // this.Close();
                Application.Exit();
            }
        }

        private void ServiceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ReaderCard.BasicTable.modST.IsAutoClose)
            {
                if (!_isClose)
                {
                    if (e.CloseReason.ToString() == "UserClosing")
                    {
                        e.Cancel = true;
                        this.Visible = false;
                    }
                }
            }
        }

        private void ServiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
        }


        private void 退出ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("是否真的退出？退出后客户端将不能正常工作！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, 0))
            {
                _isClose = true;
                this.Close();
                Application.Exit();
            }

        }

        private void dfgToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 备份ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  Hownet.BLL.BaseFile.sample s = new Hownet.BLL.BaseFile.sample();
          //  MessageBox.Show(s.CheckKey().ToString());
            //string ss = Hownet.BLL.GetHDID.md5One();
            //MessageBox.Show(ss);
            try
            {
                string str = Dir + @"\Backup\Task_backup_" + DateTime.Now.ToString("yyyyMMddhhmmss");
                Hownet.BLL.SysTem bllST = new Hownet.BLL.SysTem();
                bllST.Backup(str);
                MessageBox.Show("备份成功！");
            }
            catch
            {
                MessageBox.Show("备份失败，请在SQL管理器中手工备份或联系软件客服。");
            }
            //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            //watch.Reset();
            //watch.Start();
            //Hownet.BLL.PermissionsUser bllMat = new Hownet.BLL.PermissionsUser();
            //DataTable dt = bllMat.GetAllList().Tables[0];
            //watch.Stop();
            //MessageBox.Show(watch.ElapsedMilliseconds.ToString());


            //Form fr = new frColumns();
            //fr.ShowDialog();
        }


        private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new frCompanyInfo();
            fr.ShowDialog();
        }

        private void 权限设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Assembly asm = Assembly.Load("ReaderCard");//程序集名
            //object frmObj = asm.CreateInstance("ReaderCard.frPermissions");//程序集+form的类名。
            //Form frms = (Form)frmObj;
            //if (frms != null)
            //{
            //    frms.ShowDialog();
            //    //frms.Show();
            //}
            //Form fr = new frPermissions();
            //fr.ShowDialog();

            Form fr = new frCheckPass();
            fr.ShowDialog();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //    //Form fr = new frColumns();
            //    //fr.ShowDialog();
            //    //Hownet.BLL.Company bllC = new Hownet.BLL.Company();
            //    //bllC.InKJKM();
            Form fr = new frAbout();
            fr.ShowDialog();
            //Hownet.BLL.OrderingList bllOL = new Hownet.BLL.OrderingList();
            //bllOL.CaicMoney(DateTime.Now);
        }

        private void 调试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr = new Form1();
            fr.ShowDialog();
        }
        #region TCPServer服务器
        private ITxServer server = null;
        /// <summary>
        /// 当接收到来之客户端的文本信息的时候
        /// </summary>
        /// <param name="state"></param>
        /// <param name="str"></param>
        private void acceptString(IPEndPoint ipEndPoint, string str)
        {
            ListViewItem item = new ListViewItem(new string[] { DateTime.Now.ToString(), ipEndPoint.ToString(), str });
            this.listView1.Items.Insert(0, item);
        }
        /// <summary>
        /// 当接收到来之客户端的图片信息的时候
        /// </summary>
        /// <param name="ipEndPoint"></param>
        /// <param name="bytes"></param>
        private void acceptBytes(IPEndPoint ipEndPoint, byte[] bytes)
        {
            MessageBox.Show(bytes.Length.ToString());
            // this.pictureBox1.Image = objectByte.ReadImage(bytes);
        }
        /// <summary>
        /// 当有客户端连接上来的时候
        /// </summary>
        /// <param name="state"></param>
        private void connect(IPEndPoint ipEndPoint)
        {
            show(ipEndPoint, "上线");
        }
        /// <summary>
        /// 当对方已收到我方发送数据的时候
        /// </summary>
        /// <param name="state"></param>
        private void dateSuccess(IPEndPoint ipEndPoint)
        {
            textBox_msg.Text = "已向" + ipEndPoint.ToString() + "发送成功";
        }
        /// <summary>
        /// 当有客户端掉线的时候
        /// </summary>
        /// <param name="state"></param>
        /// <param name="str"></param>
        private void disconnection(IPEndPoint ipEndPoint, string str)
        {
            show(ipEndPoint, "下线");
        }
        /// <summary>
        /// 当服务器完全关闭的时候
        /// </summary>
        private void engineClose()
        {
            MessageBox.Show("服务器已关闭");
        }
        /// <summary>
        /// 当服务器非正常原因断开的时候
        /// </summary>
        /// <param name="str"></param>
        private void engineLost(string str)
        { MessageBox.Show(str); }
        private void button3_Click(object sender, EventArgs e)
        {
            // server.clientClose(server.StateAll[0]);
            MessageBox.Show(server.ClientAll[0].ToString());
        }
        /// <summary>
        /// 启动按钮Tcp服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                server = TxStart.startServer(int.Parse(textBox_port.Text));
                server.AcceptString += new TxDelegate<IPEndPoint, string>(acceptString);
                server.AcceptByte += new TxDelegate<IPEndPoint, byte[]>(acceptBytes);
                server.Connect += new TxDelegate<IPEndPoint>(connect);
                server.dateSuccess += new TxDelegate<IPEndPoint>(dateSuccess);
                server.Disconnection += new TxDelegate<IPEndPoint, string>(disconnection);
                server.EngineClose += new TxDelegate(engineClose);
                server.EngineLost += new TxDelegate<string>(engineLost);
                //server.BufferSize=12048;
                //server.FileLog = "C:\\test.txt";
                server.StartEngine();
                this.button1.Enabled = false;
                this.button2.Enabled = true;
                this.button3.Enabled = true;
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }

        }
        /// <summary>
        /// 发送按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint client = (IPEndPoint)this.comboBox1.SelectedItem;
                if (client == null)
                {
                    MessageBox.Show("没有选中任何在线客户端！");
                    return;
                }

                if (!this.server.clientCheck(client))
                {
                    MessageBox.Show("目标客户端不在线！");
                    return;
                }
                server.sendMessage(client, textBox_msg.Text);
            }
            catch (Exception Ex) { MessageBox.Show(Ex.Message); }
        }
        /// <summary>
        /// 下面显示的
        /// </summary>
        /// <param name="ipEndPoint"></param>
        /// <param name="str"></param>
        private void show(IPEndPoint ipEndPoint, string str)
        {
            label_zt.Text = ipEndPoint.ToString() + ":" + str;
            label_all.Text = "当前在线人数:" + this.server.ClientNumber.ToString();
        }
        /// <summary>
        /// 当组合框按下的时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_DropDown_1(object sender, EventArgs e)
        {
            try
            {
                List<IPEndPoint> list = this.server.ClientAll;
                this.comboBox1.DataSource = list;
            }
            catch { }
        }
        /// <summary>
        /// 关闭客户端的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            IPEndPoint client = (IPEndPoint)this.comboBox1.SelectedItem;
            if (client == null)
            {
                MessageBox.Show("没有选中任何在线客户端！");
                return;
            }

            if (!this.server.clientCheck(client))
            {
                MessageBox.Show("目标客户端不在线！");
                return;
            }
            server.clientClose(client);
        }
        #endregion
    
    }
}
