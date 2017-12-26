using System;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = n;
            int sign = 1;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                string line = new string('\'', dots) + new string('^', sign) + new string('\'', dots);
                Console.WriteLine(line);
                dots--;
                sign += 2;
            }

            dots = n - 1;
            sign = 3;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                string line = new string('\'', dots) + new string('^', sign) + new string('\'', dots);
                Console.WriteLine(line);
                dots--;
                sign += 2;
            }

            for (int i = 0; i < n / 2 + 1; i++)
            {
                string line = new string('\'', n - 1) + "| |" + new string('\'', n - 1);
                Console.WriteLine(line);
            }

            Console.WriteLine(new string('-', n * 2 + 1));
        }
    }
}
