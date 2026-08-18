using DesignPatternsProject.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Bridge
{
    internal class WhatsappSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Whatsapp Sending : {message}");
        }
    }
}
