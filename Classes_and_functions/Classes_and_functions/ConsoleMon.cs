using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_functions
{
    internal class ConsoleMon
    {
        internal int health;
        internal int energy;
        internal string name;

        private List<Skill> skills;


        internal void TakeDamage(int damage)
        {
            this.health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}
