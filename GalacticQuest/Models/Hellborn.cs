using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    class Hellborn : Monster
    {
        public Hellborn()
        {
        }

        public Hellborn(string name, int hp, int attack, HellRing originRealm, DemonSpecies specie) : base(name, hp, attack, originRealm, specie)
        {
        }

        public override void ShowInfo() => Console.WriteLine($"Name: {this.Name} | Type: Hellborn | Attack: {this.Attack} | Hp: {this.Hp} | Realm of origin:{this.OriginRealm} | Specie: {this.Specie}");

    }
}
