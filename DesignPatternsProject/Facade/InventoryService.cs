using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Facade
{
    internal class InventoryService
    {
        public bool CheckStock(int productid)
        {
            Console.WriteLine("Checking Stock...");

            return true;
        }
    }
}
