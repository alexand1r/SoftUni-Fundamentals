using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestPoints
{
    class ClosestPoints
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();
            var closestPoints = FindClosestTwoPoints(points);
            Console.WriteLine("{0:f3}", CalcDistance(
               closestPoints[0], closestPoints[1]));
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);

        }

        private static Point[] FindClosestTwoPoints(Point[] points)
        {
            double min = double.MaxValue;
            double current = 0;
            Point[] closestPoints = new Point[2];
            for (int i = 0; i < points.Length - 1; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    current = CalcDistance(points[i], points[j]);
                    if (min > current)
                    {
                        min = current;
                        closestPoints[0] = new Point() { X = points[i].X, Y = points[i].Y };
                        closestPoints[1] = new Point() { X = points[j].X, Y = points[j].Y };
                    }
                }
            }
            return closestPoints;
        }

        private static Point ReadPoint()
        {
            var input = Console.ReadLine()
                .Split(' ').Select(int.Parse).ToArray();
            Point p = new Point() { X = input[0], Y = input[1] };
            return p;
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            var points = new Point[n];
            for (int i = 0; i < n; i++)
                points[i] = ReadPoint();
            return points;
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
