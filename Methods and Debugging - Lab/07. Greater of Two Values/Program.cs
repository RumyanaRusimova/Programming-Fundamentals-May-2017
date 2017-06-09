using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main()
        {
            var type = Console.ReadLine().ToLower();

            if (type == "int")
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());


                Console.WriteLine(GetMaxInteger(firstNumber, secondNumber));
            }

            else if (type == "char")
            {
                char firstChar = char.Parse(Console.ReadLine());
                char secondChar = char.Parse(Console.ReadLine());

                Console.WriteLine(GetMaxChar(firstChar, secondChar));
            }
            else if (type == "string")
            {
                var firstString = Console.ReadLine();
                var secondString = Console.ReadLine();
                Console.WriteLine(GetMaxString(firstString, secondString));
            }
        }

        static string GetMaxString(string firstString, string secondString)
        {
            if (string.Compare(firstString, secondString) >= 0)
                return firstString;

            else
                return secondString;
        }

        static int GetMaxInteger(int firstNumber, int secondNumber)
        {
            if (firstNumber >= secondNumber)
                return firstNumber;

            else
                return secondNumber;
        }

        static char GetMaxChar(char firstChar, char secondChar)
        {
           
            if (firstChar >= secondChar)
                return firstChar;

            else
               return secondChar;
        } 
    }
}
