using DesignPatternsProject.Adapter;
using DesignPatternsProject.Bridge;
using DesignPatternsProject.ChainOfResponsibility;
using DesignPatternsProject.ChainOfResponsibility.Interfaces;
using DesignPatternsProject.Composite;
using DesignPatternsProject.Decorator;
using DesignPatternsProject.Decorator.Interfaces;
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
            //Mocha mocha = new Mocha(new Sugar(new Coffe()));

            //Console.WriteLine(mocha.Description()); 

            IBeverage Coffe1 = new Coffe();

            Coffe1 = new Sugar(Coffe1);

            Console.WriteLine(Coffe1.Description() + ", Cost :" + Coffe1.Cost()+"$");
        }
    }
}
