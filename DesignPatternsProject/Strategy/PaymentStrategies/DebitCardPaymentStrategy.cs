using DesignPatternsProject.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Strategy.PaymentStrategies
{
    internal class DebitCardPaymentStrategy : IPaymentStrategy
    {
        public void PaymentProccessing(double price)
        {
            Console.WriteLine($"Payment is proccessing with Debit CARD for {price}");
            Console.WriteLine("Payment Done With Debit CARD..");
        }
    }
}
