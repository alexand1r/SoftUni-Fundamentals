using System;

namespace _1.SumOf3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double sum = a + b + c;

            Console.WriteLine("The sum of the 3 numbers is {0}.", sum);
        }
    }
}
