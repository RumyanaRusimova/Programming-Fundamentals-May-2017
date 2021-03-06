﻿namespace Problem_7.Cake_Ingredients
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var ingredient = Console.ReadLine();

            var ingredientCounter = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");

                ingredientCounter++;
                ingredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {ingredientCounter} ingredients.");
        }
    }
}