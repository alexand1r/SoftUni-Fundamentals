using System;

namespace _1.PrintingNumbers
{
    class PrintingNumbers
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            PrintEvenNumbers(a, b);
        }

        static void PrintEvenNumbers(int a, int b)
        {
            int minRange = a;
            int maxRange = b;
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }
    }
}
