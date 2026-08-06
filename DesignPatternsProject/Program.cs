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
            Player player1 = new Player(health: 100, coins: 10, level: 10);

            PlayerMomento momento1 =  player1.Save();

            CareTaker careTaker = new CareTaker();
            careTaker.playerMomentos.Add(momento1);

            player1.TakeDamage();
            player1.TakeCoins();

            Console.WriteLine(player1.Coins);
            Console.WriteLine(player1.Health);

            player1.Restore(momento1);

            Console.WriteLine(player1.Coins);
            Console.WriteLine(player1.Health);

            player1.TakeCoins();
            PlayerMomento momento2 = player1.Save();

            careTaker.playerMomentos.Add(momento2);


        }
    }
}
