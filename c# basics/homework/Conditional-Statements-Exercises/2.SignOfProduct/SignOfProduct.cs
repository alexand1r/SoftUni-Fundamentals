using System;

namespace _2.SignOfProduct
{
    class SignOfProduct
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double product = a * b * c;
            int count = 0;

            if (a < 0)
            {
                count++;
            }
            if (b < 0)
            {
                count++;
            }
            if (c < 0)
            {
                count++;
            }
            if (count == 0 || count == 2)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

        }
    }
}
