using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Strategy.Interfaces
{
    internal interface IPricingStrategy
    {
        public double CalculatePrice(double price);
    }
}
