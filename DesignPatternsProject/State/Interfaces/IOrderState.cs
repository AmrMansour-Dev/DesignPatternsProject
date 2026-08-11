using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.State.Interfaces
{
    internal interface IOrderState
    {
        void ProcessOrder();
        void ShipOrder();
        void DeliverOrder();
        void CancelOrder();

    }
}
