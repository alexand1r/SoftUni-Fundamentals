using System;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            n >>= p;
            uint bitp = n & 1;

            Console.WriteLine("bit @ p: {0}", bitp);
        }
    }
}
