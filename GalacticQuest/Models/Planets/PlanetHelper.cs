using GalacticQuest.Models.Monsters;

namespace GalacticQuest.Planets
{
    internal static class PlanetHelper
    {
        internal static readonly List<IPlanet> PLANETS_LIST = new List<IPlanet>() { new PlanetMeridian(), new PlanetNibiru(), new PlanetVespera() };

        private static readonly Random _randomNumberGenerator = new Random();

        internal static void TravelToRandomPlanet()
        {
            int randomPlanetIndex = _randomNumberGenerator.Next(0, 2);
            IPlanet chosenPlanet = PLANETS_LIST.ElementAt(randomPlanetIndex);

            Console.WriteLine($" You travelled to planet : {chosenPlanet.GetType().ToString().Split(".").Last()} ");

            Monster? randomMonster = ChooseRandomMonsterFromPlanet(chosenPlanet);

            if (randomMonster is null)
            {
                Console.WriteLine("Unfortunately no monsters live on this planet :( ");
                return;
            }

            Console.WriteLine($" You have encountered a monster of type : {randomMonster.GetType().ToString().Split(".").Last()}, called by their name {randomMonster?.Name} with {randomMonster?.Hp} HP ");
        }

        private static Monster? ChooseRandomMonsterFromPlanet(IPlanet planet)
        {
            IList<Monster> monstersOnPlanet = planet.GetInhabitants();

            if (monstersOnPlanet is null || monstersOnPlanet.Count < 1)
            {
                return null;
            }

            return monstersOnPlanet.ElementAtOrDefault(_randomNumberGenerator.Next(0, monstersOnPlanet.Count - 1));
        }
    }
}