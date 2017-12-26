using System;
using System.Numerics;

namespace _16.DecimalToHexadecimalNumber
{
    class DecimalToHexadecimalNumber
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string num = Convert.ToString(n, 16).ToUpper();
            Console.WriteLine(num);
        }
    }
}
