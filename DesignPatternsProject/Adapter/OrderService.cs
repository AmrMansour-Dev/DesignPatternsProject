using DesignPatternsProject.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Adapter
{
    internal class OrderService
    {
        INotificationService notificationService;

        public OrderService(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            Console.WriteLine("Placing Order...");

            notificationService.Send("The Order Has been Placed.");
        }
    }
}
