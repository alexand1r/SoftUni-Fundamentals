using System;

namespace _6.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;

            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1 = {0} ; x2 = {1}", x1, x2);
            }
            else if(d == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
