using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split().ToArray();
            List<int> numbers = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                string num = new string(nums[i].Reverse().ToArray());
                numbers.Add(int.Parse(num));
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
