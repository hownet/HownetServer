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


namespace Service
{

    //[ServiceBehavior(
    //AutomaticSessionShutdown = false,
    //ConcurrencyMode = ConcurrencyMode.Multiple,
    //InstanceContextMode = InstanceContextMode.PerSession,
    //IncludeExceptionDetailInFaults = true,
    //UseSynchronizationContext = true,AutomaticSessionShutdown=false,
    //ValidateMustUnderstand = true)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Materiel : IMateriel
    {
        private static Dictionary<string, IChatCallBack> chaters = new Dictionary<string, IChatCallBack>();
        private Int32 bufferLen = 4096;// Int32.Parse(ConfigurationSettings.AppSettings["BufferSize"]);
        //  private String uploadFolder = ServiceForm.Dir + @"\UploadFile\";
        public static readonly String uploadFolder = ServiceForm.Dir + @"\UploadFile\";
        Hownet.BLL.Materiel bllMat = new Hownet.BLL.Materiel();
        public DataSet GetList(string strWhere)
        {
            if (strWhere.Length > 0)
                return bllMat.GetList(strWhere);
            else
                return bllMat.GetAllList();
        }

    }
}
