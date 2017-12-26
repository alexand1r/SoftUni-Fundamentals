using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniAirline
{
    class SoftUniAirline
    {
        static void Main(string[] args)
        {
            var n = decimal.Parse(Console.ReadLine());
            var profits = new List<decimal>();

            for (int i = 0; i < n; i++)
            {
                var adultPassengersCount = decimal.Parse(Console.ReadLine());
                var adultTicketPrice = decimal.Parse(Console.ReadLine());
                var youthPassengersCount = decimal.Parse(Console.ReadLine());
                var youthTicketPrice = decimal.Parse(Console.ReadLine());
                var fuelPricePerHour = decimal.Parse(Console.ReadLine());
                var fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                var flightDuration = decimal.Parse(Console.ReadLine());

                var income = (adultPassengersCount * adultTicketPrice)
                    + (youthPassengersCount * youthTicketPrice);
                var expense = fuelConsumptionPerHour * fuelPricePerHour * flightDuration;
                var profit = income - expense;

                if (income >= expense)
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                else
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");

                profits.Add(profit);
            }
 
            var overallProfit = profits.Sum();
            var averageProfit = overallProfit / n;

            Console.WriteLine($"Overall profit -> {overallProfit:f3}$.");
            Console.WriteLine($"Average profit -> {averageProfit:f3}$.");
        }
    }
}
