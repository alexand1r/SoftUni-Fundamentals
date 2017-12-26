using System;

namespace Problem_5.Big_and_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n = uint.Parse(Console.ReadLine());
            bool result = true;
            //if (n > 20 && n % 2 == 1)
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine(!result);
            //}
            Console.WriteLine((n > 20) && (n % 2 == 1) ? true : false);
        }
    }
}
