using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal c = decimal.Parse(Console.ReadLine());
            decimal f = decimal.Parse(Console.ReadLine());
            decimal t = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal cakePrice = 0;
            decimal kilogramNeeded = 0;

            decimal kilograms = f / c;
            if (kilograms >= n)
            {
                decimal truffleCost = t * p;
                cakePrice = (truffleCost / n) * 1.25m;
                Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
            }
            else
            {
                decimal totalFlourNeeded = n * c;
                kilogramNeeded = totalFlourNeeded - f;
                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour", (int)kilograms, kilogramNeeded);
            }
        }
    }
}
