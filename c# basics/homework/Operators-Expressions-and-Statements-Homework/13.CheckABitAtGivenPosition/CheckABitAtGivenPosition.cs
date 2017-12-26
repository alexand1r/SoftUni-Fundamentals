using System;

namespace _13.CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            n >>= p;
            uint bitp = n & 1;

            Console.WriteLine("bit @ p == 1: {0}", bitp == 1 ? true :false);
        }
    }
}
