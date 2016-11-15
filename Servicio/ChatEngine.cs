using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Servicio
{
    public class ChatEngine
    {
        /// <summary>
        /// Almacena los usuarios connectados.
        /// </summary>
        private List<ChatUser> connectedUsers = new List<ChatUser>();
        /// <summary>
        /// Diccionario que guarda los mensajes a entregar.
        /// </summary>
        private Dictionary<string, List<ChatMessage>> incomingMessages = new Dictionary<string, List<ChatMessage>>();

        public List<ChatUser> ConnectedUsers
        {
            get
            {
                return connectedUsers;
            }

            set
            {
                connectedUsers = value;
            }
        }

        /// <summary>
        /// Agregar un nuevo usuario al Chat.
        /// </summary>
        /// <param name="newUser"></param>
        /// <returns></returns>
        public ChatUser AddNewChatUser(ChatUser newUser)
        {
            bool existe = ConnectedUsers.Exists(x => x.UserName == newUser.UserName);

            if (!existe)
            {
                this.ConnectedUsers.Add(newUser);
                incomingMessages.Add(newUser.UserName, new List<ChatMessage>()
                {
                    new ChatMessage() {
                        User = newUser,
                        Message = "Bienvenido " + newUser.UserName.ToString(),
                        Date = DateTime.Now
                    }
                });

                Console.WriteLine("\n New user connected " + newUser.UserName);
                return newUser;
            }
            else
            {
                return null;
            }
        }
    }
}