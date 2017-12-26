using System;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int max = a > b ? a : b;
            int min = a < b ? a : b;
            int n = 1;

            do
            {
                n = max - min;
                max = min;
                min = n;
            }
            while (n != 0);

            Console.WriteLine(max);
        }
    }
}
