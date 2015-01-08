using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hownet.BLL.BaseFile
{
    public class ZipDt
    {
        public static DataSet Byte2Ds(byte[] bb)
        {
            MemoryStream input = new MemoryStream();
            input.Write(bb, 0, bb.Length);
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
        /// 获取解压缩后的字符串
        public static string DeCompressString(byte[] arrbts)
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
    }
}
