using System;

namespace BabaTincheAirlines
{
    class BabaTincheAirlines
    {
        static void Main(string[] args)
        {
            string[] firstClass = Console.ReadLine().Split();
            int passengersFirstClass = int.Parse(firstClass[0]);
            int frequentFirstClass = int.Parse(firstClass[1]);
            int mealsFirstClass = int.Parse(firstClass[2]);
            string[] businessClass = Console.ReadLine().Split();
            int passengerBusinessClass = int.Parse(businessClass[0]);
            int frequentBusinessClass = int.Parse(businessClass[1]);
            int mealsBusinessClass = int.Parse(businessClass[2]);
            string[] economyClass = Console.ReadLine().Split();
            int passengerEconomyClass = int.Parse(economyClass[0]);
            int frequentEconomyClass = int.Parse(economyClass[1]);
            int mealsEconomyClass = int.Parse(economyClass[2]);

            int normalFirstClassPassengers = passengersFirstClass - frequentFirstClass;
            int normalBusinessClassPassengers = passengerBusinessClass - frequentBusinessClass;
            int normalEconomyClassPassengers = passengerEconomyClass - frequentEconomyClass;

            double firstClassTicket = 7000;
            double businessClassTicket = 3500;
            double economyClassTicket = 1000;

            double frequentFirstClassTicket = firstClassTicket - (70 * firstClassTicket / 100);
            double frequentBusinessClassTicket = businessClassTicket - (70 * businessClassTicket / 100);
            double frequentEconomyClassTicket = economyClassTicket - (70 * economyClassTicket / 100);

            double maximumIncome = 12d * (firstClassTicket + 0.5d * firstClassTicket / 100d)
                + 28d * (businessClassTicket + 0.5d * businessClassTicket / 100d)
                + 50d * (economyClassTicket + 0.5d * economyClassTicket / 100d);

            double firstClassMeal = 0.5d * firstClassTicket / 100d;
            double businessClassMeal = 0.5d * businessClassTicket / 100d;
            double economyClassMeal = 0.5d * economyClassTicket / 100d;

            double income = normalFirstClassPassengers * firstClassTicket + mealsFirstClass * firstClassMeal + frequentFirstClass * frequentFirstClassTicket
                + normalBusinessClassPassengers * businessClassTicket + mealsBusinessClass * businessClassMeal + frequentBusinessClass * frequentBusinessClassTicket
                + normalEconomyClassPassengers * economyClassTicket + mealsEconomyClass * economyClassMeal + frequentEconomyClass * frequentEconomyClassTicket;

            Console.WriteLine((int)income);
            Console.WriteLine(Math.Ceiling(maximumIncome - income));
        }
    }
}
