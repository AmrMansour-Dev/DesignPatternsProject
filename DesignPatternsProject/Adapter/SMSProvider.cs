using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Adapter
{
    internal class SMSProvider
    {
        public void SendSms(string Message, string PhoneNumber)
        {
            Console.WriteLine($"{Message} sent to {PhoneNumber}");
        }
    }
}
