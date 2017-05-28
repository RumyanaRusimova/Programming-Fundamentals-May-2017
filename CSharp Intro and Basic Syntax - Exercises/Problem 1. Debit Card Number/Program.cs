using System;
using System.Collections.Generic;

namespace _01.Debit_Card_Number
{
    public class Program
    {
        public static void Main()
        {
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();
            var thirdNumberAsString = Console.ReadLine();
            var fourthNumberAsString = Console.ReadLine();

            var list = new List<string>();
            list.Add(firstNumberAsString);
            list.Add(secondNumberAsString);
            list.Add(thirdNumberAsString);
            list.Add(fourthNumberAsString);

            for (int i = 0; i < 4; i++)
            {
                if (list[i].Length == 3)
                {
                    list[i] = "0" + list[i];
                }

                else if (list[i].Length == 2)
                {
                    list[i] = "00" + list[i];
                }

                else if (list[i].Length == 1)
                {
                    list[i] = "000" + list[i];
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
