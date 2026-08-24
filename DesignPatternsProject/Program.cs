using DesignPatternsProject.Adapter;
using DesignPatternsProject.Bridge;
using DesignPatternsProject.ChainOfResponsibility;
using DesignPatternsProject.ChainOfResponsibility.Interfaces;
using DesignPatternsProject.Composite;
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
            Composite.File Image = new Composite.File("Salwa.jpg", 5);
            Composite.File Document = new Composite.File("Presentation.docs", 30);
            Composite.File PDF = new Composite.File("TITLE.PDF", 50);

            Folder DocumentsFolder = new Folder("Testing Folder");

            DocumentsFolder.Add(Document);
            DocumentsFolder.Add(Image);
            DocumentsFolder.Add(PDF);

            Composite.File Crack = new Composite.File("Crack.exe", 120);

            Folder MainFolder = new Folder("Main Folder");

            MainFolder.Add(Crack);
            MainFolder.Add(DocumentsFolder);

            Console.WriteLine(MainFolder.GetSize());




        }
    }
}
