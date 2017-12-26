using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dashes = n / 2;
            int asterisk = 1;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', dashes), new string('*', asterisk));
                dashes--;
                asterisk += 2;
            }
            asterisk -= 4;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("|{0}|", new string('*', asterisk));
            }
        }
    }
}
