using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var item in arr)
            {
                Console.WriteLine("{0} => {1}"
                    , item
                    , Math.Round(item
                    , MidpointRounding.AwayFromZero));
            }
        }
    }
}
