using DesignPatternsProject.ChainOfResponsibility;
using DesignPatternsProject.ChainOfResponsibility.Interfaces;
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
            IChatMediator ChatGroup = new ChatMediator();
            User User1 = new User("Amr",ChatGroup);
            User User2 = new User("Ahmed", ChatGroup);
            User User3 = new User("Sally", ChatGroup);
            User User4 = new User("hOKA", ChatGroup);

            ChatGroup.AddUser(User1);
            ChatGroup.AddUser(User2);
            ChatGroup.AddUser(User3);
            ChatGroup.AddUser(User4);

            User1.SendMessage("Saba7o ya rgala");


            //User1.SendMessage("Hello", User2);

        }
    }
}
