using DesignPatternsProject.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Mediator
{
    internal class ChatMediator : IChatMediator
    {
        List<User> ChatUsers = new List<User>();
        public void AddUser(User NewChatUser)
        {
            ChatUsers.Add(NewChatUser);
        }

        public void SendMessage(string Message, User FromUser)
        {
            foreach (var user in ChatUsers)
            {
                if(user != FromUser)
                {
                    user.ReceiveMessage(Message, FromUser);
                }
            }
        }


    }
}
