using System;

namespace _1.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine(a + " " + b);
            }
            else
            {
                int temp = b;
                b = a;
                a = temp;
                Console.WriteLine(a + " " + b);
            }
        }
    }
}
