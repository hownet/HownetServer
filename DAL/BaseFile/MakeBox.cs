using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Maticsoft.DBUtility;

namespace Hownet.DAL.BaseFile
{
  public  class MakeBox
    {
      public static void AddWorkTicket(DataTable dt)
      {
          using (System.Data.SqlClient.SqlBulkCopy sqlBC = new System.Data.SqlClient.SqlBulkCopy(DbHelperSQL.connection))
          {
              sqlBC.BatchSize = 100000;
              sqlBC.BulkCopyTimeout = 60;
              sqlBC.DestinationTableName = "dbo.WorkTicket";
              for (int i = 0; i < dt.Columns.Count; i++)
              {
                  sqlBC.ColumnMappings.Add(i, i);
              }
              sqlBC.WriteToServer(dt);
              dt = null;
              GC.Collect();
          }
      }
      public static void AddWorkTicketInfo(DataTable dt)
      {
          using (System.Data.SqlClient.SqlBulkCopy sqlBC = new System.Data.SqlClient.SqlBulkCopy(DbHelperSQL.connection))
          {
              sqlBC.BatchSize = 100000;
              sqlBC.BulkCopyTimeout = 60;
              sqlBC.DestinationTableName = "dbo.WorkTicketInfo";
              for (int i = 0; i < dt.Columns.Count; i++)
              {
                  sqlBC.ColumnMappings.Add(i, i);
              }
              sqlBC.WriteToServer(dt);
              dt = null;
              GC.Collect();
          }
      }
      public static void AddSizePartTask(DataTable dt)
      {
          try
          {
              using (System.Data.SqlClient.SqlBulkCopy sqlBC = new System.Data.SqlClient.SqlBulkCopy(DbHelperSQL.connection))
              {
                  sqlBC.BatchSize = 100000;
                  sqlBC.BulkCopyTimeout = 60;
                  sqlBC.DestinationTableName = "dbo.SizeTableTask";
                  for (int i = 0; i < dt.Columns.Count; i++)
                  {
                      sqlBC.ColumnMappings.Add(i, i);
                  }
                  sqlBC.WriteToServer(dt);
                  dt = null;
                  GC.Collect();
              }
          }
          catch (Exception Exce)
          {
          }
      }
    }
}
