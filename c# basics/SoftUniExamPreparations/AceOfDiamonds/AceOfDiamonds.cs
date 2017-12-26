using System;
using System.Text;

namespace AceOfDiamonds
{
    class AceOfDiamonds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            int dashes = n / 2 - 1;
            int sign = 1;
            for (int i = 0; i < n / 2; i++)
            {
                string line = "*" + new string('-',dashes)
                    + new string('@', sign)
                    + new string('-', dashes) + "*";
                Console.WriteLine(line);
                dashes--;
                sign += 2;
            }
            for (int i = 0; i < n / 2 - 1; i++)
            {
                string line = "*" + new string('-', dashes + 2)
                    + new string('@', sign - 4)
                    + new string('-', dashes + 2) + "*";
                Console.WriteLine(line);
                dashes++;
                sign -= 2;
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
