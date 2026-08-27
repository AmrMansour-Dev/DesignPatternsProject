using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Facade
{
    internal class CheckoutFacade
    {
        InventoryService inventoryService;
        PaymentService paymentService;
        OrderService orderService;
        ShippingService shippingService;

        public CheckoutFacade()
        {
            this.shippingService = new ShippingService();
            this.paymentService = new PaymentService();
            this.inventoryService = new InventoryService();
            this.orderService = new OrderService();
        }

        public void Checkout(int Productid, decimal Amount)
        {
            bool isavailable = inventoryService.CheckStock(Productid);

            if (!isavailable)
            {
                Console.WriteLine("Product is out of stock!");
                return;
            }

            bool paymentproccessed = paymentService.ProcessPayment(Amount);

            if (!paymentproccessed)
            {
                Console.WriteLine("Payment failed");
                return;
            }

            int orderid = orderService.CreateOrder(Productid);

            shippingService.ShipOrder(orderid);

            Console.WriteLine("Order is placed successfully :)");
        }
    }
}
