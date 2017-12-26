using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool found = false;

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    int c = arr[a] + arr[b];
                    if (arr.Contains(c))
                    {
                        found = true;
                        Console.WriteLine("{0} + {1} == {2}", arr[a], arr[b], c);
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
