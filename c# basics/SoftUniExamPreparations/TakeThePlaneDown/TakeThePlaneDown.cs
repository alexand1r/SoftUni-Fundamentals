using System;

namespace TakeThePlaneDown
{
    class TakeThePlaneDown
    {
        static void Main(string[] args)
        {
            int hqX = int.Parse(Console.ReadLine());
            int hqY = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int fighterX = int.Parse(Console.ReadLine());
                int fighterY = int.Parse(Console.ReadLine());
                int calcX = fighterX - hqX;
                int calcY = fighterY - hqY;
                int dist = calcY * calcY + calcX * calcX;
                if (radius * radius  >= dist)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", fighterX, fighterY);
                }
            }
        }
    }
}
