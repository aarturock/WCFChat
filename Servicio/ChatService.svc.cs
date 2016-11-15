using System;
using System.Collections.Generic;
using System.Linq;

namespace Servicio
{

    public class ChatService : IChatService
    {
        private ChatEngine chatEngine;


        public ChatService()
        {
            chatEngine = new ChatEngine();
        }
        /// <summary>
        /// Función que conecta un usuario al chat.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public ChatUser ClientConnect(string userName)
        {
            return chatEngine.AddNewChatUser(new ChatUser() { UserName = userName});
        }

        /// <summary>
        /// Función que retorna el listado de Usuarios Conectados.
        /// </summary>
        /// <returns></returns>
        public List<ChatUser> GetAllUsers()
        {
            return chatEngine.ConnectedUsers.ToList();
        }

    
        public List<ChatMessage> GetNewMessages(ChatUser user)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(ChatUser user)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(ChatMessage newMessage)
        {
            throw new NotImplementedException();
        }
    }
}
