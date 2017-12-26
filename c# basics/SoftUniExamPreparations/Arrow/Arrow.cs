using System;

namespace Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int dots = n / 2;
            int innerDots = n - 2;

            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', n));
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dots), new string('.', innerDots));
            }
            Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', innerDots));
            dots = 1;
            innerDots = width - 4;
            for (int i = 0; i < n - 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('.', dots), new string('.', innerDots));
                dots++;
                innerDots -= 2;
            }
            Console.WriteLine("{0}#{0}", new string('.', dots));
        }
    }
}
