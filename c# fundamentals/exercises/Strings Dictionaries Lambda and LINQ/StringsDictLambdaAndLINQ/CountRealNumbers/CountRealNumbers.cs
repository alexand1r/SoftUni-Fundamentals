using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ')
                    .Select(double.Parse).ToList();
            var counts = new SortedDictionary<double, int>();
            foreach (var num in nums)
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            foreach (var num in counts.Keys)
                Console.WriteLine($"{num} -> {counts[num]}");

        }
    }
}
