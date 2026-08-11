using DesignPatternsProject.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State
{
    internal class CancelledOrderState : IOrderState
    {
        OrderManagement orderManagement;

        public CancelledOrderState(OrderManagement orderManagement)
        {
            this.orderManagement = orderManagement;
        }
        public void CancelOrder()
        {
            Console.WriteLine("order is cancelled already");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("can not deliver the order at current state");
        }

        public void ProcessOrder()
        {
            Console.WriteLine("can not process the order at current state");
        }

        public void ShipOrder()
        {
            Console.WriteLine("can not ship the order at current state");
        }
    }
}
