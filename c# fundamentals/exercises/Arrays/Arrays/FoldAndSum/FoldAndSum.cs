using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int k = nums.Length / 4;

            int[] arr1 = nums.Take(k).ToArray();
            Array.Reverse(arr1);
            int[] arr2 = nums.Skip(nums.Length - k).Take(k).ToArray();
            Array.Reverse(arr2);
            int[] arr3 = arr1.Concat(arr2).ToArray();
            int[] arr4 = new int[nums.Length - 2 * k];
            for (int i = k; i < nums.Length - k; i++)
            {
                arr4[i - k] = nums[i];
            }
            int[] sum = new int[arr4.Length];
            for (int i = 0; i < arr4.Length; i++)
            {
                sum[i] = arr3[i] + arr4[i];
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
