using System;
using System.Data;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

using Hownet.Model;
namespace Hownet.BLL
{
	/// <summary>
	/// 业务逻辑类Users 的摘要说明。
	/// </summary>
	public class Users
	{
		private readonly Hownet.DAL.Users dal=new Hownet.DAL.Users();
		public Users()
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
		public int  Add(Hownet.Model.Users model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 增加一条数据,数据源为DataTable
		/// </summary>
		public int  AddByDt(DataTable dt)
		{
			List<Hownet.Model.Users> li=DataTableToList(dt);
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
		public void Update(Hownet.Model.Users model)
		{
			dal.Update(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public void UpdateByDt(DataTable dt)
		{
            List<Hownet.Model.Users> li = DataTableToList(dt);
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
		public Hownet.Model.Users GetModel(int ID)
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
		public List<Hownet.Model.Users> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Hownet.Model.Users> DataTableToList(DataTable dt)
		{
			List<Hownet.Model.Users> modelList = new List<Hownet.Model.Users>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Hownet.Model.Users model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Hownet.Model.Users();
                    if (dt.Rows[n]["ID"].ToString() != "")
                    {
                        model.ID = int.Parse(dt.Rows[n]["ID"].ToString());
                    }
                    model.Name = dt.Rows[n]["Name"].ToString();
                    if (dt.Rows[n]["Password"].ToString() != "")
                    {
                        model.Password = (byte[])dt.Rows[n]["Password"];
                    }
                    model.TrueName = dt.Rows[n]["TrueName"].ToString();
                    model.Phone = dt.Rows[n]["Phone"].ToString();
                    model.Email = dt.Rows[n]["Email"].ToString();
                    if (dt.Rows[n]["EmployeeID"].ToString() != "")
                    {
                        model.EmployeeID = int.Parse(dt.Rows[n]["EmployeeID"].ToString());
                    }
                    if (dt.Rows[n]["DepartmentID"].ToString() != "")
                    {
                        model.DepartmentID = int.Parse(dt.Rows[n]["DepartmentID"].ToString());
                    }
                    if (dt.Rows[n]["State"].ToString() != "")
                    {
                        model.State = int.Parse(dt.Rows[n]["State"].ToString());
                    }
                    if (dt.Rows[n]["JobsID"].ToString() != "")
                    {
                        model.JobsID = int.Parse(dt.Rows[n]["JobsID"].ToString());
                    }
                    model.A = int.Parse(dt.Rows[n]["A"].ToString());
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
        public DataSet GetViewList()
        {
           
            DataSet ds = dal.GetViewList();
            return ds;
        }
        public bool CheckUser(int UserID, byte[] bb)
        {
            bool t = true;
            object obj = dal.GetPass(UserID);
            if (obj != null)
            {
                byte[] a = (byte[])(obj);
                for (int i = 0; i < bb.Length; i++)
                {
                    if (bb[i] != a[i])
                    {
                        t = false;
                        break;
                    }
                }
            }
            else
            {
                t = false;
            }
            return t;
        }
        public int CheckUserByUserName(string  UserName, byte[] bb)
        {
            bool t = true;
           DataTable dt = dal.GetPassByUserName(UserName);
            if (dt.Rows.Count>0&&dt.Rows[0][1] != null)
            {
                byte[] a = (byte[])(dt.Rows[0][1]);
                for (int i = 0; i < bb.Length; i++)
                {
                    if (bb[i] != a[i])
                    {
                        t = false;
                        break;
                    }
                }
            }
            else
            {
                t = false;
            }
            if (t)
                return Convert.ToInt32(dt.Rows[0]["ID"]);
            else
                return 0;
        }
        public int CheckUserByStrPW(string UserName, string PassWord)
        {
            bool t = true;
            DataTable dt = dal.GetPassByUserName(UserName);
            if (dt.Rows.Count > 0 && dt.Rows[0][1] != null)
            {
                byte[] a = (byte[])(dt.Rows[0][1]);

                string pass = Encrypt(PassWord, "howneter");
                byte[] bb = Convert.FromBase64String(pass);
                for (int i = 0; i < bb.Length; i++)
                {
                    if (bb[i] != a[i])
                    {
                        t = false;
                        break;
                    }
                }
            }
            else
            {
                t = false;
            }
            if (t)
                return Convert.ToInt32(dt.Rows[0]["ID"]);
            else
                return 0;
        }
        public DataSet GetPerList()
        {
            return dal.GetPerList();
        }
        public string Encrypt(string pToEncrypt, string sKey)
        {

            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(pToEncrypt);
                des.Key = ASCIIEncoding.ASCII.GetBytes(sKey);
                des.IV = ASCIIEncoding.ASCII.GetBytes(sKey);
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                return str;
            }
        }

        public DataSet GetTableName()
        {
            return dal.GetTableName();
        }
        public DataSet GetTableColumns(string TableName)
        {
            return dal.GetTableColumns(TableName);
        }
        public int GetUserIDByName(string UserName)
        {
            return dal.GetUserIDByName(UserName);
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

