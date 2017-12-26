using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesIntersection
{
    class CirclesIntersection
    {
        class Circle
        {
            public int X { get; set; }
            public int Y { get; set; }
            public int R { get; set; }
        }

        static void Main(string[] args)
        {
            Circle c1 = ReadCircle();
            Circle c2 = ReadCircle();
            Console.WriteLine(Intersect(c1, c2) ? "Yes" : "No");
        }

        private static bool Intersect(Circle c1, Circle c2)
        {
            var sumOfCircleR = c1.R + c2.R;
            var deltaX = c2.X - c1.X;
            var deltaY = c2.Y - c1.Y;
            var distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            if (distance <= sumOfCircleR) return true;
            else return false;
        }

        private static Circle ReadCircle()
        {
            var input = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToList();

            Circle c = new Circle()
            {
                X = input[0],
                Y = input[1],
                R = input[2]
            };

            return c;
        }
    }
}
