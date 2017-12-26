using System;
using System.Collections.Generic;

namespace TicTacToePower
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int value = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[3,3];
            int[,] matrix2 = new int[3,3];
            int value2 = 1;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    matrix1[i, j] = value + j * 1;
                    matrix2[i, j] = value2 + j * 1;
                }
                value += 3;
                value2 += 3;
            }
            Console.WriteLine(Math.Pow(matrix1[y,x], matrix2[y,x]));
        }
//        int x = int.Parse(Console.ReadLine());
//        int y = int.Parse(Console.ReadLine());
//        int firstValue = int.Parse(Console.ReadLine());

//        long result = 0;
//        int position = x + 1;  // 1, 2, 3
//		if (y == 1)
//		{
//			position = x + 4;  // 4, 5, 6
//		}
//		else if (y == 2)
//		{
//			position = x + 7;  // 7, 8, 9
//		}
//      firstValue += position - 1; 
//		result = (long)Math.Pow(firstValue, position);
//		Console.WriteLine(result);
    }
}
