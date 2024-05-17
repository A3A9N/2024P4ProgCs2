using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        int health;
        int energy;
        string name;
        public int Health;
        public int Energy;
        internal void TakeDamage(int damage)
        {

            Health -= damage;

            if (Health < 0)
            {
                Health = 0;
            }
        }
        internal void DepleteEnergy(int energy)
        {
            Energy -= energy;

            if (Energy < 0)
            {
                Energy = 0;
            }
        }

    }
}
