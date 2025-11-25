namespace GalacticQuest
{
    internal class Program
    {
        enum GameAction
        {
            Monsters = 1,
            Travel = 2,
            Journal = 3,
            Exit
        }

        static Dictionary<string, (int Health, int Attack)> monsters = new Dictionary<string, (int, int)>();
        static void Main(string[] args)
        {
            AddMonsters();

            bool isGameRunning = true;
            while (isGameRunning)
            {
                Console.WriteLine("\nSelect One Option:");
                Console.WriteLine("1. Monsters");
                Console.WriteLine("2. Travel");
                Console.WriteLine("3. Journal");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();
                int.TryParse(input, out int actionNumber);

                switch (actionNumber)
                {
                    case (int)GameAction.Monsters:
                        HandleMonstersMenu();
                        break;

                    case (int)GameAction.Travel:
                        HandleTravelMenu();
                        break;

                    case (int)GameAction.Journal:
                        HandleJournalMenu();
                        break;

                    case (int)GameAction.Exit:
                        Console.WriteLine("Exiting Game.Bye!");
                        isGameRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option. Please try again.");
                        break;
                }
            }

        }

        static void AddMonsters()
        {
            monsters.Add("Dedei", (100, 15));
            monsters.Add("Xelthar", (150, 20));
            monsters.Add("Nebulon", (200, 25));
            monsters.Add("Krylon", (250, 30));
            monsters.Add("Vorticon", (300, 35));
            monsters.Add("Quasarion", (350, 40));
            monsters.Add("Zyglor", (400, 45));
            monsters.Add("Thraxor", (450, 50));
        }

        static void HandleMonstersMenu()
        {
            bool isInMonstersMenu = true;
            bool isMonstersVisible = false;

            while (isInMonstersMenu)
            {
                while (!isMonstersVisible)
                {
                    Console.WriteLine("\nMONSTERS:");
                    DisplayMonsters(monsters);
                    isMonstersVisible = true;
                }

                Console.WriteLine("\nSelect One Option:");
                Console.WriteLine("1.Filter by name");
                Console.WriteLine("2.Back to Menu");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Enter monster name to filter:");
                    string filterName = Console.ReadLine();

                    bool foundAny = false;
                    Console.WriteLine("\nFILTERED MONSTERS:");

                    foreach (var monster in monsters)
                    {
                        if (monster.Key.ToLower().Contains(filterName.ToLower()))
                        {
                            Console.WriteLine($"Name: {monster.Key}| Health = {monster.Value.Health}, Attack = {monster.Value.Attack}");
                            foundAny = true;
                        }
                    }

                    if (!foundAny)
                    {
                        Console.WriteLine("No monsters found with that name.");
                        DisplayMonsters(monsters);
                    }
                }
                else if (input == "2")
                {
                    isInMonstersMenu = false;
                }

            }
        }

        static void DisplayMonsters(Dictionary<string, (int Health, int Attack)> monsters)
        {
            foreach (var monster in monsters)
            {
                Console.WriteLine($"Name: {monster.Key}| Health = {monster.Value.Health}, Attack = {monster.Value.Attack}");
            }
        }

        static void HandleJournalMenu()
        {
            bool isInJournalMenu = true;
            while (isInJournalMenu)
            {
                Console.WriteLine("\nJOURNAL MENU:");
                Console.WriteLine("1. Monsters");
                Console.WriteLine("2. Planets");
                Console.WriteLine("3. Items");
                Console.WriteLine("4. Back to Main Menu");
                Console.WriteLine("Select Option:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        HandleMonstersMenu();
                        break;

                    case "2":
                        Console.WriteLine("\nWe are looking for planets...");
                        break;

                    case "3":
                        Console.WriteLine("\nWe are looking for items.");
                        break;

                    case "4":
                        isInJournalMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option. Please try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void HandleTravelMenu()
        {
            bool isInTravelMenu = true;
            while (isInTravelMenu)
            {
                Console.WriteLine("\nTRAVEL MENU:");
                Console.WriteLine("1. Explore New Planet");
                Console.WriteLine("2. Search for Items");
                Console.WriteLine("3. Back to Ship");
                Console.WriteLine("Select Option:");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("\nExploring new planet...");
                        break;

                    case "2":
                        Console.WriteLine("\nSearching for items...");
                        break;

                    case "3":
                        isInTravelMenu = false;
                        break;

                    default:
                        Console.WriteLine("Invalid Option. Please try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
