﻿namespace Problem_5.Word_in_Plural
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var noun = Console.ReadLine().ToCharArray();

            //check if the noun ends with "sh" or "ch"
            var fullyConcattedNoun = string.Concat(noun);

            //get only the last two letters
            var checkFor2CasesEnd = noun.Skip(noun.Length - 2).Take(2);

            //and concat them
            var endConcat = string.Concat(checkFor2CasesEnd);

            //pluralNoun will hold the result plural noun
            var pluralNoun = string.Empty;

            if (endConcat == "ch" || endConcat == "sh")
            {
                pluralNoun = fullyConcattedNoun + "es";
                Console.WriteLine(pluralNoun);
                return;
            }

            else if (noun.Last() == 'y')
            {
                pluralNoun = fullyConcattedNoun.Remove(noun.Length - 1, 1) + "ies";
            }

            else if (noun.Last() == 'o' || noun.Last() == 's' || noun.Last() == 'x' || noun.Last() == 'z')
            {
                pluralNoun = fullyConcattedNoun + "es";
            }

            else
            {
                pluralNoun = fullyConcattedNoun + "s";
            }

            Console.WriteLine(pluralNoun);
        }
    }
}