using System;

namespace Plane
{
    class Plane
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int outterDots = width / 2;
            int innerDots = 1;

            Console.WriteLine("{0}*{0}"
                , new string('.', outterDots));
            for (int i = 0; i < n / 2 + 2; i++)
            {
                outterDots--;
                Console.WriteLine("{0}*{1}*{0}"
                    , new string('.', outterDots)
                    , new string('.', innerDots));
                innerDots += 2;
            }
            innerDots += 2;
            outterDots -= 2;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}"
                    , new string('.', outterDots)
                    , new string('.', innerDots));
                innerDots += 4;
                outterDots -= 2;
            }
            innerDots = n;
            outterDots = n - 2;
            Console.WriteLine("*{0}*{1}*{0}*"
                , new string('.', outterDots)
                , new string('.', innerDots));
            int middleDots = 1;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                outterDots -= 2;
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*"
                    , new string('.', outterDots)
                    , new string('.', middleDots)
                    , new string('.', innerDots));
                middleDots += 2;
            }
            middleDots++;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}"
                    , new string('.', middleDots)
                    , new string('.', innerDots));
                middleDots -= 1;
                innerDots += 2;
            }
            Console.WriteLine("{0}", new string('*', width));
        }
    }
}
