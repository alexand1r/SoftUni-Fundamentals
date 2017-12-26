using System;
using System.Numerics;

namespace _8.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
        
            int n2 = 2 * n;
            int n1 = n + 1;
            BigInteger n2Factoriel = 1;
            BigInteger n1Factoriel = 1;
            BigInteger nFactoriel = 1;

            do
            {
                n2Factoriel *= n2;
                n2--;
                if (n1 > 0)
                {
                    n1Factoriel *= n1;
                    n1--;
                }
                if (n > 0)
                {
                    nFactoriel *= n;
                    n--;
                }
            }
            while (n2 > 0);

            BigInteger catalan = n2Factoriel / (n1Factoriel * nFactoriel);
            
            Console.WriteLine(catalan);
        }
    }
}
