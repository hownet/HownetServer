﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReaderCard
{
    public partial class frPermissions : Form
    {
        public frPermissions()
        {
            InitializeComponent();
        }
        Hownet.BLL.Users bllU = new Hownet.BLL.Users();
        Hownet.BLL.Items bllI = new Hownet.BLL.Items();
        Hownet.BLL.PermissionsUser bllPU = new Hownet.BLL.PermissionsUser();
        DataTable dtUser = new DataTable();
        DataSet dsItems = new DataSet();
        DataTable dtPU = new DataTable();
        int _userID = 0;
        int _itesmID=0;
        int _permissionID = 0;
        string _UserName = string.Empty;
        private void frPermissions_Load(object sender, EventArgs e)
        {
            dtUser = bllU.GetAllList().Tables[0];
            dsItems = bllI.GetList("ParentID>-1");
            dsItems.Relations.Add("sdf", dsItems.Tables[0].Columns["ID"], dsItems.Tables[0].Columns["ParentID"], false);
            dtPU = bllPU.GetAllList().Tables[0];
            this.treeView1.CheckBoxes = true;
            InitTree(treeView1, dsItems);
            listBox1.DataSource = dtUser;
            try
            {
                _userID = int.Parse(listBox1.SelectedValue.ToString());
                _UserName = listBox1.Text;
            }
            catch { _userID = 0; }
            //if (_userID > 0)
            //{
            //    ShowUserPermissin(_userID);
            //}

            treeView1.AfterCheck+=new TreeViewEventHandler(treeView1_AfterCheck);
        }

        public bool InitTree(TreeView treeview, DataSet ds)
        {
            treeview.Nodes.Clear();
            treeView1.HideSelection = false;
            foreach (DataRow dbRow in ds.Tables[0].Rows)
            {
                if (dbRow["ParentID"].ToString()=="0")
                {
                    TreeNode newNode = CreateNode(dbRow["Text"].ToString(), dbRow["ID"].ToString());
                    treeview.Nodes.Add(newNode);
                    SubTree(dbRow, newNode);
                }
            }
          
            treeview.ExpandAll();
            treeView1.SelectedNode = treeView1.Nodes[0];
            return true;
        }


        private void SubTree(DataRow dbRow, TreeNode node)
        {
            foreach (DataRow childRow in dbRow.GetChildRows("sdf"))
            {
                TreeNode childNode = CreateNode(childRow["Text"].ToString(), childRow["ID"].ToString());
                node.Nodes.Add(childNode);
                SubTree(childRow, childNode);

            }
        }

        private TreeNode CreateNode(string text, string tag)
        {
            TreeNode node = new TreeNode();
            node.Text = text;
            node.Tag = tag;
            return node;
        }
        //如果选中修改，则查看自动选中
        private void checkedListBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox2.SelectedIndex > -1)
            {
                _permissionID = 0;
                if (checkedListBox2.GetItemChecked(checkedListBox2.SelectedIndex))
                {
                    checkedListBox2.SetItemChecked(0, true);
                    _permissionID = checkedListBox2.SelectedIndex + 1;
                }
                else
                {
                    if (checkedListBox2.GetItemChecked(0))
                        _permissionID = 1;
                }
                DataRow[] drs = dtPU.Select("(UserID=" + _userID + ") And (IsSelect=1) And (ItemsID=" + _itesmID + ")");
                for (int i = 0; i < drs.Length; i++)
                {
                    drs[i]["PermissionsPropertyID"] = _permissionID;
                }
            }
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _userID = int.Parse(listBox1.SelectedValue.ToString());
                _UserName = listBox1.Text;
            }
            catch { _userID = 0; }
            if (_userID > 0)
                ShowUserPermissin(_userID);
        }
        private void ShowUserPermissin(int UserID)
        {
            treeView1.AfterCheck -= new TreeViewEventHandler(treeView1_AfterCheck);
            InitTree(treeView1, dsItems);
            dtPU.DefaultView.RowFilter = ("(UserID=" + _userID + ")");
            TreeNodeCollection nodes = treeView1.Nodes;
            for (int i = 0; i < dtPU.DefaultView.Count; i++)
            {
                foreach (TreeNode TNode in nodes)
                {
                    object o = dtPU.DefaultView[i]["ID"];
                    CheckIsCheck(TNode, dtPU.DefaultView[i]["ItemsID"].ToString());
                }
            }
            treeView1.AfterCheck += new TreeViewEventHandler(treeView1_AfterCheck);
        }
        private void CheckIsCheck(TreeNode treeNode,string IName)
        {
            object o = treeNode.Tag;
            if (IName == treeNode.Tag.ToString())
            {
                treeNode.Checked = true;
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                CheckIsCheck(tn, IName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int _id = 0;
            int _IsSelect = 0;
            DataTable dtt=dtPU.Clone();
            dtPU.AcceptChanges();
            for (int i = 0; i < dtPU.Rows.Count; i++)
            {
                _id = int.Parse(dtPU.Rows[i]["ID"].ToString());
                _IsSelect = int.Parse(dtPU.Rows[i]["IsSelect"].ToString());
                dtt.Rows.Clear();
                dtt.Rows.Add(dtPU.Rows[i].ItemArray);
                if (_IsSelect == 1)
                {
                    if (_id == 0)
                        dtPU.Rows[i]["ID"] = bllPU.AddByDt(dtt);
                    else
                        bllPU.UpdateByDt(dtt);
                }
                else if (_IsSelect == -1)
                {
                    if (_id > 0)
                        bllPU.Delete(_id);
                }
            }
            BasicTable.dsPU = bllPU.GetAllList();
        }

       private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _itesmID = int.Parse(e.Node.Tag.ToString());
            if (e.Node.Level == 2)
            {
                AfterCheck(e.Node.Checked, e.Node);
            }
            checkedListBox2.Enabled = (e.Node.Level == 2);
            //DataRow[] drs = dtPU.Select("(UserID=" + _userID + ") And (ItemsID=" + _itesmID + ")");
            //if (checkedListBox1.GetItemChecked(checkedListBox1.SelectedIndex))//如果选中，设置为1，未选中设置为-1，保存时删除掉为-1的记录
        }
        private void AfterCheck(bool t,TreeNode Tn)
        {
            checkedListBox2.SetItemChecked(0, false);
            checkedListBox2.SetItemChecked(1, false);
            groupBox3.Text = "用户" + _UserName + "在--" + Tn.Text + "--中的权限";
            DataRow[] drs = dtPU.Select("(UserID=" + _userID + ") And (ItemsID=" + _itesmID + ")");
            if (t)
            {
                if (drs.Length > 0)
                {
                    drs[0]["IsSelect"] = 1;
                    _permissionID = int.Parse(drs[0]["PermissionsPropertyID"].ToString());
                    if (_permissionID == 1)
                        checkedListBox2.SetItemChecked(0, true);
                    else if (_permissionID == 2)
                    {
                        checkedListBox2.SetItemChecked(0, true);
                        checkedListBox2.SetItemChecked(1, true);
                    }
                }
                else
                {
                    DataRow dr = dtPU.NewRow();
                    dr["A"] = dr["ID"] = 0;
                    dr["ItemsID"] = _itesmID;
                    dr["UserID"] = _userID;
                    dr["IsSelect"] = 1;
                    dr["PermissionsPropertyID"] = _permissionID;
                    dr["ItemsName"] = Tn.Text;
                    dtPU.Rows.Add(dr);
                }
                drs = dtPU.Select("(UserID=" + _userID + ") And (ItemsID=" + int.Parse(Tn.Parent.Tag.ToString()) + ")");
                if (drs.Length == 0)
                {
                    DataRow dr = dtPU.NewRow();
                    dr["A"] = dr["ID"] = 0;
                    dr["ItemsID"] = int.Parse(Tn.Parent.Tag.ToString());
                    dr["UserID"] = _userID;
                    dr["IsSelect"] = 1;
                    dr["PermissionsPropertyID"] = 0;
                    dr["ItemsName"] = Tn.Text;
                    dtPU.Rows.Add(dr);
                }
                drs = dtPU.Select("(UserID=" + _userID + ") And (ItemsID=" + int.Parse(Tn.Parent.Parent.Tag.ToString()) + ")");
                if (drs.Length == 0)
                {
                    DataRow dr = dtPU.NewRow();
                    dr["A"] = dr["ID"] = 0;
                    dr["ItemsID"] = int.Parse(Tn.Parent.Parent.Tag.ToString());
                    dr["UserID"] = _userID;
                    dr["IsSelect"] = 1;
                    dr["PermissionsPropertyID"] = 0;
                    dr["ItemsName"] = Tn.Text;
                    dtPU.Rows.Add(dr);
                }
            }
            else
            {
                if (drs.Length > 0)
                {
                    drs[0]["PermissionsPropertyID"] = 0;
                    drs[0]["IsSelect"] = -1;
                }
            }
        }
        private void treeView1_AfterCheck(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            //MessageBox.Show(e.Node.Tag.ToString());
            bool bNodeStatus = false;
            bNodeStatus = e.Node.Checked;
            
            if (e.Node.Level == 2)
            {_itesmID = int.Parse(e.Node.Tag.ToString());
                AfterCheck(bNodeStatus, e.Node);
                if (bNodeStatus)
                {
                    e.Node.Parent.Checked = true;
                    e.Node.Parent.Parent.Checked = true;
                }
                checkedListBox2.Enabled = true;
            }
            else
            {
                checkedListBox2.Enabled = false;
            }
        }

    }
}
