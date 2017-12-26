using System;

namespace PiggyBank
{
    class PiggyBank
    {
        static void Main(string[] args)
        {
            decimal tankPrice = decimal.Parse(Console.ReadLine());
            int partyDaysInMonth = int.Parse(Console.ReadLine());

            int normalDaysInMonth = 30 - partyDaysInMonth;
            int moneySaved = normalDaysInMonth * 2;
            int moneySpend = partyDaysInMonth * 5;

            int moneySavedPerMonth = moneySaved - moneySpend;
            decimal monthsNeeded = tankPrice / moneySavedPerMonth;

            decimal years = monthsNeeded / 12m;
            decimal months = monthsNeeded % 12m;
            
            if (monthsNeeded <= 0)
            {
                Console.WriteLine("never");
            }
            else if(Math.Ceiling(months) == 12)
            {
                months = 0;
                years++;
                Console.WriteLine("{0:0} years, {1} months"
                   , Math.Floor(years), Math.Ceiling(months));
            }
            else
            {
                Console.WriteLine("{0:0} years, {1} months"
                   , Math.Floor(years), Math.Ceiling(months));
            }
            //int price = int.Parse(Console.ReadLine());
            //int partyDays = int.Parse(Console.ReadLine());
            //if (partyDays > 8)
            //{
            //    Console.WriteLine("never");
            //}
            //else
            //{
            //    int normalDays = 30 - partyDays;

            //    int monthlySavings = normalDays * 2;
            //    int monthlyExpenses = partyDays * 5;
            //    int monthlyBalance = monthlySavings - monthlyExpenses;

            //    double totalMonthsRequired = (double)price / monthlyBalance;
            //    int result = (int)Math.Ceiling(totalMonthsRequired);
            //    int years = result / 12;
            //    int months = result % 12;
            //    Console.WriteLine("{0} years, {1} months", years, months);
            }
    }
}
