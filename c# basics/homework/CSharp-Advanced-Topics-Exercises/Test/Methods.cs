using System;

namespace Test
{
    class Methods
    {
        public static double Divide(int a, int b)
        {
            double result = 0;
            if (b != 0)
            {
                result = (double)a / b;
            }
            return result;
        }

        public static void PrintMatrix(int n)
        {
            PrintMatrix(n, n);
        }

        public static void PrintMatrix(int n, int m)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", j + i);
                }
                Console.WriteLine();
            }
        }

        public static void Reorder(int[] array)
        {
            int a = array[0];
            array[0] = array[array.Length - 1];
            array[array.Length - 1] = a;
        }

        public static int[,] CreateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = i + j + 1;
                }
            }
            return matrix;
        }
    }
}
