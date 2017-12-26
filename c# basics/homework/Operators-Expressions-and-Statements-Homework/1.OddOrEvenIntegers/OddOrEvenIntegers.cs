using System;

namespace _1.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Odd? {0}", n % 2 == 1 ? true:false);
        }
    }
}
