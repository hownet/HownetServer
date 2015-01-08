using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Service
{
    public interface IChatCallBack
    {
        [OperationContract(IsOneWay = true)]
        void Receive(string name, string msg);

        [OperationContract(IsOneWay = true)]
        void ReceiveWhisper(string name, string msg);

        [OperationContract(IsOneWay = true)]
        void UserEnter(string name);

        [OperationContract(IsOneWay = true)]
        void UserLeave(string name);

        [OperationContract(IsOneWay = true)]
        void LoadUsers(List<string> chaters);
    }
}
