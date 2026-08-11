using DesignPatternsProject.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State
{
    internal class DeliveredOrderState : IOrderState
    {
        OrderManagement orderManagement;

        public DeliveredOrderState(OrderManagement orderManagement)
        {
            this.orderManagement = orderManagement;
        }
        public void CancelOrder()
        {
            Console.WriteLine("can not cancel order at current state");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("order is already delivered");
        }

        public void ProcessOrder()
        {
            Console.WriteLine("order is already processed");
        }

        public void ShipOrder()
        {
            Console.WriteLine("order is already shipped");
        }
    }
}
