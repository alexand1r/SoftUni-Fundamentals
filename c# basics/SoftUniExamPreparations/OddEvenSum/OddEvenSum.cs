using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[2 * n];
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    oddSum += nums[i];
                }
                else if (i % 2 == 1)
                {
                    evenSum += nums[i];
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum={0}", oddSum);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
