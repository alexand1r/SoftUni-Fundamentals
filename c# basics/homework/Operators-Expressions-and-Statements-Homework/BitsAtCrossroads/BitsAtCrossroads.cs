using System;

namespace BitsAtCrossroads
{
    class BitsAtCrossroads
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] matrix = new int[size];
            int crossroads = 0;

            string command = Console.ReadLine();

            while (command != "end")
            {
                int row = int.Parse(command.Split()[0]);
                int column = int.Parse(command.Split()[1]);

                crossroads++;

                matrix[row] |= 1 << column;

                FillPath(row - 1, column + 1, matrix, -1, 1, ref crossroads);
                FillPath(row + 1, column - 1, matrix, 1, -1, ref crossroads);
                FillPath(row + 1, column + 1, matrix, 1, 1, ref crossroads);
                FillPath(row - 1, column - 1, matrix, -1, -1, ref crossroads);

                command = Console.ReadLine();
            }
            foreach (var number in matrix)
            {
                Console.WriteLine((uint)number);
            }

            Console.WriteLine(crossroads);

        }
        public static void FillPath(
            int currentRow,
            int currentColumn,
            int[] matrix,
            int rowUpdate,
            int colUpdate,
            ref int crossroads)
        {
            while (AreCoordinatesValid(currentRow, currentColumn, matrix.Length))
            {
                if (((matrix[currentRow] >> currentColumn) & 1) == 1)
                {
                    crossroads++;
                }

                matrix[currentRow] |= 1 << currentColumn;

                currentRow += rowUpdate;
                currentColumn += colUpdate;
            }
        }

        public static bool AreCoordinatesValid(int row, int col, int size)
        {
            bool isRowValid = 0 <= row && row < size;
            bool isColValid = 0 <= col && col < size;

            return isRowValid && isColValid;
        }
    }
}