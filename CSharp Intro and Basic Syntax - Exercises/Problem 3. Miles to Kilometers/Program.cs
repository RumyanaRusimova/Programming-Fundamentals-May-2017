﻿using System;

namespace Problem_3.Miles_to_Kilometers
{
    public class Program
    {
        public static void Main()
        {
            var miles = double.Parse(Console.ReadLine());

            var milesToKm = miles * 1.60934;

            Console.WriteLine("{0:f2}",milesToKm);
        }
    }
}
