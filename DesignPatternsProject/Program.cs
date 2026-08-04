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
            DocumentProcessor processor = new PDFProcessor();

            processor.ProcessDocument();

        }
    }
}
