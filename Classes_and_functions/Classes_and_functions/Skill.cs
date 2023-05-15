using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_functions
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal int name;
        internal Elements element;

        internal void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
            if (element == target.weakness)
            {
                target.TakeDamage(damage/2);
            }
        }
    }
}
