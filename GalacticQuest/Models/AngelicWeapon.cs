using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    class AngelicWeapon : Item
    {
        public AngelicWeapon(string name, int attack, int health) : base(name, attack, health)
        {
        }

        public override void SpeciaLPower()
        {
            Console.WriteLine("Take that, depression!");
            Console.WriteLine("A radiant burst of serotonin hits your soul like a musical number.");
            Console.WriteLine("You regain +75 HP and become immune to negative status effects for 3 turns.");

        }
    }
}
