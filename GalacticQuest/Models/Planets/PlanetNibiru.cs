
using GalacticQuest.Models.Monsters;

namespace GalacticQuest.Planets
{
    internal class PlanetNibiru : IPlanet
    {
        public IList<Monster> GetInhabitants()
        {
            return new List<Monster>() { new Xenotutzi() };
        }
    }
}