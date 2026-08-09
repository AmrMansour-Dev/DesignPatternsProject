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
           StudentCollection students = new StudentCollection();

           IIterator<Student> iterator = students.CreateIterator();

           while(iterator.HasNext())
            {

                var next = iterator.Next();

                Console.WriteLine(next.Name);
            }


        }
    }
}
