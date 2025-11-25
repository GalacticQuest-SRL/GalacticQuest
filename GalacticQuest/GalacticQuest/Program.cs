namespace GalacticQuest
{
    internal class Program
    {
        enum GameAction{
            Monsters = 1,
            Travel=2,
            Journal=3,
            Exit = 4
        }
        static Dictionary<string, (int Health, int Attack)> monsters = new Dictionary<string, (int, int)>();
        static void Main(string[] args)
        {
            PopulateMonsters();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nSelect One Option:");
                Console.WriteLine("1. Monsters");
                Console.WriteLine("2. Travel");
                Console.WriteLine("3. Journal");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();
                int.TryParse(input, out int ParsedInput);

                switch (ParsedInput)
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
                        Console.WriteLine("Exiting the game");
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
            }

            static void PopulateMonsters()
            {
                monsters.Add("Void Spider", (50, 10));
                monsters.Add("Xenomorph", (100, 25));
                monsters.Add("Star Eater", (300, 50));
                monsters.Add("Stardust Dragon", (450, 80));
                monsters.Add("Space Slime", (150, 5));
                monsters.Add("Star Scavenger", (40, 5));
                monsters.Add("Void Walker", (120, 25));
                monsters.Add("Martian Drone", (60, 12));
                monsters.Add("Sentry Empier", (80, 15));
                monsters.Add("Battle Mork", (110, 20));
                monsters.Add("The Pirate", (80, 15));
                monsters.Add("Void Ray", (75, 40));
                monsters.Add("Space Kraken", (500, 60));
                monsters.Add("Crystal Thech", (45, 30));
                monsters.Add("Ironmaiden", (90, 20));
                monsters.Add("Galactic Golem", (200, 40));
            }

            static void HandleMonstersMenu()
            {
                bool inMenu = true;
                bool isMonsterDisplayed = false;
                while (inMenu)
                {
                    if (!isMonsterDisplayed)
                    {
                        Console.WriteLine("\nMONSTERS:");
                        DisplayMonsters(monsters);
                        isMonsterDisplayed = true;
                    }


                    Console.WriteLine("\nOptions:");
                    Console.WriteLine("1. Filter by Name");
                    Console.WriteLine("2. Back");

                    string input = Console.ReadLine();
                    if (input == "1")
                    {
                        Console.WriteLine("Enter sequence to search:");
                        string filter = Console.ReadLine();

                        bool foundAny = false;
                        Console.WriteLine("\n FILTER RESULTS:");

                        foreach (var m in monsters)
                        {
                            if (m.Key.ToLower().Contains(filter.ToLower()))
                            {
                                Console.WriteLine($"Name: {m.Key} | HP: {m.Value.Health} | Attack: {m.Value.Attack}");
                                foundAny = true;
                            }
                        }

                        if (!foundAny)
                        {
                            Console.WriteLine($"No monsters found matching '{filter}'. Displaying all:");
                            DisplayMonsters(monsters);
                        }
                    }
                    else if (input == "2")
                    {
                        inMenu = false;
                    }
                }
            }

            static void DisplayMonsters(Dictionary<string, (int Health, int Attack)> list)
            {
                foreach (var m in list)
                {
                    Console.WriteLine($"Name: {m.Key} | HP: {m.Value.Health} | Attack: {m.Value.Attack}");
                }
            }

            static void HandleTravelMenu()
            {
                bool inMenu = true;
                while (inMenu)
                {
                    Console.WriteLine("\nTRAVEL MENU:");
                    Console.WriteLine("Select an action:");
                    Console.WriteLine("1. Explore");
                    Console.WriteLine("2. Search For Items");
                    Console.WriteLine("3. Back To Ship");
                    Console.Write("Selection: ");

                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            Console.WriteLine("\nWe are exploring...");
                            break;
                        case "2":
                            Console.WriteLine("\nWe are looking for items...");
                            break;
                        case "3":
                            inMenu = false; 
                            break;
                        default:
                            Console.WriteLine("\nInvalid command. Press Enter.");
                            Console.ReadLine();
                            break;
                    }
                }
            }

            static void HandleJournalMenu()
            {
                bool inMenu = true;
                while (inMenu)
                {
                    Console.WriteLine("\nJOURNAL:");
                    Console.WriteLine("1. Monsters (Database)");
                    Console.WriteLine("2. Planets");
                    Console.WriteLine("3. Items");
                    Console.WriteLine("4. Back");
                    Console.Write("Selection: ");

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
                            Console.WriteLine("\nWe are looking for items...");
                            break;

                        case "4":
                            inMenu = false; 
                            break;

                        default:
                            Console.WriteLine("\nInvalid selection. Press Enter.");
                            Console.ReadLine();
                            break;
                    }
                }
            }
        }
    }
}
