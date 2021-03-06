﻿namespace Problem_4.Hotel
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var month = Console.ReadLine();
            var nightsCount = int.Parse(Console.ReadLine());

            var studio = 0;
            var doubleRoom = 0;
            var suite = 0;
            var discount = 0.0;

            if (month == "May" || month == "October")
            {
                if (month == "October")
                {
                    if (nightsCount > 7)
                    {
                        studio -= 50;
                    }
                }

                if (nightsCount > 7)
                {
                    discount = 0.05;
                }

                studio += 50 * nightsCount;
                doubleRoom = 65 * nightsCount;
                suite = 75 * nightsCount;

                Console.WriteLine($"Studio: {(studio - (studio * discount)):f2} lv.");
                Console.WriteLine($"Double: {doubleRoom:f2} lv.");
                Console.WriteLine($"Suite: {suite:f2} lv.");
            }

            else if (month == "June" || month == "September")
            {
                if(month == "September")
                {
                    if (nightsCount > 7)
                    {
                        studio -= 60;
                    }
                }

                if (nightsCount > 14)
                {
                    discount = 0.1;
                }

                studio += 60 * nightsCount;
                doubleRoom = 72 * nightsCount;
                suite = 82 * nightsCount;

                Console.WriteLine($"Studio: {studio:f2} lv.");
                Console.WriteLine($"Double: {(doubleRoom - (doubleRoom * discount)):f2} lv.");
                Console.WriteLine($"Suite: {suite:f2} lv.");
            }

            else if (month == "July" || month == "August" || month == "December")
            {
                if (nightsCount > 14)
                {
                    discount = 0.15;
                }

                studio = 68 * nightsCount;
                doubleRoom = 77 * nightsCount;
                suite = 89 * nightsCount;

                Console.WriteLine($"Studio: {studio:f2} lv.");
                Console.WriteLine($"Double: {doubleRoom:f2} lv.");
                Console.WriteLine($"Suite: {(suite - (suite * discount)):f2} lv.");
            }
        }
    }
}