using GalacticQuest.Models.Monsters;

namespace GalacticQuest.Planets
{
    internal class PlanetVespera : IPlanet
    {
        public IList<Monster> GetInhabitants()
        {
            return new List<Monster>() { new Ignifax(), new Xenotutzi() };
        }
    }
}