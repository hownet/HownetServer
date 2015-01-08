using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Hownet.DAL
{
	/// <summary>
	/// 数据访问类:KQ_GuiZeSet
	/// </summary>
	public partial class KQ_GuiZeSet
	{
		public KQ_GuiZeSet()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "KQ_GuiZeSet"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from KQ_GuiZeSet");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Hownet.Model.KQ_GuiZeSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into KQ_GuiZeSet(");
			strSql.Append("OneTime,OneTimeUp,OneTimeLast,TwoTime,TwoTimeUp,TwoTimeLast,ThreeTime,ThreeTimeUp,ThreeTimeLast,FourTime,FourTimeUp,FourTimeLast,FiveTime,FiveTimeUp,FiveTimeLast,SixTime,SixTimeUp,SixTimeLast,SixLast,SixCD,SixZT,SixKG,NoQD,NoQT,OneWor)");
			strSql.Append(" values (");
			strSql.Append("@OneTime,@OneTimeUp,@OneTimeLast,@TwoTime,@TwoTimeUp,@TwoTimeLast,@ThreeTime,@ThreeTimeUp,@ThreeTimeLast,@FourTime,@FourTimeUp,@FourTimeLast,@FiveTime,@FiveTimeUp,@FiveTimeLast,@SixTime,@SixTimeUp,@SixTimeLast,@SixLast,@SixCD,@SixZT,@SixKG,@NoQD,@NoQT,@OneWor)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@OneTime", SqlDbType.NVarChar,50),
					new SqlParameter("@OneTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@OneTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@TwoTime", SqlDbType.NVarChar,50),
					new SqlParameter("@TwoTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@TwoTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@ThreeTime", SqlDbType.NVarChar,50),
					new SqlParameter("@ThreeTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@ThreeTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@FourTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FourTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@FourTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@FiveTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FiveTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@FiveTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@SixTime", SqlDbType.NVarChar,50),
					new SqlParameter("@SixTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@SixTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@SixLast", SqlDbType.NVarChar,50),
					new SqlParameter("@SixCD", SqlDbType.Bit,1),
					new SqlParameter("@SixZT", SqlDbType.Bit,1),
					new SqlParameter("@SixKG", SqlDbType.Bit,1),
					new SqlParameter("@NoQD", SqlDbType.Int,4),
					new SqlParameter("@NoQT", SqlDbType.Int,4),
					new SqlParameter("@OneWor", SqlDbType.Int,4)};
			parameters[0].Value = model.OneTime;
			parameters[1].Value = model.OneTimeUp;
			parameters[2].Value = model.OneTimeLast;
			parameters[3].Value = model.TwoTime;
			parameters[4].Value = model.TwoTimeUp;
			parameters[5].Value = model.TwoTimeLast;
			parameters[6].Value = model.ThreeTime;
			parameters[7].Value = model.ThreeTimeUp;
			parameters[8].Value = model.ThreeTimeLast;
			parameters[9].Value = model.FourTime;
			parameters[10].Value = model.FourTimeUp;
			parameters[11].Value = model.FourTimeLast;
			parameters[12].Value = model.FiveTime;
			parameters[13].Value = model.FiveTimeUp;
			parameters[14].Value = model.FiveTimeLast;
			parameters[15].Value = model.SixTime;
			parameters[16].Value = model.SixTimeUp;
			parameters[17].Value = model.SixTimeLast;
			parameters[18].Value = model.SixLast;
			parameters[19].Value = model.SixCD;
			parameters[20].Value = model.SixZT;
			parameters[21].Value = model.SixKG;
			parameters[22].Value = model.NoQD;
			parameters[23].Value = model.NoQT;
			parameters[24].Value = model.OneWor;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Hownet.Model.KQ_GuiZeSet model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update KQ_GuiZeSet set ");
			strSql.Append("OneTime=@OneTime,");
			strSql.Append("OneTimeUp=@OneTimeUp,");
			strSql.Append("OneTimeLast=@OneTimeLast,");
			strSql.Append("TwoTime=@TwoTime,");
			strSql.Append("TwoTimeUp=@TwoTimeUp,");
			strSql.Append("TwoTimeLast=@TwoTimeLast,");
			strSql.Append("ThreeTime=@ThreeTime,");
			strSql.Append("ThreeTimeUp=@ThreeTimeUp,");
			strSql.Append("ThreeTimeLast=@ThreeTimeLast,");
			strSql.Append("FourTime=@FourTime,");
			strSql.Append("FourTimeUp=@FourTimeUp,");
			strSql.Append("FourTimeLast=@FourTimeLast,");
			strSql.Append("FiveTime=@FiveTime,");
			strSql.Append("FiveTimeUp=@FiveTimeUp,");
			strSql.Append("FiveTimeLast=@FiveTimeLast,");
			strSql.Append("SixTime=@SixTime,");
			strSql.Append("SixTimeUp=@SixTimeUp,");
			strSql.Append("SixTimeLast=@SixTimeLast,");
			strSql.Append("SixLast=@SixLast,");
			strSql.Append("SixCD=@SixCD,");
			strSql.Append("SixZT=@SixZT,");
			strSql.Append("SixKG=@SixKG,");
			strSql.Append("NoQD=@NoQD,");
			strSql.Append("NoQT=@NoQT,");
			strSql.Append("OneWor=@OneWor");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@OneTime", SqlDbType.NVarChar,50),
					new SqlParameter("@OneTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@OneTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@TwoTime", SqlDbType.NVarChar,50),
					new SqlParameter("@TwoTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@TwoTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@ThreeTime", SqlDbType.NVarChar,50),
					new SqlParameter("@ThreeTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@ThreeTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@FourTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FourTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@FourTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@FiveTime", SqlDbType.NVarChar,50),
					new SqlParameter("@FiveTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@FiveTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@SixTime", SqlDbType.NVarChar,50),
					new SqlParameter("@SixTimeUp", SqlDbType.NVarChar,50),
					new SqlParameter("@SixTimeLast", SqlDbType.NVarChar,50),
					new SqlParameter("@SixLast", SqlDbType.NVarChar,50),
					new SqlParameter("@SixCD", SqlDbType.Bit,1),
					new SqlParameter("@SixZT", SqlDbType.Bit,1),
					new SqlParameter("@SixKG", SqlDbType.Bit,1),
					new SqlParameter("@NoQD", SqlDbType.Int,4),
					new SqlParameter("@NoQT", SqlDbType.Int,4),
					new SqlParameter("@OneWor", SqlDbType.Int,4),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.OneTime;
			parameters[1].Value = model.OneTimeUp;
			parameters[2].Value = model.OneTimeLast;
			parameters[3].Value = model.TwoTime;
			parameters[4].Value = model.TwoTimeUp;
			parameters[5].Value = model.TwoTimeLast;
			parameters[6].Value = model.ThreeTime;
			parameters[7].Value = model.ThreeTimeUp;
			parameters[8].Value = model.ThreeTimeLast;
			parameters[9].Value = model.FourTime;
			parameters[10].Value = model.FourTimeUp;
			parameters[11].Value = model.FourTimeLast;
			parameters[12].Value = model.FiveTime;
			parameters[13].Value = model.FiveTimeUp;
			parameters[14].Value = model.FiveTimeLast;
			parameters[15].Value = model.SixTime;
			parameters[16].Value = model.SixTimeUp;
			parameters[17].Value = model.SixTimeLast;
			parameters[18].Value = model.SixLast;
			parameters[19].Value = model.SixCD;
			parameters[20].Value = model.SixZT;
			parameters[21].Value = model.SixKG;
			parameters[22].Value = model.NoQD;
			parameters[23].Value = model.NoQT;
			parameters[24].Value = model.OneWor;
			parameters[25].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KQ_GuiZeSet ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from KQ_GuiZeSet ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Hownet.Model.KQ_GuiZeSet GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,OneTime,OneTimeUp,OneTimeLast,TwoTime,TwoTimeUp,TwoTimeLast,ThreeTime,ThreeTimeUp,ThreeTimeLast,FourTime,FourTimeUp,FourTimeLast,FiveTime,FiveTimeUp,FiveTimeLast,SixTime,SixTimeUp,SixTimeLast,SixLast,SixCD,SixZT,SixKG,NoQD,NoQT,OneWor from KQ_GuiZeSet ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
};
			parameters[0].Value = ID;

			Hownet.Model.KQ_GuiZeSet model=new Hownet.Model.KQ_GuiZeSet();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
					model.OneTime=ds.Tables[0].Rows[0]["OneTime"].ToString();
					model.OneTimeUp=ds.Tables[0].Rows[0]["OneTimeUp"].ToString();
					model.OneTimeLast=ds.Tables[0].Rows[0]["OneTimeLast"].ToString();
					model.TwoTime=ds.Tables[0].Rows[0]["TwoTime"].ToString();
					model.TwoTimeUp=ds.Tables[0].Rows[0]["TwoTimeUp"].ToString();
					model.TwoTimeLast=ds.Tables[0].Rows[0]["TwoTimeLast"].ToString();
					model.ThreeTime=ds.Tables[0].Rows[0]["ThreeTime"].ToString();
					model.ThreeTimeUp=ds.Tables[0].Rows[0]["ThreeTimeUp"].ToString();
					model.ThreeTimeLast=ds.Tables[0].Rows[0]["ThreeTimeLast"].ToString();
					model.FourTime=ds.Tables[0].Rows[0]["FourTime"].ToString();
					model.FourTimeUp=ds.Tables[0].Rows[0]["FourTimeUp"].ToString();
					model.FourTimeLast=ds.Tables[0].Rows[0]["FourTimeLast"].ToString();
					model.FiveTime=ds.Tables[0].Rows[0]["FiveTime"].ToString();
					model.FiveTimeUp=ds.Tables[0].Rows[0]["FiveTimeUp"].ToString();
					model.FiveTimeLast=ds.Tables[0].Rows[0]["FiveTimeLast"].ToString();
					model.SixTime=ds.Tables[0].Rows[0]["SixTime"].ToString();
					model.SixTimeUp=ds.Tables[0].Rows[0]["SixTimeUp"].ToString();
					model.SixTimeLast=ds.Tables[0].Rows[0]["SixTimeLast"].ToString();
					model.SixLast=ds.Tables[0].Rows[0]["SixLast"].ToString();
				if(ds.Tables[0].Rows[0]["SixCD"]!=null && ds.Tables[0].Rows[0]["SixCD"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["SixCD"].ToString()=="1")||(ds.Tables[0].Rows[0]["SixCD"].ToString().ToLower()=="true"))
					{
						model.SixCD=true;
					}
					else
					{
						model.SixCD=false;
					}
				}
				if(ds.Tables[0].Rows[0]["SixZT"]!=null && ds.Tables[0].Rows[0]["SixZT"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["SixZT"].ToString()=="1")||(ds.Tables[0].Rows[0]["SixZT"].ToString().ToLower()=="true"))
					{
						model.SixZT=true;
					}
					else
					{
						model.SixZT=false;
					}
				}
				if(ds.Tables[0].Rows[0]["SixKG"]!=null && ds.Tables[0].Rows[0]["SixKG"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["SixKG"].ToString()=="1")||(ds.Tables[0].Rows[0]["SixKG"].ToString().ToLower()=="true"))
					{
						model.SixKG=true;
					}
					else
					{
						model.SixKG=false;
					}
				}
				if(ds.Tables[0].Rows[0]["NoQD"]!=null && ds.Tables[0].Rows[0]["NoQD"].ToString()!="")
				{
					model.NoQD=int.Parse(ds.Tables[0].Rows[0]["NoQD"].ToString());
				}
				if(ds.Tables[0].Rows[0]["NoQT"]!=null && ds.Tables[0].Rows[0]["NoQT"].ToString()!="")
				{
					model.NoQT=int.Parse(ds.Tables[0].Rows[0]["NoQT"].ToString());
				}
				if(ds.Tables[0].Rows[0]["OneWor"]!=null && ds.Tables[0].Rows[0]["OneWor"].ToString()!="")
				{
					model.OneWor=int.Parse(ds.Tables[0].Rows[0]["OneWor"].ToString());
				}
				model.A=1;
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  1 as A,ID,OneTime,OneTimeUp,OneTimeLast,TwoTime,TwoTimeUp,TwoTimeLast,ThreeTime,ThreeTimeUp,ThreeTimeLast,FourTime,FourTimeUp,FourTimeLast,FiveTime,FiveTimeUp,FiveTimeLast,SixTime,SixTimeUp,SixTimeLast,SixLast,SixCD,SixZT,SixKG,NoQD,NoQT,OneWor ");
			strSql.Append(" FROM KQ_GuiZeSet ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,OneTime,OneTimeUp,OneTimeLast,TwoTime,TwoTimeUp,TwoTimeLast,ThreeTime,ThreeTimeUp,ThreeTimeLast,FourTime,FourTimeUp,FourTimeLast,FiveTime,FiveTimeUp,FiveTimeLast,SixTime,SixTimeUp,SixTimeLast,SixLast,SixCD,SixZT,SixKG,NoQD,NoQT,OneWor ");
			strSql.Append(" FROM KQ_GuiZeSet ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "KQ_GuiZeSet";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

