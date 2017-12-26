using System;

namespace BeerStock
{
    class BeerStock
    {
        static void Main(string[] args)
        {
            long reservedBeers = long.Parse(Console.ReadLine());
            long totalAmountOfBeers = 0;
            string command = Console.ReadLine();
            while (!command.Equals("Exam Over"))
            {
                string[] input = command.Split(' ');
                long amount = long.Parse(input[0]);
                string type = input[1];
                switch (type){
                    case "cases": amount *= 24l; break;
                    case "sixpacks": amount *= 6l; break;
                    default: break;
                }
                totalAmountOfBeers += amount;

                command = Console.ReadLine();
            }
            if (totalAmountOfBeers >= 100)
            {
                totalAmountOfBeers -= totalAmountOfBeers / 100u;
            }
            if (totalAmountOfBeers >= reservedBeers)
            {
                long beersLeft = totalAmountOfBeers - reservedBeers;
                long casesLeft = beersLeft / 24;
                long sixpacksLeft = (beersLeft % 24) / 6;
                beersLeft -= casesLeft * 24 + sixpacksLeft * 6;
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers."
                    , casesLeft, sixpacksLeft, beersLeft);
            }
            else
            {
                long beersNeeded = reservedBeers - totalAmountOfBeers;
                long casesNeeded = beersNeeded / 24;
                long sixpacksNeeded = (beersNeeded % 24) / 6;
                beersNeeded -= casesNeeded * 24 + sixpacksNeeded * 6;
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers."
                    , casesNeeded, sixpacksNeeded, beersNeeded);
            }
        }
    }
}
