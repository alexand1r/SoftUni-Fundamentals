using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(new char[] { ' ' }
                , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> result = new List<int>();

            for (int i = 0; i <= 2000000; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if (i * i == nums[j])
                    {
                        result.Add(nums[j]);
                    }
                }
            }

            //foreach (var num in nums)
            //{
            //    double sq1 = num * num;
            //    int sq2 = num * num;
            //    if (sq1 == (double)sq2)
            //        result.Add(num);
            //}
            result.Sort((x,y) => y.CompareTo(x));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
    