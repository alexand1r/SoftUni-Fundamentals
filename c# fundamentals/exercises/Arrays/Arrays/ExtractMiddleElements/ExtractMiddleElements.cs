using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElements
{
    class ExtractMiddleElements
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int len = nums.Length;
            Console.Write("{ ");
            if (len == 1)
            {
                Console.Write("{0}", nums.First());
            }
            else if (len % 2 == 0)
            {
                Console.Write("{0} {1}"
                    , nums[len / 2 - 1], nums[len / 2]);
            }
            else if (len % 2 == 1)
            {
                Console.Write("{0} {1} {2}"
                    , nums[len / 2 - 1], nums[len / 2], nums[len / 2 + 1]);
            }
            Console.Write(" }");
        }
    }
}
