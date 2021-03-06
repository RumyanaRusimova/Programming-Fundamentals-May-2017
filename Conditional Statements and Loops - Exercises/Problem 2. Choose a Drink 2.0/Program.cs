﻿namespace Problem_2.Choose_a_Drink_2._0
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var proffession = Console.ReadLine();
            var quantities = int.Parse(Console.ReadLine());

            switch (proffession)
            {
                case "Athlete":
                    Console.WriteLine($"The Athlete has to pay {(quantities * 0.70):f2}.");
                    break;
                case "Businessman":
                    Console.WriteLine($"The Businessman has to pay {(quantities * 1.00):f2}.");
                    break;
                case "Businesswoman":
                    Console.WriteLine($"The Businesswoman has to pay {(quantities * 1.00):f2}.");
                    break;
                case "SoftUni Student":
                    Console.WriteLine($"The SoftUni Student has to pay {(quantities * 1.70):f2}.");
                    break;
                default:
                    Console.WriteLine($"The {proffession} has to pay {(quantities * 1.20):f2}.");
                    break;
            }
        }
    }
}