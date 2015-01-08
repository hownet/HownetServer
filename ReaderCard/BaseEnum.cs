using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ReaderCard
{
    public class BaseEnum
    {
        public enum Formula
        {
            押金 = 1,
            补贴 = 2
        }
        public static DataTable dtOperator()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            return dt;
        }
    }
}
