using DesignPatternsProject.ChainOfResponsibility;
using DesignPatternsProject.ChainOfResponsibility.Interfaces;
using DesignPatternsProject.Iterator;
using DesignPatternsProject.Iterator.Interfaces;
using DesignPatternsProject.Momento;
using DesignPatternsProject.Observer;
using DesignPatternsProject.Observer.Enum;
using DesignPatternsProject.Observer.Models;
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
            IExpenseHandler teamLeader = new TeamLeader();
            IExpenseHandler manager = new Manager();
            IExpenseHandler director = new Director();

            teamLeader.setNext(manager);
            manager.setNext(director);

            ExpenseRequest request = new ExpenseRequest(EmployeeName: "Amr", Amount: 36000);

            teamLeader.Handle(request);

        }
    }
}
