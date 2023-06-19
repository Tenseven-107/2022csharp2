using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_functions
{
    internal class Skill
    {
        public int damage { get; set; }
        public int energyCost { get; set; }
        public string name { get; set; }
        public Elements element { get; set; }


        public Skill()
        { }

        internal Skill(int damage, int energyCost, string name, Elements element)
        {
            this.damage = damage;
            this.energyCost = energyCost;
            this.name = name;
            this.element = element;
        }

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
