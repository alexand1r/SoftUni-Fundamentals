using System;
using System.Linq;

class Program
{
    static void Main()
    {
        //string pointA = Console.ReadLine();
        //string pointB = Console.ReadLine();
        //string pointC = Console.ReadLine();
        //string pointD = Console.ReadLine();

        //string[] tokens = pointA.Split(' ');
        //double xPointA = double.Parse(tokens[0]);
        //double yPointA = double.Parse(tokens[1]);

        //tokens = pointB.Split(' ');
        //double xPointB = double.Parse(tokens[0]);
        //double yPointB = double.Parse(tokens[1]);

        //tokens = pointC.Split(' ');
        //double xPointC = double.Parse(tokens[0]);
        //double yPointC = double.Parse(tokens[1]);

        //tokens = pointD.Split(' ');
        //double xPointD = double.Parse(tokens[0]);
        //double yPointD = double.Parse(tokens[1]);

        //double radius = double.Parse(Console.ReadLine());
        //double step = double.Parse(Console.ReadLine());

        //int validPoints = 0;
        //double mostFarAway = radius - (radius % step);

        //for (double x = -mostFarAway; x <= mostFarAway; x+=step)
        //{
        //    for (double y = -mostFarAway; y <= mostFarAway; y+=step)
        //    {
        //        double distance = Math.Sqrt((x * x) + (y * y));
        //        if ((x > xPointA) && (x < xPointC) && (y > yPointA) && (y < yPointC) && (distance <= radius))
        //        {
        //            validPoints++;
        //        }
        //    }
        //}

        //Console.WriteLine(validPoints);

        string[] pointA = Console.ReadLine().Split(' ').ToArray();
        string[] pointB = Console.ReadLine().Split(' ').ToArray();
        string[] pointC = Console.ReadLine().Split(' ').ToArray();
        string[] pointD = Console.ReadLine().Split(' ').ToArray();

        double radius = double.Parse(Console.ReadLine());
        double step = double.Parse(Console.ReadLine());

        double aX = double.Parse(pointA[0]);
        double aY = double.Parse(pointA[1]);
        double bX = double.Parse(pointB[0]);
        double bY = double.Parse(pointB[1]);
        double cX = double.Parse(pointC[0]);
        double cY = double.Parse(pointC[1]);
        double dX = double.Parse(pointD[0]);
        double dY = double.Parse(pointD[1]);

        int pointCounter = 0;

        //Check the right side
        for (double x = 0; x <= radius; x += step)
        {
            //Upper quadrant
            for (double y = 0; y <= radius; y += step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aX && x < bX) && (y < cY && y > bY))
                    {
                        pointCounter++;
                    }
                }
            }

            //Lower quadrant
            for (double y = -step; y >= -radius; y -= step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aX && x < bX) && (y < cY && y > bY))
                    {
                        pointCounter++;
                    }
                }
            }

        }

        //Check the left side
        for (double x = -step; x >= -radius; x -= step)
        {
            //Upper quadrant
            for (double y = 0; y <= radius; y += step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aX && x < bX) && (y < cY && y > bY))
                    {
                        pointCounter++;
                    }
                }
            }

            //Lower quadrant
            for (double y = -step; y >= -radius; y -= step)
            {
                if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(radius, 2))
                {
                    if ((x > aX && x < bX) && (y < cY && y > bY))
                    {
                        pointCounter++;
                    }
                }
            }
        }

        Console.WriteLine(pointCounter);
    }
}
