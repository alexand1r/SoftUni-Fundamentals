using System;

namespace _7.Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            double nFactoriel = 1;
            double kFactoriel = 1;
            int nk = n - k;
            double nkFactoriel = 1;
            double result = 0;

            do
            {
                if (nk > 0)
                {
                    nkFactoriel *= nk;
                    nk--;
                }

                nFactoriel *= n;
                n--;

                if (k > 0)
                {
                    kFactoriel *= k;
                    k--;
                }
            }
            while (n > 0);

            result = nFactoriel / (kFactoriel * nkFactoriel);
            Console.WriteLine(result);
        }
    }
}
