/************************************************************************************
 *      Copyright (C) 2007 supesoft.com,All Rights Reserved						    *
 *      File:																		*
 *				QueryParam.cs	                                           			*
 *      Description:																*
 *				 分页存储过程查询参数类 										    *
 *      Author:																		*
 *				Lzppcc														        *
 *				Lzppcc@hotmail.com													*
 *				http://www.supesoft.com												*
 *      Finish DateTime:															*
 *				2007年8月6日														*
 *      History:																	*
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Maticsoft.DBUtility
{
    /// <summary>
    /// 分页存储过程查询参数类
    /// </summary>
    public class QueryParam
    {
        #region "Private Variables"
        private string _tables;
        private string _fields="*";
        private string _filter="";
        private int _pageIndex = 1;
        private int _pageSize = 10;
        private string _orderName = "";
        private int _orderType = 0;
        private int _doCount = 0;

        #endregion
        #region "Public Variables"
        public QueryParam()
        {}
        public QueryParam(string tables,int doCount)
        {
            Tables = tables;
            DoCount = doCount;
        }
        public QueryParam(string tables, string fields, string filter, string orderName)
        {
            Tables = tables;
            Fields = fields;
            Filter = filter;
            OrderName = orderName;
        }
        public QueryParam(string tables, string fields, string filter, string orderName, int orderType)
        {
            Tables = tables;
            Fields = fields;
            Filter = filter;
            OrderName = orderName;
            OrderType = orderType;
        }
        public QueryParam(string tables, string fields, string filter, string orderName, int orderType,int pageIndex,int pageSize)
        {
            Tables = tables;
            Fields = fields;
            Filter = filter;
            PageIndex = pageIndex;
            PageSize = pageSize;
            OrderName = orderName;
            OrderType = orderType;
        }
        /// <summary>
        /// 表名
        /// </summary>
        public string Tables
        {
            get { return _tables; }
            set { _tables = value; }
        }
        /// <summary>
        /// 返回字段
        /// </summary>
        public string Fields
        {
            get { return _fields; }
            set { _fields = value; }
        }
        /// <summary>
        /// 查询条件 不需要Where
        /// </summary>
        public string Filter
        {
            get { return _filter; }
            set { _filter = value; }
        }
        /// <summary>
        /// 当前页码
        /// </summary>
        public int PageIndex
        {
            get { return _pageIndex; }
            set { _pageIndex = value; }
        }
        /// <summary>
        /// 每页记录数
        /// </summary>
        public int PageSize
        {
            get{ return _pageSize;}
            set{ _pageSize = value;}
        }
        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderName
        {
            get { return _orderName; }
            set { _orderName = value; }
        }
        /// <summary>
        /// 排序类型, 非 0 值则降序
        /// </summary>
        public int OrderType
        {
            get { return _orderType; }
            set { _orderType = value; }
        }
        /// <summary>
        /// 是否返回记录总数, 非 0 值则返回
        /// </summary>
        public int DoCount
        {
            get { return _doCount; }
            set { _doCount = value; }
        }






        #endregion
    }
}
