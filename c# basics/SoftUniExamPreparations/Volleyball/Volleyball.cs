using System;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int normal = 48 - h;
            double total = normal * 3d / 4d + p * 2d / 3d + h;
            if (year == "leap")
            {
                total = 1.15 * total;
            }

            Console.WriteLine((int)total);
        }
    }
}
