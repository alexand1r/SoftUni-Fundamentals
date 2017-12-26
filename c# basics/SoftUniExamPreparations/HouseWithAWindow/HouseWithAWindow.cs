using System;

namespace HouseWithAWindow
{
    class HouseWithAWindow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = 2 * n - 1;
            int outterDots = n - 2;
            int innerDots = 1;
            string line0 = new string('.', n - 1) + "*" + new string('.', n - 1);
            Console.WriteLine(line0);
            string line1 = new string('*', size);
            string line2 = "*" + new string('.', size - 2) + "*";
            string line3 = "*" + new string('.', n / 2) 
                + new string('*', n - 3) 
                + new string('.', n / 2) + "*";     
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(new string('.', outterDots) 
                    + "*" + new string('.', innerDots) 
                    + "*" + new string('.', outterDots));
                innerDots += 2;
                outterDots--;
            }
            Console.WriteLine(line1);
            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine(line2);
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(line3);
            }
            for (int i = 0; i < n / 4; i++)
            {
                Console.WriteLine(line2);
            }
            Console.WriteLine(line1);
        }
    }
}
