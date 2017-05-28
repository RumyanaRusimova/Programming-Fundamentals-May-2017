﻿namespace Problem_10.Triangle_of_Numbers
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var triangleLineCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= triangleLineCount; i++)
            {
                Console.WriteLine(i + " " + string.Concat( Enumerable.Repeat(i.ToString() + " ",i - 1)));        
            }
        }
    }
}