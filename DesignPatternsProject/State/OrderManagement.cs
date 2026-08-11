using DesignPatternsProject.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State
{
    internal class OrderManagement
    {
        private Order _order;

        private IOrderState _orderState;

        public OrderManagement(Order order)
        {
           _order = order;
           _orderState = new NewOrderState(this);
        }

        public void ChangeState(IOrderState changedorderState)
        {
            _orderState = changedorderState;
        }
        public void ProcessOrder()
        {
            _orderState.ProcessOrder();
        }

        public void ShipOrder()
        {
            _orderState.ShipOrder();
        }

        public void DeliverOrder()
        {
            _orderState.DeliverOrder();
        }

        public void CancelOrder()
        {
            _orderState.CancelOrder();
        }
    }
}
