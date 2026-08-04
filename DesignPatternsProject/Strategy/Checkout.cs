using DesignPatternsProject.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Strategy
{
    internal class Checkout
    {
        public IPaymentStrategy paymentStrategy {  get; private set; }

        public Checkout(IPaymentStrategy paymentStrategy)
        {
            this.paymentStrategy = paymentStrategy;
        }
        public void PaymentProcessing(double price)
        {
            paymentStrategy.PaymentProccessing(price);
        }
    }
}
