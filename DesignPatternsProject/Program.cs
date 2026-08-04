using DesignPatternsProject.Observer;
using DesignPatternsProject.Observer.Enum;
using DesignPatternsProject.Observer.Models;
using DesignPatternsProject.Strategy;
using DesignPatternsProject.Strategy.PaymentStrategies;
using DesignPatternsProject.Strategy.PricingStrategies;

namespace DesignPatternsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SProduct wallet = new SProduct(name: "Wallet", price: 5000, new RegularPricingStrategy());

            double walletprice = wallet.CalculatePrice();
            Console.WriteLine(walletprice);


            SProduct mobile = new SProduct(name: "mobile", price: 2000, new GoldPricingStrategy());

            double mobileprice = mobile.CalculatePrice();
            Console.WriteLine(mobileprice);

            Checkout MasterCardcheckout = new Checkout(new MasterCardPaymentStrategy());
            Checkout VisaCardCheckout = new Checkout(new VisaPaymentStrategy());

            MasterCardcheckout.PaymentProcessing(mobileprice);
            VisaCardCheckout.PaymentProcessing(walletprice);


        }
    }
}
