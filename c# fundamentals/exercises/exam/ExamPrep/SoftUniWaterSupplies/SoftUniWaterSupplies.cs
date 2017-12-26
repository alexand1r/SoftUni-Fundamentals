using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniWaterSupplies
{
    class SoftUniWaterSupplies
    {
        static void Main(string[] args)
        {
            var totalAmountOfWater = long.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(' ')
                .Select(decimal.Parse).ToArray();
            var capacityOfBottles = long.Parse(Console.ReadLine());

            var bottlesLeft = 0;
            var indexesOfLeftBottles = new List<int>();
            decimal litersFilled = 0m;
            
            if (totalAmountOfWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Count(); i++)
                    Liters(totalAmountOfWater, bottles, capacityOfBottles, ref bottlesLeft, indexesOfLeftBottles, ref litersFilled, i);
            }
            else
            {
                for (int i = bottles.Count() - 1; i >= 0; i--)
                {
                    Liters(totalAmountOfWater, bottles, capacityOfBottles, ref bottlesLeft, indexesOfLeftBottles, ref litersFilled, i);
                }
            }

            if (litersFilled > totalAmountOfWater)
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {bottlesLeft}");
                Console.WriteLine($"With indexes: {string.Join(", ", indexesOfLeftBottles)}");
                Console.WriteLine($"We need {litersFilled - totalAmountOfWater} more liters!");
            }
            else
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalAmountOfWater - litersFilled}l.");
            }
        }

        private static void Liters(long totalAmountOfWater, decimal[] bottles, long capacityOfBottles, ref int bottlesLeft, List<int> indexesOfLeftBottles, ref decimal litersFilled, int i)
        {
            litersFilled += capacityOfBottles - bottles[i];
            if (litersFilled > totalAmountOfWater)
            {
                bottlesLeft++;
                indexesOfLeftBottles.Add(i);
            }
        }
    }
}
