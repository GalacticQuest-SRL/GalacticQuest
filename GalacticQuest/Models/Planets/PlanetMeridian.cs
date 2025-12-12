using GalacticQuest.Models.Monsters;

namespace GalacticQuest.Planets
{
    internal class PlanetMeridian : IPlanet
    {
        public IList<Monster> GetInhabitants()
        {
            return new List<Monster>() { new Glorbazorg(), new Ignifax(), new Kryostasis() };
        }
    }
}