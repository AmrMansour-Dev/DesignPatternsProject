using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Facade
{
    internal class Client
    {
        //Before Facade Pattern the client already know all services and complexity of making an order !!

        //InventoryService inventoryService = new InventoryService();
        //PaymentService paymentService = new PaymentService();
        //OrderService orderService = new OrderService();
        //ShippingService shippingService = new ShippingService();


        public void BuyProduct(int Productid, decimal Amount)
        {
            CheckoutFacade CheckoutFacade = new CheckoutFacade();

            CheckoutFacade.Checkout(Productid, Amount);
        }
    }
}
