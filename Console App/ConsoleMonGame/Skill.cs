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
                public int damage;
                public int energyCost;
                internal Element element;

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
