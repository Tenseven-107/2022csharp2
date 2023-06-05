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
        internal Elements weakness;

        private List<Skill> skills;


        public ConsoleMon()
        {
        }

        internal ConsoleMon(int health, int energy, string name, Elements weakness)
        {
            this.health = health;
            this.energy = energy;
            this.name = name;
            this.weakness = weakness;
        }

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
