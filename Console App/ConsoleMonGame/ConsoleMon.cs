using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class ConsoleMon
    {
        string name;
        public int health;
        public int energy;
        internal void TakeDamage(int damage)
        {

            health -= damage;

            if (health < 0)
            {
                health = 0;
            }
        }
        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;

            if (this.energy < 0)
            {
                this.energy = 0;
            }
        }

    }
}
