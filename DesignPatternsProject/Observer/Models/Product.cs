using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer.Models
{
    internal class Product
    {
        public string Name { get; private set; }

        public double Price { get; private set; }

        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
