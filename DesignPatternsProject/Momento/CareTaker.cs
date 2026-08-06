using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsProject.Momento
{
    internal class CareTaker
    {
        public List<PlayerMomento> playerMomentos = new List<PlayerMomento>();

        public PlayerMomento GetLast()
        {
            return playerMomentos.Last();
        }
    }
}
