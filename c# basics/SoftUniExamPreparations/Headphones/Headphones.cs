using System;

namespace Headphones
{
    class Headphones
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string firstLine = new string('-', n / 2) 
                + new string('*', n + 2) 
                + new string('-', n / 2);
            Console.WriteLine(firstLine);

            for (int i = 0; i < n - 1; i++)
            {
                string line = new string('-', n / 2) + "*" 
                    + new string('-', n) + "*" 
                    + new string('-', n / 2);
                Console.WriteLine(line);
            }

            int outerDashes = n / 2 + 1;
            int innerDashes = n + 2;
            int star = -1;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                outerDashes--;
                innerDashes -= 2;
                star += 2;
                string line = new string('-', outerDashes) + new string('*', star) 
                    + new string('-', innerDashes) + new string('*', star) 
                    + new string('-', outerDashes);
                Console.WriteLine(line);
            }

            for (int i = 0; i < n / 2; i++)
            {
                outerDashes++;
                innerDashes += 2;
                star -= 2;
                string line = new string('-', outerDashes) + new string('*', star)
                    + new string('-', innerDashes) + new string('*', star)
                    + new string('-', outerDashes);
                Console.WriteLine(line);
            }
        }
    }
}
