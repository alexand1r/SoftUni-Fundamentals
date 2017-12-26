using System;

namespace JumpingSums
{
    class JumpingSums
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] nums = Array.ConvertAll(input, int.Parse);
            int jump = int.Parse(Console.ReadLine());
            int maxSum = Int32.MinValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];
                int currentIndex = i;
                int nextIndex = (currentIndex + value) % nums.Length;
                int sum = 0;

                for (int k = 0; k <= jump; k++)
                {
                    sum += value;
                    value = nums[nextIndex];
                    currentIndex = nextIndex;
                    nextIndex = (currentIndex + value) % nums.Length;
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
            Console.WriteLine("max sum = {0}", maxSum);
        }
    }
}
