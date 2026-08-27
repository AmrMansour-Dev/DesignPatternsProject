using DesignPatternsProject.Adapter;
using DesignPatternsProject.Bridge;
using DesignPatternsProject.ChainOfResponsibility;
using DesignPatternsProject.ChainOfResponsibility.Interfaces;
using DesignPatternsProject.Composite;
using DesignPatternsProject.Decorator;
using DesignPatternsProject.Decorator.Interfaces;
using DesignPatternsProject.Facade;
using DesignPatternsProject.Iterator;
using DesignPatternsProject.Iterator.Interfaces;
using DesignPatternsProject.Mediator;
using DesignPatternsProject.Mediator.Interfaces;
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
            Client client = new Client();

            client.BuyProduct(165, 20);
        }
    }
}
