using System;

namespace BookProblem
{
    class BookProblem
    {
        static void Main(string[] args)
        {
            uint pagesBook, campingDays, pagesPerDay;

            bool pagesBookValid = uint.TryParse(Console.ReadLine(), out pagesBook);
            bool campingDaysValid = uint.TryParse(Console.ReadLine(), out campingDays);
            bool pagesPerDayValid = uint.TryParse(Console.ReadLine(), out pagesPerDay);

            if (pagesBookValid & campingDaysValid & pagesPerDayValid)
            {
                if (campingDays == 30 || pagesPerDay == 0)
                {
                    Console.WriteLine("never");
                }
                else
                {
                    uint readDaysInMonth = 30u - campingDays;
                    uint pagesPerMonth = pagesPerDay * readDaysInMonth;
                    uint neededMonths = (uint)(Math.Ceiling((double)pagesBook / pagesPerMonth));

                    uint years = neededMonths / 12;
                    uint months = neededMonths % 12;

                    Console.WriteLine("{0} years {1} months", years, months);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
