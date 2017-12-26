using System;
using System.Collections;
using System.Collections.Generic;

namespace _1.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = Fib(n);
            Console.WriteLine(result);
        }

        static int Fib(int n)
        {
            int a = 0;
            int b = 1;
            int c = 1;

            for (int i = 0; i < n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
