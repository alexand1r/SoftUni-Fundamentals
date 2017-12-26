using System;

namespace _14.DecimalToBinaryNumber
{
    class DecimalToBinaryNumber
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            string num = Convert.ToString(n, 2);
            Console.WriteLine(num);
        }
    }
}
