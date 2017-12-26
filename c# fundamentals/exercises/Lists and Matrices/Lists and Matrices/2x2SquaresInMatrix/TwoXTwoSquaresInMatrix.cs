using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2x2SquaresInMatrix
{
    class TwoXTwoSquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] matrix = new char[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                char[] arr = Console.ReadLine().Split()
                    .Select(char.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = arr[j];
                }
            }

            int counter = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    if (matrix[i, j] == matrix[i + 1, j] &&
                        matrix[i, j] == matrix[i, j + 1] &&
                        matrix[i, j + 1] == matrix[i + 1, j + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);


            // ****** printing matrix ******
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
