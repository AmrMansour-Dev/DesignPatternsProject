using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Decorator.Interfaces
{
    internal interface IBeverage
    {
        string Description();
        double Cost();
    }
}
