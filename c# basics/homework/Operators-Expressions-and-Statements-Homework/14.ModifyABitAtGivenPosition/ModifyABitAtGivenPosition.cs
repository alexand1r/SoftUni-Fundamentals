using System;

namespace _14.ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            long n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            long mask = 1l << p;
            long result = 0;

            if (v == 0)
            {
                mask = ~mask;
                result = n & mask;
            }
            else
            {
                result = n | mask;
            }

            Console.WriteLine(result);
        }
    }
}
