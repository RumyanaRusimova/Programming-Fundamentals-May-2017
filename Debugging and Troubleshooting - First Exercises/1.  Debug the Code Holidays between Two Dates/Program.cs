using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);                         //Format -> d - Days; M - Month; 
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);


        int holidaysCount = 0;


        for (DateTime date = startDate; date <= endDate; date=date.AddDays(1))
        {
           if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
               holidaysCount++;
            Console.WriteLine(date);

        }
        Console.WriteLine(holidaysCount);


        //int days = 0;
        //while (startDate <= endDate)
        //{
        //    if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
        //    {
        //        ++days;
        //    }
        //    startDate = startDate.AddDays(1);
        //}
        //Console.WriteLine(days);
    }
}
