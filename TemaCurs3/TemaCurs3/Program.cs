namespace TemaCurs3
{
    internal class Program
    {
        // Dictionary cu: Nume -> (Health, Attack)
        static Dictionary<string, (int Health, int Attack)> monsters =
            new Dictionary<string, (int Health, int Attack)>();

        static void Main(string[] args)
        {
            InitializeMonsters();

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("=== Main Menu ===");
                Console.WriteLine("Select One Option:");
                Console.WriteLine("1. Monsters");
                Console.WriteLine("2. Travel");
                Console.WriteLine("3. Journal");
                Console.WriteLine("4. Exit");
                Console.Write("Your choice: ");

                int option = ReadOption(1, 4);

                switch (option)
                {
                    case 1:
                        MonstersMenu();
                        break;
                    case 2:
                        TravelMenu();
                        break;
                    case 3:
                        JournalMenu();
                        break;
                    case 4:
                        exit = true;
                        break;
                }
            }

            Console.WriteLine("Goodbye, Captain!");
        }

        // Inițializare monștri (nume, hp, attack)
        static void InitializeMonsters()
        {
            monsters["Goblin Raider"] = (50, 10);
            monsters["Space Slime"] = (40, 5);
            monsters["Void Dragon"] = (200, 35);
            monsters["Asteroid Worm"] = (120, 20);
            monsters["Plasma Wraith"] = (90, 25);
            monsters["Cosmic Spider"] = (70, 15);
            monsters["Shadow Beast"] = (150, 30);
        }

        // Citește o opțiune numerică între min și max
        static int ReadOption(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value) &&
                    value >= min && value <= max)
                {
                    return value;
                }

                Console.Write($"Please insert a number between {min} and {max}: ");
            }
        }

        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // ===================== MONSTERS MENU ==================
        static void MonstersMenu()
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Monsters ===");
                PrintMonsters(monsters);

                Console.WriteLine();
                Console.WriteLine("1. Filter by Name");
                Console.WriteLine("2. Back");
                Console.Write("Your choice: ");

                int option = ReadOption(1, 2);

                switch (option)
                {
                    case 1:
                        FilterMonstersByName();
                        break;
                    case 2:
                        back = true;
                        break;
                }
            }
        }

        static void PrintMonsters(Dictionary<string, (int Health, int Attack)> toPrint)
        {
            Console.WriteLine();
            Console.WriteLine("Name\t\t\tHealth\tAttack");

            foreach (var kvp in toPrint)
            {
                string name = kvp.Key;
                int health = kvp.Value.Health;
                int attack = kvp.Value.Attack;

                Console.WriteLine($"{name,-24}{health,6}\t{attack,6}");
            }
        }

        static void FilterMonstersByName()
        {
            Console.Write("Type part of the monster name to search: ");
            string sequence = Console.ReadLine() ?? string.Empty;

            var filtered = new Dictionary<string, (int Health, int Attack)>();

            foreach (var kvp in monsters)
            {
                if (kvp.Key.IndexOf(sequence, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filtered[kvp.Key] = kvp.Value;
                }
            }

            Console.Clear();
            Console.WriteLine("=== Monsters - Filter Result ===");

            if (filtered.Count == 0)
            {
                Console.WriteLine(
                    $"No monsters contain the sequence \"{sequence}\". Showing all monsters instead.");
                PrintMonsters(monsters);
            }
            else
            {
                PrintMonsters(filtered);
            }

            Pause();
        }

        // =============== TRAVEL MENU ==================
        static void TravelMenu()
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Travel ===");
                Console.WriteLine("1. Explore");
                Console.WriteLine("2. Search For Items");
                Console.WriteLine("3. Back To Ship");
                Console.Write("Your choice: ");

                int option = ReadOption(1, 3);

                switch (option)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("You leave the ship and explore a nearby planet...");
                        Pause();
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("You start searching for useful items in the sector...");
                        Pause();
                        break;
                    case 3:
                        back = true; // Back to Main Menu
                        break;
                }
            }
        }

        // ================== JOURNAL MENU ==================
        static void JournalMenu()
        {
            bool back = false;

            while (!back)
            {
                Console.Clear();
                Console.WriteLine("=== Journal ===");
                Console.WriteLine("1. Monsters");
                Console.WriteLine("2. Planets");
                Console.WriteLine("3. Items");
                Console.WriteLine("4. Back");
                Console.Write("Your choice: ");

                int option = ReadOption(1, 4);

                switch (option)
                {
                    case 1:
                        // Folosim același meniu de monștri
                        MonstersMenu();
                        break;
                    case 2:
                        ShowPlanetsJournal();
                        break;
                    case 3:
                        ShowItemsJournal();
                        break;
                    case 4:
                        back = true; // Back to Main Menu
                        break;
                }
            }
        }

        static void ShowPlanetsJournal()
        {
            Console.Clear();
            Console.WriteLine("=== Journal - Planets ===");
            Console.WriteLine("- Terra Prime");
            Console.WriteLine("- Xandar IV");
            Console.WriteLine("- Nebula Station");
            Pause();
        }

        static void ShowItemsJournal()
        {
            Console.Clear();
            Console.WriteLine("=== Journal - Items ===");
            Console.WriteLine("- Med Kit");
            Console.WriteLine("- Plasma Rifle");
            Console.WriteLine("- Alien Artifact");
            Pause();
        }
    }
}
