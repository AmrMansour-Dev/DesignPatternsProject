using DesignPatternsProject.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    internal class Coffe : IBeverage
    {
        public double Cost()
        {
            return 20;
        }

        public string Description()
        {
            return "Coffe";
        }
    }
}
