using System;

namespace _16.BitExchange_Advanced_
{
    class BitExchangeA
    {
        static void Main(string[] args)
        {
            uint n;
            byte p, q, k;
            bool nvalid = uint.TryParse(Console.ReadLine(), out n);
            bool pvalid = byte.TryParse(Console.ReadLine(), out p);
            bool qvalid = byte.TryParse(Console.ReadLine(), out q);
            bool kvalid = byte.TryParse(Console.ReadLine(), out k);

            if (nvalid&pvalid&qvalid&kvalid)
            {
                if ((p + k < 31) && (q + k < 31) && (Math.Abs(p - q) >= k))
                {
                    if (p > q)
                    {
                        byte temp = q;
                        q = p;
                        p = temp;
                    }
                    uint zero = (~((((uint)Math.Pow(2, k) - 1) << p) | (((uint)Math.Pow(2, k) - 1) << q)) & n);
                    uint moveq = (((((uint)Math.Pow(2, k) - 1) << q) & n) >> Math.Abs(p - q));
                    uint movep = (((((uint)Math.Pow(2, k) - 1) << p) & n) << Math.Abs(p - q));
                    n = zero | moveq | movep;
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("overlapping");
                }
            }
            else Console.WriteLine("Out Of Range!");
        }
    }
}
