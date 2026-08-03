using DesignPatternsProject.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Observer
{
    internal class Customer : ISubscriber
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            this.Name = name;
        }


        public void Notify(string message)
        {
            Console.WriteLine($"Alert for {Name} " + message);
        }
    }
}
