using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.Text.Json.Nodes;
using System.Text.Json;

namespace Classes_and_functions
{
    internal class ConsoleMonFactory
    {
        internal void Load(string dataFile)
        {
            string[] txt = File.ReadAllLines(dataFile);

            Console.WriteLine(txt);
        }

        internal List<ConsoleMon> LoadJson(string dataFile)
        {
            string json = File.ReadAllText(dataFile);

            List<ConsoleMon> templates = JsonSerializer.Deserialize<List<ConsoleMon>>(json);
            Console.WriteLine(templates[0].name);

            return templates;
        }

        internal Skill CopySkill(Skill copyFrom)
        {
            Skill copyResult = new Skill(copyFrom.damage, copyFrom.energyCost, copyFrom.name, copyFrom.element);

            return copyResult;
        }

        internal ConsoleMon CopyConsoleMon(ConsoleMon copyFrom)
        {
            ConsoleMon copyResult = new ConsoleMon(copyFrom.health, copyFrom.energy, copyFrom.name, copyFrom.weakness);
            copyResult.skills = new List<Skill>();

            foreach (Skill skill in copyFrom.skills)
            {
                copyResult.skills.Add(skill);
            }

            return copyResult;
        }
    }
}
