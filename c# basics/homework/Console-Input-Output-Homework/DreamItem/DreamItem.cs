using System;

namespace DreamItem
{
    class DreamItem
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\');

            string month = input[0];
            decimal moneyPerHour = decimal.Parse(input[1]);
            decimal hoursPerDay = decimal.Parse(input[2]);
            decimal itemPrice = decimal.Parse(input[3]);

            int workingDays = 0;

            switch (month)
            {
                case "Feb": workingDays = 18; break;
                case "Apr":
                case "June":
                case "Sept":
                case "Nov": workingDays = 20; break;
                default: workingDays = 21; break;
            }

            decimal moneyAll = workingDays * moneyPerHour * hoursPerDay;
            if (moneyAll > 700)
            {
                moneyAll += 0.1M * moneyAll;
            }

            if (moneyAll - itemPrice < 0)
            {
                Console.WriteLine("Not enough money. {0:F2} leva needed.", itemPrice - moneyAll);
            }
            else
            {
                Console.WriteLine("Money left = {0:F2} leva.", moneyAll - itemPrice);
            }
        }
    }
}
