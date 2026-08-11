using DesignPatternsProject.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State
{
    internal class ShippedOrderState : IOrderState
    {
        OrderManagement orderManagement;
        public ShippedOrderState(OrderManagement orderManagement)
        {
            this.orderManagement = orderManagement;
        }
        public void CancelOrder()
        {
            Console.WriteLine("can not cancel order at the current state");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Order is Delivered...");
            orderManagement.ChangeState(new DeliveredOrderState(orderManagement));
        }

        public void ProcessOrder()
        {
            Console.WriteLine("order has been processed already");
        }

        public void ShipOrder()
        {
            Console.WriteLine("order has been shipped already");
        }
    }
}
