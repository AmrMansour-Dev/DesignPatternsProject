using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Momento
{
    internal class Player // Originator
    {
        public int Health { get; private set; }
        public int Coins { get; private set; }
        public int Level { get; private set; }


        public Player(int health, int coins, int level)
        {
            this.Health = health;
            this.Coins = coins;
            this.Level = level;
        }

        public void TakeCoins()
        {
            Coins += 20;
        }

        public void TakeDamage()
        {
            Health -= 20;
        }
        public PlayerMomento Save()
        {
            PlayerMomento momento = new PlayerMomento();

            momento.Health = Health;
            momento.Coins = Coins;
            momento.Level = Level;

            return momento;
        }

        public void Restore(PlayerMomento momento)
        {
            this.Health = momento.Health;
            this.Level = momento.Level;
            this.Coins = momento.Coins;
        }
    }
}
