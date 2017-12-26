using System;

namespace Tetris
{
    class Tetris
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int[] size = Array.ConvertAll(input, int.Parse);
            int height = size[0];
            int width = size[1];
            string[,] matrix = new string[height, width];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string line = Console.ReadLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = line[j].ToString();
                }
            }
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write("{0}", matrix[i,j]);
            //    }
            //    Console.WriteLine();
            //}
            int oCount = 0, iCount = 0, lCount = 0, jCount = 0, zCount = 0, sCount = 0, tCount = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == "o" && matrix[i, j + 1] == "o" && matrix[i + 1, j + 1] == "o" && matrix[i + 1, j] == "o")
                    {
                        oCount++;
                    }
                    else if (i + 3 <= height)
                    {
                        if (matrix[i, j] == "o" && matrix[i + 1, j] == "o" && matrix[i + 2, j] == "o" && matrix[i + 3, j] == "o")
                        {
                            iCount++;
                        }
                        if (matrix[i, j] == "o" && matrix[i + 1, j] == "o" && matrix[i + 2, j] == "o" && matrix[i + 2, j + 1] == "o")
                        {
                            lCount++;
                        }
                        if (matrix[i, j] == "o" && matrix[i + 1, j] == "o" && matrix[i + 2, j] == "o" && matrix[i + 2, j - 1] == "o")
                        {
                            jCount++;
                        }
                    }
                }
            }

            Console.WriteLine(oCount);
            Console.WriteLine(iCount);
            Console.WriteLine(lCount);
            Console.WriteLine(jCount);
        }
    }
}
