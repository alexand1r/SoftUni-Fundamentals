using System;
using System.Numerics;

namespace _18.TrailingZeroesInNFac
{
    class TrailingZeroesInNFac
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger zeros = 0;
            int k = 1;
            
             do
                {
                    zeros += n / (BigInteger)Math.Pow(5, k);
                    k++;
                }
            while ((BigInteger)(Math.Pow(5, k + 1)) > n);

            Console.WriteLine(zeros);
            Console.WriteLine();
        }
    }
}
