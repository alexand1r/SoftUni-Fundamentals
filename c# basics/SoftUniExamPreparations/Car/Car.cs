using System;
namespace Car
{
    class Car
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int innerDots = n;
            int outterDots = n - 1;
            string line1 = new string('.', n) + new string('*', n) + new string('.', n);
            Console.WriteLine(line1);
            for (int i = 0; i < n / 2 - 1; i++)
            {
                string line2 = new string('.', outterDots) + "*" + new string('.', innerDots) + "*" + new string('.', outterDots);
                Console.WriteLine(line2);
                outterDots--;
                innerDots += 2;
            }
            string line3 = new string('*', n / 2 + 1) + new string('.', innerDots) + new string('*', n / 2 + 1);
            Console.WriteLine(line3);
            for (int i = 0; i < n / 2 - 2; i++)
            {
                string line4 = "*" + new string('.', width - 2) + "*";
                Console.WriteLine(line4);
            }
            string line5 = new string('*', width);
            Console.WriteLine(line5);
            for (int i = 0; i < n / 2 - 2; i++)
            {
                string line6 = new string('.', n / 2) + "*" + new string('.', n / 2 - 1) + "*" + new string('.', n - 2) + "*" + new string('.', n / 2 - 1) + "*" + new string('.', n / 2);
                Console.WriteLine(line6);
            }
            string line7 = new string('.', n / 2) + new string('*', n / 2 + 1) + new string('.', n - 2) + new string('*', n / 2 + 1) + new string('.', n / 2);
            Console.WriteLine(line7);
        }
    }
}
