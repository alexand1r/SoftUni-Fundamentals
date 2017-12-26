using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HourglassSum
{
    class HourglassSum
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[6, 6];
            for (int i = 0; i < 6; i++)
            {
                int[] arr = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < 6; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            int sum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                                       + matrix[i + 1, j + 1] 
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
