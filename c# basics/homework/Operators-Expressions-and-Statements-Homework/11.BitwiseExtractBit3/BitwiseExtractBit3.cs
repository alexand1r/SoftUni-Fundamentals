using System;

namespace _11.BitwiseExtractBit3
{
    class BitwiseExtractBit3
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());

            n >>= 3;
            uint bit3 = n & 1;

            Console.WriteLine("bit #3: {0}", bit3);
        }
    }
}
