using System;
using System.Configuration;
namespace Maticsoft.DBUtility
{
    
    public class PubConstant
    {        
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = "";
                try
                {
                    _connectionString = ConfigurationManager.ConnectionStrings["ERP"].ConnectionString;
                }
                catch
                {
                    _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                }
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ERP"];
                ////if (ConStringEncrypt == "true")
                ////{
                ////    _connectionString = DESEncrypt.Decrypt(_connectionString);
                ////}
                //string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                //string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                //if (ConStringEncrypt == "true")
                //{
                //    _connectionString = DESEncrypt.Decrypt(_connectionString);
                //}
              //  ConStringEncrypt = DESEncrypt.Encrypt(_connectionString);
                return _connectionString; 
            }
        }
        public static string ReportConn
        {
            get
            {
                string _conn = ConfigurationManager.ConnectionStrings["FastReport"].ConnectionString;
                return _conn;
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
            if (ConStringEncrypt == "true")
            {
                connectionString = DESEncrypt.Decrypt(connectionString);
            }
            return connectionString;
        }


    }
}
