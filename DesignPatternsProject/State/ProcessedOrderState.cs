using DesignPatternsProject.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State
{
    internal class ProcessedOrderState : IOrderState
    {
        OrderManagement ordermanagement;

        public ProcessedOrderState(OrderManagement ordermanagement)
        {
            this.ordermanagement = ordermanagement;
        }
        public void CancelOrder()
        {
            Console.WriteLine("Order has been cancelled");
        }

        public void DeliverOrder()
        {
            Console.WriteLine("Can not Deliver order at the current state");
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Order is already Processed");
        }

        public void ShipOrder()
        {
            Console.WriteLine("Order is being Shipped...");
            ordermanagement.ChangeState(new ShippedOrderState(ordermanagement));
        }
    }
}
