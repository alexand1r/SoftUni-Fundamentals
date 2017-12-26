using System;

namespace Problem_6.Pure_Divisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine((n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0) ? true : false);
        }
    }
}
