using System;

namespace Problem_5.Character_Stats
{
    public class Program
    {
        public static void Main()
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maximumHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maximumEnergy = int.Parse(Console.ReadLine());

            var drawCurrentHealth = new string('|', currentHealth);
            var drawMaximumHealth = new string('.', maximumHealth - currentHealth);
            var drawCurrentEnergy = new string('|', currentEnergy);
            var drawMaximumEnergy = new string('.', maximumEnergy - currentEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{drawCurrentHealth + drawMaximumHealth}|");
            Console.WriteLine($"Energy: |{drawCurrentEnergy + drawMaximumEnergy}|");
        }
    }
}