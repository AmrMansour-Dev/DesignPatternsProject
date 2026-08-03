using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer.Models
{
    internal class Offer
    {
        public string Message { get; private set; }

        public Offer(string message)
        {
            this.Message = message;
        }
    }
}
