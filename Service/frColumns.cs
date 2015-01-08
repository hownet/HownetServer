using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace Service
{
    public partial class frColumns : Form
    {
        public frColumns()
        {
            InitializeComponent();
        }
        Hownet.BLL.FromCloumnsMain bllFCM = new Hownet.BLL.FromCloumnsMain();
        Hownet.BLL.FromCloumns bllFC = new Hownet.BLL.FromCloumns();
        Hownet.Model.FromCloumnsMain modFCM = new Hownet.Model.FromCloumnsMain();
        Hownet.Model.FromCloumns modFC = new Hownet.Model.FromCloumns();
        DataTable dtFCM = new DataTable();
        DataTable dtFC = new DataTable();
        private void frColumns_Load(object sender, EventArgs e)
        {
            dtFCM = bllFCM.GetList(" (1=1) order by ClassName ").Tables[0];
            dataGridView1.DataSource = dtFCM;
            DataTable dt = bllFCM.GetTableName().Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dtFCM.Select("(ClassName='" + dt.Rows[i]["Name"].ToString() + "')").Length == 0)
                {
                    modFCM = new Hownet.Model.FromCloumnsMain();
                    modFCM.ClassName = dt.Rows[i]["Name"].ToString();
                    modFCM.CFormName = string.Empty;
                    modFCM.EFormName = string.Empty;
                    modFCM.Remark = string.Empty;
                    modFCM.A = modFCM.ID = 0;
                    bllFCM.Add(modFCM);
                }
            }
            dataGridView1.Columns["A"].Visible = false;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["ClassName"].ReadOnly = true;
            dtFCM = bllFCM.GetList(" (1=1) order by ClassName ").Tables[0];


           
            dataGridView1.DataSource = dtFCM;
        }
        /// <summary>
        /// 获取解压缩后的字符串
        /// </summary>
        public string DeCompressString(byte[] arrbts)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                ms.Write(arrbts, 0, arrbts.Length);
                ms.Position = 0;
                DeflateStream ZipStream = new DeflateStream(ms, CompressionMode.Decompress);
                MemoryStream UnzipStream = new MemoryStream();
                byte[] sDecompressed = new byte[128];
                while (true)
                {
                    int bytesRead = ZipStream.Read(sDecompressed, 0, 128);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    UnzipStream.Write(sDecompressed, 0, bytesRead);
                }
                ZipStream.Close();
                ms.Close();
                UnzipStream.Position = 0;// 解压起始位置设置为头
                StreamReader sr = new StreamReader(UnzipStream);
                return sr.ReadToEnd();
            }
            catch
            {
                return "";
            }
        }
        //保存主表
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView1["A", i].Value) == 2)
                {
                    modFCM = new Hownet.Model.FromCloumnsMain();
                    modFCM.A = 1;
                    modFCM.CFormName = dataGridView1["CFormName", i].Value.ToString();
                    modFCM.EFormName = dataGridView1["EFormName", i].Value.ToString();
                    modFCM.ID = Convert.ToInt32(dataGridView1["ID", i].Value);
                    modFCM.Remark = dataGridView1["Remark", i].Value.ToString();
                    modFCM.ClassName = dataGridView1["ClassName", i].Value.ToString();
                    bllFCM.Update(modFCM);
                    dataGridView1["A", i].Value = 1;
                }
            }



            //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            //watch.Reset();
            //watch.Start();
            //FileTransportService ftc = new FileTransportService();
            //object o = ftc.GetJson("Hownet.BLL.Color", "GetAllList", null);
            //textBox5.Text = DeCompressString((byte[])o);

            //DataTable dt = new DataTable();
            //dt.TableName = "Materiel";
            //string[] ss = textBox5.Text.Split('й');
            //string[] ssColumns = ss[0].Split('ж');
            //string[] sc;
            //for (int i = 0; i < ssColumns.Length; i++)
            //{
            //    sc=ssColumns[i].Split('ю');
            //    if(sc[0]!=string.Empty)
            //    dt.Columns.Add(sc[0], System.Type.GetType(sc[1]));
            //}
            //if (ss.Length > 1)
            //{
            //    for (int i = 1; i < ss.Length; i++)
            //    {
            //        DataRow dr = dt.NewRow();
            //        sc = ss[i].Split('ж');
            //        if (sc[0] != string.Empty)
            //        {
            //            for (int j = 0; j < dt.Columns.Count; j++)
            //            {
            //                dr[j] = sc[j];
            //            }
            //            dt.Rows.Add(dr);
            //        }
            //    }
            //}
            //watch.Stop();
            //MessageBox.Show(watch.ElapsedMilliseconds.ToString() + "+" + dt.Rows.Count.ToString());
            //dataGridView2.DataSource = dt;
        }
        //插入子表记录
        private void button2_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
            //watch.Reset();
            //watch.Start();
            //FileTransportService ftc = new FileTransportService();
            //object o = ftc.getZipData("Hownet.BLL.Color", "GetAllList", null);

            //DataTable dt = Byte2DS((byte[])o).Tables[0];
            //watch.Stop();
            //MessageBox.Show(watch.ElapsedMilliseconds.ToString() + "+" + dt.Rows.Count.ToString());
            dtFC = bllFC.GetList("(MainID=" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value + " And (TypeID=0) )  order by OrderBy ").Tables[0];
            dataGridView2.DataSource = dtFC;
        }
        private static DataSet Byte2DS(byte[] da)
        {
            MemoryStream input = new MemoryStream();
            input.Write(da, 0, da.Length);
            input.Position = 0;
            GZipStream gzip = new GZipStream(input, CompressionMode.Decompress, true);
            MemoryStream output = new MemoryStream();
            byte[] buff = new byte[4096];
            int read = -1;
            read = gzip.Read(buff, 0, buff.Length);
            while (read > 0)
            {
                output.Write(buff, 0, read);
                read = gzip.Read(buff, 0, buff.Length);
            }
            gzip.Close();
            byte[] rebytes = output.ToArray();
            output.Close(); input.Close();
            MemoryStream ms = new MemoryStream(rebytes);
            BinaryFormatter bf = new BinaryFormatter();
            object obj = bf.Deserialize(ms);
            DataSet ds = (DataSet)obj;
            return ds;
        }
        //保存子表
        private void button3_Click(object sender, EventArgs e)
        {
     
            //DataTable dtTem=((DataTable)dataGridView2.DataSource);
            //DataRow[] drs =dtTem .Select("(ID=3) or (ID=4)");
            //StringBuilder ss = new StringBuilder();
            
            //for (int j = 0; j < drs.Length; j++)
            //{

            //    drs[1][1] = 0;
            //    for (int i = 0; i < dtTem.Columns.Count; i++)
            //    {
            //        //ss.Append(i);
            //        //ss.Append("ю");
            //        ss.Append(drs[j][i].ToString());
            //        ss.Append("ж");
            //    }
            //    ss.Append("й");
            //}

            //MemoryStream ms = new MemoryStream();
            //StreamWriter sw = new StreamWriter(ms);
            //sw.Write(ss.ToString());
            //sw.Close();
            //byte[] bsrc = ms.ToArray();
            //ms.Close();
            //ms.Dispose();
            //ms = new MemoryStream();
            //ms.Position = 0;
            //// 压缩数组序列并返回压缩后的数组
            //DeflateStream zipStream = new DeflateStream(ms, CompressionMode.Compress);
            //zipStream.Write(bsrc, 0, bsrc.Length);
            //zipStream.Close();
            //zipStream.Dispose();
            //byte[] bbb= ms.ToArray();

            //Hownet.BLL.Color bllC = new Hownet.BLL.Color();
            //bllC.UpOrAdd( bbb);
            //dataGridView1.DataSource = bllC.GetList("ID=3").Tables[0];

            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView2["A", i].Value) == 2)
                {
                    modFC = bllFC.GetModel(Convert.ToInt32(dataGridView2["ID", i].Value));
                    modFC.CName = dataGridView2["CName", i].Value.ToString().Trim();
                    modFC.EName = dataGridView2["EName", i].Value.ToString().Trim();
                    modFC.Width = Convert.ToInt32(dataGridView2["Width", i].Value);
                    modFC.IsShow = modFC.CName.Length > 0;
                    modFC.IsCanEdit = Convert.ToBoolean(dataGridView2["IsCanEdit", i].Value);
                    modFC.IsCanFilter = Convert.ToBoolean(dataGridView2["IsCanFilter", i].Value);
                    modFC.IsCanGroup = Convert.ToBoolean(dataGridView2["IsCanGroup", i].Value);
                    modFC.IsCanSort = Convert.ToBoolean(dataGridView2["IsCanSort", i].Value);
                    modFC.IsFix = Convert.ToBoolean(dataGridView2["IsFix", i].Value);
                    modFC.UserID = 0;
                    modFC.MainID = Convert.ToInt32(dataGridView2["MainID", i].Value);
                    modFC.IsMust = Convert.ToBoolean(dataGridView2["IsMust", i].Value);
                    modFC.Remark = dataGridView2["Remark", i].Value.ToString();
                    modFC.OrderBy = Convert.ToInt32(dataGridView2["OrderBy", i].Value);
                    bllFC.Update(modFC);
                    dataGridView2["A", i].Value = 1;
                }
            }


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName != "A" && Convert.ToInt32(dataGridView1["A", e.RowIndex].Value) == 1)
                dataGridView1["A", e.RowIndex].Value = 2;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;
            dtFC = bllFC.GetList("(MainID=" + Convert.ToInt32(dataGridView1["ID", dataGridView1.CurrentRow.Index].Value) + " And (TypeID=0) ) order by OrderBy").Tables[0];
            dataGridView2.DataSource = dtFC;

            DataTable dt = bllFCM.GetColumnsName(dataGridView1["ClassName", dataGridView1.CurrentRow.Index].Value.ToString()).Tables[0];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dtFC.Select("(Fileds='" + dt.Rows[i]["Name"].ToString() + "')").Length == 0)
                {
                    if (dt.Rows[i]["Name"].ToString() != "ID" && dt.Rows[i]["Name"].ToString() != "A")
                    {
                        modFC = new Hownet.Model.FromCloumns();
                        modFC.Fileds = dt.Rows[i]["Name"].ToString();
                        modFC.CName = string.Empty;
                        modFC.EName = string.Empty;
                        modFC.Width = 100;
                        modFC.IsShow = true;
                        modFC.IsCanEdit = true;
                        modFC.IsCanFilter = true;
                        modFC.IsCanGroup = true;
                        modFC.IsCanSort = true;
                        modFC.IsFix = false;
                        modFC.EName = string.Empty;
                        modFC.UserID = 0;
                        modFC.MainID = Convert.ToInt32(dataGridView1["ID", dataGridView1.CurrentRow.Index].Value);
                        modFC.IsMust = false;
                        modFC.Remark = string.Empty;
                        modFC.A = modFCM.ID = 0;
                        bllFC.Add(modFC);
                    }
                }
            }
            dtFC = bllFC.GetList("(MainID=" + Convert.ToInt32(dataGridView1["ID", dataGridView1.CurrentRow.Index].Value) + " And (TypeID=0)) order by OrderBy").Tables[0];
            dataGridView2.DataSource = dtFC;
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].DataPropertyName != "A" && Convert.ToInt32(dataGridView2["A", e.RowIndex].Value) == 1)
                dataGridView2["A", e.RowIndex].Value = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (Convert.ToInt32(dataGridView2["TypeID", i].Value) == 1)
                {

                    if (Convert.ToInt32(dataGridView2["ID", i].Value) == 0)
                    {
                        modFC = new Hownet.Model.FromCloumns();
                        modFC.Fileds = dataGridView2["Fileds", i].Value.ToString().Trim();
                        modFC.CName = dataGridView2["CName", i].Value.ToString().Trim();
                        modFC.EName = dataGridView2["EName", i].Value.ToString().Trim();
                        modFC.Width = Convert.ToInt32(dataGridView2["Width", i].Value);
                        modFC.IsShow = Convert.ToBoolean(dataGridView2["IsShow", i].Value);
                        modFC.IsCanEdit = Convert.ToBoolean(dataGridView2["IsCanEdit", i].Value);
                        modFC.IsCanFilter = Convert.ToBoolean(dataGridView2["IsCanFilter", i].Value);
                        modFC.IsCanGroup = Convert.ToBoolean(dataGridView2["IsCanGroup", i].Value);
                        modFC.IsCanSort = Convert.ToBoolean(dataGridView2["IsCanSort", i].Value);
                        modFC.IsFix = Convert.ToBoolean(dataGridView2["IsFix", i].Value);
                        modFC.UserID = Convert.ToInt32(dataGridView2["UserID", i].Value);
                        modFC.MainID = Convert.ToInt32(dataGridView2["MainID", i].Value);
                        modFC.IsMust = Convert.ToBoolean(dataGridView2["IsMust", i].Value);
                        modFC.Remark = dataGridView2["Remark", i].Value.ToString();
                        modFC.OrderBy = Convert.ToInt32(dataGridView2["OrderBy", i].Value);
                        modFC.TypeID = 1;
                        dataGridView2["ID", i].Value = bllFC.Add(modFC);
                    }
                    else
                    {
                        if(Convert.ToInt32(dataGridView2["A",i].Value)==2)
                        {
                            modFC = bllFC.GetModel(Convert.ToInt32(dataGridView2["ID", i].Value));
                            modFC.CName = dataGridView2["CName", i].Value.ToString().Trim();
                            modFC.EName = dataGridView2["EName", i].Value.ToString().Trim();
                            modFC.Width = Convert.ToInt32(dataGridView2["Width", i].Value);
                            modFC.IsShow = Convert.ToBoolean(dataGridView2["IsShow", i].Value);
                            modFC.IsCanEdit = Convert.ToBoolean(dataGridView2["IsCanEdit", i].Value);
                            modFC.IsCanFilter = Convert.ToBoolean(dataGridView2["IsCanFilter", i].Value);
                            modFC.IsCanGroup = Convert.ToBoolean(dataGridView2["IsCanGroup", i].Value);
                            modFC.IsCanSort = Convert.ToBoolean(dataGridView2["IsCanSort", i].Value);
                            modFC.IsFix = Convert.ToBoolean(dataGridView2["IsFix", i].Value);
                            modFC.UserID = Convert.ToInt32(dataGridView2["UserID", i].Value);
                            modFC.MainID = Convert.ToInt32(dataGridView2["MainID", i].Value);
                            modFC.IsMust = Convert.ToBoolean(dataGridView2["IsMust", i].Value);
                            modFC.Remark = dataGridView2["Remark", i].Value.ToString();
                            modFC.OrderBy = Convert.ToInt32(dataGridView2["OrderBy", i].Value);
                            bllFC.Update(modFC);
                            dataGridView2["A", i].Value = 1;
                        }
                    }
                    
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dtFC = bllFC.GetList("(MainID=" + Convert.ToInt32(dataGridView1["ID", dataGridView1.CurrentRow.Index].Value) + ") And (TypeID=1)  order by OrderBy").Tables[0];
          
             DataTable  dt= bllFC.GetList("(MainID=" + Convert.ToInt32(dataGridView1["ID", dataGridView1.CurrentRow.Index].Value) + " And (TypeID=0) and (CName<>'') ) order by OrderBy").Tables[0];
             DataRow[] drs;
                 for(int i=0;i<dt.Rows.Count;i++)
                 {
                     dt.Rows[i]["ID"] = 0;
                     dt.Rows[i]["TypeID"] = 1;
                     drs = dtFC.Select("(Fileds='" + dt.Rows[i]["Fileds"] + "')");
                     if(drs.Length>0)
                     {
                         dt.Rows[i].ItemArray = drs[0].ItemArray;
                     }
                 }
             
           
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["Fileds"].ReadOnly = true;
            dataGridView2.Columns["ID"].ReadOnly = true;
        }

    }
}
