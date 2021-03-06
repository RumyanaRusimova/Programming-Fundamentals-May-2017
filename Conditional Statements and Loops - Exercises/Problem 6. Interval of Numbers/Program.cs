﻿namespace Problem_6.Interval_of_Numbers
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            var smallerNumber = Math.Min(firstNumber, secondNumber);
            var biggerNumber = Math.Max(firstNumber, secondNumber);

            for (int i = smallerNumber; i <= biggerNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}