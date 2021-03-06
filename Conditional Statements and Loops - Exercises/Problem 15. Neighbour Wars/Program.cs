﻿namespace Problem_15.Neighbour_Wars
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var damageOfPesho = int.Parse(Console.ReadLine());
            var damageOfGosho = int.Parse(Console.ReadLine());

            var peshoHealth = 100;
            var goshoHealth = 100;

            var roundCounter = 1;

            bool isGoshoWinner = false;

            while (peshoHealth > 0 && goshoHealth > 0)
            {
                if (roundCounter % 2 != 0)
                {
                    goshoHealth -= damageOfPesho;

                    if (goshoHealth <= 0)
                    {
                        break;
                    }

                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }

                else
                {
                    peshoHealth -= damageOfGosho;

                    if (peshoHealth <= 0)
                    {
                        isGoshoWinner = true;
                        break;
                    }

                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");

                }

                if (roundCounter % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }

                roundCounter++;
            }

            if (isGoshoWinner)
            {
                Console.WriteLine($"Gosho won in {roundCounter}th round.");
            }

            else
            {
                Console.WriteLine($"Pesho won in {roundCounter}th round.");
            }
        }
    }
}