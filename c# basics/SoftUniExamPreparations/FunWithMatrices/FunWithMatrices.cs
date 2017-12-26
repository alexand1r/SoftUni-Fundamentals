using System;

namespace FunWithMatrices
{
    class FunWithMatrices
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            double[,] matrix = new double[4, 4];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = value + (4d * row + col) * step; ;
                }
            }

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        Console.Write("{0,10}", matrix[row, col]);
            //    }
            //    Console.WriteLine();
            //}

            string command = Console.ReadLine();

            while (command != "Game Over!")
            {
                string[] input = command.Split(' ');
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);
                string action = input[2];
                double number = double.Parse(input[3]);
                 
                if (action == "multiply")
                {
                    matrix[row, col] = matrix[row,col] * number;
                }
                else if (action == "sum") 
                {
                    matrix[row, col] = matrix[row,col] + number;
                }
                else
                {
                    matrix[row, col] = Math.Pow(matrix[row, col], number);
                }

                command = Console.ReadLine();
            }

            double rowCount = 0;
            double rowMax = 0;
            int rowMaxIndex = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    rowCount += matrix[i, j];
                }
                if (rowCount > rowMax)
                {
                    rowMax = rowCount;
                    rowMaxIndex = i;
                }
                rowCount = 0;
            }
            Console.WriteLine(rowMax);

            double colCount = 0;
            double colMax = 0;
            int colMaxIndex = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    colCount += matrix[j, i];
                }
                if (colCount > colMax)
                {
                    colMax = colCount;
                    colMaxIndex = i;
                }
                colCount = 0;
            }
            Console.WriteLine(colMax);

            double leftDiagonalCount = 0;
            for (int i = 0, j = 0; i < matrix.GetLength(0); i++, j++)
            {
                leftDiagonalCount += matrix[i, j];
            }
            Console.WriteLine(leftDiagonalCount);

            double rightDiagonalCount = 0;
            for (int i = 0, j = matrix.GetLength(0) - 1; i < matrix.GetLength(0) && j > 0; i++, j--)
            {
                rightDiagonalCount += matrix[i, j];
            }
            Console.WriteLine(rightDiagonalCount);

            if (rowMax >= colMax && rowMax >= leftDiagonalCount && rowMax >= rightDiagonalCount)
            {
                Console.WriteLine("ROW[{0}] = {1:F2}", rowMaxIndex, rowMax);
            }
            else if (colMax > rowMax && colMax >= leftDiagonalCount && colMax >= rightDiagonalCount)
            {
                Console.WriteLine("COLUMN[{0}] = {1:F2}", colMaxIndex, colMax);
            }
            else if (leftDiagonalCount > rowMax && leftDiagonalCount > colMax && leftDiagonalCount >= rightDiagonalCount)
            {
                Console.WriteLine("LEFT-DIAGONAL = {0:F2}", leftDiagonalCount);
            }
            else if (rightDiagonalCount > rowMax && rightDiagonalCount > colMax && rightDiagonalCount > leftDiagonalCount)
            {
                Console.WriteLine("LEFT-DIAGONAL = {0:F2}", leftDiagonalCount);
            }
        }
    }
}
