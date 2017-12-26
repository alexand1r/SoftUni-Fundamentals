using System;
using System.Numerics;

namespace WiggleWiggle
{
    class WiggleWiggle
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            for (int k = 0; k < input.Length - 1; k += 2)
            {
                ulong n = Convert.ToUInt64(input[k]);
                ulong m = Convert.ToUInt64(input[k + 1]);

                for (int i = 0; i < 64; i += 2)
                {
                    if ((n & (1uL << i)) == (m & (1uL << i)))
                    {
                        continue;
                    }
                    else
                    {
                        n ^= 1uL << i;
                        m ^= 1uL << i;
                    }
                }

                n = ~n;
                m = ~m;

                n = n ^ (1ul << 63);
                m = m ^ (1ul << 63);

                string ns = Convert.ToString((long)n, 2).PadLeft(63, '0');
                string ms = Convert.ToString((long)m, 2).PadLeft(63, '0');

                Console.WriteLine(n + " " + ns);
                Console.WriteLine(m + " " + ms);
            }
        }
    }
}