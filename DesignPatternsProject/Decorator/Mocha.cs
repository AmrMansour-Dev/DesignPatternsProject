using DesignPatternsProject.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    internal class Mocha : BeverageDecorator
    {
        public Mocha(IBeverage beverage) : base(beverage)
        {

        }
        public override double Cost()
        {
            return beverage.Cost() + 12;
        }

        public override string Description()
        {
            return beverage.Description() + ", Mocha";
        }
    }
}
