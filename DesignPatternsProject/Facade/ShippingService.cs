using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Facade
{
    internal class ShippingService
    {
        public void ShipOrder(int orderid)
        {
            Console.WriteLine($"Shipping Order with id : {orderid}");
        }
    }
}
