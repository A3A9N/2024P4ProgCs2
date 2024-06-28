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
            public string name { get; set; }
            public int health { get; set; }
            public int energy { get; set; }
            public List<Skill> skills { get; set; }
            internal Element weakness { get; set; }

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
