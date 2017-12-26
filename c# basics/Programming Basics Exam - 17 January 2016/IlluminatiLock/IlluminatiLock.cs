using System;

namespace IlluminatiLock
{
    class IlluminatiLock
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outterDots = n;
            int innerDots = 2;
            int dots = n - 2;
            Console.WriteLine("{0}{1}{0}"
                , new string('.', outterDots)
                , new string('#', n));
            outterDots -= 2;
            Console.WriteLine("{0}{1}{0}{1}{0}"
                , new string('.', outterDots)
                , new string('#', 3));
            outterDots -= 2;
            for (int i = 0; i < (n + 1 - 6) / 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}"
                    , new string('.', outterDots), new string('.', innerDots), new string('.', dots));
                outterDots -= 2;
                innerDots += 2;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}"
                    , new string('.', outterDots), new string('.', innerDots), new string('.', dots));
            }
            for (int i = 0; i < (n + 1 - 6) / 2; i++)
            {
                outterDots += 2;
                innerDots -= 2;
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}"
                    , new string('.', outterDots), new string('.', innerDots), new string('.', dots));
            }
            outterDots += 2;
            Console.WriteLine("{0}{1}{0}{1}{0}"
                , new string('.', outterDots)
                , new string('#', 3));
            outterDots += 2;
            Console.WriteLine("{0}{1}{0}"
                , new string('.', outterDots)
                , new string('#', n));
        }
    }
}
