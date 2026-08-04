using DesignPatternsProject.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Strategy.PaymentStrategies
{
    internal class VisaPaymentStrategy : IPaymentStrategy
    {
        public void PaymentProccessing(double price)
        {
            Console.WriteLine($"Payment is proccessing with VISA for {price} L.E");
            Console.WriteLine("Payment Done With VISA..");
        }
    }
}
