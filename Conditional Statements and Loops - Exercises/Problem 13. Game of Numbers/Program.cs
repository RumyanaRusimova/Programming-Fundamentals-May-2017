﻿namespace Problem_13.Game_of_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicalNumber = int.Parse(Console.ReadLine());

            var firstNumber = 0;
            var secondNumber = 0;

            bool numbersSumEqualToMagicalNumber = false;

            var combinationsCount = 0;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    if(i + j == magicalNumber)
                    {
                        firstNumber = i;
                        secondNumber = j;
                        numbersSumEqualToMagicalNumber = true;
                    }

                    combinationsCount++;
                }
            }

            if (numbersSumEqualToMagicalNumber)
            {
                Console.WriteLine($"Number found! {firstNumber} + {secondNumber} = {magicalNumber}");
            }

            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicalNumber}");
            }
        }
    }
}