﻿using System;

namespace _04.Beverage_Labels
{
    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyFor100ml = int.Parse(Console.ReadLine());
            var sugarFor100ml = int.Parse(Console.ReadLine());

            var currentVolumeEnergy = (double)(energyFor100ml * volume) / 100;
            var currentVolumeSugar = (double)(sugarFor100ml * volume) / 100;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine("{0}kcal, {1}g sugars", currentVolumeEnergy, currentVolumeSugar);
        }
    }
}