﻿namespace Problem_3.Restaurant_Discount
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var countOfPeople = int.Parse(Console.ReadLine());
            var hallType = Console.ReadLine();

            var hallPrice = 0;
            var totalPrice = 0;
            var priceWithDiscount = 0.0;
            var hallName = string.Empty;

            if (countOfPeople > 0 && countOfPeople <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }

            else if (countOfPeople > 50 && countOfPeople <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }

            else if (countOfPeople > 100 && countOfPeople <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            }

            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (hallType == "Gold")
            {
                totalPrice = hallPrice + 750;
                priceWithDiscount = totalPrice - (totalPrice * 0.1);
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {(priceWithDiscount / countOfPeople):f2}$");
            }

            else if (hallType == "Normal")
            {
                totalPrice = hallPrice + 500;
                priceWithDiscount = totalPrice - (totalPrice * 0.05);
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {(priceWithDiscount / countOfPeople):f2}$");
            }

            else if (hallType == "Platinum")
            {
                totalPrice = hallPrice + 1000;
                priceWithDiscount = totalPrice - (totalPrice * 0.15);
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {(priceWithDiscount / countOfPeople):f2}$");
            }
        }
    }
}