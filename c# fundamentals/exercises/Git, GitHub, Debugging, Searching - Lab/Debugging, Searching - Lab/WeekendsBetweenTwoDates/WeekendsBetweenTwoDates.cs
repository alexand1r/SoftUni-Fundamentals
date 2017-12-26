using System;
using System.Globalization;

namespace WeekendsBetweenTwoDates
{
    class HolidaysBetweenTwoDates
    {
        static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "d.M.yyyy", CultureInfo.InvariantCulture);
            var holidaysCount = 0;
            for (var date = startDate.Date; date.Date <= endDate.Date; date = date.AddDays(1))
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    holidaysCount++;
                }
            Console.WriteLine(holidaysCount);
        }
    }
}
