using System;
using System.Collections;
using System.Collections.Generic;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            
            Console.WriteLine(Fib(n));
        }

        private static uint Fib(uint n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            uint a = 0;
            uint b = 1;
            uint c = 1;

            for (uint i = 0; i < n; i++)
            {
                c = b + a;
                a = b;
                b = c;
            }
            return c;
        }
    }
}
