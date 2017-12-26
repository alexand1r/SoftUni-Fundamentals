using System;

namespace Problem_9.Bit_Destroyer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int mask;

            mask = 1 << p;
            mask = ~mask;
            int newNumber = n & mask;
            Console.WriteLine(newNumber);
        }
    }
}
