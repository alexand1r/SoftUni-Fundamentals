using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetMultiplier
{
    class TargetMultiplier
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            long[,] matrix = new long[rows,cols];

            for (int row = 0; row < rows; row++)
            {
                long[] rowInit = Console.ReadLine().Split(' ')
                    .Select(long.Parse).ToArray();
                for (int col = 0; col < rowInit.Length; col++)
                {
                    matrix[row, col] = rowInit[col];
                }
            }

            int[] target = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            int targetRow = target[0];
            int targetCol = target[1];
            List<long> frameValues = new List<long>() { matrix[targetRow - 1, targetCol - 1]
                , matrix[targetRow - 1, targetCol], matrix[targetRow - 1, targetCol + 1]
                , matrix[targetRow, targetCol + 1], matrix[targetRow + 1, targetCol + 1]
                , matrix[targetRow + 1, targetCol], matrix[targetRow + 1, targetCol - 1]
                , matrix[targetRow, targetCol - 1] };
            long newValueTarget = 0;
            foreach (var value in frameValues)
            {
                newValueTarget += value;
            }
            newValueTarget *= matrix[targetRow, targetCol];
            matrix[targetRow - 1, targetCol - 1] *= matrix[targetRow, targetCol];
            matrix[targetRow - 1, targetCol] *= matrix[targetRow, targetCol];
            matrix[targetRow - 1, targetCol + 1] *= matrix[targetRow, targetCol];
            matrix[targetRow, targetCol + 1] *= matrix[targetRow, targetCol];
            matrix[targetRow + 1, targetCol + 1] *= matrix[targetRow, targetCol];
            matrix[targetRow + 1, targetCol] *= matrix[targetRow, targetCol];
            matrix[targetRow + 1, targetCol - 1] *= matrix[targetRow, targetCol];
            matrix[targetRow, targetCol - 1] *= matrix[targetRow, targetCol];
            matrix[targetRow, targetCol] = newValueTarget;
            // ***** printing the matrix *****
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}