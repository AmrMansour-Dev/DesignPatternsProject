using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Bridge.Interfaces
{
    internal abstract class Notification
    {
        protected INotificationSender notificationSender;
        protected Notification(INotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        public abstract void Send(string Message);
    }
}
