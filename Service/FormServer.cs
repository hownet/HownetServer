using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Service
{
    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;  //检查非法跨线程调用，关闭
        }

        //服务端 监听套接字
        Socket sokWatch = null;
        //服务端 监听线程
        Thread thrWatch = null;
        //字典集合：保存 通信套接字
        Dictionary<string, MsgConnection> dictConn = new Dictionary<string, MsgConnection>();

        #region 1.0 开始监听
        /// <summary>
        /// 开始监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMonitor_Click(object sender, EventArgs e)
        {
            try
            {
                //1.0创建监听套接字，使用ip4协议，流式传输，tcp链接
                sokWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //2.0绑定端口
                //2.1获取网络节点对象
                IPAddress address = IPAddress.Parse(txbIp.Text);
                IPEndPoint endPoint = new IPEndPoint(address, int.Parse(txbPort.Text));
                //2.2 绑定端口（其实内部 就向系统的端口表中注册了一个端口，并指定了当前程序句柄）
                sokWatch.Bind(endPoint);
                //2.3 设置监听队列,指限制同时处理的连接请求数，即同时处理的客户端连接请求。
                sokWatch.Listen(10);

                ////2.4开始监听：此方法会阻断当前线程，直到有其他程序连接过来，才执行完毕;    需重新开启线程
                //sokWatch.Accept();

                //2.4开始监听，调用监听线程 执行 监听套接字的监听方法。
                thrWatch = new Thread(WatchConncting);
                thrWatch.IsBackground = true;
                thrWatch.Start();
                ShowMsg("服务器启动！");
            }
            catch (SocketException soex)
            {
                ShowMsg("异常：" + soex);
            }
            catch (Exception ex)
            {
                ShowMsg("异常：" + ex);
            }
        }
        #endregion

        //开始监听，线程调用
        bool isWatch = true;
        #region 2.0 服务器监听方法 + void WatchConncting()
        void WatchConncting()
        {
            try
            {
                //循环监听客户端的连接请求。
                while (isWatch)
                {
                    //2.4开始监听，返回了一个通信套接字
                    Socket sockMsg = sokWatch.Accept();
                    //2.5 创建通信管理类
                    MsgConnection conn = new MsgConnection(sockMsg, ShowMsg, RemoveClient);

                    //将当前连接成功的【与客户端通信的套接字】的标识保存起来，并显示到列表中
                    //将远程客户端的 ip 和 端口 字符串 存入列表
                    listOnline.Items.Add(sockMsg.RemoteEndPoint.ToString());
                    //将服务器端的通信套接字存入字典集合。
                    dictConn.Add(sockMsg.RemoteEndPoint.ToString(), conn);
                    ShowMsg("有客户端连接了！");
                }
            }
            catch (Exception ex)
            {
                ShowMsg("异常" + ex);
            }
        }
        #endregion

        #region 3.0  服务端向指定的客户端发送消息
        /// <summary>
        /// 服务端向指定的客户端发送消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            string strClient = listOnline.Text;
            if (dictConn.ContainsKey(strClient))
            {
                string strMsg = txtInput.Text.Trim();
                ShowMsg("向客户端【" + strClient + "】说：" + strMsg);
                //通过指定的套接字将字符串发送到指定的客户端
                try
                {
                    dictConn[strClient].Send(strMsg);
                }
                catch (Exception ex)
                {
                    ShowMsg("异常" + ex.Message);
                }
            }
        }
        #endregion

        #region 4.0 根据要中断的客户端ipport关闭连接 + void RemoveClient(string clientIpPort)
        /// <summary>
        /// 4.0 根据要中断的客户端ipport关闭连接
        /// </summary>
        /// <param name="clientIpPort"></param>
        public void RemoveClient(string clientIpPort)
        {
            //1.0 移除列表中的项
            listOnline.Items.Remove(clientIpPort);
            //2.0 关闭通信管理类
            dictConn[clientIpPort].Close();
            //3.0 从字典中移除对应的通信管理类的项
            dictConn.Remove(clientIpPort);
        }
        #endregion

        #region 5.0 选择要发送的文件
        /// <summary>
        /// 选择要发送的文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //将选中的要发送的文件路径，显示到文本框中。
                txtFilePath.Text = ofd.FileName;
            }
        }
        #endregion

        #region 6.0 发送文件
        /// <summary>
        /// 6.0 发送文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendFile_Click(object sender, EventArgs e)
        {
            string strClient = listOnline.Text;
            if (dictConn.ContainsKey(strClient))
            {
                string strMsg = txtInput.Text.Trim();
                //通过指定的套接字将字符串发送到指定的客户端
                try
                {
                    dictConn[strClient].SendFile(txtFilePath.Text.Trim());
                }
                catch (Exception ex)
                {
                    ShowMsg("异常" + ex.Message);
                }
            }
        }
        #endregion

        #region  打印消息 + ShowMsg(string strmsg)
        /// <summary>
        /// 打印消息
        /// </summary>
        /// <param name="strmsg"></param>
        void ShowMsg(string strmsg)
        {
            this.txtShow.AppendText(strmsg + "\r\n");
        }
        #endregion

        /// <summary>
        /// 向指定的客户端发送抖屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSplash_Click(object sender, EventArgs e)
        {
            string strClient = listOnline.Text;
            if (dictConn.ContainsKey(strClient))
            {
                string strMsg = txtInput.Text.Trim();
                //通过指定的套接字将字符串发送到指定的客户端
                try
                {
                    dictConn[strClient].SendShake();
                }
                catch (Exception ex)
                {
                    ShowMsg("异常" + ex.Message);
                }
            }
        }

        private void btnGroupSplash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("待完善~~");
        }

        private void btnGroupSendMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("待完善~~");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
