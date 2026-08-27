using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Facade
{
    internal class OrderService
    {
        public int CreateOrder(int Productid)
        {
            Console.WriteLine($"Creating Order for {Productid} ...");

            return 1001;
        }
    }
}
