using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalacticQuest.Monsters;
using GalacticQuest.Planets;

namespace GalacticQuest.Models
{
    static internal class HistoryLog<T> where T : IPlanet
    {
        private static IList<T> _history = new List<T>();

        public static void AddRecord(T record)
        {
            _history.Add(record);
        }
        public static void ShowRecord()
        {
            foreach (var record in _history)
            {
                Console.WriteLine(record);
            }
        }

    }
}
