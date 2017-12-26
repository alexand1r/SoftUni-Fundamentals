using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int k = int.Parse(Console.ReadLine());
            int[] arr2 = new int[arr.Length];
            int[] sum = new int[arr.Length];
            bool sumEmpty = false;

            for (int i = 0; i < k; i++)
            {
                int temp = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr2[j] = arr[j - 1];
                }
                arr2[0] = temp;

                if (!sumEmpty)
                {
                    for (int g = 0; g < arr.Length; g++)
                    {
                        sum[g] = arr2[g];
                    }
                    sumEmpty = true;
                }
                else
                {
                    for (int e = 0; e < sum.Length; e++)
                    {
                        sum[e] = sum[e] + arr2[e];
                    }
                }

                for (int g = 0; g < arr.Length; g++)
                {
                    arr[g] = arr2[g];
                }
                
            }
            
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
