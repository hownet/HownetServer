using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Maticsoft.DBUtility;
using System.Data.SqlClient;

namespace Hownet.DAL
{
  public  class RunProcedure
    {
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
      public DataSet GetDSForPrcoce(string storedProcName, object[] obj, string tableName)
      {
        //  string[] ss=(string[])obj;
          SqlParameter[] parameters = {
					new SqlParameter("@Tables", SqlDbType.VarChar, 255),
				    new SqlParameter("@PrimaryKey" , SqlDbType.VarChar , 255),	
                    new SqlParameter("@Sort", SqlDbType.VarChar , 255 ),
                    new SqlParameter("@CurrentPage", SqlDbType.Int),
					new SqlParameter("@PageSize", SqlDbType.Int),									
                    new SqlParameter("@Fields", SqlDbType.VarChar, 255),
					new SqlParameter("@Filter", SqlDbType.VarChar,1000),
                    new SqlParameter("@Group" ,SqlDbType.VarChar , 1000 )
					};
          parameters[0].Value = obj[0];
          parameters[1].Value = obj[1];
          parameters[2].Value = obj[2];
          parameters[3].Value = Convert.ToInt32(obj[3]);
          parameters[4].Value = Convert.ToInt32(obj[4]);
          parameters[5].Value = obj[5];
          parameters[6].Value = obj[6];
          parameters[7].Value = obj[7];
          return DbHelperSQL.RunProcedure(storedProcName, parameters, tableName);
      }
      /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
      public object GetSingle(string SQLString)
      {
          return DbHelperSQL.GetSingle(SQLString);
      }
    }
}
