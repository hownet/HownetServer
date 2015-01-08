namespace Service
{
    partial class FormServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.btnGroupSendMsg = new System.Windows.Forms.Button();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btnSendFile = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnGroupSplash = new System.Windows.Forms.Button();
            this.btnSplash = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.txbPort = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.Label();
            this.txbIp = new System.Windows.Forms.TextBox();
            this.labIp = new System.Windows.Forms.Label();
            this.listOnline = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(496, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 29;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGroupSendMsg
            // 
            this.btnGroupSendMsg.Location = new System.Drawing.Point(578, 477);
            this.btnGroupSendMsg.Name = "btnGroupSendMsg";
            this.btnGroupSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnGroupSendMsg.TabIndex = 28;
            this.btnGroupSendMsg.Text = "群发消息";
            this.btnGroupSendMsg.UseVisualStyleBackColor = true;
            this.btnGroupSendMsg.Click += new System.EventHandler(this.btnGroupSendMsg_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(477, 477);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 27;
            this.btnSendMsg.Text = "发送消息";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.Location = new System.Drawing.Point(371, 477);
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 26;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = true;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(265, 477);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFile.TabIndex = 25;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(42, 477);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.Size = new System.Drawing.Size(202, 21);
            this.txtFilePath.TabIndex = 24;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(42, 249);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(529, 210);
            this.txtInput.TabIndex = 23;
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(42, 48);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(529, 184);
            this.txtShow.TabIndex = 22;
            // 
            // btnGroupSplash
            // 
            this.btnGroupSplash.Location = new System.Drawing.Point(496, 8);
            this.btnGroupSplash.Name = "btnGroupSplash";
            this.btnGroupSplash.Size = new System.Drawing.Size(75, 23);
            this.btnGroupSplash.TabIndex = 21;
            this.btnGroupSplash.Text = "群闪屏";
            this.btnGroupSplash.UseVisualStyleBackColor = true;
            this.btnGroupSplash.Click += new System.EventHandler(this.btnGroupSplash_Click);
            // 
            // btnSplash
            // 
            this.btnSplash.Location = new System.Drawing.Point(403, 8);
            this.btnSplash.Name = "btnSplash";
            this.btnSplash.Size = new System.Drawing.Size(75, 23);
            this.btnSplash.TabIndex = 20;
            this.btnSplash.Text = "闪屏";
            this.btnSplash.UseVisualStyleBackColor = true;
            this.btnSplash.Click += new System.EventHandler(this.btnSplash_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(312, 9);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnMonitor.TabIndex = 19;
            this.btnMonitor.Text = "开始监听";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // txbPort
            // 
            this.txbPort.Location = new System.Drawing.Point(216, 10);
            this.txbPort.Name = "txbPort";
            this.txbPort.Size = new System.Drawing.Size(66, 21);
            this.txbPort.TabIndex = 18;
            this.txbPort.Text = "10001";
            // 
            // txtPort
            // 
            this.txtPort.AutoSize = true;
            this.txtPort.Location = new System.Drawing.Point(175, 13);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(35, 12);
            this.txtPort.TabIndex = 17;
            this.txtPort.Text = "Port:";
            // 
            // txbIp
            // 
            this.txbIp.Location = new System.Drawing.Point(42, 10);
            this.txbIp.Name = "txbIp";
            this.txbIp.Size = new System.Drawing.Size(112, 21);
            this.txbIp.TabIndex = 16;
            this.txbIp.Text = "127.0.0.1";
            // 
            // labIp
            // 
            this.labIp.AutoSize = true;
            this.labIp.Location = new System.Drawing.Point(13, 13);
            this.labIp.Name = "labIp";
            this.labIp.Size = new System.Drawing.Size(23, 12);
            this.labIp.TabIndex = 15;
            this.labIp.Text = "Ip:";
            // 
            // listOnline
            // 
            this.listOnline.FormattingEnabled = true;
            this.listOnline.ItemHeight = 12;
            this.listOnline.Location = new System.Drawing.Point(578, 48);
            this.listOnline.Name = "listOnline";
            this.listOnline.Size = new System.Drawing.Size(198, 412);
            this.listOnline.TabIndex = 30;
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 540);
            this.Controls.Add(this.listOnline);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGroupSendMsg);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnGroupSplash);
            this.Controls.Add(this.btnSplash);
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.txbPort);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txbIp);
            this.Controls.Add(this.labIp);
            this.Name = "FormServer";
            this.Text = "聊天室服务器端";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnGroupSendMsg;
        internal System.Windows.Forms.Button btnSendMsg;
        internal System.Windows.Forms.Button btnSendFile;
        internal System.Windows.Forms.Button btnSelectFile;
        internal System.Windows.Forms.TextBox txtFilePath;
        internal System.Windows.Forms.TextBox txtInput;
        internal System.Windows.Forms.TextBox txtShow;
        internal System.Windows.Forms.Button btnGroupSplash;
        internal System.Windows.Forms.Button btnSplash;
        internal System.Windows.Forms.Button btnMonitor;
        internal System.Windows.Forms.TextBox txbPort;
        internal System.Windows.Forms.Label txtPort;
        internal System.Windows.Forms.TextBox txbIp;
        internal System.Windows.Forms.Label labIp;
        private System.Windows.Forms.ListBox listOnline;
    }
}

