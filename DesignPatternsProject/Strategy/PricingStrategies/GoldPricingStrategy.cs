using DesignPatternsProject.Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Strategy.PricingStrategies
{
    internal class GoldPricingStrategy : IPricingStrategy
    {
        public double CalculatePrice(double price)
        {
            return price * 0.9;
        }
    }
}
