using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;


namespace Contracts
{
    [ServiceContract]
    public interface IDataService
    {
        [OperationContract]
        void  Hello();

        [OperationContract]
        string CheckUser(string UserName, string Pass);

        [OperationContract]
        string GetJson(string Bll, string Exc, object[] par);

        [OperationContract]
        string GetImage(string Imagefilename);

        [OperationContract]
        string GetBoxInfo(string TicketID);

        [OperationContract]
        string GetTicketInfo(string TicketID);

        [OperationContract]
        string EmpAddWork(string TicketInfoID, string EmpID, string TicketTime);

        [OperationContract]
        string Ordering(string EID);

        [OperationContract]
        string EmpAtt(string EID);

        [OperationContract]
        string GetName(string MaterielID);
    }
}
