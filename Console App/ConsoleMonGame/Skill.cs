using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    namespace ConsoleMonGame
    {
        namespace ConsoleMonGame
        {
            internal class Skill
            {
                public string name { get; set; }
                public int damage { get; set; }
                public int energyCost { get; set; }
                internal Element element { get; set; }

                internal void UseOn(ConsoleMon target, ConsoleMon caster)
                {
                    caster.DepleteEnergy(energyCost);
                    target.TakeDamage(damage);

                    if (target.weakness == element)
                    {
                        target.TakeDamage(damage / 2);
                    }
                }
            }
        }


    }

}
