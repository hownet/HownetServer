using System;
namespace Hownet.Model
{
	/// <summary>
	/// FixedAssets:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class FixedAssets
	{
		public FixedAssets()
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
		/// 资产编码
		/// </summary>
		public string Sn
		{
			set;
			get;
		}
		/// <summary>
		/// 卡片条码
		/// </summary>
		public string Barcode
		{
			set;
			get;
		}
		/// <summary>
		/// 资产名称
		/// </summary>
		public string Name
		{
			set;
			get;
		}
		/// <summary>
		/// 资产类型
		/// </summary>
		public int FATypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 型号规格
		/// </summary>
		public string Spec
		{
			set;
			get;
		}
		/// <summary>
		/// 制造工厂
		/// </summary>
		public int CompanyID
		{
			set;
			get;
		}
		/// <summary>
		/// 国标编码
		/// </summary>
		public string GBCode
		{
			set;
			get;
		}
		/// <summary>
		/// 详细配置
		/// </summary>
		public string More
		{
			set;
			get;
		}
		/// <summary>
		/// 出厂日期
		/// </summary>
		public DateTime DateOfOut
		{
			set;
			get;
		}
		/// <summary>
		/// 使用部门
		/// </summary>
		public int UseDeparmentID
		{
			set;
			get;
		}
		/// <summary>
		/// 使用状态
		/// </summary>
		public int UseTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 存放地点
		/// </summary>
		public string StoreAccess
		{
			set;
			get;
		}
		/// <summary>
		/// 保管人员
		/// </summary>
		public int Custodian
		{
			set;
			get;
		}
		/// <summary>
		/// 数量
		/// </summary>
		public decimal Amount
		{
			set;
			get;
		}
		/// <summary>
		/// 单位
		/// </summary>
		public int MeasureID
		{
			set;
			get;
		}
		/// <summary>
		/// 单价
		/// </summary>
		public decimal Price
		{
			set;
			get;
		}
		/// <summary>
		/// 增加方式
		/// </summary>
		public int AddTypeID
		{
			set;
			get;
		}
		/// <summary>
		/// 原值
		/// </summary>
		public decimal OldMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 残值
		/// </summary>
		public decimal NowMoney
		{
			set;
			get;
		}
		/// <summary>
		/// 折旧方法
		/// </summary>
		public int Depreciation
		{
			set;
			get;
		}
		/// <summary>
		/// 残值率
		/// </summary>
		public decimal ResidualValue
		{
			set;
			get;
		}
		/// <summary>
		/// 启用时间
		/// </summary>
		public DateTime UseDate
		{
			set;
			get;
		}
		/// <summary>
		/// 维修间隔月
		/// </summary>
		public int Interval
		{
			set;
			get;
		}
		/// <summary>
		/// 折旧年限
		/// </summary>
		public int DepreciationYear
		{
			set;
			get;
		}
		/// <summary>
		/// 折旧月数
		/// </summary>
		public int DepreciationMonth
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
		/// 是否被借出或维修中
		/// </summary>
		public bool IsOut
		{
			set;
			get;
		}
		#endregion Model

	}
}

