namespace _6.Math_Power
{
    using System;

   public class Program
    {
        //static double GetRaisedNumber(int firstNumber, int secondNumber)
        //{
        //    return Math.Pow(firstNumber, secondNumber);
        //}
        //static void Main(string[] args)
        //{
        //    int firstNumber = int.Parse(Console.ReadLine());
        //    int secondNumber = int.Parse(Console.ReadLine());

        //    double GetRaisedNumber = Math.Pow(firstNumber, secondNumber);

        //    Console.WriteLine(GetRaisedNumber);
        //}


        public static double GetRaisedNumber(double number, double power)
        {
            double output = 1;
            for (double i = 1; i <= power; i++)
            {
                output *= number;

            }
            return output;
        }

        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double output = GetRaisedNumber(number,power);

            Console.WriteLine(output);
        }
    }
}
