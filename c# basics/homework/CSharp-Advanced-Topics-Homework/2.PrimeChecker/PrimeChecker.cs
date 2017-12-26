using System;

namespace _2.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool result = IsPrime(n);
            Console.WriteLine(result);
        }

        static bool IsPrime(int n)
        {
            int maxdivider = (int)Math.Sqrt(n);
            bool prime = true;
            if (n == 0) prime = false;
            if (n == 1) prime = false;
            if (n == 2) prime = true;
            for (int i = 2; i <= maxdivider; ++i)
            {
                if (n % i == 0)
                {
                    prime = false;
                }
                else
                {
                    prime = true;
                }
            }
            return prime;
        }
        }
    }
}
