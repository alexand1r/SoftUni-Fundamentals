using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDifference
{
    class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftDiagonal = 0;
            int rightDiagonal = 0;
            int absoluteDiagonal = 0;

            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                int[] arr = Console.ReadLine().Split()
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < arr.Length; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                leftDiagonal += matrix[i, i];
            }

            for (int i = 0, j = n - 1; i < n; i++, j--)
            {
                rightDiagonal += matrix[i, j];
            }

            absoluteDiagonal = Math.Abs(leftDiagonal - rightDiagonal);
            Console.WriteLine(absoluteDiagonal);

        }
    }
}
