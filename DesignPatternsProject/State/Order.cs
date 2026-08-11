using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State
{
    internal class Order
    {
        public string Name { get; private set; }

        public double Price { get; private set; }

        public Order(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }
    }
}
