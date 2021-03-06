﻿namespace Problem_8.Calories_Counter
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var inputLines = int.Parse(Console.ReadLine());

            var caloriesSum = 0;

            for (int i = 0; i < inputLines; i++)
            {
                var ingredients = Console.ReadLine().ToLower();

                switch (ingredients)
                {
                    case "cheese":
                        caloriesSum += 500;
                        break;
                    case "tomato sauce":
                        caloriesSum += 150;
                        break;
                    case "salami":
                        caloriesSum += 600;
                        break;
                    case "pepper":
                        caloriesSum += 50;
                        break;
                }
            }

            Console.WriteLine($"Total calories: {caloriesSum}");
        }
    }
}