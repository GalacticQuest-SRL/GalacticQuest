using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GalacticQuest.Models.Monster;

namespace GalacticQuest.Models
{
    class Monster
    {
        public enum HellRing
        {
            Pride,
            Wrath,
            Gluttony,
            Greed,
            Lust,
            Envy,
            Sloth
        }
        public enum DemonSpecies
        {
            Sinner,          
            Hellborn,
            Goetia,
            Imp,
            Hellhound,
            Succubi,
            Baphomet,
            Overlord,
            FallenAngel
        }
        public string Name;
        public int Hp { get; set; }
        public int Attack { get; set; }
        public HellRing OriginRealm { get; set; }
        public DemonSpecies Specie { get; set; }

        public Monster () { }

        public Monster (string name, int hp, int attack, HellRing originRealm, DemonSpecies specie)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
            OriginRealm = originRealm;
            Specie = specie;
        }

        public virtual void ShowInfo() => Console.WriteLine($"Name: {this.Name} | Type: {this.Specie} | Attack: {this.Attack} | Hp: {this.Hp} | Realm of origin:{this.OriginRealm} | Specie: {this.Specie}");
    }
}
