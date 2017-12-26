using System;

namespace _6.Calculate2
{
    class Calculate2
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            decimal nFactoriel = 1;
            decimal kFactoriel = 1;
            decimal result = 0;

            do
            {
                nFactoriel *= n;
                n--;
                if (k > 0)
                {
                    kFactoriel *= k;
                    k--;
                }
            }
            while (n > 0);

            result = nFactoriel / kFactoriel;
            Console.WriteLine(result);
        }
    }
}
