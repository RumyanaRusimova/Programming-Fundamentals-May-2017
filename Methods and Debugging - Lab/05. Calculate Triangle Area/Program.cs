namespace _5.Calculate_Triangle_Area
{
    using System;

   public class CalculateTriangleArea
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            Console.WriteLine(GetTriangleArea(width, heigth));

        }

        public static double GetTriangleArea(double width, double heigth)
        {
            return width * heigth / 2;
        }
    }
}
