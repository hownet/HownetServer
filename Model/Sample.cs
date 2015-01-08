/**  版本信息模板在安装目录下，可自行修改。
* Sample.cs
*
* 功 能： N/A
* 类 名： Sample
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2015/1/1 14:41:30   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Hownet.Model
{
	/// <summary>
	/// Sample:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Sample
	{
		public Sample()
		{}
		#region Model
		/// <summary>
		/// A，用于标识是否被修改
		/// </summary>
		public int A
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set;
			get;
		}
		/// <summary>
		/// 制板编号前缀
		/// </summary>
		public string StrNum
		{
			set;
			get;
		}
		/// <summary>
		/// 制版编号
		/// </summary>
		public int Num
		{
			set;
			get;
		}
		/// <summary>
		/// 大货批号
		/// </summary>
		public string Titlle
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string CompanyName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int CompanyID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string MaterielName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int MaterielID
		{
			set;
			get;
		}
		/// <summary>
		/// 系列名
		/// </summary>
		public string TypeName
		{
			set;
			get;
		}
		/// <summary>
		/// 计划回料期
		/// </summary>
		public DateTime PlanDate
		{
			set;
			get;
		}
		/// <summary>
		/// 系列名
		/// </summary>
		public string SeriesName
		{
			set;
			get;
		}
		/// <summary>
		/// 开版日期
		/// </summary>
		public DateTime OpenDate
		{
			set;
			get;
		}
		/// <summary>
		/// 版期
		/// </summary>
		public DateTime LastDate
		{
			set;
			get;
		}
		/// <summary>
		/// 采购部回料时间
		/// </summary>
		public DateTime StockBackDate
		{
			set;
			get;
		}
		/// <summary>
		/// 技术部回复时间
		/// </summary>
		public DateTime TechDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int FillManID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string FillManName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int VerifyID
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public string VerifyName
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime FillDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime VerifyDate
		{
			set;
			get;
		}
		/// <summary>
		/// 
		/// </summary>
		public int UpData
		{
			set;
			get;
		}
        		
		/// <summary>
		/// 品名
		/// </summary>
		public string ProductName
		{
			set;
			get;
		}
		#endregion Model

	}
}

