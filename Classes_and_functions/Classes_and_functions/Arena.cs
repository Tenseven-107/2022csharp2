using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_functions
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            fighterA.skills[0].UseOn(fighterB, fighterA);
            Console.WriteLine("Fighter A used " + fighterA.skills[0].name.ToString() +
                " on fighter B! " + "Fighter A has: " + fighterB.energy.ToString() + " energy. "+
                "Fighter B has: " + fighterA.health.ToString() + " health!");

            fighterB.skills[0].UseOn(fighterA, fighterB);
            Console.WriteLine("Fighter B used " + fighterB.skills[0].name.ToString() +
                " on fighter A! " + "Fighter B has: " + fighterB.energy.ToString() + " energy. " +
                "Fighter A has: " + fighterA.health.ToString() + " health!");

            if (fighterA.health > fighterB.health) Console.WriteLine("Fighter A wins!");
            else if (fighterA.health < fighterB.health) Console.WriteLine("Fighter B wins!");

            if (fighterB.health == fighterA.health) Console.WriteLine("ÏT IS A TIE! This is unbelievable!");
            
        }
    }
}
