using System;

namespace _4.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double perimeter = 2 * width + 2 * height;
            double area = width * height;
            Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
        }
    }
}
