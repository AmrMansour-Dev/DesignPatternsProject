using DesignPatternsProject.Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator
{
    internal class Tea : IBeverage
    {
        public double Cost()
        {
            return 10;
        }

        public string Description()
        {
            return "Tea";
        }
    }
}
