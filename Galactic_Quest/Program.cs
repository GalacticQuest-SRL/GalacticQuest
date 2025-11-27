using System.Xml.Linq;

namespace Galactic_Quest
{
    internal class Program
    {
        static void displayJournal(List<Monster>monsterList)
        {

            bool a = true;
            while (a)
            {
                Console.WriteLine("Journal:");
                Console.WriteLine("1. Monsters");
                Console.WriteLine("2. Planets");
                Console.WriteLine("3. Items");
                Console.WriteLine("4. Back");
                string input = Console.ReadLine();
                int.TryParse(input, out int choice);
                switch (choice)
                {
                    case (int)JournalOptions.Monsters:
                        foreach (var monster in monsterList)
                        {
                            Console.WriteLine($"{monster.Name}: {monster.HP} HP, {monster.AttackPower} Attack");
                        }
                        bool b = true;
                        while (b)
                        {
                            Console.WriteLine("Enter option");
                            Console.WriteLine("1.Filter by name");
                            Console.WriteLine("2.Back");
                            string input2 = Console.ReadLine();
                            int.TryParse(input2, out int choice2);
                            switch (choice2)
                            {
                                case 1:
                                    Console.WriteLine("Enter name to filter by:");
                                    string filter = Console.ReadLine();
                                    filterByName(monsterList, filter);
                                    break;
                                case 2:
                                    b = false;
                                    break;
                                default:
                                    Console.WriteLine("Invalid option");
                                    break;
                            }

                        }
                        break;
                    case (int)JournalOptions.Planets:
                        Console.WriteLine("Planets section is under construction.");
                        break;
                    case (int)JournalOptions.Items:
                        Console.WriteLine("Items section is under construction.");
                        break;
                    case (int)JournalOptions.Back:
                        a = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
        static void displayTravel()
        {
            bool d = true;
            while (d)
            {
                Console.WriteLine("Travel Menu:");
                Console.WriteLine("1. Explore");
                Console.WriteLine("2. Search for Items");
                Console.WriteLine("3. Back to Ship");
                Console.WriteLine("4. Back");
                string inputTravel = Console.ReadLine();
                int.TryParse(inputTravel, out int choiceTravel);
                switch (choiceTravel)
                {
                    case (int)TravelOptions.Explore:
                        Console.WriteLine("Exploration feature is under construction.");
                        break;
                    case (int)TravelOptions.SearchForItems:
                        Console.WriteLine("Item search feature is under construction.");
                        break;
                    case (int)TravelOptions.BackToShip:
                        Console.WriteLine("Returning to ship feature is under construction.");
                        break;
                    case (int)TravelOptions.Back:
                        d = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
        static void filterByName(List<Monster>monstersList, string filter)
        {
            List<Monster> result = new List<Monster>();
            foreach (var monster in monstersList)
            {
                if (monster.Name.Contains(filter, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(monster);
                }
            }
            if (result.Count == 0)
            {
                Console.WriteLine("Nothing found with that name.");
            }
            else
            {
                foreach (var monster in result)
                {
                    Console.WriteLine($"{monster.Name}: {monster.HP} HP, {monster.AttackPower} Attack");
                }
            }
        }
        static void Main(string[] args)
        {
            List<Monster> monsterList = new List<Monster>();
            monsterList.Add(new Monster { Name = "Goblin", HP = 50, AttackPower = 10 });
            monsterList.Add(new Monster { Name = "Troll", HP = 100, AttackPower = 20 });
            monsterList.Add(new Monster { Name = "Dragon", HP = 500, AttackPower = 50 });
            monsterList.Add(new Monster { Name = "Elf", HP = 120, AttackPower = 15 });
            monsterList.Add(new Monster { Name = "Orc", HP = 80, AttackPower = 12 });
            monsterList.Add(new Monster { Name = "Vampire", HP = 200, AttackPower = 25 });
            bool c = true;
            while (c)
            {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Journal");
                Console.WriteLine("2. Travel");
                Console.WriteLine("3. Exit");
                string inputMain = Console.ReadLine();
                int.TryParse(inputMain, out int choiceMain);
                switch (choiceMain)
                {
                    case (int)GameOptions.Journal:
                        displayJournal(monsterList);
                        break;
                    case (int)GameOptions.Travel:
                        displayTravel();
                        break;
                    case (int)GameOptions.Exit:
                        c = false;
                        break;
                }

            }
        }
    }
}

