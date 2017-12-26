using System;

namespace Tri_bit_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}",Convert.ToString(n,2).PadLeft(64, '0'));
            long mask = 7l << p;
            //TODO: Make the mask needed to invert 3 bits at position p
            Console.WriteLine(Convert.ToString(mask, 2).PadLeft(64, '0'));
            long result = n ^ mask;
            //TODO: Use the ^ (XOR) operation with the number and the mask to get the result
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(64, '0'));

            Console.WriteLine(result);

        }
    }
}
