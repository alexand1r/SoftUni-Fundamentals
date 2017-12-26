using System;

namespace Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int innerDots = 1;
            int outterDots = n;
            Console.WriteLine("{0}*{0}", new string('.', outterDots));
            for (int i = 0; i < n / 2 - 1; i++)
            {
                outterDots--;
                Console.WriteLine("{0}*{1}*{0}", new string('.', outterDots), new string('.', innerDots));
                innerDots += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', innerDots));
            outterDots = 1;
            innerDots = width - 4;
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', outterDots), new string('.', innerDots));
                outterDots++;
                innerDots -= 2;
            }
            innerDots = n / 2 - 1;
            int middleDots = 1;
            Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', outterDots), new string('.', innerDots));
            for (int i = 0; i < n / 2 - 1; i++)
            {
                outterDots--;
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}", new string('.', outterDots), new string('.', innerDots), new string('.', middleDots));
                middleDots += 2;
            }
            Console.WriteLine("{0}{1}{0}", new string('*', n / 2 + 1), new string('.', middleDots));
        }
    }
}
