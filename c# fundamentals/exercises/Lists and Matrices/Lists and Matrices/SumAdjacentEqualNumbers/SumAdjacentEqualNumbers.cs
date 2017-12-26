using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToList();
            int pos = 0;
            while (pos < nums.Count - 1)
                if (nums[pos] == nums[pos + 1])
                {
                    nums.RemoveAt(pos);
                    nums[pos] = 2 * nums[pos];
                    if (pos > 0) pos--; 
                }
                else pos++;
            Console.WriteLine(string.Join(" ", nums));

        }
    }
}
