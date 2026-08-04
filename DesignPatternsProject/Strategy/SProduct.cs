using DesignPatternsProject.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Strategy
{
    internal class SProduct
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public IPricingStrategy pricingStrategy { get; private set; }
        public SProduct(string name, double price, IPricingStrategy pricingStrategy)
        {
            this.Name = name;
            this.Price = price;
            this.pricingStrategy = pricingStrategy;
        }
        public double CalculatePrice()
        {
            return pricingStrategy.CalculatePrice(Price);
        }
    }
}
