using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace WebApplication1
{
  public  class BaseClass
    {
      public static DataSet dsSysTem
      {
          set;
          get;
      }
      public static DataSet Byte2DS(byte[] da)
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
      public static string TicketInfoID
      {
          set;
          get;
      }
      public static bool IsCanMove
      {
          set;
          get;
      }
      public static string dtNow
      {
          set;
          get;
      }
      public static int UserID
      {
          set;
          get;
      }
      public static string UserName
      {
          set;
          get;
      }
      /// <summary>
      /// 获取解压缩后的字符串
      /// </summary>
      public static DataTable ToDataTable(byte[] arrbts)
      {
          DataTable dt = new DataTable();
          dt.TableName = "dt";
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
              string strDS = sr.ReadToEnd();


              string[] ss = strDS.Split('й');
              string[] ssColumns = ss[0].Split('ж');
              string[] sc;
              for (int i = 0; i < ssColumns.Length; i++)
              {
                  sc = ssColumns[i].Split('ю');
                  if (sc[0] != string.Empty)
                      dt.Columns.Add(sc[0], System.Type.GetType(sc[1]));
              }
              if (ss.Length > 1)
              {
                  for (int i = 1; i < ss.Length; i++)
                  {
                      DataRow dr = dt.NewRow();
                      sc = ss[i].Split('ж');
                      if (sc[0] != string.Empty)
                      {
                          for (int j = 0; j < dt.Columns.Count; j++)
                          {
                              try
                              {
                                  dr[j] = sc[j];
                              }
                              catch (Exception ex)
                              {
                                  dr[j] = DBNull.Value;
                              }
                          }
                          dt.Rows.Add(dr);
                      }
                  }
              }

          }
          catch (Exception ex)
          {

          }
          return dt;
      }
    }
}
