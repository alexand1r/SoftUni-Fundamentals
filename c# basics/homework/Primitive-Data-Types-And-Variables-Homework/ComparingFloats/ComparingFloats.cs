using System;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavedete a: ");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Vavedete b: ");
            double b = Double.Parse(Console.ReadLine());

            float eps = 0.000001f;

            Console.WriteLine(Math.Abs(a - b) < eps ? true:false);
        }
    }
}
