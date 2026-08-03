using DesignPatternsProject.Observer;
using DesignPatternsProject.Observer.Enum;
using DesignPatternsProject.Observer.Models;

namespace DesignPatternsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OnlineMarketPlace onlineMarketPlace = new OnlineMarketPlace();

            Customer customer1 = new Customer(name:"Amr");
            Customer customer2 = new Customer(name: "Ahmed");

            onlineMarketPlace.Subscribe(EventType.New_Product, customer1);
            onlineMarketPlace.Subscribe(EventType.New_Offer, customer2);

            onlineMarketPlace.AddProduct(new Product(name: "Iphone 18", 156000));
            onlineMarketPlace.AddOffer(new Offer(message: "Buy 1 get 1"));
        }
    }
}
