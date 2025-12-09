using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    class HellWeapon : Item
    {
        public HellWeapon(string name, int attack, int health) : base(name, attack, health)
        {
        }

        public override void SpeciaLPower()
        {
            Console.WriteLine("Adam! First man, next to die!");
            Console.WriteLine("*Radio static kicks in and jazz plays from nowhere.*");
            Console.WriteLine("Your attack is doubled and the next hit CRITS automatically.");

        }
    }
}
