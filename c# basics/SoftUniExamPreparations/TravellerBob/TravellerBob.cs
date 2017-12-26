using System;

namespace TravellerBob
{
    class TravellerBob
    {
        static void Main(string[] args)
        {
            double totalTravels = 0;

            string month = Console.ReadLine();
            int contractMonths = int.Parse(Console.ReadLine());
            int familyMonths = int.Parse(Console.ReadLine());

            totalTravels += contractMonths * 12d;
            totalTravels += familyMonths * 4d;
            totalTravels += ((12 - contractMonths - familyMonths) * 12d) * (3d / 5d);

            if (month == "leap")
            {
                totalTravels += 5 * totalTravels / 100;
            }

            Console.WriteLine((int)totalTravels);
        }
    }
}
