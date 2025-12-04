using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    public class Item
    {
        public int Attack { get; set; }
        public string Name { get; set; }

        public Item(string name, int attack)
        {
            Attack = attack;
            Name = name;
        }

    }
}
