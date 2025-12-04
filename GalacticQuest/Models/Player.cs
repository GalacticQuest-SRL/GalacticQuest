using GalacticQuest.Models;

namespace GalacticQuest
{
    public class Player
    {
        public int Hp { get; private set; } = 100;
        public int Attack { get; private set; } = 10;
        public int Credits { get; private set; } = 0;
        public List<Item> Items { get; private set; } = new List<Item>();

        public Player(int hp, int attack, List<Item> items)
        {
            Hp = hp;
            Attack = attack;
            Items = items;
        }

        public Player(int hp, int attack)
        {
            Hp = hp;
            Attack = attack;
        }

        public Player(int hp)
        {
            Hp = hp;
        }

        public Player()
        {
        }

        public void UpdateHp(int hp)
        {
            Hp += hp;
            OnDeath();
        }

        public void OnDeath()
        {
            if (Hp <= 0)
            {
                Hp = 0;
                Console.WriteLine("You can bring the coliva");
                Console.WriteLine("The priest is singing");
            }
        }

        public List<Item> GetItems()
        {
            return Items;
        }

        public void UpdateItems(Item item, int price)
        {
            if (price == 0)
            {
                Console.WriteLine("Price can't be 0, decide if you're buying or selling.");
                return;
            }

            // BUY
            if (price < 0)
            {
                Transaction(price);
                Items.Add(item);

                Console.WriteLine($"Bought {item.Name} with attack {item.Attack}");
                return;
            }

            // SELL
            if (price > 0)
            {
                bool found = false;

                for (int i = 0; i < Items.Count; i++)
                {
                    if (Items[i].Name == item.Name && Items[i].Attack == item.Attack)
                    {
                        Items.RemoveAt(i);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine($"You cannot sell {item.Name}, you don't own it.");
                    return;
                }

                Transaction(price);

                Console.WriteLine($"Sold {item.Name} with attack {item.Attack}");
            }
        }


        public void Transaction(int transaction)
        {
            Credits += transaction;
            if (Credits < 0)
            {
                Console.WriteLine($"You are in dept, your credits are {Credits}");
            }
            else
            {
                Console.WriteLine($"your credits are {Credits}");
            }
        }

        public void ShowProfile()
        {
            Console.WriteLine("Displaying Player Profile:");

            Console.WriteLine($"Player HP: {Hp}");
            Console.Write("\n");

            Console.WriteLine($"Player Credits: {Credits}");
            Console.Write("\n");

            Console.WriteLine("Player Items: ");
            for (int index = 0; index < Items.Count; ++index)
            {
                Console.WriteLine($"Item -> Name: {Items[index].Name}" + " | " + $"Attack: {Items[index].Attack}");
            }
            Console.Write("\n");

            Console.WriteLine($"Player Attack: {Attack}");
            int playerTotalAttack = Attack;
            for (int index = 0; index < Items.Count; ++index)
            {
                string itemName = Items[index].Name;
                int itemAttack = Items[index].Attack;

                playerTotalAttack += itemAttack;
            }
            Console.WriteLine($"Player Attack (Combined With Items Attack): {playerTotalAttack}");
            Console.Write("\n");
        }
    }
}