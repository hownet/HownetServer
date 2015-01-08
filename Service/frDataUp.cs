using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Service
{
    public partial class frDataUp : Form
    {
        public frDataUp()
        {
            InitializeComponent();
        }
        Hownet.BLL.Users bllU = new Hownet.BLL.Users();
        DataTable dtT = new DataTable();
        DataTable dtC = new DataTable();
        DataTable dtTT = new DataTable();
        DataTable dtTC = new DataTable();
        private void frDataUp_Load(object sender, EventArgs e)
        {
           // button4.Enabled = false;
        }



        public DataSet GetTableColumnsList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select 1 as A,[ID],[TableName],[Orders],[ColumnsName],[IsTitle],[IsPK],[DataType],[UseByte],[ByteLenth],[IsNull],[DefaultValue],[ColumnsRemark],[DD]  ");
            strSql.Append(" FROM TableColumns ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" Order by [TableName]");
            return DbHelperSQLite.Query(strSql.ToString());
        }

        public DataSet GetTableList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [TableName] from tablecolumns group by [TableName] order by [TableName] ");
            return DbHelperSQLite.Query(strSql.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dtC=bllU.GetTableColumns("").Tables[0];
            dataGridView2.DataSource = dtC;

            dtTC = GetTableColumnsList("").Tables[0];


            DbProviderFactory factory = SQLiteFactory.Instance;
            using (DbConnection conn = factory.CreateConnection())
            {
                conn.ConnectionString = DbHelperSQLite.connectionString;
                conn.Open();

                DbTransaction trans = conn.BeginTransaction(); // <-------------------
               // string strsql = string.Empty;
                try
                {
                    DbCommand cmd = conn.CreateCommand();
                    cmd.Connection = conn;
                    // 连续插入1000条记录
                    for (int i = 0; i < dtC.Rows.Count; i++)
                    {
                        if (dtTC.Select("(TableName='" + dtC.Rows[i]["表名"].ToString() + "') And (ColumnsName='" + dtC.Rows[i]["字段名"].ToString() + "')").Length == 0)
                        {
                           // strsql = "insert into TableColumns([TableName],[Orders],[ColumnsName],[IsTitle],[IsPK],[DataType],[UseByte],[ByteLenth],[IsNull],[DefaultValue],[ColumnsRemark],[DD]) values ('" + dtC.Rows[i]["表名"].ToString() + "'," + dtC.Rows[i]["字段序号"].ToString() + ",'" + dtC.Rows[i]["字段名"].ToString() + "'," + dtC.Rows[i]["标识"].ToString() + "," + dtC.Rows[i]["主键"].ToString() + ",'" + dtC.Rows[i]["类型"].ToString() + "'," + dtC.Rows[i]["占用字节数"].ToString() + "," + dtC.Rows[i]["长度"].ToString() + "," + dtC.Rows[i]["允许空"].ToString() + ",'" + dtC.Rows[i]["默认值"].ToString() + "','" + dtC.Rows[i]["字段说明"].ToString() + "'," + dtC.Rows[i]["小数位数"].ToString() + ")";

                            cmd.CommandText =  "insert into TableColumns([TableName],[Orders],[ColumnsName],[IsTitle],[IsPK],[DataType],[UseByte],[ByteLenth],[IsNull],[DefaultValue],[ColumnsRemark],[DD]) values ('" + dtC.Rows[i]["表名"].ToString() + "'," + dtC.Rows[i]["字段序号"].ToString() + ",'" + dtC.Rows[i]["字段名"].ToString() + "'," + dtC.Rows[i]["标识"].ToString() + "," + dtC.Rows[i]["主键"].ToString() + ",'" + dtC.Rows[i]["类型"].ToString() + "'," + dtC.Rows[i]["占用字节数"].ToString() + "," + dtC.Rows[i]["长度"].ToString() + "," + dtC.Rows[i]["允许空"].ToString() + ",'" + dtC.Rows[i]["默认值"].ToString() + "','" + dtC.Rows[i]["字段说明"].ToString() + "'," + dtC.Rows[i]["小数位数"].ToString() + ")";
                            cmd.ExecuteNonQuery();
                        }
                    }

                    trans.Commit(); // <-------------------
                }
                catch (Exception ex)
                {
                    trans.Rollback(); // <-------------------
                   // throw; // <-------------------
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtTC = GetTableColumnsList("").Tables[0];
            dtC = bllU.GetTableColumns("").Tables[0];
            for (int i = 0; i < dtTC.Rows.Count; i++)
            {
                if (dtC.Select("(表名='" + dtTC.Rows[i]["TableName"].ToString() + "') And (字段名='" + dtTC.Rows[i]["ColumnsName"].ToString() + "')").Length == 0)
                {
                    dtTC.Rows[i]["A"] = 2;
                }
            }
            dtTC.DefaultView.RowFilter = "A=2";
            dataGridView2.DataSource = dtTC.DefaultView;
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
            {
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dtT = bllU.GetTableName().Tables[0];
            DataTable dtTem = new DataTable();//需添加字段或增的表
            dtTem.Columns.Add("TableName", typeof(string));
            for(int i=0;i<dataGridView2.RowCount;i++)
            {
                if (dtTem.Select("(TableName='" + dataGridView2["TableName", i].Value.ToString() + "')").Length == 0)
                {
                    dtTem.Rows.Add(dataGridView2["TableName", i].Value.ToString());
                    dtTem.AcceptChanges();
                }
            }
           // MessageBox.Show(dtTem.Rows.Count.ToString());
            StringBuilder strSql = new StringBuilder();
            DataRow[] drs;
            string def=string.Empty;
            string pk = string.Empty;
            for (int i = 0; i < dtTem.Rows.Count; i++)
            {
                try
                {
                    strSql.Remove(0, strSql.Length);
                    if (dtT.Select("(Name='" + dtTem.Rows[i][0].ToString() + "')").Length == 0)//需新增的表
                    {

                        strSql.Append(" CREATE TABLE [");
                        strSql.Append(dtTem.Rows[i][0].ToString());
                        strSql.Append("] ( ");
                        drs = dtTC.Select("(A=2) And (TableName='" + dtTem.Rows[i][0].ToString() + "')");
                        pk = string.Empty;
                        for (int r = 0; r < drs.Length; r++)
                        {
                            strSql.Append(" ");
                            strSql.Append(drs[r]["ColumnsName"].ToString());
                            strSql.Append(" ");
                            strSql.Append(drs[r]["DataType"].ToString().Trim());
                            #region 不同类型的字段，添加长度
                            switch (drs[r]["DataType"].ToString().Trim().ToLower())
                            {
                                case "int":
                                    {
                                        if (Convert.ToInt32(drs[r]["IsTitle"]) == 1)
                                        {
                                            strSql.Append(" IDENTITY (1, 1 )");
                                        }
                                        break;
                                    }
                                //case "bigint":
                                //    {

                                //        break;
                                //    }
                                case "binary":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                //case "bit":
                                //    {

                                //        break;
                                //    }
                                //case "datetime":
                                //    {

                                //        break;
                                //    }
                                case "decimal":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(",");
                                        strSql.Append(drs[r]["DD"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                //case "image":
                                //    {

                                //        break;
                                //    }
                                //case "money":
                                //    {

                                //        break;
                                //    }
                                case "nchar":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                case "nvarchar":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                //case "real":
                                //    {

                                //        break;
                                //    }
                                //case "text":
                                //    {

                                //        break;
                                //    }
                                //case "tinyint":
                                //    {

                                //        break;
                                //    }
                                case "varchar":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                default:
                                    break;
                            }
                            #endregion
                            if (Convert.ToInt32(drs[r]["IsNull"]) == 1)
                            {
                                strSql.Append("  NULL, ");
                            }
                            else
                            {
                                strSql.Append(" NOT NULL ");
                                if (drs[r]["DefaultValue"].ToString().Trim().Length > 0)
                                {
                                    strSql.Append(" DEFAULT ");

                                    def = drs[r]["DefaultValue"].ToString().Trim();
                                    if (def.IndexOf('0') == -1)
                                    {
                                        strSql.Append("('')");
                                    }
                                    else
                                    {
                                        strSql.Append("(0)");
                                    }
                                }
                                strSql.Append(",");
                            }
                            if (Convert.ToInt32(drs[r]["IsPK"]) == 1)
                            {
                                pk += (drs[r]["ColumnsName"].ToString() + ",");
                            }
                        }
                        strSql.Remove(strSql.Length - 1, 1);
                        strSql.Append(") ");
                        if (pk.Length > 0)
                        {
                            pk = pk.Remove(pk.Length - 1, 1);
                            strSql.Append(" ALTER TABLE ");
                            strSql.Append(dtTem.Rows[i][0].ToString());
                            strSql.Append(" WITH NOCHECK ADD  CONSTRAINT [PK_");
                            strSql.Append(dtTem.Rows[i][0].ToString());
                            strSql.Append("] PRIMARY KEY  NONCLUSTERED (");
                            strSql.Append(pk);
                            strSql.Append(")");
                        }
                    }
                    else//增加字段
                    {
                        strSql.Append(" ALTER TABLE dbo.");
                        strSql.Append(dtTem.Rows[i][0].ToString());
                        strSql.Append(" ADD ");
                        drs = dtTC.Select("(A=2) And (TableName='" + dtTem.Rows[i][0].ToString() + "')");
                        for (int r = 0; r < drs.Length; r++)
                        {
                            strSql.Append(" ");
                            strSql.Append(drs[r]["ColumnsName"].ToString());
                            strSql.Append(" ");
                            strSql.Append(drs[r]["DataType"].ToString().Trim());
                            #region 不同类型的字段，添加长度
                            switch (drs[r]["DataType"].ToString().Trim().ToLower())
                            {
                                case "int":
                                    {
                                        if (Convert.ToInt32(drs[r]["IsTitle"]) == 1)
                                        {
                                            strSql.Append(" IDENTITY (1, 1 )");
                                        }
                                        break;
                                    }
                                case "binary":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                case "decimal":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(",");
                                        strSql.Append(drs[r]["DD"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                case "nchar":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                case "nvarchar":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                case "varchar":
                                    {
                                        strSql.Append(" (");
                                        strSql.Append(drs[r]["ByteLenth"].ToString());
                                        strSql.Append(") ");
                                        break;
                                    }
                                default:
                                    break;
                            }
                            #endregion

                            if (Convert.ToInt32(drs[r]["IsNull"]) == 1)
                            {
                                strSql.Append("  NULL, ");
                            }
                            else
                            {
                                strSql.Append(" NOT NULL ");
                                if (drs[r]["DefaultValue"].ToString().Trim().Length > 0)
                                {
                                    strSql.Append(" DEFAULT ");

                                    def = drs[r]["DefaultValue"].ToString().Trim();
                                    if (def.IndexOf('0') == -1)
                                    {
                                        strSql.Append("('')");
                                    }
                                    else
                                    {
                                        strSql.Append("(0)");
                                    }
                                }
                                strSql.Append(",");
                            }
                        }
                        strSql.Remove(strSql.Length - 1, 1);
                    }
                    Maticsoft.DBUtility.DbHelperSQL.ExecuteSql(strSql.ToString());
                }
                catch (Exception ex)
                {
                    textBox1.Text += (ex.ToString() + "\r\n");
                }
            }
           // MessageBox.Show(c.ToString());
            dtTC.Rows.Clear();
            dataGridView2.DataSource = dtTC.DefaultView;
        }
    }
}
