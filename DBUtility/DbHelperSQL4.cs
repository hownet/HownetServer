using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Collections.Generic;
namespace Maticsoft.DBUtility
{
    /// <summary>
    /// 数据访问抽象基础类
    /// Copyright (C) 2004-2008 By LiTianPing 
    /// </summary>
    public abstract class NewDbHelperSQL
    {
        //数据库连接字符串(web.config来配置)，可以动态更改connectionString支持多数据库.		
        public static string connectionString = PubConstant.ConnectionString;     		
        public NewDbHelperSQL()
        {
        }
        #region 存储过程操作

        /// <summary>
        /// 执行存储过程，返回SqlDataReader ( 注意：调用该方法后，一定要对SqlDataReader进行Close )
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader returnReader;
            connection.Open();
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            returnReader = command.ExecuteReader(CommandBehavior.CloseConnection);
            return returnReader;
            
        }


        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.Fill(dataSet,tableName);
                connection.Close();
                return dataSet;
            }
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <param name="Times">等待时间</param>
        /// <returns>DataSet</returns>
        public static DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName, int Times)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.SelectCommand.CommandTimeout = Times;
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }


        /// <summary>
        /// 构建 SqlCommand 对象(用来返回一个结果集，而不是一个整数值)
        /// </summary>
        /// <param name="connection">数据库连接</param>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand</returns>
        private static SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            if (parameters != null)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    if (parameter != null)
                    {
                        // 检查未分配值的输出参数,将其分配以DBNull.Value.
                        if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) &&
                            (parameter.Value == null))
                        {
                            parameter.Value = DBNull.Value;
                        }
                        command.Parameters.Add(parameter);
                    }
                }
            }

            return command;
        }

        public static int RunProcedureReturnID(string storedProcName, IDataParameter[] parameters)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                object obj;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                obj = command.ExecuteScalar();
                command.Parameters.Clear();
                if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                {
                    return 0;
                }
                else
                {
                    return (int)obj;
                }
            }
        }
        /// <summary>
        /// 执行存储过程，返回影响的行数		
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="rowsAffected">影响的行数</param>
        /// <returns></returns>
        public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int result;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                result = (int)command.Parameters["ReturnValue"].Value;
                //Connection.Close();
                return result;
            }
        }
        /// <summary>
        /// 创建 SqlCommand 对象实例(用来返回一个整数值)	
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <returns>SqlCommand 对象实例</returns>
        private static SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
                SqlDbType.Int, 4, ParameterDirection.ReturnValue,
                false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }
        #endregion
        #region 公共增删改数据函数Sql存储过程版
        /// <summary>
        ///  增加一条数据
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="Where">更新字段 不带Set 例:Field1,Field2,Field3 ...</param>
        /// <param name="Where">更新字段值 不带Value() 例:Value1,Value2,Value3 ...</param>
        /// <returns>返回影响行数</returns>
        public static int Table_Insert(string TableName, string Fields, string Values)
        {
            int result;
            SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.NVarChar,50),
					new SqlParameter("@Fields", SqlDbType.NVarChar,2000),
					new SqlParameter("@Values", SqlDbType.NVarChar,2000)};
            parameters[0].Value = TableName;
            parameters[1].Value = Fields;
            parameters[2].Value = Values;
            result = NewDbHelperSQL.RunProcedureReturnID("Pr_Table_Insert", parameters);

            return result;
            
        }
        /// <summary>
        ///  修改一条数据
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="FieldsAndValues">更新字段列表以及值列表 不带Set 例:Field1=Value1,Field2=Value2 ...</param>
        /// <param name="Where">更新条件 不带Where 例:id=1 and name='张三'</param>
        /// <returns>返回影响行数</returns>
        public static int Table_Updata(string TableName, string FieldsAndValues, string Where)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.NVarChar,50),
					new SqlParameter("@FieldsAndValues", SqlDbType.NVarChar,2000),
					new SqlParameter("@Where", SqlDbType.NVarChar,2000)};
            parameters[0].Value = TableName;
            parameters[1].Value = FieldsAndValues;
            parameters[2].Value = Where;

            DbHelperSQL.RunProcedure("Pr_Table_Update", parameters, out rowsAffected);
            return rowsAffected;
        }
        /// <summary>
        ///  删除一条数据
        /// </summary>
        /// <param name="TableName">表名</param>
        /// <param name="Where">更新字段 不带Set 例:Field1,Field2,Field3 ...</param>
        /// <param name="Where">更新字段值 不带Value() 例:Value1,Value2,Value3 ...</param>
        /// <returns>返回影响行数</returns>
        public static int Table_Delete(string TableName, string Where)
        {
            int rowsAffected;
            SqlParameter[] parameters = {
					new SqlParameter("@TableName", SqlDbType.NVarChar,50),
					new SqlParameter("@Where", SqlDbType.NVarChar,2000)};
            parameters[0].Value = TableName;
            parameters[1].Value = Where;

            DbHelperSQL.RunProcedure("Pr_Table_Delete", parameters, out rowsAffected);
            return rowsAffected;
        }

        #endregion
        #region 公共查询数据函数Sql存储过程版
        /// <summary>
        /// 公共查询数据函数Sql存储过程版
        /// </summary>
        /// <param name="qp">参数对象</param>
        /// <returns>返回记录集DataSet</returns>
        public static DataSet GetListByParam(QueryParam qp, string tableName)
        {
            DataSet ds = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlParameter[] parameters = {
					new SqlParameter("@Tables", SqlDbType.VarChar,255),
					new SqlParameter("@Fields", SqlDbType.VarChar,1000),
					new SqlParameter("@Filter", SqlDbType.VarChar,1500),
                    new SqlParameter("@OrderName",SqlDbType.VarChar,255),
                    new SqlParameter("@OrderType",SqlDbType.Bit)};
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.OrderName;
                parameters[4].Value = qp.OrderType;

                ds = RunProcedure("Pr_Table_GetModel", parameters, tableName);

            }
            return ds;
        }
        /// <summary>
        /// 公共查询数据函数Sql存储过程版
        /// </summary>
        /// <param name="qp">参数对象</param>
        /// <returns>返回记录集SqlDataReader</returns>
        public static SqlDataReader GetListByParam(QueryParam qp)
        {
            SqlDataReader dr = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlParameter[] parameters = {
					new SqlParameter("@Tables", SqlDbType.VarChar,255),
					new SqlParameter("@Fields", SqlDbType.VarChar,1000),
					new SqlParameter("@Filter", SqlDbType.VarChar,1500),
                    new SqlParameter("@OrderName",SqlDbType.VarChar,255),
                    new SqlParameter("@OrderType",SqlDbType.Bit)};
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.OrderName;
                parameters[4].Value = qp.OrderType;

                dr = RunProcedure("Pr_Table_GetModel", parameters);

            }
            return dr;
        }
        /// <summary>
        /// 公共分页查询数据函数Sql存储过程版
        /// </summary>
        /// <param name="qp">参数对象</param>
        /// <param name="RecordCount">返回数据列表总记录数</param>
        /// <returns>返回记录集DataSet</returns>
        public static DataSet GetListByPagination(QueryParam qp, out int RecordCount)
        {
            DataSet ds = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //创建参数
                SqlParameter[] parameters ={new SqlParameter("@Tables", SqlDbType.VarChar, 255),
                                            new SqlParameter("@Fields", SqlDbType.VarChar, 1000), 
                                            new SqlParameter("@Filter", SqlDbType.VarChar, 1500) ,
                                            new SqlParameter("@PageSize", SqlDbType.Int),
                                            new SqlParameter("@PageIndex", SqlDbType.Int),
                                            new SqlParameter("@OrderName", SqlDbType.VarChar, 255),
                                            new SqlParameter("@OrderType", SqlDbType.Bit),
                                            new SqlParameter("@doCount",SqlDbType.Bit)};
                // 设置参数
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.PageSize;
                parameters[4].Value = qp.PageIndex;
                parameters[5].Value = qp.OrderName;
                parameters[6].Value = qp.OrderType;
                parameters[7].Value = qp.DoCount;


                ds = RunProcedure("Pr_Pagination", parameters, "ds");

                // 取记录总数 及页数
                //RecordCount = parameters[7].Value;
                //string dd = ds.Tables[1].Rows[0][0].ToString();
                RecordCount = GetPaginationCount(qp);
            }
            return ds;
        }
        public static int GetPaginationCount(QueryParam qp)
        {
            int RecordCount = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlParameter[] parameters ={new SqlParameter("@Tables", SqlDbType.VarChar, 255),
                                            new SqlParameter("@Fields", SqlDbType.VarChar, 1000), 
                                            new SqlParameter("@Filter", SqlDbType.VarChar, 1500) ,
                                            new SqlParameter("@PageSize", SqlDbType.Int),
                                            new SqlParameter("@PageIndex", SqlDbType.Int),
                                            new SqlParameter("@OrderName", SqlDbType.VarChar, 255),
                                            new SqlParameter("@OrderType", SqlDbType.Bit),
                                            new SqlParameter("@doCount",SqlDbType.Bit)};
                // 设置参数
                parameters[0].Value = qp.Tables;
                parameters[1].Value = qp.Fields;
                parameters[2].Value = qp.Filter;
                parameters[3].Value = qp.PageSize;
                parameters[4].Value = qp.PageIndex;
                parameters[5].Value = qp.OrderName;
                parameters[6].Value = qp.OrderType;
                parameters[7].Value = 1;

                SqlDataReader Dr = RunProcedure("Pr_Pagination", parameters);

                if (Dr.Read())
                {
                    if(Dr[0].ToString()!="" || Dr[0].ToString()!=null)
                    {
                        RecordCount = Convert.ToInt32(Dr[0].ToString());
                    }
                }
            }
            return RecordCount;
        }
        #endregion
    }

}
