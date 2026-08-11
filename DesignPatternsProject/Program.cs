using DesignPatternsProject.ChainOfResponsibility;
using DesignPatternsProject.ChainOfResponsibility.Interfaces;
using DesignPatternsProject.Iterator;
using DesignPatternsProject.Iterator.Interfaces;
using DesignPatternsProject.Momento;
using DesignPatternsProject.Observer;
using DesignPatternsProject.Observer.Enum;
using DesignPatternsProject.Observer.Models;
using DesignPatternsProject.State;
using DesignPatternsProject.Strategy;
using DesignPatternsProject.Strategy.PaymentStrategies;
using DesignPatternsProject.Strategy.PricingStrategies;
using DesignPatternsProject.Template;

namespace DesignPatternsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(Name: "AC Cond", Price: 27500);

            OrderManagement orderManagement = new OrderManagement(order);

            orderManagement.ProcessOrder();
            orderManagement.ShipOrder();
            orderManagement.DeliverOrder();


        }
    }
}
