using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Hownet.BLL.BaseFile
{
   public class PublicDataTable
    {
       public static DataTable PeiLiaoType
       {
           get
           {
               DataTable dt = new DataTable();
               dt.Columns.Add("TypeID", typeof(int));
               dt.Columns.Add("TypeName", typeof(string));

               return dt;
           }
       }
    }
}
