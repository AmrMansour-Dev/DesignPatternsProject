using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Mediator.Interfaces
{
    internal interface IChatMediator
    {
        void AddUser(User NewChatUser);
        void SendMessage(string Message, User Sender);
    }
}
