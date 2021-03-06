﻿namespace Problem_9.Count_the_Integers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var integersCounter = 0;

            while (true)
            {
                int tryParseNumber;
                bool isNumber = Int32.TryParse(input, out tryParseNumber);

                if (!isNumber)
                {
                    break;
                }

                integersCounter++;

                input = Console.ReadLine();
            }

            Console.WriteLine(integersCounter);
        }
    }
}