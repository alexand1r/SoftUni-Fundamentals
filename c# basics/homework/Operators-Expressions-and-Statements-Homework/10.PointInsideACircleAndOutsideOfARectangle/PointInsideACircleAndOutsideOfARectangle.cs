using System;

namespace _10.PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Inside K and Outside Of R: {0}", 
                ((x-1)*(x-1) + (y-1)*(y-1) <= 1.5*1.5) && (y>1) ? "yes":"no");
        }
    }
}
