using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            var query = arr.GroupBy(item => item)
                .OrderByDescending(g => g.Count()).Select(g => g.Key).First();

            Console.WriteLine(query);
        }
    }
}
