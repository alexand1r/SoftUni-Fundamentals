using System;

namespace Problem_8.p_th_Bit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int bitAtPosition1;

            n >>= p;
            bitAtPosition1 = n & 1;
            Console.WriteLine(bitAtPosition1);
        }
    }
}
