using System;
using System.Data;
using System.Collections.Generic;
using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// PayNew
	/// </summary>
	public partial class PayNew
	{
		private readonly Hownet.DAL.PayNew dal=new Hownet.DAL.PayNew();
		public PayNew()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			return dal.Exists(ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Hownet.Model.PayNew model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.PayNew> li = DataTableToList(dt);
			int a=0;
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					a=Add(li[i]);
				}
			}
				return a;
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Hownet.Model.PayNew model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据,数据源为DataTable
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.PayNew> li = DataTableToList(dt);
			if (li.Count > 0)
			{
				for (int i = 0; i < li.Count; i++)
				{
					 dal.Update(li[i]);
				}
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.PayNew GetModel(int ID)
		{
			
			return dal.GetModel(ID);
		}



		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.PayNew> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.PayNew> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.PayNew> modelList = new List<Hownet.Model.PayNew>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.PayNew model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.PayNew();
					if(dt.Rows[n]["ID"]!=null && dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["EmployeeID"]!=null && dt.Rows[n]["EmployeeID"].ToString()!="")
					{
						model.EmployeeID=int.Parse(dt.Rows[n]["EmployeeID"].ToString());
					}
					if(dt.Rows[n]["MainID"]!=null && dt.Rows[n]["MainID"].ToString()!="")
					{
						model.MainID=int.Parse(dt.Rows[n]["MainID"].ToString());
					}
					if(dt.Rows[n]["Month"]!=null && dt.Rows[n]["Month"].ToString()!="")
					{
						model.Month=decimal.Parse(dt.Rows[n]["Month"].ToString());
					}
					if(dt.Rows[n]["GuDing1"]!=null && dt.Rows[n]["GuDing1"].ToString()!="")
					{
						model.GuDing1=decimal.Parse(dt.Rows[n]["GuDing1"].ToString());
					}
					if(dt.Rows[n]["GuDing2"]!=null && dt.Rows[n]["GuDing2"].ToString()!="")
					{
						model.GuDing2=decimal.Parse(dt.Rows[n]["GuDing2"].ToString());
					}
					if(dt.Rows[n]["GuDing3"]!=null && dt.Rows[n]["GuDing3"].ToString()!="")
					{
						model.GuDing3=decimal.Parse(dt.Rows[n]["GuDing3"].ToString());
					}
					if(dt.Rows[n]["GuDing4"]!=null && dt.Rows[n]["GuDing4"].ToString()!="")
					{
						model.GuDing4=decimal.Parse(dt.Rows[n]["GuDing4"].ToString());
					}
					if(dt.Rows[n]["GuDing5"]!=null && dt.Rows[n]["GuDing5"].ToString()!="")
					{
						model.GuDing5=decimal.Parse(dt.Rows[n]["GuDing5"].ToString());
					}
					if(dt.Rows[n]["Add1"]!=null && dt.Rows[n]["Add1"].ToString()!="")
					{
						model.Add1=decimal.Parse(dt.Rows[n]["Add1"].ToString());
					}
					if(dt.Rows[n]["Add2"]!=null && dt.Rows[n]["Add2"].ToString()!="")
					{
						model.Add2=decimal.Parse(dt.Rows[n]["Add2"].ToString());
					}
					if(dt.Rows[n]["Add3"]!=null && dt.Rows[n]["Add3"].ToString()!="")
					{
						model.Add3=decimal.Parse(dt.Rows[n]["Add3"].ToString());
					}
					if(dt.Rows[n]["Add4"]!=null && dt.Rows[n]["Add4"].ToString()!="")
					{
						model.Add4=decimal.Parse(dt.Rows[n]["Add4"].ToString());
					}
					if(dt.Rows[n]["Add5"]!=null && dt.Rows[n]["Add5"].ToString()!="")
					{
						model.Add5=decimal.Parse(dt.Rows[n]["Add5"].ToString());
					}
					if(dt.Rows[n]["Add6"]!=null && dt.Rows[n]["Add6"].ToString()!="")
					{
						model.Add6=decimal.Parse(dt.Rows[n]["Add6"].ToString());
					}
					if(dt.Rows[n]["Add7"]!=null && dt.Rows[n]["Add7"].ToString()!="")
					{
						model.Add7=decimal.Parse(dt.Rows[n]["Add7"].ToString());
					}
					if(dt.Rows[n]["Add8"]!=null && dt.Rows[n]["Add8"].ToString()!="")
					{
						model.Add8=decimal.Parse(dt.Rows[n]["Add8"].ToString());
					}
					if(dt.Rows[n]["Add9"]!=null && dt.Rows[n]["Add9"].ToString()!="")
					{
						model.Add9=decimal.Parse(dt.Rows[n]["Add9"].ToString());
					}
					if(dt.Rows[n]["Add10"]!=null && dt.Rows[n]["Add10"].ToString()!="")
					{
						model.Add10=decimal.Parse(dt.Rows[n]["Add10"].ToString());
					}
					if(dt.Rows[n]["Jian1"]!=null && dt.Rows[n]["Jian1"].ToString()!="")
					{
						model.Jian1=decimal.Parse(dt.Rows[n]["Jian1"].ToString());
					}
					if(dt.Rows[n]["Jian2"]!=null && dt.Rows[n]["Jian2"].ToString()!="")
					{
						model.Jian2=decimal.Parse(dt.Rows[n]["Jian2"].ToString());
					}
					if(dt.Rows[n]["Jian3"]!=null && dt.Rows[n]["Jian3"].ToString()!="")
					{
						model.Jian3=decimal.Parse(dt.Rows[n]["Jian3"].ToString());
					}
					if(dt.Rows[n]["Jian4"]!=null && dt.Rows[n]["Jian4"].ToString()!="")
					{
						model.Jian4=decimal.Parse(dt.Rows[n]["Jian4"].ToString());
					}
					if(dt.Rows[n]["Jian5"]!=null && dt.Rows[n]["Jian5"].ToString()!="")
					{
						model.Jian5=decimal.Parse(dt.Rows[n]["Jian5"].ToString());
					}
					if(dt.Rows[n]["Jian6"]!=null && dt.Rows[n]["Jian6"].ToString()!="")
					{
						model.Jian6=decimal.Parse(dt.Rows[n]["Jian6"].ToString());
					}
					if(dt.Rows[n]["Jian7"]!=null && dt.Rows[n]["Jian7"].ToString()!="")
					{
						model.Jian7=decimal.Parse(dt.Rows[n]["Jian7"].ToString());
					}
					if(dt.Rows[n]["Jian8"]!=null && dt.Rows[n]["Jian8"].ToString()!="")
					{
						model.Jian8=decimal.Parse(dt.Rows[n]["Jian8"].ToString());
					}
					if(dt.Rows[n]["Jian9"]!=null && dt.Rows[n]["Jian9"].ToString()!="")
					{
						model.Jian9=decimal.Parse(dt.Rows[n]["Jian9"].ToString());
					}
					if(dt.Rows[n]["Jian10"]!=null && dt.Rows[n]["Jian10"].ToString()!="")
					{
						model.Jian10=decimal.Parse(dt.Rows[n]["Jian10"].ToString());
					}
					if(dt.Rows[n]["JiShuanHGZ"]!=null && dt.Rows[n]["JiShuanHGZ"].ToString()!="")
					{
						model.JiShuanHGZ=decimal.Parse(dt.Rows[n]["JiShuanHGZ"].ToString());
					}
					if(dt.Rows[n]["Fact"]!=null && dt.Rows[n]["Fact"].ToString()!="")
					{
						model.Fact=decimal.Parse(dt.Rows[n]["Fact"].ToString());
					}
					if(dt.Rows[n]["Remain"]!=null && dt.Rows[n]["Remain"].ToString()!="")
					{
						model.Remain=decimal.Parse(dt.Rows[n]["Remain"].ToString());
					}
					if(dt.Rows[n]["LastRemain"]!=null && dt.Rows[n]["LastRemain"].ToString()!="")
					{
						model.LastRemain=decimal.Parse(dt.Rows[n]["LastRemain"].ToString());
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

