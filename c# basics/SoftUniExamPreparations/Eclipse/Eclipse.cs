﻿using System;

namespace Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" {0}{1}{0} ", new string('*', 2 * n - 2), new string(' ', n + 1));
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string(' ', n - 1));
            }
            Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string('-', n - 1));
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', 2 * n - 2), new string(' ', n - 1));
            }
            Console.WriteLine(" {0}{1}{0} ", new string('*', 2 * n - 2), new string(' ', n + 1));
        }
    }
}
