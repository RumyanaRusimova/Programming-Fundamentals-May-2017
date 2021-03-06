﻿namespace Problem_12.Test_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maximumBoundary = int.Parse(Console.ReadLine());

            var sum = 0;
            var combinationsCount = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum = sum + 3 * (i * j);
                    combinationsCount++;

                    if (sum >= maximumBoundary)
                    {
                        Console.WriteLine($"{combinationsCount} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maximumBoundary}");
                        return;
                    }
                }
            }

            Console.WriteLine($"{combinationsCount} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}