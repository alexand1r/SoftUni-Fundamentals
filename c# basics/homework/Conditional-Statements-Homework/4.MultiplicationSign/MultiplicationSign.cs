using System;

namespace _4.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double product = a * b * c;
            int count = 0;

            if (a < 0) { count++; };
            if (b < 0) { count++; };
            if (c < 0) { count++; };
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("0");
            }
            else if (count == 0 || count == 2)
            {
                Console.WriteLine("+");
            }
            else if (count == 1 || count == 3)
            {
                Console.WriteLine("-");
            }
        }
    }
}
