using System;

namespace Problem_7.First_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bitAtPosition1;
            n >>= 1;
            bitAtPosition1 = n & 1;
            Console.WriteLine(bitAtPosition1);
        }
    }
}
