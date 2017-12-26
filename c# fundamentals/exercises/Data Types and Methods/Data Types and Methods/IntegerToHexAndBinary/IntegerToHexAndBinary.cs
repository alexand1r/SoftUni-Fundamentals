using System;

namespace IntegerToHexAndBinary
{
    class IntegerToHexAndBinary
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 2);
            string hex = Convert.ToString(n, 16);

            Console.WriteLine(hex.ToUpper());
            Console.WriteLine(binary);
        }
    }
}
