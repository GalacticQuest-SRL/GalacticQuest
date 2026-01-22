namespace GalacticQuest.Items
{
    public abstract class Item
    {
        private dynamic _specialEffect;
        public string Name { get; set; }
        public int Attack { get; set; }
        public int Resitance { get; set; }

        public dynamic SpecialEffect { get=>_specialEffect; set 
            {
                if (value is int)
                {
                    _specialEffect = Math.Abs(value);
                    Console.WriteLine("Special Effect set to absolute value.");
                }
                else if (value is string)
                {
                    _specialEffect = value.ToUpper();
                    Console.WriteLine("Special Effect set to uppercase string.");
                }
                else
                {
                    _specialEffect = value;
                    Console.WriteLine("Special Effect set to provided value.");
                }
            }  
        }
        public Item(string name, int attack, int resitance)
        {
            Name = name;
            Attack = attack;
            Resitance = resitance;
        }

        public abstract void SpecialPower();
    }
}
