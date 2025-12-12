using GalacticQuest.Models.Monsters;

namespace GalacticQuest.Planets
{
    internal interface IPlanet
    {
        IList<Monster> GetInhabitants();
    }
}