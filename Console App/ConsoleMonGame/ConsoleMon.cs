using ConsoleMonGame.ConsoleMonGame.ConsoleMonGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    namespace ConsoleMonGame
    {
        internal class ConsoleMon
        {
            public int health ; 
            public int energy ;
            internal Element weakness;

            internal void TakeDamage(int damage)
            {
                health -= damage;
            }

            internal void DepleteEnergy(int energy)
            {
                this.energy -= energy;
            }
        }
    }

}
