using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.ServiceModel;
using MessageContract;
using System.IO;
using System.Data;

namespace Service
{
    [ServiceContract]
    // [ServiceContract(CallbackContract = typeof(IChatCallBack), SessionMode = SessionMode.Allowed)]
    public interface IFileTransportService
    {
        //[OperationContract(IsInitiating = true)]
        //bool Join(string name);
        //[OperationContract]
        //void Leave(string name);
        //[OperationContract]
        //void Say(string name, string msg);
        //[OperationContract]
        //void Whisper(string chater, string chatermate, string msg);
        //[OperationContract]
        //void LoadChaters();


        [OperationContract(Action = "UploadFile", IsOneWay = true)]
        void UploadFile(FileUploadMessage request);

        [OperationContract]
        List<String> GetFileList();

        [OperationContract]
        Stream GetFile(String fileName);


        [OperationContract(Action = "DelFile", IsOneWay = true)]
        void DelFile(string FileName);

        /// <summary>
        /// 返回数据表
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <returns></returns>
        [OperationContract]
        DataSet GetList(string Bll, string Exc, object[] par);

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="storedProcName">存储过程名</param>
        /// <param name="parameters">存储过程参数</param>
        /// <param name="tableName">DataSet结果中的表名</param>
        /// <returns>DataSet</returns>
        [OperationContract]
        byte[] GetDSForPrcoce(string storedProcName, object[] parameters, string tableName);

        /// <summary>
        /// 执行一条计算查询结果语句，返回查询结果（object）。
        /// </summary>
        /// <param name="SQLString">计算查询结果语句</param>
        /// <returns>查询结果（object）</returns>
        [OperationContract]
        object GetSingle(string SQLString);

        /// <summary>
        /// 返回序列化后的DataSet
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <param name="par"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] getZipData(string Bll, string Exc, object[] par);

        /// <summary>
        /// 通过字符串格式化的。
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <param name="par"></param>
        /// <returns></returns>
        [OperationContract]
        byte[] GetJson(string Bll, string Exc, object[] par);


        [OperationContract]
        byte[] GetBySql(string Sql);

        [OperationContract]
        byte[] GetSqlByByte(string Sql);

        [OperationContract]
        byte[] GetStringList(string Bll, string Exc, object[] par);
        /// <summary>
        /// 返回单个值
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <param name="par"></param>
        /// <returns></returns>
        [OperationContract]
        object GetOne(string Bll, string Exc, object[] par);

        [OperationContract]
        void ExecSql(string Bll, string Exc, object[] par);

        [OperationContract]
        void Updata(string Bll, string Exc, DataTable dt);

        [OperationContract]
        int Add(string Bll, string Exc, DataTable dt);

        [OperationContract]
        void CloseClient();

        /// <summary>
        /// 返回系统设置
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        byte[] GetSysTem();
        [OperationContract]
        byte[] GetPU();

        [OperationContract]
        object Backup();
        [OperationContract]
        string AddLog(string UserName);
        [OperationContract]
        string GetUserName();

        [OperationContract]
        string CarID(string aaa);

        [OperationContract]
        string PadCarID(string aaa);

        [OperationContract]
        void SetDataTable();

        [OperationContract]
        DateTime GetDateTime();

        [OperationContract]
        byte[] GetCardMain(int CarID);

        [OperationContract]
        string GetBoxInfo(string TicketID);
        [OperationContract]
        string GetTicketInfo(string TicketID);

        [OperationContract]
        string EmpAddWork(string TicketInfoID, string EmpID, string TicketTime);

        [OperationContract]
        string Ordering(string EID);

        [OperationContract]
        string GetEmpWorkingList(int EmpID, DateTime dt1,DateTime dt2);

        [OperationContract]
        string GetStringData(string Bll, string Exc, object[] par);

        [OperationContract]
        DateTime GetLastBackupTime();
    }
}
