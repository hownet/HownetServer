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
   // [ServiceContract]
    [ServiceContract(CallbackContract = typeof(IChatCallBack), SessionMode = SessionMode.Allowed)]
    public interface IMateriel
    {


        /// <summary>
        /// 返回数据表
        /// </summary>
        /// <param name="Bll"></param>
        /// <param name="Exc"></param>
        /// <returns></returns>
        [OperationContract]
        DataSet GetList(string Bll);

    }
}
