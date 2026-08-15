using DesignPatternsProject.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Adapter
{
    internal class SMSAdapter : INotificationService
    {
        SMSProvider smsProvider;

        public SMSAdapter(SMSProvider sMSProvider)
        {
            this.smsProvider = sMSProvider;
        }
        public void Send(string Message)
        {
            smsProvider.SendSms(Message, "01114959644");
        }
    }
}
