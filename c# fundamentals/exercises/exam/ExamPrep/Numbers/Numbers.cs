using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Numbers
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            decimal average = (decimal)nums.Sum() / (decimal)nums.Count();
            var leftNums = nums.Where(n => n > average).OrderByDescending(n => n).Take(5).ToList();
            if (leftNums.Count() <= 0)
                Console.WriteLine("No");
            else
                Console.WriteLine(string.Join(" ", leftNums));
        }
    }
}
