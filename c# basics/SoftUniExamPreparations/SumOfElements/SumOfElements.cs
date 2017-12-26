using System;

namespace SumOfElements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string[] numbers = inputLine.Split(' ');
            int[] nums = Array.ConvertAll(numbers, int.Parse);

            decimal max = int.MinValue;
            decimal sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            if (sum == 2 * max)
            {
                Console.WriteLine("Yes, sum=" + max);
            }
            else
            {
                decimal diff = Math.Abs(sum - 2 * max);
                Console.WriteLine("No, diff=" + diff);
            }
        }
    }
}
