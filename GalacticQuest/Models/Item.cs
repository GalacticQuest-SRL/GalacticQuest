using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    abstract class Item
    {
        public string Name;
        public int Attack;
        public int Health;

        public Item (string name, int attack, int health)
        {
            Name = name;
            Attack = attack;
            Health = health;
        }

        public abstract void SpeciaLPower();
    }
}
