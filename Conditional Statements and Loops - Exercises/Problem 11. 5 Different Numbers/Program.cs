﻿namespace Problem_11._5_Different_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstNumberInput = int.Parse(Console.ReadLine());
            var secondNumberInput = int.Parse(Console.ReadLine());

            if (secondNumberInput - firstNumberInput < 5)
            {
                Console.WriteLine("No");
                return;
            }

            for (int n1 = firstNumberInput; n1 <= secondNumberInput; n1++)
            {
                for (int n2 = n1 + 1; n2 <= secondNumberInput; n2++)
                {
                    for (int n3 = n2 + 1; n3 <= secondNumberInput; n3++)
                    {
                        for (int n4 = n3 + 1; n4 <= secondNumberInput; n4++)
                        {
                            for (int n5 = n4 + 1; n5 <= secondNumberInput; n5++)
                            {
                                Console.WriteLine(n1 + " " + n2 + " " + n3 + " " + n4 + " " + n5);
                            }
                        }
                    }
                }
            }
        }
    }
}