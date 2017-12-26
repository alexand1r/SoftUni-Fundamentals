using System;

namespace SandGlass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dots = 0;
            int asterisk = n;

            for (int i = 0; i < n / 2 + 1; i++)
            {
                Console.WriteLine(new string('.', dots) 
                    + new string('*', asterisk) 
                    + new string('.', dots));
                dots++;
                asterisk -= 2;
            }

            dots -= 2;
            asterisk += 4;

            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', dots)
                    + new string('*', asterisk)
                    + new string('.', dots));
                dots--;
                asterisk += 2;
            }
        }
    }
}
