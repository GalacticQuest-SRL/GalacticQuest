using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tematrimble1
{
    internal class tema1
    {

        static void Main()
        {
            int number;
            Console.WriteLine("Enter a number between 1 and 365:");
            string input = Console.ReadLine();
            int.TryParse(input, out number);


            if (number >= 1 && number <= 365)
            {
                if (number <= 31)
                {
                    Console.WriteLine("January" + " " + number);
                }
                else if (number <= 59)
                {
                    int day = number - 31;
                    Console.WriteLine("February" + " " + day);
                }
                else if (number <= 90)
                {
                    int day = number - 59;
                    Console.WriteLine("March" + " " + day);
                }
                else if (number <= 120)
                {
                    int day = number - 90;
                    Console.WriteLine("April" + " " + day);
                }
                else if (number <= 151)
                {
                    int day = number - 120;
                    Console.WriteLine("May" + " " + day);
                }
                else if (number <= 181)
                {
                    int day = number - 151;
                    Console.WriteLine("June" + " " + day);
                }
                else if (number <= 212)
                {
                    int day = number - 181;
                    Console.WriteLine("July" + " " + day);
                }
                else if (number <= 243)
                {
                    int day = number - 212;
                    Console.WriteLine("August" + " " + day);
                }
                else if (number <= 273)
                {
                    int day = number - 243;
                    Console.WriteLine("Sep" + " " + day);
                }
                else if (number <= 304)
                {
                    int day = number - 273;
                    Console.WriteLine("Oct" + " " + day);
                }
                else if (number <= 334)
                {
                    int day = number - 304;
                    Console.WriteLine("Nov" + " " + day);
                }
                else
                {
                    int day = number - 334;
                    Console.WriteLine("Dec" + " " + day);
                }

            }

            int year;
            Console.WriteLine();
            Console.WriteLine("Enter a number between 1990 and 2026:");
            string input2 = Console.ReadLine();
            int.TryParse(input2, out year);
            if (year % 4 == 0 && ((year % 100 != 0) || (year % 400 == 0))) Console.WriteLine("Leap year");
            else Console.WriteLine("Not a leap year");


        }
    }
}
