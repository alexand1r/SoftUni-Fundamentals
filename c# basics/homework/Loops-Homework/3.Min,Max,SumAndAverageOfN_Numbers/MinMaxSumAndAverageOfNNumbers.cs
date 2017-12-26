using System;
using System.Collections;
using System.Collections.Generic;

namespace _3.Min_Max_SumAndAverageOfN_Numbers
{
    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int num = 0, min = Int32.MaxValue, max = Int32.MinValue, sum = 0;
            double avg = 0;
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("number[{0}]: ", i);
                num = int.Parse(Console.ReadLine());
                nums.Add(num);
            }
        
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] < min) min = nums[i];
                if (nums[i] > max) max = nums[i];
                sum += nums[i];
            }
            avg = sum / n;
            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:F2}", min, max, sum, avg);
        }
    }
}
