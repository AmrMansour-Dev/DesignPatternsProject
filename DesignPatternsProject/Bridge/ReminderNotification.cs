using DesignPatternsProject.Bridge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Bridge
{
    internal class ReminderNotification : Notification
    {
        public ReminderNotification(INotificationSender notificationSender) : base(notificationSender)
        {
            
        }
        public override void Send(string Message)
        {
            notificationSender.Send($"Reminder :{Message}");
        }
    }
}
