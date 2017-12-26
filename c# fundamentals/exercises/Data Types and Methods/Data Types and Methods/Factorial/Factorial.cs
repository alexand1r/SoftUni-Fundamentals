using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger facN = FactorialN(n);

            Console.WriteLine(facN);
        }

        private static BigInteger FactorialN(int n)
        {
            if (n <= 1)
                return 1;
            return n * FactorialN(n - 1);
        }
    }
}
