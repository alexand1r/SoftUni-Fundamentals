using System;
using System.Globalization;

namespace _4.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            string dt01 = Console.ReadLine();
            string dt02 = Console.ReadLine();
            DateTime dt1;
            DateTime dt2;
            bool validdt1 = DateTime.TryParseExact(dt01, "dd.MM.yyyy", CultureInfo.InvariantCulture,
        DateTimeStyles.None, out dt1);
            bool validdt2 = DateTime.TryParseExact(dt02, "dd.MM.yyyy", CultureInfo.InvariantCulture,
        DateTimeStyles.None, out dt2);
            double NrOfDays = 0;
            if (validdt1 && validdt2)
            {
                if (dt1 > dt2)
                {
                    TimeSpan t = dt1 - dt2;
                    NrOfDays = t.TotalDays;
                    Console.WriteLine(NrOfDays);
                }
                else
                {
                    TimeSpan t = dt2 - dt1;
                    NrOfDays = t.TotalDays;
                    Console.WriteLine(NrOfDays);
                }
            }
            else Console.WriteLine("error");
        }
    }
}
