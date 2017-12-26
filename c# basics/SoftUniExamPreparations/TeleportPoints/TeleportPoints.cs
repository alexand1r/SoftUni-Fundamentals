//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _04.TeleportPoints
//{
//    class TeleportPoints
//    {
//        static void Main(string[] args)
//        {
//            string[] pointA = Console.ReadLine().Split(' ').ToArray();
//            string[] pointB = Console.ReadLine().Split(' ').ToArray();
//            string[] pointC = Console.ReadLine().Split(' ').ToArray();
//            string[] pointD = Console.ReadLine().Split(' ').ToArray();

//            double radius = double.Parse(Console.ReadLine());
//            double step = double.Parse(Console.ReadLine());

//            double aX = double.Parse(pointA[0]);
//            double aY = double.Parse(pointA[1]);
//            double bX = double.Parse(pointB[0]);
//            double bY = double.Parse(pointB[1]);
//            double cX = double.Parse(pointC[0]);
//            double cY = double.Parse(pointC[1]);
//            double dX = double.Parse(pointD[0]);
//            double dY = double.Parse(pointD[1]);

//            int pointCounter = 0;

//            //Check the right side
//            for (double x = 0; x <= radius; x += step)
//            {
//                //Upper quadrant
//                for (double y = 0; y <= radius; y += step)
//                {
//                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
//                    {
//                        if ((x > aX && x < bX) && (y < cY && y > bY))
//                        {
//                            pointCounter++;
//                        }
//                    }
//                }

//                //Lower quadrant
//                for (double y = -step; y >= -radius; y -= step)
//                {
//                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
//                    {
//                        if ((x > aX && x < bX) && (y < cY && y > bY))
//                        {
//                            pointCounter++;
//                        }
//                    }
//                }

//            }

//            //Check the left side
//            for (double x = -step; x >= -radius; x -= step)
//            {
//                //Upper quadrant
//                for (double y = 0; y <= radius; y += step)
//                {
//                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
//                    {
//                        if ((x > aX && x < bX) && (y < cY && y > bY))
//                        {
//                            pointCounter++;
//                        }
//                    }
//                }

//                //Lower quadrant
//                for (double y = -step; y >= -radius; y -= step)
//                {
//                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
//                    {
//                        if ((x > aX && x < bX) && (y < cY && y > bY))
//                        {
//                            pointCounter++;
//                        }
//                    }
//                }
//            }

//            Console.WriteLine(pointCounter);
//        }
//    }
//}
using System;

namespace TeleportPoints
{
    class TeleportPoints
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] coords = line.Split(' ');
            double aX = double.Parse(coords[0]);
            double aY = double.Parse(coords[1]);
            line = Console.ReadLine();
            coords = line.Split(' ');
            double bX = double.Parse(coords[0]);
            double bY = double.Parse(coords[1]);
            line = Console.ReadLine();
            coords = line.Split(' ');
            double cX = double.Parse(coords[0]);
            double cY = double.Parse(coords[1]);
            line = Console.ReadLine();
            coords = line.Split(' ');
            double dX = double.Parse(coords[0]);
            double dY = double.Parse(coords[1]);
            double r = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            int pointCount = 1;
            double r2 = r * r;
            if (aX * cX >= 0 || aY * cY >= 0)
            {
                Console.WriteLine(0);
                return;
            }
            for (double x = h; x < cX && x <= r; x += h)
            {
                for (double y = 0; y < cY && x * x + y * y <= r2; y += h)
                {
                    pointCount++;
                }
            }
            for (double x = 0; x > dX && x >= -r; x -= h)
            {
                for (double y = h; y < dY && x * x + y * y <= r2; y += h)
                {
                    pointCount++;
                }
            }
            for (double x = -h; x > aX && x >= -r; x -= h)
            {
                for (double y = 0; y > aY && x * x + y * y <= r2; y -= h)
                {
                    pointCount++;
                }
            }
            for (double x = 0; x < bX && x >= -r; x += h)
            {
                for (double y = -h; y > bY && x * x + y * y <= r2; y -= h)
                {
                    pointCount++;
                }
            }
           
            Console.WriteLine(pointCount);
        }
    }
}
