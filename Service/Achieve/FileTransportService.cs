using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using System.Configuration;
using System.IO;
using MessageContract;
using System.ServiceModel.Channels;
using System.Threading;
using System.Data;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Compression;
using System.Collections;
using ReaderCard;


namespace Service
{

    //[ServiceBehavior(
    //AutomaticSessionShutdown = false,
    //ConcurrencyMode = ConcurrencyMode.Multiple,
    //InstanceContextMode = InstanceContextMode.PerSession,
    //IncludeExceptionDetailInFaults = true,
    //UseSynchronizationContext = true,AutomaticSessionShutdown=false,
    //ValidateMustUnderstand = true)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple, IncludeExceptionDetailInFaults = true)]
    public class FileTransportService : IFileTransportService
    {
       // private static Dictionary<string, IChatCallBack> chaters = new Dictionary<string, IChatCallBack>();
        private Int32 bufferLen = 4096;// Int32.Parse(ConfigurationSettings.AppSettings["BufferSize"]);
        //  private String uploadFolder = ServiceForm.Dir + @"\UploadFile\";
        public static readonly String uploadFolder = ServiceForm.Dir + @"\UploadFile\";
        public void UploadFile(FileUploadMessage request)
        {
            //获得客户端信息
            OperationContext context = OperationContext.Current;
            MessageProperties messageProperties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpointProperty = (RemoteEndpointMessageProperty)messageProperties[RemoteEndpointMessageProperty.Name];
            //Console.WriteLine("客户端" + endpointProperty.Address + "端口:" + endpointProperty.Port + "开始上传文件" + request.FileName + ".....");
            String fileName = request.FileName;
            Stream sourceStream = request.FileData;
            FileStream targetStream = null;
            String saveFilePath = Path.Combine(uploadFolder, request.FileName);
            byte[] buffer = new byte[bufferLen];
            Int32 count = 0;

            if (sourceStream.CanRead)
            {
                //如果文件目录不存在,创建文件所存放的目录.
                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }

                targetStream = new FileStream(saveFilePath, FileMode.Create, FileAccess.Write, FileShare.None);
                while ((count = sourceStream.Read(buffer, 0, bufferLen)) > 0)
                {
                    targetStream.Write(buffer, 0, count);
                }
                targetStream.Close();
                sourceStream.Close();

                Console.WriteLine("文件" + request.FileName + "传输完毕,存放路径:" + saveFilePath);
            }
            else
            {
                Console.WriteLine("数据流不可读.");
                throw new Exception("数据流不可读!");
            }

        }
        public void DelFile(string FileName)
        {
            if (FileName.Trim() != string.Empty)
            {
                String FilePath = Path.Combine(uploadFolder, FileName);
                File.Delete(FilePath);
            }
        }
        public List<String> GetFileList()
        {
            List<String> fileList = new List<string>();

            DirectoryInfo di = new DirectoryInfo(uploadFolder);
            FileInfo[] fis = di.GetFiles();
            foreach (FileInfo fi in fis)
            {
                fileList.Add(fi.Name);
            }

            return fileList;
        }

        /// <summary>
        /// 返回DataSet
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <returns></returns>
        public DataSet GetList(string Bll, string Exc, object[] par)
        {
            DataSet ds = new DataSet();
            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            ds = (DataSet)method.Invoke(obj, par);
            return ds;
        }
        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        public byte[] GetDSForPrcoce(string storedProcName, object[] parameters, string tableName)
        {
            Hownet.BLL.RunProcedure bllRP = new Hownet.BLL.RunProcedure();
            return ds2Byte(bllRP.GetDSForPrcoce(storedProcName, parameters, tableName));
        }
        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        public object GetSingle(string SQLString)
        {
            Hownet.BLL.RunProcedure bllRP = new Hownet.BLL.RunProcedure();
            return bllRP.GetSingle(SQLString);
        }
        /// <summary>
        /// 返回序列化后的DataSet
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <param name="par"></param>
        /// <returns></returns>
        public byte[] getZipData(string Bll, string Exc, object[] par)
        {
            DataSet ds = new DataSet();

            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            ds = (DataSet)method.Invoke(obj, par);
            return ds2Byte(ds);
        }
        private byte[] ds2Byte(DataSet ds)
        {
            ds.RemotingFormat = SerializationFormat.Binary;
            BinaryFormatter ser = new BinaryFormatter();
            MemoryStream unMS = new MemoryStream();
            ser.Serialize(unMS, ds);
            byte[] bytes = unMS.ToArray();
            int lenbyte = bytes.Length;
            MemoryStream compMs = new MemoryStream();
            GZipStream compStream = new GZipStream(compMs, CompressionMode.Compress, true);
            compStream.Write(bytes, 0, lenbyte);
            compStream.Close();
            unMS.Close();
            compMs.Close();
            byte[] zipData = compMs.ToArray();
            return zipData;
        }
        public byte[] GetJson(string Bll, string Exc, object[] par)
        {
            DataSet ds = new DataSet();
            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            ds = (DataSet)method.Invoke(obj, par);
            return jsonds2Byte(ds);
        }
        private byte[] jsonds2Byte(DataSet ds)
        {
            StringBuilder strDS = new StringBuilder();
            for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
            {
                strDS.Append(ds.Tables[0].Columns[i].ColumnName);
                strDS.Append("ю");
                strDS.Append(ds.Tables[0].Columns[i].DataType.ToString());
                strDS.Append("ж");//列字段
            }
            strDS.Append("й");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    strDS.Append(ds.Tables[0].Rows[i][j].ToString());
                    strDS.Append("ж");
                }
                strDS.Append("й");
            }

            try
            {
                // ms读取传入的str并转存如数组序列中
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(strDS.ToString());
                sw.Close();
                byte[] bsrc = ms.ToArray();
                ms.Close();
                ms.Dispose();
                ms = new MemoryStream();
                ms.Position = 0;
                // 压缩数组序列并返回压缩后的数组
                DeflateStream zipStream = new DeflateStream(ms, CompressionMode.Compress);
                zipStream.Write(bsrc, 0, bsrc.Length);
                zipStream.Close();
                zipStream.Dispose();
                return ms.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public byte[] GetBySql(string Sql)
        {
            DataSet ds = Maticsoft.DBUtility.DbHelperSQL.Query(Sql);
            return jsonds2Byte(ds);
        }
        public byte[] GetSqlByByte(string sql)
        {
            DataSet ds = Maticsoft.DBUtility.DbHelperSQL.Query(sql);
            return ds2Byte(ds);
        }
        public byte[] GetStringList(string Bll, string Exc, object[] par)
        {
            DataSet ds = new DataSet();
            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            ds = (DataSet)method.Invoke(obj, par);
            StringBuilder strDS = new StringBuilder();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                {
                    strDS.Append(ds.Tables[0].Rows[i][j].ToString());
                    strDS.Append("ж");
                }
                strDS.Append("й");
            }

            try
            {
                // ms读取传入的str并转存如数组序列中
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter(ms);
                sw.Write(strDS.ToString());
                sw.Close();
                byte[] bsrc = ms.ToArray();
                ms.Close();
                ms.Dispose();
                ms = new MemoryStream();
                ms.Position = 0;
                // 压缩数组序列并返回压缩后的数组
                DeflateStream zipStream = new DeflateStream(ms, CompressionMode.Compress);
                zipStream.Write(bsrc, 0, bsrc.Length);
                zipStream.Close();
                zipStream.Dispose();
                return ms.ToArray();
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// 返回单个值的记录
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <param name="par"></param>
        /// <returns></returns>
        public object GetOne(string Bll, string Exc, object[] par)
        {
            if (Exc == "CheckUser")
            {
                if (Hownet.BLL.GetHDID.LinesCount != -1)
                {
                    if (!(ReaderCard.BasicTable.dt.Rows.Count < Hownet.BLL.GetHDID.LinesCount))
                        return false;
                }
            }
            object oneObj = new object();
            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            oneObj = method.Invoke(obj, par);
            return oneObj;
        }
        /// <summary>
        /// 执行一条无返回的SQL
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <param name="par"></param>
        public void ExecSql(string Bll, string Exc, object[] par)
        {
            //if (GetUserName() == string.Empty)
            //    return;
            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            method.Invoke(obj, par);
        }
        
        public void Updata(string Bll, string Exc, DataTable dt)
        {
            //if (Bll != "Hownet.BLL.Users")
            //{
            //    if (GetUserName() == string.Empty)
            //        return;
            //}
            Assembly ass;
            Type type;
            Object obj;
            object[] par = new object[] { dt };
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            method.Invoke(obj, par);

        }
        
        public int Add(string Bll, string Exc, DataTable dt)
        {
            //if (GetUserName() == string.Empty)
            //    return 0;
            Assembly ass;
            Type type;
            Object obj;
            object[] par = new object[] { dt };
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            return (int)(method.Invoke(obj, par));
        }


        /// <summary>
        /// 以流方式返回文件，如果是縮略圖，則先動態創建
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public Stream GetFile(String fileName)
        {
            //获得客户端信息
            OperationContext context = OperationContext.Current;
            MessageProperties messageProperties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpointProperty = (RemoteEndpointMessageProperty)messageProperties[RemoteEndpointMessageProperty.Name];
            //Console.WriteLine("客户端:" + endpointProperty.Address + "端口:" + endpointProperty.Port + "下载文件" + fileName);
            if (fileName.Length > 4 && fileName.Substring(0, 4).ToLower() == "mini")
            {
                if (BaseFileClass.GenThumbnail(uploadFolder + fileName.Substring(4)))
                {
                    Stream stream = new FileStream(uploadFolder + "tem.jpg", FileMode.Open, FileAccess.Read);
                    return stream;
                }
                else
                {
                    Stream ss = new MemoryStream();
                    return ss;
                }
            }
            else
            {
                Stream stream = new FileStream(uploadFolder + fileName, FileMode.Open, FileAccess.Read);
                return stream;
            }
        }
        public void CloseClient()
        {
            OperationContext context = OperationContext.Current;
            MessageProperties messageProperties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpointProperty = (RemoteEndpointMessageProperty)messageProperties[RemoteEndpointMessageProperty.Name];
            for (int i = 0; i < ReaderCard.BasicTable.dt.Rows.Count; i++)
            {
                if (ReaderCard.BasicTable.dt.Rows[i]["客户端"].ToString() == endpointProperty.Address)
                {
                    ReaderCard.BasicTable.dt.Rows.RemoveAt(i);
                    ReaderCard.BasicTable.dt.AcceptChanges();
                    break;
                }
            }
        }
        /// <summary>
        /// 验证登录用户是否已在登录中，有则返回登录电脑的IP
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        public string AddLog(string UserName)
        {
            OperationContext context = OperationContext.Current;
            MessageProperties messageProperties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpointProperty = (RemoteEndpointMessageProperty)messageProperties[RemoteEndpointMessageProperty.Name];
            bool t = false;
            string strIP = string.Empty;
            Guid g = Guid.NewGuid();
            for (int i = 0; i < ReaderCard.BasicTable.dt.Rows.Count; i++)
            {
                if (ReaderCard.BasicTable.dt.Rows[i]["用户名"].ToString().Trim() == UserName)
                {
                    DateTime tt = DateTime.Parse(ReaderCard.BasicTable.dt.Rows[i]["验证时间"].ToString());
                    if (tt.AddSeconds(90) > DateTime.Now)
                    {
                        t = true;
                        strIP = ReaderCard.BasicTable.dt.Rows[i]["客户端"].ToString();
                        ReaderCard.BasicTable.dt.Rows[i]["验证时间"] = DateTime.Now;
                    }
                    else
                    {
                        ReaderCard.BasicTable.dt.Rows.RemoveAt(i);
                        ReaderCard.BasicTable.dt.AcceptChanges();
                    }
                    break;
                }
            }
            if (!t)
            {
                DataRow dr = ReaderCard.BasicTable.dt.NewRow();
                dr["客户端"] = endpointProperty.Address;
                dr["用户名"] = UserName;
                dr["连接时间"] = DateTime.Now.ToLongTimeString();
                dr["验证时间"] = DateTime.Now;
                Hownet.BLL.Users bllU=new Hownet.BLL.Users();
                dr["用户ID"] = bllU.GetUserIDByName(UserName);
                dr["GUID"] = g;
                ReaderCard.BasicTable.dt.Rows.Add(dr);
                ReaderCard.BasicTable.dt.AcceptChanges();
            }
            t = false;
            if (strIP == string.Empty)
                return g.ToString() + "," + endpointProperty.Address + "," + DateTime.Now;
            else
                return strIP + "," + DateTime.Now;
        }
        public string GetUserName()
        {
            OperationContext context = OperationContext.Current;
            MessageProperties messageProperties = context.IncomingMessageProperties;
            RemoteEndpointMessageProperty endpointProperty = (RemoteEndpointMessageProperty)messageProperties[RemoteEndpointMessageProperty.Name];
            DataRow[] drs = ReaderCard.BasicTable.dt.Select("(客户端='" + endpointProperty.Address + "')");
            if (drs.Length > 0)
            {
                DateTime ddt = Convert.ToDateTime(drs[0]["验证时间"]).AddSeconds(120);
                if (Convert.ToDateTime(drs[0]["验证时间"]).AddSeconds(120) > DateTime.Now)
                {
                    return drs[0]["用户名"].ToString();
                }
                else
                {
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }
        /// <summary>
        /// 返回系统设置 
        /// </summary>
        /// <returns></returns>
        public byte[] GetSysTem()
        {
            return ds2Byte(BaseClass.dsSysTem);
        }
        public byte[] GetPU()
        {
            return ds2Byte(ReaderCard.BasicTable.dsPU);
        }
        public object Backup()
        {
            string Dir = Directory.GetCurrentDirectory() + @"\Backup\";
            if (!Directory.Exists(Dir))
                Directory.CreateDirectory(Dir);
            try
            {
                string str = Dir + @"Task_backup_" + DateTime.Now.ToString("yyyyMMddhhmmss");
                Hownet.BLL.SysTem bllST = new Hownet.BLL.SysTem();
                bllST.Backup(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public string CarID(string aaa)
        {
            try
            {
                ReaderCard.TreatmentCarID tc = new ReaderCard.TreatmentCarID(aaa);
                string aa = tc.Treatment();
                return aa;
            }
            catch
            {
                string[] ss = aaa.Split('+');
                return "2," + ss[0] + ",错误稍后重试";
            }
            // return "1";
        }
        public string PadCarID(string aaa)
        {
            try
            {
                ReaderCard.PadCarID tc = new ReaderCard.PadCarID(aaa);
                string aa = tc.Treatment();
                return aa;
            }
            catch
            {
                string[] ss = aaa.Split('+');
                return "2," + ss[0] + ",错误稍后重试";
            }
            // return "1";
        }
        public DateTime GetDateTime()
        {
            return DateTime.Now;
        }
        public void SetDataTable()
        {
            ReaderCard.BasicTable.dtAttRules = ReaderCard.BasicTable.bllOT.GetTypeList("考勤设置").Tables[0];
            ReaderCard.BasicTable.dtWTCard = ReaderCard.BasicTable.bllWTIDC.GetAllListByCardID(0).Tables[0];
            ReaderCard.BasicTable.dtEmployee = ReaderCard.BasicTable.bllME.GetView().Tables[0];
            ReaderCard.BasicTable.dtMain = ReaderCard.BasicTable.bllWTIDC.GetdtMain().Tables[0];
            ReaderCard.BasicTable.dtWorkTime = ReaderCard.BasicTable.bllOT.GetWorkTime().Tables[0];
            ReaderCard.BasicTable.dtCarReaderList = ReaderCard.BasicTable.bllCRL.GetAllList().Tables[0];
            ReaderCard.BasicTable.dtWorkType = ReaderCard.BasicTable.bllWType.GetAllList().Tables[0];
            ReaderCard.BasicTable.dsPU = ReaderCard.BasicTable.bllPU.GetAllList();
            ReaderCard.BasicTable.modST = ReaderCard.BasicTable.bllST.GetModel(ReaderCard.BasicTable.bllST.GetMaxId() - 1);
            ReaderCard.BasicTable.dtMain.Rows.Clear();
            ReaderCard.BasicTable.dtWTCard.Rows.Clear();
            ReaderCard.BasicTable.SetCate();
            DataTable dtKQ = ReaderCard.BasicTable.bllOT.GetList("(Name='刷上班卡后才能计件')").Tables[0];
            if (dtKQ.Rows.Count == 0)
            {
                DataRow dr = dtKQ.NewRow();
                dr["A"] = 1;
                dr["ID"] = 0;
                dr["Name"] = "刷上班卡后才能计件";
                dr["TypeID"] = -1;
                dr["Value"] = 0;
                dtKQ.Rows.Add(dr);
                dtKQ.Rows[0]["ID"] = ReaderCard.BasicTable.bllOT.AddByDt(dtKQ);
            }
            ReaderCard.BasicTable.IsCheckKQ = Convert.ToInt32(dtKQ.Rows[0]["Value"]) == 1;
        }

        public byte[] GetCardMain(int CarID)
        {
            DataRow[] drs = ReaderCard.BasicTable.dtWTCard.Select("(IDCardNo=" + CarID + ")");
            DataTable dt = ReaderCard.BasicTable.dtWTCard.Clone();
            for (int i = 0; i < drs.Length; i++)
            {
                dt.Rows.Add(drs[i].ItemArray);
            }
            dt.Columns.Remove("ID");
            dt.Columns.Remove("TicketID");
            dt.Columns.Remove("GroupBy");
            dt.Columns.Remove("TaskID");
            dt.Columns.Remove("IsEnd");
            dt.Columns.Remove("PWorkingInfoID");
            dt.Columns.Remove("WorkingID");
            dt.Columns.Remove("ColorID");
            dt.Columns.Remove("SizeID");
            dt.Columns.Remove("MaterielID");
            dt.Columns.Remove("EmployeeID");
            dt.Columns.Remove("InfoID");
            dt.Columns.Remove("FastTime");
            dt.Columns.Remove("WorkTypeID");
            dt.TableName = "dt";
            DataSet ds = new DataSet();
            ds.DataSetName = "ds";
            ds.Tables.Add(dt);
            return ds2Byte(ds);
        }
        public string GetBoxInfo(string TicketID)
        {
           // string BoxInfo = string.Empty;
            StringBuilder BoxInfo=new StringBuilder();
            int _ticketID = 0;
            int _group = 0;
            try
            {
                //if (TicketID.IndexOf(',') > -1)
                //{
                    //string[] ss = TicketID.Split(',');
                    _ticketID = Convert.ToInt32(TicketID.Substring(0, TicketID.Length - 1));
                    _group = Convert.ToInt32(TicketID.Substring(TicketID.Length - 1));
                //}
                //else
                //{
                //    _ticketID = Convert.ToInt32(TicketID);
                //}
            }
            catch
            {
                return BoxInfo.ToString();
            }
            DataTable dtt = new DataTable();
            dtt.TableName = "dt";
            dtt.Columns.Add("Remark", typeof(string));
            dtt.Columns.Add("WorkingName", typeof(string));
            dtt.Columns.Add("WTIID", typeof(int));
            dtt.Columns.Add("IsCanMove", typeof(bool));
            dtt.Columns.Add("dtNow", typeof(string));
            DataRow[] drs = ReaderCard.BasicTable.dtWTCard.Select("(TicketID=" + _ticketID + ") And (GroupBy=" + _group + ")");
            if (drs.Length == 0)
            {
                DataTable dttt = BasicTable.bllWTIDC.GetAllListByTicketID(_ticketID, _group).Tables[0];
                if (dttt.Rows.Count == 0)
                {
                    #region
                    Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();
                    DataSet ds = bllWT.GetBoxInfo(_ticketID, _group);
                    DataTable dt = ds.Tables[0];
                    if (dt.Rows.Count > 0)
                    {
                        BoxInfo .Append( "箱号：" );
                        BoxInfo.Append( dt.Rows[0]["BoxNum"].ToString());
                        BoxInfo.Append( "，款号：" );
                        BoxInfo.Append( dt.Rows[0]["MaterielName"].ToString());
                        if (dt.Rows[0]["BrandName"] != null && dt.Rows[0]["BrandName"].ToString() != string.Empty)
                        {
                            BoxInfo.Append( "， 商标：" );
                            BoxInfo.Append( dt.Rows[0]["BrandName"].ToString());
                        }
                        if (dt.Rows[0]["ColorName"] != null && dt.Rows[0]["ColorName"].ToString() != string.Empty)
                        {
                            BoxInfo .Append( "， 颜色：");
                            BoxInfo.Append( dt.Rows[0]["ColorName"].ToString());
                        }
                        if (dt.Rows[0]["SizeName"] != null && dt.Rows[0]["SizeName"].ToString() != string.Empty)
                        {
                            BoxInfo .Append( "， 尺码：" );
                            BoxInfo.Append( dt.Rows[0]["SizeName"].ToString());
                        }
                        if (dt.Rows[0]["ColorOneName"] != null && dt.Rows[0]["ColorOneName"].ToString() != string.Empty)
                        {
                            BoxInfo.Append("， 配色一：" );
                            BoxInfo.Append( dt.Rows[0]["ColorOneName"].ToString());
                        }
                        if (dt.Rows[0]["ColorTwoName"] != null && dt.Rows[0]["ColorTwoName"].ToString() != string.Empty)
                        {
                            BoxInfo .Append( "， 配色二：" );
                            BoxInfo.Append( dt.Rows[0]["ColorTwoName"].ToString());
                        }
                        BoxInfo .Append( "， 数量：" );
                        BoxInfo.Append( dt.Rows[0]["Amount"].ToString());
                        DataRow dr = dtt.NewRow();
                        dr[0] = BoxInfo;
                        string amount = "0";
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            dr[1] = "  " + ds.Tables[1].Rows[0][0].ToString();
                            dr[2] = ds.Tables[1].Rows[0][1];
                            dr[3] = ds.Tables[1].Rows[0][2];
                            amount = ds.Tables[1].Rows[0][3].ToString();
                        }
                        else
                        {
                            dr[1] = "  所有工序已完成";
                            dr[2] = 0;
                            dr[3] = false;
                        }
                        dr[4] = DateTime.Now.ToString();
                        dtt.Rows.Add(dr);
                        BoxInfo.Append("й");
                        BoxInfo.Append(dr[1].ToString() + " " + amount);
                        BoxInfo.Append("й");
                        BoxInfo.Append(dr[2].ToString());
                        BoxInfo.Append("й");
                        BoxInfo.Append(dr[3].ToString());
                        BoxInfo.Append("й");
                        BoxInfo.Append(DateTime.Now.ToLongTimeString());
                        return BoxInfo.ToString();
                    }
                    else
                    {
                        return BoxInfo.ToString();
                    }
                    #endregion
                }
                else
                {
                    for (int i = 0; i < dttt.Rows.Count; i++)
                    {
                        ReaderCard.BasicTable.dtWTCard.Rows.Add(dttt.Rows[i].ItemArray);
                    }
                    drs = ReaderCard.BasicTable.dtWTCard.Select("(TicketID=" + _ticketID + ") And (GroupBy=" + _group + ")");
                }
                 
            }
            if (drs.Length > 0)
            {
                BoxInfo.Append("箱号：");
                BoxInfo.Append(drs[0]["BoxNum"].ToString());
                BoxInfo.Append("，款号：");
                BoxInfo.Append(drs[0]["MaterielName"].ToString());
               // BoxInfo = "箱号：" + drs[0]["BoxNum"].ToString() + "，款号：" + drs[0]["MaterielName"].ToString();
                //if (drs[0]["BrandName"] != null && drs[0]["BrandName"].ToString() != string.Empty)
                //{
                //    BoxInfo += "， 商标：" + drs[0]["BrandName"].ToString();
                //}
                if (drs[0]["ColorName"] != null && drs[0]["ColorName"].ToString() != string.Empty)
                {
                    BoxInfo.Append("， 颜色：");
                    BoxInfo.Append(drs[0]["ColorName"].ToString());
                }
                if (drs[0]["SizeName"] != null && drs[0]["SizeName"].ToString() != string.Empty)
                {
                    BoxInfo.Append("， 尺码：");
                    BoxInfo.Append(drs[0]["SizeName"].ToString());
                }
                //if (drs[0]["ColorOneName"] != null && drs[0]["ColorOneName"].ToString() != string.Empty)
                //{
                //    BoxInfo += "， 配色一：" + drs[0]["ColorOneName"].ToString();
                //}
                //if (drs[0]["ColorTwoName"] != null && drs[0]["ColorTwoName"].ToString() != string.Empty)
                //{
                //    BoxInfo += "， 配色二：" + drs[0]["ColorTwoName"].ToString();
                //}
                BoxInfo.Append("， 数量：");
                BoxInfo.Append(drs[0]["Amount"].ToString());
                DataRow dr = dtt.NewRow();
                dr[0] = BoxInfo;
                DataRow[] ddrs = ReaderCard.BasicTable.dtWTCard.Select("(TicketID=" + _ticketID + ") And (GroupBy=" + _group + ") And (EmployeeID=0)", "Orders");
                if (ddrs.Length > 0)
                {
                    dr[1] = ddrs[0]["WorkingName"].ToString();
                    dr[2] = ddrs[0]["InfoID"];
                    dr[3] = ddrs[0]["IsCanMove"];

                }
                else
                {
                    dr[1] = "  所有工序已完成";
                    dr[2] = 0;
                    dr[3] = false;
                }
                dr[4] = DateTime.Now.ToString();
                dtt.Rows.Add(dr);
                BoxInfo.Append("й");
                BoxInfo.Append(dr[1].ToString());// + " " + ddrs[0]["Amount"].ToString());
                BoxInfo.Append("й");
                BoxInfo.Append(dr[2].ToString());
                BoxInfo.Append("й");
                BoxInfo.Append(dr[3].ToString());
                BoxInfo.Append("й");
                BoxInfo.Append(DateTime.Now.ToLongTimeString());
                return BoxInfo.ToString(); ;
            }
            else
            {
                return BoxInfo.ToString(); ;
            }
        }
        public string GetTicketInfo(string TicketID)
        {
            string BoxInfo = string.Empty;
            int _ticketID = 0;
            int _group = 0;
            try
            {

                _ticketID = Convert.ToInt32(TicketID.Substring(0, TicketID.Length - 1));
                _group = Convert.ToInt32(TicketID.Substring(TicketID.Length - 1));
                //if (TicketID.IndexOf(',') > -1)
                //{
                //    //  string[] ss = TicketID.Split(',');
                //    _ticketID = Convert.ToInt32(TicketID.Substring(0, TicketID.Length - 1));
                //    _group = Convert.ToInt32(TicketID.Substring(TicketID.Length - 1));
                //}
                //else
                //{
                //    _ticketID = Convert.ToInt32(TicketID);
                //}
            }
            catch
            {
                return BoxInfo;
            }
            Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();
            DataTable dt = bllWT.GetTickInfo(_ticketID).Tables[0];
            if (dt.Rows.Count > 0)
                return Table2String(dt);
            else
                return string.Empty;
        }
        public string EmpAddWork(string TicketInfoID, string EmpID, string TicketTime)
        {
            if (TicketInfoID == string.Empty || TicketTime == string.Empty)
            {
                return "工序卡刷卡不正确";
            }
            if (Convert.ToDateTime(TicketTime).AddSeconds(30) < DateTime.Now)
            {
                return "刷卡超时";
            }
            if (EmpID == string.Empty)
            {
                return string.Empty;
            }
            try
            {
                Hownet.BLL.MiniEmp bllME = new Hownet.BLL.MiniEmp();
                Hownet.Model.MiniEmp modME = bllME.GetModel(Convert.ToInt32(EmpID));
                if (modME == null)
                {
                    return "员工不正确";
                }
                if (Convert.ToDateTime(modME.DimDate) > Convert.ToDateTime("1900-1-1"))
                {
                    return "员工已离职！";
                }
                Hownet.BLL.WorkTicketInfo bllWTI = new Hownet.BLL.WorkTicketInfo();
                Hownet.Model.WorkTicketInfo modWTI = bllWTI.GetModel(Convert.ToInt32(TicketInfoID));
                if (modWTI == null)
                {
                    return "工序卡刷卡不正确";
                }
                if (modWTI.EmployeeID > 0)
                {
                    return "该工序已被完成";
                }
                Hownet.BLL.Working bllW = new Hownet.BLL.Working();
                Hownet.Model.Working modW = bllW.GetModel(modWTI.WorkingID);
                if (!CheckWorkType(modW.WorkTypeID.ToString(), modME.WorkTypeID))
                {
                    return "工种不匹配";
                }
                DateTime dtNow = DateTime.Now;
                Hownet.BLL.ProductTaskMain bllPTM = new Hownet.BLL.ProductTaskMain();
                Hownet.Model.ProductTaskMain modPTM = bllPTM.GetModel(modWTI.TaskID);
                bllWTI.GetBarBack(modWTI.ID, modME.ID, dtNow, 1);
                bllWTI.AddPayInfo(modPTM.MaterielID, modWTI.ID, modPTM.DateTime.ToString("yyyyMMdd") + modPTM.Num.ToString().PadLeft(3, '0'));
                DataRow[] drs = ReaderCard.BasicTable.dtWTCard.Select("(InfoID=" + TicketInfoID + ")");
                if (drs.Length == 1)
                {
                    drs[0]["EmployeeID"] = modME.ID;
                    drs[0]["MiniEmpName"] = modME.Name;
                    drs[0]["DateTime"] = DateTime.Now;
                }

                if (modWTI.WorkingID == BasicTable.BackDepotWorkingID)
                {
                    Hownet.BLL.WorkTicket bllWT = new Hownet.BLL.WorkTicket();
                    Hownet.Model.WorkTicket modWT = bllWT.GetModel(modWTI.MainID);
                    if (modWT.P2DInfoID == 0)
                    {
                        Hownet.BLL.AmountInfo bllAI = new Hownet.BLL.AmountInfo();
                        List<Hownet.Model.AmountInfo> liAI = bllAI.GetModelList("(MainID=" + modWT.TaskID + ") And (TableTypeID=1) And (MListID=" + modWT.MListID + ")");
                        if (liAI.Count > 0)
                        {
                            liAI[0].NotAmount -= modWT.Amount;
                            bllAI.Update(liAI[0]);
                        }
                    }

                }
                return "今天总产量：" + bllWTI.CountAmount(modME.ID, dtNow, ReaderCard.BasicTable.IsShowMoney).ToString();
            }
            catch
            {
                return "对不起，出现错误！";
            }
            //return string.Empty;
        }
        public string Ordering(string EID)
        {
            Services.Services sv = new Services.Services();
            return sv.Ordering(EID);
        }
        public string GetEmpWorkingList(int EmpID,DateTime dt1,DateTime dt2)
        {
            Hownet.BLL.WorkTicketInfo bllWTI = new Hownet.BLL.WorkTicketInfo();
            string EmpAmount = bllWTI.GetEmpSum(EmpID, dt1,dt2, false);
            Hownet.BLL.MiniEmp bllME = new Hownet.BLL.MiniEmp();
            Hownet.Model.MiniEmp modME = bllME.GetModel(EmpID);
            DataTable dt = bllME.GetSumAmountByID(Convert.ToInt32(modME.IDCardID), dt1, dt2).Tables[0];


            return EmpAmount + "ю" + Table2String(dt);
        }

        public string GetStringData(string Bll, string Exc, object[] par)
        {
            DataSet ds = new DataSet();
            Assembly ass;
            Type type;
            Object obj;
            ass = Assembly.Load("Hownet.BLL");
            type = ass.GetType(Bll);
            MethodInfo method = type.GetMethod(Exc);
            obj = ass.CreateInstance(Bll);
            ds = (DataSet)method.Invoke(obj, par);
            return Table2String(ds.Tables[0]);
        }
        public DateTime GetLastBackupTime()
        {
            return Form1.GetLastBackupTime();
        }
        private bool CheckWorkType(string WorkTypeID, string wt)
        {
            bool t = false;

            if (wt.IndexOf(',') > -1)
            {
                string[] ss = wt.Split(',');
                for (int i = 0; i < ss.Length; i++)
                {
                    if (WorkTypeID == ss[i])
                    {
                        return true;
                    }
                }
            }
            else
            {
                if (WorkTypeID == wt)
                    return true;
            }
            return t;
        }
        private string Table2String(DataTable dt)
        {
            StringBuilder strDS = new StringBuilder();
            //for (int i = 0; i < dt.Columns.Count; i++)
            //{
            //    strDS.Append(dt.Columns[i].ColumnName);
            //    strDS.Append("ю");
            //    strDS.Append(dt.Columns[i].DataType.ToString());
            //    strDS.Append("ж");//列字段
            //}
            //strDS.Append("й");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (dt.Rows[i][j] == null || dt.Rows[i][j] == DBNull.Value)
                        strDS.Append(" ");
                    else
                        strDS.Append(dt.Rows[i][j].ToString());
                    strDS.Append("ж");
                }
                strDS.Append("й");
            }
            return strDS.ToString();
        }
    }
}
