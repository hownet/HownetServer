using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Hownet.BLL
{
   public class RunProcedure
    {
       private readonly Hownet.DAL.RunProcedure dal = new Hownet.DAL.RunProcedure();
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public DataSet GetDSForPrcoce(string storedProcName,object[] o, string tableName)
        {
 
            return dal.GetDSForPrcoce(storedProcName, o, tableName);
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public  object GetSingle(string SQLString)
        {
            return dal.GetSingle(SQLString);
        }
    }
}
