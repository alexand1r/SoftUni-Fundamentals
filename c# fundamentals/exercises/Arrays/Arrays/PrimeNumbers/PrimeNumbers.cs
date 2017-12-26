using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];
            for (long i = 2; i <= n; i++)
            {
                primes[i] = true;
            }
            primes[0] = false;
            primes[1] = false;
            List<long> list = new List<long>();
            for (long i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    list.Add(i);
                    long k = i;
                    for (long j = 2 * i; j <= n; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
