using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;

namespace Hownet.DAL.BaseFile
{
   public class BaseFileClass
    {
        /// <summary>
        /// 检查Sn是否重复，注意：表的ID字段名为表名+ID
        /// </summary>
        /// <param name="Sn">新添或修改后的Sn</param>
        /// <param name="ID"></param>
        /// <param name="t">是否为插入操作</param>
        /// <param name="TableName">表名</param>
        /// <returns></returns>
        public static bool CheckSn(string Sn, int ID, bool t, string TableName)
        {
            string tableID = TableName + "ID";
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(*) as Exp1  FROM '" + TableName + "' where (Sn=@SN)  ");
            if (!t)
            {
                strSql.Append("And ('" + tableID + "'<>@ID)");
            }
            SqlParameter[] parameters =    { new SqlParameter("@ID", ID), new SqlParameter("@sn", Sn) };
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
            if (obj.ToString() == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
