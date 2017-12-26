using System;
using System.Globalization;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            DateTime date;
            bool dateValid = DateTime.TryParseExact(input,
                                                    "hh:mm tt",
                                                    CultureInfo.InvariantCulture,
                                                    DateTimeStyles.AdjustToUniversal,
                                                    out date);
            if (dateValid)
            {
                if ((date.ToString("tt") == "AM" && date.Hour < 3) || (date.ToString("tt") == "PM" && date.Hour >= 1 && date.Hour < 12))
                {
                    Console.WriteLine("beer time");
                }
                else Console.WriteLine("non-beer time");
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
