using System;

namespace _11.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[n];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for(int i = 2; i <= n - 1; i++)
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            for (int i = 0; i <= fibonacci.Length - 1; i++)
            {
                Console.Write("{0} ", fibonacci[i]);
            }
        }
    }
}
