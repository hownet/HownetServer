using System;
using System.Data;
using System.Collections.Generic;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类MaterielType 的摘要说明。
	/// </summary>
	public class MaterielType
	{
		private readonly Hownet.DAL.MaterielType dal=new Hownet.DAL.MaterielType();
		public MaterielType()
		{}
		#region  成员方法

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
		public int  Add(Hownet.Model.MaterielType model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.MaterielType> li=DataTableToList(dt);
			if(li.Count>0)
			{
				return dal.Add(li[0]);
			}
			else
			{
				return 0;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void Update(Hownet.Model.MaterielType model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
			List<Hownet.Model.MaterielType> li=DataTableToList(dt);
			if(li.Count>0)
			{
				dal.Update(li[0]);
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public void Delete(int ID)
		{
			
			dal.Delete(ID);
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.MaterielType GetModel(int ID)
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
		public DataSet GetTopList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.MaterielType> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.MaterielType> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.MaterielType> modelList = new List<Hownet.Model.MaterielType>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.MaterielType model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Hownet.Model.MaterielType();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					if(dt.Rows[n]["ParentID"].ToString()!="")
					{
						model.ParentID=int.Parse(dt.Rows[n]["ParentID"].ToString());
					}
					model.Name=dt.Rows[n]["Name"].ToString();
					model.Sn=dt.Rows[n]["Sn"].ToString();
					if(dt.Rows[n]["IsEnd"].ToString()!="")
					{
						model.IsEnd=int.Parse(dt.Rows[n]["IsEnd"].ToString());
					}
					if(dt.Rows[n]["IsUse"].ToString()!="")
					{
						if((dt.Rows[n]["IsUse"].ToString()=="1")||(dt.Rows[n]["IsUse"].ToString().ToLower()=="true"))
						{
						model.IsUse=true;
						}
						else
						{
							model.IsUse=false;
						}
					}
					model.Remark=dt.Rows[n]["Remark"].ToString();
					if(dt.Rows[n]["AttributeID"].ToString()!="")
					{
						model.AttributeID=int.Parse(dt.Rows[n]["AttributeID"].ToString());
					}
					model.A=int.Parse(dt.Rows[n]["A"].ToString());
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
        public DataSet GetTree()
        {
            return dal.GetTree();
        }
        public DataSet GetFinishedTree()
        {
            return dal.GetFinishedTree();
        }
        public void AddBase()
        {
            List<Hownet.Model.MaterielType> li = DataTableToList(dal.GetList("(ID=0)").Tables[0]);
            Hownet.Model.MaterielType modMT = new Hownet.Model.MaterielType();
            modMT.ParentID=0;
            modMT.Name="原材料";
            modMT.Sn="01";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=0;
            modMT.Name="半成品";
            modMT.Sn="02";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=2;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=0;
            modMT.Name="外加工";
            modMT.Sn="03";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=3;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=0;
            modMT.Name="成品";
            modMT.Sn="04";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=4;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=0;
            modMT.Name="商标";
            modMT.Sn="05";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=5;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=1;
            modMT.Name="钢弓";
            modMT.Sn="0101";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=1;
            modMT.Name="透明背带";
            modMT.Sn="0102";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=2;
            modMT.Name="棉碗";
            modMT.Sn="0201";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=2;
            modMT.Remark = "";
            Add(modMT);

            modMT.ParentID=2;
            modMT.Name="成品肩带";
            modMT.Sn="0202";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=2;
            modMT.Remark = "";
            Add(modMT);
            
            modMT.ParentID=1;
            modMT.Name="胶骨";
            modMT.Sn="0103";
            modMT.IsEnd=0;
            modMT.IsUse=true;
            modMT.AttributeID=1;
            modMT.Remark = "";
            Add(modMT);
        }
		/// <summary>
		/// 获得数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  成员方法
	}
}

