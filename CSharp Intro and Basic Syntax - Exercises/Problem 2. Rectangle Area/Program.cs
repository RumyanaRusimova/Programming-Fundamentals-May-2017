﻿using System;
using System.Collections.Generic;

namespace Problem_2.Rectangle_Area
{
    public class Program
    {
        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var rectangleArea = width * height;

            Console.WriteLine("{0:f2}",rectangleArea);
        }
    }
}