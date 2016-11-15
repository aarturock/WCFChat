using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace Servicio
{
    [ServiceContract]
    public interface IChatService
    {
        [OperationContract]
        ChatUser ClientConnect(string userName);

        [OperationContract]
        List<ChatUser> GetAllUsers();

        [OperationContract]
        void SendMessage(ChatMessage newMessage);

        [OperationContract]
        List<ChatMessage> GetNewMessages(ChatUser user);

        [OperationContract]
        void RemoveUser(ChatUser user);
    }

    [DataContract]
    public class ChatMessage
    {
        private ChatUser user;
        private string message;
        private DateTime date;

        [DataMember]
        public ChatUser User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
            }
        }

        [DataMember]
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        [DataMember]
        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
    }

    [DataContract]
    public class ChatUser
    {
        private string userName, ipAddress, hostName;

        [DataMember]
        public string HostName
        {
            get
            {
                return hostName;
            }

            set
            {
                hostName = value;
            }
        }
        
        [DataMember]
        public string IpAddress
        {
            get
            {
                return ipAddress;
            }

            set
            {
                ipAddress = value;
            }
        }

        [DataMember]
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }
    }
}
