using System;

namespace _3.NumberAsDayOfWeek
{
    class NumberAsDayOfWeek
    {
        static void Main(string[] args)
        {
            int day;
            bool dayValid = int.TryParse(Console.ReadLine(), out day);
            if (dayValid)
            {
                switch (day)
                {
                    case 1: Console.WriteLine("Monday"); break;
                    case 2: Console.WriteLine("Tuesday"); break;
                    case 3: Console.WriteLine("Wednsday"); break;
                    case 4: Console.WriteLine("Thursday"); break;
                    case 5: Console.WriteLine("Friday"); break;
                    case 6: Console.WriteLine("Saturday"); break;
                    case 7: Console.WriteLine("Sunday"); break;
                    default: Console.WriteLine("Invalid Input!"); break;
                }
            }
            else
            {
                Console.WriteLine("Invalid Input!");
            }
        }
    }
}
