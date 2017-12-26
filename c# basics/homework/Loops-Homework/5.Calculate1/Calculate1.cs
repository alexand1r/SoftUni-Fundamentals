using System;
using System.Numerics;

namespace _5.Calculate1
{
    class Calculate1
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            decimal sum = 1;
            decimal factoriel = 1;
            int num = 0;

            for (int i = 1; i <= n; i++)
            {
                num = i;
                do
                {
                    factoriel *= num;
                    num--;
                }
                while (num > 0);

                sum += factoriel / (decimal)Math.Pow(x, i);
                factoriel = 1;
            }
            Console.WriteLine("{0:F5}", sum);
        }
    }
}
