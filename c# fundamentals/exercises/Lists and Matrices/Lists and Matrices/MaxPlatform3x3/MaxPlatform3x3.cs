using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPlatform3x3
{
    class MaxPlatform3x3
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            long[,] matrix = new long[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                long[] arr = Console.ReadLine().Split()
                    .Select(long.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            long sum = 0;
            long maxSum = long.MinValue;
            int wantedRow = 0;
            int wantedCol = 0;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < cols - 2; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                        + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                        + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        wantedCol = j;
                        wantedRow = i;
                    }
                }
            }

            Console.WriteLine(maxSum);
            for (int i = wantedRow; i < wantedRow + 3; i++)
            {
                for (int j = wantedCol; j < wantedCol + 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
