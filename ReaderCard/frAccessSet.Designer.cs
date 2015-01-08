namespace ReaderCard
{
    partial class frAccessSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this._coIsSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this._coEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._coDeparmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._coPassWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._coRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._coEmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._coID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._coAccessID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 64);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._coIsSelect,
            this._coEmployeeName,
            this._coDeparmentName,
            this._coPassWork,
            this._coRemark,
            this._coEmployeeID,
            this._coID,
            this._coAccessID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(724, 368);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _coIsSelect
            // 
            this._coIsSelect.DataPropertyName = "IsSelect";
            this._coIsSelect.HeaderText = "选择";
            this._coIsSelect.Name = "_coIsSelect";
            this._coIsSelect.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this._coIsSelect.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // _coEmployeeName
            // 
            this._coEmployeeName.DataPropertyName = "Name";
            this._coEmployeeName.HeaderText = "员工";
            this._coEmployeeName.Name = "_coEmployeeName";
            this._coEmployeeName.ReadOnly = true;
            // 
            // _coDeparmentName
            // 
            this._coDeparmentName.DataPropertyName = "DeparmentName";
            this._coDeparmentName.HeaderText = "部门";
            this._coDeparmentName.Name = "_coDeparmentName";
            this._coDeparmentName.ReadOnly = true;
            // 
            // _coPassWork
            // 
            this._coPassWork.DataPropertyName = "PassWord";
            this._coPassWork.HeaderText = "密码";
            this._coPassWork.Name = "_coPassWork";
            this._coPassWork.Visible = false;
            // 
            // _coRemark
            // 
            this._coRemark.DataPropertyName = "Remark";
            this._coRemark.HeaderText = "说明";
            this._coRemark.Name = "_coRemark";
            this._coRemark.Width = 200;
            // 
            // _coEmployeeID
            // 
            this._coEmployeeID.DataPropertyName = "EmployeeID";
            this._coEmployeeID.HeaderText = "EmployeeID";
            this._coEmployeeID.Name = "_coEmployeeID";
            this._coEmployeeID.ReadOnly = true;
            this._coEmployeeID.Visible = false;
            // 
            // _coID
            // 
            this._coID.DataPropertyName = "ID";
            this._coID.HeaderText = "ID";
            this._coID.Name = "_coID";
            this._coID.ReadOnly = true;
            this._coID.Visible = false;
            // 
            // _coAccessID
            // 
            this._coAccessID.DataPropertyName = "AccessID";
            this._coAccessID.HeaderText = "AccessID";
            this._coAccessID.Name = "_coAccessID";
            this._coAccessID.ReadOnly = true;
            this._coAccessID.Visible = false;
            // 
            // frAccessSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "frAccessSet";
            this.Text = "frAccessSet";
            this.Load += new System.EventHandler(this.frAccessSet_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn _coIsSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coDeparmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coPassWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coEmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coID;
        private System.Windows.Forms.DataGridViewTextBoxColumn _coAccessID;
    }
}