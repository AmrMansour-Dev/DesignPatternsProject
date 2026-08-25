using DesignPatternsProject.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    internal class Sugar : BeverageDecorator
    {
        public Sugar(IBeverage beverage) : base(beverage) 
        {
            
        }
        public override double Cost()
        {
            return beverage.Cost() + 10;
        }

        public override string Description()
        {
            return beverage.Description() + ", Sugar";
        }
    }
}
