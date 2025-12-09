using GalacticQuest.Models;

namespace GalacticQuest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Galactic Quest!");

            CreateAndDisplayPlayerStats();

            OpenMainMenu();
        }

        private static void CreateAndDisplayPlayerStats()
        {
            Console.Write("\n");

            List<(string, int)> items = new List<(string, int)>() { ("Excalibur", 500), ("Tessaiga", 1000) };
            Player player = new Player(50, 1, items, 10);
            //Player player = new Player(50, 1, items);
            //Player player = new Player(40, 2);
            //Player player = new Player(30);
            //Player player = new Player();
            Monster testMonster = new Monster();
            Monster testNewMonster = new Monster("Alastor", 100, 100, Monster.HellRing.Pride, Monster.DemonSpecies.Overlord);

            testMonster.ShowInfo();
            testNewMonster.ShowInfo();

            AngelicWeapon luciferStaff = new AngelicWeapon("Lucifer's Staff", 50, 20);
            luciferStaff.SpeciaLPower();

            HellWeapon alastorRadioStick = new HellWeapon("Alastor's radio stick", 80, 30);
            alastorRadioStick.SpeciaLPower();

            player.ShowProfile();

            (string, int) newItem = ("Dragon Slayer", 1500);
            player.AddItem(newItem, 6);

            player.ShowProfile();

            player.UpdateHp(-60);
            Console.WriteLine($"After updating HP: {player.Hp}");
        }

        internal static void OpenMainMenu()
        {
            bool isAppRunning = true;

            while (isAppRunning)
            {
                Console.Write("\n");
                Console.WriteLine("Select your option and press Enter: \n 1.Travel \n 2.Journal \n 3.Exit \n");
                int.TryParse(Console.ReadLine(), out int readOption);


                try
                {
                    switch (readOption)
                    {
                        case 1:
                            OpenTravelMenu();
                            break;

                        case 2:
                            OpenJournalMenu();
                            break;

                        case 3:
                            isAppRunning = false;
                            break;

                        default:
                            throw new Exception("Invalid Option");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("(-_-') " + ex.Message);
                    isAppRunning = false;
                }
            }
        }

        internal enum GameOptions
        {
            Monsters = 1,
            Journal = 2,
            Exit = 3
        }

        internal static void OpenTravelMenu()
        {
            Console.Write("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Explore \n 2.Search For Items \n 3.Back To Ship \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    Console.WriteLine("Selected Explore");
                    break;

                case 2:
                    Console.WriteLine("Selected Search For Items");
                    break;

                case 3:
                    Console.WriteLine("Selected Back To Ship");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;

            }
        }

        internal static void OpenJournalMenu()
        {
            Console.Write("\n");
            Console.WriteLine("Select your option and press Enter: \n 1.Monsters \n 2.Planets \n 3.Items \n 4.Back To Main Menu\n");

            int.TryParse(Console.ReadLine(), out int readOption);

            switch (readOption)
            {
                case 1:
                    List<Monster> monsters = CreateMonsters();
                    ShowMonsters(monsters);
                    ShowMonstersOptions(monsters);
                    break;

                case 2:
                    Console.WriteLine("Selected Planets");
                    break;

                case 3:
                    Console.WriteLine("Selected Items");
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;
            }
        }

        internal static List<Monster> CreateMonsters()
        {
            List<Monster> monsters = new()
            {
                new Sinner("Alastor", 250, 200, Monster.HellRing.Pride, Monster.DemonSpecies.Overlord),
                new Monster("Lucifer", 676, 676, Monster.HellRing.Pride, Monster.DemonSpecies.FallenAngel),
                new Hellborn("Charlie", 220, 120, Monster.HellRing.Pride, Monster.DemonSpecies.Hellborn),
                new Monster("Vaggie", 140, 90, Monster.HellRing.Pride, Monster.DemonSpecies.FallenAngel),
                new Sinner("Angel Dust", 110, 85, Monster.HellRing.Pride, Monster.DemonSpecies.Succubi),
                new Sinner("Husk", 120, 60, Monster.HellRing.Sloth, Monster.DemonSpecies.Hellborn),
                new Sinner("Niffty", 80, 75, Monster.HellRing.Greed, Monster.DemonSpecies.Hellborn),
                new Sinner("Sir Pentious", 140, 70, Monster.HellRing.Greed, Monster.DemonSpecies.Sinner),
                new Sinner("Velvette", 180, 130, Monster.HellRing.Pride, Monster.DemonSpecies.Overlord),
                new Hellborn("Blitzo", 100, 85, Monster.HellRing.Wrath, Monster.DemonSpecies.Imp),
                new Hellborn("Moxxie", 90, 80, Monster.HellRing.Wrath, Monster.DemonSpecies.Imp),
                new Hellborn("Millie", 110, 95, Monster.HellRing.Wrath, Monster.DemonSpecies.Imp),
                new Hellborn("Loona", 130, 100, Monster.HellRing.Wrath, Monster.DemonSpecies.Hellhound),
                new Hellborn("Stolas", 300, 250, Monster.HellRing.Pride, Monster.DemonSpecies.Goetia),
                new Hellborn("Asmodeus", 260, 200, Monster.HellRing.Lust, Monster.DemonSpecies.Overlord),
                new Hellborn("Fizzarolli", 110, 90, Monster.HellRing.Lust, Monster.DemonSpecies.Imp),
                new Hellborn("Striker", 140, 110, Monster.HellRing.Wrath, Monster.DemonSpecies.Sinner),
                new Hellborn("Verosika Mayday", 150, 120, Monster.HellRing.Lust, Monster.DemonSpecies.Succubi),
                new Hellborn("Mammon", 270, 220, Monster.HellRing.Greed, Monster.DemonSpecies.Overlord)
            };

            return monsters;
        }


        internal static void ShowMonsters(List<Monster> monsters)
        {
            Console.WriteLine("The monsters are : ");

            for (int index = 0; index < monsters.Count; ++index)
            {
                monsters[index].ShowInfo();
            }
            Console.Write("\n");
        }

        internal static void ShowMonstersOptions(List<Monster> monsters)
        {
            Console.WriteLine("Press 1 to go back or 2 to filter monsters based on name");

            int.TryParse(Console.ReadLine(), out int userOption);
            switch (userOption)
            {
                case 1:
                    break;

                case 2:
                    FilterMonstersByName(monsters);
                    break;

                default:
                    Console.WriteLine("Invalid Option. Please try a valid option.");
                    break;
            }
        }

        internal static void FilterMonstersByName(List<Monster> monsters)
        {
            Console.WriteLine("Enter letters to filter monsters: ");
            string? userInput = Console.ReadLine();
            List<Monster> filteredMonstersByName = new List<Monster>();
            Console.Write("\n");

            if (!string.IsNullOrEmpty(userInput))
            {
                string lowerCasedUserInput = userInput.ToLower();
                for (int index = 0; index < monsters.Count; ++index)
                {
                    string currentMonsterName = monsters[index].Name;
                    string lowerCasedCurrentMonster = currentMonsterName.ToLower();

                    if (lowerCasedCurrentMonster.Contains(lowerCasedUserInput))
                    {
                        int currentMonsterHp = monsters[index].Hp;
                        filteredMonstersByName.Add(monsters[index]);
                    }
                }
            }
            else
            {
                Console.WriteLine("No input provided. Showing all monsters.");
                Console.Write("\n");

                for (int index = 0; index < monsters.Count; ++index)
                {
                    Console.WriteLine(monsters[index].Name);
                }
            }

            if (filteredMonstersByName.Count == 0)
            {
                Console.WriteLine("None of the monsters starts with these letters.");
                Console.Write("\n");
            }
            else
            {
                for (int index = 0; index < filteredMonstersByName.Count; ++index)
                {
                    Console.WriteLine(filteredMonstersByName[index].Name + " - " + filteredMonstersByName[index].Hp + " HP");
                }
            }
        }
    }
}