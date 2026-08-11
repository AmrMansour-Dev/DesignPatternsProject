using DesignPatternsProject.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State
{
    internal class NewOrderState : IOrderState
    {
        OrderManagement ordermanagement;

        public NewOrderState(OrderManagement ordermanagement)
        {
            this.ordermanagement = ordermanagement;
        }
        public void CancelOrder()
        {
            Console.WriteLine("Order is cancelled Now...");
            ordermanagement.ChangeState(new CancelledOrderState(ordermanagement));
        }

        public void DeliverOrder()
        {
            Console.WriteLine("can not deliver order at the current state");
        }

        public void ProcessOrder()
        {
            Console.WriteLine("Order is Processing Now...");
            ordermanagement.ChangeState(new ProcessedOrderState(ordermanagement));
        }

        public void ShipOrder()
        {
            Console.WriteLine("can not ship order at the current state");
        }
    }
}
