using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Collections;
using System.Data;

namespace Service
{
    // SessionMode.Required  允许Session会话。双工协定时的回调协定类型为IChatCallback接口
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(IChatCallback))]
    public interface IChatService
    {
        [OperationContract(IsOneWay = false, IsInitiating = true, IsTerminating = false)]//----->IsOneWay = false等待服务器完成对方法处理;IsInitiating = true启动Session会话,IsTerminating = false 设置服务器发送回复后不关闭会话
        string[] Join(string name);//用户加入

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void Say(string msg);//群聊信息

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void Whisper(string to, string msg);//私聊信息

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
        void Leave();//用户加入
    }
    /// <summary>
    /// 双向通信的回调接口
    /// </summary>
    interface IChatCallback
    {
        [OperationContract(IsOneWay = true)]
        void Receive(string senderName, string message);

        [OperationContract(IsOneWay = true)]
        void ReceiveWhisper(string senderName, string message);

        [OperationContract(IsOneWay = true)]
        void UserEnter(string name);

        [OperationContract(IsOneWay = true)]
        void UserLeave(string name);
    }

    /// <summary>
    /// 设定消息的类型
    /// </summary>
    public enum MessageType { Receive, UserEnter, UserLeave, ReceiveWhisper };
    /// <summary>
    /// 定义一个本例的事件消息类. 创建包含有关事件的其他有用的信息的变量，只要派生自EventArgs即可。
    /// </summary>
    public class ChatEventArgs : EventArgs
    {
        public MessageType msgType;
        public string name;
        public string message;
    }
}
