using System;

namespace _7.PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Inside? {0}", x * x + y * y <= 4 ? true :false);
        }
    }
}
