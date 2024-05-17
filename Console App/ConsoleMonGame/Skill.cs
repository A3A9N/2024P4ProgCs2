﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMonGame
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        string name;
   

    internal void UseOn (ConsoleMon target, ConsoleMon caster)
    {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
    }
    }
}
