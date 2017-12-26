using System;

namespace Budget
{
    class Budget
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int goOutWeekDays = int.Parse(Console.ReadLine());
            int hometownWeekends = int.Parse(Console.ReadLine());

            int normalWeekends = 4 - hometownWeekends;
            int normalWeekDays = 22 - goOutWeekDays;

            decimal goOutWeekDaysSpendings = goOutWeekDays * (decimal)(Math.Floor(3m * amountOfMoney / 100m) + 10m);
            decimal normalWeekendsSpendings = normalWeekends * 40m;
            decimal normalWeekDaysSpendings = normalWeekDays * 10m;
            decimal rent = 150m;

            decimal total = goOutWeekDaysSpendings 
                + normalWeekDaysSpendings 
                + normalWeekendsSpendings + rent;

            if (amountOfMoney > total)
            {
                Console.WriteLine("Yes, leftover {0}.", amountOfMoney - total);
            }
            else if (amountOfMoney == total)
            {
                Console.WriteLine("Exact Budget.");
            }
            else
            {
                Console.WriteLine("No, not enough {0}.", total - amountOfMoney);
            }
        }
    }
}
