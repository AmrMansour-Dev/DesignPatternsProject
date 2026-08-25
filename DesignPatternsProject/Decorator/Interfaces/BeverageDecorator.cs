using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator.Interfaces
{
    internal abstract class BeverageDecorator : IBeverage
    {
        protected IBeverage beverage;

        protected BeverageDecorator(IBeverage beverage)
        {
            this.beverage = beverage;
        }
        public abstract double Cost();

        public abstract string Description();
    }
}
