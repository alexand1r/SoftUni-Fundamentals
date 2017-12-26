using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint(); // TODO: implement ReadPoint()
            Point p2 = ReadPoint();
            var dist = CalcDistance(p1, p2);
            Console.WriteLine("{0:f3}", dist);
        }

        private static Point ReadPoint()
        {
            var input = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = input[0], Y = input[1] };
            return p;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var deltaX = p2.X - p1.X;
            var deltaY = p2.Y - p1.Y;
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
