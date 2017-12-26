using System;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            uint n;
            bool valid = uint.TryParse(Console.ReadLine(), out n);
            if (valid)
            {
                uint zero = (~((7u << 3) | (7u << 24)) & n);
                uint move242526 = ((n&(7u << 24)) >> 21);
                uint move345 = ((n & (7u << 3)) << 21);
                n = zero | move242526 | move345;

                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
