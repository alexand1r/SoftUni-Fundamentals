using System;

namespace _3.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            double r = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * r * r;
            double perimeter = 2 * Math.PI * r;
            Console.WriteLine("radius: {0} \n-> perimeter: {1:F2} \n-> area: {2:F2}"
                , r, perimeter, area);
        }
    }
}
