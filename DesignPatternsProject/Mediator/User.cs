using DesignPatternsProject.Mediator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Mediator
{
    internal class User
    {
        public string Name { get;}

        IChatMediator ChatGroup { get;}
        public User(string Name, IChatMediator ChatGroup)
        {
            this.Name = Name;
            this.ChatGroup = ChatGroup;
        }

        public void SendMessage(string message)
        {
            ChatGroup.SendMessage(message,this);
        }

        public void ReceiveMessage(string message, User FromUser)
        {
            Console.WriteLine($"{Name} Received a message : {message}. Sent By {FromUser.Name}");
        }
    }
}
